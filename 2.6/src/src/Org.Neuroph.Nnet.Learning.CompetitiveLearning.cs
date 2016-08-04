using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Nnet.Learning {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.nnet.learning']/class[@name='CompetitiveLearning']"
	[global::Android.Runtime.Register ("org/neuroph/nnet/learning/CompetitiveLearning", DoNotGenerateAcw=true)]
	public partial class CompetitiveLearning : global::Org.Neuroph.Core.Learning.UnsupervisedLearning {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/nnet/learning/CompetitiveLearning", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CompetitiveLearning); }
		}

		protected CompetitiveLearning (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.nnet.learning']/class[@name='CompetitiveLearning']/constructor[@name='CompetitiveLearning' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CompetitiveLearning ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (CompetitiveLearning)) {
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
			global::Org.Neuroph.Nnet.Learning.CompetitiveLearning __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Learning.CompetitiveLearning> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UpdateNetworkWeights ();
		}
#pragma warning restore 0169

		static IntPtr id_updateNetworkWeights;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.learning']/class[@name='CompetitiveLearning']/method[@name='updateNetworkWeights' and count(parameter)=0]"
		[Register ("updateNetworkWeights", "()V", "GetUpdateNetworkWeightsHandler")]
		protected override unsafe void UpdateNetworkWeights ()
		{
			if (id_updateNetworkWeights == IntPtr.Zero)
				id_updateNetworkWeights = JNIEnv.GetMethodID (class_ref, "updateNetworkWeights", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_updateNetworkWeights);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateNetworkWeights", "()V"));
			} finally {
			}
		}

	}
}
