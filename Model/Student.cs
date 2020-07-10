using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public string Studbilet { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
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
        public DateTime BirthDate { get; set; }
        private Group group = null;
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
    }
}
