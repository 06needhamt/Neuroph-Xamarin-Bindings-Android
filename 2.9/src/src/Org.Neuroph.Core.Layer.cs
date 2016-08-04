using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.core']/class[@name='Layer']"
	[global::Android.Runtime.Register ("org/neuroph/core/Layer", DoNotGenerateAcw=true)]
	public partial class Layer : global::Java.Lang.Object, global::Java.IO.ISerializable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/core/Layer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Layer); }
		}

		protected Layer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_ILorg_neuroph_util_NeuronProperties_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.core']/class[@name='Layer']/constructor[@name='Layer' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='org.neuroph.util.NeuronProperties']]"
		[Register (".ctor", "(ILorg/neuroph/util/NeuronProperties;)V", "")]
		public unsafe Layer (int p0, global::Org.Neuroph.Util.NeuronProperties p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (Layer)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(ILorg/neuroph/util/NeuronProperties;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(ILorg/neuroph/util/NeuronProperties;)V", __args);
					return;
				}

				if (id_ctor_ILorg_neuroph_util_NeuronProperties_ == IntPtr.Zero)
					id_ctor_ILorg_neuroph_util_NeuronProperties_ = JNIEnv.GetMethodID (class_ref, "<init>", "(ILorg/neuroph/util/NeuronProperties;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_ILorg_neuroph_util_NeuronProperties_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_ILorg_neuroph_util_NeuronProperties_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.core']/class[@name='Layer']/constructor[@name='Layer' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Layer ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Layer)) {
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

		static IntPtr id_ctor_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.core']/class[@name='Layer']/constructor[@name='Layer' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe Layer (int p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (Layer)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(I)V", __args);
					return;
				}

				if (id_ctor_I == IntPtr.Zero)
					id_ctor_I = JNIEnv.GetMethodID (class_ref, "<init>", "(I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_I, __args);
			} finally {
			}
		}

		static Delegate cb_isEmpty;
#pragma warning disable 0169
		static Delegate GetIsEmptyHandler ()
		{
			if (cb_isEmpty == null)
				cb_isEmpty = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsEmpty);
			return cb_isEmpty;
		}

		static bool n_IsEmpty (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Core.Layer __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Layer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsEmpty;
		}
#pragma warning restore 0169

		static IntPtr id_isEmpty;
		public virtual unsafe bool IsEmpty {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='Layer']/method[@name='isEmpty' and count(parameter)=0]"
			[Register ("isEmpty", "()Z", "GetIsEmptyHandler")]
			get {
				if (id_isEmpty == IntPtr.Zero)
					id_isEmpty = JNIEnv.GetMethodID (class_ref, "isEmpty", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isEmpty);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isEmpty", "()Z"));
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
			global::Org.Neuroph.Core.Layer __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Layer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Org.Neuroph.Core.Layer __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Layer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Label = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getLabel;
		static IntPtr id_setLabel_Ljava_lang_String_;
		public virtual unsafe string Label {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='Layer']/method[@name='getLabel' and count(parameter)=0]"
			[Register ("getLabel", "()Ljava/lang/String;", "GetGetLabelHandler")]
			get {
				if (id_getLabel == IntPtr.Zero)
					id_getLabel = JNIEnv.GetMethodID (class_ref, "getLabel", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getLabel), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLabel", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='Layer']/method[@name='setLabel' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setLabel", "(Ljava/lang/String;)V", "GetSetLabel_Ljava_lang_String_Handler")]
			set {
				if (id_setLabel_Ljava_lang_String_ == IntPtr.Zero)
					id_setLabel_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setLabel", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setLabel_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLabel", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getNeuronsCount;
#pragma warning disable 0169
		static Delegate GetGetNeuronsCountHandler ()
		{
			if (cb_getNeuronsCount == null)
				cb_getNeuronsCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNeuronsCount);
			return cb_getNeuronsCount;
		}

		static int n_GetNeuronsCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Core.Layer __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Layer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NeuronsCount;
		}
#pragma warning restore 0169

		static IntPtr id_getNeuronsCount;
		public virtual unsafe int NeuronsCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='Layer']/method[@name='getNeuronsCount' and count(parameter)=0]"
			[Register ("getNeuronsCount", "()I", "GetGetNeuronsCountHandler")]
			get {
				if (id_getNeuronsCount == IntPtr.Zero)
					id_getNeuronsCount = JNIEnv.GetMethodID (class_ref, "getNeuronsCount", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getNeuronsCount);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNeuronsCount", "()I"));
				} finally {
				}
			}
		}

		static IntPtr id_getParentNetwork;
		static IntPtr id_setParentNetwork_Lorg_neuroph_core_NeuralNetwork_;
		public unsafe global::Org.Neuroph.Core.NeuralNetwork ParentNetwork {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='Layer']/method[@name='getParentNetwork' and count(parameter)=0]"
			[Register ("getParentNetwork", "()Lorg/neuroph/core/NeuralNetwork;", "GetGetParentNetworkHandler")]
			get {
				if (id_getParentNetwork == IntPtr.Zero)
					id_getParentNetwork = JNIEnv.GetMethodID (class_ref, "getParentNetwork", "()Lorg/neuroph/core/NeuralNetwork;");
				try {
					return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.NeuralNetwork> (JNIEnv.CallObjectMethod  (Handle, id_getParentNetwork), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='Layer']/method[@name='setParentNetwork' and count(parameter)=1 and parameter[1][@type='org.neuroph.core.NeuralNetwork']]"
			[Register ("setParentNetwork", "(Lorg/neuroph/core/NeuralNetwork;)V", "GetSetParentNetwork_Lorg_neuroph_core_NeuralNetwork_Handler")]
			set {
				if (id_setParentNetwork_Lorg_neuroph_core_NeuralNetwork_ == IntPtr.Zero)
					id_setParentNetwork_Lorg_neuroph_core_NeuralNetwork_ = JNIEnv.GetMethodID (class_ref, "setParentNetwork", "(Lorg/neuroph/core/NeuralNetwork;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod  (Handle, id_setParentNetwork_Lorg_neuroph_core_NeuralNetwork_, __args);
				} finally {
				}
			}
		}

		static IntPtr id_addNeuron_ILorg_neuroph_core_Neuron_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='Layer']/method[@name='addNeuron' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='org.neuroph.core.Neuron']]"
		[Register ("addNeuron", "(ILorg/neuroph/core/Neuron;)V", "")]
		public unsafe void AddNeuron (int p0, global::Org.Neuroph.Core.Neuron p1)
		{
			if (id_addNeuron_ILorg_neuroph_core_Neuron_ == IntPtr.Zero)
				id_addNeuron_ILorg_neuroph_core_Neuron_ = JNIEnv.GetMethodID (class_ref, "addNeuron", "(ILorg/neuroph/core/Neuron;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod  (Handle, id_addNeuron_ILorg_neuroph_core_Neuron_, __args);
			} finally {
			}
		}

		static IntPtr id_addNeuron_Lorg_neuroph_core_Neuron_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='Layer']/method[@name='addNeuron' and count(parameter)=1 and parameter[1][@type='org.neuroph.core.Neuron']]"
		[Register ("addNeuron", "(Lorg/neuroph/core/Neuron;)V", "")]
		public unsafe void AddNeuron (global::Org.Neuroph.Core.Neuron p0)
		{
			if (id_addNeuron_Lorg_neuroph_core_Neuron_ == IntPtr.Zero)
				id_addNeuron_Lorg_neuroph_core_Neuron_ = JNIEnv.GetMethodID (class_ref, "addNeuron", "(Lorg/neuroph/core/Neuron;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_addNeuron_Lorg_neuroph_core_Neuron_, __args);
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
			global::Org.Neuroph.Core.Layer __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Layer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Calculate ();
		}
#pragma warning restore 0169

		static IntPtr id_calculate;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='Layer']/method[@name='calculate' and count(parameter)=0]"
		[Register ("calculate", "()V", "GetCalculateHandler")]
		public virtual unsafe void Calculate ()
		{
			if (id_calculate == IntPtr.Zero)
				id_calculate = JNIEnv.GetMethodID (class_ref, "calculate", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_calculate);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "calculate", "()V"));
			} finally {
			}
		}

		static Delegate cb_getNeuronAt_I;
#pragma warning disable 0169
		static Delegate GetGetNeuronAt_IHandler ()
		{
			if (cb_getNeuronAt_I == null)
				cb_getNeuronAt_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetNeuronAt_I);
			return cb_getNeuronAt_I;
		}

		static IntPtr n_GetNeuronAt_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Neuroph.Core.Layer __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Layer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetNeuronAt (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getNeuronAt_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='Layer']/method[@name='getNeuronAt' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getNeuronAt", "(I)Lorg/neuroph/core/Neuron;", "GetGetNeuronAt_IHandler")]
		public virtual unsafe global::Org.Neuroph.Core.Neuron GetNeuronAt (int p0)
		{
			if (id_getNeuronAt_I == IntPtr.Zero)
				id_getNeuronAt_I = JNIEnv.GetMethodID (class_ref, "getNeuronAt", "(I)Lorg/neuroph/core/Neuron;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Neuron> (JNIEnv.CallObjectMethod  (Handle, id_getNeuronAt_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Neuron> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNeuronAt", "(I)Lorg/neuroph/core/Neuron;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_getNeurons;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='Layer']/method[@name='getNeurons' and count(parameter)=0]"
		[Register ("getNeurons", "()[Lorg/neuroph/core/Neuron;", "")]
		public unsafe global::Org.Neuroph.Core.Neuron[] GetNeurons ()
		{
			if (id_getNeurons == IntPtr.Zero)
				id_getNeurons = JNIEnv.GetMethodID (class_ref, "getNeurons", "()[Lorg/neuroph/core/Neuron;");
			try {
				return (global::Org.Neuroph.Core.Neuron[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getNeurons), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Neuroph.Core.Neuron));
			} finally {
			}
		}

		static Delegate cb_indexOf_Lorg_neuroph_core_Neuron_;
#pragma warning disable 0169
		static Delegate GetIndexOf_Lorg_neuroph_core_Neuron_Handler ()
		{
			if (cb_indexOf_Lorg_neuroph_core_Neuron_ == null)
				cb_indexOf_Lorg_neuroph_core_Neuron_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_IndexOf_Lorg_neuroph_core_Neuron_);
			return cb_indexOf_Lorg_neuroph_core_Neuron_;
		}

		static int n_IndexOf_Lorg_neuroph_core_Neuron_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Core.Layer __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Layer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Core.Neuron p0 = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Neuron> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.IndexOf (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_indexOf_Lorg_neuroph_core_Neuron_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='Layer']/method[@name='indexOf' and count(parameter)=1 and parameter[1][@type='org.neuroph.core.Neuron']]"
		[Register ("indexOf", "(Lorg/neuroph/core/Neuron;)I", "GetIndexOf_Lorg_neuroph_core_Neuron_Handler")]
		public virtual unsafe int IndexOf (global::Org.Neuroph.Core.Neuron p0)
		{
			if (id_indexOf_Lorg_neuroph_core_Neuron_ == IntPtr.Zero)
				id_indexOf_Lorg_neuroph_core_Neuron_ = JNIEnv.GetMethodID (class_ref, "indexOf", "(Lorg/neuroph/core/Neuron;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod  (Handle, id_indexOf_Lorg_neuroph_core_Neuron_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "indexOf", "(Lorg/neuroph/core/Neuron;)I"), __args);
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
			global::Org.Neuroph.Core.Layer __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Layer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.InitializeWeights (p0);
		}
#pragma warning restore 0169

		static IntPtr id_initializeWeights_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='Layer']/method[@name='initializeWeights' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("initializeWeights", "(D)V", "GetInitializeWeights_DHandler")]
		public virtual unsafe void InitializeWeights (double p0)
		{
			if (id_initializeWeights_D == IntPtr.Zero)
				id_initializeWeights_D = JNIEnv.GetMethodID (class_ref, "initializeWeights", "(D)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_initializeWeights_D, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "initializeWeights", "(D)V"), __args);
			} finally {
			}
		}

		static IntPtr id_removeAllNeurons;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='Layer']/method[@name='removeAllNeurons' and count(parameter)=0]"
		[Register ("removeAllNeurons", "()V", "")]
		public unsafe void RemoveAllNeurons ()
		{
			if (id_removeAllNeurons == IntPtr.Zero)
				id_removeAllNeurons = JNIEnv.GetMethodID (class_ref, "removeAllNeurons", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_removeAllNeurons);
			} finally {
			}
		}

		static IntPtr id_removeNeuron_Lorg_neuroph_core_Neuron_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='Layer']/method[@name='removeNeuron' and count(parameter)=1 and parameter[1][@type='org.neuroph.core.Neuron']]"
		[Register ("removeNeuron", "(Lorg/neuroph/core/Neuron;)V", "")]
		public unsafe void RemoveNeuron (global::Org.Neuroph.Core.Neuron p0)
		{
			if (id_removeNeuron_Lorg_neuroph_core_Neuron_ == IntPtr.Zero)
				id_removeNeuron_Lorg_neuroph_core_Neuron_ = JNIEnv.GetMethodID (class_ref, "removeNeuron", "(Lorg/neuroph/core/Neuron;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_removeNeuron_Lorg_neuroph_core_Neuron_, __args);
			} finally {
			}
		}

		static IntPtr id_removeNeuronAt_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='Layer']/method[@name='removeNeuronAt' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("removeNeuronAt", "(I)V", "")]
		public unsafe void RemoveNeuronAt (int p0)
		{
			if (id_removeNeuronAt_I == IntPtr.Zero)
				id_removeNeuronAt_I = JNIEnv.GetMethodID (class_ref, "removeNeuronAt", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_removeNeuronAt_I, __args);
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
			global::Org.Neuroph.Core.Layer __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Layer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Reset ();
		}
#pragma warning restore 0169

		static IntPtr id_reset;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='Layer']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "GetResetHandler")]
		public virtual unsafe void Reset ()
		{
			if (id_reset == IntPtr.Zero)
				id_reset = JNIEnv.GetMethodID (class_ref, "reset", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_reset);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "reset", "()V"));
			} finally {
			}
		}

		static IntPtr id_setNeuron_ILorg_neuroph_core_Neuron_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='Layer']/method[@name='setNeuron' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='org.neuroph.core.Neuron']]"
		[Register ("setNeuron", "(ILorg/neuroph/core/Neuron;)V", "")]
		public unsafe void SetNeuron (int p0, global::Org.Neuroph.Core.Neuron p1)
		{
			if (id_setNeuron_ILorg_neuroph_core_Neuron_ == IntPtr.Zero)
				id_setNeuron_ILorg_neuroph_core_Neuron_ = JNIEnv.GetMethodID (class_ref, "setNeuron", "(ILorg/neuroph/core/Neuron;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod  (Handle, id_setNeuron_ILorg_neuroph_core_Neuron_, __args);
			} finally {
			}
		}

	}
}
