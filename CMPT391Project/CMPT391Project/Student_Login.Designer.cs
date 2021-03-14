namespace CMPT391Project
{
    partial class Student_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student_Login));
            this.login_input = new System.Windows.Forms.TextBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.login_button = new System.Windows.Forms.Button();
            this.studentID_label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.shameText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // login_input
            // 
            this.login_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_input.Location = new System.Drawing.Point(635, 614);
            this.login_input.Name = "login_input";
            this.login_input.Size = new System.Drawing.Size(296, 32);
            this.login_input.TabIndex = 2;
            this.login_input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Login_input_KeyPress);
            // 
            // Logo
            // 
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.InitialImage = ((System.Drawing.Image)(resources.GetObject("Logo.InitialImage")));
            this.Logo.Location = new System.Drawing.Point(291, 216);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(921, 266);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Logo.TabIndex = 1;
            this.Logo.TabStop = false;
            // 
            // login_button
            // 
            this.login_button.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.login_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_button.ForeColor = System.Drawing.SystemColors.Control;
            this.login_button.Location = new System.Drawing.Point(683, 691);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(131, 47);
            this.login_button.TabIndex = 3;
            this.login_button.Text = "Login";
            this.login_button.UseVisualStyleBackColor = false;
            this.login_button.Click += new System.EventHandler(this.Button1_Click);
            // 
            // studentID_label
            // 
            this.studentID_label.AutoSize = true;
            this.studentID_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentID_label.Location = new System.Drawing.Point(505, 615);
            this.studentID_label.Name = "studentID_label";
            this.studentID_label.Size = new System.Drawing.Size(124, 29);
            this.studentID_label.TabIndex = 4;
            this.studentID_label.Text = "Student ID";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(640, 776);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 193);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // shameText
            // 
            this.shameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shameText.Location = new System.Drawing.Point(496, 649);
            this.shameText.Name = "shameText";
            this.shameText.Size = new System.Drawing.Size(520, 43);
            this.shameText.TabIndex = 6;
            this.shameText.Text = "Shame Text";
            this.shameText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.shameText.Visible = false;
            this.shameText.Click += new System.EventHandler(this.shameText_Click);
            // 
            // Student_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1484, 961);
            this.Controls.Add(this.shameText);
            this.Controls.Add(this.studentID_label);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.login_input);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Student_Login";
            this.Text = "Student Login";
            this.Load += new System.EventHandler(this.Student_Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Label studentID_label;
        private System.Windows.Forms.TextBox login_input;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label shameText;
    }
}