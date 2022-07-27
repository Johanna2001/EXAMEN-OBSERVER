using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMEN_OBSERVER
{
    class Notificacion
    {
        private readonly List<IObserver<ClienteNegocio>> observers;
        public List<ClienteNegocio> notificacion { get; set; }

        public Notificacion()
        {
            observers = new();
            notificacion = new();
        }
        public void SoporteTecnico(ClienteNegocio nott)
        {
            notificacion.Add(nott);

            foreach (var observer in observers)
            {
                observer.OnNext(nott);
            }
        }
        public void CerrarAplicacion()
        {
            foreach (var observer in observers)
            {
                observer.OnCompleted();
            }
            observers.Clear();
        }
    }
}

