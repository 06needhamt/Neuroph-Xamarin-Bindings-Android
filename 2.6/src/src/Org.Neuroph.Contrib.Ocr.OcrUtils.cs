using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Contrib.Ocr {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.contrib.ocr']/class[@name='OcrUtils']"
	[global::Android.Runtime.Register ("org/neuroph/contrib/ocr/OcrUtils", DoNotGenerateAcw=true)]
	public partial class OcrUtils : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/contrib/ocr/OcrUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (OcrUtils); }
		}

		protected OcrUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.contrib.ocr']/class[@name='OcrUtils']/constructor[@name='OcrUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe OcrUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (OcrUtils)) {
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

		static IntPtr id_blackAndGrayCleaning_Lorg_neuroph_contrib_imgrec_image_Image_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.contrib.ocr']/class[@name='OcrUtils']/method[@name='blackAndGrayCleaning' and count(parameter)=1 and parameter[1][@type='org.neuroph.contrib.imgrec.image.Image']]"
		[Register ("blackAndGrayCleaning", "(Lorg/neuroph/contrib/imgrec/image/Image;)Lorg/neuroph/contrib/imgrec/image/Image;", "")]
		public static unsafe global::Org.Neuroph.Contrib.Imgrec.Image.IImage BlackAndGrayCleaning (global::Org.Neuroph.Contrib.Imgrec.Image.IImage p0)
		{
			if (id_blackAndGrayCleaning_Lorg_neuroph_contrib_imgrec_image_Image_ == IntPtr.Zero)
				id_blackAndGrayCleaning_Lorg_neuroph_contrib_imgrec_image_Image_ = JNIEnv.GetStaticMethodID (class_ref, "blackAndGrayCleaning", "(Lorg/neuroph/contrib/imgrec/image/Image;)Lorg/neuroph/contrib/imgrec/image/Image;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Org.Neuroph.Contrib.Imgrec.Image.IImage __ret = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.Imgrec.Image.IImage> (JNIEnv.CallStaticObjectMethod  (class_ref, id_blackAndGrayCleaning_Lorg_neuroph_contrib_imgrec_image_Image_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_blackAndLightGrayCleaning_Lorg_neuroph_contrib_imgrec_image_Image_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.contrib.ocr']/class[@name='OcrUtils']/method[@name='blackAndLightGrayCleaning' and count(parameter)=1 and parameter[1][@type='org.neuroph.contrib.imgrec.image.Image']]"
		[Register ("blackAndLightGrayCleaning", "(Lorg/neuroph/contrib/imgrec/image/Image;)Lorg/neuroph/contrib/imgrec/image/Image;", "")]
		public static unsafe global::Org.Neuroph.Contrib.Imgrec.Image.IImage BlackAndLightGrayCleaning (global::Org.Neuroph.Contrib.Imgrec.Image.IImage p0)
		{
			if (id_blackAndLightGrayCleaning_Lorg_neuroph_contrib_imgrec_image_Image_ == IntPtr.Zero)
				id_blackAndLightGrayCleaning_Lorg_neuroph_contrib_imgrec_image_Image_ = JNIEnv.GetStaticMethodID (class_ref, "blackAndLightGrayCleaning", "(Lorg/neuroph/contrib/imgrec/image/Image;)Lorg/neuroph/contrib/imgrec/image/Image;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Org.Neuroph.Contrib.Imgrec.Image.IImage __ret = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.Imgrec.Image.IImage> (JNIEnv.CallStaticObjectMethod  (class_ref, id_blackAndLightGrayCleaning_Lorg_neuroph_contrib_imgrec_image_Image_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_blackAndWhiteCleaning_Lorg_neuroph_contrib_imgrec_image_Image_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.contrib.ocr']/class[@name='OcrUtils']/method[@name='blackAndWhiteCleaning' and count(parameter)=1 and parameter[1][@type='org.neuroph.contrib.imgrec.image.Image']]"
		[Register ("blackAndWhiteCleaning", "(Lorg/neuroph/contrib/imgrec/image/Image;)Lorg/neuroph/contrib/imgrec/image/Image;", "")]
		public static unsafe global::Org.Neuroph.Contrib.Imgrec.Image.IImage BlackAndWhiteCleaning (global::Org.Neuroph.Contrib.Imgrec.Image.IImage p0)
		{
			if (id_blackAndWhiteCleaning_Lorg_neuroph_contrib_imgrec_image_Image_ == IntPtr.Zero)
				id_blackAndWhiteCleaning_Lorg_neuroph_contrib_imgrec_image_Image_ = JNIEnv.GetStaticMethodID (class_ref, "blackAndWhiteCleaning", "(Lorg/neuroph/contrib/imgrec/image/Image;)Lorg/neuroph/contrib/imgrec/image/Image;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Org.Neuroph.Contrib.Imgrec.Image.IImage __ret = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.Imgrec.Image.IImage> (JNIEnv.CallStaticObjectMethod  (class_ref, id_blackAndWhiteCleaning_Lorg_neuroph_contrib_imgrec_image_Image_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_colorCleaning_Lorg_neuroph_contrib_imgrec_image_Image_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.contrib.ocr']/class[@name='OcrUtils']/method[@name='colorCleaning' and count(parameter)=2 and parameter[1][@type='org.neuroph.contrib.imgrec.image.Image'] and parameter[2][@type='int']]"
		[Register ("colorCleaning", "(Lorg/neuroph/contrib/imgrec/image/Image;I)Lorg/neuroph/contrib/imgrec/image/Image;", "")]
		public static unsafe global::Org.Neuroph.Contrib.Imgrec.Image.IImage ColorCleaning (global::Org.Neuroph.Contrib.Imgrec.Image.IImage p0, int p1)
		{
			if (id_colorCleaning_Lorg_neuroph_contrib_imgrec_image_Image_I == IntPtr.Zero)
				id_colorCleaning_Lorg_neuroph_contrib_imgrec_image_Image_I = JNIEnv.GetStaticMethodID (class_ref, "colorCleaning", "(Lorg/neuroph/contrib/imgrec/image/Image;I)Lorg/neuroph/contrib/imgrec/image/Image;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Org.Neuroph.Contrib.Imgrec.Image.IImage __ret = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.Imgrec.Image.IImage> (JNIEnv.CallStaticObjectMethod  (class_ref, id_colorCleaning_Lorg_neuroph_contrib_imgrec_image_Image_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_cropImage_Lorg_neuroph_contrib_imgrec_image_Image_IIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.contrib.ocr']/class[@name='OcrUtils']/method[@name='cropImage' and count(parameter)=5 and parameter[1][@type='org.neuroph.contrib.imgrec.image.Image'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("cropImage", "(Lorg/neuroph/contrib/imgrec/image/Image;IIII)Lorg/neuroph/contrib/imgrec/image/Image;", "")]
		public static unsafe global::Org.Neuroph.Contrib.Imgrec.Image.IImage CropImage (global::Org.Neuroph.Contrib.Imgrec.Image.IImage p0, int p1, int p2, int p3, int p4)
		{
			if (id_cropImage_Lorg_neuroph_contrib_imgrec_image_Image_IIII == IntPtr.Zero)
				id_cropImage_Lorg_neuroph_contrib_imgrec_image_Image_IIII = JNIEnv.GetStaticMethodID (class_ref, "cropImage", "(Lorg/neuroph/contrib/imgrec/image/Image;IIII)Lorg/neuroph/contrib/imgrec/image/Image;");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				global::Org.Neuroph.Contrib.Imgrec.Image.IImage __ret = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.Imgrec.Image.IImage> (JNIEnv.CallStaticObjectMethod  (class_ref, id_cropImage_Lorg_neuroph_contrib_imgrec_image_Image_IIII, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getFractionRgbDataForImages_Ljava_util_HashMap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.contrib.ocr']/class[@name='OcrUtils']/method[@name='getFractionRgbDataForImages' and count(parameter)=1 and parameter[1][@type='java.util.HashMap&lt;java.lang.String, org.neuroph.contrib.imgrec.image.Image&gt;']]"
		[Register ("getFractionRgbDataForImages", "(Ljava/util/HashMap;)Ljava/util/Map;", "")]
		public static unsafe global::System.Collections.Generic.IDictionary<string, global::Org.Neuroph.Contrib.Imgrec.FractionRgbData> GetFractionRgbDataForImages (global::System.Collections.Generic.IDictionary<string, global::Org.Neuroph.Contrib.Imgrec.Image.IImage> p0)
		{
			if (id_getFractionRgbDataForImages_Ljava_util_HashMap_ == IntPtr.Zero)
				id_getFractionRgbDataForImages_Ljava_util_HashMap_ = JNIEnv.GetStaticMethodID (class_ref, "getFractionRgbDataForImages", "(Ljava/util/HashMap;)Ljava/util/Map;");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Org.Neuroph.Contrib.Imgrec.Image.IImage>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::System.Collections.Generic.IDictionary<string, global::Org.Neuroph.Contrib.Imgrec.FractionRgbData> __ret = global::Android.Runtime.JavaDictionary<string, global::Org.Neuroph.Contrib.Imgrec.FractionRgbData>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_getFractionRgbDataForImages_Ljava_util_HashMap_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_loadAndCleanImage_Ljava_io_File_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.contrib.ocr']/class[@name='OcrUtils']/method[@name='loadAndCleanImage' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("loadAndCleanImage", "(Ljava/io/File;)Lorg/neuroph/contrib/imgrec/image/Image;", "")]
		public static unsafe global::Org.Neuroph.Contrib.Imgrec.Image.IImage LoadAndCleanImage (global::Java.IO.File p0)
		{
			if (id_loadAndCleanImage_Ljava_io_File_ == IntPtr.Zero)
				id_loadAndCleanImage_Ljava_io_File_ = JNIEnv.GetStaticMethodID (class_ref, "loadAndCleanImage", "(Ljava/io/File;)Lorg/neuroph/contrib/imgrec/image/Image;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Org.Neuroph.Contrib.Imgrec.Image.IImage __ret = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.Imgrec.Image.IImage> (JNIEnv.CallStaticObjectMethod  (class_ref, id_loadAndCleanImage_Ljava_io_File_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_loadImage_Ljava_io_File_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.contrib.ocr']/class[@name='OcrUtils']/method[@name='loadImage' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("loadImage", "(Ljava/io/File;)Lorg/neuroph/contrib/imgrec/image/Image;", "")]
		public static unsafe global::Org.Neuroph.Contrib.Imgrec.Image.IImage LoadImage (global::Java.IO.File p0)
		{
			if (id_loadImage_Ljava_io_File_ == IntPtr.Zero)
				id_loadImage_Ljava_io_File_ = JNIEnv.GetStaticMethodID (class_ref, "loadImage", "(Ljava/io/File;)Lorg/neuroph/contrib/imgrec/image/Image;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Org.Neuroph.Contrib.Imgrec.Image.IImage __ret = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.Imgrec.Image.IImage> (JNIEnv.CallStaticObjectMethod  (class_ref, id_loadImage_Ljava_io_File_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_resizeImage_Lorg_neuroph_contrib_imgrec_image_Image_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.contrib.ocr']/class[@name='OcrUtils']/method[@name='resizeImage' and count(parameter)=3 and parameter[1][@type='org.neuroph.contrib.imgrec.image.Image'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("resizeImage", "(Lorg/neuroph/contrib/imgrec/image/Image;II)Lorg/neuroph/contrib/imgrec/image/Image;", "")]
		public static unsafe global::Org.Neuroph.Contrib.Imgrec.Image.IImage ResizeImage (global::Org.Neuroph.Contrib.Imgrec.Image.IImage p0, int p1, int p2)
		{
			if (id_resizeImage_Lorg_neuroph_contrib_imgrec_image_Image_II == IntPtr.Zero)
				id_resizeImage_Lorg_neuroph_contrib_imgrec_image_Image_II = JNIEnv.GetStaticMethodID (class_ref, "resizeImage", "(Lorg/neuroph/contrib/imgrec/image/Image;II)Lorg/neuroph/contrib/imgrec/image/Image;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				global::Org.Neuroph.Contrib.Imgrec.Image.IImage __ret = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.Imgrec.Image.IImage> (JNIEnv.CallStaticObjectMethod  (class_ref, id_resizeImage_Lorg_neuroph_contrib_imgrec_image_Image_II, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_trimImage_Lorg_neuroph_contrib_imgrec_image_Image_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.contrib.ocr']/class[@name='OcrUtils']/method[@name='trimImage' and count(parameter)=1 and parameter[1][@type='org.neuroph.contrib.imgrec.image.Image']]"
		[Register ("trimImage", "(Lorg/neuroph/contrib/imgrec/image/Image;)Lorg/neuroph/contrib/imgrec/image/Image;", "")]
		public static unsafe global::Org.Neuroph.Contrib.Imgrec.Image.IImage TrimImage (global::Org.Neuroph.Contrib.Imgrec.Image.IImage p0)
		{
			if (id_trimImage_Lorg_neuroph_contrib_imgrec_image_Image_ == IntPtr.Zero)
				id_trimImage_Lorg_neuroph_contrib_imgrec_image_Image_ = JNIEnv.GetStaticMethodID (class_ref, "trimImage", "(Lorg/neuroph/contrib/imgrec/image/Image;)Lorg/neuroph/contrib/imgrec/image/Image;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Org.Neuroph.Contrib.Imgrec.Image.IImage __ret = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.Imgrec.Image.IImage> (JNIEnv.CallStaticObjectMethod  (class_ref, id_trimImage_Lorg_neuroph_contrib_imgrec_image_Image_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
