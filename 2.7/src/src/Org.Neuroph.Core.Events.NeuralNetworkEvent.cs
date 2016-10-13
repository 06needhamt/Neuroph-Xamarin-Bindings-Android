using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Core.Events {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.core.events']/class[@name='NeuralNetworkEvent']"
	[global::Android.Runtime.Register ("org/neuroph/core/events/NeuralNetworkEvent", DoNotGenerateAcw=true)]
	public partial class NeuralNetworkEvent : global::Java.Util.EventObject {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/core/events/NeuralNetworkEvent", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NeuralNetworkEvent); }
		}

		protected NeuralNetworkEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_neuroph_core_NeuralNetwork_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.core.events']/class[@name='NeuralNetworkEvent']/constructor[@name='NeuralNetworkEvent' and count(parameter)=1 and parameter[1][@type='org.neuroph.core.NeuralNetwork']]"
		[Register (".ctor", "(Lorg/neuroph/core/NeuralNetwork;)V", "")]
		public unsafe NeuralNetworkEvent (global::Org.Neuroph.Core.NeuralNetwork p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (NeuralNetworkEvent)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/neuroph/core/NeuralNetwork;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/neuroph/core/NeuralNetwork;)V", __args);
					return;
				}

				if (id_ctor_Lorg_neuroph_core_NeuralNetwork_ == IntPtr.Zero)
					id_ctor_Lorg_neuroph_core_NeuralNetwork_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/neuroph/core/NeuralNetwork;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_neuroph_core_NeuralNetwork_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_neuroph_core_NeuralNetwork_, __args);
			} finally {
			}
		}

	}
}
