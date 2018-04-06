using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz {
    public class Third {
        private Dictionary<Func<int, bool>, Func<string>> items =
            new Dictionary<Func<int, bool>, Func<string>> {
                    { value => value % 3 == 0, () => "fizz" },
                    { value => value % 5 == 0, () => "buzz" },
                };
        public string Get(int value) {
            var result = items
                            .Where(_ => _.Key(value) == true)
                            .Select(_ => _.Value())
                            .ToArray();
            return result.Length == 0 ? value.ToString() : string.Join("", result);
        }
    }
}