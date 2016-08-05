using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Nnet.Comp.Layer {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.nnet.comp.layer']/class[@name='FeatureMapsLayer']"
	[global::Android.Runtime.Register ("org/neuroph/nnet/comp/layer/FeatureMapsLayer", DoNotGenerateAcw=true)]
	public partial class FeatureMapsLayer : global::Org.Neuroph.Core.Layer {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/nnet/comp/layer/FeatureMapsLayer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FeatureMapsLayer); }
		}

		protected FeatureMapsLayer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_neuroph_nnet_comp_Kernel_Lorg_neuroph_nnet_comp_layer_Layer2D_Dimensions_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.nnet.comp.layer']/class[@name='FeatureMapsLayer']/constructor[@name='FeatureMapsLayer' and count(parameter)=2 and parameter[1][@type='org.neuroph.nnet.comp.Kernel'] and parameter[2][@type='org.neuroph.nnet.comp.layer.Layer2D.Dimensions']]"
		[Register (".ctor", "(Lorg/neuroph/nnet/comp/Kernel;Lorg/neuroph/nnet/comp/layer/Layer2D$Dimensions;)V", "")]
		public unsafe FeatureMapsLayer (global::Org.Neuroph.Nnet.Comp.Kernel p0, global::Org.Neuroph.Nnet.Comp.Layer.Layer2D.Dimensions p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (FeatureMapsLayer)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/neuroph/nnet/comp/Kernel;Lorg/neuroph/nnet/comp/layer/Layer2D$Dimensions;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorg/neuroph/nnet/comp/Kernel;Lorg/neuroph/nnet/comp/layer/Layer2D$Dimensions;)V", __args);
					return;
				}

				if (id_ctor_Lorg_neuroph_nnet_comp_Kernel_Lorg_neuroph_nnet_comp_layer_Layer2D_Dimensions_ == IntPtr.Zero)
					id_ctor_Lorg_neuroph_nnet_comp_Kernel_Lorg_neuroph_nnet_comp_layer_Layer2D_Dimensions_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/neuroph/nnet/comp/Kernel;Lorg/neuroph/nnet/comp/layer/Layer2D$Dimensions;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_neuroph_nnet_comp_Kernel_Lorg_neuroph_nnet_comp_layer_Layer2D_Dimensions_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_neuroph_nnet_comp_Kernel_Lorg_neuroph_nnet_comp_layer_Layer2D_Dimensions_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Lorg_neuroph_nnet_comp_Kernel_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.nnet.comp.layer']/class[@name='FeatureMapsLayer']/constructor[@name='FeatureMapsLayer' and count(parameter)=1 and parameter[1][@type='org.neuroph.nnet.comp.Kernel']]"
		[Register (".ctor", "(Lorg/neuroph/nnet/comp/Kernel;)V", "")]
		public unsafe FeatureMapsLayer (global::Org.Neuroph.Nnet.Comp.Kernel p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (FeatureMapsLayer)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/neuroph/nnet/comp/Kernel;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorg/neuroph/nnet/comp/Kernel;)V", __args);
					return;
				}

				if (id_ctor_Lorg_neuroph_nnet_comp_Kernel_ == IntPtr.Zero)
					id_ctor_Lorg_neuroph_nnet_comp_Kernel_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/neuroph/nnet/comp/Kernel;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_neuroph_nnet_comp_Kernel_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_neuroph_nnet_comp_Kernel_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Lorg_neuroph_nnet_comp_Kernel_Lorg_neuroph_nnet_comp_layer_Layer2D_Dimensions_ILorg_neuroph_util_NeuronProperties_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.nnet.comp.layer']/class[@name='FeatureMapsLayer']/constructor[@name='FeatureMapsLayer' and count(parameter)=4 and parameter[1][@type='org.neuroph.nnet.comp.Kernel'] and parameter[2][@type='org.neuroph.nnet.comp.layer.Layer2D.Dimensions'] and parameter[3][@type='int'] and parameter[4][@type='org.neuroph.util.NeuronProperties']]"
		[Register (".ctor", "(Lorg/neuroph/nnet/comp/Kernel;Lorg/neuroph/nnet/comp/layer/Layer2D$Dimensions;ILorg/neuroph/util/NeuronProperties;)V", "")]
		public unsafe FeatureMapsLayer (global::Org.Neuroph.Nnet.Comp.Kernel p0, global::Org.Neuroph.Nnet.Comp.Layer.Layer2D.Dimensions p1, int p2, global::Org.Neuroph.Util.NeuronProperties p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				if (GetType () != typeof (FeatureMapsLayer)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/neuroph/nnet/comp/Kernel;Lorg/neuroph/nnet/comp/layer/Layer2D$Dimensions;ILorg/neuroph/util/NeuronProperties;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorg/neuroph/nnet/comp/Kernel;Lorg/neuroph/nnet/comp/layer/Layer2D$Dimensions;ILorg/neuroph/util/NeuronProperties;)V", __args);
					return;
				}

				if (id_ctor_Lorg_neuroph_nnet_comp_Kernel_Lorg_neuroph_nnet_comp_layer_Layer2D_Dimensions_ILorg_neuroph_util_NeuronProperties_ == IntPtr.Zero)
					id_ctor_Lorg_neuroph_nnet_comp_Kernel_Lorg_neuroph_nnet_comp_layer_Layer2D_Dimensions_ILorg_neuroph_util_NeuronProperties_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/neuroph/nnet/comp/Kernel;Lorg/neuroph/nnet/comp/layer/Layer2D$Dimensions;ILorg/neuroph/util/NeuronProperties;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_neuroph_nnet_comp_Kernel_Lorg_neuroph_nnet_comp_layer_Layer2D_Dimensions_ILorg_neuroph_util_NeuronProperties_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_neuroph_nnet_comp_Kernel_Lorg_neuroph_nnet_comp_layer_Layer2D_Dimensions_ILorg_neuroph_util_NeuronProperties_, __args);
			} finally {
			}
		}

		static Delegate cb_getKernel;
#pragma warning disable 0169
		static Delegate GetGetKernelHandler ()
		{
			if (cb_getKernel == null)
				cb_getKernel = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetKernel);
			return cb_getKernel;
		}

		static IntPtr n_GetKernel (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Nnet.Comp.Layer.FeatureMapsLayer __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Comp.Layer.FeatureMapsLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Kernel);
		}
#pragma warning restore 0169

		static IntPtr id_getKernel;
		public virtual unsafe global::Org.Neuroph.Nnet.Comp.Kernel Kernel {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.comp.layer']/class[@name='FeatureMapsLayer']/method[@name='getKernel' and count(parameter)=0]"
			[Register ("getKernel", "()Lorg/neuroph/nnet/comp/Kernel;", "GetGetKernelHandler")]
			get {
				if (id_getKernel == IntPtr.Zero)
					id_getKernel = JNIEnv.GetMethodID (class_ref, "getKernel", "()Lorg/neuroph/nnet/comp/Kernel;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Comp.Kernel> (JNIEnv.CallObjectMethod  (Handle, id_getKernel), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Comp.Kernel> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getKernel", "()Lorg/neuroph/nnet/comp/Kernel;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMapDimensions;
#pragma warning disable 0169
		static Delegate GetGetMapDimensionsHandler ()
		{
			if (cb_getMapDimensions == null)
				cb_getMapDimensions = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMapDimensions);
			return cb_getMapDimensions;
		}

		static IntPtr n_GetMapDimensions (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Nnet.Comp.Layer.FeatureMapsLayer __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Comp.Layer.FeatureMapsLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MapDimensions);
		}
#pragma warning restore 0169

		static IntPtr id_getMapDimensions;
		public virtual unsafe global::Org.Neuroph.Nnet.Comp.Layer.Layer2D.Dimensions MapDimensions {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.comp.layer']/class[@name='FeatureMapsLayer']/method[@name='getMapDimensions' and count(parameter)=0]"
			[Register ("getMapDimensions", "()Lorg/neuroph/nnet/comp/layer/Layer2D$Dimensions;", "GetGetMapDimensionsHandler")]
			get {
				if (id_getMapDimensions == IntPtr.Zero)
					id_getMapDimensions = JNIEnv.GetMethodID (class_ref, "getMapDimensions", "()Lorg/neuroph/nnet/comp/layer/Layer2D$Dimensions;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Comp.Layer.Layer2D.Dimensions> (JNIEnv.CallObjectMethod  (Handle, id_getMapDimensions), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Comp.Layer.Layer2D.Dimensions> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMapDimensions", "()Lorg/neuroph/nnet/comp/layer/Layer2D$Dimensions;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getNumberOfMaps;
#pragma warning disable 0169
		static Delegate GetGetNumberOfMapsHandler ()
		{
			if (cb_getNumberOfMaps == null)
				cb_getNumberOfMaps = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNumberOfMaps);
			return cb_getNumberOfMaps;
		}

		static int n_GetNumberOfMaps (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Nnet.Comp.Layer.FeatureMapsLayer __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Comp.Layer.FeatureMapsLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NumberOfMaps;
		}
#pragma warning restore 0169

		static IntPtr id_getNumberOfMaps;
		public virtual unsafe int NumberOfMaps {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.comp.layer']/class[@name='FeatureMapsLayer']/method[@name='getNumberOfMaps' and count(parameter)=0]"
			[Register ("getNumberOfMaps", "()I", "GetGetNumberOfMapsHandler")]
			get {
				if (id_getNumberOfMaps == IntPtr.Zero)
					id_getNumberOfMaps = JNIEnv.GetMethodID (class_ref, "getNumberOfMaps", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getNumberOfMaps);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNumberOfMaps", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_addFeatureMap_Lorg_neuroph_nnet_comp_layer_Layer2D_;
#pragma warning disable 0169
		static Delegate GetAddFeatureMap_Lorg_neuroph_nnet_comp_layer_Layer2D_Handler ()
		{
			if (cb_addFeatureMap_Lorg_neuroph_nnet_comp_layer_Layer2D_ == null)
				cb_addFeatureMap_Lorg_neuroph_nnet_comp_layer_Layer2D_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddFeatureMap_Lorg_neuroph_nnet_comp_layer_Layer2D_);
			return cb_addFeatureMap_Lorg_neuroph_nnet_comp_layer_Layer2D_;
		}

		static void n_AddFeatureMap_Lorg_neuroph_nnet_comp_layer_Layer2D_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Nnet.Comp.Layer.FeatureMapsLayer __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Comp.Layer.FeatureMapsLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Nnet.Comp.Layer.Layer2D p0 = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Comp.Layer.Layer2D> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddFeatureMap (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addFeatureMap_Lorg_neuroph_nnet_comp_layer_Layer2D_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.comp.layer']/class[@name='FeatureMapsLayer']/method[@name='addFeatureMap' and count(parameter)=1 and parameter[1][@type='org.neuroph.nnet.comp.layer.Layer2D']]"
		[Register ("addFeatureMap", "(Lorg/neuroph/nnet/comp/layer/Layer2D;)V", "GetAddFeatureMap_Lorg_neuroph_nnet_comp_layer_Layer2D_Handler")]
		public virtual unsafe void AddFeatureMap (global::Org.Neuroph.Nnet.Comp.Layer.Layer2D p0)
		{
			if (id_addFeatureMap_Lorg_neuroph_nnet_comp_layer_Layer2D_ == IntPtr.Zero)
				id_addFeatureMap_Lorg_neuroph_nnet_comp_layer_Layer2D_ = JNIEnv.GetMethodID (class_ref, "addFeatureMap", "(Lorg/neuroph/nnet/comp/layer/Layer2D;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_addFeatureMap_Lorg_neuroph_nnet_comp_layer_Layer2D_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addFeatureMap", "(Lorg/neuroph/nnet/comp/layer/Layer2D;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_connectMaps_Lorg_neuroph_nnet_comp_layer_Layer2D_Lorg_neuroph_nnet_comp_layer_Layer2D_;
#pragma warning disable 0169
		static Delegate GetConnectMaps_Lorg_neuroph_nnet_comp_layer_Layer2D_Lorg_neuroph_nnet_comp_layer_Layer2D_Handler ()
		{
			if (cb_connectMaps_Lorg_neuroph_nnet_comp_layer_Layer2D_Lorg_neuroph_nnet_comp_layer_Layer2D_ == null)
				cb_connectMaps_Lorg_neuroph_nnet_comp_layer_Layer2D_Lorg_neuroph_nnet_comp_layer_Layer2D_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_ConnectMaps_Lorg_neuroph_nnet_comp_layer_Layer2D_Lorg_neuroph_nnet_comp_layer_Layer2D_);
			return cb_connectMaps_Lorg_neuroph_nnet_comp_layer_Layer2D_Lorg_neuroph_nnet_comp_layer_Layer2D_;
		}

		static void n_ConnectMaps_Lorg_neuroph_nnet_comp_layer_Layer2D_Lorg_neuroph_nnet_comp_layer_Layer2D_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Neuroph.Nnet.Comp.Layer.FeatureMapsLayer __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Comp.Layer.FeatureMapsLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Nnet.Comp.Layer.Layer2D p0 = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Comp.Layer.Layer2D> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Nnet.Comp.Layer.Layer2D p1 = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Comp.Layer.Layer2D> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.ConnectMaps (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_connectMaps_Lorg_neuroph_nnet_comp_layer_Layer2D_Lorg_neuroph_nnet_comp_layer_Layer2D_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.comp.layer']/class[@name='FeatureMapsLayer']/method[@name='connectMaps' and count(parameter)=2 and parameter[1][@type='org.neuroph.nnet.comp.layer.Layer2D'] and parameter[2][@type='org.neuroph.nnet.comp.layer.Layer2D']]"
		[Register ("connectMaps", "(Lorg/neuroph/nnet/comp/layer/Layer2D;Lorg/neuroph/nnet/comp/layer/Layer2D;)V", "GetConnectMaps_Lorg_neuroph_nnet_comp_layer_Layer2D_Lorg_neuroph_nnet_comp_layer_Layer2D_Handler")]
		public virtual unsafe void ConnectMaps (global::Org.Neuroph.Nnet.Comp.Layer.Layer2D p0, global::Org.Neuroph.Nnet.Comp.Layer.Layer2D p1)
		{
			if (id_connectMaps_Lorg_neuroph_nnet_comp_layer_Layer2D_Lorg_neuroph_nnet_comp_layer_Layer2D_ == IntPtr.Zero)
				id_connectMaps_Lorg_neuroph_nnet_comp_layer_Layer2D_Lorg_neuroph_nnet_comp_layer_Layer2D_ = JNIEnv.GetMethodID (class_ref, "connectMaps", "(Lorg/neuroph/nnet/comp/layer/Layer2D;Lorg/neuroph/nnet/comp/layer/Layer2D;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_connectMaps_Lorg_neuroph_nnet_comp_layer_Layer2D_Lorg_neuroph_nnet_comp_layer_Layer2D_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "connectMaps", "(Lorg/neuroph/nnet/comp/layer/Layer2D;Lorg/neuroph/nnet/comp/layer/Layer2D;)V"), __args);
			} finally {
			}
		}

		static IntPtr id_createFeatureMaps_ILorg_neuroph_nnet_comp_layer_Layer2D_Dimensions_Lorg_neuroph_util_NeuronProperties_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.comp.layer']/class[@name='FeatureMapsLayer']/method[@name='createFeatureMaps' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='org.neuroph.nnet.comp.layer.Layer2D.Dimensions'] and parameter[3][@type='org.neuroph.util.NeuronProperties']]"
		[Register ("createFeatureMaps", "(ILorg/neuroph/nnet/comp/layer/Layer2D$Dimensions;Lorg/neuroph/util/NeuronProperties;)V", "")]
		protected unsafe void CreateFeatureMaps (int p0, global::Org.Neuroph.Nnet.Comp.Layer.Layer2D.Dimensions p1, global::Org.Neuroph.Util.NeuronProperties p2)
		{
			if (id_createFeatureMaps_ILorg_neuroph_nnet_comp_layer_Layer2D_Dimensions_Lorg_neuroph_util_NeuronProperties_ == IntPtr.Zero)
				id_createFeatureMaps_ILorg_neuroph_nnet_comp_layer_Layer2D_Dimensions_Lorg_neuroph_util_NeuronProperties_ = JNIEnv.GetMethodID (class_ref, "createFeatureMaps", "(ILorg/neuroph/nnet/comp/layer/Layer2D$Dimensions;Lorg/neuroph/util/NeuronProperties;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallVoidMethod  (Handle, id_createFeatureMaps_ILorg_neuroph_nnet_comp_layer_Layer2D_Dimensions_Lorg_neuroph_util_NeuronProperties_, __args);
			} finally {
			}
		}

		static Delegate cb_getFeatureMap_I;
#pragma warning disable 0169
		static Delegate GetGetFeatureMap_IHandler ()
		{
			if (cb_getFeatureMap_I == null)
				cb_getFeatureMap_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetFeatureMap_I);
			return cb_getFeatureMap_I;
		}

		static IntPtr n_GetFeatureMap_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Neuroph.Nnet.Comp.Layer.FeatureMapsLayer __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Comp.Layer.FeatureMapsLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetFeatureMap (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getFeatureMap_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.comp.layer']/class[@name='FeatureMapsLayer']/method[@name='getFeatureMap' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getFeatureMap", "(I)Lorg/neuroph/nnet/comp/layer/Layer2D;", "GetGetFeatureMap_IHandler")]
		public virtual unsafe global::Org.Neuroph.Nnet.Comp.Layer.Layer2D GetFeatureMap (int p0)
		{
			if (id_getFeatureMap_I == IntPtr.Zero)
				id_getFeatureMap_I = JNIEnv.GetMethodID (class_ref, "getFeatureMap", "(I)Lorg/neuroph/nnet/comp/layer/Layer2D;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Comp.Layer.Layer2D> (JNIEnv.CallObjectMethod  (Handle, id_getFeatureMap_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Comp.Layer.Layer2D> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFeatureMap", "(I)Lorg/neuroph/nnet/comp/layer/Layer2D;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getNeuronAt_III;
#pragma warning disable 0169
		static Delegate GetGetNeuronAt_IIIHandler ()
		{
			if (cb_getNeuronAt_III == null)
				cb_getNeuronAt_III = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, int, IntPtr>) n_GetNeuronAt_III);
			return cb_getNeuronAt_III;
		}

		static IntPtr n_GetNeuronAt_III (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2)
		{
			global::Org.Neuroph.Nnet.Comp.Layer.FeatureMapsLayer __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Comp.Layer.FeatureMapsLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetNeuronAt (p0, p1, p2));
		}
#pragma warning restore 0169

		static IntPtr id_getNeuronAt_III;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.comp.layer']/class[@name='FeatureMapsLayer']/method[@name='getNeuronAt' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("getNeuronAt", "(III)Lorg/neuroph/core/Neuron;", "GetGetNeuronAt_IIIHandler")]
		public virtual unsafe global::Org.Neuroph.Core.Neuron GetNeuronAt (int p0, int p1, int p2)
		{
			if (id_getNeuronAt_III == IntPtr.Zero)
				id_getNeuronAt_III = JNIEnv.GetMethodID (class_ref, "getNeuronAt", "(III)Lorg/neuroph/core/Neuron;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Neuron> (JNIEnv.CallObjectMethod  (Handle, id_getNeuronAt_III, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Neuron> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNeuronAt", "(III)Lorg/neuroph/core/Neuron;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
