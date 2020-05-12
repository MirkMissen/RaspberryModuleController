using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.PinController.Fakes.Components {

    /// <summary>
    /// Defines a simple component on a shield.
    /// </summary>
    public interface IComponent {

        /// <summary>
        /// Defines if the component is turned on.
        /// </summary>
        bool Active { get; }

        /// <summary>
        /// Activates this component.
        /// </summary>
        void Activate();

        /// <summary>
        /// Deactivates this component.
        /// </summary>
        void Deactivate();

    }
}
