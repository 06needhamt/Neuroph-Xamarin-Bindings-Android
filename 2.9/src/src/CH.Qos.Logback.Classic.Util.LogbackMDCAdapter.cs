using System;
using System.Collections.Generic;
using Android.Runtime;

namespace CH.Qos.Logback.Classic.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='ch.qos.logback.classic.util']/class[@name='LogbackMDCAdapter']"
	[global::Android.Runtime.Register ("ch/qos/logback/classic/util/LogbackMDCAdapter", DoNotGenerateAcw=true)]
	public sealed partial class LogbackMDCAdapter : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("ch/qos/logback/classic/util/LogbackMDCAdapter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LogbackMDCAdapter); }
		}

		internal LogbackMDCAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='ch.qos.logback.classic.util']/class[@name='LogbackMDCAdapter']/constructor[@name='LogbackMDCAdapter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe LogbackMDCAdapter ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (LogbackMDCAdapter)) {
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

		static IntPtr id_getCopyOfContextMap;
		public unsafe global::System.Collections.IDictionary CopyOfContextMap {
			// Metadata.xml XPath method reference: path="/api/package[@name='ch.qos.logback.classic.util']/class[@name='LogbackMDCAdapter']/method[@name='getCopyOfContextMap' and count(parameter)=0]"
			[Register ("getCopyOfContextMap", "()Ljava/util/Map;", "GetGetCopyOfContextMapHandler")]
			get {
				if (id_getCopyOfContextMap == IntPtr.Zero)
					id_getCopyOfContextMap = JNIEnv.GetMethodID (class_ref, "getCopyOfContextMap", "()Ljava/util/Map;");
				try {
					return global::Android.Runtime.JavaDictionary.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getCopyOfContextMap), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getKeys;
		public unsafe global::System.Collections.Generic.ICollection<string> Keys {
			// Metadata.xml XPath method reference: path="/api/package[@name='ch.qos.logback.classic.util']/class[@name='LogbackMDCAdapter']/method[@name='getKeys' and count(parameter)=0]"
			[Register ("getKeys", "()Ljava/util/Set;", "GetGetKeysHandler")]
			get {
				if (id_getKeys == IntPtr.Zero)
					id_getKeys = JNIEnv.GetMethodID (class_ref, "getKeys", "()Ljava/util/Set;");
				try {
					return global::Android.Runtime.JavaSet<string>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getKeys), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getPropertyMap;
		public unsafe global::System.Collections.Generic.IDictionary<string, string> PropertyMap {
			// Metadata.xml XPath method reference: path="/api/package[@name='ch.qos.logback.classic.util']/class[@name='LogbackMDCAdapter']/method[@name='getPropertyMap' and count(parameter)=0]"
			[Register ("getPropertyMap", "()Ljava/util/Map;", "GetGetPropertyMapHandler")]
			get {
				if (id_getPropertyMap == IntPtr.Zero)
					id_getPropertyMap = JNIEnv.GetMethodID (class_ref, "getPropertyMap", "()Ljava/util/Map;");
				try {
					return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getPropertyMap), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_clear;
		// Metadata.xml XPath method reference: path="/api/package[@name='ch.qos.logback.classic.util']/class[@name='LogbackMDCAdapter']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "")]
		public unsafe void Clear ()
		{
			if (id_clear == IntPtr.Zero)
				id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_clear);
			} finally {
			}
		}

		static IntPtr id_get_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ch.qos.logback.classic.util']/class[@name='LogbackMDCAdapter']/method[@name='get' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("get", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public unsafe string Get (string p0)
		{
			if (id_get_Ljava_lang_String_ == IntPtr.Zero)
				id_get_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "get", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_get_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_put_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ch.qos.logback.classic.util']/class[@name='LogbackMDCAdapter']/method[@name='put' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("put", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe void Put (string p0, string p1)
		{
			if (id_put_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_put_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "put", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallVoidMethod  (Handle, id_put_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_remove_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ch.qos.logback.classic.util']/class[@name='LogbackMDCAdapter']/method[@name='remove' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("remove", "(Ljava/lang/String;)V", "")]
		public unsafe void Remove (string p0)
		{
			if (id_remove_Ljava_lang_String_ == IntPtr.Zero)
				id_remove_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "remove", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod  (Handle, id_remove_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_setContextMap_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ch.qos.logback.classic.util']/class[@name='LogbackMDCAdapter']/method[@name='setContextMap' and count(parameter)=1 and parameter[1][@type='java.util.Map']]"
		[Register ("setContextMap", "(Ljava/util/Map;)V", "")]
		public unsafe void SetContextMap (global::System.Collections.IDictionary p0)
		{
			if (id_setContextMap_Ljava_util_Map_ == IntPtr.Zero)
				id_setContextMap_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "setContextMap", "(Ljava/util/Map;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod  (Handle, id_setContextMap_Ljava_util_Map_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
