using System;
using System.Collections.Generic;
using Android.Runtime;

namespace CH.Qos.Logback.Classic.Spi {

	// Metadata.xml XPath interface reference: path="/api/package[@name='ch.qos.logback.classic.spi']/interface[@name='IThrowableProxy']"
	[Register ("ch/qos/logback/classic/spi/IThrowableProxy", "", "CH.Qos.Logback.Classic.Spi.IThrowableProxyInvoker")]
	public partial interface IThrowableProxy : IJavaObject {

		global::CH.Qos.Logback.Classic.Spi.IThrowableProxy Cause {
			// Metadata.xml XPath method reference: path="/api/package[@name='ch.qos.logback.classic.spi']/interface[@name='IThrowableProxy']/method[@name='getCause' and count(parameter)=0]"
			[Register ("getCause", "()Lch/qos/logback/classic/spi/IThrowableProxy;", "GetGetCauseHandler:CH.Qos.Logback.Classic.Spi.IThrowableProxyInvoker, neuroph_2.9")] get;
		}

		string ClassName {
			// Metadata.xml XPath method reference: path="/api/package[@name='ch.qos.logback.classic.spi']/interface[@name='IThrowableProxy']/method[@name='getClassName' and count(parameter)=0]"
			[Register ("getClassName", "()Ljava/lang/String;", "GetGetClassNameHandler:CH.Qos.Logback.Classic.Spi.IThrowableProxyInvoker, neuroph_2.9")] get;
		}

		int CommonFrames {
			// Metadata.xml XPath method reference: path="/api/package[@name='ch.qos.logback.classic.spi']/interface[@name='IThrowableProxy']/method[@name='getCommonFrames' and count(parameter)=0]"
			[Register ("getCommonFrames", "()I", "GetGetCommonFramesHandler:CH.Qos.Logback.Classic.Spi.IThrowableProxyInvoker, neuroph_2.9")] get;
		}

		string Message {
			// Metadata.xml XPath method reference: path="/api/package[@name='ch.qos.logback.classic.spi']/interface[@name='IThrowableProxy']/method[@name='getMessage' and count(parameter)=0]"
			[Register ("getMessage", "()Ljava/lang/String;", "GetGetMessageHandler:CH.Qos.Logback.Classic.Spi.IThrowableProxyInvoker, neuroph_2.9")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='ch.qos.logback.classic.spi']/interface[@name='IThrowableProxy']/method[@name='getStackTraceElementProxyArray' and count(parameter)=0]"
		[Register ("getStackTraceElementProxyArray", "()[Lch/qos/logback/classic/spi/StackTraceElementProxy;", "GetGetStackTraceElementProxyArrayHandler:CH.Qos.Logback.Classic.Spi.IThrowableProxyInvoker, neuroph_2.9")]
		global::CH.Qos.Logback.Classic.Spi.StackTraceElementProxy[] GetStackTraceElementProxyArray ();

		// Metadata.xml XPath method reference: path="/api/package[@name='ch.qos.logback.classic.spi']/interface[@name='IThrowableProxy']/method[@name='getSuppressed' and count(parameter)=0]"
		[Register ("getSuppressed", "()[Lch/qos/logback/classic/spi/IThrowableProxy;", "GetGetSuppressedHandler:CH.Qos.Logback.Classic.Spi.IThrowableProxyInvoker, neuroph_2.9")]
		global::CH.Qos.Logback.Classic.Spi.IThrowableProxy[] GetSuppressed ();

	}

	[global::Android.Runtime.Register ("ch/qos/logback/classic/spi/IThrowableProxy", DoNotGenerateAcw=true)]
	internal class IThrowableProxyInvoker : global::Java.Lang.Object, IThrowableProxy {

		static IntPtr java_class_ref = JNIEnv.FindClass ("ch/qos/logback/classic/spi/IThrowableProxy");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IThrowableProxyInvoker); }
		}

		IntPtr class_ref;

		public static IThrowableProxy GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IThrowableProxy> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "ch.qos.logback.classic.spi.IThrowableProxy"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IThrowableProxyInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::CH.Qos.Logback.Classic.Spi.IThrowableProxy __this = global::Java.Lang.Object.GetObject<global::CH.Qos.Logback.Classic.Spi.IThrowableProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Cause);
		}
#pragma warning restore 0169

		IntPtr id_getCause;
		public unsafe global::CH.Qos.Logback.Classic.Spi.IThrowableProxy Cause {
			get {
				if (id_getCause == IntPtr.Zero)
					id_getCause = JNIEnv.GetMethodID (class_ref, "getCause", "()Lch/qos/logback/classic/spi/IThrowableProxy;");
				return global::Java.Lang.Object.GetObject<global::CH.Qos.Logback.Classic.Spi.IThrowableProxy> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCause), JniHandleOwnership.TransferLocalRef);
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
			global::CH.Qos.Logback.Classic.Spi.IThrowableProxy __this = global::Java.Lang.Object.GetObject<global::CH.Qos.Logback.Classic.Spi.IThrowableProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ClassName);
		}
#pragma warning restore 0169

		IntPtr id_getClassName;
		public unsafe string ClassName {
			get {
				if (id_getClassName == IntPtr.Zero)
					id_getClassName = JNIEnv.GetMethodID (class_ref, "getClassName", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getClassName), JniHandleOwnership.TransferLocalRef);
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
			global::CH.Qos.Logback.Classic.Spi.IThrowableProxy __this = global::Java.Lang.Object.GetObject<global::CH.Qos.Logback.Classic.Spi.IThrowableProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CommonFrames;
		}
#pragma warning restore 0169

		IntPtr id_getCommonFrames;
		public unsafe int CommonFrames {
			get {
				if (id_getCommonFrames == IntPtr.Zero)
					id_getCommonFrames = JNIEnv.GetMethodID (class_ref, "getCommonFrames", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getCommonFrames);
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
			global::CH.Qos.Logback.Classic.Spi.IThrowableProxy __this = global::Java.Lang.Object.GetObject<global::CH.Qos.Logback.Classic.Spi.IThrowableProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Message);
		}
#pragma warning restore 0169

		IntPtr id_getMessage;
		public unsafe string Message {
			get {
				if (id_getMessage == IntPtr.Zero)
					id_getMessage = JNIEnv.GetMethodID (class_ref, "getMessage", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMessage), JniHandleOwnership.TransferLocalRef);
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
			global::CH.Qos.Logback.Classic.Spi.IThrowableProxy __this = global::Java.Lang.Object.GetObject<global::CH.Qos.Logback.Classic.Spi.IThrowableProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetStackTraceElementProxyArray ());
		}
#pragma warning restore 0169

		IntPtr id_getStackTraceElementProxyArray;
		public unsafe global::CH.Qos.Logback.Classic.Spi.StackTraceElementProxy[] GetStackTraceElementProxyArray ()
		{
			if (id_getStackTraceElementProxyArray == IntPtr.Zero)
				id_getStackTraceElementProxyArray = JNIEnv.GetMethodID (class_ref, "getStackTraceElementProxyArray", "()[Lch/qos/logback/classic/spi/StackTraceElementProxy;");
			return (global::CH.Qos.Logback.Classic.Spi.StackTraceElementProxy[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getStackTraceElementProxyArray), JniHandleOwnership.TransferLocalRef, typeof (global::CH.Qos.Logback.Classic.Spi.StackTraceElementProxy));
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
			global::CH.Qos.Logback.Classic.Spi.IThrowableProxy __this = global::Java.Lang.Object.GetObject<global::CH.Qos.Logback.Classic.Spi.IThrowableProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetSuppressed ());
		}
#pragma warning restore 0169

		IntPtr id_getSuppressed;
		public unsafe global::CH.Qos.Logback.Classic.Spi.IThrowableProxy[] GetSuppressed ()
		{
			if (id_getSuppressed == IntPtr.Zero)
				id_getSuppressed = JNIEnv.GetMethodID (class_ref, "getSuppressed", "()[Lch/qos/logback/classic/spi/IThrowableProxy;");
			return (global::CH.Qos.Logback.Classic.Spi.IThrowableProxy[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSuppressed), JniHandleOwnership.TransferLocalRef, typeof (global::CH.Qos.Logback.Classic.Spi.IThrowableProxy));
		}

	}

}
