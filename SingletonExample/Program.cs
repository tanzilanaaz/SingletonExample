using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonExample
{
    class Program
    {
        static void Main(string[] args)
        {
            logging logger1 = logging.Instance;
            logger1.LogMessage("This message is from logger1");

            logging logger2 = logging.Instance;
            logger2.LogMessage("This meesage is from logger2");

            Console.WriteLine($"logger1 and logger2 refer to the same instance. Hence: {logger1 == logger2}");
        }
    }
}
