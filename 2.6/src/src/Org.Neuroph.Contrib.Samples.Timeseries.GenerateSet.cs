using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Contrib.Samples.Timeseries {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.contrib.samples.timeseries']/class[@name='GenerateSet']"
	[global::Android.Runtime.Register ("org/neuroph/contrib/samples/timeseries/GenerateSet", DoNotGenerateAcw=true)]
	public partial class GenerateSet : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/contrib/samples/timeseries/GenerateSet", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GenerateSet); }
		}

		protected GenerateSet (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_ZII;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.contrib.samples.timeseries']/class[@name='GenerateSet']/constructor[@name='GenerateSet' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register (".ctor", "(Ljava/lang/String;ZII)V", "")]
		public unsafe GenerateSet (string p0, bool p1, int p2, int p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				if (GetType () != typeof (GenerateSet)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;ZII)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;ZII)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_ZII == IntPtr.Zero)
					id_ctor_Ljava_lang_String_ZII = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;ZII)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_ZII, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_ZII, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_doIt;
#pragma warning disable 0169
		static Delegate GetDoItHandler ()
		{
			if (cb_doIt == null)
				cb_doIt = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DoIt);
			return cb_doIt;
		}

		static void n_DoIt (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Contrib.Samples.Timeseries.GenerateSet __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.Samples.Timeseries.GenerateSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DoIt ();
		}
#pragma warning restore 0169

		static IntPtr id_doIt;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.contrib.samples.timeseries']/class[@name='GenerateSet']/method[@name='doIt' and count(parameter)=0]"
		[Register ("doIt", "()V", "GetDoItHandler")]
		public virtual unsafe void DoIt ()
		{
			if (id_doIt == IntPtr.Zero)
				id_doIt = JNIEnv.GetMethodID (class_ref, "doIt", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_doIt);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "doIt", "()V"));
			} finally {
			}
		}

	}
}
