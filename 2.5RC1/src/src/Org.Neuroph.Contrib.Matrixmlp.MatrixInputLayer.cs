using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Contrib.Matrixmlp {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.contrib.matrixmlp']/class[@name='MatrixInputLayer']"
	[global::Android.Runtime.Register ("org/neuroph/contrib/matrixmlp/MatrixInputLayer", DoNotGenerateAcw=true)]
	public partial class MatrixInputLayer : global::Java.Lang.Object, global::Org.Neuroph.Contrib.Matrixmlp.IMatrixLayer {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/contrib/matrixmlp/MatrixInputLayer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MatrixInputLayer); }
		}

		protected MatrixInputLayer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.contrib.matrixmlp']/class[@name='MatrixInputLayer']/constructor[@name='MatrixInputLayer' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe MatrixInputLayer (int p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (MatrixInputLayer)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(I)V", __args);
					return;
				}

				if (id_ctor_I == IntPtr.Zero)
					id_ctor_I = JNIEnv.GetMethodID (class_ref, "<init>", "(I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_I, __args);
			} finally {
			}
		}

		static Delegate cb_calculate;
#pragma warning disable 0169
		static Delegate GetCalculateHandler ()
		{
			if (cb_calculate == null)
				cb_calculate = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Calculate);
			return cb_calculate;
		}

		static void n_Calculate (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Contrib.Matrixmlp.MatrixInputLayer __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.Matrixmlp.MatrixInputLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Calculate ();
		}
#pragma warning restore 0169

		static IntPtr id_calculate;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.contrib.matrixmlp']/class[@name='MatrixInputLayer']/method[@name='calculate' and count(parameter)=0]"
		[Register ("calculate", "()V", "GetCalculateHandler")]
		public virtual unsafe void Calculate ()
		{
			if (id_calculate == IntPtr.Zero)
				id_calculate = JNIEnv.GetMethodID (class_ref, "calculate", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_calculate);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "calculate", "()V"));
			} finally {
			}
		}

		static Delegate cb_getInputs;
#pragma warning disable 0169
		static Delegate GetGetInputsHandler ()
		{
			if (cb_getInputs == null)
				cb_getInputs = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetInputs);
			return cb_getInputs;
		}

		static IntPtr n_GetInputs (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Contrib.Matrixmlp.MatrixInputLayer __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.Matrixmlp.MatrixInputLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetInputs ());
		}
#pragma warning restore 0169

		static IntPtr id_getInputs;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.contrib.matrixmlp']/class[@name='MatrixInputLayer']/method[@name='getInputs' and count(parameter)=0]"
		[Register ("getInputs", "()[D", "GetGetInputsHandler")]
		public virtual unsafe double[] GetInputs ()
		{
			if (id_getInputs == IntPtr.Zero)
				id_getInputs = JNIEnv.GetMethodID (class_ref, "getInputs", "()[D");
			try {

				if (GetType () == ThresholdType)
					return (double[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getInputs), JniHandleOwnership.TransferLocalRef, typeof (double));
				else
					return (double[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getInputs", "()[D")), JniHandleOwnership.TransferLocalRef, typeof (double));
			} finally {
			}
		}

		static Delegate cb_getOutputs;
#pragma warning disable 0169
		static Delegate GetGetOutputsHandler ()
		{
			if (cb_getOutputs == null)
				cb_getOutputs = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOutputs);
			return cb_getOutputs;
		}

		static IntPtr n_GetOutputs (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Contrib.Matrixmlp.MatrixInputLayer __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.Matrixmlp.MatrixInputLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetOutputs ());
		}
#pragma warning restore 0169

		static IntPtr id_getOutputs;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.contrib.matrixmlp']/class[@name='MatrixInputLayer']/method[@name='getOutputs' and count(parameter)=0]"
		[Register ("getOutputs", "()[D", "GetGetOutputsHandler")]
		public virtual unsafe double[] GetOutputs ()
		{
			if (id_getOutputs == IntPtr.Zero)
				id_getOutputs = JNIEnv.GetMethodID (class_ref, "getOutputs", "()[D");
			try {

				if (GetType () == ThresholdType)
					return (double[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOutputs), JniHandleOwnership.TransferLocalRef, typeof (double));
				else
					return (double[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOutputs", "()[D")), JniHandleOwnership.TransferLocalRef, typeof (double));
			} finally {
			}
		}

		static Delegate cb_setInputs_arrayD;
#pragma warning disable 0169
		static Delegate GetSetInputs_arrayDHandler ()
		{
			if (cb_setInputs_arrayD == null)
				cb_setInputs_arrayD = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetInputs_arrayD);
			return cb_setInputs_arrayD;
		}

		static void n_SetInputs_arrayD (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Contrib.Matrixmlp.MatrixInputLayer __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.Matrixmlp.MatrixInputLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			double[] p0 = (double[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (double));
			__this.SetInputs (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_setInputs_arrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.contrib.matrixmlp']/class[@name='MatrixInputLayer']/method[@name='setInputs' and count(parameter)=1 and parameter[1][@type='double[]']]"
		[Register ("setInputs", "([D)V", "GetSetInputs_arrayDHandler")]
		public virtual unsafe void SetInputs (double[] p0)
		{
			if (id_setInputs_arrayD == IntPtr.Zero)
				id_setInputs_arrayD = JNIEnv.GetMethodID (class_ref, "setInputs", "([D)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setInputs_arrayD, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setInputs", "([D)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_setOutputs_arrayD;
#pragma warning disable 0169
		static Delegate GetSetOutputs_arrayDHandler ()
		{
			if (cb_setOutputs_arrayD == null)
				cb_setOutputs_arrayD = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOutputs_arrayD);
			return cb_setOutputs_arrayD;
		}

		static void n_SetOutputs_arrayD (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Contrib.Matrixmlp.MatrixInputLayer __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.Matrixmlp.MatrixInputLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			double[] p0 = (double[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (double));
			__this.SetOutputs (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOutputs_arrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.contrib.matrixmlp']/class[@name='MatrixInputLayer']/method[@name='setOutputs' and count(parameter)=1 and parameter[1][@type='double[]']]"
		[Register ("setOutputs", "([D)V", "GetSetOutputs_arrayDHandler")]
		public virtual unsafe void SetOutputs (double[] p0)
		{
			if (id_setOutputs_arrayD == IntPtr.Zero)
				id_setOutputs_arrayD = JNIEnv.GetMethodID (class_ref, "setOutputs", "([D)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOutputs_arrayD, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOutputs", "([D)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

	}
}
