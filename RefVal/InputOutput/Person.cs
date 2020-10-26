using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputOutput
{
    class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Gender PerGender { get; set; }

        public override string ToString()
        {
            //${< interpolationExpression >[,< alignment >][:< formatString >]}
            return string.Format($"{Id,-10}{Name,-10}{PerGender,-10}");
        }
    }
}
