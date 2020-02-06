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
    public partial class bookfrom : Form
    {
        book model = new book();
        public bookfrom()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (start.Text.Length != 0 || finish.Text.Length != 0 || amount.Text.Length != 0)
            {
                model.start = start.Text.Trim();
                model.finish = finish.Text.Trim();
                using (TicketEntities1 db = new TicketEntities1())
                {
                    db.books.Add(model);
                    db.SaveChanges();
                }
                MessageBox.Show("จองตั๋วเสร็จสิ้น");
                
            }
            else
            {
                MessageBox.Show("โปรดใส่ข้อมูลให้ครบ");
            }

            String data1 = time.Value.ToString("HH:mm");
            String data = day.Value.ToString("dd/MM/yyyy");
            String data2 = start.Text.ToString();
            String data3 = finish.Text.ToString();
            int data4 = Convert.ToInt32(amount.Text);
            ticket frmtic = new ticket(data,data1,data2,data3,data4);

            

            frmtic.Show();
        }

        private void Day_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
            mainfrom m = new mainfrom();
            m.Show();
        }
    }
}
