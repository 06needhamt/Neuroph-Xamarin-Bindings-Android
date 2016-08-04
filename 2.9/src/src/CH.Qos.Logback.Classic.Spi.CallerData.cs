using System;
using System.Collections.Generic;
using Android.Runtime;

namespace CH.Qos.Logback.Classic.Spi {

	// Metadata.xml XPath class reference: path="/api/package[@name='ch.qos.logback.classic.spi']/class[@name='CallerData']"
	[global::Android.Runtime.Register ("ch/qos/logback/classic/spi/CallerData", DoNotGenerateAcw=true)]
	public partial class CallerData : global::Java.Lang.Object {


		static IntPtr CALLER_DATA_NA_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='ch.qos.logback.classic.spi']/class[@name='CallerData']/field[@name='CALLER_DATA_NA']"
		[Register ("CALLER_DATA_NA")]
		public static string CallerDataNa {
			get {
				if (CALLER_DATA_NA_jfieldId == IntPtr.Zero)
					CALLER_DATA_NA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CALLER_DATA_NA", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CALLER_DATA_NA_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr EMPTY_CALLER_DATA_ARRAY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='ch.qos.logback.classic.spi']/class[@name='CallerData']/field[@name='EMPTY_CALLER_DATA_ARRAY']"
		[Register ("EMPTY_CALLER_DATA_ARRAY")]
		public static IList<Java.Lang.StackTraceElement> EmptyCallerDataArray {
			get {
				if (EMPTY_CALLER_DATA_ARRAY_jfieldId == IntPtr.Zero)
					EMPTY_CALLER_DATA_ARRAY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EMPTY_CALLER_DATA_ARRAY", "[Ljava/lang/StackTraceElement;");
				return JavaArray<global::Java.Lang.StackTraceElement>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, EMPTY_CALLER_DATA_ARRAY_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='ch.qos.logback.classic.spi']/class[@name='CallerData']/field[@name='LINE_NA']"
		[Register ("LINE_NA")]
		public const int LineNa = (int) -1;

		// Metadata.xml XPath field reference: path="/api/package[@name='ch.qos.logback.classic.spi']/class[@name='CallerData']/field[@name='NA']"
		[Register ("NA")]
		public const string Na = (string) "?";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("ch/qos/logback/classic/spi/CallerData", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CallerData); }
		}

		protected CallerData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='ch.qos.logback.classic.spi']/class[@name='CallerData']/constructor[@name='CallerData' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CallerData ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (CallerData)) {
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

		static IntPtr id_extract_Ljava_lang_Throwable_Ljava_lang_String_ILjava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ch.qos.logback.classic.spi']/class[@name='CallerData']/method[@name='extract' and count(parameter)=4 and parameter[1][@type='java.lang.Throwable'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register ("extract", "(Ljava/lang/Throwable;Ljava/lang/String;ILjava/util/List;)[Ljava/lang/StackTraceElement;", "")]
		public static unsafe global::Java.Lang.StackTraceElement[] Extract (global::Java.Lang.Throwable p0, string p1, int p2, global::System.Collections.Generic.IList<string> p3)
		{
			if (id_extract_Ljava_lang_Throwable_Ljava_lang_String_ILjava_util_List_ == IntPtr.Zero)
				id_extract_Ljava_lang_Throwable_Ljava_lang_String_ILjava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "extract", "(Ljava/lang/Throwable;Ljava/lang/String;ILjava/util/List;)[Ljava/lang/StackTraceElement;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p3 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				global::Java.Lang.StackTraceElement[] __ret = (global::Java.Lang.StackTraceElement[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_extract_Ljava_lang_Throwable_Ljava_lang_String_ILjava_util_List_, __args), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.StackTraceElement));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static IntPtr id_naInstance;
		// Metadata.xml XPath method reference: path="/api/package[@name='ch.qos.logback.classic.spi']/class[@name='CallerData']/method[@name='naInstance' and count(parameter)=0]"
		[Register ("naInstance", "()Ljava/lang/StackTraceElement;", "")]
		public static unsafe global::Java.Lang.StackTraceElement NaInstance ()
		{
			if (id_naInstance == IntPtr.Zero)
				id_naInstance = JNIEnv.GetStaticMethodID (class_ref, "naInstance", "()Ljava/lang/StackTraceElement;");
			try {
				return global::Java.Lang.Object.GetObject<global::Java.Lang.StackTraceElement> (JNIEnv.CallStaticObjectMethod  (class_ref, id_naInstance), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
