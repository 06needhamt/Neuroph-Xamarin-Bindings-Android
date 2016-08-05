using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Contrib {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.contrib']/class[@name='IACNeuron']"
	[global::Android.Runtime.Register ("org/neuroph/contrib/IACNeuron", DoNotGenerateAcw=true)]
	public partial class IACNeuron : global::Org.Neuroph.Core.Neuron {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/contrib/IACNeuron", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IACNeuron); }
		}

		protected IACNeuron (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.contrib']/class[@name='IACNeuron']/constructor[@name='IACNeuron' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe IACNeuron ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (IACNeuron)) {
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

	}
}
