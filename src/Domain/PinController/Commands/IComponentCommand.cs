using System;
using System.Collections.Generic;
using System.Text;
using Domain.BasicComponents.Pins;
using Domain.PinController.Fakes.Components;

namespace Domain.PinController.Commands {

    /// <summary>
    /// Defines a simple command-like interface for activating a Pin.
    /// </summary>
    public interface IComponentCommand {

        /// <summary>
        /// Executes a specific command on a component.
        /// </summary>
        /// <param name="component">Defines the component to execute upon.</param>
        void Execute(IComponent component);

    }
}
