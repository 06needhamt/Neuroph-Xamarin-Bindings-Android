using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.util']/class[@name='Neuroph']"
	[global::Android.Runtime.Register ("org/neuroph/util/Neuroph", DoNotGenerateAcw=true)]
	public partial class Neuroph : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/util/Neuroph", ref java_class_handle);
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.util']/class[@name='Neuroph']/constructor[@name='Neuroph' and count(parameter)=0]"
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

		static Delegate cb_getInputFunctions;
#pragma warning disable 0169
		static Delegate GetGetInputFunctionsHandler ()
		{
			if (cb_getInputFunctions == null)
				cb_getInputFunctions = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetInputFunctions);
			return cb_getInputFunctions;
		}

		static IntPtr n_GetInputFunctions (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Util.Neuroph __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.Neuroph> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.InputFunctions);
		}
#pragma warning restore 0169

		static IntPtr id_getInputFunctions;
		public virtual unsafe global::System.Collections.Generic.IList<string> InputFunctions {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util']/class[@name='Neuroph']/method[@name='getInputFunctions' and count(parameter)=0]"
			[Register ("getInputFunctions", "()Ljava/util/ArrayList;", "GetGetInputFunctionsHandler")]
			get {
				if (id_getInputFunctions == IntPtr.Zero)
					id_getInputFunctions = JNIEnv.GetMethodID (class_ref, "getInputFunctions", "()Ljava/util/ArrayList;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getInputFunctions), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getInputFunctions", "()Ljava/util/ArrayList;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getInstance;
		public static unsafe global::Org.Neuroph.Util.Neuroph Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util']/class[@name='Neuroph']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lorg/neuroph/util/Neuroph;", "GetGetInstanceHandler")]
			get {
				if (id_getInstance == IntPtr.Zero)
					id_getInstance = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "()Lorg/neuroph/util/Neuroph;");
				try {
					return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.Neuroph> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getLayers;
#pragma warning disable 0169
		static Delegate GetGetLayersHandler ()
		{
			if (cb_getLayers == null)
				cb_getLayers = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLayers);
			return cb_getLayers;
		}

		static IntPtr n_GetLayers (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Util.Neuroph __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.Neuroph> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.Layers);
		}
#pragma warning restore 0169

		static IntPtr id_getLayers;
		public virtual unsafe global::System.Collections.Generic.IList<string> Layers {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util']/class[@name='Neuroph']/method[@name='getLayers' and count(parameter)=0]"
			[Register ("getLayers", "()Ljava/util/ArrayList;", "GetGetLayersHandler")]
			get {
				if (id_getLayers == IntPtr.Zero)
					id_getLayers = JNIEnv.GetMethodID (class_ref, "getLayers", "()Ljava/util/ArrayList;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getLayers), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLayers", "()Ljava/util/ArrayList;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getLearningRules;
#pragma warning disable 0169
		static Delegate GetGetLearningRulesHandler ()
		{
			if (cb_getLearningRules == null)
				cb_getLearningRules = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLearningRules);
			return cb_getLearningRules;
		}

		static IntPtr n_GetLearningRules (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Util.Neuroph __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.Neuroph> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.LearningRules);
		}
#pragma warning restore 0169

		static IntPtr id_getLearningRules;
		public virtual unsafe global::System.Collections.Generic.IList<string> LearningRules {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util']/class[@name='Neuroph']/method[@name='getLearningRules' and count(parameter)=0]"
			[Register ("getLearningRules", "()Ljava/util/ArrayList;", "GetGetLearningRulesHandler")]
			get {
				if (id_getLearningRules == IntPtr.Zero)
					id_getLearningRules = JNIEnv.GetMethodID (class_ref, "getLearningRules", "()Ljava/util/ArrayList;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getLearningRules), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLearningRules", "()Ljava/util/ArrayList;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getNeurons;
#pragma warning disable 0169
		static Delegate GetGetNeuronsHandler ()
		{
			if (cb_getNeurons == null)
				cb_getNeurons = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNeurons);
			return cb_getNeurons;
		}

		static IntPtr n_GetNeurons (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Util.Neuroph __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.Neuroph> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.Neurons);
		}
#pragma warning restore 0169

		static IntPtr id_getNeurons;
		public virtual unsafe global::System.Collections.Generic.IList<string> Neurons {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util']/class[@name='Neuroph']/method[@name='getNeurons' and count(parameter)=0]"
			[Register ("getNeurons", "()Ljava/util/ArrayList;", "GetGetNeuronsHandler")]
			get {
				if (id_getNeurons == IntPtr.Zero)
					id_getNeurons = JNIEnv.GetMethodID (class_ref, "getNeurons", "()Ljava/util/ArrayList;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getNeurons), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNeurons", "()Ljava/util/ArrayList;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTransferFunctions;
#pragma warning disable 0169
		static Delegate GetGetTransferFunctionsHandler ()
		{
			if (cb_getTransferFunctions == null)
				cb_getTransferFunctions = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTransferFunctions);
			return cb_getTransferFunctions;
		}

		static IntPtr n_GetTransferFunctions (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Util.Neuroph __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.Neuroph> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.TransferFunctions);
		}
#pragma warning restore 0169

		static IntPtr id_getTransferFunctions;
		public virtual unsafe global::System.Collections.Generic.IList<string> TransferFunctions {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util']/class[@name='Neuroph']/method[@name='getTransferFunctions' and count(parameter)=0]"
			[Register ("getTransferFunctions", "()Ljava/util/ArrayList;", "GetGetTransferFunctionsHandler")]
			get {
				if (id_getTransferFunctions == IntPtr.Zero)
					id_getTransferFunctions = JNIEnv.GetMethodID (class_ref, "getTransferFunctions", "()Ljava/util/ArrayList;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getTransferFunctions), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTransferFunctions", "()Ljava/util/ArrayList;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getVersion;
		public static unsafe string Version {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util']/class[@name='Neuroph']/method[@name='getVersion' and count(parameter)=0]"
			[Register ("getVersion", "()Ljava/lang/String;", "GetGetVersionHandler")]
			get {
				if (id_getVersion == IntPtr.Zero)
					id_getVersion = JNIEnv.GetStaticMethodID (class_ref, "getVersion", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getVersion), JniHandleOwnership.TransferLocalRef);
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
			global::Org.Neuroph.Util.Neuroph __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.Neuroph> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetFlattenNetworks (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setFlattenNetworks_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util']/class[@name='Neuroph']/method[@name='setFlattenNetworks' and count(parameter)=1 and parameter[1][@type='boolean']]"
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
			global::Org.Neuroph.Util.Neuroph __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.Neuroph> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShouldFlattenNetworks ();
		}
#pragma warning restore 0169

		static IntPtr id_shouldFlattenNetworks;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util']/class[@name='Neuroph']/method[@name='shouldFlattenNetworks' and count(parameter)=0]"
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
			global::Org.Neuroph.Util.Neuroph __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.Neuroph> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Shutdown ();
		}
#pragma warning restore 0169

		static IntPtr id_shutdown;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util']/class[@name='Neuroph']/method[@name='shutdown' and count(parameter)=0]"
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
