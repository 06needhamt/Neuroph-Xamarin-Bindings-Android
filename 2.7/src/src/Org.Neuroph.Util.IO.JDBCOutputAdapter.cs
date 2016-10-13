using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Util.IO {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.util.io']/class[@name='JDBCOutputAdapter']"
	[global::Android.Runtime.Register ("org/neuroph/util/io/JDBCOutputAdapter", DoNotGenerateAcw=true)]
	public partial class JDBCOutputAdapter : global::Java.Lang.Object, global::Org.Neuroph.Util.IO.IOutputAdapter {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/util/io/JDBCOutputAdapter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (JDBCOutputAdapter); }
		}

		protected JDBCOutputAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_sql_Connection_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.util.io']/class[@name='JDBCOutputAdapter']/constructor[@name='JDBCOutputAdapter' and count(parameter)=2 and parameter[1][@type='java.sql.Connection'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/sql/Connection;Ljava/lang/String;)V", "")]
		public unsafe JDBCOutputAdapter (global::Java.Sql.IConnection p0, string p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				if (GetType () != typeof (JDBCOutputAdapter)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/sql/Connection;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/sql/Connection;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_sql_Connection_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_sql_Connection_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/sql/Connection;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_sql_Connection_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_sql_Connection_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
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
			global::Org.Neuroph.Util.IO.JDBCOutputAdapter __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.IO.JDBCOutputAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		static IntPtr id_close;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util.io']/class[@name='JDBCOutputAdapter']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public virtual unsafe void Close ()
		{
			if (id_close == IntPtr.Zero)
				id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_close);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "close", "()V"));
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
			global::Org.Neuroph.Util.IO.JDBCOutputAdapter __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.IO.JDBCOutputAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			double[] p0 = (double[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (double));
			__this.WriteOutput (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_writeOutput_arrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util.io']/class[@name='JDBCOutputAdapter']/method[@name='writeOutput' and count(parameter)=1 and parameter[1][@type='double[]']]"
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
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_writeOutput_arrayD, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeOutput", "([D)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

	}
}
