using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Nnet.Learning {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.nnet.learning']/class[@name='OjaLearning']"
	[global::Android.Runtime.Register ("org/neuroph/nnet/learning/OjaLearning", DoNotGenerateAcw=true)]
	public partial class OjaLearning : global::Org.Neuroph.Nnet.Learning.UnsupervisedHebbianLearning {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/nnet/learning/OjaLearning", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (OjaLearning); }
		}

		protected OjaLearning (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.nnet.learning']/class[@name='OjaLearning']/constructor[@name='OjaLearning' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe OjaLearning ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (OjaLearning)) {
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
