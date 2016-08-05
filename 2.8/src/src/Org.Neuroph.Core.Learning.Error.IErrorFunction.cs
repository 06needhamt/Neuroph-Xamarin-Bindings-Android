using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Core.Learning.Error {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.neuroph.core.learning.error']/interface[@name='ErrorFunction']"
	[Register ("org/neuroph/core/learning/error/ErrorFunction", "", "Org.Neuroph.Core.Learning.Error.IErrorFunctionInvoker")]
	public partial interface IErrorFunction : IJavaObject {

		double TotalError {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.learning.error']/interface[@name='ErrorFunction']/method[@name='getTotalError' and count(parameter)=0]"
			[Register ("getTotalError", "()D", "GetGetTotalErrorHandler:Org.Neuroph.Core.Learning.Error.IErrorFunctionInvoker, neuroph_2.8")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.learning.error']/interface[@name='ErrorFunction']/method[@name='addOutputError' and count(parameter)=1 and parameter[1][@type='double[]']]"
		[Register ("addOutputError", "([D)V", "GetAddOutputError_arrayDHandler:Org.Neuroph.Core.Learning.Error.IErrorFunctionInvoker, neuroph_2.8")]
		void AddOutputError (double[] p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.learning.error']/interface[@name='ErrorFunction']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "GetResetHandler:Org.Neuroph.Core.Learning.Error.IErrorFunctionInvoker, neuroph_2.8")]
		void Reset ();

	}

	[global::Android.Runtime.Register ("org/neuroph/core/learning/error/ErrorFunction", DoNotGenerateAcw=true)]
	internal class IErrorFunctionInvoker : global::Java.Lang.Object, IErrorFunction {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/neuroph/core/learning/error/ErrorFunction");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IErrorFunctionInvoker); }
		}

		IntPtr class_ref;

		public static IErrorFunction GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IErrorFunction> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.neuroph.core.learning.error.ErrorFunction"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IErrorFunctionInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getTotalError;
#pragma warning disable 0169
		static Delegate GetGetTotalErrorHandler ()
		{
			if (cb_getTotalError == null)
				cb_getTotalError = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetTotalError);
			return cb_getTotalError;
		}

		static double n_GetTotalError (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Core.Learning.Error.IErrorFunction __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.Error.IErrorFunction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TotalError;
		}
#pragma warning restore 0169

		IntPtr id_getTotalError;
		public unsafe double TotalError {
			get {
				if (id_getTotalError == IntPtr.Zero)
					id_getTotalError = JNIEnv.GetMethodID (class_ref, "getTotalError", "()D");
				return JNIEnv.CallDoubleMethod (Handle, id_getTotalError);
			}
		}

		static Delegate cb_addOutputError_arrayD;
#pragma warning disable 0169
		static Delegate GetAddOutputError_arrayDHandler ()
		{
			if (cb_addOutputError_arrayD == null)
				cb_addOutputError_arrayD = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddOutputError_arrayD);
			return cb_addOutputError_arrayD;
		}

		static void n_AddOutputError_arrayD (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Core.Learning.Error.IErrorFunction __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.Error.IErrorFunction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			double[] p0 = (double[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (double));
			__this.AddOutputError (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		IntPtr id_addOutputError_arrayD;
		public unsafe void AddOutputError (double[] p0)
		{
			if (id_addOutputError_arrayD == IntPtr.Zero)
				id_addOutputError_arrayD = JNIEnv.GetMethodID (class_ref, "addOutputError", "([D)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (Handle, id_addOutputError_arrayD, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_reset;
#pragma warning disable 0169
		static Delegate GetResetHandler ()
		{
			if (cb_reset == null)
				cb_reset = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Reset);
			return cb_reset;
		}

		static void n_Reset (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Core.Learning.Error.IErrorFunction __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.Error.IErrorFunction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Reset ();
		}
#pragma warning restore 0169

		IntPtr id_reset;
		public unsafe void Reset ()
		{
			if (id_reset == IntPtr.Zero)
				id_reset = JNIEnv.GetMethodID (class_ref, "reset", "()V");
			JNIEnv.CallVoidMethod (Handle, id_reset);
		}

	}

}
