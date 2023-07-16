using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colecoes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            #region List
            lista.Items.Clear();

            string[] frutas = { "Abacate", "Morango", "Uva", "Melancia", "Manga", "limão" };
            List<string> nomesFrutas = new List<string>();

            for(int i = 0; i < frutas.Length; i++)
            {
                nomesFrutas.Add(frutas[i]);
            }

            nomesFrutas.RemoveAt(0);

            nomesFrutas.Sort();
            
            foreach (string fruta in nomesFrutas)
            {
                lista.Items.Add(fruta);
            }
            #endregion
        }

        private void btnHashSet_Click(object sender, EventArgs e)
        {
            #region HashSet
            lista.Items.Clear();

            string[] frutas = { "Abacate", "Abacate", "Morango", "Uva", "Uva", "Melancia", "Manga", "limão" };
            HashSet<string> nomesFrutas = new HashSet<string>();

            for (int i = 0; i < frutas.Length; i++)
            {
                string f = frutas[i];

                if (nomesFrutas.Add(f))
                {
                    MessageBox.Show($"Item {f} adicionado");
                }
                else
                {
                    MessageBox.Show($"Item {f} já existe");
                }
            }

            foreach (string fruta in nomesFrutas)
            {
                lista.Items.Add(fruta);
            }
            #endregion
        }

        private void btnDictionary_Click(object sender, EventArgs e)
        {
            #region Dictionary
            lista.Items.Clear();

            Dictionary<int, string> alunos = new Dictionary<int, string>()
            {
                { 1, "Alessandro" },
                { 2, "Bruno" },
                { 3, "Camila" },
                { 4, "Diego" },
                { 5, "Gabriel" },
                { 6, "Marcela" },
                { 7, "Renan" },
                { 8, "Wesley" }
            };

            if (alunos.ContainsValue("Renan"))
            {
                MessageBox.Show("Sim Renan está matriculado");
            }

            foreach(KeyValuePair<int, string> aluno in alunos)
            {
                lista.Items.Add($"id:{aluno.Key} -> nome: {aluno.Value}");
            }

            MessageBox.Show($"Quantidade de alunos {alunos.Count}", "Alunos");
            #endregion
        }

        private void btnSortedList_Click(object sender, EventArgs e)
        {
            #region SortedList

            lista.Items.Clear();
            SortedList<int, string> alunos = new SortedList<int, string>()
            {
                { 10, "Alessandro" },
                { 8, "Bruno" },
                { 15, "Camila" },
                { 6, "Diego" },
                { 1, "Gabriel" },
                { 30, "Marcela" },
                { 7, "Renan" },
                { 20, "Wesley" }
            };

            foreach (KeyValuePair<int, string> aluno in alunos.Reverse())
            {
                lista.Items.Add($"id:{aluno.Key} -> nome: {aluno.Value}");
            }
            #endregion
        }

        private void btnSortedDictionary_Click(object sender, EventArgs e)
        {
            #region SortedDictionary

            lista.Items.Clear();
            SortedDictionary<int, string> alunos = new SortedDictionary<int, string>()
            {
                { 1001, "Alessandro" },
                { 802, "Bruno" },
                { 1503, "Camila" },
                { 604, "Diego" },
                { 105, "Gabriel" },
                { 3006, "Marcela" },
                { 707, "Renan" },
                { 2008, "Wesley" }
            };

            foreach (KeyValuePair<int, string> aluno in alunos.Reverse())
            {
                lista.Items.Add($"id:{aluno.Key} -> nome: {aluno.Value}");
            }
            #endregion
        }

        private void btnSortedSet_Click(object sender, EventArgs e)
        {
            #region SortedSet

            lista.Items.Clear();
            SortedSet<string> alunos = new SortedSet<string>()
            {
                "Alessandro", "Bruno", "Carlos", "Camila", "Renan", "Wesley", "Wesley" 
            };

            foreach (string aluno in alunos)
            {
                lista.Items.Add($"nome: {aluno}");
            }
            #endregion
        }
    }
}
