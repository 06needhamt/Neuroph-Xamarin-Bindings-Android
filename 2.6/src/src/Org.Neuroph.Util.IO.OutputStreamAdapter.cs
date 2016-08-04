using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Util.IO {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.util.io']/class[@name='OutputStreamAdapter']"
	[global::Android.Runtime.Register ("org/neuroph/util/io/OutputStreamAdapter", DoNotGenerateAcw=true)]
	public partial class OutputStreamAdapter : global::Java.Lang.Object, global::Org.Neuroph.Util.IO.IOutputAdapter {


		static IntPtr bufferedWriter_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.neuroph.util.io']/class[@name='OutputStreamAdapter']/field[@name='bufferedWriter']"
		[Register ("bufferedWriter")]
		protected global::Java.IO.BufferedWriter BufferedWriter {
			get {
				if (bufferedWriter_jfieldId == IntPtr.Zero)
					bufferedWriter_jfieldId = JNIEnv.GetFieldID (class_ref, "bufferedWriter", "Ljava/io/BufferedWriter;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, bufferedWriter_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.IO.BufferedWriter> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (bufferedWriter_jfieldId == IntPtr.Zero)
					bufferedWriter_jfieldId = JNIEnv.GetFieldID (class_ref, "bufferedWriter", "Ljava/io/BufferedWriter;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, bufferedWriter_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/util/io/OutputStreamAdapter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (OutputStreamAdapter); }
		}

		protected OutputStreamAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_io_OutputStream_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.util.io']/class[@name='OutputStreamAdapter']/constructor[@name='OutputStreamAdapter' and count(parameter)=1 and parameter[1][@type='java.io.OutputStream']]"
		[Register (".ctor", "(Ljava/io/OutputStream;)V", "")]
		public unsafe OutputStreamAdapter (global::System.IO.Stream p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (OutputStreamAdapter)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/io/OutputStream;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/io/OutputStream;)V", __args);
					return;
				}

				if (id_ctor_Ljava_io_OutputStream_ == IntPtr.Zero)
					id_ctor_Ljava_io_OutputStream_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/io/OutputStream;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_io_OutputStream_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_io_OutputStream_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_ctor_Ljava_io_BufferedWriter_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.util.io']/class[@name='OutputStreamAdapter']/constructor[@name='OutputStreamAdapter' and count(parameter)=1 and parameter[1][@type='java.io.BufferedWriter']]"
		[Register (".ctor", "(Ljava/io/BufferedWriter;)V", "")]
		public unsafe OutputStreamAdapter (global::Java.IO.BufferedWriter p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (OutputStreamAdapter)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/io/BufferedWriter;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/io/BufferedWriter;)V", __args);
					return;
				}

				if (id_ctor_Ljava_io_BufferedWriter_ == IntPtr.Zero)
					id_ctor_Ljava_io_BufferedWriter_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/io/BufferedWriter;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_io_BufferedWriter_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_io_BufferedWriter_, __args);
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
			global::Org.Neuroph.Util.IO.OutputStreamAdapter __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.IO.OutputStreamAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		static IntPtr id_close;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util.io']/class[@name='OutputStreamAdapter']/method[@name='close' and count(parameter)=0]"
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

		static Delegate cb_writeOutput_arrayD;
#pragma warning disable 0169
		static Delegate GetWriteOutput_arrayDHandler ()
		{
			if (cb_writeOutput_arrayD == null)
				cb_writeOutput_arrayD = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_WriteOutput_arrayD);
			return cb_writeOutput_arrayD;
		}

		static void n_WriteOutput_arrayD (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Util.IO.OutputStreamAdapter __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.IO.OutputStreamAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			double[] p0 = (double[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (double));
			__this.WriteOutput (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_writeOutput_arrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util.io']/class[@name='OutputStreamAdapter']/method[@name='writeOutput' and count(parameter)=1 and parameter[1][@type='double[]']]"
		[Register ("writeOutput", "([D)V", "GetWriteOutput_arrayDHandler")]
		public virtual unsafe void WriteOutput (double[] p0)
		{
			if (id_writeOutput_arrayD == IntPtr.Zero)
				id_writeOutput_arrayD = JNIEnv.GetMethodID (class_ref, "writeOutput", "([D)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_writeOutput_arrayD, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeOutput", "([D)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

	}
}
