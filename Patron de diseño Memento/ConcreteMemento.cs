using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_de_diseño_Memento
{
    internal class ConcreteMemento : IMemento
    {
        private string _estado;

        private DateTime _fecha;

        public ConcreteMemento(string state)
        {
            this._estado = state;
            this._fecha = DateTime.Now;
        }

        public string GetEstado()
        {
            return this._estado;
        }

        public string GetName()
        {
            return $"{this._fecha} / ({this._estado.Substring(0, 9)})...";
        }

        public DateTime GetFecha()
        {
            return this._fecha;
        }
    }
}
