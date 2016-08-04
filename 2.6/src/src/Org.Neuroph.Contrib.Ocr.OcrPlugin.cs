using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Contrib.Ocr {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.contrib.ocr']/class[@name='OcrPlugin']"
	[global::Android.Runtime.Register ("org/neuroph/contrib/ocr/OcrPlugin", DoNotGenerateAcw=true)]
	public partial class OcrPlugin : global::Org.Neuroph.Util.Plugins.PluginBase, global::Java.IO.ISerializable {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.neuroph.contrib.ocr']/class[@name='OcrPlugin']/field[@name='OCR_PLUGIN_NAME']"
		[Register ("OCR_PLUGIN_NAME")]
		public const string OcrPluginName = (string) "OCR Plugin";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/contrib/ocr/OcrPlugin", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (OcrPlugin); }
		}

		protected OcrPlugin (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_neuroph_contrib_imgrec_image_Dimension_Lorg_neuroph_contrib_imgrec_ColorMode_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.contrib.ocr']/class[@name='OcrPlugin']/constructor[@name='OcrPlugin' and count(parameter)=2 and parameter[1][@type='org.neuroph.contrib.imgrec.image.Dimension'] and parameter[2][@type='org.neuroph.contrib.imgrec.ColorMode']]"
		[Register (".ctor", "(Lorg/neuroph/contrib/imgrec/image/Dimension;Lorg/neuroph/contrib/imgrec/ColorMode;)V", "")]
		public unsafe OcrPlugin (global::Org.Neuroph.Contrib.Imgrec.Image.Dimension p0, global::Org.Neuroph.Contrib.Imgrec.ColorMode p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (OcrPlugin)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/neuroph/contrib/imgrec/image/Dimension;Lorg/neuroph/contrib/imgrec/ColorMode;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorg/neuroph/contrib/imgrec/image/Dimension;Lorg/neuroph/contrib/imgrec/ColorMode;)V", __args);
					return;
				}

				if (id_ctor_Lorg_neuroph_contrib_imgrec_image_Dimension_Lorg_neuroph_contrib_imgrec_ColorMode_ == IntPtr.Zero)
					id_ctor_Lorg_neuroph_contrib_imgrec_image_Dimension_Lorg_neuroph_contrib_imgrec_ColorMode_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/neuroph/contrib/imgrec/image/Dimension;Lorg/neuroph/contrib/imgrec/ColorMode;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_neuroph_contrib_imgrec_image_Dimension_Lorg_neuroph_contrib_imgrec_ColorMode_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_neuroph_contrib_imgrec_image_Dimension_Lorg_neuroph_contrib_imgrec_ColorMode_, __args);
			} finally {
			}
		}

		static Delegate cb_getColorMode;
#pragma warning disable 0169
		static Delegate GetGetColorModeHandler ()
		{
			if (cb_getColorMode == null)
				cb_getColorMode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetColorMode);
			return cb_getColorMode;
		}

		static IntPtr n_GetColorMode (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Contrib.Ocr.OcrPlugin __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.Ocr.OcrPlugin> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ColorMode);
		}
#pragma warning restore 0169

		static IntPtr id_getColorMode;
		public virtual unsafe global::Org.Neuroph.Contrib.Imgrec.ColorMode ColorMode {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.contrib.ocr']/class[@name='OcrPlugin']/method[@name='getColorMode' and count(parameter)=0]"
			[Register ("getColorMode", "()Lorg/neuroph/contrib/imgrec/ColorMode;", "GetGetColorModeHandler")]
			get {
				if (id_getColorMode == IntPtr.Zero)
					id_getColorMode = JNIEnv.GetMethodID (class_ref, "getColorMode", "()Lorg/neuroph/contrib/imgrec/ColorMode;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.Imgrec.ColorMode> (JNIEnv.CallObjectMethod  (Handle, id_getColorMode), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.Imgrec.ColorMode> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getColorMode", "()Lorg/neuroph/contrib/imgrec/ColorMode;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSamplingResolution;
#pragma warning disable 0169
		static Delegate GetGetSamplingResolutionHandler ()
		{
			if (cb_getSamplingResolution == null)
				cb_getSamplingResolution = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSamplingResolution);
			return cb_getSamplingResolution;
		}

		static IntPtr n_GetSamplingResolution (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Contrib.Ocr.OcrPlugin __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.Ocr.OcrPlugin> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SamplingResolution);
		}
#pragma warning restore 0169

		static IntPtr id_getSamplingResolution;
		public virtual unsafe global::Org.Neuroph.Contrib.Imgrec.Image.Dimension SamplingResolution {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.contrib.ocr']/class[@name='OcrPlugin']/method[@name='getSamplingResolution' and count(parameter)=0]"
			[Register ("getSamplingResolution", "()Lorg/neuroph/contrib/imgrec/image/Dimension;", "GetGetSamplingResolutionHandler")]
			get {
				if (id_getSamplingResolution == IntPtr.Zero)
					id_getSamplingResolution = JNIEnv.GetMethodID (class_ref, "getSamplingResolution", "()Lorg/neuroph/contrib/imgrec/image/Dimension;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.Imgrec.Image.Dimension> (JNIEnv.CallObjectMethod  (Handle, id_getSamplingResolution), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.Imgrec.Image.Dimension> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSamplingResolution", "()Lorg/neuroph/contrib/imgrec/image/Dimension;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_recognizeCharacter_Lorg_neuroph_contrib_imgrec_image_Image_;
#pragma warning disable 0169
		static Delegate GetRecognizeCharacter_Lorg_neuroph_contrib_imgrec_image_Image_Handler ()
		{
			if (cb_recognizeCharacter_Lorg_neuroph_contrib_imgrec_image_Image_ == null)
				cb_recognizeCharacter_Lorg_neuroph_contrib_imgrec_image_Image_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_RecognizeCharacter_Lorg_neuroph_contrib_imgrec_image_Image_);
			return cb_recognizeCharacter_Lorg_neuroph_contrib_imgrec_image_Image_;
		}

		static IntPtr n_RecognizeCharacter_Lorg_neuroph_contrib_imgrec_image_Image_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Contrib.Ocr.OcrPlugin __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.Ocr.OcrPlugin> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Contrib.Imgrec.Image.IImage p0 = (global::Org.Neuroph.Contrib.Imgrec.Image.IImage)global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.Imgrec.Image.IImage> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.RecognizeCharacter (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_recognizeCharacter_Lorg_neuroph_contrib_imgrec_image_Image_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.contrib.ocr']/class[@name='OcrPlugin']/method[@name='recognizeCharacter' and count(parameter)=1 and parameter[1][@type='org.neuroph.contrib.imgrec.image.Image']]"
		[Register ("recognizeCharacter", "(Lorg/neuroph/contrib/imgrec/image/Image;)Ljava/lang/Character;", "GetRecognizeCharacter_Lorg_neuroph_contrib_imgrec_image_Image_Handler")]
		public virtual unsafe global::Java.Lang.Character RecognizeCharacter (global::Org.Neuroph.Contrib.Imgrec.Image.IImage p0)
		{
			if (id_recognizeCharacter_Lorg_neuroph_contrib_imgrec_image_Image_ == IntPtr.Zero)
				id_recognizeCharacter_Lorg_neuroph_contrib_imgrec_image_Image_ = JNIEnv.GetMethodID (class_ref, "recognizeCharacter", "(Lorg/neuroph/contrib/imgrec/image/Image;)Ljava/lang/Character;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Java.Lang.Character __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Character> (JNIEnv.CallObjectMethod  (Handle, id_recognizeCharacter_Lorg_neuroph_contrib_imgrec_image_Image_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Character> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "recognizeCharacter", "(Lorg/neuroph/contrib/imgrec/image/Image;)Ljava/lang/Character;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_recognizeCharacter_Lorg_neuroph_contrib_imgrec_image_Image_Lorg_neuroph_contrib_imgrec_image_Dimension_;
#pragma warning disable 0169
		static Delegate GetRecognizeCharacter_Lorg_neuroph_contrib_imgrec_image_Image_Lorg_neuroph_contrib_imgrec_image_Dimension_Handler ()
		{
			if (cb_recognizeCharacter_Lorg_neuroph_contrib_imgrec_image_Image_Lorg_neuroph_contrib_imgrec_image_Dimension_ == null)
				cb_recognizeCharacter_Lorg_neuroph_contrib_imgrec_image_Image_Lorg_neuroph_contrib_imgrec_image_Dimension_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_RecognizeCharacter_Lorg_neuroph_contrib_imgrec_image_Image_Lorg_neuroph_contrib_imgrec_image_Dimension_);
			return cb_recognizeCharacter_Lorg_neuroph_contrib_imgrec_image_Image_Lorg_neuroph_contrib_imgrec_image_Dimension_;
		}

		static IntPtr n_RecognizeCharacter_Lorg_neuroph_contrib_imgrec_image_Image_Lorg_neuroph_contrib_imgrec_image_Dimension_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Neuroph.Contrib.Ocr.OcrPlugin __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.Ocr.OcrPlugin> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Contrib.Imgrec.Image.IImage p0 = (global::Org.Neuroph.Contrib.Imgrec.Image.IImage)global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.Imgrec.Image.IImage> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Contrib.Imgrec.Image.Dimension p1 = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.Imgrec.Image.Dimension> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.RecognizeCharacter (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_recognizeCharacter_Lorg_neuroph_contrib_imgrec_image_Image_Lorg_neuroph_contrib_imgrec_image_Dimension_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.contrib.ocr']/class[@name='OcrPlugin']/method[@name='recognizeCharacter' and count(parameter)=2 and parameter[1][@type='org.neuroph.contrib.imgrec.image.Image'] and parameter[2][@type='org.neuroph.contrib.imgrec.image.Dimension']]"
		[Register ("recognizeCharacter", "(Lorg/neuroph/contrib/imgrec/image/Image;Lorg/neuroph/contrib/imgrec/image/Dimension;)Ljava/lang/Character;", "GetRecognizeCharacter_Lorg_neuroph_contrib_imgrec_image_Image_Lorg_neuroph_contrib_imgrec_image_Dimension_Handler")]
		public virtual unsafe global::Java.Lang.Character RecognizeCharacter (global::Org.Neuroph.Contrib.Imgrec.Image.IImage p0, global::Org.Neuroph.Contrib.Imgrec.Image.Dimension p1)
		{
			if (id_recognizeCharacter_Lorg_neuroph_contrib_imgrec_image_Image_Lorg_neuroph_contrib_imgrec_image_Dimension_ == IntPtr.Zero)
				id_recognizeCharacter_Lorg_neuroph_contrib_imgrec_image_Image_Lorg_neuroph_contrib_imgrec_image_Dimension_ = JNIEnv.GetMethodID (class_ref, "recognizeCharacter", "(Lorg/neuroph/contrib/imgrec/image/Image;Lorg/neuroph/contrib/imgrec/image/Dimension;)Ljava/lang/Character;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Java.Lang.Character __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Character> (JNIEnv.CallObjectMethod  (Handle, id_recognizeCharacter_Lorg_neuroph_contrib_imgrec_image_Image_Lorg_neuroph_contrib_imgrec_image_Dimension_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Character> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "recognizeCharacter", "(Lorg/neuroph/contrib/imgrec/image/Image;Lorg/neuroph/contrib/imgrec/image/Dimension;)Ljava/lang/Character;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_recognizeCharacterProbabilities_Lorg_neuroph_contrib_imgrec_image_Image_;
#pragma warning disable 0169
		static Delegate GetRecognizeCharacterProbabilities_Lorg_neuroph_contrib_imgrec_image_Image_Handler ()
		{
			if (cb_recognizeCharacterProbabilities_Lorg_neuroph_contrib_imgrec_image_Image_ == null)
				cb_recognizeCharacterProbabilities_Lorg_neuroph_contrib_imgrec_image_Image_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_RecognizeCharacterProbabilities_Lorg_neuroph_contrib_imgrec_image_Image_);
			return cb_recognizeCharacterProbabilities_Lorg_neuroph_contrib_imgrec_image_Image_;
		}

		static IntPtr n_RecognizeCharacterProbabilities_Lorg_neuroph_contrib_imgrec_image_Image_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Contrib.Ocr.OcrPlugin __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.Ocr.OcrPlugin> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Contrib.Imgrec.Image.IImage p0 = (global::Org.Neuroph.Contrib.Imgrec.Image.IImage)global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.Imgrec.Image.IImage> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (__this.RecognizeCharacterProbabilities (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_recognizeCharacterProbabilities_Lorg_neuroph_contrib_imgrec_image_Image_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.contrib.ocr']/class[@name='OcrPlugin']/method[@name='recognizeCharacterProbabilities' and count(parameter)=1 and parameter[1][@type='org.neuroph.contrib.imgrec.image.Image']]"
		[Register ("recognizeCharacterProbabilities", "(Lorg/neuroph/contrib/imgrec/image/Image;)Ljava/util/HashMap;", "GetRecognizeCharacterProbabilities_Lorg_neuroph_contrib_imgrec_image_Image_Handler")]
		public virtual unsafe global::System.Collections.IDictionary RecognizeCharacterProbabilities (global::Org.Neuroph.Contrib.Imgrec.Image.IImage p0)
		{
			if (id_recognizeCharacterProbabilities_Lorg_neuroph_contrib_imgrec_image_Image_ == IntPtr.Zero)
				id_recognizeCharacterProbabilities_Lorg_neuroph_contrib_imgrec_image_Image_ = JNIEnv.GetMethodID (class_ref, "recognizeCharacterProbabilities", "(Lorg/neuroph/contrib/imgrec/image/Image;)Ljava/util/HashMap;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::System.Collections.IDictionary __ret;
				if (GetType () == ThresholdType)
					__ret = global::Android.Runtime.JavaDictionary.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_recognizeCharacterProbabilities_Lorg_neuroph_contrib_imgrec_image_Image_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.JavaDictionary.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "recognizeCharacterProbabilities", "(Lorg/neuroph/contrib/imgrec/image/Image;)Ljava/util/HashMap;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
