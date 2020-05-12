using System;
using System.Collections.Generic;
using System.Text;
using Domain.BasicComponents.PinController;
using Domain.BasicComponents.Pins;

namespace Domain.BasicComponents.Boards {

    /// <summary>
    /// Defines the contract for a logic board.
    /// </summary>
    public interface ILogicBoard {

        /// <summary>
        /// Defines the instance which can control the pins.
        /// </summary>
        IPinController PinController { get; }

        /// <summary>
        /// Defines the name of the board.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Defines the pins available on this board.
        /// </summary>
        IEnumerable<IPin> Pins { get; }
        
    }
}
