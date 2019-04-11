using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace $safeprojectname$
{
    class ConcSala : Fabrica_Comodo
    {
        public override AbsOpen CriarAbrir()
        {
            return null;
        }

        public override AbsLevantar CriarSentar()
        {
            return new Mesa();
        }

        public override AbsOpen Janela()
        {
            return new Janela();
        }

        public override AbsOpen Porta()
        {
            return new Porta();
        }

        public AbsLevantar Cadeiras()
        {
            return new Cadeiras();
        }
    }
}
