using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Adapters.Jml {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.adapters.jml']/class[@name='JMLDataSetConverter']"
	[global::Android.Runtime.Register ("org/neuroph/adapters/jml/JMLDataSetConverter", DoNotGenerateAcw=true)]
	public partial class JMLDataSetConverter : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/adapters/jml/JMLDataSetConverter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (JMLDataSetConverter); }
		}

		protected JMLDataSetConverter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.adapters.jml']/class[@name='JMLDataSetConverter']/constructor[@name='JMLDataSetConverter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe JMLDataSetConverter ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (JMLDataSetConverter)) {
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

	}
}
