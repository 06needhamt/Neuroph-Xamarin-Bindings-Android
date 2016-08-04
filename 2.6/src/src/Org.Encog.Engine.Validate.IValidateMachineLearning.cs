using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Encog.Engine.Validate {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.encog.engine.validate']/interface[@name='ValidateMachineLearning']"
	[Register ("org/encog/engine/validate/ValidateMachineLearning", "", "Org.Encog.Engine.Validate.IValidateMachineLearningInvoker")]
	public partial interface IValidateMachineLearning : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.validate']/interface[@name='ValidateMachineLearning']/method[@name='isValid' and count(parameter)=1 and parameter[1][@type='org.encog.engine.EngineMachineLearning']]"
		[Register ("isValid", "(Lorg/encog/engine/EngineMachineLearning;)Ljava/lang/String;", "GetIsValid_Lorg_encog_engine_EngineMachineLearning_Handler:Org.Encog.Engine.Validate.IValidateMachineLearningInvoker, Neuroph_2.6")]
		string IsValid (global::Org.Encog.Engine.IEngineMachineLearning p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.validate']/interface[@name='ValidateMachineLearning']/method[@name='validate' and count(parameter)=1 and parameter[1][@type='org.encog.engine.EngineMachineLearning']]"
		[Register ("validate", "(Lorg/encog/engine/EngineMachineLearning;)V", "GetValidate_Lorg_encog_engine_EngineMachineLearning_Handler:Org.Encog.Engine.Validate.IValidateMachineLearningInvoker, Neuroph_2.6")]
		void Validate (global::Org.Encog.Engine.IEngineMachineLearning p0);

	}

	[global::Android.Runtime.Register ("org/encog/engine/validate/ValidateMachineLearning", DoNotGenerateAcw=true)]
	internal class IValidateMachineLearningInvoker : global::Java.Lang.Object, IValidateMachineLearning {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/encog/engine/validate/ValidateMachineLearning");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IValidateMachineLearningInvoker); }
		}

		IntPtr class_ref;

		public static IValidateMachineLearning GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IValidateMachineLearning> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.encog.engine.validate.ValidateMachineLearning"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IValidateMachineLearningInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Org.Encog.Engine.Validate.IValidateMachineLearning __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Validate.IValidateMachineLearning> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Encog.Engine.IEngineMachineLearning p0 = (global::Org.Encog.Engine.IEngineMachineLearning)global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.IEngineMachineLearning> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.IsValid (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_isValid_Lorg_encog_engine_EngineMachineLearning_;
		public unsafe string IsValid (global::Org.Encog.Engine.IEngineMachineLearning p0)
		{
			if (id_isValid_Lorg_encog_engine_EngineMachineLearning_ == IntPtr.Zero)
				id_isValid_Lorg_encog_engine_EngineMachineLearning_ = JNIEnv.GetMethodID (class_ref, "isValid", "(Lorg/encog/engine/EngineMachineLearning;)Ljava/lang/String;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_isValid_Lorg_encog_engine_EngineMachineLearning_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
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
			global::Org.Encog.Engine.Validate.IValidateMachineLearning __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Validate.IValidateMachineLearning> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Encog.Engine.IEngineMachineLearning p0 = (global::Org.Encog.Engine.IEngineMachineLearning)global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.IEngineMachineLearning> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Validate (p0);
		}
#pragma warning restore 0169

		IntPtr id_validate_Lorg_encog_engine_EngineMachineLearning_;
		public unsafe void Validate (global::Org.Encog.Engine.IEngineMachineLearning p0)
		{
			if (id_validate_Lorg_encog_engine_EngineMachineLearning_ == IntPtr.Zero)
				id_validate_Lorg_encog_engine_EngineMachineLearning_ = JNIEnv.GetMethodID (class_ref, "validate", "(Lorg/encog/engine/EngineMachineLearning;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_validate_Lorg_encog_engine_EngineMachineLearning_, __args);
		}

	}

}
