using System.Net;
using System.Threading;
using System.Windows.Forms;
using RestSharp;

namespace WebexIntegrate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var client = new RestClient("https://webexapis.com/v1");
            var request = new RestRequest("/messages/", Method.Post)
                .AddHeader("Authorization", "<bearer id>")
                .AddParameter("roomId", "<room id>")
                .AddParameter("text", "Direction of Call: " + textBox2.Text + "\n" + "Customer Number: " + textBox3.Text + "\n" + "Date and Time: " + textBox4.Text + "\n" + "Agent Phone Number: " + textBox5.Text + "\n" + "Agent Email: " + textBox6.Text + "\n" + "Symptoms: " + textBox7.Text);

            var go = client.Execute(request);
           
            textBox1.Text = go.Content.ToString();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox7.Text = string.Empty;
        }
    }
}
