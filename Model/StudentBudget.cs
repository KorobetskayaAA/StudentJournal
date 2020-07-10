using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Students.Model
{
    public class StudentBudget : Student
    {
        public StudentBudget() : base()
        {

        }
        public StudentBudget(Student student) : base(student)
        {
            if (student is StudentBudget)
            {
                // нет данных для копирования
            }
        }

        // TO DO возможность редактировать величину стипендии

        /// <summary>
        /// Базовая стипендия
        /// </summary>
        public const decimal BaseStipendiyaSum = 1770m;

        /// <summary>
        /// Повышенная стипендия
        /// </summary>
        public const decimal HigherStipendiyaSum = 2375m;

        /// <summary>
        /// Величина стипендии, получаемой студентом. Зависит от его оценок за последнюю сессию
        /// </summary>
        public decimal Stipend
        {
            get
            {
                bool isHigher = true;
                bool isBase = true;
                int semestr = LastSemestr;
                foreach (Grade gr in Grades)
                {
                    if (gr.Semestr != semestr)
                        continue;
                    if (gr.Value != 5)
                        isHigher = false;
                    if (gr.Value < 4)
                        isBase = false;
                }
                if (isHigher)
                    return HigherStipendiyaSum;
                if (isBase)
                    return BaseStipendiyaSum;
                return 0;
            }
        }
    }
}