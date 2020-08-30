using BULs;
using DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SearchForm
{
    public partial class Billing_confirmation : Form
    {
        TicketBUL ticketBUL = new TicketBUL();
        String[] mangid;
        String[] mangidve;
        String bookingreference;
        int tongtien;
         String cabintype;
        List<PassengerDTO> listpassenger;
        Boolean checkve;
        bookingconfirmation form2;

        public Billing_confirmation()
        {
            InitializeComponent();
        }

        public int Tongtien { get => Tongtien1; set => Tongtien1 = value; }
        public string[] Mangid { get => mangid; set => mangid = value; }
        public string[] Mangidve { get => mangidve; set => mangidve = value; }
        public string Bookingreference { get => bookingreference; set => bookingreference = value; }
        public int Tongtien1 { get => tongtien; set => tongtien = value; }
        public string Cabintype { get => cabintype; set => cabintype = value; }
        public List<PassengerDTO> Listpassenger { get => listpassenger; set => listpassenger = value; }
        public bool Checkve { get => checkve; set => checkve = value; }
        public bookingconfirmation Form2 { get => form2; set => form2 = value; }

        private void button2_Click(object sender, EventArgs e)
        {
            addTicket();
            DialogResult result = MessageBox.Show("Xác nhận", "Bạn đã đặt thành công", MessageBoxButtons.OK);
            if (result == DialogResult.OK)
            {
                Form1 form1 = new Form1();
                form1.Show();
                Visible = false;
            }
            else
            {
                Form1 form1 = new Form1();
                form1.Show();
                Visible = false;

            }
            

        }
        public String getCabintypesID()
        {
            if (cabintype.Equals("Economy"))
                return 1 + "";
            else if (cabintype.Equals("Business"))
                return 2 + "";
            else if (cabintype.Equals("First Class"))
                return 3 + "";
            return 1 + "";
        }
        public void addTicket()
        {
            foreach (PassengerDTO item in listpassenger)
            {
                ticketBUL.addTicket(item, Mangid[0], getCabintypesID(), Bookingreference);
                if (Mangid.Length > 1)
                    ticketBUL.addTicket(item, Mangid[1], getCabintypesID(), Bookingreference);
                if (Checkve)
                {
                    ticketBUL.addTicket(item, Mangidve[0], getCabintypesID(), Bookingreference);
                    if (Mangidve.Length > 1)
                        ticketBUL.addTicket(item, Mangidve[1], getCabintypesID(), Bookingreference);
                }
            }
        }
        private void Billing_confirmation_Load(object sender, EventArgs e)
        {
            txttongtien.Text = "$"+Tongtien1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bookingconfirmation bookingconfirmation = form2;
            bookingconfirmation.Show();
            Visible = false;
        }
    }
}
