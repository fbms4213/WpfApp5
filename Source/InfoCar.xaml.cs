using Source.Models;
using System.Windows;

namespace Source;

public partial class InfoCar : Window
{
    public Car? Car { get; set; }
    public InfoCar()
    {
        InitializeComponent();
        DataContext = this;
    }
}
