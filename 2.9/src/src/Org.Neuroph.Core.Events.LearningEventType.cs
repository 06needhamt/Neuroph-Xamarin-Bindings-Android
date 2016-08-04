using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Core.Events {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.core.events']/class[@name='LearningEventType']"
	[global::Android.Runtime.Register ("org/neuroph/core/events/LearningEventType", DoNotGenerateAcw=true)]
	public sealed partial class LearningEventType : global::Java.Lang.Enum {


		static IntPtr EPOCH_ENDED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.neuroph.core.events']/class[@name='LearningEventType']/field[@name='EPOCH_ENDED']"
		[Register ("EPOCH_ENDED")]
		public static global::Org.Neuroph.Core.Events.LearningEventType EpochEnded {
			get {
				if (EPOCH_ENDED_jfieldId == IntPtr.Zero)
					EPOCH_ENDED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EPOCH_ENDED", "Lorg/neuroph/core/events/LearningEventType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EPOCH_ENDED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Events.LearningEventType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr LEARNING_STOPPED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.neuroph.core.events']/class[@name='LearningEventType']/field[@name='LEARNING_STOPPED']"
		[Register ("LEARNING_STOPPED")]
		public static global::Org.Neuroph.Core.Events.LearningEventType LearningStopped {
			get {
				if (LEARNING_STOPPED_jfieldId == IntPtr.Zero)
					LEARNING_STOPPED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LEARNING_STOPPED", "Lorg/neuroph/core/events/LearningEventType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LEARNING_STOPPED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Events.LearningEventType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/core/events/LearningEventType", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LearningEventType); }
		}

		internal LearningEventType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.events']/class[@name='LearningEventType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lorg/neuroph/core/events/LearningEventType;", "")]
		public static unsafe global::Org.Neuroph.Core.Events.LearningEventType ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lorg/neuroph/core/events/LearningEventType;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Org.Neuroph.Core.Events.LearningEventType __ret = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Events.LearningEventType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.events']/class[@name='LearningEventType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lorg/neuroph/core/events/LearningEventType;", "")]
		public static unsafe global::Org.Neuroph.Core.Events.LearningEventType[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lorg/neuroph/core/events/LearningEventType;");
			try {
				return (global::Org.Neuroph.Core.Events.LearningEventType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Neuroph.Core.Events.LearningEventType));
			} finally {
			}
		}

	}
}
