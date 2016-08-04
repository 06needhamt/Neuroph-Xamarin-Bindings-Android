using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Nnet {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.nnet']/class[@name='ConvolutionalNetwork']"
	[global::Android.Runtime.Register ("org/neuroph/nnet/ConvolutionalNetwork", DoNotGenerateAcw=true)]
	public partial class ConvolutionalNetwork : global::Org.Neuroph.Core.NeuralNetwork {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/nnet/ConvolutionalNetwork", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ConvolutionalNetwork); }
		}

		protected ConvolutionalNetwork (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.nnet']/class[@name='ConvolutionalNetwork']/constructor[@name='ConvolutionalNetwork' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ConvolutionalNetwork ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ConvolutionalNetwork)) {
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
