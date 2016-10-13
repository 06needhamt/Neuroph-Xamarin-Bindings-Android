using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Core.Events {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.core.events']/class[@name='NeuralNetworkEvent']"
	[global::Android.Runtime.Register ("org/neuroph/core/events/NeuralNetworkEvent", DoNotGenerateAcw=true)]
	public partial class NeuralNetworkEvent : global::Java.Util.EventObject {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/core/events/NeuralNetworkEvent", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NeuralNetworkEvent); }
		}

		protected NeuralNetworkEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_neuroph_core_NeuralNetwork_Lorg_neuroph_core_events_NeuralNetworkEventType_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.core.events']/class[@name='NeuralNetworkEvent']/constructor[@name='NeuralNetworkEvent' and count(parameter)=2 and parameter[1][@type='org.neuroph.core.NeuralNetwork'] and parameter[2][@type='org.neuroph.core.events.NeuralNetworkEventType']]"
		[Register (".ctor", "(Lorg/neuroph/core/NeuralNetwork;Lorg/neuroph/core/events/NeuralNetworkEventType;)V", "")]
		public unsafe NeuralNetworkEvent (global::Org.Neuroph.Core.NeuralNetwork p0, global::Org.Neuroph.Core.Events.NeuralNetworkEventType p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (NeuralNetworkEvent)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/neuroph/core/NeuralNetwork;Lorg/neuroph/core/events/NeuralNetworkEventType;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/neuroph/core/NeuralNetwork;Lorg/neuroph/core/events/NeuralNetworkEventType;)V", __args);
					return;
				}

				if (id_ctor_Lorg_neuroph_core_NeuralNetwork_Lorg_neuroph_core_events_NeuralNetworkEventType_ == IntPtr.Zero)
					id_ctor_Lorg_neuroph_core_NeuralNetwork_Lorg_neuroph_core_events_NeuralNetworkEventType_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/neuroph/core/NeuralNetwork;Lorg/neuroph/core/events/NeuralNetworkEventType;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_neuroph_core_NeuralNetwork_Lorg_neuroph_core_events_NeuralNetworkEventType_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_neuroph_core_NeuralNetwork_Lorg_neuroph_core_events_NeuralNetworkEventType_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Lorg_neuroph_core_Layer_Lorg_neuroph_core_events_NeuralNetworkEventType_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.core.events']/class[@name='NeuralNetworkEvent']/constructor[@name='NeuralNetworkEvent' and count(parameter)=2 and parameter[1][@type='org.neuroph.core.Layer'] and parameter[2][@type='org.neuroph.core.events.NeuralNetworkEventType']]"
		[Register (".ctor", "(Lorg/neuroph/core/Layer;Lorg/neuroph/core/events/NeuralNetworkEventType;)V", "")]
		public unsafe NeuralNetworkEvent (global::Org.Neuroph.Core.Layer p0, global::Org.Neuroph.Core.Events.NeuralNetworkEventType p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (NeuralNetworkEvent)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/neuroph/core/Layer;Lorg/neuroph/core/events/NeuralNetworkEventType;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/neuroph/core/Layer;Lorg/neuroph/core/events/NeuralNetworkEventType;)V", __args);
					return;
				}

				if (id_ctor_Lorg_neuroph_core_Layer_Lorg_neuroph_core_events_NeuralNetworkEventType_ == IntPtr.Zero)
					id_ctor_Lorg_neuroph_core_Layer_Lorg_neuroph_core_events_NeuralNetworkEventType_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/neuroph/core/Layer;Lorg/neuroph/core/events/NeuralNetworkEventType;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_neuroph_core_Layer_Lorg_neuroph_core_events_NeuralNetworkEventType_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_neuroph_core_Layer_Lorg_neuroph_core_events_NeuralNetworkEventType_, __args);
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
			global::Org.Neuroph.Core.Events.NeuralNetworkEvent __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Events.NeuralNetworkEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.EventType);
		}
#pragma warning restore 0169

		static IntPtr id_getEventType;
		public virtual unsafe global::Org.Neuroph.Core.Events.NeuralNetworkEventType EventType {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.events']/class[@name='NeuralNetworkEvent']/method[@name='getEventType' and count(parameter)=0]"
			[Register ("getEventType", "()Lorg/neuroph/core/events/NeuralNetworkEventType;", "GetGetEventTypeHandler")]
			get {
				if (id_getEventType == IntPtr.Zero)
					id_getEventType = JNIEnv.GetMethodID (class_ref, "getEventType", "()Lorg/neuroph/core/events/NeuralNetworkEventType;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Events.NeuralNetworkEventType> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEventType), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Events.NeuralNetworkEventType> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEventType", "()Lorg/neuroph/core/events/NeuralNetworkEventType;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
