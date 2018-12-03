using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcmeLogger
{
    public class Class1
    {
        public void Log(string message)
        {
            if (message == null)
            {
                Debug.WriteLine("Message was null");
            }
            else
            {
                Debug.WriteLine(message);
            }            
        }
    }
}
