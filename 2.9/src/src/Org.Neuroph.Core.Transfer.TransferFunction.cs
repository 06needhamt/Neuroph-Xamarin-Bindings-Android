using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Core.Transfer {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.core.transfer']/class[@name='TransferFunction']"
	[global::Android.Runtime.Register ("org/neuroph/core/transfer/TransferFunction", DoNotGenerateAcw=true)]
	public abstract partial class TransferFunction : global::Java.Lang.Object, global::Java.IO.ISerializable {


		static IntPtr output_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.neuroph.core.transfer']/class[@name='TransferFunction']/field[@name='output']"
		[Register ("output")]
		protected double Output {
			get {
				if (output_jfieldId == IntPtr.Zero)
					output_jfieldId = JNIEnv.GetFieldID (class_ref, "output", "D");
				return JNIEnv.GetDoubleField (((global::Java.Lang.Object) this).Handle, output_jfieldId);
			}
			set {
				if (output_jfieldId == IntPtr.Zero)
					output_jfieldId = JNIEnv.GetFieldID (class_ref, "output", "D");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, output_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/core/transfer/TransferFunction", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TransferFunction); }
		}

		protected TransferFunction (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.core.transfer']/class[@name='TransferFunction']/constructor[@name='TransferFunction' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TransferFunction ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (TransferFunction)) {
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

		static Delegate cb_getDerivative_D;
#pragma warning disable 0169
		static Delegate GetGetDerivative_DHandler ()
		{
			if (cb_getDerivative_D == null)
				cb_getDerivative_D = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double, double>) n_GetDerivative_D);
			return cb_getDerivative_D;
		}

		static double n_GetDerivative_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Org.Neuroph.Core.Transfer.TransferFunction __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Transfer.TransferFunction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetDerivative (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getDerivative_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.transfer']/class[@name='TransferFunction']/method[@name='getDerivative' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("getDerivative", "(D)D", "GetGetDerivative_DHandler")]
		public virtual unsafe double GetDerivative (double p0)
		{
			if (id_getDerivative_D == IntPtr.Zero)
				id_getDerivative_D = JNIEnv.GetMethodID (class_ref, "getDerivative", "(D)D");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getDerivative_D, __args);
				else
					return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDerivative", "(D)D"), __args);
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
			global::Org.Neuroph.Core.Transfer.TransferFunction __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Transfer.TransferFunction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetOutput (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.transfer']/class[@name='TransferFunction']/method[@name='getOutput' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("getOutput", "(D)D", "GetGetOutput_DHandler")]
		public abstract double GetOutput (double p0);

	}

	[global::Android.Runtime.Register ("org/neuroph/core/transfer/TransferFunction", DoNotGenerateAcw=true)]
	internal partial class TransferFunctionInvoker : TransferFunction {

		public TransferFunctionInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (TransferFunctionInvoker); }
		}

		static IntPtr id_getOutput_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.transfer']/class[@name='TransferFunction']/method[@name='getOutput' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("getOutput", "(D)D", "GetGetOutput_DHandler")]
		public override unsafe double GetOutput (double p0)
		{
			if (id_getOutput_D == IntPtr.Zero)
				id_getOutput_D = JNIEnv.GetMethodID (class_ref, "getOutput", "(D)D");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getOutput_D, __args);
			} finally {
			}
		}

	}

}
