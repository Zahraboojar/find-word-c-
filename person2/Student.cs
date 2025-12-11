using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace person2
{
    public class Student : Person
    {
        public string StudentCode { get; set; }
        public Grade Grade { get; set; }
        public override string ToString()
        {
            return $"{Name} , {Family} , {National_code} , {GradeText(Grade)} , {StudentCode}";
        }

        public override string FullName()
        {
            return $"{Name} {Family} {GradeText(Grade)}";
        }

        public string GradeText(Grade grade)
        {
            switch (grade)
            {
                case Grade.Elementary_School:
                    return "ابتدایی";
                case Grade.Middel_School:
                    return "راهنمایی";
                case Grade.Diploma:
                    return "دیپلم";
                case Grade.Associate:
                    return "فوق دیپلم";
                case Grade.Bachelor:
                    return "لیسانس";
                case Grade.Master:
                    return "فوق لیسانس";
                case Grade.Doctorate:
                    return "دکترا";
                default:
                    return "نامشخص";
            }
        }

        public override bool Equals(object st)
        {
            Student student = st as Student;

            if (this.StudentCode == student.StudentCode)
                return true;
            return false;
        }
    }
}
