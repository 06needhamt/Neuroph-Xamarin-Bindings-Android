using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Contrib.Matrixmlp {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.contrib.matrixmlp']/class[@name='MatrixMomentumBackpropagation']"
	[global::Android.Runtime.Register ("org/neuroph/contrib/matrixmlp/MatrixMomentumBackpropagation", DoNotGenerateAcw=true)]
	public partial class MatrixMomentumBackpropagation : global::Org.Neuroph.Nnet.Learning.MomentumBackpropagation {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/contrib/matrixmlp/MatrixMomentumBackpropagation", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MatrixMomentumBackpropagation); }
		}

		protected MatrixMomentumBackpropagation (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.contrib.matrixmlp']/class[@name='MatrixMomentumBackpropagation']/constructor[@name='MatrixMomentumBackpropagation' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MatrixMomentumBackpropagation ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (MatrixMomentumBackpropagation)) {
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

		static Delegate cb_updateLayerWeights_Lorg_neuroph_contrib_matrixmlp_MatrixMlpLayer_arrayD;
#pragma warning disable 0169
		static Delegate GetUpdateLayerWeights_Lorg_neuroph_contrib_matrixmlp_MatrixMlpLayer_arrayDHandler ()
		{
			if (cb_updateLayerWeights_Lorg_neuroph_contrib_matrixmlp_MatrixMlpLayer_arrayD == null)
				cb_updateLayerWeights_Lorg_neuroph_contrib_matrixmlp_MatrixMlpLayer_arrayD = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_UpdateLayerWeights_Lorg_neuroph_contrib_matrixmlp_MatrixMlpLayer_arrayD);
			return cb_updateLayerWeights_Lorg_neuroph_contrib_matrixmlp_MatrixMlpLayer_arrayD;
		}

		static void n_UpdateLayerWeights_Lorg_neuroph_contrib_matrixmlp_MatrixMlpLayer_arrayD (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Neuroph.Contrib.Matrixmlp.MatrixMomentumBackpropagation __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.Matrixmlp.MatrixMomentumBackpropagation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Contrib.Matrixmlp.MatrixMlpLayer p0 = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.Matrixmlp.MatrixMlpLayer> (native_p0, JniHandleOwnership.DoNotTransfer);
			double[] p1 = (double[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (double));
			__this.UpdateLayerWeights (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		static IntPtr id_updateLayerWeights_Lorg_neuroph_contrib_matrixmlp_MatrixMlpLayer_arrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.contrib.matrixmlp']/class[@name='MatrixMomentumBackpropagation']/method[@name='updateLayerWeights' and count(parameter)=2 and parameter[1][@type='org.neuroph.contrib.matrixmlp.MatrixMlpLayer'] and parameter[2][@type='double[]']]"
		[Register ("updateLayerWeights", "(Lorg/neuroph/contrib/matrixmlp/MatrixMlpLayer;[D)V", "GetUpdateLayerWeights_Lorg_neuroph_contrib_matrixmlp_MatrixMlpLayer_arrayDHandler")]
		protected virtual unsafe void UpdateLayerWeights (global::Org.Neuroph.Contrib.Matrixmlp.MatrixMlpLayer p0, double[] p1)
		{
			if (id_updateLayerWeights_Lorg_neuroph_contrib_matrixmlp_MatrixMlpLayer_arrayD == IntPtr.Zero)
				id_updateLayerWeights_Lorg_neuroph_contrib_matrixmlp_MatrixMlpLayer_arrayD = JNIEnv.GetMethodID (class_ref, "updateLayerWeights", "(Lorg/neuroph/contrib/matrixmlp/MatrixMlpLayer;[D)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_updateLayerWeights_Lorg_neuroph_contrib_matrixmlp_MatrixMlpLayer_arrayD, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateLayerWeights", "(Lorg/neuroph/contrib/matrixmlp/MatrixMlpLayer;[D)V"), __args);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

	}
}
