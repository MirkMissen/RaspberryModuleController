using System;
using System.Collections.Generic;
using System.Text;
using Domain.PinController.Fakes.Components;

namespace Domain.PinController.Activators {

    /// <summary>
    /// Defines an activator which can execute Commands on Components.
    /// </summary>
    public interface IActivator {

        /// <summary>
        /// Defines the component to be controlled.
        /// </summary>
        IComponent Target { get; }


    }
}
