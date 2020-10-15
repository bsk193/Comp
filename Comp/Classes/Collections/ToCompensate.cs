using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp
{
    public class ToCompensate : Collection<Hour>
    {
        // métodos
        public void Adicionar(Hour toCompensate)
        {
            base.Add(toCompensate);
        }
        public void Inserir(int idx, Hour toCompensate)
        {
            base.Insert(idx, toCompensate);
        }
        public void Retirar(Hour toCompensate)
        {
            base.Remove(toCompensate);
        }
        public bool Contem(Hour toCompensate)
        {
            return base.Contains(toCompensate);
        
    }
}
}