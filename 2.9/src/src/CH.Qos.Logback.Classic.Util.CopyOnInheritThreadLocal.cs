using System;
using System.Collections.Generic;
using Android.Runtime;

namespace CH.Qos.Logback.Classic.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='ch.qos.logback.classic.util']/class[@name='CopyOnInheritThreadLocal']"
	[global::Android.Runtime.Register ("ch/qos/logback/classic/util/CopyOnInheritThreadLocal", DoNotGenerateAcw=true)]
	public partial class CopyOnInheritThreadLocal : global::Java.Lang.InheritableThreadLocal {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("ch/qos/logback/classic/util/CopyOnInheritThreadLocal", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CopyOnInheritThreadLocal); }
		}

		protected CopyOnInheritThreadLocal (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='ch.qos.logback.classic.util']/class[@name='CopyOnInheritThreadLocal']/constructor[@name='CopyOnInheritThreadLocal' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CopyOnInheritThreadLocal ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (CopyOnInheritThreadLocal)) {
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

		static Delegate cb_childValue_Ljava_util_HashMap_;
#pragma warning disable 0169
		static Delegate GetChildValue_Ljava_util_HashMap_Handler ()
		{
			if (cb_childValue_Ljava_util_HashMap_ == null)
				cb_childValue_Ljava_util_HashMap_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ChildValue_Ljava_util_HashMap_);
			return cb_childValue_Ljava_util_HashMap_;
		}

		static IntPtr n_ChildValue_Ljava_util_HashMap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CH.Qos.Logback.Classic.Util.CopyOnInheritThreadLocal __this = global::Java.Lang.Object.GetObject<global::CH.Qos.Logback.Classic.Util.CopyOnInheritThreadLocal> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.ChildValue (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_childValue_Ljava_util_HashMap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ch.qos.logback.classic.util']/class[@name='CopyOnInheritThreadLocal']/method[@name='childValue' and count(parameter)=1 and parameter[1][@type='java.util.HashMap&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("childValue", "(Ljava/util/HashMap;)Ljava/util/HashMap;", "GetChildValue_Ljava_util_HashMap_Handler")]
		protected virtual unsafe global::System.Collections.Generic.IDictionary<string, string> ChildValue (global::System.Collections.Generic.IDictionary<string, string> p0)
		{
			if (id_childValue_Ljava_util_HashMap_ == IntPtr.Zero)
				id_childValue_Ljava_util_HashMap_ = JNIEnv.GetMethodID (class_ref, "childValue", "(Ljava/util/HashMap;)Ljava/util/HashMap;");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::System.Collections.Generic.IDictionary<string, string> __ret;
				if (GetType () == ThresholdType)
					__ret = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_childValue_Ljava_util_HashMap_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "childValue", "(Ljava/util/HashMap;)Ljava/util/HashMap;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
