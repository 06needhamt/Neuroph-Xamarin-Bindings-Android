using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.util']/class[@name='SummingFunctionType']"
	[global::Android.Runtime.Register ("org/neuroph/util/SummingFunctionType", DoNotGenerateAcw=true)]
	public sealed partial class SummingFunctionType : global::Java.Lang.Enum {


		static IntPtr AND_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.neuroph.util']/class[@name='SummingFunctionType']/field[@name='AND']"
		[Register ("AND")]
		public static global::Org.Neuroph.Util.SummingFunctionType And {
			get {
				if (AND_jfieldId == IntPtr.Zero)
					AND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AND", "Lorg/neuroph/util/SummingFunctionType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AND_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.SummingFunctionType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr INTENSITY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.neuroph.util']/class[@name='SummingFunctionType']/field[@name='INTENSITY']"
		[Register ("INTENSITY")]
		public static global::Org.Neuroph.Util.SummingFunctionType Intensity {
			get {
				if (INTENSITY_jfieldId == IntPtr.Zero)
					INTENSITY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INTENSITY", "Lorg/neuroph/util/SummingFunctionType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INTENSITY_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.SummingFunctionType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr MAX_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.neuroph.util']/class[@name='SummingFunctionType']/field[@name='MAX']"
		[Register ("MAX")]
		public static global::Org.Neuroph.Util.SummingFunctionType Max {
			get {
				if (MAX_jfieldId == IntPtr.Zero)
					MAX_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MAX", "Lorg/neuroph/util/SummingFunctionType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MAX_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.SummingFunctionType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr MIN_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.neuroph.util']/class[@name='SummingFunctionType']/field[@name='MIN']"
		[Register ("MIN")]
		public static global::Org.Neuroph.Util.SummingFunctionType Min {
			get {
				if (MIN_jfieldId == IntPtr.Zero)
					MIN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MIN", "Lorg/neuroph/util/SummingFunctionType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MIN_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.SummingFunctionType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr OR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.neuroph.util']/class[@name='SummingFunctionType']/field[@name='OR']"
		[Register ("OR")]
		public static global::Org.Neuroph.Util.SummingFunctionType Or {
			get {
				if (OR_jfieldId == IntPtr.Zero)
					OR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OR", "Lorg/neuroph/util/SummingFunctionType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, OR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.SummingFunctionType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr PRODUCT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.neuroph.util']/class[@name='SummingFunctionType']/field[@name='PRODUCT']"
		[Register ("PRODUCT")]
		public static global::Org.Neuroph.Util.SummingFunctionType Product {
			get {
				if (PRODUCT_jfieldId == IntPtr.Zero)
					PRODUCT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PRODUCT", "Lorg/neuroph/util/SummingFunctionType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PRODUCT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.SummingFunctionType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SUM_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.neuroph.util']/class[@name='SummingFunctionType']/field[@name='SUM']"
		[Register ("SUM")]
		public static global::Org.Neuroph.Util.SummingFunctionType Sum {
			get {
				if (SUM_jfieldId == IntPtr.Zero)
					SUM_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SUM", "Lorg/neuroph/util/SummingFunctionType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SUM_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.SummingFunctionType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SUMSQR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.neuroph.util']/class[@name='SummingFunctionType']/field[@name='SUMSQR']"
		[Register ("SUMSQR")]
		public static global::Org.Neuroph.Util.SummingFunctionType Sumsqr {
			get {
				if (SUMSQR_jfieldId == IntPtr.Zero)
					SUMSQR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SUMSQR", "Lorg/neuroph/util/SummingFunctionType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SUMSQR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.SummingFunctionType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/util/SummingFunctionType", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SummingFunctionType); }
		}

		internal SummingFunctionType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getTypeClass;
		public unsafe global::Java.Lang.Class TypeClass {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util']/class[@name='SummingFunctionType']/method[@name='getTypeClass' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util']/class[@name='SummingFunctionType']/method[@name='getTypeLabel' and count(parameter)=0]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util']/class[@name='SummingFunctionType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lorg/neuroph/util/SummingFunctionType;", "")]
		public static unsafe global::Org.Neuroph.Util.SummingFunctionType ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lorg/neuroph/util/SummingFunctionType;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Org.Neuroph.Util.SummingFunctionType __ret = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.SummingFunctionType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util']/class[@name='SummingFunctionType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lorg/neuroph/util/SummingFunctionType;", "")]
		public static unsafe global::Org.Neuroph.Util.SummingFunctionType[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lorg/neuroph/util/SummingFunctionType;");
			try {
				return (global::Org.Neuroph.Util.SummingFunctionType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Neuroph.Util.SummingFunctionType));
			} finally {
			}
		}

	}
}
