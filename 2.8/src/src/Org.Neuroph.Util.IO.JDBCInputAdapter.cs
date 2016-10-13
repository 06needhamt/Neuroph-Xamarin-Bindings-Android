using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Util.IO {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.util.io']/class[@name='JDBCInputAdapter']"
	[global::Android.Runtime.Register ("org/neuroph/util/io/JDBCInputAdapter", DoNotGenerateAcw=true)]
	public partial class JDBCInputAdapter : global::Java.Lang.Object, global::Org.Neuroph.Util.IO.IInputAdapter {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/util/io/JDBCInputAdapter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (JDBCInputAdapter); }
		}

		protected JDBCInputAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_sql_Connection_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.util.io']/class[@name='JDBCInputAdapter']/constructor[@name='JDBCInputAdapter' and count(parameter)=2 and parameter[1][@type='java.sql.Connection'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/sql/Connection;Ljava/lang/String;)V", "")]
		public unsafe JDBCInputAdapter (global::Java.Sql.IConnection p0, string p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				if (GetType () != typeof (JDBCInputAdapter)) {
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
			global::Org.Neuroph.Util.IO.JDBCInputAdapter __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.IO.JDBCInputAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		static IntPtr id_close;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util.io']/class[@name='JDBCInputAdapter']/method[@name='close' and count(parameter)=0]"
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
			global::Org.Neuroph.Util.IO.JDBCInputAdapter __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.IO.JDBCInputAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.ReadInput ());
		}
#pragma warning restore 0169

		static IntPtr id_readInput;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util.io']/class[@name='JDBCInputAdapter']/method[@name='readInput' and count(parameter)=0]"
		[Register ("readInput", "()[D", "GetReadInputHandler")]
		public virtual unsafe double[] ReadInput ()
		{
			if (id_readInput == IntPtr.Zero)
				id_readInput = JNIEnv.GetMethodID (class_ref, "readInput", "()[D");
			try {

				if (GetType () == ThresholdType)
					return (double[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_readInput), JniHandleOwnership.TransferLocalRef, typeof (double));
				else
					return (double[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "readInput", "()[D")), JniHandleOwnership.TransferLocalRef, typeof (double));
			} finally {
			}
		}

	}
}
