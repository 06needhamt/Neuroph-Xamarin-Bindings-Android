using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Encog.Engine.Network.Train.Gradient {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.encog.engine.network.train.gradient']/interface[@name='FlatGradientWorker']"
	[Register ("org/encog/engine/network/train/gradient/FlatGradientWorker", "", "Org.Encog.Engine.Network.Train.Gradient.IFlatGradientWorkerInvoker")]
	public partial interface IFlatGradientWorker : global::Org.Encog.Engine.Concurrency.IEngineTask {

		long ElapsedTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.train.gradient']/interface[@name='FlatGradientWorker']/method[@name='getElapsedTime' and count(parameter)=0]"
			[Register ("getElapsedTime", "()J", "GetGetElapsedTimeHandler:Org.Encog.Engine.Network.Train.Gradient.IFlatGradientWorkerInvoker, neuroph_2.5RC2")] get;
		}

		global::Org.Encog.Engine.Network.Flat.FlatNetwork Network {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.train.gradient']/interface[@name='FlatGradientWorker']/method[@name='getNetwork' and count(parameter)=0]"
			[Register ("getNetwork", "()Lorg/encog/engine/network/flat/FlatNetwork;", "GetGetNetworkHandler:Org.Encog.Engine.Network.Train.Gradient.IFlatGradientWorkerInvoker, neuroph_2.5RC2")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.train.gradient']/interface[@name='FlatGradientWorker']/method[@name='getWeights' and count(parameter)=0]"
		[Register ("getWeights", "()[D", "GetGetWeightsHandler:Org.Encog.Engine.Network.Train.Gradient.IFlatGradientWorkerInvoker, neuroph_2.5RC2")]
		double[] GetWeights ();

	}

	[global::Android.Runtime.Register ("org/encog/engine/network/train/gradient/FlatGradientWorker", DoNotGenerateAcw=true)]
	internal class IFlatGradientWorkerInvoker : global::Java.Lang.Object, IFlatGradientWorker {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/encog/engine/network/train/gradient/FlatGradientWorker");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IFlatGradientWorkerInvoker); }
		}

		IntPtr class_ref;

		public static IFlatGradientWorker GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IFlatGradientWorker> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.encog.engine.network.train.gradient.FlatGradientWorker"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IFlatGradientWorkerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Org.Encog.Engine.Network.Train.Gradient.IFlatGradientWorker __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Train.Gradient.IFlatGradientWorker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ElapsedTime;
		}
#pragma warning restore 0169

		IntPtr id_getElapsedTime;
		public unsafe long ElapsedTime {
			get {
				if (id_getElapsedTime == IntPtr.Zero)
					id_getElapsedTime = JNIEnv.GetMethodID (class_ref, "getElapsedTime", "()J");
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getElapsedTime);
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
			global::Org.Encog.Engine.Network.Train.Gradient.IFlatGradientWorker __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Train.Gradient.IFlatGradientWorker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Org.Encog.Engine.Network.Train.Gradient.IFlatGradientWorker __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Train.Gradient.IFlatGradientWorker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetWeights ());
		}
#pragma warning restore 0169

		IntPtr id_getWeights;
		public unsafe double[] GetWeights ()
		{
			if (id_getWeights == IntPtr.Zero)
				id_getWeights = JNIEnv.GetMethodID (class_ref, "getWeights", "()[D");
			return (double[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getWeights), JniHandleOwnership.TransferLocalRef, typeof (double));
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
			global::Org.Encog.Engine.Network.Train.Gradient.IFlatGradientWorker __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Train.Gradient.IFlatGradientWorker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Run ();
		}
#pragma warning restore 0169

		IntPtr id_run;
		public unsafe void Run ()
		{
			if (id_run == IntPtr.Zero)
				id_run = JNIEnv.GetMethodID (class_ref, "run", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_run);
		}

	}

}
