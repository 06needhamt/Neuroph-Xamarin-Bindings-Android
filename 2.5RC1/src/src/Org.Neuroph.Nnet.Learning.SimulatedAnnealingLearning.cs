using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Nnet.Learning {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.nnet.learning']/class[@name='SimulatedAnnealingLearning']"
	[global::Android.Runtime.Register ("org/neuroph/nnet/learning/SimulatedAnnealingLearning", DoNotGenerateAcw=true)]
	public partial class SimulatedAnnealingLearning : global::Org.Neuroph.Core.Learning.SupervisedLearning {


		static IntPtr temperature_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.neuroph.nnet.learning']/class[@name='SimulatedAnnealingLearning']/field[@name='temperature']"
		[Register ("temperature")]
		protected double Temperature {
			get {
				if (temperature_jfieldId == IntPtr.Zero)
					temperature_jfieldId = JNIEnv.GetFieldID (class_ref, "temperature", "D");
				return JNIEnv.GetDoubleField (((global::Java.Lang.Object) this).Handle, temperature_jfieldId);
			}
			set {
				if (temperature_jfieldId == IntPtr.Zero)
					temperature_jfieldId = JNIEnv.GetFieldID (class_ref, "temperature", "D");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, temperature_jfieldId, value);
				} finally {
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/nnet/learning/SimulatedAnnealingLearning", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SimulatedAnnealingLearning); }
		}

		protected SimulatedAnnealingLearning (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_neuroph_core_NeuralNetwork_DDI;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.nnet.learning']/class[@name='SimulatedAnnealingLearning']/constructor[@name='SimulatedAnnealingLearning' and count(parameter)=4 and parameter[1][@type='org.neuroph.core.NeuralNetwork'] and parameter[2][@type='double'] and parameter[3][@type='double'] and parameter[4][@type='int']]"
		[Register (".ctor", "(Lorg/neuroph/core/NeuralNetwork;DDI)V", "")]
		public unsafe SimulatedAnnealingLearning (global::Org.Neuroph.Core.NeuralNetwork p0, double p1, double p2, int p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				if (GetType () != typeof (SimulatedAnnealingLearning)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/neuroph/core/NeuralNetwork;DDI)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/neuroph/core/NeuralNetwork;DDI)V", __args);
					return;
				}

				if (id_ctor_Lorg_neuroph_core_NeuralNetwork_DDI == IntPtr.Zero)
					id_ctor_Lorg_neuroph_core_NeuralNetwork_DDI = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/neuroph/core/NeuralNetwork;DDI)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_neuroph_core_NeuralNetwork_DDI, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_neuroph_core_NeuralNetwork_DDI, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Lorg_neuroph_core_NeuralNetwork_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.nnet.learning']/class[@name='SimulatedAnnealingLearning']/constructor[@name='SimulatedAnnealingLearning' and count(parameter)=1 and parameter[1][@type='org.neuroph.core.NeuralNetwork']]"
		[Register (".ctor", "(Lorg/neuroph/core/NeuralNetwork;)V", "")]
		public unsafe SimulatedAnnealingLearning (global::Org.Neuroph.Core.NeuralNetwork p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (SimulatedAnnealingLearning)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/neuroph/core/NeuralNetwork;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/neuroph/core/NeuralNetwork;)V", __args);
					return;
				}

				if (id_ctor_Lorg_neuroph_core_NeuralNetwork_ == IntPtr.Zero)
					id_ctor_Lorg_neuroph_core_NeuralNetwork_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/neuroph/core/NeuralNetwork;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_neuroph_core_NeuralNetwork_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_neuroph_core_NeuralNetwork_, __args);
			} finally {
			}
		}

		static Delegate cb_getNetwork;
#pragma warning disable 0169
		static Delegate GetGetNetworkHandler ()
		{
			if (cb_getNetwork == null)
				cb_getNetwork = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNetwork);
			return cb_getNetwork;
		}

		static IntPtr n_GetNetwork (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Nnet.Learning.SimulatedAnnealingLearning __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Learning.SimulatedAnnealingLearning> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Network);
		}
#pragma warning restore 0169

		static IntPtr id_getNetwork;
		public virtual unsafe global::Org.Neuroph.Core.NeuralNetwork Network {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.learning']/class[@name='SimulatedAnnealingLearning']/method[@name='getNetwork' and count(parameter)=0]"
			[Register ("getNetwork", "()Lorg/neuroph/core/NeuralNetwork;", "GetGetNetworkHandler")]
			get {
				if (id_getNetwork == IntPtr.Zero)
					id_getNetwork = JNIEnv.GetMethodID (class_ref, "getNetwork", "()Lorg/neuroph/core/NeuralNetwork;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.NeuralNetwork> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNetwork), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.NeuralNetwork> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNetwork", "()Lorg/neuroph/core/NeuralNetwork;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_randomize;
#pragma warning disable 0169
		static Delegate GetRandomizeHandler ()
		{
			if (cb_randomize == null)
				cb_randomize = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Randomize);
			return cb_randomize;
		}

		static void n_Randomize (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Nnet.Learning.SimulatedAnnealingLearning __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Learning.SimulatedAnnealingLearning> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Randomize ();
		}
#pragma warning restore 0169

		static IntPtr id_randomize;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.learning']/class[@name='SimulatedAnnealingLearning']/method[@name='randomize' and count(parameter)=0]"
		[Register ("randomize", "()V", "GetRandomizeHandler")]
		public virtual unsafe void Randomize ()
		{
			if (id_randomize == IntPtr.Zero)
				id_randomize = JNIEnv.GetMethodID (class_ref, "randomize", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_randomize);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "randomize", "()V"));
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
			global::Org.Neuroph.Nnet.Learning.SimulatedAnnealingLearning __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Learning.SimulatedAnnealingLearning> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			double[] p0 = (double[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (double));
			__this.UpdateNetworkWeights (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_updateNetworkWeights_arrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.learning']/class[@name='SimulatedAnnealingLearning']/method[@name='updateNetworkWeights' and count(parameter)=1 and parameter[1][@type='double[]']]"
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
			global::Org.Neuroph.Nnet.Learning.SimulatedAnnealingLearning __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Learning.SimulatedAnnealingLearning> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			double[] p0 = (double[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (double));
			__this.UpdatePatternError (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_updatePatternError_arrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.learning']/class[@name='SimulatedAnnealingLearning']/method[@name='updatePatternError' and count(parameter)=1 and parameter[1][@type='double[]']]"
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
			global::Org.Neuroph.Nnet.Learning.SimulatedAnnealingLearning __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Learning.SimulatedAnnealingLearning> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UpdateTotalNetworkError ();
		}
#pragma warning restore 0169

		static IntPtr id_updateTotalNetworkError;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.learning']/class[@name='SimulatedAnnealingLearning']/method[@name='updateTotalNetworkError' and count(parameter)=0]"
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
			global::Org.Neuroph.Nnet.Learning.SimulatedAnnealingLearning __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Learning.SimulatedAnnealingLearning> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			double[] p0 = (double[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (double));
			__this.UpdateTotalNetworkError (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_updateTotalNetworkError_arrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.learning']/class[@name='SimulatedAnnealingLearning']/method[@name='updateTotalNetworkError' and count(parameter)=1 and parameter[1][@type='double[]']]"
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
