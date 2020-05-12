using System;
using System.Collections.Generic;
using System.Text;
using Domain.PinController.Fakes.Components;

namespace Domain.PinController.Commands {

    /// <summary>
    /// Defines a command which deactivates a given component.
    /// </summary>
    class DeactivateCommand : IComponentCommand{

        /// <summary>
        /// Deactivates the component.
        /// </summary>
        /// <param name="component">The component to be deactivated.</param>
        public void Execute(IComponent component) {
            component.Deactivate();
        }
    }
}
