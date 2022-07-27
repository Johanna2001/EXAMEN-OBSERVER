using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMEN_OBSERVER
{
    class Dispositivos: IDisposable
        {
            private readonly List<IObserver<ClienteNegocio>> observers;
            private readonly IObserver<ClienteNegocio> observer;

            public Dispositivos(List<IObserver<ClienteNegocio>> observers, IObserver<ClienteNegocio> observer)
            {
                this.observers = observers;
                this.observer = observer;
            }
            public void Dispose()
            {
                if (observers.Contains(observer))
                {
                    observers.Remove(observer);
                }
            }
        }
    }



