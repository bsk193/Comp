using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp
{
    public class ToOffset : Collection<Hour>
    {
        // métodos
        public void Adicionar(Hour toOffset)
        {
            base.Add(toOffset);
        }
        public void Inserir(int idx, Hour toOffset)
        {
            base.Insert(idx, toOffset);
        }
        public void Retirar(Hour toOffset)
        {
            base.Remove(toOffset);
        }
        public bool Contem(Hour toOffset)
        {
            return base.Contains(toOffset);
        }
    }
}
