using Domain.BasicComponents.PinController;
using Domain.BasicComponents.Pins;

namespace Domain.PinController.Fakes {

    /// <summary>
    /// Defines a fake Pin controller for testing.
    /// </summary>
    public class FakePinController : IPinController{

        public void SetHigh(DigitalPin pin) {
            pin.Active = true;
        }

        public void SetLow(DigitalPin pin) {
            pin.Active = false;
        }

        public void SetPinMode(DigitalPin pin, PinMode pinMode) {
            // nothing in fake atm.
        }

        public void OpenPin(DigitalPin pin, PinMode pinMode) {
            // nothing in fake atm.
        }

        public void ClosePin(DigitalPin pin) {
            // nothing in fake atm.
        }
    }
}
