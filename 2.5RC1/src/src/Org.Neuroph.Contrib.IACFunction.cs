using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Contrib {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.contrib']/class[@name='IACFunction']"
	[global::Android.Runtime.Register ("org/neuroph/contrib/IACFunction", DoNotGenerateAcw=true)]
	public partial class IACFunction : global::Org.Neuroph.Core.Transfer.TransferFunction {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/contrib/IACFunction", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IACFunction); }
		}

		protected IACFunction (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.contrib']/class[@name='IACFunction']/constructor[@name='IACFunction' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe IACFunction ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (IACFunction)) {
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

		static Delegate cb_getOutput_D;
#pragma warning disable 0169
		static Delegate GetGetOutput_DHandler ()
		{
			if (cb_getOutput_D == null)
				cb_getOutput_D = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double, double>) n_GetOutput_D);
			return cb_getOutput_D;
		}

		static double n_GetOutput_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Org.Neuroph.Contrib.IACFunction __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.IACFunction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetOutput (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getOutput_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.contrib']/class[@name='IACFunction']/method[@name='getOutput' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("getOutput", "(D)D", "GetGetOutput_DHandler")]
		public override unsafe double GetOutput (double p0)
		{
			if (id_getOutput_D == IntPtr.Zero)
				id_getOutput_D = JNIEnv.GetMethodID (class_ref, "getOutput", "(D)D");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getOutput_D, __args);
				else
					return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOutput", "(D)D"), __args);
			} finally {
			}
		}

		static Delegate cb_getOutput_DD;
#pragma warning disable 0169
		static Delegate GetGetOutput_DDHandler ()
		{
			if (cb_getOutput_DD == null)
				cb_getOutput_DD = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double, double, double>) n_GetOutput_DD);
			return cb_getOutput_DD;
		}

		static double n_GetOutput_DD (IntPtr jnienv, IntPtr native__this, double p0, double p1)
		{
			global::Org.Neuroph.Contrib.IACFunction __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.IACFunction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetOutput (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_getOutput_DD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.contrib']/class[@name='IACFunction']/method[@name='getOutput' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='double']]"
		[Register ("getOutput", "(DD)D", "GetGetOutput_DDHandler")]
		public virtual unsafe double GetOutput (double p0, double p1)
		{
			if (id_getOutput_DD == IntPtr.Zero)
				id_getOutput_DD = JNIEnv.GetMethodID (class_ref, "getOutput", "(DD)D");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getOutput_DD, __args);
				else
					return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOutput", "(DD)D"), __args);
			} finally {
			}
		}

	}
}
