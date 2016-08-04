using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Core.Events {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.core.events']/class[@name='NeuralNetworkEventType']"
	[global::Android.Runtime.Register ("org/neuroph/core/events/NeuralNetworkEventType", DoNotGenerateAcw=true)]
	public sealed partial class NeuralNetworkEventType : global::Java.Lang.Enum {


		static IntPtr CALCULATED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.neuroph.core.events']/class[@name='NeuralNetworkEventType']/field[@name='CALCULATED']"
		[Register ("CALCULATED")]
		public static global::Org.Neuroph.Core.Events.NeuralNetworkEventType Calculated {
			get {
				if (CALCULATED_jfieldId == IntPtr.Zero)
					CALCULATED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CALCULATED", "Lorg/neuroph/core/events/NeuralNetworkEventType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CALCULATED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Events.NeuralNetworkEventType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr CONNECTION_ADDED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.neuroph.core.events']/class[@name='NeuralNetworkEventType']/field[@name='CONNECTION_ADDED']"
		[Register ("CONNECTION_ADDED")]
		public static global::Org.Neuroph.Core.Events.NeuralNetworkEventType ConnectionAdded {
			get {
				if (CONNECTION_ADDED_jfieldId == IntPtr.Zero)
					CONNECTION_ADDED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CONNECTION_ADDED", "Lorg/neuroph/core/events/NeuralNetworkEventType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CONNECTION_ADDED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Events.NeuralNetworkEventType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr CONNECTION_REMOVED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.neuroph.core.events']/class[@name='NeuralNetworkEventType']/field[@name='CONNECTION_REMOVED']"
		[Register ("CONNECTION_REMOVED")]
		public static global::Org.Neuroph.Core.Events.NeuralNetworkEventType ConnectionRemoved {
			get {
				if (CONNECTION_REMOVED_jfieldId == IntPtr.Zero)
					CONNECTION_REMOVED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CONNECTION_REMOVED", "Lorg/neuroph/core/events/NeuralNetworkEventType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CONNECTION_REMOVED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Events.NeuralNetworkEventType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr LAYER_ADDED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.neuroph.core.events']/class[@name='NeuralNetworkEventType']/field[@name='LAYER_ADDED']"
		[Register ("LAYER_ADDED")]
		public static global::Org.Neuroph.Core.Events.NeuralNetworkEventType LayerAdded {
			get {
				if (LAYER_ADDED_jfieldId == IntPtr.Zero)
					LAYER_ADDED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LAYER_ADDED", "Lorg/neuroph/core/events/NeuralNetworkEventType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LAYER_ADDED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Events.NeuralNetworkEventType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr LAYER_REMOVED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.neuroph.core.events']/class[@name='NeuralNetworkEventType']/field[@name='LAYER_REMOVED']"
		[Register ("LAYER_REMOVED")]
		public static global::Org.Neuroph.Core.Events.NeuralNetworkEventType LayerRemoved {
			get {
				if (LAYER_REMOVED_jfieldId == IntPtr.Zero)
					LAYER_REMOVED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LAYER_REMOVED", "Lorg/neuroph/core/events/NeuralNetworkEventType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LAYER_REMOVED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Events.NeuralNetworkEventType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr NEURON_ADDED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.neuroph.core.events']/class[@name='NeuralNetworkEventType']/field[@name='NEURON_ADDED']"
		[Register ("NEURON_ADDED")]
		public static global::Org.Neuroph.Core.Events.NeuralNetworkEventType NeuronAdded {
			get {
				if (NEURON_ADDED_jfieldId == IntPtr.Zero)
					NEURON_ADDED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NEURON_ADDED", "Lorg/neuroph/core/events/NeuralNetworkEventType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NEURON_ADDED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Events.NeuralNetworkEventType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr NEURON_REMOVED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.neuroph.core.events']/class[@name='NeuralNetworkEventType']/field[@name='NEURON_REMOVED']"
		[Register ("NEURON_REMOVED")]
		public static global::Org.Neuroph.Core.Events.NeuralNetworkEventType NeuronRemoved {
			get {
				if (NEURON_REMOVED_jfieldId == IntPtr.Zero)
					NEURON_REMOVED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NEURON_REMOVED", "Lorg/neuroph/core/events/NeuralNetworkEventType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NEURON_REMOVED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Events.NeuralNetworkEventType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/core/events/NeuralNetworkEventType", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NeuralNetworkEventType); }
		}

		internal NeuralNetworkEventType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.events']/class[@name='NeuralNetworkEventType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lorg/neuroph/core/events/NeuralNetworkEventType;", "")]
		public static unsafe global::Org.Neuroph.Core.Events.NeuralNetworkEventType ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lorg/neuroph/core/events/NeuralNetworkEventType;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Org.Neuroph.Core.Events.NeuralNetworkEventType __ret = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Events.NeuralNetworkEventType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.events']/class[@name='NeuralNetworkEventType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lorg/neuroph/core/events/NeuralNetworkEventType;", "")]
		public static unsafe global::Org.Neuroph.Core.Events.NeuralNetworkEventType[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lorg/neuroph/core/events/NeuralNetworkEventType;");
			try {
				return (global::Org.Neuroph.Core.Events.NeuralNetworkEventType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Neuroph.Core.Events.NeuralNetworkEventType));
			} finally {
			}
		}

	}
}
