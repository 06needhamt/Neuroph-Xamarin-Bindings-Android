using System;
using System.Collections.Generic;
using Android.Runtime;

namespace CH.Qos.Logback.Classic.Spi {

	// Metadata.xml XPath class reference: path="/api/package[@name='ch.qos.logback.classic.spi']/class[@name='ThrowableProxy']"
	[global::Android.Runtime.Register ("ch/qos/logback/classic/spi/ThrowableProxy", DoNotGenerateAcw=true)]
	public partial class ThrowableProxy : global::Java.Lang.Object, global::CH.Qos.Logback.Classic.Spi.IThrowableProxy {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("ch/qos/logback/classic/spi/ThrowableProxy", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ThrowableProxy); }
		}

		protected ThrowableProxy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_Throwable_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='ch.qos.logback.classic.spi']/class[@name='ThrowableProxy']/constructor[@name='ThrowableProxy' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register (".ctor", "(Ljava/lang/Throwable;)V", "")]
		public unsafe ThrowableProxy (global::Java.Lang.Throwable p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (ThrowableProxy)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/Throwable;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/Throwable;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_Throwable_ == IntPtr.Zero)
					id_ctor_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Throwable;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Throwable_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_Throwable_, __args);
			} finally {
			}
		}

		static Delegate cb_getCause;
#pragma warning disable 0169
		static Delegate GetGetCauseHandler ()
		{
			if (cb_getCause == null)
				cb_getCause = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCause);
			return cb_getCause;
		}

		static IntPtr n_GetCause (IntPtr jnienv, IntPtr native__this)
		{
			global::CH.Qos.Logback.Classic.Spi.ThrowableProxy __this = global::Java.Lang.Object.GetObject<global::CH.Qos.Logback.Classic.Spi.ThrowableProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Cause);
		}
#pragma warning restore 0169

		static IntPtr id_getCause;
		public virtual unsafe global::CH.Qos.Logback.Classic.Spi.IThrowableProxy Cause {
			// Metadata.xml XPath method reference: path="/api/package[@name='ch.qos.logback.classic.spi']/class[@name='ThrowableProxy']/method[@name='getCause' and count(parameter)=0]"
			[Register ("getCause", "()Lch/qos/logback/classic/spi/IThrowableProxy;", "GetGetCauseHandler")]
			get {
				if (id_getCause == IntPtr.Zero)
					id_getCause = JNIEnv.GetMethodID (class_ref, "getCause", "()Lch/qos/logback/classic/spi/IThrowableProxy;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::CH.Qos.Logback.Classic.Spi.IThrowableProxy> (JNIEnv.CallObjectMethod  (Handle, id_getCause), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::CH.Qos.Logback.Classic.Spi.IThrowableProxy> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCause", "()Lch/qos/logback/classic/spi/IThrowableProxy;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getClassName;
#pragma warning disable 0169
		static Delegate GetGetClassNameHandler ()
		{
			if (cb_getClassName == null)
				cb_getClassName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetClassName);
			return cb_getClassName;
		}

		static IntPtr n_GetClassName (IntPtr jnienv, IntPtr native__this)
		{
			global::CH.Qos.Logback.Classic.Spi.ThrowableProxy __this = global::Java.Lang.Object.GetObject<global::CH.Qos.Logback.Classic.Spi.ThrowableProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ClassName);
		}
#pragma warning restore 0169

		static IntPtr id_getClassName;
		public virtual unsafe string ClassName {
			// Metadata.xml XPath method reference: path="/api/package[@name='ch.qos.logback.classic.spi']/class[@name='ThrowableProxy']/method[@name='getClassName' and count(parameter)=0]"
			[Register ("getClassName", "()Ljava/lang/String;", "GetGetClassNameHandler")]
			get {
				if (id_getClassName == IntPtr.Zero)
					id_getClassName = JNIEnv.GetMethodID (class_ref, "getClassName", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getClassName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getClassName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCommonFrames;
#pragma warning disable 0169
		static Delegate GetGetCommonFramesHandler ()
		{
			if (cb_getCommonFrames == null)
				cb_getCommonFrames = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCommonFrames);
			return cb_getCommonFrames;
		}

		static int n_GetCommonFrames (IntPtr jnienv, IntPtr native__this)
		{
			global::CH.Qos.Logback.Classic.Spi.ThrowableProxy __this = global::Java.Lang.Object.GetObject<global::CH.Qos.Logback.Classic.Spi.ThrowableProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CommonFrames;
		}
#pragma warning restore 0169

		static IntPtr id_getCommonFrames;
		public virtual unsafe int CommonFrames {
			// Metadata.xml XPath method reference: path="/api/package[@name='ch.qos.logback.classic.spi']/class[@name='ThrowableProxy']/method[@name='getCommonFrames' and count(parameter)=0]"
			[Register ("getCommonFrames", "()I", "GetGetCommonFramesHandler")]
			get {
				if (id_getCommonFrames == IntPtr.Zero)
					id_getCommonFrames = JNIEnv.GetMethodID (class_ref, "getCommonFrames", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getCommonFrames);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCommonFrames", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getMessage;
#pragma warning disable 0169
		static Delegate GetGetMessageHandler ()
		{
			if (cb_getMessage == null)
				cb_getMessage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMessage);
			return cb_getMessage;
		}

		static IntPtr n_GetMessage (IntPtr jnienv, IntPtr native__this)
		{
			global::CH.Qos.Logback.Classic.Spi.ThrowableProxy __this = global::Java.Lang.Object.GetObject<global::CH.Qos.Logback.Classic.Spi.ThrowableProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Message);
		}
#pragma warning restore 0169

		static IntPtr id_getMessage;
		public virtual unsafe string Message {
			// Metadata.xml XPath method reference: path="/api/package[@name='ch.qos.logback.classic.spi']/class[@name='ThrowableProxy']/method[@name='getMessage' and count(parameter)=0]"
			[Register ("getMessage", "()Ljava/lang/String;", "GetGetMessageHandler")]
			get {
				if (id_getMessage == IntPtr.Zero)
					id_getMessage = JNIEnv.GetMethodID (class_ref, "getMessage", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getMessage), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessage", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPackagingDataCalculator;
#pragma warning disable 0169
		static Delegate GetGetPackagingDataCalculatorHandler ()
		{
			if (cb_getPackagingDataCalculator == null)
				cb_getPackagingDataCalculator = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPackagingDataCalculator);
			return cb_getPackagingDataCalculator;
		}

		static IntPtr n_GetPackagingDataCalculator (IntPtr jnienv, IntPtr native__this)
		{
			global::CH.Qos.Logback.Classic.Spi.ThrowableProxy __this = global::Java.Lang.Object.GetObject<global::CH.Qos.Logback.Classic.Spi.ThrowableProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PackagingDataCalculator);
		}
#pragma warning restore 0169

		static IntPtr id_getPackagingDataCalculator;
		public virtual unsafe global::CH.Qos.Logback.Classic.Spi.PackagingDataCalculator PackagingDataCalculator {
			// Metadata.xml XPath method reference: path="/api/package[@name='ch.qos.logback.classic.spi']/class[@name='ThrowableProxy']/method[@name='getPackagingDataCalculator' and count(parameter)=0]"
			[Register ("getPackagingDataCalculator", "()Lch/qos/logback/classic/spi/PackagingDataCalculator;", "GetGetPackagingDataCalculatorHandler")]
			get {
				if (id_getPackagingDataCalculator == IntPtr.Zero)
					id_getPackagingDataCalculator = JNIEnv.GetMethodID (class_ref, "getPackagingDataCalculator", "()Lch/qos/logback/classic/spi/PackagingDataCalculator;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::CH.Qos.Logback.Classic.Spi.PackagingDataCalculator> (JNIEnv.CallObjectMethod  (Handle, id_getPackagingDataCalculator), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::CH.Qos.Logback.Classic.Spi.PackagingDataCalculator> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPackagingDataCalculator", "()Lch/qos/logback/classic/spi/PackagingDataCalculator;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getThrowable;
#pragma warning disable 0169
		static Delegate GetGetThrowableHandler ()
		{
			if (cb_getThrowable == null)
				cb_getThrowable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetThrowable);
			return cb_getThrowable;
		}

		static IntPtr n_GetThrowable (IntPtr jnienv, IntPtr native__this)
		{
			global::CH.Qos.Logback.Classic.Spi.ThrowableProxy __this = global::Java.Lang.Object.GetObject<global::CH.Qos.Logback.Classic.Spi.ThrowableProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Throwable);
		}
#pragma warning restore 0169

		static IntPtr id_getThrowable;
		public virtual unsafe global::Java.Lang.Throwable Throwable {
			// Metadata.xml XPath method reference: path="/api/package[@name='ch.qos.logback.classic.spi']/class[@name='ThrowableProxy']/method[@name='getThrowable' and count(parameter)=0]"
			[Register ("getThrowable", "()Ljava/lang/Throwable;", "GetGetThrowableHandler")]
			get {
				if (id_getThrowable == IntPtr.Zero)
					id_getThrowable = JNIEnv.GetMethodID (class_ref, "getThrowable", "()Ljava/lang/Throwable;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (JNIEnv.CallObjectMethod  (Handle, id_getThrowable), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getThrowable", "()Ljava/lang/Throwable;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_calculatePackagingData;
#pragma warning disable 0169
		static Delegate GetCalculatePackagingDataHandler ()
		{
			if (cb_calculatePackagingData == null)
				cb_calculatePackagingData = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CalculatePackagingData);
			return cb_calculatePackagingData;
		}

		static void n_CalculatePackagingData (IntPtr jnienv, IntPtr native__this)
		{
			global::CH.Qos.Logback.Classic.Spi.ThrowableProxy __this = global::Java.Lang.Object.GetObject<global::CH.Qos.Logback.Classic.Spi.ThrowableProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CalculatePackagingData ();
		}
#pragma warning restore 0169

		static IntPtr id_calculatePackagingData;
		// Metadata.xml XPath method reference: path="/api/package[@name='ch.qos.logback.classic.spi']/class[@name='ThrowableProxy']/method[@name='calculatePackagingData' and count(parameter)=0]"
		[Register ("calculatePackagingData", "()V", "GetCalculatePackagingDataHandler")]
		public virtual unsafe void CalculatePackagingData ()
		{
			if (id_calculatePackagingData == IntPtr.Zero)
				id_calculatePackagingData = JNIEnv.GetMethodID (class_ref, "calculatePackagingData", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_calculatePackagingData);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "calculatePackagingData", "()V"));
			} finally {
			}
		}

		static Delegate cb_fullDump;
#pragma warning disable 0169
		static Delegate GetFullDumpHandler ()
		{
			if (cb_fullDump == null)
				cb_fullDump = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_FullDump);
			return cb_fullDump;
		}

		static void n_FullDump (IntPtr jnienv, IntPtr native__this)
		{
			global::CH.Qos.Logback.Classic.Spi.ThrowableProxy __this = global::Java.Lang.Object.GetObject<global::CH.Qos.Logback.Classic.Spi.ThrowableProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FullDump ();
		}
#pragma warning restore 0169

		static IntPtr id_fullDump;
		// Metadata.xml XPath method reference: path="/api/package[@name='ch.qos.logback.classic.spi']/class[@name='ThrowableProxy']/method[@name='fullDump' and count(parameter)=0]"
		[Register ("fullDump", "()V", "GetFullDumpHandler")]
		public virtual unsafe void FullDump ()
		{
			if (id_fullDump == IntPtr.Zero)
				id_fullDump = JNIEnv.GetMethodID (class_ref, "fullDump", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_fullDump);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "fullDump", "()V"));
			} finally {
			}
		}

		static Delegate cb_getStackTraceElementProxyArray;
#pragma warning disable 0169
		static Delegate GetGetStackTraceElementProxyArrayHandler ()
		{
			if (cb_getStackTraceElementProxyArray == null)
				cb_getStackTraceElementProxyArray = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStackTraceElementProxyArray);
			return cb_getStackTraceElementProxyArray;
		}

		static IntPtr n_GetStackTraceElementProxyArray (IntPtr jnienv, IntPtr native__this)
		{
			global::CH.Qos.Logback.Classic.Spi.ThrowableProxy __this = global::Java.Lang.Object.GetObject<global::CH.Qos.Logback.Classic.Spi.ThrowableProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetStackTraceElementProxyArray ());
		}
#pragma warning restore 0169

		static IntPtr id_getStackTraceElementProxyArray;
		// Metadata.xml XPath method reference: path="/api/package[@name='ch.qos.logback.classic.spi']/class[@name='ThrowableProxy']/method[@name='getStackTraceElementProxyArray' and count(parameter)=0]"
		[Register ("getStackTraceElementProxyArray", "()[Lch/qos/logback/classic/spi/StackTraceElementProxy;", "GetGetStackTraceElementProxyArrayHandler")]
		public virtual unsafe global::CH.Qos.Logback.Classic.Spi.StackTraceElementProxy[] GetStackTraceElementProxyArray ()
		{
			if (id_getStackTraceElementProxyArray == IntPtr.Zero)
				id_getStackTraceElementProxyArray = JNIEnv.GetMethodID (class_ref, "getStackTraceElementProxyArray", "()[Lch/qos/logback/classic/spi/StackTraceElementProxy;");
			try {

				if (GetType () == ThresholdType)
					return (global::CH.Qos.Logback.Classic.Spi.StackTraceElementProxy[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getStackTraceElementProxyArray), JniHandleOwnership.TransferLocalRef, typeof (global::CH.Qos.Logback.Classic.Spi.StackTraceElementProxy));
				else
					return (global::CH.Qos.Logback.Classic.Spi.StackTraceElementProxy[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStackTraceElementProxyArray", "()[Lch/qos/logback/classic/spi/StackTraceElementProxy;")), JniHandleOwnership.TransferLocalRef, typeof (global::CH.Qos.Logback.Classic.Spi.StackTraceElementProxy));
			} finally {
			}
		}

		static Delegate cb_getSuppressed;
#pragma warning disable 0169
		static Delegate GetGetSuppressedHandler ()
		{
			if (cb_getSuppressed == null)
				cb_getSuppressed = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSuppressed);
			return cb_getSuppressed;
		}

		static IntPtr n_GetSuppressed (IntPtr jnienv, IntPtr native__this)
		{
			global::CH.Qos.Logback.Classic.Spi.ThrowableProxy __this = global::Java.Lang.Object.GetObject<global::CH.Qos.Logback.Classic.Spi.ThrowableProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetSuppressed ());
		}
#pragma warning restore 0169

		static IntPtr id_getSuppressed;
		// Metadata.xml XPath method reference: path="/api/package[@name='ch.qos.logback.classic.spi']/class[@name='ThrowableProxy']/method[@name='getSuppressed' and count(parameter)=0]"
		[Register ("getSuppressed", "()[Lch/qos/logback/classic/spi/IThrowableProxy;", "GetGetSuppressedHandler")]
		public virtual unsafe global::CH.Qos.Logback.Classic.Spi.IThrowableProxy[] GetSuppressed ()
		{
			if (id_getSuppressed == IntPtr.Zero)
				id_getSuppressed = JNIEnv.GetMethodID (class_ref, "getSuppressed", "()[Lch/qos/logback/classic/spi/IThrowableProxy;");
			try {

				if (GetType () == ThresholdType)
					return (global::CH.Qos.Logback.Classic.Spi.IThrowableProxy[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getSuppressed), JniHandleOwnership.TransferLocalRef, typeof (global::CH.Qos.Logback.Classic.Spi.IThrowableProxy));
				else
					return (global::CH.Qos.Logback.Classic.Spi.IThrowableProxy[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSuppressed", "()[Lch/qos/logback/classic/spi/IThrowableProxy;")), JniHandleOwnership.TransferLocalRef, typeof (global::CH.Qos.Logback.Classic.Spi.IThrowableProxy));
			} finally {
			}
		}

	}
}
