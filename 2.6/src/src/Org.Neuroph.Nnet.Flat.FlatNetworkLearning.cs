using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Nnet.Flat {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.nnet.flat']/class[@name='FlatNetworkLearning']"
	[global::Android.Runtime.Register ("org/neuroph/nnet/flat/FlatNetworkLearning", DoNotGenerateAcw=true)]
	public partial class FlatNetworkLearning : global::Org.Neuroph.Core.Learning.SupervisedLearning, global::Java.IO.ISerializable {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/nnet/flat/FlatNetworkLearning", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FlatNetworkLearning); }
		}

		protected FlatNetworkLearning (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_encog_engine_network_flat_FlatNetwork_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.nnet.flat']/class[@name='FlatNetworkLearning']/constructor[@name='FlatNetworkLearning' and count(parameter)=1 and parameter[1][@type='org.encog.engine.network.flat.FlatNetwork']]"
		[Register (".ctor", "(Lorg/encog/engine/network/flat/FlatNetwork;)V", "")]
		public unsafe FlatNetworkLearning (global::Org.Encog.Engine.Network.Flat.FlatNetwork p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (FlatNetworkLearning)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/encog/engine/network/flat/FlatNetwork;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorg/encog/engine/network/flat/FlatNetwork;)V", __args);
					return;
				}

				if (id_ctor_Lorg_encog_engine_network_flat_FlatNetwork_ == IntPtr.Zero)
					id_ctor_Lorg_encog_engine_network_flat_FlatNetwork_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/encog/engine/network/flat/FlatNetwork;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_encog_engine_network_flat_FlatNetwork_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_encog_engine_network_flat_FlatNetwork_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Lorg_neuroph_core_NeuralNetwork_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.nnet.flat']/class[@name='FlatNetworkLearning']/constructor[@name='FlatNetworkLearning' and count(parameter)=1 and parameter[1][@type='org.neuroph.core.NeuralNetwork']]"
		[Register (".ctor", "(Lorg/neuroph/core/NeuralNetwork;)V", "")]
		public unsafe FlatNetworkLearning (global::Org.Neuroph.Core.NeuralNetwork p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (FlatNetworkLearning)) {
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

		static Delegate cb_getLearningType;
#pragma warning disable 0169
		static Delegate GetGetLearningTypeHandler ()
		{
			if (cb_getLearningType == null)
				cb_getLearningType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLearningType);
			return cb_getLearningType;
		}

		static IntPtr n_GetLearningType (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Nnet.Flat.FlatNetworkLearning __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Flat.FlatNetworkLearning> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LearningType);
		}
#pragma warning restore 0169

		static Delegate cb_setLearningType_Lorg_neuroph_nnet_flat_FlatLearningType_;
#pragma warning disable 0169
		static Delegate GetSetLearningType_Lorg_neuroph_nnet_flat_FlatLearningType_Handler ()
		{
			if (cb_setLearningType_Lorg_neuroph_nnet_flat_FlatLearningType_ == null)
				cb_setLearningType_Lorg_neuroph_nnet_flat_FlatLearningType_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLearningType_Lorg_neuroph_nnet_flat_FlatLearningType_);
			return cb_setLearningType_Lorg_neuroph_nnet_flat_FlatLearningType_;
		}

		static void n_SetLearningType_Lorg_neuroph_nnet_flat_FlatLearningType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Nnet.Flat.FlatNetworkLearning __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Flat.FlatNetworkLearning> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Nnet.Flat.FlatLearningType p0 = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Flat.FlatLearningType> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LearningType = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getLearningType;
		static IntPtr id_setLearningType_Lorg_neuroph_nnet_flat_FlatLearningType_;
		public virtual unsafe global::Org.Neuroph.Nnet.Flat.FlatLearningType LearningType {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.flat']/class[@name='FlatNetworkLearning']/method[@name='getLearningType' and count(parameter)=0]"
			[Register ("getLearningType", "()Lorg/neuroph/nnet/flat/FlatLearningType;", "GetGetLearningTypeHandler")]
			get {
				if (id_getLearningType == IntPtr.Zero)
					id_getLearningType = JNIEnv.GetMethodID (class_ref, "getLearningType", "()Lorg/neuroph/nnet/flat/FlatLearningType;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Flat.FlatLearningType> (JNIEnv.CallObjectMethod  (Handle, id_getLearningType), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Flat.FlatLearningType> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLearningType", "()Lorg/neuroph/nnet/flat/FlatLearningType;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.flat']/class[@name='FlatNetworkLearning']/method[@name='setLearningType' and count(parameter)=1 and parameter[1][@type='org.neuroph.nnet.flat.FlatLearningType']]"
			[Register ("setLearningType", "(Lorg/neuroph/nnet/flat/FlatLearningType;)V", "GetSetLearningType_Lorg_neuroph_nnet_flat_FlatLearningType_Handler")]
			set {
				if (id_setLearningType_Lorg_neuroph_nnet_flat_FlatLearningType_ == IntPtr.Zero)
					id_setLearningType_Lorg_neuroph_nnet_flat_FlatLearningType_ = JNIEnv.GetMethodID (class_ref, "setLearningType", "(Lorg/neuroph/nnet/flat/FlatLearningType;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setLearningType_Lorg_neuroph_nnet_flat_FlatLearningType_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLearningType", "(Lorg/neuroph/nnet/flat/FlatLearningType;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMomentum;
#pragma warning disable 0169
		static Delegate GetGetMomentumHandler ()
		{
			if (cb_getMomentum == null)
				cb_getMomentum = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetMomentum);
			return cb_getMomentum;
		}

		static double n_GetMomentum (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Nnet.Flat.FlatNetworkLearning __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Flat.FlatNetworkLearning> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Momentum;
		}
#pragma warning restore 0169

		static Delegate cb_setMomentum_D;
#pragma warning disable 0169
		static Delegate GetSetMomentum_DHandler ()
		{
			if (cb_setMomentum_D == null)
				cb_setMomentum_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetMomentum_D);
			return cb_setMomentum_D;
		}

		static void n_SetMomentum_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Org.Neuroph.Nnet.Flat.FlatNetworkLearning __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Flat.FlatNetworkLearning> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Momentum = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMomentum;
		static IntPtr id_setMomentum_D;
		public virtual unsafe double Momentum {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.flat']/class[@name='FlatNetworkLearning']/method[@name='getMomentum' and count(parameter)=0]"
			[Register ("getMomentum", "()D", "GetGetMomentumHandler")]
			get {
				if (id_getMomentum == IntPtr.Zero)
					id_getMomentum = JNIEnv.GetMethodID (class_ref, "getMomentum", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod  (Handle, id_getMomentum);
					else
						return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMomentum", "()D"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.flat']/class[@name='FlatNetworkLearning']/method[@name='setMomentum' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setMomentum", "(D)V", "GetSetMomentum_DHandler")]
			set {
				if (id_setMomentum_D == IntPtr.Zero)
					id_setMomentum_D = JNIEnv.GetMethodID (class_ref, "setMomentum", "(D)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setMomentum_D, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMomentum", "(D)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getNumThreads;
#pragma warning disable 0169
		static Delegate GetGetNumThreadsHandler ()
		{
			if (cb_getNumThreads == null)
				cb_getNumThreads = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNumThreads);
			return cb_getNumThreads;
		}

		static int n_GetNumThreads (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Nnet.Flat.FlatNetworkLearning __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Flat.FlatNetworkLearning> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NumThreads;
		}
#pragma warning restore 0169

		static Delegate cb_setNumThreads_I;
#pragma warning disable 0169
		static Delegate GetSetNumThreads_IHandler ()
		{
			if (cb_setNumThreads_I == null)
				cb_setNumThreads_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetNumThreads_I);
			return cb_setNumThreads_I;
		}

		static void n_SetNumThreads_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Neuroph.Nnet.Flat.FlatNetworkLearning __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Flat.FlatNetworkLearning> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NumThreads = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getNumThreads;
		static IntPtr id_setNumThreads_I;
		public virtual unsafe int NumThreads {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.flat']/class[@name='FlatNetworkLearning']/method[@name='getNumThreads' and count(parameter)=0]"
			[Register ("getNumThreads", "()I", "GetGetNumThreadsHandler")]
			get {
				if (id_getNumThreads == IntPtr.Zero)
					id_getNumThreads = JNIEnv.GetMethodID (class_ref, "getNumThreads", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getNumThreads);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNumThreads", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.flat']/class[@name='FlatNetworkLearning']/method[@name='setNumThreads' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setNumThreads", "(I)V", "GetSetNumThreads_IHandler")]
			set {
				if (id_setNumThreads_I == IntPtr.Zero)
					id_setNumThreads_I = JNIEnv.GetMethodID (class_ref, "setNumThreads", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setNumThreads_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNumThreads", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_updateNetworkWeights_arrayD;
#pragma warning disable 0169
		static Delegate GetUpdateNetworkWeights_arrayDHandler ()
		{
			if (cb_updateNetworkWeights_arrayD == null)
				cb_updateNetworkWeights_arrayD = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UpdateNetworkWeights_arrayD);
			return cb_updateNetworkWeights_arrayD;
		}

		static void n_UpdateNetworkWeights_arrayD (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Nnet.Flat.FlatNetworkLearning __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Flat.FlatNetworkLearning> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			double[] p0 = (double[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (double));
			__this.UpdateNetworkWeights (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_updateNetworkWeights_arrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.flat']/class[@name='FlatNetworkLearning']/method[@name='updateNetworkWeights' and count(parameter)=1 and parameter[1][@type='double[]']]"
		[Register ("updateNetworkWeights", "([D)V", "GetUpdateNetworkWeights_arrayDHandler")]
		protected override unsafe void UpdateNetworkWeights (double[] p0)
		{
			if (id_updateNetworkWeights_arrayD == IntPtr.Zero)
				id_updateNetworkWeights_arrayD = JNIEnv.GetMethodID (class_ref, "updateNetworkWeights", "([D)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_updateNetworkWeights_arrayD, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateNetworkWeights", "([D)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

	}
}
