using Domain.BasicComponents.Boards;

namespace Domain.BasicComponents.Pins {

    /// <summary>
    /// Defines a single static Pin on a <see cref="RaspberryPi2"/>
    /// </summary>
    public class StaticPin : IPin {

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
        /// Creates a new Pin.
        /// </summary>
        /// <param name="number">Defines the specific Pin number</param>
        /// <param name="name">Defines the name of the Pin</param>
        public StaticPin(int number, string name) {
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
        public StaticPin(int number, string name, string description) {
            this.Number = number;
            this.Name = name;
            this.Description = description;
        }

    }
}
