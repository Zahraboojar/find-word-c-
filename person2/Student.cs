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
                    break;
                case Grade.Middel_School:
                    return "راهنمایی";
                    break;
                case Grade.Diploma:
                    return "دیپلم";
                    break;
                case Grade.Associate:
                    return "فوق دیپلم";
                    break;
                case Grade.Bachelor:
                    return "لیسانس";
                    break;
                case Grade.Master:
                    return "فوق لیسانس";
                    break;
                case Grade.Doctorate:
                    return "دکترا";
                    break;
                default:
                    return "نامشخص";
                    break;
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
