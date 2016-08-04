using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Contrib.Samples.Stockmarket {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.contrib.samples.stockmarket']/class[@name='StockTrainingSetImport']"
	[global::Android.Runtime.Register ("org/neuroph/contrib/samples/stockmarket/StockTrainingSetImport", DoNotGenerateAcw=true)]
	public partial class StockTrainingSetImport : global::Org.Neuroph.Util.TrainingSetImport {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/contrib/samples/stockmarket/StockTrainingSetImport", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (StockTrainingSetImport); }
		}

		protected StockTrainingSetImport (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.contrib.samples.stockmarket']/class[@name='StockTrainingSetImport']/constructor[@name='StockTrainingSetImport' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe StockTrainingSetImport ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (StockTrainingSetImport)) {
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

		static IntPtr id_importFromArray_arrayDII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.contrib.samples.stockmarket']/class[@name='StockTrainingSetImport']/method[@name='importFromArray' and count(parameter)=3 and parameter[1][@type='double[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("importFromArray", "([DII)Lorg/neuroph/core/data/DataSet;", "")]
		public static unsafe global::Org.Neuroph.Core.Data.DataSet ImportFromArray (double[] p0, int p1, int p2)
		{
			if (id_importFromArray_arrayDII == IntPtr.Zero)
				id_importFromArray_arrayDII = JNIEnv.GetStaticMethodID (class_ref, "importFromArray", "([DII)Lorg/neuroph/core/data/DataSet;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				global::Org.Neuroph.Core.Data.DataSet __ret = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Data.DataSet> (JNIEnv.CallStaticObjectMethod  (class_ref, id_importFromArray_arrayDII, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

	}
}
