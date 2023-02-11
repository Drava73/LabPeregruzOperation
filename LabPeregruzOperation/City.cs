using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabPeregruzOperation
{
    public class City
    {
        private string namecity;
        private string namecountry;
        private int summofpeople;
        private int phonenumber;
        private string namecityragion;

        public static City operator +(City opl, int op2)
        {
            City result = new City();
            result.summofpeople = opl.summofpeople + op2;
            return result;
        }
        public static City operator -(City opl, int op2)
        {
            City result = new City();
            result.summofpeople = opl.summofpeople - op2;
            return result;
        }
        public static bool operator ==(City op1, City op2)
        {
            if ((op1.summofpeople == op2.summofpeople))
                return true;
            else
                return false;
        }
        public static bool operator !=(City op1, City op2)
        {
            if ((op1.summofpeople != op2.summofpeople))
                return true;
            else
                return false;
        }
        public static bool operator <(City op1, City op2)
        {
            if ((op1.summofpeople < op2.summofpeople))
                return true;
            else
                return false;
        }

        public static bool operator >(City op1, City op2)
        {
            if ((op1.summofpeople > op2.summofpeople))
                return true;
            else
                return false;
        }
        public string NameCity
        {
            get { return namecity; }

            set { namecity = value; }
        }
        public string NameCountry
        {
            get { return namecountry; }

            set { namecountry = value; }
        }
        public int People
        {
            get { return summofpeople; }

            set { summofpeople = value; }
        }
        public int Phone
        {
            get { return phonenumber; }

            set { phonenumber = value; }
        }
        public string NameRegion
        {
            get { return namecityragion; }

            set { namecityragion = value; }
        }

        public City()
        {
            namecity = "Null";
            namecityragion = "Null";
            namecountry = "Null";
            phonenumber = 0;
            phonenumber = 0;
        }
        public City(string namecity, string namecountry, int summofpeople, int phonenumber, string namecityragion)
        {
            this.namecity = namecity;
            this.namecountry = namecountry;
            this.summofpeople = summofpeople;
            this.phonenumber = phonenumber;
            this.namecityragion = namecityragion;
        }
        public void Print()
        {

        }
        public override string ToString()
        {
            return $"Name City:{namecity}\nName Country:{namecountry}\nPeople who live:{summofpeople}\nPhone number:{phonenumber}\nName city region:{namecityragion}";// переопределение ToString
        }

    }
}
