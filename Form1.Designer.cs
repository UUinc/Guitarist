
namespace Guitarist
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
            this.Tabs_TB = new System.Windows.Forms.TextBox();
            this.GenerateBTN = new System.Windows.Forms.Button();
            this.TitleTXT = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Tabs_TB
            // 
            this.Tabs_TB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Tabs_TB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Tabs_TB.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tabs_TB.Location = new System.Drawing.Point(184, 80);
            this.Tabs_TB.MaximumSize = new System.Drawing.Size(876, 550);
            this.Tabs_TB.Multiline = true;
            this.Tabs_TB.Name = "Tabs_TB";
            this.Tabs_TB.Size = new System.Drawing.Size(438, 225);
            this.Tabs_TB.TabIndex = 0;
            // 
            // GenerateBTN
            // 
            this.GenerateBTN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GenerateBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GenerateBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GenerateBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GenerateBTN.Font = new System.Drawing.Font("Britannic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerateBTN.Location = new System.Drawing.Point(308, 342);
            this.GenerateBTN.Name = "GenerateBTN";
            this.GenerateBTN.Size = new System.Drawing.Size(198, 40);
            this.GenerateBTN.TabIndex = 1;
            this.GenerateBTN.Text = "Generate";
            this.GenerateBTN.UseVisualStyleBackColor = false;
            this.GenerateBTN.Click += new System.EventHandler(this.GenerateBTN_Click);
            // 
            // TitleTXT
            // 
            this.TitleTXT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TitleTXT.AutoSize = true;
            this.TitleTXT.Font = new System.Drawing.Font("Britannic Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleTXT.Location = new System.Drawing.Point(301, 9);
            this.TitleTXT.Name = "TitleTXT";
            this.TitleTXT.Size = new System.Drawing.Size(205, 53);
            this.TitleTXT.TabIndex = 2;
            this.TitleTXT.Text = "Guitarist";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 80);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 225);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(667, 80);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(90, 225);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TitleTXT);
            this.Controls.Add(this.GenerateBTN);
            this.Controls.Add(this.Tabs_TB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Guitarist";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Tabs_TB;
        private System.Windows.Forms.Button GenerateBTN;
        private System.Windows.Forms.Label TitleTXT;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

