using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace $safeprojectname$
{
    class Cadeiras : AbsLevantar
    {
        public override void levantar()
        {
            Console.WriteLine("Levantar das " + this.GetType().Name);
        }

        public override void sentar()
        {
            Console.WriteLine("Sentar nas " + this.GetType().Name);
        }
    }
}
