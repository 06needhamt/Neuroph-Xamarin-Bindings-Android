using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Nnet.Learning {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.nnet.learning']/class[@name='HopfieldLearning']"
	[global::Android.Runtime.Register ("org/neuroph/nnet/learning/HopfieldLearning", DoNotGenerateAcw=true)]
	public partial class HopfieldLearning : global::Org.Neuroph.Core.Learning.LearningRule {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/nnet/learning/HopfieldLearning", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HopfieldLearning); }
		}

		protected HopfieldLearning (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.nnet.learning']/class[@name='HopfieldLearning']/constructor[@name='HopfieldLearning' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe HopfieldLearning ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (HopfieldLearning)) {
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

		static Delegate cb_learn_Lorg_neuroph_core_learning_DataSet_;
#pragma warning disable 0169
		static Delegate GetLearn_Lorg_neuroph_core_learning_DataSet_Handler ()
		{
			if (cb_learn_Lorg_neuroph_core_learning_DataSet_ == null)
				cb_learn_Lorg_neuroph_core_learning_DataSet_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Learn_Lorg_neuroph_core_learning_DataSet_);
			return cb_learn_Lorg_neuroph_core_learning_DataSet_;
		}

		static void n_Learn_Lorg_neuroph_core_learning_DataSet_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Nnet.Learning.HopfieldLearning __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Learning.HopfieldLearning> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Core.Learning.DataSet p0 = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.DataSet> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Learn (p0);
		}
#pragma warning restore 0169

		static IntPtr id_learn_Lorg_neuroph_core_learning_DataSet_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.learning']/class[@name='HopfieldLearning']/method[@name='learn' and count(parameter)=1 and parameter[1][@type='org.neuroph.core.learning.DataSet']]"
		[Register ("learn", "(Lorg/neuroph/core/learning/DataSet;)V", "GetLearn_Lorg_neuroph_core_learning_DataSet_Handler")]
		public override unsafe void Learn (global::Org.Neuroph.Core.Learning.DataSet p0)
		{
			if (id_learn_Lorg_neuroph_core_learning_DataSet_ == IntPtr.Zero)
				id_learn_Lorg_neuroph_core_learning_DataSet_ = JNIEnv.GetMethodID (class_ref, "learn", "(Lorg/neuroph/core/learning/DataSet;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_learn_Lorg_neuroph_core_learning_DataSet_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "learn", "(Lorg/neuroph/core/learning/DataSet;)V"), __args);
			} finally {
			}
		}

	}
}
