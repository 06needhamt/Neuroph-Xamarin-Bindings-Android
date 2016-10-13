using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Contrib.Samples.Stockmarket {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.contrib.samples.stockmarket']/class[@name='StockSocketReader']"
	[global::Android.Runtime.Register ("org/neuroph/contrib/samples/stockmarket/StockSocketReader", DoNotGenerateAcw=true)]
	public partial class StockSocketReader : global::Java.Lang.Object, global::Java.Lang.IRunnable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/contrib/samples/stockmarket/StockSocketReader", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (StockSocketReader); }
		}

		protected StockSocketReader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.contrib.samples.stockmarket']/class[@name='StockSocketReader']/constructor[@name='StockSocketReader' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe StockSocketReader (int p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (StockSocketReader)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(I)V", __args);
					return;
				}

				if (id_ctor_I == IntPtr.Zero)
					id_ctor_I = JNIEnv.GetMethodID (class_ref, "<init>", "(I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_I, __args);
			} finally {
			}
		}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.contrib.samples.stockmarket']/class[@name='StockSocketReader']/constructor[@name='StockSocketReader' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe StockSocketReader ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (StockSocketReader)) {
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

		static Delegate cb_getMaxCounter;
#pragma warning disable 0169
		static Delegate GetGetMaxCounterHandler ()
		{
			if (cb_getMaxCounter == null)
				cb_getMaxCounter = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMaxCounter);
			return cb_getMaxCounter;
		}

		static int n_GetMaxCounter (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Contrib.Samples.Stockmarket.StockSocketReader __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.Samples.Stockmarket.StockSocketReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxCounter;
		}
#pragma warning restore 0169

		static Delegate cb_setMaxCounter_I;
#pragma warning disable 0169
		static Delegate GetSetMaxCounter_IHandler ()
		{
			if (cb_setMaxCounter_I == null)
				cb_setMaxCounter_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetMaxCounter_I);
			return cb_setMaxCounter_I;
		}

		static void n_SetMaxCounter_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Neuroph.Contrib.Samples.Stockmarket.StockSocketReader __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.Samples.Stockmarket.StockSocketReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MaxCounter = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMaxCounter;
		static IntPtr id_setMaxCounter_I;
		public virtual unsafe int MaxCounter {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.contrib.samples.stockmarket']/class[@name='StockSocketReader']/method[@name='getMaxCounter' and count(parameter)=0]"
			[Register ("getMaxCounter", "()I", "GetGetMaxCounterHandler")]
			get {
				if (id_getMaxCounter == IntPtr.Zero)
					id_getMaxCounter = JNIEnv.GetMethodID (class_ref, "getMaxCounter", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getMaxCounter);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMaxCounter", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.contrib.samples.stockmarket']/class[@name='StockSocketReader']/method[@name='setMaxCounter' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMaxCounter", "(I)V", "GetSetMaxCounter_IHandler")]
			set {
				if (id_setMaxCounter_I == IntPtr.Zero)
					id_setMaxCounter_I = JNIEnv.GetMethodID (class_ref, "setMaxCounter", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMaxCounter_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMaxCounter", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTsleep;
#pragma warning disable 0169
		static Delegate GetGetTsleepHandler ()
		{
			if (cb_getTsleep == null)
				cb_getTsleep = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetTsleep);
			return cb_getTsleep;
		}

		static long n_GetTsleep (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Contrib.Samples.Stockmarket.StockSocketReader __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.Samples.Stockmarket.StockSocketReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Tsleep;
		}
#pragma warning restore 0169

		static Delegate cb_setTsleep_J;
#pragma warning disable 0169
		static Delegate GetSetTsleep_JHandler ()
		{
			if (cb_setTsleep_J == null)
				cb_setTsleep_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetTsleep_J);
			return cb_setTsleep_J;
		}

		static void n_SetTsleep_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Org.Neuroph.Contrib.Samples.Stockmarket.StockSocketReader __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.Samples.Stockmarket.StockSocketReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Tsleep = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTsleep;
		static IntPtr id_setTsleep_J;
		public virtual unsafe long Tsleep {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.contrib.samples.stockmarket']/class[@name='StockSocketReader']/method[@name='getTsleep' and count(parameter)=0]"
			[Register ("getTsleep", "()J", "GetGetTsleepHandler")]
			get {
				if (id_getTsleep == IntPtr.Zero)
					id_getTsleep = JNIEnv.GetMethodID (class_ref, "getTsleep", "()J");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getTsleep);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTsleep", "()J"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.contrib.samples.stockmarket']/class[@name='StockSocketReader']/method[@name='setTsleep' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setTsleep", "(J)V", "GetSetTsleep_JHandler")]
			set {
				if (id_setTsleep_J == IntPtr.Zero)
					id_setTsleep_J = JNIEnv.GetMethodID (class_ref, "setTsleep", "(J)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTsleep_J, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTsleep", "(J)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getValuesRow;
#pragma warning disable 0169
		static Delegate GetGetValuesRowHandler ()
		{
			if (cb_getValuesRow == null)
				cb_getValuesRow = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetValuesRow);
			return cb_getValuesRow;
		}

		static IntPtr n_GetValuesRow (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Contrib.Samples.Stockmarket.StockSocketReader __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.Samples.Stockmarket.StockSocketReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetValuesRow ());
		}
#pragma warning restore 0169

		static IntPtr id_getValuesRow;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.contrib.samples.stockmarket']/class[@name='StockSocketReader']/method[@name='getValuesRow' and count(parameter)=0]"
		[Register ("getValuesRow", "()[Ljava/lang/String;", "GetGetValuesRowHandler")]
		public virtual unsafe string[] GetValuesRow ()
		{
			if (id_getValuesRow == IntPtr.Zero)
				id_getValuesRow = JNIEnv.GetMethodID (class_ref, "getValuesRow", "()[Ljava/lang/String;");
			try {

				if (GetType () == ThresholdType)
					return (string[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getValuesRow), JniHandleOwnership.TransferLocalRef, typeof (string));
				else
					return (string[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getValuesRow", "()[Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
			}
		}

		static Delegate cb_run;
#pragma warning disable 0169
		static Delegate GetRunHandler ()
		{
			if (cb_run == null)
				cb_run = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Run);
			return cb_run;
		}

		static void n_Run (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Contrib.Samples.Stockmarket.StockSocketReader __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.Samples.Stockmarket.StockSocketReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Run ();
		}
#pragma warning restore 0169

		static IntPtr id_run;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.contrib.samples.stockmarket']/class[@name='StockSocketReader']/method[@name='run' and count(parameter)=0]"
		[Register ("run", "()V", "GetRunHandler")]
		public virtual unsafe void Run ()
		{
			if (id_run == IntPtr.Zero)
				id_run = JNIEnv.GetMethodID (class_ref, "run", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_run);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "run", "()V"));
			} finally {
			}
		}

		static Delegate cb_setValuesRow_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetValuesRow_arrayLjava_lang_String_Handler ()
		{
			if (cb_setValuesRow_arrayLjava_lang_String_ == null)
				cb_setValuesRow_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetValuesRow_arrayLjava_lang_String_);
			return cb_setValuesRow_arrayLjava_lang_String_;
		}

		static void n_SetValuesRow_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Contrib.Samples.Stockmarket.StockSocketReader __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.Samples.Stockmarket.StockSocketReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] p0 = (string[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (string));
			__this.SetValuesRow (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_setValuesRow_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.contrib.samples.stockmarket']/class[@name='StockSocketReader']/method[@name='setValuesRow' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register ("setValuesRow", "([Ljava/lang/String;)V", "GetSetValuesRow_arrayLjava_lang_String_Handler")]
		public virtual unsafe void SetValuesRow (string[] p0)
		{
			if (id_setValuesRow_arrayLjava_lang_String_ == IntPtr.Zero)
				id_setValuesRow_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setValuesRow", "([Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setValuesRow_arrayLjava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setValuesRow", "([Ljava/lang/String;)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

	}
}
