using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Nnet {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.nnet']/class[@name='MultiLayerPerceptron']"
	[global::Android.Runtime.Register ("org/neuroph/nnet/MultiLayerPerceptron", DoNotGenerateAcw=true)]
	public partial class MultiLayerPerceptron : global::Org.Neuroph.Core.NeuralNetwork {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/nnet/MultiLayerPerceptron", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MultiLayerPerceptron); }
		}

		protected MultiLayerPerceptron (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_util_List_Lorg_neuroph_util_NeuronProperties_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.nnet']/class[@name='MultiLayerPerceptron']/constructor[@name='MultiLayerPerceptron' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;java.lang.Integer&gt;'] and parameter[2][@type='org.neuroph.util.NeuronProperties']]"
		[Register (".ctor", "(Ljava/util/List;Lorg/neuroph/util/NeuronProperties;)V", "")]
		public unsafe MultiLayerPerceptron (global::System.Collections.Generic.IList<global::Java.Lang.Integer> p0, global::Org.Neuroph.Util.NeuronProperties p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Java.Lang.Integer>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (MultiLayerPerceptron)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/util/List;Lorg/neuroph/util/NeuronProperties;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/util/List;Lorg/neuroph/util/NeuronProperties;)V", __args);
					return;
				}

				if (id_ctor_Ljava_util_List_Lorg_neuroph_util_NeuronProperties_ == IntPtr.Zero)
					id_ctor_Ljava_util_List_Lorg_neuroph_util_NeuronProperties_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/util/List;Lorg/neuroph/util/NeuronProperties;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_util_List_Lorg_neuroph_util_NeuronProperties_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_util_List_Lorg_neuroph_util_NeuronProperties_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_ctor_Ljava_util_List_Lorg_neuroph_util_TransferFunctionType_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.nnet']/class[@name='MultiLayerPerceptron']/constructor[@name='MultiLayerPerceptron' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;java.lang.Integer&gt;'] and parameter[2][@type='org.neuroph.util.TransferFunctionType']]"
		[Register (".ctor", "(Ljava/util/List;Lorg/neuroph/util/TransferFunctionType;)V", "")]
		public unsafe MultiLayerPerceptron (global::System.Collections.Generic.IList<global::Java.Lang.Integer> p0, global::Org.Neuroph.Util.TransferFunctionType p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Java.Lang.Integer>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (MultiLayerPerceptron)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/util/List;Lorg/neuroph/util/TransferFunctionType;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/util/List;Lorg/neuroph/util/TransferFunctionType;)V", __args);
					return;
				}

				if (id_ctor_Ljava_util_List_Lorg_neuroph_util_TransferFunctionType_ == IntPtr.Zero)
					id_ctor_Ljava_util_List_Lorg_neuroph_util_TransferFunctionType_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/util/List;Lorg/neuroph/util/TransferFunctionType;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_util_List_Lorg_neuroph_util_TransferFunctionType_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_util_List_Lorg_neuroph_util_TransferFunctionType_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_ctor_Lorg_neuroph_util_TransferFunctionType_arrayI;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.nnet']/class[@name='MultiLayerPerceptron']/constructor[@name='MultiLayerPerceptron' and count(parameter)=2 and parameter[1][@type='org.neuroph.util.TransferFunctionType'] and parameter[2][@type='int...']]"
		[Register (".ctor", "(Lorg/neuroph/util/TransferFunctionType;[I)V", "")]
		public unsafe MultiLayerPerceptron (global::Org.Neuroph.Util.TransferFunctionType p0, params  int[] p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				if (GetType () != typeof (MultiLayerPerceptron)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/neuroph/util/TransferFunctionType;[I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/neuroph/util/TransferFunctionType;[I)V", __args);
					return;
				}

				if (id_ctor_Lorg_neuroph_util_TransferFunctionType_arrayI == IntPtr.Zero)
					id_ctor_Lorg_neuroph_util_TransferFunctionType_arrayI = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/neuroph/util/TransferFunctionType;[I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_neuroph_util_TransferFunctionType_arrayI, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_neuroph_util_TransferFunctionType_arrayI, __args);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static IntPtr id_ctor_arrayI;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.nnet']/class[@name='MultiLayerPerceptron']/constructor[@name='MultiLayerPerceptron' and count(parameter)=1 and parameter[1][@type='int...']]"
		[Register (".ctor", "([I)V", "")]
		public unsafe MultiLayerPerceptron (params  int[] p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (MultiLayerPerceptron)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "([I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "([I)V", __args);
					return;
				}

				if (id_ctor_arrayI == IntPtr.Zero)
					id_ctor_arrayI = JNIEnv.GetMethodID (class_ref, "<init>", "([I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayI, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_arrayI, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_ctor_Ljava_util_List_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.nnet']/class[@name='MultiLayerPerceptron']/constructor[@name='MultiLayerPerceptron' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.Integer&gt;']]"
		[Register (".ctor", "(Ljava/util/List;)V", "")]
		public unsafe MultiLayerPerceptron (global::System.Collections.Generic.IList<global::Java.Lang.Integer> p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Java.Lang.Integer>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (MultiLayerPerceptron)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/util/List;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/util/List;)V", __args);
					return;
				}

				if (id_ctor_Ljava_util_List_ == IntPtr.Zero)
					id_ctor_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/util/List;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_util_List_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_util_List_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_connectInputsToOutputs;
#pragma warning disable 0169
		static Delegate GetConnectInputsToOutputsHandler ()
		{
			if (cb_connectInputsToOutputs == null)
				cb_connectInputsToOutputs = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ConnectInputsToOutputs);
			return cb_connectInputsToOutputs;
		}

		static void n_ConnectInputsToOutputs (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Nnet.MultiLayerPerceptron __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.MultiLayerPerceptron> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ConnectInputsToOutputs ();
		}
#pragma warning restore 0169

		static IntPtr id_connectInputsToOutputs;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet']/class[@name='MultiLayerPerceptron']/method[@name='connectInputsToOutputs' and count(parameter)=0]"
		[Register ("connectInputsToOutputs", "()V", "GetConnectInputsToOutputsHandler")]
		public virtual unsafe void ConnectInputsToOutputs ()
		{
			if (id_connectInputsToOutputs == IntPtr.Zero)
				id_connectInputsToOutputs = JNIEnv.GetMethodID (class_ref, "connectInputsToOutputs", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_connectInputsToOutputs);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "connectInputsToOutputs", "()V"));
			} finally {
			}
		}

	}
}
