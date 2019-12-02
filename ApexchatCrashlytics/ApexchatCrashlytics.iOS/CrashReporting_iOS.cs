using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Firebase.Crashlytics;
using Foundation;
using UIKit;

namespace ApexchatCrashlytics.iOS
{
    public class CrashReporting_iOS : ICrashReporting
    {
	   /// <summary>
	   /// Crashalytics reporting initialize 
	   /// </summary>
	   /// <returns><c>true</c>, if reporting init failed, <c>false</c> otherwise worked OK.</returns>
	   public bool CrashReportingInit()
	   {
		  try
		  {
			 Firebase.Core.App.Configure();

			 Crashlytics.Configure();
			 //Fabric.Fabric.SharedSdk.Debug = true;

			 Fabric.Fabric.With(typeof(Crashlytics));
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
	   /// Not needed on iOS.
	   /// </summary>
	   /// <returns><c>false</c>.</returns>
	   public bool CrashReportingMisc()
	   {
		  return false;
	   }
	   public void LogException()
	   {
		  NSString nsString = new NSString("This is an error log - ios");
		  NSError error = new NSError(nsString, 1);
		  Crashlytics.SharedInstance.RecordError(error);

	   }

	   /// <summary>
	   /// Forces an application crash 
	   /// </summary>
	   public void ForceCrash()
	   {
		  try
		  {
			 try
			 {
				throw new ApplicationException("This is a forced crash - iOS");
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