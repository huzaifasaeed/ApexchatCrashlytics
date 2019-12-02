using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using System;
using System.Text;
using Xamarin.Forms;

namespace ApexchatCrashlytics
{
    public partial class App : Application
    {
	   public App()
	   {
		  InitializeComponent();

		  MainPage = new MainPage();

	   }

	   protected override void OnStart()
	   {
		  // Handle when your app starts
		  DependencyService.Get<ICrashReporting>().CrashReportingInit();
		  DependencyService.Get<ICrashReporting>().CrashReportingMisc();

		  AppCenter.Start("android=207a126a-7b96-4f62-a9ca-a9aed884bb02;" +
			   "ios=2a36b0c7-9ed7-4dac-a956-fbf983bb2ee8",
			   typeof(Analytics), typeof(Crashes));

		  

		  Crashes.GetErrorAttachments = (ErrorReport report) =>
		    {
			   return new ErrorAttachmentLog[]
			   {
				  ErrorAttachmentLog.AttachmentWithText("Hello world!", "hello.txt"),
				  ErrorAttachmentLog.AttachmentWithBinary(Encoding.UTF8.GetBytes("Image"), "icon.png", "image/jpeg")
			   };
		    };


		  base.OnStart();
	   }

	   protected override void OnSleep()
	   {
		  // Handle when your app sleeps
	   }

	   protected override void OnResume()
	   {
		  // Handle when your app resumes
	   }
    }
}
