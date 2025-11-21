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

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (Int32.TryParse(tbLoadCapacity.Text, out int loadC) && loadC > 0 && tbName.Text != null)
            {
                ship = new CargoShip(tbName.Text, loadC);
                lbShipsList.Items.Add(ship);
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
            if ( lbShipsList.SelectedItems.Count == 1)
            {
                CargoShip selectedShip = (CargoShip)lbShipsList.SelectedItem;
                CargoShip cS = (CargoShip)selectedShip.Clone();
                lbShipsList.Items.Add(cS);
            }
            else MessageBox.Show("Выберите ОДИН элемент для копирования!!!");
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            tbDifference.Clear();
            tbLoadCapacity.Clear();
            tbName.Clear();
            lbShipsList.Items.Clear();
            ship.Clear();
        }

        private void btnCompare_Click(object sender, RoutedEventArgs e)
        {
            if (lbShipsList.SelectedItems.Count == 2)
            {
                CargoShip cS1 = (CargoShip)lbShipsList.SelectedItems[0];
                CargoShip cS2 = (CargoShip)lbShipsList.SelectedItems[1];

                tbDifference.Text = cS1.CompareTo(cS2);
            }
            else if (lbShipsList.SelectedItems.Count != 0) MessageBox.Show("Сравнить можно только ДВА корабля ;)");
            else MessageBox.Show("Выберите корабли для сравнения, лады?)");
        }

        private void btnInfo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Работа с объектами через интерфейсы\nАртемкин М. ИСП-31 Практическая работа №7\n\nСоздать интерфейсы - корабль, грузовой транспорт. \nСоздать класс грузовой корабль. \nКласс должен включать конструктор, функцию для формирования строки информации о корабле. \nСравнение производить по грузоподъемности.");
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}