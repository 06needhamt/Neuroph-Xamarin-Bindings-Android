using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.core']/class[@name='NeuralNetwork']"
	[global::Android.Runtime.Register ("org/neuroph/core/NeuralNetwork", DoNotGenerateAcw=true)]
	public partial class NeuralNetwork : global::Java.Util.Observable, global::Java.IO.ISerializable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/core/NeuralNetwork", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NeuralNetwork); }
		}

		protected NeuralNetwork (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.core']/class[@name='NeuralNetwork']/constructor[@name='NeuralNetwork' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe NeuralNetwork ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (NeuralNetwork)) {
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

		static Delegate cb_getInputNeurons;
#pragma warning disable 0169
		static Delegate GetGetInputNeuronsHandler ()
		{
			if (cb_getInputNeurons == null)
				cb_getInputNeurons = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetInputNeurons);
			return cb_getInputNeurons;
		}

		static IntPtr n_GetInputNeurons (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Core.NeuralNetwork __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.NeuralNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Org.Neuroph.Core.Neuron>.ToLocalJniHandle (__this.InputNeurons);
		}
#pragma warning restore 0169

		static Delegate cb_setInputNeurons_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetInputNeurons_Ljava_util_List_Handler ()
		{
			if (cb_setInputNeurons_Ljava_util_List_ == null)
				cb_setInputNeurons_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetInputNeurons_Ljava_util_List_);
			return cb_setInputNeurons_Ljava_util_List_;
		}

		static void n_SetInputNeurons_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Core.NeuralNetwork __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.NeuralNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Org.Neuroph.Core.Neuron>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.InputNeurons = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getInputNeurons;
		static IntPtr id_setInputNeurons_Ljava_util_List_;
		public virtual unsafe global::System.Collections.Generic.IList<global::Org.Neuroph.Core.Neuron> InputNeurons {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='NeuralNetwork']/method[@name='getInputNeurons' and count(parameter)=0]"
			[Register ("getInputNeurons", "()Ljava/util/List;", "GetGetInputNeuronsHandler")]
			get {
				if (id_getInputNeurons == IntPtr.Zero)
					id_getInputNeurons = JNIEnv.GetMethodID (class_ref, "getInputNeurons", "()Ljava/util/List;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Org.Neuroph.Core.Neuron>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getInputNeurons), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Org.Neuroph.Core.Neuron>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getInputNeurons", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='NeuralNetwork']/method[@name='setInputNeurons' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;org.neuroph.core.Neuron&gt;']]"
			[Register ("setInputNeurons", "(Ljava/util/List;)V", "GetSetInputNeurons_Ljava_util_List_Handler")]
			set {
				if (id_setInputNeurons_Ljava_util_List_ == IntPtr.Zero)
					id_setInputNeurons_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setInputNeurons", "(Ljava/util/List;)V");
				IntPtr native_value = global::Android.Runtime.JavaList<global::Org.Neuroph.Core.Neuron>.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setInputNeurons_Ljava_util_List_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setInputNeurons", "(Ljava/util/List;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
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
			global::Org.Neuroph.Core.NeuralNetwork __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.NeuralNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Org.Neuroph.Core.NeuralNetwork __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.NeuralNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Label = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getLabel;
		static IntPtr id_setLabel_Ljava_lang_String_;
		public virtual unsafe string Label {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='NeuralNetwork']/method[@name='getLabel' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='NeuralNetwork']/method[@name='setLabel' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Org.Neuroph.Core.NeuralNetwork __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.NeuralNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Org.Neuroph.Core.Layer>.ToLocalJniHandle (__this.Layers);
		}
#pragma warning restore 0169

		static IntPtr id_getLayers;
		public virtual unsafe global::System.Collections.Generic.IList<global::Org.Neuroph.Core.Layer> Layers {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='NeuralNetwork']/method[@name='getLayers' and count(parameter)=0]"
			[Register ("getLayers", "()Ljava/util/List;", "GetGetLayersHandler")]
			get {
				if (id_getLayers == IntPtr.Zero)
					id_getLayers = JNIEnv.GetMethodID (class_ref, "getLayers", "()Ljava/util/List;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Org.Neuroph.Core.Layer>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLayers), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Org.Neuroph.Core.Layer>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLayers", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getLayersCount;
#pragma warning disable 0169
		static Delegate GetGetLayersCountHandler ()
		{
			if (cb_getLayersCount == null)
				cb_getLayersCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetLayersCount);
			return cb_getLayersCount;
		}

		static int n_GetLayersCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Core.NeuralNetwork __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.NeuralNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LayersCount;
		}
#pragma warning restore 0169

		static IntPtr id_getLayersCount;
		public virtual unsafe int LayersCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='NeuralNetwork']/method[@name='getLayersCount' and count(parameter)=0]"
			[Register ("getLayersCount", "()I", "GetGetLayersCountHandler")]
			get {
				if (id_getLayersCount == IntPtr.Zero)
					id_getLayersCount = JNIEnv.GetMethodID (class_ref, "getLayersCount", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getLayersCount);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLayersCount", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getLayersIterator;
#pragma warning disable 0169
		static Delegate GetGetLayersIteratorHandler ()
		{
			if (cb_getLayersIterator == null)
				cb_getLayersIterator = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLayersIterator);
			return cb_getLayersIterator;
		}

		static IntPtr n_GetLayersIterator (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Core.NeuralNetwork __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.NeuralNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LayersIterator);
		}
#pragma warning restore 0169

		static IntPtr id_getLayersIterator;
		public virtual unsafe global::Java.Util.IIterator LayersIterator {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='NeuralNetwork']/method[@name='getLayersIterator' and count(parameter)=0]"
			[Register ("getLayersIterator", "()Ljava/util/Iterator;", "GetGetLayersIteratorHandler")]
			get {
				if (id_getLayersIterator == IntPtr.Zero)
					id_getLayersIterator = JNIEnv.GetMethodID (class_ref, "getLayersIterator", "()Ljava/util/Iterator;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Util.IIterator> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLayersIterator), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Util.IIterator> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLayersIterator", "()Ljava/util/Iterator;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getLearningRule;
#pragma warning disable 0169
		static Delegate GetGetLearningRuleHandler ()
		{
			if (cb_getLearningRule == null)
				cb_getLearningRule = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLearningRule);
			return cb_getLearningRule;
		}

		static IntPtr n_GetLearningRule (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Core.NeuralNetwork __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.NeuralNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LearningRule);
		}
#pragma warning restore 0169

		static Delegate cb_setLearningRule_Lorg_neuroph_core_learning_LearningRule_;
#pragma warning disable 0169
		static Delegate GetSetLearningRule_Lorg_neuroph_core_learning_LearningRule_Handler ()
		{
			if (cb_setLearningRule_Lorg_neuroph_core_learning_LearningRule_ == null)
				cb_setLearningRule_Lorg_neuroph_core_learning_LearningRule_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLearningRule_Lorg_neuroph_core_learning_LearningRule_);
			return cb_setLearningRule_Lorg_neuroph_core_learning_LearningRule_;
		}

		static void n_SetLearningRule_Lorg_neuroph_core_learning_LearningRule_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Core.NeuralNetwork __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.NeuralNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Core.Learning.LearningRule p0 = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.LearningRule> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LearningRule = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getLearningRule;
		static IntPtr id_setLearningRule_Lorg_neuroph_core_learning_LearningRule_;
		public virtual unsafe global::Org.Neuroph.Core.Learning.LearningRule LearningRule {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='NeuralNetwork']/method[@name='getLearningRule' and count(parameter)=0]"
			[Register ("getLearningRule", "()Lorg/neuroph/core/learning/LearningRule;", "GetGetLearningRuleHandler")]
			get {
				if (id_getLearningRule == IntPtr.Zero)
					id_getLearningRule = JNIEnv.GetMethodID (class_ref, "getLearningRule", "()Lorg/neuroph/core/learning/LearningRule;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.LearningRule> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLearningRule), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.LearningRule> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLearningRule", "()Lorg/neuroph/core/learning/LearningRule;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='NeuralNetwork']/method[@name='setLearningRule' and count(parameter)=1 and parameter[1][@type='org.neuroph.core.learning.LearningRule']]"
			[Register ("setLearningRule", "(Lorg/neuroph/core/learning/LearningRule;)V", "GetSetLearningRule_Lorg_neuroph_core_learning_LearningRule_Handler")]
			set {
				if (id_setLearningRule_Lorg_neuroph_core_learning_LearningRule_ == IntPtr.Zero)
					id_setLearningRule_Lorg_neuroph_core_learning_LearningRule_ = JNIEnv.GetMethodID (class_ref, "setLearningRule", "(Lorg/neuroph/core/learning/LearningRule;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLearningRule_Lorg_neuroph_core_learning_LearningRule_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLearningRule", "(Lorg/neuroph/core/learning/LearningRule;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getLearningThread;
#pragma warning disable 0169
		static Delegate GetGetLearningThreadHandler ()
		{
			if (cb_getLearningThread == null)
				cb_getLearningThread = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLearningThread);
			return cb_getLearningThread;
		}

		static IntPtr n_GetLearningThread (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Core.NeuralNetwork __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.NeuralNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LearningThread);
		}
#pragma warning restore 0169

		static IntPtr id_getLearningThread;
		public virtual unsafe global::Java.Lang.Thread LearningThread {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='NeuralNetwork']/method[@name='getLearningThread' and count(parameter)=0]"
			[Register ("getLearningThread", "()Ljava/lang/Thread;", "GetGetLearningThreadHandler")]
			get {
				if (id_getLearningThread == IntPtr.Zero)
					id_getLearningThread = JNIEnv.GetMethodID (class_ref, "getLearningThread", "()Ljava/lang/Thread;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Thread> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLearningThread), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Thread> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLearningThread", "()Ljava/lang/Thread;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getNetworkType;
#pragma warning disable 0169
		static Delegate GetGetNetworkTypeHandler ()
		{
			if (cb_getNetworkType == null)
				cb_getNetworkType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNetworkType);
			return cb_getNetworkType;
		}

		static IntPtr n_GetNetworkType (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Core.NeuralNetwork __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.NeuralNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NetworkType);
		}
#pragma warning restore 0169

		static Delegate cb_setNetworkType_Lorg_neuroph_util_NeuralNetworkType_;
#pragma warning disable 0169
		static Delegate GetSetNetworkType_Lorg_neuroph_util_NeuralNetworkType_Handler ()
		{
			if (cb_setNetworkType_Lorg_neuroph_util_NeuralNetworkType_ == null)
				cb_setNetworkType_Lorg_neuroph_util_NeuralNetworkType_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetNetworkType_Lorg_neuroph_util_NeuralNetworkType_);
			return cb_setNetworkType_Lorg_neuroph_util_NeuralNetworkType_;
		}

		static void n_SetNetworkType_Lorg_neuroph_util_NeuralNetworkType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Core.NeuralNetwork __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.NeuralNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Util.NeuralNetworkType p0 = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.NeuralNetworkType> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.NetworkType = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getNetworkType;
		static IntPtr id_setNetworkType_Lorg_neuroph_util_NeuralNetworkType_;
		public virtual unsafe global::Org.Neuroph.Util.NeuralNetworkType NetworkType {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='NeuralNetwork']/method[@name='getNetworkType' and count(parameter)=0]"
			[Register ("getNetworkType", "()Lorg/neuroph/util/NeuralNetworkType;", "GetGetNetworkTypeHandler")]
			get {
				if (id_getNetworkType == IntPtr.Zero)
					id_getNetworkType = JNIEnv.GetMethodID (class_ref, "getNetworkType", "()Lorg/neuroph/util/NeuralNetworkType;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.NeuralNetworkType> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNetworkType), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.NeuralNetworkType> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNetworkType", "()Lorg/neuroph/util/NeuralNetworkType;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='NeuralNetwork']/method[@name='setNetworkType' and count(parameter)=1 and parameter[1][@type='org.neuroph.util.NeuralNetworkType']]"
			[Register ("setNetworkType", "(Lorg/neuroph/util/NeuralNetworkType;)V", "GetSetNetworkType_Lorg_neuroph_util_NeuralNetworkType_Handler")]
			set {
				if (id_setNetworkType_Lorg_neuroph_util_NeuralNetworkType_ == IntPtr.Zero)
					id_setNetworkType_Lorg_neuroph_util_NeuralNetworkType_ = JNIEnv.GetMethodID (class_ref, "setNetworkType", "(Lorg/neuroph/util/NeuralNetworkType;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setNetworkType_Lorg_neuroph_util_NeuralNetworkType_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNetworkType", "(Lorg/neuroph/util/NeuralNetworkType;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getOutputNeurons;
#pragma warning disable 0169
		static Delegate GetGetOutputNeuronsHandler ()
		{
			if (cb_getOutputNeurons == null)
				cb_getOutputNeurons = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOutputNeurons);
			return cb_getOutputNeurons;
		}

		static IntPtr n_GetOutputNeurons (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Core.NeuralNetwork __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.NeuralNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Org.Neuroph.Core.Neuron>.ToLocalJniHandle (__this.OutputNeurons);
		}
#pragma warning restore 0169

		static Delegate cb_setOutputNeurons_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetOutputNeurons_Ljava_util_List_Handler ()
		{
			if (cb_setOutputNeurons_Ljava_util_List_ == null)
				cb_setOutputNeurons_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOutputNeurons_Ljava_util_List_);
			return cb_setOutputNeurons_Ljava_util_List_;
		}

		static void n_SetOutputNeurons_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Core.NeuralNetwork __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.NeuralNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Org.Neuroph.Core.Neuron>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OutputNeurons = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getOutputNeurons;
		static IntPtr id_setOutputNeurons_Ljava_util_List_;
		public virtual unsafe global::System.Collections.Generic.IList<global::Org.Neuroph.Core.Neuron> OutputNeurons {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='NeuralNetwork']/method[@name='getOutputNeurons' and count(parameter)=0]"
			[Register ("getOutputNeurons", "()Ljava/util/List;", "GetGetOutputNeuronsHandler")]
			get {
				if (id_getOutputNeurons == IntPtr.Zero)
					id_getOutputNeurons = JNIEnv.GetMethodID (class_ref, "getOutputNeurons", "()Ljava/util/List;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Org.Neuroph.Core.Neuron>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOutputNeurons), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Org.Neuroph.Core.Neuron>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOutputNeurons", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='NeuralNetwork']/method[@name='setOutputNeurons' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;org.neuroph.core.Neuron&gt;']]"
			[Register ("setOutputNeurons", "(Ljava/util/List;)V", "GetSetOutputNeurons_Ljava_util_List_Handler")]
			set {
				if (id_setOutputNeurons_Ljava_util_List_ == IntPtr.Zero)
					id_setOutputNeurons_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setOutputNeurons", "(Ljava/util/List;)V");
				IntPtr native_value = global::Android.Runtime.JavaList<global::Org.Neuroph.Core.Neuron>.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOutputNeurons_Ljava_util_List_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOutputNeurons", "(Ljava/util/List;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_addLayer_ILorg_neuroph_core_Layer_;
#pragma warning disable 0169
		static Delegate GetAddLayer_ILorg_neuroph_core_Layer_Handler ()
		{
			if (cb_addLayer_ILorg_neuroph_core_Layer_ == null)
				cb_addLayer_ILorg_neuroph_core_Layer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_AddLayer_ILorg_neuroph_core_Layer_);
			return cb_addLayer_ILorg_neuroph_core_Layer_;
		}

		static void n_AddLayer_ILorg_neuroph_core_Layer_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Org.Neuroph.Core.NeuralNetwork __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.NeuralNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Core.Layer p1 = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Layer> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.AddLayer (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_addLayer_ILorg_neuroph_core_Layer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='NeuralNetwork']/method[@name='addLayer' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='org.neuroph.core.Layer']]"
		[Register ("addLayer", "(ILorg/neuroph/core/Layer;)V", "GetAddLayer_ILorg_neuroph_core_Layer_Handler")]
		public virtual unsafe void AddLayer (int p0, global::Org.Neuroph.Core.Layer p1)
		{
			if (id_addLayer_ILorg_neuroph_core_Layer_ == IntPtr.Zero)
				id_addLayer_ILorg_neuroph_core_Layer_ = JNIEnv.GetMethodID (class_ref, "addLayer", "(ILorg/neuroph/core/Layer;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addLayer_ILorg_neuroph_core_Layer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addLayer", "(ILorg/neuroph/core/Layer;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_addLayer_Lorg_neuroph_core_Layer_;
#pragma warning disable 0169
		static Delegate GetAddLayer_Lorg_neuroph_core_Layer_Handler ()
		{
			if (cb_addLayer_Lorg_neuroph_core_Layer_ == null)
				cb_addLayer_Lorg_neuroph_core_Layer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddLayer_Lorg_neuroph_core_Layer_);
			return cb_addLayer_Lorg_neuroph_core_Layer_;
		}

		static void n_AddLayer_Lorg_neuroph_core_Layer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Core.NeuralNetwork __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.NeuralNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Core.Layer p0 = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Layer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddLayer (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addLayer_Lorg_neuroph_core_Layer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='NeuralNetwork']/method[@name='addLayer' and count(parameter)=1 and parameter[1][@type='org.neuroph.core.Layer']]"
		[Register ("addLayer", "(Lorg/neuroph/core/Layer;)V", "GetAddLayer_Lorg_neuroph_core_Layer_Handler")]
		public virtual unsafe void AddLayer (global::Org.Neuroph.Core.Layer p0)
		{
			if (id_addLayer_Lorg_neuroph_core_Layer_ == IntPtr.Zero)
				id_addLayer_Lorg_neuroph_core_Layer_ = JNIEnv.GetMethodID (class_ref, "addLayer", "(Lorg/neuroph/core/Layer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addLayer_Lorg_neuroph_core_Layer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addLayer", "(Lorg/neuroph/core/Layer;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_addPlugin_Lorg_neuroph_util_plugins_PluginBase_;
#pragma warning disable 0169
		static Delegate GetAddPlugin_Lorg_neuroph_util_plugins_PluginBase_Handler ()
		{
			if (cb_addPlugin_Lorg_neuroph_util_plugins_PluginBase_ == null)
				cb_addPlugin_Lorg_neuroph_util_plugins_PluginBase_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddPlugin_Lorg_neuroph_util_plugins_PluginBase_);
			return cb_addPlugin_Lorg_neuroph_util_plugins_PluginBase_;
		}

		static void n_AddPlugin_Lorg_neuroph_util_plugins_PluginBase_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Core.NeuralNetwork __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.NeuralNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Util.Plugins.PluginBase p0 = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.Plugins.PluginBase> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddPlugin (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addPlugin_Lorg_neuroph_util_plugins_PluginBase_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='NeuralNetwork']/method[@name='addPlugin' and count(parameter)=1 and parameter[1][@type='org.neuroph.util.plugins.PluginBase']]"
		[Register ("addPlugin", "(Lorg/neuroph/util/plugins/PluginBase;)V", "GetAddPlugin_Lorg_neuroph_util_plugins_PluginBase_Handler")]
		public virtual unsafe void AddPlugin (global::Org.Neuroph.Util.Plugins.PluginBase p0)
		{
			if (id_addPlugin_Lorg_neuroph_util_plugins_PluginBase_ == IntPtr.Zero)
				id_addPlugin_Lorg_neuroph_util_plugins_PluginBase_ = JNIEnv.GetMethodID (class_ref, "addPlugin", "(Lorg/neuroph/util/plugins/PluginBase;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addPlugin_Lorg_neuroph_util_plugins_PluginBase_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addPlugin", "(Lorg/neuroph/util/plugins/PluginBase;)V"), __args);
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
			global::Org.Neuroph.Core.NeuralNetwork __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.NeuralNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Calculate ();
		}
#pragma warning restore 0169

		static IntPtr id_calculate;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='NeuralNetwork']/method[@name='calculate' and count(parameter)=0]"
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

		static Delegate cb_createConnection_Lorg_neuroph_core_Neuron_Lorg_neuroph_core_Neuron_D;
#pragma warning disable 0169
		static Delegate GetCreateConnection_Lorg_neuroph_core_Neuron_Lorg_neuroph_core_Neuron_DHandler ()
		{
			if (cb_createConnection_Lorg_neuroph_core_Neuron_Lorg_neuroph_core_Neuron_D == null)
				cb_createConnection_Lorg_neuroph_core_Neuron_Lorg_neuroph_core_Neuron_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, double>) n_CreateConnection_Lorg_neuroph_core_Neuron_Lorg_neuroph_core_Neuron_D);
			return cb_createConnection_Lorg_neuroph_core_Neuron_Lorg_neuroph_core_Neuron_D;
		}

		static void n_CreateConnection_Lorg_neuroph_core_Neuron_Lorg_neuroph_core_Neuron_D (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, double p2)
		{
			global::Org.Neuroph.Core.NeuralNetwork __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.NeuralNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Core.Neuron p0 = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Neuron> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Core.Neuron p1 = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Neuron> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.CreateConnection (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_createConnection_Lorg_neuroph_core_Neuron_Lorg_neuroph_core_Neuron_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='NeuralNetwork']/method[@name='createConnection' and count(parameter)=3 and parameter[1][@type='org.neuroph.core.Neuron'] and parameter[2][@type='org.neuroph.core.Neuron'] and parameter[3][@type='double']]"
		[Register ("createConnection", "(Lorg/neuroph/core/Neuron;Lorg/neuroph/core/Neuron;D)V", "GetCreateConnection_Lorg_neuroph_core_Neuron_Lorg_neuroph_core_Neuron_DHandler")]
		public virtual unsafe void CreateConnection (global::Org.Neuroph.Core.Neuron p0, global::Org.Neuroph.Core.Neuron p1, double p2)
		{
			if (id_createConnection_Lorg_neuroph_core_Neuron_Lorg_neuroph_core_Neuron_D == IntPtr.Zero)
				id_createConnection_Lorg_neuroph_core_Neuron_Lorg_neuroph_core_Neuron_D = JNIEnv.GetMethodID (class_ref, "createConnection", "(Lorg/neuroph/core/Neuron;Lorg/neuroph/core/Neuron;D)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_createConnection_Lorg_neuroph_core_Neuron_Lorg_neuroph_core_Neuron_D, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createConnection", "(Lorg/neuroph/core/Neuron;Lorg/neuroph/core/Neuron;D)V"), __args);
			} finally {
			}
		}

		static Delegate cb_getLayerAt_I;
#pragma warning disable 0169
		static Delegate GetGetLayerAt_IHandler ()
		{
			if (cb_getLayerAt_I == null)
				cb_getLayerAt_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetLayerAt_I);
			return cb_getLayerAt_I;
		}

		static IntPtr n_GetLayerAt_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Neuroph.Core.NeuralNetwork __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.NeuralNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetLayerAt (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getLayerAt_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='NeuralNetwork']/method[@name='getLayerAt' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getLayerAt", "(I)Lorg/neuroph/core/Layer;", "GetGetLayerAt_IHandler")]
		public virtual unsafe global::Org.Neuroph.Core.Layer GetLayerAt (int p0)
		{
			if (id_getLayerAt_I == IntPtr.Zero)
				id_getLayerAt_I = JNIEnv.GetMethodID (class_ref, "getLayerAt", "(I)Lorg/neuroph/core/Layer;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Layer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLayerAt_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Layer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLayerAt", "(I)Lorg/neuroph/core/Layer;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getOutput;
#pragma warning disable 0169
		static Delegate GetGetOutputHandler ()
		{
			if (cb_getOutput == null)
				cb_getOutput = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOutput);
			return cb_getOutput;
		}

		static IntPtr n_GetOutput (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Core.NeuralNetwork __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.NeuralNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetOutput ());
		}
#pragma warning restore 0169

		static IntPtr id_getOutput;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='NeuralNetwork']/method[@name='getOutput' and count(parameter)=0]"
		[Register ("getOutput", "()[D", "GetGetOutputHandler")]
		public virtual unsafe double[] GetOutput ()
		{
			if (id_getOutput == IntPtr.Zero)
				id_getOutput = JNIEnv.GetMethodID (class_ref, "getOutput", "()[D");
			try {

				if (GetType () == ThresholdType)
					return (double[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOutput), JniHandleOwnership.TransferLocalRef, typeof (double));
				else
					return (double[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOutput", "()[D")), JniHandleOwnership.TransferLocalRef, typeof (double));
			} finally {
			}
		}

		static Delegate cb_getPlugin_Ljava_lang_Class_;
#pragma warning disable 0169
		static Delegate GetGetPlugin_Ljava_lang_Class_Handler ()
		{
			if (cb_getPlugin_Ljava_lang_Class_ == null)
				cb_getPlugin_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetPlugin_Ljava_lang_Class_);
			return cb_getPlugin_Ljava_lang_Class_;
		}

		static IntPtr n_GetPlugin_Ljava_lang_Class_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Core.NeuralNetwork __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.NeuralNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetPlugin (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getPlugin_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='NeuralNetwork']/method[@name='getPlugin' and count(parameter)=1 and parameter[1][@type='java.lang.Class']]"
		[Register ("getPlugin", "(Ljava/lang/Class;)Lorg/neuroph/util/plugins/PluginBase;", "GetGetPlugin_Ljava_lang_Class_Handler")]
		public virtual unsafe global::Org.Neuroph.Util.Plugins.PluginBase GetPlugin (global::Java.Lang.Class p0)
		{
			if (id_getPlugin_Ljava_lang_Class_ == IntPtr.Zero)
				id_getPlugin_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "getPlugin", "(Ljava/lang/Class;)Lorg/neuroph/util/plugins/PluginBase;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Org.Neuroph.Util.Plugins.PluginBase __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.Plugins.PluginBase> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPlugin_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.Plugins.PluginBase> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPlugin", "(Ljava/lang/Class;)Lorg/neuroph/util/plugins/PluginBase;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_indexOf_Lorg_neuroph_core_Layer_;
#pragma warning disable 0169
		static Delegate GetIndexOf_Lorg_neuroph_core_Layer_Handler ()
		{
			if (cb_indexOf_Lorg_neuroph_core_Layer_ == null)
				cb_indexOf_Lorg_neuroph_core_Layer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_IndexOf_Lorg_neuroph_core_Layer_);
			return cb_indexOf_Lorg_neuroph_core_Layer_;
		}

		static int n_IndexOf_Lorg_neuroph_core_Layer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Core.NeuralNetwork __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.NeuralNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Core.Layer p0 = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Layer> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.IndexOf (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_indexOf_Lorg_neuroph_core_Layer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='NeuralNetwork']/method[@name='indexOf' and count(parameter)=1 and parameter[1][@type='org.neuroph.core.Layer']]"
		[Register ("indexOf", "(Lorg/neuroph/core/Layer;)I", "GetIndexOf_Lorg_neuroph_core_Layer_Handler")]
		public virtual unsafe int IndexOf (global::Org.Neuroph.Core.Layer p0)
		{
			if (id_indexOf_Lorg_neuroph_core_Layer_ == IntPtr.Zero)
				id_indexOf_Lorg_neuroph_core_Layer_ = JNIEnv.GetMethodID (class_ref, "indexOf", "(Lorg/neuroph/core/Layer;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_indexOf_Lorg_neuroph_core_Layer_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "indexOf", "(Lorg/neuroph/core/Layer;)I"), __args);
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
			global::Org.Neuroph.Core.NeuralNetwork __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.NeuralNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.InitializeWeights (p0);
		}
#pragma warning restore 0169

		static IntPtr id_initializeWeights_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='NeuralNetwork']/method[@name='initializeWeights' and count(parameter)=1 and parameter[1][@type='double']]"
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
			global::Org.Neuroph.Core.NeuralNetwork __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.NeuralNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.InitializeWeights (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_initializeWeights_DD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='NeuralNetwork']/method[@name='initializeWeights' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='double']]"
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
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_initializeWeights_DD, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "initializeWeights", "(DD)V"), __args);
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
			global::Org.Neuroph.Core.NeuralNetwork __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.NeuralNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Random p0 = global::Java.Lang.Object.GetObject<global::Java.Util.Random> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.InitializeWeights (p0);
		}
#pragma warning restore 0169

		static IntPtr id_initializeWeights_Ljava_util_Random_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='NeuralNetwork']/method[@name='initializeWeights' and count(parameter)=1 and parameter[1][@type='java.util.Random']]"
		[Register ("initializeWeights", "(Ljava/util/Random;)V", "GetInitializeWeights_Ljava_util_Random_Handler")]
		public virtual unsafe void InitializeWeights (global::Java.Util.Random p0)
		{
			if (id_initializeWeights_Ljava_util_Random_ == IntPtr.Zero)
				id_initializeWeights_Ljava_util_Random_ = JNIEnv.GetMethodID (class_ref, "initializeWeights", "(Ljava/util/Random;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_initializeWeights_Ljava_util_Random_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "initializeWeights", "(Ljava/util/Random;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_learn_Lorg_neuroph_core_learning_TrainingSet_;
#pragma warning disable 0169
		static Delegate GetLearn_Lorg_neuroph_core_learning_TrainingSet_Handler ()
		{
			if (cb_learn_Lorg_neuroph_core_learning_TrainingSet_ == null)
				cb_learn_Lorg_neuroph_core_learning_TrainingSet_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Learn_Lorg_neuroph_core_learning_TrainingSet_);
			return cb_learn_Lorg_neuroph_core_learning_TrainingSet_;
		}

		static void n_Learn_Lorg_neuroph_core_learning_TrainingSet_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Core.NeuralNetwork __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.NeuralNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Core.Learning.TrainingSet p0 = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.TrainingSet> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Learn (p0);
		}
#pragma warning restore 0169

		static IntPtr id_learn_Lorg_neuroph_core_learning_TrainingSet_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='NeuralNetwork']/method[@name='learn' and count(parameter)=1 and parameter[1][@type='org.neuroph.core.learning.TrainingSet']]"
		[Register ("learn", "(Lorg/neuroph/core/learning/TrainingSet;)V", "GetLearn_Lorg_neuroph_core_learning_TrainingSet_Handler")]
		public virtual unsafe void Learn (global::Org.Neuroph.Core.Learning.TrainingSet p0)
		{
			if (id_learn_Lorg_neuroph_core_learning_TrainingSet_ == IntPtr.Zero)
				id_learn_Lorg_neuroph_core_learning_TrainingSet_ = JNIEnv.GetMethodID (class_ref, "learn", "(Lorg/neuroph/core/learning/TrainingSet;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_learn_Lorg_neuroph_core_learning_TrainingSet_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "learn", "(Lorg/neuroph/core/learning/TrainingSet;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_learn_Lorg_neuroph_core_learning_TrainingSet_Lorg_neuroph_core_learning_LearningRule_;
#pragma warning disable 0169
		static Delegate GetLearn_Lorg_neuroph_core_learning_TrainingSet_Lorg_neuroph_core_learning_LearningRule_Handler ()
		{
			if (cb_learn_Lorg_neuroph_core_learning_TrainingSet_Lorg_neuroph_core_learning_LearningRule_ == null)
				cb_learn_Lorg_neuroph_core_learning_TrainingSet_Lorg_neuroph_core_learning_LearningRule_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Learn_Lorg_neuroph_core_learning_TrainingSet_Lorg_neuroph_core_learning_LearningRule_);
			return cb_learn_Lorg_neuroph_core_learning_TrainingSet_Lorg_neuroph_core_learning_LearningRule_;
		}

		static void n_Learn_Lorg_neuroph_core_learning_TrainingSet_Lorg_neuroph_core_learning_LearningRule_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Neuroph.Core.NeuralNetwork __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.NeuralNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Core.Learning.TrainingSet p0 = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.TrainingSet> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Core.Learning.LearningRule p1 = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.LearningRule> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Learn (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_learn_Lorg_neuroph_core_learning_TrainingSet_Lorg_neuroph_core_learning_LearningRule_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='NeuralNetwork']/method[@name='learn' and count(parameter)=2 and parameter[1][@type='org.neuroph.core.learning.TrainingSet'] and parameter[2][@type='org.neuroph.core.learning.LearningRule']]"
		[Register ("learn", "(Lorg/neuroph/core/learning/TrainingSet;Lorg/neuroph/core/learning/LearningRule;)V", "GetLearn_Lorg_neuroph_core_learning_TrainingSet_Lorg_neuroph_core_learning_LearningRule_Handler")]
		public virtual unsafe void Learn (global::Org.Neuroph.Core.Learning.TrainingSet p0, global::Org.Neuroph.Core.Learning.LearningRule p1)
		{
			if (id_learn_Lorg_neuroph_core_learning_TrainingSet_Lorg_neuroph_core_learning_LearningRule_ == IntPtr.Zero)
				id_learn_Lorg_neuroph_core_learning_TrainingSet_Lorg_neuroph_core_learning_LearningRule_ = JNIEnv.GetMethodID (class_ref, "learn", "(Lorg/neuroph/core/learning/TrainingSet;Lorg/neuroph/core/learning/LearningRule;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_learn_Lorg_neuroph_core_learning_TrainingSet_Lorg_neuroph_core_learning_LearningRule_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "learn", "(Lorg/neuroph/core/learning/TrainingSet;Lorg/neuroph/core/learning/LearningRule;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_learnInNewThread_Lorg_neuroph_core_learning_TrainingSet_;
#pragma warning disable 0169
		static Delegate GetLearnInNewThread_Lorg_neuroph_core_learning_TrainingSet_Handler ()
		{
			if (cb_learnInNewThread_Lorg_neuroph_core_learning_TrainingSet_ == null)
				cb_learnInNewThread_Lorg_neuroph_core_learning_TrainingSet_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_LearnInNewThread_Lorg_neuroph_core_learning_TrainingSet_);
			return cb_learnInNewThread_Lorg_neuroph_core_learning_TrainingSet_;
		}

		static void n_LearnInNewThread_Lorg_neuroph_core_learning_TrainingSet_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Core.NeuralNetwork __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.NeuralNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Core.Learning.TrainingSet p0 = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.TrainingSet> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LearnInNewThread (p0);
		}
#pragma warning restore 0169

		static IntPtr id_learnInNewThread_Lorg_neuroph_core_learning_TrainingSet_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='NeuralNetwork']/method[@name='learnInNewThread' and count(parameter)=1 and parameter[1][@type='org.neuroph.core.learning.TrainingSet']]"
		[Register ("learnInNewThread", "(Lorg/neuroph/core/learning/TrainingSet;)V", "GetLearnInNewThread_Lorg_neuroph_core_learning_TrainingSet_Handler")]
		public virtual unsafe void LearnInNewThread (global::Org.Neuroph.Core.Learning.TrainingSet p0)
		{
			if (id_learnInNewThread_Lorg_neuroph_core_learning_TrainingSet_ == IntPtr.Zero)
				id_learnInNewThread_Lorg_neuroph_core_learning_TrainingSet_ = JNIEnv.GetMethodID (class_ref, "learnInNewThread", "(Lorg/neuroph/core/learning/TrainingSet;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_learnInNewThread_Lorg_neuroph_core_learning_TrainingSet_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "learnInNewThread", "(Lorg/neuroph/core/learning/TrainingSet;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_learnInNewThread_Lorg_neuroph_core_learning_TrainingSet_Lorg_neuroph_core_learning_LearningRule_;
#pragma warning disable 0169
		static Delegate GetLearnInNewThread_Lorg_neuroph_core_learning_TrainingSet_Lorg_neuroph_core_learning_LearningRule_Handler ()
		{
			if (cb_learnInNewThread_Lorg_neuroph_core_learning_TrainingSet_Lorg_neuroph_core_learning_LearningRule_ == null)
				cb_learnInNewThread_Lorg_neuroph_core_learning_TrainingSet_Lorg_neuroph_core_learning_LearningRule_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_LearnInNewThread_Lorg_neuroph_core_learning_TrainingSet_Lorg_neuroph_core_learning_LearningRule_);
			return cb_learnInNewThread_Lorg_neuroph_core_learning_TrainingSet_Lorg_neuroph_core_learning_LearningRule_;
		}

		static void n_LearnInNewThread_Lorg_neuroph_core_learning_TrainingSet_Lorg_neuroph_core_learning_LearningRule_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Neuroph.Core.NeuralNetwork __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.NeuralNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Core.Learning.TrainingSet p0 = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.TrainingSet> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Core.Learning.LearningRule p1 = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.LearningRule> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.LearnInNewThread (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_learnInNewThread_Lorg_neuroph_core_learning_TrainingSet_Lorg_neuroph_core_learning_LearningRule_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='NeuralNetwork']/method[@name='learnInNewThread' and count(parameter)=2 and parameter[1][@type='org.neuroph.core.learning.TrainingSet'] and parameter[2][@type='org.neuroph.core.learning.LearningRule']]"
		[Register ("learnInNewThread", "(Lorg/neuroph/core/learning/TrainingSet;Lorg/neuroph/core/learning/LearningRule;)V", "GetLearnInNewThread_Lorg_neuroph_core_learning_TrainingSet_Lorg_neuroph_core_learning_LearningRule_Handler")]
		public virtual unsafe void LearnInNewThread (global::Org.Neuroph.Core.Learning.TrainingSet p0, global::Org.Neuroph.Core.Learning.LearningRule p1)
		{
			if (id_learnInNewThread_Lorg_neuroph_core_learning_TrainingSet_Lorg_neuroph_core_learning_LearningRule_ == IntPtr.Zero)
				id_learnInNewThread_Lorg_neuroph_core_learning_TrainingSet_Lorg_neuroph_core_learning_LearningRule_ = JNIEnv.GetMethodID (class_ref, "learnInNewThread", "(Lorg/neuroph/core/learning/TrainingSet;Lorg/neuroph/core/learning/LearningRule;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_learnInNewThread_Lorg_neuroph_core_learning_TrainingSet_Lorg_neuroph_core_learning_LearningRule_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "learnInNewThread", "(Lorg/neuroph/core/learning/TrainingSet;Lorg/neuroph/core/learning/LearningRule;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_learnInSameThread_Lorg_neuroph_core_learning_TrainingSet_;
#pragma warning disable 0169
		static Delegate GetLearnInSameThread_Lorg_neuroph_core_learning_TrainingSet_Handler ()
		{
			if (cb_learnInSameThread_Lorg_neuroph_core_learning_TrainingSet_ == null)
				cb_learnInSameThread_Lorg_neuroph_core_learning_TrainingSet_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_LearnInSameThread_Lorg_neuroph_core_learning_TrainingSet_);
			return cb_learnInSameThread_Lorg_neuroph_core_learning_TrainingSet_;
		}

		static void n_LearnInSameThread_Lorg_neuroph_core_learning_TrainingSet_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Core.NeuralNetwork __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.NeuralNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Core.Learning.TrainingSet p0 = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.TrainingSet> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LearnInSameThread (p0);
		}
#pragma warning restore 0169

		static IntPtr id_learnInSameThread_Lorg_neuroph_core_learning_TrainingSet_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='NeuralNetwork']/method[@name='learnInSameThread' and count(parameter)=1 and parameter[1][@type='org.neuroph.core.learning.TrainingSet']]"
		[Obsolete (@"deprecated")]
		[Register ("learnInSameThread", "(Lorg/neuroph/core/learning/TrainingSet;)V", "GetLearnInSameThread_Lorg_neuroph_core_learning_TrainingSet_Handler")]
		public virtual unsafe void LearnInSameThread (global::Org.Neuroph.Core.Learning.TrainingSet p0)
		{
			if (id_learnInSameThread_Lorg_neuroph_core_learning_TrainingSet_ == IntPtr.Zero)
				id_learnInSameThread_Lorg_neuroph_core_learning_TrainingSet_ = JNIEnv.GetMethodID (class_ref, "learnInSameThread", "(Lorg/neuroph/core/learning/TrainingSet;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_learnInSameThread_Lorg_neuroph_core_learning_TrainingSet_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "learnInSameThread", "(Lorg/neuroph/core/learning/TrainingSet;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_learnInSameThread_Lorg_neuroph_core_learning_TrainingSet_Lorg_neuroph_core_learning_LearningRule_;
#pragma warning disable 0169
		static Delegate GetLearnInSameThread_Lorg_neuroph_core_learning_TrainingSet_Lorg_neuroph_core_learning_LearningRule_Handler ()
		{
			if (cb_learnInSameThread_Lorg_neuroph_core_learning_TrainingSet_Lorg_neuroph_core_learning_LearningRule_ == null)
				cb_learnInSameThread_Lorg_neuroph_core_learning_TrainingSet_Lorg_neuroph_core_learning_LearningRule_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_LearnInSameThread_Lorg_neuroph_core_learning_TrainingSet_Lorg_neuroph_core_learning_LearningRule_);
			return cb_learnInSameThread_Lorg_neuroph_core_learning_TrainingSet_Lorg_neuroph_core_learning_LearningRule_;
		}

		static void n_LearnInSameThread_Lorg_neuroph_core_learning_TrainingSet_Lorg_neuroph_core_learning_LearningRule_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Neuroph.Core.NeuralNetwork __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.NeuralNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Core.Learning.TrainingSet p0 = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.TrainingSet> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Core.Learning.LearningRule p1 = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.LearningRule> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.LearnInSameThread (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_learnInSameThread_Lorg_neuroph_core_learning_TrainingSet_Lorg_neuroph_core_learning_LearningRule_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='NeuralNetwork']/method[@name='learnInSameThread' and count(parameter)=2 and parameter[1][@type='org.neuroph.core.learning.TrainingSet'] and parameter[2][@type='org.neuroph.core.learning.LearningRule']]"
		[Obsolete (@"deprecated")]
		[Register ("learnInSameThread", "(Lorg/neuroph/core/learning/TrainingSet;Lorg/neuroph/core/learning/LearningRule;)V", "GetLearnInSameThread_Lorg_neuroph_core_learning_TrainingSet_Lorg_neuroph_core_learning_LearningRule_Handler")]
		public virtual unsafe void LearnInSameThread (global::Org.Neuroph.Core.Learning.TrainingSet p0, global::Org.Neuroph.Core.Learning.LearningRule p1)
		{
			if (id_learnInSameThread_Lorg_neuroph_core_learning_TrainingSet_Lorg_neuroph_core_learning_LearningRule_ == IntPtr.Zero)
				id_learnInSameThread_Lorg_neuroph_core_learning_TrainingSet_Lorg_neuroph_core_learning_LearningRule_ = JNIEnv.GetMethodID (class_ref, "learnInSameThread", "(Lorg/neuroph/core/learning/TrainingSet;Lorg/neuroph/core/learning/LearningRule;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_learnInSameThread_Lorg_neuroph_core_learning_TrainingSet_Lorg_neuroph_core_learning_LearningRule_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "learnInSameThread", "(Lorg/neuroph/core/learning/TrainingSet;Lorg/neuroph/core/learning/LearningRule;)V"), __args);
			} finally {
			}
		}

		static IntPtr id_load_Ljava_io_InputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='NeuralNetwork']/method[@name='load' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("load", "(Ljava/io/InputStream;)Lorg/neuroph/core/NeuralNetwork;", "")]
		public static unsafe global::Org.Neuroph.Core.NeuralNetwork Load (global::System.IO.Stream p0)
		{
			if (id_load_Ljava_io_InputStream_ == IntPtr.Zero)
				id_load_Ljava_io_InputStream_ = JNIEnv.GetStaticMethodID (class_ref, "load", "(Ljava/io/InputStream;)Lorg/neuroph/core/NeuralNetwork;");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Org.Neuroph.Core.NeuralNetwork __ret = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.NeuralNetwork> (JNIEnv.CallStaticObjectMethod  (class_ref, id_load_Ljava_io_InputStream_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_load_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='NeuralNetwork']/method[@name='load' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("load", "(Ljava/lang/String;)Lorg/neuroph/core/NeuralNetwork;", "")]
		public static unsafe global::Org.Neuroph.Core.NeuralNetwork Load (string p0)
		{
			if (id_load_Ljava_lang_String_ == IntPtr.Zero)
				id_load_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "load", "(Ljava/lang/String;)Lorg/neuroph/core/NeuralNetwork;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Org.Neuroph.Core.NeuralNetwork __ret = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.NeuralNetwork> (JNIEnv.CallStaticObjectMethod  (class_ref, id_load_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_notifyChange;
#pragma warning disable 0169
		static Delegate GetNotifyChangeHandler ()
		{
			if (cb_notifyChange == null)
				cb_notifyChange = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_NotifyChange);
			return cb_notifyChange;
		}

		static void n_NotifyChange (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Core.NeuralNetwork __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.NeuralNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NotifyChange ();
		}
#pragma warning restore 0169

		static IntPtr id_notifyChange;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='NeuralNetwork']/method[@name='notifyChange' and count(parameter)=0]"
		[Register ("notifyChange", "()V", "GetNotifyChangeHandler")]
		public virtual unsafe void NotifyChange ()
		{
			if (id_notifyChange == IntPtr.Zero)
				id_notifyChange = JNIEnv.GetMethodID (class_ref, "notifyChange", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_notifyChange);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "notifyChange", "()V"));
			} finally {
			}
		}

		static Delegate cb_pauseLearning;
#pragma warning disable 0169
		static Delegate GetPauseLearningHandler ()
		{
			if (cb_pauseLearning == null)
				cb_pauseLearning = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_PauseLearning);
			return cb_pauseLearning;
		}

		static void n_PauseLearning (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Core.NeuralNetwork __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.NeuralNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PauseLearning ();
		}
#pragma warning restore 0169

		static IntPtr id_pauseLearning;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='NeuralNetwork']/method[@name='pauseLearning' and count(parameter)=0]"
		[Register ("pauseLearning", "()V", "GetPauseLearningHandler")]
		public virtual unsafe void PauseLearning ()
		{
			if (id_pauseLearning == IntPtr.Zero)
				id_pauseLearning = JNIEnv.GetMethodID (class_ref, "pauseLearning", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_pauseLearning);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "pauseLearning", "()V"));
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
			global::Org.Neuroph.Core.NeuralNetwork __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.NeuralNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RandomizeWeights ();
		}
#pragma warning restore 0169

		static IntPtr id_randomizeWeights;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='NeuralNetwork']/method[@name='randomizeWeights' and count(parameter)=0]"
		[Register ("randomizeWeights", "()V", "GetRandomizeWeightsHandler")]
		public virtual unsafe void RandomizeWeights ()
		{
			if (id_randomizeWeights == IntPtr.Zero)
				id_randomizeWeights = JNIEnv.GetMethodID (class_ref, "randomizeWeights", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_randomizeWeights);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "randomizeWeights", "()V"));
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
			global::Org.Neuroph.Core.NeuralNetwork __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.NeuralNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RandomizeWeights (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_randomizeWeights_DD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='NeuralNetwork']/method[@name='randomizeWeights' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='double']]"
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
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_randomizeWeights_DD, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "randomizeWeights", "(DD)V"), __args);
			} finally {
			}
		}

		static Delegate cb_randomizeWeights_Ljava_util_Random_;
#pragma warning disable 0169
		static Delegate GetRandomizeWeights_Ljava_util_Random_Handler ()
		{
			if (cb_randomizeWeights_Ljava_util_Random_ == null)
				cb_randomizeWeights_Ljava_util_Random_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RandomizeWeights_Ljava_util_Random_);
			return cb_randomizeWeights_Ljava_util_Random_;
		}

		static void n_RandomizeWeights_Ljava_util_Random_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Core.NeuralNetwork __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.NeuralNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Random p0 = global::Java.Lang.Object.GetObject<global::Java.Util.Random> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RandomizeWeights (p0);
		}
#pragma warning restore 0169

		static IntPtr id_randomizeWeights_Ljava_util_Random_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='NeuralNetwork']/method[@name='randomizeWeights' and count(parameter)=1 and parameter[1][@type='java.util.Random']]"
		[Register ("randomizeWeights", "(Ljava/util/Random;)V", "GetRandomizeWeights_Ljava_util_Random_Handler")]
		public virtual unsafe void RandomizeWeights (global::Java.Util.Random p0)
		{
			if (id_randomizeWeights_Ljava_util_Random_ == IntPtr.Zero)
				id_randomizeWeights_Ljava_util_Random_ = JNIEnv.GetMethodID (class_ref, "randomizeWeights", "(Ljava/util/Random;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_randomizeWeights_Ljava_util_Random_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "randomizeWeights", "(Ljava/util/Random;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_randomizeWeights_Lorg_neuroph_util_random_WeightsRandomizer_;
#pragma warning disable 0169
		static Delegate GetRandomizeWeights_Lorg_neuroph_util_random_WeightsRandomizer_Handler ()
		{
			if (cb_randomizeWeights_Lorg_neuroph_util_random_WeightsRandomizer_ == null)
				cb_randomizeWeights_Lorg_neuroph_util_random_WeightsRandomizer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RandomizeWeights_Lorg_neuroph_util_random_WeightsRandomizer_);
			return cb_randomizeWeights_Lorg_neuroph_util_random_WeightsRandomizer_;
		}

		static void n_RandomizeWeights_Lorg_neuroph_util_random_WeightsRandomizer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Core.NeuralNetwork __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.NeuralNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Util.Random.WeightsRandomizer p0 = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.Random.WeightsRandomizer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RandomizeWeights (p0);
		}
#pragma warning restore 0169

		static IntPtr id_randomizeWeights_Lorg_neuroph_util_random_WeightsRandomizer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='NeuralNetwork']/method[@name='randomizeWeights' and count(parameter)=1 and parameter[1][@type='org.neuroph.util.random.WeightsRandomizer']]"
		[Register ("randomizeWeights", "(Lorg/neuroph/util/random/WeightsRandomizer;)V", "GetRandomizeWeights_Lorg_neuroph_util_random_WeightsRandomizer_Handler")]
		public virtual unsafe void RandomizeWeights (global::Org.Neuroph.Util.Random.WeightsRandomizer p0)
		{
			if (id_randomizeWeights_Lorg_neuroph_util_random_WeightsRandomizer_ == IntPtr.Zero)
				id_randomizeWeights_Lorg_neuroph_util_random_WeightsRandomizer_ = JNIEnv.GetMethodID (class_ref, "randomizeWeights", "(Lorg/neuroph/util/random/WeightsRandomizer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_randomizeWeights_Lorg_neuroph_util_random_WeightsRandomizer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "randomizeWeights", "(Lorg/neuroph/util/random/WeightsRandomizer;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_removeLayer_Lorg_neuroph_core_Layer_;
#pragma warning disable 0169
		static Delegate GetRemoveLayer_Lorg_neuroph_core_Layer_Handler ()
		{
			if (cb_removeLayer_Lorg_neuroph_core_Layer_ == null)
				cb_removeLayer_Lorg_neuroph_core_Layer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveLayer_Lorg_neuroph_core_Layer_);
			return cb_removeLayer_Lorg_neuroph_core_Layer_;
		}

		static void n_RemoveLayer_Lorg_neuroph_core_Layer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Core.NeuralNetwork __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.NeuralNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Core.Layer p0 = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Layer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveLayer (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeLayer_Lorg_neuroph_core_Layer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='NeuralNetwork']/method[@name='removeLayer' and count(parameter)=1 and parameter[1][@type='org.neuroph.core.Layer']]"
		[Register ("removeLayer", "(Lorg/neuroph/core/Layer;)V", "GetRemoveLayer_Lorg_neuroph_core_Layer_Handler")]
		public virtual unsafe void RemoveLayer (global::Org.Neuroph.Core.Layer p0)
		{
			if (id_removeLayer_Lorg_neuroph_core_Layer_ == IntPtr.Zero)
				id_removeLayer_Lorg_neuroph_core_Layer_ = JNIEnv.GetMethodID (class_ref, "removeLayer", "(Lorg/neuroph/core/Layer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeLayer_Lorg_neuroph_core_Layer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeLayer", "(Lorg/neuroph/core/Layer;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_removeLayerAt_I;
#pragma warning disable 0169
		static Delegate GetRemoveLayerAt_IHandler ()
		{
			if (cb_removeLayerAt_I == null)
				cb_removeLayerAt_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_RemoveLayerAt_I);
			return cb_removeLayerAt_I;
		}

		static void n_RemoveLayerAt_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Neuroph.Core.NeuralNetwork __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.NeuralNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveLayerAt (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeLayerAt_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='NeuralNetwork']/method[@name='removeLayerAt' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("removeLayerAt", "(I)V", "GetRemoveLayerAt_IHandler")]
		public virtual unsafe void RemoveLayerAt (int p0)
		{
			if (id_removeLayerAt_I == IntPtr.Zero)
				id_removeLayerAt_I = JNIEnv.GetMethodID (class_ref, "removeLayerAt", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeLayerAt_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeLayerAt", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_removePlugin_Ljava_lang_Class_;
#pragma warning disable 0169
		static Delegate GetRemovePlugin_Ljava_lang_Class_Handler ()
		{
			if (cb_removePlugin_Ljava_lang_Class_ == null)
				cb_removePlugin_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemovePlugin_Ljava_lang_Class_);
			return cb_removePlugin_Ljava_lang_Class_;
		}

		static void n_RemovePlugin_Ljava_lang_Class_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Core.NeuralNetwork __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.NeuralNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemovePlugin (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removePlugin_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='NeuralNetwork']/method[@name='removePlugin' and count(parameter)=1 and parameter[1][@type='java.lang.Class']]"
		[Register ("removePlugin", "(Ljava/lang/Class;)V", "GetRemovePlugin_Ljava_lang_Class_Handler")]
		public virtual unsafe void RemovePlugin (global::Java.Lang.Class p0)
		{
			if (id_removePlugin_Ljava_lang_Class_ == IntPtr.Zero)
				id_removePlugin_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "removePlugin", "(Ljava/lang/Class;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removePlugin_Ljava_lang_Class_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removePlugin", "(Ljava/lang/Class;)V"), __args);
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
			global::Org.Neuroph.Core.NeuralNetwork __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.NeuralNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Reset ();
		}
#pragma warning restore 0169

		static IntPtr id_reset;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='NeuralNetwork']/method[@name='reset' and count(parameter)=0]"
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

		static Delegate cb_resumeLearning;
#pragma warning disable 0169
		static Delegate GetResumeLearningHandler ()
		{
			if (cb_resumeLearning == null)
				cb_resumeLearning = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ResumeLearning);
			return cb_resumeLearning;
		}

		static void n_ResumeLearning (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Core.NeuralNetwork __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.NeuralNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ResumeLearning ();
		}
#pragma warning restore 0169

		static IntPtr id_resumeLearning;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='NeuralNetwork']/method[@name='resumeLearning' and count(parameter)=0]"
		[Register ("resumeLearning", "()V", "GetResumeLearningHandler")]
		public virtual unsafe void ResumeLearning ()
		{
			if (id_resumeLearning == IntPtr.Zero)
				id_resumeLearning = JNIEnv.GetMethodID (class_ref, "resumeLearning", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_resumeLearning);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "resumeLearning", "()V"));
			} finally {
			}
		}

		static Delegate cb_save_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSave_Ljava_lang_String_Handler ()
		{
			if (cb_save_Ljava_lang_String_ == null)
				cb_save_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Save_Ljava_lang_String_);
			return cb_save_Ljava_lang_String_;
		}

		static void n_Save_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Core.NeuralNetwork __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.NeuralNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Save (p0);
		}
#pragma warning restore 0169

		static IntPtr id_save_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='NeuralNetwork']/method[@name='save' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("save", "(Ljava/lang/String;)V", "GetSave_Ljava_lang_String_Handler")]
		public virtual unsafe void Save (string p0)
		{
			if (id_save_Ljava_lang_String_ == IntPtr.Zero)
				id_save_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "save", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_save_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "save", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setInput_arrayD;
#pragma warning disable 0169
		static Delegate GetSetInput_arrayDHandler ()
		{
			if (cb_setInput_arrayD == null)
				cb_setInput_arrayD = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetInput_arrayD);
			return cb_setInput_arrayD;
		}

		static void n_SetInput_arrayD (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Core.NeuralNetwork __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.NeuralNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			double[] p0 = (double[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (double));
			__this.SetInput (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_setInput_arrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='NeuralNetwork']/method[@name='setInput' and count(parameter)=1 and parameter[1][@type='double...']]"
		[Register ("setInput", "([D)V", "GetSetInput_arrayDHandler")]
		public virtual unsafe void SetInput (params  double[] p0)
		{
			if (id_setInput_arrayD == IntPtr.Zero)
				id_setInput_arrayD = JNIEnv.GetMethodID (class_ref, "setInput", "([D)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setInput_arrayD, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setInput", "([D)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_stopLearning;
#pragma warning disable 0169
		static Delegate GetStopLearningHandler ()
		{
			if (cb_stopLearning == null)
				cb_stopLearning = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StopLearning);
			return cb_stopLearning;
		}

		static void n_StopLearning (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Core.NeuralNetwork __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.NeuralNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopLearning ();
		}
#pragma warning restore 0169

		static IntPtr id_stopLearning;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='NeuralNetwork']/method[@name='stopLearning' and count(parameter)=0]"
		[Register ("stopLearning", "()V", "GetStopLearningHandler")]
		public virtual unsafe void StopLearning ()
		{
			if (id_stopLearning == IntPtr.Zero)
				id_stopLearning = JNIEnv.GetMethodID (class_ref, "stopLearning", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stopLearning);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stopLearning", "()V"));
			} finally {
			}
		}

	}
}
