using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Core.Learning {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='LearningRule']"
	[global::Android.Runtime.Register ("org/neuroph/core/learning/LearningRule", DoNotGenerateAcw=true)]
	public abstract partial class LearningRule : global::Java.Lang.Object, global::Java.IO.ISerializable {

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
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (LearningRule)) {
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
						return JNIEnv.CallBooleanMethod  (Handle, id_isStopped);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isStopped", "()Z"));
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
						return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.NeuralNetwork> (JNIEnv.CallObjectMethod  (Handle, id_getNeuralNetwork), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.NeuralNetwork> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNeuralNetwork", "()Lorg/neuroph/core/NeuralNetwork;")), JniHandleOwnership.TransferLocalRef);
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
						JNIEnv.CallVoidMethod  (Handle, id_setNeuralNetwork_Lorg_neuroph_core_NeuralNetwork_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNeuralNetwork", "(Lorg/neuroph/core/NeuralNetwork;)V"), __args);
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

		static Delegate cb_setTrainingSet_Lorg_neuroph_core_learning_DataSet_;
#pragma warning disable 0169
		static Delegate GetSetTrainingSet_Lorg_neuroph_core_learning_DataSet_Handler ()
		{
			if (cb_setTrainingSet_Lorg_neuroph_core_learning_DataSet_ == null)
				cb_setTrainingSet_Lorg_neuroph_core_learning_DataSet_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTrainingSet_Lorg_neuroph_core_learning_DataSet_);
			return cb_setTrainingSet_Lorg_neuroph_core_learning_DataSet_;
		}

		static void n_SetTrainingSet_Lorg_neuroph_core_learning_DataSet_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Core.Learning.LearningRule __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.LearningRule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Core.Learning.DataSet p0 = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.DataSet> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TrainingSet = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTrainingSet;
		static IntPtr id_setTrainingSet_Lorg_neuroph_core_learning_DataSet_;
		public virtual unsafe global::Org.Neuroph.Core.Learning.DataSet TrainingSet {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='LearningRule']/method[@name='getTrainingSet' and count(parameter)=0]"
			[Register ("getTrainingSet", "()Lorg/neuroph/core/learning/DataSet;", "GetGetTrainingSetHandler")]
			get {
				if (id_getTrainingSet == IntPtr.Zero)
					id_getTrainingSet = JNIEnv.GetMethodID (class_ref, "getTrainingSet", "()Lorg/neuroph/core/learning/DataSet;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.DataSet> (JNIEnv.CallObjectMethod  (Handle, id_getTrainingSet), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.DataSet> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTrainingSet", "()Lorg/neuroph/core/learning/DataSet;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='LearningRule']/method[@name='setTrainingSet' and count(parameter)=1 and parameter[1][@type='org.neuroph.core.learning.DataSet']]"
			[Register ("setTrainingSet", "(Lorg/neuroph/core/learning/DataSet;)V", "GetSetTrainingSet_Lorg_neuroph_core_learning_DataSet_Handler")]
			set {
				if (id_setTrainingSet_Lorg_neuroph_core_learning_DataSet_ == IntPtr.Zero)
					id_setTrainingSet_Lorg_neuroph_core_learning_DataSet_ = JNIEnv.GetMethodID (class_ref, "setTrainingSet", "(Lorg/neuroph/core/learning/DataSet;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setTrainingSet_Lorg_neuroph_core_learning_DataSet_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTrainingSet", "(Lorg/neuroph/core/learning/DataSet;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_addListener_Lorg_neuroph_core_events_LearningEventListener_;
#pragma warning disable 0169
		static Delegate GetAddListener_Lorg_neuroph_core_events_LearningEventListener_Handler ()
		{
			if (cb_addListener_Lorg_neuroph_core_events_LearningEventListener_ == null)
				cb_addListener_Lorg_neuroph_core_events_LearningEventListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddListener_Lorg_neuroph_core_events_LearningEventListener_);
			return cb_addListener_Lorg_neuroph_core_events_LearningEventListener_;
		}

		static void n_AddListener_Lorg_neuroph_core_events_LearningEventListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Core.Learning.LearningRule __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.LearningRule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Core.Events.ILearningEventListener p0 = (global::Org.Neuroph.Core.Events.ILearningEventListener)global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Events.ILearningEventListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addListener_Lorg_neuroph_core_events_LearningEventListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='LearningRule']/method[@name='addListener' and count(parameter)=1 and parameter[1][@type='org.neuroph.core.events.LearningEventListener']]"
		[Register ("addListener", "(Lorg/neuroph/core/events/LearningEventListener;)V", "GetAddListener_Lorg_neuroph_core_events_LearningEventListener_Handler")]
		public virtual unsafe void AddListener (global::Org.Neuroph.Core.Events.ILearningEventListener p0)
		{
			if (id_addListener_Lorg_neuroph_core_events_LearningEventListener_ == IntPtr.Zero)
				id_addListener_Lorg_neuroph_core_events_LearningEventListener_ = JNIEnv.GetMethodID (class_ref, "addListener", "(Lorg/neuroph/core/events/LearningEventListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_addListener_Lorg_neuroph_core_events_LearningEventListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addListener", "(Lorg/neuroph/core/events/LearningEventListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_fireLearningEvent_Lorg_neuroph_core_events_LearningEvent_;
#pragma warning disable 0169
		static Delegate GetFireLearningEvent_Lorg_neuroph_core_events_LearningEvent_Handler ()
		{
			if (cb_fireLearningEvent_Lorg_neuroph_core_events_LearningEvent_ == null)
				cb_fireLearningEvent_Lorg_neuroph_core_events_LearningEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_FireLearningEvent_Lorg_neuroph_core_events_LearningEvent_);
			return cb_fireLearningEvent_Lorg_neuroph_core_events_LearningEvent_;
		}

		static void n_FireLearningEvent_Lorg_neuroph_core_events_LearningEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Core.Learning.LearningRule __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.LearningRule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Core.Events.LearningEvent p0 = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Events.LearningEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.FireLearningEvent (p0);
		}
#pragma warning restore 0169

		static IntPtr id_fireLearningEvent_Lorg_neuroph_core_events_LearningEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='LearningRule']/method[@name='fireLearningEvent' and count(parameter)=1 and parameter[1][@type='org.neuroph.core.events.LearningEvent']]"
		[Register ("fireLearningEvent", "(Lorg/neuroph/core/events/LearningEvent;)V", "GetFireLearningEvent_Lorg_neuroph_core_events_LearningEvent_Handler")]
		protected virtual unsafe void FireLearningEvent (global::Org.Neuroph.Core.Events.LearningEvent p0)
		{
			if (id_fireLearningEvent_Lorg_neuroph_core_events_LearningEvent_ == IntPtr.Zero)
				id_fireLearningEvent_Lorg_neuroph_core_events_LearningEvent_ = JNIEnv.GetMethodID (class_ref, "fireLearningEvent", "(Lorg/neuroph/core/events/LearningEvent;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_fireLearningEvent_Lorg_neuroph_core_events_LearningEvent_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "fireLearningEvent", "(Lorg/neuroph/core/events/LearningEvent;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_learn_Lorg_neuroph_core_learning_DataSet_;
#pragma warning disable 0169
		static Delegate GetLearn_Lorg_neuroph_core_learning_DataSet_Handler ()
		{
			if (cb_learn_Lorg_neuroph_core_learning_DataSet_ == null)
				cb_learn_Lorg_neuroph_core_learning_DataSet_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Learn_Lorg_neuroph_core_learning_DataSet_);
			return cb_learn_Lorg_neuroph_core_learning_DataSet_;
		}

		static void n_Learn_Lorg_neuroph_core_learning_DataSet_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Core.Learning.LearningRule __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.LearningRule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Core.Learning.DataSet p0 = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.DataSet> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Learn (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='LearningRule']/method[@name='learn' and count(parameter)=1 and parameter[1][@type='org.neuroph.core.learning.DataSet']]"
		[Register ("learn", "(Lorg/neuroph/core/learning/DataSet;)V", "GetLearn_Lorg_neuroph_core_learning_DataSet_Handler")]
		public abstract void Learn (global::Org.Neuroph.Core.Learning.DataSet p0);

		static Delegate cb_onStart;
#pragma warning disable 0169
		static Delegate GetOnStartHandler ()
		{
			if (cb_onStart == null)
				cb_onStart = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnStart);
			return cb_onStart;
		}

		static void n_OnStart (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Core.Learning.LearningRule __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.LearningRule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnStart ();
		}
#pragma warning restore 0169

		static IntPtr id_onStart;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='LearningRule']/method[@name='onStart' and count(parameter)=0]"
		[Register ("onStart", "()V", "GetOnStartHandler")]
		protected virtual unsafe void OnStart ()
		{
			if (id_onStart == IntPtr.Zero)
				id_onStart = JNIEnv.GetMethodID (class_ref, "onStart", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onStart);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onStart", "()V"));
			} finally {
			}
		}

		static Delegate cb_removeListener_Lorg_neuroph_core_events_LearningEventListener_;
#pragma warning disable 0169
		static Delegate GetRemoveListener_Lorg_neuroph_core_events_LearningEventListener_Handler ()
		{
			if (cb_removeListener_Lorg_neuroph_core_events_LearningEventListener_ == null)
				cb_removeListener_Lorg_neuroph_core_events_LearningEventListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveListener_Lorg_neuroph_core_events_LearningEventListener_);
			return cb_removeListener_Lorg_neuroph_core_events_LearningEventListener_;
		}

		static void n_RemoveListener_Lorg_neuroph_core_events_LearningEventListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Core.Learning.LearningRule __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.LearningRule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Core.Events.ILearningEventListener p0 = (global::Org.Neuroph.Core.Events.ILearningEventListener)global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Events.ILearningEventListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeListener_Lorg_neuroph_core_events_LearningEventListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='LearningRule']/method[@name='removeListener' and count(parameter)=1 and parameter[1][@type='org.neuroph.core.events.LearningEventListener']]"
		[Register ("removeListener", "(Lorg/neuroph/core/events/LearningEventListener;)V", "GetRemoveListener_Lorg_neuroph_core_events_LearningEventListener_Handler")]
		public virtual unsafe void RemoveListener (global::Org.Neuroph.Core.Events.ILearningEventListener p0)
		{
			if (id_removeListener_Lorg_neuroph_core_events_LearningEventListener_ == IntPtr.Zero)
				id_removeListener_Lorg_neuroph_core_events_LearningEventListener_ = JNIEnv.GetMethodID (class_ref, "removeListener", "(Lorg/neuroph/core/events/LearningEventListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_removeListener_Lorg_neuroph_core_events_LearningEventListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeListener", "(Lorg/neuroph/core/events/LearningEventListener;)V"), __args);
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
					JNIEnv.CallVoidMethod  (Handle, id_stopLearning);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stopLearning", "()V"));
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

		static IntPtr id_learn_Lorg_neuroph_core_learning_DataSet_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='LearningRule']/method[@name='learn' and count(parameter)=1 and parameter[1][@type='org.neuroph.core.learning.DataSet']]"
		[Register ("learn", "(Lorg/neuroph/core/learning/DataSet;)V", "GetLearn_Lorg_neuroph_core_learning_DataSet_Handler")]
		public override unsafe void Learn (global::Org.Neuroph.Core.Learning.DataSet p0)
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

	}

}