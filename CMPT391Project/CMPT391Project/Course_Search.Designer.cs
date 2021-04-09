namespace CMPT391Project
{
    partial class Course_Search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Course_Search));
            this.Title = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.backBtn = new System.Windows.Forms.Button();
            this.courseDetail = new System.Windows.Forms.Button();
            this.facultyDD = new System.Windows.Forms.ComboBox();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.collegeWarehouseCourseDataSet = new CMPT391Project.CollegeWarehouseCourseDataSet();
            this.TermLabel = new System.Windows.Forms.Label();
            this.termDD = new System.Windows.Forms.ComboBox();
            this.dateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.collegeWarehouseDateDataSet3 = new CMPT391Project.CollegeWarehouseDateDataSet3();
            this.YearLabel = new System.Windows.Forms.Label();
            this.yearDD = new System.Windows.Forms.ComboBox();
            this.universityLabel = new System.Windows.Forms.Label();
            this.universityDD = new System.Windows.Forms.ComboBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.departmentLabel = new System.Windows.Forms.Label();
            this.departmentDD = new System.Windows.Forms.ComboBox();
            this.resultText = new System.Windows.Forms.Label();
            this.dateTableAdapter = new CMPT391Project.CollegeWarehouseDateDataSet3TableAdapters.dateTableAdapter();
            this.courseTableAdapter = new CMPT391Project.CollegeWarehouseCourseDataSetTableAdapters.courseTableAdapter();
            this.FacultyLabel = new System.Windows.Forms.Label();
            this.MaxRBtn = new System.Windows.Forms.RadioButton();
            this.MinRBtn = new System.Windows.Forms.RadioButton();
            this.averageRBtn = new System.Windows.Forms.RadioButton();
            this.sumRBtn = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.testLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeWarehouseCourseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeWarehouseDateDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Title.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Title.Location = new System.Drawing.Point(778, 10);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(258, 46);
            this.Title.TabIndex = 0;
            this.Title.Text = "Search Class";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.backBtn);
            this.panel1.Controls.Add(this.Title);
            this.panel1.Location = new System.Drawing.Point(-1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1822, 72);
            this.panel1.TabIndex = 1;
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.Lavender;
            this.backBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backBtn.BackgroundImage")));
            this.backBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backBtn.Location = new System.Drawing.Point(13, 20);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(42, 26);
            this.backBtn.TabIndex = 1;
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // courseDetail
            // 
            this.courseDetail.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.courseDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.courseDetail.Location = new System.Drawing.Point(1430, 854);
            this.courseDetail.Name = "courseDetail";
            this.courseDetail.Size = new System.Drawing.Size(273, 45);
            this.courseDetail.TabIndex = 0;
            this.courseDetail.Text = "Update Data";
            this.courseDetail.UseVisualStyleBackColor = false;
            this.courseDetail.Click += new System.EventHandler(this.CourseDetail_Click);
            // 
            // facultyDD
            // 
            this.facultyDD.DataSource = this.courseBindingSource;
            this.facultyDD.DisplayMember = "faculty";
            this.facultyDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.facultyDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.facultyDD.FormattingEnabled = true;
            this.facultyDD.Location = new System.Drawing.Point(198, 92);
            this.facultyDD.Name = "facultyDD";
            this.facultyDD.Size = new System.Drawing.Size(176, 28);
            this.facultyDD.TabIndex = 2;
            this.facultyDD.ValueMember = "faculty";
            this.facultyDD.SelectedIndexChanged += new System.EventHandler(this.InstructorDD_SelectedIndexChanged);
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataMember = "course";
            this.courseBindingSource.DataSource = this.collegeWarehouseCourseDataSet;
            // 
            // collegeWarehouseCourseDataSet
            // 
            this.collegeWarehouseCourseDataSet.DataSetName = "CollegeWarehouseCourseDataSet";
            this.collegeWarehouseCourseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TermLabel
            // 
            this.TermLabel.AutoSize = true;
            this.TermLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TermLabel.Location = new System.Drawing.Point(128, 149);
            this.TermLabel.Name = "TermLabel";
            this.TermLabel.Size = new System.Drawing.Size(64, 25);
            this.TermLabel.TabIndex = 5;
            this.TermLabel.Text = "Term:";
            // 
            // termDD
            // 
            this.termDD.DataSource = this.dateBindingSource;
            this.termDD.DisplayMember = "semester";
            this.termDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.termDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.termDD.FormattingEnabled = true;
            this.termDD.Location = new System.Drawing.Point(198, 151);
            this.termDD.MaxDropDownItems = 100;
            this.termDD.Name = "termDD";
            this.termDD.Size = new System.Drawing.Size(176, 28);
            this.termDD.TabIndex = 4;
            this.termDD.ValueMember = "semester";
            // 
            // dateBindingSource
            // 
            this.dateBindingSource.DataMember = "date";
            this.dateBindingSource.DataSource = this.collegeWarehouseDateDataSet3;
            // 
            // collegeWarehouseDateDataSet3
            // 
            this.collegeWarehouseDateDataSet3.DataSetName = "CollegeWarehouseDateDataSet3";
            this.collegeWarehouseDateDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // YearLabel
            // 
            this.YearLabel.AutoSize = true;
            this.YearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.YearLabel.Location = new System.Drawing.Point(436, 151);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(59, 25);
            this.YearLabel.TabIndex = 7;
            this.YearLabel.Text = "Year:";
            // 
            // yearDD
            // 
            this.yearDD.DataSource = this.dateBindingSource;
            this.yearDD.DisplayMember = "year";
            this.yearDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yearDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.yearDD.FormattingEnabled = true;
            this.yearDD.Location = new System.Drawing.Point(501, 151);
            this.yearDD.MaxDropDownItems = 100;
            this.yearDD.Name = "yearDD";
            this.yearDD.Size = new System.Drawing.Size(176, 28);
            this.yearDD.TabIndex = 6;
            this.yearDD.ValueMember = "year";
            this.yearDD.SelectedIndexChanged += new System.EventHandler(this.YearDD_SelectedIndexChanged);
            // 
            // universityLabel
            // 
            this.universityLabel.AutoSize = true;
            this.universityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.universityLabel.Location = new System.Drawing.Point(397, 91);
            this.universityLabel.Name = "universityLabel";
            this.universityLabel.Size = new System.Drawing.Size(103, 25);
            this.universityLabel.TabIndex = 9;
            this.universityLabel.Text = "University:";
            this.universityLabel.Click += new System.EventHandler(this.UniversityLabel_Click);
            // 
            // universityDD
            // 
            this.universityDD.DataSource = this.courseBindingSource;
            this.universityDD.DisplayMember = "university";
            this.universityDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.universityDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.universityDD.FormattingEnabled = true;
            this.universityDD.Location = new System.Drawing.Point(501, 92);
            this.universityDD.Name = "universityDD";
            this.universityDD.Size = new System.Drawing.Size(176, 28);
            this.universityDD.TabIndex = 8;
            this.universityDD.ValueMember = "university";
            this.universityDD.SelectedIndexChanged += new System.EventHandler(this.UniversityDD_SelectedIndexChanged);
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.Ivory;
            this.searchBtn.FlatAppearance.BorderSize = 0;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.searchBtn.Location = new System.Drawing.Point(1547, 202);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(156, 30);
            this.searchBtn.TabIndex = 10;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // departmentLabel
            // 
            this.departmentLabel.AutoSize = true;
            this.departmentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.departmentLabel.Location = new System.Drawing.Point(707, 91);
            this.departmentLabel.Name = "departmentLabel";
            this.departmentLabel.Size = new System.Drawing.Size(119, 25);
            this.departmentLabel.TabIndex = 13;
            this.departmentLabel.Text = "Department:";
            // 
            // departmentDD
            // 
            this.departmentDD.DataSource = this.courseBindingSource;
            this.departmentDD.DisplayMember = "department";
            this.departmentDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departmentDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.departmentDD.FormattingEnabled = true;
            this.departmentDD.Location = new System.Drawing.Point(832, 91);
            this.departmentDD.Name = "departmentDD";
            this.departmentDD.Size = new System.Drawing.Size(176, 28);
            this.departmentDD.TabIndex = 12;
            this.departmentDD.ValueMember = "department";
            this.departmentDD.SelectedIndexChanged += new System.EventHandler(this.DepartmentDD_SelectedIndexChanged);
            // 
            // resultText
            // 
            this.resultText.AutoSize = true;
            this.resultText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.resultText.Location = new System.Drawing.Point(129, 480);
            this.resultText.Name = "resultText";
            this.resultText.Size = new System.Drawing.Size(59, 20);
            this.resultText.TabIndex = 14;
            this.resultText.Text = "Result:";
            this.resultText.Click += new System.EventHandler(this.ResultText_Click);
            // 
            // dateTableAdapter
            // 
            this.dateTableAdapter.ClearBeforeFill = true;
            // 
            // courseTableAdapter
            // 
            this.courseTableAdapter.ClearBeforeFill = true;
            // 
            // FacultyLabel
            // 
            this.FacultyLabel.AutoSize = true;
            this.FacultyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FacultyLabel.Location = new System.Drawing.Point(111, 92);
            this.FacultyLabel.Name = "FacultyLabel";
            this.FacultyLabel.Size = new System.Drawing.Size(81, 25);
            this.FacultyLabel.TabIndex = 16;
            this.FacultyLabel.Text = "Faculty:";
            // 
            // MaxRBtn
            // 
            this.MaxRBtn.AutoSize = true;
            this.MaxRBtn.Location = new System.Drawing.Point(133, 342);
            this.MaxRBtn.Name = "MaxRBtn";
            this.MaxRBtn.Size = new System.Drawing.Size(69, 17);
            this.MaxRBtn.TabIndex = 17;
            this.MaxRBtn.TabStop = true;
            this.MaxRBtn.Text = "Maximum";
            this.MaxRBtn.UseVisualStyleBackColor = true;
            this.MaxRBtn.CheckedChanged += new System.EventHandler(this.MaxRBtn_CheckedChanged);
            // 
            // MinRBtn
            // 
            this.MinRBtn.AutoSize = true;
            this.MinRBtn.Location = new System.Drawing.Point(289, 342);
            this.MinRBtn.Name = "MinRBtn";
            this.MinRBtn.Size = new System.Drawing.Size(66, 17);
            this.MinRBtn.TabIndex = 18;
            this.MinRBtn.TabStop = true;
            this.MinRBtn.Text = "Minimum";
            this.MinRBtn.UseVisualStyleBackColor = true;
            this.MinRBtn.CheckedChanged += new System.EventHandler(this.MinRBtn_CheckedChanged);
            // 
            // averageRBtn
            // 
            this.averageRBtn.AutoSize = true;
            this.averageRBtn.Location = new System.Drawing.Point(441, 342);
            this.averageRBtn.Name = "averageRBtn";
            this.averageRBtn.Size = new System.Drawing.Size(65, 17);
            this.averageRBtn.TabIndex = 19;
            this.averageRBtn.TabStop = true;
            this.averageRBtn.Text = "Average";
            this.averageRBtn.UseVisualStyleBackColor = true;
            this.averageRBtn.CheckedChanged += new System.EventHandler(this.AverageRBtn_CheckedChanged);
            // 
            // sumRBtn
            // 
            this.sumRBtn.AutoSize = true;
            this.sumRBtn.Location = new System.Drawing.Point(592, 342);
            this.sumRBtn.Name = "sumRBtn";
            this.sumRBtn.Size = new System.Drawing.Size(46, 17);
            this.sumRBtn.TabIndex = 20;
            this.sumRBtn.TabStop = true;
            this.sumRBtn.Text = "Sum";
            this.sumRBtn.UseVisualStyleBackColor = true;
            this.sumRBtn.CheckedChanged += new System.EventHandler(this.SumRBtn_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(438, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "*0 means no selection";
            // 
            // testLabel
            // 
            this.testLabel.AutoSize = true;
            this.testLabel.Location = new System.Drawing.Point(149, 551);
            this.testLabel.Name = "testLabel";
            this.testLabel.Size = new System.Drawing.Size(52, 13);
            this.testLabel.TabIndex = 23;
            this.testLabel.Text = "Test data";
            // 
            // Course_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1817, 919);
            this.Controls.Add(this.testLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sumRBtn);
            this.Controls.Add(this.averageRBtn);
            this.Controls.Add(this.MinRBtn);
            this.Controls.Add(this.MaxRBtn);
            this.Controls.Add(this.FacultyLabel);
            this.Controls.Add(this.resultText);
            this.Controls.Add(this.departmentLabel);
            this.Controls.Add(this.departmentDD);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.universityLabel);
            this.Controls.Add(this.universityDD);
            this.Controls.Add(this.YearLabel);
            this.Controls.Add(this.yearDD);
            this.Controls.Add(this.TermLabel);
            this.Controls.Add(this.termDD);
            this.Controls.Add(this.facultyDD);
            this.Controls.Add(this.courseDetail);
            this.Controls.Add(this.panel1);
            this.Name = "Course_Search";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Course_Search_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeWarehouseCourseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeWarehouseDateDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button courseDetail;
        private System.Windows.Forms.ComboBox facultyDD;
        private System.Windows.Forms.Label TermLabel;
        private System.Windows.Forms.ComboBox termDD;
        private System.Windows.Forms.Label YearLabel;
        private System.Windows.Forms.ComboBox yearDD;
        private System.Windows.Forms.Label universityLabel;
        private System.Windows.Forms.ComboBox universityDD;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label departmentLabel;
        private System.Windows.Forms.ComboBox departmentDD;
        private System.Windows.Forms.Label resultText;
        private CollegeWarehouseDateDataSet3 collegeWarehouseDateDataSet3;
        private System.Windows.Forms.BindingSource dateBindingSource;
        private CollegeWarehouseDateDataSet3TableAdapters.dateTableAdapter dateTableAdapter;
        private CollegeWarehouseCourseDataSet collegeWarehouseCourseDataSet;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private CollegeWarehouseCourseDataSetTableAdapters.courseTableAdapter courseTableAdapter;
        private System.Windows.Forms.Label FacultyLabel;
        private System.Windows.Forms.RadioButton MaxRBtn;
        private System.Windows.Forms.RadioButton MinRBtn;
        private System.Windows.Forms.RadioButton averageRBtn;
        private System.Windows.Forms.RadioButton sumRBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label testLabel;
    }
}