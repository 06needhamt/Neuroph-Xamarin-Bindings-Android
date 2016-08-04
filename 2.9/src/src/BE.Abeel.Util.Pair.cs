using System;
using System.Collections.Generic;
using Android.Runtime;

namespace BE.Abeel.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='be.abeel.util']/class[@name='Pair']"
	[global::Android.Runtime.Register ("be/abeel/util/Pair", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"S", "T"})]
	public partial class Pair : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("be/abeel/util/Pair", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Pair); }
		}

		protected Pair (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_Object_Ljava_lang_Object_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='be.abeel.util']/class[@name='Pair']/constructor[@name='Pair' and count(parameter)=2 and parameter[1][@type='S'] and parameter[2][@type='T']]"
		[Register (".ctor", "(Ljava/lang/Object;Ljava/lang/Object;)V", "")]
		public unsafe Pair (global::Java.Lang.Object p0, global::Java.Lang.Object p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				if (GetType () != typeof (Pair)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/Object;Ljava/lang/Object;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/Object;Ljava/lang/Object;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
					id_ctor_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Object;Ljava/lang/Object;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Object_Ljava_lang_Object_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_Object_Ljava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_x;
#pragma warning disable 0169
		static Delegate GetXHandler ()
		{
			if (cb_x == null)
				cb_x = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_X);
			return cb_x;
		}

		static IntPtr n_X (IntPtr jnienv, IntPtr native__this)
		{
			global::BE.Abeel.Util.Pair __this = global::Java.Lang.Object.GetObject<global::BE.Abeel.Util.Pair> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.X ());
		}
#pragma warning restore 0169

		static IntPtr id_x;
		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.util']/class[@name='Pair']/method[@name='x' and count(parameter)=0]"
		[Register ("x", "()Ljava/lang/Object;", "GetXHandler")]
		public virtual unsafe global::Java.Lang.Object X ()
		{
			if (id_x == IntPtr.Zero)
				id_x = JNIEnv.GetMethodID (class_ref, "x", "()Ljava/lang/Object;");
			try {

				if (GetType () == ThresholdType)
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_x), JniHandleOwnership.TransferLocalRef);
				else
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "x", "()Ljava/lang/Object;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_y;
#pragma warning disable 0169
		static Delegate GetYHandler ()
		{
			if (cb_y == null)
				cb_y = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Y);
			return cb_y;
		}

		static IntPtr n_Y (IntPtr jnienv, IntPtr native__this)
		{
			global::BE.Abeel.Util.Pair __this = global::Java.Lang.Object.GetObject<global::BE.Abeel.Util.Pair> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Y ());
		}
#pragma warning restore 0169

		static IntPtr id_y;
		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.util']/class[@name='Pair']/method[@name='y' and count(parameter)=0]"
		[Register ("y", "()Ljava/lang/Object;", "GetYHandler")]
		public virtual unsafe global::Java.Lang.Object Y ()
		{
			if (id_y == IntPtr.Zero)
				id_y = JNIEnv.GetMethodID (class_ref, "y", "()Ljava/lang/Object;");
			try {

				if (GetType () == ThresholdType)
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_y), JniHandleOwnership.TransferLocalRef);
				else
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "y", "()Ljava/lang/Object;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
