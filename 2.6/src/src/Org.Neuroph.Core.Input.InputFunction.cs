using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Core.Input {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.core.input']/class[@name='InputFunction']"
	[global::Android.Runtime.Register ("org/neuroph/core/input/InputFunction", DoNotGenerateAcw=true)]
	public partial class InputFunction : global::Java.Lang.Object, global::Java.IO.ISerializable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/core/input/InputFunction", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (InputFunction); }
		}

		protected InputFunction (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.core.input']/class[@name='InputFunction']/constructor[@name='InputFunction' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe InputFunction ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (InputFunction)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static IntPtr id_ctor_Lorg_neuroph_core_input_WeightsFunction_Lorg_neuroph_core_input_SummingFunction_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.core.input']/class[@name='InputFunction']/constructor[@name='InputFunction' and count(parameter)=2 and parameter[1][@type='org.neuroph.core.input.WeightsFunction'] and parameter[2][@type='org.neuroph.core.input.SummingFunction']]"
		[Register (".ctor", "(Lorg/neuroph/core/input/WeightsFunction;Lorg/neuroph/core/input/SummingFunction;)V", "")]
		public unsafe InputFunction (global::Org.Neuroph.Core.Input.WeightsFunction p0, global::Org.Neuroph.Core.Input.SummingFunction p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (InputFunction)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/neuroph/core/input/WeightsFunction;Lorg/neuroph/core/input/SummingFunction;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/neuroph/core/input/WeightsFunction;Lorg/neuroph/core/input/SummingFunction;)V", __args);
					return;
				}

				if (id_ctor_Lorg_neuroph_core_input_WeightsFunction_Lorg_neuroph_core_input_SummingFunction_ == IntPtr.Zero)
					id_ctor_Lorg_neuroph_core_input_WeightsFunction_Lorg_neuroph_core_input_SummingFunction_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/neuroph/core/input/WeightsFunction;Lorg/neuroph/core/input/SummingFunction;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_neuroph_core_input_WeightsFunction_Lorg_neuroph_core_input_SummingFunction_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_neuroph_core_input_WeightsFunction_Lorg_neuroph_core_input_SummingFunction_, __args);
			} finally {
			}
		}

		static Delegate cb_getSummingFunction;
#pragma warning disable 0169
		static Delegate GetGetSummingFunctionHandler ()
		{
			if (cb_getSummingFunction == null)
				cb_getSummingFunction = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSummingFunction);
			return cb_getSummingFunction;
		}

		static IntPtr n_GetSummingFunction (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Core.Input.InputFunction __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Input.InputFunction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SummingFunction);
		}
#pragma warning restore 0169

		static IntPtr id_getSummingFunction;
		public virtual unsafe global::Org.Neuroph.Core.Input.SummingFunction SummingFunction {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.input']/class[@name='InputFunction']/method[@name='getSummingFunction' and count(parameter)=0]"
			[Register ("getSummingFunction", "()Lorg/neuroph/core/input/SummingFunction;", "GetGetSummingFunctionHandler")]
			get {
				if (id_getSummingFunction == IntPtr.Zero)
					id_getSummingFunction = JNIEnv.GetMethodID (class_ref, "getSummingFunction", "()Lorg/neuroph/core/input/SummingFunction;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Input.SummingFunction> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSummingFunction), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Input.SummingFunction> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSummingFunction", "()Lorg/neuroph/core/input/SummingFunction;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getWeightsFunction;
#pragma warning disable 0169
		static Delegate GetGetWeightsFunctionHandler ()
		{
			if (cb_getWeightsFunction == null)
				cb_getWeightsFunction = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetWeightsFunction);
			return cb_getWeightsFunction;
		}

		static IntPtr n_GetWeightsFunction (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Core.Input.InputFunction __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Input.InputFunction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WeightsFunction);
		}
#pragma warning restore 0169

		static IntPtr id_getWeightsFunction;
		public virtual unsafe global::Org.Neuroph.Core.Input.WeightsFunction WeightsFunction {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.input']/class[@name='InputFunction']/method[@name='getWeightsFunction' and count(parameter)=0]"
			[Register ("getWeightsFunction", "()Lorg/neuroph/core/input/WeightsFunction;", "GetGetWeightsFunctionHandler")]
			get {
				if (id_getWeightsFunction == IntPtr.Zero)
					id_getWeightsFunction = JNIEnv.GetMethodID (class_ref, "getWeightsFunction", "()Lorg/neuroph/core/input/WeightsFunction;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Input.WeightsFunction> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getWeightsFunction), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Input.WeightsFunction> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWeightsFunction", "()Lorg/neuroph/core/input/WeightsFunction;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getOutput_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetGetOutput_Ljava_util_List_Handler ()
		{
			if (cb_getOutput_Ljava_util_List_ == null)
				cb_getOutput_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, double>) n_GetOutput_Ljava_util_List_);
			return cb_getOutput_Ljava_util_List_;
		}

		static double n_GetOutput_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Core.Input.InputFunction __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Input.InputFunction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Org.Neuroph.Core.Connection>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			double __ret = __this.GetOutput (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getOutput_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.input']/class[@name='InputFunction']/method[@name='getOutput' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;org.neuroph.core.Connection&gt;']]"
		[Register ("getOutput", "(Ljava/util/List;)D", "GetGetOutput_Ljava_util_List_Handler")]
		public virtual unsafe double GetOutput (global::System.Collections.Generic.IList<global::Org.Neuroph.Core.Connection> p0)
		{
			if (id_getOutput_Ljava_util_List_ == IntPtr.Zero)
				id_getOutput_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "getOutput", "(Ljava/util/List;)D");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Org.Neuroph.Core.Connection>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				double __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getOutput_Ljava_util_List_, __args);
				else
					__ret = JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOutput", "(Ljava/util/List;)D"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
