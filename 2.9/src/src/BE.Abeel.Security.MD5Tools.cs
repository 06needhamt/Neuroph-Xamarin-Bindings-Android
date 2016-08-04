using System;
using System.Collections.Generic;
using Android.Runtime;

namespace BE.Abeel.Security {

	// Metadata.xml XPath class reference: path="/api/package[@name='be.abeel.security']/class[@name='MD5Tools']"
	[global::Android.Runtime.Register ("be/abeel/security/MD5Tools", DoNotGenerateAcw=true)]
	public partial class MD5Tools : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("be/abeel/security/MD5Tools", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MD5Tools); }
		}

		protected MD5Tools (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='be.abeel.security']/class[@name='MD5Tools']/constructor[@name='MD5Tools' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MD5Tools ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (MD5Tools)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static IntPtr id_md5_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.security']/class[@name='MD5Tools']/method[@name='md5' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("md5", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string Md5 (string p0)
		{
			if (id_md5_Ljava_lang_String_ == IntPtr.Zero)
				id_md5_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "md5", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_md5_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
