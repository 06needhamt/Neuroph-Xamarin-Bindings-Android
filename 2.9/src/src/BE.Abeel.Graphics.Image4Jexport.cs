using System;
using System.Collections.Generic;
using Android.Runtime;

namespace BE.Abeel.Graphics {

	// Metadata.xml XPath class reference: path="/api/package[@name='be.abeel.graphics']/class[@name='Image4Jexport']"
	[global::Android.Runtime.Register ("be/abeel/graphics/Image4Jexport", DoNotGenerateAcw=true)]
	public partial class Image4Jexport : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("be/abeel/graphics/Image4Jexport", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Image4Jexport); }
		}

		protected Image4Jexport (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='be.abeel.graphics']/class[@name='Image4Jexport']/constructor[@name='Image4Jexport' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Image4Jexport ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Image4Jexport)) {
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
