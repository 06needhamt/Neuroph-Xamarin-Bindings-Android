using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Imgrec.Image {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.imgrec.image']/class[@name='ImageFactory']"
	[global::Android.Runtime.Register ("org/neuroph/imgrec/image/ImageFactory", DoNotGenerateAcw=true)]
	public partial class ImageFactory : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/imgrec/image/ImageFactory", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ImageFactory); }
		}

		protected ImageFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.imgrec.image']/class[@name='ImageFactory']/constructor[@name='ImageFactory' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ImageFactory ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ImageFactory)) {
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

		static IntPtr id_createImage_Ljava_lang_Integer_Ljava_lang_Integer_Ljava_lang_Integer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.imgrec.image']/class[@name='ImageFactory']/method[@name='createImage' and count(parameter)=3 and parameter[1][@type='java.lang.Integer'] and parameter[2][@type='java.lang.Integer'] and parameter[3][@type='java.lang.Integer']]"
		[Register ("createImage", "(Ljava/lang/Integer;Ljava/lang/Integer;Ljava/lang/Integer;)Lorg/neuroph/imgrec/image/Image;", "")]
		public static unsafe global::Org.Neuroph.Imgrec.Image.IImage CreateImage (global::Java.Lang.Integer p0, global::Java.Lang.Integer p1, global::Java.Lang.Integer p2)
		{
			if (id_createImage_Ljava_lang_Integer_Ljava_lang_Integer_Ljava_lang_Integer_ == IntPtr.Zero)
				id_createImage_Ljava_lang_Integer_Ljava_lang_Integer_Ljava_lang_Integer_ = JNIEnv.GetStaticMethodID (class_ref, "createImage", "(Ljava/lang/Integer;Ljava/lang/Integer;Ljava/lang/Integer;)Lorg/neuroph/imgrec/image/Image;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				global::Org.Neuroph.Imgrec.Image.IImage __ret = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Imgrec.Image.IImage> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createImage_Ljava_lang_Integer_Ljava_lang_Integer_Ljava_lang_Integer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getImage_Ljava_io_File_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.imgrec.image']/class[@name='ImageFactory']/method[@name='getImage' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("getImage", "(Ljava/io/File;)Lorg/neuroph/imgrec/image/Image;", "")]
		public static unsafe global::Org.Neuroph.Imgrec.Image.IImage GetImage (global::Java.IO.File p0)
		{
			if (id_getImage_Ljava_io_File_ == IntPtr.Zero)
				id_getImage_Ljava_io_File_ = JNIEnv.GetStaticMethodID (class_ref, "getImage", "(Ljava/io/File;)Lorg/neuroph/imgrec/image/Image;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Org.Neuroph.Imgrec.Image.IImage __ret = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Imgrec.Image.IImage> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getImage_Ljava_io_File_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getImage_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.imgrec.image']/class[@name='ImageFactory']/method[@name='getImage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getImage", "(Ljava/lang/String;)Lorg/neuroph/imgrec/image/Image;", "")]
		public static unsafe global::Org.Neuroph.Imgrec.Image.IImage GetImage (string p0)
		{
			if (id_getImage_Ljava_lang_String_ == IntPtr.Zero)
				id_getImage_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getImage", "(Ljava/lang/String;)Lorg/neuroph/imgrec/image/Image;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Org.Neuroph.Imgrec.Image.IImage __ret = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Imgrec.Image.IImage> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getImage_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_getImage_Ljava_net_URL_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.imgrec.image']/class[@name='ImageFactory']/method[@name='getImage' and count(parameter)=1 and parameter[1][@type='java.net.URL']]"
		[Register ("getImage", "(Ljava/net/URL;)Lorg/neuroph/imgrec/image/Image;", "")]
		public static unsafe global::Org.Neuroph.Imgrec.Image.IImage GetImage (global::Java.Net.URL p0)
		{
			if (id_getImage_Ljava_net_URL_ == IntPtr.Zero)
				id_getImage_Ljava_net_URL_ = JNIEnv.GetStaticMethodID (class_ref, "getImage", "(Ljava/net/URL;)Lorg/neuroph/imgrec/image/Image;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Org.Neuroph.Imgrec.Image.IImage __ret = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Imgrec.Image.IImage> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getImage_Ljava_net_URL_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
