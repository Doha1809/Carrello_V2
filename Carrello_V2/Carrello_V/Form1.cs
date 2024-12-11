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
            id=textBox1.Text;
            Prodotto p=new Prodotto(id, "marca", "modello", 12);
            carrello.Aggiungi_prodotto(p);
            listBox1.Items.Add(p);
            
        }
    }
}
