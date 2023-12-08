using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Net;
using System.IO;
using System.Windows.Forms;

namespace AppBoteco.Classes
{
    public class BuscaCEP
    {
        public string CEP { get; set; }
        public string endereco { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }

        public void Busca(string cep)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://viacep.com.br/ws/" + cep + "/json/");
            request.AllowAutoRedirect = false;
            HttpWebResponse ChecaServidor = (HttpWebResponse)request.GetResponse();
            if (ChecaServidor.StatusCode != HttpStatusCode.OK)
            {
                MessageBox.Show("Servidor Indisponível!");
                return;
            }
            using (Stream webstream = ChecaServidor.GetResponseStream())
            {
                if (webstream != null)
                {
                    using (StreamReader responseReader = new StreamReader(webstream))
                    {
                        string response = responseReader.ReadToEnd();
                        response = Regex.Replace(response, "[{},]", string.Empty);
                        response = response.Replace("\"", "");
                        string[] substrings = response.Split('\n');
                        int cont = 0;
                        foreach (var substring in substrings)
                        {
                            if (cont == 1)
                            {
                                string[] valor = substring.Split(":".ToCharArray());
                                if (valor[0] == "  erro")
                                {
                                    MessageBox.Show("CEP não encontrado!");
                                    return;
                                }
                            }
                            if (cont == 2)
                            {
                                string[] valor = substring.Split(":".ToCharArray());
                                endereco = valor[1];
                            }
                            if (cont == 4)
                            {
                                string[] valor = substring.Split(":".ToCharArray());
                                bairro = valor[1];
                            }
                            if (cont == 5)
                            {
                                string[] valor = substring.Split(":".ToCharArray());
                                cidade = valor[1];
                            }
                            cont++;
                        }
                    }
                }
            }
        }
    }
}
