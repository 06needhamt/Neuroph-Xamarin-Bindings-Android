using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Imgrec.Image {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.imgrec.image']/class[@name='ImageType']"
	[global::Android.Runtime.Register ("org/neuroph/imgrec/image/ImageType", DoNotGenerateAcw=true)]
	public partial class ImageType : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.neuroph.imgrec.image']/class[@name='ImageType']/field[@name='ANDROID_TYPE_ALPHA_8']"
		[Register ("ANDROID_TYPE_ALPHA_8")]
		public const int AndroidTypeAlpha8 = (int) 14;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.neuroph.imgrec.image']/class[@name='ImageType']/field[@name='ANDROID_TYPE_ARGB_8888']"
		[Register ("ANDROID_TYPE_ARGB_8888")]
		public const int AndroidTypeArgb8888 = (int) 15;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.neuroph.imgrec.image']/class[@name='ImageType']/field[@name='ANDROID_TYPE_RGB_565']"
		[Register ("ANDROID_TYPE_RGB_565")]
		public const int AndroidTypeRgb565 = (int) 16;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.neuroph.imgrec.image']/class[@name='ImageType']/field[@name='J2SE_TYPE_3BYTE_BGR']"
		[Register ("J2SE_TYPE_3BYTE_BGR")]
		public const int J2seType3byteBgr = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.neuroph.imgrec.image']/class[@name='ImageType']/field[@name='J2SE_TYPE_4BYTE_ABGR']"
		[Register ("J2SE_TYPE_4BYTE_ABGR")]
		public const int J2seType4byteAbgr = (int) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.neuroph.imgrec.image']/class[@name='ImageType']/field[@name='J2SE_TYPE_4BYTE_ABGR_PRE']"
		[Register ("J2SE_TYPE_4BYTE_ABGR_PRE")]
		public const int J2seType4byteAbgrPre = (int) 7;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.neuroph.imgrec.image']/class[@name='ImageType']/field[@name='J2SE_TYPE_BYTE_BINARY']"
		[Register ("J2SE_TYPE_BYTE_BINARY")]
		public const int J2seTypeByteBinary = (int) 12;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.neuroph.imgrec.image']/class[@name='ImageType']/field[@name='J2SE_TYPE_BYTE_GRAY']"
		[Register ("J2SE_TYPE_BYTE_GRAY")]
		public const int J2seTypeByteGray = (int) 10;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.neuroph.imgrec.image']/class[@name='ImageType']/field[@name='J2SE_TYPE_BYTE_INDEXED']"
		[Register ("J2SE_TYPE_BYTE_INDEXED")]
		public const int J2seTypeByteIndexed = (int) 13;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.neuroph.imgrec.image']/class[@name='ImageType']/field[@name='J2SE_TYPE_CUSTOM']"
		[Register ("J2SE_TYPE_CUSTOM")]
		public const int J2seTypeCustom = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.neuroph.imgrec.image']/class[@name='ImageType']/field[@name='J2SE_TYPE_INT_ARGB']"
		[Register ("J2SE_TYPE_INT_ARGB")]
		public const int J2seTypeIntArgb = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.neuroph.imgrec.image']/class[@name='ImageType']/field[@name='J2SE_TYPE_INT_ARGB_PRE']"
		[Register ("J2SE_TYPE_INT_ARGB_PRE")]
		public const int J2seTypeIntArgbPre = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.neuroph.imgrec.image']/class[@name='ImageType']/field[@name='J2SE_TYPE_INT_BGR']"
		[Register ("J2SE_TYPE_INT_BGR")]
		public const int J2seTypeIntBgr = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.neuroph.imgrec.image']/class[@name='ImageType']/field[@name='J2SE_TYPE_INT_RGB']"
		[Register ("J2SE_TYPE_INT_RGB")]
		public const int J2seTypeIntRgb = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.neuroph.imgrec.image']/class[@name='ImageType']/field[@name='J2SE_TYPE_USHORT_555_RGB']"
		[Register ("J2SE_TYPE_USHORT_555_RGB")]
		public const int J2seTypeUshort555Rgb = (int) 9;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.neuroph.imgrec.image']/class[@name='ImageType']/field[@name='J2SE_TYPE_USHORT_565_RGB']"
		[Register ("J2SE_TYPE_USHORT_565_RGB")]
		public const int J2seTypeUshort565Rgb = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.neuroph.imgrec.image']/class[@name='ImageType']/field[@name='J2SE_TYPE_USHORT_GRAY']"
		[Register ("J2SE_TYPE_USHORT_GRAY")]
		public const int J2seTypeUshortGray = (int) 11;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/imgrec/image/ImageType", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ImageType); }
		}

		protected ImageType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.imgrec.image']/class[@name='ImageType']/constructor[@name='ImageType' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ImageType ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ImageType)) {
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

	}
}
