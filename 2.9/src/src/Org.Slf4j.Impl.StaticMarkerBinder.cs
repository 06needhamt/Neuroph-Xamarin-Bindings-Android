using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Slf4j.Impl {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.slf4j.impl']/class[@name='StaticMarkerBinder']"
	[global::Android.Runtime.Register ("org/slf4j/impl/StaticMarkerBinder", DoNotGenerateAcw=true)]
	public partial class StaticMarkerBinder : global::Java.Lang.Object {


		static IntPtr SINGLETON_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.slf4j.impl']/class[@name='StaticMarkerBinder']/field[@name='SINGLETON']"
		[Register ("SINGLETON")]
		public static global::Org.Slf4j.Impl.StaticMarkerBinder Singleton {
			get {
				if (SINGLETON_jfieldId == IntPtr.Zero)
					SINGLETON_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SINGLETON", "Lorg/slf4j/impl/StaticMarkerBinder;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SINGLETON_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Slf4j.Impl.StaticMarkerBinder> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/slf4j/impl/StaticMarkerBinder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (StaticMarkerBinder); }
		}

		protected StaticMarkerBinder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getMarkerFactoryClassStr;
#pragma warning disable 0169
		static Delegate GetGetMarkerFactoryClassStrHandler ()
		{
			if (cb_getMarkerFactoryClassStr == null)
				cb_getMarkerFactoryClassStr = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMarkerFactoryClassStr);
			return cb_getMarkerFactoryClassStr;
		}

		static IntPtr n_GetMarkerFactoryClassStr (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Slf4j.Impl.StaticMarkerBinder __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Impl.StaticMarkerBinder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MarkerFactoryClassStr);
		}
#pragma warning restore 0169

		static IntPtr id_getMarkerFactoryClassStr;
		public virtual unsafe string MarkerFactoryClassStr {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.impl']/class[@name='StaticMarkerBinder']/method[@name='getMarkerFactoryClassStr' and count(parameter)=0]"
			[Register ("getMarkerFactoryClassStr", "()Ljava/lang/String;", "GetGetMarkerFactoryClassStrHandler")]
			get {
				if (id_getMarkerFactoryClassStr == IntPtr.Zero)
					id_getMarkerFactoryClassStr = JNIEnv.GetMethodID (class_ref, "getMarkerFactoryClassStr", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getMarkerFactoryClassStr), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMarkerFactoryClassStr", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
