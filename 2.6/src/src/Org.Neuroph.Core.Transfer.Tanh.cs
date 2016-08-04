using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Core.Transfer {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.core.transfer']/class[@name='Tanh']"
	[global::Android.Runtime.Register ("org/neuroph/core/transfer/Tanh", DoNotGenerateAcw=true)]
	public partial class Tanh : global::Org.Neuroph.Core.Transfer.TransferFunction, global::Java.IO.ISerializable {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/core/transfer/Tanh", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Tanh); }
		}

		protected Tanh (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.core.transfer']/class[@name='Tanh']/constructor[@name='Tanh' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Tanh ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Tanh)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static IntPtr id_ctor_Lorg_neuroph_util_Properties_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.core.transfer']/class[@name='Tanh']/constructor[@name='Tanh' and count(parameter)=1 and parameter[1][@type='org.neuroph.util.Properties']]"
		[Register (".ctor", "(Lorg/neuroph/util/Properties;)V", "")]
		public unsafe Tanh (global::Org.Neuroph.Util.Properties p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (Tanh)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/neuroph/util/Properties;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorg/neuroph/util/Properties;)V", __args);
					return;
				}

				if (id_ctor_Lorg_neuroph_util_Properties_ == IntPtr.Zero)
					id_ctor_Lorg_neuroph_util_Properties_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/neuroph/util/Properties;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_neuroph_util_Properties_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_neuroph_util_Properties_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_D;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.core.transfer']/class[@name='Tanh']/constructor[@name='Tanh' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register (".ctor", "(D)V", "")]
		public unsafe Tanh (double p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (Tanh)) {
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

		static Delegate cb_getSlope;
#pragma warning disable 0169
		static Delegate GetGetSlopeHandler ()
		{
			if (cb_getSlope == null)
				cb_getSlope = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetSlope);
			return cb_getSlope;
		}

		static double n_GetSlope (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Core.Transfer.Tanh __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Transfer.Tanh> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Slope;
		}
#pragma warning restore 0169

		static Delegate cb_setSlope_D;
#pragma warning disable 0169
		static Delegate GetSetSlope_DHandler ()
		{
			if (cb_setSlope_D == null)
				cb_setSlope_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetSlope_D);
			return cb_setSlope_D;
		}

		static void n_SetSlope_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Org.Neuroph.Core.Transfer.Tanh __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Transfer.Tanh> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Slope = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getSlope;
		static IntPtr id_setSlope_D;
		public virtual unsafe double Slope {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.transfer']/class[@name='Tanh']/method[@name='getSlope' and count(parameter)=0]"
			[Register ("getSlope", "()D", "GetGetSlopeHandler")]
			get {
				if (id_getSlope == IntPtr.Zero)
					id_getSlope = JNIEnv.GetMethodID (class_ref, "getSlope", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod  (Handle, id_getSlope);
					else
						return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSlope", "()D"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.transfer']/class[@name='Tanh']/method[@name='setSlope' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setSlope", "(D)V", "GetSetSlope_DHandler")]
			set {
				if (id_setSlope_D == IntPtr.Zero)
					id_setSlope_D = JNIEnv.GetMethodID (class_ref, "setSlope", "(D)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setSlope_D, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSlope", "(D)V"), __args);
				} finally {
				}
			}
		}

		static IntPtr id_getDerivative_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.transfer']/class[@name='Tanh']/method[@name='getDerivative' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("getDerivative", "(D)D", "")]
		public override sealed unsafe double GetDerivative (double p0)
		{
			if (id_getDerivative_D == IntPtr.Zero)
				id_getDerivative_D = JNIEnv.GetMethodID (class_ref, "getDerivative", "(D)D");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallDoubleMethod  (Handle, id_getDerivative_D, __args);
			} finally {
			}
		}

		static IntPtr id_getOutput_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.transfer']/class[@name='Tanh']/method[@name='getOutput' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("getOutput", "(D)D", "")]
		public override sealed unsafe double GetOutput (double p0)
		{
			if (id_getOutput_D == IntPtr.Zero)
				id_getOutput_D = JNIEnv.GetMethodID (class_ref, "getOutput", "(D)D");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallDoubleMethod  (Handle, id_getOutput_D, __args);
			} finally {
			}
		}

	}
}
