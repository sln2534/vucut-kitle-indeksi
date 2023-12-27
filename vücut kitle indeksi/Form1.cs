using static System.Windows.Forms.DataFormats;

namespace vücut_kitle_indeksi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double boy, kilo, vki;
        private void button1_Click(object sender, EventArgs e)
        { 
            boy = Convert.ToDouble(textBox2.Text);
            kilo = Convert.ToDouble(textBox1.Text);
            vki = kilo / (boy * boy);
            label3.Text = vki.ToString("##.##");

            /* 18 ile < 25 aralığında ise ‘Normal’
             25 ile < 30 aralığında ise ‘Kilolu’
             30 ve daha yüksek ise ‘Obez’
             35 ve daha fazla ise ‘Ciddi Obez’ olarak kabul edilmektedir.*/

            if (vki > 18 && vki < 25)
            {
                label4.Text = "normal";
            }
            else if (vki > 25 && vki < 30)
            {
                label4.Text = "kilolu";
            }
            else if (vki >= 30 && vki < 35)
            {
                label4.Text = "obez";
            }
            else
            {
                label4.Text = "ciddi obez";
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            label4.Text = "";
            label3.Text = "";
        }
    }
}