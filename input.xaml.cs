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
using System.Windows.Shapes;

namespace input_wpf
{
    /// <summary>
    /// input.xaml 的交互逻辑
    /// </summary>
    public partial class input : Window
    {
        public input()
        {
            InitializeComponent();
        }

        //声明一个string类型的属性
        public string InputValue { get; set; }

        //用户点击确定触发的事件
        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            //将input窗体的textbox中的内容赋值给InputValue属性
            InputValue = tb1.Text;

            //如果窗口是用ShowDialog打开的,用dialogresult,窗口自动关闭
            //而且还会把DialogResult的值通过ShowDialog的方法返回
            DialogResult = true;
        }

        //用户点击取消触发的事件
        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
