namespace PayrollMgmtSystem
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
            this.components = new System.ComponentModel.Container();
            this.lbl_ot = new System.Windows.Forms.Label();
            this.lbl_salary = new System.Windows.Forms.Label();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.OTLBL = new System.Windows.Forms.Label();
            this.SalaryLBL = new System.Windows.Forms.Label();
            this.lbl_age = new System.Windows.Forms.Label();
            this.lbl_gender = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cb_des = new System.Windows.Forms.ComboBox();
            this.cb_dep = new System.Windows.Forms.ComboBox();
            this.txt_add = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_eid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nic = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_fname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_lname = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl_dob = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_clr = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lbl_message = new System.Windows.Forms.Label();
            this.payrollManagementDataSet = new PayrollMgmtSystem.PayrollManagementDataSet();
            this.payrollManagementDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.payrollManagementDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrollManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrollManagementDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrollManagementDataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_ot
            // 
            this.lbl_ot.AutoSize = true;
            this.lbl_ot.ForeColor = System.Drawing.Color.Black;
            this.lbl_ot.Location = new System.Drawing.Point(143, 333);
            this.lbl_ot.Name = "lbl_ot";
            this.lbl_ot.Size = new System.Drawing.Size(153, 13);
            this.lbl_ot.TabIndex = 53;
            this.lbl_ot.Text = "Select Designation to generate";
            // 
            // lbl_salary
            // 
            this.lbl_salary.AutoSize = true;
            this.lbl_salary.ForeColor = System.Drawing.Color.Black;
            this.lbl_salary.Location = new System.Drawing.Point(143, 310);
            this.lbl_salary.Name = "lbl_salary";
            this.lbl_salary.Size = new System.Drawing.Size(153, 13);
            this.lbl_salary.TabIndex = 52;
            this.lbl_salary.Text = "Select Designation to generate";
            // 
            // btn_remove
            // 
            this.btn_remove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_remove.Location = new System.Drawing.Point(1121, 94);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(109, 46);
            this.btn_remove.TabIndex = 41;
            this.btn_remove.Text = "Remove";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_search
            // 
            this.btn_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search.Location = new System.Drawing.Point(982, 94);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(109, 46);
            this.btn_search.TabIndex = 39;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(982, 59);
            this.txt_search.MaxLength = 10;
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(174, 20);
            this.txt_search.TabIndex = 38;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(888, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 13);
            this.label11.TabIndex = 51;
            this.label11.Text = "Employee ID";
            // 
            // OTLBL
            // 
            this.OTLBL.AutoSize = true;
            this.OTLBL.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Bold);
            this.OTLBL.ForeColor = System.Drawing.Color.Black;
            this.OTLBL.Location = new System.Drawing.Point(173, 310);
            this.OTLBL.Name = "OTLBL";
            this.OTLBL.Size = new System.Drawing.Size(0, 12);
            this.OTLBL.TabIndex = 50;
            // 
            // SalaryLBL
            // 
            this.SalaryLBL.AutoSize = true;
            this.SalaryLBL.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Bold);
            this.SalaryLBL.ForeColor = System.Drawing.Color.Black;
            this.SalaryLBL.Location = new System.Drawing.Point(173, 287);
            this.SalaryLBL.Name = "SalaryLBL";
            this.SalaryLBL.Size = new System.Drawing.Size(0, 12);
            this.SalaryLBL.TabIndex = 49;
            // 
            // lbl_age
            // 
            this.lbl_age.AutoSize = true;
            this.lbl_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lbl_age.ForeColor = System.Drawing.Color.Black;
            this.lbl_age.Location = new System.Drawing.Point(143, 287);
            this.lbl_age.Name = "lbl_age";
            this.lbl_age.Size = new System.Drawing.Size(135, 13);
            this.lbl_age.TabIndex = 48;
            this.lbl_age.Text = "Enter valid NIC to generate";
            // 
            // lbl_gender
            // 
            this.lbl_gender.AutoSize = true;
            this.lbl_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lbl_gender.ForeColor = System.Drawing.Color.Black;
            this.lbl_gender.Location = new System.Drawing.Point(143, 241);
            this.lbl_gender.Name = "lbl_gender";
            this.lbl_gender.Size = new System.Drawing.Size(135, 13);
            this.lbl_gender.TabIndex = 47;
            this.lbl_gender.Text = "Enter valid NIC to generate";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(34, 333);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 46;
            this.label7.Text = "OT rate (per hour)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(34, 310);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 45;
            this.label8.Text = "Basic Salary";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(34, 287);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 13);
            this.label9.TabIndex = 44;
            this.label9.Text = "Age";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(35, 241);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 43;
            this.label10.Text = "Gender";
            // 
            // cb_des
            // 
            this.cb_des.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_des.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_des.FormattingEnabled = true;
            this.cb_des.Items.AddRange(new object[] {
            "..Select Designation..",
            "Junior Executive I",
            "Junior Executive II",
            "Executive I",
            "Executive II",
            "Senior Executive I",
            "Senior Executive II",
            "Manager",
            "Senior Manager",
            "Assistant General Manager",
            "Deputy General Manager"});
            this.cb_des.Location = new System.Drawing.Point(142, 189);
            this.cb_des.Name = "cb_des";
            this.cb_des.Size = new System.Drawing.Size(152, 21);
            this.cb_des.TabIndex = 33;
            this.cb_des.SelectedIndexChanged += new System.EventHandler(this.cb_des_SelectedIndexChanged);
            // 
            // cb_dep
            // 
            this.cb_dep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_dep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_dep.FormattingEnabled = true;
            this.cb_dep.Items.AddRange(new object[] {
            "Select Department",
            "IT",
            "Correspondence",
            "Risk",
            "Recovery"});
            this.cb_dep.Location = new System.Drawing.Point(142, 164);
            this.cb_dep.Name = "cb_dep";
            this.cb_dep.Size = new System.Drawing.Size(152, 21);
            this.cb_dep.TabIndex = 32;
            // 
            // txt_add
            // 
            this.txt_add.Location = new System.Drawing.Point(142, 214);
            this.txt_add.MaxLength = 50;
            this.txt_add.Name = "txt_add";
            this.txt_add.Size = new System.Drawing.Size(216, 20);
            this.txt_add.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(35, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(35, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "Designation";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(35, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Department";
            // 
            // txt_eid
            // 
            this.txt_eid.Location = new System.Drawing.Point(142, 140);
            this.txt_eid.MaxLength = 10;
            this.txt_eid.Name = "txt_eid";
            this.txt_eid.Size = new System.Drawing.Size(152, 20);
            this.txt_eid.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(35, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Employee ID";
            // 
            // txt_nic
            // 
            this.txt_nic.Location = new System.Drawing.Point(142, 116);
            this.txt_nic.MaxLength = 10;
            this.txt_nic.Name = "txt_nic";
            this.txt_nic.Size = new System.Drawing.Size(152, 20);
            this.txt_nic.TabIndex = 29;
            this.txt_nic.TextChanged += new System.EventHandler(this.txt_nic_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(36, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "NIC";
            // 
            // txt_fname
            // 
            this.txt_fname.Location = new System.Drawing.Point(142, 65);
            this.txt_fname.MaxLength = 41;
            this.txt_fname.Name = "txt_fname";
            this.txt_fname.Size = new System.Drawing.Size(216, 20);
            this.txt_fname.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(35, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "First Name";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column11,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column10,
            this.Column5,
            this.Column6,
            this.Column12,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dataGridView.Location = new System.Drawing.Point(467, 164);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(763, 268);
            this.dataGridView.TabIndex = 54;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "First Name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 76;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Last Name";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Width = 77;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "NIC Number";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 83;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Employee ID";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 85;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Department";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 87;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Designation";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 88;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Address";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 70;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Gender";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 67;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Date of Birth";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Width = 65;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Age";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 51;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Basic Salary";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 83;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "OT Rate (per hour)";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 89;
            // 
            // txt_lname
            // 
            this.txt_lname.Location = new System.Drawing.Point(142, 91);
            this.txt_lname.MaxLength = 41;
            this.txt_lname.Name = "txt_lname";
            this.txt_lname.Size = new System.Drawing.Size(216, 20);
            this.txt_lname.TabIndex = 59;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(35, 94);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 13);
            this.label14.TabIndex = 58;
            this.label14.Text = "Last Name";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.MediumBlue;
            this.label15.Location = new System.Drawing.Point(449, 18);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(373, 24);
            this.label15.TabIndex = 60;
            this.label15.Text = "Employee Payroll Management System";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(36, 263);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 13);
            this.label12.TabIndex = 44;
            this.label12.Text = "Date of Birth";
            // 
            // lbl_dob
            // 
            this.lbl_dob.AutoSize = true;
            this.lbl_dob.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lbl_dob.ForeColor = System.Drawing.Color.Black;
            this.lbl_dob.Location = new System.Drawing.Point(143, 263);
            this.lbl_dob.Name = "lbl_dob";
            this.lbl_dob.Size = new System.Drawing.Size(135, 13);
            this.lbl_dob.TabIndex = 48;
            this.lbl_dob.Text = "Enter valid NIC to generate";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(30, 386);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(109, 46);
            this.btn_add.TabIndex = 61;
            this.btn_add.Text = "Add to Grid";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(166, 386);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(109, 46);
            this.btn_save.TabIndex = 62;
            this.btn_save.Text = "Save/Update";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_clr
            // 
            this.btn_clr.Location = new System.Drawing.Point(300, 386);
            this.btn_clr.Name = "btn_clr";
            this.btn_clr.Size = new System.Drawing.Size(108, 46);
            this.btn_clr.TabIndex = 63;
            this.btn_clr.Text = "Clear All";
            this.btn_clr.UseVisualStyleBackColor = true;
            this.btn_clr.Click += new System.EventHandler(this.btn_clr_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1261, 24);
            this.menuStrip1.TabIndex = 64;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lbl_message
            // 
            this.lbl_message.AutoSize = true;
            this.lbl_message.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_message.Location = new System.Drawing.Point(34, 466);
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(0, 15);
            this.lbl_message.TabIndex = 65;
            // 
            // payrollManagementDataSet
            // 
            this.payrollManagementDataSet.DataSetName = "PayrollManagementDataSet";
            this.payrollManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // payrollManagementDataSetBindingSource
            // 
            this.payrollManagementDataSetBindingSource.DataSource = this.payrollManagementDataSet;
            this.payrollManagementDataSetBindingSource.Position = 0;
            // 
            // payrollManagementDataSetBindingSource1
            // 
            this.payrollManagementDataSetBindingSource1.Position = 0;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 500);
            this.Controls.Add(this.lbl_message);
            this.Controls.Add(this.btn_clr);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txt_lname);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.lbl_ot);
            this.Controls.Add(this.lbl_salary);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.OTLBL);
            this.Controls.Add(this.SalaryLBL);
            this.Controls.Add(this.lbl_dob);
            this.Controls.Add(this.lbl_age);
            this.Controls.Add(this.lbl_gender);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cb_des);
            this.Controls.Add(this.cb_dep);
            this.Controls.Add(this.txt_add);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_eid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_nic);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_fname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HomePage_FormClosed);
            this.Load += new System.EventHandler(this.HomePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrollManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrollManagementDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrollManagementDataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ot;
        private System.Windows.Forms.Label lbl_salary;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label OTLBL;
        private System.Windows.Forms.Label SalaryLBL;
        private System.Windows.Forms.Label lbl_age;
        private System.Windows.Forms.Label lbl_gender;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cb_des;
        private System.Windows.Forms.ComboBox cb_dep;
        private System.Windows.Forms.TextBox txt_add;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_eid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_nic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_fname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox txt_lname;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbl_dob;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_clr;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.Label lbl_message;
        private System.Windows.Forms.BindingSource payrollManagementDataSetBindingSource1;
        private PayrollManagementDataSet payrollManagementDataSet;
        private System.Windows.Forms.BindingSource payrollManagementDataSetBindingSource;
    }
}