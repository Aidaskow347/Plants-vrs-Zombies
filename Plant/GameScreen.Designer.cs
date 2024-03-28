namespace Plant
{
    partial class S
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(S));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.slotBox4 = new System.Windows.Forms.PictureBox();
            this.slotBox3 = new System.Windows.Forms.PictureBox();
            this.SlotBox2 = new System.Windows.Forms.PictureBox();
            this.SlotBox1 = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.moneyLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.shootTimer = new System.Windows.Forms.Timer(this.components);
            this.displayLabel = new System.Windows.Forms.Label();
            this.sunTimer = new System.Windows.Forms.Timer(this.components);
            this.sunFlowerTimer = new System.Windows.Forms.Timer(this.components);
            this.zombieTimer = new System.Windows.Forms.Timer(this.components);
            this.zombieSpawn = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slotBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slotBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SlotBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SlotBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(98)))), ((int)(((byte)(15)))));
            this.pictureBox1.Location = new System.Drawing.Point(462, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 70);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // slotBox4
            // 
            this.slotBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(98)))), ((int)(((byte)(15)))));
            this.slotBox4.Location = new System.Drawing.Point(356, 5);
            this.slotBox4.Name = "slotBox4";
            this.slotBox4.Size = new System.Drawing.Size(100, 70);
            this.slotBox4.TabIndex = 3;
            this.slotBox4.TabStop = false;
            // 
            // slotBox3
            // 
            this.slotBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(98)))), ((int)(((byte)(15)))));
            this.slotBox3.Location = new System.Drawing.Point(250, 5);
            this.slotBox3.Name = "slotBox3";
            this.slotBox3.Size = new System.Drawing.Size(100, 70);
            this.slotBox3.TabIndex = 2;
            this.slotBox3.TabStop = false;
            // 
            // SlotBox2
            // 
            this.SlotBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(98)))), ((int)(((byte)(15)))));
            this.SlotBox2.BackgroundImage = global::Plant.Properties.Resources.sunFlower;
            this.SlotBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SlotBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SlotBox2.Location = new System.Drawing.Point(144, 5);
            this.SlotBox2.Name = "SlotBox2";
            this.SlotBox2.Size = new System.Drawing.Size(100, 70);
            this.SlotBox2.TabIndex = 1;
            this.SlotBox2.TabStop = false;
            this.SlotBox2.Click += new System.EventHandler(this.SlotBox2_Click);
            // 
            // SlotBox1
            // 
            this.SlotBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(98)))), ((int)(((byte)(15)))));
            this.SlotBox1.BackgroundImage = global::Plant.Properties.Resources.peaShooter;
            this.SlotBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SlotBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SlotBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SlotBox1.Location = new System.Drawing.Point(38, 5);
            this.SlotBox1.Name = "SlotBox1";
            this.SlotBox1.Size = new System.Drawing.Size(100, 70);
            this.SlotBox1.TabIndex = 0;
            this.SlotBox1.TabStop = false;
            this.SlotBox1.Click += new System.EventHandler(this.slotBox1_Click);
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // moneyLabel
            // 
            this.moneyLabel.BackColor = System.Drawing.Color.Transparent;
            this.moneyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moneyLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.moneyLabel.Location = new System.Drawing.Point(568, 8);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.Size = new System.Drawing.Size(213, 32);
            this.moneyLabel.TabIndex = 8;
            this.moneyLabel.Text = "Sun Value: 0";
            this.moneyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timeLabel
            // 
            this.timeLabel.BackColor = System.Drawing.Color.Transparent;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.timeLabel.Location = new System.Drawing.Point(787, 8);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(237, 32);
            this.timeLabel.TabIndex = 9;
            this.timeLabel.Text = "Time Survived:";
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // shootTimer
            // 
            this.shootTimer.Enabled = true;
            this.shootTimer.Interval = 2000;
            this.shootTimer.Tick += new System.EventHandler(this.shootTimer_Tick);
            // 
            // displayLabel
            // 
            this.displayLabel.BackColor = System.Drawing.Color.Transparent;
            this.displayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayLabel.ForeColor = System.Drawing.Color.Red;
            this.displayLabel.Location = new System.Drawing.Point(568, 43);
            this.displayLabel.Name = "displayLabel";
            this.displayLabel.Size = new System.Drawing.Size(432, 32);
            this.displayLabel.TabIndex = 11;
            this.displayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sunTimer
            // 
            this.sunTimer.Enabled = true;
            this.sunTimer.Interval = 10000;
            this.sunTimer.Tick += new System.EventHandler(this.sunTimer_Tick);
            // 
            // sunFlowerTimer
            // 
            this.sunFlowerTimer.Enabled = true;
            this.sunFlowerTimer.Interval = 15000;
            this.sunFlowerTimer.Tick += new System.EventHandler(this.sunFlowerTimer_Tick);
            // 
            // zombieTimer
            // 
            this.zombieTimer.Enabled = true;
            this.zombieTimer.Interval = 500;
            this.zombieTimer.Tick += new System.EventHandler(this.zombieTimer_Tick);
            // 
            // zombieSpawn
            // 
            this.zombieSpawn.Enabled = true;
            this.zombieSpawn.Interval = 30000;
            this.zombieSpawn.Tick += new System.EventHandler(this.zombieSpawn_Tick);
            // 
            // S
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(80)))), ((int)(((byte)(15)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.displayLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.moneyLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.slotBox4);
            this.Controls.Add(this.slotBox3);
            this.Controls.Add(this.SlotBox2);
            this.Controls.Add(this.SlotBox1);
            this.DoubleBuffered = true;
            this.Name = "S";
            this.Size = new System.Drawing.Size(1024, 667);
            this.Click += new System.EventHandler(this.GameScreen_Click);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameScreen_Paint);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GameScreen_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slotBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slotBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SlotBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SlotBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox SlotBox1;
        private System.Windows.Forms.PictureBox SlotBox2;
        private System.Windows.Forms.PictureBox slotBox3;
        private System.Windows.Forms.PictureBox slotBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label moneyLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Timer shootTimer;
        private System.Windows.Forms.Label displayLabel;
        private System.Windows.Forms.Timer sunTimer;
        private System.Windows.Forms.Timer sunFlowerTimer;
        private System.Windows.Forms.Timer zombieTimer;
        private System.Windows.Forms.Timer zombieSpawn;
    }
}
