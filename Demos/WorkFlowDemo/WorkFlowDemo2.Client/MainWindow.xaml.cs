using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WorkFlowDemo2.Client
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            DocumentServiceReference.DocumentServiceClient proxy = new DocumentServiceReference.DocumentServiceClient();
            DocumentServiceReference.Document doc = new DocumentServiceReference.Document{
                DocumentId=txtDocId.Text,
                Content=txtContent.Text,
                Done = (bool)chbIsFinalVersion.IsChecked};
            DocumentServiceReference.DocumentResponse resp;

            if ((bool)chbIsNew.IsChecked)
            {
                resp = proxy.CreateDocument(doc);
                chbIsNew.IsChecked = false;
            }
            else
                resp = proxy.UpdateDocument(doc);

            txtStatus.Text = resp.Message;
        }
    }
}
