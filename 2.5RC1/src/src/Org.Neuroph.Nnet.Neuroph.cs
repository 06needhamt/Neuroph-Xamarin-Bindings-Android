using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Nnet {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.nnet']/class[@name='Neuroph']"
	[global::Android.Runtime.Register ("org/neuroph/nnet/Neuroph", DoNotGenerateAcw=true)]
	public partial class Neuroph : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/nnet/Neuroph", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Neuroph); }
		}

		protected Neuroph (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.nnet']/class[@name='Neuroph']/constructor[@name='Neuroph' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Neuroph ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Neuroph)) {
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

		static IntPtr id_getInstance;
		public static unsafe global::Org.Neuroph.Nnet.Neuroph Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet']/class[@name='Neuroph']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lorg/neuroph/nnet/Neuroph;", "GetGetInstanceHandler")]
			get {
				if (id_getInstance == IntPtr.Zero)
					id_getInstance = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "()Lorg/neuroph/nnet/Neuroph;");
				try {
					return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Neuroph> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_setFlattenNetworks_Z;
#pragma warning disable 0169
		static Delegate GetSetFlattenNetworks_ZHandler ()
		{
			if (cb_setFlattenNetworks_Z == null)
				cb_setFlattenNetworks_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetFlattenNetworks_Z);
			return cb_setFlattenNetworks_Z;
		}

		static void n_SetFlattenNetworks_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Org.Neuroph.Nnet.Neuroph __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Neuroph> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetFlattenNetworks (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setFlattenNetworks_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet']/class[@name='Neuroph']/method[@name='setFlattenNetworks' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setFlattenNetworks", "(Z)V", "GetSetFlattenNetworks_ZHandler")]
		public virtual unsafe void SetFlattenNetworks (bool p0)
		{
			if (id_setFlattenNetworks_Z == IntPtr.Zero)
				id_setFlattenNetworks_Z = JNIEnv.GetMethodID (class_ref, "setFlattenNetworks", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setFlattenNetworks_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFlattenNetworks", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_shouldFlattenNetworks;
#pragma warning disable 0169
		static Delegate GetShouldFlattenNetworksHandler ()
		{
			if (cb_shouldFlattenNetworks == null)
				cb_shouldFlattenNetworks = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_ShouldFlattenNetworks);
			return cb_shouldFlattenNetworks;
		}

		static bool n_ShouldFlattenNetworks (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Nnet.Neuroph __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Neuroph> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShouldFlattenNetworks ();
		}
#pragma warning restore 0169

		static IntPtr id_shouldFlattenNetworks;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet']/class[@name='Neuroph']/method[@name='shouldFlattenNetworks' and count(parameter)=0]"
		[Register ("shouldFlattenNetworks", "()Z", "GetShouldFlattenNetworksHandler")]
		public virtual unsafe bool ShouldFlattenNetworks ()
		{
			if (id_shouldFlattenNetworks == IntPtr.Zero)
				id_shouldFlattenNetworks = JNIEnv.GetMethodID (class_ref, "shouldFlattenNetworks", "()Z");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_shouldFlattenNetworks);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "shouldFlattenNetworks", "()Z"));
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
			global::Org.Neuroph.Nnet.Neuroph __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Neuroph> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Shutdown ();
		}
#pragma warning restore 0169

		static IntPtr id_shutdown;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet']/class[@name='Neuroph']/method[@name='shutdown' and count(parameter)=0]"
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
