namespace Ticket
{
    partial class mainfrom
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.firstname = new System.Windows.Forms.TextBox();
            this.lastname = new System.Windows.Forms.TextBox();
            this.gender = new System.Windows.Forms.TextBox();
            this.ncredit = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.reset = new System.Windows.Forms.Button();
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ticketDataSet = new Ticket.TicketDataSet();
            this.memberTableAdapter = new Ticket.TicketDataSetTableAdapters.memberTableAdapter();
            this.save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "ชื่อ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "นามสกุล";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "เพศ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "ที่อยู่";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "อีเมล";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "เบอร์โทร";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 336);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "เลขบัตรเครดิต";
            // 
            // firstname
            // 
            this.firstname.Location = new System.Drawing.Point(158, 28);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(248, 22);
            this.firstname.TabIndex = 2;
            // 
            // lastname
            // 
            this.lastname.Location = new System.Drawing.Point(158, 76);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(248, 22);
            this.lastname.TabIndex = 2;
            // 
            // gender
            // 
            this.gender.Location = new System.Drawing.Point(158, 121);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(86, 22);
            this.gender.TabIndex = 2;
            // 
            // ncredit
            // 
            this.ncredit.Location = new System.Drawing.Point(158, 333);
            this.ncredit.Name = "ncredit";
            this.ncredit.Size = new System.Drawing.Size(248, 22);
            this.ncredit.TabIndex = 2;
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(158, 294);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(248, 22);
            this.phone.TabIndex = 2;
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(158, 167);
            this.address.Multiline = true;
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(291, 68);
            this.address.TabIndex = 2;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(158, 252);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(248, 22);
            this.email.TabIndex = 2;
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(387, 410);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(111, 41);
            this.reset.TabIndex = 3;
            this.reset.Text = "ล้างข้อมูล";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // memberBindingSource
            // 
            this.memberBindingSource.DataMember = "member";
            this.memberBindingSource.DataSource = this.ticketDataSet;
            // 
            // ticketDataSet
            // 
            this.ticketDataSet.DataSetName = "TicketDataSet";
            this.ticketDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // memberTableAdapter
            // 
            this.memberTableAdapter.ClearBeforeFill = true;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(133, 410);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(111, 40);
            this.save.TabIndex = 5;
            this.save.Text = "บันทึก";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.Save_Click);
            // 
            // mainfrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 559);
            this.Controls.Add(this.save);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.address);
            this.Controls.Add(this.email);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.ncredit);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.firstname);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "mainfrom";
            this.Text = "หน้าหลัก";
            this.Load += new System.EventHandler(this.Mainfrom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox firstname;
        private System.Windows.Forms.TextBox lastname;
        private System.Windows.Forms.TextBox gender;
        private System.Windows.Forms.TextBox ncredit;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Button reset;
        private TicketDataSet ticketDataSet;
        private System.Windows.Forms.BindingSource memberBindingSource;
        private TicketDataSetTableAdapters.memberTableAdapter memberTableAdapter;
        private System.Windows.Forms.Button save;
    }
}

