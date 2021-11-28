
namespace MyContactTracing
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBxAge = new System.Windows.Forms.TextBox();
            this.txtBxContactNum = new System.Windows.Forms.TextBox();
            this.txtBxFirstName = new System.Windows.Forms.TextBox();
            this.txtBxMiddleName = new System.Windows.Forms.TextBox();
            this.txtBxLastName = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblContactNum = new System.Windows.Forms.Label();
            this.lblEMail = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblHealthCondition = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.lblLastnName = new System.Windows.Forms.Label();
            this.grpBxFever = new System.Windows.Forms.GroupBox();
            this.rdBtnNo_Fever = new System.Windows.Forms.RadioButton();
            this.rdBtnYes_Fever = new System.Windows.Forms.RadioButton();
            this.grpBxGender = new System.Windows.Forms.GroupBox();
            this.rdBtnFemale_Gender = new System.Windows.Forms.RadioButton();
            this.rdBtnMale_Gender = new System.Windows.Forms.RadioButton();
            this.txtBxEMail = new System.Windows.Forms.TextBox();
            this.dateDTP = new System.Windows.Forms.DateTimePicker();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abooutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpBxDryCough = new System.Windows.Forms.GroupBox();
            this.rdBtnNo_DryCough = new System.Windows.Forms.RadioButton();
            this.rdBtnYes_DryCough = new System.Windows.Forms.RadioButton();
            this.grpBxTirediness = new System.Windows.Forms.GroupBox();
            this.rdBtnNo_Tiredines = new System.Windows.Forms.RadioButton();
            this.rdBtnYes_Tirediness = new System.Windows.Forms.RadioButton();
            this.grpBxSoreThroat = new System.Windows.Forms.GroupBox();
            this.rdBtnNo_SoreThroat = new System.Windows.Forms.RadioButton();
            this.rdBtnYes_SoreThroat = new System.Windows.Forms.RadioButton();
            this.txtBxBarangay = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grpBxFever.SuspendLayout();
            this.grpBxGender.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.grpBxDryCough.SuspendLayout();
            this.grpBxTirediness.SuspendLayout();
            this.grpBxSoreThroat.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBxAge
            // 
            this.txtBxAge.Location = new System.Drawing.Point(727, 98);
            this.txtBxAge.Name = "txtBxAge";
            this.txtBxAge.Size = new System.Drawing.Size(71, 23);
            this.txtBxAge.TabIndex = 3;
            this.txtBxAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPress_Numbers);
            // 
            // txtBxContactNum
            // 
            this.txtBxContactNum.Location = new System.Drawing.Point(165, 153);
            this.txtBxContactNum.Name = "txtBxContactNum";
            this.txtBxContactNum.Size = new System.Drawing.Size(179, 23);
            this.txtBxContactNum.TabIndex = 4;
            this.txtBxContactNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPress_Numbers);
            // 
            // txtBxFirstName
            // 
            this.txtBxFirstName.Location = new System.Drawing.Point(128, 98);
            this.txtBxFirstName.Name = "txtBxFirstName";
            this.txtBxFirstName.Size = new System.Drawing.Size(179, 23);
            this.txtBxFirstName.TabIndex = 5;
            this.txtBxFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPress_Letters_Spaces);
            // 
            // txtBxMiddleName
            // 
            this.txtBxMiddleName.Location = new System.Drawing.Point(313, 98);
            this.txtBxMiddleName.Name = "txtBxMiddleName";
            this.txtBxMiddleName.Size = new System.Drawing.Size(179, 23);
            this.txtBxMiddleName.TabIndex = 6;
            this.txtBxMiddleName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPress_Letters_Spaces);
            // 
            // txtBxLastName
            // 
            this.txtBxLastName.Location = new System.Drawing.Point(498, 98);
            this.txtBxLastName.Name = "txtBxLastName";
            this.txtBxLastName.Size = new System.Drawing.Size(179, 23);
            this.txtBxLastName.TabIndex = 7;
            this.txtBxLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPress_Letters_Spaces);
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFullName.Location = new System.Drawing.Point(12, 98);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(101, 25);
            this.lblFullName.TabIndex = 8;
            this.lblFullName.Text = "Full Name:";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAge.Location = new System.Drawing.Point(674, 98);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(49, 25);
            this.lblAge.TabIndex = 9;
            this.lblAge.Text = "Age:";
            // 
            // lblContactNum
            // 
            this.lblContactNum.AutoSize = true;
            this.lblContactNum.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblContactNum.Location = new System.Drawing.Point(12, 148);
            this.lblContactNum.Name = "lblContactNum";
            this.lblContactNum.Size = new System.Drawing.Size(155, 25);
            this.lblContactNum.TabIndex = 10;
            this.lblContactNum.Text = "Contact Number:";
            // 
            // lblEMail
            // 
            this.lblEMail.AutoSize = true;
            this.lblEMail.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEMail.Location = new System.Drawing.Point(350, 153);
            this.lblEMail.Name = "lblEMail";
            this.lblEMail.Size = new System.Drawing.Size(70, 25);
            this.lblEMail.TabIndex = 11;
            this.lblEMail.Text = "E-mail:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(293, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Barangay:";
            // 
            // lblHealthCondition
            // 
            this.lblHealthCondition.AutoSize = true;
            this.lblHealthCondition.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHealthCondition.Location = new System.Drawing.Point(324, 243);
            this.lblHealthCondition.Name = "lblHealthCondition";
            this.lblHealthCondition.Size = new System.Drawing.Size(159, 25);
            this.lblHealthCondition.TabIndex = 14;
            this.lblHealthCondition.Text = "Health Condition:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(173, 124);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(64, 15);
            this.lblFirstName.TabIndex = 15;
            this.lblFirstName.Text = "First Name";
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Location = new System.Drawing.Point(361, 124);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(79, 15);
            this.lblMiddleName.TabIndex = 16;
            this.lblMiddleName.Text = "Middle Name";
            // 
            // lblLastnName
            // 
            this.lblLastnName.AutoSize = true;
            this.lblLastnName.Location = new System.Drawing.Point(543, 124);
            this.lblLastnName.Name = "lblLastnName";
            this.lblLastnName.Size = new System.Drawing.Size(63, 15);
            this.lblLastnName.TabIndex = 17;
            this.lblLastnName.Text = "Last Name";
            // 
            // grpBxFever
            // 
            this.grpBxFever.Controls.Add(this.rdBtnNo_Fever);
            this.grpBxFever.Controls.Add(this.rdBtnYes_Fever);
            this.grpBxFever.Location = new System.Drawing.Point(151, 283);
            this.grpBxFever.Name = "grpBxFever";
            this.grpBxFever.Size = new System.Drawing.Size(237, 48);
            this.grpBxFever.TabIndex = 20;
            this.grpBxFever.TabStop = false;
            this.grpBxFever.Text = "Are you experiencing fever?";
            // 
            // rdBtnNo_Fever
            // 
            this.rdBtnNo_Fever.AutoSize = true;
            this.rdBtnNo_Fever.Location = new System.Drawing.Point(115, 22);
            this.rdBtnNo_Fever.Name = "rdBtnNo_Fever";
            this.rdBtnNo_Fever.Size = new System.Drawing.Size(41, 19);
            this.rdBtnNo_Fever.TabIndex = 1;
            this.rdBtnNo_Fever.TabStop = true;
            this.rdBtnNo_Fever.Text = "No";
            this.rdBtnNo_Fever.UseVisualStyleBackColor = true;
            // 
            // rdBtnYes_Fever
            // 
            this.rdBtnYes_Fever.AutoSize = true;
            this.rdBtnYes_Fever.Location = new System.Drawing.Point(15, 22);
            this.rdBtnYes_Fever.Name = "rdBtnYes_Fever";
            this.rdBtnYes_Fever.Size = new System.Drawing.Size(42, 19);
            this.rdBtnYes_Fever.TabIndex = 0;
            this.rdBtnYes_Fever.TabStop = true;
            this.rdBtnYes_Fever.Text = "Yes";
            this.rdBtnYes_Fever.UseVisualStyleBackColor = true;
            // 
            // grpBxGender
            // 
            this.grpBxGender.Controls.Add(this.rdBtnFemale_Gender);
            this.grpBxGender.Controls.Add(this.rdBtnMale_Gender);
            this.grpBxGender.Location = new System.Drawing.Point(674, 140);
            this.grpBxGender.Name = "grpBxGender";
            this.grpBxGender.Size = new System.Drawing.Size(124, 80);
            this.grpBxGender.TabIndex = 21;
            this.grpBxGender.TabStop = false;
            this.grpBxGender.Text = "Gender:";
            // 
            // rdBtnFemale_Gender
            // 
            this.rdBtnFemale_Gender.AutoSize = true;
            this.rdBtnFemale_Gender.Location = new System.Drawing.Point(6, 47);
            this.rdBtnFemale_Gender.Name = "rdBtnFemale_Gender";
            this.rdBtnFemale_Gender.Size = new System.Drawing.Size(63, 19);
            this.rdBtnFemale_Gender.TabIndex = 1;
            this.rdBtnFemale_Gender.TabStop = true;
            this.rdBtnFemale_Gender.Text = "Female";
            this.rdBtnFemale_Gender.UseVisualStyleBackColor = true;
            // 
            // rdBtnMale_Gender
            // 
            this.rdBtnMale_Gender.AutoSize = true;
            this.rdBtnMale_Gender.Location = new System.Drawing.Point(6, 22);
            this.rdBtnMale_Gender.Name = "rdBtnMale_Gender";
            this.rdBtnMale_Gender.Size = new System.Drawing.Size(51, 19);
            this.rdBtnMale_Gender.TabIndex = 0;
            this.rdBtnMale_Gender.TabStop = true;
            this.rdBtnMale_Gender.Text = "Male";
            this.rdBtnMale_Gender.UseVisualStyleBackColor = true;
            // 
            // txtBxEMail
            // 
            this.txtBxEMail.Location = new System.Drawing.Point(426, 158);
            this.txtBxEMail.Name = "txtBxEMail";
            this.txtBxEMail.Size = new System.Drawing.Size(242, 23);
            this.txtBxEMail.TabIndex = 24;
            // 
            // dateDTP
            // 
            this.dateDTP.Location = new System.Drawing.Point(75, 194);
            this.dateDTP.Name = "dateDTP";
            this.dateDTP.Size = new System.Drawing.Size(200, 23);
            this.dateDTP.TabIndex = 25;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(727, 431);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 26;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(350, 391);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 27;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.saveBtnClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(825, 24);
            this.menuStrip1.TabIndex = 29;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newRecordToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.newRecordFrom);
            // 
            // newRecordToolStripMenuItem
            // 
            this.newRecordToolStripMenuItem.Name = "newRecordToolStripMenuItem";
            this.newRecordToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.newRecordToolStripMenuItem.Text = "New Record";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abooutToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.aboutToolStripMenuItem.Text = "Help";
            // 
            // abooutToolStripMenuItem
            // 
            this.abooutToolStripMenuItem.Name = "abooutToolStripMenuItem";
            this.abooutToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.abooutToolStripMenuItem.Text = "Aboout";
            // 
            // grpBxDryCough
            // 
            this.grpBxDryCough.Controls.Add(this.rdBtnNo_DryCough);
            this.grpBxDryCough.Controls.Add(this.rdBtnYes_DryCough);
            this.grpBxDryCough.Location = new System.Drawing.Point(394, 283);
            this.grpBxDryCough.Name = "grpBxDryCough";
            this.grpBxDryCough.Size = new System.Drawing.Size(236, 48);
            this.grpBxDryCough.TabIndex = 21;
            this.grpBxDryCough.TabStop = false;
            this.grpBxDryCough.Text = "Are you experiencing aDry Cough?";
            // 
            // rdBtnNo_DryCough
            // 
            this.rdBtnNo_DryCough.AutoSize = true;
            this.rdBtnNo_DryCough.Location = new System.Drawing.Point(115, 22);
            this.rdBtnNo_DryCough.Name = "rdBtnNo_DryCough";
            this.rdBtnNo_DryCough.Size = new System.Drawing.Size(41, 19);
            this.rdBtnNo_DryCough.TabIndex = 1;
            this.rdBtnNo_DryCough.TabStop = true;
            this.rdBtnNo_DryCough.Text = "No";
            this.rdBtnNo_DryCough.UseVisualStyleBackColor = true;
            // 
            // rdBtnYes_DryCough
            // 
            this.rdBtnYes_DryCough.AutoSize = true;
            this.rdBtnYes_DryCough.Location = new System.Drawing.Point(15, 22);
            this.rdBtnYes_DryCough.Name = "rdBtnYes_DryCough";
            this.rdBtnYes_DryCough.Size = new System.Drawing.Size(42, 19);
            this.rdBtnYes_DryCough.TabIndex = 0;
            this.rdBtnYes_DryCough.TabStop = true;
            this.rdBtnYes_DryCough.Text = "Yes";
            this.rdBtnYes_DryCough.UseVisualStyleBackColor = true;
            // 
            // grpBxTirediness
            // 
            this.grpBxTirediness.Controls.Add(this.rdBtnNo_Tiredines);
            this.grpBxTirediness.Controls.Add(this.rdBtnYes_Tirediness);
            this.grpBxTirediness.Location = new System.Drawing.Point(394, 337);
            this.grpBxTirediness.Name = "grpBxTirediness";
            this.grpBxTirediness.Size = new System.Drawing.Size(237, 48);
            this.grpBxTirediness.TabIndex = 21;
            this.grpBxTirediness.TabStop = false;
            this.grpBxTirediness.Text = "Are you Experiencing Tiredness?";
            // 
            // rdBtnNo_Tiredines
            // 
            this.rdBtnNo_Tiredines.AutoSize = true;
            this.rdBtnNo_Tiredines.Location = new System.Drawing.Point(115, 22);
            this.rdBtnNo_Tiredines.Name = "rdBtnNo_Tiredines";
            this.rdBtnNo_Tiredines.Size = new System.Drawing.Size(41, 19);
            this.rdBtnNo_Tiredines.TabIndex = 1;
            this.rdBtnNo_Tiredines.TabStop = true;
            this.rdBtnNo_Tiredines.Text = "No";
            this.rdBtnNo_Tiredines.UseVisualStyleBackColor = true;
            // 
            // rdBtnYes_Tirediness
            // 
            this.rdBtnYes_Tirediness.AutoSize = true;
            this.rdBtnYes_Tirediness.Location = new System.Drawing.Point(15, 22);
            this.rdBtnYes_Tirediness.Name = "rdBtnYes_Tirediness";
            this.rdBtnYes_Tirediness.Size = new System.Drawing.Size(42, 19);
            this.rdBtnYes_Tirediness.TabIndex = 0;
            this.rdBtnYes_Tirediness.TabStop = true;
            this.rdBtnYes_Tirediness.Text = "Yes";
            this.rdBtnYes_Tirediness.UseVisualStyleBackColor = true;
            // 
            // grpBxSoreThroat
            // 
            this.grpBxSoreThroat.Controls.Add(this.rdBtnNo_SoreThroat);
            this.grpBxSoreThroat.Controls.Add(this.rdBtnYes_SoreThroat);
            this.grpBxSoreThroat.Location = new System.Drawing.Point(151, 337);
            this.grpBxSoreThroat.Name = "grpBxSoreThroat";
            this.grpBxSoreThroat.Size = new System.Drawing.Size(237, 48);
            this.grpBxSoreThroat.TabIndex = 21;
            this.grpBxSoreThroat.TabStop = false;
            this.grpBxSoreThroat.Text = "Are you experiencing a Sore Throat?";
            // 
            // rdBtnNo_SoreThroat
            // 
            this.rdBtnNo_SoreThroat.AutoSize = true;
            this.rdBtnNo_SoreThroat.Location = new System.Drawing.Point(115, 22);
            this.rdBtnNo_SoreThroat.Name = "rdBtnNo_SoreThroat";
            this.rdBtnNo_SoreThroat.Size = new System.Drawing.Size(41, 19);
            this.rdBtnNo_SoreThroat.TabIndex = 1;
            this.rdBtnNo_SoreThroat.TabStop = true;
            this.rdBtnNo_SoreThroat.Text = "No";
            this.rdBtnNo_SoreThroat.UseVisualStyleBackColor = true;
            // 
            // rdBtnYes_SoreThroat
            // 
            this.rdBtnYes_SoreThroat.AutoSize = true;
            this.rdBtnYes_SoreThroat.Location = new System.Drawing.Point(15, 22);
            this.rdBtnYes_SoreThroat.Name = "rdBtnYes_SoreThroat";
            this.rdBtnYes_SoreThroat.Size = new System.Drawing.Size(42, 19);
            this.rdBtnYes_SoreThroat.TabIndex = 0;
            this.rdBtnYes_SoreThroat.TabStop = true;
            this.rdBtnYes_SoreThroat.Text = "Yes";
            this.rdBtnYes_SoreThroat.UseVisualStyleBackColor = true;
            // 
            // txtBxBarangay
            // 
            this.txtBxBarangay.Location = new System.Drawing.Point(403, 197);
            this.txtBxBarangay.Name = "txtBxBarangay";
            this.txtBxBarangay.Size = new System.Drawing.Size(274, 23);
            this.txtBxBarangay.TabIndex = 30;
            this.txtBxBarangay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPress_Letters_Spaces);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 478);
            this.Controls.Add(this.txtBxBarangay);
            this.Controls.Add(this.grpBxSoreThroat);
            this.Controls.Add(this.grpBxTirediness);
            this.Controls.Add(this.grpBxDryCough);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dateDTP);
            this.Controls.Add(this.txtBxEMail);
            this.Controls.Add(this.grpBxGender);
            this.Controls.Add(this.grpBxFever);
            this.Controls.Add(this.lblLastnName);
            this.Controls.Add(this.lblMiddleName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblHealthCondition);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblEMail);
            this.Controls.Add(this.lblContactNum);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.txtBxLastName);
            this.Controls.Add(this.txtBxMiddleName);
            this.Controls.Add(this.txtBxFirstName);
            this.Controls.Add(this.txtBxContactNum);
            this.Controls.Add(this.txtBxAge);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Contact Tracing";
            this.grpBxFever.ResumeLayout(false);
            this.grpBxFever.PerformLayout();
            this.grpBxGender.ResumeLayout(false);
            this.grpBxGender.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpBxDryCough.ResumeLayout(false);
            this.grpBxDryCough.PerformLayout();
            this.grpBxTirediness.ResumeLayout(false);
            this.grpBxTirediness.PerformLayout();
            this.grpBxSoreThroat.ResumeLayout(false);
            this.grpBxSoreThroat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBxAge;
        private System.Windows.Forms.TextBox txtBxContactNum;
        private System.Windows.Forms.TextBox txtBxFirstName;
        private System.Windows.Forms.TextBox txtBxMiddleName;
        private System.Windows.Forms.TextBox txtBxLastName;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblContactNum;
        private System.Windows.Forms.Label lblEMail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblHealthCondition;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblMiddleName;
        private System.Windows.Forms.Label lblLastnName;
        private System.Windows.Forms.GroupBox grpBxFever;
        private System.Windows.Forms.RadioButton rdBtnNo_Fever;
        private System.Windows.Forms.RadioButton rdBtnYes_Fever;
        private System.Windows.Forms.GroupBox grpBxGender;
        private System.Windows.Forms.RadioButton rdBtnFemale_Gender;
        private System.Windows.Forms.RadioButton rdBtnMale_Gender;
        private System.Windows.Forms.TextBox txtBxEMail;
        private System.Windows.Forms.DateTimePicker dateDTP;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpBxDryCough;
        private System.Windows.Forms.RadioButton rdBtnNo_DryCough;
        private System.Windows.Forms.RadioButton rdBtnYes_DryCough;
        private System.Windows.Forms.GroupBox grpBxTirediness;
        private System.Windows.Forms.RadioButton rdBtnNo_Tiredines;
        private System.Windows.Forms.RadioButton rdBtnYes_Tirediness;
        private System.Windows.Forms.GroupBox grpBxSoreThroat;
        private System.Windows.Forms.RadioButton rdBtnNo_SoreThroat;
        private System.Windows.Forms.RadioButton rdBtnYes_SoreThroat;
        private System.Windows.Forms.TextBox txtBxBarangay;
        private System.Windows.Forms.ToolStripMenuItem newRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abooutToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

