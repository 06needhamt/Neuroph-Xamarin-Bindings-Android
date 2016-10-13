using System;
using System.Collections.Generic;
using Android.Runtime;

namespace CH.Qos.Logback.Classic.Spi {

	// Metadata.xml XPath class reference: path="/api/package[@name='ch.qos.logback.classic.spi']/class[@name='ThrowableProxyVO']"
	[global::Android.Runtime.Register ("ch/qos/logback/classic/spi/ThrowableProxyVO", DoNotGenerateAcw=true)]
	public partial class ThrowableProxyVO : global::Java.Lang.Object, global::CH.Qos.Logback.Classic.Spi.IThrowableProxy, global::Java.IO.ISerializable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("ch/qos/logback/classic/spi/ThrowableProxyVO", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ThrowableProxyVO); }
		}

		protected ThrowableProxyVO (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='ch.qos.logback.classic.spi']/class[@name='ThrowableProxyVO']/constructor[@name='ThrowableProxyVO' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ThrowableProxyVO ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ThrowableProxyVO)) {
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
			global::CH.Qos.Logback.Classic.Spi.ThrowableProxyVO __this = global::Java.Lang.Object.GetObject<global::CH.Qos.Logback.Classic.Spi.ThrowableProxyVO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Cause);
		}
#pragma warning restore 0169

		static IntPtr id_getCause;
		public virtual unsafe global::CH.Qos.Logback.Classic.Spi.IThrowableProxy Cause {
			// Metadata.xml XPath method reference: path="/api/package[@name='ch.qos.logback.classic.spi']/class[@name='ThrowableProxyVO']/method[@name='getCause' and count(parameter)=0]"
			[Register ("getCause", "()Lch/qos/logback/classic/spi/IThrowableProxy;", "GetGetCauseHandler")]
			get {
				if (id_getCause == IntPtr.Zero)
					id_getCause = JNIEnv.GetMethodID (class_ref, "getCause", "()Lch/qos/logback/classic/spi/IThrowableProxy;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::CH.Qos.Logback.Classic.Spi.IThrowableProxy> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCause), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::CH.Qos.Logback.Classic.Spi.IThrowableProxy> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCause", "()Lch/qos/logback/classic/spi/IThrowableProxy;")), JniHandleOwnership.TransferLocalRef);
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
			global::CH.Qos.Logback.Classic.Spi.ThrowableProxyVO __this = global::Java.Lang.Object.GetObject<global::CH.Qos.Logback.Classic.Spi.ThrowableProxyVO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ClassName);
		}
#pragma warning restore 0169

		static IntPtr id_getClassName;
		public virtual unsafe string ClassName {
			// Metadata.xml XPath method reference: path="/api/package[@name='ch.qos.logback.classic.spi']/class[@name='ThrowableProxyVO']/method[@name='getClassName' and count(parameter)=0]"
			[Register ("getClassName", "()Ljava/lang/String;", "GetGetClassNameHandler")]
			get {
				if (id_getClassName == IntPtr.Zero)
					id_getClassName = JNIEnv.GetMethodID (class_ref, "getClassName", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getClassName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getClassName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
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
			global::CH.Qos.Logback.Classic.Spi.ThrowableProxyVO __this = global::Java.Lang.Object.GetObject<global::CH.Qos.Logback.Classic.Spi.ThrowableProxyVO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CommonFrames;
		}
#pragma warning restore 0169

		static IntPtr id_getCommonFrames;
		public virtual unsafe int CommonFrames {
			// Metadata.xml XPath method reference: path="/api/package[@name='ch.qos.logback.classic.spi']/class[@name='ThrowableProxyVO']/method[@name='getCommonFrames' and count(parameter)=0]"
			[Register ("getCommonFrames", "()I", "GetGetCommonFramesHandler")]
			get {
				if (id_getCommonFrames == IntPtr.Zero)
					id_getCommonFrames = JNIEnv.GetMethodID (class_ref, "getCommonFrames", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getCommonFrames);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCommonFrames", "()I"));
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
			global::CH.Qos.Logback.Classic.Spi.ThrowableProxyVO __this = global::Java.Lang.Object.GetObject<global::CH.Qos.Logback.Classic.Spi.ThrowableProxyVO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Message);
		}
#pragma warning restore 0169

		static IntPtr id_getMessage;
		public virtual unsafe string Message {
			// Metadata.xml XPath method reference: path="/api/package[@name='ch.qos.logback.classic.spi']/class[@name='ThrowableProxyVO']/method[@name='getMessage' and count(parameter)=0]"
			[Register ("getMessage", "()Ljava/lang/String;", "GetGetMessageHandler")]
			get {
				if (id_getMessage == IntPtr.Zero)
					id_getMessage = JNIEnv.GetMethodID (class_ref, "getMessage", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMessage), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessage", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_build_Lch_qos_logback_classic_spi_IThrowableProxy_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ch.qos.logback.classic.spi']/class[@name='ThrowableProxyVO']/method[@name='build' and count(parameter)=1 and parameter[1][@type='ch.qos.logback.classic.spi.IThrowableProxy']]"
		[Register ("build", "(Lch/qos/logback/classic/spi/IThrowableProxy;)Lch/qos/logback/classic/spi/ThrowableProxyVO;", "")]
		public static unsafe global::CH.Qos.Logback.Classic.Spi.ThrowableProxyVO Build (global::CH.Qos.Logback.Classic.Spi.IThrowableProxy p0)
		{
			if (id_build_Lch_qos_logback_classic_spi_IThrowableProxy_ == IntPtr.Zero)
				id_build_Lch_qos_logback_classic_spi_IThrowableProxy_ = JNIEnv.GetStaticMethodID (class_ref, "build", "(Lch/qos/logback/classic/spi/IThrowableProxy;)Lch/qos/logback/classic/spi/ThrowableProxyVO;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::CH.Qos.Logback.Classic.Spi.ThrowableProxyVO __ret = global::Java.Lang.Object.GetObject<global::CH.Qos.Logback.Classic.Spi.ThrowableProxyVO> (JNIEnv.CallStaticObjectMethod  (class_ref, id_build_Lch_qos_logback_classic_spi_IThrowableProxy_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
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
			global::CH.Qos.Logback.Classic.Spi.ThrowableProxyVO __this = global::Java.Lang.Object.GetObject<global::CH.Qos.Logback.Classic.Spi.ThrowableProxyVO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetStackTraceElementProxyArray ());
		}
#pragma warning restore 0169

		static IntPtr id_getStackTraceElementProxyArray;
		// Metadata.xml XPath method reference: path="/api/package[@name='ch.qos.logback.classic.spi']/class[@name='ThrowableProxyVO']/method[@name='getStackTraceElementProxyArray' and count(parameter)=0]"
		[Register ("getStackTraceElementProxyArray", "()[Lch/qos/logback/classic/spi/StackTraceElementProxy;", "GetGetStackTraceElementProxyArrayHandler")]
		public virtual unsafe global::CH.Qos.Logback.Classic.Spi.StackTraceElementProxy[] GetStackTraceElementProxyArray ()
		{
			if (id_getStackTraceElementProxyArray == IntPtr.Zero)
				id_getStackTraceElementProxyArray = JNIEnv.GetMethodID (class_ref, "getStackTraceElementProxyArray", "()[Lch/qos/logback/classic/spi/StackTraceElementProxy;");
			try {

				if (GetType () == ThresholdType)
					return (global::CH.Qos.Logback.Classic.Spi.StackTraceElementProxy[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getStackTraceElementProxyArray), JniHandleOwnership.TransferLocalRef, typeof (global::CH.Qos.Logback.Classic.Spi.StackTraceElementProxy));
				else
					return (global::CH.Qos.Logback.Classic.Spi.StackTraceElementProxy[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStackTraceElementProxyArray", "()[Lch/qos/logback/classic/spi/StackTraceElementProxy;")), JniHandleOwnership.TransferLocalRef, typeof (global::CH.Qos.Logback.Classic.Spi.StackTraceElementProxy));
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
			global::CH.Qos.Logback.Classic.Spi.ThrowableProxyVO __this = global::Java.Lang.Object.GetObject<global::CH.Qos.Logback.Classic.Spi.ThrowableProxyVO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetSuppressed ());
		}
#pragma warning restore 0169

		static IntPtr id_getSuppressed;
		// Metadata.xml XPath method reference: path="/api/package[@name='ch.qos.logback.classic.spi']/class[@name='ThrowableProxyVO']/method[@name='getSuppressed' and count(parameter)=0]"
		[Register ("getSuppressed", "()[Lch/qos/logback/classic/spi/IThrowableProxy;", "GetGetSuppressedHandler")]
		public virtual unsafe global::CH.Qos.Logback.Classic.Spi.IThrowableProxy[] GetSuppressed ()
		{
			if (id_getSuppressed == IntPtr.Zero)
				id_getSuppressed = JNIEnv.GetMethodID (class_ref, "getSuppressed", "()[Lch/qos/logback/classic/spi/IThrowableProxy;");
			try {

				if (GetType () == ThresholdType)
					return (global::CH.Qos.Logback.Classic.Spi.IThrowableProxy[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSuppressed), JniHandleOwnership.TransferLocalRef, typeof (global::CH.Qos.Logback.Classic.Spi.IThrowableProxy));
				else
					return (global::CH.Qos.Logback.Classic.Spi.IThrowableProxy[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSuppressed", "()[Lch/qos/logback/classic/spi/IThrowableProxy;")), JniHandleOwnership.TransferLocalRef, typeof (global::CH.Qos.Logback.Classic.Spi.IThrowableProxy));
			} finally {
			}
		}

	}
}
