namespace WindowsFormsApp1
{
    partial class gameGlav
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gameGlav));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.raketa = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.meteor1 = new System.Windows.Forms.PictureBox();
            this.meteor2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.meteor3 = new System.Windows.Forms.PictureBox();
            this.meteor4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raketa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meteor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meteor2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meteor3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meteor4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(806, 625);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // raketa
            // 
            this.raketa.BackColor = System.Drawing.Color.Transparent;
            this.raketa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.raketa.Image = ((System.Drawing.Image)(resources.GetObject("raketa.Image")));
            this.raketa.Location = new System.Drawing.Point(335, 450);
            this.raketa.Name = "raketa";
            this.raketa.Size = new System.Drawing.Size(104, 115);
            this.raketa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.raketa.TabIndex = 1;
            this.raketa.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, -625);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(800, 625);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // meteor1
            // 
            this.meteor1.Image = ((System.Drawing.Image)(resources.GetObject("meteor1.Image")));
            this.meteor1.Location = new System.Drawing.Point(91, -60);
            this.meteor1.Name = "meteor1";
            this.meteor1.Size = new System.Drawing.Size(65, 61);
            this.meteor1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.meteor1.TabIndex = 3;
            this.meteor1.TabStop = false;
            // 
            // meteor2
            // 
            this.meteor2.Image = ((System.Drawing.Image)(resources.GetObject("meteor2.Image")));
            this.meteor2.Location = new System.Drawing.Point(388, -90);
            this.meteor2.Name = "meteor2";
            this.meteor2.Size = new System.Drawing.Size(65, 61);
            this.meteor2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.meteor2.TabIndex = 4;
            this.meteor2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DarkMagenta;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(223, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(329, 377);
            this.panel1.TabIndex = 6;
            this.panel1.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Orange;
            this.label3.Location = new System.Drawing.Point(31, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 24);
            this.label3.TabIndex = 3;
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Orange;
            this.label2.Location = new System.Drawing.Point(31, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 24);
            this.label2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(117, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Перезапустить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.OrangeRed;
            this.label4.Location = new System.Drawing.Point(673, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 27);
            this.label4.TabIndex = 7;
            this.label4.Text = "label4";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(273, 310);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(39, 42);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(324, 83);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // meteor3
            // 
            this.meteor3.BackColor = System.Drawing.Color.Transparent;
            this.meteor3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.meteor3.Image = ((System.Drawing.Image)(resources.GetObject("meteor3.Image")));
            this.meteor3.Location = new System.Drawing.Point(625, -72);
            this.meteor3.Name = "meteor3";
            this.meteor3.Size = new System.Drawing.Size(100, 75);
            this.meteor3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.meteor3.TabIndex = 8;
            this.meteor3.TabStop = false;
            // 
            // meteor4
            // 
            this.meteor4.BackColor = System.Drawing.Color.Transparent;
            this.meteor4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.meteor4.Image = ((System.Drawing.Image)(resources.GetObject("meteor4.Image")));
            this.meteor4.Location = new System.Drawing.Point(251, -63);
            this.meteor4.Name = "meteor4";
            this.meteor4.Size = new System.Drawing.Size(130, 66);
            this.meteor4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.meteor4.TabIndex = 9;
            this.meteor4.TabStop = false;
            // 
            // gameGlav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 625);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.meteor4);
            this.Controls.Add(this.meteor3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.meteor2);
            this.Controls.Add(this.meteor1);
            this.Controls.Add(this.raketa);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "gameGlav";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "gameGlav";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameGlav_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raketa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meteor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meteor2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meteor3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meteor4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox raketa;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox meteor1;
        private System.Windows.Forms.PictureBox meteor2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox meteor3;
        private System.Windows.Forms.PictureBox meteor4;
    }
}