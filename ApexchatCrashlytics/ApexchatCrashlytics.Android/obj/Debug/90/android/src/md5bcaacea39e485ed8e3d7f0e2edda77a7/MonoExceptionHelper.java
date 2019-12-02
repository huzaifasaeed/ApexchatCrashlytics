package md5bcaacea39e485ed8e3d7f0e2edda77a7;


public class MonoExceptionHelper
	extends md5bcaacea39e485ed8e3d7f0e2edda77a7.MonoException
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Crashlytics.MonoExceptionHelper, Xamarin.Android.Crashlytics", MonoExceptionHelper.class, __md_methods);
	}


	public MonoExceptionHelper ()
	{
		super ();
		if (getClass () == MonoExceptionHelper.class)
			mono.android.TypeManager.Activate ("Crashlytics.MonoExceptionHelper, Xamarin.Android.Crashlytics", "", this, new java.lang.Object[] {  });
	}


	public MonoExceptionHelper (java.lang.String p0)
	{
		super (p0);
		if (getClass () == MonoExceptionHelper.class)
			mono.android.TypeManager.Activate ("Crashlytics.MonoExceptionHelper, Xamarin.Android.Crashlytics", "System.String, mscorlib", this, new java.lang.Object[] { p0 });
	}


	public MonoExceptionHelper (java.lang.String p0, java.lang.Throwable p1)
	{
		super (p0, p1);
		if (getClass () == MonoExceptionHelper.class)
			mono.android.TypeManager.Activate ("Crashlytics.MonoExceptionHelper, Xamarin.Android.Crashlytics", "System.String, mscorlib:Java.Lang.Throwable, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public MonoExceptionHelper (java.lang.Throwable p0)
	{
		super (p0);
		if (getClass () == MonoExceptionHelper.class)
			mono.android.TypeManager.Activate ("Crashlytics.MonoExceptionHelper, Xamarin.Android.Crashlytics", "Java.Lang.Throwable, Mono.Android", this, new java.lang.Object[] { p0 });
	}

	public MonoExceptionHelper (java.lang.String p0, java.lang.StackTraceElement[] p1)
	{
		super ();
		if (getClass () == MonoExceptionHelper.class)
			mono.android.TypeManager.Activate ("Crashlytics.MonoExceptionHelper, Xamarin.Android.Crashlytics", "System.String, mscorlib:Java.Lang.StackTraceElement[], Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}

	public MonoExceptionHelper (java.lang.String p0, java.lang.StackTraceElement[] p1, java.lang.Throwable p2)
	{
		super ();
		if (getClass () == MonoExceptionHelper.class)
			mono.android.TypeManager.Activate ("Crashlytics.MonoExceptionHelper, Xamarin.Android.Crashlytics", "System.String, mscorlib:Java.Lang.StackTraceElement[], Mono.Android:Java.Lang.Throwable, Mono.Android", this, new java.lang.Object[] { p0, p1, p2 });
	}

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
