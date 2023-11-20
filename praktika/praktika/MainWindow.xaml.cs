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
using System.IO;
using praktika.Entities;

namespace praktika
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var clientsData = File.ReadAllLines(@"C:\Users\PC_12\Desktop\Client.txt");
            for (int i = 0; i < clientsData.Count(); i++)
            {
                var currentClient = clientsData[i].Split('\t');
                var clientsForDb = new Client
                {
                    FirstName = currentClient[0],
                    LastName = currentClient[1],
                    Patronymic = currentClient[2],
                    Birthday = DateTime.Parse(currentClient[3]),
                    RegistrationDate = DateTime.Parse(currentClient[4]),
                    Email = currentClient[5],
                    Phone = currentClient[6],
                    GenderCode = currentClient[7],
                    PhotoPath = currentClient[8]
                };

                AppData.Context.Client.Add(clientsForDb);
                AppData.Context.SaveChanges();


               
            }
        }
    }

}