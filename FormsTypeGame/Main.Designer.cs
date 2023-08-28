namespace FormsTypeGame
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnStart = new Button();
            btnClose = new Button();
            labelScore = new Label();
            lblCharacter = new Label();
            gameTimer = new System.Windows.Forms.Timer(components);
            gamePanel = new Panel();
            gamePanel.SuspendLayout();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Location = new Point(32, 732);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(268, 118);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start Game";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(342, 732);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(268, 118);
            btnClose.TabIndex = 1;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // labelScore
            // 
            labelScore.AutoSize = true;
            labelScore.Location = new Point(659, 763);
            labelScore.Name = "labelScore";
            labelScore.Size = new Size(163, 57);
            labelScore.TabIndex = 2;
            labelScore.Text = "Score 0";
            // 
            // lblCharacter
            // 
            lblCharacter.AutoSize = true;
            lblCharacter.BackColor = SystemColors.InactiveCaption;
            lblCharacter.Location = new Point(670, 88);
            lblCharacter.MinimumSize = new Size(150, 20);
            lblCharacter.Name = "lblCharacter";
            lblCharacter.Size = new Size(150, 57);
            lblCharacter.TabIndex = 3;
            lblCharacter.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gameTimer
            // 
            gameTimer.Tick += gameTimer_Tick;
            // 
            // gamePanel
            // 
            gamePanel.Controls.Add(lblCharacter);
            gamePanel.Dock = DockStyle.Top;
            gamePanel.Location = new Point(0, 0);
            gamePanel.Name = "gamePanel";
            gamePanel.Size = new Size(1793, 693);
            gamePanel.TabIndex = 4;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(23F, 57F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1793, 915);
            Controls.Add(gamePanel);
            Controls.Add(labelScore);
            Controls.Add(btnClose);
            Controls.Add(btnStart);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            KeyPreview = true;
            Margin = new Padding(6);
            Name = "Main";
            Text = "Main";
            KeyPress += Main_KeyPress;
            gamePanel.ResumeLayout(false);
            gamePanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStart;
        private Button btnClose;
        private Label labelScore;
        private Label lblCharacter;
        private System.Windows.Forms.Timer gameTimer;
        private Panel gamePanel;
    }
}