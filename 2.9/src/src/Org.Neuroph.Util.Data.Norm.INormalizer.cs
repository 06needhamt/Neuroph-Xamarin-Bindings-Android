using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Util.Data.Norm {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.neuroph.util.data.norm']/interface[@name='Normalizer']"
	[Register ("org/neuroph/util/data/norm/Normalizer", "", "Org.Neuroph.Util.Data.Norm.INormalizerInvoker")]
	public partial interface INormalizer : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util.data.norm']/interface[@name='Normalizer']/method[@name='normalize' and count(parameter)=1 and parameter[1][@type='org.neuroph.core.data.DataSet']]"
		[Register ("normalize", "(Lorg/neuroph/core/data/DataSet;)V", "GetNormalize_Lorg_neuroph_core_data_DataSet_Handler:Org.Neuroph.Util.Data.Norm.INormalizerInvoker, neuroph_2.9")]
		void Normalize (global::Org.Neuroph.Core.Data.DataSet p0);

	}

	[global::Android.Runtime.Register ("org/neuroph/util/data/norm/Normalizer", DoNotGenerateAcw=true)]
	internal class INormalizerInvoker : global::Java.Lang.Object, INormalizer {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/neuroph/util/data/norm/Normalizer");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (INormalizerInvoker); }
		}

		IntPtr class_ref;

		public static INormalizer GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<INormalizer> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.neuroph.util.data.norm.Normalizer"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public INormalizerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_normalize_Lorg_neuroph_core_data_DataSet_;
#pragma warning disable 0169
		static Delegate GetNormalize_Lorg_neuroph_core_data_DataSet_Handler ()
		{
			if (cb_normalize_Lorg_neuroph_core_data_DataSet_ == null)
				cb_normalize_Lorg_neuroph_core_data_DataSet_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Normalize_Lorg_neuroph_core_data_DataSet_);
			return cb_normalize_Lorg_neuroph_core_data_DataSet_;
		}

		static void n_Normalize_Lorg_neuroph_core_data_DataSet_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Util.Data.Norm.INormalizer __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.Data.Norm.INormalizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Core.Data.DataSet p0 = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Data.DataSet> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Normalize (p0);
		}
#pragma warning restore 0169

		IntPtr id_normalize_Lorg_neuroph_core_data_DataSet_;
		public unsafe void Normalize (global::Org.Neuroph.Core.Data.DataSet p0)
		{
			if (id_normalize_Lorg_neuroph_core_data_DataSet_ == IntPtr.Zero)
				id_normalize_Lorg_neuroph_core_data_DataSet_ = JNIEnv.GetMethodID (class_ref, "normalize", "(Lorg/neuroph/core/data/DataSet;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_normalize_Lorg_neuroph_core_data_DataSet_, __args);
		}

	}

}
