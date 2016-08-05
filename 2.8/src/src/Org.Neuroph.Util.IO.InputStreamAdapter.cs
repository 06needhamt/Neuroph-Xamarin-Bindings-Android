using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Util.IO {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.util.io']/class[@name='InputStreamAdapter']"
	[global::Android.Runtime.Register ("org/neuroph/util/io/InputStreamAdapter", DoNotGenerateAcw=true)]
	public partial class InputStreamAdapter : global::Java.Lang.Object, global::Org.Neuroph.Util.IO.IInputAdapter {


		static IntPtr bufferedReader_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.neuroph.util.io']/class[@name='InputStreamAdapter']/field[@name='bufferedReader']"
		[Register ("bufferedReader")]
		protected global::Java.IO.BufferedReader BufferedReader {
			get {
				if (bufferedReader_jfieldId == IntPtr.Zero)
					bufferedReader_jfieldId = JNIEnv.GetFieldID (class_ref, "bufferedReader", "Ljava/io/BufferedReader;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, bufferedReader_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.IO.BufferedReader> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (bufferedReader_jfieldId == IntPtr.Zero)
					bufferedReader_jfieldId = JNIEnv.GetFieldID (class_ref, "bufferedReader", "Ljava/io/BufferedReader;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, bufferedReader_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/util/io/InputStreamAdapter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (InputStreamAdapter); }
		}

		protected InputStreamAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_io_InputStream_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.util.io']/class[@name='InputStreamAdapter']/constructor[@name='InputStreamAdapter' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register (".ctor", "(Ljava/io/InputStream;)V", "")]
		public unsafe InputStreamAdapter (global::System.IO.Stream p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (InputStreamAdapter)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/io/InputStream;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/io/InputStream;)V", __args);
					return;
				}

				if (id_ctor_Ljava_io_InputStream_ == IntPtr.Zero)
					id_ctor_Ljava_io_InputStream_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/io/InputStream;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_io_InputStream_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_io_InputStream_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_ctor_Ljava_io_BufferedReader_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.util.io']/class[@name='InputStreamAdapter']/constructor[@name='InputStreamAdapter' and count(parameter)=1 and parameter[1][@type='java.io.BufferedReader']]"
		[Register (".ctor", "(Ljava/io/BufferedReader;)V", "")]
		public unsafe InputStreamAdapter (global::Java.IO.BufferedReader p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (InputStreamAdapter)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/io/BufferedReader;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/io/BufferedReader;)V", __args);
					return;
				}

				if (id_ctor_Ljava_io_BufferedReader_ == IntPtr.Zero)
					id_ctor_Ljava_io_BufferedReader_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/io/BufferedReader;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_io_BufferedReader_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_io_BufferedReader_, __args);
			} finally {
			}
		}

		static Delegate cb_close;
#pragma warning disable 0169
		static Delegate GetCloseHandler ()
		{
			if (cb_close == null)
				cb_close = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Close);
			return cb_close;
		}

		static void n_Close (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Util.IO.InputStreamAdapter __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.IO.InputStreamAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		static IntPtr id_close;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util.io']/class[@name='InputStreamAdapter']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public virtual unsafe void Close ()
		{
			if (id_close == IntPtr.Zero)
				id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_close);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "close", "()V"));
			} finally {
			}
		}

		static Delegate cb_readInput;
#pragma warning disable 0169
		static Delegate GetReadInputHandler ()
		{
			if (cb_readInput == null)
				cb_readInput = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ReadInput);
			return cb_readInput;
		}

		static IntPtr n_ReadInput (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Util.IO.InputStreamAdapter __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.IO.InputStreamAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.ReadInput ());
		}
#pragma warning restore 0169

		static IntPtr id_readInput;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util.io']/class[@name='InputStreamAdapter']/method[@name='readInput' and count(parameter)=0]"
		[Register ("readInput", "()[D", "GetReadInputHandler")]
		public virtual unsafe double[] ReadInput ()
		{
			if (id_readInput == IntPtr.Zero)
				id_readInput = JNIEnv.GetMethodID (class_ref, "readInput", "()[D");
			try {

				if (GetType () == ThresholdType)
					return (double[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_readInput), JniHandleOwnership.TransferLocalRef, typeof (double));
				else
					return (double[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "readInput", "()[D")), JniHandleOwnership.TransferLocalRef, typeof (double));
			} finally {
			}
		}

	}
}
