using System.Collections.Generic;
using Domain.BasicComponents.PinController;
using Domain.BasicComponents.Pins;

namespace Domain.BasicComponents.Boards {

    /// <summary>
    /// Defines the RaspberryPi2 logic board.
    /// </summary>
    public class RaspberryPi2 : ILogicBoard {

        /// <summary>
        /// Defines the controller of pins.
        /// </summary>
        public IPinController PinController { get; }

        /// <summary>
        /// Defines the name of the board.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Defines the pins available on this board.
        /// </summary>
        public IEnumerable<IPin> Pins { get; }
        
        /// <summary>
        /// Creates a new logic board.
        /// </summary>
        public RaspberryPi2(string name, IEnumerable<IPin> pins, IPinController controller) {
            this.Name = name;
            this.Pins = pins;
            this.PinController = controller;
        }
        
    }
}
