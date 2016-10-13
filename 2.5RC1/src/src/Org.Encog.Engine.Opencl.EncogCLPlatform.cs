using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Encog.Engine.Opencl {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.encog.engine.opencl']/class[@name='EncogCLPlatform']"
	[global::Android.Runtime.Register ("org/encog/engine/opencl/EncogCLPlatform", DoNotGenerateAcw=true)]
	public partial class EncogCLPlatform : global::Org.Encog.Engine.Opencl.EncogCLItem {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/encog/engine/opencl/EncogCLPlatform", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (EncogCLPlatform); }
		}

		protected EncogCLPlatform (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_jocl_cl_platform_id_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.encog.engine.opencl']/class[@name='EncogCLPlatform']/constructor[@name='EncogCLPlatform' and count(parameter)=1 and parameter[1][@type='org.jocl.cl_platform_id']]"
		[Register (".ctor", "(Lorg/jocl/cl_platform_id;)V", "")]
		public unsafe EncogCLPlatform (global::Org.Jocl.Cl_platform_id p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (EncogCLPlatform)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/jocl/cl_platform_id;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/jocl/cl_platform_id;)V", __args);
					return;
				}

				if (id_ctor_Lorg_jocl_cl_platform_id_ == IntPtr.Zero)
					id_ctor_Lorg_jocl_cl_platform_id_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/jocl/cl_platform_id;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_jocl_cl_platform_id_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_jocl_cl_platform_id_, __args);
			} finally {
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
			global::Org.Encog.Engine.Opencl.EncogCLPlatform __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Opencl.EncogCLPlatform> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Context);
		}
#pragma warning restore 0169

		static IntPtr id_getContext;
		public virtual unsafe global::Org.Jocl.Cl_context Context {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.opencl']/class[@name='EncogCLPlatform']/method[@name='getContext' and count(parameter)=0]"
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

		static Delegate cb_getDevices;
#pragma warning disable 0169
		static Delegate GetGetDevicesHandler ()
		{
			if (cb_getDevices == null)
				cb_getDevices = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDevices);
			return cb_getDevices;
		}

		static IntPtr n_GetDevices (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Opencl.EncogCLPlatform __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Opencl.EncogCLPlatform> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Org.Encog.Engine.Opencl.EncogCLDevice>.ToLocalJniHandle (__this.Devices);
		}
#pragma warning restore 0169

		static IntPtr id_getDevices;
		public virtual unsafe global::System.Collections.Generic.IList<global::Org.Encog.Engine.Opencl.EncogCLDevice> Devices {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.opencl']/class[@name='EncogCLPlatform']/method[@name='getDevices' and count(parameter)=0]"
			[Register ("getDevices", "()Ljava/util/List;", "GetGetDevicesHandler")]
			get {
				if (id_getDevices == IntPtr.Zero)
					id_getDevices = JNIEnv.GetMethodID (class_ref, "getDevices", "()Ljava/util/List;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Org.Encog.Engine.Opencl.EncogCLDevice>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDevices), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Org.Encog.Engine.Opencl.EncogCLDevice>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDevices", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
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
			global::Org.Encog.Engine.Opencl.EncogCLPlatform __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Opencl.EncogCLPlatform> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Platform);
		}
#pragma warning restore 0169

		static IntPtr id_getPlatform;
		public virtual unsafe global::Org.Jocl.Cl_platform_id Platform {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.opencl']/class[@name='EncogCLPlatform']/method[@name='getPlatform' and count(parameter)=0]"
			[Register ("getPlatform", "()Lorg/jocl/cl_platform_id;", "GetGetPlatformHandler")]
			get {
				if (id_getPlatform == IntPtr.Zero)
					id_getPlatform = JNIEnv.GetMethodID (class_ref, "getPlatform", "()Lorg/jocl/cl_platform_id;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Jocl.Cl_platform_id> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPlatform), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Jocl.Cl_platform_id> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPlatform", "()Lorg/jocl/cl_platform_id;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPlatformString_I;
#pragma warning disable 0169
		static Delegate GetGetPlatformString_IHandler ()
		{
			if (cb_getPlatformString_I == null)
				cb_getPlatformString_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetPlatformString_I);
			return cb_getPlatformString_I;
		}

		static IntPtr n_GetPlatformString_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Encog.Engine.Opencl.EncogCLPlatform __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Opencl.EncogCLPlatform> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GetPlatformString (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getPlatformString_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.opencl']/class[@name='EncogCLPlatform']/method[@name='getPlatformString' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getPlatformString", "(I)Ljava/lang/String;", "GetGetPlatformString_IHandler")]
		public virtual unsafe string GetPlatformString (int p0)
		{
			if (id_getPlatformString_I == IntPtr.Zero)
				id_getPlatformString_I = JNIEnv.GetMethodID (class_ref, "getPlatformString", "(I)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPlatformString_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPlatformString", "(I)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
