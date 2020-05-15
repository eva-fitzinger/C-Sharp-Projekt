namespace VirusSweeper
{
    partial class CustomGameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridWidth = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cutomWidth = new System.Windows.Forms.TextBox();
            this.customViruses = new System.Windows.Forms.TextBox();
            this.createCustomGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gridWidth
            // 
            this.gridWidth.AutoSize = true;
            this.gridWidth.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold);
            this.gridWidth.Location = new System.Drawing.Point(42, 83);
            this.gridWidth.Name = "gridWidth";
            this.gridWidth.Size = new System.Drawing.Size(207, 34);
            this.gridWidth.TabIndex = 0;
            this.gridWidth.Text = "Grid Width: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(42, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of Viruses: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(136, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(335, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "Create a Custom Game";
            // 
            // cutomWidth
            // 
            this.cutomWidth.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold);
            this.cutomWidth.Location = new System.Drawing.Point(473, 84);
            this.cutomWidth.Name = "cutomWidth";
            this.cutomWidth.Size = new System.Drawing.Size(100, 41);
            this.cutomWidth.TabIndex = 3;
            // 
            // customViruses
            // 
            this.customViruses.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold);
            this.customViruses.Location = new System.Drawing.Point(473, 133);
            this.customViruses.Name = "customViruses";
            this.customViruses.Size = new System.Drawing.Size(100, 41);
            this.customViruses.TabIndex = 4;
            // 
            // createCustomGame
            // 
            this.createCustomGame.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold);
            this.createCustomGame.Location = new System.Drawing.Point(473, 194);
            this.createCustomGame.Name = "createCustomGame";
            this.createCustomGame.Size = new System.Drawing.Size(100, 32);
            this.createCustomGame.TabIndex = 5;
            this.createCustomGame.Text = "Start Game";
            this.createCustomGame.UseVisualStyleBackColor = true;
            this.createCustomGame.Click += new System.EventHandler(this.createCustomGame_Click);
            // 
            // CustomGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 265);
            this.Controls.Add(this.createCustomGame);
            this.Controls.Add(this.customViruses);
            this.Controls.Add(this.cutomWidth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridWidth);
            this.Name = "CustomGameForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gridWidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cutomWidth;
        private System.Windows.Forms.TextBox customViruses;
        private System.Windows.Forms.Button createCustomGame;
    }
}