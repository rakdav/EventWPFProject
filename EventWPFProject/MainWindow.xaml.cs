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

namespace EventWPFProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // button.Click += new RoutedEventHandler(Button_Click);
           // button.AddHandler(Button.ClickEvent, new RoutedEventHandler(Button_Click));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            lb.Items.Clear();
        }

        private void SomeOne_MouseDown(object sender, MouseButtonEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Sender: " + sender);
            sb.AppendLine("Source: " + e.Source);
            sb.AppendLine("OriginalSource: " + e.OriginalSource);
            sb.AppendLine("RoutedEvent: " + e.RoutedEvent);
            lb.Items.Add(sb.ToString());
            e.Handled = cb.IsChecked.Value;
        }
        private void StackPanel_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Кликнули на какой-то кнопочке внути StackPanel. Обработали событие на уровне StackPanel, у которой нет события Click");
            sb.AppendLine("Sender: " + sender);
            sb.AppendLine("Source: " + e.Source);
            sb.AppendLine("OriginalSource: " + e.OriginalSource);
            sb.AppendLine("RoutedEvent: " + e.RoutedEvent);
            MessageBox.Show(sb.ToString());
        }
    }
}
