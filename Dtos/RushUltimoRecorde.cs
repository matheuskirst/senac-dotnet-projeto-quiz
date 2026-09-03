using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacQuizApp.Dtos
{
    public class RushUltimoRecorde
    {
        public int Streak { get; set; }
        public TimeSpan Tempo { get; set; }
        public DateTimeOffset DataRecorde { get; set; }
    }
}
