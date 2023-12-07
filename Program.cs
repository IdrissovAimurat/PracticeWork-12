using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeWork
{
    /// <summary>
    /// Создать интерфейс, который уведомляет пользователя программы об изменении значений свойства в классе 
    /// (в котором реализуется данный интерфейс). 
    /// Сигнатура интерфейса:
    /// </summary>

    public delegate void PropertyEventHandler(object sender, PropertyEventArgs e);

    public class PropertyEventArgs : EventArgs
    {
        public string PropertyName { get; }

        public PropertyEventArgs(string propertyName)
        {
            PropertyName = propertyName;
        }
    }

    public interface IPropertyChanged
    {
        event PropertyEventHandler PropertyChanged;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
                     MyClass myObject = new MyClass();

            myObject.PropertyChanged += HandlePropertyChanged;

                        myObject.Name = "Новое значение";
        }


        static void HandlePropertyChanged(object sender, PropertyEventArgs e)
        {
            Console.WriteLine($"Свойство {e.PropertyName} было изменено.");
        }
    }
}
