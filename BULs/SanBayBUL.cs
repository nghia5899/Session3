using DALs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BULs
{
    public class SanBayBUL
    {
        SanBayDAL sanbayDAL = new SanBayDAL();

        public DataTable getSanBay() {
            return sanbayDAL.getSanBay();
        }
        public DataTable getCabintypes()
        {
            return sanbayDAL.getCabintypes();
        }
    }
}
