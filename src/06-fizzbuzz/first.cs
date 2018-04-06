using System;

namespace FizzBuzz {
    public class First {
        public string Get(int value) {
            if (value % 3 == 0 && value % 5 == 0) {
                return "fizzbuzz";
            } else if (value % 3 == 0 ) {
                return "fizz";
            } else if (value % 5 == 0 ) {
                return "buzz";
            }
            return value.ToString();
        }
    }
}