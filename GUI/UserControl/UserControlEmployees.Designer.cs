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
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn3 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.TC_UCEmployeeTC_EditEmployee = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataListView2 = new BrightIdeasSoftware.DataListView();
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
            this.button4 = new System.Windows.Forms.Button();
            this.dataListView3 = new BrightIdeasSoftware.DataListView();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.TabControl_UCEmployee.SuspendLayout();
            this.TC_UCEmployeeTC_FindEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectListView_UCEmployeeTCFind_FindEmployee)).BeginInit();
            this.TC_UCEmployeeTC_EditEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListView2)).BeginInit();
            this.TC_UCEmployeeTC_CreateEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListView3)).BeginInit();
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
            this.objectListView_UCEmployeeTCFind_FindEmployee.AllColumns.Add(this.olvColumn1);
            this.objectListView_UCEmployeeTCFind_FindEmployee.AllColumns.Add(this.olvColumn2);
            this.objectListView_UCEmployeeTCFind_FindEmployee.AllColumns.Add(this.olvColumn3);
            this.objectListView_UCEmployeeTCFind_FindEmployee.CellEditUseWholeCell = false;
            this.objectListView_UCEmployeeTCFind_FindEmployee.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1,
            this.olvColumn2,
            this.olvColumn3});
            this.objectListView_UCEmployeeTCFind_FindEmployee.Cursor = System.Windows.Forms.Cursors.Default;
            this.objectListView_UCEmployeeTCFind_FindEmployee.DataSource = null;
            this.objectListView_UCEmployeeTCFind_FindEmployee.Location = new System.Drawing.Point(9, 97);
            this.objectListView_UCEmployeeTCFind_FindEmployee.Name = "objectListView_UCEmployeeTCFind_FindEmployee";
            this.objectListView_UCEmployeeTCFind_FindEmployee.Size = new System.Drawing.Size(1134, 396);
            this.objectListView_UCEmployeeTCFind_FindEmployee.TabIndex = 0;
            this.objectListView_UCEmployeeTCFind_FindEmployee.UseCompatibleStateImageBehavior = false;
            this.objectListView_UCEmployeeTCFind_FindEmployee.View = System.Windows.Forms.View.Details;
            this.objectListView_UCEmployeeTCFind_FindEmployee.MouseEnter += new System.EventHandler(this.UserControlEmployees_MouseEnter);
            // 
            // olvColumn1
            // 
            this.olvColumn1.Text = "Id";
            // 
            // olvColumn2
            // 
            this.olvColumn2.Text = "Fornavn";
            this.olvColumn2.Width = 76;
            // 
            // olvColumn3
            // 
            this.olvColumn3.Text = "Efternavn";
            this.olvColumn3.Width = 89;
            // 
            // TC_UCEmployeeTC_EditEmployee
            // 
            this.TC_UCEmployeeTC_EditEmployee.Controls.Add(this.button2);
            this.TC_UCEmployeeTC_EditEmployee.Controls.Add(this.button1);
            this.TC_UCEmployeeTC_EditEmployee.Controls.Add(this.comboBox2);
            this.TC_UCEmployeeTC_EditEmployee.Controls.Add(this.label8);
            this.TC_UCEmployeeTC_EditEmployee.Controls.Add(this.dataListView2);
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(995, 472);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 30);
            this.button2.TabIndex = 15;
            this.button2.Text = "Gem ændringer";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1031, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 30);
            this.button1.TabIndex = 14;
            this.button1.Text = "Tilføj";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(904, 15);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 26);
            this.comboBox2.TabIndex = 13;
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
            // dataListView2
            // 
            this.dataListView2.CellEditUseWholeCell = false;
            this.dataListView2.DataSource = null;
            this.dataListView2.Location = new System.Drawing.Point(352, 48);
            this.dataListView2.Name = "dataListView2";
            this.dataListView2.Size = new System.Drawing.Size(781, 351);
            this.dataListView2.TabIndex = 11;
            this.dataListView2.UseCompatibleStateImageBehavior = false;
            this.dataListView2.View = System.Windows.Forms.View.Details;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(99, 283);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 26);
            this.comboBox1.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(99, 244);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(121, 24);
            this.textBox4.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(99, 204);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(121, 24);
            this.textBox3.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(99, 164);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 24);
            this.textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(99, 124);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 24);
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
            this.TC_UCEmployeeTC_CreateEmployee.Controls.Add(this.button_UCEmployeeTCCreate_FindEmployee);
            this.TC_UCEmployeeTC_CreateEmployee.Controls.Add(this.button4);
            this.TC_UCEmployeeTC_CreateEmployee.Controls.Add(this.dataListView3);
            this.TC_UCEmployeeTC_CreateEmployee.Controls.Add(this.button3);
            this.TC_UCEmployeeTC_CreateEmployee.Controls.Add(this.comboBox4);
            this.TC_UCEmployeeTC_CreateEmployee.Controls.Add(this.label15);
            this.TC_UCEmployeeTC_CreateEmployee.Controls.Add(this.label14);
            this.TC_UCEmployeeTC_CreateEmployee.Controls.Add(this.comboBox3);
            this.TC_UCEmployeeTC_CreateEmployee.Controls.Add(this.textBox5);
            this.TC_UCEmployeeTC_CreateEmployee.Controls.Add(this.textBox6);
            this.TC_UCEmployeeTC_CreateEmployee.Controls.Add(this.textBox7);
            this.TC_UCEmployeeTC_CreateEmployee.Controls.Add(this.textBox8);
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
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(995, 472);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(138, 30);
            this.button4.TabIndex = 26;
            this.button4.Text = "Gem ændringer";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // dataListView3
            // 
            this.dataListView3.CellEditUseWholeCell = false;
            this.dataListView3.DataSource = null;
            this.dataListView3.Location = new System.Drawing.Point(352, 48);
            this.dataListView3.Name = "dataListView3";
            this.dataListView3.Size = new System.Drawing.Size(781, 351);
            this.dataListView3.TabIndex = 25;
            this.dataListView3.UseCompatibleStateImageBehavior = false;
            this.dataListView3.View = System.Windows.Forms.View.Details;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1031, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 30);
            this.button3.TabIndex = 24;
            this.button3.Text = "Tilføj";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(904, 15);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 26);
            this.comboBox4.TabIndex = 23;
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
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(99, 283);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 26);
            this.comboBox3.TabIndex = 20;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(99, 244);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(121, 24);
            this.textBox5.TabIndex = 19;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(99, 204);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(121, 24);
            this.textBox6.TabIndex = 18;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(99, 164);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(121, 24);
            this.textBox7.TabIndex = 17;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(99, 124);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(121, 24);
            this.textBox8.TabIndex = 16;
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
            ((System.ComponentModel.ISupportInitialize)(this.dataListView2)).EndInit();
            this.TC_UCEmployeeTC_CreateEmployee.ResumeLayout(false);
            this.TC_UCEmployeeTC_CreateEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListView3)).EndInit();
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
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private BrightIdeasSoftware.OLVColumn olvColumn2;
        private BrightIdeasSoftware.OLVColumn olvColumn3;
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
        private BrightIdeasSoftware.DataListView dataListView2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button4;
        private BrightIdeasSoftware.DataListView dataListView3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button_UCEmployeeTCCreate_FindEmployee;
    }
}
