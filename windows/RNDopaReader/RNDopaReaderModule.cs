using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Dopa.Reader.RNDopaReader
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNDopaReaderModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNDopaReaderModule"/>.
        /// </summary>
        internal RNDopaReaderModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNDopaReader";
            }
        }
    }
}
