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
			global::Org.Neuroph.Core.Layer __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Layer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Org.Neuroph.Core.Neuron>.ToLocalJniHandle (__this.Neurons);
		}
#pragma warning restore 0169

		static IntPtr id_getNeurons;
		public virtual unsafe global::System.Collections.Generic.IList<global::Org.Neuroph.Core.Neuron> Neurons {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='Layer']/method[@name='getNeurons' and count(parameter)=0]"
			[Register ("getNeurons", "()Ljava/util/List;", "GetGetNeuronsHandler")]
			get {
				if (id_getNeurons == IntPtr.Zero)
					id_getNeurons = JNIEnv.GetMethodID (class_ref, "getNeurons", "()Ljava/util/List;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Org.Neuroph.Core.Neuron>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getNeurons), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Org.Neuroph.Core.Neuron>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNeurons", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
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

		static Delegate cb_getNeuronsIterator;
#pragma warning disable 0169
		static Delegate GetGetNeuronsIteratorHandler ()
		{
			if (cb_getNeuronsIterator == null)
				cb_getNeuronsIterator = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNeuronsIterator);
			return cb_getNeuronsIterator;
		}

		static IntPtr n_GetNeuronsIterator (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Core.Layer __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Layer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NeuronsIterator);
		}
#pragma warning restore 0169

		static IntPtr id_getNeuronsIterator;
		public virtual unsafe global::Java.Util.IIterator NeuronsIterator {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='Layer']/method[@name='getNeuronsIterator' and count(parameter)=0]"
			[Register ("getNeuronsIterator", "()Ljava/util/Iterator;", "GetGetNeuronsIteratorHandler")]
			get {
				if (id_getNeuronsIterator == IntPtr.Zero)
					id_getNeuronsIterator = JNIEnv.GetMethodID (class_ref, "getNeuronsIterator", "()Ljava/util/Iterator;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Util.IIterator> (JNIEnv.CallObjectMethod  (Handle, id_getNeuronsIterator), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Util.IIterator> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNeuronsIterator", "()Ljava/util/Iterator;")), JniHandleOwnership.TransferLocalRef);
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
			global::Org.Neuroph.Core.Layer __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Layer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Org.Neuroph.Core.Layer __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Layer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Core.NeuralNetwork p0 = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.NeuralNetwork> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ParentNetwork = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getParentNetwork;
		static IntPtr id_setParentNetwork_Lorg_neuroph_core_NeuralNetwork_;
		public virtual unsafe global::Org.Neuroph.Core.NeuralNetwork ParentNetwork {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='Layer']/method[@name='getParentNetwork' and count(parameter)=0]"
			[Register ("getParentNetwork", "()Lorg/neuroph/core/NeuralNetwork;", "GetGetParentNetworkHandler")]
			get {
				if (id_getParentNetwork == IntPtr.Zero)
					id_getParentNetwork = JNIEnv.GetMethodID (class_ref, "getParentNetwork", "()Lorg/neuroph/core/NeuralNetwork;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.NeuralNetwork> (JNIEnv.CallObjectMethod  (Handle, id_getParentNetwork), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.NeuralNetwork> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getParentNetwork", "()Lorg/neuroph/core/NeuralNetwork;")), JniHandleOwnership.TransferLocalRef);
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

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setParentNetwork_Lorg_neuroph_core_NeuralNetwork_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setParentNetwork", "(Lorg/neuroph/core/NeuralNetwork;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_addNeuron_ILorg_neuroph_core_Neuron_;
#pragma warning disable 0169
		static Delegate GetAddNeuron_ILorg_neuroph_core_Neuron_Handler ()
		{
			if (cb_addNeuron_ILorg_neuroph_core_Neuron_ == null)
				cb_addNeuron_ILorg_neuroph_core_Neuron_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_AddNeuron_ILorg_neuroph_core_Neuron_);
			return cb_addNeuron_ILorg_neuroph_core_Neuron_;
		}

		static void n_AddNeuron_ILorg_neuroph_core_Neuron_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Org.Neuroph.Core.Layer __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Layer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Core.Neuron p1 = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Neuron> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.AddNeuron (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_addNeuron_ILorg_neuroph_core_Neuron_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='Layer']/method[@name='addNeuron' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='org.neuroph.core.Neuron']]"
		[Register ("addNeuron", "(ILorg/neuroph/core/Neuron;)V", "GetAddNeuron_ILorg_neuroph_core_Neuron_Handler")]
		public virtual unsafe void AddNeuron (int p0, global::Org.Neuroph.Core.Neuron p1)
		{
			if (id_addNeuron_ILorg_neuroph_core_Neuron_ == IntPtr.Zero)
				id_addNeuron_ILorg_neuroph_core_Neuron_ = JNIEnv.GetMethodID (class_ref, "addNeuron", "(ILorg/neuroph/core/Neuron;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_addNeuron_ILorg_neuroph_core_Neuron_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addNeuron", "(ILorg/neuroph/core/Neuron;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_addNeuron_Lorg_neuroph_core_Neuron_;
#pragma warning disable 0169
		static Delegate GetAddNeuron_Lorg_neuroph_core_Neuron_Handler ()
		{
			if (cb_addNeuron_Lorg_neuroph_core_Neuron_ == null)
				cb_addNeuron_Lorg_neuroph_core_Neuron_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddNeuron_Lorg_neuroph_core_Neuron_);
			return cb_addNeuron_Lorg_neuroph_core_Neuron_;
		}

		static void n_AddNeuron_Lorg_neuroph_core_Neuron_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Core.Layer __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Layer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Core.Neuron p0 = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Neuron> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddNeuron (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addNeuron_Lorg_neuroph_core_Neuron_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='Layer']/method[@name='addNeuron' and count(parameter)=1 and parameter[1][@type='org.neuroph.core.Neuron']]"
		[Register ("addNeuron", "(Lorg/neuroph/core/Neuron;)V", "GetAddNeuron_Lorg_neuroph_core_Neuron_Handler")]
		public virtual unsafe void AddNeuron (global::Org.Neuroph.Core.Neuron p0)
		{
			if (id_addNeuron_Lorg_neuroph_core_Neuron_ == IntPtr.Zero)
				id_addNeuron_Lorg_neuroph_core_Neuron_ = JNIEnv.GetMethodID (class_ref, "addNeuron", "(Lorg/neuroph/core/Neuron;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_addNeuron_Lorg_neuroph_core_Neuron_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addNeuron", "(Lorg/neuroph/core/Neuron;)V"), __args);
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

		static Delegate cb_initializeWeights_DD;
#pragma warning disable 0169
		static Delegate GetInitializeWeights_DDHandler ()
		{
			if (cb_initializeWeights_DD == null)
				cb_initializeWeights_DD = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double, double>) n_InitializeWeights_DD);
			return cb_initializeWeights_DD;
		}

		static void n_InitializeWeights_DD (IntPtr jnienv, IntPtr native__this, double p0, double p1)
		{
			global::Org.Neuroph.Core.Layer __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Layer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.InitializeWeights (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_initializeWeights_DD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='Layer']/method[@name='initializeWeights' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='double']]"
		[Register ("initializeWeights", "(DD)V", "GetInitializeWeights_DDHandler")]
		public virtual unsafe void InitializeWeights (double p0, double p1)
		{
			if (id_initializeWeights_DD == IntPtr.Zero)
				id_initializeWeights_DD = JNIEnv.GetMethodID (class_ref, "initializeWeights", "(DD)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_initializeWeights_DD, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "initializeWeights", "(DD)V"), __args);
			} finally {
			}
		}

		static Delegate cb_initializeWeights_Ljava_util_Random_;
#pragma warning disable 0169
		static Delegate GetInitializeWeights_Ljava_util_Random_Handler ()
		{
			if (cb_initializeWeights_Ljava_util_Random_ == null)
				cb_initializeWeights_Ljava_util_Random_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_InitializeWeights_Ljava_util_Random_);
			return cb_initializeWeights_Ljava_util_Random_;
		}

		static void n_InitializeWeights_Ljava_util_Random_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Core.Layer __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Layer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Random p0 = global::Java.Lang.Object.GetObject<global::Java.Util.Random> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.InitializeWeights (p0);
		}
#pragma warning restore 0169

		static IntPtr id_initializeWeights_Ljava_util_Random_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='Layer']/method[@name='initializeWeights' and count(parameter)=1 and parameter[1][@type='java.util.Random']]"
		[Register ("initializeWeights", "(Ljava/util/Random;)V", "GetInitializeWeights_Ljava_util_Random_Handler")]
		public virtual unsafe void InitializeWeights (global::Java.Util.Random p0)
		{
			if (id_initializeWeights_Ljava_util_Random_ == IntPtr.Zero)
				id_initializeWeights_Ljava_util_Random_ = JNIEnv.GetMethodID (class_ref, "initializeWeights", "(Ljava/util/Random;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_initializeWeights_Ljava_util_Random_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "initializeWeights", "(Ljava/util/Random;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_randomizeWeights;
#pragma warning disable 0169
		static Delegate GetRandomizeWeightsHandler ()
		{
			if (cb_randomizeWeights == null)
				cb_randomizeWeights = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RandomizeWeights);
			return cb_randomizeWeights;
		}

		static void n_RandomizeWeights (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Core.Layer __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Layer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RandomizeWeights ();
		}
#pragma warning restore 0169

		static IntPtr id_randomizeWeights;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='Layer']/method[@name='randomizeWeights' and count(parameter)=0]"
		[Register ("randomizeWeights", "()V", "GetRandomizeWeightsHandler")]
		public virtual unsafe void RandomizeWeights ()
		{
			if (id_randomizeWeights == IntPtr.Zero)
				id_randomizeWeights = JNIEnv.GetMethodID (class_ref, "randomizeWeights", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_randomizeWeights);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "randomizeWeights", "()V"));
			} finally {
			}
		}

		static Delegate cb_randomizeWeights_DD;
#pragma warning disable 0169
		static Delegate GetRandomizeWeights_DDHandler ()
		{
			if (cb_randomizeWeights_DD == null)
				cb_randomizeWeights_DD = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double, double>) n_RandomizeWeights_DD);
			return cb_randomizeWeights_DD;
		}

		static void n_RandomizeWeights_DD (IntPtr jnienv, IntPtr native__this, double p0, double p1)
		{
			global::Org.Neuroph.Core.Layer __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Layer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RandomizeWeights (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_randomizeWeights_DD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='Layer']/method[@name='randomizeWeights' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='double']]"
		[Register ("randomizeWeights", "(DD)V", "GetRandomizeWeights_DDHandler")]
		public virtual unsafe void RandomizeWeights (double p0, double p1)
		{
			if (id_randomizeWeights_DD == IntPtr.Zero)
				id_randomizeWeights_DD = JNIEnv.GetMethodID (class_ref, "randomizeWeights", "(DD)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_randomizeWeights_DD, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "randomizeWeights", "(DD)V"), __args);
			} finally {
			}
		}

		static Delegate cb_removeNeuron_Lorg_neuroph_core_Neuron_;
#pragma warning disable 0169
		static Delegate GetRemoveNeuron_Lorg_neuroph_core_Neuron_Handler ()
		{
			if (cb_removeNeuron_Lorg_neuroph_core_Neuron_ == null)
				cb_removeNeuron_Lorg_neuroph_core_Neuron_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveNeuron_Lorg_neuroph_core_Neuron_);
			return cb_removeNeuron_Lorg_neuroph_core_Neuron_;
		}

		static void n_RemoveNeuron_Lorg_neuroph_core_Neuron_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Core.Layer __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Layer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Core.Neuron p0 = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Neuron> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveNeuron (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeNeuron_Lorg_neuroph_core_Neuron_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='Layer']/method[@name='removeNeuron' and count(parameter)=1 and parameter[1][@type='org.neuroph.core.Neuron']]"
		[Register ("removeNeuron", "(Lorg/neuroph/core/Neuron;)V", "GetRemoveNeuron_Lorg_neuroph_core_Neuron_Handler")]
		public virtual unsafe void RemoveNeuron (global::Org.Neuroph.Core.Neuron p0)
		{
			if (id_removeNeuron_Lorg_neuroph_core_Neuron_ == IntPtr.Zero)
				id_removeNeuron_Lorg_neuroph_core_Neuron_ = JNIEnv.GetMethodID (class_ref, "removeNeuron", "(Lorg/neuroph/core/Neuron;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_removeNeuron_Lorg_neuroph_core_Neuron_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeNeuron", "(Lorg/neuroph/core/Neuron;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_removeNeuronAt_I;
#pragma warning disable 0169
		static Delegate GetRemoveNeuronAt_IHandler ()
		{
			if (cb_removeNeuronAt_I == null)
				cb_removeNeuronAt_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_RemoveNeuronAt_I);
			return cb_removeNeuronAt_I;
		}

		static void n_RemoveNeuronAt_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Neuroph.Core.Layer __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Layer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveNeuronAt (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeNeuronAt_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='Layer']/method[@name='removeNeuronAt' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("removeNeuronAt", "(I)V", "GetRemoveNeuronAt_IHandler")]
		public virtual unsafe void RemoveNeuronAt (int p0)
		{
			if (id_removeNeuronAt_I == IntPtr.Zero)
				id_removeNeuronAt_I = JNIEnv.GetMethodID (class_ref, "removeNeuronAt", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_removeNeuronAt_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeNeuronAt", "(I)V"), __args);
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

		static Delegate cb_setNeuron_ILorg_neuroph_core_Neuron_;
#pragma warning disable 0169
		static Delegate GetSetNeuron_ILorg_neuroph_core_Neuron_Handler ()
		{
			if (cb_setNeuron_ILorg_neuroph_core_Neuron_ == null)
				cb_setNeuron_ILorg_neuroph_core_Neuron_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_SetNeuron_ILorg_neuroph_core_Neuron_);
			return cb_setNeuron_ILorg_neuroph_core_Neuron_;
		}

		static void n_SetNeuron_ILorg_neuroph_core_Neuron_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Org.Neuroph.Core.Layer __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Layer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Core.Neuron p1 = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Neuron> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetNeuron (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setNeuron_ILorg_neuroph_core_Neuron_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='Layer']/method[@name='setNeuron' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='org.neuroph.core.Neuron']]"
		[Register ("setNeuron", "(ILorg/neuroph/core/Neuron;)V", "GetSetNeuron_ILorg_neuroph_core_Neuron_Handler")]
		public virtual unsafe void SetNeuron (int p0, global::Org.Neuroph.Core.Neuron p1)
		{
			if (id_setNeuron_ILorg_neuroph_core_Neuron_ == IntPtr.Zero)
				id_setNeuron_ILorg_neuroph_core_Neuron_ = JNIEnv.GetMethodID (class_ref, "setNeuron", "(ILorg/neuroph/core/Neuron;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setNeuron_ILorg_neuroph_core_Neuron_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNeuron", "(ILorg/neuroph/core/Neuron;)V"), __args);
			} finally {
			}
		}

	}
}
