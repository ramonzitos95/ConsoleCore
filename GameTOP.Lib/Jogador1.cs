using System;
using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador1 : IJogador
    {
        public string Nome { get; set; }
        public Jogador1(string nome)
        {
            Nome =  nome;
        }
        public string Chuta()
        {
            return $"{Nome} está chutando";
        }

        public string Corre()
        {
            return $"{Nome} está correndo";
        }

        public string Passe()
        {
            return $"{Nome} está passando";
        }
    }
}