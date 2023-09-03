using Amazon.SecretsManager.Model;
using Amazon.SecretsManager;
using System.Configuration;
using Amazon;

namespace FetchSecretManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFetch_Click(object sender, EventArgs e)
        {
            Get();
        }


        private void Get()
        {
            string AWSRegion = string.Empty;
            AWSRegion = ConfigurationManager.AppSettings["AWSRegion"].ToString();
            var config = new AmazonSecretsManagerConfig { RegionEndpoint = RegionEndpoint.GetBySystemName(AWSRegion) };
            AmazonSecretsManagerClient client;

            client = new AmazonSecretsManagerClient(config);

            var request = new GetSecretValueRequest
            {
                SecretId = txtInputkey.Text
            };



            string response = null;
            try
            {
                GetSecretValueResponse getSecretTask = client.GetSecretValue(request);
                response = getSecretTask.SecretString;
                richTextBox1.Text = response;
            }
            catch (Exception e)
            {
                richTextBox1.Text = e.Message;
            }
            finally
            {
                client.Dispose();
            }


        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(richTextBox1.Text);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }
    }
}