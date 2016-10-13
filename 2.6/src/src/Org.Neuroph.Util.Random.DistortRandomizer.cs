using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Util.Random {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.util.random']/class[@name='DistortRandomizer']"
	[global::Android.Runtime.Register ("org/neuroph/util/random/DistortRandomizer", DoNotGenerateAcw=true)]
	public partial class DistortRandomizer : global::Org.Neuroph.Util.Random.WeightsRandomizer {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/util/random/DistortRandomizer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DistortRandomizer); }
		}

		protected DistortRandomizer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_D;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.util.random']/class[@name='DistortRandomizer']/constructor[@name='DistortRandomizer' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register (".ctor", "(D)V", "")]
		public unsafe DistortRandomizer (double p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (DistortRandomizer)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(D)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(D)V", __args);
					return;
				}

				if (id_ctor_D == IntPtr.Zero)
					id_ctor_D = JNIEnv.GetMethodID (class_ref, "<init>", "(D)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_D, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_D, __args);
			} finally {
			}
		}

	}
}
