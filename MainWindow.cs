using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace RSASignatureApplication1
{
    public partial class MainWindow : Form
    {
        private readonly SocketInteractor _socketInteractor;
        public MainWindow()
        {
            _socketInteractor = new SocketInteractor();
            _socketInteractor.Connect();
            InitializeComponent();
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            var data = Encoding.ASCII.GetBytes(textBox.Text);
            var rsa = new RSACryptoServiceProvider();
            var rsaKey = rsa.ExportParameters(true);
            var signature = rsa.SignData(data, SHA256.Create());
            var signatureString = Convert.ToBase64String(signature);
            var modulusO = rsaKey.Modulus;
            var modulus = Convert.ToBase64String(modulusO);
            var exponentO = rsaKey.Exponent;
            var exponent = Convert.ToBase64String(exponentO);
            var toSend = $"2~|~{textBox.Text}~|~{signatureString}~|~{modulus}~|~{exponent}";
            _socketInteractor.Send(toSend);
        }
    }
}