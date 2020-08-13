using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class SanBayDTO
    {
        String id;
        String iatacode;

        public SanBayDTO() { }
        
        public SanBayDTO(String id,String iatacode) {
                this.Id = id;
                this.Iatacode = iatacode;
        }

        public string Id { get => id; set => id = value; }
        
        public string Iatacode { get => iatacode; set => iatacode = value; }


    }
}
