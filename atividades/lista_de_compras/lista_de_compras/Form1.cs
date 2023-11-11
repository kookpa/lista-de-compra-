using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lista_de_compras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            // Adiciona o item digitado na caixa de texto à lista
            string item = txblista.Text;
            if (!string.IsNullOrEmpty(item))
            {
                listBox.Items.Add(item);
                txblista.Clear();
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            // Remove o item selecionado da lista
            int index = listBox.SelectedIndex;
            if (index != -1)
            {
                listBox.Items.RemoveAt(index);
            }
        }

        private void btnCompra_Click(object sender, EventArgs e)
        {
            // Marca o item selecionado como comprado
            int index = listBox.SelectedIndex;
            if (index != -1)
            {
                string item = listBox.Items[index].ToString();
                if (!item.StartsWith("[x] "))
                {
                    item = "[x] " + item;
                    listBox.Items[index] = item;
                }
            }
        }
    }
}
