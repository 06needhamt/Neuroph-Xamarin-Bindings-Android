using System;
using System.Collections.Generic;
using Android.Runtime;

namespace CH.Qos.Logback.Classic.Pattern {

	// Metadata.xml XPath interface reference: path="/api/package[@name='ch.qos.logback.classic.pattern']/interface[@name='Abbreviator']"
	[Register ("ch/qos/logback/classic/pattern/Abbreviator", "", "CH.Qos.Logback.Classic.Pattern.IAbbreviatorInvoker")]
	public partial interface IAbbreviator : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='ch.qos.logback.classic.pattern']/interface[@name='Abbreviator']/method[@name='abbreviate' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("abbreviate", "(Ljava/lang/String;)Ljava/lang/String;", "GetAbbreviate_Ljava_lang_String_Handler:CH.Qos.Logback.Classic.Pattern.IAbbreviatorInvoker, neuroph_2.9")]
		string Abbreviate (string p0);

	}

	[global::Android.Runtime.Register ("ch/qos/logback/classic/pattern/Abbreviator", DoNotGenerateAcw=true)]
	internal class IAbbreviatorInvoker : global::Java.Lang.Object, IAbbreviator {

		static IntPtr java_class_ref = JNIEnv.FindClass ("ch/qos/logback/classic/pattern/Abbreviator");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IAbbreviatorInvoker); }
		}

		IntPtr class_ref;

		public static IAbbreviator GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAbbreviator> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "ch.qos.logback.classic.pattern.Abbreviator"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAbbreviatorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::CH.Qos.Logback.Classic.Pattern.IAbbreviator __this = global::Java.Lang.Object.GetObject<global::CH.Qos.Logback.Classic.Pattern.IAbbreviator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Abbreviate (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_abbreviate_Ljava_lang_String_;
		public unsafe string Abbreviate (string p0)
		{
			if (id_abbreviate_Ljava_lang_String_ == IntPtr.Zero)
				id_abbreviate_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "abbreviate", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_abbreviate_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}

}
