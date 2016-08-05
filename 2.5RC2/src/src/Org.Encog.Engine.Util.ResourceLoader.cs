using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Encog.Engine.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.encog.engine.util']/class[@name='ResourceLoader']"
	[global::Android.Runtime.Register ("org/encog/engine/util/ResourceLoader", DoNotGenerateAcw=true)]
	public sealed partial class ResourceLoader : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/encog/engine/util/ResourceLoader", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ResourceLoader); }
		}

		internal ResourceLoader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_createInputStream_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.util']/class[@name='ResourceLoader']/method[@name='createInputStream' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("createInputStream", "(Ljava/lang/String;)Ljava/io/InputStream;", "")]
		public static unsafe global::System.IO.Stream CreateInputStream (string p0)
		{
			if (id_createInputStream_Ljava_lang_String_ == IntPtr.Zero)
				id_createInputStream_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "createInputStream", "(Ljava/lang/String;)Ljava/io/InputStream;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::System.IO.Stream __ret = global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_createInputStream_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_loadString_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.util']/class[@name='ResourceLoader']/method[@name='loadString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("loadString", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string LoadString (string p0)
		{
			if (id_loadString_Ljava_lang_String_ == IntPtr.Zero)
				id_loadString_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "loadString", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_loadString_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
