using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Samples.Convolution {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.samples.convolution']/class[@name='MNISTDataSet']"
	[global::Android.Runtime.Register ("org/neuroph/samples/convolution/MNISTDataSet", DoNotGenerateAcw=true)]
	public partial class MNISTDataSet : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.neuroph.samples.convolution']/class[@name='MNISTDataSet']/field[@name='TEST_IMAGE_NAME']"
		[Register ("TEST_IMAGE_NAME")]
		public const string TestImageName = (string) "t10k-images.idx3-ubyte";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.neuroph.samples.convolution']/class[@name='MNISTDataSet']/field[@name='TEST_LABEL_NAME']"
		[Register ("TEST_LABEL_NAME")]
		public const string TestLabelName = (string) "t10k-labels.idx1-ubyte";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.neuroph.samples.convolution']/class[@name='MNISTDataSet']/field[@name='TRAIN_IMAGE_NAME']"
		[Register ("TRAIN_IMAGE_NAME")]
		public const string TrainImageName = (string) "train-images.idx3-ubyte";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.neuroph.samples.convolution']/class[@name='MNISTDataSet']/field[@name='TRAIN_LABEL_NAME']"
		[Register ("TRAIN_LABEL_NAME")]
		public const string TrainLabelName = (string) "train-labels.idx1-ubyte";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/samples/convolution/MNISTDataSet", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MNISTDataSet); }
		}

		protected MNISTDataSet (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.samples.convolution']/class[@name='MNISTDataSet']/constructor[@name='MNISTDataSet' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MNISTDataSet ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (MNISTDataSet)) {
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

		static IntPtr id_createFromFile_Ljava_lang_String_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.samples.convolution']/class[@name='MNISTDataSet']/method[@name='createFromFile' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
		[Register ("createFromFile", "(Ljava/lang/String;Ljava/lang/String;I)Lorg/neuroph/core/data/DataSet;", "")]
		public static unsafe global::Org.Neuroph.Core.Data.DataSet CreateFromFile (string p0, string p1, int p2)
		{
			if (id_createFromFile_Ljava_lang_String_Ljava_lang_String_I == IntPtr.Zero)
				id_createFromFile_Ljava_lang_String_Ljava_lang_String_I = JNIEnv.GetStaticMethodID (class_ref, "createFromFile", "(Ljava/lang/String;Ljava/lang/String;I)Lorg/neuroph/core/data/DataSet;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				global::Org.Neuroph.Core.Data.DataSet __ret = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Data.DataSet> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createFromFile_Ljava_lang_String_Ljava_lang_String_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
