using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Encog.Engine.Opencl {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.encog.engine.opencl']/class[@name='EncogCLQueue']"
	[global::Android.Runtime.Register ("org/encog/engine/opencl/EncogCLQueue", DoNotGenerateAcw=true)]
	public partial class EncogCLQueue : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/encog/engine/opencl/EncogCLQueue", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (EncogCLQueue); }
		}

		protected EncogCLQueue (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_encog_engine_opencl_EncogCLDevice_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.encog.engine.opencl']/class[@name='EncogCLQueue']/constructor[@name='EncogCLQueue' and count(parameter)=1 and parameter[1][@type='org.encog.engine.opencl.EncogCLDevice']]"
		[Register (".ctor", "(Lorg/encog/engine/opencl/EncogCLDevice;)V", "")]
		public unsafe EncogCLQueue (global::Org.Encog.Engine.Opencl.EncogCLDevice p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (EncogCLQueue)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/encog/engine/opencl/EncogCLDevice;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorg/encog/engine/opencl/EncogCLDevice;)V", __args);
					return;
				}

				if (id_ctor_Lorg_encog_engine_opencl_EncogCLDevice_ == IntPtr.Zero)
					id_ctor_Lorg_encog_engine_opencl_EncogCLDevice_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/encog/engine/opencl/EncogCLDevice;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_encog_engine_opencl_EncogCLDevice_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_encog_engine_opencl_EncogCLDevice_, __args);
			} finally {
			}
		}

		static Delegate cb_getCommands;
#pragma warning disable 0169
		static Delegate GetGetCommandsHandler ()
		{
			if (cb_getCommands == null)
				cb_getCommands = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCommands);
			return cb_getCommands;
		}

		static IntPtr n_GetCommands (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Opencl.EncogCLQueue __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Opencl.EncogCLQueue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Commands);
		}
#pragma warning restore 0169

		static IntPtr id_getCommands;
		public virtual unsafe global::Org.Jocl.Cl_command_queue Commands {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.opencl']/class[@name='EncogCLQueue']/method[@name='getCommands' and count(parameter)=0]"
			[Register ("getCommands", "()Lorg/jocl/cl_command_queue;", "GetGetCommandsHandler")]
			get {
				if (id_getCommands == IntPtr.Zero)
					id_getCommands = JNIEnv.GetMethodID (class_ref, "getCommands", "()Lorg/jocl/cl_command_queue;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Jocl.Cl_command_queue> (JNIEnv.CallObjectMethod  (Handle, id_getCommands), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Jocl.Cl_command_queue> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCommands", "()Lorg/jocl/cl_command_queue;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDevice;
#pragma warning disable 0169
		static Delegate GetGetDeviceHandler ()
		{
			if (cb_getDevice == null)
				cb_getDevice = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDevice);
			return cb_getDevice;
		}

		static IntPtr n_GetDevice (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Opencl.EncogCLQueue __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Opencl.EncogCLQueue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Device);
		}
#pragma warning restore 0169

		static IntPtr id_getDevice;
		public virtual unsafe global::Org.Encog.Engine.Opencl.EncogCLDevice Device {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.opencl']/class[@name='EncogCLQueue']/method[@name='getDevice' and count(parameter)=0]"
			[Register ("getDevice", "()Lorg/encog/engine/opencl/EncogCLDevice;", "GetGetDeviceHandler")]
			get {
				if (id_getDevice == IntPtr.Zero)
					id_getDevice = JNIEnv.GetMethodID (class_ref, "getDevice", "()Lorg/encog/engine/opencl/EncogCLDevice;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Opencl.EncogCLDevice> (JNIEnv.CallObjectMethod  (Handle, id_getDevice), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Opencl.EncogCLDevice> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDevice", "()Lorg/encog/engine/opencl/EncogCLDevice;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_array2Buffer_arrayFLorg_jocl_cl_mem_;
#pragma warning disable 0169
		static Delegate GetArray2Buffer_arrayFLorg_jocl_cl_mem_Handler ()
		{
			if (cb_array2Buffer_arrayFLorg_jocl_cl_mem_ == null)
				cb_array2Buffer_arrayFLorg_jocl_cl_mem_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Array2Buffer_arrayFLorg_jocl_cl_mem_);
			return cb_array2Buffer_arrayFLorg_jocl_cl_mem_;
		}

		static void n_Array2Buffer_arrayFLorg_jocl_cl_mem_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Encog.Engine.Opencl.EncogCLQueue __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Opencl.EncogCLQueue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			float[] p0 = (float[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (float));
			global::Org.Jocl.Cl_mem p1 = global::Java.Lang.Object.GetObject<global::Org.Jocl.Cl_mem> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Array2Buffer (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_array2Buffer_arrayFLorg_jocl_cl_mem_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.opencl']/class[@name='EncogCLQueue']/method[@name='array2Buffer' and count(parameter)=2 and parameter[1][@type='float[]'] and parameter[2][@type='org.jocl.cl_mem']]"
		[Register ("array2Buffer", "([FLorg/jocl/cl_mem;)V", "GetArray2Buffer_arrayFLorg_jocl_cl_mem_Handler")]
		public virtual unsafe void Array2Buffer (float[] p0, global::Org.Jocl.Cl_mem p1)
		{
			if (id_array2Buffer_arrayFLorg_jocl_cl_mem_ == IntPtr.Zero)
				id_array2Buffer_arrayFLorg_jocl_cl_mem_ = JNIEnv.GetMethodID (class_ref, "array2Buffer", "([FLorg/jocl/cl_mem;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_array2Buffer_arrayFLorg_jocl_cl_mem_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "array2Buffer", "([FLorg/jocl/cl_mem;)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_array2Buffer_arrayILorg_jocl_cl_mem_;
#pragma warning disable 0169
		static Delegate GetArray2Buffer_arrayILorg_jocl_cl_mem_Handler ()
		{
			if (cb_array2Buffer_arrayILorg_jocl_cl_mem_ == null)
				cb_array2Buffer_arrayILorg_jocl_cl_mem_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Array2Buffer_arrayILorg_jocl_cl_mem_);
			return cb_array2Buffer_arrayILorg_jocl_cl_mem_;
		}

		static void n_Array2Buffer_arrayILorg_jocl_cl_mem_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Encog.Engine.Opencl.EncogCLQueue __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Opencl.EncogCLQueue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] p0 = (int[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (int));
			global::Org.Jocl.Cl_mem p1 = global::Java.Lang.Object.GetObject<global::Org.Jocl.Cl_mem> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Array2Buffer (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_array2Buffer_arrayILorg_jocl_cl_mem_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.opencl']/class[@name='EncogCLQueue']/method[@name='array2Buffer' and count(parameter)=2 and parameter[1][@type='int[]'] and parameter[2][@type='org.jocl.cl_mem']]"
		[Register ("array2Buffer", "([ILorg/jocl/cl_mem;)V", "GetArray2Buffer_arrayILorg_jocl_cl_mem_Handler")]
		public virtual unsafe void Array2Buffer (int[] p0, global::Org.Jocl.Cl_mem p1)
		{
			if (id_array2Buffer_arrayILorg_jocl_cl_mem_ == IntPtr.Zero)
				id_array2Buffer_arrayILorg_jocl_cl_mem_ = JNIEnv.GetMethodID (class_ref, "array2Buffer", "([ILorg/jocl/cl_mem;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_array2Buffer_arrayILorg_jocl_cl_mem_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "array2Buffer", "([ILorg/jocl/cl_mem;)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_buffer2Array_Lorg_jocl_cl_mem_arrayF;
#pragma warning disable 0169
		static Delegate GetBuffer2Array_Lorg_jocl_cl_mem_arrayFHandler ()
		{
			if (cb_buffer2Array_Lorg_jocl_cl_mem_arrayF == null)
				cb_buffer2Array_Lorg_jocl_cl_mem_arrayF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Buffer2Array_Lorg_jocl_cl_mem_arrayF);
			return cb_buffer2Array_Lorg_jocl_cl_mem_arrayF;
		}

		static void n_Buffer2Array_Lorg_jocl_cl_mem_arrayF (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Encog.Engine.Opencl.EncogCLQueue __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Opencl.EncogCLQueue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jocl.Cl_mem p0 = global::Java.Lang.Object.GetObject<global::Org.Jocl.Cl_mem> (native_p0, JniHandleOwnership.DoNotTransfer);
			float[] p1 = (float[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (float));
			__this.Buffer2Array (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		static IntPtr id_buffer2Array_Lorg_jocl_cl_mem_arrayF;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.opencl']/class[@name='EncogCLQueue']/method[@name='buffer2Array' and count(parameter)=2 and parameter[1][@type='org.jocl.cl_mem'] and parameter[2][@type='float[]']]"
		[Register ("buffer2Array", "(Lorg/jocl/cl_mem;[F)V", "GetBuffer2Array_Lorg_jocl_cl_mem_arrayFHandler")]
		public virtual unsafe void Buffer2Array (global::Org.Jocl.Cl_mem p0, float[] p1)
		{
			if (id_buffer2Array_Lorg_jocl_cl_mem_arrayF == IntPtr.Zero)
				id_buffer2Array_Lorg_jocl_cl_mem_arrayF = JNIEnv.GetMethodID (class_ref, "buffer2Array", "(Lorg/jocl/cl_mem;[F)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_buffer2Array_Lorg_jocl_cl_mem_arrayF, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "buffer2Array", "(Lorg/jocl/cl_mem;[F)V"), __args);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static Delegate cb_buffer2Array_Lorg_jocl_cl_mem_arrayI;
#pragma warning disable 0169
		static Delegate GetBuffer2Array_Lorg_jocl_cl_mem_arrayIHandler ()
		{
			if (cb_buffer2Array_Lorg_jocl_cl_mem_arrayI == null)
				cb_buffer2Array_Lorg_jocl_cl_mem_arrayI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Buffer2Array_Lorg_jocl_cl_mem_arrayI);
			return cb_buffer2Array_Lorg_jocl_cl_mem_arrayI;
		}

		static void n_Buffer2Array_Lorg_jocl_cl_mem_arrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Encog.Engine.Opencl.EncogCLQueue __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Opencl.EncogCLQueue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jocl.Cl_mem p0 = global::Java.Lang.Object.GetObject<global::Org.Jocl.Cl_mem> (native_p0, JniHandleOwnership.DoNotTransfer);
			int[] p1 = (int[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.Buffer2Array (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		static IntPtr id_buffer2Array_Lorg_jocl_cl_mem_arrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.opencl']/class[@name='EncogCLQueue']/method[@name='buffer2Array' and count(parameter)=2 and parameter[1][@type='org.jocl.cl_mem'] and parameter[2][@type='int[]']]"
		[Register ("buffer2Array", "(Lorg/jocl/cl_mem;[I)V", "GetBuffer2Array_Lorg_jocl_cl_mem_arrayIHandler")]
		public virtual unsafe void Buffer2Array (global::Org.Jocl.Cl_mem p0, int[] p1)
		{
			if (id_buffer2Array_Lorg_jocl_cl_mem_arrayI == IntPtr.Zero)
				id_buffer2Array_Lorg_jocl_cl_mem_arrayI = JNIEnv.GetMethodID (class_ref, "buffer2Array", "(Lorg/jocl/cl_mem;[I)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_buffer2Array_Lorg_jocl_cl_mem_arrayI, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "buffer2Array", "(Lorg/jocl/cl_mem;[I)V"), __args);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static Delegate cb_execute_Lorg_encog_engine_opencl_kernels_EncogKernel_;
#pragma warning disable 0169
		static Delegate GetExecute_Lorg_encog_engine_opencl_kernels_EncogKernel_Handler ()
		{
			if (cb_execute_Lorg_encog_engine_opencl_kernels_EncogKernel_ == null)
				cb_execute_Lorg_encog_engine_opencl_kernels_EncogKernel_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Execute_Lorg_encog_engine_opencl_kernels_EncogKernel_);
			return cb_execute_Lorg_encog_engine_opencl_kernels_EncogKernel_;
		}

		static void n_Execute_Lorg_encog_engine_opencl_kernels_EncogKernel_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Encog.Engine.Opencl.EncogCLQueue __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Opencl.EncogCLQueue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Encog.Engine.Opencl.Kernels.EncogKernel p0 = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Opencl.Kernels.EncogKernel> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Execute (p0);
		}
#pragma warning restore 0169

		static IntPtr id_execute_Lorg_encog_engine_opencl_kernels_EncogKernel_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.opencl']/class[@name='EncogCLQueue']/method[@name='execute' and count(parameter)=1 and parameter[1][@type='org.encog.engine.opencl.kernels.EncogKernel']]"
		[Register ("execute", "(Lorg/encog/engine/opencl/kernels/EncogKernel;)V", "GetExecute_Lorg_encog_engine_opencl_kernels_EncogKernel_Handler")]
		public virtual unsafe void Execute (global::Org.Encog.Engine.Opencl.Kernels.EncogKernel p0)
		{
			if (id_execute_Lorg_encog_engine_opencl_kernels_EncogKernel_ == IntPtr.Zero)
				id_execute_Lorg_encog_engine_opencl_kernels_EncogKernel_ = JNIEnv.GetMethodID (class_ref, "execute", "(Lorg/encog/engine/opencl/kernels/EncogKernel;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_execute_Lorg_encog_engine_opencl_kernels_EncogKernel_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "execute", "(Lorg/encog/engine/opencl/kernels/EncogKernel;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_waitFinish;
#pragma warning disable 0169
		static Delegate GetWaitFinishHandler ()
		{
			if (cb_waitFinish == null)
				cb_waitFinish = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_WaitFinish);
			return cb_waitFinish;
		}

		static void n_WaitFinish (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Opencl.EncogCLQueue __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Opencl.EncogCLQueue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WaitFinish ();
		}
#pragma warning restore 0169

		static IntPtr id_waitFinish;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.opencl']/class[@name='EncogCLQueue']/method[@name='waitFinish' and count(parameter)=0]"
		[Register ("waitFinish", "()V", "GetWaitFinishHandler")]
		public virtual unsafe void WaitFinish ()
		{
			if (id_waitFinish == IntPtr.Zero)
				id_waitFinish = JNIEnv.GetMethodID (class_ref, "waitFinish", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_waitFinish);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "waitFinish", "()V"));
			} finally {
			}
		}

	}
}
