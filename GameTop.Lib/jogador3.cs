using GameTop.Interface;

namespace GameTop.Lib
{
    public class jogador3 : IJogador
    {
        public string Chuta()
        {
            return "Teste Chuta \n";
        }

        public string Corre()
        {
            return "Teste Corre \n";
        }

        public string Passe()
        {
            return "Teste Passe \n";
        }
    }
}