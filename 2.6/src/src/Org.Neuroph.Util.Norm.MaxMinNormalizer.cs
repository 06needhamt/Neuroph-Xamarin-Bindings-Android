using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Util.Norm {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.util.norm']/class[@name='MaxMinNormalizer']"
	[global::Android.Runtime.Register ("org/neuroph/util/norm/MaxMinNormalizer", DoNotGenerateAcw=true)]
	public partial class MaxMinNormalizer : global::Java.Lang.Object, global::Org.Neuroph.Util.Norm.INormalizer {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/util/norm/MaxMinNormalizer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MaxMinNormalizer); }
		}

		protected MaxMinNormalizer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.util.norm']/class[@name='MaxMinNormalizer']/constructor[@name='MaxMinNormalizer' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MaxMinNormalizer ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (MaxMinNormalizer)) {
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

		static Delegate cb_normalize_Lorg_neuroph_core_learning_TrainingSet_;
#pragma warning disable 0169
		static Delegate GetNormalize_Lorg_neuroph_core_learning_TrainingSet_Handler ()
		{
			if (cb_normalize_Lorg_neuroph_core_learning_TrainingSet_ == null)
				cb_normalize_Lorg_neuroph_core_learning_TrainingSet_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Normalize_Lorg_neuroph_core_learning_TrainingSet_);
			return cb_normalize_Lorg_neuroph_core_learning_TrainingSet_;
		}

		static void n_Normalize_Lorg_neuroph_core_learning_TrainingSet_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Util.Norm.MaxMinNormalizer __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.Norm.MaxMinNormalizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Core.Learning.TrainingSet p0 = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.TrainingSet> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Normalize (p0);
		}
#pragma warning restore 0169

		static IntPtr id_normalize_Lorg_neuroph_core_learning_TrainingSet_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util.norm']/class[@name='MaxMinNormalizer']/method[@name='normalize' and count(parameter)=1 and parameter[1][@type='org.neuroph.core.learning.TrainingSet&lt;? extends org.neuroph.core.learning.TrainingElement&gt;']]"
		[Register ("normalize", "(Lorg/neuroph/core/learning/TrainingSet;)V", "GetNormalize_Lorg_neuroph_core_learning_TrainingSet_Handler")]
		public virtual unsafe void Normalize (global::Org.Neuroph.Core.Learning.TrainingSet p0)
		{
			if (id_normalize_Lorg_neuroph_core_learning_TrainingSet_ == IntPtr.Zero)
				id_normalize_Lorg_neuroph_core_learning_TrainingSet_ = JNIEnv.GetMethodID (class_ref, "normalize", "(Lorg/neuroph/core/learning/TrainingSet;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_normalize_Lorg_neuroph_core_learning_TrainingSet_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "normalize", "(Lorg/neuroph/core/learning/TrainingSet;)V"), __args);
			} finally {
			}
		}

	}
}
