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
    }
}
