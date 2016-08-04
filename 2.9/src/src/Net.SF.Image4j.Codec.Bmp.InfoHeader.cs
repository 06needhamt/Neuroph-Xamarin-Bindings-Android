using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Net.SF.Image4j.Codec.Bmp {

	// Metadata.xml XPath class reference: path="/api/package[@name='net.sf.image4j.codec.bmp']/class[@name='InfoHeader']"
	[global::Android.Runtime.Register ("net/sf/image4j/codec/bmp/InfoHeader", DoNotGenerateAcw=true)]
	public partial class InfoHeader : global::Java.Lang.Object {


		static IntPtr iColorsImportant_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='net.sf.image4j.codec.bmp']/class[@name='InfoHeader']/field[@name='iColorsImportant']"
		[Register ("iColorsImportant")]
		public int IColorsImportant {
			get {
				if (iColorsImportant_jfieldId == IntPtr.Zero)
					iColorsImportant_jfieldId = JNIEnv.GetFieldID (class_ref, "iColorsImportant", "I");
				return JNIEnv.GetIntField (Handle, iColorsImportant_jfieldId);
			}
			set {
				if (iColorsImportant_jfieldId == IntPtr.Zero)
					iColorsImportant_jfieldId = JNIEnv.GetFieldID (class_ref, "iColorsImportant", "I");
				try {
					JNIEnv.SetField (Handle, iColorsImportant_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr iColorsUsed_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='net.sf.image4j.codec.bmp']/class[@name='InfoHeader']/field[@name='iColorsUsed']"
		[Register ("iColorsUsed")]
		public int IColorsUsed {
			get {
				if (iColorsUsed_jfieldId == IntPtr.Zero)
					iColorsUsed_jfieldId = JNIEnv.GetFieldID (class_ref, "iColorsUsed", "I");
				return JNIEnv.GetIntField (Handle, iColorsUsed_jfieldId);
			}
			set {
				if (iColorsUsed_jfieldId == IntPtr.Zero)
					iColorsUsed_jfieldId = JNIEnv.GetFieldID (class_ref, "iColorsUsed", "I");
				try {
					JNIEnv.SetField (Handle, iColorsUsed_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr iCompression_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='net.sf.image4j.codec.bmp']/class[@name='InfoHeader']/field[@name='iCompression']"
		[Register ("iCompression")]
		public int ICompression {
			get {
				if (iCompression_jfieldId == IntPtr.Zero)
					iCompression_jfieldId = JNIEnv.GetFieldID (class_ref, "iCompression", "I");
				return JNIEnv.GetIntField (Handle, iCompression_jfieldId);
			}
			set {
				if (iCompression_jfieldId == IntPtr.Zero)
					iCompression_jfieldId = JNIEnv.GetFieldID (class_ref, "iCompression", "I");
				try {
					JNIEnv.SetField (Handle, iCompression_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr iHeight_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='net.sf.image4j.codec.bmp']/class[@name='InfoHeader']/field[@name='iHeight']"
		[Register ("iHeight")]
		public int IHeight {
			get {
				if (iHeight_jfieldId == IntPtr.Zero)
					iHeight_jfieldId = JNIEnv.GetFieldID (class_ref, "iHeight", "I");
				return JNIEnv.GetIntField (Handle, iHeight_jfieldId);
			}
			set {
				if (iHeight_jfieldId == IntPtr.Zero)
					iHeight_jfieldId = JNIEnv.GetFieldID (class_ref, "iHeight", "I");
				try {
					JNIEnv.SetField (Handle, iHeight_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr iImageSize_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='net.sf.image4j.codec.bmp']/class[@name='InfoHeader']/field[@name='iImageSize']"
		[Register ("iImageSize")]
		public int IImageSize {
			get {
				if (iImageSize_jfieldId == IntPtr.Zero)
					iImageSize_jfieldId = JNIEnv.GetFieldID (class_ref, "iImageSize", "I");
				return JNIEnv.GetIntField (Handle, iImageSize_jfieldId);
			}
			set {
				if (iImageSize_jfieldId == IntPtr.Zero)
					iImageSize_jfieldId = JNIEnv.GetFieldID (class_ref, "iImageSize", "I");
				try {
					JNIEnv.SetField (Handle, iImageSize_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr iNumColors_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='net.sf.image4j.codec.bmp']/class[@name='InfoHeader']/field[@name='iNumColors']"
		[Register ("iNumColors")]
		public int INumColors {
			get {
				if (iNumColors_jfieldId == IntPtr.Zero)
					iNumColors_jfieldId = JNIEnv.GetFieldID (class_ref, "iNumColors", "I");
				return JNIEnv.GetIntField (Handle, iNumColors_jfieldId);
			}
			set {
				if (iNumColors_jfieldId == IntPtr.Zero)
					iNumColors_jfieldId = JNIEnv.GetFieldID (class_ref, "iNumColors", "I");
				try {
					JNIEnv.SetField (Handle, iNumColors_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr iSize_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='net.sf.image4j.codec.bmp']/class[@name='InfoHeader']/field[@name='iSize']"
		[Register ("iSize")]
		public int ISize {
			get {
				if (iSize_jfieldId == IntPtr.Zero)
					iSize_jfieldId = JNIEnv.GetFieldID (class_ref, "iSize", "I");
				return JNIEnv.GetIntField (Handle, iSize_jfieldId);
			}
			set {
				if (iSize_jfieldId == IntPtr.Zero)
					iSize_jfieldId = JNIEnv.GetFieldID (class_ref, "iSize", "I");
				try {
					JNIEnv.SetField (Handle, iSize_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr iWidth_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='net.sf.image4j.codec.bmp']/class[@name='InfoHeader']/field[@name='iWidth']"
		[Register ("iWidth")]
		public int IWidth {
			get {
				if (iWidth_jfieldId == IntPtr.Zero)
					iWidth_jfieldId = JNIEnv.GetFieldID (class_ref, "iWidth", "I");
				return JNIEnv.GetIntField (Handle, iWidth_jfieldId);
			}
			set {
				if (iWidth_jfieldId == IntPtr.Zero)
					iWidth_jfieldId = JNIEnv.GetFieldID (class_ref, "iWidth", "I");
				try {
					JNIEnv.SetField (Handle, iWidth_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr iXpixelsPerM_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='net.sf.image4j.codec.bmp']/class[@name='InfoHeader']/field[@name='iXpixelsPerM']"
		[Register ("iXpixelsPerM")]
		public int IXpixelsPerM {
			get {
				if (iXpixelsPerM_jfieldId == IntPtr.Zero)
					iXpixelsPerM_jfieldId = JNIEnv.GetFieldID (class_ref, "iXpixelsPerM", "I");
				return JNIEnv.GetIntField (Handle, iXpixelsPerM_jfieldId);
			}
			set {
				if (iXpixelsPerM_jfieldId == IntPtr.Zero)
					iXpixelsPerM_jfieldId = JNIEnv.GetFieldID (class_ref, "iXpixelsPerM", "I");
				try {
					JNIEnv.SetField (Handle, iXpixelsPerM_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr iYpixelsPerM_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='net.sf.image4j.codec.bmp']/class[@name='InfoHeader']/field[@name='iYpixelsPerM']"
		[Register ("iYpixelsPerM")]
		public int IYpixelsPerM {
			get {
				if (iYpixelsPerM_jfieldId == IntPtr.Zero)
					iYpixelsPerM_jfieldId = JNIEnv.GetFieldID (class_ref, "iYpixelsPerM", "I");
				return JNIEnv.GetIntField (Handle, iYpixelsPerM_jfieldId);
			}
			set {
				if (iYpixelsPerM_jfieldId == IntPtr.Zero)
					iYpixelsPerM_jfieldId = JNIEnv.GetFieldID (class_ref, "iYpixelsPerM", "I");
				try {
					JNIEnv.SetField (Handle, iYpixelsPerM_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr sBitCount_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='net.sf.image4j.codec.bmp']/class[@name='InfoHeader']/field[@name='sBitCount']"
		[Register ("sBitCount")]
		public short SBitCount {
			get {
				if (sBitCount_jfieldId == IntPtr.Zero)
					sBitCount_jfieldId = JNIEnv.GetFieldID (class_ref, "sBitCount", "S");
				return JNIEnv.GetShortField (Handle, sBitCount_jfieldId);
			}
			set {
				if (sBitCount_jfieldId == IntPtr.Zero)
					sBitCount_jfieldId = JNIEnv.GetFieldID (class_ref, "sBitCount", "S");
				try {
					JNIEnv.SetField (Handle, sBitCount_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr sPlanes_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='net.sf.image4j.codec.bmp']/class[@name='InfoHeader']/field[@name='sPlanes']"
		[Register ("sPlanes")]
		public short SPlanes {
			get {
				if (sPlanes_jfieldId == IntPtr.Zero)
					sPlanes_jfieldId = JNIEnv.GetFieldID (class_ref, "sPlanes", "S");
				return JNIEnv.GetShortField (Handle, sPlanes_jfieldId);
			}
			set {
				if (sPlanes_jfieldId == IntPtr.Zero)
					sPlanes_jfieldId = JNIEnv.GetFieldID (class_ref, "sPlanes", "S");
				try {
					JNIEnv.SetField (Handle, sPlanes_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("net/sf/image4j/codec/bmp/InfoHeader", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (InfoHeader); }
		}

		protected InfoHeader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lnet_sf_image4j_codec_bmp_InfoHeader_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='net.sf.image4j.codec.bmp']/class[@name='InfoHeader']/constructor[@name='InfoHeader' and count(parameter)=1 and parameter[1][@type='net.sf.image4j.codec.bmp.InfoHeader']]"
		[Register (".ctor", "(Lnet/sf/image4j/codec/bmp/InfoHeader;)V", "")]
		public unsafe InfoHeader (global::Net.SF.Image4j.Codec.Bmp.InfoHeader p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (InfoHeader)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lnet/sf/image4j/codec/bmp/InfoHeader;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lnet/sf/image4j/codec/bmp/InfoHeader;)V", __args);
					return;
				}

				if (id_ctor_Lnet_sf_image4j_codec_bmp_InfoHeader_ == IntPtr.Zero)
					id_ctor_Lnet_sf_image4j_codec_bmp_InfoHeader_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lnet/sf/image4j/codec/bmp/InfoHeader;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lnet_sf_image4j_codec_bmp_InfoHeader_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lnet_sf_image4j_codec_bmp_InfoHeader_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='net.sf.image4j.codec.bmp']/class[@name='InfoHeader']/constructor[@name='InfoHeader' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe InfoHeader ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (InfoHeader)) {
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

		static IntPtr id_ctor_Lnet_sf_image4j_io_LittleEndianInputStream_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='net.sf.image4j.codec.bmp']/class[@name='InfoHeader']/constructor[@name='InfoHeader' and count(parameter)=1 and parameter[1][@type='net.sf.image4j.io.LittleEndianInputStream']]"
		[Register (".ctor", "(Lnet/sf/image4j/io/LittleEndianInputStream;)V", "")]
		public unsafe InfoHeader (global::Net.SF.Image4j.IO.LittleEndianInputStream p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (InfoHeader)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lnet/sf/image4j/io/LittleEndianInputStream;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lnet/sf/image4j/io/LittleEndianInputStream;)V", __args);
					return;
				}

				if (id_ctor_Lnet_sf_image4j_io_LittleEndianInputStream_ == IntPtr.Zero)
					id_ctor_Lnet_sf_image4j_io_LittleEndianInputStream_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lnet/sf/image4j/io/LittleEndianInputStream;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lnet_sf_image4j_io_LittleEndianInputStream_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lnet_sf_image4j_io_LittleEndianInputStream_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Lnet_sf_image4j_io_LittleEndianInputStream_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='net.sf.image4j.codec.bmp']/class[@name='InfoHeader']/constructor[@name='InfoHeader' and count(parameter)=2 and parameter[1][@type='net.sf.image4j.io.LittleEndianInputStream'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Lnet/sf/image4j/io/LittleEndianInputStream;I)V", "")]
		public unsafe InfoHeader (global::Net.SF.Image4j.IO.LittleEndianInputStream p0, int p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (InfoHeader)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lnet/sf/image4j/io/LittleEndianInputStream;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lnet/sf/image4j/io/LittleEndianInputStream;I)V", __args);
					return;
				}

				if (id_ctor_Lnet_sf_image4j_io_LittleEndianInputStream_I == IntPtr.Zero)
					id_ctor_Lnet_sf_image4j_io_LittleEndianInputStream_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Lnet/sf/image4j/io/LittleEndianInputStream;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lnet_sf_image4j_io_LittleEndianInputStream_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lnet_sf_image4j_io_LittleEndianInputStream_I, __args);
			} finally {
			}
		}

		static Delegate cb_init_Lnet_sf_image4j_io_LittleEndianInputStream_I;
#pragma warning disable 0169
		static Delegate GetInit_Lnet_sf_image4j_io_LittleEndianInputStream_IHandler ()
		{
			if (cb_init_Lnet_sf_image4j_io_LittleEndianInputStream_I == null)
				cb_init_Lnet_sf_image4j_io_LittleEndianInputStream_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_Init_Lnet_sf_image4j_io_LittleEndianInputStream_I);
			return cb_init_Lnet_sf_image4j_io_LittleEndianInputStream_I;
		}

		static void n_Init_Lnet_sf_image4j_io_LittleEndianInputStream_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Net.SF.Image4j.Codec.Bmp.InfoHeader __this = global::Java.Lang.Object.GetObject<global::Net.SF.Image4j.Codec.Bmp.InfoHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Net.SF.Image4j.IO.LittleEndianInputStream p0 = global::Java.Lang.Object.GetObject<global::Net.SF.Image4j.IO.LittleEndianInputStream> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Init (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_init_Lnet_sf_image4j_io_LittleEndianInputStream_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='net.sf.image4j.codec.bmp']/class[@name='InfoHeader']/method[@name='init' and count(parameter)=2 and parameter[1][@type='net.sf.image4j.io.LittleEndianInputStream'] and parameter[2][@type='int']]"
		[Register ("init", "(Lnet/sf/image4j/io/LittleEndianInputStream;I)V", "GetInit_Lnet_sf_image4j_io_LittleEndianInputStream_IHandler")]
		protected virtual unsafe void Init (global::Net.SF.Image4j.IO.LittleEndianInputStream p0, int p1)
		{
			if (id_init_Lnet_sf_image4j_io_LittleEndianInputStream_I == IntPtr.Zero)
				id_init_Lnet_sf_image4j_io_LittleEndianInputStream_I = JNIEnv.GetMethodID (class_ref, "init", "(Lnet/sf/image4j/io/LittleEndianInputStream;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_init_Lnet_sf_image4j_io_LittleEndianInputStream_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "init", "(Lnet/sf/image4j/io/LittleEndianInputStream;I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_write_Lnet_sf_image4j_io_LittleEndianOutputStream_;
#pragma warning disable 0169
		static Delegate GetWrite_Lnet_sf_image4j_io_LittleEndianOutputStream_Handler ()
		{
			if (cb_write_Lnet_sf_image4j_io_LittleEndianOutputStream_ == null)
				cb_write_Lnet_sf_image4j_io_LittleEndianOutputStream_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Write_Lnet_sf_image4j_io_LittleEndianOutputStream_);
			return cb_write_Lnet_sf_image4j_io_LittleEndianOutputStream_;
		}

		static void n_Write_Lnet_sf_image4j_io_LittleEndianOutputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Net.SF.Image4j.Codec.Bmp.InfoHeader __this = global::Java.Lang.Object.GetObject<global::Net.SF.Image4j.Codec.Bmp.InfoHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Net.SF.Image4j.IO.LittleEndianOutputStream p0 = global::Java.Lang.Object.GetObject<global::Net.SF.Image4j.IO.LittleEndianOutputStream> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Write (p0);
		}
#pragma warning restore 0169

		static IntPtr id_write_Lnet_sf_image4j_io_LittleEndianOutputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='net.sf.image4j.codec.bmp']/class[@name='InfoHeader']/method[@name='write' and count(parameter)=1 and parameter[1][@type='net.sf.image4j.io.LittleEndianOutputStream']]"
		[Register ("write", "(Lnet/sf/image4j/io/LittleEndianOutputStream;)V", "GetWrite_Lnet_sf_image4j_io_LittleEndianOutputStream_Handler")]
		public virtual unsafe void Write (global::Net.SF.Image4j.IO.LittleEndianOutputStream p0)
		{
			if (id_write_Lnet_sf_image4j_io_LittleEndianOutputStream_ == IntPtr.Zero)
				id_write_Lnet_sf_image4j_io_LittleEndianOutputStream_ = JNIEnv.GetMethodID (class_ref, "write", "(Lnet/sf/image4j/io/LittleEndianOutputStream;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_write_Lnet_sf_image4j_io_LittleEndianOutputStream_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "write", "(Lnet/sf/image4j/io/LittleEndianOutputStream;)V"), __args);
			} finally {
			}
		}

	}
}
