using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Encog.Engine.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.encog.engine.util']/class[@name='IntRange']"
	[global::Android.Runtime.Register ("org/encog/engine/util/IntRange", DoNotGenerateAcw=true)]
	public partial class IntRange : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/encog/engine/util/IntRange", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IntRange); }
		}

		protected IntRange (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_II;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.encog.engine.util']/class[@name='IntRange']/constructor[@name='IntRange' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register (".ctor", "(II)V", "")]
		public unsafe IntRange (int p0, int p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (IntRange)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(II)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(II)V", __args);
					return;
				}

				if (id_ctor_II == IntPtr.Zero)
					id_ctor_II = JNIEnv.GetMethodID (class_ref, "<init>", "(II)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_II, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_II, __args);
			} finally {
			}
		}

		static Delegate cb_getHigh;
#pragma warning disable 0169
		static Delegate GetGetHighHandler ()
		{
			if (cb_getHigh == null)
				cb_getHigh = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHigh);
			return cb_getHigh;
		}

		static int n_GetHigh (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Util.IntRange __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Util.IntRange> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.High;
		}
#pragma warning restore 0169

		static Delegate cb_setHigh_I;
#pragma warning disable 0169
		static Delegate GetSetHigh_IHandler ()
		{
			if (cb_setHigh_I == null)
				cb_setHigh_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetHigh_I);
			return cb_setHigh_I;
		}

		static void n_SetHigh_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Encog.Engine.Util.IntRange __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Util.IntRange> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.High = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getHigh;
		static IntPtr id_setHigh_I;
		public virtual unsafe int High {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.util']/class[@name='IntRange']/method[@name='getHigh' and count(parameter)=0]"
			[Register ("getHigh", "()I", "GetGetHighHandler")]
			get {
				if (id_getHigh == IntPtr.Zero)
					id_getHigh = JNIEnv.GetMethodID (class_ref, "getHigh", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getHigh);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHigh", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.util']/class[@name='IntRange']/method[@name='setHigh' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setHigh", "(I)V", "GetSetHigh_IHandler")]
			set {
				if (id_setHigh_I == IntPtr.Zero)
					id_setHigh_I = JNIEnv.GetMethodID (class_ref, "setHigh", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setHigh_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setHigh", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getLow;
#pragma warning disable 0169
		static Delegate GetGetLowHandler ()
		{
			if (cb_getLow == null)
				cb_getLow = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetLow);
			return cb_getLow;
		}

		static int n_GetLow (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Util.IntRange __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Util.IntRange> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Low;
		}
#pragma warning restore 0169

		static Delegate cb_setLow_I;
#pragma warning disable 0169
		static Delegate GetSetLow_IHandler ()
		{
			if (cb_setLow_I == null)
				cb_setLow_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetLow_I);
			return cb_setLow_I;
		}

		static void n_SetLow_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Encog.Engine.Util.IntRange __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Util.IntRange> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Low = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getLow;
		static IntPtr id_setLow_I;
		public virtual unsafe int Low {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.util']/class[@name='IntRange']/method[@name='getLow' and count(parameter)=0]"
			[Register ("getLow", "()I", "GetGetLowHandler")]
			get {
				if (id_getLow == IntPtr.Zero)
					id_getLow = JNIEnv.GetMethodID (class_ref, "getLow", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getLow);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLow", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.util']/class[@name='IntRange']/method[@name='setLow' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setLow", "(I)V", "GetSetLow_IHandler")]
			set {
				if (id_setLow_I == IntPtr.Zero)
					id_setLow_I = JNIEnv.GetMethodID (class_ref, "setLow", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLow_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLow", "(I)V"), __args);
				} finally {
				}
			}
		}

	}
}
