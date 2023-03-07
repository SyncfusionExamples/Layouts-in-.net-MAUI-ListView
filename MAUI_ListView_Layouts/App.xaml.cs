using System.ComponentModel;

namespace MAUI_ListView_Layouts;

public partial class App : Application
{
	public App()
	{
		InitializeComponent(); 
        MainPage = new AppShell();
	}
}
