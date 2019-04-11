using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace $safeprojectname$
{
    class Program
    {
        static void Main(string[] args)
        {

            Fabrica_Comodo Sala = new ConcSala();
            Arquiteto arq = new Arquiteto(Sala);

            arq.Construir();
            Console.ReadKey();


        }
    }
}
