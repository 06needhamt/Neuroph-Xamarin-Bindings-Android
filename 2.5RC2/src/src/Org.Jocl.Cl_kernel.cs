using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jocl {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jocl']/class[@name='cl_kernel']"
	[global::Android.Runtime.Register ("org/jocl/cl_kernel", DoNotGenerateAcw=true)]
	public sealed partial class Cl_kernel : global::Org.Jocl.NativePointerObject {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jocl/cl_kernel", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Cl_kernel); }
		}

		internal Cl_kernel (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jocl']/class[@name='cl_kernel']/constructor[@name='cl_kernel' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Cl_kernel ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Cl_kernel)) {
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

	}
}
