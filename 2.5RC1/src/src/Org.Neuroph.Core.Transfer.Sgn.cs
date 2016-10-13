using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Core.Transfer {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.core.transfer']/class[@name='Sgn']"
	[global::Android.Runtime.Register ("org/neuroph/core/transfer/Sgn", DoNotGenerateAcw=true)]
	public partial class Sgn : global::Org.Neuroph.Core.Transfer.TransferFunction, global::Java.IO.ISerializable {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/core/transfer/Sgn", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Sgn); }
		}

		protected Sgn (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.core.transfer']/class[@name='Sgn']/constructor[@name='Sgn' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Sgn ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Sgn)) {
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

		static Delegate cb_getProperties;
#pragma warning disable 0169
		static Delegate GetGetPropertiesHandler ()
		{
			if (cb_getProperties == null)
				cb_getProperties = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetProperties);
			return cb_getProperties;
		}

		static IntPtr n_GetProperties (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Core.Transfer.Sgn __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Transfer.Sgn> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Properties);
		}
#pragma warning restore 0169

		static IntPtr id_getProperties;
		public virtual unsafe global::Java.Util.Properties Properties {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.transfer']/class[@name='Sgn']/method[@name='getProperties' and count(parameter)=0]"
			[Register ("getProperties", "()Ljava/util/Properties;", "GetGetPropertiesHandler")]
			get {
				if (id_getProperties == IntPtr.Zero)
					id_getProperties = JNIEnv.GetMethodID (class_ref, "getProperties", "()Ljava/util/Properties;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Util.Properties> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getProperties), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Util.Properties> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getProperties", "()Ljava/util/Properties;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			global::Org.Neuroph.Core.Transfer.Sgn __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Transfer.Sgn> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetOutput (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getOutput_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.transfer']/class[@name='Sgn']/method[@name='getOutput' and count(parameter)=1 and parameter[1][@type='double']]"
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

	}
}
