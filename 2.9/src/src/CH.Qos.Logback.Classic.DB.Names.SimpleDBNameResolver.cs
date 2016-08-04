using System;
using System.Collections.Generic;
using Android.Runtime;

namespace CH.Qos.Logback.Classic.DB.Names {

	// Metadata.xml XPath class reference: path="/api/package[@name='ch.qos.logback.classic.db.names']/class[@name='SimpleDBNameResolver']"
	[global::Android.Runtime.Register ("ch/qos/logback/classic/db/names/SimpleDBNameResolver", DoNotGenerateAcw=true)]
	public partial class SimpleDBNameResolver : global::Java.Lang.Object, global::CH.Qos.Logback.Classic.DB.Names.IDBNameResolver {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("ch/qos/logback/classic/db/names/SimpleDBNameResolver", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SimpleDBNameResolver); }
		}

		protected SimpleDBNameResolver (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='ch.qos.logback.classic.db.names']/class[@name='SimpleDBNameResolver']/constructor[@name='SimpleDBNameResolver' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SimpleDBNameResolver ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (SimpleDBNameResolver)) {
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
			global::CH.Qos.Logback.Classic.DB.Names.SimpleDBNameResolver __this = global::Java.Lang.Object.GetObject<global::CH.Qos.Logback.Classic.DB.Names.SimpleDBNameResolver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetColumnName (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getColumnName_Ljava_lang_Enum_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ch.qos.logback.classic.db.names']/class[@name='SimpleDBNameResolver']/method[@name='getColumnName' and count(parameter)=1 and parameter[1][@type='N']]"
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
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getColumnName_Ljava_lang_Enum_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getColumnName", "(Ljava/lang/Enum;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
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
			global::CH.Qos.Logback.Classic.DB.Names.SimpleDBNameResolver __this = global::Java.Lang.Object.GetObject<global::CH.Qos.Logback.Classic.DB.Names.SimpleDBNameResolver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetTableName (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getTableName_Ljava_lang_Enum_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ch.qos.logback.classic.db.names']/class[@name='SimpleDBNameResolver']/method[@name='getTableName' and count(parameter)=1 and parameter[1][@type='N']]"
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
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getTableName_Ljava_lang_Enum_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTableName", "(Ljava/lang/Enum;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setColumnNamePrefix_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetColumnNamePrefix_Ljava_lang_String_Handler ()
		{
			if (cb_setColumnNamePrefix_Ljava_lang_String_ == null)
				cb_setColumnNamePrefix_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetColumnNamePrefix_Ljava_lang_String_);
			return cb_setColumnNamePrefix_Ljava_lang_String_;
		}

		static void n_SetColumnNamePrefix_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CH.Qos.Logback.Classic.DB.Names.SimpleDBNameResolver __this = global::Java.Lang.Object.GetObject<global::CH.Qos.Logback.Classic.DB.Names.SimpleDBNameResolver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetColumnNamePrefix (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setColumnNamePrefix_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ch.qos.logback.classic.db.names']/class[@name='SimpleDBNameResolver']/method[@name='setColumnNamePrefix' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setColumnNamePrefix", "(Ljava/lang/String;)V", "GetSetColumnNamePrefix_Ljava_lang_String_Handler")]
		public virtual unsafe void SetColumnNamePrefix (string p0)
		{
			if (id_setColumnNamePrefix_Ljava_lang_String_ == IntPtr.Zero)
				id_setColumnNamePrefix_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setColumnNamePrefix", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setColumnNamePrefix_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setColumnNamePrefix", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setColumnNameSuffix_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetColumnNameSuffix_Ljava_lang_String_Handler ()
		{
			if (cb_setColumnNameSuffix_Ljava_lang_String_ == null)
				cb_setColumnNameSuffix_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetColumnNameSuffix_Ljava_lang_String_);
			return cb_setColumnNameSuffix_Ljava_lang_String_;
		}

		static void n_SetColumnNameSuffix_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CH.Qos.Logback.Classic.DB.Names.SimpleDBNameResolver __this = global::Java.Lang.Object.GetObject<global::CH.Qos.Logback.Classic.DB.Names.SimpleDBNameResolver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetColumnNameSuffix (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setColumnNameSuffix_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ch.qos.logback.classic.db.names']/class[@name='SimpleDBNameResolver']/method[@name='setColumnNameSuffix' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setColumnNameSuffix", "(Ljava/lang/String;)V", "GetSetColumnNameSuffix_Ljava_lang_String_Handler")]
		public virtual unsafe void SetColumnNameSuffix (string p0)
		{
			if (id_setColumnNameSuffix_Ljava_lang_String_ == IntPtr.Zero)
				id_setColumnNameSuffix_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setColumnNameSuffix", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setColumnNameSuffix_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setColumnNameSuffix", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setTableNamePrefix_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTableNamePrefix_Ljava_lang_String_Handler ()
		{
			if (cb_setTableNamePrefix_Ljava_lang_String_ == null)
				cb_setTableNamePrefix_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTableNamePrefix_Ljava_lang_String_);
			return cb_setTableNamePrefix_Ljava_lang_String_;
		}

		static void n_SetTableNamePrefix_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CH.Qos.Logback.Classic.DB.Names.SimpleDBNameResolver __this = global::Java.Lang.Object.GetObject<global::CH.Qos.Logback.Classic.DB.Names.SimpleDBNameResolver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetTableNamePrefix (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setTableNamePrefix_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ch.qos.logback.classic.db.names']/class[@name='SimpleDBNameResolver']/method[@name='setTableNamePrefix' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setTableNamePrefix", "(Ljava/lang/String;)V", "GetSetTableNamePrefix_Ljava_lang_String_Handler")]
		public virtual unsafe void SetTableNamePrefix (string p0)
		{
			if (id_setTableNamePrefix_Ljava_lang_String_ == IntPtr.Zero)
				id_setTableNamePrefix_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTableNamePrefix", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setTableNamePrefix_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTableNamePrefix", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setTableNameSuffix_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTableNameSuffix_Ljava_lang_String_Handler ()
		{
			if (cb_setTableNameSuffix_Ljava_lang_String_ == null)
				cb_setTableNameSuffix_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTableNameSuffix_Ljava_lang_String_);
			return cb_setTableNameSuffix_Ljava_lang_String_;
		}

		static void n_SetTableNameSuffix_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CH.Qos.Logback.Classic.DB.Names.SimpleDBNameResolver __this = global::Java.Lang.Object.GetObject<global::CH.Qos.Logback.Classic.DB.Names.SimpleDBNameResolver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetTableNameSuffix (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setTableNameSuffix_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ch.qos.logback.classic.db.names']/class[@name='SimpleDBNameResolver']/method[@name='setTableNameSuffix' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setTableNameSuffix", "(Ljava/lang/String;)V", "GetSetTableNameSuffix_Ljava_lang_String_Handler")]
		public virtual unsafe void SetTableNameSuffix (string p0)
		{
			if (id_setTableNameSuffix_Ljava_lang_String_ == IntPtr.Zero)
				id_setTableNameSuffix_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTableNameSuffix", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setTableNameSuffix_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTableNameSuffix", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
