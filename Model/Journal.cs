using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Students.Model
{
    public class Journal
    {
        public void AddGroup(Group group)
        {
            if (!Groups.Contains(group))
            {
                Groups.Add(group);
            }
        }
        public void RemoveGroup(Group group)
        {
            if (Groups.Contains(group))
            {
                foreach (var student in group.Students)
                    student.Group = null;
                Groups.Remove(group);
            }
        }

        public Journal()
        {
            Students = new List<Student>();
            Groups = new List<Group>();
        }
        [XmlIgnore]
        public List<Student> Students { get; }

        public void AddStudent(Student student)
        {
            if (!Students.Contains(student))
            {
                Students.Add(student);
            }
        }
        public void RemoveStudent(Student student)
        {
            if (Students.Contains(student))
            {
                if (student.Group != null)
                    student.Group.Students.Remove(student);
                Students.Remove(student);
            }
        }

        public Student MoveToBudget(Student student)
        {
            if (!(student is StudentBudget))
            {
                int index = Students.IndexOf(student);
                Students[index] = new StudentBudget(student);
                return Students[index];
            }
            return student;
        }

        public Student MoveToCommercial(Student student)
        {
            if (!(student is StudentCommercial))
            {
                int index = Students.IndexOf(student);
                Students[index] = new StudentCommercial(student);
                return Students[index];
            }
            return student;
        }

        public List<Group> Groups { get; set; }

    }
}
