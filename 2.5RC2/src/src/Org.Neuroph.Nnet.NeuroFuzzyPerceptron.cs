using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Nnet {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.nnet']/class[@name='NeuroFuzzyPerceptron']"
	[global::Android.Runtime.Register ("org/neuroph/nnet/NeuroFuzzyPerceptron", DoNotGenerateAcw=true)]
	public partial class NeuroFuzzyPerceptron : global::Org.Neuroph.Core.NeuralNetwork {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/nnet/NeuroFuzzyPerceptron", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NeuroFuzzyPerceptron); }
		}

		protected NeuroFuzzyPerceptron (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_ILjava_util_Vector_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.nnet']/class[@name='NeuroFuzzyPerceptron']/constructor[@name='NeuroFuzzyPerceptron' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.util.Vector&lt;java.lang.Integer&gt;'] and parameter[3][@type='int']]"
		[Register (".ctor", "(ILjava/util/Vector;I)V", "")]
		public unsafe NeuroFuzzyPerceptron (int p0, global::Java.Util.Vector p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (NeuroFuzzyPerceptron)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(ILjava/util/Vector;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(ILjava/util/Vector;I)V", __args);
					return;
				}

				if (id_ctor_ILjava_util_Vector_I == IntPtr.Zero)
					id_ctor_ILjava_util_Vector_I = JNIEnv.GetMethodID (class_ref, "<init>", "(ILjava/util/Vector;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_ILjava_util_Vector_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_ILjava_util_Vector_I, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_arrayarrayDarrayarrayD;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.nnet']/class[@name='NeuroFuzzyPerceptron']/constructor[@name='NeuroFuzzyPerceptron' and count(parameter)=2 and parameter[1][@type='double[][]'] and parameter[2][@type='double[][]']]"
		[Register (".ctor", "([[D[[D)V", "")]
		public unsafe NeuroFuzzyPerceptron (double[][] p0, double[][] p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				if (GetType () != typeof (NeuroFuzzyPerceptron)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "([[D[[D)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "([[D[[D)V", __args);
					return;
				}

				if (id_ctor_arrayarrayDarrayarrayD == IntPtr.Zero)
					id_ctor_arrayarrayDarrayarrayD = JNIEnv.GetMethodID (class_ref, "<init>", "([[D[[D)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayarrayDarrayarrayD, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_arrayarrayDarrayarrayD, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

	}
}
