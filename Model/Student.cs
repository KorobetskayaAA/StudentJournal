using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml.Serialization;


namespace Students.Model
{
    public class Student
    {
        public Student() 
        {
            Studbilet = "00000000";
            Name = "";
            Patronymic = "";
            Surname = "";
            BirthDate = DateTime.Now.AddYears(-18);
            Group = new Group();
            grades = new List<Grade>();
        }
        /// <summary>
        /// Номер студенческого билета
        /// </summary>
        [XmlAttribute]
        public string Studbilet { get; set; }
        [XmlAttribute]
        public string Name { get; set; }
        [XmlAttribute]
        public string Patronymic { get; set; }
        [XmlAttribute]
        public string Surname { get; set; }
        public string FIO
        {
            get
            {
                string fio = Surname;
                if (Name.Length > 0)
                {
                    fio += " " + Name[0] + ".";
                }
                if (Patronymic.Length > 0)
                {
                    fio += Patronymic[0] + ".";
                }
                return fio;
            }
        }
        [XmlAttribute]
        public DateTime BirthDate { get; set; }
        private Group group = null;
        [XmlIgnore]
        public Group Group 
        { 
            get => group; 
            set
            {
                if (group != value)
                {
                    if (group != null)
                        group.Students.Remove(this);
                    if (value != null)
                        value.Students.Add(this);
                }
                group = value;
            } 
        }

        private List<Grade> grades;

        public List<Grade> Grades { get => grades; }

        public double AverageGrade
        {
            get
            {
                try
                {
                    return Grades.Select(grade => grade.Value).Average();
                }
                catch
                {
                    return 0;
                }
            }
        }

        public int Rating
        {
            get
            {
                return group.Rating.IndexOf(this) + 1;
            }
        }
    }
}
