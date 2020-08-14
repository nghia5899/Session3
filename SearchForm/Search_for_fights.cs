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
        List<RoutesDTO> listongdi = new List<RoutesDTO>();
        List<RoutesDTO> listongve = new List<RoutesDTO>();
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

            listongdi.Clear();

            listongdi.AddRange(routesBUL.xulychuyenbay(new SanBayDTO(cbfrom.SelectedValue.ToString(), cbfrom.Text),
                            new SanBayDTO(cbto.SelectedValue.ToString(), cbto.Text),
                             converttoString(txtoutbound.Value), getCabintypes()));
            // if (listong.Count != 0)
            //     gridviewoutbound.DataSource = listong;

            //   gridviewoutbound.Refresh();
            loadgrv(gridviewoutbound,listongdi);


        }
        public void loadRoutesReturn()
        {
            listongve.Clear();

            listongve.AddRange(routesBUL.xulychuyenbay(new SanBayDTO(cbto.SelectedValue.ToString(), cbto.Text),
                            new SanBayDTO(cbfrom.SelectedValue.ToString(), cbfrom.Text),
                          converttoString(txtreturn.Value), getCabintypes()));
            loadgrv(gridviewreturn,listongve);
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
                grd.Rows[i].Cells[5].Value = item.Cabin_price;
                grd.Rows[i].Cells[6].Value = item.Number_of_stops+"";
                i++;
            }
        }
        public void loadthreeday1(String ngay,DataGridView grd,List<RoutesDTO> listtong)
        {
            
            DateTime ngaydi = DateTime.Parse(ngay);
            DateTime ngayditruoc = new DateTime(ngaydi.Year, ngaydi.Month, ngaydi.Day - 1);
            DateTime ngaydisau = new DateTime(ngaydi.Year, ngaydi.Month, ngaydi.Day + 1);
            
            listtong.AddRange(routesBUL.xulychuyenbay(new SanBayDTO(cbfrom.SelectedValue.ToString(), cbfrom.Text),
                        new SanBayDTO(cbto.SelectedValue.ToString(), cbto.Text),
                        ngayditruoc.ToString("yyyy/MM/dd"), getCabintypes()));
            listtong.AddRange(routesBUL.xulychuyenbay(new SanBayDTO(cbfrom.SelectedValue.ToString(), cbfrom.Text),
                        new SanBayDTO(cbto.SelectedValue.ToString(), cbto.Text),
                        ngaydisau.ToString("yyyy/MM/dd"), getCabintypes()));

            loadgrv(grd,listtong);
        }

        public String converttoString(DateTime ngay)
        {
            return ngay.ToString("yyyy/MM/dd");

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
            if (!cbfrom.SelectedValue.Equals(cbto.SelectedValue))
            {
                
                if (rbreturn.Checked == true)
                {
                        if (cbthreeday2.Checked == true)
                        {
                            loadRoutesReturn();
                            loadthreeday1(converttoString(txtreturn.Value),gridviewreturn,listongve);
                        }else
                            loadRoutesReturn();
                }
                if (cbthreeday1.Checked == true)
                {
                    loadRoutes();
                    loadthreeday1(converttoString(txtoutbound.Value),gridviewoutbound,listongdi);
                }  
                else
                    loadRoutes();
            }

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
                txtreturn.MinDate = txtoutbound.Value;
                txtreturn.Value = txtoutbound.Value;
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
                loadthreeday1(converttoString(txtreturn.Value), gridviewreturn,listongve);
            }
            else
                loadRoutesReturn();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void txtoutbound_ValueChanged(object sender, EventArgs e)
        {
            txtreturn.MinDate = txtoutbound.Value;
            txtreturn.Value = txtoutbound.Value;
        }

        private void rbreturn_CheckedChanged(object sender, EventArgs e)
        {

            if (rbreturn.Checked == true)
            {
                gridviewreturn.Enabled = true;
                cbthreeday2.Enabled = true;
                txtreturn.Enabled = true;
                txtreturnflight.Enabled = true;
            }
            else
            {
                gridviewreturn.Rows.Clear();
            }
        }
    }
}
