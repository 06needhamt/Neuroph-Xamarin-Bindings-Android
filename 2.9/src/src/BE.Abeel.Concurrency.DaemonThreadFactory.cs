using System;
using System.Collections.Generic;
using Android.Runtime;

namespace BE.Abeel.Concurrency {

	// Metadata.xml XPath class reference: path="/api/package[@name='be.abeel.concurrency']/class[@name='DaemonThreadFactory']"
	[global::Android.Runtime.Register ("be/abeel/concurrency/DaemonThreadFactory", DoNotGenerateAcw=true)]
	public partial class DaemonThreadFactory : global::Java.Lang.Object, global::Java.Util.Concurrent.IThreadFactory {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("be/abeel/concurrency/DaemonThreadFactory", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DaemonThreadFactory); }
		}

		protected DaemonThreadFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='be.abeel.concurrency']/class[@name='DaemonThreadFactory']/constructor[@name='DaemonThreadFactory' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DaemonThreadFactory ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (DaemonThreadFactory)) {
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

		static Delegate cb_newThread_Ljava_lang_Runnable_;
#pragma warning disable 0169
		static Delegate GetNewThread_Ljava_lang_Runnable_Handler ()
		{
			if (cb_newThread_Ljava_lang_Runnable_ == null)
				cb_newThread_Ljava_lang_Runnable_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_NewThread_Ljava_lang_Runnable_);
			return cb_newThread_Ljava_lang_Runnable_;
		}

		static IntPtr n_NewThread_Ljava_lang_Runnable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BE.Abeel.Concurrency.DaemonThreadFactory __this = global::Java.Lang.Object.GetObject<global::BE.Abeel.Concurrency.DaemonThreadFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.IRunnable p0 = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.NewThread (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_newThread_Ljava_lang_Runnable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.concurrency']/class[@name='DaemonThreadFactory']/method[@name='newThread' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
		[Register ("newThread", "(Ljava/lang/Runnable;)Ljava/lang/Thread;", "GetNewThread_Ljava_lang_Runnable_Handler")]
		public virtual unsafe global::Java.Lang.Thread NewThread (global::Java.Lang.IRunnable p0)
		{
			if (id_newThread_Ljava_lang_Runnable_ == IntPtr.Zero)
				id_newThread_Ljava_lang_Runnable_ = JNIEnv.GetMethodID (class_ref, "newThread", "(Ljava/lang/Runnable;)Ljava/lang/Thread;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Java.Lang.Thread __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Thread> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_newThread_Ljava_lang_Runnable_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Thread> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "newThread", "(Ljava/lang/Runnable;)Ljava/lang/Thread;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
