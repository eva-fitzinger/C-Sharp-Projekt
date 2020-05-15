namespace VirusSweeper
{
    partial class VirusSweeperForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VirusSweeperForm));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.difficultyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.easyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.intermediateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gamePanel = new VirusSweeper.VirusSweeperForm.TileGrid();
            this.realGrid = new VirusSweeper.VirusSweeperForm.TileGrid();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timerLabel = new System.Windows.Forms.Label();
            this.maskCounterLabel = new System.Windows.Forms.Label();
            this.maskCounterImage = new System.Windows.Forms.PictureBox();
            this.pauseGame = new System.Windows.Forms.PictureBox();
            this.resumeGame = new System.Windows.Forms.PictureBox();
            this.gridSize = new System.Windows.Forms.Label();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maskCounterImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pauseGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resumeGame)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(800, 24);
            this.menu.TabIndex = 1;
            this.menu.Text = "menu";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.difficultyToolStripMenuItem,
            this.exitGameToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.StartnewGameToolStripMenuItem_Click);
            // 
            // difficultyToolStripMenuItem
            // 
            this.difficultyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.easyToolStripMenuItem,
            this.intermediateToolStripMenuItem,
            this.hardToolStripMenuItem,
            this.customToolStripMenuItem});
            this.difficultyToolStripMenuItem.Name = "difficultyToolStripMenuItem";
            this.difficultyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.difficultyToolStripMenuItem.Text = "Difficulty";
            // 
            // easyToolStripMenuItem
            // 
            this.easyToolStripMenuItem.Name = "easyToolStripMenuItem";
            this.easyToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.easyToolStripMenuItem.Text = "Easy";
            this.easyToolStripMenuItem.Click += new System.EventHandler(this.StartEasyGameToolStripMenuItem_Click);
            // 
            // intermediateToolStripMenuItem
            // 
            this.intermediateToolStripMenuItem.Name = "intermediateToolStripMenuItem";
            this.intermediateToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.intermediateToolStripMenuItem.Text = "Intermediate";
            this.intermediateToolStripMenuItem.Click += new System.EventHandler(this.StartIntermediateGameToolStripMenuItem_Click);
            // 
            // hardToolStripMenuItem
            // 
            this.hardToolStripMenuItem.Name = "hardToolStripMenuItem";
            this.hardToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.hardToolStripMenuItem.Text = "Hard";
            this.hardToolStripMenuItem.Click += new System.EventHandler(this.StartHardGameToolStripMenuItem_Click);
            // 
            // customToolStripMenuItem
            // 
            this.customToolStripMenuItem.Name = "customToolStripMenuItem";
            this.customToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.customToolStripMenuItem.Text = "Custom";
            this.customToolStripMenuItem.Click += new System.EventHandler(this.StartCustomGameToolStripMenuItem_Click);
            // 
            // exitGameToolStripMenuItem
            // 
            this.exitGameToolStripMenuItem.Name = "exitGameToolStripMenuItem";
            this.exitGameToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitGameToolStripMenuItem.Text = "Exit Game";
            this.exitGameToolStripMenuItem.Click += new System.EventHandler(this.ExitGameToolStripMenuItem_Click);
            // 
            // gamePanel
            // 
            this.gamePanel.Location = new System.Drawing.Point(13, 68);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(775, 370);
            this.gamePanel.TabIndex = 2;
            // 
            // realGrid
            // 
            this.realGrid.Location = new System.Drawing.Point(13, 68);
            this.realGrid.Name = "realGrid";
            this.realGrid.Size = new System.Drawing.Size(775, 370);
            this.realGrid.TabIndex = 2;
            this.realGrid.Visible = false;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.EnableTimer_Tick);
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.timerLabel.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold);
            this.timerLabel.Location = new System.Drawing.Point(711, 27);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(63, 34);
            this.timerLabel.TabIndex = 4;
            this.timerLabel.Text = "000";
            // 
            // maskCounterLabel
            // 
            this.maskCounterLabel.AutoSize = true;
            this.maskCounterLabel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.maskCounterLabel.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold);
            this.maskCounterLabel.Location = new System.Drawing.Point(54, 27);
            this.maskCounterLabel.Name = "maskCounterLabel";
            this.maskCounterLabel.Size = new System.Drawing.Size(47, 34);
            this.maskCounterLabel.TabIndex = 6;
            this.maskCounterLabel.Text = "00";
            // 
            // maskCounterImage
            // 
            this.maskCounterImage.BackgroundImage = global::VirusSweeper.Properties.Resources.Mask;
            this.maskCounterImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.maskCounterImage.Location = new System.Drawing.Point(13, 26);
            this.maskCounterImage.Name = "maskCounterImage";
            this.maskCounterImage.Size = new System.Drawing.Size(35, 35);
            this.maskCounterImage.TabIndex = 5;
            this.maskCounterImage.TabStop = false;
            // 
            // pauseGame
            // 
            this.pauseGame.BackgroundImage = global::VirusSweeper.Properties.Resources.PauseButton;
            this.pauseGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pauseGame.ErrorImage = null;
            this.pauseGame.InitialImage = null;
            this.pauseGame.Location = new System.Drawing.Point(670, 27);
            this.pauseGame.Name = "pauseGame";
            this.pauseGame.Size = new System.Drawing.Size(35, 35);
            this.pauseGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pauseGame.TabIndex = 0;
            this.pauseGame.TabStop = false;
            this.pauseGame.Click += new System.EventHandler(this.PauseGame_Click);
            // 
            // resumeGame
            // 
            this.resumeGame.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("resumeGame.BackgroundImage")));
            this.resumeGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.resumeGame.Location = new System.Drawing.Point(629, 27);
            this.resumeGame.Name = "resumeGame";
            this.resumeGame.Size = new System.Drawing.Size(35, 35);
            this.resumeGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.resumeGame.TabIndex = 0;
            this.resumeGame.TabStop = false;
            this.resumeGame.Click += new System.EventHandler(this.ResumeGame_Click);
            // 
            // gridSize
            // 
            this.gridSize.AutoSize = true;
            this.gridSize.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.gridSize.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold);
            this.gridSize.Location = new System.Drawing.Point(170, 26);
            this.gridSize.Name = "gridSize";
            this.gridSize.Size = new System.Drawing.Size(47, 34);
            this.gridSize.TabIndex = 7;
            this.gridSize.Text = "00";
            // 
            // VirusSweeperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridSize);
            this.Controls.Add(this.maskCounterLabel);
            this.Controls.Add(this.maskCounterImage);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.gamePanel);
            this.Controls.Add(this.pauseGame);
            this.Controls.Add(this.resumeGame);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "VirusSweeperForm";
            this.Text = "VirusSweeper";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maskCounterImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pauseGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resumeGame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox resumeGame;
        private System.Windows.Forms.PictureBox pauseGame;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem difficultyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem easyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem intermediateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customToolStripMenuItem;
        private TileGrid gamePanel;
        private TileGrid realGrid;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.PictureBox maskCounterImage;
        public System.Windows.Forms.Label maskCounterLabel;
        private System.Windows.Forms.Label gridSize;
    }
}

