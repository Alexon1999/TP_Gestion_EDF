using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ClasseMetier;
using Newtonsoft.Json;

namespace Interface
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        GestionnaireEDF gst;

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            gst = new GestionnaireEDF();
            StreamReader sr = new StreamReader("Datas/LesControleurs.txt");
            string flux = sr.ReadToEnd();
            gst.LesControleurs = JsonConvert.DeserializeObject<List<Controleur>>(flux);
            lstControleurs.ItemsSource = gst.GetAllControleur();
            txtNbtotalClients.Text = gst.NumberTotalofClients().ToString();
            txtNouveauClients.Text = gst.NumberofNewClients().ToString();
            
        }

        private void lstControleurs_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(lstControleurs.SelectedItem != null)
            {
                lstClients.ItemsSource = gst.GetAllClientsByControleur((lstControleurs.SelectedItem as Controleur).IdControleur);
                txtNbclientsparControleurs.Text = gst.NumberofClientsByControleur((lstControleurs.SelectedItem as Controleur).IdControleur).ToString();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if(txtNouveauReleve.Text == "" || lstClients.SelectedItem == null )
            {
                MessageBox.Show("Il y a r dans nouveau relevé ou vous n'avez pas selectionné un client","Erreur" , MessageBoxButton.OK,MessageBoxImage.Error);
            }
            else
            {

                //int.Parse((txtNouveauReleve.Text).Trim())

                lstClients.Items.Refresh();
                gst.UpdateCompteur((lstClients.SelectedItem as Client).IdCompteur, Convert.ToInt16(txtNouveauReleve.Text));
            }

            //lstClients.Items.Refresh();
            //lstClients.ItemsSource = null;

        }
    }
}
