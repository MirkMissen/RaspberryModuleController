using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.BasicComponents.Pins {

    /// <summary>
    /// Defines a common contract for properties which all pins must provide.
    /// </summary>
    public interface IPin {
        
        /// <summary>
        /// Defines the Pin number.
        /// </summary>
        public int Number { get; }
        
        /// <summary>
        /// Defines a short description of the Pin functionality. e.g. 5v, GND.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Defines a more detailed description of this Pin, e.g. Pin (number)19, (name)GPIO, SPIO MOSI.
        /// </summary>
        public string Description { get; }

    }
}
