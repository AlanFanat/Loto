using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Loto
{
    public partial class FormGame : Form
    {
        static int wordsCount;
        bool isShowedHiddenWord;
        bool isGameWithWordInMid = false;
        Player Player1;
        Player Player2;
        List<string> allPicturesPaths;
        static Random rnd = new Random();
        string hiddenWord;
        double time;
        string pictureOfHiddenWordPath;
        int roundsLeft;
        bool isOpponentAnswerRight;
        List<string> wordsInDGV;
        public FormGame() : this(1, FormWindowState.Normal)
        {           
        }

        public FormGame(int level, FormWindowState formWindowState)
        { 
            InitializeComponent();
            this.WindowState = formWindowState;
            this.KeyDown += new KeyEventHandler(ExitToMenu_KeyDown);
            this.KeyDown += new KeyEventHandler(Player1_KeyDown);
            this.KeyDown += new KeyEventHandler(Player2_KeyDown);
            if (level == 1)
            {
                isShowedHiddenWord = false;
                isGameWithWordInMid = false;
            }
            else if(level == 2)
            {
                isShowedHiddenWord = true;
                isGameWithWordInMid = false;
            }
            else
            {
                isShowedHiddenWord = true;
                isGameWithWordInMid = true;
            }
        }

        private class Player
        {
            private int selectedIndex = 0;
            public int SelectedIndex
            {
                get
                {
                    return selectedIndex;
                }
                set
                {
                    if (value < 0)
                    {
                        selectedIndex = 0;
                    }
                    else if (value >= wordsCount)
                    {
                        selectedIndex = wordsCount - 1;
                    }
                    else
                    {
                        selectedIndex = value;
                    }
                }
            }
            public int Points = 0;
            public string ChoosedWord = null;
            public void Reset()
            {
                selectedIndex = 0;
                ChoosedWord = null;
            }
        }

        private void ExitToMenu_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode.ToString())
            {
                case "Escape":
                    DialogResult dialogResult = MessageBox.Show("Вы точно хотите выйти?", "Выход", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        ExitToMenu();
                    }
                    break;
            }
        }

        private void Player1_KeyDown(object sender, KeyEventArgs e)
        {
            if (Player1.ChoosedWord == null)
            {
                switch (e.KeyCode.ToString())
                {
                    case "S":
                        Player1.SelectedIndex++;
                        dGVPlayer1.Rows[Player1.SelectedIndex].Cells[0].Selected = true;
                        break;
                    case "W":
                        Player1.SelectedIndex--;
                        dGVPlayer1.Rows[Player1.SelectedIndex].Cells[0].Selected = true;
                        break;
                    case "ShiftKey":
                        Player1.ChoosedWord = wordsInDGV[Player1.SelectedIndex];
                        dGVPlayer1.Rows.Clear();
                        if (isGameWithWordInMid)
                        {
                            Image imageYES = Image.FromFile("da.jpg");
                            Bitmap bitmapYES = new Bitmap(imageYES, new Size(80, 80));
                            imageYES = bitmapYES;
                            dGVPlayer1.Rows.Add(imageYES);
                            dGVPlayer1.Rows[0].Height = 80;
                            dGVPlayer1.Height = 122;
                        }
                        else
                        {
                            dGVPlayer1.Rows.Add("Выбор сделан ✔");
                            dGVPlayer1.Rows[0].Height = 40;
                            dGVPlayer1.Height = 82;
                        }
                        CheckWord(Player1);
                        if (timerGame.Enabled == false && time > 0)
                        {
                            timerGame.Start();
                        }
                        else
                        {
                            timerGame.Stop();
                            PrintPoints();
                            StartRound();
                        }
                        break;
                }
            }
        }

        private void Player2_KeyDown(object sender, KeyEventArgs e)
        {
            if (Player2.ChoosedWord == null)
            {
                switch (e.KeyCode.ToString())
                {
                    case "Down":
                        Player2.SelectedIndex++;
                        dGVPlayer2.Rows[Player2.SelectedIndex].Cells[0].Selected = true;
                        break;
                    case "Up":
                        Player2.SelectedIndex--;
                        dGVPlayer2.Rows[Player2.SelectedIndex].Cells[0].Selected = true;
                        break;
                    case "Return":
                        Player2.ChoosedWord = wordsInDGV[Player2.SelectedIndex];
                        dGVPlayer2.Rows.Clear();
                        if (isGameWithWordInMid)
                        {
                            Image imageYES = Image.FromFile("da.jpg");
                            Bitmap bitmapYES = new Bitmap(imageYES, new Size(80, 80));
                            imageYES = bitmapYES;
                            dGVPlayer2.Rows.Add(imageYES);
                            dGVPlayer2.Rows[0].Height = 80;
                            dGVPlayer2.Height = 122;
                        }
                        else
                        {
                            dGVPlayer2.Rows.Add("Выбор сделан ✔");
                            dGVPlayer2.Rows[0].Height = 40;
                            dGVPlayer2.Height = 82;
                        }
                        CheckWord(Player2);
                        if (timerGame.Enabled == false && time > 0)
                        {
                            timerGame.Start();
                        }
                        else
                        {
                            timerGame.Stop();
                            PrintPoints();
                            StartRound();
                        }
                        break;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (isGameWithWordInMid)
            {
                dGVPlayer1.Columns.RemoveAt(0);
                dGVPlayer2.Columns.RemoveAt(0);
                int Width = this.WindowState == FormWindowState.Maximized ? 500 : 375;
                lHiddenWord.Location = new Point(Width, (int)(this.Height/3.63));
            }
            else
            {
                dGVPlayer1.Columns.RemoveAt(1);
                dGVPlayer2.Columns.RemoveAt(1);
            }
            StartGame();
        }

        private void StartGame()
        {
            wordsInDGV = new List<string>();
            allPicturesPaths = Directory.GetFiles("Pictures").ToList<string>();
            time = 5;
            timerGame.Interval = 100;
            wordsCount = 6;
            roundsLeft = 10;
            isOpponentAnswerRight = false;
            lHiddenWord.Visible = isShowedHiddenWord;
            SetRoundsNumberOnForm();

            Player1 = new Player();
            Player2 = new Player();

            GetRandomWordAndImage();

            lScorePlayer1.Text = $"Баллтæ {Player1.Points}";
            lScorePlayer2.Text = $"Баллтæ {Player2.Points}";

            FillDGV();
            SetSizeForDGV(dGVPlayer1);
            SetSizeForDGV(dGVPlayer2);
        }

        private void EndGame()
        {
            string winner = "Победила дружба";
            if(Player1.Points > Player2.Points)
            {
                winner = "Победил Игрок 1";
            }
            if (Player1.Points < Player2.Points)
            {
                winner = "Победил Игрок 2";
            }
            string points = $"Счёт: { Player1.Points} - { Player2.Points}";
            StreamWriter streamWriter = new StreamWriter("results.txt", true);
            streamWriter.WriteLine($"{winner} | {points}*{DateTime.Now}");
            streamWriter.Close();
            DialogResult dialogResult = MessageBox.Show($"{winner} {Environment.NewLine} {points} {Environment.NewLine} Хотите сыграть ещё?", "Конец игры", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                ExitToMenu();
            }
            else
            {
                StartGame();
            }
        }

        private void StartRound()
        {
            roundsLeft--;
            if (roundsLeft > 0)
            {
                allPicturesPaths.Remove(pictureOfHiddenWordPath);
                time = 5;
                isOpponentAnswerRight = false;
                Player1.Reset();
                Player2.Reset();
                GetRandomWordAndImage();
                FillDGV();
                SetSizeForDGV(dGVPlayer1);
                SetSizeForDGV(dGVPlayer2);
                SetRoundsNumberOnForm();
            }
            else
            {
                EndGame();
            }
        }

        private void GetRandomWordAndImage()
        {
            pictureOfHiddenWordPath = allPicturesPaths[rnd.Next(0, allPicturesPaths.Count)];
            if (isGameWithWordInMid == false)
            {
                pBHiddenPicture.Image = Image.FromFile(pictureOfHiddenWordPath);
            }
            hiddenWord = pictureOfHiddenWordPath.Split('\\')[1].Split('.')[0];
            lHiddenWord.Text = hiddenWord;
        }

        private void FillDGV()
        {
            dGVPlayer1.Rows.Clear();
            dGVPlayer2.Rows.Clear();
            wordsInDGV.Clear();
            int indexHiddenWord = rnd.Next(0, wordsCount);
            string wordOnImage = hiddenWord;
            if (indexHiddenWord == wordsCount - 1)
            {
                hiddenWord = "нӕй ахӕм ныхас";
            }
            if (isGameWithWordInMid == false)
            {
                for (int i = 0; i < 5; i++)
                {
                    if (i == indexHiddenWord && !wordsInDGV.Contains(wordOnImage))
                    {
                        dGVPlayer1.Rows.Add(wordOnImage);
                        dGVPlayer2.Rows.Add(wordOnImage);
                        wordsInDGV.Add(wordOnImage);
                        continue;
                    }
                    int index = rnd.Next(0, allPicturesPaths.Count);
                    string word = allPicturesPaths[index].Split('\\')[1].Split('.')[0];
                    while (wordsInDGV.Contains(word) || word == wordOnImage)
                    {
                        index = rnd.Next(0, allPicturesPaths.Count);
                        word = allPicturesPaths[index].Split('\\')[1].Split('.')[0];
                    }
                    wordsInDGV.Add(word);
                    dGVPlayer1.Rows.Add(word);
                    dGVPlayer2.Rows.Add(word);
                }
                wordsInDGV.Add("нӕй ахӕм ныхас");
                dGVPlayer1.Rows.Add("нӕй ахӕм ныхас");
                dGVPlayer2.Rows.Add("нӕй ахӕм ныхас");
            }
            int WidthImage = 120;
            int HeigthImage = 90;
            if(isGameWithWordInMid == true)
            {
                for (int i = 0; i < 5; i++)
                {
                    if (i == indexHiddenWord && !wordsInDGV.Contains(wordOnImage))
                    {
                        Image imageHWord = Image.FromFile(pictureOfHiddenWordPath);
                        Bitmap bitmapHWord = new Bitmap(imageHWord, new Size(WidthImage, HeigthImage));
                        imageHWord = bitmapHWord;
                        dGVPlayer1.Rows.Add(imageHWord);
                        dGVPlayer2.Rows.Add(imageHWord);
                        wordsInDGV.Add(hiddenWord);
                        continue;
                    }
                    int index = rnd.Next(0, allPicturesPaths.Count);
                    string wordpath = allPicturesPaths[index];
                    string word = wordpath.Split('\\')[1].Split('.')[0];
                    while (wordsInDGV.Contains(word) || word == wordOnImage)
                    {
                        index = rnd.Next(0, allPicturesPaths.Count);
                        wordpath = allPicturesPaths[index];
                        word = wordpath.Split('\\')[1].Split('.')[0];
                    }
                    wordsInDGV.Add(word);

                    Image image = Image.FromFile(wordpath);
                    Bitmap bitmap = new Bitmap(image, new Size(WidthImage, HeigthImage));
                    image = bitmap;
                    dGVPlayer1.Rows.Add(image);
                    dGVPlayer2.Rows.Add(image);
                }
                wordsInDGV.Add("нӕй ахӕм ныхас");
                Image imageNO = Image.FromFile("net.jpg");
                Bitmap bitmapNO = new Bitmap(imageNO, new Size(WidthImage, HeigthImage));
                imageNO = bitmapNO;
                dGVPlayer1.Rows.Add(imageNO);
                dGVPlayer2.Rows.Add(imageNO);
            }
            dGVPlayer1.Rows[0].Cells[0].Selected = true;
            dGVPlayer2.Rows[0].Cells[0].Selected = true;
        }

        private void SetSizeForDGV(DataGridView dGV)
        {
            if(isGameWithWordInMid)
            {
                dGV.Height = 42;
                foreach (DataGridViewRow row in dGV.Rows)
                {
                    row.Height = 90;
                    dGV.Height += 90;
                }
            }
            else
            {
                dGV.Height = 42;
                foreach (DataGridViewRow row in dGV.Rows)
                {
                    row.Height = 40;
                    dGV.Height += 40;
                }
            }
        }

        private void CheckWord(Player player)
        {
            if (player.ChoosedWord == hiddenWord)
            {
                if (isOpponentAnswerRight)
                {
                    player.Points += (int)(20 * time);
                }
                else
                {
                    isOpponentAnswerRight = true;
                    player.Points += 20 * 5;
                }
            }
        }

        private void PrintPoints()
        {
            lTime.Text = "";
            lScorePlayer1.Text = $"Баллтæ: {Player1.Points}";
            lScorePlayer2.Text = $"Баллтæ: {Player2.Points}";
        }

        private void timerGame_Tick(object sender, EventArgs e)
        {
            time -= 0.1;
            lTime.Text = $"Рæстæг баззади: {time:0.0}";
            if (time <= 0)
            {
                timerGame.Stop();
                PrintPoints();
                StartRound();
            }
        }

        private void ExitToMenu()
        {
            Program.Context.MainForm = new FormMenu(this.WindowState);
            this.Close();
            Program.Context.MainForm.Show();
        }

        private void lExitToMenu_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы точно хотите выйти?", "Выход", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                ExitToMenu();
            }
        }

        private void SetRoundsNumberOnForm()
        {
            lNumberOfRound.Text = $"Раунд №{11 - roundsLeft}";
        }
    }
}
