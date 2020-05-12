using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain.BasicComponents.Boards;
using Domain.BasicComponents.Pins;
using Domain.PinController.Fakes.Components;

namespace Domain.PinController.Fakes.Shields {
    public class Fake4RelayShieldRaspberryPi : IEmulatedShield {

        /*
         *  Pin 2-> 5V
         *  Pin 6->GND
         *  Pin 7-> Relay 4
         *  Pin 11->Relay 3
         *  Pin 13-> Relay 2
         *  Pin 15-> Relay 1
         */
         
        public IComponent Relay1 { get; }
        public IComponent Relay2 { get; }
        public IComponent Relay3 { get; }
        public IComponent Relay4 { get; }

        public Fake4RelayShieldRaspberryPi(RaspberryPi2 raspberryPi) {

            var controller = raspberryPi.PinController;

            this.Relay1 = new VirtualRelay(controller, (DigitalPin) raspberryPi.Pins.First((x) => x.Number == 7));
            this.Relay2 = new VirtualRelay(controller, (DigitalPin) raspberryPi.Pins.First((x) => x.Number == 11));
            this.Relay3 = new VirtualRelay(controller, (DigitalPin) raspberryPi.Pins.First((x) => x.Number == 13));
            this.Relay4 = new VirtualRelay(controller, (DigitalPin) raspberryPi.Pins.First((x) => x.Number == 15));
        }

    }
}
