namespace Backgammon_Game
{
    partial class MainMenuForm
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
            this.WhiteCon = new System.Windows.Forms.PictureBox();
            this.Player1Name_TB = new System.Windows.Forms.TextBox();
            this.Player2Name_TB = new System.Windows.Forms.TextBox();
            this.BlackCon = new System.Windows.Forms.PictureBox();
            this.RadioButtonPoints = new System.Windows.Forms.RadioButton();
            this.Rb1 = new System.Windows.Forms.RadioButton();
            this.Rb2 = new System.Windows.Forms.RadioButton();
            this.Rb3 = new System.Windows.Forms.RadioButton();
            this.Rb4 = new System.Windows.Forms.RadioButton();
            this.Rb5 = new System.Windows.Forms.RadioButton();
            this.GroupB1 = new System.Windows.Forms.GroupBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.Rb_AI1 = new System.Windows.Forms.RadioButton();
            this.Rb_AI2 = new System.Windows.Forms.RadioButton();
            this.Rb_No_AI = new System.Windows.Forms.RadioButton();
            this.GroupB2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.WhiteCon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlackCon)).BeginInit();
            this.GroupB1.SuspendLayout();
            this.GroupB2.SuspendLayout();
            this.SuspendLayout();
            // 
            // WhiteCon
            // 
            this.WhiteCon.BackgroundImage = global::Backgammon_Game.Properties.Resources.BlackPip;
            this.WhiteCon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.WhiteCon.Location = new System.Drawing.Point(12, 16);
            this.WhiteCon.Name = "WhiteCon";
            this.WhiteCon.Size = new System.Drawing.Size(54, 57);
            this.WhiteCon.TabIndex = 0;
            this.WhiteCon.TabStop = false;
            // 
            // Player1Name_TB
            // 
            this.Player1Name_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Player1Name_TB.Location = new System.Drawing.Point(72, 29);
            this.Player1Name_TB.MaxLength = 8;
            this.Player1Name_TB.Name = "Player1Name_TB";
            this.Player1Name_TB.Size = new System.Drawing.Size(243, 26);
            this.Player1Name_TB.TabIndex = 1;
            this.Player1Name_TB.Text = "1st Player Name...";
            this.Player1Name_TB.TextChanged += new System.EventHandler(this.Player1Name_TB_TextChanged);
            // 
            // Player2Name_TB
            // 
            this.Player2Name_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Player2Name_TB.Location = new System.Drawing.Point(72, 93);
            this.Player2Name_TB.MaxLength = 8;
            this.Player2Name_TB.Name = "Player2Name_TB";
            this.Player2Name_TB.Size = new System.Drawing.Size(243, 26);
            this.Player2Name_TB.TabIndex = 3;
            this.Player2Name_TB.Text = "2nd Player Name...";
            this.Player2Name_TB.TextChanged += new System.EventHandler(this.Player2Name_TB_TextChanged);
            // 
            // BlackCon
            // 
            this.BlackCon.BackgroundImage = global::Backgammon_Game.Properties.Resources.WhitePip;
            this.BlackCon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BlackCon.Location = new System.Drawing.Point(12, 79);
            this.BlackCon.Name = "BlackCon";
            this.BlackCon.Size = new System.Drawing.Size(54, 50);
            this.BlackCon.TabIndex = 2;
            this.BlackCon.TabStop = false;
            // 
            // RadioButtonPoints
            // 
            this.RadioButtonPoints.AutoSize = true;
            this.RadioButtonPoints.Checked = true;
            this.RadioButtonPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RadioButtonPoints.Location = new System.Drawing.Point(6, 19);
            this.RadioButtonPoints.Name = "RadioButtonPoints";
            this.RadioButtonPoints.Size = new System.Drawing.Size(33, 20);
            this.RadioButtonPoints.TabIndex = 6;
            this.RadioButtonPoints.TabStop = true;
            this.RadioButtonPoints.Text = "1";
            this.RadioButtonPoints.UseVisualStyleBackColor = true;
            this.RadioButtonPoints.CheckedChanged += new System.EventHandler(this.RadioButtonPoints_CheckedChanged);
            // 
            // Rb1
            // 
            this.Rb1.AutoSize = true;
            this.Rb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Rb1.Location = new System.Drawing.Point(73, 19);
            this.Rb1.Name = "Rb1";
            this.Rb1.Size = new System.Drawing.Size(33, 20);
            this.Rb1.TabIndex = 7;
            this.Rb1.Text = "3";
            this.Rb1.UseVisualStyleBackColor = true;
            this.Rb1.CheckedChanged += new System.EventHandler(this.Rb1_CheckedChanged);
            // 
            // Rb2
            // 
            this.Rb2.AutoSize = true;
            this.Rb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Rb2.Location = new System.Drawing.Point(144, 19);
            this.Rb2.Name = "Rb2";
            this.Rb2.Size = new System.Drawing.Size(33, 20);
            this.Rb2.TabIndex = 8;
            this.Rb2.Text = "5";
            this.Rb2.UseVisualStyleBackColor = true;
            this.Rb2.CheckedChanged += new System.EventHandler(this.Rb2_CheckedChanged);
            // 
            // Rb3
            // 
            this.Rb3.AutoSize = true;
            this.Rb3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Rb3.Location = new System.Drawing.Point(211, 19);
            this.Rb3.Name = "Rb3";
            this.Rb3.Size = new System.Drawing.Size(33, 20);
            this.Rb3.TabIndex = 9;
            this.Rb3.Text = "7";
            this.Rb3.UseVisualStyleBackColor = true;
            this.Rb3.CheckedChanged += new System.EventHandler(this.Rb3_CheckedChanged);
            // 
            // Rb4
            // 
            this.Rb4.AutoSize = true;
            this.Rb4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Rb4.Location = new System.Drawing.Point(278, 19);
            this.Rb4.Name = "Rb4";
            this.Rb4.Size = new System.Drawing.Size(40, 20);
            this.Rb4.TabIndex = 10;
            this.Rb4.Text = "11";
            this.Rb4.UseVisualStyleBackColor = true;
            this.Rb4.CheckedChanged += new System.EventHandler(this.Rb4_CheckedChanged);
            // 
            // Rb5
            // 
            this.Rb5.AutoSize = true;
            this.Rb5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Rb5.Location = new System.Drawing.Point(345, 19);
            this.Rb5.Name = "Rb5";
            this.Rb5.Size = new System.Drawing.Size(40, 20);
            this.Rb5.TabIndex = 11;
            this.Rb5.Text = "15";
            this.Rb5.UseVisualStyleBackColor = true;
            this.Rb5.CheckedChanged += new System.EventHandler(this.Rb5_CheckedChanged);
            // 
            // GroupB1
            // 
            this.GroupB1.Controls.Add(this.RadioButtonPoints);
            this.GroupB1.Controls.Add(this.Rb5);
            this.GroupB1.Controls.Add(this.Rb1);
            this.GroupB1.Controls.Add(this.Rb4);
            this.GroupB1.Controls.Add(this.Rb2);
            this.GroupB1.Controls.Add(this.Rb3);
            this.GroupB1.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupB1.Location = new System.Drawing.Point(12, 219);
            this.GroupB1.Name = "GroupB1";
            this.GroupB1.Size = new System.Drawing.Size(415, 58);
            this.GroupB1.TabIndex = 12;
            this.GroupB1.TabStop = false;
            this.GroupB1.Text = "Number of Rounds";
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.Location = new System.Drawing.Point(12, 295);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(415, 37);
            this.StartButton.TabIndex = 13;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // Rb_AI1
            // 
            this.Rb_AI1.AutoSize = true;
            this.Rb_AI1.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rb_AI1.Location = new System.Drawing.Point(6, 19);
            this.Rb_AI1.Name = "Rb_AI1";
            this.Rb_AI1.Size = new System.Drawing.Size(89, 23);
            this.Rb_AI1.TabIndex = 14;
            this.Rb_AI1.Text = "Player 1";
            this.Rb_AI1.UseVisualStyleBackColor = true;
            this.Rb_AI1.CheckedChanged += new System.EventHandler(this.Rb_AI1_CheckedChanged);
            // 
            // Rb_AI2
            // 
            this.Rb_AI2.AutoSize = true;
            this.Rb_AI2.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rb_AI2.Location = new System.Drawing.Point(6, 84);
            this.Rb_AI2.Name = "Rb_AI2";
            this.Rb_AI2.Size = new System.Drawing.Size(92, 23);
            this.Rb_AI2.TabIndex = 15;
            this.Rb_AI2.Text = "Player 2";
            this.Rb_AI2.UseVisualStyleBackColor = true;
            this.Rb_AI2.CheckedChanged += new System.EventHandler(this.Rb_AI2_CheckedChanged);
            // 
            // Rb_No_AI
            // 
            this.Rb_No_AI.AutoSize = true;
            this.Rb_No_AI.Checked = true;
            this.Rb_No_AI.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rb_No_AI.Location = new System.Drawing.Point(6, 151);
            this.Rb_No_AI.Name = "Rb_No_AI";
            this.Rb_No_AI.Size = new System.Drawing.Size(70, 23);
            this.Rb_No_AI.TabIndex = 15;
            this.Rb_No_AI.TabStop = true;
            this.Rb_No_AI.Text = "No AI";
            this.Rb_No_AI.UseVisualStyleBackColor = true;
            this.Rb_No_AI.CheckedChanged += new System.EventHandler(this.Rb_No_AI_CheckedChanged);
            // 
            // GroupB2
            // 
            this.GroupB2.Controls.Add(this.Rb_AI1);
            this.GroupB2.Controls.Add(this.Rb_No_AI);
            this.GroupB2.Controls.Add(this.Rb_AI2);
            this.GroupB2.Location = new System.Drawing.Point(321, 12);
            this.GroupB2.Name = "GroupB2";
            this.GroupB2.Size = new System.Drawing.Size(106, 201);
            this.GroupB2.TabIndex = 16;
            this.GroupB2.TabStop = false;
            this.GroupB2.Text = "Player: AI";
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(439, 344);
            this.ControlBox = false;
            this.Controls.Add(this.GroupB2);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.GroupB1);
            this.Controls.Add(this.Player2Name_TB);
            this.Controls.Add(this.BlackCon);
            this.Controls.Add(this.Player1Name_TB);
            this.Controls.Add(this.WhiteCon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Game";
            ((System.ComponentModel.ISupportInitialize)(this.WhiteCon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlackCon)).EndInit();
            this.GroupB1.ResumeLayout(false);
            this.GroupB1.PerformLayout();
            this.GroupB2.ResumeLayout(false);
            this.GroupB2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox WhiteCon;
        private System.Windows.Forms.TextBox Player1Name_TB;
        private System.Windows.Forms.TextBox Player2Name_TB;
        private System.Windows.Forms.PictureBox BlackCon;
        private System.Windows.Forms.RadioButton RadioButtonPoints;
        private System.Windows.Forms.RadioButton Rb1;
        private System.Windows.Forms.RadioButton Rb2;
        private System.Windows.Forms.RadioButton Rb3;
        private System.Windows.Forms.RadioButton Rb4;
        private System.Windows.Forms.RadioButton Rb5;
        private System.Windows.Forms.GroupBox GroupB1;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.RadioButton Rb_AI1;
        private System.Windows.Forms.RadioButton Rb_AI2;
        private System.Windows.Forms.RadioButton Rb_No_AI;
        private System.Windows.Forms.GroupBox GroupB2;
    }
}