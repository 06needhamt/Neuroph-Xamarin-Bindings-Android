using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Core.Events {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.core.events']/class[@name='NNCalculatedEvent']"
	[global::Android.Runtime.Register ("org/neuroph/core/events/NNCalculatedEvent", DoNotGenerateAcw=true)]
	public partial class NNCalculatedEvent : global::Org.Neuroph.Core.Events.NeuralNetworkEvent {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/core/events/NNCalculatedEvent", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NNCalculatedEvent); }
		}

		protected NNCalculatedEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_neuroph_core_NeuralNetwork_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.core.events']/class[@name='NNCalculatedEvent']/constructor[@name='NNCalculatedEvent' and count(parameter)=1 and parameter[1][@type='org.neuroph.core.NeuralNetwork']]"
		[Register (".ctor", "(Lorg/neuroph/core/NeuralNetwork;)V", "")]
		public unsafe NNCalculatedEvent (global::Org.Neuroph.Core.NeuralNetwork p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (NNCalculatedEvent)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/neuroph/core/NeuralNetwork;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorg/neuroph/core/NeuralNetwork;)V", __args);
					return;
				}

				if (id_ctor_Lorg_neuroph_core_NeuralNetwork_ == IntPtr.Zero)
					id_ctor_Lorg_neuroph_core_NeuralNetwork_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/neuroph/core/NeuralNetwork;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_neuroph_core_NeuralNetwork_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_neuroph_core_NeuralNetwork_, __args);
			} finally {
			}
		}

	}
}
