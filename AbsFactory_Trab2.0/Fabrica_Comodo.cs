using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace $safeprojectname$
{
    abstract class Fabrica_Comodo
    {
        public abstract AbsOpen Porta();
        public abstract AbsOpen Janela();


        public abstract AbsOpen CriarAbrir();
        public abstract AbsLevantar CriarSentar();
        
    }
}
