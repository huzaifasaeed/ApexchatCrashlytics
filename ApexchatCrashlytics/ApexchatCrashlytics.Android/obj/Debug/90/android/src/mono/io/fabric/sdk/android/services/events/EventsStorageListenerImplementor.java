package mono.io.fabric.sdk.android.services.events;


public class EventsStorageListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		io.fabric.sdk.android.services.events.EventsStorageListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onRollOver:(Ljava/lang/String;)V:GetOnRollOver_Ljava_lang_String_Handler:Fabric.Services.Events.IEventsStorageListenerInvoker, Xamarin.Android.Fabric\n" +
			"";
		mono.android.Runtime.register ("Fabric.Services.Events.IEventsStorageListenerImplementor, Xamarin.Android.Fabric", EventsStorageListenerImplementor.class, __md_methods);
	}


	public EventsStorageListenerImplementor ()
	{
		super ();
		if (getClass () == EventsStorageListenerImplementor.class)
			mono.android.TypeManager.Activate ("Fabric.Services.Events.IEventsStorageListenerImplementor, Xamarin.Android.Fabric", "", this, new java.lang.Object[] {  });
	}


	public void onRollOver (java.lang.String p0)
	{
		n_onRollOver (p0);
	}

	private native void n_onRollOver (java.lang.String p0);

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
