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

namespace форма_автоизации
{
    public partial class Form1 : Form
    {
        public Dictionary<string, string> log = new Dictionary<string, string>();
        public string admin = "";
        public Form1()
        {
            InitializeComponent();
            log.Add("admin", "11111");
            log.Add("us1", "222");
            log.Add("us2", "333");
            log.Add("us3", "444");
            log.Add("us4", "555");
            log.Add("us5", "666");
            log.Add("us6", "777");
            log.Add("us7", "888");
            log.Add("us8", "999");
            log.Add("us9", "100");
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        Form2 form2 = new Form2();
        private void button1_Click(object sender, EventArgs e)
        {
            bool i = true;
            var a = log;
            if(textBox1.Text==""||textBox2.Text=="")
            {
                MessageBox.Show("Вы не ввели логин или пароль");
            }
            foreach (var key in a)
            {
                if(key.Key == textBox1.Text && key.Value == textBox2.Text)
                {
                    form2.LabelText = textBox1.Text;
                    form2.ShowDialog();
                    break;
                }
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Close();
        }
        
    }
}
