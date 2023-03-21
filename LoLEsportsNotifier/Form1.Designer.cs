namespace LoLEsportsNotifier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.form_panel = new System.Windows.Forms.Panel();
            this.bgw = new System.ComponentModel.BackgroundWorker();
            this.settings_box = new System.Windows.Forms.PictureBox();
            this.power_box = new System.Windows.Forms.PictureBox();
            this.rgb_bar = new System.Windows.Forms.PictureBox();
            this.top_bar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.settings_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.power_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgb_bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.top_bar)).BeginInit();
            this.SuspendLayout();
            // 
            // form_panel
            // 
            this.form_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.form_panel.Location = new System.Drawing.Point(0, 80);
            this.form_panel.Name = "form_panel";
            this.form_panel.Size = new System.Drawing.Size(250, 270);
            this.form_panel.TabIndex = 21;
            // 
            // bgw
            // 
            this.bgw.WorkerSupportsCancellation = true;
            this.bgw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Bgw_DoWork);
            // 
            // settings_box
            // 
            this.settings_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(72)))), ((int)(((byte)(87)))));
            this.settings_box.BackgroundImage = global::LoLEsportsNotifier.Properties.Resources.top_bg_right;
            this.settings_box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.settings_box.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settings_box.Image = global::LoLEsportsNotifier.Properties.Resources.settings;
            this.settings_box.Location = new System.Drawing.Point(125, 0);
            this.settings_box.Name = "settings_box";
            this.settings_box.Size = new System.Drawing.Size(125, 60);
            this.settings_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.settings_box.TabIndex = 24;
            this.settings_box.TabStop = false;
            this.settings_box.Click += new System.EventHandler(this.Settings_box_Click);
            this.settings_box.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Settings_box_MouseDown);
            // 
            // power_box
            // 
            this.power_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(72)))), ((int)(((byte)(87)))));
            this.power_box.BackgroundImage = global::LoLEsportsNotifier.Properties.Resources.top_bg_left;
            this.power_box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.power_box.Cursor = System.Windows.Forms.Cursors.Hand;
            this.power_box.Image = global::LoLEsportsNotifier.Properties.Resources.shutdown;
            this.power_box.Location = new System.Drawing.Point(0, 0);
            this.power_box.Name = "power_box";
            this.power_box.Size = new System.Drawing.Size(125, 60);
            this.power_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.power_box.TabIndex = 23;
            this.power_box.TabStop = false;
            this.power_box.Click += new System.EventHandler(this.Power_box_Click);
            this.power_box.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Power_box_MouseDown);
            // 
            // rgb_bar
            // 
            this.rgb_bar.Dock = System.Windows.Forms.DockStyle.Top;
            this.rgb_bar.Image = global::LoLEsportsNotifier.Properties.Resources.rgb;
            this.rgb_bar.Location = new System.Drawing.Point(0, 60);
            this.rgb_bar.Name = "rgb_bar";
            this.rgb_bar.Size = new System.Drawing.Size(250, 1);
            this.rgb_bar.TabIndex = 22;
            this.rgb_bar.TabStop = false;
            // 
            // top_bar
            // 
            this.top_bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(72)))), ((int)(((byte)(87)))));
            this.top_bar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.top_bar.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_bar.Location = new System.Drawing.Point(0, 0);
            this.top_bar.Name = "top_bar";
            this.top_bar.Size = new System.Drawing.Size(250, 60);
            this.top_bar.TabIndex = 19;
            this.top_bar.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(250, 350);
            this.Controls.Add(this.settings_box);
            this.Controls.Add(this.power_box);
            this.Controls.Add(this.rgb_bar);
            this.Controls.Add(this.form_panel);
            this.Controls.Add(this.top_bar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Lime;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.settings_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.power_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgb_bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.top_bar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox top_bar;
        private System.Windows.Forms.Panel form_panel;
        private System.Windows.Forms.PictureBox rgb_bar;
        private System.Windows.Forms.PictureBox settings_box;
        private System.Windows.Forms.PictureBox power_box;
        public System.ComponentModel.BackgroundWorker bgw;
    }
}

