using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Net.SF.Image4j.Codec.Bmp {

	// Metadata.xml XPath class reference: path="/api/package[@name='net.sf.image4j.codec.bmp']/class[@name='BMPConstants']"
	[global::Android.Runtime.Register ("net/sf/image4j/codec/bmp/BMPConstants", DoNotGenerateAcw=true)]
	public partial class BMPConstants : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='net.sf.image4j.codec.bmp']/class[@name='BMPConstants']/field[@name='BI_RGB']"
		[Register ("BI_RGB")]
		public const int BiRgb = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='net.sf.image4j.codec.bmp']/class[@name='BMPConstants']/field[@name='BI_RLE4']"
		[Register ("BI_RLE4")]
		public const int BiRle4 = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='net.sf.image4j.codec.bmp']/class[@name='BMPConstants']/field[@name='BI_RLE8']"
		[Register ("BI_RLE8")]
		public const int BiRle8 = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='net.sf.image4j.codec.bmp']/class[@name='BMPConstants']/field[@name='FILE_HEADER']"
		[Register ("FILE_HEADER")]
		public const string FileHeader = (string) "BM";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("net/sf/image4j/codec/bmp/BMPConstants", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BMPConstants); }
		}

		protected BMPConstants (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
