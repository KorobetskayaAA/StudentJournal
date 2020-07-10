using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml.Serialization;


namespace Students.Model
{
    public abstract class Student
    {
        public Student() 
        {
            Studbilet = "00000000";
            Name = "";
            Patronymic = "";
            Surname = "";
            BirthDate = DateTime.Now.AddYears(-18);
            Group = null;
            grades = new List<Grade>();
        }
        public Student(Student student)
        {
            if (student != null)
            {
                Studbilet = student.Studbilet;
                Name = student.Name;
                Patronymic = student.Patronymic;
                Surname = student.Surname;
                BirthDate = student.BirthDate;
                Group = student.Group;
                grades = student.Grades;
            }
            else
            {
                throw new ArgumentNullException();
            }
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
                    if (value != null && !value.Students.Contains(this))
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
                double avg = AverageGrade;
                return group.Students.Count(student => student.AverageGrade > avg) + 1;
            }
        }

        /// <summary>
        /// Количество долгов (несданных зачетов и экзаменов)
        /// </summary>
        public int DebtsCount
        {
            get
            {
                int count = 0;
                foreach (Grade gr in grades)
                {
                    if (gr.IsDebt)
                        count++;
                }
                return count;
            }
        }

        /// <summary>
        /// Определяет номер последнего семестра, за который есть оценки
        /// </summary>
        protected int LastSemestr
        {
            get
            {
                int maxSemestr = 1;
                foreach (Grade gr in grades)
                {
                    if (gr.Semestr > maxSemestr)
                        maxSemestr = gr.Semestr;
                }
                return maxSemestr;
            }
        }

        /// <summary>
        /// Нужно ли отчислить данного студента.
        /// </summary>
        /// <returns>Возвращает true, если студент должен быть отчислен.</returns>
        public virtual bool ShouldExpel()
        {
            return DebtsCount > 5;
        }
    }
}
