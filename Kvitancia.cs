using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1
{
    class Kvitancia
    {
        public int Number;
        public string Date;
        public double Symma;
        public void SetNumber(int Number)
        {
            this.Number = Number;
        }
        public void SetDate(string Date)
        {
            this.Date = Date;
        }
        public void SetSymma(double Symma)
        {
            this.Symma = Symma;
        }
        public int GetNumber()
        {
            return this.Number;
        }
        public string GetDate()
        {
            return this.Date;
        }
        public double GetSymma()
        {
            return this.Symma;
        }
        public Kvitancia(int Number, string Date, double Symma)
        {
            this.Number = Number;
            this.Date = Date;
            this.Symma = Symma;
        }
        public Kvitancia()
        { }
    }
}
