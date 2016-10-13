using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Encog.Engine.Opencl.Kernels {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.encog.engine.opencl.kernels']/class[@name='KernelVectorAdd']"
	[global::Android.Runtime.Register ("org/encog/engine/opencl/kernels/KernelVectorAdd", DoNotGenerateAcw=true)]
	public partial class KernelVectorAdd : global::Org.Encog.Engine.Opencl.Kernels.EncogKernel {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/encog/engine/opencl/kernels/KernelVectorAdd", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (KernelVectorAdd); }
		}

		protected KernelVectorAdd (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_encog_engine_opencl_EncogCLDevice_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.encog.engine.opencl.kernels']/class[@name='KernelVectorAdd']/constructor[@name='KernelVectorAdd' and count(parameter)=2 and parameter[1][@type='org.encog.engine.opencl.EncogCLDevice'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Lorg/encog/engine/opencl/EncogCLDevice;I)V", "")]
		public unsafe KernelVectorAdd (global::Org.Encog.Engine.Opencl.EncogCLDevice p0, int p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (KernelVectorAdd)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/encog/engine/opencl/EncogCLDevice;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/encog/engine/opencl/EncogCLDevice;I)V", __args);
					return;
				}

				if (id_ctor_Lorg_encog_engine_opencl_EncogCLDevice_I == IntPtr.Zero)
					id_ctor_Lorg_encog_engine_opencl_EncogCLDevice_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/encog/engine/opencl/EncogCLDevice;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_encog_engine_opencl_EncogCLDevice_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_encog_engine_opencl_EncogCLDevice_I, __args);
			} finally {
			}
		}

		static Delegate cb_add_Lorg_encog_engine_opencl_EncogCLDevice_arrayDarrayD;
#pragma warning disable 0169
		static Delegate GetAdd_Lorg_encog_engine_opencl_EncogCLDevice_arrayDarrayDHandler ()
		{
			if (cb_add_Lorg_encog_engine_opencl_EncogCLDevice_arrayDarrayD == null)
				cb_add_Lorg_encog_engine_opencl_EncogCLDevice_arrayDarrayD = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Add_Lorg_encog_engine_opencl_EncogCLDevice_arrayDarrayD);
			return cb_add_Lorg_encog_engine_opencl_EncogCLDevice_arrayDarrayD;
		}

		static IntPtr n_Add_Lorg_encog_engine_opencl_EncogCLDevice_arrayDarrayD (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Org.Encog.Engine.Opencl.Kernels.KernelVectorAdd __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Opencl.Kernels.KernelVectorAdd> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Encog.Engine.Opencl.EncogCLDevice p0 = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Opencl.EncogCLDevice> (native_p0, JniHandleOwnership.DoNotTransfer);
			double[] p1 = (double[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (double));
			double[] p2 = (double[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (double));
			IntPtr __ret = JNIEnv.NewArray (__this.Add (p0, p1, p2));
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_add_Lorg_encog_engine_opencl_EncogCLDevice_arrayDarrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.opencl.kernels']/class[@name='KernelVectorAdd']/method[@name='add' and count(parameter)=3 and parameter[1][@type='org.encog.engine.opencl.EncogCLDevice'] and parameter[2][@type='double[]'] and parameter[3][@type='double[]']]"
		[Register ("add", "(Lorg/encog/engine/opencl/EncogCLDevice;[D[D)[D", "GetAdd_Lorg_encog_engine_opencl_EncogCLDevice_arrayDarrayDHandler")]
		public virtual unsafe double[] Add (global::Org.Encog.Engine.Opencl.EncogCLDevice p0, double[] p1, double[] p2)
		{
			if (id_add_Lorg_encog_engine_opencl_EncogCLDevice_arrayDarrayD == IntPtr.Zero)
				id_add_Lorg_encog_engine_opencl_EncogCLDevice_arrayDarrayD = JNIEnv.GetMethodID (class_ref, "add", "(Lorg/encog/engine/opencl/EncogCLDevice;[D[D)[D");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);

				double[] __ret;
				if (GetType () == ThresholdType)
					__ret = (double[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_add_Lorg_encog_engine_opencl_EncogCLDevice_arrayDarrayD, __args), JniHandleOwnership.TransferLocalRef, typeof (double));
				else
					__ret = (double[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "add", "(Lorg/encog/engine/opencl/EncogCLDevice;[D[D)[D"), __args), JniHandleOwnership.TransferLocalRef, typeof (double));
				return __ret;
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

	}
}
