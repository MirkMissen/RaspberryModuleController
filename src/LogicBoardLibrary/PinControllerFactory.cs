using System;
using System.Collections.Generic;
using System.Text;
using Domain.BasicComponents;
using Domain.BasicComponents.Boards;
using Domain.BasicComponents.PinController;
using Domain.BasicComponents.Pins;
using Iot.Device.Ssd13xx.Commands.Ssd1327Commands;
using LogicBoardLibrary.PinControllers;

namespace LogicBoardLibrary {
    public class PinControllerFactory {

        /// <summary>
        /// Defines the dictionary with anonymous PinController creator functions.
        /// </summary>
        private readonly Dictionary<LogicBoard, Func<IPinController>> _dictionary;

        /// <summary>
        /// Initializes a new instance of the factory.
        /// </summary>
        public PinControllerFactory() {
            this._dictionary =
                new Dictionary<LogicBoard, Func<IPinController>> {
                    {LogicBoard.RaspberryPi2, () => new RaspberryPi2PinController()}
                };
        }

        /// <summary>
        /// Retrieves a new PinController for a given board.
        /// </summary>
        /// <param name="logicBoard">The board to retrieve a Pin controller for.</param>
        /// <returns></returns>
        public IPinController GetPinController(LogicBoard logicBoard) {
            if (this._dictionary.ContainsKey(logicBoard)) {
                return this._dictionary[logicBoard].Invoke();
            }
            else {
                throw new NotImplementedException($"{nameof(PinControllerFactory)} cannot create an instance {nameof(IPinController)} for {logicBoard}");
            }
        }

    }
}
