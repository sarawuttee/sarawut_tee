namespace Ticket
{
    partial class bookfrom
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
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.day = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.DateTimePicker();
            this.amount = new System.Windows.Forms.TextBox();
            this.start = new System.Windows.Forms.ComboBox();
            this.finish = new System.Windows.Forms.ComboBox();
            this.submit = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(273, 264);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "ที่นั่ง";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "จำนวน";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "ลงที่";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "ออกจาก";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "เลือกวันเดินทาง";
            // 
            // day
            // 
            this.day.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.day.Location = new System.Drawing.Point(166, 26);
            this.day.Name = "day";
            this.day.Size = new System.Drawing.Size(200, 22);
            this.day.TabIndex = 16;
            this.day.ValueChanged += new System.EventHandler(this.Day_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "เวลา";
            // 
            // time
            // 
            this.time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.time.Location = new System.Drawing.Point(166, 71);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(200, 22);
            this.time.TabIndex = 17;
            // 
            // amount
            // 
            this.amount.Location = new System.Drawing.Point(166, 259);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(56, 22);
            this.amount.TabIndex = 18;
            // 
            // start
            // 
            this.start.FormattingEnabled = true;
            this.start.Items.AddRange(new object[] {
            "กระบี่",
            "กรุงเทพมหานคร",
            "กาญจนบุรี",
            "กาฬสินธุ์",
            "กำแพงเพชร",
            "ขอนแก่น",
            "จันทบุรี",
            "ฉะเชิงเทรา",
            "ชลบุรี",
            "ชัยนาท",
            "ชัยภูมิ",
            "ชุมพร",
            "เชียงราย",
            "เชียงใหม่",
            "ตรัง",
            "ตราด",
            "ตาก",
            "นครนายก",
            "นครปฐม",
            "นครพนม",
            "นครราชสีมา",
            "นครศรีธรรมราช",
            "นครสวรรค์",
            "นนทบุรี",
            "นราธิวาส",
            "น่าน",
            "บึงกาฬ",
            "บุรีรัมย์",
            "ปทุมธานี",
            "ประจวบคีรีขันธ์",
            "ปราจีนบุรี",
            "ปัตตานี",
            "พระนครศรีอยุธยา",
            "พะเยา",
            "พังงา",
            "พัทลุง",
            "พิจิตร",
            "พิษณุโลก",
            "เพชรบุรี",
            "เพชรบูรณ์",
            "แพร่",
            "ภูเก็ต",
            "มหาสารคาม",
            "มุกดาหาร",
            "แม่ฮ่องสอน",
            "ยโสธร",
            "ยะลา",
            "ร้อยเอ็ด",
            "ระนอง",
            "ระยอง",
            "ราชบุรี",
            "ลพบุรี",
            "ลำปาง",
            "ลำพูน",
            "เลย",
            "ศรีสระเกษ",
            "สกลนคร",
            "สงขลา",
            "สตูล",
            "สมุทรปราการ",
            "สมุทรสงคราม",
            "สมุทรสาคร",
            "สระแก้ว",
            "สระบุรี",
            "สิงห์บุรี",
            "สุโขทัย",
            "สุพรรณบุรี",
            "สุราษฎร์ธานี",
            "สุรินทร์",
            "หนองคาย",
            "หนองบัวลำภู",
            "อ่างทอง",
            "อำนาจเจริญ",
            "อุดรธานี",
            "อุดตรดิตถ์",
            "อุทัยธานี",
            "อุบลราชธานี"});
            this.start.Location = new System.Drawing.Point(166, 129);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(200, 24);
            this.start.TabIndex = 19;
            // 
            // finish
            // 
            this.finish.FormattingEnabled = true;
            this.finish.Items.AddRange(new object[] {
            "กระบี่",
            "กรุงเทพมหานคร",
            "กาญจนบุรี",
            "กาฬสินธุ์",
            "กำแพงเพชร",
            "ขอนแก่น",
            "จันทบุรี",
            "ฉะเชิงเทรา",
            "ชลบุรี",
            "ชัยนาท",
            "ชัยภูมิ",
            "ชุมพร",
            "เชียงราย",
            "เชียงใหม่",
            "ตรัง",
            "ตราด",
            "ตาก",
            "นครนายก",
            "นครปฐม",
            "นครพนม",
            "นครราชสีมา",
            "นครศรีธรรมราช",
            "นครสวรรค์",
            "นนทบุรี",
            "นราธิวาส",
            "น่าน",
            "บึงกาฬ",
            "บุรีรัมย์",
            "ปทุมธานี",
            "ประจวบคีรีขันธ์",
            "ปราจีนบุรี",
            "ปัตตานี",
            "พระนครศรีอยุธยา",
            "พะเยา",
            "พังงา",
            "พัทลุง",
            "พิจิตร",
            "พิษณุโลก",
            "เพชรบุรี",
            "เพชรบูรณ์",
            "แพร่",
            "ภูเก็ต",
            "มหาสารคาม",
            "มุกดาหาร",
            "แม่ฮ่องสอน",
            "ยโสธร",
            "ยะลา",
            "ร้อยเอ็ด",
            "ระนอง",
            "ระยอง",
            "ราชบุรี",
            "ลพบุรี",
            "ลำปาง",
            "ลำพูน",
            "เลย",
            "ศรีสระเกษ",
            "สกลนคร",
            "สงขลา",
            "สตูล",
            "สมุทรปราการ",
            "สมุทรสงคราม",
            "สมุทรสาคร",
            "สระแก้ว",
            "สระบุรี",
            "สิงห์บุรี",
            "สุโขทัย",
            "สุพรรณบุรี",
            "สุราษฎร์ธานี",
            "สุรินทร์",
            "หนองคาย",
            "หนองบัวลำภู",
            "อ่างทอง",
            "อำนาจเจริญ",
            "อุดรธานี",
            "อุดตรดิตถ์",
            "อุทัยธานี",
            "อุบลราชธานี"});
            this.finish.Location = new System.Drawing.Point(166, 196);
            this.finish.Name = "finish";
            this.finish.Size = new System.Drawing.Size(200, 24);
            this.finish.TabIndex = 19;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(105, 353);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(85, 34);
            this.submit.TabIndex = 20;
            this.submit.Text = "ตกลง";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(294, 353);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 33);
            this.button2.TabIndex = 21;
            this.button2.Text = "ย้อนกลับ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // bookfrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.finish);
            this.Controls.Add(this.start);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.time);
            this.Controls.Add(this.day);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "bookfrom";
            this.Text = "bookfrom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker day;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker time;
        private System.Windows.Forms.TextBox amount;
        private System.Windows.Forms.ComboBox start;
        private System.Windows.Forms.ComboBox finish;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Button button2;
    }
}