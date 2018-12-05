namespace GUI
{
    partial class UserControlClients
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
            this.TabControl_UCClient = new System.Windows.Forms.TabControl();
            this.TC_UCEmployeeTC_FindClient = new System.Windows.Forms.TabPage();
            this.textBox_UCCaseTCFind_Search = new System.Windows.Forms.TextBox();
            this.label_UCCaseTCFind_Search = new System.Windows.Forms.Label();
            this.objectListView_UCClientTCFind_FindClient = new BrightIdeasSoftware.DataListView();
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn3 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn4 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn5 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.button_UCClientTCFind_CreateClient = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TC_UCEmployeeTC_EditClient = new System.Windows.Forms.TabPage();
            this.bottom_UCClientTCEdit_Back = new System.Windows.Forms.Button();
            this.bottom_UCClientTCEdit_Save = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.dataListView_UCClientTCEdit = new BrightIdeasSoftware.DataListView();
            this.olvColumn_UCClient_TCEdit_cases_name = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn_UCClient_TCEdit_laywer_name = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.textbox_UCClientTCEdit_email = new System.Windows.Forms.TextBox();
            this.textbox_UCClientTCEdit_addresse = new System.Windows.Forms.TextBox();
            this.textbox_UCClientTCEdit_phone = new System.Windows.Forms.TextBox();
            this.textbox_UCClientTCEdit_lastName = new System.Windows.Forms.TextBox();
            this.textbox_UCClientTCEdit_firstName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TC_UCEmployeeTC_CreateClient = new System.Windows.Forms.TabPage();
            this.label_UCClientTCCreate_Save = new System.Windows.Forms.Label();
            this.bottom_UCClientTCCreate_Save = new System.Windows.Forms.Button();
            this.textbox_UCClientTCCreate_email = new System.Windows.Forms.TextBox();
            this.textbox_UCClientTCCreate_addresse = new System.Windows.Forms.TextBox();
            this.textbox_UCClientTCCreate_phone = new System.Windows.Forms.TextBox();
            this.textbox_UCClientTCCreate_lastName = new System.Windows.Forms.TextBox();
            this.textbox_UCClientTCCreate_firstName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_UCClientTCCreate_FindClient = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TabControl_UCClient.SuspendLayout();
            this.TC_UCEmployeeTC_FindClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectListView_UCClientTCFind_FindClient)).BeginInit();
            this.TC_UCEmployeeTC_EditClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListView_UCClientTCEdit)).BeginInit();
            this.TC_UCEmployeeTC_CreateClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl_UCClient
            // 
            this.TabControl_UCClient.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.TabControl_UCClient.Controls.Add(this.TC_UCEmployeeTC_FindClient);
            this.TabControl_UCClient.Controls.Add(this.TC_UCEmployeeTC_EditClient);
            this.TabControl_UCClient.Controls.Add(this.TC_UCEmployeeTC_CreateClient);
            this.TabControl_UCClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl_UCClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.TabControl_UCClient.ItemSize = new System.Drawing.Size(100, 50);
            this.TabControl_UCClient.Location = new System.Drawing.Point(0, 0);
            this.TabControl_UCClient.Name = "TabControl_UCClient";
            this.TabControl_UCClient.SelectedIndex = 0;
            this.TabControl_UCClient.Size = new System.Drawing.Size(1157, 566);
            this.TabControl_UCClient.TabIndex = 0;
            // 
            // TC_UCEmployeeTC_FindClient
            // 
            this.TC_UCEmployeeTC_FindClient.BackColor = System.Drawing.Color.White;
            this.TC_UCEmployeeTC_FindClient.Controls.Add(this.textBox_UCCaseTCFind_Search);
            this.TC_UCEmployeeTC_FindClient.Controls.Add(this.label_UCCaseTCFind_Search);
            this.TC_UCEmployeeTC_FindClient.Controls.Add(this.objectListView_UCClientTCFind_FindClient);
            this.TC_UCEmployeeTC_FindClient.Controls.Add(this.button_UCClientTCFind_CreateClient);
            this.TC_UCEmployeeTC_FindClient.Controls.Add(this.label2);
            this.TC_UCEmployeeTC_FindClient.Location = new System.Drawing.Point(4, 54);
            this.TC_UCEmployeeTC_FindClient.Name = "TC_UCEmployeeTC_FindClient";
            this.TC_UCEmployeeTC_FindClient.Padding = new System.Windows.Forms.Padding(3);
            this.TC_UCEmployeeTC_FindClient.Size = new System.Drawing.Size(1149, 508);
            this.TC_UCEmployeeTC_FindClient.TabIndex = 0;
            this.TC_UCEmployeeTC_FindClient.Text = "Find";
            // 
            // textBox_UCCaseTCFind_Search
            // 
            this.textBox_UCCaseTCFind_Search.Location = new System.Drawing.Point(1022, 67);
            this.textBox_UCCaseTCFind_Search.Name = "textBox_UCCaseTCFind_Search";
            this.textBox_UCCaseTCFind_Search.Size = new System.Drawing.Size(121, 24);
            this.textBox_UCCaseTCFind_Search.TabIndex = 15;
            this.textBox_UCCaseTCFind_Search.TextChanged += new System.EventHandler(this.textBox_UCCaseTCFind_Search_TextChanged);
            // 
            // label_UCCaseTCFind_Search
            // 
            this.label_UCCaseTCFind_Search.AutoSize = true;
            this.label_UCCaseTCFind_Search.Location = new System.Drawing.Point(980, 67);
            this.label_UCCaseTCFind_Search.Name = "label_UCCaseTCFind_Search";
            this.label_UCCaseTCFind_Search.Size = new System.Drawing.Size(38, 18);
            this.label_UCCaseTCFind_Search.TabIndex = 14;
            this.label_UCCaseTCFind_Search.Text = "Søg";
            // 
            // objectListView_UCClientTCFind_FindClient
            // 
            this.objectListView_UCClientTCFind_FindClient.AllColumns.Add(this.olvColumn1);
            this.objectListView_UCClientTCFind_FindClient.AllColumns.Add(this.olvColumn2);
            this.objectListView_UCClientTCFind_FindClient.AllColumns.Add(this.olvColumn3);
            this.objectListView_UCClientTCFind_FindClient.AllColumns.Add(this.olvColumn4);
            this.objectListView_UCClientTCFind_FindClient.AllColumns.Add(this.olvColumn5);
            this.objectListView_UCClientTCFind_FindClient.CellEditUseWholeCell = false;
            this.objectListView_UCClientTCFind_FindClient.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1,
            this.olvColumn2,
            this.olvColumn3,
            this.olvColumn4,
            this.olvColumn5});
            this.objectListView_UCClientTCFind_FindClient.Cursor = System.Windows.Forms.Cursors.Default;
            this.objectListView_UCClientTCFind_FindClient.DataSource = null;
            this.objectListView_UCClientTCFind_FindClient.FullRowSelect = true;
            this.objectListView_UCClientTCFind_FindClient.GridLines = true;
            this.objectListView_UCClientTCFind_FindClient.Location = new System.Drawing.Point(9, 97);
            this.objectListView_UCClientTCFind_FindClient.Name = "objectListView_UCClientTCFind_FindClient";
            this.objectListView_UCClientTCFind_FindClient.ShowGroups = false;
            this.objectListView_UCClientTCFind_FindClient.Size = new System.Drawing.Size(1134, 396);
            this.objectListView_UCClientTCFind_FindClient.TabIndex = 4;
            this.objectListView_UCClientTCFind_FindClient.UseCompatibleStateImageBehavior = false;
            this.objectListView_UCClientTCFind_FindClient.View = System.Windows.Forms.View.Details;
            this.objectListView_UCClientTCFind_FindClient.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.objectListView_UCClientTCFind_FindClient_MouseDoubleClick);
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "FirstName";
            this.olvColumn1.Text = "Fornavn";
            this.olvColumn1.Width = 126;
            // 
            // olvColumn2
            // 
            this.olvColumn2.AspectName = "LastName";
            this.olvColumn2.Text = "Efternavn";
            this.olvColumn2.Width = 137;
            // 
            // olvColumn3
            // 
            this.olvColumn3.AspectName = "Phone";
            this.olvColumn3.Text = "Telefon";
            this.olvColumn3.Width = 131;
            // 
            // olvColumn4
            // 
            this.olvColumn4.AspectName = "Address";
            this.olvColumn4.Text = "Adresse";
            this.olvColumn4.Width = 222;
            // 
            // olvColumn5
            // 
            this.olvColumn5.AspectName = "Email";
            this.olvColumn5.Text = "Email";
            this.olvColumn5.Width = 177;
            // 
            // button_UCClientTCFind_CreateClient
            // 
            this.button_UCClientTCFind_CreateClient.Location = new System.Drawing.Point(6, 27);
            this.button_UCClientTCFind_CreateClient.Name = "button_UCClientTCFind_CreateClient";
            this.button_UCClientTCFind_CreateClient.Size = new System.Drawing.Size(102, 30);
            this.button_UCClientTCFind_CreateClient.TabIndex = 3;
            this.button_UCClientTCFind_CreateClient.Text = "Opret";
            this.button_UCClientTCFind_CreateClient.UseVisualStyleBackColor = true;
            this.button_UCClientTCFind_CreateClient.Click += new System.EventHandler(this.button_UCClientTCFind_CreateClient_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Find klient";
            // 
            // TC_UCEmployeeTC_EditClient
            // 
            this.TC_UCEmployeeTC_EditClient.Controls.Add(this.bottom_UCClientTCEdit_Back);
            this.TC_UCEmployeeTC_EditClient.Controls.Add(this.bottom_UCClientTCEdit_Save);
            this.TC_UCEmployeeTC_EditClient.Controls.Add(this.label14);
            this.TC_UCEmployeeTC_EditClient.Controls.Add(this.dataListView_UCClientTCEdit);
            this.TC_UCEmployeeTC_EditClient.Controls.Add(this.textbox_UCClientTCEdit_email);
            this.TC_UCEmployeeTC_EditClient.Controls.Add(this.textbox_UCClientTCEdit_addresse);
            this.TC_UCEmployeeTC_EditClient.Controls.Add(this.textbox_UCClientTCEdit_phone);
            this.TC_UCEmployeeTC_EditClient.Controls.Add(this.textbox_UCClientTCEdit_lastName);
            this.TC_UCEmployeeTC_EditClient.Controls.Add(this.textbox_UCClientTCEdit_firstName);
            this.TC_UCEmployeeTC_EditClient.Controls.Add(this.label9);
            this.TC_UCEmployeeTC_EditClient.Controls.Add(this.label10);
            this.TC_UCEmployeeTC_EditClient.Controls.Add(this.label11);
            this.TC_UCEmployeeTC_EditClient.Controls.Add(this.label12);
            this.TC_UCEmployeeTC_EditClient.Controls.Add(this.label13);
            this.TC_UCEmployeeTC_EditClient.Controls.Add(this.label3);
            this.TC_UCEmployeeTC_EditClient.Location = new System.Drawing.Point(4, 54);
            this.TC_UCEmployeeTC_EditClient.Name = "TC_UCEmployeeTC_EditClient";
            this.TC_UCEmployeeTC_EditClient.Padding = new System.Windows.Forms.Padding(3);
            this.TC_UCEmployeeTC_EditClient.Size = new System.Drawing.Size(1149, 508);
            this.TC_UCEmployeeTC_EditClient.TabIndex = 1;
            this.TC_UCEmployeeTC_EditClient.Text = "Ændre";
            this.TC_UCEmployeeTC_EditClient.UseVisualStyleBackColor = true;
            // 
            // bottom_UCClientTCEdit_Back
            // 
            this.bottom_UCClientTCEdit_Back.Location = new System.Drawing.Point(6, 27);
            this.bottom_UCClientTCEdit_Back.Name = "bottom_UCClientTCEdit_Back";
            this.bottom_UCClientTCEdit_Back.Size = new System.Drawing.Size(102, 30);
            this.bottom_UCClientTCEdit_Back.TabIndex = 25;
            this.bottom_UCClientTCEdit_Back.Text = "Tilbage";
            this.bottom_UCClientTCEdit_Back.UseVisualStyleBackColor = true;
            this.bottom_UCClientTCEdit_Back.Click += new System.EventHandler(this.bottom_UCClientTCEdit_Back_Click);
            // 
            // bottom_UCClientTCEdit_Save
            // 
            this.bottom_UCClientTCEdit_Save.Location = new System.Drawing.Point(995, 405);
            this.bottom_UCClientTCEdit_Save.Name = "bottom_UCClientTCEdit_Save";
            this.bottom_UCClientTCEdit_Save.Size = new System.Drawing.Size(138, 30);
            this.bottom_UCClientTCEdit_Save.TabIndex = 24;
            this.bottom_UCClientTCEdit_Save.Text = "Gem ændringer";
            this.bottom_UCClientTCEdit_Save.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(349, 27);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(183, 18);
            this.label14.TabIndex = 23;
            this.label14.Text = "Liste over klients sager";
            // 
            // dataListView_UCClientTCEdit
            // 
            this.dataListView_UCClientTCEdit.AllColumns.Add(this.olvColumn_UCClient_TCEdit_cases_name);
            this.dataListView_UCClientTCEdit.AllColumns.Add(this.olvColumn_UCClient_TCEdit_laywer_name);
            this.dataListView_UCClientTCEdit.CellEditUseWholeCell = false;
            this.dataListView_UCClientTCEdit.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn_UCClient_TCEdit_cases_name,
            this.olvColumn_UCClient_TCEdit_laywer_name});
            this.dataListView_UCClientTCEdit.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataListView_UCClientTCEdit.DataSource = null;
            this.dataListView_UCClientTCEdit.Location = new System.Drawing.Point(352, 48);
            this.dataListView_UCClientTCEdit.Name = "dataListView_UCClientTCEdit";
            this.dataListView_UCClientTCEdit.Size = new System.Drawing.Size(781, 351);
            this.dataListView_UCClientTCEdit.TabIndex = 22;
            this.dataListView_UCClientTCEdit.UseCompatibleStateImageBehavior = false;
            this.dataListView_UCClientTCEdit.View = System.Windows.Forms.View.Details;
            // 
            // olvColumn_UCClient_TCEdit_cases_name
            // 
            this.olvColumn_UCClient_TCEdit_cases_name.AspectName = "Title";
            this.olvColumn_UCClient_TCEdit_cases_name.Text = "Sager";
            this.olvColumn_UCClient_TCEdit_cases_name.Width = 466;
            // 
            // olvColumn_UCClient_TCEdit_laywer_name
            // 
            this.olvColumn_UCClient_TCEdit_laywer_name.Text = "Advokat";
            this.olvColumn_UCClient_TCEdit_laywer_name.Width = 205;
            // 
            // textbox_UCClientTCEdit_email
            // 
            this.textbox_UCClientTCEdit_email.Location = new System.Drawing.Point(118, 281);
            this.textbox_UCClientTCEdit_email.Name = "textbox_UCClientTCEdit_email";
            this.textbox_UCClientTCEdit_email.Size = new System.Drawing.Size(144, 24);
            this.textbox_UCClientTCEdit_email.TabIndex = 21;
            // 
            // textbox_UCClientTCEdit_addresse
            // 
            this.textbox_UCClientTCEdit_addresse.Location = new System.Drawing.Point(118, 241);
            this.textbox_UCClientTCEdit_addresse.Name = "textbox_UCClientTCEdit_addresse";
            this.textbox_UCClientTCEdit_addresse.Size = new System.Drawing.Size(144, 24);
            this.textbox_UCClientTCEdit_addresse.TabIndex = 20;
            // 
            // textbox_UCClientTCEdit_phone
            // 
            this.textbox_UCClientTCEdit_phone.Location = new System.Drawing.Point(118, 203);
            this.textbox_UCClientTCEdit_phone.Name = "textbox_UCClientTCEdit_phone";
            this.textbox_UCClientTCEdit_phone.Size = new System.Drawing.Size(144, 24);
            this.textbox_UCClientTCEdit_phone.TabIndex = 19;
            // 
            // textbox_UCClientTCEdit_lastName
            // 
            this.textbox_UCClientTCEdit_lastName.Location = new System.Drawing.Point(118, 168);
            this.textbox_UCClientTCEdit_lastName.Name = "textbox_UCClientTCEdit_lastName";
            this.textbox_UCClientTCEdit_lastName.Size = new System.Drawing.Size(144, 24);
            this.textbox_UCClientTCEdit_lastName.TabIndex = 18;
            // 
            // textbox_UCClientTCEdit_firstName
            // 
            this.textbox_UCClientTCEdit_firstName.Location = new System.Drawing.Point(118, 129);
            this.textbox_UCClientTCEdit_firstName.Name = "textbox_UCClientTCEdit_firstName";
            this.textbox_UCClientTCEdit_firstName.Size = new System.Drawing.Size(144, 24);
            this.textbox_UCClientTCEdit_firstName.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 284);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 18);
            this.label9.TabIndex = 16;
            this.label9.Text = "E mail";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 244);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 18);
            this.label10.TabIndex = 15;
            this.label10.Text = "Adresse";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 206);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 18);
            this.label11.TabIndex = 14;
            this.label11.Text = "Telefon";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 171);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 18);
            this.label12.TabIndex = 13;
            this.label12.Text = "Efternavn";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(21, 132);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 18);
            this.label13.TabIndex = 12;
            this.label13.Text = "Fornavn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ændre klient";
            // 
            // TC_UCEmployeeTC_CreateClient
            // 
            this.TC_UCEmployeeTC_CreateClient.Controls.Add(this.label_UCClientTCCreate_Save);
            this.TC_UCEmployeeTC_CreateClient.Controls.Add(this.bottom_UCClientTCCreate_Save);
            this.TC_UCEmployeeTC_CreateClient.Controls.Add(this.textbox_UCClientTCCreate_email);
            this.TC_UCEmployeeTC_CreateClient.Controls.Add(this.textbox_UCClientTCCreate_addresse);
            this.TC_UCEmployeeTC_CreateClient.Controls.Add(this.textbox_UCClientTCCreate_phone);
            this.TC_UCEmployeeTC_CreateClient.Controls.Add(this.textbox_UCClientTCCreate_lastName);
            this.TC_UCEmployeeTC_CreateClient.Controls.Add(this.textbox_UCClientTCCreate_firstName);
            this.TC_UCEmployeeTC_CreateClient.Controls.Add(this.label8);
            this.TC_UCEmployeeTC_CreateClient.Controls.Add(this.label7);
            this.TC_UCEmployeeTC_CreateClient.Controls.Add(this.label6);
            this.TC_UCEmployeeTC_CreateClient.Controls.Add(this.label5);
            this.TC_UCEmployeeTC_CreateClient.Controls.Add(this.label4);
            this.TC_UCEmployeeTC_CreateClient.Controls.Add(this.button_UCClientTCCreate_FindClient);
            this.TC_UCEmployeeTC_CreateClient.Controls.Add(this.label1);
            this.TC_UCEmployeeTC_CreateClient.Location = new System.Drawing.Point(4, 54);
            this.TC_UCEmployeeTC_CreateClient.Name = "TC_UCEmployeeTC_CreateClient";
            this.TC_UCEmployeeTC_CreateClient.Padding = new System.Windows.Forms.Padding(3);
            this.TC_UCEmployeeTC_CreateClient.Size = new System.Drawing.Size(1149, 508);
            this.TC_UCEmployeeTC_CreateClient.TabIndex = 2;
            this.TC_UCEmployeeTC_CreateClient.Text = "Opret";
            this.TC_UCEmployeeTC_CreateClient.UseVisualStyleBackColor = true;
            // 
            // label_UCClientTCCreate_Save
            // 
            this.label_UCClientTCCreate_Save.AutoSize = true;
            this.label_UCClientTCCreate_Save.Location = new System.Drawing.Point(990, 487);
            this.label_UCClientTCCreate_Save.Name = "label_UCClientTCCreate_Save";
            this.label_UCClientTCCreate_Save.Size = new System.Drawing.Size(0, 18);
            this.label_UCClientTCCreate_Save.TabIndex = 26;
            // 
            // bottom_UCClientTCCreate_Save
            // 
            this.bottom_UCClientTCCreate_Save.Location = new System.Drawing.Point(993, 450);
            this.bottom_UCClientTCCreate_Save.Name = "bottom_UCClientTCCreate_Save";
            this.bottom_UCClientTCCreate_Save.Size = new System.Drawing.Size(138, 30);
            this.bottom_UCClientTCCreate_Save.TabIndex = 25;
            this.bottom_UCClientTCCreate_Save.Text = "Gem ændringer";
            this.bottom_UCClientTCCreate_Save.UseVisualStyleBackColor = true;
            this.bottom_UCClientTCCreate_Save.Click += new System.EventHandler(this.bottom_UCClientTCCreate_Save_Click);
            // 
            // textbox_UCClientTCCreate_email
            // 
            this.textbox_UCClientTCCreate_email.Location = new System.Drawing.Point(118, 281);
            this.textbox_UCClientTCCreate_email.Name = "textbox_UCClientTCCreate_email";
            this.textbox_UCClientTCCreate_email.Size = new System.Drawing.Size(144, 24);
            this.textbox_UCClientTCCreate_email.TabIndex = 11;
            // 
            // textbox_UCClientTCCreate_addresse
            // 
            this.textbox_UCClientTCCreate_addresse.Location = new System.Drawing.Point(118, 241);
            this.textbox_UCClientTCCreate_addresse.Name = "textbox_UCClientTCCreate_addresse";
            this.textbox_UCClientTCCreate_addresse.Size = new System.Drawing.Size(144, 24);
            this.textbox_UCClientTCCreate_addresse.TabIndex = 10;
            // 
            // textbox_UCClientTCCreate_phone
            // 
            this.textbox_UCClientTCCreate_phone.Location = new System.Drawing.Point(118, 203);
            this.textbox_UCClientTCCreate_phone.Name = "textbox_UCClientTCCreate_phone";
            this.textbox_UCClientTCCreate_phone.Size = new System.Drawing.Size(144, 24);
            this.textbox_UCClientTCCreate_phone.TabIndex = 9;
            // 
            // textbox_UCClientTCCreate_lastName
            // 
            this.textbox_UCClientTCCreate_lastName.Location = new System.Drawing.Point(118, 168);
            this.textbox_UCClientTCCreate_lastName.Name = "textbox_UCClientTCCreate_lastName";
            this.textbox_UCClientTCCreate_lastName.Size = new System.Drawing.Size(144, 24);
            this.textbox_UCClientTCCreate_lastName.TabIndex = 8;
            // 
            // textbox_UCClientTCCreate_firstName
            // 
            this.textbox_UCClientTCCreate_firstName.Location = new System.Drawing.Point(118, 129);
            this.textbox_UCClientTCCreate_firstName.Name = "textbox_UCClientTCCreate_firstName";
            this.textbox_UCClientTCCreate_firstName.Size = new System.Drawing.Size(144, 24);
            this.textbox_UCClientTCCreate_firstName.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 284);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 18);
            this.label8.TabIndex = 6;
            this.label8.Text = "E mail";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 18);
            this.label7.TabIndex = 5;
            this.label7.Text = "Adresse";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 18);
            this.label6.TabIndex = 4;
            this.label6.Text = "Telefon";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Efternavn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Fornavn";
            // 
            // button_UCClientTCCreate_FindClient
            // 
            this.button_UCClientTCCreate_FindClient.Location = new System.Drawing.Point(6, 27);
            this.button_UCClientTCCreate_FindClient.Name = "button_UCClientTCCreate_FindClient";
            this.button_UCClientTCCreate_FindClient.Size = new System.Drawing.Size(102, 30);
            this.button_UCClientTCCreate_FindClient.TabIndex = 1;
            this.button_UCClientTCCreate_FindClient.Text = "Find";
            this.button_UCClientTCCreate_FindClient.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Opret klient";
            // 
            // UserControlClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.TabControl_UCClient);
            this.Name = "UserControlClients";
            this.Size = new System.Drawing.Size(1157, 566);
            this.MouseEnter += new System.EventHandler(this.UserControlClients_MouseEnter);
            this.TabControl_UCClient.ResumeLayout(false);
            this.TC_UCEmployeeTC_FindClient.ResumeLayout(false);
            this.TC_UCEmployeeTC_FindClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectListView_UCClientTCFind_FindClient)).EndInit();
            this.TC_UCEmployeeTC_EditClient.ResumeLayout(false);
            this.TC_UCEmployeeTC_EditClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListView_UCClientTCEdit)).EndInit();
            this.TC_UCEmployeeTC_CreateClient.ResumeLayout(false);
            this.TC_UCEmployeeTC_CreateClient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl_UCClient;
        private System.Windows.Forms.TabPage TC_UCEmployeeTC_FindClient;
        private System.Windows.Forms.TabPage TC_UCEmployeeTC_EditClient;
        private System.Windows.Forms.TabPage TC_UCEmployeeTC_CreateClient;
        private System.Windows.Forms.Button button_UCClientTCCreate_FindClient;
        private System.Windows.Forms.Label label1;
        private BrightIdeasSoftware.DataListView objectListView_UCClientTCFind_FindClient;
        private System.Windows.Forms.Button button_UCClientTCFind_CreateClient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_UCCaseTCFind_Search;
        private System.Windows.Forms.Label label_UCCaseTCFind_Search;
        private BrightIdeasSoftware.DataListView dataListView_UCClientTCEdit;
        private System.Windows.Forms.TextBox textbox_UCClientTCEdit_email;
        private System.Windows.Forms.TextBox textbox_UCClientTCEdit_addresse;
        private System.Windows.Forms.TextBox textbox_UCClientTCEdit_phone;
        private System.Windows.Forms.TextBox textbox_UCClientTCEdit_lastName;
        private System.Windows.Forms.TextBox textbox_UCClientTCEdit_firstName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textbox_UCClientTCCreate_email;
        private System.Windows.Forms.TextBox textbox_UCClientTCCreate_addresse;
        private System.Windows.Forms.TextBox textbox_UCClientTCCreate_phone;
        private System.Windows.Forms.TextBox textbox_UCClientTCCreate_lastName;
        private System.Windows.Forms.TextBox textbox_UCClientTCCreate_firstName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button bottom_UCClientTCEdit_Save;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private BrightIdeasSoftware.OLVColumn olvColumn2;
        private BrightIdeasSoftware.OLVColumn olvColumn3;
        private BrightIdeasSoftware.OLVColumn olvColumn4;
        private BrightIdeasSoftware.OLVColumn olvColumn5;
        private System.Windows.Forms.Button bottom_UCClientTCCreate_Save;
        private System.Windows.Forms.Label label_UCClientTCCreate_Save;
        private System.Windows.Forms.Button bottom_UCClientTCEdit_Back;
        private BrightIdeasSoftware.OLVColumn olvColumn_UCClient_TCEdit_cases_name;
        private BrightIdeasSoftware.OLVColumn olvColumn_UCClient_TCEdit_laywer_name;
    }
}
