namespace Hostel_MS
{
    partial class Assign_Room
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Assign_Room));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.cbm_RoomNo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_avaibseat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbm_CNIC = new System.Windows.Forms.ComboBox();
            this.txt_StudentName = new System.Windows.Forms.TextBox();
            this.lbl_cnic = new System.Windows.Forms.Label();
            this.hostelDbDataSet8 = new Hostel_MS.HostelDbDataSet8();
            this.tblStudentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_StudentTableAdapter = new Hostel_MS.HostelDbDataSet8TableAdapters.tbl_StudentTableAdapter();
            this.hostelDbDataSet9 = new Hostel_MS.HostelDbDataSet9();
            this.tblRoomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_RoomTableAdapter = new Hostel_MS.HostelDbDataSet9TableAdapters.tbl_RoomTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hostelDbDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hostelDbDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRoomBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(865, 134);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(232, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Assign Room";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 594);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(865, 88);
            this.panel2.TabIndex = 2;
            // 
            // btn_save
            // 
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.ImageKey = "(none)";
            this.btn_save.Location = new System.Drawing.Point(127, 430);
            this.btn_save.Name = "btn_save";
            this.btn_save.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_save.Size = new System.Drawing.Size(140, 54);
            this.btn_save.TabIndex = 41;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Image = ((System.Drawing.Image)(resources.GetObject("btn_clear.Image")));
            this.btn_clear.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_clear.Location = new System.Drawing.Point(309, 430);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(150, 54);
            this.btn_clear.TabIndex = 40;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            // 
            // cbm_RoomNo
            // 
            this.cbm_RoomNo.DataSource = this.tblRoomBindingSource;
            this.cbm_RoomNo.DisplayMember = "RoomNumber";
            this.cbm_RoomNo.FormattingEnabled = true;
            this.cbm_RoomNo.Location = new System.Drawing.Point(278, 310);
            this.cbm_RoomNo.Name = "cbm_RoomNo";
            this.cbm_RoomNo.Size = new System.Drawing.Size(201, 28);
            this.cbm_RoomNo.TabIndex = 39;
            this.cbm_RoomNo.SelectedIndexChanged += new System.EventHandler(this.cbm_RoomNo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 38;
            this.label2.Text = "Room No:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(124, 379);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 37;
            this.label4.Text = "Avaible Seat:";
            // 
            // txt_avaibseat
            // 
            this.txt_avaibseat.Location = new System.Drawing.Point(278, 373);
            this.txt_avaibseat.Name = "txt_avaibseat";
            this.txt_avaibseat.ReadOnly = true;
            this.txt_avaibseat.Size = new System.Drawing.Size(201, 26);
            this.txt_avaibseat.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(124, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 20);
            this.label5.TabIndex = 35;
            this.label5.Text = "Student Name:";
            // 
            // cbm_CNIC
            // 
            this.cbm_CNIC.DataSource = this.tblStudentBindingSource;
            this.cbm_CNIC.DisplayMember = "CNIC";
            this.cbm_CNIC.FormattingEnabled = true;
            this.cbm_CNIC.Location = new System.Drawing.Point(278, 181);
            this.cbm_CNIC.Name = "cbm_CNIC";
            this.cbm_CNIC.Size = new System.Drawing.Size(201, 28);
            this.cbm_CNIC.TabIndex = 34;
            this.cbm_CNIC.SelectedIndexChanged += new System.EventHandler(this.cbm_CNIC_SelectedIndexChanged);
            // 
            // txt_StudentName
            // 
            this.txt_StudentName.Location = new System.Drawing.Point(278, 246);
            this.txt_StudentName.Name = "txt_StudentName";
            this.txt_StudentName.ReadOnly = true;
            this.txt_StudentName.Size = new System.Drawing.Size(201, 26);
            this.txt_StudentName.TabIndex = 33;
            // 
            // lbl_cnic
            // 
            this.lbl_cnic.AutoSize = true;
            this.lbl_cnic.Location = new System.Drawing.Point(124, 189);
            this.lbl_cnic.Name = "lbl_cnic";
            this.lbl_cnic.Size = new System.Drawing.Size(112, 20);
            this.lbl_cnic.TabIndex = 32;
            this.lbl_cnic.Text = "Student CNIC:";
            // 
            // hostelDbDataSet8
            // 
            this.hostelDbDataSet8.DataSetName = "HostelDbDataSet8";
            this.hostelDbDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblStudentBindingSource
            // 
            this.tblStudentBindingSource.DataMember = "tbl_Student";
            this.tblStudentBindingSource.DataSource = this.hostelDbDataSet8;
            // 
            // tbl_StudentTableAdapter
            // 
            this.tbl_StudentTableAdapter.ClearBeforeFill = true;
            // 
            // hostelDbDataSet9
            // 
            this.hostelDbDataSet9.DataSetName = "HostelDbDataSet9";
            this.hostelDbDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblRoomBindingSource
            // 
            this.tblRoomBindingSource.DataMember = "tbl_Room";
            this.tblRoomBindingSource.DataSource = this.hostelDbDataSet9;
            // 
            // tbl_RoomTableAdapter
            // 
            this.tbl_RoomTableAdapter.ClearBeforeFill = true;
            // 
            // Assign_Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 682);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.cbm_RoomNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_avaibseat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbm_CNIC);
            this.Controls.Add(this.txt_StudentName);
            this.Controls.Add(this.lbl_cnic);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Assign_Room";
            this.Text = "Assign_Room";
            this.Load += new System.EventHandler(this.Assign_Room_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hostelDbDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hostelDbDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRoomBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.ComboBox cbm_RoomNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_avaibseat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbm_CNIC;
        private System.Windows.Forms.TextBox txt_StudentName;
        private System.Windows.Forms.Label lbl_cnic;
        private HostelDbDataSet8 hostelDbDataSet8;
        private System.Windows.Forms.BindingSource tblStudentBindingSource;
        private HostelDbDataSet8TableAdapters.tbl_StudentTableAdapter tbl_StudentTableAdapter;
        private HostelDbDataSet9 hostelDbDataSet9;
        private System.Windows.Forms.BindingSource tblRoomBindingSource;
        private HostelDbDataSet9TableAdapters.tbl_RoomTableAdapter tbl_RoomTableAdapter;
    }
}