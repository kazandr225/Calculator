using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfApp1
{
    public static class Model
    {
        //блок с данными
        static string symb = "+";
        public static List<string> datalist = new List<string> {"Сложение", "Вычитание", "Деление", "Умножение"};


        //блок для обращения к текстовым полям
        public static TextBlock tb;
        public static TextBlock tbCbx;

        public static TextBox first;
        public static TextBox second;
        public static TextBox result;

        //блок с бизнес-логикой

        public static string Symb //свойство для отоброжения знака в TextBlock
        {
            get 
            {
                return symb;
            }
            set
            { 
                symb = value;
                tb.Text = symb;
            }
        }
        public static int Combx //свойство для отображения вида арифметической операции
        {
            set 
            {
                tbCbx.Text = datalist[value];
            }
        }
    }
}
