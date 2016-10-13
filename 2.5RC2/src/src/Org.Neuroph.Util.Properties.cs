using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.util']/class[@name='Properties']"
	[global::Android.Runtime.Register ("org/neuroph/util/Properties", DoNotGenerateAcw=true)]
	public partial class Properties : global::Java.Util.Hashtable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/util/Properties", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Properties); }
		}

		protected Properties (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.util']/class[@name='Properties']/constructor[@name='Properties' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Properties ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Properties)) {
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

		static Delegate cb_createKeys_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCreateKeys_arrayLjava_lang_String_Handler ()
		{
			if (cb_createKeys_arrayLjava_lang_String_ == null)
				cb_createKeys_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_CreateKeys_arrayLjava_lang_String_);
			return cb_createKeys_arrayLjava_lang_String_;
		}

		static void n_CreateKeys_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Util.Properties __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.Properties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] p0 = (string[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (string));
			__this.CreateKeys (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_createKeys_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util']/class[@name='Properties']/method[@name='createKeys' and count(parameter)=1 and parameter[1][@type='java.lang.String...']]"
		[Register ("createKeys", "([Ljava/lang/String;)V", "GetCreateKeys_arrayLjava_lang_String_Handler")]
		protected virtual unsafe void CreateKeys (params  string[] p0)
		{
			if (id_createKeys_arrayLjava_lang_String_ == IntPtr.Zero)
				id_createKeys_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "createKeys", "([Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_createKeys_arrayLjava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createKeys", "([Ljava/lang/String;)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_getProperty_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetProperty_Ljava_lang_String_Handler ()
		{
			if (cb_getProperty_Ljava_lang_String_ == null)
				cb_getProperty_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetProperty_Ljava_lang_String_);
			return cb_getProperty_Ljava_lang_String_;
		}

		static IntPtr n_GetProperty_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Util.Properties __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.Properties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetProperty (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getProperty_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util']/class[@name='Properties']/method[@name='getProperty' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getProperty", "(Ljava/lang/String;)Ljava/lang/Object;", "GetGetProperty_Ljava_lang_String_Handler")]
		public virtual unsafe global::Java.Lang.Object GetProperty (string p0)
		{
			if (id_getProperty_Ljava_lang_String_ == IntPtr.Zero)
				id_getProperty_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getProperty", "(Ljava/lang/String;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Java.Lang.Object __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getProperty_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getProperty", "(Ljava/lang/String;)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_hasProperty_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetHasProperty_Ljava_lang_String_Handler ()
		{
			if (cb_hasProperty_Ljava_lang_String_ == null)
				cb_hasProperty_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_HasProperty_Ljava_lang_String_);
			return cb_hasProperty_Ljava_lang_String_;
		}

		static bool n_HasProperty_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Util.Properties __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.Properties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.HasProperty (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_hasProperty_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util']/class[@name='Properties']/method[@name='hasProperty' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("hasProperty", "(Ljava/lang/String;)Z", "GetHasProperty_Ljava_lang_String_Handler")]
		public virtual unsafe bool HasProperty (string p0)
		{
			if (id_hasProperty_Ljava_lang_String_ == IntPtr.Zero)
				id_hasProperty_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "hasProperty", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasProperty_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hasProperty", "(Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setProperty_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSetProperty_Ljava_lang_String_Ljava_lang_Object_Handler ()
		{
			if (cb_setProperty_Ljava_lang_String_Ljava_lang_Object_ == null)
				cb_setProperty_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetProperty_Ljava_lang_String_Ljava_lang_Object_);
			return cb_setProperty_Ljava_lang_String_Ljava_lang_Object_;
		}

		static void n_SetProperty_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Neuroph.Util.Properties __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.Properties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetProperty (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setProperty_Ljava_lang_String_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util']/class[@name='Properties']/method[@name='setProperty' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Register ("setProperty", "(Ljava/lang/String;Ljava/lang/Object;)V", "GetSetProperty_Ljava_lang_String_Ljava_lang_Object_Handler")]
		public virtual unsafe void SetProperty (string p0, global::Java.Lang.Object p1)
		{
			if (id_setProperty_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
				id_setProperty_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "setProperty", "(Ljava/lang/String;Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setProperty_Ljava_lang_String_Ljava_lang_Object_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setProperty", "(Ljava/lang/String;Ljava/lang/Object;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
