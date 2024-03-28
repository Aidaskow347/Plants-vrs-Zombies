namespace Plant
{
    partial class StatScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.statButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.statLabel = new System.Windows.Forms.Label();
            this.survivalTimeLabel = new System.Windows.Forms.Label();
            this.sunCollectedLabel = new System.Windows.Forms.Label();
            this.sunSpentLabel = new System.Windows.Forms.Label();
            this.zombiesKilledLabel = new System.Windows.Forms.Label();
            this.plantsPlacedLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // statButton
            // 
            this.statButton.BackColor = System.Drawing.Color.Transparent;
            this.statButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.statButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.statButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LawnGreen;
            this.statButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statButton.Location = new System.Drawing.Point(409, 529);
            this.statButton.Name = "statButton";
            this.statButton.Size = new System.Drawing.Size(202, 63);
            this.statButton.TabIndex = 4;
            this.statButton.Text = "Close Stats";
            this.statButton.UseVisualStyleBackColor = false;
            this.statButton.Click += new System.EventHandler(this.statButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(297, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(430, 506);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // exitButton
            // 
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.exitButton.Location = new System.Drawing.Point(841, 605);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(183, 59);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // statLabel
            // 
            this.statLabel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.statLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.statLabel.Location = new System.Drawing.Point(297, 45);
            this.statLabel.Name = "statLabel";
            this.statLabel.Size = new System.Drawing.Size(430, 32);
            this.statLabel.TabIndex = 9;
            this.statLabel.Text = "Statistics";
            this.statLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // survivalTimeLabel
            // 
            this.survivalTimeLabel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.survivalTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.survivalTimeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.survivalTimeLabel.Location = new System.Drawing.Point(358, 130);
            this.survivalTimeLabel.Name = "survivalTimeLabel";
            this.survivalTimeLabel.Size = new System.Drawing.Size(290, 32);
            this.survivalTimeLabel.TabIndex = 10;
            this.survivalTimeLabel.Text = "Time Survived:";
            this.survivalTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sunCollectedLabel
            // 
            this.sunCollectedLabel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.sunCollectedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sunCollectedLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sunCollectedLabel.Location = new System.Drawing.Point(358, 189);
            this.sunCollectedLabel.Name = "sunCollectedLabel";
            this.sunCollectedLabel.Size = new System.Drawing.Size(290, 32);
            this.sunCollectedLabel.TabIndex = 11;
            this.sunCollectedLabel.Text = "Sun Collected:";
            this.sunCollectedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sunSpentLabel
            // 
            this.sunSpentLabel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.sunSpentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sunSpentLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sunSpentLabel.Location = new System.Drawing.Point(358, 249);
            this.sunSpentLabel.Name = "sunSpentLabel";
            this.sunSpentLabel.Size = new System.Drawing.Size(290, 32);
            this.sunSpentLabel.TabIndex = 12;
            this.sunSpentLabel.Text = "Sun Spent:";
            this.sunSpentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // zombiesKilledLabel
            // 
            this.zombiesKilledLabel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.zombiesKilledLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zombiesKilledLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.zombiesKilledLabel.Location = new System.Drawing.Point(358, 307);
            this.zombiesKilledLabel.Name = "zombiesKilledLabel";
            this.zombiesKilledLabel.Size = new System.Drawing.Size(290, 32);
            this.zombiesKilledLabel.TabIndex = 13;
            this.zombiesKilledLabel.Text = "Zombies Killed:";
            this.zombiesKilledLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // plantsPlacedLabel
            // 
            this.plantsPlacedLabel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.plantsPlacedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plantsPlacedLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.plantsPlacedLabel.Location = new System.Drawing.Point(358, 362);
            this.plantsPlacedLabel.Name = "plantsPlacedLabel";
            this.plantsPlacedLabel.Size = new System.Drawing.Size(290, 32);
            this.plantsPlacedLabel.TabIndex = 14;
            this.plantsPlacedLabel.Text = "Plants Placed:";
            this.plantsPlacedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StatScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Plant.Properties.Resources.pvzMenuScreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.plantsPlacedLabel);
            this.Controls.Add(this.zombiesKilledLabel);
            this.Controls.Add(this.sunSpentLabel);
            this.Controls.Add(this.sunCollectedLabel);
            this.Controls.Add(this.survivalTimeLabel);
            this.Controls.Add(this.statLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statButton);
            this.DoubleBuffered = true;
            this.Name = "StatScreen";
            this.Size = new System.Drawing.Size(1024, 667);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button statButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label statLabel;
        private System.Windows.Forms.Label survivalTimeLabel;
        private System.Windows.Forms.Label sunCollectedLabel;
        private System.Windows.Forms.Label sunSpentLabel;
        private System.Windows.Forms.Label zombiesKilledLabel;
        private System.Windows.Forms.Label plantsPlacedLabel;
    }
}
