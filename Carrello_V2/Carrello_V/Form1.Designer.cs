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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // elimina
            // 
            elimina.BackColor = Color.Blue;
            elimina.ForeColor = Color.White;
            elimina.Location = new Point(498, 222);
            elimina.Name = "elimina";
            elimina.Size = new Size(161, 48);
            elimina.TabIndex = 0;
            elimina.Text = "Elimina";
            elimina.UseVisualStyleBackColor = false;
            // 
            // aggiungi
            // 
            aggiungi.BackColor = Color.Red;
            aggiungi.ForeColor = SystemColors.ButtonFace;
            aggiungi.Location = new Point(114, 221);
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
            svuota.ForeColor = SystemColors.ButtonHighlight;
            svuota.Location = new Point(323, 366);
            svuota.Name = "svuota";
            svuota.Size = new Size(118, 56);
            svuota.TabIndex = 2;
            svuota.Text = "Svuota";
            svuota.UseVisualStyleBackColor = false;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(297, 115);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(172, 199);
            listBox1.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(529, 276);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(143, 276);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
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
        private TextBox textBox1;
        private TextBox textBox2;
    }
}
