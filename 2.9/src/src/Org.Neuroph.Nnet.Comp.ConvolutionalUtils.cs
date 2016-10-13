using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Nnet.Comp {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.nnet.comp']/class[@name='ConvolutionalUtils']"
	[global::Android.Runtime.Register ("org/neuroph/nnet/comp/ConvolutionalUtils", DoNotGenerateAcw=true)]
	public partial class ConvolutionalUtils : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/nnet/comp/ConvolutionalUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ConvolutionalUtils); }
		}

		protected ConvolutionalUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.nnet.comp']/class[@name='ConvolutionalUtils']/constructor[@name='ConvolutionalUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ConvolutionalUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ConvolutionalUtils)) {
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

		static IntPtr id_connectFeatureMaps_Lorg_neuroph_nnet_comp_layer_FeatureMapsLayer_Lorg_neuroph_nnet_comp_layer_FeatureMapsLayer_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.comp']/class[@name='ConvolutionalUtils']/method[@name='connectFeatureMaps' and count(parameter)=4 and parameter[1][@type='org.neuroph.nnet.comp.layer.FeatureMapsLayer'] and parameter[2][@type='org.neuroph.nnet.comp.layer.FeatureMapsLayer'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("connectFeatureMaps", "(Lorg/neuroph/nnet/comp/layer/FeatureMapsLayer;Lorg/neuroph/nnet/comp/layer/FeatureMapsLayer;II)V", "")]
		public static unsafe void ConnectFeatureMaps (global::Org.Neuroph.Nnet.Comp.Layer.FeatureMapsLayer p0, global::Org.Neuroph.Nnet.Comp.Layer.FeatureMapsLayer p1, int p2, int p3)
		{
			if (id_connectFeatureMaps_Lorg_neuroph_nnet_comp_layer_FeatureMapsLayer_Lorg_neuroph_nnet_comp_layer_FeatureMapsLayer_II == IntPtr.Zero)
				id_connectFeatureMaps_Lorg_neuroph_nnet_comp_layer_FeatureMapsLayer_Lorg_neuroph_nnet_comp_layer_FeatureMapsLayer_II = JNIEnv.GetStaticMethodID (class_ref, "connectFeatureMaps", "(Lorg/neuroph/nnet/comp/layer/FeatureMapsLayer;Lorg/neuroph/nnet/comp/layer/FeatureMapsLayer;II)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_connectFeatureMaps_Lorg_neuroph_nnet_comp_layer_FeatureMapsLayer_Lorg_neuroph_nnet_comp_layer_FeatureMapsLayer_II, __args);
			} finally {
			}
		}

		static IntPtr id_fullConectMapLayers_Lorg_neuroph_nnet_comp_layer_FeatureMapsLayer_Lorg_neuroph_nnet_comp_layer_FeatureMapsLayer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.comp']/class[@name='ConvolutionalUtils']/method[@name='fullConectMapLayers' and count(parameter)=2 and parameter[1][@type='org.neuroph.nnet.comp.layer.FeatureMapsLayer'] and parameter[2][@type='org.neuroph.nnet.comp.layer.FeatureMapsLayer']]"
		[Register ("fullConectMapLayers", "(Lorg/neuroph/nnet/comp/layer/FeatureMapsLayer;Lorg/neuroph/nnet/comp/layer/FeatureMapsLayer;)V", "")]
		public static unsafe void FullConectMapLayers (global::Org.Neuroph.Nnet.Comp.Layer.FeatureMapsLayer p0, global::Org.Neuroph.Nnet.Comp.Layer.FeatureMapsLayer p1)
		{
			if (id_fullConectMapLayers_Lorg_neuroph_nnet_comp_layer_FeatureMapsLayer_Lorg_neuroph_nnet_comp_layer_FeatureMapsLayer_ == IntPtr.Zero)
				id_fullConectMapLayers_Lorg_neuroph_nnet_comp_layer_FeatureMapsLayer_Lorg_neuroph_nnet_comp_layer_FeatureMapsLayer_ = JNIEnv.GetStaticMethodID (class_ref, "fullConectMapLayers", "(Lorg/neuroph/nnet/comp/layer/FeatureMapsLayer;Lorg/neuroph/nnet/comp/layer/FeatureMapsLayer;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_fullConectMapLayers_Lorg_neuroph_nnet_comp_layer_FeatureMapsLayer_Lorg_neuroph_nnet_comp_layer_FeatureMapsLayer_, __args);
			} finally {
			}
		}

	}
}
