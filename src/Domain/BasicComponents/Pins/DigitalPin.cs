using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.BasicComponents.Pins {

    /// <summary>
    /// Defines Digital Pin which can turn on or off.
    /// </summary>
    public class DigitalPin  : IPin {

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

        /// <summary>
        /// Defines if this Pin is active.
        /// </summary>
        public bool Active { get; set; }

        /// <summary>
        /// Creates a new Pin.
        /// </summary>
        /// <param name="number">Defines the specific Pin number</param>
        /// <param name="name">Defines the name of the Pin</param>
        public DigitalPin(int number, string name) {
            this.Number = number;
            this.Name = name;
            this.Description = string.Empty;
        }
        
        /// <summary>
        /// Creates a new Pin.
        /// </summary>
        /// <param name="number">Defines the specific Pin number</param>
        /// <param name="name">Defines the name of the Pin</param>
        /// <param name="description"></param>
        public DigitalPin(int number, string name, string description) {
            this.Number = number;
            this.Name = name;
            this.Description = description;
        }

    }
}
