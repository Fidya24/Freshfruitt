using FreshFruit.Controller;
using FreshFruit.Model;
using System.Windows;

namespace FreshFruit
{

    public partial class MainWindow : Window, BucketEventListener
    {
        private Seller Fidya;
        Fruit anggur = new Fruit("Anggur");
        Fruit appel = new Fruit("Appel");
        Fruit banana = new Fruit("Banana");
        Fruit Orange = new Fruit("Orange");

        public MainWindow()
        {
            InitializeComponent();
            Bucket keranjangBuah = new Bucket(4);
            BucketController bucketController = new BucketController(keranjangBuah, this);

            Mardi = new Seller("Fidya", bucketController);

            ListBoxBucket.ItemsSource = keranjangBuah.findAll();

        }

        private void OnButtonAddAnggurClicked(object sender, RoutedEventArgs e)
        {
            Fidya.addFruit(anggur);
        }

        private void OnButtonAddApelClicked(object sender, RoutedEventArgs e)
        {
            Fidya.addFruit(appel);
        }

        private void OnButtonAddPisangClicked(object sender, RoutedEventArgs e)
        {
            Fidya.addFruit(banana);
        }

        private void OnButtonAddJerukClicked(object sender, RoutedEventArgs e)
        {
            Fidya.addFruit(Orange);
        }
        private void OnButtonClearClicked(object sender, RoutedEventArgs e)
        {
            Fidya.removeFruit(anggur);
            Fidya.removeFruit(apel);
            Fidya.removeFruit(banana);
            Fidya.removeFruit(Orange);
        }
        public void onSucceed(string message)
        {
            ListBoxBucket.Items.Refresh();
        }

        public void onFailed(string message)
        {
            MessageBox.Show(message, "Warning !");
        }


    }
}
