using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Samples.Convolution {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.samples.convolution']/class[@name='ModelMetric']"
	[global::Android.Runtime.Register ("org/neuroph/samples/convolution/ModelMetric", DoNotGenerateAcw=true)]
	public partial class ModelMetric : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.samples.convolution']/class[@name='ModelMetric.Output']"
		[global::Android.Runtime.Register ("org/neuroph/samples/convolution/ModelMetric$Output", DoNotGenerateAcw=true)]
		public partial class Output : global::Java.Lang.Object, global::Java.Lang.IComparable {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/neuroph/samples/convolution/ModelMetric$Output", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Output); }
			}

			protected Output (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_ID;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.samples.convolution']/class[@name='ModelMetric.Output']/constructor[@name='ModelMetric.Output' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='double']]"
			[Register (".ctor", "(ID)V", "")]
			public unsafe Output (int p0, double p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					if (GetType () != typeof (Output)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(ID)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(ID)V", __args);
						return;
					}

					if (id_ctor_ID == IntPtr.Zero)
						id_ctor_ID = JNIEnv.GetMethodID (class_ref, "<init>", "(ID)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_ID, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_ID, __args);
				} finally {
				}
			}

			static Delegate cb_compareTo_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetCompareTo_Ljava_lang_Object_Handler ()
			{
				if (cb_compareTo_Ljava_lang_Object_ == null)
					cb_compareTo_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_CompareTo_Ljava_lang_Object_);
				return cb_compareTo_Ljava_lang_Object_;
			}

			static int n_CompareTo_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Org.Neuroph.Samples.Convolution.ModelMetric.Output __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Samples.Convolution.ModelMetric.Output> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.CompareTo (p0);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_compareTo_Ljava_lang_Object_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.samples.convolution']/class[@name='ModelMetric.Output']/method[@name='compareTo' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
			[Register ("compareTo", "(Ljava/lang/Object;)I", "GetCompareTo_Ljava_lang_Object_Handler")]
			public virtual unsafe int CompareTo (global::Java.Lang.Object p0)
			{
				if (id_compareTo_Ljava_lang_Object_ == IntPtr.Zero)
					id_compareTo_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "compareTo", "(Ljava/lang/Object;)I");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					int __ret;
					if (GetType () == ThresholdType)
						__ret = JNIEnv.CallIntMethod  (Handle, id_compareTo_Ljava_lang_Object_, __args);
					else
						__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "compareTo", "(Ljava/lang/Object;)I"), __args);
					return __ret;
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/samples/convolution/ModelMetric", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ModelMetric); }
		}

		protected ModelMetric (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.samples.convolution']/class[@name='ModelMetric']/constructor[@name='ModelMetric' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ModelMetric ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ModelMetric)) {
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

		static IntPtr id_calculateModelMetric_Lorg_neuroph_core_NeuralNetwork_Lorg_neuroph_core_data_DataSet_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.samples.convolution']/class[@name='ModelMetric']/method[@name='calculateModelMetric' and count(parameter)=2 and parameter[1][@type='org.neuroph.core.NeuralNetwork&lt;org.neuroph.nnet.learning.ConvolutionalBackpropagation&gt;'] and parameter[2][@type='org.neuroph.core.data.DataSet']]"
		[Register ("calculateModelMetric", "(Lorg/neuroph/core/NeuralNetwork;Lorg/neuroph/core/data/DataSet;)V", "")]
		public static unsafe void CalculateModelMetric (global::Org.Neuroph.Core.NeuralNetwork p0, global::Org.Neuroph.Core.Data.DataSet p1)
		{
			if (id_calculateModelMetric_Lorg_neuroph_core_NeuralNetwork_Lorg_neuroph_core_data_DataSet_ == IntPtr.Zero)
				id_calculateModelMetric_Lorg_neuroph_core_NeuralNetwork_Lorg_neuroph_core_data_DataSet_ = JNIEnv.GetStaticMethodID (class_ref, "calculateModelMetric", "(Lorg/neuroph/core/NeuralNetwork;Lorg/neuroph/core/data/DataSet;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_calculateModelMetric_Lorg_neuroph_core_NeuralNetwork_Lorg_neuroph_core_data_DataSet_, __args);
			} finally {
			}
		}

	}
}
