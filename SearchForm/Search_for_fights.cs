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
            gridviewoutbound.DataSource = routesBUL.xulychuyenbay(new SanBayDTO(cbfrom.SelectedValue.ToString(), cbfrom.Text),
                            new SanBayDTO(cbto.SelectedValue.ToString(), cbto.Text),
                            txtoutbound.Text, getCabintypes());
        }
        public void loadRoutesReturn()
        {
            gridviewreturn.DataSource = routesBUL.xulychuyenbay(new SanBayDTO(cbto.SelectedValue.ToString(), cbto.Text),
                            new SanBayDTO(cbfrom.SelectedValue.ToString(), cbfrom.Text),
                            txtreturn.Text, getCabintypes());
        }
        public bool checkngayve()
        {
            if (String.Compare(txtoutbound.Text, txtreturn.Text, true) > 0)
                return false;

            return true;
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
            if(rbreturn.Checked==true)
            {
                if(checkngayve())
                    loadRoutesReturn();
            }
            loadRoutes();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            loadcbsanbay();
            loadcbcabintypes();
            rboneway.Checked = true;
            
        }

        private void rboneway_CheckedChanged(object sender, EventArgs e)
        {
            if (rboneway.Checked == true)
                txtreturn.Enabled = false;
            else
            {
                txtreturn.Enabled = true;
            }
                

        }
    }
}
