using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirusSweeper
{
    public partial class CustomGameForm : Form
    {
        private int CustomWidth;
        private int CustomViruses;
        
        public CustomGameForm()
        {
            InitializeComponent();
        }

        private void createCustomGame_Click(object sender, EventArgs e)
        {

            if (int.TryParse(this.cutomWidth.Text, out int width) && width > 1 && width < 25
                && int.TryParse(this.customViruses.Text, out int viruses) && viruses > 0 && viruses < width * width)
            {
                CustomWidth = width;
                CustomViruses = viruses;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
                

        }

        internal int getWidth()
        {
            return CustomWidth;
        }

        internal int getViruses()
        {
            return CustomViruses;
        }
    }
}
