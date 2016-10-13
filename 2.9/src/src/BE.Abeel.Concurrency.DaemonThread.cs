using System;
using System.Collections.Generic;
using Android.Runtime;

namespace BE.Abeel.Concurrency {

	// Metadata.xml XPath class reference: path="/api/package[@name='be.abeel.concurrency']/class[@name='DaemonThread']"
	[global::Android.Runtime.Register ("be/abeel/concurrency/DaemonThread", DoNotGenerateAcw=true)]
	public partial class DaemonThread : global::Java.Lang.Thread {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("be/abeel/concurrency/DaemonThread", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DaemonThread); }
		}

		protected DaemonThread (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_Runnable_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='be.abeel.concurrency']/class[@name='DaemonThread']/constructor[@name='DaemonThread' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
		[Register (".ctor", "(Ljava/lang/Runnable;)V", "")]
		public unsafe DaemonThread (global::Java.Lang.IRunnable p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (DaemonThread)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/Runnable;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/Runnable;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_Runnable_ == IntPtr.Zero)
					id_ctor_Ljava_lang_Runnable_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Runnable;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Runnable_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_Runnable_, __args);
			} finally {
			}
		}

	}
}
