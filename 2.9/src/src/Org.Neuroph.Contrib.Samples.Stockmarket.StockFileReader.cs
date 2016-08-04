using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Contrib.Samples.Stockmarket {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.contrib.samples.stockmarket']/class[@name='StockFileReader']"
	[global::Android.Runtime.Register ("org/neuroph/contrib/samples/stockmarket/StockFileReader", DoNotGenerateAcw=true)]
	public partial class StockFileReader : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/contrib/samples/stockmarket/StockFileReader", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (StockFileReader); }
		}

		protected StockFileReader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.contrib.samples.stockmarket']/class[@name='StockFileReader']/constructor[@name='StockFileReader' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe StockFileReader ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (StockFileReader)) {
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

		static IntPtr id_ctor_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.contrib.samples.stockmarket']/class[@name='StockFileReader']/constructor[@name='StockFileReader' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe StockFileReader (int p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (StockFileReader)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(I)V", __args);
					return;
				}

				if (id_ctor_I == IntPtr.Zero)
					id_ctor_I = JNIEnv.GetMethodID (class_ref, "<init>", "(I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_I, __args);
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
			global::Org.Neuroph.Contrib.Samples.Stockmarket.StockFileReader __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.Samples.Stockmarket.StockFileReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Org.Neuroph.Contrib.Samples.Stockmarket.StockFileReader __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.Samples.Stockmarket.StockFileReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MaxCounter = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMaxCounter;
		static IntPtr id_setMaxCounter_I;
		public virtual unsafe int MaxCounter {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.contrib.samples.stockmarket']/class[@name='StockFileReader']/method[@name='getMaxCounter' and count(parameter)=0]"
			[Register ("getMaxCounter", "()I", "GetGetMaxCounterHandler")]
			get {
				if (id_getMaxCounter == IntPtr.Zero)
					id_getMaxCounter = JNIEnv.GetMethodID (class_ref, "getMaxCounter", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getMaxCounter);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMaxCounter", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.contrib.samples.stockmarket']/class[@name='StockFileReader']/method[@name='setMaxCounter' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMaxCounter", "(I)V", "GetSetMaxCounter_IHandler")]
			set {
				if (id_setMaxCounter_I == IntPtr.Zero)
					id_setMaxCounter_I = JNIEnv.GetMethodID (class_ref, "setMaxCounter", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setMaxCounter_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMaxCounter", "(I)V"), __args);
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
			global::Org.Neuroph.Contrib.Samples.Stockmarket.StockFileReader __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.Samples.Stockmarket.StockFileReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetValuesRow ());
		}
#pragma warning restore 0169

		static IntPtr id_getValuesRow;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.contrib.samples.stockmarket']/class[@name='StockFileReader']/method[@name='getValuesRow' and count(parameter)=0]"
		[Register ("getValuesRow", "()[Ljava/lang/String;", "GetGetValuesRowHandler")]
		public virtual unsafe string[] GetValuesRow ()
		{
			if (id_getValuesRow == IntPtr.Zero)
				id_getValuesRow = JNIEnv.GetMethodID (class_ref, "getValuesRow", "()[Ljava/lang/String;");
			try {

				if (GetType () == ThresholdType)
					return (string[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getValuesRow), JniHandleOwnership.TransferLocalRef, typeof (string));
				else
					return (string[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getValuesRow", "()[Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
			}
		}

		static Delegate cb_read_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRead_Ljava_lang_String_Handler ()
		{
			if (cb_read_Ljava_lang_String_ == null)
				cb_read_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Read_Ljava_lang_String_);
			return cb_read_Ljava_lang_String_;
		}

		static void n_Read_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Contrib.Samples.Stockmarket.StockFileReader __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.Samples.Stockmarket.StockFileReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Read (p0);
		}
#pragma warning restore 0169

		static IntPtr id_read_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.contrib.samples.stockmarket']/class[@name='StockFileReader']/method[@name='read' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("read", "(Ljava/lang/String;)V", "GetRead_Ljava_lang_String_Handler")]
		public virtual unsafe void Read (string p0)
		{
			if (id_read_Ljava_lang_String_ == IntPtr.Zero)
				id_read_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "read", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_read_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "read", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
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
			global::Org.Neuroph.Contrib.Samples.Stockmarket.StockFileReader __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.Samples.Stockmarket.StockFileReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] p0 = (string[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (string));
			__this.SetValuesRow (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_setValuesRow_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.contrib.samples.stockmarket']/class[@name='StockFileReader']/method[@name='setValuesRow' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
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
					JNIEnv.CallVoidMethod  (Handle, id_setValuesRow_arrayLjava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setValuesRow", "([Ljava/lang/String;)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

	}
}
