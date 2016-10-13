using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Nnet.Learning {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.nnet.learning']/class[@name='KohonenLearning']"
	[global::Android.Runtime.Register ("org/neuroph/nnet/learning/KohonenLearning", DoNotGenerateAcw=true)]
	public partial class KohonenLearning : global::Org.Neuroph.Core.Learning.LearningRule {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/nnet/learning/KohonenLearning", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (KohonenLearning); }
		}

		protected KohonenLearning (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.nnet.learning']/class[@name='KohonenLearning']/constructor[@name='KohonenLearning' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe KohonenLearning ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (KohonenLearning)) {
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

		static Delegate cb_getIteration;
#pragma warning disable 0169
		static Delegate GetGetIterationHandler ()
		{
			if (cb_getIteration == null)
				cb_getIteration = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIteration);
			return cb_getIteration;
		}

		static IntPtr n_GetIteration (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Nnet.Learning.KohonenLearning __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Learning.KohonenLearning> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Iteration);
		}
#pragma warning restore 0169

		static IntPtr id_getIteration;
		public virtual unsafe global::Java.Lang.Integer Iteration {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.learning']/class[@name='KohonenLearning']/method[@name='getIteration' and count(parameter)=0]"
			[Register ("getIteration", "()Ljava/lang/Integer;", "GetGetIterationHandler")]
			get {
				if (id_getIteration == IntPtr.Zero)
					id_getIteration = JNIEnv.GetMethodID (class_ref, "getIteration", "()Ljava/lang/Integer;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getIteration), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIteration", "()Ljava/lang/Integer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getLearningRate;
#pragma warning disable 0169
		static Delegate GetGetLearningRateHandler ()
		{
			if (cb_getLearningRate == null)
				cb_getLearningRate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetLearningRate);
			return cb_getLearningRate;
		}

		static double n_GetLearningRate (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Nnet.Learning.KohonenLearning __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Learning.KohonenLearning> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LearningRate;
		}
#pragma warning restore 0169

		static Delegate cb_setLearningRate_D;
#pragma warning disable 0169
		static Delegate GetSetLearningRate_DHandler ()
		{
			if (cb_setLearningRate_D == null)
				cb_setLearningRate_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetLearningRate_D);
			return cb_setLearningRate_D;
		}

		static void n_SetLearningRate_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Org.Neuroph.Nnet.Learning.KohonenLearning __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Learning.KohonenLearning> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.LearningRate = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getLearningRate;
		static IntPtr id_setLearningRate_D;
		public virtual unsafe double LearningRate {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.learning']/class[@name='KohonenLearning']/method[@name='getLearningRate' and count(parameter)=0]"
			[Register ("getLearningRate", "()D", "GetGetLearningRateHandler")]
			get {
				if (id_getLearningRate == IntPtr.Zero)
					id_getLearningRate = JNIEnv.GetMethodID (class_ref, "getLearningRate", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getLearningRate);
					else
						return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLearningRate", "()D"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.learning']/class[@name='KohonenLearning']/method[@name='setLearningRate' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setLearningRate", "(D)V", "GetSetLearningRate_DHandler")]
			set {
				if (id_setLearningRate_D == IntPtr.Zero)
					id_setLearningRate_D = JNIEnv.GetMethodID (class_ref, "setLearningRate", "(D)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLearningRate_D, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLearningRate", "(D)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMapSize;
#pragma warning disable 0169
		static Delegate GetGetMapSizeHandler ()
		{
			if (cb_getMapSize == null)
				cb_getMapSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMapSize);
			return cb_getMapSize;
		}

		static int n_GetMapSize (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Nnet.Learning.KohonenLearning __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Learning.KohonenLearning> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MapSize;
		}
#pragma warning restore 0169

		static IntPtr id_getMapSize;
		public virtual unsafe int MapSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.learning']/class[@name='KohonenLearning']/method[@name='getMapSize' and count(parameter)=0]"
			[Register ("getMapSize", "()I", "GetGetMapSizeHandler")]
			get {
				if (id_getMapSize == IntPtr.Zero)
					id_getMapSize = JNIEnv.GetMethodID (class_ref, "getMapSize", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getMapSize);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMapSize", "()I"));
				} finally {
				}
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
			global::Org.Neuroph.Nnet.Learning.KohonenLearning __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Learning.KohonenLearning> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Core.Data.DataSet p0 = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Data.DataSet> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Learn (p0);
		}
#pragma warning restore 0169

		static IntPtr id_learn_Lorg_neuroph_core_data_DataSet_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.learning']/class[@name='KohonenLearning']/method[@name='learn' and count(parameter)=1 and parameter[1][@type='org.neuroph.core.data.DataSet']]"
		[Register ("learn", "(Lorg/neuroph/core/data/DataSet;)V", "GetLearn_Lorg_neuroph_core_data_DataSet_Handler")]
		public override unsafe void Learn (global::Org.Neuroph.Core.Data.DataSet p0)
		{
			if (id_learn_Lorg_neuroph_core_data_DataSet_ == IntPtr.Zero)
				id_learn_Lorg_neuroph_core_data_DataSet_ = JNIEnv.GetMethodID (class_ref, "learn", "(Lorg/neuroph/core/data/DataSet;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_learn_Lorg_neuroph_core_data_DataSet_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "learn", "(Lorg/neuroph/core/data/DataSet;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setIterations_II;
#pragma warning disable 0169
		static Delegate GetSetIterations_IIHandler ()
		{
			if (cb_setIterations_II == null)
				cb_setIterations_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_SetIterations_II);
			return cb_setIterations_II;
		}

		static void n_SetIterations_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Org.Neuroph.Nnet.Learning.KohonenLearning __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Learning.KohonenLearning> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetIterations (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setIterations_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.learning']/class[@name='KohonenLearning']/method[@name='setIterations' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("setIterations", "(II)V", "GetSetIterations_IIHandler")]
		public virtual unsafe void SetIterations (int p0, int p1)
		{
			if (id_setIterations_II == IntPtr.Zero)
				id_setIterations_II = JNIEnv.GetMethodID (class_ref, "setIterations", "(II)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setIterations_II, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setIterations", "(II)V"), __args);
			} finally {
			}
		}

	}
}
