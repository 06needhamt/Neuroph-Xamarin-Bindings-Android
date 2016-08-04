using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Contrib {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.contrib']/class[@name='RecommenderNetwork']"
	[global::Android.Runtime.Register ("org/neuroph/contrib/RecommenderNetwork", DoNotGenerateAcw=true)]
	public partial class RecommenderNetwork : global::Org.Neuroph.Core.NeuralNetwork {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/contrib/RecommenderNetwork", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RecommenderNetwork); }
		}

		protected RecommenderNetwork (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.contrib']/class[@name='RecommenderNetwork']/constructor[@name='RecommenderNetwork' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe RecommenderNetwork ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (RecommenderNetwork)) {
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

		static Delegate cb_createDemoNetwork;
#pragma warning disable 0169
		static Delegate GetCreateDemoNetworkHandler ()
		{
			if (cb_createDemoNetwork == null)
				cb_createDemoNetwork = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CreateDemoNetwork);
			return cb_createDemoNetwork;
		}

		static void n_CreateDemoNetwork (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Contrib.RecommenderNetwork __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.RecommenderNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CreateDemoNetwork ();
		}
#pragma warning restore 0169

		static IntPtr id_createDemoNetwork;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.contrib']/class[@name='RecommenderNetwork']/method[@name='createDemoNetwork' and count(parameter)=0]"
		[Register ("createDemoNetwork", "()V", "GetCreateDemoNetworkHandler")]
		public virtual unsafe void CreateDemoNetwork ()
		{
			if (id_createDemoNetwork == IntPtr.Zero)
				id_createDemoNetwork = JNIEnv.GetMethodID (class_ref, "createDemoNetwork", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_createDemoNetwork);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createDemoNetwork", "()V"));
			} finally {
			}
		}

	}
}
