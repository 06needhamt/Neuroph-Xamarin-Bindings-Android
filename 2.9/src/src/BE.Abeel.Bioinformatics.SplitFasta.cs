using System;
using System.Collections.Generic;
using Android.Runtime;

namespace BE.Abeel.Bioinformatics {

	// Metadata.xml XPath class reference: path="/api/package[@name='be.abeel.bioinformatics']/class[@name='SplitFasta']"
	[global::Android.Runtime.Register ("be/abeel/bioinformatics/SplitFasta", DoNotGenerateAcw=true)]
	public partial class SplitFasta : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("be/abeel/bioinformatics/SplitFasta", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SplitFasta); }
		}

		protected SplitFasta (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='be.abeel.bioinformatics']/class[@name='SplitFasta']/constructor[@name='SplitFasta' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SplitFasta ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (SplitFasta)) {
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

		static IntPtr id_main_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.bioinformatics']/class[@name='SplitFasta']/method[@name='main' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register ("main", "([Ljava/lang/String;)V", "")]
		public static unsafe void Main (string[] p0)
		{
			if (id_main_arrayLjava_lang_String_ == IntPtr.Zero)
				id_main_arrayLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "main", "([Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_main_arrayLjava_lang_String_, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_splitFile_Ljava_io_File_;
		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.bioinformatics']/class[@name='SplitFasta']/method[@name='splitFile' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("splitFile", "(Ljava/io/File;)V", "")]
		public static unsafe void SplitFile (global::Java.IO.File p0)
		{
			if (id_splitFile_Ljava_io_File_ == IntPtr.Zero)
				id_splitFile_Ljava_io_File_ = JNIEnv.GetStaticMethodID (class_ref, "splitFile", "(Ljava/io/File;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_splitFile_Ljava_io_File_, __args);
			} finally {
			}
		}

		static IntPtr id_splitFile_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.bioinformatics']/class[@name='SplitFasta']/method[@name='splitFile' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("splitFile", "(Ljava/lang/String;)V", "")]
		public static unsafe void SplitFile (string p0)
		{
			if (id_splitFile_Ljava_lang_String_ == IntPtr.Zero)
				id_splitFile_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "splitFile", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_splitFile_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
