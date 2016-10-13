using System;
using System.Collections.Generic;
using Android.Runtime;

namespace CH.Qos.Logback.Classic.DB.Names {

	// Metadata.xml XPath class reference: path="/api/package[@name='ch.qos.logback.classic.db.names']/class[@name='DefaultDBNameResolver']"
	[global::Android.Runtime.Register ("ch/qos/logback/classic/db/names/DefaultDBNameResolver", DoNotGenerateAcw=true)]
	public partial class DefaultDBNameResolver : global::Java.Lang.Object, global::CH.Qos.Logback.Classic.DB.Names.IDBNameResolver {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("ch/qos/logback/classic/db/names/DefaultDBNameResolver", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DefaultDBNameResolver); }
		}

		protected DefaultDBNameResolver (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='ch.qos.logback.classic.db.names']/class[@name='DefaultDBNameResolver']/constructor[@name='DefaultDBNameResolver' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DefaultDBNameResolver ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (DefaultDBNameResolver)) {
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

		static Delegate cb_getColumnName_Ljava_lang_Enum_;
#pragma warning disable 0169
		static Delegate GetGetColumnName_Ljava_lang_Enum_Handler ()
		{
			if (cb_getColumnName_Ljava_lang_Enum_ == null)
				cb_getColumnName_Ljava_lang_Enum_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetColumnName_Ljava_lang_Enum_);
			return cb_getColumnName_Ljava_lang_Enum_;
		}

		static IntPtr n_GetColumnName_Ljava_lang_Enum_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CH.Qos.Logback.Classic.DB.Names.DefaultDBNameResolver __this = global::Java.Lang.Object.GetObject<global::CH.Qos.Logback.Classic.DB.Names.DefaultDBNameResolver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetColumnName (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getColumnName_Ljava_lang_Enum_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ch.qos.logback.classic.db.names']/class[@name='DefaultDBNameResolver']/method[@name='getColumnName' and count(parameter)=1 and parameter[1][@type='N']]"
		[Register ("getColumnName", "(Ljava/lang/Enum;)Ljava/lang/String;", "GetGetColumnName_Ljava_lang_Enum_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"N extends java.lang.Enum<?>"})]
		public virtual unsafe string GetColumnName (global::Java.Lang.Object p0)
		{
			if (id_getColumnName_Ljava_lang_Enum_ == IntPtr.Zero)
				id_getColumnName_Ljava_lang_Enum_ = JNIEnv.GetMethodID (class_ref, "getColumnName", "(Ljava/lang/Enum;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				string __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getColumnName_Ljava_lang_Enum_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getColumnName", "(Ljava/lang/Enum;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getTableName_Ljava_lang_Enum_;
#pragma warning disable 0169
		static Delegate GetGetTableName_Ljava_lang_Enum_Handler ()
		{
			if (cb_getTableName_Ljava_lang_Enum_ == null)
				cb_getTableName_Ljava_lang_Enum_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetTableName_Ljava_lang_Enum_);
			return cb_getTableName_Ljava_lang_Enum_;
		}

		static IntPtr n_GetTableName_Ljava_lang_Enum_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CH.Qos.Logback.Classic.DB.Names.DefaultDBNameResolver __this = global::Java.Lang.Object.GetObject<global::CH.Qos.Logback.Classic.DB.Names.DefaultDBNameResolver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetTableName (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getTableName_Ljava_lang_Enum_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ch.qos.logback.classic.db.names']/class[@name='DefaultDBNameResolver']/method[@name='getTableName' and count(parameter)=1 and parameter[1][@type='N']]"
		[Register ("getTableName", "(Ljava/lang/Enum;)Ljava/lang/String;", "GetGetTableName_Ljava_lang_Enum_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"N extends java.lang.Enum<?>"})]
		public virtual unsafe string GetTableName (global::Java.Lang.Object p0)
		{
			if (id_getTableName_Ljava_lang_Enum_ == IntPtr.Zero)
				id_getTableName_Ljava_lang_Enum_ = JNIEnv.GetMethodID (class_ref, "getTableName", "(Ljava/lang/Enum;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				string __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTableName_Ljava_lang_Enum_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTableName", "(Ljava/lang/Enum;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
