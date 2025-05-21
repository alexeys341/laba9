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
        bool range = triangle1.Check2(sideAOfFirstTriangle, sideBOfFirstTriangle, sideCOfFirstTriangle);
        if (range == false)
        {
            ResultTextBox.SelectedText = "Value is out of range";
        }
        else if (correct == false)
        {
            ResultTextBox.Clear();
            ResultTextBox.SelectedText = "Incorrect value or triangle doesn't exist";
        }
        else
        {
            ResultTextBox.Clear();
            ResultTextBox.SelectedText = "Triangle exist";
        }
    }

    private void CheckCorrection2(object sender, RoutedEventArgs e)
    {
        string sideAOfSecondTriangle = SideA2TextBox.Text;
        string sideBOfSecondTriangle = SideB2TextBox.Text;
        string sideCOfSecondTriangle = SideC2TextBox.Text;
        Triangles triangle2 = new Triangles();
        bool correct = triangle2.Check(sideAOfSecondTriangle, sideBOfSecondTriangle, sideCOfSecondTriangle);
        bool range = triangle2.Check2(sideAOfSecondTriangle, sideBOfSecondTriangle, sideCOfSecondTriangle);
        if (range == false)
        {
            ResultTextBox.SelectedText = "Value is out of range";
        }
        else if (correct == false)
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
        bool range = triangle1.Check2(sideAOfFirstTriangle, sideBOfFirstTriangle, sideCOfFirstTriangle);
        if (range == false)
        {
            ResultTextBox.SelectedText = "Value is out of range";
        }
        else if (correct == false)
        {
            ResultTextBox.Clear();
            ResultTextBox.SelectedText = "Incorrect value or triangle doesn't exist";
        }
        else
        {
            ResultTextBox.Clear();
            ResultTextBox.SelectedText = "The perimetr of first triangle is: " + triangle1.ToString(triangle1);
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
        bool range = triangle2.Check2(sideAOfSecondTriangle, sideBOfSecondTriangle, sideCOfSecondTriangle);
        if (range == false)
        {
            ResultTextBox.SelectedText = "Value is out of range";
        }
        else if (correct == false)
        {
            ResultTextBox.SelectedText = "Incorrect value or triangle doesn't exist";
        }
        else
        {
            ResultTextBox.SelectedText = " The perimetr of first triangle is: " + triangle2.ToString(triangle2);
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
        bool range = triangle1.Check2(sideAOfFirstTriangle, sideBOfFirstTriangle, sideCOfFirstTriangle);
        bool overflow = triangle1.Check3(sideAOfFirstTriangle, sideBOfFirstTriangle, sideCOfFirstTriangle);
        if (overflow == false)
        {
            ResultTextBox.SelectedText = "Area is really big, we can't count it";
        }
        else if(range == false)
        {
            ResultTextBox.SelectedText = "Value is out of range";
        }
        else if (correct == false)
        {
            ResultTextBox.SelectedText = "Incorrect value or triangle doesn't exist";
        }
        else
        {
            ResultTextBox.SelectedText = "The area of first triangle is: " + triangle1.ToString(-triangle1);
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
        bool range = triangle2.Check2(sideAOfSecondTriangle, sideBOfSecondTriangle, sideCOfSecondTriangle);
        bool overflow = triangle2.Check3(sideAOfSecondTriangle, sideBOfSecondTriangle, sideCOfSecondTriangle);
        if (overflow == false)
        {
            ResultTextBox.SelectedText = "Area is really big, we can't count it";
        }
        else if(range == false)
        {
            ResultTextBox.SelectedText = "Value is out of range";
        }
        else if (correct == false)
        {
            ResultTextBox.SelectedText = "Incorrect value or triangle doesn't exist";
        }
        else
        {
            ResultTextBox.SelectedText = "The area of second triangle is: " + triangle2.ToString(-triangle2);
        }
    }

    private void CompareSquares(object sender, RoutedEventArgs e)
    {
        string sideAOfSecondTriangle = SideA2TextBox.Text;
        string sideBOfSecondTriangle = SideB2TextBox.Text;
        string sideCOfSecondTriangle = SideC2TextBox.Text;
        Triangles triangle2 = new Triangles();
        bool correct1 = triangle2.Check(sideAOfSecondTriangle, sideBOfSecondTriangle, sideCOfSecondTriangle);//правильность первого треугольника
        bool range1 = triangle2.Check2(sideAOfSecondTriangle, sideBOfSecondTriangle, sideCOfSecondTriangle);
        bool overflow2 = triangle2.Check3(sideAOfSecondTriangle, sideBOfSecondTriangle, sideCOfSecondTriangle);

        ResultTextBox.Clear();

        string sideAOfFirstTriangle = SideA1TextBox.Text;
        string sideBOfFirstTriangle = SideB1TextBox.Text;
        string sideCOfFirstTriangle = SideC1TextBox.Text;
        Triangles triangle1 = new Triangles();

        bool correct2 = triangle1.Check(sideAOfFirstTriangle, sideBOfFirstTriangle, sideCOfFirstTriangle);//правильность второго треугольника
        bool range2 = triangle1.Check2(sideAOfFirstTriangle, sideBOfFirstTriangle, sideCOfFirstTriangle);
        bool overflow1 = triangle1.Check3(sideAOfFirstTriangle, sideBOfFirstTriangle, sideCOfFirstTriangle);
        if ((overflow1 == false)||(overflow2 == false))
        {
            ResultTextBox.SelectedText = "One of the area is really big, we can't count it";
        }
        else if ((range2 == false)||(range1 == false))
        {
            ResultTextBox.SelectedText = "Value is out of range";
        }
        else if ((correct1 == false) || (correct2 == false))
        {
            ResultTextBox.SelectedText = "Incorrect value or triangle doesn't exist";
        }
        else
        {
            if (triangle1 > triangle2)
            {
                ResultTextBox.SelectedText = "The area of ​​the first triangle is greater than the area of ​​the second triangle";
            }
            else if (triangle1 < triangle2)
            {
                ResultTextBox.SelectedText = "The area of ​​the second triangle is greater than the area of ​​the first triangle";
            }
            else
            {
                ResultTextBox.SelectedText = "triangles have equal squares";
            }
        }
    }
}