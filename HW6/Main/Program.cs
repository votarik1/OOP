using System;
using Bank;
using Geometry;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {

            BankAccount MyAccount = new BankAccount(AccountTypes.Super_Mega_Premium_Gold);
            BankAccount AlsoMyAccount = MyAccount;
            BankAccount NotMyAccount = new BankAccount(1000, AccountTypes.Standart);
            Console.WriteLine(MyAccount==AlsoMyAccount);
            Console.WriteLine(MyAccount!=NotMyAccount);
            Console.WriteLine(MyAccount.Equals(null));
            Color black = new Color(0, "чёрный");
            Color white = new Color(1, "белый");
            Point myPoint = new Point(black, 0, 0);
            Circle myCircle = new Circle(black, 10, 10, 5);
            myCircle.Paint(white);
            Rectangle myRectangle = new Rectangle(black, -10, -10, 5, 5);
            myRectangle.MoveTo(6, -6);
            try
            {
                Circle ErrorCircle = new Circle(black, -10, -10, -1);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Figure[] arrayOfFigures = new Figure[] { myPoint, myCircle, myRectangle };
            foreach (var item in arrayOfFigures)
            {
                item.DisplayInformation();
            }
        }
    }
}
