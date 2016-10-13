using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Nnet.Learning {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.nnet.learning']/class[@name='BinaryDeltaRule']"
	[global::Android.Runtime.Register ("org/neuroph/nnet/learning/BinaryDeltaRule", DoNotGenerateAcw=true)]
	public partial class BinaryDeltaRule : global::Org.Neuroph.Nnet.Learning.PerceptronLearning {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/nnet/learning/BinaryDeltaRule", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BinaryDeltaRule); }
		}

		protected BinaryDeltaRule (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.nnet.learning']/class[@name='BinaryDeltaRule']/constructor[@name='BinaryDeltaRule' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BinaryDeltaRule ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (BinaryDeltaRule)) {
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

		static Delegate cb_getErrorCorrection;
#pragma warning disable 0169
		static Delegate GetGetErrorCorrectionHandler ()
		{
			if (cb_getErrorCorrection == null)
				cb_getErrorCorrection = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetErrorCorrection);
			return cb_getErrorCorrection;
		}

		static double n_GetErrorCorrection (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Nnet.Learning.BinaryDeltaRule __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Learning.BinaryDeltaRule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ErrorCorrection;
		}
#pragma warning restore 0169

		static Delegate cb_setErrorCorrection_D;
#pragma warning disable 0169
		static Delegate GetSetErrorCorrection_DHandler ()
		{
			if (cb_setErrorCorrection_D == null)
				cb_setErrorCorrection_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetErrorCorrection_D);
			return cb_setErrorCorrection_D;
		}

		static void n_SetErrorCorrection_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Org.Neuroph.Nnet.Learning.BinaryDeltaRule __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Learning.BinaryDeltaRule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ErrorCorrection = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getErrorCorrection;
		static IntPtr id_setErrorCorrection_D;
		public virtual unsafe double ErrorCorrection {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.learning']/class[@name='BinaryDeltaRule']/method[@name='getErrorCorrection' and count(parameter)=0]"
			[Register ("getErrorCorrection", "()D", "GetGetErrorCorrectionHandler")]
			get {
				if (id_getErrorCorrection == IntPtr.Zero)
					id_getErrorCorrection = JNIEnv.GetMethodID (class_ref, "getErrorCorrection", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getErrorCorrection);
					else
						return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getErrorCorrection", "()D"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.learning']/class[@name='BinaryDeltaRule']/method[@name='setErrorCorrection' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setErrorCorrection", "(D)V", "GetSetErrorCorrection_DHandler")]
			set {
				if (id_setErrorCorrection_D == IntPtr.Zero)
					id_setErrorCorrection_D = JNIEnv.GetMethodID (class_ref, "setErrorCorrection", "(D)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setErrorCorrection_D, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setErrorCorrection", "(D)V"), __args);
				} finally {
				}
			}
		}

	}
}
