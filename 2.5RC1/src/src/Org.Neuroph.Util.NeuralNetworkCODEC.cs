using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.util']/class[@name='NeuralNetworkCODEC']"
	[global::Android.Runtime.Register ("org/neuroph/util/NeuralNetworkCODEC", DoNotGenerateAcw=true)]
	public partial class NeuralNetworkCODEC : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/util/NeuralNetworkCODEC", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NeuralNetworkCODEC); }
		}

		protected NeuralNetworkCODEC (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_array2network_arrayDLorg_neuroph_core_NeuralNetwork_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util']/class[@name='NeuralNetworkCODEC']/method[@name='array2network' and count(parameter)=2 and parameter[1][@type='double[]'] and parameter[2][@type='org.neuroph.core.NeuralNetwork']]"
		[Register ("array2network", "([DLorg/neuroph/core/NeuralNetwork;)V", "")]
		public static unsafe void Array2network (double[] p0, global::Org.Neuroph.Core.NeuralNetwork p1)
		{
			if (id_array2network_arrayDLorg_neuroph_core_NeuralNetwork_ == IntPtr.Zero)
				id_array2network_arrayDLorg_neuroph_core_NeuralNetwork_ = JNIEnv.GetStaticMethodID (class_ref, "array2network", "([DLorg/neuroph/core/NeuralNetwork;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_array2network_arrayDLorg_neuroph_core_NeuralNetwork_, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_determineArraySize_Lorg_neuroph_core_NeuralNetwork_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util']/class[@name='NeuralNetworkCODEC']/method[@name='determineArraySize' and count(parameter)=1 and parameter[1][@type='org.neuroph.core.NeuralNetwork']]"
		[Register ("determineArraySize", "(Lorg/neuroph/core/NeuralNetwork;)I", "")]
		public static unsafe int DetermineArraySize (global::Org.Neuroph.Core.NeuralNetwork p0)
		{
			if (id_determineArraySize_Lorg_neuroph_core_NeuralNetwork_ == IntPtr.Zero)
				id_determineArraySize_Lorg_neuroph_core_NeuralNetwork_ = JNIEnv.GetStaticMethodID (class_ref, "determineArraySize", "(Lorg/neuroph/core/NeuralNetwork;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_determineArraySize_Lorg_neuroph_core_NeuralNetwork_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_network2array_Lorg_neuroph_core_NeuralNetwork_arrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util']/class[@name='NeuralNetworkCODEC']/method[@name='network2array' and count(parameter)=2 and parameter[1][@type='org.neuroph.core.NeuralNetwork'] and parameter[2][@type='double[]']]"
		[Register ("network2array", "(Lorg/neuroph/core/NeuralNetwork;[D)V", "")]
		public static unsafe void Network2array (global::Org.Neuroph.Core.NeuralNetwork p0, double[] p1)
		{
			if (id_network2array_Lorg_neuroph_core_NeuralNetwork_arrayD == IntPtr.Zero)
				id_network2array_Lorg_neuroph_core_NeuralNetwork_arrayD = JNIEnv.GetStaticMethodID (class_ref, "network2array", "(Lorg/neuroph/core/NeuralNetwork;[D)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_network2array_Lorg_neuroph_core_NeuralNetwork_arrayD, __args);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

	}
}
