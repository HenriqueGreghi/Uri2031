using System;
using System.Collections.Generic;
using System.Text;

namespace Uri2031
{
    class Logica
    {
        private string pedra { get; set; }
        private string papel { get; set; }
        private string ataque { get; set; }
        private string Jogador1 { get; set; }
        private string Jogador2 { get; set; }
        private string  jogada { get; set; }


        public Logica(string jogador1, string jogador2)
        {
            Jogador1 = jogador1;
            Jogador2 = jogador2;
        }

        
        public void Jogatadas()
        {
            if (Jogador1 == "ataque" && Jogador2 == "ataque" || Jogador1 == "pedra" && Jogador2 == "pedra")
            {
              jogada = " Todos perdem";
            }
            else if (Jogador1 == "papel" && Jogador2 == "papel")
            {
                jogada = " Todos ganham";
            }
            else if (Jogador1 == "ataque" && Jogador2 == "pedra" || Jogador1 == "pedra" && Jogador2 == "papel" || Jogador1 == "ataque" && Jogador2 == "papel")
            {
                jogada = " Jogador 1 venceu";
            }
            else if (Jogador2 == "ataque" && Jogador1 == "pedra" || Jogador2 == "pedra" && Jogador1 == "papel" || Jogador2 == "ataque" && Jogador1 == "papel") 
            {
                jogada = " Jogador 2 venceu";
            }
            else
            {
                jogada = " Erro ao escrever a jogada";
            }

        }
        public string Imprimir()
        {
            return jogada;
        }
    }
}
