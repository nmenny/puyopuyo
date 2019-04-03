namespace PuyoPuyo
{
    public class ConfigParameters
    {
        public const int combinaisonConst = 3; //nb minimum de combinaisons de piece a faire pour gagner des points
        public const int tempo = 400; //Temps qui passe avant la chute
        public const int colConst = 6; //nb de colonnes
        public const int rowConst = 12; //nb de lignes
        public const int posIntConst = 3;  //position initiale de la piece
        public const bool optionsOuvertesConst = false;


        public static int combinaison = combinaisonConst;
        public static int tempoConst = tempo;
        public static int col = colConst;
        public static int row = rowConst;
        public static int posInt = posIntConst;
        public static bool optionsOuvertes = optionsOuvertesConst;
    }
}
