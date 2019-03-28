using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gramatica
{
    public partial class Form1 : Form
    {
        List<string> Gramatica = new List<string>();

        public Form1()
        {
            InitializeComponent();    
        }

        private async void btnDerrivar_Click(object sender, EventArgs e)
        {
            txtDerivacao.Focus();
            txtDerivacao.Clear();
            txtSaida.Clear();
            Gramatica.Clear();
            //ArrayList Gramatica = new ArrayList();
            for (int i=0;i < txtGramatica.Lines.Count(); i++)
            {
            Gramatica.Add(txtGramatica.Lines[i]);
            }

            
            Stack Saida = new Stack();
            Saida.Clear();



            foreach (char ch in SelecionaProducao("S")) { 
                Saida.Push(ch.ToString());
            }

            while (Saida.Count > 0)
            {
                BtnDerivar.Enabled = false;
                if (Saida.Peek().Equals("&"))
                {
                    Saida.Pop();
                }
                else if (Char.IsUpper(Convert.ToChar(Saida.Peek())))
                {
                    foreach (char ch in SelecionaProducao(Convert.ToString(Saida.Pop())))
                    {
                        Saida.Push(ch.ToString());
                    }
                }
                else //if (Char.IsLower(Convert.ToChar(Saida.Peek())))
                {
                    txtSaida.AppendText(Convert.ToString(Saida.Pop()));
                }               await Task.Delay(350);
            }
            BtnDerivar.Enabled = true;
        }


        public String SelecionaProducao(String Letra)
        {
            String NaoTerminal="";
            foreach (var item in Gramatica)
            {
                if (item[0] == Convert.ToChar(Letra))
                {
                    NaoTerminal = item.Substring(2, item.Length - 2);
                    break;
                }
            }
            string[] ConjuntoNaoTerminal = NaoTerminal.Split('|');
            Random rng = new Random();
            int selecionado = rng.Next(0, ConjuntoNaoTerminal.Count());
            txtDerivacao.AppendText(Letra + (selecionado + 1) + " - " + ConjuntoNaoTerminal[selecionado] + "\r\n");

            String antes = ConjuntoNaoTerminal[selecionado], invertido = "";
            int Length = ConjuntoNaoTerminal[selecionado].Length - 1;
            while (Length >= 0)
            {
                invertido = invertido + antes[Length];
                Length--;
            }
            return invertido;

        }
    }
}
