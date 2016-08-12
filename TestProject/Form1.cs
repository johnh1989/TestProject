using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Hello World");
            makeApiCall();
        }

        private async Task<ExampleResponse> makeApiCall()
        {
            var exRes = await Program.myApi.GetResponse();
            Console.WriteLine(exRes);
            Console.WriteLine(exRes.insertkeyhere);
            textBox1.Text = exRes.insertkeyhere;
            Console.WriteLine(exRes.value);
            textBox2.Text = exRes.value;
            return exRes;
        }
    }
}
