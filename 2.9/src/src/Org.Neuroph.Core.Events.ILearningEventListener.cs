using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Core.Events {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.neuroph.core.events']/interface[@name='LearningEventListener']"
	[Register ("org/neuroph/core/events/LearningEventListener", "", "Org.Neuroph.Core.Events.ILearningEventListenerInvoker")]
	public partial interface ILearningEventListener : global::Java.Util.IEventListener {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.events']/interface[@name='LearningEventListener']/method[@name='handleLearningEvent' and count(parameter)=1 and parameter[1][@type='org.neuroph.core.events.LearningEvent']]"
		[Register ("handleLearningEvent", "(Lorg/neuroph/core/events/LearningEvent;)V", "GetHandleLearningEvent_Lorg_neuroph_core_events_LearningEvent_Handler:Org.Neuroph.Core.Events.ILearningEventListenerInvoker, neuroph_2.9")]
		void HandleLearningEvent (global::Org.Neuroph.Core.Events.LearningEvent p0);

	}

	[global::Android.Runtime.Register ("org/neuroph/core/events/LearningEventListener", DoNotGenerateAcw=true)]
	internal class ILearningEventListenerInvoker : global::Java.Lang.Object, ILearningEventListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/neuroph/core/events/LearningEventListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ILearningEventListenerInvoker); }
		}

		IntPtr class_ref;

		public static ILearningEventListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ILearningEventListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.neuroph.core.events.LearningEventListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ILearningEventListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_handleLearningEvent_Lorg_neuroph_core_events_LearningEvent_;
#pragma warning disable 0169
		static Delegate GetHandleLearningEvent_Lorg_neuroph_core_events_LearningEvent_Handler ()
		{
			if (cb_handleLearningEvent_Lorg_neuroph_core_events_LearningEvent_ == null)
				cb_handleLearningEvent_Lorg_neuroph_core_events_LearningEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_HandleLearningEvent_Lorg_neuroph_core_events_LearningEvent_);
			return cb_handleLearningEvent_Lorg_neuroph_core_events_LearningEvent_;
		}

		static void n_HandleLearningEvent_Lorg_neuroph_core_events_LearningEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Core.Events.ILearningEventListener __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Events.ILearningEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Core.Events.LearningEvent p0 = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Events.LearningEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.HandleLearningEvent (p0);
		}
#pragma warning restore 0169

		IntPtr id_handleLearningEvent_Lorg_neuroph_core_events_LearningEvent_;
		public unsafe void HandleLearningEvent (global::Org.Neuroph.Core.Events.LearningEvent p0)
		{
			if (id_handleLearningEvent_Lorg_neuroph_core_events_LearningEvent_ == IntPtr.Zero)
				id_handleLearningEvent_Lorg_neuroph_core_events_LearningEvent_ = JNIEnv.GetMethodID (class_ref, "handleLearningEvent", "(Lorg/neuroph/core/events/LearningEvent;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_handleLearningEvent_Lorg_neuroph_core_events_LearningEvent_, __args);
		}

	}

}
