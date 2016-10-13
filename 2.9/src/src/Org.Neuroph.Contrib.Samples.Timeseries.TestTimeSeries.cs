using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Contrib.Samples.Timeseries {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.contrib.samples.timeseries']/class[@name='TestTimeSeries']"
	[global::Android.Runtime.Register ("org/neuroph/contrib/samples/timeseries/TestTimeSeries", DoNotGenerateAcw=true)]
	public partial class TestTimeSeries : global::Java.Lang.Object, global::Org.Neuroph.Core.Events.ILearningEventListener {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/contrib/samples/timeseries/TestTimeSeries", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TestTimeSeries); }
		}

		protected TestTimeSeries (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.contrib.samples.timeseries']/class[@name='TestTimeSeries']/constructor[@name='TestTimeSeries' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TestTimeSeries ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (TestTimeSeries)) {
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
			global::Org.Neuroph.Contrib.Samples.Timeseries.TestTimeSeries __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.Samples.Timeseries.TestTimeSeries> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Core.Events.LearningEvent p0 = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Events.LearningEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.HandleLearningEvent (p0);
		}
#pragma warning restore 0169

		static IntPtr id_handleLearningEvent_Lorg_neuroph_core_events_LearningEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.contrib.samples.timeseries']/class[@name='TestTimeSeries']/method[@name='handleLearningEvent' and count(parameter)=1 and parameter[1][@type='org.neuroph.core.events.LearningEvent']]"
		[Register ("handleLearningEvent", "(Lorg/neuroph/core/events/LearningEvent;)V", "GetHandleLearningEvent_Lorg_neuroph_core_events_LearningEvent_Handler")]
		public virtual unsafe void HandleLearningEvent (global::Org.Neuroph.Core.Events.LearningEvent p0)
		{
			if (id_handleLearningEvent_Lorg_neuroph_core_events_LearningEvent_ == IntPtr.Zero)
				id_handleLearningEvent_Lorg_neuroph_core_events_LearningEvent_ = JNIEnv.GetMethodID (class_ref, "handleLearningEvent", "(Lorg/neuroph/core/events/LearningEvent;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_handleLearningEvent_Lorg_neuroph_core_events_LearningEvent_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "handleLearningEvent", "(Lorg/neuroph/core/events/LearningEvent;)V"), __args);
			} finally {
			}
		}

		static IntPtr id_main_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.contrib.samples.timeseries']/class[@name='TestTimeSeries']/method[@name='main' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
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

		static Delegate cb_testNeuralNetwork;
#pragma warning disable 0169
		static Delegate GetTestNeuralNetworkHandler ()
		{
			if (cb_testNeuralNetwork == null)
				cb_testNeuralNetwork = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_TestNeuralNetwork);
			return cb_testNeuralNetwork;
		}

		static void n_TestNeuralNetwork (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Contrib.Samples.Timeseries.TestTimeSeries __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.Samples.Timeseries.TestTimeSeries> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TestNeuralNetwork ();
		}
#pragma warning restore 0169

		static IntPtr id_testNeuralNetwork;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.contrib.samples.timeseries']/class[@name='TestTimeSeries']/method[@name='testNeuralNetwork' and count(parameter)=0]"
		[Register ("testNeuralNetwork", "()V", "GetTestNeuralNetworkHandler")]
		public virtual unsafe void TestNeuralNetwork ()
		{
			if (id_testNeuralNetwork == IntPtr.Zero)
				id_testNeuralNetwork = JNIEnv.GetMethodID (class_ref, "testNeuralNetwork", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_testNeuralNetwork);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "testNeuralNetwork", "()V"));
			} finally {
			}
		}

		static Delegate cb_train;
#pragma warning disable 0169
		static Delegate GetTrainHandler ()
		{
			if (cb_train == null)
				cb_train = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Train);
			return cb_train;
		}

		static void n_Train (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Contrib.Samples.Timeseries.TestTimeSeries __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.Samples.Timeseries.TestTimeSeries> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Train ();
		}
#pragma warning restore 0169

		static IntPtr id_train;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.contrib.samples.timeseries']/class[@name='TestTimeSeries']/method[@name='train' and count(parameter)=0]"
		[Register ("train", "()V", "GetTrainHandler")]
		public virtual unsafe void Train ()
		{
			if (id_train == IntPtr.Zero)
				id_train = JNIEnv.GetMethodID (class_ref, "train", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_train);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "train", "()V"));
			} finally {
			}
		}

	}
}
