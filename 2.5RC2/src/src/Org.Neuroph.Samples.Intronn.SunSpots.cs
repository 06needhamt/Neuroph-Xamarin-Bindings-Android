using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Samples.Intronn {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.samples.intronn']/class[@name='SunSpots']"
	[global::Android.Runtime.Register ("org/neuroph/samples/intronn/SunSpots", DoNotGenerateAcw=true)]
	public partial class SunSpots : global::Java.Lang.Object, global::Java.Util.IObserver {


		static IntPtr EVALUATE_END_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.neuroph.samples.intronn']/class[@name='SunSpots']/field[@name='EVALUATE_END']"
		[Register ("EVALUATE_END")]
		public static int EvaluateEnd {
			get {
				if (EVALUATE_END_jfieldId == IntPtr.Zero)
					EVALUATE_END_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EVALUATE_END", "I");
				return JNIEnv.GetStaticIntField (class_ref, EVALUATE_END_jfieldId);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='org.neuroph.samples.intronn']/class[@name='SunSpots']/field[@name='EVALUATE_START']"
		[Register ("EVALUATE_START")]
		public const int EvaluateStart = (int) 260;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.neuroph.samples.intronn']/class[@name='SunSpots']/field[@name='MAX_ERROR']"
		[Register ("MAX_ERROR")]
		public const double MaxError = (double) 0.060000000000000;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.neuroph.samples.intronn']/class[@name='SunSpots']/field[@name='STARTING_YEAR']"
		[Register ("STARTING_YEAR")]
		public const int StartingYear = (int) 1700;

		static IntPtr SUNSPOTS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.neuroph.samples.intronn']/class[@name='SunSpots']/field[@name='SUNSPOTS']"
		[Register ("SUNSPOTS")]
		public static IList<double> Sunspots {
			get {
				if (SUNSPOTS_jfieldId == IntPtr.Zero)
					SUNSPOTS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SUNSPOTS", "[D");
				return JavaArray<double>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, SUNSPOTS_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='org.neuroph.samples.intronn']/class[@name='SunSpots']/field[@name='TRAIN_END']"
		[Register ("TRAIN_END")]
		public const int TrainEnd = (int) 259;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.neuroph.samples.intronn']/class[@name='SunSpots']/field[@name='TRAIN_START']"
		[Register ("TRAIN_START")]
		public const int TrainStart = (int) 30;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.neuroph.samples.intronn']/class[@name='SunSpots']/field[@name='WINDOW_SIZE']"
		[Register ("WINDOW_SIZE")]
		public const int WindowSize = (int) 30;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/samples/intronn/SunSpots", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SunSpots); }
		}

		protected SunSpots (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.samples.intronn']/class[@name='SunSpots']/constructor[@name='SunSpots' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SunSpots ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (SunSpots)) {
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

		static Delegate cb_generateTraining;
#pragma warning disable 0169
		static Delegate GetGenerateTrainingHandler ()
		{
			if (cb_generateTraining == null)
				cb_generateTraining = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GenerateTraining);
			return cb_generateTraining;
		}

		static IntPtr n_GenerateTraining (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Samples.Intronn.SunSpots __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Samples.Intronn.SunSpots> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GenerateTraining ());
		}
#pragma warning restore 0169

		static IntPtr id_generateTraining;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.samples.intronn']/class[@name='SunSpots']/method[@name='generateTraining' and count(parameter)=0]"
		[Register ("generateTraining", "()Lorg/neuroph/core/learning/TrainingSet;", "GetGenerateTrainingHandler")]
		public virtual unsafe global::Org.Neuroph.Core.Learning.TrainingSet GenerateTraining ()
		{
			if (id_generateTraining == IntPtr.Zero)
				id_generateTraining = JNIEnv.GetMethodID (class_ref, "generateTraining", "()Lorg/neuroph/core/learning/TrainingSet;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.TrainingSet> (JNIEnv.CallObjectMethod  (Handle, id_generateTraining), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.TrainingSet> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "generateTraining", "()Lorg/neuroph/core/learning/TrainingSet;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_main_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.samples.intronn']/class[@name='SunSpots']/method[@name='main' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register ("main", "([Ljava/lang/String;)V", "")]
		public static unsafe void Main (string[] p0)
		{
			if (id_main_arrayLjava_lang_String_ == IntPtr.Zero)
				id_main_arrayLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "main", "([Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_main_arrayLjava_lang_String_, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_normalizeSunspots_DD;
#pragma warning disable 0169
		static Delegate GetNormalizeSunspots_DDHandler ()
		{
			if (cb_normalizeSunspots_DD == null)
				cb_normalizeSunspots_DD = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double, double>) n_NormalizeSunspots_DD);
			return cb_normalizeSunspots_DD;
		}

		static void n_NormalizeSunspots_DD (IntPtr jnienv, IntPtr native__this, double p0, double p1)
		{
			global::Org.Neuroph.Samples.Intronn.SunSpots __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Samples.Intronn.SunSpots> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NormalizeSunspots (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_normalizeSunspots_DD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.samples.intronn']/class[@name='SunSpots']/method[@name='normalizeSunspots' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='double']]"
		[Register ("normalizeSunspots", "(DD)V", "GetNormalizeSunspots_DDHandler")]
		public virtual unsafe void NormalizeSunspots (double p0, double p1)
		{
			if (id_normalizeSunspots_DD == IntPtr.Zero)
				id_normalizeSunspots_DD = JNIEnv.GetMethodID (class_ref, "normalizeSunspots", "(DD)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_normalizeSunspots_DD, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "normalizeSunspots", "(DD)V"), __args);
			} finally {
			}
		}

		static Delegate cb_predict_Lorg_neuroph_core_NeuralNetwork_;
#pragma warning disable 0169
		static Delegate GetPredict_Lorg_neuroph_core_NeuralNetwork_Handler ()
		{
			if (cb_predict_Lorg_neuroph_core_NeuralNetwork_ == null)
				cb_predict_Lorg_neuroph_core_NeuralNetwork_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Predict_Lorg_neuroph_core_NeuralNetwork_);
			return cb_predict_Lorg_neuroph_core_NeuralNetwork_;
		}

		static void n_Predict_Lorg_neuroph_core_NeuralNetwork_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Samples.Intronn.SunSpots __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Samples.Intronn.SunSpots> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Core.NeuralNetwork p0 = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.NeuralNetwork> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Predict (p0);
		}
#pragma warning restore 0169

		static IntPtr id_predict_Lorg_neuroph_core_NeuralNetwork_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.samples.intronn']/class[@name='SunSpots']/method[@name='predict' and count(parameter)=1 and parameter[1][@type='org.neuroph.core.NeuralNetwork']]"
		[Register ("predict", "(Lorg/neuroph/core/NeuralNetwork;)V", "GetPredict_Lorg_neuroph_core_NeuralNetwork_Handler")]
		public virtual unsafe void Predict (global::Org.Neuroph.Core.NeuralNetwork p0)
		{
			if (id_predict_Lorg_neuroph_core_NeuralNetwork_ == IntPtr.Zero)
				id_predict_Lorg_neuroph_core_NeuralNetwork_ = JNIEnv.GetMethodID (class_ref, "predict", "(Lorg/neuroph/core/NeuralNetwork;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_predict_Lorg_neuroph_core_NeuralNetwork_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "predict", "(Lorg/neuroph/core/NeuralNetwork;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_run;
#pragma warning disable 0169
		static Delegate GetRunHandler ()
		{
			if (cb_run == null)
				cb_run = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Run);
			return cb_run;
		}

		static void n_Run (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Samples.Intronn.SunSpots __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Samples.Intronn.SunSpots> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Run ();
		}
#pragma warning restore 0169

		static IntPtr id_run;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.samples.intronn']/class[@name='SunSpots']/method[@name='run' and count(parameter)=0]"
		[Register ("run", "()V", "GetRunHandler")]
		public virtual unsafe void Run ()
		{
			if (id_run == IntPtr.Zero)
				id_run = JNIEnv.GetMethodID (class_ref, "run", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_run);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "run", "()V"));
			} finally {
			}
		}

		static Delegate cb_update_Ljava_util_Observable_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetUpdate_Ljava_util_Observable_Ljava_lang_Object_Handler ()
		{
			if (cb_update_Ljava_util_Observable_Ljava_lang_Object_ == null)
				cb_update_Ljava_util_Observable_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Update_Ljava_util_Observable_Ljava_lang_Object_);
			return cb_update_Ljava_util_Observable_Ljava_lang_Object_;
		}

		static void n_Update_Ljava_util_Observable_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Neuroph.Samples.Intronn.SunSpots __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Samples.Intronn.SunSpots> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Observable p0 = global::Java.Lang.Object.GetObject<global::Java.Util.Observable> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Update (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_update_Ljava_util_Observable_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.samples.intronn']/class[@name='SunSpots']/method[@name='update' and count(parameter)=2 and parameter[1][@type='java.util.Observable'] and parameter[2][@type='java.lang.Object']]"
		[Register ("update", "(Ljava/util/Observable;Ljava/lang/Object;)V", "GetUpdate_Ljava_util_Observable_Ljava_lang_Object_Handler")]
		public virtual unsafe void Update (global::Java.Util.Observable p0, global::Java.Lang.Object p1)
		{
			if (id_update_Ljava_util_Observable_Ljava_lang_Object_ == IntPtr.Zero)
				id_update_Ljava_util_Observable_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "update", "(Ljava/util/Observable;Ljava/lang/Object;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_update_Ljava_util_Observable_Ljava_lang_Object_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "update", "(Ljava/util/Observable;Ljava/lang/Object;)V"), __args);
			} finally {
			}
		}

	}
}
