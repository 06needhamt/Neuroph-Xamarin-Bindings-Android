using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.util']/class[@name='WeightsFunctionType']"
	[global::Android.Runtime.Register ("org/neuroph/util/WeightsFunctionType", DoNotGenerateAcw=true)]
	public sealed partial class WeightsFunctionType : global::Java.Lang.Enum {


		static IntPtr DIFFERENCE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.neuroph.util']/class[@name='WeightsFunctionType']/field[@name='DIFFERENCE']"
		[Register ("DIFFERENCE")]
		public static global::Org.Neuroph.Util.WeightsFunctionType Difference {
			get {
				if (DIFFERENCE_jfieldId == IntPtr.Zero)
					DIFFERENCE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DIFFERENCE", "Lorg/neuroph/util/WeightsFunctionType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DIFFERENCE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.WeightsFunctionType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr WEIGHTED_INPUT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.neuroph.util']/class[@name='WeightsFunctionType']/field[@name='WEIGHTED_INPUT']"
		[Register ("WEIGHTED_INPUT")]
		public static global::Org.Neuroph.Util.WeightsFunctionType WeightedInput {
			get {
				if (WEIGHTED_INPUT_jfieldId == IntPtr.Zero)
					WEIGHTED_INPUT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "WEIGHTED_INPUT", "Lorg/neuroph/util/WeightsFunctionType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, WEIGHTED_INPUT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.WeightsFunctionType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/util/WeightsFunctionType", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (WeightsFunctionType); }
		}

		internal WeightsFunctionType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getTypeClass;
		public unsafe global::Java.Lang.Class TypeClass {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util']/class[@name='WeightsFunctionType']/method[@name='getTypeClass' and count(parameter)=0]"
			[Register ("getTypeClass", "()Ljava/lang/Class;", "GetGetTypeClassHandler")]
			get {
				if (id_getTypeClass == IntPtr.Zero)
					id_getTypeClass = JNIEnv.GetMethodID (class_ref, "getTypeClass", "()Ljava/lang/Class;");
				try {
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTypeClass), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getTypeLabel;
		public unsafe string TypeLabel {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util']/class[@name='WeightsFunctionType']/method[@name='getTypeLabel' and count(parameter)=0]"
			[Register ("getTypeLabel", "()Ljava/lang/String;", "GetGetTypeLabelHandler")]
			get {
				if (id_getTypeLabel == IntPtr.Zero)
					id_getTypeLabel = JNIEnv.GetMethodID (class_ref, "getTypeLabel", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTypeLabel), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util']/class[@name='WeightsFunctionType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lorg/neuroph/util/WeightsFunctionType;", "")]
		public static unsafe global::Org.Neuroph.Util.WeightsFunctionType ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lorg/neuroph/util/WeightsFunctionType;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Org.Neuroph.Util.WeightsFunctionType __ret = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.WeightsFunctionType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util']/class[@name='WeightsFunctionType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lorg/neuroph/util/WeightsFunctionType;", "")]
		public static unsafe global::Org.Neuroph.Util.WeightsFunctionType[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lorg/neuroph/util/WeightsFunctionType;");
			try {
				return (global::Org.Neuroph.Util.WeightsFunctionType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Neuroph.Util.WeightsFunctionType));
			} finally {
			}
		}

	}
}
