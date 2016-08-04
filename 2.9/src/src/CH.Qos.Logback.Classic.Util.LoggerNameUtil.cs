using System;
using System.Collections.Generic;
using Android.Runtime;

namespace CH.Qos.Logback.Classic.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='ch.qos.logback.classic.util']/class[@name='LoggerNameUtil']"
	[global::Android.Runtime.Register ("ch/qos/logback/classic/util/LoggerNameUtil", DoNotGenerateAcw=true)]
	public partial class LoggerNameUtil : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("ch/qos/logback/classic/util/LoggerNameUtil", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LoggerNameUtil); }
		}

		protected LoggerNameUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='ch.qos.logback.classic.util']/class[@name='LoggerNameUtil']/constructor[@name='LoggerNameUtil' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe LoggerNameUtil ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (LoggerNameUtil)) {
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

		static IntPtr id_computeNameParts_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ch.qos.logback.classic.util']/class[@name='LoggerNameUtil']/method[@name='computeNameParts' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("computeNameParts", "(Ljava/lang/String;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<string> ComputeNameParts (string p0)
		{
			if (id_computeNameParts_Ljava_lang_String_ == IntPtr.Zero)
				id_computeNameParts_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "computeNameParts", "(Ljava/lang/String;)Ljava/util/List;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::System.Collections.Generic.IList<string> __ret = global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_computeNameParts_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_getFirstSeparatorIndexOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ch.qos.logback.classic.util']/class[@name='LoggerNameUtil']/method[@name='getFirstSeparatorIndexOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getFirstSeparatorIndexOf", "(Ljava/lang/String;)I", "")]
		public static unsafe int GetFirstSeparatorIndexOf (string p0)
		{
			if (id_getFirstSeparatorIndexOf_Ljava_lang_String_ == IntPtr.Zero)
				id_getFirstSeparatorIndexOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getFirstSeparatorIndexOf", "(Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_getFirstSeparatorIndexOf_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_getSeparatorIndexOf_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='ch.qos.logback.classic.util']/class[@name='LoggerNameUtil']/method[@name='getSeparatorIndexOf' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("getSeparatorIndexOf", "(Ljava/lang/String;I)I", "")]
		public static unsafe int GetSeparatorIndexOf (string p0, int p1)
		{
			if (id_getSeparatorIndexOf_Ljava_lang_String_I == IntPtr.Zero)
				id_getSeparatorIndexOf_Ljava_lang_String_I = JNIEnv.GetStaticMethodID (class_ref, "getSeparatorIndexOf", "(Ljava/lang/String;I)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_getSeparatorIndexOf_Ljava_lang_String_I, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
