using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Encog.Engine.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.encog.engine.util']/class[@name='ErrorCalculationMode']"
	[global::Android.Runtime.Register ("org/encog/engine/util/ErrorCalculationMode", DoNotGenerateAcw=true)]
	public sealed partial class ErrorCalculationMode : global::Java.Lang.Enum {


		static IntPtr ARCTAN_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.encog.engine.util']/class[@name='ErrorCalculationMode']/field[@name='ARCTAN']"
		[Register ("ARCTAN")]
		public static global::Org.Encog.Engine.Util.ErrorCalculationMode Arctan {
			get {
				if (ARCTAN_jfieldId == IntPtr.Zero)
					ARCTAN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ARCTAN", "Lorg/encog/engine/util/ErrorCalculationMode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ARCTAN_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Util.ErrorCalculationMode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr MSE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.encog.engine.util']/class[@name='ErrorCalculationMode']/field[@name='MSE']"
		[Register ("MSE")]
		public static global::Org.Encog.Engine.Util.ErrorCalculationMode Mse {
			get {
				if (MSE_jfieldId == IntPtr.Zero)
					MSE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MSE", "Lorg/encog/engine/util/ErrorCalculationMode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MSE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Util.ErrorCalculationMode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr RMS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.encog.engine.util']/class[@name='ErrorCalculationMode']/field[@name='RMS']"
		[Register ("RMS")]
		public static global::Org.Encog.Engine.Util.ErrorCalculationMode Rms {
			get {
				if (RMS_jfieldId == IntPtr.Zero)
					RMS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RMS", "Lorg/encog/engine/util/ErrorCalculationMode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RMS_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Util.ErrorCalculationMode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/encog/engine/util/ErrorCalculationMode", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ErrorCalculationMode); }
		}

		internal ErrorCalculationMode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.util']/class[@name='ErrorCalculationMode']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lorg/encog/engine/util/ErrorCalculationMode;", "")]
		public static unsafe global::Org.Encog.Engine.Util.ErrorCalculationMode ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lorg/encog/engine/util/ErrorCalculationMode;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Org.Encog.Engine.Util.ErrorCalculationMode __ret = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Util.ErrorCalculationMode> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.util']/class[@name='ErrorCalculationMode']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lorg/encog/engine/util/ErrorCalculationMode;", "")]
		public static unsafe global::Org.Encog.Engine.Util.ErrorCalculationMode[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lorg/encog/engine/util/ErrorCalculationMode;");
			try {
				return (global::Org.Encog.Engine.Util.ErrorCalculationMode[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Encog.Engine.Util.ErrorCalculationMode));
			} finally {
			}
		}

	}
}
