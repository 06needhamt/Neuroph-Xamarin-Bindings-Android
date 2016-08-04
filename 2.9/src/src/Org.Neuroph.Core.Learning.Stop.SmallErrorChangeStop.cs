using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Core.Learning.Stop {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.core.learning.stop']/class[@name='SmallErrorChangeStop']"
	[global::Android.Runtime.Register ("org/neuroph/core/learning/stop/SmallErrorChangeStop", DoNotGenerateAcw=true)]
	public partial class SmallErrorChangeStop : global::Java.Lang.Object, global::Java.IO.ISerializable, global::Org.Neuroph.Core.Learning.Stop.IStopCondition {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/core/learning/stop/SmallErrorChangeStop", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SmallErrorChangeStop); }
		}

		protected SmallErrorChangeStop (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_neuroph_core_learning_SupervisedLearning_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.core.learning.stop']/class[@name='SmallErrorChangeStop']/constructor[@name='SmallErrorChangeStop' and count(parameter)=1 and parameter[1][@type='org.neuroph.core.learning.SupervisedLearning']]"
		[Register (".ctor", "(Lorg/neuroph/core/learning/SupervisedLearning;)V", "")]
		public unsafe SmallErrorChangeStop (global::Org.Neuroph.Core.Learning.SupervisedLearning p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (SmallErrorChangeStop)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/neuroph/core/learning/SupervisedLearning;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorg/neuroph/core/learning/SupervisedLearning;)V", __args);
					return;
				}

				if (id_ctor_Lorg_neuroph_core_learning_SupervisedLearning_ == IntPtr.Zero)
					id_ctor_Lorg_neuroph_core_learning_SupervisedLearning_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/neuroph/core/learning/SupervisedLearning;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_neuroph_core_learning_SupervisedLearning_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_neuroph_core_learning_SupervisedLearning_, __args);
			} finally {
			}
		}

		static Delegate cb_isReached;
#pragma warning disable 0169
		static Delegate GetIsReachedHandler ()
		{
			if (cb_isReached == null)
				cb_isReached = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsReached);
			return cb_isReached;
		}

		static bool n_IsReached (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Core.Learning.Stop.SmallErrorChangeStop __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.Stop.SmallErrorChangeStop> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsReached;
		}
#pragma warning restore 0169

		static IntPtr id_isReached;
		public virtual unsafe bool IsReached {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.learning.stop']/class[@name='SmallErrorChangeStop']/method[@name='isReached' and count(parameter)=0]"
			[Register ("isReached", "()Z", "GetIsReachedHandler")]
			get {
				if (id_isReached == IntPtr.Zero)
					id_isReached = JNIEnv.GetMethodID (class_ref, "isReached", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isReached);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isReached", "()Z"));
				} finally {
				}
			}
		}

	}
}
