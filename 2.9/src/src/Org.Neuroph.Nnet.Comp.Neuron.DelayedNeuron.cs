using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Nnet.Comp.Neuron {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.nnet.comp.neuron']/class[@name='DelayedNeuron']"
	[global::Android.Runtime.Register ("org/neuroph/nnet/comp/neuron/DelayedNeuron", DoNotGenerateAcw=true)]
	public partial class DelayedNeuron : global::Org.Neuroph.Core.Neuron {


		static IntPtr outputHistory_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.neuroph.nnet.comp.neuron']/class[@name='DelayedNeuron']/field[@name='outputHistory']"
		[Register ("outputHistory")]
		protected global::System.Collections.IList OutputHistory {
			get {
				if (outputHistory_jfieldId == IntPtr.Zero)
					outputHistory_jfieldId = JNIEnv.GetFieldID (class_ref, "outputHistory", "Ljava/util/List;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, outputHistory_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (outputHistory_jfieldId == IntPtr.Zero)
					outputHistory_jfieldId = JNIEnv.GetFieldID (class_ref, "outputHistory", "Ljava/util/List;");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, outputHistory_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/nnet/comp/neuron/DelayedNeuron", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DelayedNeuron); }
		}

		protected DelayedNeuron (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_neuroph_core_input_InputFunction_Lorg_neuroph_core_transfer_TransferFunction_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.nnet.comp.neuron']/class[@name='DelayedNeuron']/constructor[@name='DelayedNeuron' and count(parameter)=2 and parameter[1][@type='org.neuroph.core.input.InputFunction'] and parameter[2][@type='org.neuroph.core.transfer.TransferFunction']]"
		[Register (".ctor", "(Lorg/neuroph/core/input/InputFunction;Lorg/neuroph/core/transfer/TransferFunction;)V", "")]
		public unsafe DelayedNeuron (global::Org.Neuroph.Core.Input.InputFunction p0, global::Org.Neuroph.Core.Transfer.TransferFunction p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (DelayedNeuron)) {
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

		static Delegate cb_getOutput_I;
#pragma warning disable 0169
		static Delegate GetGetOutput_IHandler ()
		{
			if (cb_getOutput_I == null)
				cb_getOutput_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, double>) n_GetOutput_I);
			return cb_getOutput_I;
		}

		static double n_GetOutput_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Neuroph.Nnet.Comp.Neuron.DelayedNeuron __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Comp.Neuron.DelayedNeuron> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetOutput (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getOutput_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.comp.neuron']/class[@name='DelayedNeuron']/method[@name='getOutput' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getOutput", "(I)D", "GetGetOutput_IHandler")]
		public virtual unsafe double GetOutput (int p0)
		{
			if (id_getOutput_I == IntPtr.Zero)
				id_getOutput_I = JNIEnv.GetMethodID (class_ref, "getOutput", "(I)D");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.CallDoubleMethod  (Handle, id_getOutput_I, __args);
				else
					return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOutput", "(I)D"), __args);
			} finally {
			}
		}

	}
}
