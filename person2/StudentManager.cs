using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace person2
{
    internal class StudentManager
    {
        private static List<Student> studentList;

        public StudentManager()
        {
            if (studentList == null)
                studentList = new List<Student>();
        }

        public void Remove(Student student)
        {
            studentList.Remove(student);
        }
        public void Remove(int id)
        {
            Student student = null;

            foreach (var personsItem in studentList)
            {
                if (personsItem.Id == id)
                {
                    student = personsItem;
                    break;
                }
            }
            studentList.Remove(student);
        }

        internal IReadOnlyList<Student> GetAll()
        {
            return studentList;
        }

        internal void Add(Student student)
        {
             studentList.Add(student);
        }

        internal void Edit(Student student, int index)
        {
            studentList[index] = student;
        }

        public bool IsDuplicateStudentCode(string studentCode)
        {
            foreach (var student in studentList)
            {
                if (student.StudentCode == studentCode)
                    return true;
            }
            return false;
        }
        public bool IsDuplicateNationalCode(string NationalCode)
        {
            foreach (var student in studentList)
            {
                if (student.National_code == NationalCode)
                    return true;
            }
            return false;
        }

        public int LastIndex()
        {
            return studentList.Count - 1;
        }
    }
}
