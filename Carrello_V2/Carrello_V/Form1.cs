using System.Security.Cryptography.Pkcs;

namespace Carrello_V
{
    public partial class Form1 : Form
    {
        string id;
        Carrello carrello;
        public Form1()
        {
            InitializeComponent();
            carrello = new Carrello("123");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void aggiungi_Click(object sender, EventArgs e)
        {
            id = textBox2.Text;
            if (textBox2.Text != "")
            {
                Prodotto p = new Prodotto(id, "marca", "modello", 12);
                if (textBox3.Text == "prodotto_elettrico")
                {
                    Prodotto p1 = new ProdottoElettrico(id, "marca", "modello", 12.5);
                    carrello.Aggiungi_prodotto(p1);
                }
                else
                {
                    if (textBox3.Text == "prodotto_alimentare")
                    {
                        Prodotto p2 = new ProdottoAlimentare(id, "marca", "modello", 12.5);
                        carrello.Aggiungi_prodotto(p2);
                    }
                    else
                        carrello.Aggiungi_prodotto(p);
                }
                string stringa = $"E' stato aggiunto il prodotto di codice ({p.Id})";
                listBox1.Items.Add(stringa);
                MessageBox.Show(Convert.ToString(carrello.prodotti.Count));
            }
            else
                MessageBox.Show("si prega di aggiungere il codice seriale del prodotto che vuoi aggiungere");

        }

        private void elimina_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                int prodotto_eliminato = listBox1.SelectedIndex;
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                MessageBox.Show(Convert.ToString(prodotto_eliminato));
                carrello.Elimina_prodotto(carrello.prodotti[prodotto_eliminato]);

            }
            else
                MessageBox.Show("si prega di selezionare un elemento da eliminare");
        }

        private void svuota_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                listBox1.Items.Clear();
                carrello.Svuota_carrello();
            }
            else
                MessageBox.Show("il carrello è gia vuoto");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double somma_basi= 0;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                somma_basi = somma_basi + carrello.prodotti[i].Prezzo;
            }
            MessageBox.Show(Convert.ToString(somma_basi));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double somma_sconti=0;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                somma_sconti = somma_sconti + carrello.prodotti[i].Modifica_prezzo();
            }
            MessageBox.Show(Convert.ToString(somma_sconti));
        }
    }
}
