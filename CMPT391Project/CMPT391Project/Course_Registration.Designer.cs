namespace CMPT391Project
{
    partial class Course_Registration
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
            this.label1 = new System.Windows.Forms.Label();
            this.Back_Button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Cart_Button = new System.Windows.Forms.Button();
            this.yearComboBox = new System.Windows.Forms.ComboBox();
            this.sectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sectionYearDataSet = new CMPT391Project.SectionYearDataSet();
            this.termComboBox = new System.Windows.Forms.ComboBox();
            this.sectionBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.sectionTermDataSet = new CMPT391Project.SectionTermDataSet();
            this.sectionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.collegeDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.collegeDataSet1 = new CMPT391Project.CollegeDataSet1();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.departmentComboBox = new System.Windows.Forms.ComboBox();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.collegeDataSet1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sectionTableAdapter = new CMPT391Project.SectionYearDataSetTableAdapters.sectionTableAdapter();
            this.sectionTableAdapter1 = new CMPT391Project.CollegeDataSet1TableAdapters.sectionTableAdapter();
            this.departmentTableAdapter = new CMPT391Project.CollegeDataSet1TableAdapters.departmentTableAdapter();
            this.sectionTableAdapter2 = new CMPT391Project.SectionTermDataSetTableAdapters.sectionTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sectionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionYearDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionTermDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeDataSet1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(568, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(538, 78);
            this.label1.TabIndex = 4;
            this.label1.Text = "Course Registration";
            // 
            // Back_Button
            // 
            this.Back_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_Button.Location = new System.Drawing.Point(8, 8);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(240, 48);
            this.Back_Button.TabIndex = 5;
            this.Back_Button.Text = "< Student Homepage";
            this.Back_Button.UseVisualStyleBackColor = true;
            this.Back_Button.Click += new System.EventHandler(this.Go_back_button_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Cart_Button);
            this.panel1.Controls.Add(this.Back_Button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1584, 64);
            this.panel1.TabIndex = 6;
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
            this.Cart_Button.Click += new System.EventHandler(this.Cart_Button_Click);
            // 
            // yearComboBox
            // 
            this.yearComboBox.DataSource = this.sectionBindingSource;
            this.yearComboBox.DisplayMember = "year";
            this.yearComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yearComboBox.FormattingEnabled = true;
            this.yearComboBox.Location = new System.Drawing.Point(104, 176);
            this.yearComboBox.Name = "yearComboBox";
            this.yearComboBox.Size = new System.Drawing.Size(121, 28);
            this.yearComboBox.TabIndex = 7;
            this.yearComboBox.ValueMember = "year";
            // 
            // sectionBindingSource
            // 
            this.sectionBindingSource.DataMember = "section";
            this.sectionBindingSource.DataSource = this.sectionYearDataSet;
            // 
            // sectionYearDataSet
            // 
            this.sectionYearDataSet.DataSetName = "SectionYearDataSet";
            this.sectionYearDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // termComboBox
            // 
            this.termComboBox.DataSource = this.sectionBindingSource2;
            this.termComboBox.DisplayMember = "term";
            this.termComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.termComboBox.FormattingEnabled = true;
            this.termComboBox.Location = new System.Drawing.Point(344, 176);
            this.termComboBox.Name = "termComboBox";
            this.termComboBox.Size = new System.Drawing.Size(152, 28);
            this.termComboBox.TabIndex = 8;
            this.termComboBox.ValueMember = "term";
            // 
            // sectionBindingSource2
            // 
            this.sectionBindingSource2.DataMember = "section";
            this.sectionBindingSource2.DataSource = this.sectionTermDataSet;
            // 
            // sectionTermDataSet
            // 
            this.sectionTermDataSet.DataSetName = "SectionTermDataSet";
            this.sectionTermDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sectionBindingSource1
            // 
            this.sectionBindingSource1.DataMember = "section";
            this.sectionBindingSource1.DataSource = this.collegeDataSet1BindingSource;
            // 
            // collegeDataSet1BindingSource
            // 
            this.collegeDataSet1BindingSource.DataSource = this.collegeDataSet1;
            this.collegeDataSet1BindingSource.Position = 0;
            // 
            // collegeDataSet1
            // 
            this.collegeDataSet1.DataSetName = "CollegeDataSet1";
            this.collegeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Year";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(280, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Term";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(544, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Department";
            // 
            // departmentComboBox
            // 
            this.departmentComboBox.DataSource = this.departmentBindingSource;
            this.departmentComboBox.DisplayMember = "name";
            this.departmentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departmentComboBox.FormattingEnabled = true;
            this.departmentComboBox.Location = new System.Drawing.Point(680, 176);
            this.departmentComboBox.Name = "departmentComboBox";
            this.departmentComboBox.Size = new System.Drawing.Size(280, 28);
            this.departmentComboBox.TabIndex = 11;
            this.departmentComboBox.ValueMember = "name";
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataMember = "department";
            this.departmentBindingSource.DataSource = this.collegeDataSet1BindingSource1;
            // 
            // collegeDataSet1BindingSource1
            // 
            this.collegeDataSet1BindingSource1.DataSource = this.collegeDataSet1;
            this.collegeDataSet1BindingSource1.Position = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 232);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(1504, 896);
            this.dataGridView1.TabIndex = 13;
            // 
            // sectionTableAdapter
            // 
            this.sectionTableAdapter.ClearBeforeFill = true;
            // 
            // sectionTableAdapter1
            // 
            this.sectionTableAdapter1.ClearBeforeFill = true;
            // 
            // departmentTableAdapter
            // 
            this.departmentTableAdapter.ClearBeforeFill = true;
            // 
            // sectionTableAdapter2
            // 
            this.sectionTableAdapter2.ClearBeforeFill = true;
            // 
            // Course_Registration
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1584, 1161);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.departmentComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.termComboBox);
            this.Controls.Add(this.yearComboBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Course_Registration";
            this.Text = "Course Registration";
            this.Load += new System.EventHandler(this.Course_Registration_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sectionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionYearDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionTermDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeDataSet1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Back_Button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Cart_Button;
        private System.Windows.Forms.ComboBox yearComboBox;
        private System.Windows.Forms.ComboBox termComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox departmentComboBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SectionYearDataSet sectionYearDataSet;
        private System.Windows.Forms.BindingSource sectionBindingSource;
        private SectionYearDataSetTableAdapters.sectionTableAdapter sectionTableAdapter;
        private System.Windows.Forms.BindingSource collegeDataSet1BindingSource;
        private CollegeDataSet1 collegeDataSet1;
        private System.Windows.Forms.BindingSource sectionBindingSource1;
        private CollegeDataSet1TableAdapters.sectionTableAdapter sectionTableAdapter1;
        private System.Windows.Forms.BindingSource collegeDataSet1BindingSource1;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private CollegeDataSet1TableAdapters.departmentTableAdapter departmentTableAdapter;
        private SectionTermDataSet sectionTermDataSet;
        private System.Windows.Forms.BindingSource sectionBindingSource2;
        private SectionTermDataSetTableAdapters.sectionTableAdapter sectionTableAdapter2;
    }
}

