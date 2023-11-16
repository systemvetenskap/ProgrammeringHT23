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

namespace FL10
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Book book;
        public MainWindow()
        {
            InitializeComponent();
            InitializeBook();
        }

        private void InitializeBook()
        {
            book = new Book();

            Assignment assignment = new Assignment("22 a");
            Shape shape;

            shape = new Rectangle(7, 8);
            assignment.Shapes.Add(shape);

            shape = new Triangle(6, 8);
            assignment.Shapes.Add(shape);

            shape = new Square(10);
            assignment.Shapes.Add(shape);
            book.Assignments.Add(assignment);


            Assignment assignment2 = new Assignment("22 b");
            Shape shape2;

            shape2 = new Rectangle(7, 8);
            assignment2.Shapes.Add(shape2);

            shape2 = new Square(10);
            assignment2.Shapes.Add(shape2);
            book.Assignments.Add(assignment2);


        }




        private void button_Click(object sender, RoutedEventArgs e)
        {
            // en instans eller ett objekt
            int area;
             Rectangle rectangle = new Rectangle();
            
            area = rectangle.Area();

            Rectangle rectangle2 = new Rectangle
            {
                Width = 10,
                Height = 4,
            };
            area = rectangle2.Area();

            rectangle = new Rectangle(width: 12, height: 4);
            area = rectangle.Area();

            Triangle triangle = new Triangle(width: 6, height: 8);
            area = triangle.Area();
            //int area = rectangle.Height * rectangle.Width;
            //int area2 = rectangle2.Height * rectangle2.Width;

            Assignment assignment = book.Assignments[1];
            lstShapes.ItemsSource = null;
            lstShapes.ItemsSource = assignment.Shapes;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            
            Assignment assignment = book.Assignments[0];
            lstShapes.ItemsSource = assignment.Shapes;
            // visa  våra uppgifter, figurer i listboxen

            //int totalArea = assignment.TotalArea();
           


        }
    }
}
