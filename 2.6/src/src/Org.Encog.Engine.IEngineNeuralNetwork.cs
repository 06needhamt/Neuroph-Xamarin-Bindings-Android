using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Encog.Engine {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.encog.engine']/interface[@name='EngineNeuralNetwork']"
	[Register ("org/encog/engine/EngineNeuralNetwork", "", "Org.Encog.Engine.IEngineNeuralNetworkInvoker")]
	public partial interface IEngineNeuralNetwork : global::Org.Encog.Engine.IEngineMachineLearning {

		int EncodeLength {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine']/interface[@name='EngineNeuralNetwork']/method[@name='getEncodeLength' and count(parameter)=0]"
			[Register ("getEncodeLength", "()I", "GetGetEncodeLengthHandler:Org.Encog.Engine.IEngineNeuralNetworkInvoker, Neuroph_2.6")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine']/interface[@name='EngineNeuralNetwork']/method[@name='decodeNetwork' and count(parameter)=1 and parameter[1][@type='double[]']]"
		[Register ("decodeNetwork", "([D)V", "GetDecodeNetwork_arrayDHandler:Org.Encog.Engine.IEngineNeuralNetworkInvoker, Neuroph_2.6")]
		void DecodeNetwork (double[] p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine']/interface[@name='EngineNeuralNetwork']/method[@name='encodeNetwork' and count(parameter)=0]"
		[Register ("encodeNetwork", "()[D", "GetEncodeNetworkHandler:Org.Encog.Engine.IEngineNeuralNetworkInvoker, Neuroph_2.6")]
		double[] EncodeNetwork ();

	}

	[global::Android.Runtime.Register ("org/encog/engine/EngineNeuralNetwork", DoNotGenerateAcw=true)]
	internal class IEngineNeuralNetworkInvoker : global::Java.Lang.Object, IEngineNeuralNetwork {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/encog/engine/EngineNeuralNetwork");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IEngineNeuralNetworkInvoker); }
		}

		IntPtr class_ref;

		public static IEngineNeuralNetwork GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IEngineNeuralNetwork> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.encog.engine.EngineNeuralNetwork"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IEngineNeuralNetworkInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getEncodeLength;
#pragma warning disable 0169
		static Delegate GetGetEncodeLengthHandler ()
		{
			if (cb_getEncodeLength == null)
				cb_getEncodeLength = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetEncodeLength);
			return cb_getEncodeLength;
		}

		static int n_GetEncodeLength (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.IEngineNeuralNetwork __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.IEngineNeuralNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.EncodeLength;
		}
#pragma warning restore 0169

		IntPtr id_getEncodeLength;
		public unsafe int EncodeLength {
			get {
				if (id_getEncodeLength == IntPtr.Zero)
					id_getEncodeLength = JNIEnv.GetMethodID (class_ref, "getEncodeLength", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getEncodeLength);
			}
		}

		static Delegate cb_decodeNetwork_arrayD;
#pragma warning disable 0169
		static Delegate GetDecodeNetwork_arrayDHandler ()
		{
			if (cb_decodeNetwork_arrayD == null)
				cb_decodeNetwork_arrayD = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DecodeNetwork_arrayD);
			return cb_decodeNetwork_arrayD;
		}

		static void n_DecodeNetwork_arrayD (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Encog.Engine.IEngineNeuralNetwork __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.IEngineNeuralNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			double[] p0 = (double[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (double));
			__this.DecodeNetwork (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		IntPtr id_decodeNetwork_arrayD;
		public unsafe void DecodeNetwork (double[] p0)
		{
			if (id_decodeNetwork_arrayD == IntPtr.Zero)
				id_decodeNetwork_arrayD = JNIEnv.GetMethodID (class_ref, "decodeNetwork", "([D)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_decodeNetwork_arrayD, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_encodeNetwork;
#pragma warning disable 0169
		static Delegate GetEncodeNetworkHandler ()
		{
			if (cb_encodeNetwork == null)
				cb_encodeNetwork = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_EncodeNetwork);
			return cb_encodeNetwork;
		}

		static IntPtr n_EncodeNetwork (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.IEngineNeuralNetwork __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.IEngineNeuralNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.EncodeNetwork ());
		}
#pragma warning restore 0169

		IntPtr id_encodeNetwork;
		public unsafe double[] EncodeNetwork ()
		{
			if (id_encodeNetwork == IntPtr.Zero)
				id_encodeNetwork = JNIEnv.GetMethodID (class_ref, "encodeNetwork", "()[D");
			return (double[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_encodeNetwork), JniHandleOwnership.TransferLocalRef, typeof (double));
		}

		static Delegate cb_getInputCount;
#pragma warning disable 0169
		static Delegate GetGetInputCountHandler ()
		{
			if (cb_getInputCount == null)
				cb_getInputCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetInputCount);
			return cb_getInputCount;
		}

		static int n_GetInputCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.IEngineNeuralNetwork __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.IEngineNeuralNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.InputCount;
		}
#pragma warning restore 0169

		IntPtr id_getInputCount;
		public unsafe int InputCount {
			get {
				if (id_getInputCount == IntPtr.Zero)
					id_getInputCount = JNIEnv.GetMethodID (class_ref, "getInputCount", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getInputCount);
			}
		}

		static Delegate cb_getOutputCount;
#pragma warning disable 0169
		static Delegate GetGetOutputCountHandler ()
		{
			if (cb_getOutputCount == null)
				cb_getOutputCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetOutputCount);
			return cb_getOutputCount;
		}

		static int n_GetOutputCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.IEngineNeuralNetwork __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.IEngineNeuralNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.OutputCount;
		}
#pragma warning restore 0169

		IntPtr id_getOutputCount;
		public unsafe int OutputCount {
			get {
				if (id_getOutputCount == IntPtr.Zero)
					id_getOutputCount = JNIEnv.GetMethodID (class_ref, "getOutputCount", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getOutputCount);
			}
		}

		static Delegate cb_compute_arrayDarrayD;
#pragma warning disable 0169
		static Delegate GetCompute_arrayDarrayDHandler ()
		{
			if (cb_compute_arrayDarrayD == null)
				cb_compute_arrayDarrayD = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Compute_arrayDarrayD);
			return cb_compute_arrayDarrayD;
		}

		static void n_Compute_arrayDarrayD (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Encog.Engine.IEngineNeuralNetwork __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.IEngineNeuralNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			double[] p0 = (double[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (double));
			double[] p1 = (double[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (double));
			__this.Compute (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		IntPtr id_compute_arrayDarrayD;
		public unsafe void Compute (double[] p0, double[] p1)
		{
			if (id_compute_arrayDarrayD == IntPtr.Zero)
				id_compute_arrayDarrayD = JNIEnv.GetMethodID (class_ref, "compute", "([D[D)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_compute_arrayDarrayD, __args);
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
