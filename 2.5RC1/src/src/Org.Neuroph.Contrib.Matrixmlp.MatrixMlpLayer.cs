using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Contrib.Matrixmlp {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.contrib.matrixmlp']/class[@name='MatrixMlpLayer']"
	[global::Android.Runtime.Register ("org/neuroph/contrib/matrixmlp/MatrixMlpLayer", DoNotGenerateAcw=true)]
	public partial class MatrixMlpLayer : global::Java.Lang.Object, global::Org.Neuroph.Contrib.Matrixmlp.IMatrixLayer {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/contrib/matrixmlp/MatrixMlpLayer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MatrixMlpLayer); }
		}

		protected MatrixMlpLayer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_neuroph_core_Layer_Lorg_neuroph_contrib_matrixmlp_MatrixLayer_Lorg_neuroph_core_transfer_TransferFunction_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.contrib.matrixmlp']/class[@name='MatrixMlpLayer']/constructor[@name='MatrixMlpLayer' and count(parameter)=3 and parameter[1][@type='org.neuroph.core.Layer'] and parameter[2][@type='org.neuroph.contrib.matrixmlp.MatrixLayer'] and parameter[3][@type='org.neuroph.core.transfer.TransferFunction']]"
		[Register (".ctor", "(Lorg/neuroph/core/Layer;Lorg/neuroph/contrib/matrixmlp/MatrixLayer;Lorg/neuroph/core/transfer/TransferFunction;)V", "")]
		public unsafe MatrixMlpLayer (global::Org.Neuroph.Core.Layer p0, global::Org.Neuroph.Contrib.Matrixmlp.IMatrixLayer p1, global::Org.Neuroph.Core.Transfer.TransferFunction p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (MatrixMlpLayer)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/neuroph/core/Layer;Lorg/neuroph/contrib/matrixmlp/MatrixLayer;Lorg/neuroph/core/transfer/TransferFunction;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorg/neuroph/core/Layer;Lorg/neuroph/contrib/matrixmlp/MatrixLayer;Lorg/neuroph/core/transfer/TransferFunction;)V", __args);
					return;
				}

				if (id_ctor_Lorg_neuroph_core_Layer_Lorg_neuroph_contrib_matrixmlp_MatrixLayer_Lorg_neuroph_core_transfer_TransferFunction_ == IntPtr.Zero)
					id_ctor_Lorg_neuroph_core_Layer_Lorg_neuroph_contrib_matrixmlp_MatrixLayer_Lorg_neuroph_core_transfer_TransferFunction_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/neuroph/core/Layer;Lorg/neuroph/contrib/matrixmlp/MatrixLayer;Lorg/neuroph/core/transfer/TransferFunction;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_neuroph_core_Layer_Lorg_neuroph_contrib_matrixmlp_MatrixLayer_Lorg_neuroph_core_transfer_TransferFunction_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_neuroph_core_Layer_Lorg_neuroph_contrib_matrixmlp_MatrixLayer_Lorg_neuroph_core_transfer_TransferFunction_, __args);
			} finally {
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
			global::Org.Neuroph.Contrib.Matrixmlp.MatrixMlpLayer __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.Matrixmlp.MatrixMlpLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NeuronsCount;
		}
#pragma warning restore 0169

		static IntPtr id_getNeuronsCount;
		public virtual unsafe int NeuronsCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.contrib.matrixmlp']/class[@name='MatrixMlpLayer']/method[@name='getNeuronsCount' and count(parameter)=0]"
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

		static Delegate cb_getNextLayer;
#pragma warning disable 0169
		static Delegate GetGetNextLayerHandler ()
		{
			if (cb_getNextLayer == null)
				cb_getNextLayer = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNextLayer);
			return cb_getNextLayer;
		}

		static IntPtr n_GetNextLayer (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Contrib.Matrixmlp.MatrixMlpLayer __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.Matrixmlp.MatrixMlpLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NextLayer);
		}
#pragma warning restore 0169

		static Delegate cb_setNextLayer_Lorg_neuroph_contrib_matrixmlp_MatrixLayer_;
#pragma warning disable 0169
		static Delegate GetSetNextLayer_Lorg_neuroph_contrib_matrixmlp_MatrixLayer_Handler ()
		{
			if (cb_setNextLayer_Lorg_neuroph_contrib_matrixmlp_MatrixLayer_ == null)
				cb_setNextLayer_Lorg_neuroph_contrib_matrixmlp_MatrixLayer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetNextLayer_Lorg_neuroph_contrib_matrixmlp_MatrixLayer_);
			return cb_setNextLayer_Lorg_neuroph_contrib_matrixmlp_MatrixLayer_;
		}

		static void n_SetNextLayer_Lorg_neuroph_contrib_matrixmlp_MatrixLayer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Contrib.Matrixmlp.MatrixMlpLayer __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.Matrixmlp.MatrixMlpLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Contrib.Matrixmlp.IMatrixLayer p0 = (global::Org.Neuroph.Contrib.Matrixmlp.IMatrixLayer)global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.Matrixmlp.IMatrixLayer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.NextLayer = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getNextLayer;
		static IntPtr id_setNextLayer_Lorg_neuroph_contrib_matrixmlp_MatrixLayer_;
		public virtual unsafe global::Org.Neuroph.Contrib.Matrixmlp.IMatrixLayer NextLayer {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.contrib.matrixmlp']/class[@name='MatrixMlpLayer']/method[@name='getNextLayer' and count(parameter)=0]"
			[Register ("getNextLayer", "()Lorg/neuroph/contrib/matrixmlp/MatrixLayer;", "GetGetNextLayerHandler")]
			get {
				if (id_getNextLayer == IntPtr.Zero)
					id_getNextLayer = JNIEnv.GetMethodID (class_ref, "getNextLayer", "()Lorg/neuroph/contrib/matrixmlp/MatrixLayer;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.Matrixmlp.IMatrixLayer> (JNIEnv.CallObjectMethod  (Handle, id_getNextLayer), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.Matrixmlp.IMatrixLayer> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNextLayer", "()Lorg/neuroph/contrib/matrixmlp/MatrixLayer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.contrib.matrixmlp']/class[@name='MatrixMlpLayer']/method[@name='setNextLayer' and count(parameter)=1 and parameter[1][@type='org.neuroph.contrib.matrixmlp.MatrixLayer']]"
			[Register ("setNextLayer", "(Lorg/neuroph/contrib/matrixmlp/MatrixLayer;)V", "GetSetNextLayer_Lorg_neuroph_contrib_matrixmlp_MatrixLayer_Handler")]
			set {
				if (id_setNextLayer_Lorg_neuroph_contrib_matrixmlp_MatrixLayer_ == IntPtr.Zero)
					id_setNextLayer_Lorg_neuroph_contrib_matrixmlp_MatrixLayer_ = JNIEnv.GetMethodID (class_ref, "setNextLayer", "(Lorg/neuroph/contrib/matrixmlp/MatrixLayer;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setNextLayer_Lorg_neuroph_contrib_matrixmlp_MatrixLayer_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNextLayer", "(Lorg/neuroph/contrib/matrixmlp/MatrixLayer;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getPreviousLayer;
#pragma warning disable 0169
		static Delegate GetGetPreviousLayerHandler ()
		{
			if (cb_getPreviousLayer == null)
				cb_getPreviousLayer = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPreviousLayer);
			return cb_getPreviousLayer;
		}

		static IntPtr n_GetPreviousLayer (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Contrib.Matrixmlp.MatrixMlpLayer __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.Matrixmlp.MatrixMlpLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PreviousLayer);
		}
#pragma warning restore 0169

		static Delegate cb_setPreviousLayer_Lorg_neuroph_contrib_matrixmlp_MatrixLayer_;
#pragma warning disable 0169
		static Delegate GetSetPreviousLayer_Lorg_neuroph_contrib_matrixmlp_MatrixLayer_Handler ()
		{
			if (cb_setPreviousLayer_Lorg_neuroph_contrib_matrixmlp_MatrixLayer_ == null)
				cb_setPreviousLayer_Lorg_neuroph_contrib_matrixmlp_MatrixLayer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPreviousLayer_Lorg_neuroph_contrib_matrixmlp_MatrixLayer_);
			return cb_setPreviousLayer_Lorg_neuroph_contrib_matrixmlp_MatrixLayer_;
		}

		static void n_SetPreviousLayer_Lorg_neuroph_contrib_matrixmlp_MatrixLayer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Contrib.Matrixmlp.MatrixMlpLayer __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.Matrixmlp.MatrixMlpLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Contrib.Matrixmlp.IMatrixLayer p0 = (global::Org.Neuroph.Contrib.Matrixmlp.IMatrixLayer)global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.Matrixmlp.IMatrixLayer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PreviousLayer = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getPreviousLayer;
		static IntPtr id_setPreviousLayer_Lorg_neuroph_contrib_matrixmlp_MatrixLayer_;
		public virtual unsafe global::Org.Neuroph.Contrib.Matrixmlp.IMatrixLayer PreviousLayer {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.contrib.matrixmlp']/class[@name='MatrixMlpLayer']/method[@name='getPreviousLayer' and count(parameter)=0]"
			[Register ("getPreviousLayer", "()Lorg/neuroph/contrib/matrixmlp/MatrixLayer;", "GetGetPreviousLayerHandler")]
			get {
				if (id_getPreviousLayer == IntPtr.Zero)
					id_getPreviousLayer = JNIEnv.GetMethodID (class_ref, "getPreviousLayer", "()Lorg/neuroph/contrib/matrixmlp/MatrixLayer;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.Matrixmlp.IMatrixLayer> (JNIEnv.CallObjectMethod  (Handle, id_getPreviousLayer), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.Matrixmlp.IMatrixLayer> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPreviousLayer", "()Lorg/neuroph/contrib/matrixmlp/MatrixLayer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.contrib.matrixmlp']/class[@name='MatrixMlpLayer']/method[@name='setPreviousLayer' and count(parameter)=1 and parameter[1][@type='org.neuroph.contrib.matrixmlp.MatrixLayer']]"
			[Register ("setPreviousLayer", "(Lorg/neuroph/contrib/matrixmlp/MatrixLayer;)V", "GetSetPreviousLayer_Lorg_neuroph_contrib_matrixmlp_MatrixLayer_Handler")]
			set {
				if (id_setPreviousLayer_Lorg_neuroph_contrib_matrixmlp_MatrixLayer_ == IntPtr.Zero)
					id_setPreviousLayer_Lorg_neuroph_contrib_matrixmlp_MatrixLayer_ = JNIEnv.GetMethodID (class_ref, "setPreviousLayer", "(Lorg/neuroph/contrib/matrixmlp/MatrixLayer;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setPreviousLayer_Lorg_neuroph_contrib_matrixmlp_MatrixLayer_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPreviousLayer", "(Lorg/neuroph/contrib/matrixmlp/MatrixLayer;)V"), __args);
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
			global::Org.Neuroph.Contrib.Matrixmlp.MatrixMlpLayer __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.Matrixmlp.MatrixMlpLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TransferFunction);
		}
#pragma warning restore 0169

		static IntPtr id_getTransferFunction;
		public virtual unsafe global::Org.Neuroph.Core.Transfer.TransferFunction TransferFunction {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.contrib.matrixmlp']/class[@name='MatrixMlpLayer']/method[@name='getTransferFunction' and count(parameter)=0]"
			[Register ("getTransferFunction", "()Lorg/neuroph/core/transfer/TransferFunction;", "GetGetTransferFunctionHandler")]
			get {
				if (id_getTransferFunction == IntPtr.Zero)
					id_getTransferFunction = JNIEnv.GetMethodID (class_ref, "getTransferFunction", "()Lorg/neuroph/core/transfer/TransferFunction;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Transfer.TransferFunction> (JNIEnv.CallObjectMethod  (Handle, id_getTransferFunction), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Transfer.TransferFunction> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTransferFunction", "()Lorg/neuroph/core/transfer/TransferFunction;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_calculate;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.contrib.matrixmlp']/class[@name='MatrixMlpLayer']/method[@name='calculate' and count(parameter)=0]"
		[Register ("calculate", "()V", "")]
		public unsafe void Calculate ()
		{
			if (id_calculate == IntPtr.Zero)
				id_calculate = JNIEnv.GetMethodID (class_ref, "calculate", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_calculate);
			} finally {
			}
		}

		static Delegate cb_copyMatricesToNeurons;
#pragma warning disable 0169
		static Delegate GetCopyMatricesToNeuronsHandler ()
		{
			if (cb_copyMatricesToNeurons == null)
				cb_copyMatricesToNeurons = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CopyMatricesToNeurons);
			return cb_copyMatricesToNeurons;
		}

		static void n_CopyMatricesToNeurons (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Contrib.Matrixmlp.MatrixMlpLayer __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.Matrixmlp.MatrixMlpLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CopyMatricesToNeurons ();
		}
#pragma warning restore 0169

		static IntPtr id_copyMatricesToNeurons;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.contrib.matrixmlp']/class[@name='MatrixMlpLayer']/method[@name='copyMatricesToNeurons' and count(parameter)=0]"
		[Register ("copyMatricesToNeurons", "()V", "GetCopyMatricesToNeuronsHandler")]
		public virtual unsafe void CopyMatricesToNeurons ()
		{
			if (id_copyMatricesToNeurons == IntPtr.Zero)
				id_copyMatricesToNeurons = JNIEnv.GetMethodID (class_ref, "copyMatricesToNeurons", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_copyMatricesToNeurons);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "copyMatricesToNeurons", "()V"));
			} finally {
			}
		}

		static Delegate cb_copyNeuronsToMatrices;
#pragma warning disable 0169
		static Delegate GetCopyNeuronsToMatricesHandler ()
		{
			if (cb_copyNeuronsToMatrices == null)
				cb_copyNeuronsToMatrices = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CopyNeuronsToMatrices);
			return cb_copyNeuronsToMatrices;
		}

		static void n_CopyNeuronsToMatrices (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Contrib.Matrixmlp.MatrixMlpLayer __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.Matrixmlp.MatrixMlpLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CopyNeuronsToMatrices ();
		}
#pragma warning restore 0169

		static IntPtr id_copyNeuronsToMatrices;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.contrib.matrixmlp']/class[@name='MatrixMlpLayer']/method[@name='copyNeuronsToMatrices' and count(parameter)=0]"
		[Register ("copyNeuronsToMatrices", "()V", "GetCopyNeuronsToMatricesHandler")]
		public virtual unsafe void CopyNeuronsToMatrices ()
		{
			if (id_copyNeuronsToMatrices == IntPtr.Zero)
				id_copyNeuronsToMatrices = JNIEnv.GetMethodID (class_ref, "copyNeuronsToMatrices", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_copyNeuronsToMatrices);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "copyNeuronsToMatrices", "()V"));
			} finally {
			}
		}

		static Delegate cb_getDeltaWeights;
#pragma warning disable 0169
		static Delegate GetGetDeltaWeightsHandler ()
		{
			if (cb_getDeltaWeights == null)
				cb_getDeltaWeights = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDeltaWeights);
			return cb_getDeltaWeights;
		}

		static IntPtr n_GetDeltaWeights (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Contrib.Matrixmlp.MatrixMlpLayer __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.Matrixmlp.MatrixMlpLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetDeltaWeights ());
		}
#pragma warning restore 0169

		static IntPtr id_getDeltaWeights;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.contrib.matrixmlp']/class[@name='MatrixMlpLayer']/method[@name='getDeltaWeights' and count(parameter)=0]"
		[Register ("getDeltaWeights", "()[[D", "GetGetDeltaWeightsHandler")]
		public virtual unsafe double[][] GetDeltaWeights ()
		{
			if (id_getDeltaWeights == IntPtr.Zero)
				id_getDeltaWeights = JNIEnv.GetMethodID (class_ref, "getDeltaWeights", "()[[D");
			try {

				if (GetType () == ThresholdType)
					return (double[][]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getDeltaWeights), JniHandleOwnership.TransferLocalRef, typeof (double[]));
				else
					return (double[][]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDeltaWeights", "()[[D")), JniHandleOwnership.TransferLocalRef, typeof (double[]));
			} finally {
			}
		}

		static Delegate cb_getErrors;
#pragma warning disable 0169
		static Delegate GetGetErrorsHandler ()
		{
			if (cb_getErrors == null)
				cb_getErrors = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetErrors);
			return cb_getErrors;
		}

		static IntPtr n_GetErrors (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Contrib.Matrixmlp.MatrixMlpLayer __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.Matrixmlp.MatrixMlpLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetErrors ());
		}
#pragma warning restore 0169

		static IntPtr id_getErrors;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.contrib.matrixmlp']/class[@name='MatrixMlpLayer']/method[@name='getErrors' and count(parameter)=0]"
		[Register ("getErrors", "()[D", "GetGetErrorsHandler")]
		public virtual unsafe double[] GetErrors ()
		{
			if (id_getErrors == IntPtr.Zero)
				id_getErrors = JNIEnv.GetMethodID (class_ref, "getErrors", "()[D");
			try {

				if (GetType () == ThresholdType)
					return (double[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getErrors), JniHandleOwnership.TransferLocalRef, typeof (double));
				else
					return (double[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getErrors", "()[D")), JniHandleOwnership.TransferLocalRef, typeof (double));
			} finally {
			}
		}

		static Delegate cb_getInputs;
#pragma warning disable 0169
		static Delegate GetGetInputsHandler ()
		{
			if (cb_getInputs == null)
				cb_getInputs = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetInputs);
			return cb_getInputs;
		}

		static IntPtr n_GetInputs (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Contrib.Matrixmlp.MatrixMlpLayer __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.Matrixmlp.MatrixMlpLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetInputs ());
		}
#pragma warning restore 0169

		static IntPtr id_getInputs;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.contrib.matrixmlp']/class[@name='MatrixMlpLayer']/method[@name='getInputs' and count(parameter)=0]"
		[Register ("getInputs", "()[D", "GetGetInputsHandler")]
		public virtual unsafe double[] GetInputs ()
		{
			if (id_getInputs == IntPtr.Zero)
				id_getInputs = JNIEnv.GetMethodID (class_ref, "getInputs", "()[D");
			try {

				if (GetType () == ThresholdType)
					return (double[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getInputs), JniHandleOwnership.TransferLocalRef, typeof (double));
				else
					return (double[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getInputs", "()[D")), JniHandleOwnership.TransferLocalRef, typeof (double));
			} finally {
			}
		}

		static Delegate cb_getInputsFromPreviousLayer;
#pragma warning disable 0169
		static Delegate GetGetInputsFromPreviousLayerHandler ()
		{
			if (cb_getInputsFromPreviousLayer == null)
				cb_getInputsFromPreviousLayer = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_GetInputsFromPreviousLayer);
			return cb_getInputsFromPreviousLayer;
		}

		static void n_GetInputsFromPreviousLayer (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Contrib.Matrixmlp.MatrixMlpLayer __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.Matrixmlp.MatrixMlpLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.GetInputsFromPreviousLayer ();
		}
#pragma warning restore 0169

		static IntPtr id_getInputsFromPreviousLayer;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.contrib.matrixmlp']/class[@name='MatrixMlpLayer']/method[@name='getInputsFromPreviousLayer' and count(parameter)=0]"
		[Register ("getInputsFromPreviousLayer", "()V", "GetGetInputsFromPreviousLayerHandler")]
		public virtual unsafe void GetInputsFromPreviousLayer ()
		{
			if (id_getInputsFromPreviousLayer == IntPtr.Zero)
				id_getInputsFromPreviousLayer = JNIEnv.GetMethodID (class_ref, "getInputsFromPreviousLayer", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_getInputsFromPreviousLayer);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getInputsFromPreviousLayer", "()V"));
			} finally {
			}
		}

		static Delegate cb_getNetInput;
#pragma warning disable 0169
		static Delegate GetGetNetInputHandler ()
		{
			if (cb_getNetInput == null)
				cb_getNetInput = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNetInput);
			return cb_getNetInput;
		}

		static IntPtr n_GetNetInput (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Contrib.Matrixmlp.MatrixMlpLayer __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.Matrixmlp.MatrixMlpLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetNetInput ());
		}
#pragma warning restore 0169

		static IntPtr id_getNetInput;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.contrib.matrixmlp']/class[@name='MatrixMlpLayer']/method[@name='getNetInput' and count(parameter)=0]"
		[Register ("getNetInput", "()[D", "GetGetNetInputHandler")]
		public virtual unsafe double[] GetNetInput ()
		{
			if (id_getNetInput == IntPtr.Zero)
				id_getNetInput = JNIEnv.GetMethodID (class_ref, "getNetInput", "()[D");
			try {

				if (GetType () == ThresholdType)
					return (double[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getNetInput), JniHandleOwnership.TransferLocalRef, typeof (double));
				else
					return (double[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNetInput", "()[D")), JniHandleOwnership.TransferLocalRef, typeof (double));
			} finally {
			}
		}

		static Delegate cb_getOutputs;
#pragma warning disable 0169
		static Delegate GetGetOutputsHandler ()
		{
			if (cb_getOutputs == null)
				cb_getOutputs = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOutputs);
			return cb_getOutputs;
		}

		static IntPtr n_GetOutputs (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Contrib.Matrixmlp.MatrixMlpLayer __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.Matrixmlp.MatrixMlpLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetOutputs ());
		}
#pragma warning restore 0169

		static IntPtr id_getOutputs;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.contrib.matrixmlp']/class[@name='MatrixMlpLayer']/method[@name='getOutputs' and count(parameter)=0]"
		[Register ("getOutputs", "()[D", "GetGetOutputsHandler")]
		public virtual unsafe double[] GetOutputs ()
		{
			if (id_getOutputs == IntPtr.Zero)
				id_getOutputs = JNIEnv.GetMethodID (class_ref, "getOutputs", "()[D");
			try {

				if (GetType () == ThresholdType)
					return (double[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getOutputs), JniHandleOwnership.TransferLocalRef, typeof (double));
				else
					return (double[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOutputs", "()[D")), JniHandleOwnership.TransferLocalRef, typeof (double));
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
			global::Org.Neuroph.Contrib.Matrixmlp.MatrixMlpLayer __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.Matrixmlp.MatrixMlpLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetWeights ());
		}
#pragma warning restore 0169

		static IntPtr id_getWeights;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.contrib.matrixmlp']/class[@name='MatrixMlpLayer']/method[@name='getWeights' and count(parameter)=0]"
		[Register ("getWeights", "()[[D", "GetGetWeightsHandler")]
		public virtual unsafe double[][] GetWeights ()
		{
			if (id_getWeights == IntPtr.Zero)
				id_getWeights = JNIEnv.GetMethodID (class_ref, "getWeights", "()[[D");
			try {

				if (GetType () == ThresholdType)
					return (double[][]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getWeights), JniHandleOwnership.TransferLocalRef, typeof (double[]));
				else
					return (double[][]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWeights", "()[[D")), JniHandleOwnership.TransferLocalRef, typeof (double[]));
			} finally {
			}
		}

		static Delegate cb_saveCurrentWeights;
#pragma warning disable 0169
		static Delegate GetSaveCurrentWeightsHandler ()
		{
			if (cb_saveCurrentWeights == null)
				cb_saveCurrentWeights = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SaveCurrentWeights);
			return cb_saveCurrentWeights;
		}

		static void n_SaveCurrentWeights (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Contrib.Matrixmlp.MatrixMlpLayer __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.Matrixmlp.MatrixMlpLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SaveCurrentWeights ();
		}
#pragma warning restore 0169

		static IntPtr id_saveCurrentWeights;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.contrib.matrixmlp']/class[@name='MatrixMlpLayer']/method[@name='saveCurrentWeights' and count(parameter)=0]"
		[Register ("saveCurrentWeights", "()V", "GetSaveCurrentWeightsHandler")]
		public virtual unsafe void SaveCurrentWeights ()
		{
			if (id_saveCurrentWeights == IntPtr.Zero)
				id_saveCurrentWeights = JNIEnv.GetMethodID (class_ref, "saveCurrentWeights", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_saveCurrentWeights);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "saveCurrentWeights", "()V"));
			} finally {
			}
		}

		static Delegate cb_setErrors_arrayD;
#pragma warning disable 0169
		static Delegate GetSetErrors_arrayDHandler ()
		{
			if (cb_setErrors_arrayD == null)
				cb_setErrors_arrayD = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetErrors_arrayD);
			return cb_setErrors_arrayD;
		}

		static void n_SetErrors_arrayD (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Contrib.Matrixmlp.MatrixMlpLayer __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.Matrixmlp.MatrixMlpLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			double[] p0 = (double[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (double));
			__this.SetErrors (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_setErrors_arrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.contrib.matrixmlp']/class[@name='MatrixMlpLayer']/method[@name='setErrors' and count(parameter)=1 and parameter[1][@type='double[]']]"
		[Register ("setErrors", "([D)V", "GetSetErrors_arrayDHandler")]
		public virtual unsafe void SetErrors (double[] p0)
		{
			if (id_setErrors_arrayD == IntPtr.Zero)
				id_setErrors_arrayD = JNIEnv.GetMethodID (class_ref, "setErrors", "([D)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setErrors_arrayD, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setErrors", "([D)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_setInputs_arrayD;
#pragma warning disable 0169
		static Delegate GetSetInputs_arrayDHandler ()
		{
			if (cb_setInputs_arrayD == null)
				cb_setInputs_arrayD = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetInputs_arrayD);
			return cb_setInputs_arrayD;
		}

		static void n_SetInputs_arrayD (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Contrib.Matrixmlp.MatrixMlpLayer __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.Matrixmlp.MatrixMlpLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			double[] p0 = (double[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (double));
			__this.SetInputs (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_setInputs_arrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.contrib.matrixmlp']/class[@name='MatrixMlpLayer']/method[@name='setInputs' and count(parameter)=1 and parameter[1][@type='double[]']]"
		[Register ("setInputs", "([D)V", "GetSetInputs_arrayDHandler")]
		public virtual unsafe void SetInputs (double[] p0)
		{
			if (id_setInputs_arrayD == IntPtr.Zero)
				id_setInputs_arrayD = JNIEnv.GetMethodID (class_ref, "setInputs", "([D)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setInputs_arrayD, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setInputs", "([D)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_setOutputs_arrayD;
#pragma warning disable 0169
		static Delegate GetSetOutputs_arrayDHandler ()
		{
			if (cb_setOutputs_arrayD == null)
				cb_setOutputs_arrayD = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOutputs_arrayD);
			return cb_setOutputs_arrayD;
		}

		static void n_SetOutputs_arrayD (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Contrib.Matrixmlp.MatrixMlpLayer __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.Matrixmlp.MatrixMlpLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			double[] p0 = (double[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (double));
			__this.SetOutputs (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOutputs_arrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.contrib.matrixmlp']/class[@name='MatrixMlpLayer']/method[@name='setOutputs' and count(parameter)=1 and parameter[1][@type='double[]']]"
		[Register ("setOutputs", "([D)V", "GetSetOutputs_arrayDHandler")]
		public virtual unsafe void SetOutputs (double[] p0)
		{
			if (id_setOutputs_arrayD == IntPtr.Zero)
				id_setOutputs_arrayD = JNIEnv.GetMethodID (class_ref, "setOutputs", "([D)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setOutputs_arrayD, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOutputs", "([D)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_sync;
#pragma warning disable 0169
		static Delegate GetSyncHandler ()
		{
			if (cb_sync == null)
				cb_sync = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Sync);
			return cb_sync;
		}

		static void n_Sync (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Contrib.Matrixmlp.MatrixMlpLayer __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.Matrixmlp.MatrixMlpLayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Sync ();
		}
#pragma warning restore 0169

		static IntPtr id_sync;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.contrib.matrixmlp']/class[@name='MatrixMlpLayer']/method[@name='sync' and count(parameter)=0]"
		[Register ("sync", "()V", "GetSyncHandler")]
		public virtual unsafe void Sync ()
		{
			if (id_sync == IntPtr.Zero)
				id_sync = JNIEnv.GetMethodID (class_ref, "sync", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_sync);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sync", "()V"));
			} finally {
			}
		}

	}
}
