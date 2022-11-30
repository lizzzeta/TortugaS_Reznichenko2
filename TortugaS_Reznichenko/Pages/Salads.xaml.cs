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
using TortugaS_Reznichenko.BD;
using static TortugaS_Reznichenko.Classes.ClassEntities;
using TortugaS_Reznichenko.Classes;

namespace TortugaS_Reznichenko.Pages
{
    /// <summary>
    /// Логика взаимодействия для Salads.xaml
    /// </summary>
    public partial class Salads : Page
    {

        private MenuInterface menuInteface;

        public Salads(MenuInterface menuInterface)
        {
            InitializeComponent();
            this.menuInteface = menuInterface;

            lvSalads.ItemsSource = context.Dish.Where(i => i.IdCategory == 1).ToList();

        }

        private void btnOrder_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            if (button == null)
                return;
            var dish = button.DataContext as Dish;

            Basket.dishes.Add(dish);
            menuInteface.ChangeDishCount(Basket.dishes.Count);

        }
        
    }
}