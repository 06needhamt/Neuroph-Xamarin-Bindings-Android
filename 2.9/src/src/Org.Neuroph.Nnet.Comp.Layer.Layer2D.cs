using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Nnet.Comp.Layer {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.nnet.comp.layer']/class[@name='Layer2D']"
	[global::Android.Runtime.Register ("org/neuroph/nnet/comp/layer/Layer2D", DoNotGenerateAcw=true)]
	public partial class Layer2D : global::Org.Neuroph.Core.Layer {

		// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.nnet.comp.layer']/class[@name='Layer2D.Dimensions']"
		[global::Android.Runtime.Register ("org/neuroph/nnet/comp/layer/Layer2D$Dimensions", DoNotGenerateAcw=true)]
		public partial class Dimensions : global::Java.Lang.Object, global::Java.IO.ISerializable {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/neuroph/nnet/comp/layer/Layer2D$Dimensions", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Dimensions); }
			}

			protected Dimensions (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_II;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.nnet.comp.layer']/class[@name='Layer2D.Dimensions']/constructor[@name='Layer2D.Dimensions' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register (".ctor", "(II)V", "")]
			public unsafe Dimensions (int p0, int p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					if (GetType () != typeof (Dimensions)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(II)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(II)V", __args);
						return;
					}

					if (id_ctor_II == IntPtr.Zero)
						id_ctor_II = JNIEnv.GetMethodID (class_ref, "<init>", "(II)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_II, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_II, __args);
				} finally {
				}
			}

			static Delegate cb_getHeight;
#pragma warning disable 0169
			static Delegate GetGetHeightHandler ()
			{
				if (cb_getHeight == null)
					cb_getHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHeight);
				return cb_getHeight;
			}

			static int n_GetHeight (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Neuroph.Nnet.Comp.Layer.Layer2D.Dimensions __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Comp.Layer.Layer2D.Dimensions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Height;
			}
#pragma warning restore 0169

			static Delegate cb_setHeight_I;
#pragma warning disable 0169
			static Delegate GetSetHeight_IHandler ()
			{
				if (cb_setHeight_I == null)
					cb_setHeight_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetHeight_I);
				return cb_setHeight_I;
			}

			static void n_SetHeight_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Org.Neuroph.Nnet.Comp.Layer.Layer2D.Dimensions __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Comp.Layer.Layer2D.Dimensions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Height = p0;
			}
#pragma warning restore 0169

			static IntPtr id_getHeight;
			static IntPtr id_setHeight_I;
			public virtual unsafe int Height {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.comp.layer']/class[@name='Layer2D.Dimensions']/method[@name='getHeight' and count(parameter)=0]"
				[Register ("getHeight", "()I", "GetGetHeightHandler")]
				get {
					if (id_getHeight == IntPtr.Zero)
						id_getHeight = JNIEnv.GetMethodID (class_ref, "getHeight", "()I");
					try {

						if (GetType () == ThresholdType)
							return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getHeight);
						else
							return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHeight", "()I"));
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.comp.layer']/class[@name='Layer2D.Dimensions']/method[@name='setHeight' and count(parameter)=1 and parameter[1][@type='int']]"
				[Register ("setHeight", "(I)V", "GetSetHeight_IHandler")]
				set {
					if (id_setHeight_I == IntPtr.Zero)
						id_setHeight_I = JNIEnv.GetMethodID (class_ref, "setHeight", "(I)V");
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (value);

						if (GetType () == ThresholdType)
							JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setHeight_I, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setHeight", "(I)V"), __args);
					} finally {
					}
				}
			}

			static Delegate cb_getWidth;
#pragma warning disable 0169
			static Delegate GetGetWidthHandler ()
			{
				if (cb_getWidth == null)
					cb_getWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetWidth);
				return cb_getWidth;
			}

			static int n_GetWidth (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Neuroph.Nnet.Comp.Layer.Layer2D.Dimensions __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Comp.Layer.Layer2D.Dimensions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Width;
			}
#pragma warning restore 0169

			static Delegate cb_setWidth_I;
#pragma warning disable 0169
			static Delegate GetSetWidth_IHandler ()
			{
				if (cb_setWidth_I == null)
					cb_setWidth_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetWidth_I);
				return cb_setWidth_I;
			}

			static void n_SetWidth_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Org.Neuroph.Nnet.Comp.Layer.Layer2D.Dimensions __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Comp.Layer.Layer2D.Dimensions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Width = p0;
			}
#pragma warning restore 0169

			static IntPtr id_getWidth;
			static IntPtr id_setWidth_I;
			public virtual unsafe int Width {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.comp.layer']/class[@name='Layer2D.Dimensions']/method[@name='getWidth' and count(parameter)=0]"
				[Register ("getWidth", "()I", "GetGetWidthHandler")]
				get {
					if (id_getWidth == IntPtr.Zero)
						id_getWidth = JNIEnv.GetMethodID (class_ref, "getWidth", "()I");
					try {

						if (GetType () == ThresholdType)
							return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getWidth);
						else
							return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWidth", "()I"));
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.comp.layer']/class[@name='Layer2D.Dimensions']/method[@name='setWidth' and count(parameter)=1 and parameter[1][@type='int']]"
				[Register ("setWidth", "(I)V", "GetSetWidth_IHandler")]
				set {
					if (id_setWidth_I == IntPtr.Zero)
						id_setWidth_I = JNIEnv.GetMethodID (class_ref, "setWidth", "(I)V");
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (value);

						if (GetType () == ThresholdType)
							JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setWidth_I, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setWidth", "(I)V"), __args);
					} finally {
					}
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/nnet/comp/layer/Layer2D", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Layer2D); }
		}

		protected Layer2D (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_neuroph_nnet_comp_layer_Layer2D_Dimensions_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.nnet.comp.layer']/class[@name='Layer2D']/constructor[@name='Layer2D' and count(parameter)=1 and parameter[1][@type='org.neuroph.nnet.comp.layer.Layer2D.Dimensions']]"
		[Register (".ctor", "(Lorg/neuroph/nnet/comp/layer/Layer2D$Dimensions;)V", "")]
		public unsafe Layer2D (global::Org.Neuroph.Nnet.Comp.Layer.Layer2D.Dimensions p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (Layer2D)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/neuroph/nnet/comp/layer/Layer2D$Dimensions;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/neuroph/nnet/comp/layer/Layer2D$Dimensions;)V", __args);
					return;
				}

				if (id_ctor_Lorg_neuroph_nnet_comp_layer_Layer2D_Dimensions_ == IntPtr.Zero)
					id_ctor_Lorg_neuroph_nnet_comp_layer_Layer2D_Dimensions_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/neuroph/nnet/comp/layer/Layer2D$Dimensions;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_neuroph_nnet_comp_layer_Layer2D_Dimensions_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_neuroph_nnet_comp_layer_Layer2D_Dimensions_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Lorg_neuroph_nnet_comp_layer_Layer2D_Dimensions_Lorg_neuroph_util_NeuronProperties_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.nnet.comp.layer']/class[@name='Layer2D']/constructor[@name='Layer2D' and count(parameter)=2 and parameter[1][@type='org.neuroph.nnet.comp.layer.Layer2D.Dimensions'] and parameter[2][@type='org.neuroph.util.NeuronProperties']]"
		[Register (".ctor", "(Lorg/neuroph/nnet/comp/layer/Layer2D$Dimensions;Lorg/neuroph/util/NeuronProperties;)V", "")]
		public unsafe Layer2D (global::Org.Neuroph.Nnet.Comp.Layer.Layer2D.Dimensions p0, global::Org.Neuroph.Util.NeuronProperties p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (Layer2D)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/neuroph/nnet/comp/layer/Layer2D$Dimensions;Lorg/neuroph/util/NeuronProperties;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/neuroph/nnet/comp/layer/Layer2D$Dimensions;Lorg/neuroph/util/NeuronProperties;)V", __args);
					return;
				}

				if (id_ctor_Lorg_neuroph_nnet_comp_layer_Layer2D_Dimensions_Lorg_neuroph_util_NeuronProperties_ == IntPtr.Zero)
					id_ctor_Lorg_neuroph_nnet_comp_layer_Layer2D_Dimensions_Lorg_neuroph_util_NeuronProperties_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/neuroph/nnet/comp/layer/Layer2D$Dimensions;Lorg/neuroph/util/NeuronProperties;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_neuroph_nnet_comp_layer_Layer2D_Dimensions_Lorg_neuroph_util_NeuronProperties_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_neuroph_nnet_comp_layer_Layer2D_Dimensions_Lorg_neuroph_util_NeuronProperties_, __args);
			} finally {
			}
		}

		static Delegate cb_getHeight;
#pragma warning disable 0169
		static Delegate GetGetHeightHandler ()
		{
			if (cb_getHeight == null)
				cb_getHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHeight);
			return cb_getHeight;
		}

		static int n_GetHeight (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Nnet.Comp.Layer.Layer2D __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Comp.Layer.Layer2D> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Height;
		}
#pragma warning restore 0169

		static IntPtr id_getHeight;
		public virtual unsafe int Height {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.comp.layer']/class[@name='Layer2D']/method[@name='getHeight' and count(parameter)=0]"
			[Register ("getHeight", "()I", "GetGetHeightHandler")]
			get {
				if (id_getHeight == IntPtr.Zero)
					id_getHeight = JNIEnv.GetMethodID (class_ref, "getHeight", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getHeight);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHeight", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getWidth;
#pragma warning disable 0169
		static Delegate GetGetWidthHandler ()
		{
			if (cb_getWidth == null)
				cb_getWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetWidth);
			return cb_getWidth;
		}

		static int n_GetWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Nnet.Comp.Layer.Layer2D __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Comp.Layer.Layer2D> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Width;
		}
#pragma warning restore 0169

		static IntPtr id_getWidth;
		public virtual unsafe int Width {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.comp.layer']/class[@name='Layer2D']/method[@name='getWidth' and count(parameter)=0]"
			[Register ("getWidth", "()I", "GetGetWidthHandler")]
			get {
				if (id_getWidth == IntPtr.Zero)
					id_getWidth = JNIEnv.GetMethodID (class_ref, "getWidth", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getWidth);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWidth", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getDimensions;
#pragma warning disable 0169
		static Delegate GetGetDimensionsHandler ()
		{
			if (cb_getDimensions == null)
				cb_getDimensions = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDimensions);
			return cb_getDimensions;
		}

		static IntPtr n_GetDimensions (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Nnet.Comp.Layer.Layer2D __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Comp.Layer.Layer2D> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetDimensions ());
		}
#pragma warning restore 0169

		static IntPtr id_getDimensions;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.comp.layer']/class[@name='Layer2D']/method[@name='getDimensions' and count(parameter)=0]"
		[Register ("getDimensions", "()Lorg/neuroph/nnet/comp/layer/Layer2D$Dimensions;", "GetGetDimensionsHandler")]
		public virtual unsafe global::Org.Neuroph.Nnet.Comp.Layer.Layer2D.Dimensions GetDimensions ()
		{
			if (id_getDimensions == IntPtr.Zero)
				id_getDimensions = JNIEnv.GetMethodID (class_ref, "getDimensions", "()Lorg/neuroph/nnet/comp/layer/Layer2D$Dimensions;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Comp.Layer.Layer2D.Dimensions> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDimensions), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Comp.Layer.Layer2D.Dimensions> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDimensions", "()Lorg/neuroph/nnet/comp/layer/Layer2D$Dimensions;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getNeuronAt_II;
#pragma warning disable 0169
		static Delegate GetGetNeuronAt_IIHandler ()
		{
			if (cb_getNeuronAt_II == null)
				cb_getNeuronAt_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr>) n_GetNeuronAt_II);
			return cb_getNeuronAt_II;
		}

		static IntPtr n_GetNeuronAt_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Org.Neuroph.Nnet.Comp.Layer.Layer2D __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Comp.Layer.Layer2D> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetNeuronAt (p0, p1));
		}
#pragma warning restore 0169

		static IntPtr id_getNeuronAt_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.comp.layer']/class[@name='Layer2D']/method[@name='getNeuronAt' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("getNeuronAt", "(II)Lorg/neuroph/core/Neuron;", "GetGetNeuronAt_IIHandler")]
		public virtual unsafe global::Org.Neuroph.Core.Neuron GetNeuronAt (int p0, int p1)
		{
			if (id_getNeuronAt_II == IntPtr.Zero)
				id_getNeuronAt_II = JNIEnv.GetMethodID (class_ref, "getNeuronAt", "(II)Lorg/neuroph/core/Neuron;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Neuron> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNeuronAt_II, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Neuron> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNeuronAt", "(II)Lorg/neuroph/core/Neuron;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
