using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
namespace FireBase_connect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        IFirebaseConfig fcon = new FirebaseConfig
        {
            AuthSecret = "yOhY8S1R7yC3UxuitxE75TIfYTxrKPvtWxsydkxO",
            BasePath = "https://connect-45207-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;

    private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(fcon);
            }
            catch
            {
                MessageBox.Show("Not connected internet");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            person prs = new person()
            {
                name = textBox2.Text,
                surname = textBox3.Text,
                age = textBox4.Text,
                
            };
            object set = client.Set(@"Person/" + textBox1.Text , prs);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

        }
    }
}
