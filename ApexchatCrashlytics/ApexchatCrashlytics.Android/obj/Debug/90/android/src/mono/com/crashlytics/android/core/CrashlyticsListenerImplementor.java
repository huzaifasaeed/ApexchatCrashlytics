package mono.com.crashlytics.android.core;


public class CrashlyticsListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.crashlytics.android.core.CrashlyticsListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_crashlyticsDidDetectCrashDuringPreviousExecution:()V:GetCrashlyticsDidDetectCrashDuringPreviousExecutionHandler:Crashlytics.Core.ICrashlyticsListenerInvoker, Xamarin.Android.Crashlytics.Core\n" +
			"";
		mono.android.Runtime.register ("Crashlytics.Core.ICrashlyticsListenerImplementor, Xamarin.Android.Crashlytics.Core", CrashlyticsListenerImplementor.class, __md_methods);
	}


	public CrashlyticsListenerImplementor ()
	{
		super ();
		if (getClass () == CrashlyticsListenerImplementor.class)
			mono.android.TypeManager.Activate ("Crashlytics.Core.ICrashlyticsListenerImplementor, Xamarin.Android.Crashlytics.Core", "", this, new java.lang.Object[] {  });
	}


	public void crashlyticsDidDetectCrashDuringPreviousExecution ()
	{
		n_crashlyticsDidDetectCrashDuringPreviousExecution ();
	}

	private native void n_crashlyticsDidDetectCrashDuringPreviousExecution ();

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
