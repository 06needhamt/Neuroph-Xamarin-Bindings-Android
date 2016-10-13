using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Util.Plugins {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.util.plugins']/class[@name='PluginBase']"
	[global::Android.Runtime.Register ("org/neuroph/util/plugins/PluginBase", DoNotGenerateAcw=true)]
	public partial class PluginBase : global::Java.Lang.Object, global::Java.IO.ISerializable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/util/plugins/PluginBase", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PluginBase); }
		}

		protected PluginBase (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.util.plugins']/class[@name='PluginBase']/constructor[@name='PluginBase' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe PluginBase (string p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (PluginBase)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getName;
#pragma warning disable 0169
		static Delegate GetGetNameHandler ()
		{
			if (cb_getName == null)
				cb_getName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetName);
			return cb_getName;
		}

		static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Util.Plugins.PluginBase __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.Plugins.PluginBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		static IntPtr id_getName;
		public virtual unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util.plugins']/class[@name='PluginBase']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
			get {
				if (id_getName == IntPtr.Zero)
					id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getParentNetwork;
#pragma warning disable 0169
		static Delegate GetGetParentNetworkHandler ()
		{
			if (cb_getParentNetwork == null)
				cb_getParentNetwork = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetParentNetwork);
			return cb_getParentNetwork;
		}

		static IntPtr n_GetParentNetwork (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Util.Plugins.PluginBase __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.Plugins.PluginBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ParentNetwork);
		}
#pragma warning restore 0169

		static Delegate cb_setParentNetwork_Lorg_neuroph_core_NeuralNetwork_;
#pragma warning disable 0169
		static Delegate GetSetParentNetwork_Lorg_neuroph_core_NeuralNetwork_Handler ()
		{
			if (cb_setParentNetwork_Lorg_neuroph_core_NeuralNetwork_ == null)
				cb_setParentNetwork_Lorg_neuroph_core_NeuralNetwork_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetParentNetwork_Lorg_neuroph_core_NeuralNetwork_);
			return cb_setParentNetwork_Lorg_neuroph_core_NeuralNetwork_;
		}

		static void n_SetParentNetwork_Lorg_neuroph_core_NeuralNetwork_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Util.Plugins.PluginBase __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.Plugins.PluginBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Core.NeuralNetwork p0 = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.NeuralNetwork> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ParentNetwork = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getParentNetwork;
		static IntPtr id_setParentNetwork_Lorg_neuroph_core_NeuralNetwork_;
		public virtual unsafe global::Org.Neuroph.Core.NeuralNetwork ParentNetwork {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util.plugins']/class[@name='PluginBase']/method[@name='getParentNetwork' and count(parameter)=0]"
			[Register ("getParentNetwork", "()Lorg/neuroph/core/NeuralNetwork;", "GetGetParentNetworkHandler")]
			get {
				if (id_getParentNetwork == IntPtr.Zero)
					id_getParentNetwork = JNIEnv.GetMethodID (class_ref, "getParentNetwork", "()Lorg/neuroph/core/NeuralNetwork;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.NeuralNetwork> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getParentNetwork), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.NeuralNetwork> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getParentNetwork", "()Lorg/neuroph/core/NeuralNetwork;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util.plugins']/class[@name='PluginBase']/method[@name='setParentNetwork' and count(parameter)=1 and parameter[1][@type='org.neuroph.core.NeuralNetwork']]"
			[Register ("setParentNetwork", "(Lorg/neuroph/core/NeuralNetwork;)V", "GetSetParentNetwork_Lorg_neuroph_core_NeuralNetwork_Handler")]
			set {
				if (id_setParentNetwork_Lorg_neuroph_core_NeuralNetwork_ == IntPtr.Zero)
					id_setParentNetwork_Lorg_neuroph_core_NeuralNetwork_ = JNIEnv.GetMethodID (class_ref, "setParentNetwork", "(Lorg/neuroph/core/NeuralNetwork;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setParentNetwork_Lorg_neuroph_core_NeuralNetwork_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setParentNetwork", "(Lorg/neuroph/core/NeuralNetwork;)V"), __args);
				} finally {
				}
			}
		}

	}
}
