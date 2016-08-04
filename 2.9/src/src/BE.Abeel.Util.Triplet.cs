using System;
using System.Collections.Generic;
using Android.Runtime;

namespace BE.Abeel.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='be.abeel.util']/class[@name='Triplet']"
	[global::Android.Runtime.Register ("be/abeel/util/Triplet", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"S", "T", "U"})]
	public partial class Triplet : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("be/abeel/util/Triplet", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Triplet); }
		}

		protected Triplet (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='be.abeel.util']/class[@name='Triplet']/constructor[@name='Triplet' and count(parameter)=3 and parameter[1][@type='S'] and parameter[2][@type='T'] and parameter[3][@type='U']]"
		[Register (".ctor", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)V", "")]
		public unsafe Triplet (global::Java.Lang.Object p0, global::Java.Lang.Object p1, global::Java.Lang.Object p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
			IntPtr native_p2 = JNIEnv.ToLocalJniHandle (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				if (GetType () != typeof (Triplet)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
					id_ctor_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
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
			global::BE.Abeel.Util.Triplet __this = global::Java.Lang.Object.GetObject<global::BE.Abeel.Util.Triplet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.X ());
		}
#pragma warning restore 0169

		static IntPtr id_x;
		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.util']/class[@name='Triplet']/method[@name='x' and count(parameter)=0]"
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
			global::BE.Abeel.Util.Triplet __this = global::Java.Lang.Object.GetObject<global::BE.Abeel.Util.Triplet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Y ());
		}
#pragma warning restore 0169

		static IntPtr id_y;
		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.util']/class[@name='Triplet']/method[@name='y' and count(parameter)=0]"
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

		static Delegate cb_z;
#pragma warning disable 0169
		static Delegate GetZHandler ()
		{
			if (cb_z == null)
				cb_z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Z);
			return cb_z;
		}

		static IntPtr n_Z (IntPtr jnienv, IntPtr native__this)
		{
			global::BE.Abeel.Util.Triplet __this = global::Java.Lang.Object.GetObject<global::BE.Abeel.Util.Triplet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Z ());
		}
#pragma warning restore 0169

		static IntPtr id_z;
		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.util']/class[@name='Triplet']/method[@name='z' and count(parameter)=0]"
		[Register ("z", "()Ljava/lang/Object;", "GetZHandler")]
		public virtual unsafe global::Java.Lang.Object Z ()
		{
			if (id_z == IntPtr.Zero)
				id_z = JNIEnv.GetMethodID (class_ref, "z", "()Ljava/lang/Object;");
			try {

				if (GetType () == ThresholdType)
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_z), JniHandleOwnership.TransferLocalRef);
				else
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "z", "()Ljava/lang/Object;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
