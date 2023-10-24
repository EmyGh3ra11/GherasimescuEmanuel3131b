using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gherasimescu
{
    static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            using (Window3D window = new Window3D())
            {
                window.Run();
            }
        }


    }
}
