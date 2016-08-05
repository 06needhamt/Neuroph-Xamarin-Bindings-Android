using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.core']/class[@name='NeuralNetwork']"
	[global::Android.Runtime.Register ("org/neuroph/core/NeuralNetwork", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"L extends org.neuroph.core.learning.LearningRule"})]
	public partial class NeuralNetwork : global::Java.Lang.Object, global::Java.IO.ISerializable {


		static IntPtr output_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.neuroph.core']/class[@name='NeuralNetwork']/field[@name='output']"
		[Register ("output")]
		protected IList<double> Output {
			get {
				if (output_jfieldId == IntPtr.Zero)
					output_jfieldId = JNIEnv.GetFieldID (class_ref, "output", "[D");
				return JavaArray<double>.FromJniHandle (JNIEnv.GetObjectField (Handle, output_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (output_jfieldId == IntPtr.Zero)
					output_jfieldId = JNIEnv.GetFieldID (class_ref, "output", "[D");
				IntPtr native_value = JavaArray<double>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, output_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
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
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (NeuralNetwork)) {
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

		static Delegate cb_getInputsCount;
#pragma warning disable 0169
		static Delegate GetGetInputsCountHandler ()
		{
			if (cb_getInputsCount == null)
				cb_getInputsCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetInputsCount);
			return cb_getInputsCount;
		}

		static int n_GetInputsCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Core.NeuralNetwork __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.NeuralNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.InputsCount;
		}
#pragma warning restore 0169

		static IntPtr id_getInputsCount;
		public virtual unsafe int InputsCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='NeuralNetwork']/method[@name='getInputsCount' and count(parameter)=0]"
			[Register ("getInputsCount", "()I", "GetGetInputsCountHandler")]
			get {
				if (id_getInputsCount == IntPtr.Zero)
					id_getInputsCount = JNIEnv.GetMethodID (class_ref, "getInputsCount", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getInputsCount);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getInputsCount", "()I"));
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
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getLabel), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLabel", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
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
						JNIEnv.CallVoidMethod  (Handle, id_setLabel_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLabel", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
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
						return JNIEnv.CallIntMethod  (Handle, id_getLayersCount);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLayersCount", "()I"));
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
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LearningRule = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getLearningRule;
		static IntPtr id_setLearningRule_Lorg_neuroph_core_learning_LearningRule_;
		public virtual unsafe global::Java.Lang.Object LearningRule {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='NeuralNetwork']/method[@name='getLearningRule' and count(parameter)=0]"
			[Register ("getLearningRule", "()Lorg/neuroph/core/learning/LearningRule;", "GetGetLearningRuleHandler")]
			get {
				if (id_getLearningRule == IntPtr.Zero)
					id_getLearningRule = JNIEnv.GetMethodID (class_ref, "getLearningRule", "()Lorg/neuroph/core/learning/LearningRule;");
				try {

					if (GetType () == ThresholdType)
						return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_getLearningRule), JniHandleOwnership.TransferLocalRef);
					else
						return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLearningRule", "()Lorg/neuroph/core/learning/LearningRule;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='NeuralNetwork']/method[@name='setLearningRule' and count(parameter)=1 and parameter[1][@type='L']]"
			[Register ("setLearningRule", "(Lorg/neuroph/core/learning/LearningRule;)V", "GetSetLearningRule_Lorg_neuroph_core_learning_LearningRule_Handler")]
			set {
				if (id_setLearningRule_Lorg_neuroph_core_learning_LearningRule_ == IntPtr.Zero)
					id_setLearningRule_Lorg_neuroph_core_learning_LearningRule_ = JNIEnv.GetMethodID (class_ref, "setLearningRule", "(Lorg/neuroph/core/learning/LearningRule;)V");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setLearningRule_Lorg_neuroph_core_learning_LearningRule_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLearningRule", "(Lorg/neuroph/core/learning/LearningRule;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
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
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Thread> (JNIEnv.CallObjectMethod  (Handle, id_getLearningThread), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Thread> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLearningThread", "()Ljava/lang/Thread;")), JniHandleOwnership.TransferLocalRef);
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
						return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.NeuralNetworkType> (JNIEnv.CallObjectMethod  (Handle, id_getNetworkType), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.NeuralNetworkType> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNetworkType", "()Lorg/neuroph/util/NeuralNetworkType;")), JniHandleOwnership.TransferLocalRef);
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
						JNIEnv.CallVoidMethod  (Handle, id_setNetworkType_Lorg_neuroph_util_NeuralNetworkType_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNetworkType", "(Lorg/neuroph/util/NeuralNetworkType;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getOutputsCount;
#pragma warning disable 0169
		static Delegate GetGetOutputsCountHandler ()
		{
			if (cb_getOutputsCount == null)
				cb_getOutputsCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetOutputsCount);
			return cb_getOutputsCount;
		}

		static int n_GetOutputsCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Core.NeuralNetwork __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.NeuralNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.OutputsCount;
		}
#pragma warning restore 0169

		static IntPtr id_getOutputsCount;
		public virtual unsafe int OutputsCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='NeuralNetwork']/method[@name='getOutputsCount' and count(parameter)=0]"
			[Register ("getOutputsCount", "()I", "GetGetOutputsCountHandler")]
			get {
				if (id_getOutputsCount == IntPtr.Zero)
					id_getOutputsCount = JNIEnv.GetMethodID (class_ref, "getOutputsCount", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getOutputsCount);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOutputsCount", "()I"));
				} finally {
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
					JNIEnv.CallVoidMethod  (Handle, id_addLayer_ILorg_neuroph_core_Layer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addLayer", "(ILorg/neuroph/core/Layer;)V"), __args);
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
					JNIEnv.CallVoidMethod  (Handle, id_addLayer_Lorg_neuroph_core_Layer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addLayer", "(Lorg/neuroph/core/Layer;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_addListener_Lorg_neuroph_core_events_NeuralNetworkEventListener_;
#pragma warning disable 0169
		static Delegate GetAddListener_Lorg_neuroph_core_events_NeuralNetworkEventListener_Handler ()
		{
			if (cb_addListener_Lorg_neuroph_core_events_NeuralNetworkEventListener_ == null)
				cb_addListener_Lorg_neuroph_core_events_NeuralNetworkEventListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddListener_Lorg_neuroph_core_events_NeuralNetworkEventListener_);
			return cb_addListener_Lorg_neuroph_core_events_NeuralNetworkEventListener_;
		}

		static void n_AddListener_Lorg_neuroph_core_events_NeuralNetworkEventListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Core.NeuralNetwork __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.NeuralNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Core.Events.INeuralNetworkEventListener p0 = (global::Org.Neuroph.Core.Events.INeuralNetworkEventListener)global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Events.INeuralNetworkEventListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addListener_Lorg_neuroph_core_events_NeuralNetworkEventListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='NeuralNetwork']/method[@name='addListener' and count(parameter)=1 and parameter[1][@type='org.neuroph.core.events.NeuralNetworkEventListener']]"
		[Register ("addListener", "(Lorg/neuroph/core/events/NeuralNetworkEventListener;)V", "GetAddListener_Lorg_neuroph_core_events_NeuralNetworkEventListener_Handler")]
		public virtual unsafe void AddListener (global::Org.Neuroph.Core.Events.INeuralNetworkEventListener p0)
		{
			if (id_addListener_Lorg_neuroph_core_events_NeuralNetworkEventListener_ == IntPtr.Zero)
				id_addListener_Lorg_neuroph_core_events_NeuralNetworkEventListener_ = JNIEnv.GetMethodID (class_ref, "addListener", "(Lorg/neuroph/core/events/NeuralNetworkEventListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_addListener_Lorg_neuroph_core_events_NeuralNetworkEventListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addListener", "(Lorg/neuroph/core/events/NeuralNetworkEventListener;)V"), __args);
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
					JNIEnv.CallVoidMethod  (Handle, id_addPlugin_Lorg_neuroph_util_plugins_PluginBase_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addPlugin", "(Lorg/neuroph/util/plugins/PluginBase;)V"), __args);
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
					JNIEnv.CallVoidMethod  (Handle, id_calculate);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "calculate", "()V"));
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
					JNIEnv.CallVoidMethod  (Handle, id_createConnection_Lorg_neuroph_core_Neuron_Lorg_neuroph_core_Neuron_D, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createConnection", "(Lorg/neuroph/core/Neuron;Lorg/neuroph/core/Neuron;D)V"), __args);
			} finally {
			}
		}

		static IntPtr id_createFromFile_Ljava_io_File_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='NeuralNetwork']/method[@name='createFromFile' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("createFromFile", "(Ljava/io/File;)Lorg/neuroph/core/NeuralNetwork;", "")]
		public static unsafe global::Org.Neuroph.Core.NeuralNetwork CreateFromFile (global::Java.IO.File p0)
		{
			if (id_createFromFile_Ljava_io_File_ == IntPtr.Zero)
				id_createFromFile_Ljava_io_File_ = JNIEnv.GetStaticMethodID (class_ref, "createFromFile", "(Ljava/io/File;)Lorg/neuroph/core/NeuralNetwork;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Org.Neuroph.Core.NeuralNetwork __ret = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.NeuralNetwork> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createFromFile_Ljava_io_File_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_createFromFile_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='NeuralNetwork']/method[@name='createFromFile' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("createFromFile", "(Ljava/lang/String;)Lorg/neuroph/core/NeuralNetwork;", "")]
		public static unsafe global::Org.Neuroph.Core.NeuralNetwork CreateFromFile (string p0)
		{
			if (id_createFromFile_Ljava_lang_String_ == IntPtr.Zero)
				id_createFromFile_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "createFromFile", "(Ljava/lang/String;)Lorg/neuroph/core/NeuralNetwork;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Org.Neuroph.Core.NeuralNetwork __ret = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.NeuralNetwork> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createFromFile_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_fireNetworkEvent_Lorg_neuroph_core_events_NeuralNetworkEvent_;
#pragma warning disable 0169
		static Delegate GetFireNetworkEvent_Lorg_neuroph_core_events_NeuralNetworkEvent_Handler ()
		{
			if (cb_fireNetworkEvent_Lorg_neuroph_core_events_NeuralNetworkEvent_ == null)
				cb_fireNetworkEvent_Lorg_neuroph_core_events_NeuralNetworkEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_FireNetworkEvent_Lorg_neuroph_core_events_NeuralNetworkEvent_);
			return cb_fireNetworkEvent_Lorg_neuroph_core_events_NeuralNetworkEvent_;
		}

		static void n_FireNetworkEvent_Lorg_neuroph_core_events_NeuralNetworkEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Core.NeuralNetwork __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.NeuralNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Core.Events.NeuralNetworkEvent p0 = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Events.NeuralNetworkEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.FireNetworkEvent (p0);
		}
#pragma warning restore 0169

		static IntPtr id_fireNetworkEvent_Lorg_neuroph_core_events_NeuralNetworkEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='NeuralNetwork']/method[@name='fireNetworkEvent' and count(parameter)=1 and parameter[1][@type='org.neuroph.core.events.NeuralNetworkEvent']]"
		[Register ("fireNetworkEvent", "(Lorg/neuroph/core/events/NeuralNetworkEvent;)V", "GetFireNetworkEvent_Lorg_neuroph_core_events_NeuralNetworkEvent_Handler")]
		protected virtual unsafe void FireNetworkEvent (global::Org.Neuroph.Core.Events.NeuralNetworkEvent p0)
		{
			if (id_fireNetworkEvent_Lorg_neuroph_core_events_NeuralNetworkEvent_ == IntPtr.Zero)
				id_fireNetworkEvent_Lorg_neuroph_core_events_NeuralNetworkEvent_ = JNIEnv.GetMethodID (class_ref, "fireNetworkEvent", "(Lorg/neuroph/core/events/NeuralNetworkEvent;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_fireNetworkEvent_Lorg_neuroph_core_events_NeuralNetworkEvent_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "fireNetworkEvent", "(Lorg/neuroph/core/events/NeuralNetworkEvent;)V"), __args);
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
			return JNIEnv.NewArray (__this.GetInputNeurons ());
		}
#pragma warning restore 0169

		static IntPtr id_getInputNeurons;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='NeuralNetwork']/method[@name='getInputNeurons' and count(parameter)=0]"
		[Register ("getInputNeurons", "()[Lorg/neuroph/core/Neuron;", "GetGetInputNeuronsHandler")]
		public virtual unsafe global::Org.Neuroph.Core.Neuron[] GetInputNeurons ()
		{
			if (id_getInputNeurons == IntPtr.Zero)
				id_getInputNeurons = JNIEnv.GetMethodID (class_ref, "getInputNeurons", "()[Lorg/neuroph/core/Neuron;");
			try {

				if (GetType () == ThresholdType)
					return (global::Org.Neuroph.Core.Neuron[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getInputNeurons), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Neuroph.Core.Neuron));
				else
					return (global::Org.Neuroph.Core.Neuron[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getInputNeurons", "()[Lorg/neuroph/core/Neuron;")), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Neuroph.Core.Neuron));
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
					return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Layer> (JNIEnv.CallObjectMethod  (Handle, id_getLayerAt_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Layer> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLayerAt", "(I)Lorg/neuroph/core/Layer;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_getLayers;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='NeuralNetwork']/method[@name='getLayers' and count(parameter)=0]"
		[Register ("getLayers", "()[Lorg/neuroph/core/Layer;", "")]
		public unsafe global::Org.Neuroph.Core.Layer[] GetLayers ()
		{
			if (id_getLayers == IntPtr.Zero)
				id_getLayers = JNIEnv.GetMethodID (class_ref, "getLayers", "()[Lorg/neuroph/core/Layer;");
			try {
				return (global::Org.Neuroph.Core.Layer[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getLayers), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Neuroph.Core.Layer));
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
					return (double[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getOutput), JniHandleOwnership.TransferLocalRef, typeof (double));
				else
					return (double[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOutput", "()[D")), JniHandleOwnership.TransferLocalRef, typeof (double));
			} finally {
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
			return JNIEnv.NewArray (__this.GetOutputNeurons ());
		}
#pragma warning restore 0169

		static IntPtr id_getOutputNeurons;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='NeuralNetwork']/method[@name='getOutputNeurons' and count(parameter)=0]"
		[Register ("getOutputNeurons", "()[Lorg/neuroph/core/Neuron;", "GetGetOutputNeuronsHandler")]
		public virtual unsafe global::Org.Neuroph.Core.Neuron[] GetOutputNeurons ()
		{
			if (id_getOutputNeurons == IntPtr.Zero)
				id_getOutputNeurons = JNIEnv.GetMethodID (class_ref, "getOutputNeurons", "()[Lorg/neuroph/core/Neuron;");
			try {

				if (GetType () == ThresholdType)
					return (global::Org.Neuroph.Core.Neuron[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getOutputNeurons), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Neuroph.Core.Neuron));
				else
					return (global::Org.Neuroph.Core.Neuron[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOutputNeurons", "()[Lorg/neuroph/core/Neuron;")), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Neuroph.Core.Neuron));
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
					__ret = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.Plugins.PluginBase> (JNIEnv.CallObjectMethod  (Handle, id_getPlugin_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.Plugins.PluginBase> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPlugin", "(Ljava/lang/Class;)Lorg/neuroph/util/plugins/PluginBase;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
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
			global::Org.Neuroph.Core.NeuralNetwork __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.NeuralNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetWeights ());
		}
#pragma warning restore 0169

		static IntPtr id_getWeights;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='NeuralNetwork']/method[@name='getWeights' and count(parameter)=0]"
		[Register ("getWeights", "()[Ljava/lang/Double;", "GetGetWeightsHandler")]
		public virtual unsafe global::Java.Lang.Double[] GetWeights ()
		{
			if (id_getWeights == IntPtr.Zero)
				id_getWeights = JNIEnv.GetMethodID (class_ref, "getWeights", "()[Ljava/lang/Double;");
			try {

				if (GetType () == ThresholdType)
					return (global::Java.Lang.Double[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getWeights), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Double));
				else
					return (global::Java.Lang.Double[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWeights", "()[Ljava/lang/Double;")), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Double));
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
					__ret = JNIEnv.CallIntMethod  (Handle, id_indexOf_Lorg_neuroph_core_Layer_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "indexOf", "(Lorg/neuroph/core/Layer;)I"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_learn_Lorg_neuroph_core_data_DataSet_;
#pragma warning disable 0169
		static Delegate GetLearn_Lorg_neuroph_core_data_DataSet_Handler ()
		{
			if (cb_learn_Lorg_neuroph_core_data_DataSet_ == null)
				cb_learn_Lorg_neuroph_core_data_DataSet_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Learn_Lorg_neuroph_core_data_DataSet_);
			return cb_learn_Lorg_neuroph_core_data_DataSet_;
		}

		static void n_Learn_Lorg_neuroph_core_data_DataSet_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Core.NeuralNetwork __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.NeuralNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Core.Data.DataSet p0 = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Data.DataSet> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Learn (p0);
		}
#pragma warning restore 0169

		static IntPtr id_learn_Lorg_neuroph_core_data_DataSet_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='NeuralNetwork']/method[@name='learn' and count(parameter)=1 and parameter[1][@type='org.neuroph.core.data.DataSet']]"
		[Register ("learn", "(Lorg/neuroph/core/data/DataSet;)V", "GetLearn_Lorg_neuroph_core_data_DataSet_Handler")]
		public virtual unsafe void Learn (global::Org.Neuroph.Core.Data.DataSet p0)
		{
			if (id_learn_Lorg_neuroph_core_data_DataSet_ == IntPtr.Zero)
				id_learn_Lorg_neuroph_core_data_DataSet_ = JNIEnv.GetMethodID (class_ref, "learn", "(Lorg/neuroph/core/data/DataSet;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_learn_Lorg_neuroph_core_data_DataSet_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "learn", "(Lorg/neuroph/core/data/DataSet;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_learn_Lorg_neuroph_core_data_DataSet_Lorg_neuroph_core_learning_LearningRule_;
#pragma warning disable 0169
		static Delegate GetLearn_Lorg_neuroph_core_data_DataSet_Lorg_neuroph_core_learning_LearningRule_Handler ()
		{
			if (cb_learn_Lorg_neuroph_core_data_DataSet_Lorg_neuroph_core_learning_LearningRule_ == null)
				cb_learn_Lorg_neuroph_core_data_DataSet_Lorg_neuroph_core_learning_LearningRule_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Learn_Lorg_neuroph_core_data_DataSet_Lorg_neuroph_core_learning_LearningRule_);
			return cb_learn_Lorg_neuroph_core_data_DataSet_Lorg_neuroph_core_learning_LearningRule_;
		}

		static void n_Learn_Lorg_neuroph_core_data_DataSet_Lorg_neuroph_core_learning_LearningRule_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Neuroph.Core.NeuralNetwork __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.NeuralNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Core.Data.DataSet p0 = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Data.DataSet> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Learn (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_learn_Lorg_neuroph_core_data_DataSet_Lorg_neuroph_core_learning_LearningRule_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='NeuralNetwork']/method[@name='learn' and count(parameter)=2 and parameter[1][@type='org.neuroph.core.data.DataSet'] and parameter[2][@type='L']]"
		[Register ("learn", "(Lorg/neuroph/core/data/DataSet;Lorg/neuroph/core/learning/LearningRule;)V", "GetLearn_Lorg_neuroph_core_data_DataSet_Lorg_neuroph_core_learning_LearningRule_Handler")]
		public virtual unsafe void Learn (global::Org.Neuroph.Core.Data.DataSet p0, global::Java.Lang.Object p1)
		{
			if (id_learn_Lorg_neuroph_core_data_DataSet_Lorg_neuroph_core_learning_LearningRule_ == IntPtr.Zero)
				id_learn_Lorg_neuroph_core_data_DataSet_Lorg_neuroph_core_learning_LearningRule_ = JNIEnv.GetMethodID (class_ref, "learn", "(Lorg/neuroph/core/data/DataSet;Lorg/neuroph/core/learning/LearningRule;)V");
			IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_learn_Lorg_neuroph_core_data_DataSet_Lorg_neuroph_core_learning_LearningRule_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "learn", "(Lorg/neuroph/core/data/DataSet;Lorg/neuroph/core/learning/LearningRule;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_learnInNewThread_Lorg_neuroph_core_data_DataSet_;
#pragma warning disable 0169
		static Delegate GetLearnInNewThread_Lorg_neuroph_core_data_DataSet_Handler ()
		{
			if (cb_learnInNewThread_Lorg_neuroph_core_data_DataSet_ == null)
				cb_learnInNewThread_Lorg_neuroph_core_data_DataSet_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_LearnInNewThread_Lorg_neuroph_core_data_DataSet_);
			return cb_learnInNewThread_Lorg_neuroph_core_data_DataSet_;
		}

		static void n_LearnInNewThread_Lorg_neuroph_core_data_DataSet_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Core.NeuralNetwork __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.NeuralNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Core.Data.DataSet p0 = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Data.DataSet> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LearnInNewThread (p0);
		}
#pragma warning restore 0169

		static IntPtr id_learnInNewThread_Lorg_neuroph_core_data_DataSet_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='NeuralNetwork']/method[@name='learnInNewThread' and count(parameter)=1 and parameter[1][@type='org.neuroph.core.data.DataSet']]"
		[Register ("learnInNewThread", "(Lorg/neuroph/core/data/DataSet;)V", "GetLearnInNewThread_Lorg_neuroph_core_data_DataSet_Handler")]
		public virtual unsafe void LearnInNewThread (global::Org.Neuroph.Core.Data.DataSet p0)
		{
			if (id_learnInNewThread_Lorg_neuroph_core_data_DataSet_ == IntPtr.Zero)
				id_learnInNewThread_Lorg_neuroph_core_data_DataSet_ = JNIEnv.GetMethodID (class_ref, "learnInNewThread", "(Lorg/neuroph/core/data/DataSet;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_learnInNewThread_Lorg_neuroph_core_data_DataSet_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "learnInNewThread", "(Lorg/neuroph/core/data/DataSet;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_learnInNewThread_Lorg_neuroph_core_data_DataSet_Lorg_neuroph_core_learning_LearningRule_;
#pragma warning disable 0169
		static Delegate GetLearnInNewThread_Lorg_neuroph_core_data_DataSet_Lorg_neuroph_core_learning_LearningRule_Handler ()
		{
			if (cb_learnInNewThread_Lorg_neuroph_core_data_DataSet_Lorg_neuroph_core_learning_LearningRule_ == null)
				cb_learnInNewThread_Lorg_neuroph_core_data_DataSet_Lorg_neuroph_core_learning_LearningRule_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_LearnInNewThread_Lorg_neuroph_core_data_DataSet_Lorg_neuroph_core_learning_LearningRule_);
			return cb_learnInNewThread_Lorg_neuroph_core_data_DataSet_Lorg_neuroph_core_learning_LearningRule_;
		}

		static void n_LearnInNewThread_Lorg_neuroph_core_data_DataSet_Lorg_neuroph_core_learning_LearningRule_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Neuroph.Core.NeuralNetwork __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.NeuralNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Core.Data.DataSet p0 = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Data.DataSet> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.LearnInNewThread (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_learnInNewThread_Lorg_neuroph_core_data_DataSet_Lorg_neuroph_core_learning_LearningRule_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='NeuralNetwork']/method[@name='learnInNewThread' and count(parameter)=2 and parameter[1][@type='org.neuroph.core.data.DataSet'] and parameter[2][@type='L']]"
		[Register ("learnInNewThread", "(Lorg/neuroph/core/data/DataSet;Lorg/neuroph/core/learning/LearningRule;)V", "GetLearnInNewThread_Lorg_neuroph_core_data_DataSet_Lorg_neuroph_core_learning_LearningRule_Handler")]
		public virtual unsafe void LearnInNewThread (global::Org.Neuroph.Core.Data.DataSet p0, global::Java.Lang.Object p1)
		{
			if (id_learnInNewThread_Lorg_neuroph_core_data_DataSet_Lorg_neuroph_core_learning_LearningRule_ == IntPtr.Zero)
				id_learnInNewThread_Lorg_neuroph_core_data_DataSet_Lorg_neuroph_core_learning_LearningRule_ = JNIEnv.GetMethodID (class_ref, "learnInNewThread", "(Lorg/neuroph/core/data/DataSet;Lorg/neuroph/core/learning/LearningRule;)V");
			IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_learnInNewThread_Lorg_neuroph_core_data_DataSet_Lorg_neuroph_core_learning_LearningRule_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "learnInNewThread", "(Lorg/neuroph/core/data/DataSet;Lorg/neuroph/core/learning/LearningRule;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
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
					JNIEnv.CallVoidMethod  (Handle, id_pauseLearning);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "pauseLearning", "()V"));
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
					JNIEnv.CallVoidMethod  (Handle, id_randomizeWeights_DD, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "randomizeWeights", "(DD)V"), __args);
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
					JNIEnv.CallVoidMethod  (Handle, id_randomizeWeights_Ljava_util_Random_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "randomizeWeights", "(Ljava/util/Random;)V"), __args);
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
					JNIEnv.CallVoidMethod  (Handle, id_randomizeWeights_Lorg_neuroph_util_random_WeightsRandomizer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "randomizeWeights", "(Lorg/neuroph/util/random/WeightsRandomizer;)V"), __args);
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
					JNIEnv.CallVoidMethod  (Handle, id_removeLayer_Lorg_neuroph_core_Layer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeLayer", "(Lorg/neuroph/core/Layer;)V"), __args);
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
					JNIEnv.CallVoidMethod  (Handle, id_removeLayerAt_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeLayerAt", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_removeListener_Lorg_neuroph_core_events_NeuralNetworkEventListener_;
#pragma warning disable 0169
		static Delegate GetRemoveListener_Lorg_neuroph_core_events_NeuralNetworkEventListener_Handler ()
		{
			if (cb_removeListener_Lorg_neuroph_core_events_NeuralNetworkEventListener_ == null)
				cb_removeListener_Lorg_neuroph_core_events_NeuralNetworkEventListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveListener_Lorg_neuroph_core_events_NeuralNetworkEventListener_);
			return cb_removeListener_Lorg_neuroph_core_events_NeuralNetworkEventListener_;
		}

		static void n_RemoveListener_Lorg_neuroph_core_events_NeuralNetworkEventListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Core.NeuralNetwork __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.NeuralNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Core.Events.INeuralNetworkEventListener p0 = (global::Org.Neuroph.Core.Events.INeuralNetworkEventListener)global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Events.INeuralNetworkEventListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeListener_Lorg_neuroph_core_events_NeuralNetworkEventListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='NeuralNetwork']/method[@name='removeListener' and count(parameter)=1 and parameter[1][@type='org.neuroph.core.events.NeuralNetworkEventListener']]"
		[Register ("removeListener", "(Lorg/neuroph/core/events/NeuralNetworkEventListener;)V", "GetRemoveListener_Lorg_neuroph_core_events_NeuralNetworkEventListener_Handler")]
		public virtual unsafe void RemoveListener (global::Org.Neuroph.Core.Events.INeuralNetworkEventListener p0)
		{
			if (id_removeListener_Lorg_neuroph_core_events_NeuralNetworkEventListener_ == IntPtr.Zero)
				id_removeListener_Lorg_neuroph_core_events_NeuralNetworkEventListener_ = JNIEnv.GetMethodID (class_ref, "removeListener", "(Lorg/neuroph/core/events/NeuralNetworkEventListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_removeListener_Lorg_neuroph_core_events_NeuralNetworkEventListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeListener", "(Lorg/neuroph/core/events/NeuralNetworkEventListener;)V"), __args);
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
					JNIEnv.CallVoidMethod  (Handle, id_removePlugin_Ljava_lang_Class_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removePlugin", "(Ljava/lang/Class;)V"), __args);
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
					JNIEnv.CallVoidMethod  (Handle, id_reset);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "reset", "()V"));
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
					JNIEnv.CallVoidMethod  (Handle, id_resumeLearning);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "resumeLearning", "()V"));
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
					JNIEnv.CallVoidMethod  (Handle, id_save_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "save", "(Ljava/lang/String;)V"), __args);
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
					JNIEnv.CallVoidMethod  (Handle, id_setInput_arrayD, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setInput", "([D)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_setInputNeurons_arrayLorg_neuroph_core_Neuron_;
#pragma warning disable 0169
		static Delegate GetSetInputNeurons_arrayLorg_neuroph_core_Neuron_Handler ()
		{
			if (cb_setInputNeurons_arrayLorg_neuroph_core_Neuron_ == null)
				cb_setInputNeurons_arrayLorg_neuroph_core_Neuron_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetInputNeurons_arrayLorg_neuroph_core_Neuron_);
			return cb_setInputNeurons_arrayLorg_neuroph_core_Neuron_;
		}

		static void n_SetInputNeurons_arrayLorg_neuroph_core_Neuron_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Core.NeuralNetwork __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.NeuralNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Core.Neuron[] p0 = (global::Org.Neuroph.Core.Neuron[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Org.Neuroph.Core.Neuron));
			__this.SetInputNeurons (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_setInputNeurons_arrayLorg_neuroph_core_Neuron_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='NeuralNetwork']/method[@name='setInputNeurons' and count(parameter)=1 and parameter[1][@type='org.neuroph.core.Neuron[]']]"
		[Register ("setInputNeurons", "([Lorg/neuroph/core/Neuron;)V", "GetSetInputNeurons_arrayLorg_neuroph_core_Neuron_Handler")]
		public virtual unsafe void SetInputNeurons (global::Org.Neuroph.Core.Neuron[] p0)
		{
			if (id_setInputNeurons_arrayLorg_neuroph_core_Neuron_ == IntPtr.Zero)
				id_setInputNeurons_arrayLorg_neuroph_core_Neuron_ = JNIEnv.GetMethodID (class_ref, "setInputNeurons", "([Lorg/neuroph/core/Neuron;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setInputNeurons_arrayLorg_neuroph_core_Neuron_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setInputNeurons", "([Lorg/neuroph/core/Neuron;)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_setOutputNeurons_arrayLorg_neuroph_core_Neuron_;
#pragma warning disable 0169
		static Delegate GetSetOutputNeurons_arrayLorg_neuroph_core_Neuron_Handler ()
		{
			if (cb_setOutputNeurons_arrayLorg_neuroph_core_Neuron_ == null)
				cb_setOutputNeurons_arrayLorg_neuroph_core_Neuron_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOutputNeurons_arrayLorg_neuroph_core_Neuron_);
			return cb_setOutputNeurons_arrayLorg_neuroph_core_Neuron_;
		}

		static void n_SetOutputNeurons_arrayLorg_neuroph_core_Neuron_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Core.NeuralNetwork __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.NeuralNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Core.Neuron[] p0 = (global::Org.Neuroph.Core.Neuron[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Org.Neuroph.Core.Neuron));
			__this.SetOutputNeurons (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOutputNeurons_arrayLorg_neuroph_core_Neuron_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='NeuralNetwork']/method[@name='setOutputNeurons' and count(parameter)=1 and parameter[1][@type='org.neuroph.core.Neuron[]']]"
		[Register ("setOutputNeurons", "([Lorg/neuroph/core/Neuron;)V", "GetSetOutputNeurons_arrayLorg_neuroph_core_Neuron_Handler")]
		public virtual unsafe void SetOutputNeurons (global::Org.Neuroph.Core.Neuron[] p0)
		{
			if (id_setOutputNeurons_arrayLorg_neuroph_core_Neuron_ == IntPtr.Zero)
				id_setOutputNeurons_arrayLorg_neuroph_core_Neuron_ = JNIEnv.GetMethodID (class_ref, "setOutputNeurons", "([Lorg/neuroph/core/Neuron;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setOutputNeurons_arrayLorg_neuroph_core_Neuron_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOutputNeurons", "([Lorg/neuroph/core/Neuron;)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_setWeights_arrayD;
#pragma warning disable 0169
		static Delegate GetSetWeights_arrayDHandler ()
		{
			if (cb_setWeights_arrayD == null)
				cb_setWeights_arrayD = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetWeights_arrayD);
			return cb_setWeights_arrayD;
		}

		static void n_SetWeights_arrayD (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Core.NeuralNetwork __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.NeuralNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			double[] p0 = (double[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (double));
			__this.SetWeights (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_setWeights_arrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='NeuralNetwork']/method[@name='setWeights' and count(parameter)=1 and parameter[1][@type='double[]']]"
		[Register ("setWeights", "([D)V", "GetSetWeights_arrayDHandler")]
		public virtual unsafe void SetWeights (double[] p0)
		{
			if (id_setWeights_arrayD == IntPtr.Zero)
				id_setWeights_arrayD = JNIEnv.GetMethodID (class_ref, "setWeights", "([D)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setWeights_arrayD, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setWeights", "([D)V"), __args);
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
					JNIEnv.CallVoidMethod  (Handle, id_stopLearning);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stopLearning", "()V"));
			} finally {
			}
		}

	}
}
