using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Nnet.Comp.Layer {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.nnet.comp.layer']/class[@name='ConvolutionalLayer']"
	[global::Android.Runtime.Register ("org/neuroph/nnet/comp/layer/ConvolutionalLayer", DoNotGenerateAcw=true)]
	public partial class ConvolutionalLayer : global::Org.Neuroph.Nnet.Comp.Layer.FeatureMapsLayer {


		static IntPtr DEFAULT_NEURON_PROP_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.neuroph.nnet.comp.layer']/class[@name='ConvolutionalLayer']/field[@name='DEFAULT_NEURON_PROP']"
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
				return JNIEnv.FindClass ("org/neuroph/nnet/comp/layer/ConvolutionalLayer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ConvolutionalLayer); }
		}

		protected ConvolutionalLayer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_neuroph_nnet_comp_layer_FeatureMapsLayer_Lorg_neuroph_nnet_comp_Kernel_ILorg_neuroph_util_NeuronProperties_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.nnet.comp.layer']/class[@name='ConvolutionalLayer']/constructor[@name='ConvolutionalLayer' and count(parameter)=4 and parameter[1][@type='org.neuroph.nnet.comp.layer.FeatureMapsLayer'] and parameter[2][@type='org.neuroph.nnet.comp.Kernel'] and parameter[3][@type='int'] and parameter[4][@type='org.neuroph.util.NeuronProperties']]"
		[Register (".ctor", "(Lorg/neuroph/nnet/comp/layer/FeatureMapsLayer;Lorg/neuroph/nnet/comp/Kernel;ILorg/neuroph/util/NeuronProperties;)V", "")]
		public unsafe ConvolutionalLayer (global::Org.Neuroph.Nnet.Comp.Layer.FeatureMapsLayer p0, global::Org.Neuroph.Nnet.Comp.Kernel p1, int p2, global::Org.Neuroph.Util.NeuronProperties p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				if (GetType () != typeof (ConvolutionalLayer)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/neuroph/nnet/comp/layer/FeatureMapsLayer;Lorg/neuroph/nnet/comp/Kernel;ILorg/neuroph/util/NeuronProperties;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/neuroph/nnet/comp/layer/FeatureMapsLayer;Lorg/neuroph/nnet/comp/Kernel;ILorg/neuroph/util/NeuronProperties;)V", __args);
					return;
				}

				if (id_ctor_Lorg_neuroph_nnet_comp_layer_FeatureMapsLayer_Lorg_neuroph_nnet_comp_Kernel_ILorg_neuroph_util_NeuronProperties_ == IntPtr.Zero)
					id_ctor_Lorg_neuroph_nnet_comp_layer_FeatureMapsLayer_Lorg_neuroph_nnet_comp_Kernel_ILorg_neuroph_util_NeuronProperties_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/neuroph/nnet/comp/layer/FeatureMapsLayer;Lorg/neuroph/nnet/comp/Kernel;ILorg/neuroph/util/NeuronProperties;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_neuroph_nnet_comp_layer_FeatureMapsLayer_Lorg_neuroph_nnet_comp_Kernel_ILorg_neuroph_util_NeuronProperties_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_neuroph_nnet_comp_layer_FeatureMapsLayer_Lorg_neuroph_nnet_comp_Kernel_ILorg_neuroph_util_NeuronProperties_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Lorg_neuroph_nnet_comp_layer_FeatureMapsLayer_Lorg_neuroph_nnet_comp_Kernel_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.nnet.comp.layer']/class[@name='ConvolutionalLayer']/constructor[@name='ConvolutionalLayer' and count(parameter)=3 and parameter[1][@type='org.neuroph.nnet.comp.layer.FeatureMapsLayer'] and parameter[2][@type='org.neuroph.nnet.comp.Kernel'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Lorg/neuroph/nnet/comp/layer/FeatureMapsLayer;Lorg/neuroph/nnet/comp/Kernel;I)V", "")]
		public unsafe ConvolutionalLayer (global::Org.Neuroph.Nnet.Comp.Layer.FeatureMapsLayer p0, global::Org.Neuroph.Nnet.Comp.Kernel p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (ConvolutionalLayer)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/neuroph/nnet/comp/layer/FeatureMapsLayer;Lorg/neuroph/nnet/comp/Kernel;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/neuroph/nnet/comp/layer/FeatureMapsLayer;Lorg/neuroph/nnet/comp/Kernel;I)V", __args);
					return;
				}

				if (id_ctor_Lorg_neuroph_nnet_comp_layer_FeatureMapsLayer_Lorg_neuroph_nnet_comp_Kernel_I == IntPtr.Zero)
					id_ctor_Lorg_neuroph_nnet_comp_layer_FeatureMapsLayer_Lorg_neuroph_nnet_comp_Kernel_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/neuroph/nnet/comp/layer/FeatureMapsLayer;Lorg/neuroph/nnet/comp/Kernel;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_neuroph_nnet_comp_layer_FeatureMapsLayer_Lorg_neuroph_nnet_comp_Kernel_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_neuroph_nnet_comp_layer_FeatureMapsLayer_Lorg_neuroph_nnet_comp_Kernel_I, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Lorg_neuroph_nnet_comp_layer_FeatureMapsLayer_Lorg_neuroph_nnet_comp_Kernel_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.nnet.comp.layer']/class[@name='ConvolutionalLayer']/constructor[@name='ConvolutionalLayer' and count(parameter)=2 and parameter[1][@type='org.neuroph.nnet.comp.layer.FeatureMapsLayer'] and parameter[2][@type='org.neuroph.nnet.comp.Kernel']]"
		[Register (".ctor", "(Lorg/neuroph/nnet/comp/layer/FeatureMapsLayer;Lorg/neuroph/nnet/comp/Kernel;)V", "")]
		public unsafe ConvolutionalLayer (global::Org.Neuroph.Nnet.Comp.Layer.FeatureMapsLayer p0, global::Org.Neuroph.Nnet.Comp.Kernel p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (ConvolutionalLayer)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/neuroph/nnet/comp/layer/FeatureMapsLayer;Lorg/neuroph/nnet/comp/Kernel;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/neuroph/nnet/comp/layer/FeatureMapsLayer;Lorg/neuroph/nnet/comp/Kernel;)V", __args);
					return;
				}

				if (id_ctor_Lorg_neuroph_nnet_comp_layer_FeatureMapsLayer_Lorg_neuroph_nnet_comp_Kernel_ == IntPtr.Zero)
					id_ctor_Lorg_neuroph_nnet_comp_layer_FeatureMapsLayer_Lorg_neuroph_nnet_comp_Kernel_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/neuroph/nnet/comp/layer/FeatureMapsLayer;Lorg/neuroph/nnet/comp/Kernel;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_neuroph_nnet_comp_layer_FeatureMapsLayer_Lorg_neuroph_nnet_comp_Kernel_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_neuroph_nnet_comp_layer_FeatureMapsLayer_Lorg_neuroph_nnet_comp_Kernel_, __args);
			} finally {
			}
		}

	}
}
