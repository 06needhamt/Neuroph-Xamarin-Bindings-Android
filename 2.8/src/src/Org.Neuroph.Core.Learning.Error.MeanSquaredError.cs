using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Core.Learning.Error {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.core.learning.error']/class[@name='MeanSquaredError']"
	[global::Android.Runtime.Register ("org/neuroph/core/learning/error/MeanSquaredError", DoNotGenerateAcw=true)]
	public partial class MeanSquaredError : global::Java.Lang.Object, global::Java.IO.ISerializable, global::Org.Neuroph.Core.Learning.Error.IErrorFunction {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/core/learning/error/MeanSquaredError", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MeanSquaredError); }
		}

		protected MeanSquaredError (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_D;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.core.learning.error']/class[@name='MeanSquaredError']/constructor[@name='MeanSquaredError' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register (".ctor", "(D)V", "")]
		public unsafe MeanSquaredError (double p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (MeanSquaredError)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(D)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(D)V", __args);
					return;
				}

				if (id_ctor_D == IntPtr.Zero)
					id_ctor_D = JNIEnv.GetMethodID (class_ref, "<init>", "(D)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_D, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_D, __args);
			} finally {
			}
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
			global::Org.Neuroph.Core.Learning.Error.MeanSquaredError __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.Error.MeanSquaredError> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TotalError;
		}
#pragma warning restore 0169

		static IntPtr id_getTotalError;
		public virtual unsafe double TotalError {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.learning.error']/class[@name='MeanSquaredError']/method[@name='getTotalError' and count(parameter)=0]"
			[Register ("getTotalError", "()D", "GetGetTotalErrorHandler")]
			get {
				if (id_getTotalError == IntPtr.Zero)
					id_getTotalError = JNIEnv.GetMethodID (class_ref, "getTotalError", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod  (Handle, id_getTotalError);
					else
						return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTotalError", "()D"));
				} finally {
				}
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
			global::Org.Neuroph.Core.Learning.Error.MeanSquaredError __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.Error.MeanSquaredError> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			double[] p0 = (double[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (double));
			__this.AddOutputError (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_addOutputError_arrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.learning.error']/class[@name='MeanSquaredError']/method[@name='addOutputError' and count(parameter)=1 and parameter[1][@type='double[]']]"
		[Register ("addOutputError", "([D)V", "GetAddOutputError_arrayDHandler")]
		public virtual unsafe void AddOutputError (double[] p0)
		{
			if (id_addOutputError_arrayD == IntPtr.Zero)
				id_addOutputError_arrayD = JNIEnv.GetMethodID (class_ref, "addOutputError", "([D)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_addOutputError_arrayD, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addOutputError", "([D)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
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
			global::Org.Neuroph.Core.Learning.Error.MeanSquaredError __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.Error.MeanSquaredError> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Reset ();
		}
#pragma warning restore 0169

		static IntPtr id_reset;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.learning.error']/class[@name='MeanSquaredError']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "GetResetHandler")]
		public virtual unsafe void Reset ()
		{
			if (id_reset == IntPtr.Zero)
				id_reset = JNIEnv.GetMethodID (class_ref, "reset", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_reset);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "reset", "()V"));
			} finally {
			}
		}

	}
}
