using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Encog.Engine.Network.Train {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.encog.engine.network.train']/interface[@name='TrainFlatNetwork']"
	[Register ("org/encog/engine/network/train/TrainFlatNetwork", "", "Org.Encog.Engine.Network.Train.ITrainFlatNetworkInvoker")]
	public partial interface ITrainFlatNetwork : IJavaObject {

		double Error {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.train']/interface[@name='TrainFlatNetwork']/method[@name='getError' and count(parameter)=0]"
			[Register ("getError", "()D", "GetGetErrorHandler:Org.Encog.Engine.Network.Train.ITrainFlatNetworkInvoker, neuroph_2.5RC2")] get;
		}

		int Iteration {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.train']/interface[@name='TrainFlatNetwork']/method[@name='getIteration' and count(parameter)=0]"
			[Register ("getIteration", "()I", "GetGetIterationHandler:Org.Encog.Engine.Network.Train.ITrainFlatNetworkInvoker, neuroph_2.5RC2")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.train']/interface[@name='TrainFlatNetwork']/method[@name='setIteration' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setIteration", "(I)V", "GetSetIteration_IHandler:Org.Encog.Engine.Network.Train.ITrainFlatNetworkInvoker, neuroph_2.5RC2")] set;
		}

		global::Org.Encog.Engine.Network.Flat.FlatNetwork Network {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.train']/interface[@name='TrainFlatNetwork']/method[@name='getNetwork' and count(parameter)=0]"
			[Register ("getNetwork", "()Lorg/encog/engine/network/flat/FlatNetwork;", "GetGetNetworkHandler:Org.Encog.Engine.Network.Train.ITrainFlatNetworkInvoker, neuroph_2.5RC2")] get;
		}

		int NumThreads {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.train']/interface[@name='TrainFlatNetwork']/method[@name='getNumThreads' and count(parameter)=0]"
			[Register ("getNumThreads", "()I", "GetGetNumThreadsHandler:Org.Encog.Engine.Network.Train.ITrainFlatNetworkInvoker, neuroph_2.5RC2")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.train']/interface[@name='TrainFlatNetwork']/method[@name='setNumThreads' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setNumThreads", "(I)V", "GetSetNumThreads_IHandler:Org.Encog.Engine.Network.Train.ITrainFlatNetworkInvoker, neuroph_2.5RC2")] set;
		}

		global::Org.Encog.Engine.Data.IEngineDataSet Training {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.train']/interface[@name='TrainFlatNetwork']/method[@name='getTraining' and count(parameter)=0]"
			[Register ("getTraining", "()Lorg/encog/engine/data/EngineDataSet;", "GetGetTrainingHandler:Org.Encog.Engine.Network.Train.ITrainFlatNetworkInvoker, neuroph_2.5RC2")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.train']/interface[@name='TrainFlatNetwork']/method[@name='finishTraining' and count(parameter)=0]"
		[Register ("finishTraining", "()V", "GetFinishTrainingHandler:Org.Encog.Engine.Network.Train.ITrainFlatNetworkInvoker, neuroph_2.5RC2")]
		void FinishTraining ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.train']/interface[@name='TrainFlatNetwork']/method[@name='iteration' and count(parameter)=0]"
		[Register ("iteration", "()V", "GetInvokeIterationHandler:Org.Encog.Engine.Network.Train.ITrainFlatNetworkInvoker, neuroph_2.5RC2")]
		void InvokeIteration ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.train']/interface[@name='TrainFlatNetwork']/method[@name='iteration' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("iteration", "(I)V", "GetInvokeIteration_IHandler:Org.Encog.Engine.Network.Train.ITrainFlatNetworkInvoker, neuroph_2.5RC2")]
		void InvokeIteration (int p0);

	}

	[global::Android.Runtime.Register ("org/encog/engine/network/train/TrainFlatNetwork", DoNotGenerateAcw=true)]
	internal class ITrainFlatNetworkInvoker : global::Java.Lang.Object, ITrainFlatNetwork {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/encog/engine/network/train/TrainFlatNetwork");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ITrainFlatNetworkInvoker); }
		}

		IntPtr class_ref;

		public static ITrainFlatNetwork GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITrainFlatNetwork> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.encog.engine.network.train.TrainFlatNetwork"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITrainFlatNetworkInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Org.Encog.Engine.Network.Train.ITrainFlatNetwork __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Train.ITrainFlatNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Error;
		}
#pragma warning restore 0169

		IntPtr id_getError;
		public unsafe double Error {
			get {
				if (id_getError == IntPtr.Zero)
					id_getError = JNIEnv.GetMethodID (class_ref, "getError", "()D");
				return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getError);
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
			global::Org.Encog.Engine.Network.Train.ITrainFlatNetwork __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Train.ITrainFlatNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Org.Encog.Engine.Network.Train.ITrainFlatNetwork __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Train.ITrainFlatNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Iteration = p0;
		}
#pragma warning restore 0169

		IntPtr id_getIteration;
		IntPtr id_setIteration_I;
		public unsafe int Iteration {
			get {
				if (id_getIteration == IntPtr.Zero)
					id_getIteration = JNIEnv.GetMethodID (class_ref, "getIteration", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getIteration);
			}
			set {
				if (id_setIteration_I == IntPtr.Zero)
					id_setIteration_I = JNIEnv.GetMethodID (class_ref, "setIteration", "(I)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setIteration_I, __args);
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
			global::Org.Encog.Engine.Network.Train.ITrainFlatNetwork __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Train.ITrainFlatNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Network);
		}
#pragma warning restore 0169

		IntPtr id_getNetwork;
		public unsafe global::Org.Encog.Engine.Network.Flat.FlatNetwork Network {
			get {
				if (id_getNetwork == IntPtr.Zero)
					id_getNetwork = JNIEnv.GetMethodID (class_ref, "getNetwork", "()Lorg/encog/engine/network/flat/FlatNetwork;");
				return global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Flat.FlatNetwork> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNetwork), JniHandleOwnership.TransferLocalRef);
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
			global::Org.Encog.Engine.Network.Train.ITrainFlatNetwork __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Train.ITrainFlatNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Org.Encog.Engine.Network.Train.ITrainFlatNetwork __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Train.ITrainFlatNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NumThreads = p0;
		}
#pragma warning restore 0169

		IntPtr id_getNumThreads;
		IntPtr id_setNumThreads_I;
		public unsafe int NumThreads {
			get {
				if (id_getNumThreads == IntPtr.Zero)
					id_getNumThreads = JNIEnv.GetMethodID (class_ref, "getNumThreads", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getNumThreads);
			}
			set {
				if (id_setNumThreads_I == IntPtr.Zero)
					id_setNumThreads_I = JNIEnv.GetMethodID (class_ref, "setNumThreads", "(I)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setNumThreads_I, __args);
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
			global::Org.Encog.Engine.Network.Train.ITrainFlatNetwork __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Train.ITrainFlatNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Training);
		}
#pragma warning restore 0169

		IntPtr id_getTraining;
		public unsafe global::Org.Encog.Engine.Data.IEngineDataSet Training {
			get {
				if (id_getTraining == IntPtr.Zero)
					id_getTraining = JNIEnv.GetMethodID (class_ref, "getTraining", "()Lorg/encog/engine/data/EngineDataSet;");
				return global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Data.IEngineDataSet> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTraining), JniHandleOwnership.TransferLocalRef);
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
			global::Org.Encog.Engine.Network.Train.ITrainFlatNetwork __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Train.ITrainFlatNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FinishTraining ();
		}
#pragma warning restore 0169

		IntPtr id_finishTraining;
		public unsafe void FinishTraining ()
		{
			if (id_finishTraining == IntPtr.Zero)
				id_finishTraining = JNIEnv.GetMethodID (class_ref, "finishTraining", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_finishTraining);
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
			global::Org.Encog.Engine.Network.Train.ITrainFlatNetwork __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Train.ITrainFlatNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.InvokeIteration ();
		}
#pragma warning restore 0169

		IntPtr id_iteration;
		public unsafe void InvokeIteration ()
		{
			if (id_iteration == IntPtr.Zero)
				id_iteration = JNIEnv.GetMethodID (class_ref, "iteration", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_iteration);
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
			global::Org.Encog.Engine.Network.Train.ITrainFlatNetwork __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Train.ITrainFlatNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.InvokeIteration (p0);
		}
#pragma warning restore 0169

		IntPtr id_iteration_I;
		public unsafe void InvokeIteration (int p0)
		{
			if (id_iteration_I == IntPtr.Zero)
				id_iteration_I = JNIEnv.GetMethodID (class_ref, "iteration", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_iteration_I, __args);
		}

	}

}
