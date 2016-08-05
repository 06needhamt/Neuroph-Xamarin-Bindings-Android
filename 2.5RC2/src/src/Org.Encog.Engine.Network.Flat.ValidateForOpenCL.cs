using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Encog.Engine.Network.Flat {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.encog.engine.network.flat']/class[@name='ValidateForOpenCL']"
	[global::Android.Runtime.Register ("org/encog/engine/network/flat/ValidateForOpenCL", DoNotGenerateAcw=true)]
	public partial class ValidateForOpenCL : global::Org.Encog.Engine.Validate.BasicMachineLearningValidate {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/encog/engine/network/flat/ValidateForOpenCL", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ValidateForOpenCL); }
		}

		protected ValidateForOpenCL (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.encog.engine.network.flat']/class[@name='ValidateForOpenCL']/constructor[@name='ValidateForOpenCL' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ValidateForOpenCL ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ValidateForOpenCL)) {
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
			global::Org.Encog.Engine.Network.Flat.ValidateForOpenCL __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Flat.ValidateForOpenCL> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Encog.Engine.IEngineMachineLearning p0 = (global::Org.Encog.Engine.IEngineMachineLearning)global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.IEngineMachineLearning> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.IsValid (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_isValid_Lorg_encog_engine_EngineMachineLearning_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.flat']/class[@name='ValidateForOpenCL']/method[@name='isValid' and count(parameter)=1 and parameter[1][@type='org.encog.engine.EngineMachineLearning']]"
		[Register ("isValid", "(Lorg/encog/engine/EngineMachineLearning;)Ljava/lang/String;", "GetIsValid_Lorg_encog_engine_EngineMachineLearning_Handler")]
		public override unsafe string IsValid (global::Org.Encog.Engine.IEngineMachineLearning p0)
		{
			if (id_isValid_Lorg_encog_engine_EngineMachineLearning_ == IntPtr.Zero)
				id_isValid_Lorg_encog_engine_EngineMachineLearning_ = JNIEnv.GetMethodID (class_ref, "isValid", "(Lorg/encog/engine/EngineMachineLearning;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				string __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_isValid_Lorg_encog_engine_EngineMachineLearning_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isValid", "(Lorg/encog/engine/EngineMachineLearning;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
