using System;
using System.Collections.Generic;
using Android.Runtime;

namespace CH.Qos.Logback.Classic.Spi {

	// Metadata.xml XPath class reference: path="/api/package[@name='ch.qos.logback.classic.spi']/class[@name='ThrowableProxyUtil']"
	[global::Android.Runtime.Register ("ch/qos/logback/classic/spi/ThrowableProxyUtil", DoNotGenerateAcw=true)]
	public partial class ThrowableProxyUtil : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='ch.qos.logback.classic.spi']/class[@name='ThrowableProxyUtil']/field[@name='REGULAR_EXCEPTION_INDENT']"
		[Register ("REGULAR_EXCEPTION_INDENT")]
		public const int RegularExceptionIndent = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='ch.qos.logback.classic.spi']/class[@name='ThrowableProxyUtil']/field[@name='SUPPRESSED_EXCEPTION_INDENT']"
		[Register ("SUPPRESSED_EXCEPTION_INDENT")]
		public const int SuppressedExceptionIndent = (int) 2;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("ch/qos/logback/classic/spi/ThrowableProxyUtil", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ThrowableProxyUtil); }
		}

		protected ThrowableProxyUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='ch.qos.logback.classic.spi']/class[@name='ThrowableProxyUtil']/constructor[@name='ThrowableProxyUtil' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ThrowableProxyUtil ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ThrowableProxyUtil)) {
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

		static IntPtr id_asString_Lch_qos_logback_classic_spi_IThrowableProxy_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ch.qos.logback.classic.spi']/class[@name='ThrowableProxyUtil']/method[@name='asString' and count(parameter)=1 and parameter[1][@type='ch.qos.logback.classic.spi.IThrowableProxy']]"
		[Register ("asString", "(Lch/qos/logback/classic/spi/IThrowableProxy;)Ljava/lang/String;", "")]
		public static unsafe string AsString (global::CH.Qos.Logback.Classic.Spi.IThrowableProxy p0)
		{
			if (id_asString_Lch_qos_logback_classic_spi_IThrowableProxy_ == IntPtr.Zero)
				id_asString_Lch_qos_logback_classic_spi_IThrowableProxy_ = JNIEnv.GetStaticMethodID (class_ref, "asString", "(Lch/qos/logback/classic/spi/IThrowableProxy;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_asString_Lch_qos_logback_classic_spi_IThrowableProxy_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_build_Lch_qos_logback_classic_spi_ThrowableProxy_Ljava_lang_Throwable_Lch_qos_logback_classic_spi_ThrowableProxy_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ch.qos.logback.classic.spi']/class[@name='ThrowableProxyUtil']/method[@name='build' and count(parameter)=3 and parameter[1][@type='ch.qos.logback.classic.spi.ThrowableProxy'] and parameter[2][@type='java.lang.Throwable'] and parameter[3][@type='ch.qos.logback.classic.spi.ThrowableProxy']]"
		[Register ("build", "(Lch/qos/logback/classic/spi/ThrowableProxy;Ljava/lang/Throwable;Lch/qos/logback/classic/spi/ThrowableProxy;)V", "")]
		public static unsafe void Build (global::CH.Qos.Logback.Classic.Spi.ThrowableProxy p0, global::Java.Lang.Throwable p1, global::CH.Qos.Logback.Classic.Spi.ThrowableProxy p2)
		{
			if (id_build_Lch_qos_logback_classic_spi_ThrowableProxy_Ljava_lang_Throwable_Lch_qos_logback_classic_spi_ThrowableProxy_ == IntPtr.Zero)
				id_build_Lch_qos_logback_classic_spi_ThrowableProxy_Ljava_lang_Throwable_Lch_qos_logback_classic_spi_ThrowableProxy_ = JNIEnv.GetStaticMethodID (class_ref, "build", "(Lch/qos/logback/classic/spi/ThrowableProxy;Ljava/lang/Throwable;Lch/qos/logback/classic/spi/ThrowableProxy;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_build_Lch_qos_logback_classic_spi_ThrowableProxy_Ljava_lang_Throwable_Lch_qos_logback_classic_spi_ThrowableProxy_, __args);
			} finally {
			}
		}

		static IntPtr id_subjoinFirstLine_Ljava_lang_StringBuilder_Lch_qos_logback_classic_spi_IThrowableProxy_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ch.qos.logback.classic.spi']/class[@name='ThrowableProxyUtil']/method[@name='subjoinFirstLine' and count(parameter)=2 and parameter[1][@type='java.lang.StringBuilder'] and parameter[2][@type='ch.qos.logback.classic.spi.IThrowableProxy']]"
		[Register ("subjoinFirstLine", "(Ljava/lang/StringBuilder;Lch/qos/logback/classic/spi/IThrowableProxy;)V", "")]
		public static unsafe void SubjoinFirstLine (global::Java.Lang.StringBuilder p0, global::CH.Qos.Logback.Classic.Spi.IThrowableProxy p1)
		{
			if (id_subjoinFirstLine_Ljava_lang_StringBuilder_Lch_qos_logback_classic_spi_IThrowableProxy_ == IntPtr.Zero)
				id_subjoinFirstLine_Ljava_lang_StringBuilder_Lch_qos_logback_classic_spi_IThrowableProxy_ = JNIEnv.GetStaticMethodID (class_ref, "subjoinFirstLine", "(Ljava/lang/StringBuilder;Lch/qos/logback/classic/spi/IThrowableProxy;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_subjoinFirstLine_Ljava_lang_StringBuilder_Lch_qos_logback_classic_spi_IThrowableProxy_, __args);
			} finally {
			}
		}

		static IntPtr id_subjoinFirstLineRootCauseFirst_Ljava_lang_StringBuilder_Lch_qos_logback_classic_spi_IThrowableProxy_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ch.qos.logback.classic.spi']/class[@name='ThrowableProxyUtil']/method[@name='subjoinFirstLineRootCauseFirst' and count(parameter)=2 and parameter[1][@type='java.lang.StringBuilder'] and parameter[2][@type='ch.qos.logback.classic.spi.IThrowableProxy']]"
		[Register ("subjoinFirstLineRootCauseFirst", "(Ljava/lang/StringBuilder;Lch/qos/logback/classic/spi/IThrowableProxy;)V", "")]
		public static unsafe void SubjoinFirstLineRootCauseFirst (global::Java.Lang.StringBuilder p0, global::CH.Qos.Logback.Classic.Spi.IThrowableProxy p1)
		{
			if (id_subjoinFirstLineRootCauseFirst_Ljava_lang_StringBuilder_Lch_qos_logback_classic_spi_IThrowableProxy_ == IntPtr.Zero)
				id_subjoinFirstLineRootCauseFirst_Ljava_lang_StringBuilder_Lch_qos_logback_classic_spi_IThrowableProxy_ = JNIEnv.GetStaticMethodID (class_ref, "subjoinFirstLineRootCauseFirst", "(Ljava/lang/StringBuilder;Lch/qos/logback/classic/spi/IThrowableProxy;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_subjoinFirstLineRootCauseFirst_Ljava_lang_StringBuilder_Lch_qos_logback_classic_spi_IThrowableProxy_, __args);
			} finally {
			}
		}

		static IntPtr id_subjoinPackagingData_Ljava_lang_StringBuilder_Lch_qos_logback_classic_spi_StackTraceElementProxy_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ch.qos.logback.classic.spi']/class[@name='ThrowableProxyUtil']/method[@name='subjoinPackagingData' and count(parameter)=2 and parameter[1][@type='java.lang.StringBuilder'] and parameter[2][@type='ch.qos.logback.classic.spi.StackTraceElementProxy']]"
		[Register ("subjoinPackagingData", "(Ljava/lang/StringBuilder;Lch/qos/logback/classic/spi/StackTraceElementProxy;)V", "")]
		public static unsafe void SubjoinPackagingData (global::Java.Lang.StringBuilder p0, global::CH.Qos.Logback.Classic.Spi.StackTraceElementProxy p1)
		{
			if (id_subjoinPackagingData_Ljava_lang_StringBuilder_Lch_qos_logback_classic_spi_StackTraceElementProxy_ == IntPtr.Zero)
				id_subjoinPackagingData_Ljava_lang_StringBuilder_Lch_qos_logback_classic_spi_StackTraceElementProxy_ = JNIEnv.GetStaticMethodID (class_ref, "subjoinPackagingData", "(Ljava/lang/StringBuilder;Lch/qos/logback/classic/spi/StackTraceElementProxy;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_subjoinPackagingData_Ljava_lang_StringBuilder_Lch_qos_logback_classic_spi_StackTraceElementProxy_, __args);
			} finally {
			}
		}

		static IntPtr id_subjoinSTEP_Ljava_lang_StringBuilder_Lch_qos_logback_classic_spi_StackTraceElementProxy_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ch.qos.logback.classic.spi']/class[@name='ThrowableProxyUtil']/method[@name='subjoinSTEP' and count(parameter)=2 and parameter[1][@type='java.lang.StringBuilder'] and parameter[2][@type='ch.qos.logback.classic.spi.StackTraceElementProxy']]"
		[Register ("subjoinSTEP", "(Ljava/lang/StringBuilder;Lch/qos/logback/classic/spi/StackTraceElementProxy;)V", "")]
		public static unsafe void SubjoinSTEP (global::Java.Lang.StringBuilder p0, global::CH.Qos.Logback.Classic.Spi.StackTraceElementProxy p1)
		{
			if (id_subjoinSTEP_Ljava_lang_StringBuilder_Lch_qos_logback_classic_spi_StackTraceElementProxy_ == IntPtr.Zero)
				id_subjoinSTEP_Ljava_lang_StringBuilder_Lch_qos_logback_classic_spi_StackTraceElementProxy_ = JNIEnv.GetStaticMethodID (class_ref, "subjoinSTEP", "(Ljava/lang/StringBuilder;Lch/qos/logback/classic/spi/StackTraceElementProxy;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_subjoinSTEP_Ljava_lang_StringBuilder_Lch_qos_logback_classic_spi_StackTraceElementProxy_, __args);
			} finally {
			}
		}

		static IntPtr id_subjoinSTEPArray_Ljava_lang_StringBuilder_Lch_qos_logback_classic_spi_IThrowableProxy_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ch.qos.logback.classic.spi']/class[@name='ThrowableProxyUtil']/method[@name='subjoinSTEPArray' and count(parameter)=2 and parameter[1][@type='java.lang.StringBuilder'] and parameter[2][@type='ch.qos.logback.classic.spi.IThrowableProxy']]"
		[Register ("subjoinSTEPArray", "(Ljava/lang/StringBuilder;Lch/qos/logback/classic/spi/IThrowableProxy;)V", "")]
		public static unsafe void SubjoinSTEPArray (global::Java.Lang.StringBuilder p0, global::CH.Qos.Logback.Classic.Spi.IThrowableProxy p1)
		{
			if (id_subjoinSTEPArray_Ljava_lang_StringBuilder_Lch_qos_logback_classic_spi_IThrowableProxy_ == IntPtr.Zero)
				id_subjoinSTEPArray_Ljava_lang_StringBuilder_Lch_qos_logback_classic_spi_IThrowableProxy_ = JNIEnv.GetStaticMethodID (class_ref, "subjoinSTEPArray", "(Ljava/lang/StringBuilder;Lch/qos/logback/classic/spi/IThrowableProxy;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_subjoinSTEPArray_Ljava_lang_StringBuilder_Lch_qos_logback_classic_spi_IThrowableProxy_, __args);
			} finally {
			}
		}

		static IntPtr id_subjoinSTEPArray_Ljava_lang_StringBuilder_ILch_qos_logback_classic_spi_IThrowableProxy_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ch.qos.logback.classic.spi']/class[@name='ThrowableProxyUtil']/method[@name='subjoinSTEPArray' and count(parameter)=3 and parameter[1][@type='java.lang.StringBuilder'] and parameter[2][@type='int'] and parameter[3][@type='ch.qos.logback.classic.spi.IThrowableProxy']]"
		[Register ("subjoinSTEPArray", "(Ljava/lang/StringBuilder;ILch/qos/logback/classic/spi/IThrowableProxy;)V", "")]
		public static unsafe void SubjoinSTEPArray (global::Java.Lang.StringBuilder p0, int p1, global::CH.Qos.Logback.Classic.Spi.IThrowableProxy p2)
		{
			if (id_subjoinSTEPArray_Ljava_lang_StringBuilder_ILch_qos_logback_classic_spi_IThrowableProxy_ == IntPtr.Zero)
				id_subjoinSTEPArray_Ljava_lang_StringBuilder_ILch_qos_logback_classic_spi_IThrowableProxy_ = JNIEnv.GetStaticMethodID (class_ref, "subjoinSTEPArray", "(Ljava/lang/StringBuilder;ILch/qos/logback/classic/spi/IThrowableProxy;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_subjoinSTEPArray_Ljava_lang_StringBuilder_ILch_qos_logback_classic_spi_IThrowableProxy_, __args);
			} finally {
			}
		}

	}
}
