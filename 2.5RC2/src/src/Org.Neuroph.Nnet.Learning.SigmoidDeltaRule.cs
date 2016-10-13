using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Nnet.Learning {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.nnet.learning']/class[@name='SigmoidDeltaRule']"
	[global::Android.Runtime.Register ("org/neuroph/nnet/learning/SigmoidDeltaRule", DoNotGenerateAcw=true)]
	public partial class SigmoidDeltaRule : global::Org.Neuroph.Nnet.Learning.LMS {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/nnet/learning/SigmoidDeltaRule", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SigmoidDeltaRule); }
		}

		protected SigmoidDeltaRule (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.nnet.learning']/class[@name='SigmoidDeltaRule']/constructor[@name='SigmoidDeltaRule' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SigmoidDeltaRule ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (SigmoidDeltaRule)) {
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

		static Delegate cb_adjustOutputNeurons_arrayD;
#pragma warning disable 0169
		static Delegate GetAdjustOutputNeurons_arrayDHandler ()
		{
			if (cb_adjustOutputNeurons_arrayD == null)
				cb_adjustOutputNeurons_arrayD = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AdjustOutputNeurons_arrayD);
			return cb_adjustOutputNeurons_arrayD;
		}

		static void n_AdjustOutputNeurons_arrayD (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Nnet.Learning.SigmoidDeltaRule __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Learning.SigmoidDeltaRule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			double[] p0 = (double[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (double));
			__this.AdjustOutputNeurons (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_adjustOutputNeurons_arrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.learning']/class[@name='SigmoidDeltaRule']/method[@name='adjustOutputNeurons' and count(parameter)=1 and parameter[1][@type='double[]']]"
		[Register ("adjustOutputNeurons", "([D)V", "GetAdjustOutputNeurons_arrayDHandler")]
		protected virtual unsafe void AdjustOutputNeurons (double[] p0)
		{
			if (id_adjustOutputNeurons_arrayD == IntPtr.Zero)
				id_adjustOutputNeurons_arrayD = JNIEnv.GetMethodID (class_ref, "adjustOutputNeurons", "([D)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_adjustOutputNeurons_arrayD, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "adjustOutputNeurons", "([D)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

	}
}
