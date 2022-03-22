using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Calculator
{
    public interface IDiagnostics
    {
        public string ramUsage();
        public string cpuUsage();
        public string memoryUsage();      

    }
}
