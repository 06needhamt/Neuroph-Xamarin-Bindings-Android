using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Encog.Engine.Network.Train.Prop {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.encog.engine.network.train.prop']/class[@name='OpenCLTrainingProfile']"
	[global::Android.Runtime.Register ("org/encog/engine/network/train/prop/OpenCLTrainingProfile", DoNotGenerateAcw=true)]
	public partial class OpenCLTrainingProfile : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/encog/engine/network/train/prop/OpenCLTrainingProfile", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (OpenCLTrainingProfile); }
		}

		protected OpenCLTrainingProfile (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_encog_engine_opencl_EncogCLDevice_DID;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.encog.engine.network.train.prop']/class[@name='OpenCLTrainingProfile']/constructor[@name='OpenCLTrainingProfile' and count(parameter)=4 and parameter[1][@type='org.encog.engine.opencl.EncogCLDevice'] and parameter[2][@type='double'] and parameter[3][@type='int'] and parameter[4][@type='double']]"
		[Register (".ctor", "(Lorg/encog/engine/opencl/EncogCLDevice;DID)V", "")]
		public unsafe OpenCLTrainingProfile (global::Org.Encog.Engine.Opencl.EncogCLDevice p0, double p1, int p2, double p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				if (GetType () != typeof (OpenCLTrainingProfile)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/encog/engine/opencl/EncogCLDevice;DID)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/encog/engine/opencl/EncogCLDevice;DID)V", __args);
					return;
				}

				if (id_ctor_Lorg_encog_engine_opencl_EncogCLDevice_DID == IntPtr.Zero)
					id_ctor_Lorg_encog_engine_opencl_EncogCLDevice_DID = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/encog/engine/opencl/EncogCLDevice;DID)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_encog_engine_opencl_EncogCLDevice_DID, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_encog_engine_opencl_EncogCLDevice_DID, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Lorg_encog_engine_opencl_EncogCLDevice_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.encog.engine.network.train.prop']/class[@name='OpenCLTrainingProfile']/constructor[@name='OpenCLTrainingProfile' and count(parameter)=1 and parameter[1][@type='org.encog.engine.opencl.EncogCLDevice']]"
		[Register (".ctor", "(Lorg/encog/engine/opencl/EncogCLDevice;)V", "")]
		public unsafe OpenCLTrainingProfile (global::Org.Encog.Engine.Opencl.EncogCLDevice p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (OpenCLTrainingProfile)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/encog/engine/opencl/EncogCLDevice;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/encog/engine/opencl/EncogCLDevice;)V", __args);
					return;
				}

				if (id_ctor_Lorg_encog_engine_opencl_EncogCLDevice_ == IntPtr.Zero)
					id_ctor_Lorg_encog_engine_opencl_EncogCLDevice_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/encog/engine/opencl/EncogCLDevice;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_encog_engine_opencl_EncogCLDevice_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_encog_engine_opencl_EncogCLDevice_, __args);
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
			global::Org.Encog.Engine.Network.Train.Prop.OpenCLTrainingProfile __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Train.Prop.OpenCLTrainingProfile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Device);
		}
#pragma warning restore 0169

		static Delegate cb_setDevice_Lorg_encog_engine_opencl_EncogCLDevice_;
#pragma warning disable 0169
		static Delegate GetSetDevice_Lorg_encog_engine_opencl_EncogCLDevice_Handler ()
		{
			if (cb_setDevice_Lorg_encog_engine_opencl_EncogCLDevice_ == null)
				cb_setDevice_Lorg_encog_engine_opencl_EncogCLDevice_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDevice_Lorg_encog_engine_opencl_EncogCLDevice_);
			return cb_setDevice_Lorg_encog_engine_opencl_EncogCLDevice_;
		}

		static void n_SetDevice_Lorg_encog_engine_opencl_EncogCLDevice_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Encog.Engine.Network.Train.Prop.OpenCLTrainingProfile __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Train.Prop.OpenCLTrainingProfile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Encog.Engine.Opencl.EncogCLDevice p0 = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Opencl.EncogCLDevice> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Device = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDevice;
		static IntPtr id_setDevice_Lorg_encog_engine_opencl_EncogCLDevice_;
		public virtual unsafe global::Org.Encog.Engine.Opencl.EncogCLDevice Device {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.train.prop']/class[@name='OpenCLTrainingProfile']/method[@name='getDevice' and count(parameter)=0]"
			[Register ("getDevice", "()Lorg/encog/engine/opencl/EncogCLDevice;", "GetGetDeviceHandler")]
			get {
				if (id_getDevice == IntPtr.Zero)
					id_getDevice = JNIEnv.GetMethodID (class_ref, "getDevice", "()Lorg/encog/engine/opencl/EncogCLDevice;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Opencl.EncogCLDevice> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDevice), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Opencl.EncogCLDevice> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDevice", "()Lorg/encog/engine/opencl/EncogCLDevice;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.train.prop']/class[@name='OpenCLTrainingProfile']/method[@name='setDevice' and count(parameter)=1 and parameter[1][@type='org.encog.engine.opencl.EncogCLDevice']]"
			[Register ("setDevice", "(Lorg/encog/engine/opencl/EncogCLDevice;)V", "GetSetDevice_Lorg_encog_engine_opencl_EncogCLDevice_Handler")]
			set {
				if (id_setDevice_Lorg_encog_engine_opencl_EncogCLDevice_ == IntPtr.Zero)
					id_setDevice_Lorg_encog_engine_opencl_EncogCLDevice_ = JNIEnv.GetMethodID (class_ref, "setDevice", "(Lorg/encog/engine/opencl/EncogCLDevice;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDevice_Lorg_encog_engine_opencl_EncogCLDevice_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDevice", "(Lorg/encog/engine/opencl/EncogCLDevice;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getGlobalRatio;
#pragma warning disable 0169
		static Delegate GetGetGlobalRatioHandler ()
		{
			if (cb_getGlobalRatio == null)
				cb_getGlobalRatio = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetGlobalRatio);
			return cb_getGlobalRatio;
		}

		static int n_GetGlobalRatio (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Network.Train.Prop.OpenCLTrainingProfile __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Train.Prop.OpenCLTrainingProfile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GlobalRatio;
		}
#pragma warning restore 0169

		static IntPtr id_getGlobalRatio;
		public virtual unsafe int GlobalRatio {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.train.prop']/class[@name='OpenCLTrainingProfile']/method[@name='getGlobalRatio' and count(parameter)=0]"
			[Register ("getGlobalRatio", "()I", "GetGetGlobalRatioHandler")]
			get {
				if (id_getGlobalRatio == IntPtr.Zero)
					id_getGlobalRatio = JNIEnv.GetMethodID (class_ref, "getGlobalRatio", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getGlobalRatio);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getGlobalRatio", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getKernelGlobalWorkgroup;
#pragma warning disable 0169
		static Delegate GetGetKernelGlobalWorkgroupHandler ()
		{
			if (cb_getKernelGlobalWorkgroup == null)
				cb_getKernelGlobalWorkgroup = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetKernelGlobalWorkgroup);
			return cb_getKernelGlobalWorkgroup;
		}

		static int n_GetKernelGlobalWorkgroup (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Network.Train.Prop.OpenCLTrainingProfile __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Train.Prop.OpenCLTrainingProfile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.KernelGlobalWorkgroup;
		}
#pragma warning restore 0169

		static IntPtr id_getKernelGlobalWorkgroup;
		public virtual unsafe int KernelGlobalWorkgroup {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.train.prop']/class[@name='OpenCLTrainingProfile']/method[@name='getKernelGlobalWorkgroup' and count(parameter)=0]"
			[Register ("getKernelGlobalWorkgroup", "()I", "GetGetKernelGlobalWorkgroupHandler")]
			get {
				if (id_getKernelGlobalWorkgroup == IntPtr.Zero)
					id_getKernelGlobalWorkgroup = JNIEnv.GetMethodID (class_ref, "getKernelGlobalWorkgroup", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getKernelGlobalWorkgroup);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getKernelGlobalWorkgroup", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getKernelLocalWorkgroup;
#pragma warning disable 0169
		static Delegate GetGetKernelLocalWorkgroupHandler ()
		{
			if (cb_getKernelLocalWorkgroup == null)
				cb_getKernelLocalWorkgroup = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetKernelLocalWorkgroup);
			return cb_getKernelLocalWorkgroup;
		}

		static int n_GetKernelLocalWorkgroup (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Network.Train.Prop.OpenCLTrainingProfile __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Train.Prop.OpenCLTrainingProfile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.KernelLocalWorkgroup;
		}
#pragma warning restore 0169

		static IntPtr id_getKernelLocalWorkgroup;
		public virtual unsafe int KernelLocalWorkgroup {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.train.prop']/class[@name='OpenCLTrainingProfile']/method[@name='getKernelLocalWorkgroup' and count(parameter)=0]"
			[Register ("getKernelLocalWorkgroup", "()I", "GetGetKernelLocalWorkgroupHandler")]
			get {
				if (id_getKernelLocalWorkgroup == IntPtr.Zero)
					id_getKernelLocalWorkgroup = JNIEnv.GetMethodID (class_ref, "getKernelLocalWorkgroup", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getKernelLocalWorkgroup);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getKernelLocalWorkgroup", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getKernelNumberOfCalls;
#pragma warning disable 0169
		static Delegate GetGetKernelNumberOfCallsHandler ()
		{
			if (cb_getKernelNumberOfCalls == null)
				cb_getKernelNumberOfCalls = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetKernelNumberOfCalls);
			return cb_getKernelNumberOfCalls;
		}

		static int n_GetKernelNumberOfCalls (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Network.Train.Prop.OpenCLTrainingProfile __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Train.Prop.OpenCLTrainingProfile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.KernelNumberOfCalls;
		}
#pragma warning restore 0169

		static IntPtr id_getKernelNumberOfCalls;
		public virtual unsafe int KernelNumberOfCalls {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.train.prop']/class[@name='OpenCLTrainingProfile']/method[@name='getKernelNumberOfCalls' and count(parameter)=0]"
			[Register ("getKernelNumberOfCalls", "()I", "GetGetKernelNumberOfCallsHandler")]
			get {
				if (id_getKernelNumberOfCalls == IntPtr.Zero)
					id_getKernelNumberOfCalls = JNIEnv.GetMethodID (class_ref, "getKernelNumberOfCalls", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getKernelNumberOfCalls);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getKernelNumberOfCalls", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getKernelRemainder;
#pragma warning disable 0169
		static Delegate GetGetKernelRemainderHandler ()
		{
			if (cb_getKernelRemainder == null)
				cb_getKernelRemainder = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetKernelRemainder);
			return cb_getKernelRemainder;
		}

		static int n_GetKernelRemainder (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Network.Train.Prop.OpenCLTrainingProfile __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Train.Prop.OpenCLTrainingProfile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.KernelRemainder;
		}
#pragma warning restore 0169

		static IntPtr id_getKernelRemainder;
		public virtual unsafe int KernelRemainder {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.train.prop']/class[@name='OpenCLTrainingProfile']/method[@name='getKernelRemainder' and count(parameter)=0]"
			[Register ("getKernelRemainder", "()I", "GetGetKernelRemainderHandler")]
			get {
				if (id_getKernelRemainder == IntPtr.Zero)
					id_getKernelRemainder = JNIEnv.GetMethodID (class_ref, "getKernelRemainder", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getKernelRemainder);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getKernelRemainder", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getKernelRemainderGlobal;
#pragma warning disable 0169
		static Delegate GetGetKernelRemainderGlobalHandler ()
		{
			if (cb_getKernelRemainderGlobal == null)
				cb_getKernelRemainderGlobal = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetKernelRemainderGlobal);
			return cb_getKernelRemainderGlobal;
		}

		static int n_GetKernelRemainderGlobal (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Network.Train.Prop.OpenCLTrainingProfile __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Train.Prop.OpenCLTrainingProfile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.KernelRemainderGlobal;
		}
#pragma warning restore 0169

		static IntPtr id_getKernelRemainderGlobal;
		public virtual unsafe int KernelRemainderGlobal {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.train.prop']/class[@name='OpenCLTrainingProfile']/method[@name='getKernelRemainderGlobal' and count(parameter)=0]"
			[Register ("getKernelRemainderGlobal", "()I", "GetGetKernelRemainderGlobalHandler")]
			get {
				if (id_getKernelRemainderGlobal == IntPtr.Zero)
					id_getKernelRemainderGlobal = JNIEnv.GetMethodID (class_ref, "getKernelRemainderGlobal", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getKernelRemainderGlobal);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getKernelRemainderGlobal", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getKernelRemainderPer;
#pragma warning disable 0169
		static Delegate GetGetKernelRemainderPerHandler ()
		{
			if (cb_getKernelRemainderPer == null)
				cb_getKernelRemainderPer = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetKernelRemainderPer);
			return cb_getKernelRemainderPer;
		}

		static int n_GetKernelRemainderPer (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Network.Train.Prop.OpenCLTrainingProfile __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Train.Prop.OpenCLTrainingProfile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.KernelRemainderPer;
		}
#pragma warning restore 0169

		static IntPtr id_getKernelRemainderPer;
		public virtual unsafe int KernelRemainderPer {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.train.prop']/class[@name='OpenCLTrainingProfile']/method[@name='getKernelRemainderPer' and count(parameter)=0]"
			[Register ("getKernelRemainderPer", "()I", "GetGetKernelRemainderPerHandler")]
			get {
				if (id_getKernelRemainderPer == IntPtr.Zero)
					id_getKernelRemainderPer = JNIEnv.GetMethodID (class_ref, "getKernelRemainderPer", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getKernelRemainderPer);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getKernelRemainderPer", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getKernelWorkPerCall;
#pragma warning disable 0169
		static Delegate GetGetKernelWorkPerCallHandler ()
		{
			if (cb_getKernelWorkPerCall == null)
				cb_getKernelWorkPerCall = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetKernelWorkPerCall);
			return cb_getKernelWorkPerCall;
		}

		static int n_GetKernelWorkPerCall (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Network.Train.Prop.OpenCLTrainingProfile __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Train.Prop.OpenCLTrainingProfile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.KernelWorkPerCall;
		}
#pragma warning restore 0169

		static IntPtr id_getKernelWorkPerCall;
		public virtual unsafe int KernelWorkPerCall {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.train.prop']/class[@name='OpenCLTrainingProfile']/method[@name='getKernelWorkPerCall' and count(parameter)=0]"
			[Register ("getKernelWorkPerCall", "()I", "GetGetKernelWorkPerCallHandler")]
			get {
				if (id_getKernelWorkPerCall == IntPtr.Zero)
					id_getKernelWorkPerCall = JNIEnv.GetMethodID (class_ref, "getKernelWorkPerCall", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getKernelWorkPerCall);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getKernelWorkPerCall", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getLocalRatio;
#pragma warning disable 0169
		static Delegate GetGetLocalRatioHandler ()
		{
			if (cb_getLocalRatio == null)
				cb_getLocalRatio = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetLocalRatio);
			return cb_getLocalRatio;
		}

		static double n_GetLocalRatio (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Network.Train.Prop.OpenCLTrainingProfile __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Train.Prop.OpenCLTrainingProfile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LocalRatio;
		}
#pragma warning restore 0169

		static IntPtr id_getLocalRatio;
		public virtual unsafe double LocalRatio {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.train.prop']/class[@name='OpenCLTrainingProfile']/method[@name='getLocalRatio' and count(parameter)=0]"
			[Register ("getLocalRatio", "()D", "GetGetLocalRatioHandler")]
			get {
				if (id_getLocalRatio == IntPtr.Zero)
					id_getLocalRatio = JNIEnv.GetMethodID (class_ref, "getLocalRatio", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getLocalRatio);
					else
						return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLocalRatio", "()D"));
				} finally {
				}
			}
		}

		static Delegate cb_getSegmentationRatio;
#pragma warning disable 0169
		static Delegate GetGetSegmentationRatioHandler ()
		{
			if (cb_getSegmentationRatio == null)
				cb_getSegmentationRatio = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetSegmentationRatio);
			return cb_getSegmentationRatio;
		}

		static double n_GetSegmentationRatio (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Network.Train.Prop.OpenCLTrainingProfile __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Train.Prop.OpenCLTrainingProfile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SegmentationRatio;
		}
#pragma warning restore 0169

		static IntPtr id_getSegmentationRatio;
		public virtual unsafe double SegmentationRatio {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.train.prop']/class[@name='OpenCLTrainingProfile']/method[@name='getSegmentationRatio' and count(parameter)=0]"
			[Register ("getSegmentationRatio", "()D", "GetGetSegmentationRatioHandler")]
			get {
				if (id_getSegmentationRatio == IntPtr.Zero)
					id_getSegmentationRatio = JNIEnv.GetMethodID (class_ref, "getSegmentationRatio", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getSegmentationRatio);
					else
						return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSegmentationRatio", "()D"));
				} finally {
				}
			}
		}

		static Delegate cb_calculateKernelParams_Lorg_encog_engine_opencl_kernels_EncogKernel_Lorg_encog_engine_data_EngineIndexableSet_;
#pragma warning disable 0169
		static Delegate GetCalculateKernelParams_Lorg_encog_engine_opencl_kernels_EncogKernel_Lorg_encog_engine_data_EngineIndexableSet_Handler ()
		{
			if (cb_calculateKernelParams_Lorg_encog_engine_opencl_kernels_EncogKernel_Lorg_encog_engine_data_EngineIndexableSet_ == null)
				cb_calculateKernelParams_Lorg_encog_engine_opencl_kernels_EncogKernel_Lorg_encog_engine_data_EngineIndexableSet_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_CalculateKernelParams_Lorg_encog_engine_opencl_kernels_EncogKernel_Lorg_encog_engine_data_EngineIndexableSet_);
			return cb_calculateKernelParams_Lorg_encog_engine_opencl_kernels_EncogKernel_Lorg_encog_engine_data_EngineIndexableSet_;
		}

		static void n_CalculateKernelParams_Lorg_encog_engine_opencl_kernels_EncogKernel_Lorg_encog_engine_data_EngineIndexableSet_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Encog.Engine.Network.Train.Prop.OpenCLTrainingProfile __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Train.Prop.OpenCLTrainingProfile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Encog.Engine.Opencl.Kernels.EncogKernel p0 = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Opencl.Kernels.EncogKernel> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Encog.Engine.Data.IEngineIndexableSet p1 = (global::Org.Encog.Engine.Data.IEngineIndexableSet)global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Data.IEngineIndexableSet> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.CalculateKernelParams (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_calculateKernelParams_Lorg_encog_engine_opencl_kernels_EncogKernel_Lorg_encog_engine_data_EngineIndexableSet_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.train.prop']/class[@name='OpenCLTrainingProfile']/method[@name='calculateKernelParams' and count(parameter)=2 and parameter[1][@type='org.encog.engine.opencl.kernels.EncogKernel'] and parameter[2][@type='org.encog.engine.data.EngineIndexableSet']]"
		[Register ("calculateKernelParams", "(Lorg/encog/engine/opencl/kernels/EncogKernel;Lorg/encog/engine/data/EngineIndexableSet;)V", "GetCalculateKernelParams_Lorg_encog_engine_opencl_kernels_EncogKernel_Lorg_encog_engine_data_EngineIndexableSet_Handler")]
		public virtual unsafe void CalculateKernelParams (global::Org.Encog.Engine.Opencl.Kernels.EncogKernel p0, global::Org.Encog.Engine.Data.IEngineIndexableSet p1)
		{
			if (id_calculateKernelParams_Lorg_encog_engine_opencl_kernels_EncogKernel_Lorg_encog_engine_data_EngineIndexableSet_ == IntPtr.Zero)
				id_calculateKernelParams_Lorg_encog_engine_opencl_kernels_EncogKernel_Lorg_encog_engine_data_EngineIndexableSet_ = JNIEnv.GetMethodID (class_ref, "calculateKernelParams", "(Lorg/encog/engine/opencl/kernels/EncogKernel;Lorg/encog/engine/data/EngineIndexableSet;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_calculateKernelParams_Lorg_encog_engine_opencl_kernels_EncogKernel_Lorg_encog_engine_data_EngineIndexableSet_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "calculateKernelParams", "(Lorg/encog/engine/opencl/kernels/EncogKernel;Lorg/encog/engine/data/EngineIndexableSet;)V"), __args);
			} finally {
			}
		}

	}
}
