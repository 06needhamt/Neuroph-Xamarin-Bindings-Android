using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Encog.Engine.Network.Train.Prop {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.encog.engine.network.train.prop']/class[@name='TrainFlatNetworkOpenCL']"
	[global::Android.Runtime.Register ("org/encog/engine/network/train/prop/TrainFlatNetworkOpenCL", DoNotGenerateAcw=true)]
	public partial class TrainFlatNetworkOpenCL : global::Java.Lang.Object, global::Org.Encog.Engine.Network.Train.ITrainFlatNetwork {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.encog.engine.network.train.prop']/class[@name='TrainFlatNetworkOpenCL']/field[@name='LEARN_BPROP']"
		[Register ("LEARN_BPROP")]
		public const int LearnBprop = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.encog.engine.network.train.prop']/class[@name='TrainFlatNetworkOpenCL']/field[@name='LEARN_RPROP']"
		[Register ("LEARN_RPROP")]
		public const int LearnRprop = (int) 0;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/encog/engine/network/train/prop/TrainFlatNetworkOpenCL", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TrainFlatNetworkOpenCL); }
		}

		protected TrainFlatNetworkOpenCL (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_encog_engine_network_flat_FlatNetwork_Lorg_encog_engine_data_EngineDataSet_Lorg_encog_engine_network_train_prop_OpenCLTrainingProfile_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.encog.engine.network.train.prop']/class[@name='TrainFlatNetworkOpenCL']/constructor[@name='TrainFlatNetworkOpenCL' and count(parameter)=3 and parameter[1][@type='org.encog.engine.network.flat.FlatNetwork'] and parameter[2][@type='org.encog.engine.data.EngineDataSet'] and parameter[3][@type='org.encog.engine.network.train.prop.OpenCLTrainingProfile']]"
		[Register (".ctor", "(Lorg/encog/engine/network/flat/FlatNetwork;Lorg/encog/engine/data/EngineDataSet;Lorg/encog/engine/network/train/prop/OpenCLTrainingProfile;)V", "")]
		public unsafe TrainFlatNetworkOpenCL (global::Org.Encog.Engine.Network.Flat.FlatNetwork p0, global::Org.Encog.Engine.Data.IEngineDataSet p1, global::Org.Encog.Engine.Network.Train.Prop.OpenCLTrainingProfile p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (TrainFlatNetworkOpenCL)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/encog/engine/network/flat/FlatNetwork;Lorg/encog/engine/data/EngineDataSet;Lorg/encog/engine/network/train/prop/OpenCLTrainingProfile;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorg/encog/engine/network/flat/FlatNetwork;Lorg/encog/engine/data/EngineDataSet;Lorg/encog/engine/network/train/prop/OpenCLTrainingProfile;)V", __args);
					return;
				}

				if (id_ctor_Lorg_encog_engine_network_flat_FlatNetwork_Lorg_encog_engine_data_EngineDataSet_Lorg_encog_engine_network_train_prop_OpenCLTrainingProfile_ == IntPtr.Zero)
					id_ctor_Lorg_encog_engine_network_flat_FlatNetwork_Lorg_encog_engine_data_EngineDataSet_Lorg_encog_engine_network_train_prop_OpenCLTrainingProfile_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/encog/engine/network/flat/FlatNetwork;Lorg/encog/engine/data/EngineDataSet;Lorg/encog/engine/network/train/prop/OpenCLTrainingProfile;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_encog_engine_network_flat_FlatNetwork_Lorg_encog_engine_data_EngineDataSet_Lorg_encog_engine_network_train_prop_OpenCLTrainingProfile_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_encog_engine_network_flat_FlatNetwork_Lorg_encog_engine_data_EngineDataSet_Lorg_encog_engine_network_train_prop_OpenCLTrainingProfile_, __args);
			} finally {
			}
		}

		static Delegate cb_getError;
#pragma warning disable 0169
		static Delegate GetGetErrorHandler ()
		{
			if (cb_getError == null)
				cb_getError = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetError);
			return cb_getError;
		}

		static double n_GetError (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Network.Train.Prop.TrainFlatNetworkOpenCL __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Train.Prop.TrainFlatNetworkOpenCL> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Error;
		}
#pragma warning restore 0169

		static IntPtr id_getError;
		public virtual unsafe double Error {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.train.prop']/class[@name='TrainFlatNetworkOpenCL']/method[@name='getError' and count(parameter)=0]"
			[Register ("getError", "()D", "GetGetErrorHandler")]
			get {
				if (id_getError == IntPtr.Zero)
					id_getError = JNIEnv.GetMethodID (class_ref, "getError", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod  (Handle, id_getError);
					else
						return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getError", "()D"));
				} finally {
				}
			}
		}

		static Delegate cb_getIteration;
#pragma warning disable 0169
		static Delegate GetGetIterationHandler ()
		{
			if (cb_getIteration == null)
				cb_getIteration = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetIteration);
			return cb_getIteration;
		}

		static int n_GetIteration (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Network.Train.Prop.TrainFlatNetworkOpenCL __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Train.Prop.TrainFlatNetworkOpenCL> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Iteration;
		}
#pragma warning restore 0169

		static Delegate cb_setIteration_I;
#pragma warning disable 0169
		static Delegate GetSetIteration_IHandler ()
		{
			if (cb_setIteration_I == null)
				cb_setIteration_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetIteration_I);
			return cb_setIteration_I;
		}

		static void n_SetIteration_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Encog.Engine.Network.Train.Prop.TrainFlatNetworkOpenCL __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Train.Prop.TrainFlatNetworkOpenCL> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Iteration = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getIteration;
		static IntPtr id_setIteration_I;
		public virtual unsafe int Iteration {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.train.prop']/class[@name='TrainFlatNetworkOpenCL']/method[@name='getIteration' and count(parameter)=0]"
			[Register ("getIteration", "()I", "GetGetIterationHandler")]
			get {
				if (id_getIteration == IntPtr.Zero)
					id_getIteration = JNIEnv.GetMethodID (class_ref, "getIteration", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getIteration);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIteration", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.train.prop']/class[@name='TrainFlatNetworkOpenCL']/method[@name='setIteration' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setIteration", "(I)V", "GetSetIteration_IHandler")]
			set {
				if (id_setIteration_I == IntPtr.Zero)
					id_setIteration_I = JNIEnv.GetMethodID (class_ref, "setIteration", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setIteration_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setIteration", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getLearningRate;
#pragma warning disable 0169
		static Delegate GetGetLearningRateHandler ()
		{
			if (cb_getLearningRate == null)
				cb_getLearningRate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetLearningRate);
			return cb_getLearningRate;
		}

		static double n_GetLearningRate (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Network.Train.Prop.TrainFlatNetworkOpenCL __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Train.Prop.TrainFlatNetworkOpenCL> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LearningRate;
		}
#pragma warning restore 0169

		static IntPtr id_getLearningRate;
		public virtual unsafe double LearningRate {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.train.prop']/class[@name='TrainFlatNetworkOpenCL']/method[@name='getLearningRate' and count(parameter)=0]"
			[Register ("getLearningRate", "()D", "GetGetLearningRateHandler")]
			get {
				if (id_getLearningRate == IntPtr.Zero)
					id_getLearningRate = JNIEnv.GetMethodID (class_ref, "getLearningRate", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod  (Handle, id_getLearningRate);
					else
						return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLearningRate", "()D"));
				} finally {
				}
			}
		}

		static Delegate cb_getLearningType;
#pragma warning disable 0169
		static Delegate GetGetLearningTypeHandler ()
		{
			if (cb_getLearningType == null)
				cb_getLearningType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetLearningType);
			return cb_getLearningType;
		}

		static int n_GetLearningType (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Network.Train.Prop.TrainFlatNetworkOpenCL __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Train.Prop.TrainFlatNetworkOpenCL> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LearningType;
		}
#pragma warning restore 0169

		static IntPtr id_getLearningType;
		public virtual unsafe int LearningType {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.train.prop']/class[@name='TrainFlatNetworkOpenCL']/method[@name='getLearningType' and count(parameter)=0]"
			[Register ("getLearningType", "()I", "GetGetLearningTypeHandler")]
			get {
				if (id_getLearningType == IntPtr.Zero)
					id_getLearningType = JNIEnv.GetMethodID (class_ref, "getLearningType", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getLearningType);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLearningType", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getMaxStep;
#pragma warning disable 0169
		static Delegate GetGetMaxStepHandler ()
		{
			if (cb_getMaxStep == null)
				cb_getMaxStep = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetMaxStep);
			return cb_getMaxStep;
		}

		static double n_GetMaxStep (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Network.Train.Prop.TrainFlatNetworkOpenCL __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Train.Prop.TrainFlatNetworkOpenCL> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxStep;
		}
#pragma warning restore 0169

		static IntPtr id_getMaxStep;
		public virtual unsafe double MaxStep {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.train.prop']/class[@name='TrainFlatNetworkOpenCL']/method[@name='getMaxStep' and count(parameter)=0]"
			[Register ("getMaxStep", "()D", "GetGetMaxStepHandler")]
			get {
				if (id_getMaxStep == IntPtr.Zero)
					id_getMaxStep = JNIEnv.GetMethodID (class_ref, "getMaxStep", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod  (Handle, id_getMaxStep);
					else
						return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMaxStep", "()D"));
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
			global::Org.Encog.Engine.Network.Train.Prop.TrainFlatNetworkOpenCL __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Train.Prop.TrainFlatNetworkOpenCL> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Momentum;
		}
#pragma warning restore 0169

		static IntPtr id_getMomentum;
		public virtual unsafe double Momentum {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.train.prop']/class[@name='TrainFlatNetworkOpenCL']/method[@name='getMomentum' and count(parameter)=0]"
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
			global::Org.Encog.Engine.Network.Train.Prop.TrainFlatNetworkOpenCL __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Train.Prop.TrainFlatNetworkOpenCL> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Network);
		}
#pragma warning restore 0169

		static IntPtr id_getNetwork;
		public virtual unsafe global::Org.Encog.Engine.Network.Flat.FlatNetwork Network {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.train.prop']/class[@name='TrainFlatNetworkOpenCL']/method[@name='getNetwork' and count(parameter)=0]"
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
			global::Org.Encog.Engine.Network.Train.Prop.TrainFlatNetworkOpenCL __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Train.Prop.TrainFlatNetworkOpenCL> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Org.Encog.Engine.Network.Train.Prop.TrainFlatNetworkOpenCL __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Train.Prop.TrainFlatNetworkOpenCL> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NumThreads = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getNumThreads;
		static IntPtr id_setNumThreads_I;
		public virtual unsafe int NumThreads {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.train.prop']/class[@name='TrainFlatNetworkOpenCL']/method[@name='getNumThreads' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.train.prop']/class[@name='TrainFlatNetworkOpenCL']/method[@name='setNumThreads' and count(parameter)=1 and parameter[1][@type='int']]"
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

		static Delegate cb_getTraining;
#pragma warning disable 0169
		static Delegate GetGetTrainingHandler ()
		{
			if (cb_getTraining == null)
				cb_getTraining = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTraining);
			return cb_getTraining;
		}

		static IntPtr n_GetTraining (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Network.Train.Prop.TrainFlatNetworkOpenCL __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Train.Prop.TrainFlatNetworkOpenCL> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Training);
		}
#pragma warning restore 0169

		static IntPtr id_getTraining;
		public virtual unsafe global::Org.Encog.Engine.Data.IEngineDataSet Training {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.train.prop']/class[@name='TrainFlatNetworkOpenCL']/method[@name='getTraining' and count(parameter)=0]"
			[Register ("getTraining", "()Lorg/encog/engine/data/EngineDataSet;", "GetGetTrainingHandler")]
			get {
				if (id_getTraining == IntPtr.Zero)
					id_getTraining = JNIEnv.GetMethodID (class_ref, "getTraining", "()Lorg/encog/engine/data/EngineDataSet;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Data.IEngineDataSet> (JNIEnv.CallObjectMethod  (Handle, id_getTraining), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Data.IEngineDataSet> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTraining", "()Lorg/encog/engine/data/EngineDataSet;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_finishTraining;
#pragma warning disable 0169
		static Delegate GetFinishTrainingHandler ()
		{
			if (cb_finishTraining == null)
				cb_finishTraining = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_FinishTraining);
			return cb_finishTraining;
		}

		static void n_FinishTraining (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Network.Train.Prop.TrainFlatNetworkOpenCL __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Train.Prop.TrainFlatNetworkOpenCL> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FinishTraining ();
		}
#pragma warning restore 0169

		static IntPtr id_finishTraining;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.train.prop']/class[@name='TrainFlatNetworkOpenCL']/method[@name='finishTraining' and count(parameter)=0]"
		[Register ("finishTraining", "()V", "GetFinishTrainingHandler")]
		public virtual unsafe void FinishTraining ()
		{
			if (id_finishTraining == IntPtr.Zero)
				id_finishTraining = JNIEnv.GetMethodID (class_ref, "finishTraining", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_finishTraining);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "finishTraining", "()V"));
			} finally {
			}
		}

		static Delegate cb_getLastGradient;
#pragma warning disable 0169
		static Delegate GetGetLastGradientHandler ()
		{
			if (cb_getLastGradient == null)
				cb_getLastGradient = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLastGradient);
			return cb_getLastGradient;
		}

		static IntPtr n_GetLastGradient (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Network.Train.Prop.TrainFlatNetworkOpenCL __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Train.Prop.TrainFlatNetworkOpenCL> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetLastGradient ());
		}
#pragma warning restore 0169

		static IntPtr id_getLastGradient;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.train.prop']/class[@name='TrainFlatNetworkOpenCL']/method[@name='getLastGradient' and count(parameter)=0]"
		[Register ("getLastGradient", "()[D", "GetGetLastGradientHandler")]
		public virtual unsafe double[] GetLastGradient ()
		{
			if (id_getLastGradient == IntPtr.Zero)
				id_getLastGradient = JNIEnv.GetMethodID (class_ref, "getLastGradient", "()[D");
			try {

				if (GetType () == ThresholdType)
					return (double[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getLastGradient), JniHandleOwnership.TransferLocalRef, typeof (double));
				else
					return (double[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLastGradient", "()[D")), JniHandleOwnership.TransferLocalRef, typeof (double));
			} finally {
			}
		}

		static Delegate cb_getUpdateValues;
#pragma warning disable 0169
		static Delegate GetGetUpdateValuesHandler ()
		{
			if (cb_getUpdateValues == null)
				cb_getUpdateValues = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUpdateValues);
			return cb_getUpdateValues;
		}

		static IntPtr n_GetUpdateValues (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Network.Train.Prop.TrainFlatNetworkOpenCL __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Train.Prop.TrainFlatNetworkOpenCL> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetUpdateValues ());
		}
#pragma warning restore 0169

		static IntPtr id_getUpdateValues;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.train.prop']/class[@name='TrainFlatNetworkOpenCL']/method[@name='getUpdateValues' and count(parameter)=0]"
		[Register ("getUpdateValues", "()[D", "GetGetUpdateValuesHandler")]
		public virtual unsafe double[] GetUpdateValues ()
		{
			if (id_getUpdateValues == IntPtr.Zero)
				id_getUpdateValues = JNIEnv.GetMethodID (class_ref, "getUpdateValues", "()[D");
			try {

				if (GetType () == ThresholdType)
					return (double[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getUpdateValues), JniHandleOwnership.TransferLocalRef, typeof (double));
				else
					return (double[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUpdateValues", "()[D")), JniHandleOwnership.TransferLocalRef, typeof (double));
			} finally {
			}
		}

		static Delegate cb_iteration;
#pragma warning disable 0169
		static Delegate GetInvokeIterationHandler ()
		{
			if (cb_iteration == null)
				cb_iteration = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_InvokeIteration);
			return cb_iteration;
		}

		static void n_InvokeIteration (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Network.Train.Prop.TrainFlatNetworkOpenCL __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Train.Prop.TrainFlatNetworkOpenCL> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.InvokeIteration ();
		}
#pragma warning restore 0169

		static IntPtr id_iteration;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.train.prop']/class[@name='TrainFlatNetworkOpenCL']/method[@name='iteration' and count(parameter)=0]"
		[Register ("iteration", "()V", "GetInvokeIterationHandler")]
		public virtual unsafe void InvokeIteration ()
		{
			if (id_iteration == IntPtr.Zero)
				id_iteration = JNIEnv.GetMethodID (class_ref, "iteration", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_iteration);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "iteration", "()V"));
			} finally {
			}
		}

		static Delegate cb_iteration_I;
#pragma warning disable 0169
		static Delegate GetInvokeIteration_IHandler ()
		{
			if (cb_iteration_I == null)
				cb_iteration_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_InvokeIteration_I);
			return cb_iteration_I;
		}

		static void n_InvokeIteration_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Encog.Engine.Network.Train.Prop.TrainFlatNetworkOpenCL __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Train.Prop.TrainFlatNetworkOpenCL> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.InvokeIteration (p0);
		}
#pragma warning restore 0169

		static IntPtr id_iteration_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.train.prop']/class[@name='TrainFlatNetworkOpenCL']/method[@name='iteration' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("iteration", "(I)V", "GetInvokeIteration_IHandler")]
		public virtual unsafe void InvokeIteration (int p0)
		{
			if (id_iteration_I == IntPtr.Zero)
				id_iteration_I = JNIEnv.GetMethodID (class_ref, "iteration", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_iteration_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "iteration", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_learnBPROP_DD;
#pragma warning disable 0169
		static Delegate GetLearnBPROP_DDHandler ()
		{
			if (cb_learnBPROP_DD == null)
				cb_learnBPROP_DD = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double, double>) n_LearnBPROP_DD);
			return cb_learnBPROP_DD;
		}

		static void n_LearnBPROP_DD (IntPtr jnienv, IntPtr native__this, double p0, double p1)
		{
			global::Org.Encog.Engine.Network.Train.Prop.TrainFlatNetworkOpenCL __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Train.Prop.TrainFlatNetworkOpenCL> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.LearnBPROP (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_learnBPROP_DD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.train.prop']/class[@name='TrainFlatNetworkOpenCL']/method[@name='learnBPROP' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='double']]"
		[Register ("learnBPROP", "(DD)V", "GetLearnBPROP_DDHandler")]
		public virtual unsafe void LearnBPROP (double p0, double p1)
		{
			if (id_learnBPROP_DD == IntPtr.Zero)
				id_learnBPROP_DD = JNIEnv.GetMethodID (class_ref, "learnBPROP", "(DD)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_learnBPROP_DD, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "learnBPROP", "(DD)V"), __args);
			} finally {
			}
		}

		static Delegate cb_learnManhattan_D;
#pragma warning disable 0169
		static Delegate GetLearnManhattan_DHandler ()
		{
			if (cb_learnManhattan_D == null)
				cb_learnManhattan_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_LearnManhattan_D);
			return cb_learnManhattan_D;
		}

		static void n_LearnManhattan_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Org.Encog.Engine.Network.Train.Prop.TrainFlatNetworkOpenCL __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Train.Prop.TrainFlatNetworkOpenCL> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.LearnManhattan (p0);
		}
#pragma warning restore 0169

		static IntPtr id_learnManhattan_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.train.prop']/class[@name='TrainFlatNetworkOpenCL']/method[@name='learnManhattan' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("learnManhattan", "(D)V", "GetLearnManhattan_DHandler")]
		public virtual unsafe void LearnManhattan (double p0)
		{
			if (id_learnManhattan_D == IntPtr.Zero)
				id_learnManhattan_D = JNIEnv.GetMethodID (class_ref, "learnManhattan", "(D)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_learnManhattan_D, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "learnManhattan", "(D)V"), __args);
			} finally {
			}
		}

		static Delegate cb_learnRPROP;
#pragma warning disable 0169
		static Delegate GetLearnRPROPHandler ()
		{
			if (cb_learnRPROP == null)
				cb_learnRPROP = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_LearnRPROP);
			return cb_learnRPROP;
		}

		static void n_LearnRPROP (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Network.Train.Prop.TrainFlatNetworkOpenCL __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Train.Prop.TrainFlatNetworkOpenCL> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.LearnRPROP ();
		}
#pragma warning restore 0169

		static IntPtr id_learnRPROP;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.train.prop']/class[@name='TrainFlatNetworkOpenCL']/method[@name='learnRPROP' and count(parameter)=0]"
		[Register ("learnRPROP", "()V", "GetLearnRPROPHandler")]
		public virtual unsafe void LearnRPROP ()
		{
			if (id_learnRPROP == IntPtr.Zero)
				id_learnRPROP = JNIEnv.GetMethodID (class_ref, "learnRPROP", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_learnRPROP);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "learnRPROP", "()V"));
			} finally {
			}
		}

		static Delegate cb_learnRPROP_DD;
#pragma warning disable 0169
		static Delegate GetLearnRPROP_DDHandler ()
		{
			if (cb_learnRPROP_DD == null)
				cb_learnRPROP_DD = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double, double>) n_LearnRPROP_DD);
			return cb_learnRPROP_DD;
		}

		static void n_LearnRPROP_DD (IntPtr jnienv, IntPtr native__this, double p0, double p1)
		{
			global::Org.Encog.Engine.Network.Train.Prop.TrainFlatNetworkOpenCL __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Train.Prop.TrainFlatNetworkOpenCL> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.LearnRPROP (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_learnRPROP_DD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.train.prop']/class[@name='TrainFlatNetworkOpenCL']/method[@name='learnRPROP' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='double']]"
		[Register ("learnRPROP", "(DD)V", "GetLearnRPROP_DDHandler")]
		public virtual unsafe void LearnRPROP (double p0, double p1)
		{
			if (id_learnRPROP_DD == IntPtr.Zero)
				id_learnRPROP_DD = JNIEnv.GetMethodID (class_ref, "learnRPROP", "(DD)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_learnRPROP_DD, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "learnRPROP", "(DD)V"), __args);
			} finally {
			}
		}

	}
}
