namespace CMPT391Project
{
    partial class Cart
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cart));
            this.label1 = new System.Windows.Forms.Label();
            this.Cart_View = new System.Windows.Forms.DataGridView();
            this.Register_Button = new System.Windows.Forms.Button();
            this.Error_Text = new System.Windows.Forms.Label();
            this.Delete_Course_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Cart_View)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(162)))), ((int)(((byte)(171)))));
            this.label1.Location = new System.Drawing.Point(448, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 73);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cart";
            // 
            // Cart_View
            // 
            this.Cart_View.AllowUserToAddRows = false;
            this.Cart_View.AllowUserToDeleteRows = false;
            this.Cart_View.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Cart_View.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Cart_View.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Cart_View.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(198)))), ((int)(((byte)(235)))));
            this.Cart_View.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(229)))), ((int)(((byte)(171)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(89)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Cart_View.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Cart_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Cart_View.DefaultCellStyle = dataGridViewCellStyle2;
            this.Cart_View.Location = new System.Drawing.Point(8, 112);
            this.Cart_View.Name = "Cart_View";
            this.Cart_View.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Cart_View.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Cart_View.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Cart_View.ShowEditingIcon = false;
            this.Cart_View.Size = new System.Drawing.Size(984, 519);
            this.Cart_View.TabIndex = 7;
            // 
            // Register_Button
            // 
            this.Register_Button.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Register_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(138)))), ((int)(((byte)(129)))));
            this.Register_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Register_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(214)))), ((int)(((byte)(160)))));
            this.Register_Button.Location = new System.Drawing.Point(392, 800);
            this.Register_Button.Name = "Register_Button";
            this.Register_Button.Size = new System.Drawing.Size(242, 65);
            this.Register_Button.TabIndex = 8;
            this.Register_Button.Text = "Register";
            this.Register_Button.UseVisualStyleBackColor = false;
            this.Register_Button.Click += new System.EventHandler(this.Register_Button_Click);
            // 
            // Error_Text
            // 
            this.Error_Text.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Error_Text.AutoSize = true;
            this.Error_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Error_Text.ForeColor = System.Drawing.Color.Red;
            this.Error_Text.Location = new System.Drawing.Point(8, 640);
            this.Error_Text.Name = "Error_Text";
            this.Error_Text.Size = new System.Drawing.Size(76, 25);
            this.Error_Text.TabIndex = 9;
            this.Error_Text.Text = "label2";
            this.Error_Text.Visible = false;
            // 
            // Delete_Course_Button
            // 
            this.Delete_Course_Button.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Delete_Course_Button.BackColor = System.Drawing.Color.Maroon;
            this.Delete_Course_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_Course_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_Course_Button.ForeColor = System.Drawing.Color.White;
            this.Delete_Course_Button.Location = new System.Drawing.Point(744, 640);
            this.Delete_Course_Button.Name = "Delete_Course_Button";
            this.Delete_Course_Button.Size = new System.Drawing.Size(245, 65);
            this.Delete_Course_Button.TabIndex = 10;
            this.Delete_Course_Button.Text = "Delete Course";
            this.Delete_Course_Button.UseVisualStyleBackColor = false;
            this.Delete_Course_Button.Click += new System.EventHandler(this.Delete_Course_Button_Click);
            // 
            // Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1001, 878);
            this.Controls.Add(this.Delete_Course_Button);
            this.Controls.Add(this.Error_Text);
            this.Controls.Add(this.Register_Button);
            this.Controls.Add(this.Cart_View);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cart";
            this.Text = "Cart";
            ((System.ComponentModel.ISupportInitialize)(this.Cart_View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Cart_View;
        private System.Windows.Forms.Button Register_Button;
        private System.Windows.Forms.Label Error_Text;
        private System.Windows.Forms.Button Delete_Course_Button;
    }
}