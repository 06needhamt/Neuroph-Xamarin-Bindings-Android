using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Nnet.Comp {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.nnet.comp']/class[@name='CompetitiveNeuron']"
	[global::Android.Runtime.Register ("org/neuroph/nnet/comp/CompetitiveNeuron", DoNotGenerateAcw=true)]
	public partial class CompetitiveNeuron : global::Org.Neuroph.Nnet.Comp.DelayedNeuron {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/nnet/comp/CompetitiveNeuron", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CompetitiveNeuron); }
		}

		protected CompetitiveNeuron (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_neuroph_core_input_InputFunction_Lorg_neuroph_core_transfer_TransferFunction_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.nnet.comp']/class[@name='CompetitiveNeuron']/constructor[@name='CompetitiveNeuron' and count(parameter)=2 and parameter[1][@type='org.neuroph.core.input.InputFunction'] and parameter[2][@type='org.neuroph.core.transfer.TransferFunction']]"
		[Register (".ctor", "(Lorg/neuroph/core/input/InputFunction;Lorg/neuroph/core/transfer/TransferFunction;)V", "")]
		public unsafe CompetitiveNeuron (global::Org.Neuroph.Core.Input.InputFunction p0, global::Org.Neuroph.Core.Transfer.TransferFunction p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (CompetitiveNeuron)) {
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

		static Delegate cb_getConnectionsFromOtherLayers;
#pragma warning disable 0169
		static Delegate GetGetConnectionsFromOtherLayersHandler ()
		{
			if (cb_getConnectionsFromOtherLayers == null)
				cb_getConnectionsFromOtherLayers = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetConnectionsFromOtherLayers);
			return cb_getConnectionsFromOtherLayers;
		}

		static IntPtr n_GetConnectionsFromOtherLayers (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Nnet.Comp.CompetitiveNeuron __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Comp.CompetitiveNeuron> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ConnectionsFromOtherLayers);
		}
#pragma warning restore 0169

		static IntPtr id_getConnectionsFromOtherLayers;
		public virtual unsafe global::Java.Util.Vector ConnectionsFromOtherLayers {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.comp']/class[@name='CompetitiveNeuron']/method[@name='getConnectionsFromOtherLayers' and count(parameter)=0]"
			[Register ("getConnectionsFromOtherLayers", "()Ljava/util/Vector;", "GetGetConnectionsFromOtherLayersHandler")]
			get {
				if (id_getConnectionsFromOtherLayers == IntPtr.Zero)
					id_getConnectionsFromOtherLayers = JNIEnv.GetMethodID (class_ref, "getConnectionsFromOtherLayers", "()Ljava/util/Vector;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Util.Vector> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getConnectionsFromOtherLayers), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Util.Vector> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getConnectionsFromOtherLayers", "()Ljava/util/Vector;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isCompeting;
#pragma warning disable 0169
		static Delegate GetIsCompetingHandler ()
		{
			if (cb_isCompeting == null)
				cb_isCompeting = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsCompeting);
			return cb_isCompeting;
		}

		static bool n_IsCompeting (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Nnet.Comp.CompetitiveNeuron __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Comp.CompetitiveNeuron> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsCompeting;
		}
#pragma warning restore 0169

		static Delegate cb_setIsCompeting_Z;
#pragma warning disable 0169
		static Delegate GetSetIsCompeting_ZHandler ()
		{
			if (cb_setIsCompeting_Z == null)
				cb_setIsCompeting_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetIsCompeting_Z);
			return cb_setIsCompeting_Z;
		}

		static void n_SetIsCompeting_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Org.Neuroph.Nnet.Comp.CompetitiveNeuron __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Comp.CompetitiveNeuron> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.IsCompeting = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isCompeting;
		static IntPtr id_setIsCompeting_Z;
		public virtual unsafe bool IsCompeting {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.comp']/class[@name='CompetitiveNeuron']/method[@name='isCompeting' and count(parameter)=0]"
			[Register ("isCompeting", "()Z", "GetIsCompetingHandler")]
			get {
				if (id_isCompeting == IntPtr.Zero)
					id_isCompeting = JNIEnv.GetMethodID (class_ref, "isCompeting", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isCompeting);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isCompeting", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.comp']/class[@name='CompetitiveNeuron']/method[@name='setIsCompeting' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setIsCompeting", "(Z)V", "GetSetIsCompeting_ZHandler")]
			set {
				if (id_setIsCompeting_Z == IntPtr.Zero)
					id_setIsCompeting_Z = JNIEnv.GetMethodID (class_ref, "setIsCompeting", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setIsCompeting_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setIsCompeting", "(Z)V"), __args);
				} finally {
				}
			}
		}

	}
}
