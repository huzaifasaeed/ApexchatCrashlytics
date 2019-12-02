using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace ApexchatCrashlytics
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    public partial class MainPage : ContentPage
    {
	   public MainPage()
	   {
		  InitializeComponent();
	   }

	   private void ReportError_clicked(object sender, EventArgs e)
	   {
		  Exception exception = new Exception("test error");

		  var properties = new Dictionary<string, string>
		  {
			 { "Category", "Chat" },
			 { "Wifi", "On"}
		  };
		  Crashes.TrackError(exception, properties);
		  Analytics.TrackEvent("test event");
		  AppCenterLog.Info("Test Log", "Sending error report");

		  DependencyService.Get<ICrashReporting>().LogException();

	   }
	   private void ForceCrash_clicked(object sender, EventArgs e)
	   {
		  Crashes.GenerateTestCrash();
		  DependencyService.Get<ICrashReporting>().ForceCrash();
	   }
    }
}
