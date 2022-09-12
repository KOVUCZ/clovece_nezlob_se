using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clovece_nezlob_se
{
    internal class Class1
    {
    }

    public class Dice
    {
        private Random random;
        public int Value { get; set; }  

        public Dice()
        {
            random = new Random();
            Throw();
        }

        public void Throw()
        {
            Value = random.Next(1, 7);
        }
    }
}
