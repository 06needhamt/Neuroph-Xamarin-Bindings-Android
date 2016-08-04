using System;
using System.Collections.Generic;
using Android.Runtime;

namespace CH.Qos.Logback.Classic.DB.Names {

	// Metadata.xml XPath class reference: path="/api/package[@name='ch.qos.logback.classic.db.names']/class[@name='TableName']"
	[global::Android.Runtime.Register ("ch/qos/logback/classic/db/names/TableName", DoNotGenerateAcw=true)]
	public sealed partial class TableName : global::Java.Lang.Enum {


		static IntPtr LOGGING_EVENT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='ch.qos.logback.classic.db.names']/class[@name='TableName']/field[@name='LOGGING_EVENT']"
		[Register ("LOGGING_EVENT")]
		public static global::CH.Qos.Logback.Classic.DB.Names.TableName LoggingEvent {
			get {
				if (LOGGING_EVENT_jfieldId == IntPtr.Zero)
					LOGGING_EVENT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LOGGING_EVENT", "Lch/qos/logback/classic/db/names/TableName;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LOGGING_EVENT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::CH.Qos.Logback.Classic.DB.Names.TableName> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr LOGGING_EVENT_EXCEPTION_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='ch.qos.logback.classic.db.names']/class[@name='TableName']/field[@name='LOGGING_EVENT_EXCEPTION']"
		[Register ("LOGGING_EVENT_EXCEPTION")]
		public static global::CH.Qos.Logback.Classic.DB.Names.TableName LoggingEventException {
			get {
				if (LOGGING_EVENT_EXCEPTION_jfieldId == IntPtr.Zero)
					LOGGING_EVENT_EXCEPTION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LOGGING_EVENT_EXCEPTION", "Lch/qos/logback/classic/db/names/TableName;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LOGGING_EVENT_EXCEPTION_jfieldId);
				return global::Java.Lang.Object.GetObject<global::CH.Qos.Logback.Classic.DB.Names.TableName> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr LOGGING_EVENT_PROPERTY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='ch.qos.logback.classic.db.names']/class[@name='TableName']/field[@name='LOGGING_EVENT_PROPERTY']"
		[Register ("LOGGING_EVENT_PROPERTY")]
		public static global::CH.Qos.Logback.Classic.DB.Names.TableName LoggingEventProperty {
			get {
				if (LOGGING_EVENT_PROPERTY_jfieldId == IntPtr.Zero)
					LOGGING_EVENT_PROPERTY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LOGGING_EVENT_PROPERTY", "Lch/qos/logback/classic/db/names/TableName;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LOGGING_EVENT_PROPERTY_jfieldId);
				return global::Java.Lang.Object.GetObject<global::CH.Qos.Logback.Classic.DB.Names.TableName> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("ch/qos/logback/classic/db/names/TableName", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TableName); }
		}

		internal TableName (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ch.qos.logback.classic.db.names']/class[@name='TableName']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lch/qos/logback/classic/db/names/TableName;", "")]
		public static unsafe global::CH.Qos.Logback.Classic.DB.Names.TableName ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lch/qos/logback/classic/db/names/TableName;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::CH.Qos.Logback.Classic.DB.Names.TableName __ret = global::Java.Lang.Object.GetObject<global::CH.Qos.Logback.Classic.DB.Names.TableName> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='ch.qos.logback.classic.db.names']/class[@name='TableName']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lch/qos/logback/classic/db/names/TableName;", "")]
		public static unsafe global::CH.Qos.Logback.Classic.DB.Names.TableName[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lch/qos/logback/classic/db/names/TableName;");
			try {
				return (global::CH.Qos.Logback.Classic.DB.Names.TableName[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::CH.Qos.Logback.Classic.DB.Names.TableName));
			} finally {
			}
		}

	}
}
