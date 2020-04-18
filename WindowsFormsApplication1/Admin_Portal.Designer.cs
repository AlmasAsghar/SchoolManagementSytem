namespace WindowsFormsApplication1
{
    partial class Admin_Portal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Portal));
            this.button8 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.Logout_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(77, 234);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(390, 45);
            this.button8.TabIndex = 55;
            this.button8.Text = "Principal\'s Info";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(77, 81);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(390, 45);
            this.button12.TabIndex = 54;
            this.button12.Text = "Student\'s Info";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(77, 183);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(390, 45);
            this.button9.TabIndex = 52;
            this.button9.Text = "Non-Teaching Staff\'s Info";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(77, 132);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(390, 45);
            this.button10.TabIndex = 51;
            this.button10.Text = "Teaching Staff\'s Info";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button24
            // 
            this.button24.BackColor = System.Drawing.Color.Transparent;
            this.button24.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button24.Location = new System.Drawing.Point(77, 30);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(390, 45);
            this.button24.TabIndex = 57;
            this.button24.Text = "Class Info";
            this.button24.UseVisualStyleBackColor = false;
            this.button24.Click += new System.EventHandler(this.button24_Click);
            // 
            // Logout_Button
            // 
            this.Logout_Button.Location = new System.Drawing.Point(239, 301);
            this.Logout_Button.Name = "Logout_Button";
            this.Logout_Button.Size = new System.Drawing.Size(75, 23);
            this.Logout_Button.TabIndex = 58;
            this.Logout_Button.Text = "Logout";
            this.Logout_Button.UseVisualStyleBackColor = true;
            this.Logout_Button.Click += new System.EventHandler(this.Logout_Button_Click);
            // 
            // Admin_Portal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(554, 336);
            this.Controls.Add(this.Logout_Button);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.MaximumSize = new System.Drawing.Size(570, 375);
            this.MinimumSize = new System.Drawing.Size(570, 375);
            this.Name = "Admin_Portal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_Portal";
            this.Load += new System.EventHandler(this.Admin_Portal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button Logout_Button;
    }
}