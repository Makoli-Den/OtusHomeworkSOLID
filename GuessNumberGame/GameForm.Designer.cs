namespace GuessNumberGame
{
    partial class GameForm
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
            label = new Label();
            textBox = new TextBox();
            button = new Button();
            buttonRestart = new Button();
            labelCounter = new Label();
            labelMain = new Label();
            SuspendLayout();
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(12, 24);
            label.Name = "label";
            label.Size = new Size(32, 15);
            label.TabIndex = 0;
            label.Text = "label";
            // 
            // textBox
            // 
            textBox.Location = new Point(12, 42);
            textBox.Name = "textBox";
            textBox.Size = new Size(100, 23);
            textBox.TabIndex = 1;
            textBox.KeyPress += textBox_KeyPress;
            // 
            // button
            // 
            button.Location = new Point(12, 71);
            button.Name = "button";
            button.Size = new Size(75, 23);
            button.TabIndex = 2;
            button.Text = "Угадать";
            button.UseVisualStyleBackColor = true;
            button.Click += button_Click;
            // 
            // buttonRestart
            // 
            buttonRestart.Location = new Point(93, 71);
            buttonRestart.Name = "buttonRestart";
            buttonRestart.Size = new Size(144, 23);
            buttonRestart.TabIndex = 3;
            buttonRestart.Text = "Начать сначала";
            buttonRestart.UseVisualStyleBackColor = true;
            buttonRestart.Click += buttonRestart_Click;
            // 
            // labelCounter
            // 
            labelCounter.AutoSize = true;
            labelCounter.Location = new Point(118, 45);
            labelCounter.Name = "labelCounter";
            labelCounter.Size = new Size(100, 15);
            labelCounter.TabIndex = 4;
            labelCounter.Text = "Кол-во попыток:";
            // 
            // labelMain
            // 
            labelMain.AutoSize = true;
            labelMain.Location = new Point(12, 9);
            labelMain.Name = "labelMain";
            labelMain.Size = new Size(32, 15);
            labelMain.TabIndex = 5;
            labelMain.Text = "label";
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 146);
            Controls.Add(labelMain);
            Controls.Add(labelCounter);
            Controls.Add(buttonRestart);
            Controls.Add(button);
            Controls.Add(textBox);
            Controls.Add(label);
            Name = "GameForm";
            Text = "Guess Number Game";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label;
        private TextBox textBox;
        private Button button;
        private Button buttonRestart;
        private Label labelCounter;
        private Label labelMain;
    }
}