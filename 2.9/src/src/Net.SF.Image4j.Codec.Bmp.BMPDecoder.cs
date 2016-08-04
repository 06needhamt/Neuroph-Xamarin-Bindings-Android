using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Net.SF.Image4j.Codec.Bmp {

	// Metadata.xml XPath class reference: path="/api/package[@name='net.sf.image4j.codec.bmp']/class[@name='BMPDecoder']"
	[global::Android.Runtime.Register ("net/sf/image4j/codec/bmp/BMPDecoder", DoNotGenerateAcw=true)]
	public partial class BMPDecoder : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("net/sf/image4j/codec/bmp/BMPDecoder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BMPDecoder); }
		}

		protected BMPDecoder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_io_InputStream_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='net.sf.image4j.codec.bmp']/class[@name='BMPDecoder']/constructor[@name='BMPDecoder' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register (".ctor", "(Ljava/io/InputStream;)V", "")]
		public unsafe BMPDecoder (global::System.IO.Stream p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (BMPDecoder)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/io/InputStream;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/io/InputStream;)V", __args);
					return;
				}

				if (id_ctor_Ljava_io_InputStream_ == IntPtr.Zero)
					id_ctor_Ljava_io_InputStream_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/io/InputStream;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_io_InputStream_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_io_InputStream_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getInfoHeader;
#pragma warning disable 0169
		static Delegate GetGetInfoHeaderHandler ()
		{
			if (cb_getInfoHeader == null)
				cb_getInfoHeader = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetInfoHeader);
			return cb_getInfoHeader;
		}

		static IntPtr n_GetInfoHeader (IntPtr jnienv, IntPtr native__this)
		{
			global::Net.SF.Image4j.Codec.Bmp.BMPDecoder __this = global::Java.Lang.Object.GetObject<global::Net.SF.Image4j.Codec.Bmp.BMPDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InfoHeader);
		}
#pragma warning restore 0169

		static IntPtr id_getInfoHeader;
		public virtual unsafe global::Net.SF.Image4j.Codec.Bmp.InfoHeader InfoHeader {
			// Metadata.xml XPath method reference: path="/api/package[@name='net.sf.image4j.codec.bmp']/class[@name='BMPDecoder']/method[@name='getInfoHeader' and count(parameter)=0]"
			[Register ("getInfoHeader", "()Lnet/sf/image4j/codec/bmp/InfoHeader;", "GetGetInfoHeaderHandler")]
			get {
				if (id_getInfoHeader == IntPtr.Zero)
					id_getInfoHeader = JNIEnv.GetMethodID (class_ref, "getInfoHeader", "()Lnet/sf/image4j/codec/bmp/InfoHeader;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Net.SF.Image4j.Codec.Bmp.InfoHeader> (JNIEnv.CallObjectMethod  (Handle, id_getInfoHeader), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Net.SF.Image4j.Codec.Bmp.InfoHeader> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getInfoHeader", "()Lnet/sf/image4j/codec/bmp/InfoHeader;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_readColorTable_Lnet_sf_image4j_codec_bmp_InfoHeader_Lnet_sf_image4j_io_LittleEndianInputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='net.sf.image4j.codec.bmp']/class[@name='BMPDecoder']/method[@name='readColorTable' and count(parameter)=2 and parameter[1][@type='net.sf.image4j.codec.bmp.InfoHeader'] and parameter[2][@type='net.sf.image4j.io.LittleEndianInputStream']]"
		[Register ("readColorTable", "(Lnet/sf/image4j/codec/bmp/InfoHeader;Lnet/sf/image4j/io/LittleEndianInputStream;)[Lnet/sf/image4j/codec/bmp/ColorEntry;", "")]
		public static unsafe global::Net.SF.Image4j.Codec.Bmp.ColorEntry[] ReadColorTable (global::Net.SF.Image4j.Codec.Bmp.InfoHeader p0, global::Net.SF.Image4j.IO.LittleEndianInputStream p1)
		{
			if (id_readColorTable_Lnet_sf_image4j_codec_bmp_InfoHeader_Lnet_sf_image4j_io_LittleEndianInputStream_ == IntPtr.Zero)
				id_readColorTable_Lnet_sf_image4j_codec_bmp_InfoHeader_Lnet_sf_image4j_io_LittleEndianInputStream_ = JNIEnv.GetStaticMethodID (class_ref, "readColorTable", "(Lnet/sf/image4j/codec/bmp/InfoHeader;Lnet/sf/image4j/io/LittleEndianInputStream;)[Lnet/sf/image4j/codec/bmp/ColorEntry;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Net.SF.Image4j.Codec.Bmp.ColorEntry[] __ret = (global::Net.SF.Image4j.Codec.Bmp.ColorEntry[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_readColorTable_Lnet_sf_image4j_codec_bmp_InfoHeader_Lnet_sf_image4j_io_LittleEndianInputStream_, __args), JniHandleOwnership.TransferLocalRef, typeof (global::Net.SF.Image4j.Codec.Bmp.ColorEntry));
				return __ret;
			} finally {
			}
		}

		static IntPtr id_readExt_Ljava_io_File_;
		// Metadata.xml XPath method reference: path="/api/package[@name='net.sf.image4j.codec.bmp']/class[@name='BMPDecoder']/method[@name='readExt' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("readExt", "(Ljava/io/File;)Lnet/sf/image4j/codec/bmp/BMPImage;", "")]
		public static unsafe global::Net.SF.Image4j.Codec.Bmp.BMPImage ReadExt (global::Java.IO.File p0)
		{
			if (id_readExt_Ljava_io_File_ == IntPtr.Zero)
				id_readExt_Ljava_io_File_ = JNIEnv.GetStaticMethodID (class_ref, "readExt", "(Ljava/io/File;)Lnet/sf/image4j/codec/bmp/BMPImage;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Net.SF.Image4j.Codec.Bmp.BMPImage __ret = global::Java.Lang.Object.GetObject<global::Net.SF.Image4j.Codec.Bmp.BMPImage> (JNIEnv.CallStaticObjectMethod  (class_ref, id_readExt_Ljava_io_File_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_readExt_Ljava_io_InputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='net.sf.image4j.codec.bmp']/class[@name='BMPDecoder']/method[@name='readExt' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("readExt", "(Ljava/io/InputStream;)Lnet/sf/image4j/codec/bmp/BMPImage;", "")]
		public static unsafe global::Net.SF.Image4j.Codec.Bmp.BMPImage ReadExt (global::System.IO.Stream p0)
		{
			if (id_readExt_Ljava_io_InputStream_ == IntPtr.Zero)
				id_readExt_Ljava_io_InputStream_ = JNIEnv.GetStaticMethodID (class_ref, "readExt", "(Ljava/io/InputStream;)Lnet/sf/image4j/codec/bmp/BMPImage;");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Net.SF.Image4j.Codec.Bmp.BMPImage __ret = global::Java.Lang.Object.GetObject<global::Net.SF.Image4j.Codec.Bmp.BMPImage> (JNIEnv.CallStaticObjectMethod  (class_ref, id_readExt_Ljava_io_InputStream_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_readInfoHeader_Lnet_sf_image4j_io_LittleEndianInputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='net.sf.image4j.codec.bmp']/class[@name='BMPDecoder']/method[@name='readInfoHeader' and count(parameter)=1 and parameter[1][@type='net.sf.image4j.io.LittleEndianInputStream']]"
		[Register ("readInfoHeader", "(Lnet/sf/image4j/io/LittleEndianInputStream;)Lnet/sf/image4j/codec/bmp/InfoHeader;", "")]
		public static unsafe global::Net.SF.Image4j.Codec.Bmp.InfoHeader ReadInfoHeader (global::Net.SF.Image4j.IO.LittleEndianInputStream p0)
		{
			if (id_readInfoHeader_Lnet_sf_image4j_io_LittleEndianInputStream_ == IntPtr.Zero)
				id_readInfoHeader_Lnet_sf_image4j_io_LittleEndianInputStream_ = JNIEnv.GetStaticMethodID (class_ref, "readInfoHeader", "(Lnet/sf/image4j/io/LittleEndianInputStream;)Lnet/sf/image4j/codec/bmp/InfoHeader;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Net.SF.Image4j.Codec.Bmp.InfoHeader __ret = global::Java.Lang.Object.GetObject<global::Net.SF.Image4j.Codec.Bmp.InfoHeader> (JNIEnv.CallStaticObjectMethod  (class_ref, id_readInfoHeader_Lnet_sf_image4j_io_LittleEndianInputStream_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_readInfoHeader_Lnet_sf_image4j_io_LittleEndianInputStream_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='net.sf.image4j.codec.bmp']/class[@name='BMPDecoder']/method[@name='readInfoHeader' and count(parameter)=2 and parameter[1][@type='net.sf.image4j.io.LittleEndianInputStream'] and parameter[2][@type='int']]"
		[Register ("readInfoHeader", "(Lnet/sf/image4j/io/LittleEndianInputStream;I)Lnet/sf/image4j/codec/bmp/InfoHeader;", "")]
		public static unsafe global::Net.SF.Image4j.Codec.Bmp.InfoHeader ReadInfoHeader (global::Net.SF.Image4j.IO.LittleEndianInputStream p0, int p1)
		{
			if (id_readInfoHeader_Lnet_sf_image4j_io_LittleEndianInputStream_I == IntPtr.Zero)
				id_readInfoHeader_Lnet_sf_image4j_io_LittleEndianInputStream_I = JNIEnv.GetStaticMethodID (class_ref, "readInfoHeader", "(Lnet/sf/image4j/io/LittleEndianInputStream;I)Lnet/sf/image4j/codec/bmp/InfoHeader;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Net.SF.Image4j.Codec.Bmp.InfoHeader __ret = global::Java.Lang.Object.GetObject<global::Net.SF.Image4j.Codec.Bmp.InfoHeader> (JNIEnv.CallStaticObjectMethod  (class_ref, id_readInfoHeader_Lnet_sf_image4j_io_LittleEndianInputStream_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
