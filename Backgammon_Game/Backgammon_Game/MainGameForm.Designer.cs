namespace Backgammon_Game
{
    partial class MainGameForm
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
            this.components = new System.ComponentModel.Container();
            this.DiceButton = new System.Windows.Forms.Button();
            this.DiceLabel = new System.Windows.Forms.Label();
            this.NewGameButton = new System.Windows.Forms.Button();
            this.InfoPanel = new System.Windows.Forms.Panel();
            this.InfoLabel = new System.Windows.Forms.TextBox();
            this.PointsPanel = new System.Windows.Forms.Panel();
            this.Person2Label = new System.Windows.Forms.Label();
            this.Person1Label = new System.Windows.Forms.Label();
            this.DiceTimer = new System.Windows.Forms.Timer(this.components);
            this.MoveTimer = new System.Windows.Forms.Timer(this.components);
            this.InfoPanel.SuspendLayout();
            this.PointsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DiceButton
            // 
            this.DiceButton.Enabled = false;
            this.DiceButton.Font = new System.Drawing.Font("AR JULIAN", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiceButton.Location = new System.Drawing.Point(718, 329);
            this.DiceButton.Name = "DiceButton";
            this.DiceButton.Size = new System.Drawing.Size(254, 77);
            this.DiceButton.TabIndex = 0;
            this.DiceButton.Text = "Roll Dice";
            this.DiceButton.UseVisualStyleBackColor = true;
            this.DiceButton.Click += new System.EventHandler(this.DiceButton_Click);
            // 
            // DiceLabel
            // 
            this.DiceLabel.AutoSize = true;
            this.DiceLabel.BackColor = System.Drawing.Color.White;
            this.DiceLabel.Font = new System.Drawing.Font("AR JULIAN", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiceLabel.Location = new System.Drawing.Point(45, 72);
            this.DiceLabel.Name = "DiceLabel";
            this.DiceLabel.Size = new System.Drawing.Size(171, 111);
            this.DiceLabel.TabIndex = 2;
            this.DiceLabel.Text = "⚅⚅";
            this.DiceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DiceLabel.Visible = false;
            // 
            // NewGameButton
            // 
            this.NewGameButton.Font = new System.Drawing.Font("AR JULIAN", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewGameButton.Location = new System.Drawing.Point(718, 412);
            this.NewGameButton.Name = "NewGameButton";
            this.NewGameButton.Size = new System.Drawing.Size(254, 77);
            this.NewGameButton.TabIndex = 3;
            this.NewGameButton.Text = "New Game";
            this.NewGameButton.UseVisualStyleBackColor = true;
            this.NewGameButton.Click += new System.EventHandler(this.NewGameButton_Click);
            // 
            // InfoPanel
            // 
            this.InfoPanel.BackColor = System.Drawing.Color.White;
            this.InfoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InfoPanel.Controls.Add(this.InfoLabel);
            this.InfoPanel.Controls.Add(this.PointsPanel);
            this.InfoPanel.Controls.Add(this.DiceLabel);
            this.InfoPanel.Location = new System.Drawing.Point(718, 12);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(254, 311);
            this.InfoPanel.TabIndex = 4;
            // 
            // InfoLabel
            // 
            this.InfoLabel.BackColor = System.Drawing.SystemColors.Window;
            this.InfoLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InfoLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.InfoLabel.Enabled = false;
            this.InfoLabel.Font = new System.Drawing.Font("AR JULIAN", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoLabel.Location = new System.Drawing.Point(18, 11);
            this.InfoLabel.Multiline = true;
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.ReadOnly = true;
            this.InfoLabel.ShortcutsEnabled = false;
            this.InfoLabel.Size = new System.Drawing.Size(220, 58);
            this.InfoLabel.TabIndex = 4;
            this.InfoLabel.Text = "New Game";
            this.InfoLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.InfoLabel.TextChanged += new System.EventHandler(this.InfoLabel_TextChanged);
            // 
            // PointsPanel
            // 
            this.PointsPanel.Controls.Add(this.Person2Label);
            this.PointsPanel.Location = new System.Drawing.Point(3, 206);
            this.PointsPanel.Name = "PointsPanel";
            this.PointsPanel.Size = new System.Drawing.Size(246, 100);
            this.PointsPanel.TabIndex = 3;
            this.PointsPanel.Visible = false;
            // 
            // Person2Label
            // 
            this.Person2Label.AutoSize = true;
            this.Person2Label.Font = new System.Drawing.Font("AR JULIAN", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Person2Label.Location = new System.Drawing.Point(10, 65);
            this.Person2Label.Name = "Person2Label";
            this.Person2Label.Size = new System.Drawing.Size(188, 25);
            this.Person2Label.TabIndex = 8;
            this.Person2Label.Text = "Player  : 147 / 15";
            this.Person2Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Person1Label
            // 
            this.Person1Label.AutoSize = true;
            this.Person1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Person1Label.Location = new System.Drawing.Point(10, 40);
            this.Person1Label.Name = "Person1Label";
            this.Person1Label.Size = new System.Drawing.Size(161, 25);
            this.Person1Label.TabIndex = 3;
            this.Person1Label.Text = "Player   :  147/15";
            this.Person1Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DiceTimer
            // 
            this.DiceTimer.Interval = 2000;
            this.DiceTimer.Tick += new System.EventHandler(this.DiceTimer_Tick);
            // 
            // MoveTimer
            // 
            this.MoveTimer.Interval = 2000;
            this.MoveTimer.Tick += new System.EventHandler(this.MoveTimer_Tick);
            // 
            // MainGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(984, 581);
            this.Controls.Add(this.InfoPanel);
            this.Controls.Add(this.NewGameButton);
            this.Controls.Add(this.DiceButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = Backgammon_Game.Properties.Resources.backgam;
            this.MaximizeBox = false;
            this.Name = "MainGameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple Backgammon";
            this.Load += new System.EventHandler(this.MainGameFormLoad);
            this.InfoPanel.ResumeLayout(false);
            this.InfoPanel.PerformLayout();
            this.PointsPanel.ResumeLayout(false);
            this.PointsPanel.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Button DiceButton;
        private System.Windows.Forms.Label DiceLabel;
        private System.Windows.Forms.Button NewGameButton;
        private System.Windows.Forms.Panel InfoPanel;
        private System.Windows.Forms.Label Person2Label;
        private System.Windows.Forms.Label Person1Label;
        private System.Windows.Forms.Panel PointsPanel;
        private System.Windows.Forms.TextBox InfoLabel;
        private System.Windows.Forms.Timer DiceTimer;
        private System.Windows.Forms.Timer MoveTimer;

    }
}