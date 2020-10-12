using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp
{
    public class Compensated : Collection<HourC>
    {
        // métodos
        public void Adicionar(HourC Compensated)
        {
            base.Add(Compensated);
        }
        public void Inserir(int idx, HourC Compensated)
        {
            base.Insert(idx, Compensated);
        }
        public void Retirar(HourC Compensated)
        {
            base.Remove(Compensated);
        }
        public bool Contem(HourC Compensated)
        {
            return base.Contains(Compensated);
        }
    }
}
