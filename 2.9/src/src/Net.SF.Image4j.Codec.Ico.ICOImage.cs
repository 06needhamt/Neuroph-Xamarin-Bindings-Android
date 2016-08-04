using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Net.SF.Image4j.Codec.Ico {

	// Metadata.xml XPath class reference: path="/api/package[@name='net.sf.image4j.codec.ico']/class[@name='ICOImage']"
	[global::Android.Runtime.Register ("net/sf/image4j/codec/ico/ICOImage", DoNotGenerateAcw=true)]
	public partial class ICOImage : global::Net.SF.Image4j.Codec.Bmp.BMPImage {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("net/sf/image4j/codec/ico/ICOImage", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ICOImage); }
		}

		protected ICOImage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getIconEntry;
#pragma warning disable 0169
		static Delegate GetGetIconEntryHandler ()
		{
			if (cb_getIconEntry == null)
				cb_getIconEntry = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIconEntry);
			return cb_getIconEntry;
		}

		static IntPtr n_GetIconEntry (IntPtr jnienv, IntPtr native__this)
		{
			global::Net.SF.Image4j.Codec.Ico.ICOImage __this = global::Java.Lang.Object.GetObject<global::Net.SF.Image4j.Codec.Ico.ICOImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IconEntry);
		}
#pragma warning restore 0169

		static Delegate cb_setIconEntry_Lnet_sf_image4j_codec_ico_IconEntry_;
#pragma warning disable 0169
		static Delegate GetSetIconEntry_Lnet_sf_image4j_codec_ico_IconEntry_Handler ()
		{
			if (cb_setIconEntry_Lnet_sf_image4j_codec_ico_IconEntry_ == null)
				cb_setIconEntry_Lnet_sf_image4j_codec_ico_IconEntry_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetIconEntry_Lnet_sf_image4j_codec_ico_IconEntry_);
			return cb_setIconEntry_Lnet_sf_image4j_codec_ico_IconEntry_;
		}

		static void n_SetIconEntry_Lnet_sf_image4j_codec_ico_IconEntry_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Net.SF.Image4j.Codec.Ico.ICOImage __this = global::Java.Lang.Object.GetObject<global::Net.SF.Image4j.Codec.Ico.ICOImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Net.SF.Image4j.Codec.Ico.IconEntry p0 = global::Java.Lang.Object.GetObject<global::Net.SF.Image4j.Codec.Ico.IconEntry> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.IconEntry = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getIconEntry;
		static IntPtr id_setIconEntry_Lnet_sf_image4j_codec_ico_IconEntry_;
		public virtual unsafe global::Net.SF.Image4j.Codec.Ico.IconEntry IconEntry {
			// Metadata.xml XPath method reference: path="/api/package[@name='net.sf.image4j.codec.ico']/class[@name='ICOImage']/method[@name='getIconEntry' and count(parameter)=0]"
			[Register ("getIconEntry", "()Lnet/sf/image4j/codec/ico/IconEntry;", "GetGetIconEntryHandler")]
			get {
				if (id_getIconEntry == IntPtr.Zero)
					id_getIconEntry = JNIEnv.GetMethodID (class_ref, "getIconEntry", "()Lnet/sf/image4j/codec/ico/IconEntry;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Net.SF.Image4j.Codec.Ico.IconEntry> (JNIEnv.CallObjectMethod  (Handle, id_getIconEntry), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Net.SF.Image4j.Codec.Ico.IconEntry> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIconEntry", "()Lnet/sf/image4j/codec/ico/IconEntry;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='net.sf.image4j.codec.ico']/class[@name='ICOImage']/method[@name='setIconEntry' and count(parameter)=1 and parameter[1][@type='net.sf.image4j.codec.ico.IconEntry']]"
			[Register ("setIconEntry", "(Lnet/sf/image4j/codec/ico/IconEntry;)V", "GetSetIconEntry_Lnet_sf_image4j_codec_ico_IconEntry_Handler")]
			set {
				if (id_setIconEntry_Lnet_sf_image4j_codec_ico_IconEntry_ == IntPtr.Zero)
					id_setIconEntry_Lnet_sf_image4j_codec_ico_IconEntry_ = JNIEnv.GetMethodID (class_ref, "setIconEntry", "(Lnet/sf/image4j/codec/ico/IconEntry;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setIconEntry_Lnet_sf_image4j_codec_ico_IconEntry_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setIconEntry", "(Lnet/sf/image4j/codec/ico/IconEntry;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getIconIndex;
#pragma warning disable 0169
		static Delegate GetGetIconIndexHandler ()
		{
			if (cb_getIconIndex == null)
				cb_getIconIndex = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetIconIndex);
			return cb_getIconIndex;
		}

		static int n_GetIconIndex (IntPtr jnienv, IntPtr native__this)
		{
			global::Net.SF.Image4j.Codec.Ico.ICOImage __this = global::Java.Lang.Object.GetObject<global::Net.SF.Image4j.Codec.Ico.ICOImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IconIndex;
		}
#pragma warning restore 0169

		static Delegate cb_setIconIndex_I;
#pragma warning disable 0169
		static Delegate GetSetIconIndex_IHandler ()
		{
			if (cb_setIconIndex_I == null)
				cb_setIconIndex_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetIconIndex_I);
			return cb_setIconIndex_I;
		}

		static void n_SetIconIndex_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Net.SF.Image4j.Codec.Ico.ICOImage __this = global::Java.Lang.Object.GetObject<global::Net.SF.Image4j.Codec.Ico.ICOImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.IconIndex = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getIconIndex;
		static IntPtr id_setIconIndex_I;
		public virtual unsafe int IconIndex {
			// Metadata.xml XPath method reference: path="/api/package[@name='net.sf.image4j.codec.ico']/class[@name='ICOImage']/method[@name='getIconIndex' and count(parameter)=0]"
			[Register ("getIconIndex", "()I", "GetGetIconIndexHandler")]
			get {
				if (id_getIconIndex == IntPtr.Zero)
					id_getIconIndex = JNIEnv.GetMethodID (class_ref, "getIconIndex", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getIconIndex);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIconIndex", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='net.sf.image4j.codec.ico']/class[@name='ICOImage']/method[@name='setIconIndex' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setIconIndex", "(I)V", "GetSetIconIndex_IHandler")]
			set {
				if (id_setIconIndex_I == IntPtr.Zero)
					id_setIconIndex_I = JNIEnv.GetMethodID (class_ref, "setIconIndex", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setIconIndex_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setIconIndex", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_isPngCompressed;
#pragma warning disable 0169
		static Delegate GetIsPngCompressedHandler ()
		{
			if (cb_isPngCompressed == null)
				cb_isPngCompressed = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsPngCompressed);
			return cb_isPngCompressed;
		}

		static bool n_IsPngCompressed (IntPtr jnienv, IntPtr native__this)
		{
			global::Net.SF.Image4j.Codec.Ico.ICOImage __this = global::Java.Lang.Object.GetObject<global::Net.SF.Image4j.Codec.Ico.ICOImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PngCompressed;
		}
#pragma warning restore 0169

		static Delegate cb_setPngCompressed_Z;
#pragma warning disable 0169
		static Delegate GetSetPngCompressed_ZHandler ()
		{
			if (cb_setPngCompressed_Z == null)
				cb_setPngCompressed_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetPngCompressed_Z);
			return cb_setPngCompressed_Z;
		}

		static void n_SetPngCompressed_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Net.SF.Image4j.Codec.Ico.ICOImage __this = global::Java.Lang.Object.GetObject<global::Net.SF.Image4j.Codec.Ico.ICOImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PngCompressed = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isPngCompressed;
		static IntPtr id_setPngCompressed_Z;
		public virtual unsafe bool PngCompressed {
			// Metadata.xml XPath method reference: path="/api/package[@name='net.sf.image4j.codec.ico']/class[@name='ICOImage']/method[@name='isPngCompressed' and count(parameter)=0]"
			[Register ("isPngCompressed", "()Z", "GetIsPngCompressedHandler")]
			get {
				if (id_isPngCompressed == IntPtr.Zero)
					id_isPngCompressed = JNIEnv.GetMethodID (class_ref, "isPngCompressed", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isPngCompressed);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isPngCompressed", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='net.sf.image4j.codec.ico']/class[@name='ICOImage']/method[@name='setPngCompressed' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setPngCompressed", "(Z)V", "GetSetPngCompressed_ZHandler")]
			set {
				if (id_setPngCompressed_Z == IntPtr.Zero)
					id_setPngCompressed_Z = JNIEnv.GetMethodID (class_ref, "setPngCompressed", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setPngCompressed_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPngCompressed", "(Z)V"), __args);
				} finally {
				}
			}
		}

	}
}
