namespace GUI
{
    partial class UserControlCases
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
            this.components = new System.ComponentModel.Container();
            this.TabControlCases = new System.Windows.Forms.TabControl();
            this.FindCase = new System.Windows.Forms.TabPage();
            this.FindbtnEdit = new System.Windows.Forms.Button();
            this.dataListView1 = new BrightIdeasSoftware.DataListView();
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.label3 = new System.Windows.Forms.Label();
            this.FindbtnCreate = new System.Windows.Forms.Button();
            this.EditCase = new System.Windows.Forms.TabPage();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.EditbtnCreate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.EditBtnFind = new System.Windows.Forms.Button();
            this.CreateCase = new System.Windows.Forms.TabPage();
            this.CreatebtnEdit = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CreatebtnFind = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.imageListCases = new System.Windows.Forms.ImageList(this.components);
            this.TabControlCases.SuspendLayout();
            this.FindCase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListView1)).BeginInit();
            this.EditCase.SuspendLayout();
            this.CreateCase.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControlCases
            // 
            this.TabControlCases.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.TabControlCases.Controls.Add(this.FindCase);
            this.TabControlCases.Controls.Add(this.EditCase);
            this.TabControlCases.Controls.Add(this.CreateCase);
            this.TabControlCases.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControlCases.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControlCases.ItemSize = new System.Drawing.Size(0, 1);
            this.TabControlCases.Location = new System.Drawing.Point(69, 37);
            this.TabControlCases.Margin = new System.Windows.Forms.Padding(5);
            this.TabControlCases.Name = "TabControlCases";
            this.TabControlCases.Padding = new System.Drawing.Point(0, 0);
            this.TabControlCases.SelectedIndex = 0;
            this.TabControlCases.Size = new System.Drawing.Size(1157, 566);
            this.TabControlCases.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TabControlCases.TabIndex = 0;
            // 
            // FindCase
            // 
            this.FindCase.Controls.Add(this.FindbtnEdit);
            this.FindCase.Controls.Add(this.dataListView1);
            this.FindCase.Controls.Add(this.label3);
            this.FindCase.Controls.Add(this.FindbtnCreate);
            this.FindCase.Location = new System.Drawing.Point(4, 5);
            this.FindCase.Name = "FindCase";
            this.FindCase.Padding = new System.Windows.Forms.Padding(3);
            this.FindCase.Size = new System.Drawing.Size(1149, 557);
            this.FindCase.TabIndex = 0;
            this.FindCase.Text = "Find sag";
            this.FindCase.UseVisualStyleBackColor = true;
            this.FindCase.MouseEnter += new System.EventHandler(this.FindCase_MouseEnter);
            // 
            // FindbtnEdit
            // 
            this.FindbtnEdit.Location = new System.Drawing.Point(6, 35);
            this.FindbtnEdit.Name = "FindbtnEdit";
            this.FindbtnEdit.Size = new System.Drawing.Size(75, 30);
            this.FindbtnEdit.TabIndex = 3;
            this.FindbtnEdit.Text = "Ændre";
            this.FindbtnEdit.UseVisualStyleBackColor = true;
            this.FindbtnEdit.Click += new System.EventHandler(this.FindbtnEdit_Click);
            // 
            // dataListView1
            // 
            this.dataListView1.AllColumns.Add(this.olvColumn1);
            this.dataListView1.AllColumns.Add(this.olvColumn2);
            this.dataListView1.CellEditUseWholeCell = false;
            this.dataListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1,
            this.olvColumn2});
            this.dataListView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataListView1.DataSource = null;
            this.dataListView1.Location = new System.Drawing.Point(9, 97);
            this.dataListView1.Name = "dataListView1";
            this.dataListView1.Size = new System.Drawing.Size(1134, 412);
            this.dataListView1.TabIndex = 2;
            this.dataListView1.UseCompatibleStateImageBehavior = false;
            this.dataListView1.View = System.Windows.Forms.View.Details;
            this.dataListView1.MouseEnter += new System.EventHandler(this.FindCase_MouseEnter);
            // 
            // olvColumn1
            // 
            this.olvColumn1.Text = "ID";
            this.olvColumn1.Width = 39;
            // 
            // olvColumn2
            // 
            this.olvColumn2.Text = "Advokat";
            this.olvColumn2.Width = 77;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Find sag";
            // 
            // FindbtnCreate
            // 
            this.FindbtnCreate.Location = new System.Drawing.Point(88, 35);
            this.FindbtnCreate.Name = "FindbtnCreate";
            this.FindbtnCreate.Size = new System.Drawing.Size(75, 30);
            this.FindbtnCreate.TabIndex = 0;
            this.FindbtnCreate.Text = "Opret";
            this.FindbtnCreate.UseVisualStyleBackColor = true;
            this.FindbtnCreate.Click += new System.EventHandler(this.FindbtnCreate_Click);
            // 
            // EditCase
            // 
            this.EditCase.Controls.Add(this.label18);
            this.EditCase.Controls.Add(this.textBox7);
            this.EditCase.Controls.Add(this.comboBox6);
            this.EditCase.Controls.Add(this.comboBox5);
            this.EditCase.Controls.Add(this.comboBox4);
            this.EditCase.Controls.Add(this.dateTimePicker2);
            this.EditCase.Controls.Add(this.textBox6);
            this.EditCase.Controls.Add(this.textBox5);
            this.EditCase.Controls.Add(this.textBox4);
            this.EditCase.Controls.Add(this.label17);
            this.EditCase.Controls.Add(this.label16);
            this.EditCase.Controls.Add(this.label15);
            this.EditCase.Controls.Add(this.label14);
            this.EditCase.Controls.Add(this.label13);
            this.EditCase.Controls.Add(this.label12);
            this.EditCase.Controls.Add(this.label11);
            this.EditCase.Controls.Add(this.EditbtnCreate);
            this.EditCase.Controls.Add(this.label1);
            this.EditCase.Controls.Add(this.EditBtnFind);
            this.EditCase.Location = new System.Drawing.Point(4, 5);
            this.EditCase.Name = "EditCase";
            this.EditCase.Padding = new System.Windows.Forms.Padding(3);
            this.EditCase.Size = new System.Drawing.Size(1149, 557);
            this.EditCase.TabIndex = 1;
            this.EditCase.Text = "Ændre";
            this.EditCase.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(20, 107);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(38, 18);
            this.label18.TabIndex = 18;
            this.label18.Text = "Søg";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(197, 101);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(121, 24);
            this.textBox7.TabIndex = 17;
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(197, 369);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(121, 26);
            this.comboBox6.TabIndex = 16;
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(197, 326);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(121, 26);
            this.comboBox5.TabIndex = 15;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(197, 285);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 26);
            this.comboBox4.TabIndex = 14;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(197, 250);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 24);
            this.dateTimePicker2.TabIndex = 13;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(197, 214);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(121, 24);
            this.textBox6.TabIndex = 12;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(197, 177);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(121, 24);
            this.textBox5.TabIndex = 11;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(197, 140);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(121, 24);
            this.textBox4.TabIndex = 10;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(17, 377);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(104, 18);
            this.label17.TabIndex = 9;
            this.label17.Text = "Vælg service";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(17, 334);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(109, 18);
            this.label16.TabIndex = 8;
            this.label16.Text = "Vælg advokat";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(17, 293);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(90, 18);
            this.label15.TabIndex = 7;
            this.label15.Text = "Vælg klient";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(17, 255);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 18);
            this.label14.TabIndex = 6;
            this.label14.Text = "Start dato";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 219);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 18);
            this.label13.TabIndex = 5;
            this.label13.Text = "Est. timer";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 182);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 18);
            this.label12.TabIndex = 4;
            this.label12.Text = "Beskrivelse";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 145);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 18);
            this.label11.TabIndex = 3;
            this.label11.Text = "Sags title";
            // 
            // EditbtnCreate
            // 
            this.EditbtnCreate.Location = new System.Drawing.Point(88, 35);
            this.EditbtnCreate.Name = "EditbtnCreate";
            this.EditbtnCreate.Size = new System.Drawing.Size(75, 31);
            this.EditbtnCreate.TabIndex = 2;
            this.EditbtnCreate.Text = "Opret";
            this.EditbtnCreate.UseVisualStyleBackColor = true;
            this.EditbtnCreate.Click += new System.EventHandler(this.EditbtnCreate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ændre sag";
            // 
            // EditBtnFind
            // 
            this.EditBtnFind.Location = new System.Drawing.Point(6, 35);
            this.EditBtnFind.Name = "EditBtnFind";
            this.EditBtnFind.Size = new System.Drawing.Size(75, 31);
            this.EditBtnFind.TabIndex = 0;
            this.EditBtnFind.Tag = "";
            this.EditBtnFind.Text = "Find";
            this.EditBtnFind.UseVisualStyleBackColor = true;
            this.EditBtnFind.Click += new System.EventHandler(this.EditBtnFind_Click);
            // 
            // CreateCase
            // 
            this.CreateCase.Controls.Add(this.CreatebtnEdit);
            this.CreateCase.Controls.Add(this.comboBox3);
            this.CreateCase.Controls.Add(this.comboBox2);
            this.CreateCase.Controls.Add(this.comboBox1);
            this.CreateCase.Controls.Add(this.dateTimePicker1);
            this.CreateCase.Controls.Add(this.textBox3);
            this.CreateCase.Controls.Add(this.textBox2);
            this.CreateCase.Controls.Add(this.textBox1);
            this.CreateCase.Controls.Add(this.label10);
            this.CreateCase.Controls.Add(this.label9);
            this.CreateCase.Controls.Add(this.label8);
            this.CreateCase.Controls.Add(this.label7);
            this.CreateCase.Controls.Add(this.label6);
            this.CreateCase.Controls.Add(this.label5);
            this.CreateCase.Controls.Add(this.label4);
            this.CreateCase.Controls.Add(this.label2);
            this.CreateCase.Controls.Add(this.CreatebtnFind);
            this.CreateCase.Location = new System.Drawing.Point(4, 5);
            this.CreateCase.Name = "CreateCase";
            this.CreateCase.Padding = new System.Windows.Forms.Padding(3);
            this.CreateCase.Size = new System.Drawing.Size(1149, 557);
            this.CreateCase.TabIndex = 2;
            this.CreateCase.Text = "Opret";
            this.CreateCase.UseVisualStyleBackColor = true;
            // 
            // CreatebtnEdit
            // 
            this.CreatebtnEdit.Location = new System.Drawing.Point(88, 35);
            this.CreatebtnEdit.Name = "CreatebtnEdit";
            this.CreatebtnEdit.Size = new System.Drawing.Size(75, 30);
            this.CreatebtnEdit.TabIndex = 16;
            this.CreatebtnEdit.Text = "Ændre";
            this.CreatebtnEdit.UseVisualStyleBackColor = true;
            this.CreatebtnEdit.Click += new System.EventHandler(this.CreatebtnEdit_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(205, 345);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 26);
            this.comboBox3.TabIndex = 15;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(205, 300);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 26);
            this.comboBox2.TabIndex = 14;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(205, 256);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 26);
            this.comboBox1.TabIndex = 13;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(205, 214);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 24);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(205, 171);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(121, 24);
            this.textBox3.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(205, 132);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 24);
            this.textBox2.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(205, 94);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 24);
            this.textBox1.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 352);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 18);
            this.label10.TabIndex = 8;
            this.label10.Text = "Vælg service";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 307);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 18);
            this.label9.TabIndex = 7;
            this.label9.Text = "Vælg advokat";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 18);
            this.label8.TabIndex = 6;
            this.label8.Text = "Vælg klient";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 18);
            this.label7.TabIndex = 5;
            this.label7.Text = "Start dato";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 18);
            this.label6.TabIndex = 4;
            this.label6.Text = "Est. timer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Beskrivelse";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Sags title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Opret sag";
            // 
            // CreatebtnFind
            // 
            this.CreatebtnFind.Location = new System.Drawing.Point(6, 35);
            this.CreatebtnFind.Name = "CreatebtnFind";
            this.CreatebtnFind.Size = new System.Drawing.Size(75, 30);
            this.CreatebtnFind.TabIndex = 0;
            this.CreatebtnFind.Text = "Find";
            this.CreatebtnFind.UseVisualStyleBackColor = true;
            this.CreatebtnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(69, 566);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1226, 37);
            this.panel2.TabIndex = 2;
            // 
            // imageListCases
            // 
            this.imageListCases.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageListCases.ImageSize = new System.Drawing.Size(20, 20);
            this.imageListCases.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // UserControlCases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.TabControlCases);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "UserControlCases";
            this.Size = new System.Drawing.Size(1226, 603);
            this.TabControlCases.ResumeLayout(false);
            this.FindCase.ResumeLayout(false);
            this.FindCase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListView1)).EndInit();
            this.EditCase.ResumeLayout(false);
            this.EditCase.PerformLayout();
            this.CreateCase.ResumeLayout(false);
            this.CreateCase.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControlCases;
        private System.Windows.Forms.TabPage FindCase;
        private System.Windows.Forms.TabPage EditCase;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabPage CreateCase;
        private System.Windows.Forms.ImageList imageListCases;
        private System.Windows.Forms.Button FindbtnCreate;
        private System.Windows.Forms.Button EditBtnFind;
        private System.Windows.Forms.Button CreatebtnFind;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private BrightIdeasSoftware.DataListView dataListView1;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private BrightIdeasSoftware.OLVColumn olvColumn2;
        private System.Windows.Forms.Button FindbtnEdit;
        private System.Windows.Forms.Button EditbtnCreate;
        private System.Windows.Forms.Button CreatebtnEdit;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
    }
}
