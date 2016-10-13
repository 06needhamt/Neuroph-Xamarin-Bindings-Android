using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Core.Learning {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='LearningRule']"
	[global::Android.Runtime.Register ("org/neuroph/core/learning/LearningRule", DoNotGenerateAcw=true)]
	public abstract partial class LearningRule : global::Java.Util.Observable, global::Java.IO.ISerializable, global::Java.Lang.IRunnable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/core/learning/LearningRule", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LearningRule); }
		}

		protected LearningRule (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='LearningRule']/constructor[@name='LearningRule' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe LearningRule ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (LearningRule)) {
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

		static Delegate cb_isStopped;
#pragma warning disable 0169
		static Delegate GetIsStoppedHandler ()
		{
			if (cb_isStopped == null)
				cb_isStopped = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsStopped);
			return cb_isStopped;
		}

		static bool n_IsStopped (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Core.Learning.LearningRule __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.LearningRule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsStopped;
		}
#pragma warning restore 0169

		static IntPtr id_isStopped;
		public virtual unsafe bool IsStopped {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='LearningRule']/method[@name='isStopped' and count(parameter)=0]"
			[Register ("isStopped", "()Z", "GetIsStoppedHandler")]
			get {
				if (id_isStopped == IntPtr.Zero)
					id_isStopped = JNIEnv.GetMethodID (class_ref, "isStopped", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isStopped);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isStopped", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getNeuralNetwork;
#pragma warning disable 0169
		static Delegate GetGetNeuralNetworkHandler ()
		{
			if (cb_getNeuralNetwork == null)
				cb_getNeuralNetwork = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNeuralNetwork);
			return cb_getNeuralNetwork;
		}

		static IntPtr n_GetNeuralNetwork (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Core.Learning.LearningRule __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.LearningRule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NeuralNetwork);
		}
#pragma warning restore 0169

		static Delegate cb_setNeuralNetwork_Lorg_neuroph_core_NeuralNetwork_;
#pragma warning disable 0169
		static Delegate GetSetNeuralNetwork_Lorg_neuroph_core_NeuralNetwork_Handler ()
		{
			if (cb_setNeuralNetwork_Lorg_neuroph_core_NeuralNetwork_ == null)
				cb_setNeuralNetwork_Lorg_neuroph_core_NeuralNetwork_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetNeuralNetwork_Lorg_neuroph_core_NeuralNetwork_);
			return cb_setNeuralNetwork_Lorg_neuroph_core_NeuralNetwork_;
		}

		static void n_SetNeuralNetwork_Lorg_neuroph_core_NeuralNetwork_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Core.Learning.LearningRule __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.LearningRule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Core.NeuralNetwork p0 = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.NeuralNetwork> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.NeuralNetwork = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getNeuralNetwork;
		static IntPtr id_setNeuralNetwork_Lorg_neuroph_core_NeuralNetwork_;
		public virtual unsafe global::Org.Neuroph.Core.NeuralNetwork NeuralNetwork {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='LearningRule']/method[@name='getNeuralNetwork' and count(parameter)=0]"
			[Register ("getNeuralNetwork", "()Lorg/neuroph/core/NeuralNetwork;", "GetGetNeuralNetworkHandler")]
			get {
				if (id_getNeuralNetwork == IntPtr.Zero)
					id_getNeuralNetwork = JNIEnv.GetMethodID (class_ref, "getNeuralNetwork", "()Lorg/neuroph/core/NeuralNetwork;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.NeuralNetwork> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNeuralNetwork), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.NeuralNetwork> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNeuralNetwork", "()Lorg/neuroph/core/NeuralNetwork;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='LearningRule']/method[@name='setNeuralNetwork' and count(parameter)=1 and parameter[1][@type='org.neuroph.core.NeuralNetwork']]"
			[Register ("setNeuralNetwork", "(Lorg/neuroph/core/NeuralNetwork;)V", "GetSetNeuralNetwork_Lorg_neuroph_core_NeuralNetwork_Handler")]
			set {
				if (id_setNeuralNetwork_Lorg_neuroph_core_NeuralNetwork_ == IntPtr.Zero)
					id_setNeuralNetwork_Lorg_neuroph_core_NeuralNetwork_ = JNIEnv.GetMethodID (class_ref, "setNeuralNetwork", "(Lorg/neuroph/core/NeuralNetwork;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setNeuralNetwork_Lorg_neuroph_core_NeuralNetwork_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNeuralNetwork", "(Lorg/neuroph/core/NeuralNetwork;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTrainingSet;
#pragma warning disable 0169
		static Delegate GetGetTrainingSetHandler ()
		{
			if (cb_getTrainingSet == null)
				cb_getTrainingSet = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTrainingSet);
			return cb_getTrainingSet;
		}

		static IntPtr n_GetTrainingSet (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Core.Learning.LearningRule __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.LearningRule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TrainingSet);
		}
#pragma warning restore 0169

		static Delegate cb_setTrainingSet_Lorg_neuroph_core_learning_TrainingSet_;
#pragma warning disable 0169
		static Delegate GetSetTrainingSet_Lorg_neuroph_core_learning_TrainingSet_Handler ()
		{
			if (cb_setTrainingSet_Lorg_neuroph_core_learning_TrainingSet_ == null)
				cb_setTrainingSet_Lorg_neuroph_core_learning_TrainingSet_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTrainingSet_Lorg_neuroph_core_learning_TrainingSet_);
			return cb_setTrainingSet_Lorg_neuroph_core_learning_TrainingSet_;
		}

		static void n_SetTrainingSet_Lorg_neuroph_core_learning_TrainingSet_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Core.Learning.LearningRule __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.LearningRule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Core.Learning.TrainingSet p0 = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.TrainingSet> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TrainingSet = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTrainingSet;
		static IntPtr id_setTrainingSet_Lorg_neuroph_core_learning_TrainingSet_;
		public virtual unsafe global::Org.Neuroph.Core.Learning.TrainingSet TrainingSet {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='LearningRule']/method[@name='getTrainingSet' and count(parameter)=0]"
			[Register ("getTrainingSet", "()Lorg/neuroph/core/learning/TrainingSet;", "GetGetTrainingSetHandler")]
			get {
				if (id_getTrainingSet == IntPtr.Zero)
					id_getTrainingSet = JNIEnv.GetMethodID (class_ref, "getTrainingSet", "()Lorg/neuroph/core/learning/TrainingSet;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.TrainingSet> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTrainingSet), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.TrainingSet> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTrainingSet", "()Lorg/neuroph/core/learning/TrainingSet;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='LearningRule']/method[@name='setTrainingSet' and count(parameter)=1 and parameter[1][@type='org.neuroph.core.learning.TrainingSet']]"
			[Register ("setTrainingSet", "(Lorg/neuroph/core/learning/TrainingSet;)V", "GetSetTrainingSet_Lorg_neuroph_core_learning_TrainingSet_Handler")]
			set {
				if (id_setTrainingSet_Lorg_neuroph_core_learning_TrainingSet_ == IntPtr.Zero)
					id_setTrainingSet_Lorg_neuroph_core_learning_TrainingSet_ = JNIEnv.GetMethodID (class_ref, "setTrainingSet", "(Lorg/neuroph/core/learning/TrainingSet;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTrainingSet_Lorg_neuroph_core_learning_TrainingSet_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTrainingSet", "(Lorg/neuroph/core/learning/TrainingSet;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_learn_Lorg_neuroph_core_learning_TrainingSet_;
#pragma warning disable 0169
		static Delegate GetLearn_Lorg_neuroph_core_learning_TrainingSet_Handler ()
		{
			if (cb_learn_Lorg_neuroph_core_learning_TrainingSet_ == null)
				cb_learn_Lorg_neuroph_core_learning_TrainingSet_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Learn_Lorg_neuroph_core_learning_TrainingSet_);
			return cb_learn_Lorg_neuroph_core_learning_TrainingSet_;
		}

		static void n_Learn_Lorg_neuroph_core_learning_TrainingSet_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Core.Learning.LearningRule __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.LearningRule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Core.Learning.TrainingSet p0 = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.TrainingSet> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Learn (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='LearningRule']/method[@name='learn' and count(parameter)=1 and parameter[1][@type='org.neuroph.core.learning.TrainingSet']]"
		[Register ("learn", "(Lorg/neuroph/core/learning/TrainingSet;)V", "GetLearn_Lorg_neuroph_core_learning_TrainingSet_Handler")]
		public abstract void Learn (global::Org.Neuroph.Core.Learning.TrainingSet p0);

		static Delegate cb_notifyChange;
#pragma warning disable 0169
		static Delegate GetNotifyChangeHandler ()
		{
			if (cb_notifyChange == null)
				cb_notifyChange = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_NotifyChange);
			return cb_notifyChange;
		}

		static void n_NotifyChange (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Core.Learning.LearningRule __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.LearningRule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NotifyChange ();
		}
#pragma warning restore 0169

		static IntPtr id_notifyChange;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='LearningRule']/method[@name='notifyChange' and count(parameter)=0]"
		[Register ("notifyChange", "()V", "GetNotifyChangeHandler")]
		protected virtual unsafe void NotifyChange ()
		{
			if (id_notifyChange == IntPtr.Zero)
				id_notifyChange = JNIEnv.GetMethodID (class_ref, "notifyChange", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_notifyChange);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "notifyChange", "()V"));
			} finally {
			}
		}

		static Delegate cb_run;
#pragma warning disable 0169
		static Delegate GetRunHandler ()
		{
			if (cb_run == null)
				cb_run = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Run);
			return cb_run;
		}

		static void n_Run (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Core.Learning.LearningRule __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.LearningRule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Run ();
		}
#pragma warning restore 0169

		static IntPtr id_run;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='LearningRule']/method[@name='run' and count(parameter)=0]"
		[Register ("run", "()V", "GetRunHandler")]
		public virtual unsafe void Run ()
		{
			if (id_run == IntPtr.Zero)
				id_run = JNIEnv.GetMethodID (class_ref, "run", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_run);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "run", "()V"));
			} finally {
			}
		}

		static Delegate cb_setStarted;
#pragma warning disable 0169
		static Delegate GetSetStartedHandler ()
		{
			if (cb_setStarted == null)
				cb_setStarted = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SetStarted);
			return cb_setStarted;
		}

		static void n_SetStarted (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Core.Learning.LearningRule __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.LearningRule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetStarted ();
		}
#pragma warning restore 0169

		static IntPtr id_setStarted;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='LearningRule']/method[@name='setStarted' and count(parameter)=0]"
		[Register ("setStarted", "()V", "GetSetStartedHandler")]
		public virtual unsafe void SetStarted ()
		{
			if (id_setStarted == IntPtr.Zero)
				id_setStarted = JNIEnv.GetMethodID (class_ref, "setStarted", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setStarted);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setStarted", "()V"));
			} finally {
			}
		}

		static Delegate cb_stopLearning;
#pragma warning disable 0169
		static Delegate GetStopLearningHandler ()
		{
			if (cb_stopLearning == null)
				cb_stopLearning = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StopLearning);
			return cb_stopLearning;
		}

		static void n_StopLearning (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Core.Learning.LearningRule __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.LearningRule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopLearning ();
		}
#pragma warning restore 0169

		static IntPtr id_stopLearning;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='LearningRule']/method[@name='stopLearning' and count(parameter)=0]"
		[Register ("stopLearning", "()V", "GetStopLearningHandler")]
		public virtual unsafe void StopLearning ()
		{
			if (id_stopLearning == IntPtr.Zero)
				id_stopLearning = JNIEnv.GetMethodID (class_ref, "stopLearning", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stopLearning);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stopLearning", "()V"));
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("org/neuroph/core/learning/LearningRule", DoNotGenerateAcw=true)]
	internal partial class LearningRuleInvoker : LearningRule {

		public LearningRuleInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (LearningRuleInvoker); }
		}

		static IntPtr id_learn_Lorg_neuroph_core_learning_TrainingSet_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='LearningRule']/method[@name='learn' and count(parameter)=1 and parameter[1][@type='org.neuroph.core.learning.TrainingSet']]"
		[Register ("learn", "(Lorg/neuroph/core/learning/TrainingSet;)V", "GetLearn_Lorg_neuroph_core_learning_TrainingSet_Handler")]
		public override unsafe void Learn (global::Org.Neuroph.Core.Learning.TrainingSet p0)
		{
			if (id_learn_Lorg_neuroph_core_learning_TrainingSet_ == IntPtr.Zero)
				id_learn_Lorg_neuroph_core_learning_TrainingSet_ = JNIEnv.GetMethodID (class_ref, "learn", "(Lorg/neuroph/core/learning/TrainingSet;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_learn_Lorg_neuroph_core_learning_TrainingSet_, __args);
			} finally {
			}
		}

	}

}
