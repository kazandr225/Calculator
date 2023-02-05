using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp1
{
    public static class Model
    {
        //блок с данными
        public static List<string> datalist = new List<string> {"Сложение", "Вычитание", "Деление", "Умножение"};
        public static List<string> dataSymb = new List<string> { "+", "-", "*", "/" };

        //блок для обращения к текстовым полям
        public static TextBlock tb;
        public static TextBlock tbCbx;
        public static TextBlock tbSymb;

        public static TextBox first;
        public static TextBox second;
        public static TextBox result;


        //блок с бизнес-логикой
        public static int Combx //свойство для отображения вида арифметической операции
        {
            set 
            {
                tbSymb.Text = dataSymb[value];
            }
        }

        public static void calculations(int choice) //вычисление
        {
            double firstnum = Double.Parse(first.Text); //для поля первого числа
            double secondnum = Double.Parse(second.Text);//для поля второго числа

            double calcresult; //для результата

            switch (choice) //зависит от выбранной операции
            {
                case 0:
                    calcresult = firstnum + secondnum;
                    result.Text = Convert.ToString(calcresult);
                    break;

                case 1:
                    calcresult = firstnum - secondnum;
                    result.Text = Convert.ToString(calcresult);
                    break;

                case 2:
                    calcresult = firstnum * secondnum;
                    result.Text = Convert.ToString(calcresult);
                    break;

                case 3:
                    calcresult = firstnum / secondnum;
                    if (firstnum == 0 || secondnum == 0) //проверка на ноль
                    {
                        MessageBox.Show("Нельзя делить на ноль");
                    }
                    else
                        result.Text = Convert.ToString(calcresult);
                    break;
            }
        }
    }
}
