using System;
using System.Collections.Generic;
using Android.Runtime;

namespace BE.Abeel.IO {

	// Metadata.xml XPath class reference: path="/api/package[@name='be.abeel.io']/class[@name='PatternFileFilter']"
	[global::Android.Runtime.Register ("be/abeel/io/PatternFileFilter", DoNotGenerateAcw=true)]
	public partial class PatternFileFilter : global::Java.Lang.Object, global::Java.IO.IFileFilter {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("be/abeel/io/PatternFileFilter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PatternFileFilter); }
		}

		protected PatternFileFilter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='be.abeel.io']/class[@name='PatternFileFilter']/constructor[@name='PatternFileFilter' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe PatternFileFilter (string p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (PatternFileFilter)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
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
			global::BE.Abeel.IO.PatternFileFilter __this = global::Java.Lang.Object.GetObject<global::BE.Abeel.IO.PatternFileFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.File p0 = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Accept (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_accept_Ljava_io_File_;
		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.io']/class[@name='PatternFileFilter']/method[@name='accept' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
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
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_accept_Ljava_io_File_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "accept", "(Ljava/io/File;)Z"), __args);
				return __ret;
			} finally {
			}
		}

	}
}
