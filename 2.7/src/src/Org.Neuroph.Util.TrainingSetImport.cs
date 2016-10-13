using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.util']/class[@name='TrainingSetImport']"
	[global::Android.Runtime.Register ("org/neuroph/util/TrainingSetImport", DoNotGenerateAcw=true)]
	public partial class TrainingSetImport : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/util/TrainingSetImport", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TrainingSetImport); }
		}

		protected TrainingSetImport (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.util']/class[@name='TrainingSetImport']/constructor[@name='TrainingSetImport' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TrainingSetImport ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (TrainingSetImport)) {
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

		static IntPtr id_importFromFile_Ljava_lang_String_IILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util']/class[@name='TrainingSetImport']/method[@name='importFromFile' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String']]"
		[Register ("importFromFile", "(Ljava/lang/String;IILjava/lang/String;)Lorg/neuroph/core/learning/DataSet;", "")]
		public static unsafe global::Org.Neuroph.Core.Learning.DataSet ImportFromFile (string p0, int p1, int p2, string p3)
		{
			if (id_importFromFile_Ljava_lang_String_IILjava_lang_String_ == IntPtr.Zero)
				id_importFromFile_Ljava_lang_String_IILjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "importFromFile", "(Ljava/lang/String;IILjava/lang/String;)Lorg/neuroph/core/learning/DataSet;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				global::Org.Neuroph.Core.Learning.DataSet __ret = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.DataSet> (JNIEnv.CallStaticObjectMethod  (class_ref, id_importFromFile_Ljava_lang_String_IILjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

	}
}
