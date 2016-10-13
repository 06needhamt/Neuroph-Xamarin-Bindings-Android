using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Nnet.Flat {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.nnet.flat']/class[@name='FlatWeight']"
	[global::Android.Runtime.Register ("org/neuroph/nnet/flat/FlatWeight", DoNotGenerateAcw=true)]
	public partial class FlatWeight : global::Org.Neuroph.Core.Weight {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/nnet/flat/FlatWeight", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FlatWeight); }
		}

		protected FlatWeight (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_arrayDI;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.nnet.flat']/class[@name='FlatWeight']/constructor[@name='FlatWeight' and count(parameter)=2 and parameter[1][@type='double[]'] and parameter[2][@type='int']]"
		[Register (".ctor", "([DI)V", "")]
		public unsafe FlatWeight (double[] p0, int p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (FlatWeight)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "([DI)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "([DI)V", __args);
					return;
				}

				if (id_ctor_arrayDI == IntPtr.Zero)
					id_ctor_arrayDI = JNIEnv.GetMethodID (class_ref, "<init>", "([DI)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayDI, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_arrayDI, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_ctor_D;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.nnet.flat']/class[@name='FlatWeight']/constructor[@name='FlatWeight' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register (".ctor", "(D)V", "")]
		public unsafe FlatWeight (double p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (FlatWeight)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(D)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(D)V", __args);
					return;
				}

				if (id_ctor_D == IntPtr.Zero)
					id_ctor_D = JNIEnv.GetMethodID (class_ref, "<init>", "(D)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_D, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_D, __args);
			} finally {
			}
		}

		static Delegate cb_getPreviousValue;
#pragma warning disable 0169
		static Delegate GetGetPreviousValueHandler ()
		{
			if (cb_getPreviousValue == null)
				cb_getPreviousValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetPreviousValue);
			return cb_getPreviousValue;
		}

		static double n_GetPreviousValue (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Nnet.Flat.FlatWeight __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Flat.FlatWeight> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PreviousValue;
		}
#pragma warning restore 0169

		static Delegate cb_setPreviousValue_D;
#pragma warning disable 0169
		static Delegate GetSetPreviousValue_DHandler ()
		{
			if (cb_setPreviousValue_D == null)
				cb_setPreviousValue_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetPreviousValue_D);
			return cb_setPreviousValue_D;
		}

		static void n_SetPreviousValue_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Org.Neuroph.Nnet.Flat.FlatWeight __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Flat.FlatWeight> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PreviousValue = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getPreviousValue;
		static IntPtr id_setPreviousValue_D;
		public virtual unsafe double PreviousValue {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.flat']/class[@name='FlatWeight']/method[@name='getPreviousValue' and count(parameter)=0]"
			[Register ("getPreviousValue", "()D", "GetGetPreviousValueHandler")]
			get {
				if (id_getPreviousValue == IntPtr.Zero)
					id_getPreviousValue = JNIEnv.GetMethodID (class_ref, "getPreviousValue", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getPreviousValue);
					else
						return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPreviousValue", "()D"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.flat']/class[@name='FlatWeight']/method[@name='setPreviousValue' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setPreviousValue", "(D)V", "GetSetPreviousValue_DHandler")]
			set {
				if (id_setPreviousValue_D == IntPtr.Zero)
					id_setPreviousValue_D = JNIEnv.GetMethodID (class_ref, "setPreviousValue", "(D)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPreviousValue_D, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPreviousValue", "(D)V"), __args);
				} finally {
				}
			}
		}

	}
}
