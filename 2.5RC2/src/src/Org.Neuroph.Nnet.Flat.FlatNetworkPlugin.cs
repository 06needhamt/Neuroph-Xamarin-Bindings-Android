using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Nnet.Flat {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.nnet.flat']/class[@name='FlatNetworkPlugin']"
	[global::Android.Runtime.Register ("org/neuroph/nnet/flat/FlatNetworkPlugin", DoNotGenerateAcw=true)]
	public partial class FlatNetworkPlugin : global::Org.Neuroph.Util.Plugins.PluginBase {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.neuroph.nnet.flat']/class[@name='FlatNetworkPlugin']/field[@name='PLUGIN_NAME']"
		[Register ("PLUGIN_NAME")]
		public const string PluginName = (string) "FlatNetworkPlugin";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/nnet/flat/FlatNetworkPlugin", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FlatNetworkPlugin); }
		}

		protected FlatNetworkPlugin (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_encog_engine_network_flat_FlatNetwork_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.nnet.flat']/class[@name='FlatNetworkPlugin']/constructor[@name='FlatNetworkPlugin' and count(parameter)=1 and parameter[1][@type='org.encog.engine.network.flat.FlatNetwork']]"
		[Register (".ctor", "(Lorg/encog/engine/network/flat/FlatNetwork;)V", "")]
		public unsafe FlatNetworkPlugin (global::Org.Encog.Engine.Network.Flat.FlatNetwork p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (FlatNetworkPlugin)) {
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

		static Delegate cb_getFlatNetwork;
#pragma warning disable 0169
		static Delegate GetGetFlatNetworkHandler ()
		{
			if (cb_getFlatNetwork == null)
				cb_getFlatNetwork = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFlatNetwork);
			return cb_getFlatNetwork;
		}

		static IntPtr n_GetFlatNetwork (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Nnet.Flat.FlatNetworkPlugin __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Flat.FlatNetworkPlugin> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FlatNetwork);
		}
#pragma warning restore 0169

		static IntPtr id_getFlatNetwork;
		public virtual unsafe global::Org.Encog.Engine.Network.Flat.FlatNetwork FlatNetwork {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.flat']/class[@name='FlatNetworkPlugin']/method[@name='getFlatNetwork' and count(parameter)=0]"
			[Register ("getFlatNetwork", "()Lorg/encog/engine/network/flat/FlatNetwork;", "GetGetFlatNetworkHandler")]
			get {
				if (id_getFlatNetwork == IntPtr.Zero)
					id_getFlatNetwork = JNIEnv.GetMethodID (class_ref, "getFlatNetwork", "()Lorg/encog/engine/network/flat/FlatNetwork;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Flat.FlatNetwork> (JNIEnv.CallObjectMethod  (Handle, id_getFlatNetwork), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Flat.FlatNetwork> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFlatNetwork", "()Lorg/encog/engine/network/flat/FlatNetwork;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_flattenNeuralNetworkNetwork_Lorg_neuroph_core_NeuralNetwork_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.flat']/class[@name='FlatNetworkPlugin']/method[@name='flattenNeuralNetworkNetwork' and count(parameter)=1 and parameter[1][@type='org.neuroph.core.NeuralNetwork']]"
		[Register ("flattenNeuralNetworkNetwork", "(Lorg/neuroph/core/NeuralNetwork;)Z", "")]
		public static unsafe bool FlattenNeuralNetworkNetwork (global::Org.Neuroph.Core.NeuralNetwork p0)
		{
			if (id_flattenNeuralNetworkNetwork_Lorg_neuroph_core_NeuralNetwork_ == IntPtr.Zero)
				id_flattenNeuralNetworkNetwork_Lorg_neuroph_core_NeuralNetwork_ = JNIEnv.GetStaticMethodID (class_ref, "flattenNeuralNetworkNetwork", "(Lorg/neuroph/core/NeuralNetwork;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_flattenNeuralNetworkNetwork_Lorg_neuroph_core_NeuralNetwork_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_initCL;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.flat']/class[@name='FlatNetworkPlugin']/method[@name='initCL' and count(parameter)=0]"
		[Register ("initCL", "()V", "")]
		public static unsafe void InitCL ()
		{
			if (id_initCL == IntPtr.Zero)
				id_initCL = JNIEnv.GetStaticMethodID (class_ref, "initCL", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_initCL);
			} finally {
			}
		}

		static IntPtr id_shutdown;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.flat']/class[@name='FlatNetworkPlugin']/method[@name='shutdown' and count(parameter)=0]"
		[Register ("shutdown", "()V", "")]
		public static unsafe void Shutdown ()
		{
			if (id_shutdown == IntPtr.Zero)
				id_shutdown = JNIEnv.GetStaticMethodID (class_ref, "shutdown", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_shutdown);
			} finally {
			}
		}

		static IntPtr id_unFlattenNeuralNetworkNetwork_Lorg_neuroph_core_NeuralNetwork_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.flat']/class[@name='FlatNetworkPlugin']/method[@name='unFlattenNeuralNetworkNetwork' and count(parameter)=1 and parameter[1][@type='org.neuroph.core.NeuralNetwork']]"
		[Register ("unFlattenNeuralNetworkNetwork", "(Lorg/neuroph/core/NeuralNetwork;)Z", "")]
		public static unsafe bool UnFlattenNeuralNetworkNetwork (global::Org.Neuroph.Core.NeuralNetwork p0)
		{
			if (id_unFlattenNeuralNetworkNetwork_Lorg_neuroph_core_NeuralNetwork_ == IntPtr.Zero)
				id_unFlattenNeuralNetworkNetwork_Lorg_neuroph_core_NeuralNetwork_ = JNIEnv.GetStaticMethodID (class_ref, "unFlattenNeuralNetworkNetwork", "(Lorg/neuroph/core/NeuralNetwork;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_unFlattenNeuralNetworkNetwork_Lorg_neuroph_core_NeuralNetwork_, __args);
				return __ret;
			} finally {
			}
		}

	}
}
