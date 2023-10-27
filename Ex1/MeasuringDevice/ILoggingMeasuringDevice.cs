﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MeasuringDevice
{
    // TODO: Implement the ILoggingMeasuringDevice interface.
    public interface ILoggingMeasuringDevice : IMeasuringDevice
    {
        /// <summary> 
        /// Returns the file name of the logging file for the device. 
        /// </summary> 
        /// <returns>The file name for the logging file.</returns> 
        string GetLoggingFile();
    }
}
