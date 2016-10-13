using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Nnet.Learning {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.nnet.learning']/class[@name='BackPropagation']"
	[global::Android.Runtime.Register ("org/neuroph/nnet/learning/BackPropagation", DoNotGenerateAcw=true)]
	public partial class BackPropagation : global::Org.Neuroph.Nnet.Learning.SigmoidDeltaRule {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/nnet/learning/BackPropagation", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BackPropagation); }
		}

		protected BackPropagation (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.nnet.learning']/class[@name='BackPropagation']/constructor[@name='BackPropagation' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BackPropagation ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (BackPropagation)) {
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

		static Delegate cb_calculateErrorAndUpdateHiddenNeurons;
#pragma warning disable 0169
		static Delegate GetCalculateErrorAndUpdateHiddenNeuronsHandler ()
		{
			if (cb_calculateErrorAndUpdateHiddenNeurons == null)
				cb_calculateErrorAndUpdateHiddenNeurons = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CalculateErrorAndUpdateHiddenNeurons);
			return cb_calculateErrorAndUpdateHiddenNeurons;
		}

		static void n_CalculateErrorAndUpdateHiddenNeurons (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Nnet.Learning.BackPropagation __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Learning.BackPropagation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CalculateErrorAndUpdateHiddenNeurons ();
		}
#pragma warning restore 0169

		static IntPtr id_calculateErrorAndUpdateHiddenNeurons;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.learning']/class[@name='BackPropagation']/method[@name='calculateErrorAndUpdateHiddenNeurons' and count(parameter)=0]"
		[Register ("calculateErrorAndUpdateHiddenNeurons", "()V", "GetCalculateErrorAndUpdateHiddenNeuronsHandler")]
		protected virtual unsafe void CalculateErrorAndUpdateHiddenNeurons ()
		{
			if (id_calculateErrorAndUpdateHiddenNeurons == IntPtr.Zero)
				id_calculateErrorAndUpdateHiddenNeurons = JNIEnv.GetMethodID (class_ref, "calculateErrorAndUpdateHiddenNeurons", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_calculateErrorAndUpdateHiddenNeurons);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "calculateErrorAndUpdateHiddenNeurons", "()V"));
			} finally {
			}
		}

		static Delegate cb_calculateHiddenNeuronError_Lorg_neuroph_core_Neuron_;
#pragma warning disable 0169
		static Delegate GetCalculateHiddenNeuronError_Lorg_neuroph_core_Neuron_Handler ()
		{
			if (cb_calculateHiddenNeuronError_Lorg_neuroph_core_Neuron_ == null)
				cb_calculateHiddenNeuronError_Lorg_neuroph_core_Neuron_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, double>) n_CalculateHiddenNeuronError_Lorg_neuroph_core_Neuron_);
			return cb_calculateHiddenNeuronError_Lorg_neuroph_core_Neuron_;
		}

		static double n_CalculateHiddenNeuronError_Lorg_neuroph_core_Neuron_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Nnet.Learning.BackPropagation __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Learning.BackPropagation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Core.Neuron p0 = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Neuron> (native_p0, JniHandleOwnership.DoNotTransfer);
			double __ret = __this.CalculateHiddenNeuronError (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_calculateHiddenNeuronError_Lorg_neuroph_core_Neuron_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.learning']/class[@name='BackPropagation']/method[@name='calculateHiddenNeuronError' and count(parameter)=1 and parameter[1][@type='org.neuroph.core.Neuron']]"
		[Register ("calculateHiddenNeuronError", "(Lorg/neuroph/core/Neuron;)D", "GetCalculateHiddenNeuronError_Lorg_neuroph_core_Neuron_Handler")]
		protected virtual unsafe double CalculateHiddenNeuronError (global::Org.Neuroph.Core.Neuron p0)
		{
			if (id_calculateHiddenNeuronError_Lorg_neuroph_core_Neuron_ == IntPtr.Zero)
				id_calculateHiddenNeuronError_Lorg_neuroph_core_Neuron_ = JNIEnv.GetMethodID (class_ref, "calculateHiddenNeuronError", "(Lorg/neuroph/core/Neuron;)D");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				double __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_calculateHiddenNeuronError_Lorg_neuroph_core_Neuron_, __args);
				else
					__ret = JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "calculateHiddenNeuronError", "(Lorg/neuroph/core/Neuron;)D"), __args);
				return __ret;
			} finally {
			}
		}

	}
}
