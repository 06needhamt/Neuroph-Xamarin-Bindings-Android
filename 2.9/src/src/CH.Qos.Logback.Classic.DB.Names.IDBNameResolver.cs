using System;
using System.Collections.Generic;
using Android.Runtime;

namespace CH.Qos.Logback.Classic.DB.Names {

	// Metadata.xml XPath interface reference: path="/api/package[@name='ch.qos.logback.classic.db.names']/interface[@name='DBNameResolver']"
	[Register ("ch/qos/logback/classic/db/names/DBNameResolver", "", "CH.Qos.Logback.Classic.DB.Names.IDBNameResolverInvoker")]
	public partial interface IDBNameResolver : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='ch.qos.logback.classic.db.names']/interface[@name='DBNameResolver']/method[@name='getColumnName' and count(parameter)=1 and parameter[1][@type='N']]"
		[Register ("getColumnName", "(Ljava/lang/Enum;)Ljava/lang/String;", "GetGetColumnName_Ljava_lang_Enum_Handler:CH.Qos.Logback.Classic.DB.Names.IDBNameResolverInvoker, neuroph_2.9")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"N extends java.lang.Enum<?>"})]
		string GetColumnName (global::Java.Lang.Object p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='ch.qos.logback.classic.db.names']/interface[@name='DBNameResolver']/method[@name='getTableName' and count(parameter)=1 and parameter[1][@type='N']]"
		[Register ("getTableName", "(Ljava/lang/Enum;)Ljava/lang/String;", "GetGetTableName_Ljava_lang_Enum_Handler:CH.Qos.Logback.Classic.DB.Names.IDBNameResolverInvoker, neuroph_2.9")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"N extends java.lang.Enum<?>"})]
		string GetTableName (global::Java.Lang.Object p0);

	}

	[global::Android.Runtime.Register ("ch/qos/logback/classic/db/names/DBNameResolver", DoNotGenerateAcw=true)]
	internal class IDBNameResolverInvoker : global::Java.Lang.Object, IDBNameResolver {

		static IntPtr java_class_ref = JNIEnv.FindClass ("ch/qos/logback/classic/db/names/DBNameResolver");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IDBNameResolverInvoker); }
		}

		IntPtr class_ref;

		public static IDBNameResolver GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDBNameResolver> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "ch.qos.logback.classic.db.names.DBNameResolver"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDBNameResolverInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::CH.Qos.Logback.Classic.DB.Names.IDBNameResolver __this = global::Java.Lang.Object.GetObject<global::CH.Qos.Logback.Classic.DB.Names.IDBNameResolver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetColumnName (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getColumnName_Ljava_lang_Enum_;
		public unsafe string GetColumnName (global::Java.Lang.Object p0)
		{
			if (id_getColumnName_Ljava_lang_Enum_ == IntPtr.Zero)
				id_getColumnName_Ljava_lang_Enum_ = JNIEnv.GetMethodID (class_ref, "getColumnName", "(Ljava/lang/Enum;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getColumnName_Ljava_lang_Enum_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
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
			global::CH.Qos.Logback.Classic.DB.Names.IDBNameResolver __this = global::Java.Lang.Object.GetObject<global::CH.Qos.Logback.Classic.DB.Names.IDBNameResolver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetTableName (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getTableName_Ljava_lang_Enum_;
		public unsafe string GetTableName (global::Java.Lang.Object p0)
		{
			if (id_getTableName_Ljava_lang_Enum_ == IntPtr.Zero)
				id_getTableName_Ljava_lang_Enum_ = JNIEnv.GetMethodID (class_ref, "getTableName", "(Ljava/lang/Enum;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTableName_Ljava_lang_Enum_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}

}
