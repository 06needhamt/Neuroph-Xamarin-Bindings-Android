using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Nnet.Learning {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.nnet.learning']/class[@name='LMS']"
	[global::Android.Runtime.Register ("org/neuroph/nnet/learning/LMS", DoNotGenerateAcw=true)]
	public partial class LMS : global::Org.Neuroph.Core.Learning.SupervisedLearning, global::Java.IO.ISerializable {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/nnet/learning/LMS", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LMS); }
		}

		protected LMS (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.nnet.learning']/class[@name='LMS']/constructor[@name='LMS' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe LMS ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (LMS)) {
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

		static Delegate cb_isBatchMode;
#pragma warning disable 0169
		static Delegate GetIsBatchModeHandler ()
		{
			if (cb_isBatchMode == null)
				cb_isBatchMode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsBatchMode);
			return cb_isBatchMode;
		}

		static bool n_IsBatchMode (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Nnet.Learning.LMS __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Learning.LMS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BatchMode;
		}
#pragma warning restore 0169

		static Delegate cb_setBatchMode_Z;
#pragma warning disable 0169
		static Delegate GetSetBatchMode_ZHandler ()
		{
			if (cb_setBatchMode_Z == null)
				cb_setBatchMode_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetBatchMode_Z);
			return cb_setBatchMode_Z;
		}

		static void n_SetBatchMode_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Org.Neuroph.Nnet.Learning.LMS __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Learning.LMS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.BatchMode = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isBatchMode;
		static IntPtr id_setBatchMode_Z;
		public virtual unsafe bool BatchMode {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.learning']/class[@name='LMS']/method[@name='isBatchMode' and count(parameter)=0]"
			[Register ("isBatchMode", "()Z", "GetIsBatchModeHandler")]
			get {
				if (id_isBatchMode == IntPtr.Zero)
					id_isBatchMode = JNIEnv.GetMethodID (class_ref, "isBatchMode", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isBatchMode);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isBatchMode", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.learning']/class[@name='LMS']/method[@name='setBatchMode' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setBatchMode", "(Z)V", "GetSetBatchMode_ZHandler")]
			set {
				if (id_setBatchMode_Z == IntPtr.Zero)
					id_setBatchMode_Z = JNIEnv.GetMethodID (class_ref, "setBatchMode", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBatchMode_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBatchMode", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static IntPtr id_getTrainingDataBufferSize;
		static IntPtr id_setTrainingDataBufferSize_I;
		public unsafe int TrainingDataBufferSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.learning']/class[@name='LMS']/method[@name='getTrainingDataBufferSize' and count(parameter)=0]"
			[Register ("getTrainingDataBufferSize", "()I", "GetGetTrainingDataBufferSizeHandler")]
			get {
				if (id_getTrainingDataBufferSize == IntPtr.Zero)
					id_getTrainingDataBufferSize = JNIEnv.GetMethodID (class_ref, "getTrainingDataBufferSize", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getTrainingDataBufferSize);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTrainingDataBufferSize", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.learning']/class[@name='LMS']/method[@name='setTrainingDataBufferSize' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setTrainingDataBufferSize", "(I)V", "GetSetTrainingDataBufferSize_IHandler")]
			set {
				if (id_setTrainingDataBufferSize_I == IntPtr.Zero)
					id_setTrainingDataBufferSize_I = JNIEnv.GetMethodID (class_ref, "setTrainingDataBufferSize", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTrainingDataBufferSize_I, __args);
				} finally {
				}
			}
		}

		static Delegate cb_applyWeightChange_Lorg_neuroph_core_Weight_D;
#pragma warning disable 0169
		static Delegate GetApplyWeightChange_Lorg_neuroph_core_Weight_DHandler ()
		{
			if (cb_applyWeightChange_Lorg_neuroph_core_Weight_D == null)
				cb_applyWeightChange_Lorg_neuroph_core_Weight_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, double>) n_ApplyWeightChange_Lorg_neuroph_core_Weight_D);
			return cb_applyWeightChange_Lorg_neuroph_core_Weight_D;
		}

		static void n_ApplyWeightChange_Lorg_neuroph_core_Weight_D (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, double p1)
		{
			global::Org.Neuroph.Nnet.Learning.LMS __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Learning.LMS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Core.Weight p0 = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Weight> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ApplyWeightChange (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_applyWeightChange_Lorg_neuroph_core_Weight_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.learning']/class[@name='LMS']/method[@name='applyWeightChange' and count(parameter)=2 and parameter[1][@type='org.neuroph.core.Weight'] and parameter[2][@type='double']]"
		[Register ("applyWeightChange", "(Lorg/neuroph/core/Weight;D)V", "GetApplyWeightChange_Lorg_neuroph_core_Weight_DHandler")]
		protected virtual unsafe void ApplyWeightChange (global::Org.Neuroph.Core.Weight p0, double p1)
		{
			if (id_applyWeightChange_Lorg_neuroph_core_Weight_D == IntPtr.Zero)
				id_applyWeightChange_Lorg_neuroph_core_Weight_D = JNIEnv.GetMethodID (class_ref, "applyWeightChange", "(Lorg/neuroph/core/Weight;D)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_applyWeightChange_Lorg_neuroph_core_Weight_D, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "applyWeightChange", "(Lorg/neuroph/core/Weight;D)V"), __args);
			} finally {
			}
		}

		static Delegate cb_batchModeWeightsUpdate;
#pragma warning disable 0169
		static Delegate GetBatchModeWeightsUpdateHandler ()
		{
			if (cb_batchModeWeightsUpdate == null)
				cb_batchModeWeightsUpdate = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_BatchModeWeightsUpdate);
			return cb_batchModeWeightsUpdate;
		}

		static void n_BatchModeWeightsUpdate (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Nnet.Learning.LMS __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Learning.LMS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.BatchModeWeightsUpdate ();
		}
#pragma warning restore 0169

		static IntPtr id_batchModeWeightsUpdate;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.learning']/class[@name='LMS']/method[@name='batchModeWeightsUpdate' and count(parameter)=0]"
		[Register ("batchModeWeightsUpdate", "()V", "GetBatchModeWeightsUpdateHandler")]
		protected virtual unsafe void BatchModeWeightsUpdate ()
		{
			if (id_batchModeWeightsUpdate == IntPtr.Zero)
				id_batchModeWeightsUpdate = JNIEnv.GetMethodID (class_ref, "batchModeWeightsUpdate", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_batchModeWeightsUpdate);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "batchModeWeightsUpdate", "()V"));
			} finally {
			}
		}

		static Delegate cb_initTrainingDataBuffer;
#pragma warning disable 0169
		static Delegate GetInitTrainingDataBufferHandler ()
		{
			if (cb_initTrainingDataBuffer == null)
				cb_initTrainingDataBuffer = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_InitTrainingDataBuffer);
			return cb_initTrainingDataBuffer;
		}

		static void n_InitTrainingDataBuffer (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Nnet.Learning.LMS __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Learning.LMS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.InitTrainingDataBuffer ();
		}
#pragma warning restore 0169

		static IntPtr id_initTrainingDataBuffer;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.learning']/class[@name='LMS']/method[@name='initTrainingDataBuffer' and count(parameter)=0]"
		[Register ("initTrainingDataBuffer", "()V", "GetInitTrainingDataBufferHandler")]
		protected virtual unsafe void InitTrainingDataBuffer ()
		{
			if (id_initTrainingDataBuffer == IntPtr.Zero)
				id_initTrainingDataBuffer = JNIEnv.GetMethodID (class_ref, "initTrainingDataBuffer", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_initTrainingDataBuffer);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "initTrainingDataBuffer", "()V"));
			} finally {
			}
		}

		static Delegate cb_updateNetworkWeights_arrayD;
#pragma warning disable 0169
		static Delegate GetUpdateNetworkWeights_arrayDHandler ()
		{
			if (cb_updateNetworkWeights_arrayD == null)
				cb_updateNetworkWeights_arrayD = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UpdateNetworkWeights_arrayD);
			return cb_updateNetworkWeights_arrayD;
		}

		static void n_UpdateNetworkWeights_arrayD (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Nnet.Learning.LMS __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Learning.LMS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			double[] p0 = (double[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (double));
			__this.UpdateNetworkWeights (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_updateNetworkWeights_arrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.learning']/class[@name='LMS']/method[@name='updateNetworkWeights' and count(parameter)=1 and parameter[1][@type='double[]']]"
		[Register ("updateNetworkWeights", "([D)V", "GetUpdateNetworkWeights_arrayDHandler")]
		protected override unsafe void UpdateNetworkWeights (double[] p0)
		{
			if (id_updateNetworkWeights_arrayD == IntPtr.Zero)
				id_updateNetworkWeights_arrayD = JNIEnv.GetMethodID (class_ref, "updateNetworkWeights", "([D)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateNetworkWeights_arrayD, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateNetworkWeights", "([D)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_updateNeuronWeights_Lorg_neuroph_core_Neuron_;
#pragma warning disable 0169
		static Delegate GetUpdateNeuronWeights_Lorg_neuroph_core_Neuron_Handler ()
		{
			if (cb_updateNeuronWeights_Lorg_neuroph_core_Neuron_ == null)
				cb_updateNeuronWeights_Lorg_neuroph_core_Neuron_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UpdateNeuronWeights_Lorg_neuroph_core_Neuron_);
			return cb_updateNeuronWeights_Lorg_neuroph_core_Neuron_;
		}

		static void n_UpdateNeuronWeights_Lorg_neuroph_core_Neuron_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Nnet.Learning.LMS __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Learning.LMS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Core.Neuron p0 = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Neuron> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UpdateNeuronWeights (p0);
		}
#pragma warning restore 0169

		static IntPtr id_updateNeuronWeights_Lorg_neuroph_core_Neuron_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.learning']/class[@name='LMS']/method[@name='updateNeuronWeights' and count(parameter)=1 and parameter[1][@type='org.neuroph.core.Neuron']]"
		[Register ("updateNeuronWeights", "(Lorg/neuroph/core/Neuron;)V", "GetUpdateNeuronWeights_Lorg_neuroph_core_Neuron_Handler")]
		protected virtual unsafe void UpdateNeuronWeights (global::Org.Neuroph.Core.Neuron p0)
		{
			if (id_updateNeuronWeights_Lorg_neuroph_core_Neuron_ == IntPtr.Zero)
				id_updateNeuronWeights_Lorg_neuroph_core_Neuron_ = JNIEnv.GetMethodID (class_ref, "updateNeuronWeights", "(Lorg/neuroph/core/Neuron;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateNeuronWeights_Lorg_neuroph_core_Neuron_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateNeuronWeights", "(Lorg/neuroph/core/Neuron;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_updatePatternError_arrayD;
#pragma warning disable 0169
		static Delegate GetUpdatePatternError_arrayDHandler ()
		{
			if (cb_updatePatternError_arrayD == null)
				cb_updatePatternError_arrayD = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UpdatePatternError_arrayD);
			return cb_updatePatternError_arrayD;
		}

		static void n_UpdatePatternError_arrayD (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Nnet.Learning.LMS __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Learning.LMS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			double[] p0 = (double[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (double));
			__this.UpdatePatternError (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_updatePatternError_arrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.learning']/class[@name='LMS']/method[@name='updatePatternError' and count(parameter)=1 and parameter[1][@type='double[]']]"
		[Register ("updatePatternError", "([D)V", "GetUpdatePatternError_arrayDHandler")]
		protected override unsafe void UpdatePatternError (double[] p0)
		{
			if (id_updatePatternError_arrayD == IntPtr.Zero)
				id_updatePatternError_arrayD = JNIEnv.GetMethodID (class_ref, "updatePatternError", "([D)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updatePatternError_arrayD, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updatePatternError", "([D)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_updateTotalNetworkError;
#pragma warning disable 0169
		static Delegate GetUpdateTotalNetworkErrorHandler ()
		{
			if (cb_updateTotalNetworkError == null)
				cb_updateTotalNetworkError = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_UpdateTotalNetworkError);
			return cb_updateTotalNetworkError;
		}

		static void n_UpdateTotalNetworkError (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Nnet.Learning.LMS __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Learning.LMS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UpdateTotalNetworkError ();
		}
#pragma warning restore 0169

		static IntPtr id_updateTotalNetworkError;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.learning']/class[@name='LMS']/method[@name='updateTotalNetworkError' and count(parameter)=0]"
		[Register ("updateTotalNetworkError", "()V", "GetUpdateTotalNetworkErrorHandler")]
		protected override unsafe void UpdateTotalNetworkError ()
		{
			if (id_updateTotalNetworkError == IntPtr.Zero)
				id_updateTotalNetworkError = JNIEnv.GetMethodID (class_ref, "updateTotalNetworkError", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateTotalNetworkError);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateTotalNetworkError", "()V"));
			} finally {
			}
		}

		static Delegate cb_updateTotalNetworkError_arrayD;
#pragma warning disable 0169
		static Delegate GetUpdateTotalNetworkError_arrayDHandler ()
		{
			if (cb_updateTotalNetworkError_arrayD == null)
				cb_updateTotalNetworkError_arrayD = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UpdateTotalNetworkError_arrayD);
			return cb_updateTotalNetworkError_arrayD;
		}

		static void n_UpdateTotalNetworkError_arrayD (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Nnet.Learning.LMS __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Learning.LMS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			double[] p0 = (double[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (double));
			__this.UpdateTotalNetworkError (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_updateTotalNetworkError_arrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.learning']/class[@name='LMS']/method[@name='updateTotalNetworkError' and count(parameter)=1 and parameter[1][@type='double[]']]"
		[Register ("updateTotalNetworkError", "([D)V", "GetUpdateTotalNetworkError_arrayDHandler")]
		protected override unsafe void UpdateTotalNetworkError (double[] p0)
		{
			if (id_updateTotalNetworkError_arrayD == IntPtr.Zero)
				id_updateTotalNetworkError_arrayD = JNIEnv.GetMethodID (class_ref, "updateTotalNetworkError", "([D)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateTotalNetworkError_arrayD, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateTotalNetworkError", "([D)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

	}
}
