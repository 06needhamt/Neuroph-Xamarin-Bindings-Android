using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Nnet {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.nnet']/class[@name='ModularNetwork']"
	[global::Android.Runtime.Register ("org/neuroph/nnet/ModularNetwork", DoNotGenerateAcw=true)]
	public partial class ModularNetwork : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/nnet/ModularNetwork", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ModularNetwork); }
		}

		protected ModularNetwork (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.nnet']/class[@name='ModularNetwork']/constructor[@name='ModularNetwork' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ModularNetwork ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ModularNetwork)) {
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

		static Delegate cb_addNetwork_Lorg_neuroph_core_NeuralNetwork_;
#pragma warning disable 0169
		static Delegate GetAddNetwork_Lorg_neuroph_core_NeuralNetwork_Handler ()
		{
			if (cb_addNetwork_Lorg_neuroph_core_NeuralNetwork_ == null)
				cb_addNetwork_Lorg_neuroph_core_NeuralNetwork_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddNetwork_Lorg_neuroph_core_NeuralNetwork_);
			return cb_addNetwork_Lorg_neuroph_core_NeuralNetwork_;
		}

		static void n_AddNetwork_Lorg_neuroph_core_NeuralNetwork_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Nnet.ModularNetwork __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.ModularNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Core.NeuralNetwork p0 = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.NeuralNetwork> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddNetwork (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addNetwork_Lorg_neuroph_core_NeuralNetwork_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet']/class[@name='ModularNetwork']/method[@name='addNetwork' and count(parameter)=1 and parameter[1][@type='org.neuroph.core.NeuralNetwork']]"
		[Register ("addNetwork", "(Lorg/neuroph/core/NeuralNetwork;)V", "GetAddNetwork_Lorg_neuroph_core_NeuralNetwork_Handler")]
		public virtual unsafe void AddNetwork (global::Org.Neuroph.Core.NeuralNetwork p0)
		{
			if (id_addNetwork_Lorg_neuroph_core_NeuralNetwork_ == IntPtr.Zero)
				id_addNetwork_Lorg_neuroph_core_NeuralNetwork_ = JNIEnv.GetMethodID (class_ref, "addNetwork", "(Lorg/neuroph/core/NeuralNetwork;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addNetwork_Lorg_neuroph_core_NeuralNetwork_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addNetwork", "(Lorg/neuroph/core/NeuralNetwork;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_getNetwork_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetNetwork_Ljava_lang_String_Handler ()
		{
			if (cb_getNetwork_Ljava_lang_String_ == null)
				cb_getNetwork_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetNetwork_Ljava_lang_String_);
			return cb_getNetwork_Ljava_lang_String_;
		}

		static IntPtr n_GetNetwork_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Nnet.ModularNetwork __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.ModularNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetNetwork (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getNetwork_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet']/class[@name='ModularNetwork']/method[@name='getNetwork' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getNetwork", "(Ljava/lang/String;)Lorg/neuroph/core/NeuralNetwork;", "GetGetNetwork_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Neuroph.Core.NeuralNetwork GetNetwork (string p0)
		{
			if (id_getNetwork_Ljava_lang_String_ == IntPtr.Zero)
				id_getNetwork_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getNetwork", "(Ljava/lang/String;)Lorg/neuroph/core/NeuralNetwork;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Org.Neuroph.Core.NeuralNetwork __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.NeuralNetwork> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNetwork_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.NeuralNetwork> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNetwork", "(Ljava/lang/String;)Lorg/neuroph/core/NeuralNetwork;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_removeNetwork_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemoveNetwork_Ljava_lang_String_Handler ()
		{
			if (cb_removeNetwork_Ljava_lang_String_ == null)
				cb_removeNetwork_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveNetwork_Ljava_lang_String_);
			return cb_removeNetwork_Ljava_lang_String_;
		}

		static void n_RemoveNetwork_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Nnet.ModularNetwork __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.ModularNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveNetwork (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeNetwork_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet']/class[@name='ModularNetwork']/method[@name='removeNetwork' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("removeNetwork", "(Ljava/lang/String;)V", "GetRemoveNetwork_Ljava_lang_String_Handler")]
		public virtual unsafe void RemoveNetwork (string p0)
		{
			if (id_removeNetwork_Ljava_lang_String_ == IntPtr.Zero)
				id_removeNetwork_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "removeNetwork", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeNetwork_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeNetwork", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
