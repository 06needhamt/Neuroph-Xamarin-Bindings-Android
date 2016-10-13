using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.util']/class[@name='VectorParser']"
	[global::Android.Runtime.Register ("org/neuroph/util/VectorParser", DoNotGenerateAcw=true)]
	public partial class VectorParser : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/util/VectorParser", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VectorParser); }
		}

		protected VectorParser (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.util']/class[@name='VectorParser']/constructor[@name='VectorParser' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe VectorParser ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (VectorParser)) {
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

		static IntPtr id_convertToVector_arrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util']/class[@name='VectorParser']/method[@name='convertToVector' and count(parameter)=1 and parameter[1][@type='double[]']]"
		[Register ("convertToVector", "([D)Ljava/util/ArrayList;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::Java.Lang.Double> ConvertToVector (double[] p0)
		{
			if (id_convertToVector_arrayD == IntPtr.Zero)
				id_convertToVector_arrayD = JNIEnv.GetStaticMethodID (class_ref, "convertToVector", "([D)Ljava/util/ArrayList;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::System.Collections.Generic.IList<global::Java.Lang.Double> __ret = global::Android.Runtime.JavaList<global::Java.Lang.Double>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_convertToVector_arrayD, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_parseDoubleArray_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util']/class[@name='VectorParser']/method[@name='parseDoubleArray' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("parseDoubleArray", "(Ljava/lang/String;)[D", "")]
		public static unsafe double[] ParseDoubleArray (string p0)
		{
			if (id_parseDoubleArray_Ljava_lang_String_ == IntPtr.Zero)
				id_parseDoubleArray_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "parseDoubleArray", "(Ljava/lang/String;)[D");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				double[] __ret = (double[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseDoubleArray_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (double));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_parseInteger_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util']/class[@name='VectorParser']/method[@name='parseInteger' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("parseInteger", "(Ljava/lang/String;)Ljava/util/ArrayList;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::Java.Lang.Integer> ParseInteger (string p0)
		{
			if (id_parseInteger_Ljava_lang_String_ == IntPtr.Zero)
				id_parseInteger_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "parseInteger", "(Ljava/lang/String;)Ljava/util/ArrayList;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::System.Collections.Generic.IList<global::Java.Lang.Integer> __ret = global::Android.Runtime.JavaList<global::Java.Lang.Integer>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseInteger_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_toDoubleArray_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util']/class[@name='VectorParser']/method[@name='toDoubleArray' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.Double&gt;']]"
		[Register ("toDoubleArray", "(Ljava/util/List;)[D", "")]
		public static unsafe double[] ToDoubleArray (global::System.Collections.Generic.IList<global::Java.Lang.Double> p0)
		{
			if (id_toDoubleArray_Ljava_util_List_ == IntPtr.Zero)
				id_toDoubleArray_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "toDoubleArray", "(Ljava/util/List;)[D");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Java.Lang.Double>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				double[] __ret = (double[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_toDoubleArray_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef, typeof (double));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
