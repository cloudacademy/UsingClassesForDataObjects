using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesForDataObjects
{
    public class Student
    {
        public string Initials { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Hobby { get; set; }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("Initials: ");
            builder.Append(Initials);
            builder.Append("\n");
            builder.Append("Name: ");
            builder.Append(Name);
            builder.Append("\n");
            builder.Append("Age: ");
            builder.Append(Age);
            builder.Append("\n");
            builder.Append("Gender: ");
            builder.Append(Gender);
            builder.Append("\n");
            builder.Append("Hobby: ");
            builder.Append(Hobby);
            builder.Append("\n\n");

            return builder.ToString();
        }
    }
}
