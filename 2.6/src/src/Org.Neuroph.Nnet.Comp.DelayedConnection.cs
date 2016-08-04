using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Nnet.Comp {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.nnet.comp']/class[@name='DelayedConnection']"
	[global::Android.Runtime.Register ("org/neuroph/nnet/comp/DelayedConnection", DoNotGenerateAcw=true)]
	public partial class DelayedConnection : global::Org.Neuroph.Core.Connection {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/nnet/comp/DelayedConnection", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DelayedConnection); }
		}

		protected DelayedConnection (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_neuroph_core_Neuron_Lorg_neuroph_core_Neuron_DI;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.nnet.comp']/class[@name='DelayedConnection']/constructor[@name='DelayedConnection' and count(parameter)=4 and parameter[1][@type='org.neuroph.core.Neuron'] and parameter[2][@type='org.neuroph.core.Neuron'] and parameter[3][@type='double'] and parameter[4][@type='int']]"
		[Register (".ctor", "(Lorg/neuroph/core/Neuron;Lorg/neuroph/core/Neuron;DI)V", "")]
		public unsafe DelayedConnection (global::Org.Neuroph.Core.Neuron p0, global::Org.Neuroph.Core.Neuron p1, double p2, int p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				if (GetType () != typeof (DelayedConnection)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/neuroph/core/Neuron;Lorg/neuroph/core/Neuron;DI)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorg/neuroph/core/Neuron;Lorg/neuroph/core/Neuron;DI)V", __args);
					return;
				}

				if (id_ctor_Lorg_neuroph_core_Neuron_Lorg_neuroph_core_Neuron_DI == IntPtr.Zero)
					id_ctor_Lorg_neuroph_core_Neuron_Lorg_neuroph_core_Neuron_DI = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/neuroph/core/Neuron;Lorg/neuroph/core/Neuron;DI)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_neuroph_core_Neuron_Lorg_neuroph_core_Neuron_DI, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_neuroph_core_Neuron_Lorg_neuroph_core_Neuron_DI, __args);
			} finally {
			}
		}

		static Delegate cb_getDelay;
#pragma warning disable 0169
		static Delegate GetGetDelayHandler ()
		{
			if (cb_getDelay == null)
				cb_getDelay = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDelay);
			return cb_getDelay;
		}

		static int n_GetDelay (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Nnet.Comp.DelayedConnection __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Comp.DelayedConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Delay;
		}
#pragma warning restore 0169

		static Delegate cb_setDelay_I;
#pragma warning disable 0169
		static Delegate GetSetDelay_IHandler ()
		{
			if (cb_setDelay_I == null)
				cb_setDelay_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetDelay_I);
			return cb_setDelay_I;
		}

		static void n_SetDelay_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Neuroph.Nnet.Comp.DelayedConnection __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Comp.DelayedConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Delay = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDelay;
		static IntPtr id_setDelay_I;
		public virtual unsafe int Delay {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.comp']/class[@name='DelayedConnection']/method[@name='getDelay' and count(parameter)=0]"
			[Register ("getDelay", "()I", "GetGetDelayHandler")]
			get {
				if (id_getDelay == IntPtr.Zero)
					id_getDelay = JNIEnv.GetMethodID (class_ref, "getDelay", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getDelay);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDelay", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.comp']/class[@name='DelayedConnection']/method[@name='setDelay' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setDelay", "(I)V", "GetSetDelay_IHandler")]
			set {
				if (id_setDelay_I == IntPtr.Zero)
					id_setDelay_I = JNIEnv.GetMethodID (class_ref, "setDelay", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setDelay_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDelay", "(I)V"), __args);
				} finally {
				}
			}
		}

	}
}
