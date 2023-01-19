using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_de_diseño_Memento
{
    public interface IMemento
    {
        string GetName();

        string GetEstado();

        DateTime GetFecha();
    }
}
