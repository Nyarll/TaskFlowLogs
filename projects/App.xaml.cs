using System.Configuration;
using System.Data;
using System.Windows;

namespace projects;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    public static readonly string APP_NAME = "Task Flow Logs";
    private static readonly int MajorVersion = 0;
    private static readonly int MinorVersion = 0;
    private static readonly int BuildVersion = 1;
    private static readonly string SubVersion = "develop";
    public static readonly string APP_VERSION = MajorVersion.ToString() + "." + MinorVersion.ToString() + "." + BuildVersion.ToString() + "-" + SubVersion.ToString();

}

