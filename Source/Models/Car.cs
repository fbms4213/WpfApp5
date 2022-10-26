using System.ComponentModel;

namespace Source.Models;


public class Car
{
    public string? Make { get; set; }
    public string? Model { get; set; }
    public int? Year { get; set; }
}





//public class Car : INotifyPropertyChanged
//{
//    public string? Make { get; set; }
//    public string? Model { get; set; }


//    private int year;


//    public int Year
//    {
//        get { return year; }
//        set 
//        { 
//            year = value;
//            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Year)));
//        }
//    }


//    public event PropertyChangedEventHandler? PropertyChanged;
//}