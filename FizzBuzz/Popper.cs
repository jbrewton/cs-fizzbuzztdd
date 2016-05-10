using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class Popper
    {
        public string apply(int item)
        {
            string result;
            StringBuilder sb = new StringBuilder();

            fizz(item, ref sb);
            buzz(item, ref sb);

            if (sb.Length == 0) {
                result = item.ToString();
            }
            else {
                result = sb.ToString();
            }
            return result;
        }

        private void fizz(int item, ref StringBuilder s)
        {
            if(item % 3 == 0)
            {
                s.Append("fizz");
            }
        }

        private void buzz(int item, ref StringBuilder s)
        {
            if (item % 5 == 0)
            {
                s.Append("buzz");
            }
        }

    }
}
