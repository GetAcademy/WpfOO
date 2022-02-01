using System;
using System.Windows;
using System.Windows.Controls;

namespace WpfOO
{
    internal class Program
    {
        //private static int _counter = 0;
        //private static Label _label;

        [STAThread]
        public static void Main(string[] args)
        {
            var application = new Application();
            var window = new Window();

            var panel1 = new ClickerPanel();
            var panel2 = new ClickerPanel();
            var panel3 = new ClickerPanel();
            var panel4 = new ClickerPanel();
            var panel5 = new ClickerPanel();

            //var button = new Button {Content = "Trykk her"};
            //_label = new Label {Content = "0"};

            //button.Click += ButtonClick;

            //var panel = new StackPanel();
            //panel.Children.Add(button);
            //panel.Children.Add(_label);

            //window.Content = panel;

            var panel = new StackPanel();
            panel.Children.Add(panel1);
            panel.Children.Add(panel2);
            panel.Children.Add(panel3);
            panel.Children.Add(panel4);
            panel.Children.Add(panel5);

            window.Content = panel;

            application.Run(window);
        }

        //private static void ButtonClick(object sender, RoutedEventArgs e)
        //{
        //    _counter++;
        //    _label.Content = _counter;
        //}
    }
}
