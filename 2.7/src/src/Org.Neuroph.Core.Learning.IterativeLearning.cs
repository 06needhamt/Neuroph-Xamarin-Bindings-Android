using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Core.Learning {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='IterativeLearning']"
	[global::Android.Runtime.Register ("org/neuroph/core/learning/IterativeLearning", DoNotGenerateAcw=true)]
	public abstract partial class IterativeLearning : global::Org.Neuroph.Core.Learning.LearningRule, global::Java.IO.ISerializable {


		static IntPtr iterationsLimited_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='IterativeLearning']/field[@name='iterationsLimited']"
		[Register ("iterationsLimited")]
		protected bool IterationsLimited {
			get {
				if (iterationsLimited_jfieldId == IntPtr.Zero)
					iterationsLimited_jfieldId = JNIEnv.GetFieldID (class_ref, "iterationsLimited", "Z");
				return JNIEnv.GetBooleanField (Handle, iterationsLimited_jfieldId);
			}
			set {
				if (iterationsLimited_jfieldId == IntPtr.Zero)
					iterationsLimited_jfieldId = JNIEnv.GetFieldID (class_ref, "iterationsLimited", "Z");
				try {
					JNIEnv.SetField (Handle, iterationsLimited_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr maxIterations_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='IterativeLearning']/field[@name='maxIterations']"
		[Register ("maxIterations")]
		protected int MaxIterations {
			get {
				if (maxIterations_jfieldId == IntPtr.Zero)
					maxIterations_jfieldId = JNIEnv.GetFieldID (class_ref, "maxIterations", "I");
				return JNIEnv.GetIntField (Handle, maxIterations_jfieldId);
			}
			set {
				if (maxIterations_jfieldId == IntPtr.Zero)
					maxIterations_jfieldId = JNIEnv.GetFieldID (class_ref, "maxIterations", "I");
				try {
					JNIEnv.SetField (Handle, maxIterations_jfieldId, value);
				} finally {
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/core/learning/IterativeLearning", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IterativeLearning); }
		}

		protected IterativeLearning (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='IterativeLearning']/constructor[@name='IterativeLearning' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe IterativeLearning ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (IterativeLearning)) {
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

		static Delegate cb_getCurrentIteration;
#pragma warning disable 0169
		static Delegate GetGetCurrentIterationHandler ()
		{
			if (cb_getCurrentIteration == null)
				cb_getCurrentIteration = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCurrentIteration);
			return cb_getCurrentIteration;
		}

		static IntPtr n_GetCurrentIteration (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Core.Learning.IterativeLearning __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.IterativeLearning> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CurrentIteration);
		}
#pragma warning restore 0169

		static IntPtr id_getCurrentIteration;
		public virtual unsafe global::Java.Lang.Integer CurrentIteration {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='IterativeLearning']/method[@name='getCurrentIteration' and count(parameter)=0]"
			[Register ("getCurrentIteration", "()Ljava/lang/Integer;", "GetGetCurrentIterationHandler")]
			get {
				if (id_getCurrentIteration == IntPtr.Zero)
					id_getCurrentIteration = JNIEnv.GetMethodID (class_ref, "getCurrentIteration", "()Ljava/lang/Integer;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod  (Handle, id_getCurrentIteration), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCurrentIteration", "()Ljava/lang/Integer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isPausedLearning;
#pragma warning disable 0169
		static Delegate GetIsPausedLearningHandler ()
		{
			if (cb_isPausedLearning == null)
				cb_isPausedLearning = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsPausedLearning);
			return cb_isPausedLearning;
		}

		static bool n_IsPausedLearning (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Core.Learning.IterativeLearning __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.IterativeLearning> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsPausedLearning;
		}
#pragma warning restore 0169

		static IntPtr id_isPausedLearning;
		public virtual unsafe bool IsPausedLearning {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='IterativeLearning']/method[@name='isPausedLearning' and count(parameter)=0]"
			[Register ("isPausedLearning", "()Z", "GetIsPausedLearningHandler")]
			get {
				if (id_isPausedLearning == IntPtr.Zero)
					id_isPausedLearning = JNIEnv.GetMethodID (class_ref, "isPausedLearning", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isPausedLearning);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isPausedLearning", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getLearningRate;
#pragma warning disable 0169
		static Delegate GetGetLearningRateHandler ()
		{
			if (cb_getLearningRate == null)
				cb_getLearningRate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetLearningRate);
			return cb_getLearningRate;
		}

		static double n_GetLearningRate (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Core.Learning.IterativeLearning __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.IterativeLearning> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LearningRate;
		}
#pragma warning restore 0169

		static Delegate cb_setLearningRate_D;
#pragma warning disable 0169
		static Delegate GetSetLearningRate_DHandler ()
		{
			if (cb_setLearningRate_D == null)
				cb_setLearningRate_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetLearningRate_D);
			return cb_setLearningRate_D;
		}

		static void n_SetLearningRate_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Org.Neuroph.Core.Learning.IterativeLearning __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.IterativeLearning> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.LearningRate = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getLearningRate;
		static IntPtr id_setLearningRate_D;
		public virtual unsafe double LearningRate {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='IterativeLearning']/method[@name='getLearningRate' and count(parameter)=0]"
			[Register ("getLearningRate", "()D", "GetGetLearningRateHandler")]
			get {
				if (id_getLearningRate == IntPtr.Zero)
					id_getLearningRate = JNIEnv.GetMethodID (class_ref, "getLearningRate", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod  (Handle, id_getLearningRate);
					else
						return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLearningRate", "()D"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='IterativeLearning']/method[@name='setLearningRate' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setLearningRate", "(D)V", "GetSetLearningRate_DHandler")]
			set {
				if (id_setLearningRate_D == IntPtr.Zero)
					id_setLearningRate_D = JNIEnv.GetMethodID (class_ref, "setLearningRate", "(D)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setLearningRate_D, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLearningRate", "(D)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_afterEpoch;
#pragma warning disable 0169
		static Delegate GetAfterEpochHandler ()
		{
			if (cb_afterEpoch == null)
				cb_afterEpoch = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_AfterEpoch);
			return cb_afterEpoch;
		}

		static void n_AfterEpoch (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Core.Learning.IterativeLearning __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.IterativeLearning> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AfterEpoch ();
		}
#pragma warning restore 0169

		static IntPtr id_afterEpoch;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='IterativeLearning']/method[@name='afterEpoch' and count(parameter)=0]"
		[Register ("afterEpoch", "()V", "GetAfterEpochHandler")]
		protected virtual unsafe void AfterEpoch ()
		{
			if (id_afterEpoch == IntPtr.Zero)
				id_afterEpoch = JNIEnv.GetMethodID (class_ref, "afterEpoch", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_afterEpoch);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "afterEpoch", "()V"));
			} finally {
			}
		}

		static Delegate cb_beforeEpoch;
#pragma warning disable 0169
		static Delegate GetBeforeEpochHandler ()
		{
			if (cb_beforeEpoch == null)
				cb_beforeEpoch = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_BeforeEpoch);
			return cb_beforeEpoch;
		}

		static void n_BeforeEpoch (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Core.Learning.IterativeLearning __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.IterativeLearning> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.BeforeEpoch ();
		}
#pragma warning restore 0169

		static IntPtr id_beforeEpoch;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='IterativeLearning']/method[@name='beforeEpoch' and count(parameter)=0]"
		[Register ("beforeEpoch", "()V", "GetBeforeEpochHandler")]
		protected virtual unsafe void BeforeEpoch ()
		{
			if (id_beforeEpoch == IntPtr.Zero)
				id_beforeEpoch = JNIEnv.GetMethodID (class_ref, "beforeEpoch", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_beforeEpoch);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "beforeEpoch", "()V"));
			} finally {
			}
		}

		static Delegate cb_doLearningEpoch_Lorg_neuroph_core_learning_DataSet_;
#pragma warning disable 0169
		static Delegate GetDoLearningEpoch_Lorg_neuroph_core_learning_DataSet_Handler ()
		{
			if (cb_doLearningEpoch_Lorg_neuroph_core_learning_DataSet_ == null)
				cb_doLearningEpoch_Lorg_neuroph_core_learning_DataSet_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DoLearningEpoch_Lorg_neuroph_core_learning_DataSet_);
			return cb_doLearningEpoch_Lorg_neuroph_core_learning_DataSet_;
		}

		static void n_DoLearningEpoch_Lorg_neuroph_core_learning_DataSet_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Core.Learning.IterativeLearning __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.IterativeLearning> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Core.Learning.DataSet p0 = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.DataSet> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DoLearningEpoch (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='IterativeLearning']/method[@name='doLearningEpoch' and count(parameter)=1 and parameter[1][@type='org.neuroph.core.learning.DataSet']]"
		[Register ("doLearningEpoch", "(Lorg/neuroph/core/learning/DataSet;)V", "GetDoLearningEpoch_Lorg_neuroph_core_learning_DataSet_Handler")]
		public abstract void DoLearningEpoch (global::Org.Neuroph.Core.Learning.DataSet p0);

		static Delegate cb_doOneLearningIteration_Lorg_neuroph_core_learning_DataSet_;
#pragma warning disable 0169
		static Delegate GetDoOneLearningIteration_Lorg_neuroph_core_learning_DataSet_Handler ()
		{
			if (cb_doOneLearningIteration_Lorg_neuroph_core_learning_DataSet_ == null)
				cb_doOneLearningIteration_Lorg_neuroph_core_learning_DataSet_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DoOneLearningIteration_Lorg_neuroph_core_learning_DataSet_);
			return cb_doOneLearningIteration_Lorg_neuroph_core_learning_DataSet_;
		}

		static void n_DoOneLearningIteration_Lorg_neuroph_core_learning_DataSet_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Core.Learning.IterativeLearning __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.IterativeLearning> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Core.Learning.DataSet p0 = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.DataSet> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DoOneLearningIteration (p0);
		}
#pragma warning restore 0169

		static IntPtr id_doOneLearningIteration_Lorg_neuroph_core_learning_DataSet_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='IterativeLearning']/method[@name='doOneLearningIteration' and count(parameter)=1 and parameter[1][@type='org.neuroph.core.learning.DataSet']]"
		[Register ("doOneLearningIteration", "(Lorg/neuroph/core/learning/DataSet;)V", "GetDoOneLearningIteration_Lorg_neuroph_core_learning_DataSet_Handler")]
		public virtual unsafe void DoOneLearningIteration (global::Org.Neuroph.Core.Learning.DataSet p0)
		{
			if (id_doOneLearningIteration_Lorg_neuroph_core_learning_DataSet_ == IntPtr.Zero)
				id_doOneLearningIteration_Lorg_neuroph_core_learning_DataSet_ = JNIEnv.GetMethodID (class_ref, "doOneLearningIteration", "(Lorg/neuroph/core/learning/DataSet;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_doOneLearningIteration_Lorg_neuroph_core_learning_DataSet_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "doOneLearningIteration", "(Lorg/neuroph/core/learning/DataSet;)V"), __args);
			} finally {
			}
		}

		static IntPtr id_learn_Lorg_neuroph_core_learning_DataSet_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='IterativeLearning']/method[@name='learn' and count(parameter)=1 and parameter[1][@type='org.neuroph.core.learning.DataSet']]"
		[Register ("learn", "(Lorg/neuroph/core/learning/DataSet;)V", "")]
		public override sealed unsafe void Learn (global::Org.Neuroph.Core.Learning.DataSet p0)
		{
			if (id_learn_Lorg_neuroph_core_learning_DataSet_ == IntPtr.Zero)
				id_learn_Lorg_neuroph_core_learning_DataSet_ = JNIEnv.GetMethodID (class_ref, "learn", "(Lorg/neuroph/core/learning/DataSet;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_learn_Lorg_neuroph_core_learning_DataSet_, __args);
			} finally {
			}
		}

		static Delegate cb_learn_Lorg_neuroph_core_learning_DataSet_I;
#pragma warning disable 0169
		static Delegate GetLearn_Lorg_neuroph_core_learning_DataSet_IHandler ()
		{
			if (cb_learn_Lorg_neuroph_core_learning_DataSet_I == null)
				cb_learn_Lorg_neuroph_core_learning_DataSet_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_Learn_Lorg_neuroph_core_learning_DataSet_I);
			return cb_learn_Lorg_neuroph_core_learning_DataSet_I;
		}

		static void n_Learn_Lorg_neuroph_core_learning_DataSet_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Org.Neuroph.Core.Learning.IterativeLearning __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.IterativeLearning> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Core.Learning.DataSet p0 = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.DataSet> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Learn (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_learn_Lorg_neuroph_core_learning_DataSet_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='IterativeLearning']/method[@name='learn' and count(parameter)=2 and parameter[1][@type='org.neuroph.core.learning.DataSet'] and parameter[2][@type='int']]"
		[Register ("learn", "(Lorg/neuroph/core/learning/DataSet;I)V", "GetLearn_Lorg_neuroph_core_learning_DataSet_IHandler")]
		public virtual unsafe void Learn (global::Org.Neuroph.Core.Learning.DataSet p0, int p1)
		{
			if (id_learn_Lorg_neuroph_core_learning_DataSet_I == IntPtr.Zero)
				id_learn_Lorg_neuroph_core_learning_DataSet_I = JNIEnv.GetMethodID (class_ref, "learn", "(Lorg/neuroph/core/learning/DataSet;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_learn_Lorg_neuroph_core_learning_DataSet_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "learn", "(Lorg/neuroph/core/learning/DataSet;I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_pause;
#pragma warning disable 0169
		static Delegate GetPauseHandler ()
		{
			if (cb_pause == null)
				cb_pause = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Pause);
			return cb_pause;
		}

		static void n_Pause (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Core.Learning.IterativeLearning __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.IterativeLearning> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Pause ();
		}
#pragma warning restore 0169

		static IntPtr id_pause;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='IterativeLearning']/method[@name='pause' and count(parameter)=0]"
		[Register ("pause", "()V", "GetPauseHandler")]
		public virtual unsafe void Pause ()
		{
			if (id_pause == IntPtr.Zero)
				id_pause = JNIEnv.GetMethodID (class_ref, "pause", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_pause);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "pause", "()V"));
			} finally {
			}
		}

		static Delegate cb_resume;
#pragma warning disable 0169
		static Delegate GetResumeHandler ()
		{
			if (cb_resume == null)
				cb_resume = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Resume);
			return cb_resume;
		}

		static void n_Resume (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Core.Learning.IterativeLearning __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.IterativeLearning> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Resume ();
		}
#pragma warning restore 0169

		static IntPtr id_resume;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='IterativeLearning']/method[@name='resume' and count(parameter)=0]"
		[Register ("resume", "()V", "GetResumeHandler")]
		public virtual unsafe void Resume ()
		{
			if (id_resume == IntPtr.Zero)
				id_resume = JNIEnv.GetMethodID (class_ref, "resume", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_resume);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "resume", "()V"));
			} finally {
			}
		}

		static Delegate cb_setMaxIterations_I;
#pragma warning disable 0169
		static Delegate GetSetMaxIterations_IHandler ()
		{
			if (cb_setMaxIterations_I == null)
				cb_setMaxIterations_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetMaxIterations_I);
			return cb_setMaxIterations_I;
		}

		static void n_SetMaxIterations_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Neuroph.Core.Learning.IterativeLearning __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.IterativeLearning> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetMaxIterations (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setMaxIterations_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='IterativeLearning']/method[@name='setMaxIterations' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setMaxIterations", "(I)V", "GetSetMaxIterations_IHandler")]
		public virtual unsafe void SetMaxIterations (int p0)
		{
			if (id_setMaxIterations_I == IntPtr.Zero)
				id_setMaxIterations_I = JNIEnv.GetMethodID (class_ref, "setMaxIterations", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setMaxIterations_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMaxIterations", "(I)V"), __args);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("org/neuroph/core/learning/IterativeLearning", DoNotGenerateAcw=true)]
	internal partial class IterativeLearningInvoker : IterativeLearning {

		public IterativeLearningInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (IterativeLearningInvoker); }
		}

		static IntPtr id_doLearningEpoch_Lorg_neuroph_core_learning_DataSet_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='IterativeLearning']/method[@name='doLearningEpoch' and count(parameter)=1 and parameter[1][@type='org.neuroph.core.learning.DataSet']]"
		[Register ("doLearningEpoch", "(Lorg/neuroph/core/learning/DataSet;)V", "GetDoLearningEpoch_Lorg_neuroph_core_learning_DataSet_Handler")]
		public override unsafe void DoLearningEpoch (global::Org.Neuroph.Core.Learning.DataSet p0)
		{
			if (id_doLearningEpoch_Lorg_neuroph_core_learning_DataSet_ == IntPtr.Zero)
				id_doLearningEpoch_Lorg_neuroph_core_learning_DataSet_ = JNIEnv.GetMethodID (class_ref, "doLearningEpoch", "(Lorg/neuroph/core/learning/DataSet;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_doLearningEpoch_Lorg_neuroph_core_learning_DataSet_, __args);
			} finally {
			}
		}

	}

}
