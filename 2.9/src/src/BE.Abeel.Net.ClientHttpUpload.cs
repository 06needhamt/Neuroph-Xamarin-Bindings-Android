using System;
using System.Collections.Generic;
using Android.Runtime;

namespace BE.Abeel.Net {

	// Metadata.xml XPath class reference: path="/api/package[@name='be.abeel.net']/class[@name='ClientHttpUpload']"
	[global::Android.Runtime.Register ("be/abeel/net/ClientHttpUpload", DoNotGenerateAcw=true)]
	public partial class ClientHttpUpload : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("be/abeel/net/ClientHttpUpload", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ClientHttpUpload); }
		}

		protected ClientHttpUpload (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='be.abeel.net']/class[@name='ClientHttpUpload']/constructor[@name='ClientHttpUpload' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ClientHttpUpload ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ClientHttpUpload)) {
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

		static IntPtr id_upload_Ljava_io_File_Ljava_net_URL_;
		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.net']/class[@name='ClientHttpUpload']/method[@name='upload' and count(parameter)=2 and parameter[1][@type='java.io.File'] and parameter[2][@type='java.net.URL']]"
		[Register ("upload", "(Ljava/io/File;Ljava/net/URL;)Ljava/lang/String;", "")]
		public static unsafe string Upload (global::Java.IO.File p0, global::Java.Net.URL p1)
		{
			if (id_upload_Ljava_io_File_Ljava_net_URL_ == IntPtr.Zero)
				id_upload_Ljava_io_File_Ljava_net_URL_ = JNIEnv.GetStaticMethodID (class_ref, "upload", "(Ljava/io/File;Ljava/net/URL;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_upload_Ljava_io_File_Ljava_net_URL_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
