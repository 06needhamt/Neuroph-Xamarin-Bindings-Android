using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Core.Learning {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='SupervisedTrainingElement']"
	[global::Android.Runtime.Register ("org/neuroph/core/learning/SupervisedTrainingElement", DoNotGenerateAcw=true)]
	public partial class SupervisedTrainingElement : global::Org.Neuroph.Core.Learning.TrainingElement, global::Java.IO.ISerializable {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/core/learning/SupervisedTrainingElement", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SupervisedTrainingElement); }
		}

		protected SupervisedTrainingElement (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_arrayDarrayD;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='SupervisedTrainingElement']/constructor[@name='SupervisedTrainingElement' and count(parameter)=2 and parameter[1][@type='double[]'] and parameter[2][@type='double[]']]"
		[Register (".ctor", "([D[D)V", "")]
		public unsafe SupervisedTrainingElement (double[] p0, double[] p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				if (GetType () != typeof (SupervisedTrainingElement)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "([D[D)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "([D[D)V", __args);
					return;
				}

				if (id_ctor_arrayDarrayD == IntPtr.Zero)
					id_ctor_arrayDarrayD = JNIEnv.GetMethodID (class_ref, "<init>", "([D[D)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayDarrayD, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_arrayDarrayD, __args);
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

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='SupervisedTrainingElement']/constructor[@name='SupervisedTrainingElement' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe SupervisedTrainingElement (string p0, string p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				if (GetType () != typeof (SupervisedTrainingElement)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_ctor_Ljava_util_ArrayList_Ljava_util_ArrayList_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='SupervisedTrainingElement']/constructor[@name='SupervisedTrainingElement' and count(parameter)=2 and parameter[1][@type='java.util.ArrayList&lt;java.lang.Double&gt;'] and parameter[2][@type='java.util.ArrayList&lt;java.lang.Double&gt;']]"
		[Register (".ctor", "(Ljava/util/ArrayList;Ljava/util/ArrayList;)V", "")]
		public unsafe SupervisedTrainingElement (global::System.Collections.Generic.IList<global::Java.Lang.Double> p0, global::System.Collections.Generic.IList<global::Java.Lang.Double> p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Java.Lang.Double>.ToLocalJniHandle (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::Java.Lang.Double>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				if (GetType () != typeof (SupervisedTrainingElement)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/util/ArrayList;Ljava/util/ArrayList;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/util/ArrayList;Ljava/util/ArrayList;)V", __args);
					return;
				}

				if (id_ctor_Ljava_util_ArrayList_Ljava_util_ArrayList_ == IntPtr.Zero)
					id_ctor_Ljava_util_ArrayList_Ljava_util_ArrayList_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/util/ArrayList;Ljava/util/ArrayList;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_util_ArrayList_Ljava_util_ArrayList_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_util_ArrayList_Ljava_util_ArrayList_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_getDesiredOutput;
#pragma warning disable 0169
		static Delegate GetGetDesiredOutputHandler ()
		{
			if (cb_getDesiredOutput == null)
				cb_getDesiredOutput = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDesiredOutput);
			return cb_getDesiredOutput;
		}

		static IntPtr n_GetDesiredOutput (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Core.Learning.SupervisedTrainingElement __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.SupervisedTrainingElement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetDesiredOutput ());
		}
#pragma warning restore 0169

		static IntPtr id_getDesiredOutput;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='SupervisedTrainingElement']/method[@name='getDesiredOutput' and count(parameter)=0]"
		[Register ("getDesiredOutput", "()[D", "GetGetDesiredOutputHandler")]
		public virtual unsafe double[] GetDesiredOutput ()
		{
			if (id_getDesiredOutput == IntPtr.Zero)
				id_getDesiredOutput = JNIEnv.GetMethodID (class_ref, "getDesiredOutput", "()[D");
			try {

				if (GetType () == ThresholdType)
					return (double[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getDesiredOutput), JniHandleOwnership.TransferLocalRef, typeof (double));
				else
					return (double[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDesiredOutput", "()[D")), JniHandleOwnership.TransferLocalRef, typeof (double));
			} finally {
			}
		}

		static Delegate cb_setDesiredOutput_arrayD;
#pragma warning disable 0169
		static Delegate GetSetDesiredOutput_arrayDHandler ()
		{
			if (cb_setDesiredOutput_arrayD == null)
				cb_setDesiredOutput_arrayD = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDesiredOutput_arrayD);
			return cb_setDesiredOutput_arrayD;
		}

		static void n_SetDesiredOutput_arrayD (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Core.Learning.SupervisedTrainingElement __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.SupervisedTrainingElement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			double[] p0 = (double[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (double));
			__this.SetDesiredOutput (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_setDesiredOutput_arrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='SupervisedTrainingElement']/method[@name='setDesiredOutput' and count(parameter)=1 and parameter[1][@type='double[]']]"
		[Register ("setDesiredOutput", "([D)V", "GetSetDesiredOutput_arrayDHandler")]
		public virtual unsafe void SetDesiredOutput (double[] p0)
		{
			if (id_setDesiredOutput_arrayD == IntPtr.Zero)
				id_setDesiredOutput_arrayD = JNIEnv.GetMethodID (class_ref, "setDesiredOutput", "([D)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setDesiredOutput_arrayD, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDesiredOutput", "([D)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

	}
}
