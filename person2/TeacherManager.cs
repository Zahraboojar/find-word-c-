using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace person2
{
    internal class TeacherManager
    {
        private static List<Teacher> teachers;
        public TeacherManager()
        {
            if (teachers == null)
                teachers = new List<Teacher>();
        }

        public void Remove(Teacher teacher)
        {
            teachers.Remove(teacher);
        }
        public void Remove(int id)
        {
            Teacher teacher = null;

            foreach (var teachersItem in teachers)
            {
                if (teachersItem.Id == id)
                {
                    teacher = teachersItem;
                    break;
                }
            }
            teachers.Remove(teacher);
        }

        internal IReadOnlyList<Teacher> GetAll()
        {
            return teachers;
        }

        internal void Add(Teacher teacher)
        {
            teachers.Add(teacher);
        }

        internal void Edit(Teacher teacher, int index)
        {
            teachers[index] = teacher;
        }

        public override bool Equals(object? obj)
        {
            Teacher teacher = obj as Teacher;

            foreach (var teachersItem in teachers)
            {
                if (teacher.National_code == teachersItem.National_code &&
                    teacher.PhoneNumber == teachersItem.PhoneNumber)
                    return true;
            }
            return false;
        }
        public int LastIndex()
        {
            return teachers.Count - 1;
        }
    }
}
