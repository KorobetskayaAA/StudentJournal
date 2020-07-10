using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Students.Model
{
    public class StudentCommercial : Student
    {
        public StudentCommercial() : base()
        {
        }
        public StudentCommercial(Student student) : base(student)
        {
            if (student is StudentCommercial)
            {
                paidSum = (student as StudentCommercial).PaidSum;
            }
        }

        public const decimal SemestrCost = 70000m;

        private decimal paidSum;
        public decimal PaidSum { get { return paidSum; } }

        /// <summary>
        /// Оплатить обучение.
        /// </summary>
        /// <param name="sum">Сумма оплаты.</param>
        public void Pay(decimal sum)
        {
            paidSum += sum;
        }

        // TO DO возможность уменьшить оплаченную сумму

        /// <summary>
        /// Сумма долга по оплате обучения.
        /// </summary>
        public decimal PaymentDebt
        {
            get
            {
                return SemestrCost * LastSemestr - PaidSum;
            }
        }

        public override bool ShouldExpel()
        {
            return base.ShouldExpel() || (PaymentDebt > SemestrCost);
        }
    }
}