using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Device.Gpio;
using System.Text;
using Domain.BasicComponents.PinController;
using Domain.BasicComponents.Pins;

namespace LogicBoardLibrary.PinControllers {

    /// <summary>
    /// Defines a controller for the Raspberry PI 2.
    /// </summary>
    internal class RaspberryPi2PinController : IPinController {

        /// <summary>
        /// Defines the controller of the Raspberry PI.
        /// </summary>
        readonly GpioController _controller = new GpioController();
        
        /// <summary>
        /// Sets the given Pin HIGH.
        /// </summary>
        /// <param name="pin">The Pin to set HIGH</param>
        public void SetHigh(DigitalPin pin) {
            this._controller.Write(pin.Number, PinValue.High);
        }
        
        /// <summary>
        /// Sets the given Pin LOW.
        /// </summary>
        /// <param name="pin">The Pin to set LOW</param>
        public void SetLow(DigitalPin pin) {
            this._controller.Write(pin.Number, PinValue.Low);
        }

        /// <summary>
        /// Defines the mode of the given Pin
        /// </summary>
        /// <param name="pin">The Pin to alter.</param>
        /// <param name="pinMode">The specific mode for the Pin.</param>
        public void SetPinMode(DigitalPin pin, Domain.PinController.PinMode pinMode) {
            this._controller.SetPinMode(pin.Number, this.AdaptPinMode(pinMode));
        }

        /// <summary>
        /// Adapts domain PinMode to controller PinMode.
        /// </summary>
        /// <param name="pinMode"></param>
        /// <returns></returns>
        private PinMode AdaptPinMode(Domain.PinController.PinMode pinMode) {
            return pinMode switch {
                Domain.PinController.PinMode.Input => PinMode.Input,
                Domain.PinController.PinMode.Output => PinMode.Output,
                _ => throw new NotFiniteNumberException(pinMode.ToString())
            };
        }
    }
}
