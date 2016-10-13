using System;
using System.Collections.Generic;
using Android.Runtime;

namespace BE.Abeel.Net {

	// Metadata.xml XPath class reference: path="/api/package[@name='be.abeel.net']/class[@name='URIFactory']"
	[global::Android.Runtime.Register ("be/abeel/net/URIFactory", DoNotGenerateAcw=true)]
	public partial class URIFactory : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("be/abeel/net/URIFactory", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (URIFactory); }
		}

		protected URIFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='be.abeel.net']/class[@name='URIFactory']/constructor[@name='URIFactory' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe URIFactory ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (URIFactory)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static IntPtr id_uri_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.net']/class[@name='URIFactory']/method[@name='uri' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("uri", "(Ljava/lang/String;)Ljava/net/URI;", "")]
		public static unsafe global::Java.Net.URI Uri (string p0)
		{
			if (id_uri_Ljava_lang_String_ == IntPtr.Zero)
				id_uri_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "uri", "(Ljava/lang/String;)Ljava/net/URI;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Java.Net.URI __ret = global::Java.Lang.Object.GetObject<global::Java.Net.URI> (JNIEnv.CallStaticObjectMethod  (class_ref, id_uri_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_url_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.net']/class[@name='URIFactory']/method[@name='url' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("url", "(Ljava/lang/String;)Ljava/net/URL;", "")]
		public static unsafe global::Java.Net.URL Url (string p0)
		{
			if (id_url_Ljava_lang_String_ == IntPtr.Zero)
				id_url_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "url", "(Ljava/lang/String;)Ljava/net/URL;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Java.Net.URL __ret = global::Java.Lang.Object.GetObject<global::Java.Net.URL> (JNIEnv.CallStaticObjectMethod  (class_ref, id_url_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
