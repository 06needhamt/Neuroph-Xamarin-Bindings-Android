using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Util.Random {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.util.random']/class[@name='WeightsRandomizer']"
	[global::Android.Runtime.Register ("org/neuroph/util/random/WeightsRandomizer", DoNotGenerateAcw=true)]
	public partial class WeightsRandomizer : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/util/random/WeightsRandomizer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (WeightsRandomizer); }
		}

		protected WeightsRandomizer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_util_Random_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.util.random']/class[@name='WeightsRandomizer']/constructor[@name='WeightsRandomizer' and count(parameter)=1 and parameter[1][@type='java.util.Random']]"
		[Register (".ctor", "(Ljava/util/Random;)V", "")]
		public unsafe WeightsRandomizer (global::Java.Util.Random p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (WeightsRandomizer)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/util/Random;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/util/Random;)V", __args);
					return;
				}

				if (id_ctor_Ljava_util_Random_ == IntPtr.Zero)
					id_ctor_Ljava_util_Random_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/util/Random;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_util_Random_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_util_Random_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.util.random']/class[@name='WeightsRandomizer']/constructor[@name='WeightsRandomizer' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe WeightsRandomizer ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (WeightsRandomizer)) {
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

		static Delegate cb_getRandomGenerator;
#pragma warning disable 0169
		static Delegate GetGetRandomGeneratorHandler ()
		{
			if (cb_getRandomGenerator == null)
				cb_getRandomGenerator = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRandomGenerator);
			return cb_getRandomGenerator;
		}

		static IntPtr n_GetRandomGenerator (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Util.Random.WeightsRandomizer __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.Random.WeightsRandomizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RandomGenerator);
		}
#pragma warning restore 0169

		static Delegate cb_setRandomGenerator_Ljava_util_Random_;
#pragma warning disable 0169
		static Delegate GetSetRandomGenerator_Ljava_util_Random_Handler ()
		{
			if (cb_setRandomGenerator_Ljava_util_Random_ == null)
				cb_setRandomGenerator_Ljava_util_Random_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRandomGenerator_Ljava_util_Random_);
			return cb_setRandomGenerator_Ljava_util_Random_;
		}

		static void n_SetRandomGenerator_Ljava_util_Random_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Util.Random.WeightsRandomizer __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.Random.WeightsRandomizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Random p0 = global::Java.Lang.Object.GetObject<global::Java.Util.Random> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RandomGenerator = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getRandomGenerator;
		static IntPtr id_setRandomGenerator_Ljava_util_Random_;
		public virtual unsafe global::Java.Util.Random RandomGenerator {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util.random']/class[@name='WeightsRandomizer']/method[@name='getRandomGenerator' and count(parameter)=0]"
			[Register ("getRandomGenerator", "()Ljava/util/Random;", "GetGetRandomGeneratorHandler")]
			get {
				if (id_getRandomGenerator == IntPtr.Zero)
					id_getRandomGenerator = JNIEnv.GetMethodID (class_ref, "getRandomGenerator", "()Ljava/util/Random;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Util.Random> (JNIEnv.CallObjectMethod  (Handle, id_getRandomGenerator), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Util.Random> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRandomGenerator", "()Ljava/util/Random;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util.random']/class[@name='WeightsRandomizer']/method[@name='setRandomGenerator' and count(parameter)=1 and parameter[1][@type='java.util.Random']]"
			[Register ("setRandomGenerator", "(Ljava/util/Random;)V", "GetSetRandomGenerator_Ljava_util_Random_Handler")]
			set {
				if (id_setRandomGenerator_Ljava_util_Random_ == IntPtr.Zero)
					id_setRandomGenerator_Ljava_util_Random_ = JNIEnv.GetMethodID (class_ref, "setRandomGenerator", "(Ljava/util/Random;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setRandomGenerator_Ljava_util_Random_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRandomGenerator", "(Ljava/util/Random;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_nextRandomWeight;
#pragma warning disable 0169
		static Delegate GetNextRandomWeightHandler ()
		{
			if (cb_nextRandomWeight == null)
				cb_nextRandomWeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_NextRandomWeight);
			return cb_nextRandomWeight;
		}

		static double n_NextRandomWeight (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Util.Random.WeightsRandomizer __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.Random.WeightsRandomizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NextRandomWeight ();
		}
#pragma warning restore 0169

		static IntPtr id_nextRandomWeight;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util.random']/class[@name='WeightsRandomizer']/method[@name='nextRandomWeight' and count(parameter)=0]"
		[Register ("nextRandomWeight", "()D", "GetNextRandomWeightHandler")]
		protected virtual unsafe double NextRandomWeight ()
		{
			if (id_nextRandomWeight == IntPtr.Zero)
				id_nextRandomWeight = JNIEnv.GetMethodID (class_ref, "nextRandomWeight", "()D");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallDoubleMethod  (Handle, id_nextRandomWeight);
				else
					return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "nextRandomWeight", "()D"));
			} finally {
			}
		}

		static Delegate cb_randomize_Lorg_neuroph_core_Layer_;
#pragma warning disable 0169
		static Delegate GetRandomize_Lorg_neuroph_core_Layer_Handler ()
		{
			if (cb_randomize_Lorg_neuroph_core_Layer_ == null)
				cb_randomize_Lorg_neuroph_core_Layer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Randomize_Lorg_neuroph_core_Layer_);
			return cb_randomize_Lorg_neuroph_core_Layer_;
		}

		static void n_Randomize_Lorg_neuroph_core_Layer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Util.Random.WeightsRandomizer __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.Random.WeightsRandomizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Core.Layer p0 = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Layer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Randomize (p0);
		}
#pragma warning restore 0169

		static IntPtr id_randomize_Lorg_neuroph_core_Layer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util.random']/class[@name='WeightsRandomizer']/method[@name='randomize' and count(parameter)=1 and parameter[1][@type='org.neuroph.core.Layer']]"
		[Register ("randomize", "(Lorg/neuroph/core/Layer;)V", "GetRandomize_Lorg_neuroph_core_Layer_Handler")]
		public virtual unsafe void Randomize (global::Org.Neuroph.Core.Layer p0)
		{
			if (id_randomize_Lorg_neuroph_core_Layer_ == IntPtr.Zero)
				id_randomize_Lorg_neuroph_core_Layer_ = JNIEnv.GetMethodID (class_ref, "randomize", "(Lorg/neuroph/core/Layer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_randomize_Lorg_neuroph_core_Layer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "randomize", "(Lorg/neuroph/core/Layer;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_randomize_Lorg_neuroph_core_NeuralNetwork_;
#pragma warning disable 0169
		static Delegate GetRandomize_Lorg_neuroph_core_NeuralNetwork_Handler ()
		{
			if (cb_randomize_Lorg_neuroph_core_NeuralNetwork_ == null)
				cb_randomize_Lorg_neuroph_core_NeuralNetwork_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Randomize_Lorg_neuroph_core_NeuralNetwork_);
			return cb_randomize_Lorg_neuroph_core_NeuralNetwork_;
		}

		static void n_Randomize_Lorg_neuroph_core_NeuralNetwork_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Util.Random.WeightsRandomizer __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.Random.WeightsRandomizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Core.NeuralNetwork p0 = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.NeuralNetwork> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Randomize (p0);
		}
#pragma warning restore 0169

		static IntPtr id_randomize_Lorg_neuroph_core_NeuralNetwork_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util.random']/class[@name='WeightsRandomizer']/method[@name='randomize' and count(parameter)=1 and parameter[1][@type='org.neuroph.core.NeuralNetwork']]"
		[Register ("randomize", "(Lorg/neuroph/core/NeuralNetwork;)V", "GetRandomize_Lorg_neuroph_core_NeuralNetwork_Handler")]
		public virtual unsafe void Randomize (global::Org.Neuroph.Core.NeuralNetwork p0)
		{
			if (id_randomize_Lorg_neuroph_core_NeuralNetwork_ == IntPtr.Zero)
				id_randomize_Lorg_neuroph_core_NeuralNetwork_ = JNIEnv.GetMethodID (class_ref, "randomize", "(Lorg/neuroph/core/NeuralNetwork;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_randomize_Lorg_neuroph_core_NeuralNetwork_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "randomize", "(Lorg/neuroph/core/NeuralNetwork;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_randomize_Lorg_neuroph_core_Neuron_;
#pragma warning disable 0169
		static Delegate GetRandomize_Lorg_neuroph_core_Neuron_Handler ()
		{
			if (cb_randomize_Lorg_neuroph_core_Neuron_ == null)
				cb_randomize_Lorg_neuroph_core_Neuron_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Randomize_Lorg_neuroph_core_Neuron_);
			return cb_randomize_Lorg_neuroph_core_Neuron_;
		}

		static void n_Randomize_Lorg_neuroph_core_Neuron_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Util.Random.WeightsRandomizer __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.Random.WeightsRandomizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Core.Neuron p0 = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Neuron> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Randomize (p0);
		}
#pragma warning restore 0169

		static IntPtr id_randomize_Lorg_neuroph_core_Neuron_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util.random']/class[@name='WeightsRandomizer']/method[@name='randomize' and count(parameter)=1 and parameter[1][@type='org.neuroph.core.Neuron']]"
		[Register ("randomize", "(Lorg/neuroph/core/Neuron;)V", "GetRandomize_Lorg_neuroph_core_Neuron_Handler")]
		public virtual unsafe void Randomize (global::Org.Neuroph.Core.Neuron p0)
		{
			if (id_randomize_Lorg_neuroph_core_Neuron_ == IntPtr.Zero)
				id_randomize_Lorg_neuroph_core_Neuron_ = JNIEnv.GetMethodID (class_ref, "randomize", "(Lorg/neuroph/core/Neuron;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_randomize_Lorg_neuroph_core_Neuron_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "randomize", "(Lorg/neuroph/core/Neuron;)V"), __args);
			} finally {
			}
		}

	}
}
