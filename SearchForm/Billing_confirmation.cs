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
        int tongtien;

        public Billing_confirmation()
        {
            InitializeComponent();
        }

        public int Tongtien { get => tongtien; set => tongtien = value; }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Billing_confirmation_Load(object sender, EventArgs e)
        {
            txttongtien.Text = "$"+tongtien;
        }
    }
}
