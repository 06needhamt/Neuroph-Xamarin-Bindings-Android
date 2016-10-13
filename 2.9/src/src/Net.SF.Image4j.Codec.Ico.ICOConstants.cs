using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Net.SF.Image4j.Codec.Ico {

	// Metadata.xml XPath class reference: path="/api/package[@name='net.sf.image4j.codec.ico']/class[@name='ICOConstants']"
	[global::Android.Runtime.Register ("net/sf/image4j/codec/ico/ICOConstants", DoNotGenerateAcw=true)]
	public partial class ICOConstants : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='net.sf.image4j.codec.ico']/class[@name='ICOConstants']/field[@name='TYPE_CURSOR']"
		[Register ("TYPE_CURSOR")]
		public const int TypeCursor = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='net.sf.image4j.codec.ico']/class[@name='ICOConstants']/field[@name='TYPE_ICON']"
		[Register ("TYPE_ICON")]
		public const int TypeIcon = (int) 1;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("net/sf/image4j/codec/ico/ICOConstants", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ICOConstants); }
		}

		protected ICOConstants (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='net.sf.image4j.codec.ico']/class[@name='ICOConstants']/constructor[@name='ICOConstants' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ICOConstants ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ICOConstants)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

	}
}
