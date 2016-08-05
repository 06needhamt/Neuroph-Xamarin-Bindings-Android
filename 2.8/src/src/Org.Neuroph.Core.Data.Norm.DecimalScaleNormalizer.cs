using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Core.Data.Norm {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.core.data.norm']/class[@name='DecimalScaleNormalizer']"
	[global::Android.Runtime.Register ("org/neuroph/core/data/norm/DecimalScaleNormalizer", DoNotGenerateAcw=true)]
	public partial class DecimalScaleNormalizer : global::Java.Lang.Object, global::Org.Neuroph.Core.Data.Norm.INormalizer {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/core/data/norm/DecimalScaleNormalizer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DecimalScaleNormalizer); }
		}

		protected DecimalScaleNormalizer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.core.data.norm']/class[@name='DecimalScaleNormalizer']/constructor[@name='DecimalScaleNormalizer' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DecimalScaleNormalizer ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (DecimalScaleNormalizer)) {
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

		static Delegate cb_findScaleVectors;
#pragma warning disable 0169
		static Delegate GetFindScaleVectorsHandler ()
		{
			if (cb_findScaleVectors == null)
				cb_findScaleVectors = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_FindScaleVectors);
			return cb_findScaleVectors;
		}

		static void n_FindScaleVectors (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Core.Data.Norm.DecimalScaleNormalizer __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Data.Norm.DecimalScaleNormalizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FindScaleVectors ();
		}
#pragma warning restore 0169

		static IntPtr id_findScaleVectors;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.data.norm']/class[@name='DecimalScaleNormalizer']/method[@name='findScaleVectors' and count(parameter)=0]"
		[Register ("findScaleVectors", "()V", "GetFindScaleVectorsHandler")]
		public virtual unsafe void FindScaleVectors ()
		{
			if (id_findScaleVectors == IntPtr.Zero)
				id_findScaleVectors = JNIEnv.GetMethodID (class_ref, "findScaleVectors", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_findScaleVectors);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "findScaleVectors", "()V"));
			} finally {
			}
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
			global::Org.Neuroph.Core.Data.Norm.DecimalScaleNormalizer __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Data.Norm.DecimalScaleNormalizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Core.Data.DataSet p0 = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Data.DataSet> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Normalize (p0);
		}
#pragma warning restore 0169

		static IntPtr id_normalize_Lorg_neuroph_core_data_DataSet_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.data.norm']/class[@name='DecimalScaleNormalizer']/method[@name='normalize' and count(parameter)=1 and parameter[1][@type='org.neuroph.core.data.DataSet']]"
		[Register ("normalize", "(Lorg/neuroph/core/data/DataSet;)V", "GetNormalize_Lorg_neuroph_core_data_DataSet_Handler")]
		public virtual unsafe void Normalize (global::Org.Neuroph.Core.Data.DataSet p0)
		{
			if (id_normalize_Lorg_neuroph_core_data_DataSet_ == IntPtr.Zero)
				id_normalize_Lorg_neuroph_core_data_DataSet_ = JNIEnv.GetMethodID (class_ref, "normalize", "(Lorg/neuroph/core/data/DataSet;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_normalize_Lorg_neuroph_core_data_DataSet_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "normalize", "(Lorg/neuroph/core/data/DataSet;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_normalizeScale_arrayDarrayD;
#pragma warning disable 0169
		static Delegate GetNormalizeScale_arrayDarrayDHandler ()
		{
			if (cb_normalizeScale_arrayDarrayD == null)
				cb_normalizeScale_arrayDarrayD = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_NormalizeScale_arrayDarrayD);
			return cb_normalizeScale_arrayDarrayD;
		}

		static IntPtr n_NormalizeScale_arrayDarrayD (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Neuroph.Core.Data.Norm.DecimalScaleNormalizer __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Data.Norm.DecimalScaleNormalizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			double[] p0 = (double[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (double));
			double[] p1 = (double[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (double));
			IntPtr __ret = JNIEnv.NewArray (__this.NormalizeScale (p0, p1));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_normalizeScale_arrayDarrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.data.norm']/class[@name='DecimalScaleNormalizer']/method[@name='normalizeScale' and count(parameter)=2 and parameter[1][@type='double[]'] and parameter[2][@type='double[]']]"
		[Register ("normalizeScale", "([D[D)[D", "GetNormalizeScale_arrayDarrayDHandler")]
		public virtual unsafe double[] NormalizeScale (double[] p0, double[] p1)
		{
			if (id_normalizeScale_arrayDarrayD == IntPtr.Zero)
				id_normalizeScale_arrayDarrayD = JNIEnv.GetMethodID (class_ref, "normalizeScale", "([D[D)[D");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				double[] __ret;
				if (GetType () == ThresholdType)
					__ret = (double[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_normalizeScale_arrayDarrayD, __args), JniHandleOwnership.TransferLocalRef, typeof (double));
				else
					__ret = (double[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "normalizeScale", "([D[D)[D"), __args), JniHandleOwnership.TransferLocalRef, typeof (double));
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

	}
}
