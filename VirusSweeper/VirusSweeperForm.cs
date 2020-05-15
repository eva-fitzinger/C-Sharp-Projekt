using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Schema;
using VirusSweeper.Properties;

namespace VirusSweeper
{
    public partial class VirusSweeperForm : Form
    {
        private Difficulty difficulty = Difficulty.Intermediate;
        private int timerTicks = 0;
        
        private int customGridWidth = 0;
        private int customViruses = 0;        

        public VirusSweeperForm()
        {
            InitializeComponent();
            this.Start();
            this.gamePanel.AddNewMask += this.NewMaskAdded;
        }

        private enum Difficulty {Easy, Intermediate, Hard, Custom} 

        private void Start()
        {

            int gridWidth = this.difficulty switch
            {
                Difficulty.Easy => 10,
                Difficulty.Intermediate => 18,
                Difficulty.Hard => 24,
                Difficulty.Custom => customGridWidth,
                _ => 18
            };

            int numberOfViruses = this.difficulty switch
            {
                Difficulty.Easy => 10,
                Difficulty.Intermediate => 40,
                Difficulty.Hard => 99,
                Difficulty.Custom => customViruses,
                _ => 40
            };

            //load the TileGrid
            this.gamePanel.LoadGrid(gridWidth, numberOfViruses, false);
            this.realGrid.LoadGrid(gridWidth, numberOfViruses, true);


            //start timer at 0
            timerTicks = 0;
            timer.Interval = 999;
            timer.Start();

            

            //print Grid Size
            gridSize.Text = "Grid Size: " + gridWidth.ToString() + " x " + gridWidth.ToString();
        }
        internal class TileGrid : Panel
        {
            private int masksLeft = 0;
            private int numberOfViruses = 0;
            private bool firstClick = true;
            private List<Tile> alreadyOpened = new List<Tile>();
            private Tile[][] TileGrid_real = null;

            internal event EventHandler<NewMaskAddedEventArgs> AddNewMask = delegate { };

            private void HandleTile_Click(object sender, MouseEventArgs e)
            {
                if (firstClick)
                {
                    SpreadVirus(TileGrid_real, sender);
                    firstClick = false;

                }
                Tile tile = (Tile)sender;
                if (!tile.Opened)
                {
                    //Open Tiles
                    if (e.Button == MouseButtons.Left && !tile.Masked)
                    {
                        if (tile.Image != null)
                        {
                            if (tile.Contaminated)
                            {
                                HandleLost();
                            }
                            else
                            {
                                OpenTiles(tile);
                                alreadyOpened.Clear();
                            }
                        }
                    }
                    //Mask Tiles
                    if (e.Button == MouseButtons.Right && masksLeft > 0 && tile.Image != null)
                    {
                        if (tile.Masked)
                        {
                            tile.Image = Resources.Tile;
                            tile.Masked = false;
                            masksLeft++;
                        }
                        else
                        {
                            tile.Image = Resources.MaskTile;
                            tile.Masked = true;
                            masksLeft--;
                        }                                             
                    }
                    AddNewMask(this, new NewMaskAddedEventArgs(masksLeft));
                }
            }

            private void OpenTiles(Tile tile)
            {
                tile.Image = null;
                tile.Opened = true;
                if (alreadyOpened.Contains(tile))
                {
                    return;
                }
                alreadyOpened.Add(tile);

                foreach(Tile t in tile.AdjacentTiles)
                {
                    if (!t.Contaminated)
                    {
                        if (t.NumberOfAdjacent == 0) OpenTiles(t);
                        t.Image = null;
                    }
                }
   
            }

            internal void HandleLost()
            {
                foreach (Tile tile in this.Controls)
                {
                    tile.MouseDown -= HandleTile_Click;
                    tile.Image = null;

                }
            }


            internal void LoadGrid (int gridWidth, int numberOfViruses, bool real)
            {
                this.firstClick = true;
                this.Controls.Clear();
                this.numberOfViruses =  numberOfViruses;
                this.Size = new Size(gridWidth * Tile.TILE_LENGTH, gridWidth * Tile.TILE_LENGTH);

                //start MaskCounter
                masksLeft = numberOfViruses;
                

                //create the Tile Grid
                TileGrid_real = new Tile[gridWidth][];
                for (int x = 0; x < gridWidth; x++)
                {
                    TileGrid_real[x] = new Tile[gridWidth];
                    for (int y = 0; y < gridWidth; y++)
                    {
                        Tile tile = new Tile(x, y);
                        this.Controls.Add(tile);
                        tile.MouseDown += HandleTile_Click;
                        TileGrid_real[x][y] = tile;                      
                    }
                }

                foreach(Tile t in Controls)
                {
                    SetAdjacentTiles(t);
                }
            }

            private void SetAdjacentTiles(Tile tile)
            {
                if (tile.X > 0) tile.AdjacentTiles.Add(TileGrid_real[tile.X - 1][tile.Y]);
                if (tile.X > 0 && tile.Y > 0) tile.AdjacentTiles.Add(TileGrid_real[tile.X - 1][tile.Y - 1]);
                if (tile.Y > 0) tile.AdjacentTiles.Add(TileGrid_real[tile.X][tile.Y - 1]);
                if (tile.X < TileGrid_real.Length - 1 && tile.Y > 0) tile.AdjacentTiles.Add(TileGrid_real[tile.X + 1][tile.Y - 1]);
                if (tile.X < TileGrid_real.Length - 1) tile.AdjacentTiles.Add(TileGrid_real[tile.X + 1][tile.Y]);
                if (tile.X < TileGrid_real.Length - 1 && tile.Y < TileGrid_real.Length - 1) tile.AdjacentTiles.Add(TileGrid_real[tile.X + 1][tile.Y + 1]);
                if (tile.Y < TileGrid_real.Length - 1) tile.AdjacentTiles.Add(TileGrid_real[tile.X][tile.Y + 1]);
                if (tile.X > 0 && tile.Y < TileGrid_real.Length - 1) tile.AdjacentTiles.Add(TileGrid_real[tile.X - 1][tile.Y + 1]);
            }


            //load the infected tiles adjacent to the tile at x,y
            private int InfSurrounding(Tile[][] grid, int x, int y)
            {
                int adjacent = 0;
                if (x > 0 && grid[x - 1][y].Contaminated) adjacent ++;
                if (x > 0 && y > 0 && grid[x - 1][y - 1].Contaminated) adjacent++;
                if (y > 0 && grid[x][y - 1].Contaminated) adjacent++;
                if (x < grid.Length-1 && y > 0 && grid[x + 1][y - 1].Contaminated) adjacent++;
                if (x < grid.Length-1 && grid[x + 1][y].Contaminated) adjacent++;
                if (x < grid.Length-1 && y < grid.Length-1 && grid[x + 1][y + 1].Contaminated) adjacent++;
                if (y < grid.Length-1 && grid[x][y + 1].Contaminated) adjacent++;
                if (x > 0 && y < grid.Length-1 && grid[x - 1][y + 1].Contaminated) adjacent++;
                return adjacent;
            }

            private void SpreadVirus(Tile [][] grid,  object sender)
            {
                Random random = new Random();
                Tile first = (Tile)sender;
                Tile tile;

                //infect random tiles
                for(int i = 0; i < numberOfViruses; i++)
                {
                    int x = random.Next(grid.Length);
                    int y = random.Next(grid.Length);
                    
                    tile = grid[random.Next(grid.Length)][random.Next(grid.Length)];
                    if (!tile.Contaminated && tile != first)
                    {                      
                        tile.Contaminated = true;
                        tile.BackgroundImage = Resources.VirusTile;
                    } 
                    else
                    {
                        i--;
                    }
                }

                //start loading number of infected adjacent tiles
                for (int x = 0; x < grid.Length; x++)
                {
                    for (int y = 0; y < grid.Length; y++)
                    {
                        if (!TileGrid_real[x][y].Contaminated)
                        {
                            TileGrid_real[x][y].NumberOfAdjacent = InfSurrounding(TileGrid_real, x, y);
                            TileGrid_real[x][y].BackgroundImage = TileGrid_real[x][y].NumberOfAdjacent switch
                            {
                                0 => Resources.EmptyTile,
                                1 => Resources.NumberTile_1,
                                2 => Resources.NumberTile_2,
                                3 => Resources.NumberTile_3,
                                4 => Resources.NumberTile_4,
                                5 => Resources.NumberTile_5,
                                6 => Resources.NumberTile_6,
                                7 => Resources.NumberTile_7,
                                8 => Resources.NumberTile_8,
                                _ => throw new InvalidOperationException("This Tile has too many infected tiles around it")

                            };
                        }

                    }
                }
            }

            internal class NewMaskAddedEventArgs : EventArgs
            {
                internal int Mask { get; }

                internal NewMaskAddedEventArgs(int mask)
                {
                    this.Mask = mask;
                }
            }
        }

        private class Tile : PictureBox
        {
            public int X { get; set; }
            public int Y { get; set; }

            internal const int TILE_LENGTH = 25;
            internal Point GridPosition { get; }
            internal int NumberOfAdjacent { get; set; }
            internal bool Contaminated { get; set; }          
            internal bool Opened { get; set; }
            internal bool Masked { get; set; }
            internal bool Visible_realTile { get; set; }
            internal List<Tile> AdjacentTiles { get; set; }
            internal Tile(int x, int y)
            {
                this.X = x;
                this.Y = y;
                this.Name = $"Tile_{x}_{y}"; 
                this.Location = new Point(x * TILE_LENGTH, y * TILE_LENGTH);
                this.GridPosition = new Point(x, y);
                this.Size = new Size(TILE_LENGTH, TILE_LENGTH);
                this.Image = Resources.Tile;
                this.SizeMode = PictureBoxSizeMode.Zoom;
                this.Contaminated = false;
                this.NumberOfAdjacent = 0;
                this.Opened = false;
                this.Masked = false;
                this.Visible_realTile = false;
                this.BackgroundImageLayout = ImageLayout.Stretch;
                this.AdjacentTiles = new List<Tile>();
            }


        }

        private void NewMaskAdded(object sender, TileGrid.NewMaskAddedEventArgs e)
        {
            this.maskCounterLabel.Text = e.Mask.ToString();
        }

        private void StartnewGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Start();
        }

        private void StartEasyGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.difficulty = Difficulty.Easy;
            this.Start();
        }

        private void StartIntermediateGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.difficulty = Difficulty.Intermediate;
            this.Start();
        }

        private void StartHardGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.difficulty = Difficulty.Hard;
            this.Start();
        }

        private void StartCustomGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer.Stop();
            CustomGameForm customGame = new CustomGameForm();
            customGame.ShowDialog();           
            customGridWidth = customGame.getWidth();
            customViruses = customGame.getViruses();
            this.difficulty = Difficulty.Custom;
            this.Start();
        }

        private void ExitGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PauseGame_Click(object sender, EventArgs e)
        {
            timer.Stop();           
        }

        private void ResumeGame_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void EnableTimer_Tick(object sender, EventArgs e)
        {
            timerTicks++;
            timerLabel.Text = timerTicks.ToString("d3");
        }

        public void ChangeMaskNumber(int numberOfMasks)
        {
            maskCounterLabel.Text = numberOfMasks.ToString("d2");
        }
    }
}
