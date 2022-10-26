using Source.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Source;

// DependencyProperty
// INotifyPropertyChanged

public partial class MainWindow : Window, INotifyPropertyChanged
{

    // public string SomeText { get; set; } = "Hello WPF";



    //public string SomeText
    //{
    //    get { return (string)GetValue(SomeTextProperty); }
    //    set { SetValue(SomeTextProperty, value); }
    //}

    //public static readonly DependencyProperty SomeTextProperty =
    //    DependencyProperty.Register("SomeText", typeof(string), typeof(MainWindow));





    private string? someText;
    public string? SomeText
    {
        get => someText;
        set
        {
            someText = value;
            // NotifyPropertyChanged(nameof(SomeText));
            NotifyPropertyChanged();
        }
    }









    public Car Car { get; set; }
    // public List<Car> Cars { get; set; }
    public ObservableCollection<Car> Cars { get; set; }




    //private List<Car> cars;

    //public List<Car> Cars
    //{
    //    get { return cars; }
    //    set
    //    {
    //        cars = value;
    //        NotifyPropertyChanged();
    //    }
    //}





    //public List<Car> Cars
    //{
    //    get { return (List<Car>)GetValue(CarsProperty); }
    //    set { SetValue(CarsProperty, value); }
    //}

    //public static readonly DependencyProperty CarsProperty =
    //    DependencyProperty.Register("Cars", typeof(List<Car>), typeof(MainWindow));







    public MainWindow()
    {
        InitializeComponent();
        DataContext = this;



        Car = new()
        {
            Make = "BMW",
            Model = "X6",
            Year = 2022
        };



        Cars = new()
        {
            new()
            {
                Make = "BMW",
                Model = "X6",
                Year = 2022
            },
            new()
            {
                Make = "Mersedes",
                Model = "Maybach",
                Year = 2021
            }
        };



    }










    private void ChangeBackColor(object sender, RoutedEventArgs e)
    {
        // grid.Resources["primaryBtnColor"] = Brushes.Red;
        Resources["primaryBtnColor"] = Brushes.Red;
    }



    private void Button_Click(object sender, RoutedEventArgs e)
    {
        SomeText += 'a';
        // MessageBox.Show(SomeText);
    }




    private void ListBox_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
    {
        var listBox = sender as ListBox;

        if (listBox is null)
            return;



        Car? selectedCar = listBox.SelectedItem as Car;

        if (selectedCar is null)
            return;



        InfoCar? infoCar = new();
        infoCar.Car = selectedCar;

        infoCar.ShowDialog();



        //selectedCar.Year = 2000;
        //MessageBox.Show(selectedCar.Year.ToString());
    }



    private void AddCar(object sender, RoutedEventArgs e)
    {

        Cars.Add(
                new()
                {
                    Make = "Kia",
                    Model = "Cerato",
                    Year = 2013
                }
            );


       //  NotifyPropertyChanged(nameof(Cars));
    }






    public event PropertyChangedEventHandler? PropertyChanged;
    private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SomeText)));


}