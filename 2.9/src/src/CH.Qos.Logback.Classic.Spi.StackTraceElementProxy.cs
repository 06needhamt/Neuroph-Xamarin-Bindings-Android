using System;
using System.Collections.Generic;
using Android.Runtime;

namespace CH.Qos.Logback.Classic.Spi {

	// Metadata.xml XPath class reference: path="/api/package[@name='ch.qos.logback.classic.spi']/class[@name='StackTraceElementProxy']"
	[global::Android.Runtime.Register ("ch/qos/logback/classic/spi/StackTraceElementProxy", DoNotGenerateAcw=true)]
	public partial class StackTraceElementProxy : global::Java.Lang.Object, global::Java.IO.ISerializable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("ch/qos/logback/classic/spi/StackTraceElementProxy", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (StackTraceElementProxy); }
		}

		protected StackTraceElementProxy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_StackTraceElement_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='ch.qos.logback.classic.spi']/class[@name='StackTraceElementProxy']/constructor[@name='StackTraceElementProxy' and count(parameter)=1 and parameter[1][@type='java.lang.StackTraceElement']]"
		[Register (".ctor", "(Ljava/lang/StackTraceElement;)V", "")]
		public unsafe StackTraceElementProxy (global::Java.Lang.StackTraceElement p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (StackTraceElementProxy)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/StackTraceElement;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/StackTraceElement;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_StackTraceElement_ == IntPtr.Zero)
					id_ctor_Ljava_lang_StackTraceElement_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/StackTraceElement;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_StackTraceElement_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_StackTraceElement_, __args);
			} finally {
			}
		}

		static Delegate cb_getClassPackagingData;
#pragma warning disable 0169
		static Delegate GetGetClassPackagingDataHandler ()
		{
			if (cb_getClassPackagingData == null)
				cb_getClassPackagingData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetClassPackagingData);
			return cb_getClassPackagingData;
		}

		static IntPtr n_GetClassPackagingData (IntPtr jnienv, IntPtr native__this)
		{
			global::CH.Qos.Logback.Classic.Spi.StackTraceElementProxy __this = global::Java.Lang.Object.GetObject<global::CH.Qos.Logback.Classic.Spi.StackTraceElementProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ClassPackagingData);
		}
#pragma warning restore 0169

		static Delegate cb_setClassPackagingData_Lch_qos_logback_classic_spi_ClassPackagingData_;
#pragma warning disable 0169
		static Delegate GetSetClassPackagingData_Lch_qos_logback_classic_spi_ClassPackagingData_Handler ()
		{
			if (cb_setClassPackagingData_Lch_qos_logback_classic_spi_ClassPackagingData_ == null)
				cb_setClassPackagingData_Lch_qos_logback_classic_spi_ClassPackagingData_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetClassPackagingData_Lch_qos_logback_classic_spi_ClassPackagingData_);
			return cb_setClassPackagingData_Lch_qos_logback_classic_spi_ClassPackagingData_;
		}

		static void n_SetClassPackagingData_Lch_qos_logback_classic_spi_ClassPackagingData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CH.Qos.Logback.Classic.Spi.StackTraceElementProxy __this = global::Java.Lang.Object.GetObject<global::CH.Qos.Logback.Classic.Spi.StackTraceElementProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::CH.Qos.Logback.Classic.Spi.ClassPackagingData p0 = global::Java.Lang.Object.GetObject<global::CH.Qos.Logback.Classic.Spi.ClassPackagingData> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ClassPackagingData = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getClassPackagingData;
		static IntPtr id_setClassPackagingData_Lch_qos_logback_classic_spi_ClassPackagingData_;
		public virtual unsafe global::CH.Qos.Logback.Classic.Spi.ClassPackagingData ClassPackagingData {
			// Metadata.xml XPath method reference: path="/api/package[@name='ch.qos.logback.classic.spi']/class[@name='StackTraceElementProxy']/method[@name='getClassPackagingData' and count(parameter)=0]"
			[Register ("getClassPackagingData", "()Lch/qos/logback/classic/spi/ClassPackagingData;", "GetGetClassPackagingDataHandler")]
			get {
				if (id_getClassPackagingData == IntPtr.Zero)
					id_getClassPackagingData = JNIEnv.GetMethodID (class_ref, "getClassPackagingData", "()Lch/qos/logback/classic/spi/ClassPackagingData;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::CH.Qos.Logback.Classic.Spi.ClassPackagingData> (JNIEnv.CallObjectMethod  (Handle, id_getClassPackagingData), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::CH.Qos.Logback.Classic.Spi.ClassPackagingData> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getClassPackagingData", "()Lch/qos/logback/classic/spi/ClassPackagingData;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='ch.qos.logback.classic.spi']/class[@name='StackTraceElementProxy']/method[@name='setClassPackagingData' and count(parameter)=1 and parameter[1][@type='ch.qos.logback.classic.spi.ClassPackagingData']]"
			[Register ("setClassPackagingData", "(Lch/qos/logback/classic/spi/ClassPackagingData;)V", "GetSetClassPackagingData_Lch_qos_logback_classic_spi_ClassPackagingData_Handler")]
			set {
				if (id_setClassPackagingData_Lch_qos_logback_classic_spi_ClassPackagingData_ == IntPtr.Zero)
					id_setClassPackagingData_Lch_qos_logback_classic_spi_ClassPackagingData_ = JNIEnv.GetMethodID (class_ref, "setClassPackagingData", "(Lch/qos/logback/classic/spi/ClassPackagingData;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setClassPackagingData_Lch_qos_logback_classic_spi_ClassPackagingData_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setClassPackagingData", "(Lch/qos/logback/classic/spi/ClassPackagingData;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSTEAsString;
#pragma warning disable 0169
		static Delegate GetGetSTEAsStringHandler ()
		{
			if (cb_getSTEAsString == null)
				cb_getSTEAsString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSTEAsString);
			return cb_getSTEAsString;
		}

		static IntPtr n_GetSTEAsString (IntPtr jnienv, IntPtr native__this)
		{
			global::CH.Qos.Logback.Classic.Spi.StackTraceElementProxy __this = global::Java.Lang.Object.GetObject<global::CH.Qos.Logback.Classic.Spi.StackTraceElementProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.STEAsString);
		}
#pragma warning restore 0169

		static IntPtr id_getSTEAsString;
		public virtual unsafe string STEAsString {
			// Metadata.xml XPath method reference: path="/api/package[@name='ch.qos.logback.classic.spi']/class[@name='StackTraceElementProxy']/method[@name='getSTEAsString' and count(parameter)=0]"
			[Register ("getSTEAsString", "()Ljava/lang/String;", "GetGetSTEAsStringHandler")]
			get {
				if (id_getSTEAsString == IntPtr.Zero)
					id_getSTEAsString = JNIEnv.GetMethodID (class_ref, "getSTEAsString", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getSTEAsString), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSTEAsString", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getStackTraceElement;
#pragma warning disable 0169
		static Delegate GetGetStackTraceElementHandler ()
		{
			if (cb_getStackTraceElement == null)
				cb_getStackTraceElement = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStackTraceElement);
			return cb_getStackTraceElement;
		}

		static IntPtr n_GetStackTraceElement (IntPtr jnienv, IntPtr native__this)
		{
			global::CH.Qos.Logback.Classic.Spi.StackTraceElementProxy __this = global::Java.Lang.Object.GetObject<global::CH.Qos.Logback.Classic.Spi.StackTraceElementProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.StackTraceElement);
		}
#pragma warning restore 0169

		static IntPtr id_getStackTraceElement;
		public virtual unsafe global::Java.Lang.StackTraceElement StackTraceElement {
			// Metadata.xml XPath method reference: path="/api/package[@name='ch.qos.logback.classic.spi']/class[@name='StackTraceElementProxy']/method[@name='getStackTraceElement' and count(parameter)=0]"
			[Register ("getStackTraceElement", "()Ljava/lang/StackTraceElement;", "GetGetStackTraceElementHandler")]
			get {
				if (id_getStackTraceElement == IntPtr.Zero)
					id_getStackTraceElement = JNIEnv.GetMethodID (class_ref, "getStackTraceElement", "()Ljava/lang/StackTraceElement;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.StackTraceElement> (JNIEnv.CallObjectMethod  (Handle, id_getStackTraceElement), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.StackTraceElement> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStackTraceElement", "()Ljava/lang/StackTraceElement;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
