using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Imgrec {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.imgrec']/class[@name='ImageUtilities']"
	[global::Android.Runtime.Register ("org/neuroph/imgrec/ImageUtilities", DoNotGenerateAcw=true)]
	public partial class ImageUtilities : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/imgrec/ImageUtilities", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ImageUtilities); }
		}

		protected ImageUtilities (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.imgrec']/class[@name='ImageUtilities']/constructor[@name='ImageUtilities' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ImageUtilities ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ImageUtilities)) {
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

		static IntPtr id_resizeImage_Lorg_neuroph_imgrec_image_Image_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.imgrec']/class[@name='ImageUtilities']/method[@name='resizeImage' and count(parameter)=3 and parameter[1][@type='org.neuroph.imgrec.image.Image'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("resizeImage", "(Lorg/neuroph/imgrec/image/Image;II)Lorg/neuroph/imgrec/image/Image;", "")]
		public static unsafe global::Org.Neuroph.Imgrec.Image.IImage ResizeImage (global::Org.Neuroph.Imgrec.Image.IImage p0, int p1, int p2)
		{
			if (id_resizeImage_Lorg_neuroph_imgrec_image_Image_II == IntPtr.Zero)
				id_resizeImage_Lorg_neuroph_imgrec_image_Image_II = JNIEnv.GetStaticMethodID (class_ref, "resizeImage", "(Lorg/neuroph/imgrec/image/Image;II)Lorg/neuroph/imgrec/image/Image;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				global::Org.Neuroph.Imgrec.Image.IImage __ret = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Imgrec.Image.IImage> (JNIEnv.CallStaticObjectMethod  (class_ref, id_resizeImage_Lorg_neuroph_imgrec_image_Image_II, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
