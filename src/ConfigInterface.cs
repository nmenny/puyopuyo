using System;
using System.Windows.Forms;

namespace PuyoPuyo
{
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();

        }

        int tempCol = ConfigParameters.col;
        int tempCombi = ConfigParameters.combinaison;
        int tempDrop = ConfigParameters.tempoConst;
        int tempPos = ConfigParameters.posInt;
        int tempRow = ConfigParameters.row;

        private void Options_Load(object sender, EventArgs e)
        {
            BoxCol.Text = ConfigParameters.col.ToString();
            BoxCombi.Text = ConfigParameters.combinaison.ToString();
            BoxDrop.Text = ConfigParameters.tempoConst.ToString();
            BoxPos.Text = ConfigParameters.posInt.ToString();
            BoxRow.Text = ConfigParameters.row.ToString();
        }


        private void dropVerif(object sender, EventArgs e)
        {
            if (verification(BoxDrop.Text))
            {
                BoxDrop.Text = ConfigParameters.tempoConst.ToString();
            }
            else
            {
                tempDrop = Int32.Parse(BoxDrop.Text);
                BoxDrop.Text = tempDrop.ToString();
            }
        }


        private void colVerif(object sender, EventArgs e)
        {
            if (verification(BoxCol.Text))
            {
                BoxCol.Text = ConfigParameters.col.ToString();
            }
            else
            {
                if (Int32.Parse(BoxCol.Text) >= 2)
                {
                    tempCol = Int32.Parse(BoxCol.Text);
                    BoxCol.Text = tempCol.ToString();
                }
                else
                {
                    MessageBox.Show("nb de colonnes trop petite");
                    BoxCol.Text = ConfigParameters.col.ToString();
                }
            }
        }


        private void rowVerif(object sender, EventArgs e)
        {
            if (verification(BoxRow.Text))
            {
                BoxRow.Text = ConfigParameters.row.ToString();
            }
            else
            {
                if (Int32.Parse(BoxRow.Text) >= 2)
                {
                    tempRow = Int32.Parse(BoxRow.Text);
                    BoxRow.Text = tempRow.ToString();
                }
                else
                {
                    MessageBox.Show("nb de lignes trop petite");
                    BoxRow.Text = ConfigParameters.row.ToString();
                }
            }
        }

        private void posVerif(object sender, EventArgs e)
        {
            if (verification(BoxPos.Text))
            {
                BoxPos.Text = ConfigParameters.posInt.ToString();
            }
            else
            {
                if (Int32.Parse(BoxPos.Text) < tempCol)
                {
                    tempPos = Int32.Parse(BoxPos.Text);
                    BoxPos.Text = tempPos.ToString();
                }
                else
                {
                    MessageBox.Show("Position trop grande");
                    BoxPos.Text = ConfigParameters.posInt.ToString();
                }
            }
        }


        private void comboVerif(object sender, EventArgs e)
        {
            if (verification(BoxCombi.Text))
            {
                BoxCombi.Text = ConfigParameters.combinaison.ToString();
            }
            else
            {
                if (Int32.Parse(BoxCombi.Text) < tempCol)
                {
                    tempCombi = Int32.Parse(BoxCombi.Text);
                    BoxCombi.Text = tempCombi.ToString();
                }
                else
                {
                    MessageBox.Show("Combinaison trop grande");
                    BoxCombi.Text = ConfigParameters.combinaison.ToString();
                }
            }
        }

        public bool verification(String text)
        {
            bool erreur = false;
            int number = 0; ;
            try
            {
                number = Int32.Parse(text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Erreur, ne mettez que des nombres");
                erreur = true;
            }
            catch (OverflowException)
            {
                MessageBox.Show("Erreur, nombre trop grand");
                erreur = true;
            }
            if (number < 0)
            {
                MessageBox.Show("Erreur, nombre negatif");
                erreur = true;
            }
            return erreur;
        }

        private void Reinitialiser_Click(object sender, EventArgs e)
        {
            tempCol = ConfigParameters.colConst;
            tempCombi = ConfigParameters.combinaisonConst;
            tempDrop = ConfigParameters.tempo;
            tempPos = ConfigParameters.posIntConst;
            tempRow = ConfigParameters.rowConst;

            BoxDrop.Text = ConfigParameters.tempo.ToString();
            BoxCol.Text = ConfigParameters.colConst.ToString();
            BoxRow.Text = ConfigParameters.rowConst.ToString();
            BoxPos.Text = ConfigParameters.posIntConst.ToString();
            BoxCombi.Text = ConfigParameters.combinaisonConst.ToString();
        }

        private void confirmation_Click(object sender, EventArgs e)
        {
            if (!verification(BoxCol.Text.ToString()) && !verification(BoxDrop.Text) && !verification(BoxRow.Text) && !verification(BoxPos.Text) && !verification(BoxCombi.Text))
            {
                if (Int32.Parse(BoxCombi.Text) < tempCol)
                {
                    if (Int32.Parse(BoxPos.Text) < tempCol)
                    {
                        if (Int32.Parse(BoxRow.Text) >= 2)
                        {
                            if (Int32.Parse(BoxCol.Text) >= 2)
                            {
                                ConfigParameters.optionsOuvertes = false;
                                ConfigParameters.col = tempCol;
                                ConfigParameters.combinaison = tempCombi;
                                ConfigParameters.tempoConst = tempDrop;
                                ConfigParameters.posInt = tempPos;
                                ConfigParameters.row = tempRow;
                                Options.ActiveForm.Close();
                            }
                            else
                            {
                                MessageBox.Show("nb de colonnes trop petite");
                                BoxCol.Text = ConfigParameters.col.ToString();
                            }
                        }
                        else
                        {
                            MessageBox.Show("nb de lignes trop petite");
                            BoxRow.Text = ConfigParameters.row.ToString();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Position trop grande");
                        BoxPos.Text = ConfigParameters.posInt.ToString();
                    }

                }
                else
                {
                    MessageBox.Show("Combinaison trop grande");
                    BoxCombi.Text = ConfigParameters.combinaison.ToString();
                }

            }
        }

        private void Options_FormClosed(object sender, FormClosedEventArgs e)
        {
            ConfigParameters.optionsOuvertes = false;
        }
    }
}
