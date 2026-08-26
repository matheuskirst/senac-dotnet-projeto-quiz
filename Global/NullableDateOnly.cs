using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacQuizApp.Global
{
    public class NullableDateOnly
    {
        public static DateOnly? ToNullableDateOnly(DateTime? input)
        {
            if (input == null) return null;
            return DateOnly.FromDateTime(input.Value);
        }
    }
}
