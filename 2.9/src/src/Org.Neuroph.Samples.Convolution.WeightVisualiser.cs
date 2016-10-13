using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Samples.Convolution {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.samples.convolution']/class[@name='WeightVisualiser']"
	[global::Android.Runtime.Register ("org/neuroph/samples/convolution/WeightVisualiser", DoNotGenerateAcw=true)]
	public partial class WeightVisualiser : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/samples/convolution/WeightVisualiser", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (WeightVisualiser); }
		}

		protected WeightVisualiser (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_neuroph_nnet_comp_layer_Layer2D_Lorg_neuroph_nnet_comp_Kernel_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.samples.convolution']/class[@name='WeightVisualiser']/constructor[@name='WeightVisualiser' and count(parameter)=2 and parameter[1][@type='org.neuroph.nnet.comp.layer.Layer2D'] and parameter[2][@type='org.neuroph.nnet.comp.Kernel']]"
		[Register (".ctor", "(Lorg/neuroph/nnet/comp/layer/Layer2D;Lorg/neuroph/nnet/comp/Kernel;)V", "")]
		public unsafe WeightVisualiser (global::Org.Neuroph.Nnet.Comp.Layer.Layer2D p0, global::Org.Neuroph.Nnet.Comp.Kernel p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (WeightVisualiser)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/neuroph/nnet/comp/layer/Layer2D;Lorg/neuroph/nnet/comp/Kernel;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/neuroph/nnet/comp/layer/Layer2D;Lorg/neuroph/nnet/comp/Kernel;)V", __args);
					return;
				}

				if (id_ctor_Lorg_neuroph_nnet_comp_layer_Layer2D_Lorg_neuroph_nnet_comp_Kernel_ == IntPtr.Zero)
					id_ctor_Lorg_neuroph_nnet_comp_layer_Layer2D_Lorg_neuroph_nnet_comp_Kernel_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/neuroph/nnet/comp/layer/Layer2D;Lorg/neuroph/nnet/comp/Kernel;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_neuroph_nnet_comp_layer_Layer2D_Lorg_neuroph_nnet_comp_Kernel_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_neuroph_nnet_comp_layer_Layer2D_Lorg_neuroph_nnet_comp_Kernel_, __args);
			} finally {
			}
		}

		static Delegate cb_displayWeights;
#pragma warning disable 0169
		static Delegate GetDisplayWeightsHandler ()
		{
			if (cb_displayWeights == null)
				cb_displayWeights = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DisplayWeights);
			return cb_displayWeights;
		}

		static void n_DisplayWeights (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Samples.Convolution.WeightVisualiser __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Samples.Convolution.WeightVisualiser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DisplayWeights ();
		}
#pragma warning restore 0169

		static IntPtr id_displayWeights;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.samples.convolution']/class[@name='WeightVisualiser']/method[@name='displayWeights' and count(parameter)=0]"
		[Register ("displayWeights", "()V", "GetDisplayWeightsHandler")]
		public virtual unsafe void DisplayWeights ()
		{
			if (id_displayWeights == IntPtr.Zero)
				id_displayWeights = JNIEnv.GetMethodID (class_ref, "displayWeights", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_displayWeights);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "displayWeights", "()V"));
			} finally {
			}
		}

	}
}
