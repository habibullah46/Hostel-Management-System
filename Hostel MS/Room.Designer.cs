namespace Hostel_MS
{
    partial class Room
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Room));
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Rnumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_floor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_perSeatRent = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbm_type = new System.Windows.Forms.ComboBox();
            this.cbm_AttachWashroom = new System.Windows.Forms.ComboBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_Availableseat = new System.Windows.Forms.TextBox();
            this.lable8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(245, 516);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 64);
            this.button2.TabIndex = 11;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 586);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(506, 88);
            this.panel2.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(506, 134);
            this.panel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(175, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Room";
            // 
            // txt_Rnumber
            // 
            this.txt_Rnumber.Location = new System.Drawing.Point(209, 165);
            this.txt_Rnumber.Name = "txt_Rnumber";
            this.txt_Rnumber.Size = new System.Drawing.Size(223, 26);
            this.txt_Rnumber.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Number:";
            // 
            // txt_floor
            // 
            this.txt_floor.Location = new System.Drawing.Point(209, 219);
            this.txt_floor.Name = "txt_floor";
            this.txt_floor.Size = new System.Drawing.Size(223, 26);
            this.txt_floor.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Floor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Type:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Attach Washroom:";
            // 
            // txt_perSeatRent
            // 
            this.txt_perSeatRent.Location = new System.Drawing.Point(209, 385);
            this.txt_perSeatRent.Name = "txt_perSeatRent";
            this.txt_perSeatRent.Size = new System.Drawing.Size(223, 26);
            this.txt_perSeatRent.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(36, 391);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "Per Seat Rent:";
            // 
            // cbm_type
            // 
            this.cbm_type.FormattingEnabled = true;
            this.cbm_type.Items.AddRange(new object[] {
            "1Bed",
            "2Bed",
            "3Bed",
            "4Bed",
            "5Bed"});
            this.cbm_type.Location = new System.Drawing.Point(209, 263);
            this.cbm_type.Name = "cbm_type";
            this.cbm_type.Size = new System.Drawing.Size(223, 28);
            this.cbm_type.TabIndex = 28;
            // 
            // cbm_AttachWashroom
            // 
            this.cbm_AttachWashroom.FormattingEnabled = true;
            this.cbm_AttachWashroom.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cbm_AttachWashroom.Location = new System.Drawing.Point(209, 324);
            this.cbm_AttachWashroom.Name = "cbm_AttachWashroom";
            this.cbm_AttachWashroom.Size = new System.Drawing.Size(223, 28);
            this.cbm_AttachWashroom.TabIndex = 29;
            // 
            // btn_save
            // 
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.ImageKey = "(none)";
            this.btn_save.Location = new System.Drawing.Point(43, 516);
            this.btn_save.Name = "btn_save";
            this.btn_save.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_save.Size = new System.Drawing.Size(149, 64);
            this.btn_save.TabIndex = 30;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txt_Availableseat
            // 
            this.txt_Availableseat.AcceptsReturn = true;
            this.txt_Availableseat.Location = new System.Drawing.Point(209, 441);
            this.txt_Availableseat.Name = "txt_Availableseat";
            this.txt_Availableseat.Size = new System.Drawing.Size(223, 26);
            this.txt_Availableseat.TabIndex = 32;
            // 
            // lable8
            // 
            this.lable8.AutoSize = true;
            this.lable8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable8.Location = new System.Drawing.Point(36, 441);
            this.lable8.Name = "lable8";
            this.lable8.Size = new System.Drawing.Size(124, 20);
            this.lable8.TabIndex = 31;
            this.lable8.Text = "Available Seat";
            // 
            // Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 674);
            this.Controls.Add(this.txt_Availableseat);
            this.Controls.Add(this.lable8);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.cbm_AttachWashroom);
            this.Controls.Add(this.cbm_type);
            this.Controls.Add(this.txt_perSeatRent);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_floor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Rnumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(528, 730);
            this.MinimumSize = new System.Drawing.Size(528, 730);
            this.Name = "Room";
            this.Text = "Room";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Rnumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_floor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_perSeatRent;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbm_type;
        private System.Windows.Forms.ComboBox cbm_AttachWashroom;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox txt_Availableseat;
        private System.Windows.Forms.Label lable8;
    }
}