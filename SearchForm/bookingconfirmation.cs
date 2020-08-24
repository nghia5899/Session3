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
    public partial class bookingconfirmation : Form
    {
        TicketBUL ticketBUL = new TicketBUL();
        BookingBUL bookingBUL = new BookingBUL();
        List<RoutesDTO> listdi = new List<RoutesDTO>();
        List<RoutesDTO> listve = new List<RoutesDTO>();
        List<PassengerDTO> listpassenger = new List<PassengerDTO>();
        private String cabintype;
        private String iddi = "";
        private String idve = "";
        String bookingreference;
        String ngaydi;
        String ngayve;
        Boolean checkve = false;
        String[] mangid;
        String[] mangidve;

        public string Cabintype { get => cabintype; set => cabintype = value; }
        public string Iddi { get => iddi; set => iddi = value; }
        public string Idve { get => idve; set => idve = value; }
        public string Ngaydi { get => ngaydi; set => ngaydi = value; }
        public string Ngayve { get => ngayve; set => ngayve = value; }
        public bool Checkve { get => checkve; set => checkve = value; }

        public bookingconfirmation()
        {
            InitializeComponent();
            taobookingreference();
        }
        public void loadcoutries()
        {
            txtpassportcountry.DataSource = bookingBUL.getCountries();
            txtpassportcountry.DisplayMember = "name";
            txtpassportcountry.ValueMember = "id";
        }

        public double getCabintypes()
        {
            if (cabintype.Equals("Economy"))
                return 1;
            else if (cabintype.Equals("Business"))
                return 1 + 0.35;
            else if (cabintype.Equals("First Class"))
                return (1 + 0.35) * (1 + 0.3);
            return 1;
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
        public void loadchuyenbaydi()
        {
            mangid = Iddi.Split('-');

            listdi.Add(bookingBUL.GetRoutes(mangid[0], getCabintypes()));

            if (mangid.Length > 1)
                listdi.Add(bookingBUL.GetRoutes(mangid[1], getCabintypes()));

            hienthidi(mangid);
        }
        public void loadchuyenbayve()
        {
            if (checkve)
            {
                mangidve = Idve.Split('-');
                listve.Add(bookingBUL.GetRoutes(mangidve[0], getCabintypes()));
                if (mangidve.Length > 1)
                    listve.Add(bookingBUL.GetRoutes(mangidve[1], getCabintypes()));
                hienthive(mangidve);
            }

        }

        public void hienthidi(String[] mangdi)
        {
            txtfromout.Text = listdi[0].From;
            txttoout.Text = listdi[0].To;
            txtcabintypeout.Text = Cabintype;
            txtdateout.Text = ngaydi;
            txtflightnumberout.Text = listdi[0].Flights_number;
            if (mangdi.Length > 1)
            {
                outbound1.Visible = true;
                txtfromout1.Text = listdi[1].From;
                txttoout1.Text = listdi[1].To;
                txtcabintypeout1.Text = Cabintype;
                txtdateout1.Text = ngaydi;
                txtflightnumberout1.Text = listdi[1].Flights_number;
            }
        }
        public void hienthive(String[] mangve)
        {
            returnflight.Visible = true;
            txtfromre.Text = listve[0].From;
            txttore.Text = listve[0].To;
            txtcabintypere.Text = Cabintype;
            txtdatere.Text = ngayve;
            txtflightre.Text = listve[0].Flights_number;
            if (mangve.Length > 1)
            {
                returnflight1.Visible = true;
                txtfromre1.Text = listve[1].From;
                txttore1.Text = listve[1].To;
                txtcabintypere1.Text = Cabintype;
                txtdatere1.Text = ngayve;
                txtflightre1.Text = listve[1].Flights_number;
            }
        }
        public void addpassenger()
        {
            PassengerDTO passenger = new PassengerDTO();
            passenger.Firstname = txtfirstname.Text;
            passenger.Lastname = txtlastname.Text;
            passenger.PassportcountryId = txtpassportcountry.SelectedValue.ToString();
            passenger.Passportcountry = txtpassportcountry.Text;
            passenger.Passportnumber = txtpassportnb.Text;
            passenger.Phone = txtphone.Text;
            passenger.Birthday = txtbirthdate.Value.ToString("yyyy/MM/dd");
            listpassenger.Add(passenger);
        }

        public void loadgrv()
        {
            grvpassenger.Rows.Clear();
            grvpassenger.ColumnCount = 6;
            int i = 0;
            foreach (PassengerDTO item in listpassenger)
            {
                grvpassenger.Rows.Add();
                grvpassenger.Rows[i].Cells[0].Value = item.Firstname;
                grvpassenger.Rows[i].Cells[1].Value = item.Lastname;
                grvpassenger.Rows[i].Cells[2].Value = item.Birthday;
                grvpassenger.Rows[i].Cells[3].Value = item.Passportnumber;
                grvpassenger.Rows[i].Cells[4].Value = item.Passportcountry;
                grvpassenger.Rows[i].Cells[5].Value = item.Phone;
                i++;
            }
        }

        public void remove()
        {
            int vitri = listpassenger.Count;
            listpassenger.RemoveAt(vitri - 1);
        }

        public int getTongTien()
        {
            int tongtien = 0;
            foreach (RoutesDTO item in listdi)
            {
                tongtien += Convert.ToInt32(item.Cabin_price);
            }
            if(checkve)
                foreach (RoutesDTO item in listve)
                {
                    tongtien += Convert.ToInt32(item.Cabin_price);
                }
            return tongtien;
        }
        public void addTicket()
        {
            foreach (PassengerDTO item in listpassenger)
            {
                ticketBUL.addTicket(item,mangid[0],getCabintypesID(),bookingreference);
                if(mangid.Length>1)
                    ticketBUL.addTicket(item, mangid[1], getCabintypesID(), bookingreference);
                if(checkve)
                {
                    ticketBUL.addTicket(item, mangidve[0], getCabintypesID(), bookingreference);
                    if(mangidve.Length>1)
                        ticketBUL.addTicket(item, mangidve[1], getCabintypesID(), bookingreference);
                }
            }
        }

        public void taobookingreference()
        {
            Random random = new Random();  
            for (int i = 0; i < 6; i++)
            {
                String br = char.ConvertFromUtf32(random.Next(65, 90));
                bookingreference +=  br;
            }
            
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnremove_Click(object sender, EventArgs e)
        {

            if (listpassenger.Count > 0)
            {
                DialogResult result = MessageBox.Show(this, "Bạn chắc chắn xóa", "Xóa", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    remove();
                }
            }  
            //ádsads
            loadgrv();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            addpassenger();
            loadgrv();
        }

        private void bookingconfirmation_Load(object sender, EventArgs e)
        {
            loadcoutries();
            loadchuyenbaydi();
            if(checkve)
                loadchuyenbayve();
        }

        private void btnconfirm_Click(object sender, EventArgs e)
        {
            if (listpassenger.Count > 0)
            {
                addTicket();
                MessageBox.Show("Đặt vé thành công");
                Billing_confirmation billing = new Billing_confirmation();
                billing.Tongtien = getTongTien() * listpassenger.Count;
                billing.Show();
                Visible = false;
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            Visible = false;
        }
    }
}
