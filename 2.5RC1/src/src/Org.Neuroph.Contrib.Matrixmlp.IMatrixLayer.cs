using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Contrib.Matrixmlp {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.neuroph.contrib.matrixmlp']/interface[@name='MatrixLayer']"
	[Register ("org/neuroph/contrib/matrixmlp/MatrixLayer", "", "Org.Neuroph.Contrib.Matrixmlp.IMatrixLayerInvoker")]
	public partial interface IMatrixLayer : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.contrib.matrixmlp']/interface[@name='MatrixLayer']/method[@name='calculate' and count(parameter)=0]"
		[Register ("calculate", "()V", "GetCalculateHandler:Org.Neuroph.Contrib.Matrixmlp.IMatrixLayerInvoker, neuroph_2.5RC1")]
		void Calculate ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.contrib.matrixmlp']/interface[@name='MatrixLayer']/method[@name='getInputs' and count(parameter)=0]"
		[Register ("getInputs", "()[D", "GetGetInputsHandler:Org.Neuroph.Contrib.Matrixmlp.IMatrixLayerInvoker, neuroph_2.5RC1")]
		double[] GetInputs ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.contrib.matrixmlp']/interface[@name='MatrixLayer']/method[@name='getOutputs' and count(parameter)=0]"
		[Register ("getOutputs", "()[D", "GetGetOutputsHandler:Org.Neuroph.Contrib.Matrixmlp.IMatrixLayerInvoker, neuroph_2.5RC1")]
		double[] GetOutputs ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.contrib.matrixmlp']/interface[@name='MatrixLayer']/method[@name='setInputs' and count(parameter)=1 and parameter[1][@type='double[]']]"
		[Register ("setInputs", "([D)V", "GetSetInputs_arrayDHandler:Org.Neuroph.Contrib.Matrixmlp.IMatrixLayerInvoker, neuroph_2.5RC1")]
		void SetInputs (double[] p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.contrib.matrixmlp']/interface[@name='MatrixLayer']/method[@name='setOutputs' and count(parameter)=1 and parameter[1][@type='double[]']]"
		[Register ("setOutputs", "([D)V", "GetSetOutputs_arrayDHandler:Org.Neuroph.Contrib.Matrixmlp.IMatrixLayerInvoker, neuroph_2.5RC1")]
		void SetOutputs (double[] p0);

	}

	[global::Android.Runtime.Register ("org/neuroph/contrib/matrixmlp/MatrixLayer", DoNotGenerateAcw=true)]
	internal class IMatrixLayerInvoker : global::Java.Lang.Object, IMatrixLayer {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/neuroph/contrib/matrixmlp/MatrixLayer");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IMatrixLayerInvoker); }
		}

		IntPtr class_ref;

		public static IMatrixLayer GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMatrixLayer> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.neuroph.contrib.matrixmlp.MatrixLayer"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMatrixLayerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Org.Neuroph.Contrib.Matrixmlp.IMatrixLayer __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.Matrixmlp.IMatrixLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Calculate ();
		}
#pragma warning restore 0169

		IntPtr id_calculate;
		public unsafe void Calculate ()
		{
			if (id_calculate == IntPtr.Zero)
				id_calculate = JNIEnv.GetMethodID (class_ref, "calculate", "()V");
			JNIEnv.CallVoidMethod (Handle, id_calculate);
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
			global::Org.Neuroph.Contrib.Matrixmlp.IMatrixLayer __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.Matrixmlp.IMatrixLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetInputs ());
		}
#pragma warning restore 0169

		IntPtr id_getInputs;
		public unsafe double[] GetInputs ()
		{
			if (id_getInputs == IntPtr.Zero)
				id_getInputs = JNIEnv.GetMethodID (class_ref, "getInputs", "()[D");
			return (double[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (Handle, id_getInputs), JniHandleOwnership.TransferLocalRef, typeof (double));
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
			global::Org.Neuroph.Contrib.Matrixmlp.IMatrixLayer __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.Matrixmlp.IMatrixLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetOutputs ());
		}
#pragma warning restore 0169

		IntPtr id_getOutputs;
		public unsafe double[] GetOutputs ()
		{
			if (id_getOutputs == IntPtr.Zero)
				id_getOutputs = JNIEnv.GetMethodID (class_ref, "getOutputs", "()[D");
			return (double[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (Handle, id_getOutputs), JniHandleOwnership.TransferLocalRef, typeof (double));
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
			global::Org.Neuroph.Contrib.Matrixmlp.IMatrixLayer __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.Matrixmlp.IMatrixLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			double[] p0 = (double[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (double));
			__this.SetInputs (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		IntPtr id_setInputs_arrayD;
		public unsafe void SetInputs (double[] p0)
		{
			if (id_setInputs_arrayD == IntPtr.Zero)
				id_setInputs_arrayD = JNIEnv.GetMethodID (class_ref, "setInputs", "([D)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (Handle, id_setInputs_arrayD, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
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
			global::Org.Neuroph.Contrib.Matrixmlp.IMatrixLayer __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.Matrixmlp.IMatrixLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			double[] p0 = (double[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (double));
			__this.SetOutputs (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		IntPtr id_setOutputs_arrayD;
		public unsafe void SetOutputs (double[] p0)
		{
			if (id_setOutputs_arrayD == IntPtr.Zero)
				id_setOutputs_arrayD = JNIEnv.GetMethodID (class_ref, "setOutputs", "([D)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (Handle, id_setOutputs_arrayD, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}

}
