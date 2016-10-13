using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Core.Transfer {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.core.transfer']/class[@name='Gaussian']"
	[global::Android.Runtime.Register ("org/neuroph/core/transfer/Gaussian", DoNotGenerateAcw=true)]
	public partial class Gaussian : global::Org.Neuroph.Core.Transfer.TransferFunction, global::Java.IO.ISerializable {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/core/transfer/Gaussian", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Gaussian); }
		}

		protected Gaussian (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.core.transfer']/class[@name='Gaussian']/constructor[@name='Gaussian' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Gaussian ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Gaussian)) {
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

		static IntPtr id_ctor_Lorg_neuroph_util_Properties_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.core.transfer']/class[@name='Gaussian']/constructor[@name='Gaussian' and count(parameter)=1 and parameter[1][@type='org.neuroph.util.Properties']]"
		[Register (".ctor", "(Lorg/neuroph/util/Properties;)V", "")]
		public unsafe Gaussian (global::Org.Neuroph.Util.Properties p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (Gaussian)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/neuroph/util/Properties;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/neuroph/util/Properties;)V", __args);
					return;
				}

				if (id_ctor_Lorg_neuroph_util_Properties_ == IntPtr.Zero)
					id_ctor_Lorg_neuroph_util_Properties_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/neuroph/util/Properties;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_neuroph_util_Properties_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_neuroph_util_Properties_, __args);
			} finally {
			}
		}

		static Delegate cb_getSigma;
#pragma warning disable 0169
		static Delegate GetGetSigmaHandler ()
		{
			if (cb_getSigma == null)
				cb_getSigma = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetSigma);
			return cb_getSigma;
		}

		static double n_GetSigma (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Core.Transfer.Gaussian __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Transfer.Gaussian> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Sigma;
		}
#pragma warning restore 0169

		static Delegate cb_setSigma_D;
#pragma warning disable 0169
		static Delegate GetSetSigma_DHandler ()
		{
			if (cb_setSigma_D == null)
				cb_setSigma_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetSigma_D);
			return cb_setSigma_D;
		}

		static void n_SetSigma_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Org.Neuroph.Core.Transfer.Gaussian __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Transfer.Gaussian> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Sigma = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getSigma;
		static IntPtr id_setSigma_D;
		public virtual unsafe double Sigma {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.transfer']/class[@name='Gaussian']/method[@name='getSigma' and count(parameter)=0]"
			[Register ("getSigma", "()D", "GetGetSigmaHandler")]
			get {
				if (id_getSigma == IntPtr.Zero)
					id_getSigma = JNIEnv.GetMethodID (class_ref, "getSigma", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getSigma);
					else
						return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSigma", "()D"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.transfer']/class[@name='Gaussian']/method[@name='setSigma' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setSigma", "(D)V", "GetSetSigma_DHandler")]
			set {
				if (id_setSigma_D == IntPtr.Zero)
					id_setSigma_D = JNIEnv.GetMethodID (class_ref, "setSigma", "(D)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSigma_D, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSigma", "(D)V"), __args);
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
			global::Org.Neuroph.Core.Transfer.Gaussian __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Transfer.Gaussian> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetOutput (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getOutput_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.transfer']/class[@name='Gaussian']/method[@name='getOutput' and count(parameter)=1 and parameter[1][@type='double']]"
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
