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
    public partial class Form1 : Form
    {
        SanBayBUL sanbayBUL = new SanBayBUL();
        RoutesBUL routesBUL = new RoutesBUL();
        SeatBUL seatBUL = new SeatBUL();
        int vitridi=0;
        int vitrive=0;
        List<RoutesDTO> listongdi = new List<RoutesDTO>();
        List<RoutesDTO> listongve = new List<RoutesDTO>();
        Boolean clickdi = false, clickve = false;

        public void loadcbsanbay()
        {
            cbfrom.DataSource = sanbayBUL.getSanBay();
            cbfrom.DisplayMember = "iatacode";
            cbfrom.ValueMember = "id";
            cbto.DataSource = sanbayBUL.getSanBay();
            cbto.DisplayMember = "iatacode";
            cbto.ValueMember = "id";
        }
        public void loadcbcabintypes()
        {
            cbcabintype.DataSource = sanbayBUL.getCabintypes();
            cbcabintype.DisplayMember = "name";
            cbcabintype.ValueMember = "id";
        }
        public double getCabintypes()
        {
            if (cbcabintype.Text.Equals("Economy"))
                return 1;
            else if (cbcabintype.Text.Equals("Business"))
                return 1 + 0.35;
            else if (cbcabintype.Text.Equals("First Class"))
                return (1 + 0.35) * (1 + 0.3);
            return 1;
        }
        public void loadRoutes()
        {
            if (!cbfrom.SelectedValue.Equals(cbto.SelectedValue))
            {
                listongdi.Clear();

                listongdi.AddRange(routesBUL.xulychuyenbay(new SanBayDTO(cbfrom.SelectedValue.ToString(), cbfrom.Text),
                                new SanBayDTO(cbto.SelectedValue.ToString(), cbto.Text),
                                 converttoString(txtoutbound.Value), getCabintypes()));

                loadgrv(gridviewoutbound, listongdi);
            }


        }
        public void loadRoutesReturn()
        {
            if (!cbfrom.SelectedValue.Equals(cbto.SelectedValue))
            {
                listongve.Clear();

                listongve.AddRange(routesBUL.xulychuyenbay(new SanBayDTO(cbto.SelectedValue.ToString(), cbto.Text),
                                new SanBayDTO(cbfrom.SelectedValue.ToString(), cbfrom.Text),
                              converttoString(txtreturn.Value), getCabintypes()));
                loadgrv(gridviewreturn, listongve);
            }
        }
        public void loadgrv(DataGridView grd,List<RoutesDTO> listong)
        {
            grd.Rows.Clear();
            grd.ColumnCount = 7;
            int i = 0;
            foreach (RoutesDTO item in listong)
            {
                grd.Rows.Add();
                grd.Rows[i].Cells[0].Value = item.From;
                grd.Rows[i].Cells[1].Value = item.To;
                grd.Rows[i].Cells[2].Value = item.Date;
                grd.Rows[i].Cells[3].Value = item.Time;
                grd.Rows[i].Cells[4].Value = item.Flights_number;
                grd.Rows[i].Cells[5].Value = "$"+item.Cabin_price;
                grd.Rows[i].Cells[6].Value = item.Number_of_stops+"";
                i++;
            }
        }
        public void loadthreeday1(String ngay,DataGridView grd,List<RoutesDTO> listtong)
        {
            if (!cbfrom.SelectedValue.Equals(cbto.SelectedValue))
            {
                listongdi.Clear();  
                DateTime ngaydi = DateTime.Parse(ngay);
                
                

                for (int i = 3; i >=1; i--)
                {
                    DateTime ngayditruoc = new DateTime(ngaydi.Year, ngaydi.Month, ngaydi.Day - i);
                    listtong.AddRange(routesBUL.xulychuyenbay(new SanBayDTO(cbfrom.SelectedValue.ToString(), cbfrom.Text),
                            new SanBayDTO(cbto.SelectedValue.ToString(), cbto.Text),
                            ngayditruoc.ToString("yyyy/MM/dd"), getCabintypes()));
                }
                listongdi.AddRange(routesBUL.xulychuyenbay(new SanBayDTO(cbfrom.SelectedValue.ToString(), cbfrom.Text),
                                new SanBayDTO(cbto.SelectedValue.ToString(), cbto.Text),
                                 converttoString(txtoutbound.Value), getCabintypes()));

                
                for (int i = 1; i <=3; i++)
                {
                    DateTime ngaydisau = new DateTime(ngaydi.Year, ngaydi.Month, ngaydi.Day + i);
                    listtong.AddRange(routesBUL.xulychuyenbay(new SanBayDTO(cbfrom.SelectedValue.ToString(), cbfrom.Text),
                            new SanBayDTO(cbto.SelectedValue.ToString(), cbto.Text),
                            ngaydisau.ToString("yyyy/MM/dd"), getCabintypes()));
                }
                
                

                loadgrv(grd, listtong);
            }
        }
        public void loadthreeday2(String ngay, DataGridView grd, List<RoutesDTO> listtong)
        {

            if (!cbfrom.SelectedValue.Equals(cbto.SelectedValue))
            {
                listongve.Clear();
                DateTime ngaydi = DateTime.Parse(ngay);
                
                

                for (int i = 3; i >=1; i--)
                {
                    DateTime ngayditruoc = new DateTime(ngaydi.Year, ngaydi.Month, ngaydi.Day - i);
                    listtong.AddRange(routesBUL.xulychuyenbay(new SanBayDTO(cbto.SelectedValue.ToString(), cbto.Text),
                                                new SanBayDTO(cbfrom.SelectedValue.ToString(), cbfrom.Text),
                                                ngayditruoc.ToString("yyyy/MM/dd"), getCabintypes()));
                }
                listongve.AddRange(routesBUL.xulychuyenbay(new SanBayDTO(cbto.SelectedValue.ToString(), cbto.Text),
                                new SanBayDTO(cbfrom.SelectedValue.ToString(), cbfrom.Text),
                              converttoString(txtreturn.Value), getCabintypes()));
                for (int i = 1; i<=3; i++)
                {
                    DateTime ngaydisau = new DateTime(ngaydi.Year, ngaydi.Month, ngaydi.Day + i);
                    listtong.AddRange(routesBUL.xulychuyenbay(new SanBayDTO(cbto.SelectedValue.ToString(), cbto.Text),
                            new SanBayDTO(cbfrom.SelectedValue.ToString(), cbfrom.Text),
                            ngaydisau.ToString("yyyy/MM/dd"), getCabintypes()));
                }
                

                loadgrv(grd, listtong);
            }
        }

        public String converttoString(DateTime ngay)
        {
            return ngay.ToString("yyyy/MM/dd");

        }
        public void setngayve()
        {
            DateTime ngayve = new DateTime(txtoutbound.Value.Year, txtoutbound.Value.Month, txtoutbound.Value.Day + 1);
            txtreturn.MinDate = ngayve;
            txtreturn.Value = ngayve;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clickdi = false;
            clickve = false;
            if (!cbfrom.SelectedValue.Equals(cbto.SelectedValue))
            {
                
                if (rbreturn.Checked == true)
                {
                        if (cbthreeday2.Checked == true)
                        {
                            loadthreeday2(converttoString(txtreturn.Value), gridviewreturn, listongve);
                        }else
                            loadRoutesReturn();
                }
                if (cbthreeday1.Checked == true)
                {
                    loadthreeday1(converttoString(txtoutbound.Value),gridviewoutbound,listongdi);
                }  
                else
                    loadRoutes();
            }
            confirmbooking.Enabled = false;

        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            loadcbsanbay();
            loadcbcabintypes();
        }

        private void rboneway_CheckedChanged(object sender, EventArgs e)
        {
            if (rboneway.Checked == true)
            {
                txtreturn.Enabled = false;
                gridviewreturn.Enabled = false;
                cbthreeday2.Enabled = false;
                txtreturnflight.Enabled = false;
            }   
           
                

        }

        private void cbthreeday1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbthreeday1.Checked == true)
            {
                
                loadthreeday1(converttoString(txtoutbound.Value),gridviewoutbound,listongdi);
            }
            else
                loadRoutes();
            
        }

        private void cbcabintype_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbthreeday2_CheckedChanged(object sender, EventArgs e)
        {
            if (cbthreeday2.Checked == true)
            {
                
                loadthreeday2(converttoString(txtreturn.Value), gridviewreturn,listongve);
            }
            else
                loadRoutesReturn();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bookingconfirmation bc = new bookingconfirmation();
            bc.Iddi = listongdi[vitridi].Idschedules;
            bc.Cabintype = cbcabintype.Text;
            bc.Ngaydi = converttoString(txtoutbound.Value);
            bc.Checkve = rbreturn.Checked;
            if (rbreturn.Checked)
            { 
               bc.Idve = listongve[vitrive].Idschedules;
               bc.Ngayve = converttoString(txtreturn.Value);
            }
            bc.Show();
            Visible = false;
        }

        private void txtoutbound_ValueChanged(object sender, EventArgs e)
        {
            setngayve();
        }

        private void rbreturn_CheckedChanged(object sender, EventArgs e)
        {

            if (rbreturn.Checked == true)
            {
                gridviewreturn.Enabled = true;
                cbthreeday2.Enabled = true;
                txtreturn.Enabled = true;
                txtreturnflight.Enabled = true;
                setngayve();
            }
            else
            {
                gridviewreturn.Rows.Clear();
            }
        }
        public void xulyghe(List<RoutesDTO> list,int vitri)
        {
            String cabintype = cbcabintype.SelectedValue.ToString();
            String idschedules = list[vitri].Idschedules;
            String[] mangid = idschedules.Split('-');
            if (mangid.Length > 1)
            {

                if (seatBUL.checkSeat(mangid[0], cabintype).Equals("1"))
                {

                    if (seatBUL.checkSeat(mangid[1], cabintype).Equals("1"))
                    {
                        if (rboneway.Checked && clickdi == true)
                            confirmbooking.Enabled = true;
                        else if (rbreturn.Checked && clickdi == true && clickve == true)
                            confirmbooking.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show(seatBUL.checkSeat(mangid[1], cabintype), "Tình trạng vé ");
                        confirmbooking.Enabled = false;
                    }

                }
                else
                {
                    MessageBox.Show(seatBUL.checkSeat(mangid[0], cabintype), "Tình trạng vé ");
                    confirmbooking.Enabled = false;
                }
            }
            else
                if (seatBUL.checkSeat(idschedules, cabintype).Equals("1"))
                {
                    if(rboneway.Checked && clickdi == true)
                        confirmbooking.Enabled = true;
                    else if (rbreturn.Checked && clickdi == true && clickve == true)
                            confirmbooking.Enabled = true;
            }
                else
                {
                    MessageBox.Show(seatBUL.checkSeat(idschedules, cabintype), "Tình trạng vé");
                    confirmbooking.Enabled = false;
                }

            


        }
        private void gridviewoutbound_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            clickdi = true;
            vitridi = e.RowIndex;
            xulyghe(listongdi, vitridi);
        }

        private void gridviewreturn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            clickve = true;
            vitrive = e.RowIndex;
            xulyghe(listongve, vitrive);
        }
    }
}
