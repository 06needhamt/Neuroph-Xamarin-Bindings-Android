using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.util']/class[@name='FileUtils']"
	[global::Android.Runtime.Register ("org/neuroph/util/FileUtils", DoNotGenerateAcw=true)]
	public partial class FileUtils : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/util/FileUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FileUtils); }
		}

		protected FileUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.util']/class[@name='FileUtils']/constructor[@name='FileUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe FileUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (FileUtils)) {
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

		static IntPtr id_readStringFromFile_Ljava_io_File_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util']/class[@name='FileUtils']/method[@name='readStringFromFile' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("readStringFromFile", "(Ljava/io/File;)Ljava/lang/String;", "")]
		public static unsafe string ReadStringFromFile (global::Java.IO.File p0)
		{
			if (id_readStringFromFile_Ljava_io_File_ == IntPtr.Zero)
				id_readStringFromFile_Ljava_io_File_ = JNIEnv.GetStaticMethodID (class_ref, "readStringFromFile", "(Ljava/io/File;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_readStringFromFile_Ljava_io_File_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_writeStringToFile_Ljava_io_File_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util']/class[@name='FileUtils']/method[@name='writeStringToFile' and count(parameter)=2 and parameter[1][@type='java.io.File'] and parameter[2][@type='java.lang.String']]"
		[Register ("writeStringToFile", "(Ljava/io/File;Ljava/lang/String;)V", "")]
		public static unsafe void WriteStringToFile (global::Java.IO.File p0, string p1)
		{
			if (id_writeStringToFile_Ljava_io_File_Ljava_lang_String_ == IntPtr.Zero)
				id_writeStringToFile_Ljava_io_File_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "writeStringToFile", "(Ljava/io/File;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_writeStringToFile_Ljava_io_File_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
