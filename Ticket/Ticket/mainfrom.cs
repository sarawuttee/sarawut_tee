using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticket
{
    public partial class mainfrom : System.Windows.Forms.Form
    {
        member model = new member();
        private object dgvmember;

        public mainfrom()
        {
            InitializeComponent();
        }
        private void Reset_Click(object sender, EventArgs e)
        {
            this.firstname.Clear();
            this.lastname.Clear();
            this.gender.Clear();
            this.address.Clear();
            this.email.Clear();
            this.phone.Clear();
            this.ncredit.Clear();
        }


        private void Mainfrom_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ticketDataSet.member' table. You can move, or remove it, as needed.
            this.memberTableAdapter.Fill(this.ticketDataSet.member);
            Clear();
        }
        void Clear()
        {
            save.Text = "save";
            model.idmember = 0;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (firstname.Text.Length != 0 || lastname.Text.Length != 0 || gender.Text.Length != 0 || address.Text.Length != 0 || email.Text.Length != 0 || phone.Text.Length != 0 || ncredit.Text.Length != 0)
            {

                model.firstname = firstname.Text.Trim();
                model.lastname = lastname.Text.Trim();
                model.address = address.Text.Trim();
                model.email = email.Text.Trim();
                model.ncradit = ncredit.Text.Trim();
                model.gender = gender.Text.Trim();
                model.phone = phone.Text.Trim();
                using (TicketEntities1 db = new TicketEntities1())
                {
                    db.members.Add(model);
                    db.SaveChanges();
                }
                Clear();
                MessageBox.Show("บันทึกเสร็จสิ้น");
                this.Hide();
                bookfrom b = new bookfrom();
                b.Show();
            }
            else
            {
                MessageBox.Show("โปรดใส่ข้อมูลให้ครบ");
            }
        }
       
    }
}
