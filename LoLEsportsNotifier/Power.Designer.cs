namespace LoLEsportsNotifier
{
    partial class Power
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
            this.next = new System.Windows.Forms.Button();
            this.open = new System.Windows.Forms.Button();
            this.prev = new System.Windows.Forms.Button();
            this.game = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.teams = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.Label();
            this.infoImage = new System.Windows.Forms.PictureBox();
            this.gameImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.infoImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameImage)).BeginInit();
            this.SuspendLayout();
            // 
            // next
            // 
            this.next.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.next.BackgroundImage = global::LoLEsportsNotifier.Properties.Resources.power_bg_leftright;
            this.next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.next.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next.ForeColor = System.Drawing.Color.Yellow;
            this.next.Location = new System.Drawing.Point(182, 234);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(55, 25);
            this.next.TabIndex = 37;
            this.next.Text = ">";
            this.next.UseVisualStyleBackColor = false;
            this.next.Click += new System.EventHandler(this.Next_Click);
            this.next.MouseEnter += new System.EventHandler(this.Next_MouseEnter);
            this.next.MouseLeave += new System.EventHandler(this.Next_MouseLeave);
            // 
            // open
            // 
            this.open.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.open.BackgroundImage = global::LoLEsportsNotifier.Properties.Resources.power_bg_open;
            this.open.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.open.Cursor = System.Windows.Forms.Cursors.Hand;
            this.open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.open.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.open.ForeColor = System.Drawing.Color.Chartreuse;
            this.open.Location = new System.Drawing.Point(73, 234);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(103, 25);
            this.open.TabIndex = 50;
            this.open.Text = "open";
            this.open.UseVisualStyleBackColor = false;
            this.open.Click += new System.EventHandler(this.Button1_Click);
            this.open.MouseEnter += new System.EventHandler(this.Open_MouseEnter);
            this.open.MouseLeave += new System.EventHandler(this.Open_MouseLeave);
            // 
            // prev
            // 
            this.prev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.prev.BackgroundImage = global::LoLEsportsNotifier.Properties.Resources.power_bg_leftright;
            this.prev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.prev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.prev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prev.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prev.ForeColor = System.Drawing.Color.Yellow;
            this.prev.Location = new System.Drawing.Point(12, 234);
            this.prev.Name = "prev";
            this.prev.Size = new System.Drawing.Size(55, 25);
            this.prev.TabIndex = 38;
            this.prev.Text = "<";
            this.prev.UseVisualStyleBackColor = false;
            this.prev.Click += new System.EventHandler(this.Prev_Click);
            this.prev.MouseEnter += new System.EventHandler(this.Prev_MouseEnter);
            this.prev.MouseLeave += new System.EventHandler(this.Prev_MouseLeave);
            // 
            // game
            // 
            this.game.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.game.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.game.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.game.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.game.Image = global::LoLEsportsNotifier.Properties.Resources.power_name_bg;
            this.game.Location = new System.Drawing.Point(12, 200);
            this.game.Name = "game";
            this.game.Size = new System.Drawing.Size(225, 25);
            this.game.TabIndex = 44;
            this.game.Text = "No Active Games";
            this.game.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // time
            // 
            this.time.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.time.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.time.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.time.Image = global::LoLEsportsNotifier.Properties.Resources.power_bg_info2;
            this.time.Location = new System.Drawing.Point(24, 62);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(204, 25);
            this.time.TabIndex = 54;
            this.time.Text = "Start Time";
            this.time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // status
            // 
            this.status.BackColor = System.Drawing.Color.Transparent;
            this.status.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.status.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.status.Image = global::LoLEsportsNotifier.Properties.Resources.power_bg_info1;
            this.status.Location = new System.Drawing.Point(24, 26);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(204, 25);
            this.status.TabIndex = 55;
            this.status.Text = "Status";
            this.status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // teams
            // 
            this.teams.BackColor = System.Drawing.Color.Transparent;
            this.teams.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.teams.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teams.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.teams.Image = global::LoLEsportsNotifier.Properties.Resources.power_bg_info3;
            this.teams.Location = new System.Drawing.Point(24, 98);
            this.teams.Name = "teams";
            this.teams.Size = new System.Drawing.Size(204, 25);
            this.teams.TabIndex = 56;
            this.teams.Text = "Teams";
            this.teams.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // type
            // 
            this.type.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.type.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.type.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.type.Image = global::LoLEsportsNotifier.Properties.Resources.power_bg_info4;
            this.type.Location = new System.Drawing.Point(24, 134);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(204, 25);
            this.type.TabIndex = 57;
            this.type.Text = "Type";
            this.type.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // infoImage
            // 
            this.infoImage.BackColor = System.Drawing.Color.Transparent;
            this.infoImage.BackgroundImage = global::LoLEsportsNotifier.Properties.Resources.power_bg_infox;
            this.infoImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.infoImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.infoImage.Image = global::LoLEsportsNotifier.Properties.Resources.more;
            this.infoImage.Location = new System.Drawing.Point(216, 166);
            this.infoImage.Name = "infoImage";
            this.infoImage.Size = new System.Drawing.Size(20, 20);
            this.infoImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.infoImage.TabIndex = 53;
            this.infoImage.TabStop = false;
            this.infoImage.Click += new System.EventHandler(this.InfoImage_Click);
            // 
            // gameImage
            // 
            this.gameImage.BackColor = System.Drawing.Color.Transparent;
            this.gameImage.BackgroundImage = global::LoLEsportsNotifier.Properties.Resources.power_pic_bg;
            this.gameImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gameImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gameImage.Image = global::LoLEsportsNotifier.Properties.Resources.transparent;
            this.gameImage.Location = new System.Drawing.Point(13, 12);
            this.gameImage.Name = "gameImage";
            this.gameImage.Size = new System.Drawing.Size(224, 175);
            this.gameImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gameImage.TabIndex = 49;
            this.gameImage.TabStop = false;
            // 
            // Power
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(72)))), ((int)(((byte)(87)))));
            this.BackgroundImage = global::LoLEsportsNotifier.Properties.Resources.power_bg;
            this.ClientSize = new System.Drawing.Size(250, 270);
            this.Controls.Add(this.infoImage);
            this.Controls.Add(this.gameImage);
            this.Controls.Add(this.type);
            this.Controls.Add(this.teams);
            this.Controls.Add(this.status);
            this.Controls.Add(this.time);
            this.Controls.Add(this.game);
            this.Controls.Add(this.next);
            this.Controls.Add(this.open);
            this.Controls.Add(this.prev);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Power";
            this.Text = "Power";
            this.Load += new System.EventHandler(this.Power_Load);
            ((System.ComponentModel.ISupportInitialize)(this.infoImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Button open;
        private System.Windows.Forms.Button prev;
        private System.Windows.Forms.PictureBox gameImage;
        private System.Windows.Forms.Label game;
        private System.Windows.Forms.PictureBox infoImage;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label teams;
        private System.Windows.Forms.Label type;
    }
}