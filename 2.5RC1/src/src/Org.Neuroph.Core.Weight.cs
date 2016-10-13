using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.core']/class[@name='Weight']"
	[global::Android.Runtime.Register ("org/neuroph/core/Weight", DoNotGenerateAcw=true)]
	public partial class Weight : global::Java.Lang.Object, global::Java.IO.ISerializable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/core/Weight", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Weight); }
		}

		protected Weight (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.core']/class[@name='Weight']/constructor[@name='Weight' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Weight ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Weight)) {
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

		static IntPtr id_ctor_D;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.core']/class[@name='Weight']/constructor[@name='Weight' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register (".ctor", "(D)V", "")]
		public unsafe Weight (double p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (Weight)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(D)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(D)V", __args);
					return;
				}

				if (id_ctor_D == IntPtr.Zero)
					id_ctor_D = JNIEnv.GetMethodID (class_ref, "<init>", "(D)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_D, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_D, __args);
			} finally {
			}
		}

		static Delegate cb_getTrainingData;
#pragma warning disable 0169
		static Delegate GetGetTrainingDataHandler ()
		{
			if (cb_getTrainingData == null)
				cb_getTrainingData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTrainingData);
			return cb_getTrainingData;
		}

		static IntPtr n_GetTrainingData (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Core.Weight __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Weight> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TrainingData);
		}
#pragma warning restore 0169

		static IntPtr id_getTrainingData;
		public virtual unsafe global::Org.Neuroph.Core.Learning.TrainingData TrainingData {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='Weight']/method[@name='getTrainingData' and count(parameter)=0]"
			[Register ("getTrainingData", "()Lorg/neuroph/core/learning/TrainingData;", "GetGetTrainingDataHandler")]
			get {
				if (id_getTrainingData == IntPtr.Zero)
					id_getTrainingData = JNIEnv.GetMethodID (class_ref, "getTrainingData", "()Lorg/neuroph/core/learning/TrainingData;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.TrainingData> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTrainingData), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.TrainingData> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTrainingData", "()Lorg/neuroph/core/learning/TrainingData;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getValue;
#pragma warning disable 0169
		static Delegate GetGetValueHandler ()
		{
			if (cb_getValue == null)
				cb_getValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetValue);
			return cb_getValue;
		}

		static double n_GetValue (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Core.Weight __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Weight> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Value;
		}
#pragma warning restore 0169

		static Delegate cb_setValue_D;
#pragma warning disable 0169
		static Delegate GetSetValue_DHandler ()
		{
			if (cb_setValue_D == null)
				cb_setValue_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetValue_D);
			return cb_setValue_D;
		}

		static void n_SetValue_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Org.Neuroph.Core.Weight __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Weight> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Value = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getValue;
		static IntPtr id_setValue_D;
		public virtual unsafe double Value {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='Weight']/method[@name='getValue' and count(parameter)=0]"
			[Register ("getValue", "()D", "GetGetValueHandler")]
			get {
				if (id_getValue == IntPtr.Zero)
					id_getValue = JNIEnv.GetMethodID (class_ref, "getValue", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getValue);
					else
						return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getValue", "()D"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='Weight']/method[@name='setValue' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setValue", "(D)V", "GetSetValue_DHandler")]
			set {
				if (id_setValue_D == IntPtr.Zero)
					id_setValue_D = JNIEnv.GetMethodID (class_ref, "setValue", "(D)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setValue_D, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setValue", "(D)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_dec_D;
#pragma warning disable 0169
		static Delegate GetDec_DHandler ()
		{
			if (cb_dec_D == null)
				cb_dec_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_Dec_D);
			return cb_dec_D;
		}

		static void n_Dec_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Org.Neuroph.Core.Weight __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Weight> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Dec (p0);
		}
#pragma warning restore 0169

		static IntPtr id_dec_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='Weight']/method[@name='dec' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("dec", "(D)V", "GetDec_DHandler")]
		public virtual unsafe void Dec (double p0)
		{
			if (id_dec_D == IntPtr.Zero)
				id_dec_D = JNIEnv.GetMethodID (class_ref, "dec", "(D)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_dec_D, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "dec", "(D)V"), __args);
			} finally {
			}
		}

		static Delegate cb_inc_D;
#pragma warning disable 0169
		static Delegate GetInc_DHandler ()
		{
			if (cb_inc_D == null)
				cb_inc_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_Inc_D);
			return cb_inc_D;
		}

		static void n_Inc_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Org.Neuroph.Core.Weight __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Weight> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Inc (p0);
		}
#pragma warning restore 0169

		static IntPtr id_inc_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='Weight']/method[@name='inc' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("inc", "(D)V", "GetInc_DHandler")]
		public virtual unsafe void Inc (double p0)
		{
			if (id_inc_D == IntPtr.Zero)
				id_inc_D = JNIEnv.GetMethodID (class_ref, "inc", "(D)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_inc_D, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "inc", "(D)V"), __args);
			} finally {
			}
		}

		static Delegate cb_initTrainingDataBuffer_I;
#pragma warning disable 0169
		static Delegate GetInitTrainingDataBuffer_IHandler ()
		{
			if (cb_initTrainingDataBuffer_I == null)
				cb_initTrainingDataBuffer_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_InitTrainingDataBuffer_I);
			return cb_initTrainingDataBuffer_I;
		}

		static void n_InitTrainingDataBuffer_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Neuroph.Core.Weight __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Weight> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.InitTrainingDataBuffer (p0);
		}
#pragma warning restore 0169

		static IntPtr id_initTrainingDataBuffer_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='Weight']/method[@name='initTrainingDataBuffer' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("initTrainingDataBuffer", "(I)V", "GetInitTrainingDataBuffer_IHandler")]
		public virtual unsafe void InitTrainingDataBuffer (int p0)
		{
			if (id_initTrainingDataBuffer_I == IntPtr.Zero)
				id_initTrainingDataBuffer_I = JNIEnv.GetMethodID (class_ref, "initTrainingDataBuffer", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_initTrainingDataBuffer_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "initTrainingDataBuffer", "(I)V"), __args);
			} finally {
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
			global::Org.Neuroph.Core.Weight __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Weight> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Randomize ();
		}
#pragma warning restore 0169

		static IntPtr id_randomize;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='Weight']/method[@name='randomize' and count(parameter)=0]"
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

		static Delegate cb_randomize_DD;
#pragma warning disable 0169
		static Delegate GetRandomize_DDHandler ()
		{
			if (cb_randomize_DD == null)
				cb_randomize_DD = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double, double>) n_Randomize_DD);
			return cb_randomize_DD;
		}

		static void n_Randomize_DD (IntPtr jnienv, IntPtr native__this, double p0, double p1)
		{
			global::Org.Neuroph.Core.Weight __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Weight> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Randomize (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_randomize_DD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='Weight']/method[@name='randomize' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='double']]"
		[Register ("randomize", "(DD)V", "GetRandomize_DDHandler")]
		public virtual unsafe void Randomize (double p0, double p1)
		{
			if (id_randomize_DD == IntPtr.Zero)
				id_randomize_DD = JNIEnv.GetMethodID (class_ref, "randomize", "(DD)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_randomize_DD, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "randomize", "(DD)V"), __args);
			} finally {
			}
		}

	}
}
