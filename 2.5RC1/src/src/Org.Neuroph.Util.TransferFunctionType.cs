using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.util']/class[@name='TransferFunctionType']"
	[global::Android.Runtime.Register ("org/neuroph/util/TransferFunctionType", DoNotGenerateAcw=true)]
	public sealed partial class TransferFunctionType : global::Java.Lang.Enum {


		static IntPtr GAUSSIAN_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.neuroph.util']/class[@name='TransferFunctionType']/field[@name='GAUSSIAN']"
		[Register ("GAUSSIAN")]
		public static global::Org.Neuroph.Util.TransferFunctionType Gaussian {
			get {
				if (GAUSSIAN_jfieldId == IntPtr.Zero)
					GAUSSIAN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GAUSSIAN", "Lorg/neuroph/util/TransferFunctionType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, GAUSSIAN_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.TransferFunctionType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr LINEAR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.neuroph.util']/class[@name='TransferFunctionType']/field[@name='LINEAR']"
		[Register ("LINEAR")]
		public static global::Org.Neuroph.Util.TransferFunctionType Linear {
			get {
				if (LINEAR_jfieldId == IntPtr.Zero)
					LINEAR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LINEAR", "Lorg/neuroph/util/TransferFunctionType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LINEAR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.TransferFunctionType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr RAMP_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.neuroph.util']/class[@name='TransferFunctionType']/field[@name='RAMP']"
		[Register ("RAMP")]
		public static global::Org.Neuroph.Util.TransferFunctionType Ramp {
			get {
				if (RAMP_jfieldId == IntPtr.Zero)
					RAMP_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RAMP", "Lorg/neuroph/util/TransferFunctionType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RAMP_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.TransferFunctionType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SGN_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.neuroph.util']/class[@name='TransferFunctionType']/field[@name='SGN']"
		[Register ("SGN")]
		public static global::Org.Neuroph.Util.TransferFunctionType Sgn {
			get {
				if (SGN_jfieldId == IntPtr.Zero)
					SGN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SGN", "Lorg/neuroph/util/TransferFunctionType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SGN_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.TransferFunctionType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SIGMOID_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.neuroph.util']/class[@name='TransferFunctionType']/field[@name='SIGMOID']"
		[Register ("SIGMOID")]
		public static global::Org.Neuroph.Util.TransferFunctionType Sigmoid {
			get {
				if (SIGMOID_jfieldId == IntPtr.Zero)
					SIGMOID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SIGMOID", "Lorg/neuroph/util/TransferFunctionType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SIGMOID_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.TransferFunctionType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr STEP_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.neuroph.util']/class[@name='TransferFunctionType']/field[@name='STEP']"
		[Register ("STEP")]
		public static global::Org.Neuroph.Util.TransferFunctionType Step {
			get {
				if (STEP_jfieldId == IntPtr.Zero)
					STEP_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "STEP", "Lorg/neuroph/util/TransferFunctionType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, STEP_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.TransferFunctionType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TANH_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.neuroph.util']/class[@name='TransferFunctionType']/field[@name='TANH']"
		[Register ("TANH")]
		public static global::Org.Neuroph.Util.TransferFunctionType Tanh {
			get {
				if (TANH_jfieldId == IntPtr.Zero)
					TANH_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TANH", "Lorg/neuroph/util/TransferFunctionType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TANH_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.TransferFunctionType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TRAPEZOID_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.neuroph.util']/class[@name='TransferFunctionType']/field[@name='TRAPEZOID']"
		[Register ("TRAPEZOID")]
		public static global::Org.Neuroph.Util.TransferFunctionType Trapezoid {
			get {
				if (TRAPEZOID_jfieldId == IntPtr.Zero)
					TRAPEZOID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TRAPEZOID", "Lorg/neuroph/util/TransferFunctionType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TRAPEZOID_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.TransferFunctionType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/util/TransferFunctionType", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TransferFunctionType); }
		}

		internal TransferFunctionType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getTypeClass;
		public unsafe global::Java.Lang.Class TypeClass {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util']/class[@name='TransferFunctionType']/method[@name='getTypeClass' and count(parameter)=0]"
			[Register ("getTypeClass", "()Ljava/lang/Class;", "GetGetTypeClassHandler")]
			get {
				if (id_getTypeClass == IntPtr.Zero)
					id_getTypeClass = JNIEnv.GetMethodID (class_ref, "getTypeClass", "()Ljava/lang/Class;");
				try {
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallObjectMethod  (Handle, id_getTypeClass), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getTypeLabel;
		public unsafe string TypeLabel {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util']/class[@name='TransferFunctionType']/method[@name='getTypeLabel' and count(parameter)=0]"
			[Register ("getTypeLabel", "()Ljava/lang/String;", "GetGetTypeLabelHandler")]
			get {
				if (id_getTypeLabel == IntPtr.Zero)
					id_getTypeLabel = JNIEnv.GetMethodID (class_ref, "getTypeLabel", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getTypeLabel), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util']/class[@name='TransferFunctionType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lorg/neuroph/util/TransferFunctionType;", "")]
		public static unsafe global::Org.Neuroph.Util.TransferFunctionType ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lorg/neuroph/util/TransferFunctionType;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Org.Neuroph.Util.TransferFunctionType __ret = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.TransferFunctionType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util']/class[@name='TransferFunctionType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lorg/neuroph/util/TransferFunctionType;", "")]
		public static unsafe global::Org.Neuroph.Util.TransferFunctionType[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lorg/neuroph/util/TransferFunctionType;");
			try {
				return (global::Org.Neuroph.Util.TransferFunctionType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Neuroph.Util.TransferFunctionType));
			} finally {
			}
		}

	}
}
