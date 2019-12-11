using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
namespace GameCell
{
    class GameCell: UserControl
    {
        private Button btnGame;

        public int GameCellRow { get; set; }
        public int GameCellCol { get; set; }
        public GameCellStates GameCellStates { get; set; }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameCell));
            this.btnGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGame
            // 
            this.btnGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGame.Image = ((System.Drawing.Image)(resources.GetObject("btnGame.Image")));
            this.btnGame.Location = new System.Drawing.Point(0, 0);
            this.btnGame.Name = "btnGame";
            this.btnGame.Size = new System.Drawing.Size(150, 150);
            this.btnGame.TabIndex = 0;
            this.btnGame.UseVisualStyleBackColor = true;
            this.btnGame.Click += new System.EventHandler(this.btnGame_Click);
            // 
            // GameCell
            // 
            this.Controls.Add(this.btnGame);
            this.Name = "GameCell";
            this.ResumeLayout(false);

        }

        private void btnGame_Click(object sender, EventArgs e)
        {
            if(sender is GameCell gCell)
            {
                var targetColumn = gCell.GameCellCol;
            }
        }
    }
}
