using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Nnet.Comp.Layer {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.nnet.comp.layer']/class[@name='InputMapsLayer']"
	[global::Android.Runtime.Register ("org/neuroph/nnet/comp/layer/InputMapsLayer", DoNotGenerateAcw=true)]
	public partial class InputMapsLayer : global::Org.Neuroph.Nnet.Comp.Layer.FeatureMapsLayer {


		static IntPtr DEFAULT_NEURON_PROP_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.neuroph.nnet.comp.layer']/class[@name='InputMapsLayer']/field[@name='DEFAULT_NEURON_PROP']"
		[Register ("DEFAULT_NEURON_PROP")]
		public static global::Org.Neuroph.Util.NeuronProperties DefaultNeuronProp {
			get {
				if (DEFAULT_NEURON_PROP_jfieldId == IntPtr.Zero)
					DEFAULT_NEURON_PROP_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEFAULT_NEURON_PROP", "Lorg/neuroph/util/NeuronProperties;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DEFAULT_NEURON_PROP_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.NeuronProperties> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/nnet/comp/layer/InputMapsLayer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (InputMapsLayer); }
		}

		protected InputMapsLayer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_neuroph_nnet_comp_layer_Layer2D_Dimensions_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.nnet.comp.layer']/class[@name='InputMapsLayer']/constructor[@name='InputMapsLayer' and count(parameter)=2 and parameter[1][@type='org.neuroph.nnet.comp.layer.Layer2D.Dimensions'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Lorg/neuroph/nnet/comp/layer/Layer2D$Dimensions;I)V", "")]
		public unsafe InputMapsLayer (global::Org.Neuroph.Nnet.Comp.Layer.Layer2D.Dimensions p0, int p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (InputMapsLayer)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/neuroph/nnet/comp/layer/Layer2D$Dimensions;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorg/neuroph/nnet/comp/layer/Layer2D$Dimensions;I)V", __args);
					return;
				}

				if (id_ctor_Lorg_neuroph_nnet_comp_layer_Layer2D_Dimensions_I == IntPtr.Zero)
					id_ctor_Lorg_neuroph_nnet_comp_layer_Layer2D_Dimensions_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/neuroph/nnet/comp/layer/Layer2D$Dimensions;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_neuroph_nnet_comp_layer_Layer2D_Dimensions_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_neuroph_nnet_comp_layer_Layer2D_Dimensions_I, __args);
			} finally {
			}
		}

	}
}
