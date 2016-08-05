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

	}
}
