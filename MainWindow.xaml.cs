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

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            //vs自带的messagebox小窗口
            //第一个参数:显示的文本
            //第二个参数:窗口标题
            //第三个窗口:窗口按钮(为枚举值,为OK,Cancel,OKCancel)
            //如何看用户点击的是确定还是取消?  答案:show的对话框也有返回值
            MessageBoxResult msr = MessageBox.Show("确定还是取消?", "提示", MessageBoxButton.OKCancel);

            //判断用户点击的结果
            if (msr == MessageBoxResult.OK)
            {
                MessageBox.Show("确定");
            }
            else if (msr == MessageBoxResult.Cancel)
            {
               MessageBox.Show("取消");
            }


            //弹出对话框询问用户是否执行删除操作
            MessageBoxResult msr2 = MessageBox.Show("确定要删除?", "警告", MessageBoxButton.YesNoCancel);

            //判断用户点击的结果
            if (msr2==MessageBoxResult.Yes)
            {
                MessageBox.Show("删除");
            }
            else if (msr2==MessageBoxResult.No)
            {
                MessageBox.Show("不删除");
            }
            else if (msr2==MessageBoxResult.Cancel)
            {
                MessageBox.Show("取消选择");
            }
            

        }
    }
}
