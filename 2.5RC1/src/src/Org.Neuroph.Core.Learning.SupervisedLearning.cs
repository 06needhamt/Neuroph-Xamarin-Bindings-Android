using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Core.Learning {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='SupervisedLearning']"
	[global::Android.Runtime.Register ("org/neuroph/core/learning/SupervisedLearning", DoNotGenerateAcw=true)]
	public abstract partial class SupervisedLearning : global::Org.Neuroph.Core.Learning.IterativeLearning, global::Java.IO.ISerializable {


		static IntPtr patternErrorSqrSum_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='SupervisedLearning']/field[@name='patternErrorSqrSum']"
		[Register ("patternErrorSqrSum")]
		protected double PatternErrorSqrSum {
			get {
				if (patternErrorSqrSum_jfieldId == IntPtr.Zero)
					patternErrorSqrSum_jfieldId = JNIEnv.GetFieldID (class_ref, "patternErrorSqrSum", "D");
				return JNIEnv.GetDoubleField (Handle, patternErrorSqrSum_jfieldId);
			}
			set {
				if (patternErrorSqrSum_jfieldId == IntPtr.Zero)
					patternErrorSqrSum_jfieldId = JNIEnv.GetFieldID (class_ref, "patternErrorSqrSum", "D");
				try {
					JNIEnv.SetField (Handle, patternErrorSqrSum_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr totalPatternErrorSqrSum_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='SupervisedLearning']/field[@name='totalPatternErrorSqrSum']"
		[Register ("totalPatternErrorSqrSum")]
		protected double TotalPatternErrorSqrSum {
			get {
				if (totalPatternErrorSqrSum_jfieldId == IntPtr.Zero)
					totalPatternErrorSqrSum_jfieldId = JNIEnv.GetFieldID (class_ref, "totalPatternErrorSqrSum", "D");
				return JNIEnv.GetDoubleField (Handle, totalPatternErrorSqrSum_jfieldId);
			}
			set {
				if (totalPatternErrorSqrSum_jfieldId == IntPtr.Zero)
					totalPatternErrorSqrSum_jfieldId = JNIEnv.GetFieldID (class_ref, "totalPatternErrorSqrSum", "D");
				try {
					JNIEnv.SetField (Handle, totalPatternErrorSqrSum_jfieldId, value);
				} finally {
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/core/learning/SupervisedLearning", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SupervisedLearning); }
		}

		protected SupervisedLearning (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='SupervisedLearning']/constructor[@name='SupervisedLearning' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SupervisedLearning ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (SupervisedLearning)) {
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

		static Delegate cb_hasReachedStopCondition;
#pragma warning disable 0169
		static Delegate GetHasReachedStopConditionHandler ()
		{
			if (cb_hasReachedStopCondition == null)
				cb_hasReachedStopCondition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasReachedStopCondition);
			return cb_hasReachedStopCondition;
		}

		static bool n_HasReachedStopCondition (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Core.Learning.SupervisedLearning __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.SupervisedLearning> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasReachedStopCondition;
		}
#pragma warning restore 0169

		static IntPtr id_hasReachedStopCondition;
		protected virtual unsafe bool HasReachedStopCondition {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='SupervisedLearning']/method[@name='hasReachedStopCondition' and count(parameter)=0]"
			[Register ("hasReachedStopCondition", "()Z", "GetHasReachedStopConditionHandler")]
			get {
				if (id_hasReachedStopCondition == IntPtr.Zero)
					id_hasReachedStopCondition = JNIEnv.GetMethodID (class_ref, "hasReachedStopCondition", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_hasReachedStopCondition);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hasReachedStopCondition", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getMaxError;
#pragma warning disable 0169
		static Delegate GetGetMaxErrorHandler ()
		{
			if (cb_getMaxError == null)
				cb_getMaxError = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetMaxError);
			return cb_getMaxError;
		}

		static double n_GetMaxError (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Core.Learning.SupervisedLearning __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.SupervisedLearning> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxError;
		}
#pragma warning restore 0169

		static Delegate cb_setMaxError_D;
#pragma warning disable 0169
		static Delegate GetSetMaxError_DHandler ()
		{
			if (cb_setMaxError_D == null)
				cb_setMaxError_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetMaxError_D);
			return cb_setMaxError_D;
		}

		static void n_SetMaxError_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Org.Neuroph.Core.Learning.SupervisedLearning __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.SupervisedLearning> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MaxError = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMaxError;
		static IntPtr id_setMaxError_D;
		public virtual unsafe double MaxError {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='SupervisedLearning']/method[@name='getMaxError' and count(parameter)=0]"
			[Register ("getMaxError", "()D", "GetGetMaxErrorHandler")]
			get {
				if (id_getMaxError == IntPtr.Zero)
					id_getMaxError = JNIEnv.GetMethodID (class_ref, "getMaxError", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod  (Handle, id_getMaxError);
					else
						return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMaxError", "()D"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='SupervisedLearning']/method[@name='setMaxError' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setMaxError", "(D)V", "GetSetMaxError_DHandler")]
			set {
				if (id_setMaxError_D == IntPtr.Zero)
					id_setMaxError_D = JNIEnv.GetMethodID (class_ref, "setMaxError", "(D)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setMaxError_D, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMaxError", "(D)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMinErrorChange;
#pragma warning disable 0169
		static Delegate GetGetMinErrorChangeHandler ()
		{
			if (cb_getMinErrorChange == null)
				cb_getMinErrorChange = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetMinErrorChange);
			return cb_getMinErrorChange;
		}

		static double n_GetMinErrorChange (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Core.Learning.SupervisedLearning __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.SupervisedLearning> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MinErrorChange;
		}
#pragma warning restore 0169

		static Delegate cb_setMinErrorChange_D;
#pragma warning disable 0169
		static Delegate GetSetMinErrorChange_DHandler ()
		{
			if (cb_setMinErrorChange_D == null)
				cb_setMinErrorChange_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetMinErrorChange_D);
			return cb_setMinErrorChange_D;
		}

		static void n_SetMinErrorChange_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Org.Neuroph.Core.Learning.SupervisedLearning __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.SupervisedLearning> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MinErrorChange = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMinErrorChange;
		static IntPtr id_setMinErrorChange_D;
		public virtual unsafe double MinErrorChange {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='SupervisedLearning']/method[@name='getMinErrorChange' and count(parameter)=0]"
			[Register ("getMinErrorChange", "()D", "GetGetMinErrorChangeHandler")]
			get {
				if (id_getMinErrorChange == IntPtr.Zero)
					id_getMinErrorChange = JNIEnv.GetMethodID (class_ref, "getMinErrorChange", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod  (Handle, id_getMinErrorChange);
					else
						return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMinErrorChange", "()D"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='SupervisedLearning']/method[@name='setMinErrorChange' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setMinErrorChange", "(D)V", "GetSetMinErrorChange_DHandler")]
			set {
				if (id_setMinErrorChange_D == IntPtr.Zero)
					id_setMinErrorChange_D = JNIEnv.GetMethodID (class_ref, "setMinErrorChange", "(D)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setMinErrorChange_D, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMinErrorChange", "(D)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMinErrorChangeIterationsCount;
#pragma warning disable 0169
		static Delegate GetGetMinErrorChangeIterationsCountHandler ()
		{
			if (cb_getMinErrorChangeIterationsCount == null)
				cb_getMinErrorChangeIterationsCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMinErrorChangeIterationsCount);
			return cb_getMinErrorChangeIterationsCount;
		}

		static int n_GetMinErrorChangeIterationsCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Core.Learning.SupervisedLearning __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.SupervisedLearning> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MinErrorChangeIterationsCount;
		}
#pragma warning restore 0169

		static IntPtr id_getMinErrorChangeIterationsCount;
		public virtual unsafe int MinErrorChangeIterationsCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='SupervisedLearning']/method[@name='getMinErrorChangeIterationsCount' and count(parameter)=0]"
			[Register ("getMinErrorChangeIterationsCount", "()I", "GetGetMinErrorChangeIterationsCountHandler")]
			get {
				if (id_getMinErrorChangeIterationsCount == IntPtr.Zero)
					id_getMinErrorChangeIterationsCount = JNIEnv.GetMethodID (class_ref, "getMinErrorChangeIterationsCount", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getMinErrorChangeIterationsCount);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMinErrorChangeIterationsCount", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getMinErrorChangeIterationsLimit;
#pragma warning disable 0169
		static Delegate GetGetMinErrorChangeIterationsLimitHandler ()
		{
			if (cb_getMinErrorChangeIterationsLimit == null)
				cb_getMinErrorChangeIterationsLimit = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMinErrorChangeIterationsLimit);
			return cb_getMinErrorChangeIterationsLimit;
		}

		static int n_GetMinErrorChangeIterationsLimit (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Core.Learning.SupervisedLearning __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.SupervisedLearning> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MinErrorChangeIterationsLimit;
		}
#pragma warning restore 0169

		static Delegate cb_setMinErrorChangeIterationsLimit_I;
#pragma warning disable 0169
		static Delegate GetSetMinErrorChangeIterationsLimit_IHandler ()
		{
			if (cb_setMinErrorChangeIterationsLimit_I == null)
				cb_setMinErrorChangeIterationsLimit_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetMinErrorChangeIterationsLimit_I);
			return cb_setMinErrorChangeIterationsLimit_I;
		}

		static void n_SetMinErrorChangeIterationsLimit_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Neuroph.Core.Learning.SupervisedLearning __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.SupervisedLearning> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MinErrorChangeIterationsLimit = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMinErrorChangeIterationsLimit;
		static IntPtr id_setMinErrorChangeIterationsLimit_I;
		public virtual unsafe int MinErrorChangeIterationsLimit {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='SupervisedLearning']/method[@name='getMinErrorChangeIterationsLimit' and count(parameter)=0]"
			[Register ("getMinErrorChangeIterationsLimit", "()I", "GetGetMinErrorChangeIterationsLimitHandler")]
			get {
				if (id_getMinErrorChangeIterationsLimit == IntPtr.Zero)
					id_getMinErrorChangeIterationsLimit = JNIEnv.GetMethodID (class_ref, "getMinErrorChangeIterationsLimit", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getMinErrorChangeIterationsLimit);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMinErrorChangeIterationsLimit", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='SupervisedLearning']/method[@name='setMinErrorChangeIterationsLimit' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMinErrorChangeIterationsLimit", "(I)V", "GetSetMinErrorChangeIterationsLimit_IHandler")]
			set {
				if (id_setMinErrorChangeIterationsLimit_I == IntPtr.Zero)
					id_setMinErrorChangeIterationsLimit_I = JNIEnv.GetMethodID (class_ref, "setMinErrorChangeIterationsLimit", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setMinErrorChangeIterationsLimit_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMinErrorChangeIterationsLimit", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getPreviousEpochError;
#pragma warning disable 0169
		static Delegate GetGetPreviousEpochErrorHandler ()
		{
			if (cb_getPreviousEpochError == null)
				cb_getPreviousEpochError = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetPreviousEpochError);
			return cb_getPreviousEpochError;
		}

		static double n_GetPreviousEpochError (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Core.Learning.SupervisedLearning __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.SupervisedLearning> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PreviousEpochError;
		}
#pragma warning restore 0169

		static IntPtr id_getPreviousEpochError;
		public virtual unsafe double PreviousEpochError {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='SupervisedLearning']/method[@name='getPreviousEpochError' and count(parameter)=0]"
			[Register ("getPreviousEpochError", "()D", "GetGetPreviousEpochErrorHandler")]
			get {
				if (id_getPreviousEpochError == IntPtr.Zero)
					id_getPreviousEpochError = JNIEnv.GetMethodID (class_ref, "getPreviousEpochError", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod  (Handle, id_getPreviousEpochError);
					else
						return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPreviousEpochError", "()D"));
				} finally {
				}
			}
		}

		static Delegate cb_getTotalNetworkError;
#pragma warning disable 0169
		static Delegate GetGetTotalNetworkErrorHandler ()
		{
			if (cb_getTotalNetworkError == null)
				cb_getTotalNetworkError = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetTotalNetworkError);
			return cb_getTotalNetworkError;
		}

		static double n_GetTotalNetworkError (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Core.Learning.SupervisedLearning __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.SupervisedLearning> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TotalNetworkError;
		}
#pragma warning restore 0169

		static IntPtr id_getTotalNetworkError;
		public virtual unsafe double TotalNetworkError {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='SupervisedLearning']/method[@name='getTotalNetworkError' and count(parameter)=0]"
			[Register ("getTotalNetworkError", "()D", "GetGetTotalNetworkErrorHandler")]
			get {
				if (id_getTotalNetworkError == IntPtr.Zero)
					id_getTotalNetworkError = JNIEnv.GetMethodID (class_ref, "getTotalNetworkError", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod  (Handle, id_getTotalNetworkError);
					else
						return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTotalNetworkError", "()D"));
				} finally {
				}
			}
		}

		static Delegate cb_doLearningEpoch_Lorg_neuroph_core_learning_TrainingSet_;
#pragma warning disable 0169
		static Delegate GetDoLearningEpoch_Lorg_neuroph_core_learning_TrainingSet_Handler ()
		{
			if (cb_doLearningEpoch_Lorg_neuroph_core_learning_TrainingSet_ == null)
				cb_doLearningEpoch_Lorg_neuroph_core_learning_TrainingSet_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DoLearningEpoch_Lorg_neuroph_core_learning_TrainingSet_);
			return cb_doLearningEpoch_Lorg_neuroph_core_learning_TrainingSet_;
		}

		static void n_DoLearningEpoch_Lorg_neuroph_core_learning_TrainingSet_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Core.Learning.SupervisedLearning __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.SupervisedLearning> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Core.Learning.TrainingSet p0 = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.TrainingSet> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DoLearningEpoch (p0);
		}
#pragma warning restore 0169

		static IntPtr id_doLearningEpoch_Lorg_neuroph_core_learning_TrainingSet_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='SupervisedLearning']/method[@name='doLearningEpoch' and count(parameter)=1 and parameter[1][@type='org.neuroph.core.learning.TrainingSet']]"
		[Register ("doLearningEpoch", "(Lorg/neuroph/core/learning/TrainingSet;)V", "GetDoLearningEpoch_Lorg_neuroph_core_learning_TrainingSet_Handler")]
		public override unsafe void DoLearningEpoch (global::Org.Neuroph.Core.Learning.TrainingSet p0)
		{
			if (id_doLearningEpoch_Lorg_neuroph_core_learning_TrainingSet_ == IntPtr.Zero)
				id_doLearningEpoch_Lorg_neuroph_core_learning_TrainingSet_ = JNIEnv.GetMethodID (class_ref, "doLearningEpoch", "(Lorg/neuroph/core/learning/TrainingSet;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_doLearningEpoch_Lorg_neuroph_core_learning_TrainingSet_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "doLearningEpoch", "(Lorg/neuroph/core/learning/TrainingSet;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_errorChangeStalled;
#pragma warning disable 0169
		static Delegate GetErrorChangeStalledHandler ()
		{
			if (cb_errorChangeStalled == null)
				cb_errorChangeStalled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_ErrorChangeStalled);
			return cb_errorChangeStalled;
		}

		static bool n_ErrorChangeStalled (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Core.Learning.SupervisedLearning __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.SupervisedLearning> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ErrorChangeStalled ();
		}
#pragma warning restore 0169

		static IntPtr id_errorChangeStalled;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='SupervisedLearning']/method[@name='errorChangeStalled' and count(parameter)=0]"
		[Register ("errorChangeStalled", "()Z", "GetErrorChangeStalledHandler")]
		protected virtual unsafe bool ErrorChangeStalled ()
		{
			if (id_errorChangeStalled == IntPtr.Zero)
				id_errorChangeStalled = JNIEnv.GetMethodID (class_ref, "errorChangeStalled", "()Z");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_errorChangeStalled);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "errorChangeStalled", "()Z"));
			} finally {
			}
		}

		static Delegate cb_getPatternError_arrayDarrayD;
#pragma warning disable 0169
		static Delegate GetGetPatternError_arrayDarrayDHandler ()
		{
			if (cb_getPatternError_arrayDarrayD == null)
				cb_getPatternError_arrayDarrayD = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetPatternError_arrayDarrayD);
			return cb_getPatternError_arrayDarrayD;
		}

		static IntPtr n_GetPatternError_arrayDarrayD (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Neuroph.Core.Learning.SupervisedLearning __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.SupervisedLearning> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			double[] p0 = (double[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (double));
			double[] p1 = (double[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (double));
			IntPtr __ret = JNIEnv.NewArray (__this.GetPatternError (p0, p1));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getPatternError_arrayDarrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='SupervisedLearning']/method[@name='getPatternError' and count(parameter)=2 and parameter[1][@type='double[]'] and parameter[2][@type='double[]']]"
		[Register ("getPatternError", "([D[D)[D", "GetGetPatternError_arrayDarrayDHandler")]
		protected virtual unsafe double[] GetPatternError (double[] p0, double[] p1)
		{
			if (id_getPatternError_arrayDarrayD == IntPtr.Zero)
				id_getPatternError_arrayDarrayD = JNIEnv.GetMethodID (class_ref, "getPatternError", "([D[D)[D");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				double[] __ret;
				if (GetType () == ThresholdType)
					__ret = (double[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getPatternError_arrayDarrayD, __args), JniHandleOwnership.TransferLocalRef, typeof (double));
				else
					__ret = (double[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPatternError", "([D[D)[D"), __args), JniHandleOwnership.TransferLocalRef, typeof (double));
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static Delegate cb_learn_Lorg_neuroph_core_learning_TrainingSet_D;
#pragma warning disable 0169
		static Delegate GetLearn_Lorg_neuroph_core_learning_TrainingSet_DHandler ()
		{
			if (cb_learn_Lorg_neuroph_core_learning_TrainingSet_D == null)
				cb_learn_Lorg_neuroph_core_learning_TrainingSet_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, double>) n_Learn_Lorg_neuroph_core_learning_TrainingSet_D);
			return cb_learn_Lorg_neuroph_core_learning_TrainingSet_D;
		}

		static void n_Learn_Lorg_neuroph_core_learning_TrainingSet_D (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, double p1)
		{
			global::Org.Neuroph.Core.Learning.SupervisedLearning __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.SupervisedLearning> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Core.Learning.TrainingSet p0 = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.TrainingSet> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Learn (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_learn_Lorg_neuroph_core_learning_TrainingSet_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='SupervisedLearning']/method[@name='learn' and count(parameter)=2 and parameter[1][@type='org.neuroph.core.learning.TrainingSet'] and parameter[2][@type='double']]"
		[Register ("learn", "(Lorg/neuroph/core/learning/TrainingSet;D)V", "GetLearn_Lorg_neuroph_core_learning_TrainingSet_DHandler")]
		public virtual unsafe void Learn (global::Org.Neuroph.Core.Learning.TrainingSet p0, double p1)
		{
			if (id_learn_Lorg_neuroph_core_learning_TrainingSet_D == IntPtr.Zero)
				id_learn_Lorg_neuroph_core_learning_TrainingSet_D = JNIEnv.GetMethodID (class_ref, "learn", "(Lorg/neuroph/core/learning/TrainingSet;D)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_learn_Lorg_neuroph_core_learning_TrainingSet_D, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "learn", "(Lorg/neuroph/core/learning/TrainingSet;D)V"), __args);
			} finally {
			}
		}

		static Delegate cb_learn_Lorg_neuroph_core_learning_TrainingSet_DI;
#pragma warning disable 0169
		static Delegate GetLearn_Lorg_neuroph_core_learning_TrainingSet_DIHandler ()
		{
			if (cb_learn_Lorg_neuroph_core_learning_TrainingSet_DI == null)
				cb_learn_Lorg_neuroph_core_learning_TrainingSet_DI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, double, int>) n_Learn_Lorg_neuroph_core_learning_TrainingSet_DI);
			return cb_learn_Lorg_neuroph_core_learning_TrainingSet_DI;
		}

		static void n_Learn_Lorg_neuroph_core_learning_TrainingSet_DI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, double p1, int p2)
		{
			global::Org.Neuroph.Core.Learning.SupervisedLearning __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.SupervisedLearning> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Core.Learning.TrainingSet p0 = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.TrainingSet> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Learn (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_learn_Lorg_neuroph_core_learning_TrainingSet_DI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='SupervisedLearning']/method[@name='learn' and count(parameter)=3 and parameter[1][@type='org.neuroph.core.learning.TrainingSet'] and parameter[2][@type='double'] and parameter[3][@type='int']]"
		[Register ("learn", "(Lorg/neuroph/core/learning/TrainingSet;DI)V", "GetLearn_Lorg_neuroph_core_learning_TrainingSet_DIHandler")]
		public virtual unsafe void Learn (global::Org.Neuroph.Core.Learning.TrainingSet p0, double p1, int p2)
		{
			if (id_learn_Lorg_neuroph_core_learning_TrainingSet_DI == IntPtr.Zero)
				id_learn_Lorg_neuroph_core_learning_TrainingSet_DI = JNIEnv.GetMethodID (class_ref, "learn", "(Lorg/neuroph/core/learning/TrainingSet;DI)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_learn_Lorg_neuroph_core_learning_TrainingSet_DI, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "learn", "(Lorg/neuroph/core/learning/TrainingSet;DI)V"), __args);
			} finally {
			}
		}

		static Delegate cb_learnPattern_Lorg_neuroph_core_learning_SupervisedTrainingElement_;
#pragma warning disable 0169
		static Delegate GetLearnPattern_Lorg_neuroph_core_learning_SupervisedTrainingElement_Handler ()
		{
			if (cb_learnPattern_Lorg_neuroph_core_learning_SupervisedTrainingElement_ == null)
				cb_learnPattern_Lorg_neuroph_core_learning_SupervisedTrainingElement_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_LearnPattern_Lorg_neuroph_core_learning_SupervisedTrainingElement_);
			return cb_learnPattern_Lorg_neuroph_core_learning_SupervisedTrainingElement_;
		}

		static void n_LearnPattern_Lorg_neuroph_core_learning_SupervisedTrainingElement_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Core.Learning.SupervisedLearning __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.SupervisedLearning> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Core.Learning.SupervisedTrainingElement p0 = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.SupervisedTrainingElement> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LearnPattern (p0);
		}
#pragma warning restore 0169

		static IntPtr id_learnPattern_Lorg_neuroph_core_learning_SupervisedTrainingElement_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='SupervisedLearning']/method[@name='learnPattern' and count(parameter)=1 and parameter[1][@type='org.neuroph.core.learning.SupervisedTrainingElement']]"
		[Register ("learnPattern", "(Lorg/neuroph/core/learning/SupervisedTrainingElement;)V", "GetLearnPattern_Lorg_neuroph_core_learning_SupervisedTrainingElement_Handler")]
		protected virtual unsafe void LearnPattern (global::Org.Neuroph.Core.Learning.SupervisedTrainingElement p0)
		{
			if (id_learnPattern_Lorg_neuroph_core_learning_SupervisedTrainingElement_ == IntPtr.Zero)
				id_learnPattern_Lorg_neuroph_core_learning_SupervisedTrainingElement_ = JNIEnv.GetMethodID (class_ref, "learnPattern", "(Lorg/neuroph/core/learning/SupervisedTrainingElement;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_learnPattern_Lorg_neuroph_core_learning_SupervisedTrainingElement_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "learnPattern", "(Lorg/neuroph/core/learning/SupervisedTrainingElement;)V"), __args);
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
			global::Org.Neuroph.Core.Learning.SupervisedLearning __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.SupervisedLearning> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			double[] p0 = (double[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (double));
			__this.UpdateNetworkWeights (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='SupervisedLearning']/method[@name='updateNetworkWeights' and count(parameter)=1 and parameter[1][@type='double[]']]"
		[Register ("updateNetworkWeights", "([D)V", "GetUpdateNetworkWeights_arrayDHandler")]
		protected abstract void UpdateNetworkWeights (double[] p0);

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
			global::Org.Neuroph.Core.Learning.SupervisedLearning __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.SupervisedLearning> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			double[] p0 = (double[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (double));
			__this.UpdatePatternError (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='SupervisedLearning']/method[@name='updatePatternError' and count(parameter)=1 and parameter[1][@type='double[]']]"
		[Register ("updatePatternError", "([D)V", "GetUpdatePatternError_arrayDHandler")]
		protected abstract void UpdatePatternError (double[] p0);

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
			global::Org.Neuroph.Core.Learning.SupervisedLearning __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.SupervisedLearning> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UpdateTotalNetworkError ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='SupervisedLearning']/method[@name='updateTotalNetworkError' and count(parameter)=0]"
		[Register ("updateTotalNetworkError", "()V", "GetUpdateTotalNetworkErrorHandler")]
		protected abstract void UpdateTotalNetworkError ();

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
			global::Org.Neuroph.Core.Learning.SupervisedLearning __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.SupervisedLearning> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			double[] p0 = (double[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (double));
			__this.UpdateTotalNetworkError (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='SupervisedLearning']/method[@name='updateTotalNetworkError' and count(parameter)=1 and parameter[1][@type='double[]']]"
		[Register ("updateTotalNetworkError", "([D)V", "GetUpdateTotalNetworkError_arrayDHandler")]
		protected abstract void UpdateTotalNetworkError (double[] p0);

	}

	[global::Android.Runtime.Register ("org/neuroph/core/learning/SupervisedLearning", DoNotGenerateAcw=true)]
	internal partial class SupervisedLearningInvoker : SupervisedLearning {

		public SupervisedLearningInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (SupervisedLearningInvoker); }
		}

		static IntPtr id_updateNetworkWeights_arrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='SupervisedLearning']/method[@name='updateNetworkWeights' and count(parameter)=1 and parameter[1][@type='double[]']]"
		[Register ("updateNetworkWeights", "([D)V", "GetUpdateNetworkWeights_arrayDHandler")]
		protected override unsafe void UpdateNetworkWeights (double[] p0)
		{
			if (id_updateNetworkWeights_arrayD == IntPtr.Zero)
				id_updateNetworkWeights_arrayD = JNIEnv.GetMethodID (class_ref, "updateNetworkWeights", "([D)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod  (Handle, id_updateNetworkWeights_arrayD, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_updatePatternError_arrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='SupervisedLearning']/method[@name='updatePatternError' and count(parameter)=1 and parameter[1][@type='double[]']]"
		[Register ("updatePatternError", "([D)V", "GetUpdatePatternError_arrayDHandler")]
		protected override unsafe void UpdatePatternError (double[] p0)
		{
			if (id_updatePatternError_arrayD == IntPtr.Zero)
				id_updatePatternError_arrayD = JNIEnv.GetMethodID (class_ref, "updatePatternError", "([D)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod  (Handle, id_updatePatternError_arrayD, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_updateTotalNetworkError;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='SupervisedLearning']/method[@name='updateTotalNetworkError' and count(parameter)=0]"
		[Register ("updateTotalNetworkError", "()V", "GetUpdateTotalNetworkErrorHandler")]
		protected override unsafe void UpdateTotalNetworkError ()
		{
			if (id_updateTotalNetworkError == IntPtr.Zero)
				id_updateTotalNetworkError = JNIEnv.GetMethodID (class_ref, "updateTotalNetworkError", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_updateTotalNetworkError);
			} finally {
			}
		}

		static IntPtr id_updateTotalNetworkError_arrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='SupervisedLearning']/method[@name='updateTotalNetworkError' and count(parameter)=1 and parameter[1][@type='double[]']]"
		[Register ("updateTotalNetworkError", "([D)V", "GetUpdateTotalNetworkError_arrayDHandler")]
		protected override unsafe void UpdateTotalNetworkError (double[] p0)
		{
			if (id_updateTotalNetworkError_arrayD == IntPtr.Zero)
				id_updateTotalNetworkError_arrayD = JNIEnv.GetMethodID (class_ref, "updateTotalNetworkError", "([D)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod  (Handle, id_updateTotalNetworkError_arrayD, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

	}

}
