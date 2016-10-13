using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Util.Data.Sample {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.neuroph.util.data.sample']/interface[@name='Sampling']"
	[Register ("org/neuroph/util/data/sample/Sampling", "", "Org.Neuroph.Util.Data.Sample.ISamplingInvoker")]
	public partial interface ISampling : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util.data.sample']/interface[@name='Sampling']/method[@name='sample' and count(parameter)=1 and parameter[1][@type='org.neuroph.core.data.DataSet']]"
		[Register ("sample", "(Lorg/neuroph/core/data/DataSet;)[Lorg/neuroph/core/data/DataSet;", "GetSample_Lorg_neuroph_core_data_DataSet_Handler:Org.Neuroph.Util.Data.Sample.ISamplingInvoker, neuroph_2.9")]
		global::Org.Neuroph.Core.Data.DataSet[] Sample (global::Org.Neuroph.Core.Data.DataSet p0);

	}

	[global::Android.Runtime.Register ("org/neuroph/util/data/sample/Sampling", DoNotGenerateAcw=true)]
	internal class ISamplingInvoker : global::Java.Lang.Object, ISampling {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/neuroph/util/data/sample/Sampling");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ISamplingInvoker); }
		}

		IntPtr class_ref;

		public static ISampling GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISampling> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.neuroph.util.data.sample.Sampling"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISamplingInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Org.Neuroph.Util.Data.Sample.ISampling __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.Data.Sample.ISampling> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Core.Data.DataSet p0 = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Data.DataSet> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.Sample (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_sample_Lorg_neuroph_core_data_DataSet_;
		public unsafe global::Org.Neuroph.Core.Data.DataSet[] Sample (global::Org.Neuroph.Core.Data.DataSet p0)
		{
			if (id_sample_Lorg_neuroph_core_data_DataSet_ == IntPtr.Zero)
				id_sample_Lorg_neuroph_core_data_DataSet_ = JNIEnv.GetMethodID (class_ref, "sample", "(Lorg/neuroph/core/data/DataSet;)[Lorg/neuroph/core/data/DataSet;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			global::Org.Neuroph.Core.Data.DataSet[] __ret = (global::Org.Neuroph.Core.Data.DataSet[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_sample_Lorg_neuroph_core_data_DataSet_, __args), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Neuroph.Core.Data.DataSet));
			return __ret;
		}

	}

}
