using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.PinController.Commands {

    /// <summary>
    /// Defines a factory of commands.
    /// </summary>
    public class CommandFactory {

        /// <summary>
        /// Retrieves a command for activating a component.
        /// </summary>
        /// <returns></returns>
        public IComponentCommand GetActivateCommand() => new ActivateCommand();

        /// <summary>
        /// Retrieves a command for deactivating a component.
        /// </summary>
        /// <returns></returns>
        public IComponentCommand GetDeactivateCommand() => new DeactivateCommand();
    }
}
