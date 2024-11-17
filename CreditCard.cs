using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOperators
{
    public class CreditCard
    {
        public int CVCode { get; set; }
        public string CardNumber { get; set; }
        public int Money {  get; set; }

        public CreditCard(string cardNumber, int cvcode, int money)
        {
            CVCode = cvcode;
            CardNumber = cardNumber;
            Money = money;
        }

        public void Show()
        {
            Console.WriteLine("Card number: {0}", CardNumber);
            Console.WriteLine("CVC code: {0}", CVCode);
            Console.WriteLine("Balance: {0}", Money);
        }

        public static CreditCard operator + (CreditCard left,int number)
        {
            left.Money += number;
            return left;
        }

        public static CreditCard operator - (CreditCard left, int number)
        {
            left.Money -= number;
            return left;
        }

        public static bool operator == (CreditCard left,CreditCard right)
        {
            return left.CVCode == right.CVCode;
        }

        public static bool operator !=(CreditCard left, CreditCard right)
        {
            return left.CVCode != right.CVCode;
        }

        public static bool operator > (CreditCard left, CreditCard right)
        {
            return left.Money > right.Money;
        }

        public static bool operator < (CreditCard left, CreditCard right)
        {
            return left.Money < right.Money;
        }

        public override bool Equals(object? obj)
        {
            if (obj is CreditCard other)
            {
                return this == other;
            }
            return false;
        }
    }
}
