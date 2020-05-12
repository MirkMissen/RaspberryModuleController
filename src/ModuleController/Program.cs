using System;
using System.Threading;
using Domain.BasicComponents;
using Domain.BasicComponents.Boards;
using Domain.PinController.Fakes.Components;
using Domain.PinController.Fakes.Shields;
using LogicBoardLibrary;

namespace ModuleController {
    class Program {
        static void Main(string[] args) {

            var logicBoardFactory = new Domain.LogicBoardFactory();
            var pinControllerFactory = new PinControllerFactory();
            
            var pinController = pinControllerFactory.GetPinController(LogicBoard.RaspberryPi2);
            var logicBoard = logicBoardFactory.GetLogicBoard(LogicBoard.RaspberryPi2, pinController);
            var relayShield = new Fake4RelayShieldRaspberryPi((RaspberryPi2) logicBoard);

            while (true) {
                ActivateAndDeactivate(relayShield.Relay1);
                ActivateAndDeactivate(relayShield.Relay2);
                ActivateAndDeactivate(relayShield.Relay3);
                ActivateAndDeactivate(relayShield.Relay4);
            }

        }

        private static void ActivateAndDeactivate(IComponent component) {
            component.Activate();
            Thread.Sleep(1000);
            component.Deactivate();
        }
    }
}
