using System;
using System.Collections.Generic;
using System.Text;
using Domain.PinController.Fakes.Components;

namespace Domain.PinController.Commands {
    class ActivateCommand : IComponentCommand {

        /// <summary>
        /// Activates a given component.
        /// </summary>
        /// <param name="component">Defines the component to be activated.</param>
        public void Execute(IComponent component) {
            component.Activate();
        }
    }
}
