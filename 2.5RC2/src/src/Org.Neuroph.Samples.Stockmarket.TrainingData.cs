using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Samples.Stockmarket {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.samples.stockmarket']/class[@name='TrainingData']"
	[global::Android.Runtime.Register ("org/neuroph/samples/stockmarket/TrainingData", DoNotGenerateAcw=true)]
	public partial class TrainingData : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/samples/stockmarket/TrainingData", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TrainingData); }
		}

		protected TrainingData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.samples.stockmarket']/class[@name='TrainingData']/constructor[@name='TrainingData' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TrainingData ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (TrainingData)) {
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

		static IntPtr id_ctor_arrayLjava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.samples.stockmarket']/class[@name='TrainingData']/constructor[@name='TrainingData' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register (".ctor", "([Ljava/lang/String;)V", "")]
		public unsafe TrainingData (string[] p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (TrainingData)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "([Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "([Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_arrayLjava_lang_String_ == IntPtr.Zero)
					id_ctor_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "([Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayLjava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_arrayLjava_lang_String_, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_getNormalizer;
#pragma warning disable 0169
		static Delegate GetGetNormalizerHandler ()
		{
			if (cb_getNormalizer == null)
				cb_getNormalizer = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetNormalizer);
			return cb_getNormalizer;
		}

		static double n_GetNormalizer (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Samples.Stockmarket.TrainingData __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Samples.Stockmarket.TrainingData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Normalizer;
		}
#pragma warning restore 0169

		static Delegate cb_setNormalizer_D;
#pragma warning disable 0169
		static Delegate GetSetNormalizer_DHandler ()
		{
			if (cb_setNormalizer_D == null)
				cb_setNormalizer_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetNormalizer_D);
			return cb_setNormalizer_D;
		}

		static void n_SetNormalizer_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Org.Neuroph.Samples.Stockmarket.TrainingData __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Samples.Stockmarket.TrainingData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Normalizer = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getNormalizer;
		static IntPtr id_setNormalizer_D;
		public virtual unsafe double Normalizer {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.samples.stockmarket']/class[@name='TrainingData']/method[@name='getNormalizer' and count(parameter)=0]"
			[Register ("getNormalizer", "()D", "GetGetNormalizerHandler")]
			get {
				if (id_getNormalizer == IntPtr.Zero)
					id_getNormalizer = JNIEnv.GetMethodID (class_ref, "getNormalizer", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getNormalizer);
					else
						return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNormalizer", "()D"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.samples.stockmarket']/class[@name='TrainingData']/method[@name='setNormalizer' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setNormalizer", "(D)V", "GetSetNormalizer_DHandler")]
			set {
				if (id_setNormalizer_D == IntPtr.Zero)
					id_setNormalizer_D = JNIEnv.GetMethodID (class_ref, "setNormalizer", "(D)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setNormalizer_D, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNormalizer", "(D)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTrainingSet;
#pragma warning disable 0169
		static Delegate GetGetTrainingSetHandler ()
		{
			if (cb_getTrainingSet == null)
				cb_getTrainingSet = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTrainingSet);
			return cb_getTrainingSet;
		}

		static IntPtr n_GetTrainingSet (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Samples.Stockmarket.TrainingData __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Samples.Stockmarket.TrainingData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TrainingSet);
		}
#pragma warning restore 0169

		static Delegate cb_setTrainingSet_Lorg_neuroph_core_learning_TrainingSet_;
#pragma warning disable 0169
		static Delegate GetSetTrainingSet_Lorg_neuroph_core_learning_TrainingSet_Handler ()
		{
			if (cb_setTrainingSet_Lorg_neuroph_core_learning_TrainingSet_ == null)
				cb_setTrainingSet_Lorg_neuroph_core_learning_TrainingSet_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTrainingSet_Lorg_neuroph_core_learning_TrainingSet_);
			return cb_setTrainingSet_Lorg_neuroph_core_learning_TrainingSet_;
		}

		static void n_SetTrainingSet_Lorg_neuroph_core_learning_TrainingSet_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Samples.Stockmarket.TrainingData __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Samples.Stockmarket.TrainingData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Core.Learning.TrainingSet p0 = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.TrainingSet> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TrainingSet = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTrainingSet;
		static IntPtr id_setTrainingSet_Lorg_neuroph_core_learning_TrainingSet_;
		public virtual unsafe global::Org.Neuroph.Core.Learning.TrainingSet TrainingSet {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.samples.stockmarket']/class[@name='TrainingData']/method[@name='getTrainingSet' and count(parameter)=0]"
			[Register ("getTrainingSet", "()Lorg/neuroph/core/learning/TrainingSet;", "GetGetTrainingSetHandler")]
			get {
				if (id_getTrainingSet == IntPtr.Zero)
					id_getTrainingSet = JNIEnv.GetMethodID (class_ref, "getTrainingSet", "()Lorg/neuroph/core/learning/TrainingSet;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.TrainingSet> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTrainingSet), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.TrainingSet> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTrainingSet", "()Lorg/neuroph/core/learning/TrainingSet;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.samples.stockmarket']/class[@name='TrainingData']/method[@name='setTrainingSet' and count(parameter)=1 and parameter[1][@type='org.neuroph.core.learning.TrainingSet']]"
			[Register ("setTrainingSet", "(Lorg/neuroph/core/learning/TrainingSet;)V", "GetSetTrainingSet_Lorg_neuroph_core_learning_TrainingSet_Handler")]
			set {
				if (id_setTrainingSet_Lorg_neuroph_core_learning_TrainingSet_ == IntPtr.Zero)
					id_setTrainingSet_Lorg_neuroph_core_learning_TrainingSet_ = JNIEnv.GetMethodID (class_ref, "setTrainingSet", "(Lorg/neuroph/core/learning/TrainingSet;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTrainingSet_Lorg_neuroph_core_learning_TrainingSet_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTrainingSet", "(Lorg/neuroph/core/learning/TrainingSet;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getValuesRow;
#pragma warning disable 0169
		static Delegate GetGetValuesRowHandler ()
		{
			if (cb_getValuesRow == null)
				cb_getValuesRow = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetValuesRow);
			return cb_getValuesRow;
		}

		static IntPtr n_GetValuesRow (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Samples.Stockmarket.TrainingData __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Samples.Stockmarket.TrainingData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetValuesRow ());
		}
#pragma warning restore 0169

		static IntPtr id_getValuesRow;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.samples.stockmarket']/class[@name='TrainingData']/method[@name='getValuesRow' and count(parameter)=0]"
		[Register ("getValuesRow", "()[Ljava/lang/String;", "GetGetValuesRowHandler")]
		public virtual unsafe string[] GetValuesRow ()
		{
			if (id_getValuesRow == IntPtr.Zero)
				id_getValuesRow = JNIEnv.GetMethodID (class_ref, "getValuesRow", "()[Ljava/lang/String;");
			try {

				if (GetType () == ThresholdType)
					return (string[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getValuesRow), JniHandleOwnership.TransferLocalRef, typeof (string));
				else
					return (string[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getValuesRow", "()[Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
			}
		}

		static Delegate cb_setValuesRow_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetValuesRow_arrayLjava_lang_String_Handler ()
		{
			if (cb_setValuesRow_arrayLjava_lang_String_ == null)
				cb_setValuesRow_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetValuesRow_arrayLjava_lang_String_);
			return cb_setValuesRow_arrayLjava_lang_String_;
		}

		static void n_SetValuesRow_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Samples.Stockmarket.TrainingData __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Samples.Stockmarket.TrainingData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] p0 = (string[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (string));
			__this.SetValuesRow (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_setValuesRow_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.samples.stockmarket']/class[@name='TrainingData']/method[@name='setValuesRow' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register ("setValuesRow", "([Ljava/lang/String;)V", "GetSetValuesRow_arrayLjava_lang_String_Handler")]
		public virtual unsafe void SetValuesRow (string[] p0)
		{
			if (id_setValuesRow_arrayLjava_lang_String_ == IntPtr.Zero)
				id_setValuesRow_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setValuesRow", "([Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setValuesRow_arrayLjava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setValuesRow", "([Ljava/lang/String;)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

	}
}
