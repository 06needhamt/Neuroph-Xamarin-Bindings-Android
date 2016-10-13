using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Core.Input {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.core.input']/class[@name='Or']"
	[global::Android.Runtime.Register ("org/neuroph/core/input/Or", DoNotGenerateAcw=true)]
	public partial class Or : global::Org.Neuroph.Core.Input.InputFunction, global::Java.IO.ISerializable {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/core/input/Or", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Or); }
		}

		protected Or (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.core.input']/class[@name='Or']/constructor[@name='Or' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Or ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Or)) {
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

		static Delegate cb_getOutput_arrayLorg_neuroph_core_Connection_;
#pragma warning disable 0169
		static Delegate GetGetOutput_arrayLorg_neuroph_core_Connection_Handler ()
		{
			if (cb_getOutput_arrayLorg_neuroph_core_Connection_ == null)
				cb_getOutput_arrayLorg_neuroph_core_Connection_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, double>) n_GetOutput_arrayLorg_neuroph_core_Connection_);
			return cb_getOutput_arrayLorg_neuroph_core_Connection_;
		}

		static double n_GetOutput_arrayLorg_neuroph_core_Connection_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Core.Input.Or __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Input.Or> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Core.Connection[] p0 = (global::Org.Neuroph.Core.Connection[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Org.Neuroph.Core.Connection));
			double __ret = __this.GetOutput (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getOutput_arrayLorg_neuroph_core_Connection_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.input']/class[@name='Or']/method[@name='getOutput' and count(parameter)=1 and parameter[1][@type='org.neuroph.core.Connection[]']]"
		[Register ("getOutput", "([Lorg/neuroph/core/Connection;)D", "GetGetOutput_arrayLorg_neuroph_core_Connection_Handler")]
		public override unsafe double GetOutput (global::Org.Neuroph.Core.Connection[] p0)
		{
			if (id_getOutput_arrayLorg_neuroph_core_Connection_ == IntPtr.Zero)
				id_getOutput_arrayLorg_neuroph_core_Connection_ = JNIEnv.GetMethodID (class_ref, "getOutput", "([Lorg/neuroph/core/Connection;)D");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				double __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getOutput_arrayLorg_neuroph_core_Connection_, __args);
				else
					__ret = JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOutput", "([Lorg/neuroph/core/Connection;)D"), __args);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

	}
}
