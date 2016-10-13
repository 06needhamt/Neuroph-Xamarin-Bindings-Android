using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Net.SF.Image4j.Codec.Bmp {

	// Metadata.xml XPath class reference: path="/api/package[@name='net.sf.image4j.codec.bmp']/class[@name='BMPImage']"
	[global::Android.Runtime.Register ("net/sf/image4j/codec/bmp/BMPImage", DoNotGenerateAcw=true)]
	public partial class BMPImage : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("net/sf/image4j/codec/bmp/BMPImage", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BMPImage); }
		}

		protected BMPImage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getColourCount;
#pragma warning disable 0169
		static Delegate GetGetColourCountHandler ()
		{
			if (cb_getColourCount == null)
				cb_getColourCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetColourCount);
			return cb_getColourCount;
		}

		static int n_GetColourCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Net.SF.Image4j.Codec.Bmp.BMPImage __this = global::Java.Lang.Object.GetObject<global::Net.SF.Image4j.Codec.Bmp.BMPImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ColourCount;
		}
#pragma warning restore 0169

		static IntPtr id_getColourCount;
		public virtual unsafe int ColourCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='net.sf.image4j.codec.bmp']/class[@name='BMPImage']/method[@name='getColourCount' and count(parameter)=0]"
			[Register ("getColourCount", "()I", "GetGetColourCountHandler")]
			get {
				if (id_getColourCount == IntPtr.Zero)
					id_getColourCount = JNIEnv.GetMethodID (class_ref, "getColourCount", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getColourCount);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getColourCount", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getColourDepth;
#pragma warning disable 0169
		static Delegate GetGetColourDepthHandler ()
		{
			if (cb_getColourDepth == null)
				cb_getColourDepth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetColourDepth);
			return cb_getColourDepth;
		}

		static int n_GetColourDepth (IntPtr jnienv, IntPtr native__this)
		{
			global::Net.SF.Image4j.Codec.Bmp.BMPImage __this = global::Java.Lang.Object.GetObject<global::Net.SF.Image4j.Codec.Bmp.BMPImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ColourDepth;
		}
#pragma warning restore 0169

		static IntPtr id_getColourDepth;
		public virtual unsafe int ColourDepth {
			// Metadata.xml XPath method reference: path="/api/package[@name='net.sf.image4j.codec.bmp']/class[@name='BMPImage']/method[@name='getColourDepth' and count(parameter)=0]"
			[Register ("getColourDepth", "()I", "GetGetColourDepthHandler")]
			get {
				if (id_getColourDepth == IntPtr.Zero)
					id_getColourDepth = JNIEnv.GetMethodID (class_ref, "getColourDepth", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getColourDepth);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getColourDepth", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getHeight;
#pragma warning disable 0169
		static Delegate GetGetHeightHandler ()
		{
			if (cb_getHeight == null)
				cb_getHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHeight);
			return cb_getHeight;
		}

		static int n_GetHeight (IntPtr jnienv, IntPtr native__this)
		{
			global::Net.SF.Image4j.Codec.Bmp.BMPImage __this = global::Java.Lang.Object.GetObject<global::Net.SF.Image4j.Codec.Bmp.BMPImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Height;
		}
#pragma warning restore 0169

		static IntPtr id_getHeight;
		public virtual unsafe int Height {
			// Metadata.xml XPath method reference: path="/api/package[@name='net.sf.image4j.codec.bmp']/class[@name='BMPImage']/method[@name='getHeight' and count(parameter)=0]"
			[Register ("getHeight", "()I", "GetGetHeightHandler")]
			get {
				if (id_getHeight == IntPtr.Zero)
					id_getHeight = JNIEnv.GetMethodID (class_ref, "getHeight", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getHeight);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHeight", "()I"));
				} finally {
				}
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
			global::Net.SF.Image4j.Codec.Bmp.BMPImage __this = global::Java.Lang.Object.GetObject<global::Net.SF.Image4j.Codec.Bmp.BMPImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InfoHeader);
		}
#pragma warning restore 0169

		static Delegate cb_setInfoHeader_Lnet_sf_image4j_codec_bmp_InfoHeader_;
#pragma warning disable 0169
		static Delegate GetSetInfoHeader_Lnet_sf_image4j_codec_bmp_InfoHeader_Handler ()
		{
			if (cb_setInfoHeader_Lnet_sf_image4j_codec_bmp_InfoHeader_ == null)
				cb_setInfoHeader_Lnet_sf_image4j_codec_bmp_InfoHeader_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetInfoHeader_Lnet_sf_image4j_codec_bmp_InfoHeader_);
			return cb_setInfoHeader_Lnet_sf_image4j_codec_bmp_InfoHeader_;
		}

		static void n_SetInfoHeader_Lnet_sf_image4j_codec_bmp_InfoHeader_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Net.SF.Image4j.Codec.Bmp.BMPImage __this = global::Java.Lang.Object.GetObject<global::Net.SF.Image4j.Codec.Bmp.BMPImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Net.SF.Image4j.Codec.Bmp.InfoHeader p0 = global::Java.Lang.Object.GetObject<global::Net.SF.Image4j.Codec.Bmp.InfoHeader> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.InfoHeader = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getInfoHeader;
		static IntPtr id_setInfoHeader_Lnet_sf_image4j_codec_bmp_InfoHeader_;
		public virtual unsafe global::Net.SF.Image4j.Codec.Bmp.InfoHeader InfoHeader {
			// Metadata.xml XPath method reference: path="/api/package[@name='net.sf.image4j.codec.bmp']/class[@name='BMPImage']/method[@name='getInfoHeader' and count(parameter)=0]"
			[Register ("getInfoHeader", "()Lnet/sf/image4j/codec/bmp/InfoHeader;", "GetGetInfoHeaderHandler")]
			get {
				if (id_getInfoHeader == IntPtr.Zero)
					id_getInfoHeader = JNIEnv.GetMethodID (class_ref, "getInfoHeader", "()Lnet/sf/image4j/codec/bmp/InfoHeader;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Net.SF.Image4j.Codec.Bmp.InfoHeader> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getInfoHeader), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Net.SF.Image4j.Codec.Bmp.InfoHeader> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getInfoHeader", "()Lnet/sf/image4j/codec/bmp/InfoHeader;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='net.sf.image4j.codec.bmp']/class[@name='BMPImage']/method[@name='setInfoHeader' and count(parameter)=1 and parameter[1][@type='net.sf.image4j.codec.bmp.InfoHeader']]"
			[Register ("setInfoHeader", "(Lnet/sf/image4j/codec/bmp/InfoHeader;)V", "GetSetInfoHeader_Lnet_sf_image4j_codec_bmp_InfoHeader_Handler")]
			set {
				if (id_setInfoHeader_Lnet_sf_image4j_codec_bmp_InfoHeader_ == IntPtr.Zero)
					id_setInfoHeader_Lnet_sf_image4j_codec_bmp_InfoHeader_ = JNIEnv.GetMethodID (class_ref, "setInfoHeader", "(Lnet/sf/image4j/codec/bmp/InfoHeader;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setInfoHeader_Lnet_sf_image4j_codec_bmp_InfoHeader_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setInfoHeader", "(Lnet/sf/image4j/codec/bmp/InfoHeader;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_isIndexed;
#pragma warning disable 0169
		static Delegate GetIsIndexedHandler ()
		{
			if (cb_isIndexed == null)
				cb_isIndexed = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsIndexed);
			return cb_isIndexed;
		}

		static bool n_IsIndexed (IntPtr jnienv, IntPtr native__this)
		{
			global::Net.SF.Image4j.Codec.Bmp.BMPImage __this = global::Java.Lang.Object.GetObject<global::Net.SF.Image4j.Codec.Bmp.BMPImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsIndexed;
		}
#pragma warning restore 0169

		static IntPtr id_isIndexed;
		public virtual unsafe bool IsIndexed {
			// Metadata.xml XPath method reference: path="/api/package[@name='net.sf.image4j.codec.bmp']/class[@name='BMPImage']/method[@name='isIndexed' and count(parameter)=0]"
			[Register ("isIndexed", "()Z", "GetIsIndexedHandler")]
			get {
				if (id_isIndexed == IntPtr.Zero)
					id_isIndexed = JNIEnv.GetMethodID (class_ref, "isIndexed", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isIndexed);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isIndexed", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getWidth;
#pragma warning disable 0169
		static Delegate GetGetWidthHandler ()
		{
			if (cb_getWidth == null)
				cb_getWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetWidth);
			return cb_getWidth;
		}

		static int n_GetWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::Net.SF.Image4j.Codec.Bmp.BMPImage __this = global::Java.Lang.Object.GetObject<global::Net.SF.Image4j.Codec.Bmp.BMPImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Width;
		}
#pragma warning restore 0169

		static IntPtr id_getWidth;
		public virtual unsafe int Width {
			// Metadata.xml XPath method reference: path="/api/package[@name='net.sf.image4j.codec.bmp']/class[@name='BMPImage']/method[@name='getWidth' and count(parameter)=0]"
			[Register ("getWidth", "()I", "GetGetWidthHandler")]
			get {
				if (id_getWidth == IntPtr.Zero)
					id_getWidth = JNIEnv.GetMethodID (class_ref, "getWidth", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getWidth);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWidth", "()I"));
				} finally {
				}
			}
		}

	}
}
