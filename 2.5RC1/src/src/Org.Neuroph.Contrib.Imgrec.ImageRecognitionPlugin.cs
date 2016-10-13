using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Contrib.Imgrec {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.contrib.imgrec']/class[@name='ImageRecognitionPlugin']"
	[global::Android.Runtime.Register ("org/neuroph/contrib/imgrec/ImageRecognitionPlugin", DoNotGenerateAcw=true)]
	public partial class ImageRecognitionPlugin : global::Org.Neuroph.Util.Plugins.PluginBase, global::Java.IO.ISerializable {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.neuroph.contrib.imgrec']/class[@name='ImageRecognitionPlugin']/field[@name='IMG_REC_PLUGIN_NAME']"
		[Register ("IMG_REC_PLUGIN_NAME")]
		public const string ImgRecPluginName = (string) "Image Recognition Plugin";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/contrib/imgrec/ImageRecognitionPlugin", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ImageRecognitionPlugin); }
		}

		protected ImageRecognitionPlugin (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

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
			global::Org.Neuroph.Contrib.Imgrec.ImageRecognitionPlugin __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.Imgrec.ImageRecognitionPlugin> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ColorMode);
		}
#pragma warning restore 0169

		static IntPtr id_getColorMode;
		public virtual unsafe global::Org.Neuroph.Contrib.Imgrec.ColorMode ColorMode {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.contrib.imgrec']/class[@name='ImageRecognitionPlugin']/method[@name='getColorMode' and count(parameter)=0]"
			[Register ("getColorMode", "()Lorg/neuroph/contrib/imgrec/ColorMode;", "GetGetColorModeHandler")]
			get {
				if (id_getColorMode == IntPtr.Zero)
					id_getColorMode = JNIEnv.GetMethodID (class_ref, "getColorMode", "()Lorg/neuroph/contrib/imgrec/ColorMode;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.Imgrec.ColorMode> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getColorMode), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.Imgrec.ColorMode> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getColorMode", "()Lorg/neuroph/contrib/imgrec/ColorMode;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMaxOutput;
#pragma warning disable 0169
		static Delegate GetGetMaxOutputHandler ()
		{
			if (cb_getMaxOutput == null)
				cb_getMaxOutput = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMaxOutput);
			return cb_getMaxOutput;
		}

		static IntPtr n_GetMaxOutput (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Contrib.Imgrec.ImageRecognitionPlugin __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.Imgrec.ImageRecognitionPlugin> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, global::Org.Neuroph.Core.Neuron>.ToLocalJniHandle (__this.MaxOutput);
		}
#pragma warning restore 0169

		static IntPtr id_getMaxOutput;
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, global::Org.Neuroph.Core.Neuron> MaxOutput {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.contrib.imgrec']/class[@name='ImageRecognitionPlugin']/method[@name='getMaxOutput' and count(parameter)=0]"
			[Register ("getMaxOutput", "()Ljava/util/HashMap;", "GetGetMaxOutputHandler")]
			get {
				if (id_getMaxOutput == IntPtr.Zero)
					id_getMaxOutput = JNIEnv.GetMethodID (class_ref, "getMaxOutput", "()Ljava/util/HashMap;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaDictionary<string, global::Org.Neuroph.Core.Neuron>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMaxOutput), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaDictionary<string, global::Org.Neuroph.Core.Neuron>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMaxOutput", "()Ljava/util/HashMap;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getOutput;
#pragma warning disable 0169
		static Delegate GetGetOutputHandler ()
		{
			if (cb_getOutput == null)
				cb_getOutput = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOutput);
			return cb_getOutput;
		}

		static IntPtr n_GetOutput (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Contrib.Imgrec.ImageRecognitionPlugin __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.Imgrec.ImageRecognitionPlugin> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Double>.ToLocalJniHandle (__this.Output);
		}
#pragma warning restore 0169

		static IntPtr id_getOutput;
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Double> Output {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.contrib.imgrec']/class[@name='ImageRecognitionPlugin']/method[@name='getOutput' and count(parameter)=0]"
			[Register ("getOutput", "()Ljava/util/HashMap;", "GetGetOutputHandler")]
			get {
				if (id_getOutput == IntPtr.Zero)
					id_getOutput = JNIEnv.GetMethodID (class_ref, "getOutput", "()Ljava/util/HashMap;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Double>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOutput), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Double>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOutput", "()Ljava/util/HashMap;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_processInput;
#pragma warning disable 0169
		static Delegate GetProcessInputHandler ()
		{
			if (cb_processInput == null)
				cb_processInput = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ProcessInput);
			return cb_processInput;
		}

		static void n_ProcessInput (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Contrib.Imgrec.ImageRecognitionPlugin __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.Imgrec.ImageRecognitionPlugin> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ProcessInput ();
		}
#pragma warning restore 0169

		static IntPtr id_processInput;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.contrib.imgrec']/class[@name='ImageRecognitionPlugin']/method[@name='processInput' and count(parameter)=0]"
		[Register ("processInput", "()V", "GetProcessInputHandler")]
		public virtual unsafe void ProcessInput ()
		{
			if (id_processInput == IntPtr.Zero)
				id_processInput = JNIEnv.GetMethodID (class_ref, "processInput", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_processInput);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "processInput", "()V"));
			} finally {
			}
		}

		static Delegate cb_recognizeImage_Ljava_io_File_;
#pragma warning disable 0169
		static Delegate GetRecognizeImage_Ljava_io_File_Handler ()
		{
			if (cb_recognizeImage_Ljava_io_File_ == null)
				cb_recognizeImage_Ljava_io_File_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_RecognizeImage_Ljava_io_File_);
			return cb_recognizeImage_Ljava_io_File_;
		}

		static IntPtr n_RecognizeImage_Ljava_io_File_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Contrib.Imgrec.ImageRecognitionPlugin __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.Imgrec.ImageRecognitionPlugin> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.File p0 = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Double>.ToLocalJniHandle (__this.RecognizeImage (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_recognizeImage_Ljava_io_File_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.contrib.imgrec']/class[@name='ImageRecognitionPlugin']/method[@name='recognizeImage' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("recognizeImage", "(Ljava/io/File;)Ljava/util/HashMap;", "GetRecognizeImage_Ljava_io_File_Handler")]
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Double> RecognizeImage (global::Java.IO.File p0)
		{
			if (id_recognizeImage_Ljava_io_File_ == IntPtr.Zero)
				id_recognizeImage_Ljava_io_File_ = JNIEnv.GetMethodID (class_ref, "recognizeImage", "(Ljava/io/File;)Ljava/util/HashMap;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Double> __ret;
				if (GetType () == ThresholdType)
					__ret = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Double>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_recognizeImage_Ljava_io_File_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Double>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "recognizeImage", "(Ljava/io/File;)Ljava/util/HashMap;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_recognizeImage_Ljava_net_URL_;
#pragma warning disable 0169
		static Delegate GetRecognizeImage_Ljava_net_URL_Handler ()
		{
			if (cb_recognizeImage_Ljava_net_URL_ == null)
				cb_recognizeImage_Ljava_net_URL_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_RecognizeImage_Ljava_net_URL_);
			return cb_recognizeImage_Ljava_net_URL_;
		}

		static IntPtr n_RecognizeImage_Ljava_net_URL_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Contrib.Imgrec.ImageRecognitionPlugin __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.Imgrec.ImageRecognitionPlugin> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Net.URL p0 = global::Java.Lang.Object.GetObject<global::Java.Net.URL> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Double>.ToLocalJniHandle (__this.RecognizeImage (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_recognizeImage_Ljava_net_URL_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.contrib.imgrec']/class[@name='ImageRecognitionPlugin']/method[@name='recognizeImage' and count(parameter)=1 and parameter[1][@type='java.net.URL']]"
		[Register ("recognizeImage", "(Ljava/net/URL;)Ljava/util/HashMap;", "GetRecognizeImage_Ljava_net_URL_Handler")]
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Double> RecognizeImage (global::Java.Net.URL p0)
		{
			if (id_recognizeImage_Ljava_net_URL_ == IntPtr.Zero)
				id_recognizeImage_Ljava_net_URL_ = JNIEnv.GetMethodID (class_ref, "recognizeImage", "(Ljava/net/URL;)Ljava/util/HashMap;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Double> __ret;
				if (GetType () == ThresholdType)
					__ret = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Double>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_recognizeImage_Ljava_net_URL_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Double>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "recognizeImage", "(Ljava/net/URL;)Ljava/util/HashMap;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_setInput_Ljava_io_File_;
#pragma warning disable 0169
		static Delegate GetSetInput_Ljava_io_File_Handler ()
		{
			if (cb_setInput_Ljava_io_File_ == null)
				cb_setInput_Ljava_io_File_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetInput_Ljava_io_File_);
			return cb_setInput_Ljava_io_File_;
		}

		static void n_SetInput_Ljava_io_File_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Contrib.Imgrec.ImageRecognitionPlugin __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.Imgrec.ImageRecognitionPlugin> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.File p0 = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetInput (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setInput_Ljava_io_File_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.contrib.imgrec']/class[@name='ImageRecognitionPlugin']/method[@name='setInput' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("setInput", "(Ljava/io/File;)V", "GetSetInput_Ljava_io_File_Handler")]
		public virtual unsafe void SetInput (global::Java.IO.File p0)
		{
			if (id_setInput_Ljava_io_File_ == IntPtr.Zero)
				id_setInput_Ljava_io_File_ = JNIEnv.GetMethodID (class_ref, "setInput", "(Ljava/io/File;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setInput_Ljava_io_File_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setInput", "(Ljava/io/File;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setInput_Ljava_net_URL_;
#pragma warning disable 0169
		static Delegate GetSetInput_Ljava_net_URL_Handler ()
		{
			if (cb_setInput_Ljava_net_URL_ == null)
				cb_setInput_Ljava_net_URL_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetInput_Ljava_net_URL_);
			return cb_setInput_Ljava_net_URL_;
		}

		static void n_SetInput_Ljava_net_URL_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Contrib.Imgrec.ImageRecognitionPlugin __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.Imgrec.ImageRecognitionPlugin> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Net.URL p0 = global::Java.Lang.Object.GetObject<global::Java.Net.URL> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetInput (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setInput_Ljava_net_URL_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.contrib.imgrec']/class[@name='ImageRecognitionPlugin']/method[@name='setInput' and count(parameter)=1 and parameter[1][@type='java.net.URL']]"
		[Register ("setInput", "(Ljava/net/URL;)V", "GetSetInput_Ljava_net_URL_Handler")]
		public virtual unsafe void SetInput (global::Java.Net.URL p0)
		{
			if (id_setInput_Ljava_net_URL_ == IntPtr.Zero)
				id_setInput_Ljava_net_URL_ = JNIEnv.GetMethodID (class_ref, "setInput", "(Ljava/net/URL;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setInput_Ljava_net_URL_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setInput", "(Ljava/net/URL;)V"), __args);
			} finally {
			}
		}

	}
}
