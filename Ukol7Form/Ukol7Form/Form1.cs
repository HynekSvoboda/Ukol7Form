using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ukol7Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
            button2.Enabled = false;
        }

        ColorDialog barva;

        private void button2_Click(object sender, EventArgs e)
        {

            Form f2 = new Form();
            this.Hide();
            int x = (int)numericUpDown1.Value;
            int y = (int)numericUpDown2.Value;
            f2.Size = new Size(x,y);
            f2.StartPosition = FormStartPosition.CenterScreen;
            f2.ShowIcon = false;
            f2.Text = "";
            f2.BackColor = barva.Color;

           

            Button buttonok = new Button();
            buttonok.Text = "Zpět";
            buttonok.Location = new Point(25, 10);
            buttonok.Size = new Size(50, 50);
            buttonok.DialogResult = DialogResult.OK;
            buttonok.BackColor = Color.Black;
            buttonok.ForeColor = Color.White;

            Button buttoncan = new Button();
            buttoncan.Text = "Konec";
            buttoncan.Location = new Point(85, 10);
            buttoncan.Size = new Size(50, 50);
            buttoncan.DialogResult = DialogResult.Cancel;
            buttoncan.BackColor = Color.Black;
            buttoncan.ForeColor = Color.White;

            Label labeltext = new Label();
            labeltext.Text = "text: "+textBox1.Text;
            labeltext.Location = new Point(50, 100);
            if (checkBox1.Checked) f2.FormBorderStyle = FormBorderStyle.Sizable;
            else f2.FormBorderStyle = FormBorderStyle.None;

            f2.Controls.Add(buttoncan);
            f2.Controls.Add(buttonok);
            f2.Controls.Add(labeltext);

            if (f2.ShowDialog() == DialogResult.OK)
            {
                f2.Close();
                this.Show();
            }
            else System.Windows.Forms.Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            barva = new ColorDialog();
            if(barva.ShowDialog()==DialogResult.OK)
            {
                button2.Enabled = true;
            }
        }
    }
}
