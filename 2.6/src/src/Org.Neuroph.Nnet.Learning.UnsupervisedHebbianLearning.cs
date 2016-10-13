using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Nnet.Learning {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.nnet.learning']/class[@name='UnsupervisedHebbianLearning']"
	[global::Android.Runtime.Register ("org/neuroph/nnet/learning/UnsupervisedHebbianLearning", DoNotGenerateAcw=true)]
	public partial class UnsupervisedHebbianLearning : global::Org.Neuroph.Core.Learning.UnsupervisedLearning {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/nnet/learning/UnsupervisedHebbianLearning", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UnsupervisedHebbianLearning); }
		}

		protected UnsupervisedHebbianLearning (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.nnet.learning']/class[@name='UnsupervisedHebbianLearning']/constructor[@name='UnsupervisedHebbianLearning' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe UnsupervisedHebbianLearning ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (UnsupervisedHebbianLearning)) {
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

		static Delegate cb_updateNetworkWeights;
#pragma warning disable 0169
		static Delegate GetUpdateNetworkWeightsHandler ()
		{
			if (cb_updateNetworkWeights == null)
				cb_updateNetworkWeights = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_UpdateNetworkWeights);
			return cb_updateNetworkWeights;
		}

		static void n_UpdateNetworkWeights (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Nnet.Learning.UnsupervisedHebbianLearning __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Learning.UnsupervisedHebbianLearning> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UpdateNetworkWeights ();
		}
#pragma warning restore 0169

		static IntPtr id_updateNetworkWeights;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.learning']/class[@name='UnsupervisedHebbianLearning']/method[@name='updateNetworkWeights' and count(parameter)=0]"
		[Register ("updateNetworkWeights", "()V", "GetUpdateNetworkWeightsHandler")]
		protected override unsafe void UpdateNetworkWeights ()
		{
			if (id_updateNetworkWeights == IntPtr.Zero)
				id_updateNetworkWeights = JNIEnv.GetMethodID (class_ref, "updateNetworkWeights", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateNetworkWeights);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateNetworkWeights", "()V"));
			} finally {
			}
		}

		static Delegate cb_updateNeuronWeights_Lorg_neuroph_core_Neuron_;
#pragma warning disable 0169
		static Delegate GetUpdateNeuronWeights_Lorg_neuroph_core_Neuron_Handler ()
		{
			if (cb_updateNeuronWeights_Lorg_neuroph_core_Neuron_ == null)
				cb_updateNeuronWeights_Lorg_neuroph_core_Neuron_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UpdateNeuronWeights_Lorg_neuroph_core_Neuron_);
			return cb_updateNeuronWeights_Lorg_neuroph_core_Neuron_;
		}

		static void n_UpdateNeuronWeights_Lorg_neuroph_core_Neuron_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Nnet.Learning.UnsupervisedHebbianLearning __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Learning.UnsupervisedHebbianLearning> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Core.Neuron p0 = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Neuron> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UpdateNeuronWeights (p0);
		}
#pragma warning restore 0169

		static IntPtr id_updateNeuronWeights_Lorg_neuroph_core_Neuron_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.learning']/class[@name='UnsupervisedHebbianLearning']/method[@name='updateNeuronWeights' and count(parameter)=1 and parameter[1][@type='org.neuroph.core.Neuron']]"
		[Register ("updateNeuronWeights", "(Lorg/neuroph/core/Neuron;)V", "GetUpdateNeuronWeights_Lorg_neuroph_core_Neuron_Handler")]
		protected virtual unsafe void UpdateNeuronWeights (global::Org.Neuroph.Core.Neuron p0)
		{
			if (id_updateNeuronWeights_Lorg_neuroph_core_Neuron_ == IntPtr.Zero)
				id_updateNeuronWeights_Lorg_neuroph_core_Neuron_ = JNIEnv.GetMethodID (class_ref, "updateNeuronWeights", "(Lorg/neuroph/core/Neuron;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateNeuronWeights_Lorg_neuroph_core_Neuron_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateNeuronWeights", "(Lorg/neuroph/core/Neuron;)V"), __args);
			} finally {
			}
		}

	}
}
