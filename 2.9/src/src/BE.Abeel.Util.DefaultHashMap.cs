using System;
using System.Collections.Generic;
using Android.Runtime;

namespace BE.Abeel.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='be.abeel.util']/class[@name='DefaultHashMap']"
	[global::Android.Runtime.Register ("be/abeel/util/DefaultHashMap", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"K", "V"})]
	public partial class DefaultHashMap : global::Java.Util.HashMap {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("be/abeel/util/DefaultHashMap", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DefaultHashMap); }
		}

		protected DefaultHashMap (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_Object_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='be.abeel.util']/class[@name='DefaultHashMap']/constructor[@name='DefaultHashMap' and count(parameter)=1 and parameter[1][@type='V']]"
		[Register (".ctor", "(Ljava/lang/Object;)V", "")]
		public unsafe DefaultHashMap (global::Java.Lang.Object p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (DefaultHashMap)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/Object;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/Object;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_Object_ == IntPtr.Zero)
					id_ctor_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Object;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Object_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
