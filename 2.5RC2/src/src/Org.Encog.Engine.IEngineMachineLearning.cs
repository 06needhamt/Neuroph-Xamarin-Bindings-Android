using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Encog.Engine {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.encog.engine']/interface[@name='EngineMachineLearning']"
	[Register ("org/encog/engine/EngineMachineLearning", "", "Org.Encog.Engine.IEngineMachineLearningInvoker")]
	public partial interface IEngineMachineLearning : IJavaObject {

		int InputCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine']/interface[@name='EngineMachineLearning']/method[@name='getInputCount' and count(parameter)=0]"
			[Register ("getInputCount", "()I", "GetGetInputCountHandler:Org.Encog.Engine.IEngineMachineLearningInvoker, neuroph_2.5RC2")] get;
		}

		int OutputCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine']/interface[@name='EngineMachineLearning']/method[@name='getOutputCount' and count(parameter)=0]"
			[Register ("getOutputCount", "()I", "GetGetOutputCountHandler:Org.Encog.Engine.IEngineMachineLearningInvoker, neuroph_2.5RC2")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine']/interface[@name='EngineMachineLearning']/method[@name='compute' and count(parameter)=2 and parameter[1][@type='double[]'] and parameter[2][@type='double[]']]"
		[Register ("compute", "([D[D)V", "GetCompute_arrayDarrayDHandler:Org.Encog.Engine.IEngineMachineLearningInvoker, neuroph_2.5RC2")]
		void Compute (double[] p0, double[] p1);

	}

	[global::Android.Runtime.Register ("org/encog/engine/EngineMachineLearning", DoNotGenerateAcw=true)]
	internal class IEngineMachineLearningInvoker : global::Java.Lang.Object, IEngineMachineLearning {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/encog/engine/EngineMachineLearning");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IEngineMachineLearningInvoker); }
		}

		IntPtr class_ref;

		public static IEngineMachineLearning GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IEngineMachineLearning> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.encog.engine.EngineMachineLearning"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IEngineMachineLearningInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Org.Encog.Engine.IEngineMachineLearning __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.IEngineMachineLearning> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Org.Encog.Engine.IEngineMachineLearning __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.IEngineMachineLearning> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Org.Encog.Engine.IEngineMachineLearning __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.IEngineMachineLearning> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
