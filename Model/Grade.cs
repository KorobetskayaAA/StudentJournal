using System.Collections.Generic;
using System.Xml.Serialization;

namespace Students.Model
{
    public enum GradeType
    {
        Экзамен, Зачет, Зачет_с_оценкой, Курсовой_проект
    }

    public class Grade
    {
        public Grade()
        {
            Dicipline = "";
            Semestr = 1;
            Type = GradeType.Экзамен;
            Name = "";
        }

        public Grade(string dicipline, int semestr,
            GradeType type, string name)
        {
            Dicipline = dicipline;
            Semestr = semestr;
            Type = type;
            Name = name;
        }
        public string Dicipline { get; set; }
        public int Semestr { get; set; }
        [XmlAttribute]
        public GradeType Type { get; set; }
        public string Name { get; set; }
        // TO DO проверить правильность имени оценки
        public static Dictionary<string, int> ExamGradation = new Dictionary<string, int>()
        {
            { "отлично", 5 },
            { "хорошо", 4 },
            { "удовлетворительно", 3 },
            { "неудовлетворительно", 2 },
            { "неявка", 0 }
        };
        public static Dictionary<string, int> ZachetGradation = new Dictionary<string, int>()
        {
            { "зачтено", 5 },
            { "не зачтено", 1 },
            { "неявка", 0 }
        };
        // альтернативное решение
        //public static int GetExamGradation(string name)
        //{
        //    switch (name)
        //    {
        //        case "отлично": return 5;
        //        case "хорошо": return 4;
        //        case "удовлетворительно": return 3;
        //        case "неудовлетворительно": return 2;
        //        case "зачтено": return 5;
        //        case "не зачтено": return 1;
        //        case "неявка": return 0;
        //        default: return 0;
        //    }
        //}
        public static string[] GetGradeNames(GradeType type)
        {
            if (type == GradeType.Зачет)
                return new List<string>(ZachetGradation.Keys).ToArray();
            return new List<string>(ExamGradation.Keys).ToArray();
        }
        public int Value 
        {
            get
            {
                if (Type == GradeType.Зачет)
                    return ZachetGradation[Name];
                return ExamGradation[Name];
            }
        }

        public bool IsDebt
        {
            get
            {
                return Value <= 2;
            }
        }
    }
}