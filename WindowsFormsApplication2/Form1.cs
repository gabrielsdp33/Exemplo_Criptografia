using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //limpa o label
            lb_Token.Text = "";


            string retorno = "";

            //Converte a hora baseada no padrão GMT (hora média de Greenwich).
            //Nesse formato, a chave muda a cada minuto 
            string mensagem = DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm");
            //
            string secret = "TokenTeste";

            retorno = CriandoToken(mensagem, secret);

            lb_Token.Text = retorno;

            label_Token_bold.Visible = true;
        }

        private string CriandoToken(string mensagem, string secret)
        {
            //retorna em branco se a variável for nula.
            secret = secret ?? "";

            var encoding = new System.Text.ASCIIEncoding();

            byte[] keyByte = encoding.GetBytes(secret);

            byte[] messageBytes = encoding.GetBytes(mensagem);

            //retorna criptografado e substituindo as caracteres que o URL quebra no browser
            using (var hmacSHA256 = new HMACSHA256(keyByte))
            {
                byte[] hashMessage = hmacSHA256.ComputeHash(messageBytes);
                return Convert.ToBase64String(hashMessage).Replace('+', '.').Replace('/', '_').Replace('=', '-');
            }
        }


    }
}
