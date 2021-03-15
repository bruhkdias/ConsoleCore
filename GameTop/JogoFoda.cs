using GameTop.Interface;

namespace GameTop
{
    public class JogoFoda
    {
        private readonly IJogador _JogadorA;
        private readonly IJogador _JogadorB;
        public JogoFoda(IJogador jogadorA, IJogador jogadorB)
        {
            _JogadorA = jogadorA;
            _JogadorB = jogadorB;

        }
        public void IniciarJogo()
        {
            System.Console.Write(_JogadorA.Corre());
            System.Console.Write(_JogadorA.Chuta());
            System.Console.Write(_JogadorA.Passe());

            System.Console.Write("\n PRÓXIMO JOGADOR \n\n");

            System.Console.Write(_JogadorB.Corre());
            System.Console.Write(_JogadorB.Chuta());
            System.Console.Write(_JogadorB.Passe());
        }
        
    }

}