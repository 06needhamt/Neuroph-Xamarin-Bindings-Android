using System;
using System.Collections.Generic;
using Android.Runtime;

namespace CH.Qos.Logback.Classic {

	// Metadata.xml XPath class reference: path="/api/package[@name='ch.qos.logback.classic']/class[@name='Level']"
	[global::Android.Runtime.Register ("ch/qos/logback/classic/Level", DoNotGenerateAcw=true)]
	public sealed partial class Level : global::Java.Lang.Object, global::Java.IO.ISerializable {


		static IntPtr ALL_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='ch.qos.logback.classic']/class[@name='Level']/field[@name='ALL']"
		[Register ("ALL")]
		public static global::CH.Qos.Logback.Classic.Level All {
			get {
				if (ALL_jfieldId == IntPtr.Zero)
					ALL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ALL", "Lch/qos/logback/classic/Level;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ALL_jfieldId);
				return global::Java.Lang.Object.GetObject<global::CH.Qos.Logback.Classic.Level> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='ch.qos.logback.classic']/class[@name='Level']/field[@name='ALL_INT']"
		[Register ("ALL_INT")]
		public const int AllInt = (int) -2147483648;

		static IntPtr ALL_INTEGER_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='ch.qos.logback.classic']/class[@name='Level']/field[@name='ALL_INTEGER']"
		[Register ("ALL_INTEGER")]
		public static global::Java.Lang.Integer AllInteger {
			get {
				if (ALL_INTEGER_jfieldId == IntPtr.Zero)
					ALL_INTEGER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ALL_INTEGER", "Ljava/lang/Integer;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ALL_INTEGER_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr DEBUG_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='ch.qos.logback.classic']/class[@name='Level']/field[@name='DEBUG']"
		[Register ("DEBUG")]
		public static global::CH.Qos.Logback.Classic.Level Debug {
			get {
				if (DEBUG_jfieldId == IntPtr.Zero)
					DEBUG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEBUG", "Lch/qos/logback/classic/Level;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DEBUG_jfieldId);
				return global::Java.Lang.Object.GetObject<global::CH.Qos.Logback.Classic.Level> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='ch.qos.logback.classic']/class[@name='Level']/field[@name='DEBUG_INT']"
		[Register ("DEBUG_INT")]
		public const int DebugInt = (int) 10000;

		static IntPtr DEBUG_INTEGER_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='ch.qos.logback.classic']/class[@name='Level']/field[@name='DEBUG_INTEGER']"
		[Register ("DEBUG_INTEGER")]
		public static global::Java.Lang.Integer DebugInteger {
			get {
				if (DEBUG_INTEGER_jfieldId == IntPtr.Zero)
					DEBUG_INTEGER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEBUG_INTEGER", "Ljava/lang/Integer;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DEBUG_INTEGER_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ERROR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='ch.qos.logback.classic']/class[@name='Level']/field[@name='ERROR']"
		[Register ("ERROR")]
		public static global::CH.Qos.Logback.Classic.Level Error {
			get {
				if (ERROR_jfieldId == IntPtr.Zero)
					ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ERROR", "Lch/qos/logback/classic/Level;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ERROR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::CH.Qos.Logback.Classic.Level> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='ch.qos.logback.classic']/class[@name='Level']/field[@name='ERROR_INT']"
		[Register ("ERROR_INT")]
		public const int ErrorInt = (int) 40000;

		static IntPtr ERROR_INTEGER_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='ch.qos.logback.classic']/class[@name='Level']/field[@name='ERROR_INTEGER']"
		[Register ("ERROR_INTEGER")]
		public static global::Java.Lang.Integer ErrorInteger {
			get {
				if (ERROR_INTEGER_jfieldId == IntPtr.Zero)
					ERROR_INTEGER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ERROR_INTEGER", "Ljava/lang/Integer;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ERROR_INTEGER_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr INFO_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='ch.qos.logback.classic']/class[@name='Level']/field[@name='INFO']"
		[Register ("INFO")]
		public static global::CH.Qos.Logback.Classic.Level Info {
			get {
				if (INFO_jfieldId == IntPtr.Zero)
					INFO_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INFO", "Lch/qos/logback/classic/Level;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INFO_jfieldId);
				return global::Java.Lang.Object.GetObject<global::CH.Qos.Logback.Classic.Level> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='ch.qos.logback.classic']/class[@name='Level']/field[@name='INFO_INT']"
		[Register ("INFO_INT")]
		public const int InfoInt = (int) 20000;

		static IntPtr INFO_INTEGER_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='ch.qos.logback.classic']/class[@name='Level']/field[@name='INFO_INTEGER']"
		[Register ("INFO_INTEGER")]
		public static global::Java.Lang.Integer InfoInteger {
			get {
				if (INFO_INTEGER_jfieldId == IntPtr.Zero)
					INFO_INTEGER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INFO_INTEGER", "Ljava/lang/Integer;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INFO_INTEGER_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr OFF_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='ch.qos.logback.classic']/class[@name='Level']/field[@name='OFF']"
		[Register ("OFF")]
		public static global::CH.Qos.Logback.Classic.Level Off {
			get {
				if (OFF_jfieldId == IntPtr.Zero)
					OFF_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OFF", "Lch/qos/logback/classic/Level;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, OFF_jfieldId);
				return global::Java.Lang.Object.GetObject<global::CH.Qos.Logback.Classic.Level> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='ch.qos.logback.classic']/class[@name='Level']/field[@name='OFF_INT']"
		[Register ("OFF_INT")]
		public const int OffInt = (int) 2147483647;

		static IntPtr OFF_INTEGER_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='ch.qos.logback.classic']/class[@name='Level']/field[@name='OFF_INTEGER']"
		[Register ("OFF_INTEGER")]
		public static global::Java.Lang.Integer OffInteger {
			get {
				if (OFF_INTEGER_jfieldId == IntPtr.Zero)
					OFF_INTEGER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OFF_INTEGER", "Ljava/lang/Integer;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, OFF_INTEGER_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TRACE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='ch.qos.logback.classic']/class[@name='Level']/field[@name='TRACE']"
		[Register ("TRACE")]
		public static global::CH.Qos.Logback.Classic.Level Trace {
			get {
				if (TRACE_jfieldId == IntPtr.Zero)
					TRACE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TRACE", "Lch/qos/logback/classic/Level;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TRACE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::CH.Qos.Logback.Classic.Level> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='ch.qos.logback.classic']/class[@name='Level']/field[@name='TRACE_INT']"
		[Register ("TRACE_INT")]
		public const int TraceInt = (int) 5000;

		static IntPtr TRACE_INTEGER_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='ch.qos.logback.classic']/class[@name='Level']/field[@name='TRACE_INTEGER']"
		[Register ("TRACE_INTEGER")]
		public static global::Java.Lang.Integer TraceInteger {
			get {
				if (TRACE_INTEGER_jfieldId == IntPtr.Zero)
					TRACE_INTEGER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TRACE_INTEGER", "Ljava/lang/Integer;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TRACE_INTEGER_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr WARN_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='ch.qos.logback.classic']/class[@name='Level']/field[@name='WARN']"
		[Register ("WARN")]
		public static global::CH.Qos.Logback.Classic.Level Warn {
			get {
				if (WARN_jfieldId == IntPtr.Zero)
					WARN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "WARN", "Lch/qos/logback/classic/Level;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, WARN_jfieldId);
				return global::Java.Lang.Object.GetObject<global::CH.Qos.Logback.Classic.Level> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='ch.qos.logback.classic']/class[@name='Level']/field[@name='WARN_INT']"
		[Register ("WARN_INT")]
		public const int WarnInt = (int) 30000;

		static IntPtr WARN_INTEGER_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='ch.qos.logback.classic']/class[@name='Level']/field[@name='WARN_INTEGER']"
		[Register ("WARN_INTEGER")]
		public static global::Java.Lang.Integer WarnInteger {
			get {
				if (WARN_INTEGER_jfieldId == IntPtr.Zero)
					WARN_INTEGER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "WARN_INTEGER", "Ljava/lang/Integer;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, WARN_INTEGER_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr levelInt_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='ch.qos.logback.classic']/class[@name='Level']/field[@name='levelInt']"
		[Register ("levelInt")]
		public int LevelInt {
			get {
				if (levelInt_jfieldId == IntPtr.Zero)
					levelInt_jfieldId = JNIEnv.GetFieldID (class_ref, "levelInt", "I");
				return JNIEnv.GetIntField (Handle, levelInt_jfieldId);
			}
			set {
				if (levelInt_jfieldId == IntPtr.Zero)
					levelInt_jfieldId = JNIEnv.GetFieldID (class_ref, "levelInt", "I");
				try {
					JNIEnv.SetField (Handle, levelInt_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr levelStr_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='ch.qos.logback.classic']/class[@name='Level']/field[@name='levelStr']"
		[Register ("levelStr")]
		public string LevelStr {
			get {
				if (levelStr_jfieldId == IntPtr.Zero)
					levelStr_jfieldId = JNIEnv.GetFieldID (class_ref, "levelStr", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, levelStr_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (levelStr_jfieldId == IntPtr.Zero)
					levelStr_jfieldId = JNIEnv.GetFieldID (class_ref, "levelStr", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, levelStr_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("ch/qos/logback/classic/Level", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Level); }
		}

		internal Level (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_fromLocationAwareLoggerInteger_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='ch.qos.logback.classic']/class[@name='Level']/method[@name='fromLocationAwareLoggerInteger' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("fromLocationAwareLoggerInteger", "(I)Lch/qos/logback/classic/Level;", "")]
		public static unsafe global::CH.Qos.Logback.Classic.Level FromLocationAwareLoggerInteger (int p0)
		{
			if (id_fromLocationAwareLoggerInteger_I == IntPtr.Zero)
				id_fromLocationAwareLoggerInteger_I = JNIEnv.GetStaticMethodID (class_ref, "fromLocationAwareLoggerInteger", "(I)Lch/qos/logback/classic/Level;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::CH.Qos.Logback.Classic.Level> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromLocationAwareLoggerInteger_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_isGreaterOrEqual_Lch_qos_logback_classic_Level_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ch.qos.logback.classic']/class[@name='Level']/method[@name='isGreaterOrEqual' and count(parameter)=1 and parameter[1][@type='ch.qos.logback.classic.Level']]"
		[Register ("isGreaterOrEqual", "(Lch/qos/logback/classic/Level;)Z", "")]
		public unsafe bool IsGreaterOrEqual (global::CH.Qos.Logback.Classic.Level p0)
		{
			if (id_isGreaterOrEqual_Lch_qos_logback_classic_Level_ == IntPtr.Zero)
				id_isGreaterOrEqual_Lch_qos_logback_classic_Level_ = JNIEnv.GetMethodID (class_ref, "isGreaterOrEqual", "(Lch/qos/logback/classic/Level;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_isGreaterOrEqual_Lch_qos_logback_classic_Level_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_toInt;
		// Metadata.xml XPath method reference: path="/api/package[@name='ch.qos.logback.classic']/class[@name='Level']/method[@name='toInt' and count(parameter)=0]"
		[Register ("toInt", "()I", "")]
		public unsafe int ToInt ()
		{
			if (id_toInt == IntPtr.Zero)
				id_toInt = JNIEnv.GetMethodID (class_ref, "toInt", "()I");
			try {
				return JNIEnv.CallIntMethod  (Handle, id_toInt);
			} finally {
			}
		}

		static IntPtr id_toInteger;
		// Metadata.xml XPath method reference: path="/api/package[@name='ch.qos.logback.classic']/class[@name='Level']/method[@name='toInteger' and count(parameter)=0]"
		[Register ("toInteger", "()Ljava/lang/Integer;", "")]
		public unsafe global::Java.Lang.Integer ToInteger ()
		{
			if (id_toInteger == IntPtr.Zero)
				id_toInteger = JNIEnv.GetMethodID (class_ref, "toInteger", "()Ljava/lang/Integer;");
			try {
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod  (Handle, id_toInteger), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_toLevel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='ch.qos.logback.classic']/class[@name='Level']/method[@name='toLevel' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("toLevel", "(I)Lch/qos/logback/classic/Level;", "")]
		public static unsafe global::CH.Qos.Logback.Classic.Level ToLevel (int p0)
		{
			if (id_toLevel_I == IntPtr.Zero)
				id_toLevel_I = JNIEnv.GetStaticMethodID (class_ref, "toLevel", "(I)Lch/qos/logback/classic/Level;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::CH.Qos.Logback.Classic.Level> (JNIEnv.CallStaticObjectMethod  (class_ref, id_toLevel_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_toLevel_ILch_qos_logback_classic_Level_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ch.qos.logback.classic']/class[@name='Level']/method[@name='toLevel' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='ch.qos.logback.classic.Level']]"
		[Register ("toLevel", "(ILch/qos/logback/classic/Level;)Lch/qos/logback/classic/Level;", "")]
		public static unsafe global::CH.Qos.Logback.Classic.Level ToLevel (int p0, global::CH.Qos.Logback.Classic.Level p1)
		{
			if (id_toLevel_ILch_qos_logback_classic_Level_ == IntPtr.Zero)
				id_toLevel_ILch_qos_logback_classic_Level_ = JNIEnv.GetStaticMethodID (class_ref, "toLevel", "(ILch/qos/logback/classic/Level;)Lch/qos/logback/classic/Level;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::CH.Qos.Logback.Classic.Level __ret = global::Java.Lang.Object.GetObject<global::CH.Qos.Logback.Classic.Level> (JNIEnv.CallStaticObjectMethod  (class_ref, id_toLevel_ILch_qos_logback_classic_Level_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_toLevel_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ch.qos.logback.classic']/class[@name='Level']/method[@name='toLevel' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("toLevel", "(Ljava/lang/String;)Lch/qos/logback/classic/Level;", "")]
		public static unsafe global::CH.Qos.Logback.Classic.Level ToLevel (string p0)
		{
			if (id_toLevel_Ljava_lang_String_ == IntPtr.Zero)
				id_toLevel_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "toLevel", "(Ljava/lang/String;)Lch/qos/logback/classic/Level;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::CH.Qos.Logback.Classic.Level __ret = global::Java.Lang.Object.GetObject<global::CH.Qos.Logback.Classic.Level> (JNIEnv.CallStaticObjectMethod  (class_ref, id_toLevel_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_toLevel_Ljava_lang_String_Lch_qos_logback_classic_Level_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ch.qos.logback.classic']/class[@name='Level']/method[@name='toLevel' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='ch.qos.logback.classic.Level']]"
		[Register ("toLevel", "(Ljava/lang/String;Lch/qos/logback/classic/Level;)Lch/qos/logback/classic/Level;", "")]
		public static unsafe global::CH.Qos.Logback.Classic.Level ToLevel (string p0, global::CH.Qos.Logback.Classic.Level p1)
		{
			if (id_toLevel_Ljava_lang_String_Lch_qos_logback_classic_Level_ == IntPtr.Zero)
				id_toLevel_Ljava_lang_String_Lch_qos_logback_classic_Level_ = JNIEnv.GetStaticMethodID (class_ref, "toLevel", "(Ljava/lang/String;Lch/qos/logback/classic/Level;)Lch/qos/logback/classic/Level;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				global::CH.Qos.Logback.Classic.Level __ret = global::Java.Lang.Object.GetObject<global::CH.Qos.Logback.Classic.Level> (JNIEnv.CallStaticObjectMethod  (class_ref, id_toLevel_Ljava_lang_String_Lch_qos_logback_classic_Level_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_toLocationAwareLoggerInteger_Lch_qos_logback_classic_Level_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ch.qos.logback.classic']/class[@name='Level']/method[@name='toLocationAwareLoggerInteger' and count(parameter)=1 and parameter[1][@type='ch.qos.logback.classic.Level']]"
		[Register ("toLocationAwareLoggerInteger", "(Lch/qos/logback/classic/Level;)I", "")]
		public static unsafe int ToLocationAwareLoggerInteger (global::CH.Qos.Logback.Classic.Level p0)
		{
			if (id_toLocationAwareLoggerInteger_Lch_qos_logback_classic_Level_ == IntPtr.Zero)
				id_toLocationAwareLoggerInteger_Lch_qos_logback_classic_Level_ = JNIEnv.GetStaticMethodID (class_ref, "toLocationAwareLoggerInteger", "(Lch/qos/logback/classic/Level;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_toLocationAwareLoggerInteger_Lch_qos_logback_classic_Level_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ch.qos.logback.classic']/class[@name='Level']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lch/qos/logback/classic/Level;", "")]
		public static unsafe global::CH.Qos.Logback.Classic.Level ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lch/qos/logback/classic/Level;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::CH.Qos.Logback.Classic.Level __ret = global::Java.Lang.Object.GetObject<global::CH.Qos.Logback.Classic.Level> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
