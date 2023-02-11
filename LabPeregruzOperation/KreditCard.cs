using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabPeregruzOperation
{
    public class KreditCard
    {
        public int numbercard;
        public string Name;
        public int CVC;
        public string timeofend;
        public int money;

        public static KreditCard operator +(KreditCard opl, int op2)
        {
            KreditCard result = new KreditCard();
            result.money = opl.money + op2;
            return result;
        }
        public static KreditCard operator -(KreditCard opl, int op2)
        {
            KreditCard result = new KreditCard();
            result.money = opl.money - op2;
            return result;
        }
        public static bool operator ==(KreditCard op1, KreditCard op2)
        {
            if ((op1.CVC == op2.CVC))
                return true;
            else
                return false;
        }
        public static bool operator !=(KreditCard op1, KreditCard op2)
        {
            if ((op1.CVC != op2.CVC))
                return true;
            else
                return false;
        }
        public static bool operator <(KreditCard op1, KreditCard op2)
        {
            if ((op1.money < op2.money))
                return true;
            else
                return false;
        }

        public static bool operator >(KreditCard op1, KreditCard op2)
        {
            if ((op1.money > op2.money))
                return true;
            else
                return false;
        }

        public int MoneyinCard
        {
            get { return money; }

            set { money = value; }
        }

        public int NameCard
        {
            get { return numbercard; }

            set { numbercard = value; }
        }
        public int CCVVCC
        {
            get { return CVC; }

            set { CVC = value; }
        }
        public String NamePerson
        {
            get { return Name; }

            set { Name = value; }
        }
        public string Endcard
        {
            get { return timeofend; }

            set { timeofend = value; }
        }
        public KreditCard()
        {
            Random r = new Random();
            numbercard = r.Next(10000000, 99999999);
            Name = "None";
            CVC = r.Next(100, 999);
            timeofend = "None";
            money = 0;
        }
        public KreditCard(int numbercard, string Name, int CVC, string timeofend,int money)
        {
            this.numbercard = numbercard;
            this.Name = Name;
            this.CVC = CVC;
            this.timeofend = timeofend;
            this.money = money;

        }
        public override string ToString()
        {
            return $"Card:{numbercard}\nName:{Name}\nCVC:{CVC}\nEnd card:{timeofend}\nMoney:{money}$";
        }

    }
}

