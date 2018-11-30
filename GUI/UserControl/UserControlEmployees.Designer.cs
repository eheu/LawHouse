namespace GUI
{
    partial class UserControlEmployees
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TabControl_UCEmployee = new System.Windows.Forms.TabControl();
            this.TC_UCEmployeeTC_FindEmployee = new System.Windows.Forms.TabPage();
            this.textBox_UCCaseTCFind_Search = new System.Windows.Forms.TextBox();
            this.label_UCCaseTCFind_Search = new System.Windows.Forms.Label();
            this.button_UCEmployeeTCFind_CreateEmployee = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.objectListView_UCEmployeeTCFind_FindEmployee = new BrightIdeasSoftware.DataListView();
            this.olvColumnEmployeeFindID = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnEmployeeFindFirstName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnEmployeeFindLastName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.TC_UCEmployeeTC_EditEmployee = new System.Windows.Forms.TabPage();
            this.ListBox_UCEmployeeTCEdit_EditEmployee_ShowSpeciality = new System.Windows.Forms.ListBox();
            this.button_UCEmployeeTCEdit_Back_FindEmployee = new System.Windows.Forms.Button();
            this.button_UCEmployeeTCEdit_EditEmployee_SaveEmployee = new System.Windows.Forms.Button();
            this.button_UCEmployeeTCEdit_EditEmployee_AddSpeciality = new System.Windows.Forms.Button();
            this.comboBox_UCEmployeeTCEdit_EditEmployee_Speciality = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TC_UCEmployeeTC_CreateEmployee = new System.Windows.Forms.TabPage();
            this.button_UCEmployeeTCCreate_FindEmployee = new System.Windows.Forms.Button();
            this.button_UCEmployeeTCCreate_CreateEmployee_SaveEmployee = new System.Windows.Forms.Button();
            this.button_UCEmployeeTCCreate_CreateEmployee_AddSpeciality = new System.Windows.Forms.Button();
            this.comboBox_UCEmployeeTCCreate_CreateEmployee_Speciality = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.combo_UCEmployeeTCCreate_Role = new System.Windows.Forms.ComboBox();
            this.textbox_UCEmployeeTCCreate_phone = new System.Windows.Forms.TextBox();
            this.textbox_UCEmployeeTCCreate_emailName = new System.Windows.Forms.TextBox();
            this.textbox_UCEmployeeTCCreate_lastName = new System.Windows.Forms.TextBox();
            this.textbox_UCEmployeeTCCreate_firstName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.ListBox_UCEmployeeTCCreate_CreateEmployee_ShowSpeciality = new System.Windows.Forms.ListBox();
            this.TabControl_UCEmployee.SuspendLayout();
            this.TC_UCEmployeeTC_FindEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectListView_UCEmployeeTCFind_FindEmployee)).BeginInit();
            this.TC_UCEmployeeTC_EditEmployee.SuspendLayout();
            this.TC_UCEmployeeTC_CreateEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl_UCEmployee
            // 
            this.TabControl_UCEmployee.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.TabControl_UCEmployee.Controls.Add(this.TC_UCEmployeeTC_FindEmployee);
            this.TabControl_UCEmployee.Controls.Add(this.TC_UCEmployeeTC_EditEmployee);
            this.TabControl_UCEmployee.Controls.Add(this.TC_UCEmployeeTC_CreateEmployee);
            this.TabControl_UCEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl_UCEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.TabControl_UCEmployee.ItemSize = new System.Drawing.Size(100, 50);
            this.TabControl_UCEmployee.Location = new System.Drawing.Point(0, 0);
            this.TabControl_UCEmployee.Name = "TabControl_UCEmployee";
            this.TabControl_UCEmployee.SelectedIndex = 0;
            this.TabControl_UCEmployee.Size = new System.Drawing.Size(1157, 566);
            this.TabControl_UCEmployee.TabIndex = 0;
            this.TabControl_UCEmployee.MouseEnter += new System.EventHandler(this.UserControlEmployees_MouseEnter);
            // 
            // TC_UCEmployeeTC_FindEmployee
            // 
            this.TC_UCEmployeeTC_FindEmployee.BackColor = System.Drawing.Color.White;
            this.TC_UCEmployeeTC_FindEmployee.Controls.Add(this.textBox_UCCaseTCFind_Search);
            this.TC_UCEmployeeTC_FindEmployee.Controls.Add(this.label_UCCaseTCFind_Search);
            this.TC_UCEmployeeTC_FindEmployee.Controls.Add(this.button_UCEmployeeTCFind_CreateEmployee);
            this.TC_UCEmployeeTC_FindEmployee.Controls.Add(this.label1);
            this.TC_UCEmployeeTC_FindEmployee.Controls.Add(this.objectListView_UCEmployeeTCFind_FindEmployee);
            this.TC_UCEmployeeTC_FindEmployee.Location = new System.Drawing.Point(4, 54);
            this.TC_UCEmployeeTC_FindEmployee.Name = "TC_UCEmployeeTC_FindEmployee";
            this.TC_UCEmployeeTC_FindEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.TC_UCEmployeeTC_FindEmployee.Size = new System.Drawing.Size(1149, 508);
            this.TC_UCEmployeeTC_FindEmployee.TabIndex = 0;
            this.TC_UCEmployeeTC_FindEmployee.Text = "Find ansat";
            this.TC_UCEmployeeTC_FindEmployee.MouseEnter += new System.EventHandler(this.UserControlEmployees_MouseEnter);
            // 
            // textBox_UCCaseTCFind_Search
            // 
            this.textBox_UCCaseTCFind_Search.Location = new System.Drawing.Point(1022, 67);
            this.textBox_UCCaseTCFind_Search.Name = "textBox_UCCaseTCFind_Search";
            this.textBox_UCCaseTCFind_Search.Size = new System.Drawing.Size(121, 24);
            this.textBox_UCCaseTCFind_Search.TabIndex = 13;
            // 
            // label_UCCaseTCFind_Search
            // 
            this.label_UCCaseTCFind_Search.AutoSize = true;
            this.label_UCCaseTCFind_Search.Location = new System.Drawing.Point(980, 67);
            this.label_UCCaseTCFind_Search.Name = "label_UCCaseTCFind_Search";
            this.label_UCCaseTCFind_Search.Size = new System.Drawing.Size(38, 18);
            this.label_UCCaseTCFind_Search.TabIndex = 12;
            this.label_UCCaseTCFind_Search.Text = "Søg";
            // 
            // button_UCEmployeeTCFind_CreateEmployee
            // 
            this.button_UCEmployeeTCFind_CreateEmployee.Location = new System.Drawing.Point(6, 27);
            this.button_UCEmployeeTCFind_CreateEmployee.Name = "button_UCEmployeeTCFind_CreateEmployee";
            this.button_UCEmployeeTCFind_CreateEmployee.Size = new System.Drawing.Size(102, 30);
            this.button_UCEmployeeTCFind_CreateEmployee.TabIndex = 2;
            this.button_UCEmployeeTCFind_CreateEmployee.Text = "Opret";
            this.button_UCEmployeeTCFind_CreateEmployee.UseVisualStyleBackColor = true;
            this.button_UCEmployeeTCFind_CreateEmployee.Click += new System.EventHandler(this.button_UCEmployeeTCFind_CreateEmployee_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Find ansat";
            // 
            // objectListView_UCEmployeeTCFind_FindEmployee
            // 
            this.objectListView_UCEmployeeTCFind_FindEmployee.AllColumns.Add(this.olvColumnEmployeeFindID);
            this.objectListView_UCEmployeeTCFind_FindEmployee.AllColumns.Add(this.olvColumnEmployeeFindFirstName);
            this.objectListView_UCEmployeeTCFind_FindEmployee.AllColumns.Add(this.olvColumnEmployeeFindLastName);
            this.objectListView_UCEmployeeTCFind_FindEmployee.CellEditUseWholeCell = false;
            this.objectListView_UCEmployeeTCFind_FindEmployee.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumnEmployeeFindID,
            this.olvColumnEmployeeFindFirstName,
            this.olvColumnEmployeeFindLastName});
            this.objectListView_UCEmployeeTCFind_FindEmployee.Cursor = System.Windows.Forms.Cursors.Default;
            this.objectListView_UCEmployeeTCFind_FindEmployee.DataSource = null;
            this.objectListView_UCEmployeeTCFind_FindEmployee.FullRowSelect = true;
            this.objectListView_UCEmployeeTCFind_FindEmployee.GridLines = true;
            this.objectListView_UCEmployeeTCFind_FindEmployee.Location = new System.Drawing.Point(9, 97);
            this.objectListView_UCEmployeeTCFind_FindEmployee.Name = "objectListView_UCEmployeeTCFind_FindEmployee";
            this.objectListView_UCEmployeeTCFind_FindEmployee.ShowGroups = false;
            this.objectListView_UCEmployeeTCFind_FindEmployee.Size = new System.Drawing.Size(1134, 396);
            this.objectListView_UCEmployeeTCFind_FindEmployee.TabIndex = 0;
            this.objectListView_UCEmployeeTCFind_FindEmployee.UseCompatibleStateImageBehavior = false;
            this.objectListView_UCEmployeeTCFind_FindEmployee.View = System.Windows.Forms.View.Details;
            this.objectListView_UCEmployeeTCFind_FindEmployee.MouseEnter += new System.EventHandler(this.UserControlEmployees_MouseEnter);
            // 
            // olvColumnEmployeeFindID
            // 
            this.olvColumnEmployeeFindID.AspectName = "ID";
            this.olvColumnEmployeeFindID.Text = "Id";
            // 
            // olvColumnEmployeeFindFirstName
            // 
            this.olvColumnEmployeeFindFirstName.AspectName = "FirstName";
            this.olvColumnEmployeeFindFirstName.Text = "Fornavn";
            this.olvColumnEmployeeFindFirstName.Width = 76;
            // 
            // olvColumnEmployeeFindLastName
            // 
            this.olvColumnEmployeeFindLastName.AspectName = "LastName";
            this.olvColumnEmployeeFindLastName.Text = "Efternavn";
            this.olvColumnEmployeeFindLastName.Width = 89;
            // 
            // TC_UCEmployeeTC_EditEmployee
            // 
            this.TC_UCEmployeeTC_EditEmployee.Controls.Add(this.ListBox_UCEmployeeTCEdit_EditEmployee_ShowSpeciality);
            this.TC_UCEmployeeTC_EditEmployee.Controls.Add(this.button_UCEmployeeTCEdit_Back_FindEmployee);
            this.TC_UCEmployeeTC_EditEmployee.Controls.Add(this.button_UCEmployeeTCEdit_EditEmployee_SaveEmployee);
            this.TC_UCEmployeeTC_EditEmployee.Controls.Add(this.button_UCEmployeeTCEdit_EditEmployee_AddSpeciality);
            this.TC_UCEmployeeTC_EditEmployee.Controls.Add(this.comboBox_UCEmployeeTCEdit_EditEmployee_Speciality);
            this.TC_UCEmployeeTC_EditEmployee.Controls.Add(this.label8);
            this.TC_UCEmployeeTC_EditEmployee.Controls.Add(this.comboBox1);
            this.TC_UCEmployeeTC_EditEmployee.Controls.Add(this.textBox4);
            this.TC_UCEmployeeTC_EditEmployee.Controls.Add(this.textBox3);
            this.TC_UCEmployeeTC_EditEmployee.Controls.Add(this.textBox2);
            this.TC_UCEmployeeTC_EditEmployee.Controls.Add(this.textBox1);
            this.TC_UCEmployeeTC_EditEmployee.Controls.Add(this.label7);
            this.TC_UCEmployeeTC_EditEmployee.Controls.Add(this.label6);
            this.TC_UCEmployeeTC_EditEmployee.Controls.Add(this.label5);
            this.TC_UCEmployeeTC_EditEmployee.Controls.Add(this.label4);
            this.TC_UCEmployeeTC_EditEmployee.Controls.Add(this.label3);
            this.TC_UCEmployeeTC_EditEmployee.Controls.Add(this.label2);
            this.TC_UCEmployeeTC_EditEmployee.Location = new System.Drawing.Point(4, 54);
            this.TC_UCEmployeeTC_EditEmployee.Name = "TC_UCEmployeeTC_EditEmployee";
            this.TC_UCEmployeeTC_EditEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.TC_UCEmployeeTC_EditEmployee.Size = new System.Drawing.Size(1149, 508);
            this.TC_UCEmployeeTC_EditEmployee.TabIndex = 1;
            this.TC_UCEmployeeTC_EditEmployee.Text = "Rediger";
            this.TC_UCEmployeeTC_EditEmployee.UseVisualStyleBackColor = true;
            // 
            // ListBox_UCEmployeeTCEdit_EditEmployee_ShowSpeciality
            // 
            this.ListBox_UCEmployeeTCEdit_EditEmployee_ShowSpeciality.FormattingEnabled = true;
            this.ListBox_UCEmployeeTCEdit_EditEmployee_ShowSpeciality.ItemHeight = 18;
            this.ListBox_UCEmployeeTCEdit_EditEmployee_ShowSpeciality.Location = new System.Drawing.Point(732, 54);
            this.ListBox_UCEmployeeTCEdit_EditEmployee_ShowSpeciality.Name = "ListBox_UCEmployeeTCEdit_EditEmployee_ShowSpeciality";
            this.ListBox_UCEmployeeTCEdit_EditEmployee_ShowSpeciality.Size = new System.Drawing.Size(401, 400);
            this.ListBox_UCEmployeeTCEdit_EditEmployee_ShowSpeciality.TabIndex = 17;
            // 
            // button_UCEmployeeTCEdit_Back_FindEmployee
            // 
            this.button_UCEmployeeTCEdit_Back_FindEmployee.Location = new System.Drawing.Point(6, 27);
            this.button_UCEmployeeTCEdit_Back_FindEmployee.Name = "button_UCEmployeeTCEdit_Back_FindEmployee";
            this.button_UCEmployeeTCEdit_Back_FindEmployee.Size = new System.Drawing.Size(102, 30);
            this.button_UCEmployeeTCEdit_Back_FindEmployee.TabIndex = 16;
            this.button_UCEmployeeTCEdit_Back_FindEmployee.Text = "Tilbage";
            this.button_UCEmployeeTCEdit_Back_FindEmployee.UseVisualStyleBackColor = true;
            this.button_UCEmployeeTCEdit_Back_FindEmployee.Click += new System.EventHandler(this.button_UCEmployeeTCEdit_Back_FindEmployee_Click);
            // 
            // button_UCEmployeeTCEdit_EditEmployee_SaveEmployee
            // 
            this.button_UCEmployeeTCEdit_EditEmployee_SaveEmployee.Location = new System.Drawing.Point(995, 472);
            this.button_UCEmployeeTCEdit_EditEmployee_SaveEmployee.Name = "button_UCEmployeeTCEdit_EditEmployee_SaveEmployee";
            this.button_UCEmployeeTCEdit_EditEmployee_SaveEmployee.Size = new System.Drawing.Size(138, 30);
            this.button_UCEmployeeTCEdit_EditEmployee_SaveEmployee.TabIndex = 15;
            this.button_UCEmployeeTCEdit_EditEmployee_SaveEmployee.Text = "Gem ændringer";
            this.button_UCEmployeeTCEdit_EditEmployee_SaveEmployee.UseVisualStyleBackColor = true;
            // 
            // button_UCEmployeeTCEdit_EditEmployee_AddSpeciality
            // 
            this.button_UCEmployeeTCEdit_EditEmployee_AddSpeciality.Location = new System.Drawing.Point(1031, 12);
            this.button_UCEmployeeTCEdit_EditEmployee_AddSpeciality.Name = "button_UCEmployeeTCEdit_EditEmployee_AddSpeciality";
            this.button_UCEmployeeTCEdit_EditEmployee_AddSpeciality.Size = new System.Drawing.Size(102, 30);
            this.button_UCEmployeeTCEdit_EditEmployee_AddSpeciality.TabIndex = 14;
            this.button_UCEmployeeTCEdit_EditEmployee_AddSpeciality.Text = "Tilføj";
            this.button_UCEmployeeTCEdit_EditEmployee_AddSpeciality.UseVisualStyleBackColor = true;
            this.button_UCEmployeeTCEdit_EditEmployee_AddSpeciality.Click += new System.EventHandler(this.button_UCEmployeeTCEdit_EditEmployee_AddSpeciality_Click);
            // 
            // comboBox_UCEmployeeTCEdit_EditEmployee_Speciality
            // 
            this.comboBox_UCEmployeeTCEdit_EditEmployee_Speciality.FormattingEnabled = true;
            this.comboBox_UCEmployeeTCEdit_EditEmployee_Speciality.Location = new System.Drawing.Point(904, 15);
            this.comboBox_UCEmployeeTCEdit_EditEmployee_Speciality.Name = "comboBox_UCEmployeeTCEdit_EditEmployee_Speciality";
            this.comboBox_UCEmployeeTCEdit_EditEmployee_Speciality.Size = new System.Drawing.Size(121, 26);
            this.comboBox_UCEmployeeTCEdit_EditEmployee_Speciality.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(729, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(174, 18);
            this.label8.TabIndex = 12;
            this.label8.Text = "Tilføj efteruddannelse:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(99, 283);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(191, 26);
            this.comboBox1.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(99, 244);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(191, 24);
            this.textBox4.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(99, 204);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(191, 24);
            this.textBox3.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(99, 164);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(191, 24);
            this.textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(99, 124);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(191, 24);
            this.textBox1.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 18);
            this.label7.TabIndex = 5;
            this.label7.Text = "Rolle";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 18);
            this.label6.TabIndex = 4;
            this.label6.Text = "Telefon";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "E mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Efternavn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Fornavn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Redigere ansat";
            // 
            // TC_UCEmployeeTC_CreateEmployee
            // 
            this.TC_UCEmployeeTC_CreateEmployee.Controls.Add(this.ListBox_UCEmployeeTCCreate_CreateEmployee_ShowSpeciality);
            this.TC_UCEmployeeTC_CreateEmployee.Controls.Add(this.button_UCEmployeeTCCreate_FindEmployee);
            this.TC_UCEmployeeTC_CreateEmployee.Controls.Add(this.button_UCEmployeeTCCreate_CreateEmployee_SaveEmployee);
            this.TC_UCEmployeeTC_CreateEmployee.Controls.Add(this.button_UCEmployeeTCCreate_CreateEmployee_AddSpeciality);
            this.TC_UCEmployeeTC_CreateEmployee.Controls.Add(this.comboBox_UCEmployeeTCCreate_CreateEmployee_Speciality);
            this.TC_UCEmployeeTC_CreateEmployee.Controls.Add(this.label15);
            this.TC_UCEmployeeTC_CreateEmployee.Controls.Add(this.label14);
            this.TC_UCEmployeeTC_CreateEmployee.Controls.Add(this.combo_UCEmployeeTCCreate_Role);
            this.TC_UCEmployeeTC_CreateEmployee.Controls.Add(this.textbox_UCEmployeeTCCreate_phone);
            this.TC_UCEmployeeTC_CreateEmployee.Controls.Add(this.textbox_UCEmployeeTCCreate_emailName);
            this.TC_UCEmployeeTC_CreateEmployee.Controls.Add(this.textbox_UCEmployeeTCCreate_lastName);
            this.TC_UCEmployeeTC_CreateEmployee.Controls.Add(this.textbox_UCEmployeeTCCreate_firstName);
            this.TC_UCEmployeeTC_CreateEmployee.Controls.Add(this.label9);
            this.TC_UCEmployeeTC_CreateEmployee.Controls.Add(this.label10);
            this.TC_UCEmployeeTC_CreateEmployee.Controls.Add(this.label11);
            this.TC_UCEmployeeTC_CreateEmployee.Controls.Add(this.label12);
            this.TC_UCEmployeeTC_CreateEmployee.Controls.Add(this.label13);
            this.TC_UCEmployeeTC_CreateEmployee.Location = new System.Drawing.Point(4, 54);
            this.TC_UCEmployeeTC_CreateEmployee.Name = "TC_UCEmployeeTC_CreateEmployee";
            this.TC_UCEmployeeTC_CreateEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.TC_UCEmployeeTC_CreateEmployee.Size = new System.Drawing.Size(1149, 508);
            this.TC_UCEmployeeTC_CreateEmployee.TabIndex = 2;
            this.TC_UCEmployeeTC_CreateEmployee.Text = "Opret";
            this.TC_UCEmployeeTC_CreateEmployee.UseVisualStyleBackColor = true;
            // 
            // button_UCEmployeeTCCreate_FindEmployee
            // 
            this.button_UCEmployeeTCCreate_FindEmployee.Location = new System.Drawing.Point(6, 27);
            this.button_UCEmployeeTCCreate_FindEmployee.Name = "button_UCEmployeeTCCreate_FindEmployee";
            this.button_UCEmployeeTCCreate_FindEmployee.Size = new System.Drawing.Size(102, 30);
            this.button_UCEmployeeTCCreate_FindEmployee.TabIndex = 27;
            this.button_UCEmployeeTCCreate_FindEmployee.Text = "Find";
            this.button_UCEmployeeTCCreate_FindEmployee.UseVisualStyleBackColor = true;
            this.button_UCEmployeeTCCreate_FindEmployee.Click += new System.EventHandler(this.button_UCEmployeeTCCreate_FindEmployee_Click);
            // 
            // button_UCEmployeeTCCreate_CreateEmployee_SaveEmployee
            // 
            this.button_UCEmployeeTCCreate_CreateEmployee_SaveEmployee.Location = new System.Drawing.Point(995, 472);
            this.button_UCEmployeeTCCreate_CreateEmployee_SaveEmployee.Name = "button_UCEmployeeTCCreate_CreateEmployee_SaveEmployee";
            this.button_UCEmployeeTCCreate_CreateEmployee_SaveEmployee.Size = new System.Drawing.Size(138, 30);
            this.button_UCEmployeeTCCreate_CreateEmployee_SaveEmployee.TabIndex = 26;
            this.button_UCEmployeeTCCreate_CreateEmployee_SaveEmployee.Text = "Gem ændringer";
            this.button_UCEmployeeTCCreate_CreateEmployee_SaveEmployee.UseVisualStyleBackColor = true;
            this.button_UCEmployeeTCCreate_CreateEmployee_SaveEmployee.Click += new System.EventHandler(this.button_UCEmployeeTCCreate_CreateEmployee_SaveEmployee_Click);
            // 
            // button_UCEmployeeTCCreate_CreateEmployee_AddSpeciality
            // 
            this.button_UCEmployeeTCCreate_CreateEmployee_AddSpeciality.Location = new System.Drawing.Point(1031, 12);
            this.button_UCEmployeeTCCreate_CreateEmployee_AddSpeciality.Name = "button_UCEmployeeTCCreate_CreateEmployee_AddSpeciality";
            this.button_UCEmployeeTCCreate_CreateEmployee_AddSpeciality.Size = new System.Drawing.Size(102, 30);
            this.button_UCEmployeeTCCreate_CreateEmployee_AddSpeciality.TabIndex = 24;
            this.button_UCEmployeeTCCreate_CreateEmployee_AddSpeciality.Text = "Tilføj";
            this.button_UCEmployeeTCCreate_CreateEmployee_AddSpeciality.UseVisualStyleBackColor = true;
            this.button_UCEmployeeTCCreate_CreateEmployee_AddSpeciality.Click += new System.EventHandler(this.button_UCEmployeeTCCreate_CreateEmployee_AddSpeciality_Click);
            // 
            // comboBox_UCEmployeeTCCreate_CreateEmployee_Speciality
            // 
            this.comboBox_UCEmployeeTCCreate_CreateEmployee_Speciality.FormattingEnabled = true;
            this.comboBox_UCEmployeeTCCreate_CreateEmployee_Speciality.Location = new System.Drawing.Point(904, 15);
            this.comboBox_UCEmployeeTCCreate_CreateEmployee_Speciality.Name = "comboBox_UCEmployeeTCCreate_CreateEmployee_Speciality";
            this.comboBox_UCEmployeeTCCreate_CreateEmployee_Speciality.Size = new System.Drawing.Size(121, 26);
            this.comboBox_UCEmployeeTCCreate_CreateEmployee_Speciality.TabIndex = 23;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(729, 18);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(174, 18);
            this.label15.TabIndex = 22;
            this.label15.Text = "Tilføj efteruddannelse:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 6);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(96, 18);
            this.label14.TabIndex = 21;
            this.label14.Text = "Opret ansat";
            // 
            // combo_UCEmployeeTCCreate_Role
            // 
            this.combo_UCEmployeeTCCreate_Role.FormattingEnabled = true;
            this.combo_UCEmployeeTCCreate_Role.Location = new System.Drawing.Point(99, 283);
            this.combo_UCEmployeeTCCreate_Role.Name = "combo_UCEmployeeTCCreate_Role";
            this.combo_UCEmployeeTCCreate_Role.Size = new System.Drawing.Size(191, 26);
            this.combo_UCEmployeeTCCreate_Role.TabIndex = 20;
            // 
            // textbox_UCEmployeeTCCreate_phone
            // 
            this.textbox_UCEmployeeTCCreate_phone.Location = new System.Drawing.Point(99, 244);
            this.textbox_UCEmployeeTCCreate_phone.Name = "textbox_UCEmployeeTCCreate_phone";
            this.textbox_UCEmployeeTCCreate_phone.Size = new System.Drawing.Size(191, 24);
            this.textbox_UCEmployeeTCCreate_phone.TabIndex = 19;
            // 
            // textbox_UCEmployeeTCCreate_emailName
            // 
            this.textbox_UCEmployeeTCCreate_emailName.Location = new System.Drawing.Point(99, 204);
            this.textbox_UCEmployeeTCCreate_emailName.Name = "textbox_UCEmployeeTCCreate_emailName";
            this.textbox_UCEmployeeTCCreate_emailName.Size = new System.Drawing.Size(191, 24);
            this.textbox_UCEmployeeTCCreate_emailName.TabIndex = 18;
            // 
            // textbox_UCEmployeeTCCreate_lastName
            // 
            this.textbox_UCEmployeeTCCreate_lastName.Location = new System.Drawing.Point(99, 164);
            this.textbox_UCEmployeeTCCreate_lastName.Name = "textbox_UCEmployeeTCCreate_lastName";
            this.textbox_UCEmployeeTCCreate_lastName.Size = new System.Drawing.Size(191, 24);
            this.textbox_UCEmployeeTCCreate_lastName.TabIndex = 17;
            // 
            // textbox_UCEmployeeTCCreate_firstName
            // 
            this.textbox_UCEmployeeTCCreate_firstName.Location = new System.Drawing.Point(99, 124);
            this.textbox_UCEmployeeTCCreate_firstName.Name = "textbox_UCEmployeeTCCreate_firstName";
            this.textbox_UCEmployeeTCCreate_firstName.Size = new System.Drawing.Size(191, 24);
            this.textbox_UCEmployeeTCCreate_firstName.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 287);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 18);
            this.label9.TabIndex = 15;
            this.label9.Text = "Rolle";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 247);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 18);
            this.label10.TabIndex = 14;
            this.label10.Text = "Telefon";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 207);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 18);
            this.label11.TabIndex = 13;
            this.label11.Text = "E mail";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 167);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 18);
            this.label12.TabIndex = 12;
            this.label12.Text = "Efternavn";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 127);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 18);
            this.label13.TabIndex = 11;
            this.label13.Text = "Fornavn";
            // 
            // ListBox_UCEmployeeTCCreate_CreateEmployee_ShowSpeciality
            // 
            this.ListBox_UCEmployeeTCCreate_CreateEmployee_ShowSpeciality.FormattingEnabled = true;
            this.ListBox_UCEmployeeTCCreate_CreateEmployee_ShowSpeciality.ItemHeight = 18;
            this.ListBox_UCEmployeeTCCreate_CreateEmployee_ShowSpeciality.Location = new System.Drawing.Point(732, 54);
            this.ListBox_UCEmployeeTCCreate_CreateEmployee_ShowSpeciality.Name = "ListBox_UCEmployeeTCCreate_CreateEmployee_ShowSpeciality";
            this.ListBox_UCEmployeeTCCreate_CreateEmployee_ShowSpeciality.Size = new System.Drawing.Size(401, 400);
            this.ListBox_UCEmployeeTCCreate_CreateEmployee_ShowSpeciality.TabIndex = 28;
            // 
            // UserControlEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.TabControl_UCEmployee);
            this.Name = "UserControlEmployees";
            this.Size = new System.Drawing.Size(1157, 566);
            this.MouseEnter += new System.EventHandler(this.UserControlEmployees_MouseEnter);
            this.TabControl_UCEmployee.ResumeLayout(false);
            this.TC_UCEmployeeTC_FindEmployee.ResumeLayout(false);
            this.TC_UCEmployeeTC_FindEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectListView_UCEmployeeTCFind_FindEmployee)).EndInit();
            this.TC_UCEmployeeTC_EditEmployee.ResumeLayout(false);
            this.TC_UCEmployeeTC_EditEmployee.PerformLayout();
            this.TC_UCEmployeeTC_CreateEmployee.ResumeLayout(false);
            this.TC_UCEmployeeTC_CreateEmployee.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl_UCEmployee;
        private System.Windows.Forms.TabPage TC_UCEmployeeTC_FindEmployee;
        private System.Windows.Forms.TabPage TC_UCEmployeeTC_EditEmployee;
        private System.Windows.Forms.TabPage TC_UCEmployeeTC_CreateEmployee;
        private System.Windows.Forms.Button button_UCEmployeeTCFind_CreateEmployee;
        private System.Windows.Forms.Label label1;
        private BrightIdeasSoftware.DataListView objectListView_UCEmployeeTCFind_FindEmployee;
        private System.Windows.Forms.TextBox textBox_UCCaseTCFind_Search;
        private System.Windows.Forms.Label label_UCCaseTCFind_Search;
        private BrightIdeasSoftware.OLVColumn olvColumnEmployeeFindID;
        private BrightIdeasSoftware.OLVColumn olvColumnEmployeeFindFirstName;
        private BrightIdeasSoftware.OLVColumn olvColumnEmployeeFindLastName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox_UCEmployeeTCEdit_EditEmployee_Speciality;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button_UCEmployeeTCEdit_EditEmployee_SaveEmployee;
        private System.Windows.Forms.Button button_UCEmployeeTCEdit_EditEmployee_AddSpeciality;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox combo_UCEmployeeTCCreate_Role;
        private System.Windows.Forms.TextBox textbox_UCEmployeeTCCreate_phone;
        private System.Windows.Forms.TextBox textbox_UCEmployeeTCCreate_emailName;
        private System.Windows.Forms.TextBox textbox_UCEmployeeTCCreate_lastName;
        private System.Windows.Forms.TextBox textbox_UCEmployeeTCCreate_firstName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button_UCEmployeeTCCreate_CreateEmployee_SaveEmployee;
        private System.Windows.Forms.Button button_UCEmployeeTCCreate_CreateEmployee_AddSpeciality;
        private System.Windows.Forms.ComboBox comboBox_UCEmployeeTCCreate_CreateEmployee_Speciality;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button_UCEmployeeTCCreate_FindEmployee;
        private System.Windows.Forms.Button button_UCEmployeeTCEdit_Back_FindEmployee;
        private System.Windows.Forms.ListBox ListBox_UCEmployeeTCEdit_EditEmployee_ShowSpeciality;
        private System.Windows.Forms.ListBox ListBox_UCEmployeeTCCreate_CreateEmployee_ShowSpeciality;
    }
}
