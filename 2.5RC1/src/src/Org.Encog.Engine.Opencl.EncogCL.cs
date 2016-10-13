using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Encog.Engine.Opencl {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.encog.engine.opencl']/class[@name='EncogCL']"
	[global::Android.Runtime.Register ("org/encog/engine/opencl/EncogCL", DoNotGenerateAcw=true)]
	public partial class EncogCL : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/encog/engine/opencl/EncogCL", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (EncogCL); }
		}

		protected EncogCL (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.encog.engine.opencl']/class[@name='EncogCL']/constructor[@name='EncogCL' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe EncogCL ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (EncogCL)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
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
			global::Org.Encog.Engine.Opencl.EncogCL __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Opencl.EncogCL> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Org.Encog.Engine.Opencl.EncogCLDevice>.ToLocalJniHandle (__this.Devices);
		}
#pragma warning restore 0169

		static IntPtr id_getDevices;
		public virtual unsafe global::System.Collections.Generic.IList<global::Org.Encog.Engine.Opencl.EncogCLDevice> Devices {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.opencl']/class[@name='EncogCL']/method[@name='getDevices' and count(parameter)=0]"
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

		static Delegate cb_getEnabledDevices;
#pragma warning disable 0169
		static Delegate GetGetEnabledDevicesHandler ()
		{
			if (cb_getEnabledDevices == null)
				cb_getEnabledDevices = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEnabledDevices);
			return cb_getEnabledDevices;
		}

		static IntPtr n_GetEnabledDevices (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Opencl.EncogCL __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Opencl.EncogCL> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Org.Encog.Engine.Opencl.EncogCLDevice>.ToLocalJniHandle (__this.EnabledDevices);
		}
#pragma warning restore 0169

		static IntPtr id_getEnabledDevices;
		public virtual unsafe global::System.Collections.Generic.IList<global::Org.Encog.Engine.Opencl.EncogCLDevice> EnabledDevices {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.opencl']/class[@name='EncogCL']/method[@name='getEnabledDevices' and count(parameter)=0]"
			[Register ("getEnabledDevices", "()Ljava/util/List;", "GetGetEnabledDevicesHandler")]
			get {
				if (id_getEnabledDevices == IntPtr.Zero)
					id_getEnabledDevices = JNIEnv.GetMethodID (class_ref, "getEnabledDevices", "()Ljava/util/List;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Org.Encog.Engine.Opencl.EncogCLDevice>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEnabledDevices), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Org.Encog.Engine.Opencl.EncogCLDevice>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEnabledDevices", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPlatforms;
#pragma warning disable 0169
		static Delegate GetGetPlatformsHandler ()
		{
			if (cb_getPlatforms == null)
				cb_getPlatforms = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPlatforms);
			return cb_getPlatforms;
		}

		static IntPtr n_GetPlatforms (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Opencl.EncogCL __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Opencl.EncogCL> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Org.Encog.Engine.Opencl.EncogCLPlatform>.ToLocalJniHandle (__this.Platforms);
		}
#pragma warning restore 0169

		static IntPtr id_getPlatforms;
		public virtual unsafe global::System.Collections.Generic.IList<global::Org.Encog.Engine.Opencl.EncogCLPlatform> Platforms {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.opencl']/class[@name='EncogCL']/method[@name='getPlatforms' and count(parameter)=0]"
			[Register ("getPlatforms", "()Ljava/util/List;", "GetGetPlatformsHandler")]
			get {
				if (id_getPlatforms == IntPtr.Zero)
					id_getPlatforms = JNIEnv.GetMethodID (class_ref, "getPlatforms", "()Ljava/util/List;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Org.Encog.Engine.Opencl.EncogCLPlatform>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPlatforms), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Org.Encog.Engine.Opencl.EncogCLPlatform>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPlatforms", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_areCPUsPresent;
#pragma warning disable 0169
		static Delegate GetAreCPUsPresentHandler ()
		{
			if (cb_areCPUsPresent == null)
				cb_areCPUsPresent = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_AreCPUsPresent);
			return cb_areCPUsPresent;
		}

		static bool n_AreCPUsPresent (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Opencl.EncogCL __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Opencl.EncogCL> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AreCPUsPresent ();
		}
#pragma warning restore 0169

		static IntPtr id_areCPUsPresent;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.opencl']/class[@name='EncogCL']/method[@name='areCPUsPresent' and count(parameter)=0]"
		[Register ("areCPUsPresent", "()Z", "GetAreCPUsPresentHandler")]
		public virtual unsafe bool AreCPUsPresent ()
		{
			if (id_areCPUsPresent == IntPtr.Zero)
				id_areCPUsPresent = JNIEnv.GetMethodID (class_ref, "areCPUsPresent", "()Z");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_areCPUsPresent);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "areCPUsPresent", "()Z"));
			} finally {
			}
		}

		static Delegate cb_chooseDevice;
#pragma warning disable 0169
		static Delegate GetChooseDeviceHandler ()
		{
			if (cb_chooseDevice == null)
				cb_chooseDevice = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ChooseDevice);
			return cb_chooseDevice;
		}

		static IntPtr n_ChooseDevice (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Opencl.EncogCL __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Opencl.EncogCL> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ChooseDevice ());
		}
#pragma warning restore 0169

		static IntPtr id_chooseDevice;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.opencl']/class[@name='EncogCL']/method[@name='chooseDevice' and count(parameter)=0]"
		[Register ("chooseDevice", "()Lorg/encog/engine/opencl/EncogCLDevice;", "GetChooseDeviceHandler")]
		public virtual unsafe global::Org.Encog.Engine.Opencl.EncogCLDevice ChooseDevice ()
		{
			if (id_chooseDevice == IntPtr.Zero)
				id_chooseDevice = JNIEnv.GetMethodID (class_ref, "chooseDevice", "()Lorg/encog/engine/opencl/EncogCLDevice;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Opencl.EncogCLDevice> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_chooseDevice), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Opencl.EncogCLDevice> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "chooseDevice", "()Lorg/encog/engine/opencl/EncogCLDevice;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_chooseDevice_Z;
#pragma warning disable 0169
		static Delegate GetChooseDevice_ZHandler ()
		{
			if (cb_chooseDevice_Z == null)
				cb_chooseDevice_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_ChooseDevice_Z);
			return cb_chooseDevice_Z;
		}

		static IntPtr n_ChooseDevice_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Org.Encog.Engine.Opencl.EncogCL __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Opencl.EncogCL> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ChooseDevice (p0));
		}
#pragma warning restore 0169

		static IntPtr id_chooseDevice_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.opencl']/class[@name='EncogCL']/method[@name='chooseDevice' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("chooseDevice", "(Z)Lorg/encog/engine/opencl/EncogCLDevice;", "GetChooseDevice_ZHandler")]
		public virtual unsafe global::Org.Encog.Engine.Opencl.EncogCLDevice ChooseDevice (bool p0)
		{
			if (id_chooseDevice_Z == IntPtr.Zero)
				id_chooseDevice_Z = JNIEnv.GetMethodID (class_ref, "chooseDevice", "(Z)Lorg/encog/engine/opencl/EncogCLDevice;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Opencl.EncogCLDevice> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_chooseDevice_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Opencl.EncogCLDevice> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "chooseDevice", "(Z)Lorg/encog/engine/opencl/EncogCLDevice;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_disableAllCPUs;
#pragma warning disable 0169
		static Delegate GetDisableAllCPUsHandler ()
		{
			if (cb_disableAllCPUs == null)
				cb_disableAllCPUs = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DisableAllCPUs);
			return cb_disableAllCPUs;
		}

		static void n_DisableAllCPUs (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Opencl.EncogCL __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Opencl.EncogCL> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DisableAllCPUs ();
		}
#pragma warning restore 0169

		static IntPtr id_disableAllCPUs;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.opencl']/class[@name='EncogCL']/method[@name='disableAllCPUs' and count(parameter)=0]"
		[Register ("disableAllCPUs", "()V", "GetDisableAllCPUsHandler")]
		public virtual unsafe void DisableAllCPUs ()
		{
			if (id_disableAllCPUs == IntPtr.Zero)
				id_disableAllCPUs = JNIEnv.GetMethodID (class_ref, "disableAllCPUs", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_disableAllCPUs);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "disableAllCPUs", "()V"));
			} finally {
			}
		}

		static Delegate cb_enableAllCPUs;
#pragma warning disable 0169
		static Delegate GetEnableAllCPUsHandler ()
		{
			if (cb_enableAllCPUs == null)
				cb_enableAllCPUs = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_EnableAllCPUs);
			return cb_enableAllCPUs;
		}

		static void n_EnableAllCPUs (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Opencl.EncogCL __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Opencl.EncogCL> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EnableAllCPUs ();
		}
#pragma warning restore 0169

		static IntPtr id_enableAllCPUs;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.opencl']/class[@name='EncogCL']/method[@name='enableAllCPUs' and count(parameter)=0]"
		[Register ("enableAllCPUs", "()V", "GetEnableAllCPUsHandler")]
		public virtual unsafe void EnableAllCPUs ()
		{
			if (id_enableAllCPUs == IntPtr.Zero)
				id_enableAllCPUs = JNIEnv.GetMethodID (class_ref, "enableAllCPUs", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_enableAllCPUs);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "enableAllCPUs", "()V"));
			} finally {
			}
		}

	}
}
