using System;
using System.Collections.Generic;
using Android.Runtime;

namespace CH.Qos.Logback.Classic.Spi {

	// Metadata.xml XPath class reference: path="/api/package[@name='ch.qos.logback.classic.spi']/class[@name='PlatformInfo']"
	[global::Android.Runtime.Register ("ch/qos/logback/classic/spi/PlatformInfo", DoNotGenerateAcw=true)]
	public partial class PlatformInfo : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("ch/qos/logback/classic/spi/PlatformInfo", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PlatformInfo); }
		}

		protected PlatformInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='ch.qos.logback.classic.spi']/class[@name='PlatformInfo']/constructor[@name='PlatformInfo' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PlatformInfo ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (PlatformInfo)) {
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

		static IntPtr id_hasJMXObjectName;
		public static unsafe bool HasJMXObjectName {
			// Metadata.xml XPath method reference: path="/api/package[@name='ch.qos.logback.classic.spi']/class[@name='PlatformInfo']/method[@name='hasJMXObjectName' and count(parameter)=0]"
			[Register ("hasJMXObjectName", "()Z", "GetHasJMXObjectNameHandler")]
			get {
				if (id_hasJMXObjectName == IntPtr.Zero)
					id_hasJMXObjectName = JNIEnv.GetStaticMethodID (class_ref, "hasJMXObjectName", "()Z");
				try {
					return JNIEnv.CallStaticBooleanMethod  (class_ref, id_hasJMXObjectName);
				} finally {
				}
			}
		}

	}
}
