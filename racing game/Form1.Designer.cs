namespace racing_game
{
    partial class Form1
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
            this.Winlabel = new System.Windows.Forms.Label();
            this.Game_Timer = new System.Windows.Forms.Timer(this.components);
            this.titleLabel = new System.Windows.Forms.Label();
            this.SubtitleLabel = new System.Windows.Forms.Label();
            this.track2car1Lap = new System.Windows.Forms.Label();
            this.track2car2Lap = new System.Windows.Forms.Label();
            this.car1Lap = new System.Windows.Forms.Label();
            this.car2Lap = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Winlabel
            // 
            this.Winlabel.BackColor = System.Drawing.Color.Black;
            this.Winlabel.Font = new System.Drawing.Font("Sitka Small", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Winlabel.ForeColor = System.Drawing.Color.White;
            this.Winlabel.Location = new System.Drawing.Point(12, 9);
            this.Winlabel.Name = "Winlabel";
            this.Winlabel.Size = new System.Drawing.Size(976, 313);
            this.Winlabel.TabIndex = 5;
            this.Winlabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Winlabel.Visible = false;
            // 
            // Game_Timer
            // 
            this.Game_Timer.Interval = 20;
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.titleLabel.Location = new System.Drawing.Point(0, 342);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(999, 61);
            this.titleLabel.TabIndex = 6;
            this.titleLabel.Text = "TopDownRacing";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SubtitleLabel
            // 
            this.SubtitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.SubtitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubtitleLabel.ForeColor = System.Drawing.Color.Red;
            this.SubtitleLabel.Location = new System.Drawing.Point(0, 434);
            this.SubtitleLabel.Name = "SubtitleLabel";
            this.SubtitleLabel.Size = new System.Drawing.Size(999, 61);
            this.SubtitleLabel.TabIndex = 7;
            this.SubtitleLabel.Text = "Press Space to Play and Esc to Exit";
            this.SubtitleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // track2car1Lap
            // 
            this.track2car1Lap.BackColor = System.Drawing.Color.Black;
            this.track2car1Lap.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.track2car1Lap.ForeColor = System.Drawing.Color.Red;
            this.track2car1Lap.Location = new System.Drawing.Point(713, 618);
            this.track2car1Lap.Name = "track2car1Lap";
            this.track2car1Lap.Size = new System.Drawing.Size(36, 66);
            this.track2car1Lap.TabIndex = 8;
            this.track2car1Lap.Text = "1";
            this.track2car1Lap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.track2car1Lap.Visible = false;
            // 
            // track2car2Lap
            // 
            this.track2car2Lap.BackColor = System.Drawing.Color.Black;
            this.track2car2Lap.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.track2car2Lap.ForeColor = System.Drawing.Color.Red;
            this.track2car2Lap.Location = new System.Drawing.Point(787, 618);
            this.track2car2Lap.Name = "track2car2Lap";
            this.track2car2Lap.Size = new System.Drawing.Size(36, 66);
            this.track2car2Lap.TabIndex = 9;
            this.track2car2Lap.Text = "2";
            this.track2car2Lap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.track2car2Lap.Visible = false;
            // 
            // car1Lap
            // 
            this.car1Lap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.car1Lap.Font = new System.Drawing.Font("Microsoft YaHei", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.car1Lap.ForeColor = System.Drawing.Color.Red;
            this.car1Lap.Location = new System.Drawing.Point(66, 538);
            this.car1Lap.Name = "car1Lap";
            this.car1Lap.Size = new System.Drawing.Size(96, 146);
            this.car1Lap.TabIndex = 10;
            this.car1Lap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.car1Lap.Visible = false;
            // 
            // car2Lap
            // 
            this.car2Lap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.car2Lap.Font = new System.Drawing.Font("Microsoft YaHei", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.car2Lap.ForeColor = System.Drawing.Color.Red;
            this.car2Lap.Location = new System.Drawing.Point(250, 538);
            this.car2Lap.Name = "car2Lap";
            this.car2Lap.Size = new System.Drawing.Size(96, 146);
            this.car2Lap.TabIndex = 11;
            this.car2Lap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.car2Lap.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1000, 788);
            this.Controls.Add(this.car2Lap);
            this.Controls.Add(this.car1Lap);
            this.Controls.Add(this.track2car2Lap);
            this.Controls.Add(this.track2car1Lap);
            this.Controls.Add(this.SubtitleLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.Winlabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Winlabel;
        private System.Windows.Forms.Timer Game_Timer;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label SubtitleLabel;
        private System.Windows.Forms.Label track2car1Lap;
        private System.Windows.Forms.Label track2car2Lap;
        private System.Windows.Forms.Label car1Lap;
        private System.Windows.Forms.Label car2Lap;
    }
}

