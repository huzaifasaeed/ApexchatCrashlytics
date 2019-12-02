using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace ApexchatCrashlytics.Droid
{
    public class CrashReporting_Android : ICrashReporting
    {
	   /// <summary>
	   /// Crashalytics reporting initialize 
	   /// </summary>
	   /// <returns><c>true</c>, if reporting init failed, <c>false</c> otherwise worked OK.</returns>
	   public bool CrashReportingInit()
	   {
		  try
		  {
			 var context = Android.App.Application.Context;
			 Fabric.Fabric.With(context, new Crashlytics.Crashlytics());
		  }
		  catch (Exception exception)
		  {
			 System.Diagnostics.Debug.WriteLine("CrashReportingInit - " +
								" failed - " + exception.Message);
			 return true;
		  }

		  return false;
	   }

	   /// <summary>
	   /// Sets Misc options for crash reporting
	   /// </summary>
	   /// <returns><c>true</c>, if reporting misc failed, <c>false</c> otherwise worked OK.</returns>
	   public bool CrashReportingMisc()
	   {
		  try
		  {
			 // Optional: Setup Xamarin / Mono Unhandled exception parsing / handling
			 Crashlytics.Crashlytics.HandleManagedExceptions();

			 Crashlytics.Crashlytics.SetUserIdentifier("118");
			 Crashlytics.Crashlytics.SetUserIdentifier("huzaifa.saeed@apexchat.com");
			 Crashlytics.Crashlytics.SetUserName("Huzaifa Saeed");

			 //CrashReportingMisc = true;
		  }
		  catch (Exception exception)
		  {
			 System.Diagnostics.Debug.WriteLine("CrashReportingMisc - " +
								" failed - " + exception.Message);
			 return true;
		  }

		  return false;
	   }
	   public static async Task GetRequestAsync(Uri uri) {
            try {
                using (var client = new HttpClient()) {
                    using (var requestMessage = new HttpRequestMessage(HttpMethod.Get, uri)) {
                        using (var responseMessage = await client.SendAsync(requestMessage)) {
                            var stringResponse = await responseMessage.Content.ReadAsStringAsync();

                            return;
                        }
                    }
                }
            } catch (Exception exception) {
                Console.WriteLine(exception.StackTrace);
                throw exception;
            }
        }

	   public void LogException()
	   {
		  var uri = new Uri("https://www.google.com/");
		  GetRequestAsync(uri).ContinueWith(task => {
			 if (task.IsFaulted)
			 {
				    Toast.MakeText(Application.Context, "Call failed", ToastLength.Long).Show();

				return;
			 }
				Toast.MakeText(Application.Context, "Call succeeded", ToastLength.Long).Show();
		  });
		  Crashlytics.Crashlytics.Log(1, "error log", "This is an error log - android");

	   }
	   /// <summary>
	   /// Forces an application crash 
	   /// </summary>
	   public void ForceCrash()
	   {
		  //Crashlytics.Crashlytics.Instance.Crash();

		  try
		  {
			 try
			 {

				throw new ApplicationException("This is a forced crash - ANDROID");
			 }
			 catch (System.Exception e1)
			 {
				throw new InvalidCastException("Level 1", e1);
			 }
		  }
		  catch (System.Exception e2)
		  {
			 throw new InvalidCastException("Level 2", e2);
		  }

	   }
    }
}