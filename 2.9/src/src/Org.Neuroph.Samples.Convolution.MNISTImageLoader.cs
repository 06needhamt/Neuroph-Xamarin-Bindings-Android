using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Samples.Convolution {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.samples.convolution']/class[@name='MNISTImageLoader']"
	[global::Android.Runtime.Register ("org/neuroph/samples/convolution/MNISTImageLoader", DoNotGenerateAcw=true)]
	public partial class MNISTImageLoader : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.neuroph.samples.convolution']/class[@name='MNISTImageLoader']/field[@name='COLUMNS']"
		[Register ("COLUMNS")]
		public const int Columns = (int) 28;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.neuroph.samples.convolution']/class[@name='MNISTImageLoader']/field[@name='ROWS']"
		[Register ("ROWS")]
		public const int Rows = (int) 28;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/samples/convolution/MNISTImageLoader", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MNISTImageLoader); }
		}

		protected MNISTImageLoader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.samples.convolution']/class[@name='MNISTImageLoader']/constructor[@name='MNISTImageLoader' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe MNISTImageLoader (string p0, string p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				if (GetType () != typeof (MNISTImageLoader)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_loadDigitImages;
#pragma warning disable 0169
		static Delegate GetLoadDigitImagesHandler ()
		{
			if (cb_loadDigitImages == null)
				cb_loadDigitImages = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_LoadDigitImages);
			return cb_loadDigitImages;
		}

		static IntPtr n_LoadDigitImages (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Samples.Convolution.MNISTImageLoader __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Samples.Convolution.MNISTImageLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Org.Neuroph.Samples.Convolution.MNISTImage>.ToLocalJniHandle (__this.LoadDigitImages ());
		}
#pragma warning restore 0169

		static IntPtr id_loadDigitImages;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.samples.convolution']/class[@name='MNISTImageLoader']/method[@name='loadDigitImages' and count(parameter)=0]"
		[Register ("loadDigitImages", "()Ljava/util/List;", "GetLoadDigitImagesHandler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Org.Neuroph.Samples.Convolution.MNISTImage> LoadDigitImages ()
		{
			if (id_loadDigitImages == IntPtr.Zero)
				id_loadDigitImages = JNIEnv.GetMethodID (class_ref, "loadDigitImages", "()Ljava/util/List;");
			try {

				if (GetType () == ThresholdType)
					return global::Android.Runtime.JavaList<global::Org.Neuroph.Samples.Convolution.MNISTImage>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_loadDigitImages), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaList<global::Org.Neuroph.Samples.Convolution.MNISTImage>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "loadDigitImages", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
