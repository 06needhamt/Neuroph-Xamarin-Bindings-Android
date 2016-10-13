using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Nnet.Learning {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.nnet.learning']/class[@name='SupervisedHebbianLearning']"
	[global::Android.Runtime.Register ("org/neuroph/nnet/learning/SupervisedHebbianLearning", DoNotGenerateAcw=true)]
	public partial class SupervisedHebbianLearning : global::Org.Neuroph.Nnet.Learning.LMS {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/nnet/learning/SupervisedHebbianLearning", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SupervisedHebbianLearning); }
		}

		protected SupervisedHebbianLearning (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.nnet.learning']/class[@name='SupervisedHebbianLearning']/constructor[@name='SupervisedHebbianLearning' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SupervisedHebbianLearning ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (SupervisedHebbianLearning)) {
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

		static Delegate cb_updateNeuronWeights_Lorg_neuroph_core_Neuron_D;
#pragma warning disable 0169
		static Delegate GetUpdateNeuronWeights_Lorg_neuroph_core_Neuron_DHandler ()
		{
			if (cb_updateNeuronWeights_Lorg_neuroph_core_Neuron_D == null)
				cb_updateNeuronWeights_Lorg_neuroph_core_Neuron_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, double>) n_UpdateNeuronWeights_Lorg_neuroph_core_Neuron_D);
			return cb_updateNeuronWeights_Lorg_neuroph_core_Neuron_D;
		}

		static void n_UpdateNeuronWeights_Lorg_neuroph_core_Neuron_D (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, double p1)
		{
			global::Org.Neuroph.Nnet.Learning.SupervisedHebbianLearning __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Learning.SupervisedHebbianLearning> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Core.Neuron p0 = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Neuron> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UpdateNeuronWeights (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_updateNeuronWeights_Lorg_neuroph_core_Neuron_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.learning']/class[@name='SupervisedHebbianLearning']/method[@name='updateNeuronWeights' and count(parameter)=2 and parameter[1][@type='org.neuroph.core.Neuron'] and parameter[2][@type='double']]"
		[Register ("updateNeuronWeights", "(Lorg/neuroph/core/Neuron;D)V", "GetUpdateNeuronWeights_Lorg_neuroph_core_Neuron_DHandler")]
		protected virtual unsafe void UpdateNeuronWeights (global::Org.Neuroph.Core.Neuron p0, double p1)
		{
			if (id_updateNeuronWeights_Lorg_neuroph_core_Neuron_D == IntPtr.Zero)
				id_updateNeuronWeights_Lorg_neuroph_core_Neuron_D = JNIEnv.GetMethodID (class_ref, "updateNeuronWeights", "(Lorg/neuroph/core/Neuron;D)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateNeuronWeights_Lorg_neuroph_core_Neuron_D, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateNeuronWeights", "(Lorg/neuroph/core/Neuron;D)V"), __args);
			} finally {
			}
		}

	}
}
