using System;
using System.Collections.Generic;
using Android.Runtime;

namespace CH.Qos.Logback.Classic.Pattern {

	// Metadata.xml XPath class reference: path="/api/package[@name='ch.qos.logback.classic.pattern']/class[@name='ClassNameOnlyAbbreviator']"
	[global::Android.Runtime.Register ("ch/qos/logback/classic/pattern/ClassNameOnlyAbbreviator", DoNotGenerateAcw=true)]
	public partial class ClassNameOnlyAbbreviator : global::Java.Lang.Object, global::CH.Qos.Logback.Classic.Pattern.IAbbreviator {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("ch/qos/logback/classic/pattern/ClassNameOnlyAbbreviator", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ClassNameOnlyAbbreviator); }
		}

		protected ClassNameOnlyAbbreviator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='ch.qos.logback.classic.pattern']/class[@name='ClassNameOnlyAbbreviator']/constructor[@name='ClassNameOnlyAbbreviator' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ClassNameOnlyAbbreviator ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ClassNameOnlyAbbreviator)) {
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
			global::CH.Qos.Logback.Classic.Pattern.ClassNameOnlyAbbreviator __this = global::Java.Lang.Object.GetObject<global::CH.Qos.Logback.Classic.Pattern.ClassNameOnlyAbbreviator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Abbreviate (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_abbreviate_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ch.qos.logback.classic.pattern']/class[@name='ClassNameOnlyAbbreviator']/method[@name='abbreviate' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_abbreviate_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "abbreviate", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
