using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Slf4j.Impl {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.slf4j.impl']/class[@name='StaticMDCBinder']"
	[global::Android.Runtime.Register ("org/slf4j/impl/StaticMDCBinder", DoNotGenerateAcw=true)]
	public partial class StaticMDCBinder : global::Java.Lang.Object {


		static IntPtr SINGLETON_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.slf4j.impl']/class[@name='StaticMDCBinder']/field[@name='SINGLETON']"
		[Register ("SINGLETON")]
		public static global::Org.Slf4j.Impl.StaticMDCBinder Singleton {
			get {
				if (SINGLETON_jfieldId == IntPtr.Zero)
					SINGLETON_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SINGLETON", "Lorg/slf4j/impl/StaticMDCBinder;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SINGLETON_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Slf4j.Impl.StaticMDCBinder> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/slf4j/impl/StaticMDCBinder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (StaticMDCBinder); }
		}

		protected StaticMDCBinder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getMDCAdapterClassStr;
#pragma warning disable 0169
		static Delegate GetGetMDCAdapterClassStrHandler ()
		{
			if (cb_getMDCAdapterClassStr == null)
				cb_getMDCAdapterClassStr = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMDCAdapterClassStr);
			return cb_getMDCAdapterClassStr;
		}

		static IntPtr n_GetMDCAdapterClassStr (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Slf4j.Impl.StaticMDCBinder __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Impl.StaticMDCBinder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MDCAdapterClassStr);
		}
#pragma warning restore 0169

		static IntPtr id_getMDCAdapterClassStr;
		public virtual unsafe string MDCAdapterClassStr {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.impl']/class[@name='StaticMDCBinder']/method[@name='getMDCAdapterClassStr' and count(parameter)=0]"
			[Register ("getMDCAdapterClassStr", "()Ljava/lang/String;", "GetGetMDCAdapterClassStrHandler")]
			get {
				if (id_getMDCAdapterClassStr == IntPtr.Zero)
					id_getMDCAdapterClassStr = JNIEnv.GetMethodID (class_ref, "getMDCAdapterClassStr", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getMDCAdapterClassStr), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMDCAdapterClassStr", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
