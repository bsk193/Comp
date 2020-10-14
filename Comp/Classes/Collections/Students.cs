using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp
{
    public class Students : Collection<Student>
    {
        // métodos
        public void Adicionar(Student student)
        {
            base.Add(student);
        }
        public void Inserir(int idx, Student student)
        {
            base.Insert(idx, student);
        }
        public void Retirar(Student student)
        {
            base.Remove(student);
        }
        public bool Contem(Student student)
        {
            return base.Contains(student);
        }
        public bool validateNumber(Int64 StudentNumber)
        {
            foreach (Student st in this)
            {
                if (st.StudentNumber == StudentNumber)
                    return false;
            }
            return true;
        }

        public bool validateData(String Subject, Int32 Quarter, Int32 Student)
        {
            foreach (Student s in Program.students)
            {
                if (s.StudentNumber == Student)
                {
                    foreach (Hour h in s.HoursToCompensate)
                    {
                        if (h.Initials.ToString() == Subject && h.Quarter == Quarter)
                        {
                            return false;

                        }
                        else
                        {
                            return true;
                        }
                    }
                }
                else
                    return true;
            }
            return false;
        }

        public Student getByNumber(Int64 Number)
        {
            foreach(Student s in this)
            {
                if (s.StudentNumber == Number)
                    return s;
            }
            return null;
        }

        public String[] getClasses()
        {
            String[] classes = {};
            Int32 idx = 0;
            foreach(Student s in Program.students)
            {
                if (classes.Contains(s.ClassCode))
                {
                    continue;
                }
                else
                {
                    classes[idx] = s.ClassCode;
                    idx++;
                }
            }
            return classes;
        }

        public Student[] getStudsbyClass(String Class)
        {
            Student[] studs = { };
            Int32 idx = 0;
            foreach (Student s in Program.students)
            {
                if (studs.Contains(s))
                {
                    continue;
                }
                else
                {
                    if (s.ClassCode == Class)
                    {
                        studs[idx] = s;
                        idx++;
                    }
                }
            }
            return studs;
        }

    }
}
