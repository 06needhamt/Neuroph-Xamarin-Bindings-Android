using System;
using System.Collections.Generic;
using Android.Runtime;

namespace CH.Qos.Logback.Classic.Pattern {

	// Metadata.xml XPath class reference: path="/api/package[@name='ch.qos.logback.classic.pattern']/class[@name='TargetLengthBasedClassNameAbbreviator']"
	[global::Android.Runtime.Register ("ch/qos/logback/classic/pattern/TargetLengthBasedClassNameAbbreviator", DoNotGenerateAcw=true)]
	public partial class TargetLengthBasedClassNameAbbreviator : global::Java.Lang.Object, global::CH.Qos.Logback.Classic.Pattern.IAbbreviator {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("ch/qos/logback/classic/pattern/TargetLengthBasedClassNameAbbreviator", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TargetLengthBasedClassNameAbbreviator); }
		}

		protected TargetLengthBasedClassNameAbbreviator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='ch.qos.logback.classic.pattern']/class[@name='TargetLengthBasedClassNameAbbreviator']/constructor[@name='TargetLengthBasedClassNameAbbreviator' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe TargetLengthBasedClassNameAbbreviator (int p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (TargetLengthBasedClassNameAbbreviator)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(I)V", __args);
					return;
				}

				if (id_ctor_I == IntPtr.Zero)
					id_ctor_I = JNIEnv.GetMethodID (class_ref, "<init>", "(I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_I, __args);
			} finally {
			}
		}

		static Delegate cb_abbreviate_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAbbreviate_Ljava_lang_String_Handler ()
		{
			if (cb_abbreviate_Ljava_lang_String_ == null)
				cb_abbreviate_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Abbreviate_Ljava_lang_String_);
			return cb_abbreviate_Ljava_lang_String_;
		}

		static IntPtr n_Abbreviate_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CH.Qos.Logback.Classic.Pattern.TargetLengthBasedClassNameAbbreviator __this = global::Java.Lang.Object.GetObject<global::CH.Qos.Logback.Classic.Pattern.TargetLengthBasedClassNameAbbreviator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Abbreviate (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_abbreviate_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ch.qos.logback.classic.pattern']/class[@name='TargetLengthBasedClassNameAbbreviator']/method[@name='abbreviate' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("abbreviate", "(Ljava/lang/String;)Ljava/lang/String;", "GetAbbreviate_Ljava_lang_String_Handler")]
		public virtual unsafe string Abbreviate (string p0)
		{
			if (id_abbreviate_Ljava_lang_String_ == IntPtr.Zero)
				id_abbreviate_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "abbreviate", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				string __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_abbreviate_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "abbreviate", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
