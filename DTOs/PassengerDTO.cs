using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class PassengerDTO
    {
        String firstname;
        String lastname;
        String birthday;
        String passportnumber;
        String passportcountry;
        String phone;
        String passportcountryId;
        public PassengerDTO()
        {

        }
        public PassengerDTO(String firstname, String lastname, String birthday, String passportnumber, String passportcountry, String phone)
        {
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.Birthday = birthday;
            this.Passportnumber = passportnumber;
            this.Passportcountry = passportcountry;
            this.Phone = phone;
        }
        public string Firstname { get => firstname; set => firstname = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public string Birthday { get => birthday; set => birthday = value; }
        public string Passportnumber { get => passportnumber; set => passportnumber = value; }
        public string Passportcountry { get => passportcountry; set => passportcountry = value; }
        public string Phone { get => phone; set => phone = value; }
        public string PassportcountryId { get => passportcountryId; set => passportcountryId = value; }
    }
}
