using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Encog.Engine.Network.Train.Gradient {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.encog.engine.network.train.gradient']/class[@name='GradientWorkerCPU']"
	[global::Android.Runtime.Register ("org/encog/engine/network/train/gradient/GradientWorkerCPU", DoNotGenerateAcw=true)]
	public partial class GradientWorkerCPU : global::Java.Lang.Object, global::Org.Encog.Engine.Network.Train.Gradient.IFlatGradientWorker {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/encog/engine/network/train/gradient/GradientWorkerCPU", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GradientWorkerCPU); }
		}

		protected GradientWorkerCPU (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_encog_engine_network_flat_FlatNetwork_Lorg_encog_engine_network_train_prop_TrainFlatNetworkProp_Lorg_encog_engine_data_EngineIndexableSet_II;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.encog.engine.network.train.gradient']/class[@name='GradientWorkerCPU']/constructor[@name='GradientWorkerCPU' and count(parameter)=5 and parameter[1][@type='org.encog.engine.network.flat.FlatNetwork'] and parameter[2][@type='org.encog.engine.network.train.prop.TrainFlatNetworkProp'] and parameter[3][@type='org.encog.engine.data.EngineIndexableSet'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register (".ctor", "(Lorg/encog/engine/network/flat/FlatNetwork;Lorg/encog/engine/network/train/prop/TrainFlatNetworkProp;Lorg/encog/engine/data/EngineIndexableSet;II)V", "")]
		public unsafe GradientWorkerCPU (global::Org.Encog.Engine.Network.Flat.FlatNetwork p0, global::Org.Encog.Engine.Network.Train.Prop.TrainFlatNetworkProp p1, global::Org.Encog.Engine.Data.IEngineIndexableSet p2, int p3, int p4)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				if (GetType () != typeof (GradientWorkerCPU)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/encog/engine/network/flat/FlatNetwork;Lorg/encog/engine/network/train/prop/TrainFlatNetworkProp;Lorg/encog/engine/data/EngineIndexableSet;II)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorg/encog/engine/network/flat/FlatNetwork;Lorg/encog/engine/network/train/prop/TrainFlatNetworkProp;Lorg/encog/engine/data/EngineIndexableSet;II)V", __args);
					return;
				}

				if (id_ctor_Lorg_encog_engine_network_flat_FlatNetwork_Lorg_encog_engine_network_train_prop_TrainFlatNetworkProp_Lorg_encog_engine_data_EngineIndexableSet_II == IntPtr.Zero)
					id_ctor_Lorg_encog_engine_network_flat_FlatNetwork_Lorg_encog_engine_network_train_prop_TrainFlatNetworkProp_Lorg_encog_engine_data_EngineIndexableSet_II = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/encog/engine/network/flat/FlatNetwork;Lorg/encog/engine/network/train/prop/TrainFlatNetworkProp;Lorg/encog/engine/data/EngineIndexableSet;II)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_encog_engine_network_flat_FlatNetwork_Lorg_encog_engine_network_train_prop_TrainFlatNetworkProp_Lorg_encog_engine_data_EngineIndexableSet_II, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_encog_engine_network_flat_FlatNetwork_Lorg_encog_engine_network_train_prop_TrainFlatNetworkProp_Lorg_encog_engine_data_EngineIndexableSet_II, __args);
			} finally {
			}
		}

		static Delegate cb_getElapsedTime;
#pragma warning disable 0169
		static Delegate GetGetElapsedTimeHandler ()
		{
			if (cb_getElapsedTime == null)
				cb_getElapsedTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetElapsedTime);
			return cb_getElapsedTime;
		}

		static long n_GetElapsedTime (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Network.Train.Gradient.GradientWorkerCPU __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Train.Gradient.GradientWorkerCPU> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ElapsedTime;
		}
#pragma warning restore 0169

		static IntPtr id_getElapsedTime;
		public virtual unsafe long ElapsedTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.train.gradient']/class[@name='GradientWorkerCPU']/method[@name='getElapsedTime' and count(parameter)=0]"
			[Register ("getElapsedTime", "()J", "GetGetElapsedTimeHandler")]
			get {
				if (id_getElapsedTime == IntPtr.Zero)
					id_getElapsedTime = JNIEnv.GetMethodID (class_ref, "getElapsedTime", "()J");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallLongMethod  (Handle, id_getElapsedTime);
					else
						return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getElapsedTime", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_getNetwork;
#pragma warning disable 0169
		static Delegate GetGetNetworkHandler ()
		{
			if (cb_getNetwork == null)
				cb_getNetwork = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNetwork);
			return cb_getNetwork;
		}

		static IntPtr n_GetNetwork (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Network.Train.Gradient.GradientWorkerCPU __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Train.Gradient.GradientWorkerCPU> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Network);
		}
#pragma warning restore 0169

		static IntPtr id_getNetwork;
		public virtual unsafe global::Org.Encog.Engine.Network.Flat.FlatNetwork Network {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.train.gradient']/class[@name='GradientWorkerCPU']/method[@name='getNetwork' and count(parameter)=0]"
			[Register ("getNetwork", "()Lorg/encog/engine/network/flat/FlatNetwork;", "GetGetNetworkHandler")]
			get {
				if (id_getNetwork == IntPtr.Zero)
					id_getNetwork = JNIEnv.GetMethodID (class_ref, "getNetwork", "()Lorg/encog/engine/network/flat/FlatNetwork;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Flat.FlatNetwork> (JNIEnv.CallObjectMethod  (Handle, id_getNetwork), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Flat.FlatNetwork> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNetwork", "()Lorg/encog/engine/network/flat/FlatNetwork;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getWeights;
#pragma warning disable 0169
		static Delegate GetGetWeightsHandler ()
		{
			if (cb_getWeights == null)
				cb_getWeights = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetWeights);
			return cb_getWeights;
		}

		static IntPtr n_GetWeights (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Network.Train.Gradient.GradientWorkerCPU __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Train.Gradient.GradientWorkerCPU> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetWeights ());
		}
#pragma warning restore 0169

		static IntPtr id_getWeights;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.train.gradient']/class[@name='GradientWorkerCPU']/method[@name='getWeights' and count(parameter)=0]"
		[Register ("getWeights", "()[D", "GetGetWeightsHandler")]
		public virtual unsafe double[] GetWeights ()
		{
			if (id_getWeights == IntPtr.Zero)
				id_getWeights = JNIEnv.GetMethodID (class_ref, "getWeights", "()[D");
			try {

				if (GetType () == ThresholdType)
					return (double[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getWeights), JniHandleOwnership.TransferLocalRef, typeof (double));
				else
					return (double[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWeights", "()[D")), JniHandleOwnership.TransferLocalRef, typeof (double));
			} finally {
			}
		}

		static Delegate cb_run;
#pragma warning disable 0169
		static Delegate GetRunHandler ()
		{
			if (cb_run == null)
				cb_run = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Run);
			return cb_run;
		}

		static void n_Run (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Network.Train.Gradient.GradientWorkerCPU __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Train.Gradient.GradientWorkerCPU> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Run ();
		}
#pragma warning restore 0169

		static IntPtr id_run;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.train.gradient']/class[@name='GradientWorkerCPU']/method[@name='run' and count(parameter)=0]"
		[Register ("run", "()V", "GetRunHandler")]
		public virtual unsafe void Run ()
		{
			if (id_run == IntPtr.Zero)
				id_run = JNIEnv.GetMethodID (class_ref, "run", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_run);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "run", "()V"));
			} finally {
			}
		}

	}
}
