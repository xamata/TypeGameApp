namespace FormsTypeGame
{
    partial class mainForm
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
            startButton = new Button();
            closeButton = new Button();
            scoreLabel = new Label();
            characterLabel = new Label();
            gameTimer = new System.Windows.Forms.Timer(components);
            gamePanel = new Panel();
            testLabel = new Label();
            timerLabel = new Label();
            gamePanel.SuspendLayout();
            SuspendLayout();
            // 
            // startButton
            // 
            startButton.Location = new Point(32, 732);
            startButton.Name = "startButton";
            startButton.Size = new Size(268, 118);
            startButton.TabIndex = 0;
            startButton.Text = "Start Game";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += btnStart_Click;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(342, 732);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(268, 118);
            closeButton.TabIndex = 1;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += btnClose_Click;
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.Location = new Point(972, 763);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(163, 57);
            scoreLabel.TabIndex = 2;
            scoreLabel.Text = "Score 0";
            // 
            // characterLabel
            // 
            characterLabel.AutoSize = true;
            characterLabel.BackColor = SystemColors.InactiveCaption;
            characterLabel.Location = new Point(65, 74);
            characterLabel.MinimumSize = new Size(1000, 500);
            characterLabel.Name = "characterLabel";
            characterLabel.Size = new Size(1000, 500);
            characterLabel.TabIndex = 3;
            characterLabel.Text = "characterLabel";
            characterLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gameTimer
            // 
            gameTimer.Interval = 1000;
            gameTimer.Tick += gameTimer_Tick;
            // 
            // gamePanel
            // 
            gamePanel.Controls.Add(testLabel);
            gamePanel.Controls.Add(characterLabel);
            gamePanel.Dock = DockStyle.Top;
            gamePanel.Location = new Point(0, 0);
            gamePanel.Name = "gamePanel";
            gamePanel.Size = new Size(1793, 693);
            gamePanel.TabIndex = 4;
            // 
            // testLabel
            // 
            testLabel.AutoSize = true;
            testLabel.Location = new Point(85, 122);
            testLabel.Name = "testLabel";
            testLabel.Size = new Size(237, 57);
            testLabel.TabIndex = 4;
            testLabel.Text = "TEST LABEL";
            // 
            // timerLabel
            // 
            timerLabel.AutoSize = true;
            timerLabel.Location = new Point(670, 763);
            timerLabel.Name = "timerLabel";
            timerLabel.Size = new Size(126, 57);
            timerLabel.TabIndex = 5;
            timerLabel.Text = "00:00";
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(23F, 57F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1793, 915);
            Controls.Add(timerLabel);
            Controls.Add(gamePanel);
            Controls.Add(scoreLabel);
            Controls.Add(closeButton);
            Controls.Add(startButton);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            KeyPreview = true;
            Margin = new Padding(6);
            Name = "mainForm";
            Text = "Main";
            KeyPress += Main_KeyPress;
            gamePanel.ResumeLayout(false);
            gamePanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button startButton;
        private Button closeButton;
        private Label scoreLabel;
        private Label characterLabel;
        private System.Windows.Forms.Timer gameTimer;
        private Panel gamePanel;
        private Label timerLabel;
        private Label testLabel;
    }
}