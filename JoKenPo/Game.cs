using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoKenPo
{
    internal class Game
    {
        public enum Resultado
        {
            Ganhar, Perder, Empatar

        }

        public static Image[] images =
        {
            Image.FromFile("imagens/Pedra.png"), //indice 0
            Image.FromFile("imagens/Tesoura.png"),//indice 1
            Image.FromFile("imagens/Papel.png") //indice 2
        };

        public Image ImgPc { get; private set; } 
        public Image ImgJogador { get; private set; }

        public Resultado Jogar(int jogador) //Controlador de jogadas
        {
            int pc = JogadaPc();

            ImgJogador = images[jogador];
            ImgPc = images[pc];

            if (jogador == pc)
            {
                return Resultado.Empatar;
            }
            else if ((jogador == 0 && pc == 1) ||(jogador == 1 && pc ==2) || (jogador == 2 && pc == 0))
            {
                return Resultado.Ganhar;
            }
            else
            {
                return Resultado.Perder;
            }


            return Resultado.Empatar;
        }

        private int JogadaPc()
        {
           int mil = DateTime.Now.Millisecond;

            if (mil < 333)
            {
                return 0;
            }
            else if (mil >= 333 && mil < 667)
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }
    }
}
