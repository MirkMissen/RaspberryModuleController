using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Domain.BasicComponents.Pins;
using Domain.PinController;

namespace Domain.BasicComponents.PinController {

    /// <summary>
    /// Defines a Pin Controller which can alter the states of pins.
    /// </summary>
    public interface IPinController {

        /// <summary>
        /// Sets a specific Pin to HIGH.
        /// </summary>
        /// <param name="pin">Defines the Pin number</param>
        void SetHigh(DigitalPin pin);

        /// <summary>
        /// Sets a specific Pin to LOW
        /// </summary>
        /// <param name="pin">Defines the Pin number</param>
        void SetLow(DigitalPin pin);

        /// <summary>
        /// Defines how the Pin must function.
        /// </summary>
        /// <param name="pinMode">The Pin mode to be applied.</param>
        void SetPinMode(DigitalPin pin, PinMode pinMode);

    }
}
