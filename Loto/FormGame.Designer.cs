
namespace Loto
{
    partial class FormGame
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGame));
            this.pBHiddenPicture = new System.Windows.Forms.PictureBox();
            this.lScorePlayer1 = new System.Windows.Forms.Label();
            this.lScorePlayer2 = new System.Windows.Forms.Label();
            this.timerGame = new System.Windows.Forms.Timer(this.components);
            this.lTime = new System.Windows.Forms.Label();
            this.dGVPlayer2 = new System.Windows.Forms.DataGridView();
            this.ColumnPlayer2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPlayer2Images = new System.Windows.Forms.DataGridViewImageColumn();
            this.dGVPlayer1 = new System.Windows.Forms.DataGridView();
            this.ColumnPlayer1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPlayer1Images = new System.Windows.Forms.DataGridViewImageColumn();
            this.lExitToMenu = new System.Windows.Forms.Label();
            this.lNumberOfRound = new System.Windows.Forms.Label();
            this.lHiddenWord = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pBHiddenPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVPlayer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // pBHiddenPicture
            // 
            this.pBHiddenPicture.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pBHiddenPicture.Location = new System.Drawing.Point(415, 75);
            this.pBHiddenPicture.Name = "pBHiddenPicture";
            this.pBHiddenPicture.Size = new System.Drawing.Size(323, 345);
            this.pBHiddenPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBHiddenPicture.TabIndex = 2;
            this.pBHiddenPicture.TabStop = false;
            // 
            // lScorePlayer1
            // 
            this.lScorePlayer1.AutoSize = true;
            this.lScorePlayer1.BackColor = System.Drawing.Color.DeepPink;
            this.lScorePlayer1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lScorePlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lScorePlayer1.ForeColor = System.Drawing.Color.White;
            this.lScorePlayer1.Location = new System.Drawing.Point(116, 18);
            this.lScorePlayer1.Name = "lScorePlayer1";
            this.lScorePlayer1.Size = new System.Drawing.Size(104, 29);
            this.lScorePlayer1.TabIndex = 3;
            this.lScorePlayer1.Text = "Баллтæ";
            // 
            // lScorePlayer2
            // 
            this.lScorePlayer2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lScorePlayer2.AutoSize = true;
            this.lScorePlayer2.BackColor = System.Drawing.Color.DeepPink;
            this.lScorePlayer2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lScorePlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lScorePlayer2.ForeColor = System.Drawing.Color.White;
            this.lScorePlayer2.Location = new System.Drawing.Point(914, 18);
            this.lScorePlayer2.Name = "lScorePlayer2";
            this.lScorePlayer2.Size = new System.Drawing.Size(104, 29);
            this.lScorePlayer2.TabIndex = 4;
            this.lScorePlayer2.Text = "Баллтæ";
            // 
            // timerGame
            // 
            this.timerGame.Tick += new System.EventHandler(this.timerGame_Tick);
            // 
            // lTime
            // 
            this.lTime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lTime.AutoSize = true;
            this.lTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lTime.Location = new System.Drawing.Point(421, 18);
            this.lTime.Name = "lTime";
            this.lTime.Size = new System.Drawing.Size(0, 37);
            this.lTime.TabIndex = 5;
            // 
            // dGVPlayer2
            // 
            this.dGVPlayer2.AllowUserToAddRows = false;
            this.dGVPlayer2.AllowUserToDeleteRows = false;
            this.dGVPlayer2.AllowUserToResizeColumns = false;
            this.dGVPlayer2.AllowUserToResizeRows = false;
            this.dGVPlayer2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVPlayer2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVPlayer2.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dGVPlayer2.CausesValidation = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGVPlayer2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dGVPlayer2.ColumnHeadersHeight = 40;
            this.dGVPlayer2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dGVPlayer2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnPlayer2,
            this.ColumnPlayer2Images});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVPlayer2.DefaultCellStyle = dataGridViewCellStyle3;
            this.dGVPlayer2.Enabled = false;
            this.dGVPlayer2.Location = new System.Drawing.Point(843, 55);
            this.dGVPlayer2.MultiSelect = false;
            this.dGVPlayer2.Name = "dGVPlayer2";
            this.dGVPlayer2.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGVPlayer2.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dGVPlayer2.RowHeadersWidth = 40;
            this.dGVPlayer2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dGVPlayer2.Size = new System.Drawing.Size(250, 42);
            this.dGVPlayer2.TabIndex = 0;
            this.dGVPlayer2.TabStop = false;
            // 
            // ColumnPlayer2
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ColumnPlayer2.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColumnPlayer2.HeaderText = "Слова 2 игрока";
            this.ColumnPlayer2.Name = "ColumnPlayer2";
            this.ColumnPlayer2.ReadOnly = true;
            // 
            // ColumnPlayer2Images
            // 
            this.ColumnPlayer2Images.HeaderText = "Картинки 2 игрока";
            this.ColumnPlayer2Images.Name = "ColumnPlayer2Images";
            this.ColumnPlayer2Images.ReadOnly = true;
            // 
            // dGVPlayer1
            // 
            this.dGVPlayer1.AllowUserToAddRows = false;
            this.dGVPlayer1.AllowUserToDeleteRows = false;
            this.dGVPlayer1.AllowUserToResizeColumns = false;
            this.dGVPlayer1.AllowUserToResizeRows = false;
            this.dGVPlayer1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVPlayer1.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dGVPlayer1.CausesValidation = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGVPlayer1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dGVPlayer1.ColumnHeadersHeight = 40;
            this.dGVPlayer1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dGVPlayer1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnPlayer1,
            this.ColumnPlayer1Images});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVPlayer1.DefaultCellStyle = dataGridViewCellStyle7;
            this.dGVPlayer1.Enabled = false;
            this.dGVPlayer1.Location = new System.Drawing.Point(49, 55);
            this.dGVPlayer1.MultiSelect = false;
            this.dGVPlayer1.Name = "dGVPlayer1";
            this.dGVPlayer1.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGVPlayer1.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dGVPlayer1.RowHeadersWidth = 40;
            this.dGVPlayer1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dGVPlayer1.Size = new System.Drawing.Size(250, 42);
            this.dGVPlayer1.TabIndex = 6;
            this.dGVPlayer1.TabStop = false;
            // 
            // ColumnPlayer1
            // 
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ColumnPlayer1.DefaultCellStyle = dataGridViewCellStyle6;
            this.ColumnPlayer1.HeaderText = "Слова 1 игрока";
            this.ColumnPlayer1.Name = "ColumnPlayer1";
            this.ColumnPlayer1.ReadOnly = true;
            // 
            // ColumnPlayer1Images
            // 
            this.ColumnPlayer1Images.HeaderText = "Картинки 1 игрока";
            this.ColumnPlayer1Images.Name = "ColumnPlayer1Images";
            this.ColumnPlayer1Images.ReadOnly = true;
            this.ColumnPlayer1Images.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnPlayer1Images.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // lExitToMenu
            // 
            this.lExitToMenu.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lExitToMenu.AutoSize = true;
            this.lExitToMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lExitToMenu.ForeColor = System.Drawing.Color.Firebrick;
            this.lExitToMenu.Location = new System.Drawing.Point(475, 596);
            this.lExitToMenu.Name = "lExitToMenu";
            this.lExitToMenu.Size = new System.Drawing.Size(215, 24);
            this.lExitToMenu.TabIndex = 7;
            this.lExitToMenu.Text = "Выйти в главное меню";
            this.lExitToMenu.Click += new System.EventHandler(this.lExitToMenu_Click);
            // 
            // lNumberOfRound
            // 
            this.lNumberOfRound.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lNumberOfRound.AutoSize = true;
            this.lNumberOfRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lNumberOfRound.ForeColor = System.Drawing.Color.Black;
            this.lNumberOfRound.Location = new System.Drawing.Point(507, 541);
            this.lNumberOfRound.Name = "lNumberOfRound";
            this.lNumberOfRound.Size = new System.Drawing.Size(141, 31);
            this.lNumberOfRound.TabIndex = 8;
            this.lNumberOfRound.Text = "Раунд №1";
            // 
            // lHiddenWord
            // 
            this.lHiddenWord.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lHiddenWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lHiddenWord.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lHiddenWord.Location = new System.Drawing.Point(379, 438);
            this.lHiddenWord.Name = "lHiddenWord";
            this.lHiddenWord.Size = new System.Drawing.Size(400, 77);
            this.lHiddenWord.TabIndex = 9;
            this.lHiddenWord.Text = "Ныхас";
            this.lHiddenWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lHiddenWord.Visible = false;
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1131, 687);
            this.Controls.Add(this.lHiddenWord);
            this.Controls.Add(this.lNumberOfRound);
            this.Controls.Add(this.lExitToMenu);
            this.Controls.Add(this.dGVPlayer1);
            this.Controls.Add(this.dGVPlayer2);
            this.Controls.Add(this.lTime);
            this.Controls.Add(this.lScorePlayer2);
            this.Controls.Add(this.lScorePlayer1);
            this.Controls.Add(this.pBHiddenPicture);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(900, 620);
            this.Name = "FormGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лото";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBHiddenPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVPlayer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pBHiddenPicture;
        private System.Windows.Forms.Label lScorePlayer1;
        private System.Windows.Forms.Label lScorePlayer2;
        private System.Windows.Forms.Timer timerGame;
        private System.Windows.Forms.Label lTime;
        private System.Windows.Forms.DataGridView dGVPlayer2;
        private System.Windows.Forms.DataGridView dGVPlayer1;
        private System.Windows.Forms.Label lExitToMenu;
        private System.Windows.Forms.Label lNumberOfRound;
        private System.Windows.Forms.Label lHiddenWord;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPlayer2;
        private System.Windows.Forms.DataGridViewImageColumn ColumnPlayer2Images;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPlayer1;
        private System.Windows.Forms.DataGridViewImageColumn ColumnPlayer1Images;
    }
}

