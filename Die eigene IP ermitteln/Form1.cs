using System;
using System.Windows.Forms;
using System.IO;
using System.Net;


namespace Die_eigene_IP_ermitteln
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_ip_aktual_Click(object sender, EventArgs e)
        {
            string ip = "";
            string time_anzg = "";
            string url = "http://api.ipify.org";

            try
            {
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
                using (HttpWebResponse res = (HttpWebResponse)req.GetResponse())
                {
                    using (StreamReader str = new StreamReader(res.GetResponseStream()))
                    {
                        ip = str.ReadToEnd();
                        str.Close();
                        time_anzg = "Zeit : " + DateTime.Now.ToLocalTime().ToString("dd.MM.yyyy HH:mm ") + "Uhr ";
                        //wenn ich Zeit habe, mach ich eine Regex Zerlegung in IPv4 und IPv6 Erkennung
                        // damit man auch andere Seiten aufrufen kann als "http://api.ipify.org"
                        lbl_anzge.Text = IPAddress.Parse(ip).ToString();
                        this.Text = "Die IP ..  " + lbl_anzge.Text;
                        btn_Kopie_ablge.Enabled = true;
                    }
                    res.Close();
                }
            }
            catch (Exception es)
            {
                MessageBox.Show("Quelle : " + es.Source + "\n\r" + "Botschaft : " + es.Message, "Eine Ausnahme erwischt!!!");
            }
        }

        private void Btn_Kopie_ablge_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetDataObject(IPAddress.Parse(lbl_anzge.Text).ToString(), true);
            }
            catch (Exception es)
            {
                MessageBox.Show("Quelle : " + es.Source + "\n\r" + "Botschaft : " + es.Message, "Eine Ausnahme erwischt!!!");
            }
        }


        //Ich habe hier das ganze als eine Simple Funktion geschrieben einfach rauskopieren

        //------------Funktion-Anfang---------------------------------
        public IPAddress My_IP()
        // public string My_IPstr()  
        {
            string ip = "";
            string url = "http://api.ipify.org";

            try
            {
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
                using (HttpWebResponse res = (HttpWebResponse)req.GetResponse())
                {
                    using (StreamReader str = new StreamReader(res.GetResponseStream()))
                    {
                        ip = str.ReadToEnd();
                        //wenn ich Zeit habe, mach ich eine Regex Zerlegung in IPv4 und IPv6 Erkennung
                        // damit man auch andere Seiten aufrufen kann als "http://api.ipify.org"
                        str.Close();
                    }
                    res.Close();
                }
            }
            catch (Exception es)
            {
                MessageBox.Show("Quelle : " + es.Source + "\n\r" + "Botschaft : " + es.Message, "Eine Ausnahme erwischt!!!");
            }
            try
            {
                return IPAddress.Parse(ip);
                //return IPAddress.Parse(ip).ToString();
            }
            catch (Exception es1)
            {
                MessageBox.Show("Quelle : " + es1.Source + "\n\r" + "Botschaft : " + es1.Message + "\n\rAchtung : Es wird eine 0.0.0.0 IP zurückgegeben", "Eine Ausnahme erwischt!!!");
                ip = "0.0.0.0";
                return IPAddress.Parse(ip);
                //return IPAddress.Parse(ip).ToString();
            }
        }

        //------------------Funktion-Ende-------------------------------
    }
}
