using System;
using System.Collections.Generic;
using System.Text;
using Domain.BasicComponents;
using Domain.BasicComponents.Boards;
using Domain.PinController;
using Domain.PinController.Fakes;
using Domain.PinController.Fakes.Shields;
using NUnit.Framework;

namespace ConfiguratorUnitTests.RaspberryPI2 {

    [TestFixture]
    class RaspberryRelayShield {

        [Test]
        public void TestShield() {

            var logicBoardFactory = new Domain.LogicBoardFactory();
            var pinController = new FakePinController();
            var raspberryPi2 = logicBoardFactory.GetLogicBoard(LogicBoard.RaspberryPi2, pinController);
            var relayShield = new Fake4RelayShieldRaspberryPi((RaspberryPi2) raspberryPi2);
            
            Assert.IsTrue(!relayShield.Relay1.Active);
            Assert.IsTrue(!relayShield.Relay2.Active);
            Assert.IsTrue(!relayShield.Relay3.Active);
            Assert.IsTrue(!relayShield.Relay4.Active);

            relayShield.Relay1.Activate();

            Assert.IsTrue(relayShield.Relay1.Active);
            Assert.IsTrue(!relayShield.Relay2.Active);
            Assert.IsTrue(!relayShield.Relay3.Active);
            Assert.IsTrue(!relayShield.Relay4.Active);
            
            relayShield.Relay2.Activate();

            Assert.IsTrue(relayShield.Relay1.Active);
            Assert.IsTrue(relayShield.Relay2.Active);
            Assert.IsTrue(!relayShield.Relay3.Active);
            Assert.IsTrue(!relayShield.Relay4.Active);
            
            relayShield.Relay3.Activate();

            Assert.IsTrue(relayShield.Relay1.Active);
            Assert.IsTrue(relayShield.Relay2.Active);
            Assert.IsTrue(relayShield.Relay3.Active);
            Assert.IsTrue(!relayShield.Relay4.Active);
            
            relayShield.Relay4.Activate();

            Assert.IsTrue(relayShield.Relay1.Active);
            Assert.IsTrue(relayShield.Relay2.Active);
            Assert.IsTrue(relayShield.Relay3.Active);
            Assert.IsTrue(relayShield.Relay4.Active);

            relayShield.Relay1.Deactivate();

            Assert.IsTrue(!relayShield.Relay1.Active);
            Assert.IsTrue(relayShield.Relay2.Active);
            Assert.IsTrue(relayShield.Relay3.Active);
            Assert.IsTrue(relayShield.Relay4.Active);
            
            relayShield.Relay2.Deactivate();

            Assert.IsTrue(!relayShield.Relay1.Active);
            Assert.IsTrue(!relayShield.Relay2.Active);
            Assert.IsTrue(relayShield.Relay3.Active);
            Assert.IsTrue(relayShield.Relay4.Active);
            
            relayShield.Relay3.Deactivate();

            Assert.IsTrue(!relayShield.Relay1.Active);
            Assert.IsTrue(!relayShield.Relay2.Active);
            Assert.IsTrue(!relayShield.Relay3.Active);
            Assert.IsTrue(relayShield.Relay4.Active);
            
            relayShield.Relay4.Deactivate();

            Assert.IsTrue(!relayShield.Relay1.Active);
            Assert.IsTrue(!relayShield.Relay2.Active);
            Assert.IsTrue(!relayShield.Relay3.Active);
            Assert.IsTrue(!relayShield.Relay4.Active);
        }

        [Test]
        public void TurnOnAndOff() {
            
            var logicBoardFactory = new Domain.LogicBoardFactory();
            var pinController = new FakePinController();
            var raspberryPi2 = logicBoardFactory.GetLogicBoard(LogicBoard.RaspberryPi2, pinController);
            var relayShield = new Fake4RelayShieldRaspberryPi((RaspberryPi2) raspberryPi2);

            for (int i = 0; i < 100; i++) {
                if (i % 2 == 0) {

                    relayShield.Relay1.Activate();
                    Assert.IsTrue(relayShield.Relay1.Active);
                }  else {
                    relayShield.Relay1.Deactivate();
                    Assert.IsTrue(!relayShield.Relay1.Active);
                }
            }
        }

    }
}
