using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Encog.Engine.Opencl {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.encog.engine.opencl']/class[@name='EncogCLDevice']"
	[global::Android.Runtime.Register ("org/encog/engine/opencl/EncogCLDevice", DoNotGenerateAcw=true)]
	public partial class EncogCLDevice : global::Org.Encog.Engine.Opencl.EncogCLItem {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/encog/engine/opencl/EncogCLDevice", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (EncogCLDevice); }
		}

		protected EncogCLDevice (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_encog_engine_opencl_EncogCLPlatform_Lorg_jocl_cl_device_id_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.encog.engine.opencl']/class[@name='EncogCLDevice']/constructor[@name='EncogCLDevice' and count(parameter)=2 and parameter[1][@type='org.encog.engine.opencl.EncogCLPlatform'] and parameter[2][@type='org.jocl.cl_device_id']]"
		[Register (".ctor", "(Lorg/encog/engine/opencl/EncogCLPlatform;Lorg/jocl/cl_device_id;)V", "")]
		public unsafe EncogCLDevice (global::Org.Encog.Engine.Opencl.EncogCLPlatform p0, global::Org.Jocl.Cl_device_id p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (EncogCLDevice)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/encog/engine/opencl/EncogCLPlatform;Lorg/jocl/cl_device_id;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorg/encog/engine/opencl/EncogCLPlatform;Lorg/jocl/cl_device_id;)V", __args);
					return;
				}

				if (id_ctor_Lorg_encog_engine_opencl_EncogCLPlatform_Lorg_jocl_cl_device_id_ == IntPtr.Zero)
					id_ctor_Lorg_encog_engine_opencl_EncogCLPlatform_Lorg_jocl_cl_device_id_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/encog/engine/opencl/EncogCLPlatform;Lorg/jocl/cl_device_id;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_encog_engine_opencl_EncogCLPlatform_Lorg_jocl_cl_device_id_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_encog_engine_opencl_EncogCLPlatform_Lorg_jocl_cl_device_id_, __args);
			} finally {
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
			global::Org.Encog.Engine.Opencl.EncogCLDevice __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Opencl.EncogCLDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Device);
		}
#pragma warning restore 0169

		static IntPtr id_getDevice;
		public virtual unsafe global::Org.Jocl.Cl_device_id Device {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.opencl']/class[@name='EncogCLDevice']/method[@name='getDevice' and count(parameter)=0]"
			[Register ("getDevice", "()Lorg/jocl/cl_device_id;", "GetGetDeviceHandler")]
			get {
				if (id_getDevice == IntPtr.Zero)
					id_getDevice = JNIEnv.GetMethodID (class_ref, "getDevice", "()Lorg/jocl/cl_device_id;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Jocl.Cl_device_id> (JNIEnv.CallObjectMethod  (Handle, id_getDevice), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Jocl.Cl_device_id> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDevice", "()Lorg/jocl/cl_device_id;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getGlobalMemorySize;
#pragma warning disable 0169
		static Delegate GetGetGlobalMemorySizeHandler ()
		{
			if (cb_getGlobalMemorySize == null)
				cb_getGlobalMemorySize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetGlobalMemorySize);
			return cb_getGlobalMemorySize;
		}

		static long n_GetGlobalMemorySize (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Opencl.EncogCLDevice __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Opencl.EncogCLDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GlobalMemorySize;
		}
#pragma warning restore 0169

		static IntPtr id_getGlobalMemorySize;
		public virtual unsafe long GlobalMemorySize {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.opencl']/class[@name='EncogCLDevice']/method[@name='getGlobalMemorySize' and count(parameter)=0]"
			[Register ("getGlobalMemorySize", "()J", "GetGetGlobalMemorySizeHandler")]
			get {
				if (id_getGlobalMemorySize == IntPtr.Zero)
					id_getGlobalMemorySize = JNIEnv.GetMethodID (class_ref, "getGlobalMemorySize", "()J");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallLongMethod  (Handle, id_getGlobalMemorySize);
					else
						return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getGlobalMemorySize", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_isCPU;
#pragma warning disable 0169
		static Delegate GetIsCPUHandler ()
		{
			if (cb_isCPU == null)
				cb_isCPU = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsCPU);
			return cb_isCPU;
		}

		static bool n_IsCPU (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Opencl.EncogCLDevice __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Opencl.EncogCLDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsCPU;
		}
#pragma warning restore 0169

		static IntPtr id_isCPU;
		public virtual unsafe bool IsCPU {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.opencl']/class[@name='EncogCLDevice']/method[@name='isCPU' and count(parameter)=0]"
			[Register ("isCPU", "()Z", "GetIsCPUHandler")]
			get {
				if (id_isCPU == IntPtr.Zero)
					id_isCPU = JNIEnv.GetMethodID (class_ref, "isCPU", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isCPU);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isCPU", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getLocalMemorySize;
#pragma warning disable 0169
		static Delegate GetGetLocalMemorySizeHandler ()
		{
			if (cb_getLocalMemorySize == null)
				cb_getLocalMemorySize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetLocalMemorySize);
			return cb_getLocalMemorySize;
		}

		static long n_GetLocalMemorySize (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Opencl.EncogCLDevice __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Opencl.EncogCLDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LocalMemorySize;
		}
#pragma warning restore 0169

		static IntPtr id_getLocalMemorySize;
		public virtual unsafe long LocalMemorySize {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.opencl']/class[@name='EncogCLDevice']/method[@name='getLocalMemorySize' and count(parameter)=0]"
			[Register ("getLocalMemorySize", "()J", "GetGetLocalMemorySizeHandler")]
			get {
				if (id_getLocalMemorySize == IntPtr.Zero)
					id_getLocalMemorySize = JNIEnv.GetMethodID (class_ref, "getLocalMemorySize", "()J");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallLongMethod  (Handle, id_getLocalMemorySize);
					else
						return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLocalMemorySize", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_getMaxClockFrequency;
#pragma warning disable 0169
		static Delegate GetGetMaxClockFrequencyHandler ()
		{
			if (cb_getMaxClockFrequency == null)
				cb_getMaxClockFrequency = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetMaxClockFrequency);
			return cb_getMaxClockFrequency;
		}

		static long n_GetMaxClockFrequency (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Opencl.EncogCLDevice __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Opencl.EncogCLDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxClockFrequency;
		}
#pragma warning restore 0169

		static IntPtr id_getMaxClockFrequency;
		public virtual unsafe long MaxClockFrequency {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.opencl']/class[@name='EncogCLDevice']/method[@name='getMaxClockFrequency' and count(parameter)=0]"
			[Register ("getMaxClockFrequency", "()J", "GetGetMaxClockFrequencyHandler")]
			get {
				if (id_getMaxClockFrequency == IntPtr.Zero)
					id_getMaxClockFrequency = JNIEnv.GetMethodID (class_ref, "getMaxClockFrequency", "()J");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallLongMethod  (Handle, id_getMaxClockFrequency);
					else
						return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMaxClockFrequency", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_getMaxComputeUnits;
#pragma warning disable 0169
		static Delegate GetGetMaxComputeUnitsHandler ()
		{
			if (cb_getMaxComputeUnits == null)
				cb_getMaxComputeUnits = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetMaxComputeUnits);
			return cb_getMaxComputeUnits;
		}

		static long n_GetMaxComputeUnits (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Opencl.EncogCLDevice __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Opencl.EncogCLDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxComputeUnits;
		}
#pragma warning restore 0169

		static IntPtr id_getMaxComputeUnits;
		public virtual unsafe long MaxComputeUnits {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.opencl']/class[@name='EncogCLDevice']/method[@name='getMaxComputeUnits' and count(parameter)=0]"
			[Register ("getMaxComputeUnits", "()J", "GetGetMaxComputeUnitsHandler")]
			get {
				if (id_getMaxComputeUnits == IntPtr.Zero)
					id_getMaxComputeUnits = JNIEnv.GetMethodID (class_ref, "getMaxComputeUnits", "()J");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallLongMethod  (Handle, id_getMaxComputeUnits);
					else
						return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMaxComputeUnits", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_getMaxWorkGroupSize;
#pragma warning disable 0169
		static Delegate GetGetMaxWorkGroupSizeHandler ()
		{
			if (cb_getMaxWorkGroupSize == null)
				cb_getMaxWorkGroupSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetMaxWorkGroupSize);
			return cb_getMaxWorkGroupSize;
		}

		static long n_GetMaxWorkGroupSize (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Opencl.EncogCLDevice __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Opencl.EncogCLDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxWorkGroupSize;
		}
#pragma warning restore 0169

		static IntPtr id_getMaxWorkGroupSize;
		public virtual unsafe long MaxWorkGroupSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.opencl']/class[@name='EncogCLDevice']/method[@name='getMaxWorkGroupSize' and count(parameter)=0]"
			[Register ("getMaxWorkGroupSize", "()J", "GetGetMaxWorkGroupSizeHandler")]
			get {
				if (id_getMaxWorkGroupSize == IntPtr.Zero)
					id_getMaxWorkGroupSize = JNIEnv.GetMethodID (class_ref, "getMaxWorkGroupSize", "()J");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallLongMethod  (Handle, id_getMaxWorkGroupSize);
					else
						return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMaxWorkGroupSize", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_getPlatform;
#pragma warning disable 0169
		static Delegate GetGetPlatformHandler ()
		{
			if (cb_getPlatform == null)
				cb_getPlatform = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPlatform);
			return cb_getPlatform;
		}

		static IntPtr n_GetPlatform (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Opencl.EncogCLDevice __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Opencl.EncogCLDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Platform);
		}
#pragma warning restore 0169

		static IntPtr id_getPlatform;
		public virtual unsafe global::Org.Encog.Engine.Opencl.EncogCLPlatform Platform {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.opencl']/class[@name='EncogCLDevice']/method[@name='getPlatform' and count(parameter)=0]"
			[Register ("getPlatform", "()Lorg/encog/engine/opencl/EncogCLPlatform;", "GetGetPlatformHandler")]
			get {
				if (id_getPlatform == IntPtr.Zero)
					id_getPlatform = JNIEnv.GetMethodID (class_ref, "getPlatform", "()Lorg/encog/engine/opencl/EncogCLPlatform;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Opencl.EncogCLPlatform> (JNIEnv.CallObjectMethod  (Handle, id_getPlatform), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Opencl.EncogCLPlatform> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPlatform", "()Lorg/encog/engine/opencl/EncogCLPlatform;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getQueue;
#pragma warning disable 0169
		static Delegate GetGetQueueHandler ()
		{
			if (cb_getQueue == null)
				cb_getQueue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetQueue);
			return cb_getQueue;
		}

		static IntPtr n_GetQueue (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Opencl.EncogCLDevice __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Opencl.EncogCLDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Queue);
		}
#pragma warning restore 0169

		static IntPtr id_getQueue;
		public virtual unsafe global::Org.Encog.Engine.Opencl.EncogCLQueue Queue {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.opencl']/class[@name='EncogCLDevice']/method[@name='getQueue' and count(parameter)=0]"
			[Register ("getQueue", "()Lorg/encog/engine/opencl/EncogCLQueue;", "GetGetQueueHandler")]
			get {
				if (id_getQueue == IntPtr.Zero)
					id_getQueue = JNIEnv.GetMethodID (class_ref, "getQueue", "()Lorg/encog/engine/opencl/EncogCLQueue;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Opencl.EncogCLQueue> (JNIEnv.CallObjectMethod  (Handle, id_getQueue), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Opencl.EncogCLQueue> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getQueue", "()Lorg/encog/engine/opencl/EncogCLQueue;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDeviceLong_I;
#pragma warning disable 0169
		static Delegate GetGetDeviceLong_IHandler ()
		{
			if (cb_getDeviceLong_I == null)
				cb_getDeviceLong_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, long>) n_GetDeviceLong_I);
			return cb_getDeviceLong_I;
		}

		static long n_GetDeviceLong_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Encog.Engine.Opencl.EncogCLDevice __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Opencl.EncogCLDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetDeviceLong (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getDeviceLong_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.opencl']/class[@name='EncogCLDevice']/method[@name='getDeviceLong' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getDeviceLong", "(I)J", "GetGetDeviceLong_IHandler")]
		public virtual unsafe long GetDeviceLong (int p0)
		{
			if (id_getDeviceLong_I == IntPtr.Zero)
				id_getDeviceLong_I = JNIEnv.GetMethodID (class_ref, "getDeviceLong", "(I)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.CallLongMethod  (Handle, id_getDeviceLong_I, __args);
				else
					return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDeviceLong", "(I)J"), __args);
			} finally {
			}
		}

		static Delegate cb_getDeviceString_I;
#pragma warning disable 0169
		static Delegate GetGetDeviceString_IHandler ()
		{
			if (cb_getDeviceString_I == null)
				cb_getDeviceString_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetDeviceString_I);
			return cb_getDeviceString_I;
		}

		static IntPtr n_GetDeviceString_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Encog.Engine.Opencl.EncogCLDevice __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Opencl.EncogCLDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GetDeviceString (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getDeviceString_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.opencl']/class[@name='EncogCLDevice']/method[@name='getDeviceString' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getDeviceString", "(I)Ljava/lang/String;", "GetGetDeviceString_IHandler")]
		public virtual unsafe string GetDeviceString (int p0)
		{
			if (id_getDeviceString_I == IntPtr.Zero)
				id_getDeviceString_I = JNIEnv.GetMethodID (class_ref, "getDeviceString", "(I)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getDeviceString_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDeviceString", "(I)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
