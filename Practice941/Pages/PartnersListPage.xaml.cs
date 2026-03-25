using System;
using System.Collections.Generic;
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
using Test942.Model;

namespace Test942.Pages
{
    /// <summary>
    /// Логика взаимодействия для PartnersListPage.xaml
    /// </summary>
    public partial class PartnersListPage : Page
    {
        public PartnersListPage()
        {
            InitializeComponent();
            PartnersLW.ItemsSource = ConnectionClass.comfortEntities.Partners.ToList();
        }
    }
}
