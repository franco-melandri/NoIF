using System;
using System.Text;

namespace FizzBuzz {
    public class Second {
        public string Get(int value) {
            var result = new StringBuilder();
            if (value % 3 == 0)
                result.Append ("fizz");
            if (value % 5 == 0 )
                result.Append ("buzz");
            return result.Length == 0 ? value.ToString() : result.ToString();
        }
    }
}