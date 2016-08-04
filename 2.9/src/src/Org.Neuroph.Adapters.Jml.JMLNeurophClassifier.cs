using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Adapters.Jml {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.adapters.jml']/class[@name='JMLNeurophClassifier']"
	[global::Android.Runtime.Register ("org/neuroph/adapters/jml/JMLNeurophClassifier", DoNotGenerateAcw=true)]
	public partial class JMLNeurophClassifier : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/adapters/jml/JMLNeurophClassifier", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (JMLNeurophClassifier); }
		}

		protected JMLNeurophClassifier (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_neuroph_core_NeuralNetwork_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.adapters.jml']/class[@name='JMLNeurophClassifier']/constructor[@name='JMLNeurophClassifier' and count(parameter)=1 and parameter[1][@type='org.neuroph.core.NeuralNetwork']]"
		[Register (".ctor", "(Lorg/neuroph/core/NeuralNetwork;)V", "")]
		public unsafe JMLNeurophClassifier (global::Org.Neuroph.Core.NeuralNetwork p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (JMLNeurophClassifier)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/neuroph/core/NeuralNetwork;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorg/neuroph/core/NeuralNetwork;)V", __args);
					return;
				}

				if (id_ctor_Lorg_neuroph_core_NeuralNetwork_ == IntPtr.Zero)
					id_ctor_Lorg_neuroph_core_NeuralNetwork_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/neuroph/core/NeuralNetwork;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_neuroph_core_NeuralNetwork_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_neuroph_core_NeuralNetwork_, __args);
			} finally {
			}
		}

	}
}
