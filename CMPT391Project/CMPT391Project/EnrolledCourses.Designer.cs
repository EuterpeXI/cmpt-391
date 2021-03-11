namespace CMPT391Project
{
    partial class EnrolledCourses
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.enrolledCoursesDataGridView1 = new System.Windows.Forms.DataGridView();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.termDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkEnrolledBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.enrolledCoursesDataSet = new CMPT391Project.EnrolledCoursesDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Cart_Button = new System.Windows.Forms.Button();
            this.Back_Button = new System.Windows.Forms.Button();
            this.checkEnrolledTableAdapter = new CMPT391Project.EnrolledCoursesDataSetTableAdapters.checkEnrolledTableAdapter();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.studentIDToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.studentIDToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.enrolledCoursesDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEnrolledBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enrolledCoursesDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.fillToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(468, 78);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enrolled Courses";
            // 
            // enrolledCoursesDataGridView1
            // 
            this.enrolledCoursesDataGridView1.AllowUserToAddRows = false;
            this.enrolledCoursesDataGridView1.AllowUserToDeleteRows = false;
            this.enrolledCoursesDataGridView1.AutoGenerateColumns = false;
            this.enrolledCoursesDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.enrolledCoursesDataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.enrolledCoursesDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.enrolledCoursesDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.enrolledCoursesDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn,
            this.creditDataGridViewTextBoxColumn,
            this.termDataGridViewTextBoxColumn,
            this.departmentDataGridViewTextBoxColumn});
            this.enrolledCoursesDataGridView1.DataSource = this.checkEnrolledBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.enrolledCoursesDataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.enrolledCoursesDataGridView1.Location = new System.Drawing.Point(32, 168);
            this.enrolledCoursesDataGridView1.Name = "enrolledCoursesDataGridView1";
            this.enrolledCoursesDataGridView1.ReadOnly = true;
            this.enrolledCoursesDataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.enrolledCoursesDataGridView1.Size = new System.Drawing.Size(720, 720);
            this.enrolledCoursesDataGridView1.TabIndex = 8;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // creditDataGridViewTextBoxColumn
            // 
            this.creditDataGridViewTextBoxColumn.DataPropertyName = "credit";
            this.creditDataGridViewTextBoxColumn.HeaderText = "credit";
            this.creditDataGridViewTextBoxColumn.Name = "creditDataGridViewTextBoxColumn";
            this.creditDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // termDataGridViewTextBoxColumn
            // 
            this.termDataGridViewTextBoxColumn.DataPropertyName = "term";
            this.termDataGridViewTextBoxColumn.HeaderText = "term";
            this.termDataGridViewTextBoxColumn.Name = "termDataGridViewTextBoxColumn";
            this.termDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // departmentDataGridViewTextBoxColumn
            // 
            this.departmentDataGridViewTextBoxColumn.DataPropertyName = "department";
            this.departmentDataGridViewTextBoxColumn.HeaderText = "department";
            this.departmentDataGridViewTextBoxColumn.Name = "departmentDataGridViewTextBoxColumn";
            this.departmentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // checkEnrolledBindingSource
            // 
            this.checkEnrolledBindingSource.DataMember = "checkEnrolled";
            this.checkEnrolledBindingSource.DataSource = this.enrolledCoursesDataSet;
            // 
            // enrolledCoursesDataSet
            // 
            this.enrolledCoursesDataSet.DataSetName = "EnrolledCoursesDataSet";
            this.enrolledCoursesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Cart_Button);
            this.panel1.Controls.Add(this.Back_Button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 56);
            this.panel1.TabIndex = 9;
            // 
            // Cart_Button
            // 
            this.Cart_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cart_Button.Location = new System.Drawing.Point(1336, 8);
            this.Cart_Button.Name = "Cart_Button";
            this.Cart_Button.Size = new System.Drawing.Size(240, 48);
            this.Cart_Button.TabIndex = 6;
            this.Cart_Button.Text = "Cart";
            this.Cart_Button.UseVisualStyleBackColor = true;
            // 
            // Back_Button
            // 
            this.Back_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_Button.Location = new System.Drawing.Point(8, 8);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(200, 40);
            this.Back_Button.TabIndex = 5;
            this.Back_Button.Text = "< Student Homepage";
            this.Back_Button.UseVisualStyleBackColor = true;
            this.Back_Button.Click += new System.EventHandler(this.Back_Button_Click);
            // 
            // checkEnrolledTableAdapter
            // 
            this.checkEnrolledTableAdapter.ClearBeforeFill = true;
            // 
            // fillToolStrip
            // 
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentIDToolStripLabel,
            this.studentIDToolStripTextBox,
            this.fillToolStripButton});
            this.fillToolStrip.Location = new System.Drawing.Point(0, 56);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(784, 25);
            this.fillToolStrip.TabIndex = 10;
            this.fillToolStrip.Text = "fillToolStrip";
            // 
            // studentIDToolStripLabel
            // 
            this.studentIDToolStripLabel.Name = "studentIDToolStripLabel";
            this.studentIDToolStripLabel.Size = new System.Drawing.Size(61, 22);
            this.studentIDToolStripLabel.Text = "studentID:";
            // 
            // studentIDToolStripTextBox
            // 
            this.studentIDToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.studentIDToolStripTextBox.Name = "studentIDToolStripTextBox";
            this.studentIDToolStripTextBox.ReadOnly = true;
            this.studentIDToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillToolStripButton
            // 
            this.fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton.Name = "fillToolStripButton";
            this.fillToolStripButton.Size = new System.Drawing.Size(26, 22);
            this.fillToolStripButton.Text = "Fill";
            this.fillToolStripButton.Click += new System.EventHandler(this.fillToolStripButton_Click);
            // 
            // EnrolledCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 911);
            this.Controls.Add(this.fillToolStrip);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.enrolledCoursesDataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "EnrolledCourses";
            this.Text = "EnrolledCourses";
            this.Load += new System.EventHandler(this.EnrolledCourses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.enrolledCoursesDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEnrolledBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enrolledCoursesDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView enrolledCoursesDataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Cart_Button;
        private System.Windows.Forms.Button Back_Button;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn termDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource checkEnrolledBindingSource;
        private EnrolledCoursesDataSet enrolledCoursesDataSet;
        private EnrolledCoursesDataSetTableAdapters.checkEnrolledTableAdapter checkEnrolledTableAdapter;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripLabel studentIDToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox studentIDToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
    }
}