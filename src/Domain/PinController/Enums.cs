using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.PinController {

    /// <summary>
    /// Defines modes from which pins will function.
    /// </summary>
    public enum PinMode {
        /// <summary>Input used for reading values from a Pin.</summary>
        Input,
        /// <summary>Output used for writing values to a Pin.</summary>
        Output
    }

}
