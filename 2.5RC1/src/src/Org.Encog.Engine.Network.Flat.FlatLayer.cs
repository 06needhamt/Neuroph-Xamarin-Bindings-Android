using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Encog.Engine.Network.Flat {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.encog.engine.network.flat']/class[@name='FlatLayer']"
	[global::Android.Runtime.Register ("org/encog/engine/network/flat/FlatLayer", DoNotGenerateAcw=true)]
	public partial class FlatLayer : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/encog/engine/network/flat/FlatLayer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FlatLayer); }
		}

		protected FlatLayer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_encog_engine_network_activation_ActivationFunction_IDarrayD;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.encog.engine.network.flat']/class[@name='FlatLayer']/constructor[@name='FlatLayer' and count(parameter)=4 and parameter[1][@type='org.encog.engine.network.activation.ActivationFunction'] and parameter[2][@type='int'] and parameter[3][@type='double'] and parameter[4][@type='double[]']]"
		[Register (".ctor", "(Lorg/encog/engine/network/activation/ActivationFunction;ID[D)V", "")]
		public unsafe FlatLayer (global::Org.Encog.Engine.Network.Activation.IActivationFunction p0, int p1, double p2, double[] p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p3 = JNIEnv.NewArray (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				if (GetType () != typeof (FlatLayer)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/encog/engine/network/activation/ActivationFunction;ID[D)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/encog/engine/network/activation/ActivationFunction;ID[D)V", __args);
					return;
				}

				if (id_ctor_Lorg_encog_engine_network_activation_ActivationFunction_IDarrayD == IntPtr.Zero)
					id_ctor_Lorg_encog_engine_network_activation_ActivationFunction_IDarrayD = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/encog/engine/network/activation/ActivationFunction;ID[D)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_encog_engine_network_activation_ActivationFunction_IDarrayD, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_encog_engine_network_activation_ActivationFunction_IDarrayD, __args);
			} finally {
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
			}
		}

		static Delegate cb_getActivation;
#pragma warning disable 0169
		static Delegate GetGetActivationHandler ()
		{
			if (cb_getActivation == null)
				cb_getActivation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetActivation);
			return cb_getActivation;
		}

		static IntPtr n_GetActivation (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Network.Flat.FlatLayer __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Flat.FlatLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Activation);
		}
#pragma warning restore 0169

		static IntPtr id_getActivation;
		public virtual unsafe global::Org.Encog.Engine.Network.Activation.IActivationFunction Activation {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.flat']/class[@name='FlatLayer']/method[@name='getActivation' and count(parameter)=0]"
			[Register ("getActivation", "()Lorg/encog/engine/network/activation/ActivationFunction;", "GetGetActivationHandler")]
			get {
				if (id_getActivation == IntPtr.Zero)
					id_getActivation = JNIEnv.GetMethodID (class_ref, "getActivation", "()Lorg/encog/engine/network/activation/ActivationFunction;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Activation.IActivationFunction> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getActivation), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Activation.IActivationFunction> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getActivation", "()Lorg/encog/engine/network/activation/ActivationFunction;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getBiasActivation;
#pragma warning disable 0169
		static Delegate GetGetBiasActivationHandler ()
		{
			if (cb_getBiasActivation == null)
				cb_getBiasActivation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetBiasActivation);
			return cb_getBiasActivation;
		}

		static double n_GetBiasActivation (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Network.Flat.FlatLayer __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Flat.FlatLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BiasActivation;
		}
#pragma warning restore 0169

		static IntPtr id_getBiasActivation;
		public virtual unsafe double BiasActivation {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.flat']/class[@name='FlatLayer']/method[@name='getBiasActivation' and count(parameter)=0]"
			[Register ("getBiasActivation", "()D", "GetGetBiasActivationHandler")]
			get {
				if (id_getBiasActivation == IntPtr.Zero)
					id_getBiasActivation = JNIEnv.GetMethodID (class_ref, "getBiasActivation", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getBiasActivation);
					else
						return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBiasActivation", "()D"));
				} finally {
				}
			}
		}

		static Delegate cb_getContectCount;
#pragma warning disable 0169
		static Delegate GetGetContectCountHandler ()
		{
			if (cb_getContectCount == null)
				cb_getContectCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetContectCount);
			return cb_getContectCount;
		}

		static int n_GetContectCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Network.Flat.FlatLayer __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Flat.FlatLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ContectCount;
		}
#pragma warning restore 0169

		static IntPtr id_getContectCount;
		public virtual unsafe int ContectCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.flat']/class[@name='FlatLayer']/method[@name='getContectCount' and count(parameter)=0]"
			[Register ("getContectCount", "()I", "GetGetContectCountHandler")]
			get {
				if (id_getContectCount == IntPtr.Zero)
					id_getContectCount = JNIEnv.GetMethodID (class_ref, "getContectCount", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getContectCount);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getContectCount", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getContextFedBy;
#pragma warning disable 0169
		static Delegate GetGetContextFedByHandler ()
		{
			if (cb_getContextFedBy == null)
				cb_getContextFedBy = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContextFedBy);
			return cb_getContextFedBy;
		}

		static IntPtr n_GetContextFedBy (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Network.Flat.FlatLayer __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Flat.FlatLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ContextFedBy);
		}
#pragma warning restore 0169

		static Delegate cb_setContextFedBy_Lorg_encog_engine_network_flat_FlatLayer_;
#pragma warning disable 0169
		static Delegate GetSetContextFedBy_Lorg_encog_engine_network_flat_FlatLayer_Handler ()
		{
			if (cb_setContextFedBy_Lorg_encog_engine_network_flat_FlatLayer_ == null)
				cb_setContextFedBy_Lorg_encog_engine_network_flat_FlatLayer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetContextFedBy_Lorg_encog_engine_network_flat_FlatLayer_);
			return cb_setContextFedBy_Lorg_encog_engine_network_flat_FlatLayer_;
		}

		static void n_SetContextFedBy_Lorg_encog_engine_network_flat_FlatLayer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Encog.Engine.Network.Flat.FlatLayer __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Flat.FlatLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Encog.Engine.Network.Flat.FlatLayer p0 = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Flat.FlatLayer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ContextFedBy = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getContextFedBy;
		static IntPtr id_setContextFedBy_Lorg_encog_engine_network_flat_FlatLayer_;
		public virtual unsafe global::Org.Encog.Engine.Network.Flat.FlatLayer ContextFedBy {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.flat']/class[@name='FlatLayer']/method[@name='getContextFedBy' and count(parameter)=0]"
			[Register ("getContextFedBy", "()Lorg/encog/engine/network/flat/FlatLayer;", "GetGetContextFedByHandler")]
			get {
				if (id_getContextFedBy == IntPtr.Zero)
					id_getContextFedBy = JNIEnv.GetMethodID (class_ref, "getContextFedBy", "()Lorg/encog/engine/network/flat/FlatLayer;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Flat.FlatLayer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getContextFedBy), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Flat.FlatLayer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getContextFedBy", "()Lorg/encog/engine/network/flat/FlatLayer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.flat']/class[@name='FlatLayer']/method[@name='setContextFedBy' and count(parameter)=1 and parameter[1][@type='org.encog.engine.network.flat.FlatLayer']]"
			[Register ("setContextFedBy", "(Lorg/encog/engine/network/flat/FlatLayer;)V", "GetSetContextFedBy_Lorg_encog_engine_network_flat_FlatLayer_Handler")]
			set {
				if (id_setContextFedBy_Lorg_encog_engine_network_flat_FlatLayer_ == IntPtr.Zero)
					id_setContextFedBy_Lorg_encog_engine_network_flat_FlatLayer_ = JNIEnv.GetMethodID (class_ref, "setContextFedBy", "(Lorg/encog/engine/network/flat/FlatLayer;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setContextFedBy_Lorg_encog_engine_network_flat_FlatLayer_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setContextFedBy", "(Lorg/encog/engine/network/flat/FlatLayer;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getCount;
#pragma warning disable 0169
		static Delegate GetGetCountHandler ()
		{
			if (cb_getCount == null)
				cb_getCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCount);
			return cb_getCount;
		}

		static int n_GetCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Network.Flat.FlatLayer __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Flat.FlatLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Count;
		}
#pragma warning restore 0169

		static IntPtr id_getCount;
		public virtual unsafe int Count {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.flat']/class[@name='FlatLayer']/method[@name='getCount' and count(parameter)=0]"
			[Register ("getCount", "()I", "GetGetCountHandler")]
			get {
				if (id_getCount == IntPtr.Zero)
					id_getCount = JNIEnv.GetMethodID (class_ref, "getCount", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getCount);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCount", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_isBias;
#pragma warning disable 0169
		static Delegate GetIsBiasHandler ()
		{
			if (cb_isBias == null)
				cb_isBias = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsBias);
			return cb_isBias;
		}

		static bool n_IsBias (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Network.Flat.FlatLayer __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Flat.FlatLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsBias;
		}
#pragma warning restore 0169

		static IntPtr id_isBias;
		public virtual unsafe bool IsBias {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.flat']/class[@name='FlatLayer']/method[@name='isBias' and count(parameter)=0]"
			[Register ("isBias", "()Z", "GetIsBiasHandler")]
			get {
				if (id_isBias == IntPtr.Zero)
					id_isBias = JNIEnv.GetMethodID (class_ref, "isBias", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isBias);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isBias", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getTotalCount;
#pragma warning disable 0169
		static Delegate GetGetTotalCountHandler ()
		{
			if (cb_getTotalCount == null)
				cb_getTotalCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTotalCount);
			return cb_getTotalCount;
		}

		static int n_GetTotalCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Network.Flat.FlatLayer __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Flat.FlatLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TotalCount;
		}
#pragma warning restore 0169

		static IntPtr id_getTotalCount;
		public virtual unsafe int TotalCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.flat']/class[@name='FlatLayer']/method[@name='getTotalCount' and count(parameter)=0]"
			[Register ("getTotalCount", "()I", "GetGetTotalCountHandler")]
			get {
				if (id_getTotalCount == IntPtr.Zero)
					id_getTotalCount = JNIEnv.GetMethodID (class_ref, "getTotalCount", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getTotalCount);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTotalCount", "()I"));
				} finally {
				}
			}
		}

	}
}
