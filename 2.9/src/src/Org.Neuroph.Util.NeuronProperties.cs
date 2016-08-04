using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.util']/class[@name='NeuronProperties']"
	[global::Android.Runtime.Register ("org/neuroph/util/NeuronProperties", DoNotGenerateAcw=true)]
	public partial class NeuronProperties : global::Org.Neuroph.Util.Properties {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/util/NeuronProperties", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NeuronProperties); }
		}

		protected NeuronProperties (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.util']/class[@name='NeuronProperties']/constructor[@name='NeuronProperties' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe NeuronProperties ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (NeuronProperties)) {
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

		static IntPtr id_ctor_Ljava_lang_Class_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.util']/class[@name='NeuronProperties']/constructor[@name='NeuronProperties' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;? extends org.neuroph.core.Neuron&gt;']]"
		[Register (".ctor", "(Ljava/lang/Class;)V", "")]
		public unsafe NeuronProperties (global::Java.Lang.Class p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (NeuronProperties)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/Class;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/Class;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_Class_ == IntPtr.Zero)
					id_ctor_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Class;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Class_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_Class_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Ljava_lang_Class_Ljava_lang_Class_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.util']/class[@name='NeuronProperties']/constructor[@name='NeuronProperties' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;? extends org.neuroph.core.Neuron&gt;'] and parameter[2][@type='java.lang.Class&lt;? extends org.neuroph.core.transfer.TransferFunction&gt;']]"
		[Register (".ctor", "(Ljava/lang/Class;Ljava/lang/Class;)V", "")]
		public unsafe NeuronProperties (global::Java.Lang.Class p0, global::Java.Lang.Class p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (NeuronProperties)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/Class;Ljava/lang/Class;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/Class;Ljava/lang/Class;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_Class_Ljava_lang_Class_ == IntPtr.Zero)
					id_ctor_Ljava_lang_Class_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Class;Ljava/lang/Class;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Class_Ljava_lang_Class_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_Class_Ljava_lang_Class_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Ljava_lang_Class_Ljava_lang_Class_Ljava_lang_Class_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.util']/class[@name='NeuronProperties']/constructor[@name='NeuronProperties' and count(parameter)=3 and parameter[1][@type='java.lang.Class&lt;? extends org.neuroph.core.Neuron&gt;'] and parameter[2][@type='java.lang.Class&lt;? extends org.neuroph.core.input.InputFunction&gt;'] and parameter[3][@type='java.lang.Class&lt;? extends org.neuroph.core.transfer.TransferFunction&gt;']]"
		[Register (".ctor", "(Ljava/lang/Class;Ljava/lang/Class;Ljava/lang/Class;)V", "")]
		public unsafe NeuronProperties (global::Java.Lang.Class p0, global::Java.Lang.Class p1, global::Java.Lang.Class p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (NeuronProperties)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/Class;Ljava/lang/Class;Ljava/lang/Class;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/Class;Ljava/lang/Class;Ljava/lang/Class;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_Class_Ljava_lang_Class_Ljava_lang_Class_ == IntPtr.Zero)
					id_ctor_Ljava_lang_Class_Ljava_lang_Class_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Class;Ljava/lang/Class;Ljava/lang/Class;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Class_Ljava_lang_Class_Ljava_lang_Class_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_Class_Ljava_lang_Class_Ljava_lang_Class_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Ljava_lang_Class_Lorg_neuroph_util_TransferFunctionType_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.util']/class[@name='NeuronProperties']/constructor[@name='NeuronProperties' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;? extends org.neuroph.core.Neuron&gt;'] and parameter[2][@type='org.neuroph.util.TransferFunctionType']]"
		[Register (".ctor", "(Ljava/lang/Class;Lorg/neuroph/util/TransferFunctionType;)V", "")]
		public unsafe NeuronProperties (global::Java.Lang.Class p0, global::Org.Neuroph.Util.TransferFunctionType p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (NeuronProperties)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/Class;Lorg/neuroph/util/TransferFunctionType;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/Class;Lorg/neuroph/util/TransferFunctionType;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_Class_Lorg_neuroph_util_TransferFunctionType_ == IntPtr.Zero)
					id_ctor_Ljava_lang_Class_Lorg_neuroph_util_TransferFunctionType_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Class;Lorg/neuroph/util/TransferFunctionType;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Class_Lorg_neuroph_util_TransferFunctionType_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_Class_Lorg_neuroph_util_TransferFunctionType_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Lorg_neuroph_util_TransferFunctionType_Z;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.util']/class[@name='NeuronProperties']/constructor[@name='NeuronProperties' and count(parameter)=2 and parameter[1][@type='org.neuroph.util.TransferFunctionType'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(Lorg/neuroph/util/TransferFunctionType;Z)V", "")]
		public unsafe NeuronProperties (global::Org.Neuroph.Util.TransferFunctionType p0, bool p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (NeuronProperties)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/neuroph/util/TransferFunctionType;Z)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorg/neuroph/util/TransferFunctionType;Z)V", __args);
					return;
				}

				if (id_ctor_Lorg_neuroph_util_TransferFunctionType_Z == IntPtr.Zero)
					id_ctor_Lorg_neuroph_util_TransferFunctionType_Z = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/neuroph/util/TransferFunctionType;Z)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_neuroph_util_TransferFunctionType_Z, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_neuroph_util_TransferFunctionType_Z, __args);
			} finally {
			}
		}

		static Delegate cb_getInputFunction;
#pragma warning disable 0169
		static Delegate GetGetInputFunctionHandler ()
		{
			if (cb_getInputFunction == null)
				cb_getInputFunction = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetInputFunction);
			return cb_getInputFunction;
		}

		static IntPtr n_GetInputFunction (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Util.NeuronProperties __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.NeuronProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InputFunction);
		}
#pragma warning restore 0169

		static IntPtr id_getInputFunction;
		public virtual unsafe global::Java.Lang.Class InputFunction {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util']/class[@name='NeuronProperties']/method[@name='getInputFunction' and count(parameter)=0]"
			[Register ("getInputFunction", "()Ljava/lang/Class;", "GetGetInputFunctionHandler")]
			get {
				if (id_getInputFunction == IntPtr.Zero)
					id_getInputFunction = JNIEnv.GetMethodID (class_ref, "getInputFunction", "()Ljava/lang/Class;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallObjectMethod  (Handle, id_getInputFunction), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getInputFunction", "()Ljava/lang/Class;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getNeuronType;
#pragma warning disable 0169
		static Delegate GetGetNeuronTypeHandler ()
		{
			if (cb_getNeuronType == null)
				cb_getNeuronType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNeuronType);
			return cb_getNeuronType;
		}

		static IntPtr n_GetNeuronType (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Util.NeuronProperties __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.NeuronProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NeuronType);
		}
#pragma warning restore 0169

		static IntPtr id_getNeuronType;
		public virtual unsafe global::Java.Lang.Class NeuronType {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util']/class[@name='NeuronProperties']/method[@name='getNeuronType' and count(parameter)=0]"
			[Register ("getNeuronType", "()Ljava/lang/Class;", "GetGetNeuronTypeHandler")]
			get {
				if (id_getNeuronType == IntPtr.Zero)
					id_getNeuronType = JNIEnv.GetMethodID (class_ref, "getNeuronType", "()Ljava/lang/Class;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallObjectMethod  (Handle, id_getNeuronType), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNeuronType", "()Ljava/lang/Class;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTransferFunction;
#pragma warning disable 0169
		static Delegate GetGetTransferFunctionHandler ()
		{
			if (cb_getTransferFunction == null)
				cb_getTransferFunction = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTransferFunction);
			return cb_getTransferFunction;
		}

		static IntPtr n_GetTransferFunction (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Util.NeuronProperties __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.NeuronProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TransferFunction);
		}
#pragma warning restore 0169

		static IntPtr id_getTransferFunction;
		public virtual unsafe global::Java.Lang.Class TransferFunction {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util']/class[@name='NeuronProperties']/method[@name='getTransferFunction' and count(parameter)=0]"
			[Register ("getTransferFunction", "()Ljava/lang/Class;", "GetGetTransferFunctionHandler")]
			get {
				if (id_getTransferFunction == IntPtr.Zero)
					id_getTransferFunction = JNIEnv.GetMethodID (class_ref, "getTransferFunction", "()Ljava/lang/Class;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallObjectMethod  (Handle, id_getTransferFunction), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTransferFunction", "()Ljava/lang/Class;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTransferFunctionProperties;
#pragma warning disable 0169
		static Delegate GetGetTransferFunctionPropertiesHandler ()
		{
			if (cb_getTransferFunctionProperties == null)
				cb_getTransferFunctionProperties = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTransferFunctionProperties);
			return cb_getTransferFunctionProperties;
		}

		static IntPtr n_GetTransferFunctionProperties (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Util.NeuronProperties __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.NeuronProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TransferFunctionProperties);
		}
#pragma warning restore 0169

		static IntPtr id_getTransferFunctionProperties;
		public virtual unsafe global::Org.Neuroph.Util.Properties TransferFunctionProperties {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util']/class[@name='NeuronProperties']/method[@name='getTransferFunctionProperties' and count(parameter)=0]"
			[Register ("getTransferFunctionProperties", "()Lorg/neuroph/util/Properties;", "GetGetTransferFunctionPropertiesHandler")]
			get {
				if (id_getTransferFunctionProperties == IntPtr.Zero)
					id_getTransferFunctionProperties = JNIEnv.GetMethodID (class_ref, "getTransferFunctionProperties", "()Lorg/neuroph/util/Properties;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.Properties> (JNIEnv.CallObjectMethod  (Handle, id_getTransferFunctionProperties), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.Properties> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTransferFunctionProperties", "()Lorg/neuroph/util/Properties;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_setProperty_Ljava_lang_String_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util']/class[@name='NeuronProperties']/method[@name='setProperty' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Register ("setProperty", "(Ljava/lang/String;Ljava/lang/Object;)V", "")]
		public override sealed unsafe void SetProperty (string p0, global::Java.Lang.Object p1)
		{
			if (id_setProperty_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
				id_setProperty_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "setProperty", "(Ljava/lang/String;Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod  (Handle, id_setProperty_Ljava_lang_String_Ljava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
