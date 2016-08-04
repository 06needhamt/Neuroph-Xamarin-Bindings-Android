using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Contrib.Ocr {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.contrib.ocr']/class[@name='OcrHelper']"
	[global::Android.Runtime.Register ("org/neuroph/contrib/ocr/OcrHelper", DoNotGenerateAcw=true)]
	public partial class OcrHelper : global::Org.Neuroph.Contrib.Imgrec.ImageRecognitionHelper {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/contrib/ocr/OcrHelper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (OcrHelper); }
		}

		protected OcrHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.contrib.ocr']/class[@name='OcrHelper']/constructor[@name='OcrHelper' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe OcrHelper ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (OcrHelper)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static IntPtr id_createNewNeuralNetwork_Ljava_lang_String_Lorg_neuroph_contrib_imgrec_image_Dimension_Lorg_neuroph_contrib_imgrec_ColorMode_Ljava_util_List_Ljava_util_List_Lorg_neuroph_util_TransferFunctionType_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.contrib.ocr']/class[@name='OcrHelper']/method[@name='createNewNeuralNetwork' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.neuroph.contrib.imgrec.image.Dimension'] and parameter[3][@type='org.neuroph.contrib.imgrec.ColorMode'] and parameter[4][@type='java.util.List&lt;java.lang.String&gt;'] and parameter[5][@type='java.util.List&lt;java.lang.Integer&gt;'] and parameter[6][@type='org.neuroph.util.TransferFunctionType']]"
		[Register ("createNewNeuralNetwork", "(Ljava/lang/String;Lorg/neuroph/contrib/imgrec/image/Dimension;Lorg/neuroph/contrib/imgrec/ColorMode;Ljava/util/List;Ljava/util/List;Lorg/neuroph/util/TransferFunctionType;)Lorg/neuroph/core/NeuralNetwork;", "")]
		public static unsafe global::Org.Neuroph.Core.NeuralNetwork CreateNewNeuralNetwork (string p0, global::Org.Neuroph.Contrib.Imgrec.Image.Dimension p1, global::Org.Neuroph.Contrib.Imgrec.ColorMode p2, global::System.Collections.Generic.IList<string> p3, global::System.Collections.Generic.IList<global::Java.Lang.Integer> p4, global::Org.Neuroph.Util.TransferFunctionType p5)
		{
			if (id_createNewNeuralNetwork_Ljava_lang_String_Lorg_neuroph_contrib_imgrec_image_Dimension_Lorg_neuroph_contrib_imgrec_ColorMode_Ljava_util_List_Ljava_util_List_Lorg_neuroph_util_TransferFunctionType_ == IntPtr.Zero)
				id_createNewNeuralNetwork_Ljava_lang_String_Lorg_neuroph_contrib_imgrec_image_Dimension_Lorg_neuroph_contrib_imgrec_ColorMode_Ljava_util_List_Ljava_util_List_Lorg_neuroph_util_TransferFunctionType_ = JNIEnv.GetStaticMethodID (class_ref, "createNewNeuralNetwork", "(Ljava/lang/String;Lorg/neuroph/contrib/imgrec/image/Dimension;Lorg/neuroph/contrib/imgrec/ColorMode;Ljava/util/List;Ljava/util/List;Lorg/neuroph/util/TransferFunctionType;)Lorg/neuroph/core/NeuralNetwork;");
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
				global::Org.Neuroph.Core.NeuralNetwork __ret = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.NeuralNetwork> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createNewNeuralNetwork_Ljava_lang_String_Lorg_neuroph_contrib_imgrec_image_Dimension_Lorg_neuroph_contrib_imgrec_ColorMode_Ljava_util_List_Ljava_util_List_Lorg_neuroph_util_TransferFunctionType_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

	}
}
