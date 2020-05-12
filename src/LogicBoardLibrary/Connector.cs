using System;
using System.Collections.Generic;
using System.Text;
using Domain.BasicComponents;

namespace LogicBoardLibrary {

    /// <summary>
    /// Initial demonstration of combining the domain logic into practice.
    /// </summary>
    public class Connector {

        public void Test() {

            var logicBoardFactory = new Domain.LogicBoardFactory();
            var pinControllerFactory = new PinControllerFactory();
            
            var pinController = pinControllerFactory.GetPinController(LogicBoard.RaspberryPi2);
            var logicBoard = logicBoardFactory.GetLogicBoard(LogicBoard.RaspberryPi2, pinController);


        }

    }
}
