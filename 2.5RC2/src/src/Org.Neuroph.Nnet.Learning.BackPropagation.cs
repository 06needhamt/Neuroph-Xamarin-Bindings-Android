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

		static Delegate cb_adjustHiddenLayers;
#pragma warning disable 0169
		static Delegate GetAdjustHiddenLayersHandler ()
		{
			if (cb_adjustHiddenLayers == null)
				cb_adjustHiddenLayers = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_AdjustHiddenLayers);
			return cb_adjustHiddenLayers;
		}

		static void n_AdjustHiddenLayers (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Nnet.Learning.BackPropagation __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Learning.BackPropagation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AdjustHiddenLayers ();
		}
#pragma warning restore 0169

		static IntPtr id_adjustHiddenLayers;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.learning']/class[@name='BackPropagation']/method[@name='adjustHiddenLayers' and count(parameter)=0]"
		[Register ("adjustHiddenLayers", "()V", "GetAdjustHiddenLayersHandler")]
		protected virtual unsafe void AdjustHiddenLayers ()
		{
			if (id_adjustHiddenLayers == IntPtr.Zero)
				id_adjustHiddenLayers = JNIEnv.GetMethodID (class_ref, "adjustHiddenLayers", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_adjustHiddenLayers);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "adjustHiddenLayers", "()V"));
			} finally {
			}
		}

	}
}
