using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Encog.Engine.Validate {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.encog.engine.validate']/class[@name='BasicMachineLearningValidate']"
	[global::Android.Runtime.Register ("org/encog/engine/validate/BasicMachineLearningValidate", DoNotGenerateAcw=true)]
	public abstract partial class BasicMachineLearningValidate : global::Java.Lang.Object, global::Org.Encog.Engine.Validate.IValidateMachineLearning {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/encog/engine/validate/BasicMachineLearningValidate", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BasicMachineLearningValidate); }
		}

		protected BasicMachineLearningValidate (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.encog.engine.validate']/class[@name='BasicMachineLearningValidate']/constructor[@name='BasicMachineLearningValidate' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BasicMachineLearningValidate ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (BasicMachineLearningValidate)) {
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

		static Delegate cb_validate_Lorg_encog_engine_EngineMachineLearning_;
#pragma warning disable 0169
		static Delegate GetValidate_Lorg_encog_engine_EngineMachineLearning_Handler ()
		{
			if (cb_validate_Lorg_encog_engine_EngineMachineLearning_ == null)
				cb_validate_Lorg_encog_engine_EngineMachineLearning_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Validate_Lorg_encog_engine_EngineMachineLearning_);
			return cb_validate_Lorg_encog_engine_EngineMachineLearning_;
		}

		static void n_Validate_Lorg_encog_engine_EngineMachineLearning_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Encog.Engine.Validate.BasicMachineLearningValidate __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Validate.BasicMachineLearningValidate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Encog.Engine.IEngineMachineLearning p0 = (global::Org.Encog.Engine.IEngineMachineLearning)global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.IEngineMachineLearning> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Validate (p0);
		}
#pragma warning restore 0169

		static IntPtr id_validate_Lorg_encog_engine_EngineMachineLearning_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.validate']/class[@name='BasicMachineLearningValidate']/method[@name='validate' and count(parameter)=1 and parameter[1][@type='org.encog.engine.EngineMachineLearning']]"
		[Register ("validate", "(Lorg/encog/engine/EngineMachineLearning;)V", "GetValidate_Lorg_encog_engine_EngineMachineLearning_Handler")]
		public virtual unsafe void Validate (global::Org.Encog.Engine.IEngineMachineLearning p0)
		{
			if (id_validate_Lorg_encog_engine_EngineMachineLearning_ == IntPtr.Zero)
				id_validate_Lorg_encog_engine_EngineMachineLearning_ = JNIEnv.GetMethodID (class_ref, "validate", "(Lorg/encog/engine/EngineMachineLearning;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_validate_Lorg_encog_engine_EngineMachineLearning_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "validate", "(Lorg/encog/engine/EngineMachineLearning;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_isValid_Lorg_encog_engine_EngineMachineLearning_;
#pragma warning disable 0169
		static Delegate GetIsValid_Lorg_encog_engine_EngineMachineLearning_Handler ()
		{
			if (cb_isValid_Lorg_encog_engine_EngineMachineLearning_ == null)
				cb_isValid_Lorg_encog_engine_EngineMachineLearning_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_IsValid_Lorg_encog_engine_EngineMachineLearning_);
			return cb_isValid_Lorg_encog_engine_EngineMachineLearning_;
		}

		static IntPtr n_IsValid_Lorg_encog_engine_EngineMachineLearning_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Encog.Engine.Validate.BasicMachineLearningValidate __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Validate.BasicMachineLearningValidate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Encog.Engine.IEngineMachineLearning p0 = (global::Org.Encog.Engine.IEngineMachineLearning)global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.IEngineMachineLearning> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.IsValid (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.validate']/interface[@name='ValidateMachineLearning']/method[@name='isValid' and count(parameter)=1 and parameter[1][@type='org.encog.engine.EngineMachineLearning']]"
		[Register ("isValid", "(Lorg/encog/engine/EngineMachineLearning;)Ljava/lang/String;", "GetIsValid_Lorg_encog_engine_EngineMachineLearning_Handler")]
		public abstract string IsValid (global::Org.Encog.Engine.IEngineMachineLearning p0);

	}

	[global::Android.Runtime.Register ("org/encog/engine/validate/BasicMachineLearningValidate", DoNotGenerateAcw=true)]
	internal partial class BasicMachineLearningValidateInvoker : BasicMachineLearningValidate {

		public BasicMachineLearningValidateInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (BasicMachineLearningValidateInvoker); }
		}

		static IntPtr id_isValid_Lorg_encog_engine_EngineMachineLearning_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.validate']/interface[@name='ValidateMachineLearning']/method[@name='isValid' and count(parameter)=1 and parameter[1][@type='org.encog.engine.EngineMachineLearning']]"
		[Register ("isValid", "(Lorg/encog/engine/EngineMachineLearning;)Ljava/lang/String;", "GetIsValid_Lorg_encog_engine_EngineMachineLearning_Handler")]
		public override unsafe string IsValid (global::Org.Encog.Engine.IEngineMachineLearning p0)
		{
			if (id_isValid_Lorg_encog_engine_EngineMachineLearning_ == IntPtr.Zero)
				id_isValid_Lorg_encog_engine_EngineMachineLearning_ = JNIEnv.GetMethodID (class_ref, "isValid", "(Lorg/encog/engine/EngineMachineLearning;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_isValid_Lorg_encog_engine_EngineMachineLearning_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}

}
