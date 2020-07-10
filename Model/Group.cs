using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml.Serialization;

namespace Students.Model
{
    public class Group
    {
        public Group()
        {
            Year = 1;
            EducationForm = EducationForms[0];
            Name = "";
            Students = new List<Student>();
        }

        public Group(int year, string educationForm, string name)
        {
            Year = year;
            EducationForm = educationForm;
            Name = name;
            Students = new List<Student>();
        }

        public int Year { get; set; }
        public string EducationForm { get; set; }
        public static readonly string[] EducationForms =
            new[] { "Очная", "Заочная", "Очно-заочная" };

        public string Name { get; set; }

        [XmlIgnore]
        public List<Student> Students { get; set; }

        public int StudentsCount { get => Students.Count; }

        public override string ToString()
        {
            return $"{Year}к {Name} ({EducationForm})";
        }

    }
}
