using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Core.Transfer {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.core.transfer']/class[@name='Step']"
	[global::Android.Runtime.Register ("org/neuroph/core/transfer/Step", DoNotGenerateAcw=true)]
	public partial class Step : global::Org.Neuroph.Core.Transfer.TransferFunction, global::Java.IO.ISerializable {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/core/transfer/Step", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Step); }
		}

		protected Step (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.core.transfer']/class[@name='Step']/constructor[@name='Step' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Step ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Step)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.core.transfer']/class[@name='Step']/constructor[@name='Step' and count(parameter)=1 and parameter[1][@type='org.neuroph.util.Properties']]"
		[Register (".ctor", "(Lorg/neuroph/util/Properties;)V", "")]
		public unsafe Step (global::Org.Neuroph.Util.Properties p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (Step)) {
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
			global::Org.Neuroph.Core.Transfer.Step __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Transfer.Step> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Properties);
		}
#pragma warning restore 0169

		static IntPtr id_getProperties;
		public virtual unsafe global::Org.Neuroph.Util.Properties Properties {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.transfer']/class[@name='Step']/method[@name='getProperties' and count(parameter)=0]"
			[Register ("getProperties", "()Lorg/neuroph/util/Properties;", "GetGetPropertiesHandler")]
			get {
				if (id_getProperties == IntPtr.Zero)
					id_getProperties = JNIEnv.GetMethodID (class_ref, "getProperties", "()Lorg/neuroph/util/Properties;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.Properties> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getProperties), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.Properties> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getProperties", "()Lorg/neuroph/util/Properties;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getYHigh;
#pragma warning disable 0169
		static Delegate GetGetYHighHandler ()
		{
			if (cb_getYHigh == null)
				cb_getYHigh = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetYHigh);
			return cb_getYHigh;
		}

		static double n_GetYHigh (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Core.Transfer.Step __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Transfer.Step> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.YHigh;
		}
#pragma warning restore 0169

		static Delegate cb_setYHigh_D;
#pragma warning disable 0169
		static Delegate GetSetYHigh_DHandler ()
		{
			if (cb_setYHigh_D == null)
				cb_setYHigh_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetYHigh_D);
			return cb_setYHigh_D;
		}

		static void n_SetYHigh_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Org.Neuroph.Core.Transfer.Step __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Transfer.Step> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.YHigh = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getYHigh;
		static IntPtr id_setYHigh_D;
		public virtual unsafe double YHigh {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.transfer']/class[@name='Step']/method[@name='getYHigh' and count(parameter)=0]"
			[Register ("getYHigh", "()D", "GetGetYHighHandler")]
			get {
				if (id_getYHigh == IntPtr.Zero)
					id_getYHigh = JNIEnv.GetMethodID (class_ref, "getYHigh", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getYHigh);
					else
						return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getYHigh", "()D"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.transfer']/class[@name='Step']/method[@name='setYHigh' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setYHigh", "(D)V", "GetSetYHigh_DHandler")]
			set {
				if (id_setYHigh_D == IntPtr.Zero)
					id_setYHigh_D = JNIEnv.GetMethodID (class_ref, "setYHigh", "(D)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setYHigh_D, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setYHigh", "(D)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getYLow;
#pragma warning disable 0169
		static Delegate GetGetYLowHandler ()
		{
			if (cb_getYLow == null)
				cb_getYLow = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetYLow);
			return cb_getYLow;
		}

		static double n_GetYLow (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Core.Transfer.Step __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Transfer.Step> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.YLow;
		}
#pragma warning restore 0169

		static Delegate cb_setYLow_D;
#pragma warning disable 0169
		static Delegate GetSetYLow_DHandler ()
		{
			if (cb_setYLow_D == null)
				cb_setYLow_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetYLow_D);
			return cb_setYLow_D;
		}

		static void n_SetYLow_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Org.Neuroph.Core.Transfer.Step __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Transfer.Step> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.YLow = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getYLow;
		static IntPtr id_setYLow_D;
		public virtual unsafe double YLow {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.transfer']/class[@name='Step']/method[@name='getYLow' and count(parameter)=0]"
			[Register ("getYLow", "()D", "GetGetYLowHandler")]
			get {
				if (id_getYLow == IntPtr.Zero)
					id_getYLow = JNIEnv.GetMethodID (class_ref, "getYLow", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getYLow);
					else
						return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getYLow", "()D"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.transfer']/class[@name='Step']/method[@name='setYLow' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setYLow", "(D)V", "GetSetYLow_DHandler")]
			set {
				if (id_setYLow_D == IntPtr.Zero)
					id_setYLow_D = JNIEnv.GetMethodID (class_ref, "setYLow", "(D)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setYLow_D, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setYLow", "(D)V"), __args);
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
			global::Org.Neuroph.Core.Transfer.Step __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Transfer.Step> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetOutput (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getOutput_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.transfer']/class[@name='Step']/method[@name='getOutput' and count(parameter)=1 and parameter[1][@type='double']]"
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
