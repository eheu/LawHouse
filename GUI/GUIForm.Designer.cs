namespace GUI
{
    partial class GUIForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUIForm));
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.HelpBtn = new System.Windows.Forms.Button();
            this.ClientBtn = new System.Windows.Forms.Button();
            this.EmployeeBtn = new System.Windows.Forms.Button();
            this.CaseBtn = new System.Windows.Forms.Button();
            this.MenuPictureBtn = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.CloseWindowBtn = new System.Windows.Forms.PictureBox();
            this.MenuSlideTimer = new System.Windows.Forms.Timer(this.components);
            this.UcContainer = new System.Windows.Forms.Panel();
            this.dragControl1 = new GUI.DragControl();
            this.MenuTestPanelLeave = new System.Windows.Forms.Panel();
            this.MenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuPictureBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseWindowBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.SystemColors.Control;
            this.MenuPanel.Controls.Add(this.MenuTestPanelLeave);
            this.MenuPanel.Controls.Add(this.HelpBtn);
            this.MenuPanel.Controls.Add(this.ClientBtn);
            this.MenuPanel.Controls.Add(this.EmployeeBtn);
            this.MenuPanel.Controls.Add(this.CaseBtn);
            this.MenuPanel.Controls.Add(this.MenuPictureBtn);
            this.MenuPanel.Controls.Add(this.pictureBox1);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPanel.Location = new System.Drawing.Point(0, 37);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(69, 566);
            this.MenuPanel.TabIndex = 1;
            // 
            // HelpBtn
            // 
            this.HelpBtn.FlatAppearance.BorderSize = 0;
            this.HelpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HelpBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.HelpBtn.Image = ((System.Drawing.Image)(resources.GetObject("HelpBtn.Image")));
            this.HelpBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HelpBtn.Location = new System.Drawing.Point(0, 496);
            this.HelpBtn.Name = "HelpBtn";
            this.HelpBtn.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.HelpBtn.Size = new System.Drawing.Size(347, 68);
            this.HelpBtn.TabIndex = 4;
            this.HelpBtn.Text = "       Hjælp";
            this.HelpBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.HelpBtn.UseVisualStyleBackColor = true;
            this.HelpBtn.Click += new System.EventHandler(this.HelpBtn_Click);
            this.HelpBtn.MouseEnter += new System.EventHandler(this.HelpBtn_MouseEnter);
            this.HelpBtn.MouseLeave += new System.EventHandler(this.HelpBtn_MouseLeave);
            // 
            // ClientBtn
            // 
            this.ClientBtn.FlatAppearance.BorderSize = 0;
            this.ClientBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClientBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ClientBtn.Image = ((System.Drawing.Image)(resources.GetObject("ClientBtn.Image")));
            this.ClientBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ClientBtn.Location = new System.Drawing.Point(0, 281);
            this.ClientBtn.Name = "ClientBtn";
            this.ClientBtn.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.ClientBtn.Size = new System.Drawing.Size(347, 68);
            this.ClientBtn.TabIndex = 4;
            this.ClientBtn.Text = "     Klienter";
            this.ClientBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ClientBtn.UseVisualStyleBackColor = true;
            this.ClientBtn.Click += new System.EventHandler(this.ClientBtn_Click);
            this.ClientBtn.MouseEnter += new System.EventHandler(this.ClientBtn_MouseEnter);
            this.ClientBtn.MouseLeave += new System.EventHandler(this.ClientBtn_MouseLeave);
            // 
            // EmployeeBtn
            // 
            this.EmployeeBtn.FlatAppearance.BorderSize = 0;
            this.EmployeeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EmployeeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.EmployeeBtn.Image = ((System.Drawing.Image)(resources.GetObject("EmployeeBtn.Image")));
            this.EmployeeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EmployeeBtn.Location = new System.Drawing.Point(0, 218);
            this.EmployeeBtn.Name = "EmployeeBtn";
            this.EmployeeBtn.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.EmployeeBtn.Size = new System.Drawing.Size(347, 68);
            this.EmployeeBtn.TabIndex = 4;
            this.EmployeeBtn.Text = "     Ansatte";
            this.EmployeeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EmployeeBtn.UseVisualStyleBackColor = true;
            this.EmployeeBtn.Click += new System.EventHandler(this.EmployeeBtn_Click);
            this.EmployeeBtn.MouseEnter += new System.EventHandler(this.EmployeeBtn_MouseEnter);
            this.EmployeeBtn.MouseLeave += new System.EventHandler(this.EmployeeBtn_MouseLeave);
            // 
            // CaseBtn
            // 
            this.CaseBtn.FlatAppearance.BorderSize = 0;
            this.CaseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CaseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaseBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CaseBtn.Image = ((System.Drawing.Image)(resources.GetObject("CaseBtn.Image")));
            this.CaseBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CaseBtn.Location = new System.Drawing.Point(0, 155);
            this.CaseBtn.Name = "CaseBtn";
            this.CaseBtn.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.CaseBtn.Size = new System.Drawing.Size(347, 68);
            this.CaseBtn.TabIndex = 4;
            this.CaseBtn.Text = "     Sager";
            this.CaseBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CaseBtn.UseVisualStyleBackColor = true;
            this.CaseBtn.Click += new System.EventHandler(this.CaseBtn_Click);
            this.CaseBtn.MouseEnter += new System.EventHandler(this.CaseBtn_MouseEnter);
            this.CaseBtn.MouseLeave += new System.EventHandler(this.CaseBtn_MouseLeave);
            // 
            // MenuPictureBtn
            // 
            this.MenuPictureBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MenuPictureBtn.Image = ((System.Drawing.Image)(resources.GetObject("MenuPictureBtn.Image")));
            this.MenuPictureBtn.Location = new System.Drawing.Point(0, 32);
            this.MenuPictureBtn.Name = "MenuPictureBtn";
            this.MenuPictureBtn.Size = new System.Drawing.Size(69, 69);
            this.MenuPictureBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MenuPictureBtn.TabIndex = 3;
            this.MenuPictureBtn.TabStop = false;
            this.MenuPictureBtn.Click += new System.EventHandler(this.MenuPictureBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.TopPanel.Controls.Add(this.CloseWindowBtn);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1226, 37);
            this.TopPanel.TabIndex = 2;
            // 
            // CloseWindowBtn
            // 
            this.CloseWindowBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseWindowBtn.Image = ((System.Drawing.Image)(resources.GetObject("CloseWindowBtn.Image")));
            this.CloseWindowBtn.Location = new System.Drawing.Point(1192, 6);
            this.CloseWindowBtn.Name = "CloseWindowBtn";
            this.CloseWindowBtn.Size = new System.Drawing.Size(25, 24);
            this.CloseWindowBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CloseWindowBtn.TabIndex = 3;
            this.CloseWindowBtn.TabStop = false;
            this.CloseWindowBtn.Click += new System.EventHandler(this.CloseWindowBtn_Click);
            // 
            // MenuSlideTimer
            // 
            this.MenuSlideTimer.Interval = 10;
            this.MenuSlideTimer.Tag = "";
            this.MenuSlideTimer.Tick += new System.EventHandler(this.MenuSlideTimer_Tick);
            // 
            // UcContainer
            // 
            this.UcContainer.BackColor = System.Drawing.Color.Transparent;
            this.UcContainer.Location = new System.Drawing.Point(68, 37);
            this.UcContainer.Name = "UcContainer";
            this.UcContainer.Size = new System.Drawing.Size(1158, 566);
            this.UcContainer.TabIndex = 3;
            // 
            // dragControl1
            // 
            this.dragControl1.SelectControl = this.TopPanel;
            // 
            // MenuTestPanelLeave
            // 
            this.MenuTestPanelLeave.BackColor = System.Drawing.Color.Transparent;
            this.MenuTestPanelLeave.Dock = System.Windows.Forms.DockStyle.Right;
            this.MenuTestPanelLeave.Location = new System.Drawing.Point(68, 0);
            this.MenuTestPanelLeave.Margin = new System.Windows.Forms.Padding(0);
            this.MenuTestPanelLeave.Name = "MenuTestPanelLeave";
            this.MenuTestPanelLeave.Size = new System.Drawing.Size(1, 566);
            this.MenuTestPanelLeave.TabIndex = 5;
            this.MenuTestPanelLeave.MouseLeave += new System.EventHandler(this.Menu_leave);
            // 
            // GUIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1226, 603);
            this.Controls.Add(this.MenuPanel);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.UcContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GUIForm";
            this.Text = "GUI";
            this.Load += new System.EventHandler(this.GUI_Load);
            this.MenuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MenuPictureBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.TopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CloseWindowBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Button HelpBtn;
        private System.Windows.Forms.Button ClientBtn;
        private System.Windows.Forms.Button EmployeeBtn;
        private System.Windows.Forms.Button CaseBtn;
        private System.Windows.Forms.PictureBox MenuPictureBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.PictureBox CloseWindowBtn;
        private System.Windows.Forms.Timer MenuSlideTimer;
        private DragControl dragControl1;
        private System.Windows.Forms.Panel UcContainer;
        private System.Windows.Forms.Panel MenuTestPanelLeave;
    }
}