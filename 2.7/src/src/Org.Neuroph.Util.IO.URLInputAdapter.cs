using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Util.IO {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.util.io']/class[@name='URLInputAdapter']"
	[global::Android.Runtime.Register ("org/neuroph/util/io/URLInputAdapter", DoNotGenerateAcw=true)]
	public partial class URLInputAdapter : global::Org.Neuroph.Util.IO.InputStreamAdapter {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/util/io/URLInputAdapter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (URLInputAdapter); }
		}

		protected URLInputAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_net_URL_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.util.io']/class[@name='URLInputAdapter']/constructor[@name='URLInputAdapter' and count(parameter)=1 and parameter[1][@type='java.net.URL']]"
		[Register (".ctor", "(Ljava/net/URL;)V", "")]
		public unsafe URLInputAdapter (global::Java.Net.URL p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (URLInputAdapter)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/net/URL;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/net/URL;)V", __args);
					return;
				}

				if (id_ctor_Ljava_net_URL_ == IntPtr.Zero)
					id_ctor_Ljava_net_URL_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/net/URL;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_net_URL_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_net_URL_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.util.io']/class[@name='URLInputAdapter']/constructor[@name='URLInputAdapter' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe URLInputAdapter (string p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (URLInputAdapter)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
