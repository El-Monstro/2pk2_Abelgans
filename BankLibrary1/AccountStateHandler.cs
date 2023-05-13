using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibrary1
{
    public delegate void AccountStateHandler(object sender, AccountEventArgs e);
    public class AccountEventArgs
    {
        // создайте автосвойство сообщения (Message)
        // определите автосвойство суммы (Sum), на которую изменился счет,
        // причем блок set сделайте приватным, для того чтобы внешний код не
        // мог менять данную сумму.

        // определите конструктор класса, инициирующий Message и Sum
        private string v;
        private decimal sum;

        public AccountEventArgs(string v, decimal sum)
        {
            this.v = v;
            this.sum = sum;
        }
    }
}
