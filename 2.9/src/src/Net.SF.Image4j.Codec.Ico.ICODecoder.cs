using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Net.SF.Image4j.Codec.Ico {

	// Metadata.xml XPath class reference: path="/api/package[@name='net.sf.image4j.codec.ico']/class[@name='ICODecoder']"
	[global::Android.Runtime.Register ("net/sf/image4j/codec/ico/ICODecoder", DoNotGenerateAcw=true)]
	public partial class ICODecoder : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("net/sf/image4j/codec/ico/ICODecoder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ICODecoder); }
		}

		protected ICODecoder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_readExt_Ljava_io_File_;
		// Metadata.xml XPath method reference: path="/api/package[@name='net.sf.image4j.codec.ico']/class[@name='ICODecoder']/method[@name='readExt' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("readExt", "(Ljava/io/File;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::Net.SF.Image4j.Codec.Ico.ICOImage> ReadExt (global::Java.IO.File p0)
		{
			if (id_readExt_Ljava_io_File_ == IntPtr.Zero)
				id_readExt_Ljava_io_File_ = JNIEnv.GetStaticMethodID (class_ref, "readExt", "(Ljava/io/File;)Ljava/util/List;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::System.Collections.Generic.IList<global::Net.SF.Image4j.Codec.Ico.ICOImage> __ret = global::Android.Runtime.JavaList<global::Net.SF.Image4j.Codec.Ico.ICOImage>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_readExt_Ljava_io_File_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_readExt_Ljava_io_InputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='net.sf.image4j.codec.ico']/class[@name='ICODecoder']/method[@name='readExt' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("readExt", "(Ljava/io/InputStream;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::Net.SF.Image4j.Codec.Ico.ICOImage> ReadExt (global::System.IO.Stream p0)
		{
			if (id_readExt_Ljava_io_InputStream_ == IntPtr.Zero)
				id_readExt_Ljava_io_InputStream_ = JNIEnv.GetStaticMethodID (class_ref, "readExt", "(Ljava/io/InputStream;)Ljava/util/List;");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::System.Collections.Generic.IList<global::Net.SF.Image4j.Codec.Ico.ICOImage> __ret = global::Android.Runtime.JavaList<global::Net.SF.Image4j.Codec.Ico.ICOImage>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_readExt_Ljava_io_InputStream_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
