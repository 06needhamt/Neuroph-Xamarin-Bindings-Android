using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Encog.Engine.Opencl.Exceptions {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.encog.engine.opencl.exceptions']/class[@name='MissingOpenCLAdapterError']"
	[global::Android.Runtime.Register ("org/encog/engine/opencl/exceptions/MissingOpenCLAdapterError", DoNotGenerateAcw=true)]
	public partial class MissingOpenCLAdapterError : global::Org.Encog.Engine.Opencl.Exceptions.OpenCLError {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/encog/engine/opencl/exceptions/MissingOpenCLAdapterError", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MissingOpenCLAdapterError); }
		}

		protected MissingOpenCLAdapterError (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_Throwable_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.encog.engine.opencl.exceptions']/class[@name='MissingOpenCLAdapterError']/constructor[@name='MissingOpenCLAdapterError' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register (".ctor", "(Ljava/lang/Throwable;)V", "")]
		public unsafe MissingOpenCLAdapterError (global::Java.Lang.Throwable p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (MissingOpenCLAdapterError)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/Throwable;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, "(Ljava/lang/Throwable;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_Throwable_ == IntPtr.Zero)
					id_ctor_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Throwable;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Throwable_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, class_ref, id_ctor_Ljava_lang_Throwable_, __args);
			} finally {
			}
		}

	}
}
