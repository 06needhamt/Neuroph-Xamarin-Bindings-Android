using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Encog.Engine {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.encog.engine']/class[@name='EncogEngine']"
	[global::Android.Runtime.Register ("org/encog/engine/EncogEngine", DoNotGenerateAcw=true)]
	public partial class EncogEngine : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.encog.engine']/class[@name='EncogEngine']/field[@name='DEFAULT_ZERO_TOLERANCE']"
		[Register ("DEFAULT_ZERO_TOLERANCE")]
		public const double DefaultZeroTolerance = (double) 0.000001000000000;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/encog/engine/EncogEngine", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (EncogEngine); }
		}

		protected EncogEngine (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.encog.engine']/class[@name='EncogEngine']/constructor[@name='EncogEngine' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe EncogEngine ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (EncogEngine)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static Delegate cb_getCL;
#pragma warning disable 0169
		static Delegate GetGetCLHandler ()
		{
			if (cb_getCL == null)
				cb_getCL = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCL);
			return cb_getCL;
		}

		static IntPtr n_GetCL (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.EncogEngine __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.EncogEngine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CL);
		}
#pragma warning restore 0169

		static IntPtr id_getCL;
		public virtual unsafe global::Org.Encog.Engine.Opencl.EncogCL CL {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine']/class[@name='EncogEngine']/method[@name='getCL' and count(parameter)=0]"
			[Register ("getCL", "()Lorg/encog/engine/opencl/EncogCL;", "GetGetCLHandler")]
			get {
				if (id_getCL == IntPtr.Zero)
					id_getCL = JNIEnv.GetMethodID (class_ref, "getCL", "()Lorg/encog/engine/opencl/EncogCL;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Opencl.EncogCL> (JNIEnv.CallObjectMethod  (Handle, id_getCL), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Opencl.EncogCL> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCL", "()Lorg/encog/engine/opencl/EncogCL;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getInstance;
		public static unsafe global::Org.Encog.Engine.EncogEngine Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine']/class[@name='EncogEngine']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lorg/encog/engine/EncogEngine;", "GetGetInstanceHandler")]
			get {
				if (id_getInstance == IntPtr.Zero)
					id_getInstance = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "()Lorg/encog/engine/EncogEngine;");
				try {
					return global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.EncogEngine> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_initCL;
#pragma warning disable 0169
		static Delegate GetInitCLHandler ()
		{
			if (cb_initCL == null)
				cb_initCL = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_InitCL);
			return cb_initCL;
		}

		static void n_InitCL (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.EncogEngine __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.EncogEngine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.InitCL ();
		}
#pragma warning restore 0169

		static IntPtr id_initCL;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine']/class[@name='EncogEngine']/method[@name='initCL' and count(parameter)=0]"
		[Register ("initCL", "()V", "GetInitCLHandler")]
		public virtual unsafe void InitCL ()
		{
			if (id_initCL == IntPtr.Zero)
				id_initCL = JNIEnv.GetMethodID (class_ref, "initCL", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_initCL);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "initCL", "()V"));
			} finally {
			}
		}

		static Delegate cb_shutdown;
#pragma warning disable 0169
		static Delegate GetShutdownHandler ()
		{
			if (cb_shutdown == null)
				cb_shutdown = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Shutdown);
			return cb_shutdown;
		}

		static void n_Shutdown (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.EncogEngine __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.EncogEngine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Shutdown ();
		}
#pragma warning restore 0169

		static IntPtr id_shutdown;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine']/class[@name='EncogEngine']/method[@name='shutdown' and count(parameter)=0]"
		[Register ("shutdown", "()V", "GetShutdownHandler")]
		public virtual unsafe void Shutdown ()
		{
			if (id_shutdown == IntPtr.Zero)
				id_shutdown = JNIEnv.GetMethodID (class_ref, "shutdown", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_shutdown);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "shutdown", "()V"));
			} finally {
			}
		}

	}
}
