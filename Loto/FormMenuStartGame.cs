using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loto
{
    public partial class FormMenuStartGame : Form
    {
        public FormMenuStartGame()
        {
            InitializeComponent();
        }

        public FormMenuStartGame(FormWindowState formWindowState)
        {
            InitializeComponent();
            this.WindowState = formWindowState;
        }

        private void bStartClassicGame_Click(object sender, EventArgs e)
        {
            Program.Context.MainForm = new FormGame(1, this.WindowState);
            this.Close();
            Program.Context.MainForm.Show();
        }

        private void bStartStudyGame_Click(object sender, EventArgs e)
        {
            Program.Context.MainForm = new FormGame(2, this.WindowState);
            this.Close();
            Program.Context.MainForm.Show();
        }

        private void bExitToMenu_Click(object sender, EventArgs e)
        {
            Program.Context.MainForm = new FormMenu(this.WindowState);
            this.Close();
            Program.Context.MainForm.Show();
        }

        private void bStartGameWithWord_Click(object sender, EventArgs e)
        {
            Program.Context.MainForm = new FormGame(3, this.WindowState);
            this.Close();
            Program.Context.MainForm.Show();
        }
    }
}
