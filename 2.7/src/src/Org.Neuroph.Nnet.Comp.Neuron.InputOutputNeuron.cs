using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Nnet.Comp.Neuron {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.nnet.comp.neuron']/class[@name='InputOutputNeuron']"
	[global::Android.Runtime.Register ("org/neuroph/nnet/comp/neuron/InputOutputNeuron", DoNotGenerateAcw=true)]
	public partial class InputOutputNeuron : global::Org.Neuroph.Core.Neuron {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/nnet/comp/neuron/InputOutputNeuron", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (InputOutputNeuron); }
		}

		protected InputOutputNeuron (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.nnet.comp.neuron']/class[@name='InputOutputNeuron']/constructor[@name='InputOutputNeuron' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe InputOutputNeuron ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (InputOutputNeuron)) {
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

		static IntPtr id_ctor_Lorg_neuroph_core_input_InputFunction_Lorg_neuroph_core_transfer_TransferFunction_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.nnet.comp.neuron']/class[@name='InputOutputNeuron']/constructor[@name='InputOutputNeuron' and count(parameter)=2 and parameter[1][@type='org.neuroph.core.input.InputFunction'] and parameter[2][@type='org.neuroph.core.transfer.TransferFunction']]"
		[Register (".ctor", "(Lorg/neuroph/core/input/InputFunction;Lorg/neuroph/core/transfer/TransferFunction;)V", "")]
		public unsafe InputOutputNeuron (global::Org.Neuroph.Core.Input.InputFunction p0, global::Org.Neuroph.Core.Transfer.TransferFunction p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (InputOutputNeuron)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/neuroph/core/input/InputFunction;Lorg/neuroph/core/transfer/TransferFunction;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorg/neuroph/core/input/InputFunction;Lorg/neuroph/core/transfer/TransferFunction;)V", __args);
					return;
				}

				if (id_ctor_Lorg_neuroph_core_input_InputFunction_Lorg_neuroph_core_transfer_TransferFunction_ == IntPtr.Zero)
					id_ctor_Lorg_neuroph_core_input_InputFunction_Lorg_neuroph_core_transfer_TransferFunction_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/neuroph/core/input/InputFunction;Lorg/neuroph/core/transfer/TransferFunction;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_neuroph_core_input_InputFunction_Lorg_neuroph_core_transfer_TransferFunction_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_neuroph_core_input_InputFunction_Lorg_neuroph_core_transfer_TransferFunction_, __args);
			} finally {
			}
		}

		static Delegate cb_getBias;
#pragma warning disable 0169
		static Delegate GetGetBiasHandler ()
		{
			if (cb_getBias == null)
				cb_getBias = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetBias);
			return cb_getBias;
		}

		static double n_GetBias (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Nnet.Comp.Neuron.InputOutputNeuron __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Comp.Neuron.InputOutputNeuron> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Bias;
		}
#pragma warning restore 0169

		static Delegate cb_setBias_D;
#pragma warning disable 0169
		static Delegate GetSetBias_DHandler ()
		{
			if (cb_setBias_D == null)
				cb_setBias_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetBias_D);
			return cb_setBias_D;
		}

		static void n_SetBias_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Org.Neuroph.Nnet.Comp.Neuron.InputOutputNeuron __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Comp.Neuron.InputOutputNeuron> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Bias = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getBias;
		static IntPtr id_setBias_D;
		public virtual unsafe double Bias {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.comp.neuron']/class[@name='InputOutputNeuron']/method[@name='getBias' and count(parameter)=0]"
			[Register ("getBias", "()D", "GetGetBiasHandler")]
			get {
				if (id_getBias == IntPtr.Zero)
					id_getBias = JNIEnv.GetMethodID (class_ref, "getBias", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod  (Handle, id_getBias);
					else
						return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBias", "()D"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.comp.neuron']/class[@name='InputOutputNeuron']/method[@name='setBias' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setBias", "(D)V", "GetSetBias_DHandler")]
			set {
				if (id_setBias_D == IntPtr.Zero)
					id_setBias_D = JNIEnv.GetMethodID (class_ref, "setBias", "(D)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setBias_D, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBias", "(D)V"), __args);
				} finally {
				}
			}
		}

	}
}
