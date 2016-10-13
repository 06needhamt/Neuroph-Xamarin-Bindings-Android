using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Encog.Engine.Network.Train.Prop {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.encog.engine.network.train.prop']/class[@name='TrainFlatNetworkProp']"
	[global::Android.Runtime.Register ("org/encog/engine/network/train/prop/TrainFlatNetworkProp", DoNotGenerateAcw=true)]
	public abstract partial class TrainFlatNetworkProp : global::Java.Lang.Object, global::Org.Encog.Engine.Network.Train.ITrainFlatNetwork {


		static IntPtr currentError_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.encog.engine.network.train.prop']/class[@name='TrainFlatNetworkProp']/field[@name='currentError']"
		[Register ("currentError")]
		protected double CurrentError {
			get {
				if (currentError_jfieldId == IntPtr.Zero)
					currentError_jfieldId = JNIEnv.GetFieldID (class_ref, "currentError", "D");
				return JNIEnv.GetDoubleField (((global::Java.Lang.Object) this).Handle, currentError_jfieldId);
			}
			set {
				if (currentError_jfieldId == IntPtr.Zero)
					currentError_jfieldId = JNIEnv.GetFieldID (class_ref, "currentError", "D");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, currentError_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr gradients_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.encog.engine.network.train.prop']/class[@name='TrainFlatNetworkProp']/field[@name='gradients']"
		[Register ("gradients")]
		protected IList<double> Gradients {
			get {
				if (gradients_jfieldId == IntPtr.Zero)
					gradients_jfieldId = JNIEnv.GetFieldID (class_ref, "gradients", "[D");
				return global::Android.Runtime.JavaArray<double>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, gradients_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (gradients_jfieldId == IntPtr.Zero)
					gradients_jfieldId = JNIEnv.GetFieldID (class_ref, "gradients", "[D");
				IntPtr native_value = global::Android.Runtime.JavaArray<double>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, gradients_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr indexable_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.encog.engine.network.train.prop']/class[@name='TrainFlatNetworkProp']/field[@name='indexable']"
		[Register ("indexable")]
		protected global::Org.Encog.Engine.Data.IEngineIndexableSet Indexable {
			get {
				if (indexable_jfieldId == IntPtr.Zero)
					indexable_jfieldId = JNIEnv.GetFieldID (class_ref, "indexable", "Lorg/encog/engine/data/EngineIndexableSet;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, indexable_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Data.IEngineIndexableSet> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (indexable_jfieldId == IntPtr.Zero)
					indexable_jfieldId = JNIEnv.GetFieldID (class_ref, "indexable", "Lorg/encog/engine/data/EngineIndexableSet;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, indexable_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr lastGradient_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.encog.engine.network.train.prop']/class[@name='TrainFlatNetworkProp']/field[@name='lastGradient']"
		[Register ("lastGradient")]
		protected IList<double> LastGradient {
			get {
				if (lastGradient_jfieldId == IntPtr.Zero)
					lastGradient_jfieldId = JNIEnv.GetFieldID (class_ref, "lastGradient", "[D");
				return global::Android.Runtime.JavaArray<double>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, lastGradient_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (lastGradient_jfieldId == IntPtr.Zero)
					lastGradient_jfieldId = JNIEnv.GetFieldID (class_ref, "lastGradient", "[D");
				IntPtr native_value = global::Android.Runtime.JavaArray<double>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, lastGradient_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr reportedException_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.encog.engine.network.train.prop']/class[@name='TrainFlatNetworkProp']/field[@name='reportedException']"
		[Register ("reportedException")]
		protected global::Java.Lang.Throwable ReportedException {
			get {
				if (reportedException_jfieldId == IntPtr.Zero)
					reportedException_jfieldId = JNIEnv.GetFieldID (class_ref, "reportedException", "Ljava/lang/Throwable;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, reportedException_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (reportedException_jfieldId == IntPtr.Zero)
					reportedException_jfieldId = JNIEnv.GetFieldID (class_ref, "reportedException", "Ljava/lang/Throwable;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, reportedException_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr totalError_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.encog.engine.network.train.prop']/class[@name='TrainFlatNetworkProp']/field[@name='totalError']"
		[Register ("totalError")]
		protected double TotalError {
			get {
				if (totalError_jfieldId == IntPtr.Zero)
					totalError_jfieldId = JNIEnv.GetFieldID (class_ref, "totalError", "D");
				return JNIEnv.GetDoubleField (((global::Java.Lang.Object) this).Handle, totalError_jfieldId);
			}
			set {
				if (totalError_jfieldId == IntPtr.Zero)
					totalError_jfieldId = JNIEnv.GetFieldID (class_ref, "totalError", "D");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, totalError_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr workers_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.encog.engine.network.train.prop']/class[@name='TrainFlatNetworkProp']/field[@name='workers']"
		[Register ("workers")]
		protected IList<Org.Encog.Engine.Network.Train.Gradient.IFlatGradientWorker> Workers {
			get {
				if (workers_jfieldId == IntPtr.Zero)
					workers_jfieldId = JNIEnv.GetFieldID (class_ref, "workers", "[Lorg/encog/engine/network/train/gradient/FlatGradientWorker;");
				return global::Android.Runtime.JavaArray<global::Org.Encog.Engine.Network.Train.Gradient.IFlatGradientWorker>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, workers_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (workers_jfieldId == IntPtr.Zero)
					workers_jfieldId = JNIEnv.GetFieldID (class_ref, "workers", "[Lorg/encog/engine/network/train/gradient/FlatGradientWorker;");
				IntPtr native_value = global::Android.Runtime.JavaArray<global::Org.Encog.Engine.Network.Train.Gradient.IFlatGradientWorker>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, workers_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/encog/engine/network/train/prop/TrainFlatNetworkProp", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TrainFlatNetworkProp); }
		}

		protected TrainFlatNetworkProp (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_encog_engine_network_flat_FlatNetwork_Lorg_encog_engine_data_EngineDataSet_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.encog.engine.network.train.prop']/class[@name='TrainFlatNetworkProp']/constructor[@name='TrainFlatNetworkProp' and count(parameter)=2 and parameter[1][@type='org.encog.engine.network.flat.FlatNetwork'] and parameter[2][@type='org.encog.engine.data.EngineDataSet']]"
		[Register (".ctor", "(Lorg/encog/engine/network/flat/FlatNetwork;Lorg/encog/engine/data/EngineDataSet;)V", "")]
		public unsafe TrainFlatNetworkProp (global::Org.Encog.Engine.Network.Flat.FlatNetwork p0, global::Org.Encog.Engine.Data.IEngineDataSet p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (TrainFlatNetworkProp)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/encog/engine/network/flat/FlatNetwork;Lorg/encog/engine/data/EngineDataSet;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/encog/engine/network/flat/FlatNetwork;Lorg/encog/engine/data/EngineDataSet;)V", __args);
					return;
				}

				if (id_ctor_Lorg_encog_engine_network_flat_FlatNetwork_Lorg_encog_engine_data_EngineDataSet_ == IntPtr.Zero)
					id_ctor_Lorg_encog_engine_network_flat_FlatNetwork_Lorg_encog_engine_data_EngineDataSet_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/encog/engine/network/flat/FlatNetwork;Lorg/encog/engine/data/EngineDataSet;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_encog_engine_network_flat_FlatNetwork_Lorg_encog_engine_data_EngineDataSet_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_encog_engine_network_flat_FlatNetwork_Lorg_encog_engine_data_EngineDataSet_, __args);
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
			global::Org.Encog.Engine.Network.Train.Prop.TrainFlatNetworkProp __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Train.Prop.TrainFlatNetworkProp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Error;
		}
#pragma warning restore 0169

		static IntPtr id_getError;
		public virtual unsafe double Error {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.train.prop']/class[@name='TrainFlatNetworkProp']/method[@name='getError' and count(parameter)=0]"
			[Register ("getError", "()D", "GetGetErrorHandler")]
			get {
				if (id_getError == IntPtr.Zero)
					id_getError = JNIEnv.GetMethodID (class_ref, "getError", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getError);
					else
						return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getError", "()D"));
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
			global::Org.Encog.Engine.Network.Train.Prop.TrainFlatNetworkProp __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Train.Prop.TrainFlatNetworkProp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Org.Encog.Engine.Network.Train.Prop.TrainFlatNetworkProp __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Train.Prop.TrainFlatNetworkProp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Iteration = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getIteration;
		static IntPtr id_setIteration_I;
		public virtual unsafe int Iteration {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.train.prop']/class[@name='TrainFlatNetworkProp']/method[@name='getIteration' and count(parameter)=0]"
			[Register ("getIteration", "()I", "GetGetIterationHandler")]
			get {
				if (id_getIteration == IntPtr.Zero)
					id_getIteration = JNIEnv.GetMethodID (class_ref, "getIteration", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getIteration);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIteration", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.train.prop']/class[@name='TrainFlatNetworkProp']/method[@name='setIteration' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setIteration", "(I)V", "GetSetIteration_IHandler")]
			set {
				if (id_setIteration_I == IntPtr.Zero)
					id_setIteration_I = JNIEnv.GetMethodID (class_ref, "setIteration", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setIteration_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setIteration", "(I)V"), __args);
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
			global::Org.Encog.Engine.Network.Train.Prop.TrainFlatNetworkProp __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Train.Prop.TrainFlatNetworkProp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Network);
		}
#pragma warning restore 0169

		static IntPtr id_getNetwork;
		public virtual unsafe global::Org.Encog.Engine.Network.Flat.FlatNetwork Network {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.train.prop']/class[@name='TrainFlatNetworkProp']/method[@name='getNetwork' and count(parameter)=0]"
			[Register ("getNetwork", "()Lorg/encog/engine/network/flat/FlatNetwork;", "GetGetNetworkHandler")]
			get {
				if (id_getNetwork == IntPtr.Zero)
					id_getNetwork = JNIEnv.GetMethodID (class_ref, "getNetwork", "()Lorg/encog/engine/network/flat/FlatNetwork;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Flat.FlatNetwork> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNetwork), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Flat.FlatNetwork> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNetwork", "()Lorg/encog/engine/network/flat/FlatNetwork;")), JniHandleOwnership.TransferLocalRef);
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
			global::Org.Encog.Engine.Network.Train.Prop.TrainFlatNetworkProp __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Train.Prop.TrainFlatNetworkProp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Org.Encog.Engine.Network.Train.Prop.TrainFlatNetworkProp __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Train.Prop.TrainFlatNetworkProp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NumThreads = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getNumThreads;
		static IntPtr id_setNumThreads_I;
		public virtual unsafe int NumThreads {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.train.prop']/class[@name='TrainFlatNetworkProp']/method[@name='getNumThreads' and count(parameter)=0]"
			[Register ("getNumThreads", "()I", "GetGetNumThreadsHandler")]
			get {
				if (id_getNumThreads == IntPtr.Zero)
					id_getNumThreads = JNIEnv.GetMethodID (class_ref, "getNumThreads", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getNumThreads);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNumThreads", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.train.prop']/class[@name='TrainFlatNetworkProp']/method[@name='setNumThreads' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setNumThreads", "(I)V", "GetSetNumThreads_IHandler")]
			set {
				if (id_setNumThreads_I == IntPtr.Zero)
					id_setNumThreads_I = JNIEnv.GetMethodID (class_ref, "setNumThreads", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setNumThreads_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNumThreads", "(I)V"), __args);
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
			global::Org.Encog.Engine.Network.Train.Prop.TrainFlatNetworkProp __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Train.Prop.TrainFlatNetworkProp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Training);
		}
#pragma warning restore 0169

		static IntPtr id_getTraining;
		public virtual unsafe global::Org.Encog.Engine.Data.IEngineDataSet Training {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.train.prop']/class[@name='TrainFlatNetworkProp']/method[@name='getTraining' and count(parameter)=0]"
			[Register ("getTraining", "()Lorg/encog/engine/data/EngineDataSet;", "GetGetTrainingHandler")]
			get {
				if (id_getTraining == IntPtr.Zero)
					id_getTraining = JNIEnv.GetMethodID (class_ref, "getTraining", "()Lorg/encog/engine/data/EngineDataSet;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Data.IEngineDataSet> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTraining), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Data.IEngineDataSet> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTraining", "()Lorg/encog/engine/data/EngineDataSet;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_calculateGradients;
#pragma warning disable 0169
		static Delegate GetCalculateGradientsHandler ()
		{
			if (cb_calculateGradients == null)
				cb_calculateGradients = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CalculateGradients);
			return cb_calculateGradients;
		}

		static void n_CalculateGradients (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Network.Train.Prop.TrainFlatNetworkProp __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Train.Prop.TrainFlatNetworkProp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CalculateGradients ();
		}
#pragma warning restore 0169

		static IntPtr id_calculateGradients;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.train.prop']/class[@name='TrainFlatNetworkProp']/method[@name='calculateGradients' and count(parameter)=0]"
		[Register ("calculateGradients", "()V", "GetCalculateGradientsHandler")]
		public virtual unsafe void CalculateGradients ()
		{
			if (id_calculateGradients == IntPtr.Zero)
				id_calculateGradients = JNIEnv.GetMethodID (class_ref, "calculateGradients", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_calculateGradients);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "calculateGradients", "()V"));
			} finally {
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
			global::Org.Encog.Engine.Network.Train.Prop.TrainFlatNetworkProp __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Train.Prop.TrainFlatNetworkProp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FinishTraining ();
		}
#pragma warning restore 0169

		static IntPtr id_finishTraining;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.train.prop']/class[@name='TrainFlatNetworkProp']/method[@name='finishTraining' and count(parameter)=0]"
		[Register ("finishTraining", "()V", "GetFinishTrainingHandler")]
		public virtual unsafe void FinishTraining ()
		{
			if (id_finishTraining == IntPtr.Zero)
				id_finishTraining = JNIEnv.GetMethodID (class_ref, "finishTraining", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_finishTraining);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "finishTraining", "()V"));
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
			global::Org.Encog.Engine.Network.Train.Prop.TrainFlatNetworkProp __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Train.Prop.TrainFlatNetworkProp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetLastGradient ());
		}
#pragma warning restore 0169

		static IntPtr id_getLastGradient;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.train.prop']/class[@name='TrainFlatNetworkProp']/method[@name='getLastGradient' and count(parameter)=0]"
		[Register ("getLastGradient", "()[D", "GetGetLastGradientHandler")]
		public virtual unsafe double[] GetLastGradient ()
		{
			if (id_getLastGradient == IntPtr.Zero)
				id_getLastGradient = JNIEnv.GetMethodID (class_ref, "getLastGradient", "()[D");
			try {

				if (GetType () == ThresholdType)
					return (double[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLastGradient), JniHandleOwnership.TransferLocalRef, typeof (double));
				else
					return (double[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLastGradient", "()[D")), JniHandleOwnership.TransferLocalRef, typeof (double));
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
			global::Org.Encog.Engine.Network.Train.Prop.TrainFlatNetworkProp __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Train.Prop.TrainFlatNetworkProp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.InvokeIteration ();
		}
#pragma warning restore 0169

		static IntPtr id_iteration;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.train.prop']/class[@name='TrainFlatNetworkProp']/method[@name='iteration' and count(parameter)=0]"
		[Register ("iteration", "()V", "GetInvokeIterationHandler")]
		public virtual unsafe void InvokeIteration ()
		{
			if (id_iteration == IntPtr.Zero)
				id_iteration = JNIEnv.GetMethodID (class_ref, "iteration", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_iteration);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "iteration", "()V"));
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
			global::Org.Encog.Engine.Network.Train.Prop.TrainFlatNetworkProp __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Train.Prop.TrainFlatNetworkProp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.InvokeIteration (p0);
		}
#pragma warning restore 0169

		static IntPtr id_iteration_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.train.prop']/class[@name='TrainFlatNetworkProp']/method[@name='iteration' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("iteration", "(I)V", "GetInvokeIteration_IHandler")]
		public virtual unsafe void InvokeIteration (int p0)
		{
			if (id_iteration_I == IntPtr.Zero)
				id_iteration_I = JNIEnv.GetMethodID (class_ref, "iteration", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_iteration_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "iteration", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_learn;
#pragma warning disable 0169
		static Delegate GetLearnHandler ()
		{
			if (cb_learn == null)
				cb_learn = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Learn);
			return cb_learn;
		}

		static void n_Learn (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Network.Train.Prop.TrainFlatNetworkProp __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Train.Prop.TrainFlatNetworkProp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Learn ();
		}
#pragma warning restore 0169

		static IntPtr id_learn;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.train.prop']/class[@name='TrainFlatNetworkProp']/method[@name='learn' and count(parameter)=0]"
		[Register ("learn", "()V", "GetLearnHandler")]
		protected virtual unsafe void Learn ()
		{
			if (id_learn == IntPtr.Zero)
				id_learn = JNIEnv.GetMethodID (class_ref, "learn", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_learn);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "learn", "()V"));
			} finally {
			}
		}

		static Delegate cb_learnLimited;
#pragma warning disable 0169
		static Delegate GetLearnLimitedHandler ()
		{
			if (cb_learnLimited == null)
				cb_learnLimited = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_LearnLimited);
			return cb_learnLimited;
		}

		static void n_LearnLimited (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Network.Train.Prop.TrainFlatNetworkProp __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Train.Prop.TrainFlatNetworkProp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.LearnLimited ();
		}
#pragma warning restore 0169

		static IntPtr id_learnLimited;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.train.prop']/class[@name='TrainFlatNetworkProp']/method[@name='learnLimited' and count(parameter)=0]"
		[Register ("learnLimited", "()V", "GetLearnLimitedHandler")]
		protected virtual unsafe void LearnLimited ()
		{
			if (id_learnLimited == IntPtr.Zero)
				id_learnLimited = JNIEnv.GetMethodID (class_ref, "learnLimited", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_learnLimited);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "learnLimited", "()V"));
			} finally {
			}
		}

		static Delegate cb_report_arrayDDLjava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetReport_arrayDDLjava_lang_Throwable_Handler ()
		{
			if (cb_report_arrayDDLjava_lang_Throwable_ == null)
				cb_report_arrayDDLjava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, double, IntPtr>) n_Report_arrayDDLjava_lang_Throwable_);
			return cb_report_arrayDDLjava_lang_Throwable_;
		}

		static void n_Report_arrayDDLjava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, double p1, IntPtr native_p2)
		{
			global::Org.Encog.Engine.Network.Train.Prop.TrainFlatNetworkProp __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Train.Prop.TrainFlatNetworkProp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			double[] p0 = (double[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (double));
			global::Java.Lang.Throwable p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Report (p0, p1, p2);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_report_arrayDDLjava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.train.prop']/class[@name='TrainFlatNetworkProp']/method[@name='report' and count(parameter)=3 and parameter[1][@type='double[]'] and parameter[2][@type='double'] and parameter[3][@type='java.lang.Throwable']]"
		[Register ("report", "([DDLjava/lang/Throwable;)V", "GetReport_arrayDDLjava_lang_Throwable_Handler")]
		public virtual unsafe void Report (double[] p0, double p1, global::Java.Lang.Throwable p2)
		{
			if (id_report_arrayDDLjava_lang_Throwable_ == IntPtr.Zero)
				id_report_arrayDDLjava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "report", "([DDLjava/lang/Throwable;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_report_arrayDDLjava_lang_Throwable_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "report", "([DDLjava/lang/Throwable;)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_updateWeight_arrayDarrayDI;
#pragma warning disable 0169
		static Delegate GetUpdateWeight_arrayDarrayDIHandler ()
		{
			if (cb_updateWeight_arrayDarrayDI == null)
				cb_updateWeight_arrayDarrayDI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int, double>) n_UpdateWeight_arrayDarrayDI);
			return cb_updateWeight_arrayDarrayDI;
		}

		static double n_UpdateWeight_arrayDarrayDI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2)
		{
			global::Org.Encog.Engine.Network.Train.Prop.TrainFlatNetworkProp __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Train.Prop.TrainFlatNetworkProp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			double[] p0 = (double[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (double));
			double[] p1 = (double[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (double));
			double __ret = __this.UpdateWeight (p0, p1, p2);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.train.prop']/class[@name='TrainFlatNetworkProp']/method[@name='updateWeight' and count(parameter)=3 and parameter[1][@type='double[]'] and parameter[2][@type='double[]'] and parameter[3][@type='int']]"
		[Register ("updateWeight", "([D[DI)D", "GetUpdateWeight_arrayDarrayDIHandler")]
		public abstract double UpdateWeight (double[] p0, double[] p1, int p2);

	}

	[global::Android.Runtime.Register ("org/encog/engine/network/train/prop/TrainFlatNetworkProp", DoNotGenerateAcw=true)]
	internal partial class TrainFlatNetworkPropInvoker : TrainFlatNetworkProp {

		public TrainFlatNetworkPropInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (TrainFlatNetworkPropInvoker); }
		}

		static IntPtr id_updateWeight_arrayDarrayDI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.train.prop']/class[@name='TrainFlatNetworkProp']/method[@name='updateWeight' and count(parameter)=3 and parameter[1][@type='double[]'] and parameter[2][@type='double[]'] and parameter[3][@type='int']]"
		[Register ("updateWeight", "([D[DI)D", "GetUpdateWeight_arrayDarrayDIHandler")]
		public override unsafe double UpdateWeight (double[] p0, double[] p1, int p2)
		{
			if (id_updateWeight_arrayDarrayDI == IntPtr.Zero)
				id_updateWeight_arrayDarrayDI = JNIEnv.GetMethodID (class_ref, "updateWeight", "([D[DI)D");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				double __ret = JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_updateWeight_arrayDarrayDI, __args);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

	}

}
