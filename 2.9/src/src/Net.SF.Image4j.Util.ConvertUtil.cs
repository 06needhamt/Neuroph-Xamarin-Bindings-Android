using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Net.SF.Image4j.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='net.sf.image4j.util']/class[@name='ConvertUtil']"
	[global::Android.Runtime.Register ("net/sf/image4j/util/ConvertUtil", DoNotGenerateAcw=true)]
	public partial class ConvertUtil : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("net/sf/image4j/util/ConvertUtil", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ConvertUtil); }
		}

		protected ConvertUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='net.sf.image4j.util']/class[@name='ConvertUtil']/constructor[@name='ConvertUtil' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ConvertUtil ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ConvertUtil)) {
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

	}
}
