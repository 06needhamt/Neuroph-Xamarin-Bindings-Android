using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Samples.Convolution {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.samples.convolution']/class[@name='OCRExample']"
	[global::Android.Runtime.Register ("org/neuroph/samples/convolution/OCRExample", DoNotGenerateAcw=true)]
	public partial class OCRExample : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.samples.convolution']/class[@name='OCRExample.LearningListener']"
		[global::Android.Runtime.Register ("org/neuroph/samples/convolution/OCRExample$LearningListener", DoNotGenerateAcw=true)]
		public partial class LearningListener : global::Java.Lang.Object, global::Org.Neuroph.Core.Events.ILearningEventListener {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/neuroph/samples/convolution/OCRExample$LearningListener", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (LearningListener); }
			}

			protected LearningListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

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
				global::Org.Neuroph.Samples.Convolution.OCRExample.LearningListener __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Samples.Convolution.OCRExample.LearningListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Neuroph.Core.Events.LearningEvent p0 = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Events.LearningEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.HandleLearningEvent (p0);
			}
#pragma warning restore 0169

			static IntPtr id_handleLearningEvent_Lorg_neuroph_core_events_LearningEvent_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.samples.convolution']/class[@name='OCRExample.LearningListener']/method[@name='handleLearningEvent' and count(parameter)=1 and parameter[1][@type='org.neuroph.core.events.LearningEvent']]"
			[Register ("handleLearningEvent", "(Lorg/neuroph/core/events/LearningEvent;)V", "GetHandleLearningEvent_Lorg_neuroph_core_events_LearningEvent_Handler")]
			public virtual unsafe void HandleLearningEvent (global::Org.Neuroph.Core.Events.LearningEvent p0)
			{
				if (id_handleLearningEvent_Lorg_neuroph_core_events_LearningEvent_ == IntPtr.Zero)
					id_handleLearningEvent_Lorg_neuroph_core_events_LearningEvent_ = JNIEnv.GetMethodID (class_ref, "handleLearningEvent", "(Lorg/neuroph/core/events/LearningEvent;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_handleLearningEvent_Lorg_neuroph_core_events_LearningEvent_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "handleLearningEvent", "(Lorg/neuroph/core/events/LearningEvent;)V"), __args);
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/samples/convolution/OCRExample", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (OCRExample); }
		}

		protected OCRExample (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.samples.convolution']/class[@name='OCRExample']/constructor[@name='OCRExample' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe OCRExample ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (OCRExample)) {
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

		static IntPtr id_fullConnect_Lorg_neuroph_nnet_comp_layer_FeatureMapsLayer_Lorg_neuroph_core_Layer_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.samples.convolution']/class[@name='OCRExample']/method[@name='fullConnect' and count(parameter)=3 and parameter[1][@type='org.neuroph.nnet.comp.layer.FeatureMapsLayer'] and parameter[2][@type='org.neuroph.core.Layer'] and parameter[3][@type='boolean']]"
		[Register ("fullConnect", "(Lorg/neuroph/nnet/comp/layer/FeatureMapsLayer;Lorg/neuroph/core/Layer;Z)V", "")]
		public static unsafe void FullConnect (global::Org.Neuroph.Nnet.Comp.Layer.FeatureMapsLayer p0, global::Org.Neuroph.Core.Layer p1, bool p2)
		{
			if (id_fullConnect_Lorg_neuroph_nnet_comp_layer_FeatureMapsLayer_Lorg_neuroph_core_Layer_Z == IntPtr.Zero)
				id_fullConnect_Lorg_neuroph_nnet_comp_layer_FeatureMapsLayer_Lorg_neuroph_core_Layer_Z = JNIEnv.GetStaticMethodID (class_ref, "fullConnect", "(Lorg/neuroph/nnet/comp/layer/FeatureMapsLayer;Lorg/neuroph/core/Layer;Z)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_fullConnect_Lorg_neuroph_nnet_comp_layer_FeatureMapsLayer_Lorg_neuroph_core_Layer_Z, __args);
			} finally {
			}
		}

		static IntPtr id_main_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.samples.convolution']/class[@name='OCRExample']/method[@name='main' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register ("main", "([Ljava/lang/String;)V", "")]
		public static unsafe void Main (string[] p0)
		{
			if (id_main_arrayLjava_lang_String_ == IntPtr.Zero)
				id_main_arrayLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "main", "([Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_main_arrayLjava_lang_String_, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_saveImage_Lorg_neuroph_nnet_comp_layer_Layer2D_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.samples.convolution']/class[@name='OCRExample']/method[@name='saveImage' and count(parameter)=1 and parameter[1][@type='org.neuroph.nnet.comp.layer.Layer2D']]"
		[Register ("saveImage", "(Lorg/neuroph/nnet/comp/layer/Layer2D;)V", "")]
		public static unsafe void SaveImage (global::Org.Neuroph.Nnet.Comp.Layer.Layer2D p0)
		{
			if (id_saveImage_Lorg_neuroph_nnet_comp_layer_Layer2D_ == IntPtr.Zero)
				id_saveImage_Lorg_neuroph_nnet_comp_layer_Layer2D_ = JNIEnv.GetStaticMethodID (class_ref, "saveImage", "(Lorg/neuroph/nnet/comp/layer/Layer2D;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_saveImage_Lorg_neuroph_nnet_comp_layer_Layer2D_, __args);
			} finally {
			}
		}

		static IntPtr id_test_Lorg_neuroph_nnet_ConvolutionalNetwork_Lorg_neuroph_core_data_DataSet_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.samples.convolution']/class[@name='OCRExample']/method[@name='test' and count(parameter)=2 and parameter[1][@type='org.neuroph.nnet.ConvolutionalNetwork'] and parameter[2][@type='org.neuroph.core.data.DataSet']]"
		[Register ("test", "(Lorg/neuroph/nnet/ConvolutionalNetwork;Lorg/neuroph/core/data/DataSet;)V", "")]
		public static unsafe void Test (global::Org.Neuroph.Nnet.ConvolutionalNetwork p0, global::Org.Neuroph.Core.Data.DataSet p1)
		{
			if (id_test_Lorg_neuroph_nnet_ConvolutionalNetwork_Lorg_neuroph_core_data_DataSet_ == IntPtr.Zero)
				id_test_Lorg_neuroph_nnet_ConvolutionalNetwork_Lorg_neuroph_core_data_DataSet_ = JNIEnv.GetStaticMethodID (class_ref, "test", "(Lorg/neuroph/nnet/ConvolutionalNetwork;Lorg/neuroph/core/data/DataSet;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_test_Lorg_neuroph_nnet_ConvolutionalNetwork_Lorg_neuroph_core_data_DataSet_, __args);
			} finally {
			}
		}

	}
}
