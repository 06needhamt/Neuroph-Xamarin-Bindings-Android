using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Nnet.Learning {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.nnet.learning']/class[@name='DynamicBackPropagation']"
	[global::Android.Runtime.Register ("org/neuroph/nnet/learning/DynamicBackPropagation", DoNotGenerateAcw=true)]
	public partial class DynamicBackPropagation : global::Org.Neuroph.Nnet.Learning.MomentumBackpropagation {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/nnet/learning/DynamicBackPropagation", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DynamicBackPropagation); }
		}

		protected DynamicBackPropagation (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.nnet.learning']/class[@name='DynamicBackPropagation']/constructor[@name='DynamicBackPropagation' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DynamicBackPropagation ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (DynamicBackPropagation)) {
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

		static Delegate cb_getLearningRateChange;
#pragma warning disable 0169
		static Delegate GetGetLearningRateChangeHandler ()
		{
			if (cb_getLearningRateChange == null)
				cb_getLearningRateChange = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetLearningRateChange);
			return cb_getLearningRateChange;
		}

		static double n_GetLearningRateChange (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Nnet.Learning.DynamicBackPropagation __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Learning.DynamicBackPropagation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LearningRateChange;
		}
#pragma warning restore 0169

		static Delegate cb_setLearningRateChange_D;
#pragma warning disable 0169
		static Delegate GetSetLearningRateChange_DHandler ()
		{
			if (cb_setLearningRateChange_D == null)
				cb_setLearningRateChange_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetLearningRateChange_D);
			return cb_setLearningRateChange_D;
		}

		static void n_SetLearningRateChange_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Org.Neuroph.Nnet.Learning.DynamicBackPropagation __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Learning.DynamicBackPropagation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.LearningRateChange = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getLearningRateChange;
		static IntPtr id_setLearningRateChange_D;
		public virtual unsafe double LearningRateChange {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.learning']/class[@name='DynamicBackPropagation']/method[@name='getLearningRateChange' and count(parameter)=0]"
			[Register ("getLearningRateChange", "()D", "GetGetLearningRateChangeHandler")]
			get {
				if (id_getLearningRateChange == IntPtr.Zero)
					id_getLearningRateChange = JNIEnv.GetMethodID (class_ref, "getLearningRateChange", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod  (Handle, id_getLearningRateChange);
					else
						return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLearningRateChange", "()D"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.learning']/class[@name='DynamicBackPropagation']/method[@name='setLearningRateChange' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setLearningRateChange", "(D)V", "GetSetLearningRateChange_DHandler")]
			set {
				if (id_setLearningRateChange_D == IntPtr.Zero)
					id_setLearningRateChange_D = JNIEnv.GetMethodID (class_ref, "setLearningRateChange", "(D)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setLearningRateChange_D, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLearningRateChange", "(D)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMaxLearningRate;
#pragma warning disable 0169
		static Delegate GetGetMaxLearningRateHandler ()
		{
			if (cb_getMaxLearningRate == null)
				cb_getMaxLearningRate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetMaxLearningRate);
			return cb_getMaxLearningRate;
		}

		static double n_GetMaxLearningRate (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Nnet.Learning.DynamicBackPropagation __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Learning.DynamicBackPropagation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxLearningRate;
		}
#pragma warning restore 0169

		static Delegate cb_setMaxLearningRate_D;
#pragma warning disable 0169
		static Delegate GetSetMaxLearningRate_DHandler ()
		{
			if (cb_setMaxLearningRate_D == null)
				cb_setMaxLearningRate_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetMaxLearningRate_D);
			return cb_setMaxLearningRate_D;
		}

		static void n_SetMaxLearningRate_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Org.Neuroph.Nnet.Learning.DynamicBackPropagation __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Learning.DynamicBackPropagation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MaxLearningRate = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMaxLearningRate;
		static IntPtr id_setMaxLearningRate_D;
		public virtual unsafe double MaxLearningRate {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.learning']/class[@name='DynamicBackPropagation']/method[@name='getMaxLearningRate' and count(parameter)=0]"
			[Register ("getMaxLearningRate", "()D", "GetGetMaxLearningRateHandler")]
			get {
				if (id_getMaxLearningRate == IntPtr.Zero)
					id_getMaxLearningRate = JNIEnv.GetMethodID (class_ref, "getMaxLearningRate", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod  (Handle, id_getMaxLearningRate);
					else
						return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMaxLearningRate", "()D"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.learning']/class[@name='DynamicBackPropagation']/method[@name='setMaxLearningRate' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setMaxLearningRate", "(D)V", "GetSetMaxLearningRate_DHandler")]
			set {
				if (id_setMaxLearningRate_D == IntPtr.Zero)
					id_setMaxLearningRate_D = JNIEnv.GetMethodID (class_ref, "setMaxLearningRate", "(D)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setMaxLearningRate_D, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMaxLearningRate", "(D)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMaxMomentum;
#pragma warning disable 0169
		static Delegate GetGetMaxMomentumHandler ()
		{
			if (cb_getMaxMomentum == null)
				cb_getMaxMomentum = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetMaxMomentum);
			return cb_getMaxMomentum;
		}

		static double n_GetMaxMomentum (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Nnet.Learning.DynamicBackPropagation __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Learning.DynamicBackPropagation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxMomentum;
		}
#pragma warning restore 0169

		static Delegate cb_setMaxMomentum_D;
#pragma warning disable 0169
		static Delegate GetSetMaxMomentum_DHandler ()
		{
			if (cb_setMaxMomentum_D == null)
				cb_setMaxMomentum_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetMaxMomentum_D);
			return cb_setMaxMomentum_D;
		}

		static void n_SetMaxMomentum_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Org.Neuroph.Nnet.Learning.DynamicBackPropagation __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Learning.DynamicBackPropagation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MaxMomentum = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMaxMomentum;
		static IntPtr id_setMaxMomentum_D;
		public virtual unsafe double MaxMomentum {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.learning']/class[@name='DynamicBackPropagation']/method[@name='getMaxMomentum' and count(parameter)=0]"
			[Register ("getMaxMomentum", "()D", "GetGetMaxMomentumHandler")]
			get {
				if (id_getMaxMomentum == IntPtr.Zero)
					id_getMaxMomentum = JNIEnv.GetMethodID (class_ref, "getMaxMomentum", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod  (Handle, id_getMaxMomentum);
					else
						return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMaxMomentum", "()D"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.learning']/class[@name='DynamicBackPropagation']/method[@name='setMaxMomentum' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setMaxMomentum", "(D)V", "GetSetMaxMomentum_DHandler")]
			set {
				if (id_setMaxMomentum_D == IntPtr.Zero)
					id_setMaxMomentum_D = JNIEnv.GetMethodID (class_ref, "setMaxMomentum", "(D)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setMaxMomentum_D, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMaxMomentum", "(D)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMinLearningRate;
#pragma warning disable 0169
		static Delegate GetGetMinLearningRateHandler ()
		{
			if (cb_getMinLearningRate == null)
				cb_getMinLearningRate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetMinLearningRate);
			return cb_getMinLearningRate;
		}

		static double n_GetMinLearningRate (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Nnet.Learning.DynamicBackPropagation __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Learning.DynamicBackPropagation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MinLearningRate;
		}
#pragma warning restore 0169

		static Delegate cb_setMinLearningRate_D;
#pragma warning disable 0169
		static Delegate GetSetMinLearningRate_DHandler ()
		{
			if (cb_setMinLearningRate_D == null)
				cb_setMinLearningRate_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetMinLearningRate_D);
			return cb_setMinLearningRate_D;
		}

		static void n_SetMinLearningRate_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Org.Neuroph.Nnet.Learning.DynamicBackPropagation __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Learning.DynamicBackPropagation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MinLearningRate = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMinLearningRate;
		static IntPtr id_setMinLearningRate_D;
		public virtual unsafe double MinLearningRate {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.learning']/class[@name='DynamicBackPropagation']/method[@name='getMinLearningRate' and count(parameter)=0]"
			[Register ("getMinLearningRate", "()D", "GetGetMinLearningRateHandler")]
			get {
				if (id_getMinLearningRate == IntPtr.Zero)
					id_getMinLearningRate = JNIEnv.GetMethodID (class_ref, "getMinLearningRate", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod  (Handle, id_getMinLearningRate);
					else
						return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMinLearningRate", "()D"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.learning']/class[@name='DynamicBackPropagation']/method[@name='setMinLearningRate' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setMinLearningRate", "(D)V", "GetSetMinLearningRate_DHandler")]
			set {
				if (id_setMinLearningRate_D == IntPtr.Zero)
					id_setMinLearningRate_D = JNIEnv.GetMethodID (class_ref, "setMinLearningRate", "(D)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setMinLearningRate_D, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMinLearningRate", "(D)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMinMomentum;
#pragma warning disable 0169
		static Delegate GetGetMinMomentumHandler ()
		{
			if (cb_getMinMomentum == null)
				cb_getMinMomentum = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetMinMomentum);
			return cb_getMinMomentum;
		}

		static double n_GetMinMomentum (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Nnet.Learning.DynamicBackPropagation __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Learning.DynamicBackPropagation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MinMomentum;
		}
#pragma warning restore 0169

		static Delegate cb_setMinMomentum_D;
#pragma warning disable 0169
		static Delegate GetSetMinMomentum_DHandler ()
		{
			if (cb_setMinMomentum_D == null)
				cb_setMinMomentum_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetMinMomentum_D);
			return cb_setMinMomentum_D;
		}

		static void n_SetMinMomentum_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Org.Neuroph.Nnet.Learning.DynamicBackPropagation __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Learning.DynamicBackPropagation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MinMomentum = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMinMomentum;
		static IntPtr id_setMinMomentum_D;
		public virtual unsafe double MinMomentum {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.learning']/class[@name='DynamicBackPropagation']/method[@name='getMinMomentum' and count(parameter)=0]"
			[Register ("getMinMomentum", "()D", "GetGetMinMomentumHandler")]
			get {
				if (id_getMinMomentum == IntPtr.Zero)
					id_getMinMomentum = JNIEnv.GetMethodID (class_ref, "getMinMomentum", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod  (Handle, id_getMinMomentum);
					else
						return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMinMomentum", "()D"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.learning']/class[@name='DynamicBackPropagation']/method[@name='setMinMomentum' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setMinMomentum", "(D)V", "GetSetMinMomentum_DHandler")]
			set {
				if (id_setMinMomentum_D == IntPtr.Zero)
					id_setMinMomentum_D = JNIEnv.GetMethodID (class_ref, "setMinMomentum", "(D)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setMinMomentum_D, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMinMomentum", "(D)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMomentumChange;
#pragma warning disable 0169
		static Delegate GetGetMomentumChangeHandler ()
		{
			if (cb_getMomentumChange == null)
				cb_getMomentumChange = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetMomentumChange);
			return cb_getMomentumChange;
		}

		static double n_GetMomentumChange (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Nnet.Learning.DynamicBackPropagation __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Learning.DynamicBackPropagation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MomentumChange;
		}
#pragma warning restore 0169

		static Delegate cb_setMomentumChange_D;
#pragma warning disable 0169
		static Delegate GetSetMomentumChange_DHandler ()
		{
			if (cb_setMomentumChange_D == null)
				cb_setMomentumChange_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetMomentumChange_D);
			return cb_setMomentumChange_D;
		}

		static void n_SetMomentumChange_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Org.Neuroph.Nnet.Learning.DynamicBackPropagation __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Learning.DynamicBackPropagation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MomentumChange = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMomentumChange;
		static IntPtr id_setMomentumChange_D;
		public virtual unsafe double MomentumChange {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.learning']/class[@name='DynamicBackPropagation']/method[@name='getMomentumChange' and count(parameter)=0]"
			[Register ("getMomentumChange", "()D", "GetGetMomentumChangeHandler")]
			get {
				if (id_getMomentumChange == IntPtr.Zero)
					id_getMomentumChange = JNIEnv.GetMethodID (class_ref, "getMomentumChange", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod  (Handle, id_getMomentumChange);
					else
						return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMomentumChange", "()D"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.learning']/class[@name='DynamicBackPropagation']/method[@name='setMomentumChange' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setMomentumChange", "(D)V", "GetSetMomentumChange_DHandler")]
			set {
				if (id_setMomentumChange_D == IntPtr.Zero)
					id_setMomentumChange_D = JNIEnv.GetMethodID (class_ref, "setMomentumChange", "(D)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setMomentumChange_D, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMomentumChange", "(D)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getUseDynamicLearningRate;
#pragma warning disable 0169
		static Delegate GetGetUseDynamicLearningRateHandler ()
		{
			if (cb_getUseDynamicLearningRate == null)
				cb_getUseDynamicLearningRate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetUseDynamicLearningRate);
			return cb_getUseDynamicLearningRate;
		}

		static bool n_GetUseDynamicLearningRate (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Nnet.Learning.DynamicBackPropagation __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Learning.DynamicBackPropagation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UseDynamicLearningRate;
		}
#pragma warning restore 0169

		static Delegate cb_setUseDynamicLearningRate_Z;
#pragma warning disable 0169
		static Delegate GetSetUseDynamicLearningRate_ZHandler ()
		{
			if (cb_setUseDynamicLearningRate_Z == null)
				cb_setUseDynamicLearningRate_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetUseDynamicLearningRate_Z);
			return cb_setUseDynamicLearningRate_Z;
		}

		static void n_SetUseDynamicLearningRate_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Org.Neuroph.Nnet.Learning.DynamicBackPropagation __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Learning.DynamicBackPropagation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UseDynamicLearningRate = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getUseDynamicLearningRate;
		static IntPtr id_setUseDynamicLearningRate_Z;
		public virtual unsafe bool UseDynamicLearningRate {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.learning']/class[@name='DynamicBackPropagation']/method[@name='getUseDynamicLearningRate' and count(parameter)=0]"
			[Register ("getUseDynamicLearningRate", "()Z", "GetGetUseDynamicLearningRateHandler")]
			get {
				if (id_getUseDynamicLearningRate == IntPtr.Zero)
					id_getUseDynamicLearningRate = JNIEnv.GetMethodID (class_ref, "getUseDynamicLearningRate", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_getUseDynamicLearningRate);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUseDynamicLearningRate", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.learning']/class[@name='DynamicBackPropagation']/method[@name='setUseDynamicLearningRate' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setUseDynamicLearningRate", "(Z)V", "GetSetUseDynamicLearningRate_ZHandler")]
			set {
				if (id_setUseDynamicLearningRate_Z == IntPtr.Zero)
					id_setUseDynamicLearningRate_Z = JNIEnv.GetMethodID (class_ref, "setUseDynamicLearningRate", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setUseDynamicLearningRate_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUseDynamicLearningRate", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getUseDynamicMomentum;
#pragma warning disable 0169
		static Delegate GetGetUseDynamicMomentumHandler ()
		{
			if (cb_getUseDynamicMomentum == null)
				cb_getUseDynamicMomentum = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetUseDynamicMomentum);
			return cb_getUseDynamicMomentum;
		}

		static bool n_GetUseDynamicMomentum (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Nnet.Learning.DynamicBackPropagation __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Learning.DynamicBackPropagation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UseDynamicMomentum;
		}
#pragma warning restore 0169

		static Delegate cb_setUseDynamicMomentum_Z;
#pragma warning disable 0169
		static Delegate GetSetUseDynamicMomentum_ZHandler ()
		{
			if (cb_setUseDynamicMomentum_Z == null)
				cb_setUseDynamicMomentum_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetUseDynamicMomentum_Z);
			return cb_setUseDynamicMomentum_Z;
		}

		static void n_SetUseDynamicMomentum_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Org.Neuroph.Nnet.Learning.DynamicBackPropagation __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Learning.DynamicBackPropagation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UseDynamicMomentum = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getUseDynamicMomentum;
		static IntPtr id_setUseDynamicMomentum_Z;
		public virtual unsafe bool UseDynamicMomentum {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.learning']/class[@name='DynamicBackPropagation']/method[@name='getUseDynamicMomentum' and count(parameter)=0]"
			[Register ("getUseDynamicMomentum", "()Z", "GetGetUseDynamicMomentumHandler")]
			get {
				if (id_getUseDynamicMomentum == IntPtr.Zero)
					id_getUseDynamicMomentum = JNIEnv.GetMethodID (class_ref, "getUseDynamicMomentum", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_getUseDynamicMomentum);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUseDynamicMomentum", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.learning']/class[@name='DynamicBackPropagation']/method[@name='setUseDynamicMomentum' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setUseDynamicMomentum", "(Z)V", "GetSetUseDynamicMomentum_ZHandler")]
			set {
				if (id_setUseDynamicMomentum_Z == IntPtr.Zero)
					id_setUseDynamicMomentum_Z = JNIEnv.GetMethodID (class_ref, "setUseDynamicMomentum", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setUseDynamicMomentum_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUseDynamicMomentum", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_adjustLearningRate;
#pragma warning disable 0169
		static Delegate GetAdjustLearningRateHandler ()
		{
			if (cb_adjustLearningRate == null)
				cb_adjustLearningRate = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_AdjustLearningRate);
			return cb_adjustLearningRate;
		}

		static void n_AdjustLearningRate (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Nnet.Learning.DynamicBackPropagation __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Learning.DynamicBackPropagation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AdjustLearningRate ();
		}
#pragma warning restore 0169

		static IntPtr id_adjustLearningRate;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.learning']/class[@name='DynamicBackPropagation']/method[@name='adjustLearningRate' and count(parameter)=0]"
		[Register ("adjustLearningRate", "()V", "GetAdjustLearningRateHandler")]
		protected virtual unsafe void AdjustLearningRate ()
		{
			if (id_adjustLearningRate == IntPtr.Zero)
				id_adjustLearningRate = JNIEnv.GetMethodID (class_ref, "adjustLearningRate", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_adjustLearningRate);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "adjustLearningRate", "()V"));
			} finally {
			}
		}

		static Delegate cb_adjustMomentum;
#pragma warning disable 0169
		static Delegate GetAdjustMomentumHandler ()
		{
			if (cb_adjustMomentum == null)
				cb_adjustMomentum = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_AdjustMomentum);
			return cb_adjustMomentum;
		}

		static void n_AdjustMomentum (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Nnet.Learning.DynamicBackPropagation __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Learning.DynamicBackPropagation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AdjustMomentum ();
		}
#pragma warning restore 0169

		static IntPtr id_adjustMomentum;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.learning']/class[@name='DynamicBackPropagation']/method[@name='adjustMomentum' and count(parameter)=0]"
		[Register ("adjustMomentum", "()V", "GetAdjustMomentumHandler")]
		protected virtual unsafe void AdjustMomentum ()
		{
			if (id_adjustMomentum == IntPtr.Zero)
				id_adjustMomentum = JNIEnv.GetMethodID (class_ref, "adjustMomentum", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_adjustMomentum);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "adjustMomentum", "()V"));
			} finally {
			}
		}

	}
}
