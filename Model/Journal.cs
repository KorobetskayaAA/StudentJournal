using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students.Model
{
    public class Journal
    {
        public Journal()
        {
            Students = new List<Student>();
            Groups = new List<Group>();
        }
        public List<Student> Students { get; set; }

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

        public List<Group> Groups { get; set; }
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

    }
}
