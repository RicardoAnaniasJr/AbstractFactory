using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace $safeprojectname$
{
    class Porta : AbsOpen
    {
        public override void Abrir()
        {
            Console.WriteLine(this.GetType().Name );
        }

        public override void Fechar()
        {
            Console.WriteLine(this.GetType().Name );
        }
    }
}
