using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class DviMonitor
    {
        private byte[] _inputStream;
        public void SetInput(DviStream inputStream)
        {
            _inputStream = inputStream.GetData();
        }

    }
}
