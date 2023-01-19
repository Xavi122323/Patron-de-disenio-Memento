using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_de_diseño_Memento
{
    internal class Originator
    {
        private string _estado;

        public Originator(string state)
        {
            this._estado = state;
            Console.WriteLine("Originator: Estado inicial: " + state);
        }

        public void Accion()
        {
            Console.WriteLine("Originator: Realizando operaciones.");
            this._estado = this.GenerarCadenaAleatoria(30);
            Console.WriteLine($"Originator: Estado cambiado a: {_estado}");
        }

        private string GenerarCadenaAleatoria(int length = 10)
        {
            string allowedSymbols = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string result = string.Empty;

            while (length > 0)
            {
                result += allowedSymbols[new Random().Next(0, allowedSymbols.Length)];

                Thread.Sleep(12);

                length--;
            }

            return result;
        }

        public IMemento Guardar()
        {
            return new ConcreteMemento(this._estado);
        }

        public void Restaurar(IMemento memento)
        {
            if (!(memento is ConcreteMemento))
            {
                throw new Exception("No se encuentra el estado anterior " + memento.ToString());
            }

            this._estado = memento.GetEstado();
            Console.Write($"Originator: Estado cambiado a: {_estado}");
        }
    }
}
