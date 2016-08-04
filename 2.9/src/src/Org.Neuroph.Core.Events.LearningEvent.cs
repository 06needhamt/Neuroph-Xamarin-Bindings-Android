using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Core.Events {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.core.events']/class[@name='LearningEvent']"
	[global::Android.Runtime.Register ("org/neuroph/core/events/LearningEvent", DoNotGenerateAcw=true)]
	public partial class LearningEvent : global::Java.Util.EventObject {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/core/events/LearningEvent", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LearningEvent); }
		}

		protected LearningEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_neuroph_core_learning_LearningRule_Lorg_neuroph_core_events_LearningEventType_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.core.events']/class[@name='LearningEvent']/constructor[@name='LearningEvent' and count(parameter)=2 and parameter[1][@type='org.neuroph.core.learning.LearningRule'] and parameter[2][@type='org.neuroph.core.events.LearningEventType']]"
		[Register (".ctor", "(Lorg/neuroph/core/learning/LearningRule;Lorg/neuroph/core/events/LearningEventType;)V", "")]
		public unsafe LearningEvent (global::Org.Neuroph.Core.Learning.LearningRule p0, global::Org.Neuroph.Core.Events.LearningEventType p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (LearningEvent)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/neuroph/core/learning/LearningRule;Lorg/neuroph/core/events/LearningEventType;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorg/neuroph/core/learning/LearningRule;Lorg/neuroph/core/events/LearningEventType;)V", __args);
					return;
				}

				if (id_ctor_Lorg_neuroph_core_learning_LearningRule_Lorg_neuroph_core_events_LearningEventType_ == IntPtr.Zero)
					id_ctor_Lorg_neuroph_core_learning_LearningRule_Lorg_neuroph_core_events_LearningEventType_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/neuroph/core/learning/LearningRule;Lorg/neuroph/core/events/LearningEventType;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_neuroph_core_learning_LearningRule_Lorg_neuroph_core_events_LearningEventType_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_neuroph_core_learning_LearningRule_Lorg_neuroph_core_events_LearningEventType_, __args);
			} finally {
			}
		}

		static Delegate cb_getEventType;
#pragma warning disable 0169
		static Delegate GetGetEventTypeHandler ()
		{
			if (cb_getEventType == null)
				cb_getEventType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEventType);
			return cb_getEventType;
		}

		static IntPtr n_GetEventType (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Core.Events.LearningEvent __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Events.LearningEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.EventType);
		}
#pragma warning restore 0169

		static IntPtr id_getEventType;
		public virtual unsafe global::Org.Neuroph.Core.Events.LearningEventType EventType {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.events']/class[@name='LearningEvent']/method[@name='getEventType' and count(parameter)=0]"
			[Register ("getEventType", "()Lorg/neuroph/core/events/LearningEventType;", "GetGetEventTypeHandler")]
			get {
				if (id_getEventType == IntPtr.Zero)
					id_getEventType = JNIEnv.GetMethodID (class_ref, "getEventType", "()Lorg/neuroph/core/events/LearningEventType;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Events.LearningEventType> (JNIEnv.CallObjectMethod  (Handle, id_getEventType), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Events.LearningEventType> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEventType", "()Lorg/neuroph/core/events/LearningEventType;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
