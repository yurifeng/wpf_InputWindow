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

namespace input_wpf
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //主窗体的按钮点击触发的事件
        //弹出input窗体
        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            input ip = new input();
            bool? b = ip.ShowDialog();
            if (b==null)
            {
                MessageBox.Show("你未进行任何操作....");
            }
            else if (b==true)
            {
                MessageBox.Show("确定: " + ip.InputValue);
            }
            else
            {
                MessageBox.Show("取消..");
            }
            
        }
    }
}
