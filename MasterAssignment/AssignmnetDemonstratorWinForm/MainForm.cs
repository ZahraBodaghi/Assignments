using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
/*
 * Zahra Bodaghi
 */
namespace AssignmnetDemonstratorWinForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MenuItemExit_Click(object sender, EventArgs e)
        {
            Close(); 
        }

        private void MenuItemAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is Master Assginment Week 6  By Zahra :) ");
        }

        private void MenuItemOpen_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                Filter = "Comman Separated Values|*.CSV",
                Title = "Select the Hundred Names CSV"
            };

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                TxtFileFlash.Text = openFileDialog.SafeFileName;
                using(StreamReader sr = File.OpenText(openFileDialog.FileName))
                {
                    var oneLineOfText = "";
                    while((oneLineOfText = sr.ReadLine()) != null)
                    {
                        ListBoxOutput.Items.Add(oneLineOfText);
                    }
                }
            }
            TxtFileFlash.Text = openFileDialog.SafeFileName;
            using(StreamReader sr = File.OpenText(openFileDialog.FileName))
            {
                var oneLineOfText = "";
                while ((oneLineOfText = sr.ReadLine()) != null)
                {
                    ListBoxOutput.Items.Add(oneLineOfText);
                }
            }
        }

    }
}
