using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEG_Marker
{
    class SerialPortMarker : IMarker
    {
        private static SerialPort _serialPort;
        public SerialPortMarker(int portNumber)
        {
            _serialPort = new SerialPort("COM"+portNumber, 9600, Parity.None, 8, StopBits.One);
            _serialPort.Open();
        }


        public void setMarker(int marker)
        {
            _serialPort.Write(marker.ToString());
        }

        ~SerialPortMarker()
        {
            if (_serialPort.IsOpen)
                _serialPort.Close();

            _serialPort.Dispose();

            _serialPort = null;
        }
    }
}
