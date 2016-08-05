using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Core.Transfer {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.core.transfer']/class[@name='Ramp']"
	[global::Android.Runtime.Register ("org/neuroph/core/transfer/Ramp", DoNotGenerateAcw=true)]
	public partial class Ramp : global::Org.Neuroph.Core.Transfer.TransferFunction, global::Java.IO.ISerializable {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/core/transfer/Ramp", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Ramp); }
		}

		protected Ramp (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_DDDDD;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.core.transfer']/class[@name='Ramp']/constructor[@name='Ramp' and count(parameter)=5 and parameter[1][@type='double'] and parameter[2][@type='double'] and parameter[3][@type='double'] and parameter[4][@type='double'] and parameter[5][@type='double']]"
		[Register (".ctor", "(DDDDD)V", "")]
		public unsafe Ramp (double p0, double p1, double p2, double p3, double p4)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				if (GetType () != typeof (Ramp)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(DDDDD)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(DDDDD)V", __args);
					return;
				}

				if (id_ctor_DDDDD == IntPtr.Zero)
					id_ctor_DDDDD = JNIEnv.GetMethodID (class_ref, "<init>", "(DDDDD)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_DDDDD, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_DDDDD, __args);
			} finally {
			}
		}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.core.transfer']/class[@name='Ramp']/constructor[@name='Ramp' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Ramp ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Ramp)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.core.transfer']/class[@name='Ramp']/constructor[@name='Ramp' and count(parameter)=1 and parameter[1][@type='org.neuroph.util.Properties']]"
		[Register (".ctor", "(Lorg/neuroph/util/Properties;)V", "")]
		public unsafe Ramp (global::Org.Neuroph.Util.Properties p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (Ramp)) {
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

		static Delegate cb_getXHigh;
#pragma warning disable 0169
		static Delegate GetGetXHighHandler ()
		{
			if (cb_getXHigh == null)
				cb_getXHigh = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetXHigh);
			return cb_getXHigh;
		}

		static double n_GetXHigh (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Core.Transfer.Ramp __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Transfer.Ramp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.XHigh;
		}
#pragma warning restore 0169

		static Delegate cb_setXHigh_D;
#pragma warning disable 0169
		static Delegate GetSetXHigh_DHandler ()
		{
			if (cb_setXHigh_D == null)
				cb_setXHigh_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetXHigh_D);
			return cb_setXHigh_D;
		}

		static void n_SetXHigh_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Org.Neuroph.Core.Transfer.Ramp __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Transfer.Ramp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.XHigh = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getXHigh;
		static IntPtr id_setXHigh_D;
		public virtual unsafe double XHigh {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.transfer']/class[@name='Ramp']/method[@name='getXHigh' and count(parameter)=0]"
			[Register ("getXHigh", "()D", "GetGetXHighHandler")]
			get {
				if (id_getXHigh == IntPtr.Zero)
					id_getXHigh = JNIEnv.GetMethodID (class_ref, "getXHigh", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod  (Handle, id_getXHigh);
					else
						return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getXHigh", "()D"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.transfer']/class[@name='Ramp']/method[@name='setXHigh' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setXHigh", "(D)V", "GetSetXHigh_DHandler")]
			set {
				if (id_setXHigh_D == IntPtr.Zero)
					id_setXHigh_D = JNIEnv.GetMethodID (class_ref, "setXHigh", "(D)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setXHigh_D, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setXHigh", "(D)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getXLow;
#pragma warning disable 0169
		static Delegate GetGetXLowHandler ()
		{
			if (cb_getXLow == null)
				cb_getXLow = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetXLow);
			return cb_getXLow;
		}

		static double n_GetXLow (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Core.Transfer.Ramp __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Transfer.Ramp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.XLow;
		}
#pragma warning restore 0169

		static Delegate cb_setXLow_D;
#pragma warning disable 0169
		static Delegate GetSetXLow_DHandler ()
		{
			if (cb_setXLow_D == null)
				cb_setXLow_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetXLow_D);
			return cb_setXLow_D;
		}

		static void n_SetXLow_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Org.Neuroph.Core.Transfer.Ramp __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Transfer.Ramp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.XLow = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getXLow;
		static IntPtr id_setXLow_D;
		public virtual unsafe double XLow {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.transfer']/class[@name='Ramp']/method[@name='getXLow' and count(parameter)=0]"
			[Register ("getXLow", "()D", "GetGetXLowHandler")]
			get {
				if (id_getXLow == IntPtr.Zero)
					id_getXLow = JNIEnv.GetMethodID (class_ref, "getXLow", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod  (Handle, id_getXLow);
					else
						return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getXLow", "()D"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.transfer']/class[@name='Ramp']/method[@name='setXLow' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setXLow", "(D)V", "GetSetXLow_DHandler")]
			set {
				if (id_setXLow_D == IntPtr.Zero)
					id_setXLow_D = JNIEnv.GetMethodID (class_ref, "setXLow", "(D)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setXLow_D, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setXLow", "(D)V"), __args);
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
			global::Org.Neuroph.Core.Transfer.Ramp __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Transfer.Ramp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Org.Neuroph.Core.Transfer.Ramp __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Transfer.Ramp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.YHigh = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getYHigh;
		static IntPtr id_setYHigh_D;
		public virtual unsafe double YHigh {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.transfer']/class[@name='Ramp']/method[@name='getYHigh' and count(parameter)=0]"
			[Register ("getYHigh", "()D", "GetGetYHighHandler")]
			get {
				if (id_getYHigh == IntPtr.Zero)
					id_getYHigh = JNIEnv.GetMethodID (class_ref, "getYHigh", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod  (Handle, id_getYHigh);
					else
						return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getYHigh", "()D"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.transfer']/class[@name='Ramp']/method[@name='setYHigh' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setYHigh", "(D)V", "GetSetYHigh_DHandler")]
			set {
				if (id_setYHigh_D == IntPtr.Zero)
					id_setYHigh_D = JNIEnv.GetMethodID (class_ref, "setYHigh", "(D)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setYHigh_D, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setYHigh", "(D)V"), __args);
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
			global::Org.Neuroph.Core.Transfer.Ramp __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Transfer.Ramp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Org.Neuroph.Core.Transfer.Ramp __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Transfer.Ramp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.YLow = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getYLow;
		static IntPtr id_setYLow_D;
		public virtual unsafe double YLow {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.transfer']/class[@name='Ramp']/method[@name='getYLow' and count(parameter)=0]"
			[Register ("getYLow", "()D", "GetGetYLowHandler")]
			get {
				if (id_getYLow == IntPtr.Zero)
					id_getYLow = JNIEnv.GetMethodID (class_ref, "getYLow", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod  (Handle, id_getYLow);
					else
						return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getYLow", "()D"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.transfer']/class[@name='Ramp']/method[@name='setYLow' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setYLow", "(D)V", "GetSetYLow_DHandler")]
			set {
				if (id_setYLow_D == IntPtr.Zero)
					id_setYLow_D = JNIEnv.GetMethodID (class_ref, "setYLow", "(D)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setYLow_D, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setYLow", "(D)V"), __args);
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
			global::Org.Neuroph.Core.Transfer.Ramp __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Transfer.Ramp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetOutput (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getOutput_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.transfer']/class[@name='Ramp']/method[@name='getOutput' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("getOutput", "(D)D", "GetGetOutput_DHandler")]
		public override unsafe double GetOutput (double p0)
		{
			if (id_getOutput_D == IntPtr.Zero)
				id_getOutput_D = JNIEnv.GetMethodID (class_ref, "getOutput", "(D)D");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.CallDoubleMethod  (Handle, id_getOutput_D, __args);
				else
					return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOutput", "(D)D"), __args);
			} finally {
			}
		}

	}
}
