using System;
using System.Collections.Generic;
using Android.Runtime;

namespace CH.Qos.Logback.Classic.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='ch.qos.logback.classic.util']/class[@name='EnvUtil']"
	[global::Android.Runtime.Register ("ch/qos/logback/classic/util/EnvUtil", DoNotGenerateAcw=true)]
	public partial class EnvUtil : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("ch/qos/logback/classic/util/EnvUtil", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (EnvUtil); }
		}

		protected EnvUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='ch.qos.logback.classic.util']/class[@name='EnvUtil']/constructor[@name='EnvUtil' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe EnvUtil ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (EnvUtil)) {
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

		static IntPtr id_isGroovyAvailable;
		public static unsafe bool IsGroovyAvailable {
			// Metadata.xml XPath method reference: path="/api/package[@name='ch.qos.logback.classic.util']/class[@name='EnvUtil']/method[@name='isGroovyAvailable' and count(parameter)=0]"
			[Register ("isGroovyAvailable", "()Z", "GetIsGroovyAvailableHandler")]
			get {
				if (id_isGroovyAvailable == IntPtr.Zero)
					id_isGroovyAvailable = JNIEnv.GetStaticMethodID (class_ref, "isGroovyAvailable", "()Z");
				try {
					return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isGroovyAvailable);
				} finally {
				}
			}
		}

	}
}
