using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WA_Estrazione
{
    public partial class rdn2allievi : Form
    {
        string allievo = " ";
        int nstudenti = 13;
        Random rnd = new Random();
        int nestratto;
        public rdn2allievi()
        {
            InitializeComponent();
            ListaStudenti.Items.Add("Rossi");
            ListaStudenti.Items.Add("Napolitano");
            ListaStudenti.Items.Add("Esposito");
            ListaStudenti.Items.Add("Covone");
            ListaStudenti.Items.Add("Cesiro");
            ListaStudenti.Items.Add("LauroLauri");
            ListaStudenti.Items.Add("Amato");
            ListaStudenti.Items.Add("Serpico");
            ListaStudenti.Items.Add("Coppola");
            ListaStudenti.Items.Add("Vaccari");
            ListaStudenti.Items.Add("Terracciano");
            ListaStudenti.Items.Add("Aliperti");
            ListaStudenti.Items.Add("Diocleziano");
            
           
        }

        private void ListaStudenti_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdn1allievo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListaStudenti.Items.Clear();
            ListaStudenti.Items.Add("Rossi");
            ListaStudenti.Items.Add("Napolitano");
            ListaStudenti.Items.Add("Esposito");
            ListaStudenti.Items.Add("Covone");
            ListaStudenti.Items.Add("Cesiro");
            ListaStudenti.Items.Add("LauroLauri");
            ListaStudenti.Items.Add("Amato");
            ListaStudenti.Items.Add("Serpico");
            ListaStudenti.Items.Add("Coppola");
            ListaStudenti.Items.Add("Vaccari");
            ListaStudenti.Items.Add("Terracciano");
            ListaStudenti.Items.Add("Aliperti");
            ListaStudenti.Items.Add("Diocleziano");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (rdn1allievo.Checked)
            {
                estrazione(1);
            }
            if (rdn2all.Checked)
            {
                estrazione(2);
            }
            if (rnd3allievi.Checked)
            {
                estrazione(3);
            }
            
           

        }
        private void estrazione(int r)
        {
            for (int i = 0; i < r; i++)
            {
                nestratto = rnd.Next(0, nstudenti);
                if (Casuale.Checked == true)
                {
                    if (Esclusioneallievi.Checked == true)
                    {
                        nestratto = rnd.Next(0, nstudenti);
                        ListaStudenti.SetSelected(nestratto, true);
                        allievo = Convert.ToString(ListaStudenti.SelectedItem);
                        if (ListaStudenti.Items.Contains(allievo) == true)
                        {

                            ListaStudenti.Items.Remove(allievo);
                            MessageBox.Show(allievo);
                            nstudenti = nstudenti - 1;
                        }
                    }
                    else
                    {
                        nestratto = rnd.Next(0, nstudenti);
                        ListaStudenti.SetSelected(nestratto, true);
                        allievo = Convert.ToString(ListaStudenti.SelectedItem);
                        MessageBox.Show(allievo);
                    }
                }
                else if (CasualeP.Checked)
                {
                    do
                    {
                        nestratto = rnd.Next(0, nstudenti);
                    } while (nestratto % 2 == 0);


                    {
                        if (Esclusioneallievi.Checked == true)
                        {
                            ListaStudenti.SetSelected(nestratto, true);
                            allievo = Convert.ToString(ListaStudenti.SelectedItem);
                            if (ListaStudenti.Items.Contains(allievo) == true)
                            {

                                ListaStudenti.Items.Remove(allievo);
                                MessageBox.Show(allievo);
                                nstudenti = nstudenti - 1;
                            }
                        }
                        else
                        {
                            ListaStudenti.SetSelected(nestratto, true);
                            allievo = Convert.ToString(ListaStudenti.SelectedItem);
                            MessageBox.Show(allievo);
                        }
                    }
                }
                else
                {
                    do
                    {
                        nestratto = rnd.Next(0, nstudenti);
                    } while (nestratto%2==0);
                    

                    {
                        if (Esclusioneallievi.Checked == true)
                        {
                            ListaStudenti.SetSelected(nestratto, true);
                            allievo = Convert.ToString(ListaStudenti.SelectedItem);
                            if (ListaStudenti.Items.Contains(allievo) == true)
                            {

                                ListaStudenti.Items.Remove(allievo);
                                MessageBox.Show(allievo);
                                nstudenti = nstudenti - 1;
                            }
                        }
                        else
                        {
                            ListaStudenti.SetSelected(nestratto, true);
                            allievo = Convert.ToString(ListaStudenti.SelectedItem);
                            MessageBox.Show(allievo);
                        }


                    }

                }
            } 
        }

        private void Esclusioneallievi_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
  
}
