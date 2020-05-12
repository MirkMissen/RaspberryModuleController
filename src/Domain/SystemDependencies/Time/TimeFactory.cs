using System;

namespace Domain.SystemDependencies.Time {

    /// <summary>
    /// Defines a factory for defining the time.
    /// </summary>
    public class TimeFactory : ITimeFactory {
        
        /// <summary>
        /// Retrieves the current DateTime.
        /// </summary>
        /// <returns></returns>
        public DateTime GetCurrentTime() => DateTime.Now;
    }
}
