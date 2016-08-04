using System;
using System.Collections.Generic;
using Android.Runtime;

namespace CH.Qos.Logback.Classic.Turbo {

	// Metadata.xml XPath class reference: path="/api/package[@name='ch.qos.logback.classic.turbo']/class[@name='MDCValueLevelPair']"
	[global::Android.Runtime.Register ("ch/qos/logback/classic/turbo/MDCValueLevelPair", DoNotGenerateAcw=true)]
	public partial class MDCValueLevelPair : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("ch/qos/logback/classic/turbo/MDCValueLevelPair", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MDCValueLevelPair); }
		}

		protected MDCValueLevelPair (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='ch.qos.logback.classic.turbo']/class[@name='MDCValueLevelPair']/constructor[@name='MDCValueLevelPair' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MDCValueLevelPair ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (MDCValueLevelPair)) {
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

		static Delegate cb_getLevel;
#pragma warning disable 0169
		static Delegate GetGetLevelHandler ()
		{
			if (cb_getLevel == null)
				cb_getLevel = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLevel);
			return cb_getLevel;
		}

		static IntPtr n_GetLevel (IntPtr jnienv, IntPtr native__this)
		{
			global::CH.Qos.Logback.Classic.Turbo.MDCValueLevelPair __this = global::Java.Lang.Object.GetObject<global::CH.Qos.Logback.Classic.Turbo.MDCValueLevelPair> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Level);
		}
#pragma warning restore 0169

		static Delegate cb_setLevel_Lch_qos_logback_classic_Level_;
#pragma warning disable 0169
		static Delegate GetSetLevel_Lch_qos_logback_classic_Level_Handler ()
		{
			if (cb_setLevel_Lch_qos_logback_classic_Level_ == null)
				cb_setLevel_Lch_qos_logback_classic_Level_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLevel_Lch_qos_logback_classic_Level_);
			return cb_setLevel_Lch_qos_logback_classic_Level_;
		}

		static void n_SetLevel_Lch_qos_logback_classic_Level_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CH.Qos.Logback.Classic.Turbo.MDCValueLevelPair __this = global::Java.Lang.Object.GetObject<global::CH.Qos.Logback.Classic.Turbo.MDCValueLevelPair> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::CH.Qos.Logback.Classic.Level p0 = global::Java.Lang.Object.GetObject<global::CH.Qos.Logback.Classic.Level> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Level = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getLevel;
		static IntPtr id_setLevel_Lch_qos_logback_classic_Level_;
		public virtual unsafe global::CH.Qos.Logback.Classic.Level Level {
			// Metadata.xml XPath method reference: path="/api/package[@name='ch.qos.logback.classic.turbo']/class[@name='MDCValueLevelPair']/method[@name='getLevel' and count(parameter)=0]"
			[Register ("getLevel", "()Lch/qos/logback/classic/Level;", "GetGetLevelHandler")]
			get {
				if (id_getLevel == IntPtr.Zero)
					id_getLevel = JNIEnv.GetMethodID (class_ref, "getLevel", "()Lch/qos/logback/classic/Level;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::CH.Qos.Logback.Classic.Level> (JNIEnv.CallObjectMethod  (Handle, id_getLevel), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::CH.Qos.Logback.Classic.Level> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLevel", "()Lch/qos/logback/classic/Level;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='ch.qos.logback.classic.turbo']/class[@name='MDCValueLevelPair']/method[@name='setLevel' and count(parameter)=1 and parameter[1][@type='ch.qos.logback.classic.Level']]"
			[Register ("setLevel", "(Lch/qos/logback/classic/Level;)V", "GetSetLevel_Lch_qos_logback_classic_Level_Handler")]
			set {
				if (id_setLevel_Lch_qos_logback_classic_Level_ == IntPtr.Zero)
					id_setLevel_Lch_qos_logback_classic_Level_ = JNIEnv.GetMethodID (class_ref, "setLevel", "(Lch/qos/logback/classic/Level;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setLevel_Lch_qos_logback_classic_Level_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLevel", "(Lch/qos/logback/classic/Level;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getValue;
#pragma warning disable 0169
		static Delegate GetGetValueHandler ()
		{
			if (cb_getValue == null)
				cb_getValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetValue);
			return cb_getValue;
		}

		static IntPtr n_GetValue (IntPtr jnienv, IntPtr native__this)
		{
			global::CH.Qos.Logback.Classic.Turbo.MDCValueLevelPair __this = global::Java.Lang.Object.GetObject<global::CH.Qos.Logback.Classic.Turbo.MDCValueLevelPair> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Value);
		}
#pragma warning restore 0169

		static Delegate cb_setValue_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetValue_Ljava_lang_String_Handler ()
		{
			if (cb_setValue_Ljava_lang_String_ == null)
				cb_setValue_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetValue_Ljava_lang_String_);
			return cb_setValue_Ljava_lang_String_;
		}

		static void n_SetValue_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CH.Qos.Logback.Classic.Turbo.MDCValueLevelPair __this = global::Java.Lang.Object.GetObject<global::CH.Qos.Logback.Classic.Turbo.MDCValueLevelPair> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Value = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getValue;
		static IntPtr id_setValue_Ljava_lang_String_;
		public virtual unsafe string Value {
			// Metadata.xml XPath method reference: path="/api/package[@name='ch.qos.logback.classic.turbo']/class[@name='MDCValueLevelPair']/method[@name='getValue' and count(parameter)=0]"
			[Register ("getValue", "()Ljava/lang/String;", "GetGetValueHandler")]
			get {
				if (id_getValue == IntPtr.Zero)
					id_getValue = JNIEnv.GetMethodID (class_ref, "getValue", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getValue), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getValue", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='ch.qos.logback.classic.turbo']/class[@name='MDCValueLevelPair']/method[@name='setValue' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setValue", "(Ljava/lang/String;)V", "GetSetValue_Ljava_lang_String_Handler")]
			set {
				if (id_setValue_Ljava_lang_String_ == IntPtr.Zero)
					id_setValue_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setValue", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setValue_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setValue", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

	}
}
