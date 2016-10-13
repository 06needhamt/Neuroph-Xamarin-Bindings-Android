using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Core.Learning {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='UnsupervisedLearning']"
	[global::Android.Runtime.Register ("org/neuroph/core/learning/UnsupervisedLearning", DoNotGenerateAcw=true)]
	public abstract partial class UnsupervisedLearning : global::Org.Neuroph.Core.Learning.IterativeLearning, global::Java.IO.ISerializable {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/core/learning/UnsupervisedLearning", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UnsupervisedLearning); }
		}

		protected UnsupervisedLearning (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='UnsupervisedLearning']/constructor[@name='UnsupervisedLearning' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe UnsupervisedLearning ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (UnsupervisedLearning)) {
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

		static Delegate cb_adjustWeights;
#pragma warning disable 0169
		static Delegate GetAdjustWeightsHandler ()
		{
			if (cb_adjustWeights == null)
				cb_adjustWeights = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_AdjustWeights);
			return cb_adjustWeights;
		}

		static void n_AdjustWeights (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Core.Learning.UnsupervisedLearning __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.UnsupervisedLearning> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AdjustWeights ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='UnsupervisedLearning']/method[@name='adjustWeights' and count(parameter)=0]"
		[Register ("adjustWeights", "()V", "GetAdjustWeightsHandler")]
		protected abstract void AdjustWeights ();

		static Delegate cb_doLearningEpoch_Lorg_neuroph_core_learning_TrainingSet_;
#pragma warning disable 0169
		static Delegate GetDoLearningEpoch_Lorg_neuroph_core_learning_TrainingSet_Handler ()
		{
			if (cb_doLearningEpoch_Lorg_neuroph_core_learning_TrainingSet_ == null)
				cb_doLearningEpoch_Lorg_neuroph_core_learning_TrainingSet_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DoLearningEpoch_Lorg_neuroph_core_learning_TrainingSet_);
			return cb_doLearningEpoch_Lorg_neuroph_core_learning_TrainingSet_;
		}

		static void n_DoLearningEpoch_Lorg_neuroph_core_learning_TrainingSet_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Core.Learning.UnsupervisedLearning __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.UnsupervisedLearning> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Core.Learning.TrainingSet p0 = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.TrainingSet> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DoLearningEpoch (p0);
		}
#pragma warning restore 0169

		static IntPtr id_doLearningEpoch_Lorg_neuroph_core_learning_TrainingSet_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='UnsupervisedLearning']/method[@name='doLearningEpoch' and count(parameter)=1 and parameter[1][@type='org.neuroph.core.learning.TrainingSet']]"
		[Register ("doLearningEpoch", "(Lorg/neuroph/core/learning/TrainingSet;)V", "GetDoLearningEpoch_Lorg_neuroph_core_learning_TrainingSet_Handler")]
		public override unsafe void DoLearningEpoch (global::Org.Neuroph.Core.Learning.TrainingSet p0)
		{
			if (id_doLearningEpoch_Lorg_neuroph_core_learning_TrainingSet_ == IntPtr.Zero)
				id_doLearningEpoch_Lorg_neuroph_core_learning_TrainingSet_ = JNIEnv.GetMethodID (class_ref, "doLearningEpoch", "(Lorg/neuroph/core/learning/TrainingSet;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_doLearningEpoch_Lorg_neuroph_core_learning_TrainingSet_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "doLearningEpoch", "(Lorg/neuroph/core/learning/TrainingSet;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_learnPattern_Lorg_neuroph_core_learning_TrainingElement_;
#pragma warning disable 0169
		static Delegate GetLearnPattern_Lorg_neuroph_core_learning_TrainingElement_Handler ()
		{
			if (cb_learnPattern_Lorg_neuroph_core_learning_TrainingElement_ == null)
				cb_learnPattern_Lorg_neuroph_core_learning_TrainingElement_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_LearnPattern_Lorg_neuroph_core_learning_TrainingElement_);
			return cb_learnPattern_Lorg_neuroph_core_learning_TrainingElement_;
		}

		static void n_LearnPattern_Lorg_neuroph_core_learning_TrainingElement_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Core.Learning.UnsupervisedLearning __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.UnsupervisedLearning> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Core.Learning.TrainingElement p0 = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.TrainingElement> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LearnPattern (p0);
		}
#pragma warning restore 0169

		static IntPtr id_learnPattern_Lorg_neuroph_core_learning_TrainingElement_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='UnsupervisedLearning']/method[@name='learnPattern' and count(parameter)=1 and parameter[1][@type='org.neuroph.core.learning.TrainingElement']]"
		[Register ("learnPattern", "(Lorg/neuroph/core/learning/TrainingElement;)V", "GetLearnPattern_Lorg_neuroph_core_learning_TrainingElement_Handler")]
		protected virtual unsafe void LearnPattern (global::Org.Neuroph.Core.Learning.TrainingElement p0)
		{
			if (id_learnPattern_Lorg_neuroph_core_learning_TrainingElement_ == IntPtr.Zero)
				id_learnPattern_Lorg_neuroph_core_learning_TrainingElement_ = JNIEnv.GetMethodID (class_ref, "learnPattern", "(Lorg/neuroph/core/learning/TrainingElement;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_learnPattern_Lorg_neuroph_core_learning_TrainingElement_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "learnPattern", "(Lorg/neuroph/core/learning/TrainingElement;)V"), __args);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("org/neuroph/core/learning/UnsupervisedLearning", DoNotGenerateAcw=true)]
	internal partial class UnsupervisedLearningInvoker : UnsupervisedLearning {

		public UnsupervisedLearningInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (UnsupervisedLearningInvoker); }
		}

		static IntPtr id_adjustWeights;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='UnsupervisedLearning']/method[@name='adjustWeights' and count(parameter)=0]"
		[Register ("adjustWeights", "()V", "GetAdjustWeightsHandler")]
		protected override unsafe void AdjustWeights ()
		{
			if (id_adjustWeights == IntPtr.Zero)
				id_adjustWeights = JNIEnv.GetMethodID (class_ref, "adjustWeights", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_adjustWeights);
			} finally {
			}
		}

	}

}
