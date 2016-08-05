using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Util.Norm {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.util.norm']/class[@name='DecimalScaleNormalizer']"
	[global::Android.Runtime.Register ("org/neuroph/util/norm/DecimalScaleNormalizer", DoNotGenerateAcw=true)]
	public partial class DecimalScaleNormalizer : global::Java.Lang.Object, global::Org.Neuroph.Util.Norm.INormalizer {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/util/norm/DecimalScaleNormalizer", ref java_class_handle);
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.util.norm']/class[@name='DecimalScaleNormalizer']/constructor[@name='DecimalScaleNormalizer' and count(parameter)=0]"
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

		static Delegate cb_findScaleVector;
#pragma warning disable 0169
		static Delegate GetFindScaleVectorHandler ()
		{
			if (cb_findScaleVector == null)
				cb_findScaleVector = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_FindScaleVector);
			return cb_findScaleVector;
		}

		static void n_FindScaleVector (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Util.Norm.DecimalScaleNormalizer __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.Norm.DecimalScaleNormalizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FindScaleVector ();
		}
#pragma warning restore 0169

		static IntPtr id_findScaleVector;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util.norm']/class[@name='DecimalScaleNormalizer']/method[@name='findScaleVector' and count(parameter)=0]"
		[Register ("findScaleVector", "()V", "GetFindScaleVectorHandler")]
		public virtual unsafe void FindScaleVector ()
		{
			if (id_findScaleVector == IntPtr.Zero)
				id_findScaleVector = JNIEnv.GetMethodID (class_ref, "findScaleVector", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_findScaleVector);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "findScaleVector", "()V"));
			} finally {
			}
		}

		static Delegate cb_normalize_Lorg_neuroph_core_learning_DataSet_;
#pragma warning disable 0169
		static Delegate GetNormalize_Lorg_neuroph_core_learning_DataSet_Handler ()
		{
			if (cb_normalize_Lorg_neuroph_core_learning_DataSet_ == null)
				cb_normalize_Lorg_neuroph_core_learning_DataSet_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Normalize_Lorg_neuroph_core_learning_DataSet_);
			return cb_normalize_Lorg_neuroph_core_learning_DataSet_;
		}

		static void n_Normalize_Lorg_neuroph_core_learning_DataSet_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Util.Norm.DecimalScaleNormalizer __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.Norm.DecimalScaleNormalizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Core.Learning.DataSet p0 = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.DataSet> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Normalize (p0);
		}
#pragma warning restore 0169

		static IntPtr id_normalize_Lorg_neuroph_core_learning_DataSet_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util.norm']/class[@name='DecimalScaleNormalizer']/method[@name='normalize' and count(parameter)=1 and parameter[1][@type='org.neuroph.core.learning.DataSet']]"
		[Register ("normalize", "(Lorg/neuroph/core/learning/DataSet;)V", "GetNormalize_Lorg_neuroph_core_learning_DataSet_Handler")]
		public virtual unsafe void Normalize (global::Org.Neuroph.Core.Learning.DataSet p0)
		{
			if (id_normalize_Lorg_neuroph_core_learning_DataSet_ == IntPtr.Zero)
				id_normalize_Lorg_neuroph_core_learning_DataSet_ = JNIEnv.GetMethodID (class_ref, "normalize", "(Lorg/neuroph/core/learning/DataSet;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_normalize_Lorg_neuroph_core_learning_DataSet_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "normalize", "(Lorg/neuroph/core/learning/DataSet;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_normalizeScale_arrayD;
#pragma warning disable 0169
		static Delegate GetNormalizeScale_arrayDHandler ()
		{
			if (cb_normalizeScale_arrayD == null)
				cb_normalizeScale_arrayD = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_NormalizeScale_arrayD);
			return cb_normalizeScale_arrayD;
		}

		static IntPtr n_NormalizeScale_arrayD (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Util.Norm.DecimalScaleNormalizer __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.Norm.DecimalScaleNormalizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			double[] p0 = (double[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (double));
			IntPtr __ret = JNIEnv.NewArray (__this.NormalizeScale (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_normalizeScale_arrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util.norm']/class[@name='DecimalScaleNormalizer']/method[@name='normalizeScale' and count(parameter)=1 and parameter[1][@type='double[]']]"
		[Register ("normalizeScale", "([D)[D", "GetNormalizeScale_arrayDHandler")]
		public virtual unsafe double[] NormalizeScale (double[] p0)
		{
			if (id_normalizeScale_arrayD == IntPtr.Zero)
				id_normalizeScale_arrayD = JNIEnv.GetMethodID (class_ref, "normalizeScale", "([D)[D");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				double[] __ret;
				if (GetType () == ThresholdType)
					__ret = (double[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_normalizeScale_arrayD, __args), JniHandleOwnership.TransferLocalRef, typeof (double));
				else
					__ret = (double[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "normalizeScale", "([D)[D"), __args), JniHandleOwnership.TransferLocalRef, typeof (double));
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
