using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Nnet.Learning {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.nnet.learning']/class[@name='ResilientPropagation']"
	[global::Android.Runtime.Register ("org/neuroph/nnet/learning/ResilientPropagation", DoNotGenerateAcw=true)]
	public partial class ResilientPropagation : global::Org.Neuroph.Nnet.Learning.BackPropagation {

		// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.nnet.learning']/class[@name='ResilientPropagation.ResilientWeightTrainingtData']"
		[global::Android.Runtime.Register ("org/neuroph/nnet/learning/ResilientPropagation$ResilientWeightTrainingtData", DoNotGenerateAcw=true)]
		public partial class ResilientWeightTrainingtData : global::Java.Lang.Object {


			static IntPtr gradient_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.neuroph.nnet.learning']/class[@name='ResilientPropagation.ResilientWeightTrainingtData']/field[@name='gradient']"
			[Register ("gradient")]
			public double Gradient {
				get {
					if (gradient_jfieldId == IntPtr.Zero)
						gradient_jfieldId = JNIEnv.GetFieldID (class_ref, "gradient", "D");
					return JNIEnv.GetDoubleField (((global::Java.Lang.Object) this).Handle, gradient_jfieldId);
				}
				set {
					if (gradient_jfieldId == IntPtr.Zero)
						gradient_jfieldId = JNIEnv.GetFieldID (class_ref, "gradient", "D");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, gradient_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr previousDelta_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.neuroph.nnet.learning']/class[@name='ResilientPropagation.ResilientWeightTrainingtData']/field[@name='previousDelta']"
			[Register ("previousDelta")]
			public double PreviousDelta {
				get {
					if (previousDelta_jfieldId == IntPtr.Zero)
						previousDelta_jfieldId = JNIEnv.GetFieldID (class_ref, "previousDelta", "D");
					return JNIEnv.GetDoubleField (((global::Java.Lang.Object) this).Handle, previousDelta_jfieldId);
				}
				set {
					if (previousDelta_jfieldId == IntPtr.Zero)
						previousDelta_jfieldId = JNIEnv.GetFieldID (class_ref, "previousDelta", "D");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, previousDelta_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr previousGradient_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.neuroph.nnet.learning']/class[@name='ResilientPropagation.ResilientWeightTrainingtData']/field[@name='previousGradient']"
			[Register ("previousGradient")]
			public double PreviousGradient {
				get {
					if (previousGradient_jfieldId == IntPtr.Zero)
						previousGradient_jfieldId = JNIEnv.GetFieldID (class_ref, "previousGradient", "D");
					return JNIEnv.GetDoubleField (((global::Java.Lang.Object) this).Handle, previousGradient_jfieldId);
				}
				set {
					if (previousGradient_jfieldId == IntPtr.Zero)
						previousGradient_jfieldId = JNIEnv.GetFieldID (class_ref, "previousGradient", "D");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, previousGradient_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr previousWeightChange_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.neuroph.nnet.learning']/class[@name='ResilientPropagation.ResilientWeightTrainingtData']/field[@name='previousWeightChange']"
			[Register ("previousWeightChange")]
			public double PreviousWeightChange {
				get {
					if (previousWeightChange_jfieldId == IntPtr.Zero)
						previousWeightChange_jfieldId = JNIEnv.GetFieldID (class_ref, "previousWeightChange", "D");
					return JNIEnv.GetDoubleField (((global::Java.Lang.Object) this).Handle, previousWeightChange_jfieldId);
				}
				set {
					if (previousWeightChange_jfieldId == IntPtr.Zero)
						previousWeightChange_jfieldId = JNIEnv.GetFieldID (class_ref, "previousWeightChange", "D");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, previousWeightChange_jfieldId, value);
					} finally {
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/neuroph/nnet/learning/ResilientPropagation$ResilientWeightTrainingtData", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ResilientWeightTrainingtData); }
			}

			protected ResilientWeightTrainingtData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lorg_neuroph_nnet_learning_ResilientPropagation_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.nnet.learning']/class[@name='ResilientPropagation.ResilientWeightTrainingtData']/constructor[@name='ResilientPropagation.ResilientWeightTrainingtData' and count(parameter)=1 and parameter[1][@type='org.neuroph.nnet.learning.ResilientPropagation']]"
			[Register (".ctor", "(Lorg/neuroph/nnet/learning/ResilientPropagation;)V", "")]
			public unsafe ResilientWeightTrainingtData (global::Org.Neuroph.Nnet.Learning.ResilientPropagation __self)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (__self);
					if (GetType () != typeof (ResilientWeightTrainingtData)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args);
						return;
					}

					if (id_ctor_Lorg_neuroph_nnet_learning_ResilientPropagation_ == IntPtr.Zero)
						id_ctor_Lorg_neuroph_nnet_learning_ResilientPropagation_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/neuroph/nnet/learning/ResilientPropagation;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_neuroph_nnet_learning_ResilientPropagation_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_neuroph_nnet_learning_ResilientPropagation_, __args);
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/nnet/learning/ResilientPropagation", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ResilientPropagation); }
		}

		protected ResilientPropagation (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.nnet.learning']/class[@name='ResilientPropagation']/constructor[@name='ResilientPropagation' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ResilientPropagation ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ResilientPropagation)) {
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

		static Delegate cb_getDecreaseFactor;
#pragma warning disable 0169
		static Delegate GetGetDecreaseFactorHandler ()
		{
			if (cb_getDecreaseFactor == null)
				cb_getDecreaseFactor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetDecreaseFactor);
			return cb_getDecreaseFactor;
		}

		static double n_GetDecreaseFactor (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Nnet.Learning.ResilientPropagation __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Learning.ResilientPropagation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DecreaseFactor;
		}
#pragma warning restore 0169

		static Delegate cb_setDecreaseFactor_D;
#pragma warning disable 0169
		static Delegate GetSetDecreaseFactor_DHandler ()
		{
			if (cb_setDecreaseFactor_D == null)
				cb_setDecreaseFactor_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetDecreaseFactor_D);
			return cb_setDecreaseFactor_D;
		}

		static void n_SetDecreaseFactor_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Org.Neuroph.Nnet.Learning.ResilientPropagation __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Learning.ResilientPropagation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DecreaseFactor = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDecreaseFactor;
		static IntPtr id_setDecreaseFactor_D;
		public virtual unsafe double DecreaseFactor {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.learning']/class[@name='ResilientPropagation']/method[@name='getDecreaseFactor' and count(parameter)=0]"
			[Register ("getDecreaseFactor", "()D", "GetGetDecreaseFactorHandler")]
			get {
				if (id_getDecreaseFactor == IntPtr.Zero)
					id_getDecreaseFactor = JNIEnv.GetMethodID (class_ref, "getDecreaseFactor", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getDecreaseFactor);
					else
						return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDecreaseFactor", "()D"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.learning']/class[@name='ResilientPropagation']/method[@name='setDecreaseFactor' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setDecreaseFactor", "(D)V", "GetSetDecreaseFactor_DHandler")]
			set {
				if (id_setDecreaseFactor_D == IntPtr.Zero)
					id_setDecreaseFactor_D = JNIEnv.GetMethodID (class_ref, "setDecreaseFactor", "(D)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDecreaseFactor_D, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDecreaseFactor", "(D)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getIncreaseFactor;
#pragma warning disable 0169
		static Delegate GetGetIncreaseFactorHandler ()
		{
			if (cb_getIncreaseFactor == null)
				cb_getIncreaseFactor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetIncreaseFactor);
			return cb_getIncreaseFactor;
		}

		static double n_GetIncreaseFactor (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Nnet.Learning.ResilientPropagation __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Learning.ResilientPropagation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IncreaseFactor;
		}
#pragma warning restore 0169

		static Delegate cb_setIncreaseFactor_D;
#pragma warning disable 0169
		static Delegate GetSetIncreaseFactor_DHandler ()
		{
			if (cb_setIncreaseFactor_D == null)
				cb_setIncreaseFactor_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetIncreaseFactor_D);
			return cb_setIncreaseFactor_D;
		}

		static void n_SetIncreaseFactor_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Org.Neuroph.Nnet.Learning.ResilientPropagation __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Learning.ResilientPropagation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.IncreaseFactor = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getIncreaseFactor;
		static IntPtr id_setIncreaseFactor_D;
		public virtual unsafe double IncreaseFactor {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.learning']/class[@name='ResilientPropagation']/method[@name='getIncreaseFactor' and count(parameter)=0]"
			[Register ("getIncreaseFactor", "()D", "GetGetIncreaseFactorHandler")]
			get {
				if (id_getIncreaseFactor == IntPtr.Zero)
					id_getIncreaseFactor = JNIEnv.GetMethodID (class_ref, "getIncreaseFactor", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getIncreaseFactor);
					else
						return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIncreaseFactor", "()D"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.learning']/class[@name='ResilientPropagation']/method[@name='setIncreaseFactor' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setIncreaseFactor", "(D)V", "GetSetIncreaseFactor_DHandler")]
			set {
				if (id_setIncreaseFactor_D == IntPtr.Zero)
					id_setIncreaseFactor_D = JNIEnv.GetMethodID (class_ref, "setIncreaseFactor", "(D)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setIncreaseFactor_D, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setIncreaseFactor", "(D)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getInitialDelta;
#pragma warning disable 0169
		static Delegate GetGetInitialDeltaHandler ()
		{
			if (cb_getInitialDelta == null)
				cb_getInitialDelta = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetInitialDelta);
			return cb_getInitialDelta;
		}

		static double n_GetInitialDelta (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Nnet.Learning.ResilientPropagation __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Learning.ResilientPropagation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.InitialDelta;
		}
#pragma warning restore 0169

		static Delegate cb_setInitialDelta_D;
#pragma warning disable 0169
		static Delegate GetSetInitialDelta_DHandler ()
		{
			if (cb_setInitialDelta_D == null)
				cb_setInitialDelta_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetInitialDelta_D);
			return cb_setInitialDelta_D;
		}

		static void n_SetInitialDelta_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Org.Neuroph.Nnet.Learning.ResilientPropagation __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Learning.ResilientPropagation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.InitialDelta = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getInitialDelta;
		static IntPtr id_setInitialDelta_D;
		public virtual unsafe double InitialDelta {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.learning']/class[@name='ResilientPropagation']/method[@name='getInitialDelta' and count(parameter)=0]"
			[Register ("getInitialDelta", "()D", "GetGetInitialDeltaHandler")]
			get {
				if (id_getInitialDelta == IntPtr.Zero)
					id_getInitialDelta = JNIEnv.GetMethodID (class_ref, "getInitialDelta", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getInitialDelta);
					else
						return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getInitialDelta", "()D"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.learning']/class[@name='ResilientPropagation']/method[@name='setInitialDelta' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setInitialDelta", "(D)V", "GetSetInitialDelta_DHandler")]
			set {
				if (id_setInitialDelta_D == IntPtr.Zero)
					id_setInitialDelta_D = JNIEnv.GetMethodID (class_ref, "setInitialDelta", "(D)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setInitialDelta_D, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setInitialDelta", "(D)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMaxDelta;
#pragma warning disable 0169
		static Delegate GetGetMaxDeltaHandler ()
		{
			if (cb_getMaxDelta == null)
				cb_getMaxDelta = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetMaxDelta);
			return cb_getMaxDelta;
		}

		static double n_GetMaxDelta (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Nnet.Learning.ResilientPropagation __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Learning.ResilientPropagation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxDelta;
		}
#pragma warning restore 0169

		static Delegate cb_setMaxDelta_D;
#pragma warning disable 0169
		static Delegate GetSetMaxDelta_DHandler ()
		{
			if (cb_setMaxDelta_D == null)
				cb_setMaxDelta_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetMaxDelta_D);
			return cb_setMaxDelta_D;
		}

		static void n_SetMaxDelta_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Org.Neuroph.Nnet.Learning.ResilientPropagation __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Learning.ResilientPropagation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MaxDelta = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMaxDelta;
		static IntPtr id_setMaxDelta_D;
		public virtual unsafe double MaxDelta {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.learning']/class[@name='ResilientPropagation']/method[@name='getMaxDelta' and count(parameter)=0]"
			[Register ("getMaxDelta", "()D", "GetGetMaxDeltaHandler")]
			get {
				if (id_getMaxDelta == IntPtr.Zero)
					id_getMaxDelta = JNIEnv.GetMethodID (class_ref, "getMaxDelta", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getMaxDelta);
					else
						return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMaxDelta", "()D"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.learning']/class[@name='ResilientPropagation']/method[@name='setMaxDelta' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setMaxDelta", "(D)V", "GetSetMaxDelta_DHandler")]
			set {
				if (id_setMaxDelta_D == IntPtr.Zero)
					id_setMaxDelta_D = JNIEnv.GetMethodID (class_ref, "setMaxDelta", "(D)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMaxDelta_D, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMaxDelta", "(D)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMinDelta;
#pragma warning disable 0169
		static Delegate GetGetMinDeltaHandler ()
		{
			if (cb_getMinDelta == null)
				cb_getMinDelta = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetMinDelta);
			return cb_getMinDelta;
		}

		static double n_GetMinDelta (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Nnet.Learning.ResilientPropagation __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Learning.ResilientPropagation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MinDelta;
		}
#pragma warning restore 0169

		static Delegate cb_setMinDelta_D;
#pragma warning disable 0169
		static Delegate GetSetMinDelta_DHandler ()
		{
			if (cb_setMinDelta_D == null)
				cb_setMinDelta_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetMinDelta_D);
			return cb_setMinDelta_D;
		}

		static void n_SetMinDelta_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Org.Neuroph.Nnet.Learning.ResilientPropagation __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Learning.ResilientPropagation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MinDelta = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMinDelta;
		static IntPtr id_setMinDelta_D;
		public virtual unsafe double MinDelta {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.learning']/class[@name='ResilientPropagation']/method[@name='getMinDelta' and count(parameter)=0]"
			[Register ("getMinDelta", "()D", "GetGetMinDeltaHandler")]
			get {
				if (id_getMinDelta == IntPtr.Zero)
					id_getMinDelta = JNIEnv.GetMethodID (class_ref, "getMinDelta", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getMinDelta);
					else
						return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMinDelta", "()D"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.learning']/class[@name='ResilientPropagation']/method[@name='setMinDelta' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setMinDelta", "(D)V", "GetSetMinDelta_DHandler")]
			set {
				if (id_setMinDelta_D == IntPtr.Zero)
					id_setMinDelta_D = JNIEnv.GetMethodID (class_ref, "setMinDelta", "(D)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMinDelta_D, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMinDelta", "(D)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_resillientWeightUpdate_Lorg_neuroph_core_Weight_;
#pragma warning disable 0169
		static Delegate GetResillientWeightUpdate_Lorg_neuroph_core_Weight_Handler ()
		{
			if (cb_resillientWeightUpdate_Lorg_neuroph_core_Weight_ == null)
				cb_resillientWeightUpdate_Lorg_neuroph_core_Weight_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ResillientWeightUpdate_Lorg_neuroph_core_Weight_);
			return cb_resillientWeightUpdate_Lorg_neuroph_core_Weight_;
		}

		static void n_ResillientWeightUpdate_Lorg_neuroph_core_Weight_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Nnet.Learning.ResilientPropagation __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Learning.ResilientPropagation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Core.Weight p0 = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Weight> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ResillientWeightUpdate (p0);
		}
#pragma warning restore 0169

		static IntPtr id_resillientWeightUpdate_Lorg_neuroph_core_Weight_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.learning']/class[@name='ResilientPropagation']/method[@name='resillientWeightUpdate' and count(parameter)=1 and parameter[1][@type='org.neuroph.core.Weight']]"
		[Register ("resillientWeightUpdate", "(Lorg/neuroph/core/Weight;)V", "GetResillientWeightUpdate_Lorg_neuroph_core_Weight_Handler")]
		protected virtual unsafe void ResillientWeightUpdate (global::Org.Neuroph.Core.Weight p0)
		{
			if (id_resillientWeightUpdate_Lorg_neuroph_core_Weight_ == IntPtr.Zero)
				id_resillientWeightUpdate_Lorg_neuroph_core_Weight_ = JNIEnv.GetMethodID (class_ref, "resillientWeightUpdate", "(Lorg/neuroph/core/Weight;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_resillientWeightUpdate_Lorg_neuroph_core_Weight_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "resillientWeightUpdate", "(Lorg/neuroph/core/Weight;)V"), __args);
			} finally {
			}
		}

	}
}
