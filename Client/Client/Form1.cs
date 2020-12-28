using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net.WebSockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Serialization;
using MainService;

namespace Client
{
    public partial class Form1 : Form
    {
        private Image qrImage;
        private MainServicePortTypeClient client;
        public Form1()
        {
            client = new MainServicePortTypeClient(MainServicePortTypeClient.EndpointConfiguration.MainServiceHttpSoap11Endpoint);

            InitializeComponent();
        }

        /*
         * Metode for å hente string med brukerinfo fra webservice
         */
        private async void userCheckBtn_Click(object sender, EventArgs e)
        {
            string brukernavn = userCheckName.Text;
            string passord = userCheckPassword.Text;

            if (String.IsNullOrEmpty(brukernavn) || String.IsNullOrEmpty(passord))
            {
                MessageBox.Show("Brukernavn og passord må fylles inn");
                return;
            }
            var res = await client.userCheckAsync(brukernavn, passord);
            MessageBox.Show(res.get());
        }

        /*
         * Metode for å hente QR-bildet. Får bytearray og konverterer dette til bilde som vises i brukergrensesnittet.
         */
        private async void getQRBtn_Click(object sender, EventArgs e)
        {
            string brukernavn = userNameQRBox.Text;
            if (String.IsNullOrEmpty(brukernavn))
            {
                MessageBox.Show("BRUKERNAVN MÅ FYLLES UT");
                return;
            }
            var request = new getQRImageRequest(brukernavn);
            var res = await client.getQRImageAsync(brukernavn);
            MemoryStream ms = new MemoryStream(res.get());
            
            qrImage = Image.FromStream(ms);
            qRPictureBox.Image = qrImage;

        }
        /*
         * Konverterer brukerstring til bytearray og etterspør størrelse hos webservice
         */
        private async void btnStringSize_Click(object sender, EventArgs e)
        {
            string stringToCheck = textBoxStringSize.Text;
            byte[] bytes = Encoding.UTF8.GetBytes(stringToCheck);
            if (String.IsNullOrEmpty(stringToCheck))
            {
                MessageBox.Show("Må skrive inn string for å sjekke");
                return;
            }
            

            var res = await client.getByteCountAsync(bytes);
            MessageBox.Show("Størrelse på stringen er: " + res.get());
            
        }
        /*
        * Konverterer Person-objekt til bytearray og etterspør størrelse hos webservice
        */
        private async void btnSendPerson_Click(object sender, EventArgs e)
        {
            Person person = new Person("martin", 29);
            MemoryStream ms = new MemoryStream();
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(ms, person);
            //mySerializer.Serialize(ms, person);
            

            var res = await client.getByteCountAsync(ms.ToArray());
            MessageBox.Show("størrelse på person: " + res.get()); 
           
        }
        /*
        * Konverterer flyttall til bytearray og etterspør størrelse hos webservice
        */
        private async void btnNumericSize_Click(object sender, EventArgs e)
        {
            if (numericSize.Value == null)
            {
                MessageBox.Show("Må fylle ut nummer");
            }
            
            float number = Convert.ToSingle(numericSize.Value);
            //var res = await client.getByteCountFloatAsync(number);
            byte[] bytes = BitConverter.GetBytes(number);
            var res = await client.getByteCountAsync(bytes);
            MessageBox.Show("Størrelsen på flyttallet er: " + res.get());
        }
        /*
        * Konverterer fil til bytearray og etterspør størrelse hos webservice
        */
        private async void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Browse Files",

                CheckFileExists = true,
                CheckPathExists = true,
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    byte[] bytes = File.ReadAllBytes(openFileDialog.FileName);
                    var file = File.Open(openFileDialog.FileName, FileMode.Open);
                    var res = await client.getByteCountAsync(bytes);

                    MessageBox.Show("STørrelse på fil: " + res.get());
                }
                catch (Exception efr)
                {
                    MessageBox.Show(efr.ToString());
                }
            }
        }
        /*
        * Konverterer QR-bildet til bytearray og etterspør størrelse hos webservice
        */
        private async void checkQRsize_Click(object sender, EventArgs e)
        {
            if (qrImage == null)
            {
                MessageBox.Show("HENT QR BILDE FØRST");
            }

            MemoryStream ms = new MemoryStream();
            qrImage.Save(ms, ImageFormat.Png);
            var res = await client.getByteCountAsync(ms.ToArray());
            MessageBox.Show("Bildet er antall bytes: " + res.get());
        }
    }


}
