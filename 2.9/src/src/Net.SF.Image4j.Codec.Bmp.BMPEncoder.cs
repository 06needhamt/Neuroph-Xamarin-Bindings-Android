using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Net.SF.Image4j.Codec.Bmp {

	// Metadata.xml XPath class reference: path="/api/package[@name='net.sf.image4j.codec.bmp']/class[@name='BMPEncoder']"
	[global::Android.Runtime.Register ("net/sf/image4j/codec/bmp/BMPEncoder", DoNotGenerateAcw=true)]
	public partial class BMPEncoder : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("net/sf/image4j/codec/bmp/BMPEncoder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BMPEncoder); }
		}

		protected BMPEncoder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getBitmapSize_III;
		// Metadata.xml XPath method reference: path="/api/package[@name='net.sf.image4j.codec.bmp']/class[@name='BMPEncoder']/method[@name='getBitmapSize' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("getBitmapSize", "(III)I", "")]
		public static unsafe int GetBitmapSize (int p0, int p1, int p2)
		{
			if (id_getBitmapSize_III == IntPtr.Zero)
				id_getBitmapSize_III = JNIEnv.GetStaticMethodID (class_ref, "getBitmapSize", "(III)I");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_getBitmapSize_III, __args);
			} finally {
			}
		}

		static IntPtr id_getBytesPerLine1_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='net.sf.image4j.codec.bmp']/class[@name='BMPEncoder']/method[@name='getBytesPerLine1' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getBytesPerLine1", "(I)I", "")]
		public static unsafe int GetBytesPerLine1 (int p0)
		{
			if (id_getBytesPerLine1_I == IntPtr.Zero)
				id_getBytesPerLine1_I = JNIEnv.GetStaticMethodID (class_ref, "getBytesPerLine1", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_getBytesPerLine1_I, __args);
			} finally {
			}
		}

		static IntPtr id_getBytesPerLine24_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='net.sf.image4j.codec.bmp']/class[@name='BMPEncoder']/method[@name='getBytesPerLine24' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getBytesPerLine24", "(I)I", "")]
		public static unsafe int GetBytesPerLine24 (int p0)
		{
			if (id_getBytesPerLine24_I == IntPtr.Zero)
				id_getBytesPerLine24_I = JNIEnv.GetStaticMethodID (class_ref, "getBytesPerLine24", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_getBytesPerLine24_I, __args);
			} finally {
			}
		}

		static IntPtr id_getBytesPerLine4_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='net.sf.image4j.codec.bmp']/class[@name='BMPEncoder']/method[@name='getBytesPerLine4' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getBytesPerLine4", "(I)I", "")]
		public static unsafe int GetBytesPerLine4 (int p0)
		{
			if (id_getBytesPerLine4_I == IntPtr.Zero)
				id_getBytesPerLine4_I = JNIEnv.GetStaticMethodID (class_ref, "getBytesPerLine4", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_getBytesPerLine4_I, __args);
			} finally {
			}
		}

		static IntPtr id_getBytesPerLine8_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='net.sf.image4j.codec.bmp']/class[@name='BMPEncoder']/method[@name='getBytesPerLine8' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getBytesPerLine8", "(I)I", "")]
		public static unsafe int GetBytesPerLine8 (int p0)
		{
			if (id_getBytesPerLine8_I == IntPtr.Zero)
				id_getBytesPerLine8_I = JNIEnv.GetStaticMethodID (class_ref, "getBytesPerLine8", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_getBytesPerLine8_I, __args);
			} finally {
			}
		}

		static IntPtr id_getColorMapSize_S;
		// Metadata.xml XPath method reference: path="/api/package[@name='net.sf.image4j.codec.bmp']/class[@name='BMPEncoder']/method[@name='getColorMapSize' and count(parameter)=1 and parameter[1][@type='short']]"
		[Register ("getColorMapSize", "(S)I", "")]
		public static unsafe int GetColorMapSize (short p0)
		{
			if (id_getColorMapSize_S == IntPtr.Zero)
				id_getColorMapSize_S = JNIEnv.GetStaticMethodID (class_ref, "getColorMapSize", "(S)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_getColorMapSize_S, __args);
			} finally {
			}
		}

		static IntPtr id_writeFileHeader_IILnet_sf_image4j_io_LittleEndianOutputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='net.sf.image4j.codec.bmp']/class[@name='BMPEncoder']/method[@name='writeFileHeader' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='net.sf.image4j.io.LittleEndianOutputStream']]"
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
