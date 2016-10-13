using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Core.Events {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.neuroph.core.events']/interface[@name='NeuralNetworkEventListener']"
	[Register ("org/neuroph/core/events/NeuralNetworkEventListener", "", "Org.Neuroph.Core.Events.INeuralNetworkEventListenerInvoker")]
	public partial interface INeuralNetworkEventListener : global::Java.Util.IEventListener {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.events']/interface[@name='NeuralNetworkEventListener']/method[@name='handleNeuralNetworkEvent' and count(parameter)=1 and parameter[1][@type='org.neuroph.core.events.NeuralNetworkEvent']]"
		[Register ("handleNeuralNetworkEvent", "(Lorg/neuroph/core/events/NeuralNetworkEvent;)V", "GetHandleNeuralNetworkEvent_Lorg_neuroph_core_events_NeuralNetworkEvent_Handler:Org.Neuroph.Core.Events.INeuralNetworkEventListenerInvoker, neuroph_2.7")]
		void HandleNeuralNetworkEvent (global::Org.Neuroph.Core.Events.NeuralNetworkEvent p0);

	}

	[global::Android.Runtime.Register ("org/neuroph/core/events/NeuralNetworkEventListener", DoNotGenerateAcw=true)]
	internal class INeuralNetworkEventListenerInvoker : global::Java.Lang.Object, INeuralNetworkEventListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/neuroph/core/events/NeuralNetworkEventListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (INeuralNetworkEventListenerInvoker); }
		}

		IntPtr class_ref;

		public static INeuralNetworkEventListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<INeuralNetworkEventListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.neuroph.core.events.NeuralNetworkEventListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public INeuralNetworkEventListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_handleNeuralNetworkEvent_Lorg_neuroph_core_events_NeuralNetworkEvent_;
#pragma warning disable 0169
		static Delegate GetHandleNeuralNetworkEvent_Lorg_neuroph_core_events_NeuralNetworkEvent_Handler ()
		{
			if (cb_handleNeuralNetworkEvent_Lorg_neuroph_core_events_NeuralNetworkEvent_ == null)
				cb_handleNeuralNetworkEvent_Lorg_neuroph_core_events_NeuralNetworkEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_HandleNeuralNetworkEvent_Lorg_neuroph_core_events_NeuralNetworkEvent_);
			return cb_handleNeuralNetworkEvent_Lorg_neuroph_core_events_NeuralNetworkEvent_;
		}

		static void n_HandleNeuralNetworkEvent_Lorg_neuroph_core_events_NeuralNetworkEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Core.Events.INeuralNetworkEventListener __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Events.INeuralNetworkEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Core.Events.NeuralNetworkEvent p0 = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Events.NeuralNetworkEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.HandleNeuralNetworkEvent (p0);
		}
#pragma warning restore 0169

		IntPtr id_handleNeuralNetworkEvent_Lorg_neuroph_core_events_NeuralNetworkEvent_;
		public unsafe void HandleNeuralNetworkEvent (global::Org.Neuroph.Core.Events.NeuralNetworkEvent p0)
		{
			if (id_handleNeuralNetworkEvent_Lorg_neuroph_core_events_NeuralNetworkEvent_ == IntPtr.Zero)
				id_handleNeuralNetworkEvent_Lorg_neuroph_core_events_NeuralNetworkEvent_ = JNIEnv.GetMethodID (class_ref, "handleNeuralNetworkEvent", "(Lorg/neuroph/core/events/NeuralNetworkEvent;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_handleNeuralNetworkEvent_Lorg_neuroph_core_events_NeuralNetworkEvent_, __args);
		}

	}

}
