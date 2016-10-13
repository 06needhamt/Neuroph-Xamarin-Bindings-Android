using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Contrib.Norm {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.contrib.norm']/class[@name='DataSetStatistics']"
	[global::Android.Runtime.Register ("org/neuroph/contrib/norm/DataSetStatistics", DoNotGenerateAcw=true)]
	public partial class DataSetStatistics : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/contrib/norm/DataSetStatistics", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DataSetStatistics); }
		}

		protected DataSetStatistics (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.contrib.norm']/class[@name='DataSetStatistics']/constructor[@name='DataSetStatistics' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DataSetStatistics ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (DataSetStatistics)) {
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

		static IntPtr id_calculateMaxByColumns_Lorg_neuroph_core_data_DataSet_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.contrib.norm']/class[@name='DataSetStatistics']/method[@name='calculateMaxByColumns' and count(parameter)=1 and parameter[1][@type='org.neuroph.core.data.DataSet']]"
		[Register ("calculateMaxByColumns", "(Lorg/neuroph/core/data/DataSet;)[D", "")]
		public static unsafe double[] CalculateMaxByColumns (global::Org.Neuroph.Core.Data.DataSet p0)
		{
			if (id_calculateMaxByColumns_Lorg_neuroph_core_data_DataSet_ == IntPtr.Zero)
				id_calculateMaxByColumns_Lorg_neuroph_core_data_DataSet_ = JNIEnv.GetStaticMethodID (class_ref, "calculateMaxByColumns", "(Lorg/neuroph/core/data/DataSet;)[D");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				double[] __ret = (double[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_calculateMaxByColumns_Lorg_neuroph_core_data_DataSet_, __args), JniHandleOwnership.TransferLocalRef, typeof (double));
				return __ret;
			} finally {
			}
		}

		static IntPtr id_calculateMean_Lorg_neuroph_core_data_DataSet_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.contrib.norm']/class[@name='DataSetStatistics']/method[@name='calculateMean' and count(parameter)=1 and parameter[1][@type='org.neuroph.core.data.DataSet']]"
		[Register ("calculateMean", "(Lorg/neuroph/core/data/DataSet;)[D", "")]
		public static unsafe double[] CalculateMean (global::Org.Neuroph.Core.Data.DataSet p0)
		{
			if (id_calculateMean_Lorg_neuroph_core_data_DataSet_ == IntPtr.Zero)
				id_calculateMean_Lorg_neuroph_core_data_DataSet_ = JNIEnv.GetStaticMethodID (class_ref, "calculateMean", "(Lorg/neuroph/core/data/DataSet;)[D");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				double[] __ret = (double[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_calculateMean_Lorg_neuroph_core_data_DataSet_, __args), JniHandleOwnership.TransferLocalRef, typeof (double));
				return __ret;
			} finally {
			}
		}

		static IntPtr id_calculateMinByColumns_Lorg_neuroph_core_data_DataSet_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.contrib.norm']/class[@name='DataSetStatistics']/method[@name='calculateMinByColumns' and count(parameter)=1 and parameter[1][@type='org.neuroph.core.data.DataSet']]"
		[Register ("calculateMinByColumns", "(Lorg/neuroph/core/data/DataSet;)[D", "")]
		public static unsafe double[] CalculateMinByColumns (global::Org.Neuroph.Core.Data.DataSet p0)
		{
			if (id_calculateMinByColumns_Lorg_neuroph_core_data_DataSet_ == IntPtr.Zero)
				id_calculateMinByColumns_Lorg_neuroph_core_data_DataSet_ = JNIEnv.GetStaticMethodID (class_ref, "calculateMinByColumns", "(Lorg/neuroph/core/data/DataSet;)[D");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				double[] __ret = (double[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_calculateMinByColumns_Lorg_neuroph_core_data_DataSet_, __args), JniHandleOwnership.TransferLocalRef, typeof (double));
				return __ret;
			} finally {
			}
		}

	}
}
