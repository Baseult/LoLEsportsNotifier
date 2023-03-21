namespace LoLEsportsNotifier
{
    partial class Settings
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
            this.notifications = new System.Windows.Forms.Label();
            this.notificationBox = new System.Windows.Forms.CheckBox();
            this.checkSeconds = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.minimize = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.checkSeconds)).BeginInit();
            this.SuspendLayout();
            // 
            // notifications
            // 
            this.notifications.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.notifications.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.notifications.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notifications.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.notifications.Image = global::LoLEsportsNotifier.Properties.Resources.settings_1;
            this.notifications.Location = new System.Drawing.Point(12, 12);
            this.notifications.Name = "notifications";
            this.notifications.Size = new System.Drawing.Size(226, 25);
            this.notifications.TabIndex = 45;
            this.notifications.Text = "Get Desktop Notifications:";
            this.notifications.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // notificationBox
            // 
            this.notificationBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.notificationBox.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.notificationBox.Checked = true;
            this.notificationBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.notificationBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.notificationBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.notificationBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notificationBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.notificationBox.Location = new System.Drawing.Point(216, 16);
            this.notificationBox.Name = "notificationBox";
            this.notificationBox.Size = new System.Drawing.Size(20, 18);
            this.notificationBox.TabIndex = 46;
            this.notificationBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.notificationBox.UseVisualStyleBackColor = false;
            this.notificationBox.CheckedChanged += new System.EventHandler(this.NotificationBox_CheckedChanged);
            // 
            // checkSeconds
            // 
            this.checkSeconds.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.checkSeconds.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.checkSeconds.ForeColor = System.Drawing.Color.White;
            this.checkSeconds.Location = new System.Drawing.Point(12, 71);
            this.checkSeconds.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.checkSeconds.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.checkSeconds.Name = "checkSeconds";
            this.checkSeconds.Size = new System.Drawing.Size(226, 20);
            this.checkSeconds.TabIndex = 47;
            this.checkSeconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.checkSeconds.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.checkSeconds.ValueChanged += new System.EventHandler(this.CheckSeconds_ValueChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Image = global::LoLEsportsNotifier.Properties.Resources.settings_2;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 25);
            this.label1.TabIndex = 48;
            this.label1.Text = "Check every X Seconds for Streams:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Image = global::LoLEsportsNotifier.Properties.Resources.paypal;
            this.button1.Location = new System.Drawing.Point(82, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 66);
            this.button1.TabIndex = 49;
            this.button1.Text = "Donate";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Red;
            this.close.BackgroundImage = global::LoLEsportsNotifier.Properties.Resources.close;
            this.close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.close.Location = new System.Drawing.Point(133, 113);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(40, 40);
            this.close.TabIndex = 50;
            this.close.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.Close_Click);
            // 
            // minimize
            // 
            this.minimize.BackColor = System.Drawing.Color.Cyan;
            this.minimize.BackgroundImage = global::LoLEsportsNotifier.Properties.Resources.minimize;
            this.minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.minimize.Location = new System.Drawing.Point(82, 113);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(40, 40);
            this.minimize.TabIndex = 51;
            this.minimize.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.minimize.UseVisualStyleBackColor = false;
            this.minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(72)))), ((int)(((byte)(87)))));
            this.BackgroundImage = global::LoLEsportsNotifier.Properties.Resources.settings_31;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(250, 270);
            this.Controls.Add(this.minimize);
            this.Controls.Add(this.close);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkSeconds);
            this.Controls.Add(this.notificationBox);
            this.Controls.Add(this.notifications);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Settings";
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.checkSeconds)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label notifications;
        private System.Windows.Forms.CheckBox notificationBox;
        private System.Windows.Forms.NumericUpDown checkSeconds;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button minimize;
    }
}