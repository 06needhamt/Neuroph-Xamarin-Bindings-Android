using System;
using System.Collections.Generic;
using Android.Runtime;

namespace BE.Abeel.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='be.abeel.util']/class[@name='DefaultHashMap2D']"
	[global::Android.Runtime.Register ("be/abeel/util/DefaultHashMap2D", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"K", "L", "V"})]
	public partial class DefaultHashMap2D : global::BE.Abeel.Util.HashMap2D {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("be/abeel/util/DefaultHashMap2D", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DefaultHashMap2D); }
		}

		protected DefaultHashMap2D (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_Object_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='be.abeel.util']/class[@name='DefaultHashMap2D']/constructor[@name='DefaultHashMap2D' and count(parameter)=1 and parameter[1][@type='V']]"
		[Register (".ctor", "(Ljava/lang/Object;)V", "")]
		public unsafe DefaultHashMap2D (global::Java.Lang.Object p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (DefaultHashMap2D)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/Object;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/Object;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_Object_ == IntPtr.Zero)
					id_ctor_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Object;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Object_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getDefault;
#pragma warning disable 0169
		static Delegate GetGetDefaultHandler ()
		{
			if (cb_getDefault == null)
				cb_getDefault = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDefault);
			return cb_getDefault;
		}

		static IntPtr n_GetDefault (IntPtr jnienv, IntPtr native__this)
		{
			global::BE.Abeel.Util.DefaultHashMap2D __this = global::Java.Lang.Object.GetObject<global::BE.Abeel.Util.DefaultHashMap2D> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Default);
		}
#pragma warning restore 0169

		static IntPtr id_getDefault;
		public virtual unsafe global::Java.Lang.Object Default {
			// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.util']/class[@name='DefaultHashMap2D']/method[@name='getDefault' and count(parameter)=0]"
			[Register ("getDefault", "()Ljava/lang/Object;", "GetGetDefaultHandler")]
			get {
				if (id_getDefault == IntPtr.Zero)
					id_getDefault = JNIEnv.GetMethodID (class_ref, "getDefault", "()Ljava/lang/Object;");
				try {

					if (GetType () == ThresholdType)
						return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDefault), JniHandleOwnership.TransferLocalRef);
					else
						return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDefault", "()Ljava/lang/Object;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
