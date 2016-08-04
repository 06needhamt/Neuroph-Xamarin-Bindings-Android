using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Samples.Uci {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.samples.uci']/class[@name='WineClassificationSample']"
	[global::Android.Runtime.Register ("org/neuroph/samples/uci/WineClassificationSample", DoNotGenerateAcw=true)]
	public partial class WineClassificationSample : global::Java.Lang.Object, global::Org.Neuroph.Core.Events.ILearningEventListener {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/samples/uci/WineClassificationSample", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (WineClassificationSample); }
		}

		protected WineClassificationSample (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.samples.uci']/class[@name='WineClassificationSample']/constructor[@name='WineClassificationSample' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe WineClassificationSample ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (WineClassificationSample)) {
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

		static Delegate cb_handleLearningEvent_Lorg_neuroph_core_events_LearningEvent_;
#pragma warning disable 0169
		static Delegate GetHandleLearningEvent_Lorg_neuroph_core_events_LearningEvent_Handler ()
		{
			if (cb_handleLearningEvent_Lorg_neuroph_core_events_LearningEvent_ == null)
				cb_handleLearningEvent_Lorg_neuroph_core_events_LearningEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_HandleLearningEvent_Lorg_neuroph_core_events_LearningEvent_);
			return cb_handleLearningEvent_Lorg_neuroph_core_events_LearningEvent_;
		}

		static void n_HandleLearningEvent_Lorg_neuroph_core_events_LearningEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Samples.Uci.WineClassificationSample __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Samples.Uci.WineClassificationSample> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Core.Events.LearningEvent p0 = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Events.LearningEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.HandleLearningEvent (p0);
		}
#pragma warning restore 0169

		static IntPtr id_handleLearningEvent_Lorg_neuroph_core_events_LearningEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.samples.uci']/class[@name='WineClassificationSample']/method[@name='handleLearningEvent' and count(parameter)=1 and parameter[1][@type='org.neuroph.core.events.LearningEvent']]"
		[Register ("handleLearningEvent", "(Lorg/neuroph/core/events/LearningEvent;)V", "GetHandleLearningEvent_Lorg_neuroph_core_events_LearningEvent_Handler")]
		public virtual unsafe void HandleLearningEvent (global::Org.Neuroph.Core.Events.LearningEvent p0)
		{
			if (id_handleLearningEvent_Lorg_neuroph_core_events_LearningEvent_ == IntPtr.Zero)
				id_handleLearningEvent_Lorg_neuroph_core_events_LearningEvent_ = JNIEnv.GetMethodID (class_ref, "handleLearningEvent", "(Lorg/neuroph/core/events/LearningEvent;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_handleLearningEvent_Lorg_neuroph_core_events_LearningEvent_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "handleLearningEvent", "(Lorg/neuroph/core/events/LearningEvent;)V"), __args);
			} finally {
			}
		}

		static IntPtr id_main_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.samples.uci']/class[@name='WineClassificationSample']/method[@name='main' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register ("main", "([Ljava/lang/String;)V", "")]
		public static unsafe void Main (string[] p0)
		{
			if (id_main_arrayLjava_lang_String_ == IntPtr.Zero)
				id_main_arrayLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "main", "([Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_main_arrayLjava_lang_String_, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
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
			global::Org.Neuroph.Samples.Uci.WineClassificationSample __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Samples.Uci.WineClassificationSample> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Run ();
		}
#pragma warning restore 0169

		static IntPtr id_run;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.samples.uci']/class[@name='WineClassificationSample']/method[@name='run' and count(parameter)=0]"
		[Register ("run", "()V", "GetRunHandler")]
		public virtual unsafe void Run ()
		{
			if (id_run == IntPtr.Zero)
				id_run = JNIEnv.GetMethodID (class_ref, "run", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_run);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "run", "()V"));
			} finally {
			}
		}

		static Delegate cb_testNeuralNetwork_Lorg_neuroph_core_NeuralNetwork_Lorg_neuroph_core_data_DataSet_;
#pragma warning disable 0169
		static Delegate GetTestNeuralNetwork_Lorg_neuroph_core_NeuralNetwork_Lorg_neuroph_core_data_DataSet_Handler ()
		{
			if (cb_testNeuralNetwork_Lorg_neuroph_core_NeuralNetwork_Lorg_neuroph_core_data_DataSet_ == null)
				cb_testNeuralNetwork_Lorg_neuroph_core_NeuralNetwork_Lorg_neuroph_core_data_DataSet_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_TestNeuralNetwork_Lorg_neuroph_core_NeuralNetwork_Lorg_neuroph_core_data_DataSet_);
			return cb_testNeuralNetwork_Lorg_neuroph_core_NeuralNetwork_Lorg_neuroph_core_data_DataSet_;
		}

		static void n_TestNeuralNetwork_Lorg_neuroph_core_NeuralNetwork_Lorg_neuroph_core_data_DataSet_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Neuroph.Samples.Uci.WineClassificationSample __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Samples.Uci.WineClassificationSample> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Core.NeuralNetwork p0 = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.NeuralNetwork> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Core.Data.DataSet p1 = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Data.DataSet> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.TestNeuralNetwork (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_testNeuralNetwork_Lorg_neuroph_core_NeuralNetwork_Lorg_neuroph_core_data_DataSet_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.samples.uci']/class[@name='WineClassificationSample']/method[@name='testNeuralNetwork' and count(parameter)=2 and parameter[1][@type='org.neuroph.core.NeuralNetwork'] and parameter[2][@type='org.neuroph.core.data.DataSet']]"
		[Register ("testNeuralNetwork", "(Lorg/neuroph/core/NeuralNetwork;Lorg/neuroph/core/data/DataSet;)V", "GetTestNeuralNetwork_Lorg_neuroph_core_NeuralNetwork_Lorg_neuroph_core_data_DataSet_Handler")]
		public virtual unsafe void TestNeuralNetwork (global::Org.Neuroph.Core.NeuralNetwork p0, global::Org.Neuroph.Core.Data.DataSet p1)
		{
			if (id_testNeuralNetwork_Lorg_neuroph_core_NeuralNetwork_Lorg_neuroph_core_data_DataSet_ == IntPtr.Zero)
				id_testNeuralNetwork_Lorg_neuroph_core_NeuralNetwork_Lorg_neuroph_core_data_DataSet_ = JNIEnv.GetMethodID (class_ref, "testNeuralNetwork", "(Lorg/neuroph/core/NeuralNetwork;Lorg/neuroph/core/data/DataSet;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_testNeuralNetwork_Lorg_neuroph_core_NeuralNetwork_Lorg_neuroph_core_data_DataSet_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "testNeuralNetwork", "(Lorg/neuroph/core/NeuralNetwork;Lorg/neuroph/core/data/DataSet;)V"), __args);
			} finally {
			}
		}

	}
}
