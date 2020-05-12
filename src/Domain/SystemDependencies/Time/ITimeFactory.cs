using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.SystemDependencies.Time {
    
    /// <summary>
    /// Defines the contract for a time factory.
    /// </summary>
    public interface ITimeFactory {

        /// <summary>
        /// Retrieves the current DateTime.
        /// </summary>
        /// <returns></returns>
        DateTime GetCurrentTime();
    }
}
