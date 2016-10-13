using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.core']/class[@name='Neuron']"
	[global::Android.Runtime.Register ("org/neuroph/core/Neuron", DoNotGenerateAcw=true)]
	public partial class Neuron : global::Java.Lang.Object, global::Java.IO.ISerializable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/core/Neuron", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Neuron); }
		}

		protected Neuron (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.core']/class[@name='Neuron']/constructor[@name='Neuron' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Neuron ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Neuron)) {
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

		static IntPtr id_ctor_Lorg_neuroph_core_input_InputFunction_Lorg_neuroph_core_transfer_TransferFunction_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.core']/class[@name='Neuron']/constructor[@name='Neuron' and count(parameter)=2 and parameter[1][@type='org.neuroph.core.input.InputFunction'] and parameter[2][@type='org.neuroph.core.transfer.TransferFunction']]"
		[Register (".ctor", "(Lorg/neuroph/core/input/InputFunction;Lorg/neuroph/core/transfer/TransferFunction;)V", "")]
		public unsafe Neuron (global::Org.Neuroph.Core.Input.InputFunction p0, global::Org.Neuroph.Core.Transfer.TransferFunction p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (Neuron)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/neuroph/core/input/InputFunction;Lorg/neuroph/core/transfer/TransferFunction;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/neuroph/core/input/InputFunction;Lorg/neuroph/core/transfer/TransferFunction;)V", __args);
					return;
				}

				if (id_ctor_Lorg_neuroph_core_input_InputFunction_Lorg_neuroph_core_transfer_TransferFunction_ == IntPtr.Zero)
					id_ctor_Lorg_neuroph_core_input_InputFunction_Lorg_neuroph_core_transfer_TransferFunction_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/neuroph/core/input/InputFunction;Lorg/neuroph/core/transfer/TransferFunction;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_neuroph_core_input_InputFunction_Lorg_neuroph_core_transfer_TransferFunction_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_neuroph_core_input_InputFunction_Lorg_neuroph_core_transfer_TransferFunction_, __args);
			} finally {
			}
		}

		static Delegate cb_getError;
#pragma warning disable 0169
		static Delegate GetGetErrorHandler ()
		{
			if (cb_getError == null)
				cb_getError = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetError);
			return cb_getError;
		}

		static double n_GetError (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Core.Neuron __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Neuron> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Error;
		}
#pragma warning restore 0169

		static Delegate cb_setError_D;
#pragma warning disable 0169
		static Delegate GetSetError_DHandler ()
		{
			if (cb_setError_D == null)
				cb_setError_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetError_D);
			return cb_setError_D;
		}

		static void n_SetError_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Org.Neuroph.Core.Neuron __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Neuron> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Error = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getError;
		static IntPtr id_setError_D;
		public virtual unsafe double Error {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='Neuron']/method[@name='getError' and count(parameter)=0]"
			[Register ("getError", "()D", "GetGetErrorHandler")]
			get {
				if (id_getError == IntPtr.Zero)
					id_getError = JNIEnv.GetMethodID (class_ref, "getError", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getError);
					else
						return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getError", "()D"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='Neuron']/method[@name='setError' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setError", "(D)V", "GetSetError_DHandler")]
			set {
				if (id_setError_D == IntPtr.Zero)
					id_setError_D = JNIEnv.GetMethodID (class_ref, "setError", "(D)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setError_D, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setError", "(D)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_hasInputConnections;
#pragma warning disable 0169
		static Delegate GetHasInputConnectionsHandler ()
		{
			if (cb_hasInputConnections == null)
				cb_hasInputConnections = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasInputConnections);
			return cb_hasInputConnections;
		}

		static bool n_HasInputConnections (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Core.Neuron __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Neuron> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasInputConnections;
		}
#pragma warning restore 0169

		static IntPtr id_hasInputConnections;
		public virtual unsafe bool HasInputConnections {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='Neuron']/method[@name='hasInputConnections' and count(parameter)=0]"
			[Register ("hasInputConnections", "()Z", "GetHasInputConnectionsHandler")]
			get {
				if (id_hasInputConnections == IntPtr.Zero)
					id_hasInputConnections = JNIEnv.GetMethodID (class_ref, "hasInputConnections", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasInputConnections);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hasInputConnections", "()Z"));
				} finally {
				}
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
			global::Org.Neuroph.Core.Neuron __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Neuron> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InputFunction);
		}
#pragma warning restore 0169

		static Delegate cb_setInputFunction_Lorg_neuroph_core_input_InputFunction_;
#pragma warning disable 0169
		static Delegate GetSetInputFunction_Lorg_neuroph_core_input_InputFunction_Handler ()
		{
			if (cb_setInputFunction_Lorg_neuroph_core_input_InputFunction_ == null)
				cb_setInputFunction_Lorg_neuroph_core_input_InputFunction_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetInputFunction_Lorg_neuroph_core_input_InputFunction_);
			return cb_setInputFunction_Lorg_neuroph_core_input_InputFunction_;
		}

		static void n_SetInputFunction_Lorg_neuroph_core_input_InputFunction_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Core.Neuron __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Neuron> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Core.Input.InputFunction p0 = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Input.InputFunction> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.InputFunction = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getInputFunction;
		static IntPtr id_setInputFunction_Lorg_neuroph_core_input_InputFunction_;
		public virtual unsafe global::Org.Neuroph.Core.Input.InputFunction InputFunction {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='Neuron']/method[@name='getInputFunction' and count(parameter)=0]"
			[Register ("getInputFunction", "()Lorg/neuroph/core/input/InputFunction;", "GetGetInputFunctionHandler")]
			get {
				if (id_getInputFunction == IntPtr.Zero)
					id_getInputFunction = JNIEnv.GetMethodID (class_ref, "getInputFunction", "()Lorg/neuroph/core/input/InputFunction;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Input.InputFunction> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getInputFunction), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Input.InputFunction> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getInputFunction", "()Lorg/neuroph/core/input/InputFunction;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='Neuron']/method[@name='setInputFunction' and count(parameter)=1 and parameter[1][@type='org.neuroph.core.input.InputFunction']]"
			[Register ("setInputFunction", "(Lorg/neuroph/core/input/InputFunction;)V", "GetSetInputFunction_Lorg_neuroph_core_input_InputFunction_Handler")]
			set {
				if (id_setInputFunction_Lorg_neuroph_core_input_InputFunction_ == IntPtr.Zero)
					id_setInputFunction_Lorg_neuroph_core_input_InputFunction_ = JNIEnv.GetMethodID (class_ref, "setInputFunction", "(Lorg/neuroph/core/input/InputFunction;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setInputFunction_Lorg_neuroph_core_input_InputFunction_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setInputFunction", "(Lorg/neuroph/core/input/InputFunction;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getLabel;
#pragma warning disable 0169
		static Delegate GetGetLabelHandler ()
		{
			if (cb_getLabel == null)
				cb_getLabel = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLabel);
			return cb_getLabel;
		}

		static IntPtr n_GetLabel (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Core.Neuron __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Neuron> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Label);
		}
#pragma warning restore 0169

		static Delegate cb_setLabel_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetLabel_Ljava_lang_String_Handler ()
		{
			if (cb_setLabel_Ljava_lang_String_ == null)
				cb_setLabel_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLabel_Ljava_lang_String_);
			return cb_setLabel_Ljava_lang_String_;
		}

		static void n_SetLabel_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Core.Neuron __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Neuron> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Label = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getLabel;
		static IntPtr id_setLabel_Ljava_lang_String_;
		public virtual unsafe string Label {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='Neuron']/method[@name='getLabel' and count(parameter)=0]"
			[Register ("getLabel", "()Ljava/lang/String;", "GetGetLabelHandler")]
			get {
				if (id_getLabel == IntPtr.Zero)
					id_getLabel = JNIEnv.GetMethodID (class_ref, "getLabel", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLabel), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLabel", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='Neuron']/method[@name='setLabel' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setLabel", "(Ljava/lang/String;)V", "GetSetLabel_Ljava_lang_String_Handler")]
			set {
				if (id_setLabel_Ljava_lang_String_ == IntPtr.Zero)
					id_setLabel_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setLabel", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLabel_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLabel", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getNetInput;
#pragma warning disable 0169
		static Delegate GetGetNetInputHandler ()
		{
			if (cb_getNetInput == null)
				cb_getNetInput = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetNetInput);
			return cb_getNetInput;
		}

		static double n_GetNetInput (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Core.Neuron __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Neuron> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NetInput;
		}
#pragma warning restore 0169

		static IntPtr id_getNetInput;
		public virtual unsafe double NetInput {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='Neuron']/method[@name='getNetInput' and count(parameter)=0]"
			[Register ("getNetInput", "()D", "GetGetNetInputHandler")]
			get {
				if (id_getNetInput == IntPtr.Zero)
					id_getNetInput = JNIEnv.GetMethodID (class_ref, "getNetInput", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getNetInput);
					else
						return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNetInput", "()D"));
				} finally {
				}
			}
		}

		static Delegate cb_getOutput;
#pragma warning disable 0169
		static Delegate GetGetOutputHandler ()
		{
			if (cb_getOutput == null)
				cb_getOutput = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetOutput);
			return cb_getOutput;
		}

		static double n_GetOutput (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Core.Neuron __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Neuron> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Output;
		}
#pragma warning restore 0169

		static Delegate cb_setOutput_D;
#pragma warning disable 0169
		static Delegate GetSetOutput_DHandler ()
		{
			if (cb_setOutput_D == null)
				cb_setOutput_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetOutput_D);
			return cb_setOutput_D;
		}

		static void n_SetOutput_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Org.Neuroph.Core.Neuron __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Neuron> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Output = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getOutput;
		static IntPtr id_setOutput_D;
		public virtual unsafe double Output {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='Neuron']/method[@name='getOutput' and count(parameter)=0]"
			[Register ("getOutput", "()D", "GetGetOutputHandler")]
			get {
				if (id_getOutput == IntPtr.Zero)
					id_getOutput = JNIEnv.GetMethodID (class_ref, "getOutput", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getOutput);
					else
						return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOutput", "()D"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='Neuron']/method[@name='setOutput' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setOutput", "(D)V", "GetSetOutput_DHandler")]
			set {
				if (id_setOutput_D == IntPtr.Zero)
					id_setOutput_D = JNIEnv.GetMethodID (class_ref, "setOutput", "(D)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOutput_D, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOutput", "(D)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getParentLayer;
#pragma warning disable 0169
		static Delegate GetGetParentLayerHandler ()
		{
			if (cb_getParentLayer == null)
				cb_getParentLayer = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetParentLayer);
			return cb_getParentLayer;
		}

		static IntPtr n_GetParentLayer (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Core.Neuron __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Neuron> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ParentLayer);
		}
#pragma warning restore 0169

		static Delegate cb_setParentLayer_Lorg_neuroph_core_Layer_;
#pragma warning disable 0169
		static Delegate GetSetParentLayer_Lorg_neuroph_core_Layer_Handler ()
		{
			if (cb_setParentLayer_Lorg_neuroph_core_Layer_ == null)
				cb_setParentLayer_Lorg_neuroph_core_Layer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetParentLayer_Lorg_neuroph_core_Layer_);
			return cb_setParentLayer_Lorg_neuroph_core_Layer_;
		}

		static void n_SetParentLayer_Lorg_neuroph_core_Layer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Core.Neuron __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Neuron> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Core.Layer p0 = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Layer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ParentLayer = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getParentLayer;
		static IntPtr id_setParentLayer_Lorg_neuroph_core_Layer_;
		public virtual unsafe global::Org.Neuroph.Core.Layer ParentLayer {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='Neuron']/method[@name='getParentLayer' and count(parameter)=0]"
			[Register ("getParentLayer", "()Lorg/neuroph/core/Layer;", "GetGetParentLayerHandler")]
			get {
				if (id_getParentLayer == IntPtr.Zero)
					id_getParentLayer = JNIEnv.GetMethodID (class_ref, "getParentLayer", "()Lorg/neuroph/core/Layer;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Layer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getParentLayer), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Layer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getParentLayer", "()Lorg/neuroph/core/Layer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='Neuron']/method[@name='setParentLayer' and count(parameter)=1 and parameter[1][@type='org.neuroph.core.Layer']]"
			[Register ("setParentLayer", "(Lorg/neuroph/core/Layer;)V", "GetSetParentLayer_Lorg_neuroph_core_Layer_Handler")]
			set {
				if (id_setParentLayer_Lorg_neuroph_core_Layer_ == IntPtr.Zero)
					id_setParentLayer_Lorg_neuroph_core_Layer_ = JNIEnv.GetMethodID (class_ref, "setParentLayer", "(Lorg/neuroph/core/Layer;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setParentLayer_Lorg_neuroph_core_Layer_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setParentLayer", "(Lorg/neuroph/core/Layer;)V"), __args);
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
			global::Org.Neuroph.Core.Neuron __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Neuron> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TransferFunction);
		}
#pragma warning restore 0169

		static Delegate cb_setTransferFunction_Lorg_neuroph_core_transfer_TransferFunction_;
#pragma warning disable 0169
		static Delegate GetSetTransferFunction_Lorg_neuroph_core_transfer_TransferFunction_Handler ()
		{
			if (cb_setTransferFunction_Lorg_neuroph_core_transfer_TransferFunction_ == null)
				cb_setTransferFunction_Lorg_neuroph_core_transfer_TransferFunction_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTransferFunction_Lorg_neuroph_core_transfer_TransferFunction_);
			return cb_setTransferFunction_Lorg_neuroph_core_transfer_TransferFunction_;
		}

		static void n_SetTransferFunction_Lorg_neuroph_core_transfer_TransferFunction_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Core.Neuron __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Neuron> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Core.Transfer.TransferFunction p0 = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Transfer.TransferFunction> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TransferFunction = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTransferFunction;
		static IntPtr id_setTransferFunction_Lorg_neuroph_core_transfer_TransferFunction_;
		public virtual unsafe global::Org.Neuroph.Core.Transfer.TransferFunction TransferFunction {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='Neuron']/method[@name='getTransferFunction' and count(parameter)=0]"
			[Register ("getTransferFunction", "()Lorg/neuroph/core/transfer/TransferFunction;", "GetGetTransferFunctionHandler")]
			get {
				if (id_getTransferFunction == IntPtr.Zero)
					id_getTransferFunction = JNIEnv.GetMethodID (class_ref, "getTransferFunction", "()Lorg/neuroph/core/transfer/TransferFunction;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Transfer.TransferFunction> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTransferFunction), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Transfer.TransferFunction> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTransferFunction", "()Lorg/neuroph/core/transfer/TransferFunction;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='Neuron']/method[@name='setTransferFunction' and count(parameter)=1 and parameter[1][@type='org.neuroph.core.transfer.TransferFunction']]"
			[Register ("setTransferFunction", "(Lorg/neuroph/core/transfer/TransferFunction;)V", "GetSetTransferFunction_Lorg_neuroph_core_transfer_TransferFunction_Handler")]
			set {
				if (id_setTransferFunction_Lorg_neuroph_core_transfer_TransferFunction_ == IntPtr.Zero)
					id_setTransferFunction_Lorg_neuroph_core_transfer_TransferFunction_ = JNIEnv.GetMethodID (class_ref, "setTransferFunction", "(Lorg/neuroph/core/transfer/TransferFunction;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTransferFunction_Lorg_neuroph_core_transfer_TransferFunction_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTransferFunction", "(Lorg/neuroph/core/transfer/TransferFunction;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_addInputConnection_Lorg_neuroph_core_Connection_;
#pragma warning disable 0169
		static Delegate GetAddInputConnection_Lorg_neuroph_core_Connection_Handler ()
		{
			if (cb_addInputConnection_Lorg_neuroph_core_Connection_ == null)
				cb_addInputConnection_Lorg_neuroph_core_Connection_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddInputConnection_Lorg_neuroph_core_Connection_);
			return cb_addInputConnection_Lorg_neuroph_core_Connection_;
		}

		static void n_AddInputConnection_Lorg_neuroph_core_Connection_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Core.Neuron __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Neuron> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Core.Connection p0 = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Connection> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddInputConnection (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addInputConnection_Lorg_neuroph_core_Connection_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='Neuron']/method[@name='addInputConnection' and count(parameter)=1 and parameter[1][@type='org.neuroph.core.Connection']]"
		[Register ("addInputConnection", "(Lorg/neuroph/core/Connection;)V", "GetAddInputConnection_Lorg_neuroph_core_Connection_Handler")]
		public virtual unsafe void AddInputConnection (global::Org.Neuroph.Core.Connection p0)
		{
			if (id_addInputConnection_Lorg_neuroph_core_Connection_ == IntPtr.Zero)
				id_addInputConnection_Lorg_neuroph_core_Connection_ = JNIEnv.GetMethodID (class_ref, "addInputConnection", "(Lorg/neuroph/core/Connection;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addInputConnection_Lorg_neuroph_core_Connection_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addInputConnection", "(Lorg/neuroph/core/Connection;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_addInputConnection_Lorg_neuroph_core_Neuron_;
#pragma warning disable 0169
		static Delegate GetAddInputConnection_Lorg_neuroph_core_Neuron_Handler ()
		{
			if (cb_addInputConnection_Lorg_neuroph_core_Neuron_ == null)
				cb_addInputConnection_Lorg_neuroph_core_Neuron_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddInputConnection_Lorg_neuroph_core_Neuron_);
			return cb_addInputConnection_Lorg_neuroph_core_Neuron_;
		}

		static void n_AddInputConnection_Lorg_neuroph_core_Neuron_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Core.Neuron __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Neuron> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Core.Neuron p0 = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Neuron> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddInputConnection (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addInputConnection_Lorg_neuroph_core_Neuron_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='Neuron']/method[@name='addInputConnection' and count(parameter)=1 and parameter[1][@type='org.neuroph.core.Neuron']]"
		[Register ("addInputConnection", "(Lorg/neuroph/core/Neuron;)V", "GetAddInputConnection_Lorg_neuroph_core_Neuron_Handler")]
		public virtual unsafe void AddInputConnection (global::Org.Neuroph.Core.Neuron p0)
		{
			if (id_addInputConnection_Lorg_neuroph_core_Neuron_ == IntPtr.Zero)
				id_addInputConnection_Lorg_neuroph_core_Neuron_ = JNIEnv.GetMethodID (class_ref, "addInputConnection", "(Lorg/neuroph/core/Neuron;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addInputConnection_Lorg_neuroph_core_Neuron_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addInputConnection", "(Lorg/neuroph/core/Neuron;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_addInputConnection_Lorg_neuroph_core_Neuron_D;
#pragma warning disable 0169
		static Delegate GetAddInputConnection_Lorg_neuroph_core_Neuron_DHandler ()
		{
			if (cb_addInputConnection_Lorg_neuroph_core_Neuron_D == null)
				cb_addInputConnection_Lorg_neuroph_core_Neuron_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, double>) n_AddInputConnection_Lorg_neuroph_core_Neuron_D);
			return cb_addInputConnection_Lorg_neuroph_core_Neuron_D;
		}

		static void n_AddInputConnection_Lorg_neuroph_core_Neuron_D (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, double p1)
		{
			global::Org.Neuroph.Core.Neuron __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Neuron> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Core.Neuron p0 = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Neuron> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddInputConnection (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_addInputConnection_Lorg_neuroph_core_Neuron_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='Neuron']/method[@name='addInputConnection' and count(parameter)=2 and parameter[1][@type='org.neuroph.core.Neuron'] and parameter[2][@type='double']]"
		[Register ("addInputConnection", "(Lorg/neuroph/core/Neuron;D)V", "GetAddInputConnection_Lorg_neuroph_core_Neuron_DHandler")]
		public virtual unsafe void AddInputConnection (global::Org.Neuroph.Core.Neuron p0, double p1)
		{
			if (id_addInputConnection_Lorg_neuroph_core_Neuron_D == IntPtr.Zero)
				id_addInputConnection_Lorg_neuroph_core_Neuron_D = JNIEnv.GetMethodID (class_ref, "addInputConnection", "(Lorg/neuroph/core/Neuron;D)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addInputConnection_Lorg_neuroph_core_Neuron_D, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addInputConnection", "(Lorg/neuroph/core/Neuron;D)V"), __args);
			} finally {
			}
		}

		static Delegate cb_addOutputConnection_Lorg_neuroph_core_Connection_;
#pragma warning disable 0169
		static Delegate GetAddOutputConnection_Lorg_neuroph_core_Connection_Handler ()
		{
			if (cb_addOutputConnection_Lorg_neuroph_core_Connection_ == null)
				cb_addOutputConnection_Lorg_neuroph_core_Connection_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddOutputConnection_Lorg_neuroph_core_Connection_);
			return cb_addOutputConnection_Lorg_neuroph_core_Connection_;
		}

		static void n_AddOutputConnection_Lorg_neuroph_core_Connection_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Core.Neuron __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Neuron> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Core.Connection p0 = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Connection> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddOutputConnection (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addOutputConnection_Lorg_neuroph_core_Connection_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='Neuron']/method[@name='addOutputConnection' and count(parameter)=1 and parameter[1][@type='org.neuroph.core.Connection']]"
		[Register ("addOutputConnection", "(Lorg/neuroph/core/Connection;)V", "GetAddOutputConnection_Lorg_neuroph_core_Connection_Handler")]
		protected virtual unsafe void AddOutputConnection (global::Org.Neuroph.Core.Connection p0)
		{
			if (id_addOutputConnection_Lorg_neuroph_core_Connection_ == IntPtr.Zero)
				id_addOutputConnection_Lorg_neuroph_core_Connection_ = JNIEnv.GetMethodID (class_ref, "addOutputConnection", "(Lorg/neuroph/core/Connection;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addOutputConnection_Lorg_neuroph_core_Connection_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addOutputConnection", "(Lorg/neuroph/core/Connection;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_calculate;
#pragma warning disable 0169
		static Delegate GetCalculateHandler ()
		{
			if (cb_calculate == null)
				cb_calculate = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Calculate);
			return cb_calculate;
		}

		static void n_Calculate (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Core.Neuron __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Neuron> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Calculate ();
		}
#pragma warning restore 0169

		static IntPtr id_calculate;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='Neuron']/method[@name='calculate' and count(parameter)=0]"
		[Register ("calculate", "()V", "GetCalculateHandler")]
		public virtual unsafe void Calculate ()
		{
			if (id_calculate == IntPtr.Zero)
				id_calculate = JNIEnv.GetMethodID (class_ref, "calculate", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_calculate);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "calculate", "()V"));
			} finally {
			}
		}

		static Delegate cb_getConnectionFrom_Lorg_neuroph_core_Neuron_;
#pragma warning disable 0169
		static Delegate GetGetConnectionFrom_Lorg_neuroph_core_Neuron_Handler ()
		{
			if (cb_getConnectionFrom_Lorg_neuroph_core_Neuron_ == null)
				cb_getConnectionFrom_Lorg_neuroph_core_Neuron_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetConnectionFrom_Lorg_neuroph_core_Neuron_);
			return cb_getConnectionFrom_Lorg_neuroph_core_Neuron_;
		}

		static IntPtr n_GetConnectionFrom_Lorg_neuroph_core_Neuron_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Core.Neuron __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Neuron> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Core.Neuron p0 = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Neuron> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetConnectionFrom (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getConnectionFrom_Lorg_neuroph_core_Neuron_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='Neuron']/method[@name='getConnectionFrom' and count(parameter)=1 and parameter[1][@type='org.neuroph.core.Neuron']]"
		[Register ("getConnectionFrom", "(Lorg/neuroph/core/Neuron;)Lorg/neuroph/core/Connection;", "GetGetConnectionFrom_Lorg_neuroph_core_Neuron_Handler")]
		public virtual unsafe global::Org.Neuroph.Core.Connection GetConnectionFrom (global::Org.Neuroph.Core.Neuron p0)
		{
			if (id_getConnectionFrom_Lorg_neuroph_core_Neuron_ == IntPtr.Zero)
				id_getConnectionFrom_Lorg_neuroph_core_Neuron_ = JNIEnv.GetMethodID (class_ref, "getConnectionFrom", "(Lorg/neuroph/core/Neuron;)Lorg/neuroph/core/Connection;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Org.Neuroph.Core.Connection __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Connection> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getConnectionFrom_Lorg_neuroph_core_Neuron_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Connection> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getConnectionFrom", "(Lorg/neuroph/core/Neuron;)Lorg/neuroph/core/Connection;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getInputConnections;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='Neuron']/method[@name='getInputConnections' and count(parameter)=0]"
		[Register ("getInputConnections", "()[Lorg/neuroph/core/Connection;", "")]
		public unsafe global::Org.Neuroph.Core.Connection[] GetInputConnections ()
		{
			if (id_getInputConnections == IntPtr.Zero)
				id_getInputConnections = JNIEnv.GetMethodID (class_ref, "getInputConnections", "()[Lorg/neuroph/core/Connection;");
			try {
				return (global::Org.Neuroph.Core.Connection[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getInputConnections), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Neuroph.Core.Connection));
			} finally {
			}
		}

		static IntPtr id_getOutConnections;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='Neuron']/method[@name='getOutConnections' and count(parameter)=0]"
		[Register ("getOutConnections", "()[Lorg/neuroph/core/Connection;", "")]
		public unsafe global::Org.Neuroph.Core.Connection[] GetOutConnections ()
		{
			if (id_getOutConnections == IntPtr.Zero)
				id_getOutConnections = JNIEnv.GetMethodID (class_ref, "getOutConnections", "()[Lorg/neuroph/core/Connection;");
			try {
				return (global::Org.Neuroph.Core.Connection[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOutConnections), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Neuroph.Core.Connection));
			} finally {
			}
		}

		static Delegate cb_getWeights;
#pragma warning disable 0169
		static Delegate GetGetWeightsHandler ()
		{
			if (cb_getWeights == null)
				cb_getWeights = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetWeights);
			return cb_getWeights;
		}

		static IntPtr n_GetWeights (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Core.Neuron __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Neuron> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetWeights ());
		}
#pragma warning restore 0169

		static IntPtr id_getWeights;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='Neuron']/method[@name='getWeights' and count(parameter)=0]"
		[Register ("getWeights", "()[Lorg/neuroph/core/Weight;", "GetGetWeightsHandler")]
		public virtual unsafe global::Org.Neuroph.Core.Weight[] GetWeights ()
		{
			if (id_getWeights == IntPtr.Zero)
				id_getWeights = JNIEnv.GetMethodID (class_ref, "getWeights", "()[Lorg/neuroph/core/Weight;");
			try {

				if (GetType () == ThresholdType)
					return (global::Org.Neuroph.Core.Weight[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getWeights), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Neuroph.Core.Weight));
				else
					return (global::Org.Neuroph.Core.Weight[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWeights", "()[Lorg/neuroph/core/Weight;")), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Neuroph.Core.Weight));
			} finally {
			}
		}

		static Delegate cb_hasInputConnectionFrom_Lorg_neuroph_core_Neuron_;
#pragma warning disable 0169
		static Delegate GetHasInputConnectionFrom_Lorg_neuroph_core_Neuron_Handler ()
		{
			if (cb_hasInputConnectionFrom_Lorg_neuroph_core_Neuron_ == null)
				cb_hasInputConnectionFrom_Lorg_neuroph_core_Neuron_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_HasInputConnectionFrom_Lorg_neuroph_core_Neuron_);
			return cb_hasInputConnectionFrom_Lorg_neuroph_core_Neuron_;
		}

		static bool n_HasInputConnectionFrom_Lorg_neuroph_core_Neuron_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Core.Neuron __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Neuron> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Core.Neuron p0 = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Neuron> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.HasInputConnectionFrom (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_hasInputConnectionFrom_Lorg_neuroph_core_Neuron_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='Neuron']/method[@name='hasInputConnectionFrom' and count(parameter)=1 and parameter[1][@type='org.neuroph.core.Neuron']]"
		[Register ("hasInputConnectionFrom", "(Lorg/neuroph/core/Neuron;)Z", "GetHasInputConnectionFrom_Lorg_neuroph_core_Neuron_Handler")]
		public virtual unsafe bool HasInputConnectionFrom (global::Org.Neuroph.Core.Neuron p0)
		{
			if (id_hasInputConnectionFrom_Lorg_neuroph_core_Neuron_ == IntPtr.Zero)
				id_hasInputConnectionFrom_Lorg_neuroph_core_Neuron_ = JNIEnv.GetMethodID (class_ref, "hasInputConnectionFrom", "(Lorg/neuroph/core/Neuron;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasInputConnectionFrom_Lorg_neuroph_core_Neuron_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hasInputConnectionFrom", "(Lorg/neuroph/core/Neuron;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_hasOutputConnectionTo_Lorg_neuroph_core_Neuron_;
#pragma warning disable 0169
		static Delegate GetHasOutputConnectionTo_Lorg_neuroph_core_Neuron_Handler ()
		{
			if (cb_hasOutputConnectionTo_Lorg_neuroph_core_Neuron_ == null)
				cb_hasOutputConnectionTo_Lorg_neuroph_core_Neuron_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_HasOutputConnectionTo_Lorg_neuroph_core_Neuron_);
			return cb_hasOutputConnectionTo_Lorg_neuroph_core_Neuron_;
		}

		static bool n_HasOutputConnectionTo_Lorg_neuroph_core_Neuron_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Core.Neuron __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Neuron> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Core.Neuron p0 = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Neuron> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.HasOutputConnectionTo (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_hasOutputConnectionTo_Lorg_neuroph_core_Neuron_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='Neuron']/method[@name='hasOutputConnectionTo' and count(parameter)=1 and parameter[1][@type='org.neuroph.core.Neuron']]"
		[Register ("hasOutputConnectionTo", "(Lorg/neuroph/core/Neuron;)Z", "GetHasOutputConnectionTo_Lorg_neuroph_core_Neuron_Handler")]
		public virtual unsafe bool HasOutputConnectionTo (global::Org.Neuroph.Core.Neuron p0)
		{
			if (id_hasOutputConnectionTo_Lorg_neuroph_core_Neuron_ == IntPtr.Zero)
				id_hasOutputConnectionTo_Lorg_neuroph_core_Neuron_ = JNIEnv.GetMethodID (class_ref, "hasOutputConnectionTo", "(Lorg/neuroph/core/Neuron;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasOutputConnectionTo_Lorg_neuroph_core_Neuron_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hasOutputConnectionTo", "(Lorg/neuroph/core/Neuron;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_initializeWeights_D;
#pragma warning disable 0169
		static Delegate GetInitializeWeights_DHandler ()
		{
			if (cb_initializeWeights_D == null)
				cb_initializeWeights_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_InitializeWeights_D);
			return cb_initializeWeights_D;
		}

		static void n_InitializeWeights_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Org.Neuroph.Core.Neuron __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Neuron> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.InitializeWeights (p0);
		}
#pragma warning restore 0169

		static IntPtr id_initializeWeights_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='Neuron']/method[@name='initializeWeights' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("initializeWeights", "(D)V", "GetInitializeWeights_DHandler")]
		public virtual unsafe void InitializeWeights (double p0)
		{
			if (id_initializeWeights_D == IntPtr.Zero)
				id_initializeWeights_D = JNIEnv.GetMethodID (class_ref, "initializeWeights", "(D)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_initializeWeights_D, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "initializeWeights", "(D)V"), __args);
			} finally {
			}
		}

		static Delegate cb_removeAllConnections;
#pragma warning disable 0169
		static Delegate GetRemoveAllConnectionsHandler ()
		{
			if (cb_removeAllConnections == null)
				cb_removeAllConnections = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RemoveAllConnections);
			return cb_removeAllConnections;
		}

		static void n_RemoveAllConnections (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Core.Neuron __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Neuron> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveAllConnections ();
		}
#pragma warning restore 0169

		static IntPtr id_removeAllConnections;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='Neuron']/method[@name='removeAllConnections' and count(parameter)=0]"
		[Register ("removeAllConnections", "()V", "GetRemoveAllConnectionsHandler")]
		public virtual unsafe void RemoveAllConnections ()
		{
			if (id_removeAllConnections == IntPtr.Zero)
				id_removeAllConnections = JNIEnv.GetMethodID (class_ref, "removeAllConnections", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeAllConnections);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeAllConnections", "()V"));
			} finally {
			}
		}

		static Delegate cb_removeAllInputConnections;
#pragma warning disable 0169
		static Delegate GetRemoveAllInputConnectionsHandler ()
		{
			if (cb_removeAllInputConnections == null)
				cb_removeAllInputConnections = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RemoveAllInputConnections);
			return cb_removeAllInputConnections;
		}

		static void n_RemoveAllInputConnections (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Core.Neuron __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Neuron> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveAllInputConnections ();
		}
#pragma warning restore 0169

		static IntPtr id_removeAllInputConnections;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='Neuron']/method[@name='removeAllInputConnections' and count(parameter)=0]"
		[Register ("removeAllInputConnections", "()V", "GetRemoveAllInputConnectionsHandler")]
		public virtual unsafe void RemoveAllInputConnections ()
		{
			if (id_removeAllInputConnections == IntPtr.Zero)
				id_removeAllInputConnections = JNIEnv.GetMethodID (class_ref, "removeAllInputConnections", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeAllInputConnections);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeAllInputConnections", "()V"));
			} finally {
			}
		}

		static Delegate cb_removeAllOutputConnections;
#pragma warning disable 0169
		static Delegate GetRemoveAllOutputConnectionsHandler ()
		{
			if (cb_removeAllOutputConnections == null)
				cb_removeAllOutputConnections = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RemoveAllOutputConnections);
			return cb_removeAllOutputConnections;
		}

		static void n_RemoveAllOutputConnections (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Core.Neuron __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Neuron> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveAllOutputConnections ();
		}
#pragma warning restore 0169

		static IntPtr id_removeAllOutputConnections;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='Neuron']/method[@name='removeAllOutputConnections' and count(parameter)=0]"
		[Register ("removeAllOutputConnections", "()V", "GetRemoveAllOutputConnectionsHandler")]
		public virtual unsafe void RemoveAllOutputConnections ()
		{
			if (id_removeAllOutputConnections == IntPtr.Zero)
				id_removeAllOutputConnections = JNIEnv.GetMethodID (class_ref, "removeAllOutputConnections", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeAllOutputConnections);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeAllOutputConnections", "()V"));
			} finally {
			}
		}

		static Delegate cb_removeInputConnection_Lorg_neuroph_core_Connection_;
#pragma warning disable 0169
		static Delegate GetRemoveInputConnection_Lorg_neuroph_core_Connection_Handler ()
		{
			if (cb_removeInputConnection_Lorg_neuroph_core_Connection_ == null)
				cb_removeInputConnection_Lorg_neuroph_core_Connection_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveInputConnection_Lorg_neuroph_core_Connection_);
			return cb_removeInputConnection_Lorg_neuroph_core_Connection_;
		}

		static void n_RemoveInputConnection_Lorg_neuroph_core_Connection_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Core.Neuron __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Neuron> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Core.Connection p0 = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Connection> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveInputConnection (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeInputConnection_Lorg_neuroph_core_Connection_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='Neuron']/method[@name='removeInputConnection' and count(parameter)=1 and parameter[1][@type='org.neuroph.core.Connection']]"
		[Register ("removeInputConnection", "(Lorg/neuroph/core/Connection;)V", "GetRemoveInputConnection_Lorg_neuroph_core_Connection_Handler")]
		protected virtual unsafe void RemoveInputConnection (global::Org.Neuroph.Core.Connection p0)
		{
			if (id_removeInputConnection_Lorg_neuroph_core_Connection_ == IntPtr.Zero)
				id_removeInputConnection_Lorg_neuroph_core_Connection_ = JNIEnv.GetMethodID (class_ref, "removeInputConnection", "(Lorg/neuroph/core/Connection;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeInputConnection_Lorg_neuroph_core_Connection_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeInputConnection", "(Lorg/neuroph/core/Connection;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_removeInputConnectionFrom_Lorg_neuroph_core_Neuron_;
#pragma warning disable 0169
		static Delegate GetRemoveInputConnectionFrom_Lorg_neuroph_core_Neuron_Handler ()
		{
			if (cb_removeInputConnectionFrom_Lorg_neuroph_core_Neuron_ == null)
				cb_removeInputConnectionFrom_Lorg_neuroph_core_Neuron_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveInputConnectionFrom_Lorg_neuroph_core_Neuron_);
			return cb_removeInputConnectionFrom_Lorg_neuroph_core_Neuron_;
		}

		static void n_RemoveInputConnectionFrom_Lorg_neuroph_core_Neuron_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Core.Neuron __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Neuron> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Core.Neuron p0 = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Neuron> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveInputConnectionFrom (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeInputConnectionFrom_Lorg_neuroph_core_Neuron_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='Neuron']/method[@name='removeInputConnectionFrom' and count(parameter)=1 and parameter[1][@type='org.neuroph.core.Neuron']]"
		[Register ("removeInputConnectionFrom", "(Lorg/neuroph/core/Neuron;)V", "GetRemoveInputConnectionFrom_Lorg_neuroph_core_Neuron_Handler")]
		public virtual unsafe void RemoveInputConnectionFrom (global::Org.Neuroph.Core.Neuron p0)
		{
			if (id_removeInputConnectionFrom_Lorg_neuroph_core_Neuron_ == IntPtr.Zero)
				id_removeInputConnectionFrom_Lorg_neuroph_core_Neuron_ = JNIEnv.GetMethodID (class_ref, "removeInputConnectionFrom", "(Lorg/neuroph/core/Neuron;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeInputConnectionFrom_Lorg_neuroph_core_Neuron_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeInputConnectionFrom", "(Lorg/neuroph/core/Neuron;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_removeOutputConnection_Lorg_neuroph_core_Connection_;
#pragma warning disable 0169
		static Delegate GetRemoveOutputConnection_Lorg_neuroph_core_Connection_Handler ()
		{
			if (cb_removeOutputConnection_Lorg_neuroph_core_Connection_ == null)
				cb_removeOutputConnection_Lorg_neuroph_core_Connection_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveOutputConnection_Lorg_neuroph_core_Connection_);
			return cb_removeOutputConnection_Lorg_neuroph_core_Connection_;
		}

		static void n_RemoveOutputConnection_Lorg_neuroph_core_Connection_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Core.Neuron __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Neuron> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Core.Connection p0 = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Connection> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveOutputConnection (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeOutputConnection_Lorg_neuroph_core_Connection_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='Neuron']/method[@name='removeOutputConnection' and count(parameter)=1 and parameter[1][@type='org.neuroph.core.Connection']]"
		[Register ("removeOutputConnection", "(Lorg/neuroph/core/Connection;)V", "GetRemoveOutputConnection_Lorg_neuroph_core_Connection_Handler")]
		protected virtual unsafe void RemoveOutputConnection (global::Org.Neuroph.Core.Connection p0)
		{
			if (id_removeOutputConnection_Lorg_neuroph_core_Connection_ == IntPtr.Zero)
				id_removeOutputConnection_Lorg_neuroph_core_Connection_ = JNIEnv.GetMethodID (class_ref, "removeOutputConnection", "(Lorg/neuroph/core/Connection;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeOutputConnection_Lorg_neuroph_core_Connection_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeOutputConnection", "(Lorg/neuroph/core/Connection;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_removeOutputConnectionTo_Lorg_neuroph_core_Neuron_;
#pragma warning disable 0169
		static Delegate GetRemoveOutputConnectionTo_Lorg_neuroph_core_Neuron_Handler ()
		{
			if (cb_removeOutputConnectionTo_Lorg_neuroph_core_Neuron_ == null)
				cb_removeOutputConnectionTo_Lorg_neuroph_core_Neuron_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveOutputConnectionTo_Lorg_neuroph_core_Neuron_);
			return cb_removeOutputConnectionTo_Lorg_neuroph_core_Neuron_;
		}

		static void n_RemoveOutputConnectionTo_Lorg_neuroph_core_Neuron_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Core.Neuron __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Neuron> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Core.Neuron p0 = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Neuron> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveOutputConnectionTo (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeOutputConnectionTo_Lorg_neuroph_core_Neuron_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='Neuron']/method[@name='removeOutputConnectionTo' and count(parameter)=1 and parameter[1][@type='org.neuroph.core.Neuron']]"
		[Register ("removeOutputConnectionTo", "(Lorg/neuroph/core/Neuron;)V", "GetRemoveOutputConnectionTo_Lorg_neuroph_core_Neuron_Handler")]
		public virtual unsafe void RemoveOutputConnectionTo (global::Org.Neuroph.Core.Neuron p0)
		{
			if (id_removeOutputConnectionTo_Lorg_neuroph_core_Neuron_ == IntPtr.Zero)
				id_removeOutputConnectionTo_Lorg_neuroph_core_Neuron_ = JNIEnv.GetMethodID (class_ref, "removeOutputConnectionTo", "(Lorg/neuroph/core/Neuron;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeOutputConnectionTo_Lorg_neuroph_core_Neuron_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeOutputConnectionTo", "(Lorg/neuroph/core/Neuron;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_reset;
#pragma warning disable 0169
		static Delegate GetResetHandler ()
		{
			if (cb_reset == null)
				cb_reset = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Reset);
			return cb_reset;
		}

		static void n_Reset (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Core.Neuron __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Neuron> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Reset ();
		}
#pragma warning restore 0169

		static IntPtr id_reset;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='Neuron']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "GetResetHandler")]
		public virtual unsafe void Reset ()
		{
			if (id_reset == IntPtr.Zero)
				id_reset = JNIEnv.GetMethodID (class_ref, "reset", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_reset);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "reset", "()V"));
			} finally {
			}
		}

		static Delegate cb_setInput_D;
#pragma warning disable 0169
		static Delegate GetSetInput_DHandler ()
		{
			if (cb_setInput_D == null)
				cb_setInput_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetInput_D);
			return cb_setInput_D;
		}

		static void n_SetInput_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Org.Neuroph.Core.Neuron __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Neuron> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetInput (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setInput_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='Neuron']/method[@name='setInput' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("setInput", "(D)V", "GetSetInput_DHandler")]
		public virtual unsafe void SetInput (double p0)
		{
			if (id_setInput_D == IntPtr.Zero)
				id_setInput_D = JNIEnv.GetMethodID (class_ref, "setInput", "(D)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setInput_D, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setInput", "(D)V"), __args);
			} finally {
			}
		}

	}
}
