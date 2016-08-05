using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Nnet.Learning {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.nnet.learning']/class[@name='MomentumBackpropagation']"
	[global::Android.Runtime.Register ("org/neuroph/nnet/learning/MomentumBackpropagation", DoNotGenerateAcw=true)]
	public partial class MomentumBackpropagation : global::Org.Neuroph.Nnet.Learning.BackPropagation {

		// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.nnet.learning']/class[@name='MomentumBackpropagation.MomentumWeightTrainingData']"
		[global::Android.Runtime.Register ("org/neuroph/nnet/learning/MomentumBackpropagation$MomentumWeightTrainingData", DoNotGenerateAcw=true)]
		public partial class MomentumWeightTrainingData : global::Java.Lang.Object {


			static IntPtr previousValue_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.neuroph.nnet.learning']/class[@name='MomentumBackpropagation.MomentumWeightTrainingData']/field[@name='previousValue']"
			[Register ("previousValue")]
			public double PreviousValue {
				get {
					if (previousValue_jfieldId == IntPtr.Zero)
						previousValue_jfieldId = JNIEnv.GetFieldID (class_ref, "previousValue", "D");
					return JNIEnv.GetDoubleField (Handle, previousValue_jfieldId);
				}
				set {
					if (previousValue_jfieldId == IntPtr.Zero)
						previousValue_jfieldId = JNIEnv.GetFieldID (class_ref, "previousValue", "D");
					try {
						JNIEnv.SetField (Handle, previousValue_jfieldId, value);
					} finally {
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/neuroph/nnet/learning/MomentumBackpropagation$MomentumWeightTrainingData", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (MomentumWeightTrainingData); }
			}

			protected MomentumWeightTrainingData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lorg_neuroph_nnet_learning_MomentumBackpropagation_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.nnet.learning']/class[@name='MomentumBackpropagation.MomentumWeightTrainingData']/constructor[@name='MomentumBackpropagation.MomentumWeightTrainingData' and count(parameter)=1 and parameter[1][@type='org.neuroph.nnet.learning.MomentumBackpropagation']]"
			[Register (".ctor", "(Lorg/neuroph/nnet/learning/MomentumBackpropagation;)V", "")]
			public unsafe MomentumWeightTrainingData (global::Org.Neuroph.Nnet.Learning.MomentumBackpropagation __self)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (__self);
					if (GetType () != typeof (MomentumWeightTrainingData)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args);
						return;
					}

					if (id_ctor_Lorg_neuroph_nnet_learning_MomentumBackpropagation_ == IntPtr.Zero)
						id_ctor_Lorg_neuroph_nnet_learning_MomentumBackpropagation_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/neuroph/nnet/learning/MomentumBackpropagation;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_neuroph_nnet_learning_MomentumBackpropagation_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_neuroph_nnet_learning_MomentumBackpropagation_, __args);
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/nnet/learning/MomentumBackpropagation", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MomentumBackpropagation); }
		}

		protected MomentumBackpropagation (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.nnet.learning']/class[@name='MomentumBackpropagation']/constructor[@name='MomentumBackpropagation' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MomentumBackpropagation ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (MomentumBackpropagation)) {
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

		static Delegate cb_getMomentum;
#pragma warning disable 0169
		static Delegate GetGetMomentumHandler ()
		{
			if (cb_getMomentum == null)
				cb_getMomentum = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetMomentum);
			return cb_getMomentum;
		}

		static double n_GetMomentum (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Nnet.Learning.MomentumBackpropagation __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Learning.MomentumBackpropagation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Momentum;
		}
#pragma warning restore 0169

		static Delegate cb_setMomentum_D;
#pragma warning disable 0169
		static Delegate GetSetMomentum_DHandler ()
		{
			if (cb_setMomentum_D == null)
				cb_setMomentum_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetMomentum_D);
			return cb_setMomentum_D;
		}

		static void n_SetMomentum_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Org.Neuroph.Nnet.Learning.MomentumBackpropagation __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Learning.MomentumBackpropagation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Momentum = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMomentum;
		static IntPtr id_setMomentum_D;
		public virtual unsafe double Momentum {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.learning']/class[@name='MomentumBackpropagation']/method[@name='getMomentum' and count(parameter)=0]"
			[Register ("getMomentum", "()D", "GetGetMomentumHandler")]
			get {
				if (id_getMomentum == IntPtr.Zero)
					id_getMomentum = JNIEnv.GetMethodID (class_ref, "getMomentum", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod  (Handle, id_getMomentum);
					else
						return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMomentum", "()D"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.learning']/class[@name='MomentumBackpropagation']/method[@name='setMomentum' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setMomentum", "(D)V", "GetSetMomentum_DHandler")]
			set {
				if (id_setMomentum_D == IntPtr.Zero)
					id_setMomentum_D = JNIEnv.GetMethodID (class_ref, "setMomentum", "(D)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setMomentum_D, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMomentum", "(D)V"), __args);
				} finally {
				}
			}
		}

	}
}
