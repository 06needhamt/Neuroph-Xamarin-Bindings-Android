using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Nnet.Comp {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.nnet.comp']/class[@name='CompetitiveLayer']"
	[global::Android.Runtime.Register ("org/neuroph/nnet/comp/CompetitiveLayer", DoNotGenerateAcw=true)]
	public partial class CompetitiveLayer : global::Org.Neuroph.Core.Layer {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/nnet/comp/CompetitiveLayer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CompetitiveLayer); }
		}

		protected CompetitiveLayer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_ILorg_neuroph_util_NeuronProperties_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.nnet.comp']/class[@name='CompetitiveLayer']/constructor[@name='CompetitiveLayer' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='org.neuroph.util.NeuronProperties']]"
		[Register (".ctor", "(ILorg/neuroph/util/NeuronProperties;)V", "")]
		public unsafe CompetitiveLayer (int p0, global::Org.Neuroph.Util.NeuronProperties p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (CompetitiveLayer)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(ILorg/neuroph/util/NeuronProperties;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(ILorg/neuroph/util/NeuronProperties;)V", __args);
					return;
				}

				if (id_ctor_ILorg_neuroph_util_NeuronProperties_ == IntPtr.Zero)
					id_ctor_ILorg_neuroph_util_NeuronProperties_ = JNIEnv.GetMethodID (class_ref, "<init>", "(ILorg/neuroph/util/NeuronProperties;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_ILorg_neuroph_util_NeuronProperties_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_ILorg_neuroph_util_NeuronProperties_, __args);
			} finally {
			}
		}

		static Delegate cb_getMaxIterations;
#pragma warning disable 0169
		static Delegate GetGetMaxIterationsHandler ()
		{
			if (cb_getMaxIterations == null)
				cb_getMaxIterations = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMaxIterations);
			return cb_getMaxIterations;
		}

		static int n_GetMaxIterations (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Nnet.Comp.CompetitiveLayer __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Comp.CompetitiveLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxIterations;
		}
#pragma warning restore 0169

		static Delegate cb_setMaxIterations_I;
#pragma warning disable 0169
		static Delegate GetSetMaxIterations_IHandler ()
		{
			if (cb_setMaxIterations_I == null)
				cb_setMaxIterations_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetMaxIterations_I);
			return cb_setMaxIterations_I;
		}

		static void n_SetMaxIterations_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Neuroph.Nnet.Comp.CompetitiveLayer __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Comp.CompetitiveLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MaxIterations = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMaxIterations;
		static IntPtr id_setMaxIterations_I;
		public virtual unsafe int MaxIterations {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.comp']/class[@name='CompetitiveLayer']/method[@name='getMaxIterations' and count(parameter)=0]"
			[Register ("getMaxIterations", "()I", "GetGetMaxIterationsHandler")]
			get {
				if (id_getMaxIterations == IntPtr.Zero)
					id_getMaxIterations = JNIEnv.GetMethodID (class_ref, "getMaxIterations", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getMaxIterations);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMaxIterations", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.comp']/class[@name='CompetitiveLayer']/method[@name='setMaxIterations' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMaxIterations", "(I)V", "GetSetMaxIterations_IHandler")]
			set {
				if (id_setMaxIterations_I == IntPtr.Zero)
					id_setMaxIterations_I = JNIEnv.GetMethodID (class_ref, "setMaxIterations", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMaxIterations_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMaxIterations", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getWinner;
#pragma warning disable 0169
		static Delegate GetGetWinnerHandler ()
		{
			if (cb_getWinner == null)
				cb_getWinner = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetWinner);
			return cb_getWinner;
		}

		static IntPtr n_GetWinner (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Nnet.Comp.CompetitiveLayer __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Comp.CompetitiveLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Winner);
		}
#pragma warning restore 0169

		static IntPtr id_getWinner;
		public virtual unsafe global::Org.Neuroph.Nnet.Comp.CompetitiveNeuron Winner {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.comp']/class[@name='CompetitiveLayer']/method[@name='getWinner' and count(parameter)=0]"
			[Register ("getWinner", "()Lorg/neuroph/nnet/comp/CompetitiveNeuron;", "GetGetWinnerHandler")]
			get {
				if (id_getWinner == IntPtr.Zero)
					id_getWinner = JNIEnv.GetMethodID (class_ref, "getWinner", "()Lorg/neuroph/nnet/comp/CompetitiveNeuron;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Comp.CompetitiveNeuron> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getWinner), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Comp.CompetitiveNeuron> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWinner", "()Lorg/neuroph/nnet/comp/CompetitiveNeuron;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
