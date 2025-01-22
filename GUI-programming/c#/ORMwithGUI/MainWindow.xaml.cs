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
using ORMwithGUI.Models;
using ORMwithGUI.Utils;

namespace ORMwithGUI;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private ProductDbContext _db = new ProductDbContext();
    public MainWindow()
    {
        InitializeComponent();
        LoadData();

    }

    private void LoadData()
    {
        productGrid.ItemsSource = _db.Products.ToList();
    }


}