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

namespace projects;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{

    public MainWindow()
    {
        InitializeComponent();
        this.Title = App.APP_NAME + " - " + App.APP_VERSION;
    }

    private void NewFile_Click(object sender, RoutedEventArgs e)
    {
        MessageBox.Show("新規作成がクリックされました。");
    }

    private void OpenFile_Click(object sender, RoutedEventArgs e)
    {
        MessageBox.Show("開くがクリックされました。");
    }

    private void Exit_Click(object sender, RoutedEventArgs e)
    {
        this.Close();
    }

    private void About_Click(object sender, RoutedEventArgs e)
    {
        MessageBox.Show("バージョン：" + App.APP_VERSION);
    }
}