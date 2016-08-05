using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Encog.Engine.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.encog.engine.util']/class[@name='Format']"
	[global::Android.Runtime.Register ("org/encog/engine/util/Format", DoNotGenerateAcw=true)]
	public sealed partial class Format : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.encog.engine.util']/class[@name='Format']/field[@name='MEMORY_GIG']"
		[Register ("MEMORY_GIG")]
		public const long MemoryGig = (long) 1073741824L;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.encog.engine.util']/class[@name='Format']/field[@name='MEMORY_K']"
		[Register ("MEMORY_K")]
		public const long MemoryK = (long) 1024L;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.encog.engine.util']/class[@name='Format']/field[@name='MEMORY_MEG']"
		[Register ("MEMORY_MEG")]
		public const long MemoryMeg = (long) 1048576L;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.encog.engine.util']/class[@name='Format']/field[@name='MEMORY_TERA']"
		[Register ("MEMORY_TERA")]
		public const long MemoryTera = (long) 1099511627776L;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.encog.engine.util']/class[@name='Format']/field[@name='SECONDS_INA_DAY']"
		[Register ("SECONDS_INA_DAY")]
		public const int SecondsInaDay = (int) 86400;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.encog.engine.util']/class[@name='Format']/field[@name='SECONDS_INA_HOUR']"
		[Register ("SECONDS_INA_HOUR")]
		public const int SecondsInaHour = (int) 3600;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.encog.engine.util']/class[@name='Format']/field[@name='SECONDS_INA_MINUTE']"
		[Register ("SECONDS_INA_MINUTE")]
		public const int SecondsInaMinute = (int) 60;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/encog/engine/util/Format", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Format); }
		}

		internal Format (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_formatDouble_DI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.util']/class[@name='Format']/method[@name='formatDouble' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='int']]"
		[Register ("formatDouble", "(DI)Ljava/lang/String;", "")]
		public static unsafe string FormatDouble (double p0, int p1)
		{
			if (id_formatDouble_DI == IntPtr.Zero)
				id_formatDouble_DI = JNIEnv.GetStaticMethodID (class_ref, "formatDouble", "(DI)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_formatDouble_DI, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_formatInteger_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.util']/class[@name='Format']/method[@name='formatInteger' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("formatInteger", "(I)Ljava/lang/String;", "")]
		public static unsafe string FormatInteger (int p0)
		{
			if (id_formatInteger_I == IntPtr.Zero)
				id_formatInteger_I = JNIEnv.GetStaticMethodID (class_ref, "formatInteger", "(I)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_formatInteger_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_formatMemory_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.util']/class[@name='Format']/method[@name='formatMemory' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("formatMemory", "(J)Ljava/lang/String;", "")]
		public static unsafe string FormatMemory (long p0)
		{
			if (id_formatMemory_J == IntPtr.Zero)
				id_formatMemory_J = JNIEnv.GetStaticMethodID (class_ref, "formatMemory", "(J)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_formatMemory_J, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_formatPercent_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.util']/class[@name='Format']/method[@name='formatPercent' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("formatPercent", "(D)Ljava/lang/String;", "")]
		public static unsafe string FormatPercent (double p0)
		{
			if (id_formatPercent_D == IntPtr.Zero)
				id_formatPercent_D = JNIEnv.GetStaticMethodID (class_ref, "formatPercent", "(D)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_formatPercent_D, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_formatPercentWhole_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.util']/class[@name='Format']/method[@name='formatPercentWhole' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("formatPercentWhole", "(D)Ljava/lang/String;", "")]
		public static unsafe string FormatPercentWhole (double p0)
		{
			if (id_formatPercentWhole_D == IntPtr.Zero)
				id_formatPercentWhole_D = JNIEnv.GetStaticMethodID (class_ref, "formatPercentWhole", "(D)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_formatPercentWhole_D, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_formatTimeSpan_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.util']/class[@name='Format']/method[@name='formatTimeSpan' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("formatTimeSpan", "(I)Ljava/lang/String;", "")]
		public static unsafe string FormatTimeSpan (int p0)
		{
			if (id_formatTimeSpan_I == IntPtr.Zero)
				id_formatTimeSpan_I = JNIEnv.GetStaticMethodID (class_ref, "formatTimeSpan", "(I)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_formatTimeSpan_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
