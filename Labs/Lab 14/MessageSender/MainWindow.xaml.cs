using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using System.Xml;

namespace MessageSender
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        string _userName = "[YOUR NAME]";
        string _serviceUri = "https://a372wabs.biztalk.windows.net/default/SendMessage";
        string _status = string.Empty;
        public string Status
        {
            get { return _status; }
            set
            {
                _status = value;
                NotifyPropertyChanged("Status");
                Console.WriteLine("Status: " + value);
                //txtStatus.Dispatcher.BeginInvoke(DispatcherPriority.Normal, new Action(delegate()
                //{
                //    NotifyPropertyChanged("Status");
                //}));

                
            }
        }
        public string UserName
        {
            get { return _userName; }
            set
            {
                _userName = value;
                ServiceUri = string.Format("https://a372wabs.biztalk.windows.net/default/{0}/GetEmployees", _userName);
                NotifyPropertyChanged("UserName");
                NotifyPropertyChanged("ServiceUri");
            }
        }
        public string ServiceUri { get; set; }
  
        public MainWindow()
        {
            InitializeComponent();
            ServiceUri = "https://a372wabs.biztalk.windows.net/default/SendMessage";
            this.DataContext = this;
        }

        private void btnBrowse_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.DefaultExt = ".xml";
            dialog.Filter = "Xml Files (*.xml)|*.xml"; 

            if ((bool)dialog.ShowDialog())
            {
                txtFilePath.Text = dialog.FileName;
            }
        }

        private void btnCallWABS_Click(object sender, RoutedEventArgs e)
        {
            //this.Dispatcher.Invoke(
            //                DispatcherPriority.Normal,
            //                (ThreadStart)delegate {
            //                    Status = "Begin calling service."; });
            //Status = "Begin calling service.";


            SendMessage(txtNamespace.Text,
                txtUser.Text,
                txtPassword.Text,
                txtServiceUri.Text,
                txtFilePath.Text,
                "application/soap+xml");
        }

        /// <summary>
        /// Send message, based on content type and messaging protocol, to the runtime adresss of the deployed bridge end point
        /// </summary>
        /// <param name="acsNamespace">ACS namespace</param>
        /// <param name="issuerName">Issuer name for the specified namespace</param>
        /// <param name="issuerKey">Issuer key for the specified namespace</param>
        /// <param name="runtimeAddress">Runtime address of the deployed bridge</param>
        /// <param name="messageFilePath">Path of the input message file</param>
        /// <param name="contentType">Content type of the message</param>
        public void SendMessage(string acsNamespace, string issuerName, string issuerKey, string runtimeAddress, string messageFilePath, string contentType)
        {
            byte[] inputMessageBytes = null;

            if (string.Equals(contentType, "application/soap+xml", StringComparison.InvariantCultureIgnoreCase))
            {
                try
                {
                    Encoding encoding = Encoding.UTF8;
                    using (XmlReader bodyReader = XmlReader.Create(messageFilePath))
                    {
                        Message inputMessage = Message.CreateMessage(MessageVersion.Default, "*", bodyReader);
                        inputMessageBytes = GetMessageBytes(inputMessage, encoding);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                inputMessageBytes = File.ReadAllBytes(messageFilePath);
            }
            
            Status += "\nSending data to end point: " + runtimeAddress; 
            
            try
            {
                string response = SendMessage(acsNamespace, issuerName, issuerKey, runtimeAddress, inputMessageBytes, contentType);
                Console.WriteLine("Message sent successfully");
                if (!string.IsNullOrEmpty(response))
                {
                    Console.WriteLine("Received response {0}", response);
                }
            }
            catch (WebException we)
            {

                Status += "\nWebexception received while sending the data";
                
                Console.WriteLine(Environment.NewLine + "Webexception received while sending the data");
                HttpWebResponse httpWebExceptionResponse = we.Response as HttpWebResponse;
                
                // Get the fault from the Response
                if (we.Response != null)
                {
                    try
                    {
                        using (Stream stream = we.Response.GetResponseStream())
                        {
                            using (StreamReader reader = new StreamReader(stream))
                            {
                                string error = reader.ReadToEnd();
                                Status += "\nERROR: " + error;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("An exception occured while interpreting the response: {0}", ex.Message);
                    }
                }
            }
        }
        /// <summary>
        /// Send message bytes to the runtime adresss of the deployed bridge end point
        /// </summary>
        /// <param name="acsNamespace">ACS namespace</param>
        /// <param name="issuerName">Issuer name for the specified namespace</param>
        /// <param name="issuerKey">Issuer key for the specified namespace</param>
        /// <param name="runtimeAddress">Runtime address of the deployed bridge</param>
        /// <param name="messageBytes">Bytes of the message to be sent</param>
        /// <param name="contentType">Content type of the message</param>
        /// <returns></returns>
        public string SendMessage(string acsNamespace, string issuerName, string issuerKey, string runtimeAddress, byte[] messageBytes, string contentType)
        {
            string runtimeToken;
            UriBuilder endpointToGetAcsTokenForBuilder = new UriBuilder(runtimeAddress);
            endpointToGetAcsTokenForBuilder.Scheme = Uri.UriSchemeHttp;
            endpointToGetAcsTokenForBuilder.Port = -1;
            runtimeToken = GetAccessControlToken(endpointToGetAcsTokenForBuilder.ToString(), issuerName, issuerKey, acsNamespace);
            return SendMessageToBridge(runtimeAddress, messageBytes, runtimeToken, contentType);
        }
        /// <summary>
        /// Get bytes corresponding to a WCF Message
        /// </summary>
        /// <param name="message">The message to be converted into bytes</param>
        /// <param name="encoding">The encoding of the message</param>
        /// <returns></returns>
        private byte[] GetMessageBytes(Message message, Encoding encoding)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                using (XmlWriter xmlWriter = XmlWriter.Create(ms, new XmlWriterSettings() { Encoding = encoding }))
                {
                    message.WriteMessage(xmlWriter);
                    xmlWriter.Flush();
                }

                ms.Position = 0;
                return ms.ToArray();
            }
        }
        /// <summary>
        /// Get the Access Control token for the Service Bus URI
        /// </summary>
        /// <param name="endpointUri">Represents the End Point URI</param>
        /// <param name="issuerName">Issuer name for the Service Bus URI</param>
        /// <param name="issuerKey">Issuer key for the Service Bus URI</param>
        /// <returns>Access Control token</returns>
        private string GetAccessControlToken(string endpointUri, string issuerName, string issuerKey, string acsNamespace)
        {
            Status += "\nCalling ACS to recieve token"; 

            string acsAddress = GetAcsAddress(acsNamespace);
            string token = GetAcsToken(acsAddress, issuerName, issuerKey, endpointUri);
            Console.WriteLine(token);
            return token;
        }
        /// <summary>
        /// Get the ACS address from the ACS namespace
        /// </summary>
        /// <param name="acsNamespace">Represents ACS Namespace</param>
        /// <returns>ACS Address</returns>
        private string GetAcsAddress(string acsNamespace)
        {
            UriBuilder acsUri = new UriBuilder(Uri.UriSchemeHttps + "://" + acsNamespace + "." + ConfigurationManager.AppSettings["acsHost"]);
            return acsUri.ToString();
        }
        /// <summary>
        /// Gets the ACS token for the specified Service Bus URI
        /// </summary>
        /// <param name="acsAddress">Represents ACS address</param>
        /// <param name="issuerName">Issuer name for the specified Service Bus namespace</param>
        /// <param name="issuerKey">Issuer key for the specified Service Bus namespace</param>
        /// <param name="appliesToAddress">Represents Service Bus URI</param>
        /// <returns>ACS Token</returns>
        private string GetAcsToken(string acsAddress, string issuerName, string issuerKey, string appliesToAddress)
        {
            using (WebClient client = new WebClient())
            {
                client.BaseAddress = acsAddress;

                NameValueCollection values = new NameValueCollection();
                values.Add("wrap_name", issuerName);
                values.Add("wrap_password", issuerKey);
                values.Add("wrap_scope", appliesToAddress);

                byte[] responseBytes = client.UploadValues("WRAPv0.9/", "POST", values);

                string response = Encoding.UTF8.GetString(responseBytes);

                Status += "\nReceived token from ACS";

                // Extract the SWT token and return it.
                return response
                    .Split('&')
                    .Single(value => value.StartsWith("wrap_access_token=", StringComparison.OrdinalIgnoreCase))
                    .Split('=')[1];
            }
        }
        /// <summary>
        /// Sends message
        /// </summary>
        /// <param name="address">Represents the runtime address of the bridge end point</param>
        /// <param name="messageBytes">Represents the byte array of the message to be sent</param>
        /// <param name="token">Represents ACS token</param>
        /// <param name="contentType">Content type of the message</param>
        /// <returns>Success/Failure message of the Send operation</returns>
        private string SendMessageToBridge(string address, byte[] messageBytes, string token, string contentType)
        {

            Status += "\nCalling service at " + address;

            string response;
            WebClient webClient = new WebClient();
            webClient.Headers[HttpRequestHeader.Authorization] = "WRAP access_token=\"" + HttpUtility.UrlDecode(token) + "\"";
            webClient.Headers["Content-Type"] = contentType;

            System.Net.ServicePointManager.ServerCertificateValidationCallback =
                ((sender, certificate, chain, sslPolicyErrors) => true);

            byte[] uploadData = webClient.UploadData(address, "POST", messageBytes);
            response = Encoding.UTF8.GetString(uploadData);

            Status += "\nDone";
            if (!string.IsNullOrEmpty(response))
            {
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(response);
                var xPath = "/*[local-name()='Envelope' and namespace-uri()='http://www.w3.org/2003/05/soap-envelope']/*[local-name()='Body' and namespace-uri()='http://www.w3.org/2003/05/soap-envelope']";
                var xml = doc.SelectSingleNode(xPath);
                doc.LoadXml(xml.InnerXml);

                txtResponse.Text = IndentXml(doc);
            }
            else
                txtResponse.Text = "No response";

            btnCallWABS.IsEnabled = true;
            return response;
        }
        private string IndentXml(XmlDocument doc)
        {
            StringBuilder sb = new StringBuilder();
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = "  ";
            settings.NewLineChars = "\r\n";
            settings.NewLineHandling = NewLineHandling.Replace;
            using (XmlWriter writer = XmlWriter.Create(sb, settings))
            {
                doc.Save(writer);
            }
            return sb.ToString();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this,
                    new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
