using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Core.Learning {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='TrainingData']"
	[global::Android.Runtime.Register ("org/neuroph/core/learning/TrainingData", DoNotGenerateAcw=true)]
	public partial class TrainingData : global::Java.Lang.Object, global::Java.IO.ISerializable {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='TrainingData']/field[@name='DELTA_WEIGHT_SUM']"
		[Register ("DELTA_WEIGHT_SUM")]
		public const int DeltaWeightSum = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='TrainingData']/field[@name='PREVIOUS_WEIGHT']"
		[Register ("PREVIOUS_WEIGHT")]
		public const int PreviousWeight = (int) 1;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/core/learning/TrainingData", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TrainingData); }
		}

		protected TrainingData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='TrainingData']/constructor[@name='TrainingData' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe TrainingData (int p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (TrainingData)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(I)V", __args);
					return;
				}

				if (id_ctor_I == IntPtr.Zero)
					id_ctor_I = JNIEnv.GetMethodID (class_ref, "<init>", "(I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_I, __args);
			} finally {
			}
		}

		static Delegate cb_get_I;
#pragma warning disable 0169
		static Delegate GetGet_IHandler ()
		{
			if (cb_get_I == null)
				cb_get_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, double>) n_Get_I);
			return cb_get_I;
		}

		static double n_Get_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Neuroph.Core.Learning.TrainingData __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.TrainingData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Get (p0);
		}
#pragma warning restore 0169

		static IntPtr id_get_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='TrainingData']/method[@name='get' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("get", "(I)D", "GetGet_IHandler")]
		public virtual unsafe double Get (int p0)
		{
			if (id_get_I == IntPtr.Zero)
				id_get_I = JNIEnv.GetMethodID (class_ref, "get", "(I)D");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.CallDoubleMethod  (Handle, id_get_I, __args);
				else
					return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get", "(I)D"), __args);
			} finally {
			}
		}

		static Delegate cb_set_ID;
#pragma warning disable 0169
		static Delegate GetSet_IDHandler ()
		{
			if (cb_set_ID == null)
				cb_set_ID = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, double>) n_Set_ID);
			return cb_set_ID;
		}

		static void n_Set_ID (IntPtr jnienv, IntPtr native__this, int p0, double p1)
		{
			global::Org.Neuroph.Core.Learning.TrainingData __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.TrainingData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Set (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_set_ID;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='TrainingData']/method[@name='set' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='double']]"
		[Register ("set", "(ID)V", "GetSet_IDHandler")]
		public virtual unsafe void Set (int p0, double p1)
		{
			if (id_set_ID == IntPtr.Zero)
				id_set_ID = JNIEnv.GetMethodID (class_ref, "set", "(ID)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_set_ID, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "set", "(ID)V"), __args);
			} finally {
			}
		}

	}
}
