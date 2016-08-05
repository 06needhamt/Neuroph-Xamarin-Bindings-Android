using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Contrib.Imgrec {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.contrib.imgrec']/class[@name='ColorMode']"
	[global::Android.Runtime.Register ("org/neuroph/contrib/imgrec/ColorMode", DoNotGenerateAcw=true)]
	public sealed partial class ColorMode : global::Java.Lang.Enum {


		static IntPtr BLACK_AND_WHITE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.neuroph.contrib.imgrec']/class[@name='ColorMode']/field[@name='BLACK_AND_WHITE']"
		[Register ("BLACK_AND_WHITE")]
		public static global::Org.Neuroph.Contrib.Imgrec.ColorMode BlackAndWhite {
			get {
				if (BLACK_AND_WHITE_jfieldId == IntPtr.Zero)
					BLACK_AND_WHITE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BLACK_AND_WHITE", "Lorg/neuroph/contrib/imgrec/ColorMode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BLACK_AND_WHITE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.Imgrec.ColorMode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr FULL_COLOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.neuroph.contrib.imgrec']/class[@name='ColorMode']/field[@name='FULL_COLOR']"
		[Register ("FULL_COLOR")]
		public static global::Org.Neuroph.Contrib.Imgrec.ColorMode FullColor {
			get {
				if (FULL_COLOR_jfieldId == IntPtr.Zero)
					FULL_COLOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FULL_COLOR", "Lorg/neuroph/contrib/imgrec/ColorMode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FULL_COLOR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.Imgrec.ColorMode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/contrib/imgrec/ColorMode", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ColorMode); }
		}

		internal ColorMode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.contrib.imgrec']/class[@name='ColorMode']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lorg/neuroph/contrib/imgrec/ColorMode;", "")]
		public static unsafe global::Org.Neuroph.Contrib.Imgrec.ColorMode ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lorg/neuroph/contrib/imgrec/ColorMode;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Org.Neuroph.Contrib.Imgrec.ColorMode __ret = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.Imgrec.ColorMode> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.contrib.imgrec']/class[@name='ColorMode']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lorg/neuroph/contrib/imgrec/ColorMode;", "")]
		public static unsafe global::Org.Neuroph.Contrib.Imgrec.ColorMode[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lorg/neuroph/contrib/imgrec/ColorMode;");
			try {
				return (global::Org.Neuroph.Contrib.Imgrec.ColorMode[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Neuroph.Contrib.Imgrec.ColorMode));
			} finally {
			}
		}

	}
}
