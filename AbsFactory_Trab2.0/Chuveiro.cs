using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace $safeprojectname$
{
    class Chuveiro : AbsOpen
    {
        public override void Abrir()
        {
            Console.WriteLine(this.GetType().Name + " Abriu ");
        }

        public override void Fechar()
        {
            Console.WriteLine(this.GetType().Name + " Fechou ");
        }
    }
}
