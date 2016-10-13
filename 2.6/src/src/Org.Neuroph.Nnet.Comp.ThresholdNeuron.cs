using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Nnet.Comp {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.nnet.comp']/class[@name='ThresholdNeuron']"
	[global::Android.Runtime.Register ("org/neuroph/nnet/comp/ThresholdNeuron", DoNotGenerateAcw=true)]
	public partial class ThresholdNeuron : global::Org.Neuroph.Core.Neuron {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/nnet/comp/ThresholdNeuron", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ThresholdNeuron); }
		}

		protected ThresholdNeuron (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_neuroph_core_input_InputFunction_Lorg_neuroph_core_transfer_TransferFunction_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.nnet.comp']/class[@name='ThresholdNeuron']/constructor[@name='ThresholdNeuron' and count(parameter)=2 and parameter[1][@type='org.neuroph.core.input.InputFunction'] and parameter[2][@type='org.neuroph.core.transfer.TransferFunction']]"
		[Register (".ctor", "(Lorg/neuroph/core/input/InputFunction;Lorg/neuroph/core/transfer/TransferFunction;)V", "")]
		public unsafe ThresholdNeuron (global::Org.Neuroph.Core.Input.InputFunction p0, global::Org.Neuroph.Core.Transfer.TransferFunction p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (ThresholdNeuron)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/neuroph/core/input/InputFunction;Lorg/neuroph/core/transfer/TransferFunction;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/neuroph/core/input/InputFunction;Lorg/neuroph/core/transfer/TransferFunction;)V", __args);
					return;
				}

				if (id_ctor_Lorg_neuroph_core_input_InputFunction_Lorg_neuroph_core_transfer_TransferFunction_ == IntPtr.Zero)
					id_ctor_Lorg_neuroph_core_input_InputFunction_Lorg_neuroph_core_transfer_TransferFunction_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/neuroph/core/input/InputFunction;Lorg/neuroph/core/transfer/TransferFunction;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_neuroph_core_input_InputFunction_Lorg_neuroph_core_transfer_TransferFunction_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_neuroph_core_input_InputFunction_Lorg_neuroph_core_transfer_TransferFunction_, __args);
			} finally {
			}
		}

		static Delegate cb_getThresh;
#pragma warning disable 0169
		static Delegate GetGetThreshHandler ()
		{
			if (cb_getThresh == null)
				cb_getThresh = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetThresh);
			return cb_getThresh;
		}

		static double n_GetThresh (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Nnet.Comp.ThresholdNeuron __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Comp.ThresholdNeuron> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Thresh;
		}
#pragma warning restore 0169

		static Delegate cb_setThresh_D;
#pragma warning disable 0169
		static Delegate GetSetThresh_DHandler ()
		{
			if (cb_setThresh_D == null)
				cb_setThresh_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetThresh_D);
			return cb_setThresh_D;
		}

		static void n_SetThresh_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Org.Neuroph.Nnet.Comp.ThresholdNeuron __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Comp.ThresholdNeuron> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Thresh = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getThresh;
		static IntPtr id_setThresh_D;
		public virtual unsafe double Thresh {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.comp']/class[@name='ThresholdNeuron']/method[@name='getThresh' and count(parameter)=0]"
			[Register ("getThresh", "()D", "GetGetThreshHandler")]
			get {
				if (id_getThresh == IntPtr.Zero)
					id_getThresh = JNIEnv.GetMethodID (class_ref, "getThresh", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getThresh);
					else
						return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getThresh", "()D"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.comp']/class[@name='ThresholdNeuron']/method[@name='setThresh' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setThresh", "(D)V", "GetSetThresh_DHandler")]
			set {
				if (id_setThresh_D == IntPtr.Zero)
					id_setThresh_D = JNIEnv.GetMethodID (class_ref, "setThresh", "(D)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setThresh_D, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setThresh", "(D)V"), __args);
				} finally {
				}
			}
		}

	}
}
