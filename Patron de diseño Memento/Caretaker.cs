using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_de_diseño_Memento
{
    internal class Caretaker
    {
        private List<IMemento> _mementos = new List<IMemento>();

        private Originator _originator = null;

        public Caretaker(Originator originator)
        {
            this._originator = originator;
        }

        public void Respaldo()
        {
            Console.WriteLine("\nCaretaker: Guardando en estado del Originator");
            this._mementos.Add(this._originator.Guardar());
        }

        public void Deshacer()
        {
            if (this._mementos.Count == 0)
            {
                return;
            }

            var memento = this._mementos.Last();
            this._mementos.Remove(memento);

            Console.WriteLine("Caretaker: Restaurando anterior estado: " + memento.GetName());

            try
            {
                this._originator.Restaurar(memento);
            }
            catch (Exception)
            {
                this.Deshacer();
            }
        }

        public void MostrarHistorial()
        {
            Console.WriteLine("Caretaker: Historial de mementos:");

            foreach (var memento in this._mementos)
            {
                Console.WriteLine(memento.GetName());
            }
        }
    }
}
