using System;
using System.Collections.Generic;
using System.Text;
using Domain.BasicComponents;
using Domain.BasicComponents.Boards;
using Domain.BasicComponents.PinController;
using Domain.BasicComponents.Pins;

namespace Domain {

    /// <summary>
    /// Defines the factory for creating all logic boards.
    /// </summary>
    public class LogicBoardFactory {
        
        /// <summary>
        /// Creates a specific logic board.
        /// </summary>
        /// <param name="logicBoard">Defines the logic board to create.</param>
        /// <returns></returns>
        public ILogicBoard GetLogicBoard(LogicBoard logicBoard, IPinController controller) {
            return logicBoard switch {
                LogicBoard.RaspberryPi2 => GetRaspberryPi2(controller),
                _ => throw new NotImplementedException(logicBoard.ToString())
            };
        }

        /// <summary>
        /// Creates a Raspberry PI 2 logic board.
        /// </summary>
        /// <param name="controller">Defines the controller for this board.</param>
        /// <returns></returns>
        private static RaspberryPi2 GetRaspberryPi2(IPinController controller) {

            // Using the source:
            // https://darenmay.com/blog/net-core-and-gpio-on-the-raspberry-pi---leds-and-gpio/

            var pins = new IPin[] {
                new StaticPin(1, "3.3V PWR"),
                new DigitalPin(3, "GPIO 2"), 
                new DigitalPin(5, "GPIO 3"), 
                new DigitalPin(7, "GPIO 4"), 
                new StaticPin(9, "GND"), 
                new DigitalPin(11, "GPIO 17"), 
                new DigitalPin(13, "GPIO 27"), 
                new DigitalPin(15, "GPIO 22"), 
                new StaticPin(17, "3.3V PWR"), 
                new DigitalPin(19, "GPIO 10"), 
                new DigitalPin(21, "GPIO 9"), 
                new DigitalPin(23, "GPIO 11"), 
                new StaticPin(25, "GND"), 
                new StaticPin(27, "RESERVED"), 
                new DigitalPin(29, "GPIO 5"), 
                new DigitalPin(31, "GPIO 6"), 
                new DigitalPin(33, "GPIO 13"), 
                new DigitalPin(35, "GPIO 19"), 
                new DigitalPin(37, "GPIO 26"), 
                new StaticPin(39, "GND"), 
                
                new StaticPin(2, "5V PWR"),
                new StaticPin(4, "5V PWR"), 
                new StaticPin(6, "GND"), 
                new StaticPin(8, "UART0 TX"), 
                new StaticPin(10, "UART0 RX"), 
                new DigitalPin(12, "GPIO 18"), 
                new StaticPin(14, "GND"), 
                new DigitalPin(16, "GPIO 23"), 
                new DigitalPin(18, "GPIO 24"), 
                new StaticPin(20, "GND"), 
                new DigitalPin(22, "GPIO 25"), 
                new DigitalPin(24, "GPIO 8"), 
                new DigitalPin(26, "GPIO 7"), 
                new StaticPin(28, "RESERVED"), 
                new StaticPin(30, "GND"), 
                new DigitalPin(32, "GPIO 12"), 
                new StaticPin(34, "GND"), 
                new DigitalPin(36, "GPIO 16"), 
                new DigitalPin(38, "GPIO 20"), 
                new DigitalPin(40, "GPIO 21")
            };

            var board = new RaspberryPi2("RaspberryPi", pins, controller);
            return board;
        }


    }
}
