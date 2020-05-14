using System;
using System.Collections.Generic;
using System.Text;
using Domain.BasicComponents.PinController;
using Domain.BasicComponents.Pins;
using Domain.PinController.Fakes.Components;

namespace Domain.PinController.Fakes {

    /// <summary>
    /// Defines simple relay.
    /// </summary>
    public class VirtualRelay : IComponent {
        
        /// <summary>
        /// Defines the controller of pins.
        /// </summary>
        private readonly IPinController _controller;

        /// <summary>
        /// Defines the monitored Pin.
        /// </summary>
        public readonly DigitalPin Pin;

        /// <summary>
        /// Defines if the relay is closed.
        /// </summary>
        public bool Active => this.Pin.Active;

        /// <summary>
        /// Creates a new Virtual Relay dependent on its "connected" Pin.
        /// </summary>
        /// <param name="pinController">Defines a controller of pins.</param>
        /// <param name="pin">Defines the Pin to activate the relay.</param>
        public VirtualRelay(IPinController pinController, DigitalPin pin) {
            this.Pin = pin;
            this._controller = pinController;
            
            _controller.OpenPin(pin, PinMode.Output);
        }
        
        /// <summary>
        /// Activates this component.
        /// </summary>
        public void Activate() => this._controller.SetHigh(this.Pin);

        /// <summary>
        /// Deactivates this component.
        /// </summary>
        public void Deactivate() => this._controller.SetLow(this.Pin);

    }
}
