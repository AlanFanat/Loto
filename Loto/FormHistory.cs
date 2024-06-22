using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loto
{
    public partial class FormHistory : Form
    {
        public FormHistory()
        {
            InitializeComponent();
        }

        public FormHistory(FormWindowState formWindowState)
        {
            InitializeComponent();
            this.WindowState = formWindowState;
        }

        private void bMainMenu_Click(object sender, EventArgs e)
        {
            Program.Context.MainForm = new FormMenu(this.WindowState);
            this.Close();
            Program.Context.MainForm.Show();
        }

        private void FormHistory_Load(object sender, EventArgs e)
        {
            StreamReader streamReader = new StreamReader("results.txt");
            string s = streamReader.ReadLine();
            int i = 0;
            while (!string.IsNullOrEmpty(s))
            {
                string[] ss = s.Split('*');
                dGVHistoryOfGames.Rows.Add($"{i}.{ss[0]} {Environment.NewLine}   {ss[1]}");
                s = streamReader.ReadLine();
                dGVHistoryOfGames.Rows[i].Height = 60;
                i++;
            }
            dGVHistoryOfGames.ClearSelection();
            streamReader.Close();
        }
    }
}
