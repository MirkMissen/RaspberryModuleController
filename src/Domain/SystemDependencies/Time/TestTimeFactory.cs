using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.SystemDependencies.Time {

    /// <summary>
    /// Defines a test time factory for injecting the time desired.
    /// </summary>
    class TestTimeFactory : ITimeFactory {

        /// <summary>
        /// Defines the function for retrieving 
        /// </summary>
        private readonly Func<DateTime> _getCurrentTime;

        
        /// <summary>
        /// Initializes a new TimeFactory using injected functionality.
        /// </summary>
        public TestTimeFactory(Func<DateTime> getCurrentTime) {
            this._getCurrentTime = getCurrentTime;
        }
        
        /// <summary>
        /// Retrieves the DateTime of the test function.
        /// </summary>
        /// <returns></returns>
        public DateTime GetCurrentTime() => this._getCurrentTime.Invoke();
    }
}
