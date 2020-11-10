using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorExample.Interfaces
{
    // The Mediator interface declares a method used by components to notify the
    // mediator about various events. The Mediator may react to these events and
    // pass the execution to other components.
    interface IMediator
    {
        void Notify(object sender, string ev);
    }
}
