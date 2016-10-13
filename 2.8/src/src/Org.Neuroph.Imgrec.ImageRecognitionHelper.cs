using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Imgrec {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.imgrec']/class[@name='ImageRecognitionHelper']"
	[global::Android.Runtime.Register ("org/neuroph/imgrec/ImageRecognitionHelper", DoNotGenerateAcw=true)]
	public partial class ImageRecognitionHelper : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/imgrec/ImageRecognitionHelper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ImageRecognitionHelper); }
		}

		protected ImageRecognitionHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.imgrec']/class[@name='ImageRecognitionHelper']/constructor[@name='ImageRecognitionHelper' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ImageRecognitionHelper ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ImageRecognitionHelper)) {
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

		static IntPtr id_createBlackAndWhiteTrainingSet_Ljava_util_List_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.imgrec']/class[@name='ImageRecognitionHelper']/method[@name='createBlackAndWhiteTrainingSet' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;'] and parameter[2][@type='java.util.Map&lt;java.lang.String, org.neuroph.imgrec.FractionRgbData&gt;']]"
		[Register ("createBlackAndWhiteTrainingSet", "(Ljava/util/List;Ljava/util/Map;)Lorg/neuroph/core/data/DataSet;", "")]
		public static unsafe global::Org.Neuroph.Core.Data.DataSet CreateBlackAndWhiteTrainingSet (global::System.Collections.Generic.IList<string> p0, global::System.Collections.Generic.IDictionary<string, global::Org.Neuroph.Imgrec.FractionRgbData> p1)
		{
			if (id_createBlackAndWhiteTrainingSet_Ljava_util_List_Ljava_util_Map_ == IntPtr.Zero)
				id_createBlackAndWhiteTrainingSet_Ljava_util_List_Ljava_util_Map_ = JNIEnv.GetStaticMethodID (class_ref, "createBlackAndWhiteTrainingSet", "(Ljava/util/List;Ljava/util/Map;)Lorg/neuroph/core/data/DataSet;");
			IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, global::Org.Neuroph.Imgrec.FractionRgbData>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				global::Org.Neuroph.Core.Data.DataSet __ret = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Data.DataSet> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createBlackAndWhiteTrainingSet_Ljava_util_List_Ljava_util_Map_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_createNewNeuralNetwork_Ljava_lang_String_Lorg_neuroph_imgrec_image_Dimension_Lorg_neuroph_imgrec_ColorMode_Ljava_util_List_Ljava_util_List_Lorg_neuroph_util_TransferFunctionType_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.imgrec']/class[@name='ImageRecognitionHelper']/method[@name='createNewNeuralNetwork' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.neuroph.imgrec.image.Dimension'] and parameter[3][@type='org.neuroph.imgrec.ColorMode'] and parameter[4][@type='java.util.List&lt;java.lang.String&gt;'] and parameter[5][@type='java.util.List&lt;java.lang.Integer&gt;'] and parameter[6][@type='org.neuroph.util.TransferFunctionType']]"
		[Register ("createNewNeuralNetwork", "(Ljava/lang/String;Lorg/neuroph/imgrec/image/Dimension;Lorg/neuroph/imgrec/ColorMode;Ljava/util/List;Ljava/util/List;Lorg/neuroph/util/TransferFunctionType;)Lorg/neuroph/core/NeuralNetwork;", "")]
		public static unsafe global::Org.Neuroph.Core.NeuralNetwork CreateNewNeuralNetwork (string p0, global::Org.Neuroph.Imgrec.Image.Dimension p1, global::Org.Neuroph.Imgrec.ColorMode p2, global::System.Collections.Generic.IList<string> p3, global::System.Collections.Generic.IList<global::Java.Lang.Integer> p4, global::Org.Neuroph.Util.TransferFunctionType p5)
		{
			if (id_createNewNeuralNetwork_Ljava_lang_String_Lorg_neuroph_imgrec_image_Dimension_Lorg_neuroph_imgrec_ColorMode_Ljava_util_List_Ljava_util_List_Lorg_neuroph_util_TransferFunctionType_ == IntPtr.Zero)
				id_createNewNeuralNetwork_Ljava_lang_String_Lorg_neuroph_imgrec_image_Dimension_Lorg_neuroph_imgrec_ColorMode_Ljava_util_List_Ljava_util_List_Lorg_neuroph_util_TransferFunctionType_ = JNIEnv.GetStaticMethodID (class_ref, "createNewNeuralNetwork", "(Ljava/lang/String;Lorg/neuroph/imgrec/image/Dimension;Lorg/neuroph/imgrec/ColorMode;Ljava/util/List;Ljava/util/List;Lorg/neuroph/util/TransferFunctionType;)Lorg/neuroph/core/NeuralNetwork;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p3 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p3);
			IntPtr native_p4 = global::Android.Runtime.JavaList<global::Java.Lang.Integer>.ToLocalJniHandle (p4);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (p5);
				global::Org.Neuroph.Core.NeuralNetwork __ret = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.NeuralNetwork> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createNewNeuralNetwork_Ljava_lang_String_Lorg_neuroph_imgrec_image_Dimension_Lorg_neuroph_imgrec_ColorMode_Ljava_util_List_Ljava_util_List_Lorg_neuroph_util_TransferFunctionType_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static IntPtr id_createTrainingSet_Ljava_util_List_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.imgrec']/class[@name='ImageRecognitionHelper']/method[@name='createTrainingSet' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;'] and parameter[2][@type='java.util.Map&lt;java.lang.String, org.neuroph.imgrec.FractionRgbData&gt;']]"
		[Register ("createTrainingSet", "(Ljava/util/List;Ljava/util/Map;)Lorg/neuroph/core/data/DataSet;", "")]
		public static unsafe global::Org.Neuroph.Core.Data.DataSet CreateTrainingSet (global::System.Collections.Generic.IList<string> p0, global::System.Collections.Generic.IDictionary<string, global::Org.Neuroph.Imgrec.FractionRgbData> p1)
		{
			if (id_createTrainingSet_Ljava_util_List_Ljava_util_Map_ == IntPtr.Zero)
				id_createTrainingSet_Ljava_util_List_Ljava_util_Map_ = JNIEnv.GetStaticMethodID (class_ref, "createTrainingSet", "(Ljava/util/List;Ljava/util/Map;)Lorg/neuroph/core/data/DataSet;");
			IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, global::Org.Neuroph.Imgrec.FractionRgbData>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				global::Org.Neuroph.Core.Data.DataSet __ret = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Data.DataSet> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createTrainingSet_Ljava_util_List_Ljava_util_Map_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
