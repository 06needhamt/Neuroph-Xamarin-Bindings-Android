using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Imgrec {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.imgrec']/class[@name='ImageSampler']"
	[global::Android.Runtime.Register ("org/neuroph/imgrec/ImageSampler", DoNotGenerateAcw=true)]
	public partial class ImageSampler : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/imgrec/ImageSampler", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ImageSampler); }
		}

		protected ImageSampler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.imgrec']/class[@name='ImageSampler']/constructor[@name='ImageSampler' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ImageSampler ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ImageSampler)) {
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

		static IntPtr id_downSampleImage_Lorg_neuroph_imgrec_image_Dimension_Lorg_neuroph_imgrec_image_Image_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.imgrec']/class[@name='ImageSampler']/method[@name='downSampleImage' and count(parameter)=2 and parameter[1][@type='org.neuroph.imgrec.image.Dimension'] and parameter[2][@type='org.neuroph.imgrec.image.Image']]"
		[Register ("downSampleImage", "(Lorg/neuroph/imgrec/image/Dimension;Lorg/neuroph/imgrec/image/Image;)Lorg/neuroph/imgrec/image/Image;", "")]
		public static unsafe global::Org.Neuroph.Imgrec.Image.IImage DownSampleImage (global::Org.Neuroph.Imgrec.Image.Dimension p0, global::Org.Neuroph.Imgrec.Image.IImage p1)
		{
			if (id_downSampleImage_Lorg_neuroph_imgrec_image_Dimension_Lorg_neuroph_imgrec_image_Image_ == IntPtr.Zero)
				id_downSampleImage_Lorg_neuroph_imgrec_image_Dimension_Lorg_neuroph_imgrec_image_Image_ = JNIEnv.GetStaticMethodID (class_ref, "downSampleImage", "(Lorg/neuroph/imgrec/image/Dimension;Lorg/neuroph/imgrec/image/Image;)Lorg/neuroph/imgrec/image/Image;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Org.Neuroph.Imgrec.Image.IImage __ret = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Imgrec.Image.IImage> (JNIEnv.CallStaticObjectMethod  (class_ref, id_downSampleImage_Lorg_neuroph_imgrec_image_Dimension_Lorg_neuroph_imgrec_image_Image_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_downSampleImage_Lorg_neuroph_imgrec_image_Dimension_Lorg_neuroph_imgrec_image_Image_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.imgrec']/class[@name='ImageSampler']/method[@name='downSampleImage' and count(parameter)=3 and parameter[1][@type='org.neuroph.imgrec.image.Dimension'] and parameter[2][@type='org.neuroph.imgrec.image.Image'] and parameter[3][@type='int']]"
		[Register ("downSampleImage", "(Lorg/neuroph/imgrec/image/Dimension;Lorg/neuroph/imgrec/image/Image;I)Lorg/neuroph/imgrec/image/Image;", "")]
		public static unsafe global::Org.Neuroph.Imgrec.Image.IImage DownSampleImage (global::Org.Neuroph.Imgrec.Image.Dimension p0, global::Org.Neuroph.Imgrec.Image.IImage p1, int p2)
		{
			if (id_downSampleImage_Lorg_neuroph_imgrec_image_Dimension_Lorg_neuroph_imgrec_image_Image_I == IntPtr.Zero)
				id_downSampleImage_Lorg_neuroph_imgrec_image_Dimension_Lorg_neuroph_imgrec_image_Image_I = JNIEnv.GetStaticMethodID (class_ref, "downSampleImage", "(Lorg/neuroph/imgrec/image/Dimension;Lorg/neuroph/imgrec/image/Image;I)Lorg/neuroph/imgrec/image/Image;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				global::Org.Neuroph.Imgrec.Image.IImage __ret = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Imgrec.Image.IImage> (JNIEnv.CallStaticObjectMethod  (class_ref, id_downSampleImage_Lorg_neuroph_imgrec_image_Dimension_Lorg_neuroph_imgrec_image_Image_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
