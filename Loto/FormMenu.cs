using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loto
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        public FormMenu(FormWindowState formWindowState)
        {
            InitializeComponent();
            this.WindowState = formWindowState;
        }

        private void bStart_Click(object sender, EventArgs e)
        {
            Program.Context.MainForm = new FormMenuStartGame(this.WindowState);
            this.Close();
            Program.Context.MainForm.Show();
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы точно хотите выйти?", "Выход", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void bRules_Click(object sender, EventArgs e)
        {
            StreamReader streamReader = new StreamReader("rules.txt");
            string s = streamReader.ReadToEnd();
            MessageBox.Show(s);
            streamReader.Close();
        }

        private void bHistory_Click(object sender, EventArgs e)
        {
            Program.Context.MainForm = new FormHistory(this.WindowState);
            this.Close();
            Program.Context.MainForm.Show();
        }

    }
}
