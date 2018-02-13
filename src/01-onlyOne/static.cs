
using System.Collections.Generic;

namespace OnlyOne
{
    public static class Departments
    {
        public static List<string> FAYTDepartments
        {
            get
            {   
                System.Console.Error.WriteLine("GEt");       
                return new List<string>
                {
                    "Women",
                    "Men"
                };
            }
        }
    }
}