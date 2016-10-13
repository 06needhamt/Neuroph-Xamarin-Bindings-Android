using System;
using System.Collections.Generic;
using Android.Runtime;

namespace BE.Abeel.IO {

	// Metadata.xml XPath class reference: path="/api/package[@name='be.abeel.io']/class[@name='DirectoryFilter']"
	[global::Android.Runtime.Register ("be/abeel/io/DirectoryFilter", DoNotGenerateAcw=true)]
	public partial class DirectoryFilter : global::Java.Lang.Object, global::Java.IO.IFileFilter {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("be/abeel/io/DirectoryFilter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DirectoryFilter); }
		}

		protected DirectoryFilter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='be.abeel.io']/class[@name='DirectoryFilter']/constructor[@name='DirectoryFilter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DirectoryFilter ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (DirectoryFilter)) {
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

		static Delegate cb_accept_Ljava_io_File_;
#pragma warning disable 0169
		static Delegate GetAccept_Ljava_io_File_Handler ()
		{
			if (cb_accept_Ljava_io_File_ == null)
				cb_accept_Ljava_io_File_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Accept_Ljava_io_File_);
			return cb_accept_Ljava_io_File_;
		}

		static bool n_Accept_Ljava_io_File_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BE.Abeel.IO.DirectoryFilter __this = global::Java.Lang.Object.GetObject<global::BE.Abeel.IO.DirectoryFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.File p0 = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Accept (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_accept_Ljava_io_File_;
		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.io']/class[@name='DirectoryFilter']/method[@name='accept' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("accept", "(Ljava/io/File;)Z", "GetAccept_Ljava_io_File_Handler")]
		public virtual unsafe bool Accept (global::Java.IO.File p0)
		{
			if (id_accept_Ljava_io_File_ == IntPtr.Zero)
				id_accept_Ljava_io_File_ = JNIEnv.GetMethodID (class_ref, "accept", "(Ljava/io/File;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_accept_Ljava_io_File_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "accept", "(Ljava/io/File;)Z"), __args);
				return __ret;
			} finally {
			}
		}

	}
}
