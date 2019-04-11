using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace $safeprojectname$
{
    class Mesa : AbsLevantar
    {
        public override void levantar()
        {
            Console.WriteLine("Levantar da " + this.GetType().Name);
        }

        public override void sentar()
        {
            Console.WriteLine("Sentar na " + this.GetType().Name);
        }
    }
}
