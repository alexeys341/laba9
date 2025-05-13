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

namespace lab9;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// Данный класс содержит методы, которые отвечают за нажатия кнопок в интерфейсе
/// Метод CheckCorrection1 проверяет корректность первого треугольника
/// Метод CheckCorrection2 проверяет корректность второго треугольника
/// Метод CalculatePerimetr1 считает периметр первого треугольника
/// Метод CalculatePerimetr2 считает периметр второго треугольника
/// Метод CalculateSquare1 считает площадь первого треугольника
/// Метод CalculateSquare2 считает площадь второго треугольника
/// Метод CompareSquares сравнивает площади треугольников
/// </summary>
public partial class MainWindow : Window
{
    private void CheckCorrection1(object sender, RoutedEventArgs e)
    {
        string sideAOfFirstTriangle = SideA1TextBox.Text;
        string sideBOfFirstTriangle = SideB1TextBox.Text;
        string sideCOfFirstTriangle = SideC1TextBox.Text;
        Triangles triangle1 = new Triangles();
        bool correct = triangle1.Check(sideAOfFirstTriangle, sideBOfFirstTriangle, sideCOfFirstTriangle);
        if (correct == false)
        {
            ResultTextBox.Clear();
            ResultTextBox.SelectedText = "Incorrect value or triangle doesn't exist";
        }
        else
        {
            ResultTextBox.Clear();
            ResultTextBox.SelectedText = "triangle exist";
        }
    }

    private void CheckCorrection2(object sender, RoutedEventArgs e)
    {
        string sideAOfSecondTriangle = SideA2TextBox.Text;
        string sideBOfSecondTriangle = SideB2TextBox.Text;
        string sideCOfSecondTriangle = SideC2TextBox.Text;
        Triangles triangle2 = new Triangles();
        bool correct = triangle2.Check(sideAOfSecondTriangle, sideBOfSecondTriangle, sideCOfSecondTriangle);
        if (correct == false)
        {
            ResultTextBox.Clear();
            ResultTextBox.SelectedText = "Incorrect value or triangle doesn't exist";
        }
        else
        {
            ResultTextBox.Clear();
            ResultTextBox.SelectedText  = "triangle exist";
        }
    }

    private void CalculatePerimetr1(object sender, RoutedEventArgs e)
    {
        string sideAOfFirstTriangle = SideA1TextBox.Text;
        string sideBOfFirstTriangle = SideB1TextBox.Text;
        string sideCOfFirstTriangle = SideC1TextBox.Text;
        Triangles triangle1 = new Triangles();
        bool correct = triangle1.Check(sideAOfFirstTriangle, sideBOfFirstTriangle, sideCOfFirstTriangle);
        if (correct == false)
        {
            ResultTextBox.Clear();
            ResultTextBox.SelectedText = "Incorrect value or triangle doesn't exist";
        }
        else
        {
            ResultTextBox.Clear();
            ResultTextBox.SelectedText = "Perimetr of first triangle is: " + triangle1.ToString(triangle1);
        }
    }

    private void CalculatePerimetr2(object sender, RoutedEventArgs e)
    {
        string sideAOfSecondTriangle = SideA2TextBox.Text;
        string sideBOfSecondTriangle = SideB2TextBox.Text;
        string sideCOfSecondTriangle = SideC2TextBox.Text;
        ResultTextBox.Clear();
        Triangles triangle2 = new Triangles();
        bool correct = triangle2.Check(sideAOfSecondTriangle, sideBOfSecondTriangle, sideCOfSecondTriangle);
        if (correct == false)
        {
            ResultTextBox.SelectedText = "Incorrect value or triangle doesn't exist";
        }
        else
        {
            ResultTextBox.SelectedText = "Perimetr of first triangle is: " + triangle2.ToString(triangle2);
        }
    }

    private void CalculateSquare1(object sender, RoutedEventArgs e)
    {
        string sideAOfFirstTriangle = SideA1TextBox.Text;
        string sideBOfFirstTriangle = SideB1TextBox.Text;
        string sideCOfFirstTriangle = SideC1TextBox.Text;
        ResultTextBox.Clear();
        Triangles triangle1 = new Triangles();
        bool correct = triangle1.Check(sideAOfFirstTriangle, sideBOfFirstTriangle, sideCOfFirstTriangle);
        if (correct == false)
        {
            ResultTextBox.SelectedText = "Incorrect value or triangle doesn't exist";
        }
        else
        {
            ResultTextBox.SelectedText = "Square of first triangle is: " + triangle1.ToString(-triangle1);
        }
    }

    private void CalculateSquare2(object sender, RoutedEventArgs e)
    {
        string sideAOfSecondTriangle = SideA2TextBox.Text;
        string sideBOfSecondTriangle = SideB2TextBox.Text;
        string sideCOfSecondTriangle = SideC2TextBox.Text;
        ResultTextBox.Clear();
        Triangles triangle2 = new Triangles();
        bool correct = triangle2.Check(sideAOfSecondTriangle, sideBOfSecondTriangle, sideCOfSecondTriangle);
        if (correct == false)
        {
            ResultTextBox.SelectedText = "Incorrect value or triangle doesn't exist";
        }
        else
        {
            ResultTextBox.SelectedText = "Square of second triangle is: " + triangle2.ToString(-triangle2);
        }
    }

    private void CompareSquares(object sender, RoutedEventArgs e)
    {
        string sideAOfSecondTriangle = SideA2TextBox.Text;
        string sideBOfSecondTriangle = SideB2TextBox.Text;
        string sideCOfSecondTriangle = SideC2TextBox.Text;
        Triangles triangle2 = new Triangles();
        bool correct1 = triangle2.Check(sideAOfSecondTriangle, sideBOfSecondTriangle, sideCOfSecondTriangle);//правильность первого треугольника

        ResultTextBox.Clear();

        string sideAOfFirstTriangle = SideA1TextBox.Text;
        string sideBOfFirstTriangle = SideB1TextBox.Text;
        string sideCOfFirstTriangle = SideC1TextBox.Text;
        Triangles triangle1 = new Triangles();

        bool correct2 = triangle1.Check(sideAOfFirstTriangle, sideBOfFirstTriangle, sideCOfFirstTriangle);//правильность второго треугольника
        if ((correct1 == false) || (correct2 == false))
        {
            ResultTextBox.SelectedText = "Incorrect value or triangle doesn't exist";
        }
        else
        {
            if (triangle1 > triangle2)
            {
                ResultTextBox.SelectedText = "First triangle have bigger square then second triangle";
            }
            else if (triangle1 < triangle2)
            {
                ResultTextBox.SelectedText = "Second triangle have bigger square then first triangle";
            }
            else
            {
                ResultTextBox.SelectedText = "triangles have equal squares";
            }
        }
    }
}