namespace Carrello_V
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            elimina = new Button();
            aggiungi = new Button();
            svuota = new Button();
            listBox1 = new ListBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // elimina
            // 
            elimina.BackColor = Color.FromArgb(128, 255, 255);
            elimina.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            elimina.ForeColor = Color.Black;
            elimina.Location = new Point(83, 235);
            elimina.Name = "elimina";
            elimina.Size = new Size(177, 48);
            elimina.TabIndex = 0;
            elimina.Text = "Elimina";
            elimina.UseVisualStyleBackColor = false;
            elimina.Click += elimina_Click;
            // 
            // aggiungi
            // 
            aggiungi.BackColor = Color.FromArgb(255, 192, 192);
            aggiungi.Font = new Font("Sitka Text", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            aggiungi.ForeColor = SystemColors.ActiveCaptionText;
            aggiungi.Location = new Point(99, 99);
            aggiungi.Name = "aggiungi";
            aggiungi.Size = new Size(161, 49);
            aggiungi.TabIndex = 1;
            aggiungi.Text = "Aggiungi prodotto";
            aggiungi.UseVisualStyleBackColor = false;
            aggiungi.Click += aggiungi_Click;
            // 
            // svuota
            // 
            svuota.BackColor = Color.Black;
            svuota.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            svuota.ForeColor = SystemColors.ButtonHighlight;
            svuota.Location = new Point(356, 329);
            svuota.Name = "svuota";
            svuota.Size = new Size(155, 56);
            svuota.TabIndex = 2;
            svuota.Text = "Svuota";
            svuota.UseVisualStyleBackColor = false;
            svuota.Click += svuota_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(285, 99);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(312, 199);
            listBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(126, 154);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(99, 183);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(161, 23);
            textBox3.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.Yellow;
            button1.Font = new Font("Sitka Subheading", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(623, 214);
            button1.Name = "button1";
            button1.Size = new Size(138, 54);
            button1.TabIndex = 7;
            button1.Text = "Visualizza la somma di tutti i prezzi basi";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 192, 192);
            button2.Font = new Font("Sitka Subheading", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(623, 302);
            button2.Name = "button2";
            button2.Size = new Size(138, 69);
            button2.TabIndex = 8;
            button2.Text = "Visualizza la somma di tutti i prezzi effettivi";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(646, 181);
            label1.Name = "label1";
            label1.Size = new Size(84, 22);
            label1.TabIndex = 9;
            label1.Text = "Scontrini";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(listBox1);
            Controls.Add(svuota);
            Controls.Add(aggiungi);
            Controls.Add(elimina);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button elimina;
        private Button aggiungi;
        private Button svuota;
        private ListBox listBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private Button button2;
        private Label label1;
    }
}
