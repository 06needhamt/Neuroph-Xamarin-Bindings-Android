using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.util']/class[@name='NeuronFactory']"
	[global::Android.Runtime.Register ("org/neuroph/util/NeuronFactory", DoNotGenerateAcw=true)]
	public partial class NeuronFactory : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/util/NeuronFactory", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NeuronFactory); }
		}

		protected NeuronFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.util']/class[@name='NeuronFactory']/constructor[@name='NeuronFactory' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe NeuronFactory ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (NeuronFactory)) {
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

		static IntPtr id_createNeuron_Lorg_neuroph_util_NeuronProperties_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util']/class[@name='NeuronFactory']/method[@name='createNeuron' and count(parameter)=1 and parameter[1][@type='org.neuroph.util.NeuronProperties']]"
		[Register ("createNeuron", "(Lorg/neuroph/util/NeuronProperties;)Lorg/neuroph/core/Neuron;", "")]
		public static unsafe global::Org.Neuroph.Core.Neuron CreateNeuron (global::Org.Neuroph.Util.NeuronProperties p0)
		{
			if (id_createNeuron_Lorg_neuroph_util_NeuronProperties_ == IntPtr.Zero)
				id_createNeuron_Lorg_neuroph_util_NeuronProperties_ = JNIEnv.GetStaticMethodID (class_ref, "createNeuron", "(Lorg/neuroph/util/NeuronProperties;)Lorg/neuroph/core/Neuron;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Org.Neuroph.Core.Neuron __ret = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Neuron> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createNeuron_Lorg_neuroph_util_NeuronProperties_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
