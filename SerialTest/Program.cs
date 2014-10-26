using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialTest
{
    class Program
    {
        private static SerialPort _serialPort2;
        static void Main(string[] args)
        {
            _serialPort2 = new SerialPort("COM21", 9600, Parity.None, 8, StopBits.One);
            _serialPort2.Open();

            while (!Console.KeyAvailable)
            {
                byte[] buffer = new byte[4096];
                int kacsa = _serialPort2.BaseStream.Read(buffer, 0, 100);

                string data = Encoding.ASCII.GetString(buffer, 0, kacsa);

                Console.WriteLine(data);
            }

            if (_serialPort2.IsOpen)
                _serialPort2.Close();

            _serialPort2.Dispose();

            _serialPort2 = null;          
        }

        

        

    }
}
