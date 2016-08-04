using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Util.Data.Sample {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.util.data.sample']/class[@name='SubSampling']"
	[global::Android.Runtime.Register ("org/neuroph/util/data/sample/SubSampling", DoNotGenerateAcw=true)]
	public partial class SubSampling : global::Java.Lang.Object, global::Org.Neuroph.Util.Data.Sample.ISampling {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/util/data/sample/SubSampling", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SubSampling); }
		}

		protected SubSampling (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.util.data.sample']/class[@name='SubSampling']/constructor[@name='SubSampling' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe SubSampling (int p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (SubSampling)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(I)V", __args);
					return;
				}

				if (id_ctor_I == IntPtr.Zero)
					id_ctor_I = JNIEnv.GetMethodID (class_ref, "<init>", "(I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_I, __args);
			} finally {
			}
		}

		static Delegate cb_sample_Lorg_neuroph_core_data_DataSet_;
#pragma warning disable 0169
		static Delegate GetSample_Lorg_neuroph_core_data_DataSet_Handler ()
		{
			if (cb_sample_Lorg_neuroph_core_data_DataSet_ == null)
				cb_sample_Lorg_neuroph_core_data_DataSet_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Sample_Lorg_neuroph_core_data_DataSet_);
			return cb_sample_Lorg_neuroph_core_data_DataSet_;
		}

		static IntPtr n_Sample_Lorg_neuroph_core_data_DataSet_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Util.Data.Sample.SubSampling __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.Data.Sample.SubSampling> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Core.Data.DataSet p0 = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Data.DataSet> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.Sample (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_sample_Lorg_neuroph_core_data_DataSet_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util.data.sample']/class[@name='SubSampling']/method[@name='sample' and count(parameter)=1 and parameter[1][@type='org.neuroph.core.data.DataSet']]"
		[Register ("sample", "(Lorg/neuroph/core/data/DataSet;)[Lorg/neuroph/core/data/DataSet;", "GetSample_Lorg_neuroph_core_data_DataSet_Handler")]
		public virtual unsafe global::Org.Neuroph.Core.Data.DataSet[] Sample (global::Org.Neuroph.Core.Data.DataSet p0)
		{
			if (id_sample_Lorg_neuroph_core_data_DataSet_ == IntPtr.Zero)
				id_sample_Lorg_neuroph_core_data_DataSet_ = JNIEnv.GetMethodID (class_ref, "sample", "(Lorg/neuroph/core/data/DataSet;)[Lorg/neuroph/core/data/DataSet;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Org.Neuroph.Core.Data.DataSet[] __ret;
				if (GetType () == ThresholdType)
					__ret = (global::Org.Neuroph.Core.Data.DataSet[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_sample_Lorg_neuroph_core_data_DataSet_, __args), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Neuroph.Core.Data.DataSet));
				else
					__ret = (global::Org.Neuroph.Core.Data.DataSet[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sample", "(Lorg/neuroph/core/data/DataSet;)[Lorg/neuroph/core/data/DataSet;"), __args), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Neuroph.Core.Data.DataSet));
				return __ret;
			} finally {
			}
		}

	}
}
