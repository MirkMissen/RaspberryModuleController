using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Domain.PinController.Fakes.Components;

namespace Domain.PinController.Activators {

    /// <summary>
    /// Defines a timed activator which will execute instructions based on the time.
    /// </summary>
    public class TimedActivator : IActivator {

        /// <summary>
        /// Defines the target to be activated.
        /// </summary>
        public IComponent Target { get; }

        public TimedActivator(IComponent target) {
            this.Target = target;
        }

    }
}
