using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Encog.Engine.Opencl.Kernels {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.encog.engine.opencl.kernels']/class[@name='EncogKernel']"
	[global::Android.Runtime.Register ("org/encog/engine/opencl/kernels/EncogKernel", DoNotGenerateAcw=true)]
	public partial class EncogKernel : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/encog/engine/opencl/kernels/EncogKernel", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (EncogKernel); }
		}

		protected EncogKernel (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_encog_engine_opencl_EncogCLDevice_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.encog.engine.opencl.kernels']/class[@name='EncogKernel']/constructor[@name='EncogKernel' and count(parameter)=3 and parameter[1][@type='org.encog.engine.opencl.EncogCLDevice'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "(Lorg/encog/engine/opencl/EncogCLDevice;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe EncogKernel (global::Org.Encog.Engine.Opencl.EncogCLDevice p0, string p1, string p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				if (GetType () != typeof (EncogKernel)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/encog/engine/opencl/EncogCLDevice;Ljava/lang/String;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/encog/engine/opencl/EncogCLDevice;Ljava/lang/String;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Lorg_encog_engine_opencl_EncogCLDevice_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Lorg_encog_engine_opencl_EncogCLDevice_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/encog/engine/opencl/EncogCLDevice;Ljava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_encog_engine_opencl_EncogCLDevice_Ljava_lang_String_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_encog_engine_opencl_EncogCLDevice_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_getCLSource;
#pragma warning disable 0169
		static Delegate GetGetCLSourceHandler ()
		{
			if (cb_getCLSource == null)
				cb_getCLSource = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCLSource);
			return cb_getCLSource;
		}

		static IntPtr n_GetCLSource (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Opencl.Kernels.EncogKernel __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Opencl.Kernels.EncogKernel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CLSource);
		}
#pragma warning restore 0169

		static Delegate cb_setCLSource_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCLSource_Ljava_lang_String_Handler ()
		{
			if (cb_setCLSource_Ljava_lang_String_ == null)
				cb_setCLSource_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCLSource_Ljava_lang_String_);
			return cb_setCLSource_Ljava_lang_String_;
		}

		static void n_SetCLSource_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Encog.Engine.Opencl.Kernels.EncogKernel __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Opencl.Kernels.EncogKernel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CLSource = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCLSource;
		static IntPtr id_setCLSource_Ljava_lang_String_;
		public virtual unsafe string CLSource {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.opencl.kernels']/class[@name='EncogKernel']/method[@name='getCLSource' and count(parameter)=0]"
			[Register ("getCLSource", "()Ljava/lang/String;", "GetGetCLSourceHandler")]
			get {
				if (id_getCLSource == IntPtr.Zero)
					id_getCLSource = JNIEnv.GetMethodID (class_ref, "getCLSource", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCLSource), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCLSource", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.opencl.kernels']/class[@name='EncogKernel']/method[@name='setCLSource' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCLSource", "(Ljava/lang/String;)V", "GetSetCLSource_Ljava_lang_String_Handler")]
			set {
				if (id_setCLSource_Ljava_lang_String_ == IntPtr.Zero)
					id_setCLSource_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCLSource", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCLSource_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCLSource", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getContext;
#pragma warning disable 0169
		static Delegate GetGetContextHandler ()
		{
			if (cb_getContext == null)
				cb_getContext = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContext);
			return cb_getContext;
		}

		static IntPtr n_GetContext (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Opencl.Kernels.EncogKernel __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Opencl.Kernels.EncogKernel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Context);
		}
#pragma warning restore 0169

		static IntPtr id_getContext;
		public virtual unsafe global::Org.Jocl.Cl_context Context {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.opencl.kernels']/class[@name='EncogKernel']/method[@name='getContext' and count(parameter)=0]"
			[Register ("getContext", "()Lorg/jocl/cl_context;", "GetGetContextHandler")]
			get {
				if (id_getContext == IntPtr.Zero)
					id_getContext = JNIEnv.GetMethodID (class_ref, "getContext", "()Lorg/jocl/cl_context;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Jocl.Cl_context> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getContext), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Jocl.Cl_context> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getContext", "()Lorg/jocl/cl_context;")), JniHandleOwnership.TransferLocalRef);
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
			global::Org.Encog.Engine.Opencl.Kernels.EncogKernel __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Opencl.Kernels.EncogKernel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Device);
		}
#pragma warning restore 0169

		static IntPtr id_getDevice;
		public virtual unsafe global::Org.Encog.Engine.Opencl.EncogCLDevice Device {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.opencl.kernels']/class[@name='EncogKernel']/method[@name='getDevice' and count(parameter)=0]"
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
		}

		static Delegate cb_getGlobalWork;
#pragma warning disable 0169
		static Delegate GetGetGlobalWorkHandler ()
		{
			if (cb_getGlobalWork == null)
				cb_getGlobalWork = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetGlobalWork);
			return cb_getGlobalWork;
		}

		static int n_GetGlobalWork (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Opencl.Kernels.EncogKernel __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Opencl.Kernels.EncogKernel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GlobalWork;
		}
#pragma warning restore 0169

		static Delegate cb_setGlobalWork_I;
#pragma warning disable 0169
		static Delegate GetSetGlobalWork_IHandler ()
		{
			if (cb_setGlobalWork_I == null)
				cb_setGlobalWork_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetGlobalWork_I);
			return cb_setGlobalWork_I;
		}

		static void n_SetGlobalWork_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Encog.Engine.Opencl.Kernels.EncogKernel __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Opencl.Kernels.EncogKernel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.GlobalWork = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getGlobalWork;
		static IntPtr id_setGlobalWork_I;
		public virtual unsafe int GlobalWork {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.opencl.kernels']/class[@name='EncogKernel']/method[@name='getGlobalWork' and count(parameter)=0]"
			[Register ("getGlobalWork", "()I", "GetGetGlobalWorkHandler")]
			get {
				if (id_getGlobalWork == IntPtr.Zero)
					id_getGlobalWork = JNIEnv.GetMethodID (class_ref, "getGlobalWork", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getGlobalWork);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getGlobalWork", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.opencl.kernels']/class[@name='EncogKernel']/method[@name='setGlobalWork' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setGlobalWork", "(I)V", "GetSetGlobalWork_IHandler")]
			set {
				if (id_setGlobalWork_I == IntPtr.Zero)
					id_setGlobalWork_I = JNIEnv.GetMethodID (class_ref, "setGlobalWork", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setGlobalWork_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setGlobalWork", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getKernel;
#pragma warning disable 0169
		static Delegate GetGetKernelHandler ()
		{
			if (cb_getKernel == null)
				cb_getKernel = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetKernel);
			return cb_getKernel;
		}

		static IntPtr n_GetKernel (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Opencl.Kernels.EncogKernel __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Opencl.Kernels.EncogKernel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Kernel);
		}
#pragma warning restore 0169

		static IntPtr id_getKernel;
		public virtual unsafe global::Org.Jocl.Cl_kernel Kernel {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.opencl.kernels']/class[@name='EncogKernel']/method[@name='getKernel' and count(parameter)=0]"
			[Register ("getKernel", "()Lorg/jocl/cl_kernel;", "GetGetKernelHandler")]
			get {
				if (id_getKernel == IntPtr.Zero)
					id_getKernel = JNIEnv.GetMethodID (class_ref, "getKernel", "()Lorg/jocl/cl_kernel;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Jocl.Cl_kernel> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getKernel), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Jocl.Cl_kernel> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getKernel", "()Lorg/jocl/cl_kernel;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getLocalWork;
#pragma warning disable 0169
		static Delegate GetGetLocalWorkHandler ()
		{
			if (cb_getLocalWork == null)
				cb_getLocalWork = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetLocalWork);
			return cb_getLocalWork;
		}

		static int n_GetLocalWork (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Opencl.Kernels.EncogKernel __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Opencl.Kernels.EncogKernel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LocalWork;
		}
#pragma warning restore 0169

		static Delegate cb_setLocalWork_I;
#pragma warning disable 0169
		static Delegate GetSetLocalWork_IHandler ()
		{
			if (cb_setLocalWork_I == null)
				cb_setLocalWork_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetLocalWork_I);
			return cb_setLocalWork_I;
		}

		static void n_SetLocalWork_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Encog.Engine.Opencl.Kernels.EncogKernel __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Opencl.Kernels.EncogKernel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.LocalWork = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getLocalWork;
		static IntPtr id_setLocalWork_I;
		public virtual unsafe int LocalWork {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.opencl.kernels']/class[@name='EncogKernel']/method[@name='getLocalWork' and count(parameter)=0]"
			[Register ("getLocalWork", "()I", "GetGetLocalWorkHandler")]
			get {
				if (id_getLocalWork == IntPtr.Zero)
					id_getLocalWork = JNIEnv.GetMethodID (class_ref, "getLocalWork", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getLocalWork);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLocalWork", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.opencl.kernels']/class[@name='EncogKernel']/method[@name='setLocalWork' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setLocalWork", "(I)V", "GetSetLocalWork_IHandler")]
			set {
				if (id_setLocalWork_I == IntPtr.Zero)
					id_setLocalWork_I = JNIEnv.GetMethodID (class_ref, "setLocalWork", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLocalWork_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLocalWork", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMaxWorkGroupSize;
#pragma warning disable 0169
		static Delegate GetGetMaxWorkGroupSizeHandler ()
		{
			if (cb_getMaxWorkGroupSize == null)
				cb_getMaxWorkGroupSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMaxWorkGroupSize);
			return cb_getMaxWorkGroupSize;
		}

		static int n_GetMaxWorkGroupSize (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Opencl.Kernels.EncogKernel __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Opencl.Kernels.EncogKernel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxWorkGroupSize;
		}
#pragma warning restore 0169

		static IntPtr id_getMaxWorkGroupSize;
		public virtual unsafe int MaxWorkGroupSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.opencl.kernels']/class[@name='EncogKernel']/method[@name='getMaxWorkGroupSize' and count(parameter)=0]"
			[Register ("getMaxWorkGroupSize", "()I", "GetGetMaxWorkGroupSizeHandler")]
			get {
				if (id_getMaxWorkGroupSize == IntPtr.Zero)
					id_getMaxWorkGroupSize = JNIEnv.GetMethodID (class_ref, "getMaxWorkGroupSize", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getMaxWorkGroupSize);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMaxWorkGroupSize", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getProgram;
#pragma warning disable 0169
		static Delegate GetGetProgramHandler ()
		{
			if (cb_getProgram == null)
				cb_getProgram = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetProgram);
			return cb_getProgram;
		}

		static IntPtr n_GetProgram (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Opencl.Kernels.EncogKernel __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Opencl.Kernels.EncogKernel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Program);
		}
#pragma warning restore 0169

		static IntPtr id_getProgram;
		public virtual unsafe global::Org.Jocl.Cl_program Program {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.opencl.kernels']/class[@name='EncogKernel']/method[@name='getProgram' and count(parameter)=0]"
			[Register ("getProgram", "()Lorg/jocl/cl_program;", "GetGetProgramHandler")]
			get {
				if (id_getProgram == IntPtr.Zero)
					id_getProgram = JNIEnv.GetMethodID (class_ref, "getProgram", "()Lorg/jocl/cl_program;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Jocl.Cl_program> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getProgram), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Jocl.Cl_program> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getProgram", "()Lorg/jocl/cl_program;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSourceName;
#pragma warning disable 0169
		static Delegate GetGetSourceNameHandler ()
		{
			if (cb_getSourceName == null)
				cb_getSourceName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSourceName);
			return cb_getSourceName;
		}

		static IntPtr n_GetSourceName (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Opencl.Kernels.EncogKernel __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Opencl.Kernels.EncogKernel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SourceName);
		}
#pragma warning restore 0169

		static IntPtr id_getSourceName;
		public virtual unsafe string SourceName {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.opencl.kernels']/class[@name='EncogKernel']/method[@name='getSourceName' and count(parameter)=0]"
			[Register ("getSourceName", "()Ljava/lang/String;", "GetGetSourceNameHandler")]
			get {
				if (id_getSourceName == IntPtr.Zero)
					id_getSourceName = JNIEnv.GetMethodID (class_ref, "getSourceName", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSourceName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSourceName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_compile;
#pragma warning disable 0169
		static Delegate GetCompileHandler ()
		{
			if (cb_compile == null)
				cb_compile = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Compile);
			return cb_compile;
		}

		static void n_Compile (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Opencl.Kernels.EncogKernel __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Opencl.Kernels.EncogKernel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Compile ();
		}
#pragma warning restore 0169

		static IntPtr id_compile;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.opencl.kernels']/class[@name='EncogKernel']/method[@name='compile' and count(parameter)=0]"
		[Register ("compile", "()V", "GetCompileHandler")]
		public virtual unsafe void Compile ()
		{
			if (id_compile == IntPtr.Zero)
				id_compile = JNIEnv.GetMethodID (class_ref, "compile", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_compile);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "compile", "()V"));
			} finally {
			}
		}

		static Delegate cb_compile_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetCompile_Ljava_util_Map_Handler ()
		{
			if (cb_compile_Ljava_util_Map_ == null)
				cb_compile_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Compile_Ljava_util_Map_);
			return cb_compile_Ljava_util_Map_;
		}

		static void n_Compile_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Encog.Engine.Opencl.Kernels.EncogKernel __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Opencl.Kernels.EncogKernel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Compile (p0);
		}
#pragma warning restore 0169

		static IntPtr id_compile_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.opencl.kernels']/class[@name='EncogKernel']/method[@name='compile' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("compile", "(Ljava/util/Map;)V", "GetCompile_Ljava_util_Map_Handler")]
		public virtual unsafe void Compile (global::System.Collections.Generic.IDictionary<string, string> p0)
		{
			if (id_compile_Ljava_util_Map_ == IntPtr.Zero)
				id_compile_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "compile", "(Ljava/util/Map;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_compile_Ljava_util_Map_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "compile", "(Ljava/util/Map;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_createArrayReadOnly_arrayF;
#pragma warning disable 0169
		static Delegate GetCreateArrayReadOnly_arrayFHandler ()
		{
			if (cb_createArrayReadOnly_arrayF == null)
				cb_createArrayReadOnly_arrayF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateArrayReadOnly_arrayF);
			return cb_createArrayReadOnly_arrayF;
		}

		static IntPtr n_CreateArrayReadOnly_arrayF (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Encog.Engine.Opencl.Kernels.EncogKernel __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Opencl.Kernels.EncogKernel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			float[] p0 = (float[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (float));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateArrayReadOnly (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_createArrayReadOnly_arrayF;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.opencl.kernels']/class[@name='EncogKernel']/method[@name='createArrayReadOnly' and count(parameter)=1 and parameter[1][@type='float[]']]"
		[Register ("createArrayReadOnly", "([F)Lorg/jocl/cl_mem;", "GetCreateArrayReadOnly_arrayFHandler")]
		public virtual unsafe global::Org.Jocl.Cl_mem CreateArrayReadOnly (float[] p0)
		{
			if (id_createArrayReadOnly_arrayF == IntPtr.Zero)
				id_createArrayReadOnly_arrayF = JNIEnv.GetMethodID (class_ref, "createArrayReadOnly", "([F)Lorg/jocl/cl_mem;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Org.Jocl.Cl_mem __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Jocl.Cl_mem> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createArrayReadOnly_arrayF, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Jocl.Cl_mem> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createArrayReadOnly", "([F)Lorg/jocl/cl_mem;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_createArrayReadOnly_arrayI;
#pragma warning disable 0169
		static Delegate GetCreateArrayReadOnly_arrayIHandler ()
		{
			if (cb_createArrayReadOnly_arrayI == null)
				cb_createArrayReadOnly_arrayI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateArrayReadOnly_arrayI);
			return cb_createArrayReadOnly_arrayI;
		}

		static IntPtr n_CreateArrayReadOnly_arrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Encog.Engine.Opencl.Kernels.EncogKernel __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Opencl.Kernels.EncogKernel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] p0 = (int[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (int));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateArrayReadOnly (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_createArrayReadOnly_arrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.opencl.kernels']/class[@name='EncogKernel']/method[@name='createArrayReadOnly' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[Register ("createArrayReadOnly", "([I)Lorg/jocl/cl_mem;", "GetCreateArrayReadOnly_arrayIHandler")]
		public virtual unsafe global::Org.Jocl.Cl_mem CreateArrayReadOnly (int[] p0)
		{
			if (id_createArrayReadOnly_arrayI == IntPtr.Zero)
				id_createArrayReadOnly_arrayI = JNIEnv.GetMethodID (class_ref, "createArrayReadOnly", "([I)Lorg/jocl/cl_mem;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Org.Jocl.Cl_mem __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Jocl.Cl_mem> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createArrayReadOnly_arrayI, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Jocl.Cl_mem> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createArrayReadOnly", "([I)Lorg/jocl/cl_mem;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_createFloatArrayWriteOnly_I;
#pragma warning disable 0169
		static Delegate GetCreateFloatArrayWriteOnly_IHandler ()
		{
			if (cb_createFloatArrayWriteOnly_I == null)
				cb_createFloatArrayWriteOnly_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_CreateFloatArrayWriteOnly_I);
			return cb_createFloatArrayWriteOnly_I;
		}

		static IntPtr n_CreateFloatArrayWriteOnly_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Encog.Engine.Opencl.Kernels.EncogKernel __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Opencl.Kernels.EncogKernel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CreateFloatArrayWriteOnly (p0));
		}
#pragma warning restore 0169

		static IntPtr id_createFloatArrayWriteOnly_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.opencl.kernels']/class[@name='EncogKernel']/method[@name='createFloatArrayWriteOnly' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("createFloatArrayWriteOnly", "(I)Lorg/jocl/cl_mem;", "GetCreateFloatArrayWriteOnly_IHandler")]
		public virtual unsafe global::Org.Jocl.Cl_mem CreateFloatArrayWriteOnly (int p0)
		{
			if (id_createFloatArrayWriteOnly_I == IntPtr.Zero)
				id_createFloatArrayWriteOnly_I = JNIEnv.GetMethodID (class_ref, "createFloatArrayWriteOnly", "(I)Lorg/jocl/cl_mem;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Jocl.Cl_mem> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createFloatArrayWriteOnly_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Jocl.Cl_mem> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createFloatArrayWriteOnly", "(I)Lorg/jocl/cl_mem;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getWorkGroupLong_I;
#pragma warning disable 0169
		static Delegate GetGetWorkGroupLong_IHandler ()
		{
			if (cb_getWorkGroupLong_I == null)
				cb_getWorkGroupLong_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, long>) n_GetWorkGroupLong_I);
			return cb_getWorkGroupLong_I;
		}

		static long n_GetWorkGroupLong_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Encog.Engine.Opencl.Kernels.EncogKernel __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Opencl.Kernels.EncogKernel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetWorkGroupLong (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getWorkGroupLong_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.opencl.kernels']/class[@name='EncogKernel']/method[@name='getWorkGroupLong' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getWorkGroupLong", "(I)J", "GetGetWorkGroupLong_IHandler")]
		public virtual unsafe long GetWorkGroupLong (int p0)
		{
			if (id_getWorkGroupLong_I == IntPtr.Zero)
				id_getWorkGroupLong_I = JNIEnv.GetMethodID (class_ref, "getWorkGroupLong", "(I)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getWorkGroupLong_I, __args);
				else
					return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWorkGroupLong", "(I)J"), __args);
			} finally {
			}
		}

		static Delegate cb_prepareKernel;
#pragma warning disable 0169
		static Delegate GetPrepareKernelHandler ()
		{
			if (cb_prepareKernel == null)
				cb_prepareKernel = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_PrepareKernel);
			return cb_prepareKernel;
		}

		static void n_PrepareKernel (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Opencl.Kernels.EncogKernel __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Opencl.Kernels.EncogKernel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PrepareKernel ();
		}
#pragma warning restore 0169

		static IntPtr id_prepareKernel;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.opencl.kernels']/class[@name='EncogKernel']/method[@name='prepareKernel' and count(parameter)=0]"
		[Register ("prepareKernel", "()V", "GetPrepareKernelHandler")]
		public virtual unsafe void PrepareKernel ()
		{
			if (id_prepareKernel == IntPtr.Zero)
				id_prepareKernel = JNIEnv.GetMethodID (class_ref, "prepareKernel", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_prepareKernel);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "prepareKernel", "()V"));
			} finally {
			}
		}

		static Delegate cb_release;
#pragma warning disable 0169
		static Delegate GetReleaseHandler ()
		{
			if (cb_release == null)
				cb_release = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Release);
			return cb_release;
		}

		static void n_Release (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Opencl.Kernels.EncogKernel __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Opencl.Kernels.EncogKernel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Release ();
		}
#pragma warning restore 0169

		static IntPtr id_release;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.opencl.kernels']/class[@name='EncogKernel']/method[@name='release' and count(parameter)=0]"
		[Register ("release", "()V", "GetReleaseHandler")]
		public virtual unsafe void Release ()
		{
			if (id_release == IntPtr.Zero)
				id_release = JNIEnv.GetMethodID (class_ref, "release", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_release);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "release", "()V"));
			} finally {
			}
		}

		static Delegate cb_releaseBuffer_Lorg_jocl_cl_mem_;
#pragma warning disable 0169
		static Delegate GetReleaseBuffer_Lorg_jocl_cl_mem_Handler ()
		{
			if (cb_releaseBuffer_Lorg_jocl_cl_mem_ == null)
				cb_releaseBuffer_Lorg_jocl_cl_mem_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ReleaseBuffer_Lorg_jocl_cl_mem_);
			return cb_releaseBuffer_Lorg_jocl_cl_mem_;
		}

		static void n_ReleaseBuffer_Lorg_jocl_cl_mem_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Encog.Engine.Opencl.Kernels.EncogKernel __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Opencl.Kernels.EncogKernel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jocl.Cl_mem p0 = global::Java.Lang.Object.GetObject<global::Org.Jocl.Cl_mem> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ReleaseBuffer (p0);
		}
#pragma warning restore 0169

		static IntPtr id_releaseBuffer_Lorg_jocl_cl_mem_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.opencl.kernels']/class[@name='EncogKernel']/method[@name='releaseBuffer' and count(parameter)=1 and parameter[1][@type='org.jocl.cl_mem']]"
		[Register ("releaseBuffer", "(Lorg/jocl/cl_mem;)V", "GetReleaseBuffer_Lorg_jocl_cl_mem_Handler")]
		public virtual unsafe void ReleaseBuffer (global::Org.Jocl.Cl_mem p0)
		{
			if (id_releaseBuffer_Lorg_jocl_cl_mem_ == IntPtr.Zero)
				id_releaseBuffer_Lorg_jocl_cl_mem_ = JNIEnv.GetMethodID (class_ref, "releaseBuffer", "(Lorg/jocl/cl_mem;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_releaseBuffer_Lorg_jocl_cl_mem_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "releaseBuffer", "(Lorg/jocl/cl_mem;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setArg_ILorg_jocl_cl_mem_;
#pragma warning disable 0169
		static Delegate GetSetArg_ILorg_jocl_cl_mem_Handler ()
		{
			if (cb_setArg_ILorg_jocl_cl_mem_ == null)
				cb_setArg_ILorg_jocl_cl_mem_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_SetArg_ILorg_jocl_cl_mem_);
			return cb_setArg_ILorg_jocl_cl_mem_;
		}

		static void n_SetArg_ILorg_jocl_cl_mem_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Org.Encog.Engine.Opencl.Kernels.EncogKernel __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Opencl.Kernels.EncogKernel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jocl.Cl_mem p1 = global::Java.Lang.Object.GetObject<global::Org.Jocl.Cl_mem> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetArg (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setArg_ILorg_jocl_cl_mem_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.opencl.kernels']/class[@name='EncogKernel']/method[@name='setArg' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='org.jocl.cl_mem']]"
		[Register ("setArg", "(ILorg/jocl/cl_mem;)V", "GetSetArg_ILorg_jocl_cl_mem_Handler")]
		public virtual unsafe void SetArg (int p0, global::Org.Jocl.Cl_mem p1)
		{
			if (id_setArg_ILorg_jocl_cl_mem_ == IntPtr.Zero)
				id_setArg_ILorg_jocl_cl_mem_ = JNIEnv.GetMethodID (class_ref, "setArg", "(ILorg/jocl/cl_mem;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setArg_ILorg_jocl_cl_mem_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setArg", "(ILorg/jocl/cl_mem;)V"), __args);
			} finally {
			}
		}

	}
}
