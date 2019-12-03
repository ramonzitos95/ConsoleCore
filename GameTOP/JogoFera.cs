using GameTOP.Interface;

namespace GameTOP
{
    class JogoFERA
    {
        private readonly IJogador _jogador1;
        private readonly IJogador _jogador2;

        public JogoFERA(IJogador jogador1, 
            IJogador jogador2)
        {
            this._jogador1 = jogador1;
            this._jogador2 = jogador2;
        }
        public void IniciarJogo()
        {
            System.Console.WriteLine(_jogador1.Corre());
            System.Console.WriteLine(_jogador1.Chuta());
            System.Console.WriteLine(_jogador1.Passe());
            ///
            System.Console.Write("\n PRÓXIMO JOGADOR \n");
            ///
            System.Console.WriteLine(_jogador2.Corre());
            System.Console.WriteLine(_jogador2.Chuta());
            System.Console.WriteLine(_jogador2.Passe());
        }
        
    }
}