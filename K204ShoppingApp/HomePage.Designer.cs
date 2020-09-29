namespace K204ShoppingApp
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRegisterHome = new System.Windows.Forms.Button();
            this.btnLoginHome = new System.Windows.Forms.Button();
            this.pbFormClose = new System.Windows.Forms.PictureBox();
            this.pcFormMinimize = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFormClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcFormMinimize)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(45, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(592, 231);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnRegisterHome
            // 
            this.btnRegisterHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRegisterHome.BackColor = System.Drawing.Color.ForestGreen;
            this.btnRegisterHome.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterHome.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnRegisterHome.Location = new System.Drawing.Point(45, 360);
            this.btnRegisterHome.Name = "btnRegisterHome";
            this.btnRegisterHome.Size = new System.Drawing.Size(189, 74);
            this.btnRegisterHome.TabIndex = 1;
            this.btnRegisterHome.Text = "Register";
            this.btnRegisterHome.UseVisualStyleBackColor = false;
            this.btnRegisterHome.Click += new System.EventHandler(this.btnRegisterHome_Click);
            // 
            // btnLoginHome
            // 
            this.btnLoginHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoginHome.BackColor = System.Drawing.Color.Orange;
            this.btnLoginHome.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginHome.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnLoginHome.Location = new System.Drawing.Point(448, 360);
            this.btnLoginHome.Name = "btnLoginHome";
            this.btnLoginHome.Size = new System.Drawing.Size(189, 74);
            this.btnLoginHome.TabIndex = 2;
            this.btnLoginHome.Text = "Login";
            this.btnLoginHome.UseVisualStyleBackColor = false;
            this.btnLoginHome.Click += new System.EventHandler(this.btnLoginHome_Click);
            // 
            // pbFormClose
            // 
            this.pbFormClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbFormClose.Image = ((System.Drawing.Image)(resources.GetObject("pbFormClose.Image")));
            this.pbFormClose.Location = new System.Drawing.Point(645, 9);
            this.pbFormClose.Name = "pbFormClose";
            this.pbFormClose.Size = new System.Drawing.Size(34, 30);
            this.pbFormClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFormClose.TabIndex = 3;
            this.pbFormClose.TabStop = false;
            this.pbFormClose.Click += new System.EventHandler(this.pbFormClose_Click);
            // 
            // pcFormMinimize
            // 
            this.pcFormMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcFormMinimize.Image = ((System.Drawing.Image)(resources.GetObject("pcFormMinimize.Image")));
            this.pcFormMinimize.Location = new System.Drawing.Point(608, 18);
            this.pcFormMinimize.Name = "pcFormMinimize";
            this.pcFormMinimize.Size = new System.Drawing.Size(31, 28);
            this.pcFormMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcFormMinimize.TabIndex = 4;
            this.pcFormMinimize.TabStop = false;
            this.pcFormMinimize.Click += new System.EventHandler(this.pcFormMinimize_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(688, 446);
            this.Controls.Add(this.pcFormMinimize);
            this.Controls.Add(this.pbFormClose);
            this.Controls.Add(this.btnLoginHome);
            this.Controls.Add(this.btnRegisterHome);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home Page";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFormClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcFormMinimize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRegisterHome;
        private System.Windows.Forms.Button btnLoginHome;
        private System.Windows.Forms.PictureBox pbFormClose;
        private System.Windows.Forms.PictureBox pcFormMinimize;
    }
}

