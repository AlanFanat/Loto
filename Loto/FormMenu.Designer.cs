
namespace Loto
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.bStart = new System.Windows.Forms.Button();
            this.bHistory = new System.Windows.Forms.Button();
            this.bRules = new System.Windows.Forms.Button();
            this.bExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bStart
            // 
            this.bStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bStart.BackColor = System.Drawing.Color.DeepPink;
            this.bStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bStart.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumVioletRed;
            this.bStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumVioletRed;
            this.bStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bStart.ForeColor = System.Drawing.Color.White;
            this.bStart.Location = new System.Drawing.Point(221, 48);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(305, 85);
            this.bStart.TabIndex = 0;
            this.bStart.Text = "Начать игру";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // bHistory
            // 
            this.bHistory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bHistory.BackColor = System.Drawing.Color.DeepPink;
            this.bHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bHistory.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bHistory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumVioletRed;
            this.bHistory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumVioletRed;
            this.bHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bHistory.ForeColor = System.Drawing.Color.White;
            this.bHistory.Location = new System.Drawing.Point(221, 150);
            this.bHistory.Name = "bHistory";
            this.bHistory.Size = new System.Drawing.Size(305, 85);
            this.bHistory.TabIndex = 1;
            this.bHistory.Text = "История игр";
            this.bHistory.UseVisualStyleBackColor = false;
            this.bHistory.Click += new System.EventHandler(this.bHistory_Click);
            // 
            // bRules
            // 
            this.bRules.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bRules.BackColor = System.Drawing.Color.DeepPink;
            this.bRules.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bRules.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bRules.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumVioletRed;
            this.bRules.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumVioletRed;
            this.bRules.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bRules.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bRules.ForeColor = System.Drawing.Color.White;
            this.bRules.Location = new System.Drawing.Point(221, 253);
            this.bRules.Name = "bRules";
            this.bRules.Size = new System.Drawing.Size(305, 85);
            this.bRules.TabIndex = 2;
            this.bRules.Text = "Правила";
            this.bRules.UseVisualStyleBackColor = false;
            this.bRules.Click += new System.EventHandler(this.bRules_Click);
            // 
            // bExit
            // 
            this.bExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bExit.BackColor = System.Drawing.Color.DeepPink;
            this.bExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bExit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumVioletRed;
            this.bExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumVioletRed;
            this.bExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bExit.ForeColor = System.Drawing.Color.White;
            this.bExit.Location = new System.Drawing.Point(221, 355);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(305, 85);
            this.bExit.TabIndex = 3;
            this.bExit.Text = "Выход из игры";
            this.bExit.UseVisualStyleBackColor = false;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(734, 511);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.bRules);
            this.Controls.Add(this.bHistory);
            this.Controls.Add(this.bStart);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(230, 450);
            this.Name = "FormMenu";
            this.Text = "Главное меню";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.Button bHistory;
        private System.Windows.Forms.Button bRules;
        private System.Windows.Forms.Button bExit;
    }
}