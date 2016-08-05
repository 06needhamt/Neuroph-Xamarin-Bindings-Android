using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Contrib.Matrixmlp {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.contrib.matrixmlp']/class[@name='MatrixMultiLayerPerceptron']"
	[global::Android.Runtime.Register ("org/neuroph/contrib/matrixmlp/MatrixMultiLayerPerceptron", DoNotGenerateAcw=true)]
	public partial class MatrixMultiLayerPerceptron : global::Org.Neuroph.Core.NeuralNetwork {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/contrib/matrixmlp/MatrixMultiLayerPerceptron", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MatrixMultiLayerPerceptron); }
		}

		protected MatrixMultiLayerPerceptron (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_neuroph_nnet_MultiLayerPerceptron_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.contrib.matrixmlp']/class[@name='MatrixMultiLayerPerceptron']/constructor[@name='MatrixMultiLayerPerceptron' and count(parameter)=1 and parameter[1][@type='org.neuroph.nnet.MultiLayerPerceptron']]"
		[Register (".ctor", "(Lorg/neuroph/nnet/MultiLayerPerceptron;)V", "")]
		public unsafe MatrixMultiLayerPerceptron (global::Org.Neuroph.Nnet.MultiLayerPerceptron p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (MatrixMultiLayerPerceptron)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/neuroph/nnet/MultiLayerPerceptron;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorg/neuroph/nnet/MultiLayerPerceptron;)V", __args);
					return;
				}

				if (id_ctor_Lorg_neuroph_nnet_MultiLayerPerceptron_ == IntPtr.Zero)
					id_ctor_Lorg_neuroph_nnet_MultiLayerPerceptron_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/neuroph/nnet/MultiLayerPerceptron;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_neuroph_nnet_MultiLayerPerceptron_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_neuroph_nnet_MultiLayerPerceptron_, __args);
			} finally {
			}
		}

		static Delegate cb_getMatrixLayers;
#pragma warning disable 0169
		static Delegate GetGetMatrixLayersHandler ()
		{
			if (cb_getMatrixLayers == null)
				cb_getMatrixLayers = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMatrixLayers);
			return cb_getMatrixLayers;
		}

		static IntPtr n_GetMatrixLayers (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Contrib.Matrixmlp.MatrixMultiLayerPerceptron __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.Matrixmlp.MatrixMultiLayerPerceptron> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetMatrixLayers ());
		}
#pragma warning restore 0169

		static IntPtr id_getMatrixLayers;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.contrib.matrixmlp']/class[@name='MatrixMultiLayerPerceptron']/method[@name='getMatrixLayers' and count(parameter)=0]"
		[Register ("getMatrixLayers", "()[Lorg/neuroph/contrib/matrixmlp/MatrixLayer;", "GetGetMatrixLayersHandler")]
		public virtual unsafe global::Org.Neuroph.Contrib.Matrixmlp.IMatrixLayer[] GetMatrixLayers ()
		{
			if (id_getMatrixLayers == IntPtr.Zero)
				id_getMatrixLayers = JNIEnv.GetMethodID (class_ref, "getMatrixLayers", "()[Lorg/neuroph/contrib/matrixmlp/MatrixLayer;");
			try {

				if (GetType () == ThresholdType)
					return (global::Org.Neuroph.Contrib.Matrixmlp.IMatrixLayer[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getMatrixLayers), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Neuroph.Contrib.Matrixmlp.IMatrixLayer));
				else
					return (global::Org.Neuroph.Contrib.Matrixmlp.IMatrixLayer[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMatrixLayers", "()[Lorg/neuroph/contrib/matrixmlp/MatrixLayer;")), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Neuroph.Contrib.Matrixmlp.IMatrixLayer));
			} finally {
			}
		}

	}
}
