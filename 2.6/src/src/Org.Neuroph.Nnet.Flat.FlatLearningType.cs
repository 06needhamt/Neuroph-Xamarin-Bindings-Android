using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Nnet.Flat {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.nnet.flat']/class[@name='FlatLearningType']"
	[global::Android.Runtime.Register ("org/neuroph/nnet/flat/FlatLearningType", DoNotGenerateAcw=true)]
	public sealed partial class FlatLearningType : global::Java.Lang.Enum {


		static IntPtr BackPropagation_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.neuroph.nnet.flat']/class[@name='FlatLearningType']/field[@name='BackPropagation']"
		[Register ("BackPropagation")]
		public static global::Org.Neuroph.Nnet.Flat.FlatLearningType BackPropagation {
			get {
				if (BackPropagation_jfieldId == IntPtr.Zero)
					BackPropagation_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BackPropagation", "Lorg/neuroph/nnet/flat/FlatLearningType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BackPropagation_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Flat.FlatLearningType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ManhattanUpdateRule_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.neuroph.nnet.flat']/class[@name='FlatLearningType']/field[@name='ManhattanUpdateRule']"
		[Register ("ManhattanUpdateRule")]
		public static global::Org.Neuroph.Nnet.Flat.FlatLearningType ManhattanUpdateRule {
			get {
				if (ManhattanUpdateRule_jfieldId == IntPtr.Zero)
					ManhattanUpdateRule_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ManhattanUpdateRule", "Lorg/neuroph/nnet/flat/FlatLearningType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ManhattanUpdateRule_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Flat.FlatLearningType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ResilientPropagation_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.neuroph.nnet.flat']/class[@name='FlatLearningType']/field[@name='ResilientPropagation']"
		[Register ("ResilientPropagation")]
		public static global::Org.Neuroph.Nnet.Flat.FlatLearningType ResilientPropagation {
			get {
				if (ResilientPropagation_jfieldId == IntPtr.Zero)
					ResilientPropagation_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ResilientPropagation", "Lorg/neuroph/nnet/flat/FlatLearningType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ResilientPropagation_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Flat.FlatLearningType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/nnet/flat/FlatLearningType", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FlatLearningType); }
		}

		internal FlatLearningType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.flat']/class[@name='FlatLearningType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lorg/neuroph/nnet/flat/FlatLearningType;", "")]
		public static unsafe global::Org.Neuroph.Nnet.Flat.FlatLearningType ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lorg/neuroph/nnet/flat/FlatLearningType;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Org.Neuroph.Nnet.Flat.FlatLearningType __ret = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Flat.FlatLearningType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.flat']/class[@name='FlatLearningType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lorg/neuroph/nnet/flat/FlatLearningType;", "")]
		public static unsafe global::Org.Neuroph.Nnet.Flat.FlatLearningType[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lorg/neuroph/nnet/flat/FlatLearningType;");
			try {
				return (global::Org.Neuroph.Nnet.Flat.FlatLearningType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Neuroph.Nnet.Flat.FlatLearningType));
			} finally {
			}
		}

	}
}
