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

        [XmlAttribute]
        public int Year { get; set; }
        [XmlAttribute]
        public string EducationForm { get; set; }
        public static readonly string[] EducationForms =
            new[] { "очная", "заочная", "очно-заочная" };

        [XmlAttribute]
        public string Name { get; set; }
        public List<Student> Students { get; set; }

        public int StudentsCount { get => Students.Count; }
        public List<Student> Rating
        {
            get
            {
                return Students.OrderByDescending(student => student.AverageGrade).ToList();
            }
        }
        public List<Student> Alphabetical
        {
            get
            {
                return Students.OrderBy(student => student.FIO).ToList();
            }
        }

        public override string ToString()
        {
            return $"{Year}к {Name} ({EducationForm})";
        }

    }
}
