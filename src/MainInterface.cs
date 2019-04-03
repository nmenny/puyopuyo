/*
 Nathan : Affichage et logique combinatoire
 Cyril : Class.score, timer
 Alexis : collision
*/

using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace PuyoPuyo
{
    public partial class MainInterface : Form
    {
        System.Drawing.Rectangle[] rectangles;
        System.Drawing.SolidBrush[] brush;
        System.Drawing.SolidBrush couleurFond = new System.Drawing.SolidBrush(Color.LightGray);
        System.Drawing.SolidBrush couleurPiece = new System.Drawing.SolidBrush(Color.Blue);
        System.Drawing.SolidBrush couleurPieceDeux = new System.Drawing.SolidBrush(Color.Orange);
        System.Drawing.SolidBrush couleurPieceTrois = new System.Drawing.SolidBrush(Color.Red);

        int pos;
        int score = 0;
        int tempo;
        int dropStart = 50; //temps avant que la piece ne tombe d'elle meme
        int timerInit = 50;
        int secondes_int = 0;
        int minutes_int = 0;
        bool aCommencer = false;
        int nbPiece;
        int max;
        int coteInfGauche;
        int coteSupDroit;
        int codeSecret = 0;
        int couleurPassee = 0;
        bool secretActive = false;

        int tailleCarreX = 36;
        int tailleCarreY = 36;
        int ecart = 1;

        public MainInterface()
        {
            init();
            InitializeComponent();
        }

        public void init()
        {
            nbPiece = ConfigParameters.col * ConfigParameters.row;
            rectangles = new System.Drawing.Rectangle[nbPiece];
            brush = new System.Drawing.SolidBrush[nbPiece];

            ConfigParameters.posInt = ConfigParameters.col / 2;
            pos = ConfigParameters.posInt;
            tempo = ConfigParameters.tempoConst;


            tailleCarreX = 255 / ConfigParameters.col;
            tailleCarreY = 515 / ConfigParameters.row;

            for (int i = 0; i < rectangles.GetLength(0); i++)
            {
                rectangles[i] = new Rectangle(1, 1, tailleCarreX, tailleCarreY);
                brush[i] = new SolidBrush(couleurFond.Color);
            }
            max = nbPiece - 1;
            coteInfGauche = nbPiece - ConfigParameters.col;
            coteSupDroit = ConfigParameters.col - 1;
        }

        public System.Drawing.SolidBrush whichColor() //Permet de generer une couleur de facon aleatoire
        {
            System.Drawing.SolidBrush couleur = new System.Drawing.SolidBrush(Color.Black);
            int nb;
            do
            {
                Random aleatoire = new Random();
                nb = aleatoire.Next(6);
            } while (nb == couleurPassee);
            couleurPassee = nb;

            if (nb == 0)
            {
                couleur.Color = Color.Green;
            }
            else if (nb == 1)
            {
                couleur.Color = Color.Yellow;
            }
            else if (nb == 2)
            {
                couleur.Color = Color.Blue;
            }
            else if (nb == 3)
            {
                couleur.Color = Color.Orange;
            }
            else if (nb == 4)
            {
                couleur.Color = Color.Red;
            }
            else if (nb == 5)
            {
                couleur.Color = Color.Brown;
            }

            return couleur;
        }

        public void scorePlus() //affiche le Class.score
        {
            points.Text = score.ToString();
        }

        public void drawPiece() //dessine la piece
        {
            brush[pos].Color = couleurPiece.Color;
        }

        public bool collision() //gere les collisions
        {
            bool collision = false;
            if (brush[pos].Color != couleurFond.Color)
            {
                collision = true;
            }
            return collision;
        }

        public void newPiece() //genere une nouvelle piece et attribut aux deux suivantes leur nouvelles couleurs
        {
            couleurPiece.Color = couleurPieceDeux.Color;
            couleurPieceDeux.Color = couleurPieceTrois.Color;
            couleurPieceTrois.Color = whichColor().Color;
            pos = ConfigParameters.posInt;
            Refresh();
        }

        public void stop() //stop la piece de tomber
        {
            if (!secretActive)
            {
                verifHori();
                verifVerti();
                faireTomber();
                if (!defaite())
                {
                    tempo -= 10;
                    newPiece();
                }
                else
                {
                    perdu();
                }
            }
        }

        public void verifHori() //verifie si sur la ligne actuelle il y a un combo de couleur
        {
            int nb = 0;
            int[] pieceAEnlever = new int[max];
            if (rectangles[pos].X == rectangles[max].X)
            {
                int i = 0;
                int posTemp = pos;
                while (brush[posTemp].Color == couleurPiece.Color)
                {
                    pieceAEnlever[i] = posTemp;
                    i++;
                    nb++;
                    posTemp--;
                }
            }
            else if (rectangles[pos].X == rectangles[0].X)
            {
                int i = 0;
                int posTemp = pos;
                while (brush[posTemp].Color == couleurPiece.Color && posTemp < (max))
                {
                    pieceAEnlever[i] = posTemp;
                    i++;
                    nb++;
                    posTemp++;
                }
            }
            else
            {
                int posTemp = pos;
                int i = 0;
                if (posTemp != (coteInfGauche))
                {
                    pieceAEnlever[i] = posTemp;
                    i++;
                    nb++;
                    posTemp--;
                    if (brush[posTemp].Color == couleurPiece.Color)
                    {
                        pieceAEnlever[i] = posTemp;
                        i++;
                        nb++;
                        if (posTemp != (coteInfGauche))
                        {
                            posTemp--;
                            if (brush[posTemp].Color == couleurPiece.Color)
                            {
                                pieceAEnlever[i] = posTemp;
                                i++;
                                nb++;
                                if (posTemp != (coteInfGauche))
                                {
                                    posTemp--;
                                    if (brush[posTemp].Color == couleurPiece.Color)
                                    {
                                        pieceAEnlever[i] = posTemp;
                                        i++;
                                        nb++;
                                        if (posTemp != (coteInfGauche))
                                        {
                                            posTemp--;
                                            if (brush[posTemp].Color == couleurPiece.Color)
                                            {
                                                pieceAEnlever[i] = posTemp;
                                                i++;
                                                nb++;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                posTemp = pos;
                if (posTemp != (max))
                {
                    posTemp++;
                    if (brush[posTemp].Color == couleurPiece.Color)
                    {
                        pieceAEnlever[i] = posTemp;
                        i++;
                        nb++;
                        if (posTemp != (max))
                        {
                            posTemp++;
                            if (brush[posTemp].Color == couleurPiece.Color)
                            {
                                pieceAEnlever[i] = posTemp;
                                i++;
                                nb++;
                                if (posTemp != (max))
                                {
                                    posTemp++;
                                    if (brush[posTemp].Color == couleurPiece.Color)
                                    {
                                        pieceAEnlever[i] = posTemp;
                                        i++;
                                        nb++;
                                        if (posTemp != (max))
                                        {
                                            posTemp++;
                                            if (brush[posTemp].Color == couleurPiece.Color)
                                            {
                                                pieceAEnlever[i] = posTemp;
                                                i++;
                                                nb++;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            if (nb >= ConfigParameters.combinaison)
            {
                for (int j = 0; j < nb; j++)
                {
                    brush[pieceAEnlever[j]].Color = couleurFond.Color;
                    score++;
                }
                scorePlus();
            }

        }

        public void verifVerti() //verifie si sur la colonne actuelle il y a un combo de couleur
        {
            int nb = 0;
            int[] pieceAEnlever = new int[max];
            int i = 0;
            int posTemp = pos;
            pieceAEnlever[i] = posTemp;
            i++;
            nb++;
            while (rectangles[posTemp].Y != rectangles[(max)].Y)
            {
                if (brush[posTemp + ConfigParameters.col].Color == couleurPiece.Color)
                {
                    posTemp += ConfigParameters.col;
                    pieceAEnlever[i] = posTemp;
                    i++;
                    nb++;
                }
                else
                {
                    break;
                }
            }

            if (nb >= ConfigParameters.combinaison)
            {
                for (int j = 0; j < nb; j++)
                {
                    brush[pieceAEnlever[j]].Color = couleurFond.Color;
                    score++;
                }
                scorePlus();
            }
        }

        public void faireTomber() //fait tomber les pieces d'un niveau
        {
            int[] rectanglesColore = new int[max];
            int j = 0;
            for (int i = 0; i < rectangles.GetLength(0); i++)
            {
                if (brush[i].Color != couleurFond.Color)
                {
                    rectanglesColore[j] = i;
                    j++;
                }
            }
            int compteur = 0;
            while (compteur < ConfigParameters.row)
            {
                for (int i = 0; i < rectanglesColore.GetLength(0); i++)
                {
                    if (rectangles[rectanglesColore[i]].Y != rectangles[max].Y)
                    {
                        int r = rectanglesColore[i];
                        r += ConfigParameters.col;
                        if (brush[r].Color == couleurFond.Color)
                        {
                            brush[r].Color = brush[rectanglesColore[i]].Color;
                            brush[rectanglesColore[i]].Color = couleurFond.Color;
                        }
                    }
                }
                compteur++;
            }
        }

        public bool defaite() //verifie si on a perdu
        {
            bool defaite = false;
            if (rectangles[pos].Y == rectangles[0].Y)
            {
                defaite = true;
            }
            return defaite;
        }

        public void perdu() //Se declenche quand on a perdu
        {
            Timer.Stop();
            Timer_time.Stop();
            commencer.Visible = true;
            Reglage.Visible = true;
            MessageBox.Show("Vous avez perdu" + "\n" + "Vous avez un score de " + score + " pts");
        }

        public bool gravity() //syteme de gravite surveillant le temps qui s'ecoule
        {
            if (dropStart > tempo)
            {
                dropStart = 100;
                return true;
            }
            else
            {
                dropStart += 50;
                return false;
            }
        }

        public void afficherSeconde() //affiche le temps qui passe
        {
            secondes.Text = secondes_int.ToString();
            minutes.Text = minutes_int.ToString();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) //permet d'acquerir les touches du clavier
        {
            if (keyData == Keys.Down || keyData == Keys.Left || keyData == Keys.Right || keyData == Keys.D || keyData == Keys.A || keyData == Keys.B)
            {
                //Recupere la valeur fleche du bas
                if (keyData == Keys.Down)
                {
                    if (aCommencer)
                    {
                        if (rectangles[pos].Y < rectangles[max].Y)
                        {
                            brush[pos].Color = couleurFond.Color;
                            pos += ConfigParameters.col;
                            if (!collision())
                            {
                                brush[pos].Color = couleurPiece.Color;
                                dropStart = 100;
                                Refresh();
                            }
                            else
                            {
                                pos -= ConfigParameters.col;
                                brush[pos].Color = couleurPiece.Color;
                                dropStart = 100;
                                stop();
                            }
                        }
                        else
                        {
                            brush[pos].Color = couleurPiece.Color;
                            dropStart = 100;
                            stop();
                        }
                        return true;
                    }
                }
                //Recupere la valeur fleche de gauche
                if (keyData == Keys.Left)
                {
                    if (aCommencer)
                    {
                        if (rectangles[pos].X > rectangles[0].X)
                        {
                            brush[pos].Color = couleurFond.Color;
                            pos--;
                            if (!collision())
                            {
                                brush[pos].Color = couleurPiece.Color;
                                dropStart = 100;
                                Refresh();
                            }
                            else
                            {
                                pos++;
                                brush[pos].Color = couleurPiece.Color;
                                dropStart = 100;
                                Refresh();
                            }
                        }
                        return true;
                    }

                }
                //Recupere la valeur fleche de droite
                if (keyData == Keys.Right)
                {
                    if (aCommencer)
                    {
                        if (rectangles[pos].X < rectangles[coteSupDroit].X)
                        {
                            brush[pos].Color = couleurFond.Color;
                            pos++;
                            if (!collision())
                            {
                                brush[pos].Color = couleurPiece.Color;
                                dropStart = 100;
                                Refresh();
                            }
                            else
                            {
                                pos--;
                                brush[pos].Color = couleurPiece.Color;
                                dropStart = 100;
                                Refresh();
                            }
                        }
                        return true;
                    }
                }
                if (keyData == Keys.D)
                {
                    if (codeSecret == 0)
                    {
                        codeSecret++;
                    }
                    else
                    {
                        codeSecret = 0;
                    }

                }
                if (keyData == Keys.A)
                {
                    if (codeSecret == 1)
                    {
                        codeSecret++;
                    }
                    else
                    {
                        codeSecret = 0;
                    }

                }
                if (keyData == Keys.B)
                {
                    if (codeSecret == 2)
                    {
                        codeSecret++;
                    }
                    else
                    {
                        codeSecret = 0;
                    }

                }
                if (codeSecret == 3)
                {
                    codeSecret = 0;
                    secret();
                }
                return base.ProcessCmdKey(ref msg, keyData);
            }
            else
            {
                codeSecret = 0;
                return base.ProcessCmdKey(ref msg, keyData);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            drawPiece();
        }

        private void refreshProgram(object sender, EventArgs e) //actualise le programme toutes les X millisecondes
        {
            Refresh();
        }

        private void clock(object sender, EventArgs e) //horloge qui toutes les secondes change la valeur des secondes/minutes
        {
            secondes_int++;
            if (secondes_int == 60)
            {
                secondes_int = 0;
                minutes_int++;
            }
            afficherSeconde();
        }

        private void DrawBackground(object sender, PaintEventArgs e) //dessine le fond
        {
            drawPiece();
            int x = 1;
            int y = 1;
            for (int i = 0; i < rectangles.GetLength(0); i++)
            {
                if (i % ConfigParameters.col == 0 && i != 0)
                {
                    y += tailleCarreY + ecart;
                    x = 1;
                }
                rectangles[i].Y = y;
                rectangles[i].X = x;
                e.Graphics.FillRectangle(brush[i], rectangles[i]);
                x += tailleCarreX + ecart;
            }
            if (gravity())
            {
                if (rectangles[pos].Y < rectangles[max].Y)
                {
                    brush[pos].Color = couleurFond.Color;
                    pos += ConfigParameters.col;
                    if (!collision())
                    {
                        brush[pos].Color = couleurPiece.Color;
                    }
                    else
                    {
                        pos -= ConfigParameters.col;
                        brush[pos].Color = couleurPiece.Color;
                        stop();
                    }
                }
                else
                {
                    brush[pos].Color = couleurPiece.Color;
                    stop();
                }
            }
        }

        private void DrawPieceDeux(object sender, PaintEventArgs e) //dessine la preview de la deuxieme piece
        {
            e.Graphics.FillRectangle(couleurPieceDeux, new Rectangle(0, 0, 30, 30));
        }

        private void DrawPieceTrois(object sender, PaintEventArgs e) //dessine la preview de la troisieme piece
        {
            e.Graphics.FillRectangle(couleurPieceTrois, new Rectangle(0, 0, 30, 30));
        }

        private void commencer_Click(object sender, EventArgs e) //bouton pour commencer la partie et la recommencer
        {
            if (!aCommencer)
            {
                if (!ConfigParameters.optionsOuvertes)
                {
                    init();
                    Refresh();
                    Timer.Interval = timerInit;
                    Timer.Enabled = true;
                    Timer_time.Enabled = true;
                    commencer.Visible = false;
                    affichageControles.Visible = false;
                    commencer.Text = "Recommencer";
                    Reglage.Visible = false;
                    aCommencer = true;
                }

            }
            else //on recommence, donc on reinitialise les variables
            {
                tempo = ConfigParameters.tempoConst;
                score = 0;
                for (int i = 0; i < brush.GetLength(0); i++)
                {
                    brush[i].Color = couleurFond.Color;
                }
                secondes_int = 0;
                minutes_int = 0;
                afficherSeconde();
                scorePlus();
                couleurPiece.Color = whichColor().Color;
                couleurPieceDeux.Color = Color.Red;
                couleurPieceTrois.Color = Color.Orange;
                init();
                Refresh();
                Reglage.Visible = true;
                affichageControles.Visible = true;
                commencer.Text = "Commencer";
                aCommencer = false;
            }
        }

        private void Reglage_Click(object sender, EventArgs e)
        {
            ConfigParameters.optionsOuvertes = true;
            Options tf = new Options();
            tf.Show();
        }

        public void secret()
        {
            //Inserer un mode secret

            secondes_int = 20;
            minutes_int = 4;
            afficherSeconde();
            AfficherScore.Text = "SATAN";


            secretActive = true;
            Timer_time.Stop();
            Reglage.Visible = false;
            commencer.Visible = false;
            Timer_secret.Enabled = true;
            couleurPieceDeux.Color = whichColor().Color;
            couleurPieceTrois.Color = whichColor().Color;
            for (int i = 0; i < brush.GetLength(0); i++)
            {
                brush[i].Color = whichColor().Color;
            }
            Refresh();
        }

        private void Timer_secret_Tick(object sender, EventArgs e)
        {
            secret();
        }
    }
}