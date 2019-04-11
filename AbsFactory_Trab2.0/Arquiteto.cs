using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace $safeprojectname$
{
    class Arquiteto
    {
        private AbsOpen _abrir;
        private AbsLevantar _sentar;
        private AbsOpen _porta;
        private AbsOpen _janela;

        public Arquiteto (Fabrica_Comodo fabrica)
        {
            _porta = fabrica.Porta();
            _janela = fabrica.Janela();
            _abrir = fabrica.CriarAbrir();
            _sentar = fabrica.CriarSentar();
           
        }

        public void Construir()
        {
            Console.WriteLine(_abrir );
            Console.WriteLine(_sentar );
            Console.WriteLine(_porta);
            Console.WriteLine(_janela);
        }

    }
}
