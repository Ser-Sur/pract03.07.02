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

namespace pract03._07
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CargoShip ship = new CargoShip();
        CargoShip thisShip = new CargoShip();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (Int32.TryParse(tbLoadCapacity.Text, out int loadC) && loadC > 0 && tbName.Text != null)
            {
                ship = new CargoShip(tbName.Text, loadC);
                lbShipsList.Items.Add(ship.ToString());
                tbLoadCapacity.Text = null;
                tbName.Text = null;
            }
            else MessageBox.Show("Введите корректные данные!!!");
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (lbShipsList.SelectedIndex != -1)
            {
                lbShipsList.Items.Remove(lbShipsList.SelectedItem);
            }
            else MessageBox.Show("Выберите элемент для удаления!!!");
        }

        private void btnClone_Click(object sender, RoutedEventArgs e)
        {
            if (thisShip != null)
            {
                CargoShip cS = new CargoShip();
                cS = (CargoShip)thisShip.Clone();
                lbShipsList.Items.Add(cS.ToString());
                thisShip = null;
            }
            else MessageBox.Show("Выберите элемент для копирования!!!");
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnCompare_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnInfo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Работа с объектами через интерфейсы\nАртемкин М. ИСП-31 Практическая работа №7\nСоздать интерфейсы - корабль, грузовой транспорт. \nСоздать класс грузовой корабль. \nКласс должен включать конструктор, функцию для формирования строки информации о корабле. \nСравнение производить по грузоподъемности.");
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void lbLCS(object sender, SelectionChangedEventArgs e)
        {
            if (lbShipsList.SelectedIndex != -1) thisShip = (CargoShip)lbShipsList.SelectedItem;
        }
    }
}