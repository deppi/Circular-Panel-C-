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

namespace CircularPanel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void addRectangleButton_Click(object sender, RoutedEventArgs e)
        {
            Rectangle exampleRectangle = new Rectangle(); // can probably refactor this some way
            exampleRectangle.Width = 75;
            exampleRectangle.Height = 75;
            SolidColorBrush myBrush = new SolidColorBrush(Colors.Red);
            exampleRectangle.Fill = myBrush;
            exampleRectangle.MouseUp += new MouseButtonEventHandler(Rectangle_MouseUp);
            myCircularPanel.addElement(exampleRectangle);
        }

        private void removeRectangleButton_Click(object sender, RoutedEventArgs e)
        {
            myCircularPanel.removeElement(); // remove selected element
        }

        private void Rectangle_MouseUp(object sender, MouseButtonEventArgs e) // should this be somewhere else?
        {
            myCircularPanel.selectRectangle((Rectangle)sender);
            e.Handled = true;
        }

        protected override void OnMouseUp(MouseButtonEventArgs e)
        {
            myCircularPanel.selectRectangle(null); // is this best?
            base.OnMouseUp(e);
        }
    }
}
