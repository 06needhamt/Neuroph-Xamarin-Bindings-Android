using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Core.Transfer {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.core.transfer']/class[@name='Trapezoid']"
	[global::Android.Runtime.Register ("org/neuroph/core/transfer/Trapezoid", DoNotGenerateAcw=true)]
	public partial class Trapezoid : global::Org.Neuroph.Core.Transfer.TransferFunction, global::Java.IO.ISerializable {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/core/transfer/Trapezoid", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Trapezoid); }
		}

		protected Trapezoid (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_neuroph_util_Properties_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.core.transfer']/class[@name='Trapezoid']/constructor[@name='Trapezoid' and count(parameter)=1 and parameter[1][@type='org.neuroph.util.Properties']]"
		[Register (".ctor", "(Lorg/neuroph/util/Properties;)V", "")]
		public unsafe Trapezoid (global::Org.Neuroph.Util.Properties p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (Trapezoid)) {
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

		static IntPtr id_ctor_DDDD;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.core.transfer']/class[@name='Trapezoid']/constructor[@name='Trapezoid' and count(parameter)=4 and parameter[1][@type='double'] and parameter[2][@type='double'] and parameter[3][@type='double'] and parameter[4][@type='double']]"
		[Register (".ctor", "(DDDD)V", "")]
		public unsafe Trapezoid (double p0, double p1, double p2, double p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				if (GetType () != typeof (Trapezoid)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(DDDD)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(DDDD)V", __args);
					return;
				}

				if (id_ctor_DDDD == IntPtr.Zero)
					id_ctor_DDDD = JNIEnv.GetMethodID (class_ref, "<init>", "(DDDD)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_DDDD, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_DDDD, __args);
			} finally {
			}
		}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.core.transfer']/class[@name='Trapezoid']/constructor[@name='Trapezoid' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Trapezoid ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Trapezoid)) {
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

		static Delegate cb_getLeftHigh;
#pragma warning disable 0169
		static Delegate GetGetLeftHighHandler ()
		{
			if (cb_getLeftHigh == null)
				cb_getLeftHigh = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetLeftHigh);
			return cb_getLeftHigh;
		}

		static double n_GetLeftHigh (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Core.Transfer.Trapezoid __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Transfer.Trapezoid> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LeftHigh;
		}
#pragma warning restore 0169

		static Delegate cb_setLeftHigh_D;
#pragma warning disable 0169
		static Delegate GetSetLeftHigh_DHandler ()
		{
			if (cb_setLeftHigh_D == null)
				cb_setLeftHigh_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetLeftHigh_D);
			return cb_setLeftHigh_D;
		}

		static void n_SetLeftHigh_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Org.Neuroph.Core.Transfer.Trapezoid __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Transfer.Trapezoid> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.LeftHigh = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getLeftHigh;
		static IntPtr id_setLeftHigh_D;
		public virtual unsafe double LeftHigh {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.transfer']/class[@name='Trapezoid']/method[@name='getLeftHigh' and count(parameter)=0]"
			[Register ("getLeftHigh", "()D", "GetGetLeftHighHandler")]
			get {
				if (id_getLeftHigh == IntPtr.Zero)
					id_getLeftHigh = JNIEnv.GetMethodID (class_ref, "getLeftHigh", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getLeftHigh);
					else
						return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLeftHigh", "()D"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.transfer']/class[@name='Trapezoid']/method[@name='setLeftHigh' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setLeftHigh", "(D)V", "GetSetLeftHigh_DHandler")]
			set {
				if (id_setLeftHigh_D == IntPtr.Zero)
					id_setLeftHigh_D = JNIEnv.GetMethodID (class_ref, "setLeftHigh", "(D)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLeftHigh_D, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLeftHigh", "(D)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getLeftLow;
#pragma warning disable 0169
		static Delegate GetGetLeftLowHandler ()
		{
			if (cb_getLeftLow == null)
				cb_getLeftLow = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetLeftLow);
			return cb_getLeftLow;
		}

		static double n_GetLeftLow (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Core.Transfer.Trapezoid __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Transfer.Trapezoid> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LeftLow;
		}
#pragma warning restore 0169

		static Delegate cb_setLeftLow_D;
#pragma warning disable 0169
		static Delegate GetSetLeftLow_DHandler ()
		{
			if (cb_setLeftLow_D == null)
				cb_setLeftLow_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetLeftLow_D);
			return cb_setLeftLow_D;
		}

		static void n_SetLeftLow_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Org.Neuroph.Core.Transfer.Trapezoid __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Transfer.Trapezoid> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.LeftLow = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getLeftLow;
		static IntPtr id_setLeftLow_D;
		public virtual unsafe double LeftLow {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.transfer']/class[@name='Trapezoid']/method[@name='getLeftLow' and count(parameter)=0]"
			[Register ("getLeftLow", "()D", "GetGetLeftLowHandler")]
			get {
				if (id_getLeftLow == IntPtr.Zero)
					id_getLeftLow = JNIEnv.GetMethodID (class_ref, "getLeftLow", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getLeftLow);
					else
						return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLeftLow", "()D"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.transfer']/class[@name='Trapezoid']/method[@name='setLeftLow' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setLeftLow", "(D)V", "GetSetLeftLow_DHandler")]
			set {
				if (id_setLeftLow_D == IntPtr.Zero)
					id_setLeftLow_D = JNIEnv.GetMethodID (class_ref, "setLeftLow", "(D)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLeftLow_D, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLeftLow", "(D)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getRightHigh;
#pragma warning disable 0169
		static Delegate GetGetRightHighHandler ()
		{
			if (cb_getRightHigh == null)
				cb_getRightHigh = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetRightHigh);
			return cb_getRightHigh;
		}

		static double n_GetRightHigh (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Core.Transfer.Trapezoid __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Transfer.Trapezoid> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RightHigh;
		}
#pragma warning restore 0169

		static Delegate cb_setRightHigh_D;
#pragma warning disable 0169
		static Delegate GetSetRightHigh_DHandler ()
		{
			if (cb_setRightHigh_D == null)
				cb_setRightHigh_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetRightHigh_D);
			return cb_setRightHigh_D;
		}

		static void n_SetRightHigh_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Org.Neuroph.Core.Transfer.Trapezoid __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Transfer.Trapezoid> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RightHigh = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getRightHigh;
		static IntPtr id_setRightHigh_D;
		public virtual unsafe double RightHigh {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.transfer']/class[@name='Trapezoid']/method[@name='getRightHigh' and count(parameter)=0]"
			[Register ("getRightHigh", "()D", "GetGetRightHighHandler")]
			get {
				if (id_getRightHigh == IntPtr.Zero)
					id_getRightHigh = JNIEnv.GetMethodID (class_ref, "getRightHigh", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getRightHigh);
					else
						return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRightHigh", "()D"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.transfer']/class[@name='Trapezoid']/method[@name='setRightHigh' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setRightHigh", "(D)V", "GetSetRightHigh_DHandler")]
			set {
				if (id_setRightHigh_D == IntPtr.Zero)
					id_setRightHigh_D = JNIEnv.GetMethodID (class_ref, "setRightHigh", "(D)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRightHigh_D, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRightHigh", "(D)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getRightLow;
#pragma warning disable 0169
		static Delegate GetGetRightLowHandler ()
		{
			if (cb_getRightLow == null)
				cb_getRightLow = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetRightLow);
			return cb_getRightLow;
		}

		static double n_GetRightLow (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Core.Transfer.Trapezoid __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Transfer.Trapezoid> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RightLow;
		}
#pragma warning restore 0169

		static Delegate cb_setRightLow_D;
#pragma warning disable 0169
		static Delegate GetSetRightLow_DHandler ()
		{
			if (cb_setRightLow_D == null)
				cb_setRightLow_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetRightLow_D);
			return cb_setRightLow_D;
		}

		static void n_SetRightLow_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Org.Neuroph.Core.Transfer.Trapezoid __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Transfer.Trapezoid> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RightLow = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getRightLow;
		static IntPtr id_setRightLow_D;
		public virtual unsafe double RightLow {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.transfer']/class[@name='Trapezoid']/method[@name='getRightLow' and count(parameter)=0]"
			[Register ("getRightLow", "()D", "GetGetRightLowHandler")]
			get {
				if (id_getRightLow == IntPtr.Zero)
					id_getRightLow = JNIEnv.GetMethodID (class_ref, "getRightLow", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getRightLow);
					else
						return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRightLow", "()D"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.transfer']/class[@name='Trapezoid']/method[@name='setRightLow' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setRightLow", "(D)V", "GetSetRightLow_DHandler")]
			set {
				if (id_setRightLow_D == IntPtr.Zero)
					id_setRightLow_D = JNIEnv.GetMethodID (class_ref, "setRightLow", "(D)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRightLow_D, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRightLow", "(D)V"), __args);
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
			global::Org.Neuroph.Core.Transfer.Trapezoid __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Transfer.Trapezoid> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetOutput (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getOutput_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.transfer']/class[@name='Trapezoid']/method[@name='getOutput' and count(parameter)=1 and parameter[1][@type='double']]"
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
