using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Contrib.Imgrec {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.contrib.imgrec']/class[@name='ImageRecognitionHelper']"
	[global::Android.Runtime.Register ("org/neuroph/contrib/imgrec/ImageRecognitionHelper", DoNotGenerateAcw=true)]
	public partial class ImageRecognitionHelper : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/contrib/imgrec/ImageRecognitionHelper", ref java_class_handle);
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.contrib.imgrec']/class[@name='ImageRecognitionHelper']/constructor[@name='ImageRecognitionHelper' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ImageRecognitionHelper ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ImageRecognitionHelper)) {
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

		static IntPtr id_createBlackAndWhiteTrainingSet_Ljava_util_List_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.contrib.imgrec']/class[@name='ImageRecognitionHelper']/method[@name='createBlackAndWhiteTrainingSet' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;'] and parameter[2][@type='java.util.Map&lt;java.lang.String, org.neuroph.contrib.imgrec.FractionRgbData&gt;']]"
		[Register ("createBlackAndWhiteTrainingSet", "(Ljava/util/List;Ljava/util/Map;)Lorg/neuroph/core/learning/TrainingSet;", "")]
		public static unsafe global::Org.Neuroph.Core.Learning.TrainingSet CreateBlackAndWhiteTrainingSet (global::System.Collections.Generic.IList<string> p0, global::System.Collections.Generic.IDictionary<string, global::Org.Neuroph.Contrib.Imgrec.FractionRgbData> p1)
		{
			if (id_createBlackAndWhiteTrainingSet_Ljava_util_List_Ljava_util_Map_ == IntPtr.Zero)
				id_createBlackAndWhiteTrainingSet_Ljava_util_List_Ljava_util_Map_ = JNIEnv.GetStaticMethodID (class_ref, "createBlackAndWhiteTrainingSet", "(Ljava/util/List;Ljava/util/Map;)Lorg/neuroph/core/learning/TrainingSet;");
			IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, global::Org.Neuroph.Contrib.Imgrec.FractionRgbData>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				global::Org.Neuroph.Core.Learning.TrainingSet __ret = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.TrainingSet> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createBlackAndWhiteTrainingSet_Ljava_util_List_Ljava_util_Map_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_createTrainingSet_Ljava_util_List_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.contrib.imgrec']/class[@name='ImageRecognitionHelper']/method[@name='createTrainingSet' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;'] and parameter[2][@type='java.util.Map&lt;java.lang.String, org.neuroph.contrib.imgrec.FractionRgbData&gt;']]"
		[Register ("createTrainingSet", "(Ljava/util/List;Ljava/util/Map;)Lorg/neuroph/core/learning/TrainingSet;", "")]
		public static unsafe global::Org.Neuroph.Core.Learning.TrainingSet CreateTrainingSet (global::System.Collections.Generic.IList<string> p0, global::System.Collections.Generic.IDictionary<string, global::Org.Neuroph.Contrib.Imgrec.FractionRgbData> p1)
		{
			if (id_createTrainingSet_Ljava_util_List_Ljava_util_Map_ == IntPtr.Zero)
				id_createTrainingSet_Ljava_util_List_Ljava_util_Map_ = JNIEnv.GetStaticMethodID (class_ref, "createTrainingSet", "(Ljava/util/List;Ljava/util/Map;)Lorg/neuroph/core/learning/TrainingSet;");
			IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, global::Org.Neuroph.Contrib.Imgrec.FractionRgbData>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				global::Org.Neuroph.Core.Learning.TrainingSet __ret = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.TrainingSet> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createTrainingSet_Ljava_util_List_Ljava_util_Map_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
