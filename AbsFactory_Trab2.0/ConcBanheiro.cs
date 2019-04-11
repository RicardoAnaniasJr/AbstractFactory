using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace $safeprojectname$
{
    class ConcBanheiro : Fabrica_Comodo
    {
        public override AbsOpen CriarAbrir()
        {
            return new Chuveiro();
        }

        public override AbsLevantar CriarSentar()
        {
            return null;
        }

        public override AbsOpen Janela()
        {
            return new Janela();
        }

        public override AbsOpen Porta()
        {
            return new Porta();
        }

        public AbsOpen Espelho()
        {
            return new Espelho();
        }

    }
}
