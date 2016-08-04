using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Net.SF.Image4j.Codec.Ico {

	// Metadata.xml XPath class reference: path="/api/package[@name='net.sf.image4j.codec.ico']/class[@name='ICOEncoder']"
	[global::Android.Runtime.Register ("net/sf/image4j/codec/ico/ICOEncoder", DoNotGenerateAcw=true)]
	public partial class ICOEncoder : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("net/sf/image4j/codec/ico/ICOEncoder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ICOEncoder); }
		}

		protected ICOEncoder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_createIconEntry_Lnet_sf_image4j_codec_bmp_InfoHeader_;
		// Metadata.xml XPath method reference: path="/api/package[@name='net.sf.image4j.codec.ico']/class[@name='ICOEncoder']/method[@name='createIconEntry' and count(parameter)=1 and parameter[1][@type='net.sf.image4j.codec.bmp.InfoHeader']]"
		[Register ("createIconEntry", "(Lnet/sf/image4j/codec/bmp/InfoHeader;)Lnet/sf/image4j/codec/ico/IconEntry;", "")]
		public static unsafe global::Net.SF.Image4j.Codec.Ico.IconEntry CreateIconEntry (global::Net.SF.Image4j.Codec.Bmp.InfoHeader p0)
		{
			if (id_createIconEntry_Lnet_sf_image4j_codec_bmp_InfoHeader_ == IntPtr.Zero)
				id_createIconEntry_Lnet_sf_image4j_codec_bmp_InfoHeader_ = JNIEnv.GetStaticMethodID (class_ref, "createIconEntry", "(Lnet/sf/image4j/codec/bmp/InfoHeader;)Lnet/sf/image4j/codec/ico/IconEntry;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Net.SF.Image4j.Codec.Ico.IconEntry __ret = global::Java.Lang.Object.GetObject<global::Net.SF.Image4j.Codec.Ico.IconEntry> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createIconEntry_Lnet_sf_image4j_codec_bmp_InfoHeader_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_writeFileHeader_IILnet_sf_image4j_io_LittleEndianOutputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='net.sf.image4j.codec.ico']/class[@name='ICOEncoder']/method[@name='writeFileHeader' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='net.sf.image4j.io.LittleEndianOutputStream']]"
		[Register ("writeFileHeader", "(IILnet/sf/image4j/io/LittleEndianOutputStream;)V", "")]
		public static unsafe void WriteFileHeader (int p0, int p1, global::Net.SF.Image4j.IO.LittleEndianOutputStream p2)
		{
			if (id_writeFileHeader_IILnet_sf_image4j_io_LittleEndianOutputStream_ == IntPtr.Zero)
				id_writeFileHeader_IILnet_sf_image4j_io_LittleEndianOutputStream_ = JNIEnv.GetStaticMethodID (class_ref, "writeFileHeader", "(IILnet/sf/image4j/io/LittleEndianOutputStream;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_writeFileHeader_IILnet_sf_image4j_io_LittleEndianOutputStream_, __args);
			} finally {
			}
		}

	}
}
