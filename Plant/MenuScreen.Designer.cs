namespace Plant
{
    partial class MenuScreen
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
            this.startButton = new System.Windows.Forms.Button();
            this.drawButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.statButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.Transparent;
            this.startButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.startButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LawnGreen;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(400, 372);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(220, 73);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start Game";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // drawButton
            // 
            this.drawButton.BackColor = System.Drawing.Color.LawnGreen;
            this.drawButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.drawButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.drawButton.Location = new System.Drawing.Point(400, 451);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(220, 72);
            this.drawButton.TabIndex = 1;
            this.drawButton.Text = "Draw Images: On";
            this.drawButton.UseVisualStyleBackColor = false;
            this.drawButton.Click += new System.EventHandler(this.drawButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.exitButton.Location = new System.Drawing.Point(841, 605);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(183, 59);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
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
            this.statButton.TabIndex = 3;
            this.statButton.Text = "View Stats";
            this.statButton.UseVisualStyleBackColor = false;
            this.statButton.Click += new System.EventHandler(this.statButton_Click);
            // 
            // MenuScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Plant.Properties.Resources.pvzMenuScreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.statButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.drawButton);
            this.Controls.Add(this.startButton);
            this.DoubleBuffered = true;
            this.Name = "MenuScreen";
            this.Size = new System.Drawing.Size(1024, 667);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button drawButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button statButton;
    }
}
