using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Encog.Engine.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.encog.engine.util']/class[@name='ObjectPair']"
	[global::Android.Runtime.Register ("org/encog/engine/util/ObjectPair", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"A", "B"})]
	public partial class ObjectPair : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/encog/engine/util/ObjectPair", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ObjectPair); }
		}

		protected ObjectPair (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_Object_Ljava_lang_Object_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.encog.engine.util']/class[@name='ObjectPair']/constructor[@name='ObjectPair' and count(parameter)=2 and parameter[1][@type='A'] and parameter[2][@type='B']]"
		[Register (".ctor", "(Ljava/lang/Object;Ljava/lang/Object;)V", "")]
		public unsafe ObjectPair (global::Java.Lang.Object p0, global::Java.Lang.Object p1)
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
				if (GetType () != typeof (ObjectPair)) {
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

		static Delegate cb_getA;
#pragma warning disable 0169
		static Delegate GetGetAHandler ()
		{
			if (cb_getA == null)
				cb_getA = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetA);
			return cb_getA;
		}

		static IntPtr n_GetA (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Util.ObjectPair __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Util.ObjectPair> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetA ());
		}
#pragma warning restore 0169

		static IntPtr id_getA;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.util']/class[@name='ObjectPair']/method[@name='getA' and count(parameter)=0]"
		[Register ("getA", "()Ljava/lang/Object;", "GetGetAHandler")]
		public virtual unsafe global::Java.Lang.Object GetA ()
		{
			if (id_getA == IntPtr.Zero)
				id_getA = JNIEnv.GetMethodID (class_ref, "getA", "()Ljava/lang/Object;");
			try {

				if (GetType () == ThresholdType)
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_getA), JniHandleOwnership.TransferLocalRef);
				else
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getA", "()Ljava/lang/Object;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getB;
#pragma warning disable 0169
		static Delegate GetGetBHandler ()
		{
			if (cb_getB == null)
				cb_getB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetB);
			return cb_getB;
		}

		static IntPtr n_GetB (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Util.ObjectPair __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Util.ObjectPair> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetB ());
		}
#pragma warning restore 0169

		static IntPtr id_getB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.util']/class[@name='ObjectPair']/method[@name='getB' and count(parameter)=0]"
		[Register ("getB", "()Ljava/lang/Object;", "GetGetBHandler")]
		public virtual unsafe global::Java.Lang.Object GetB ()
		{
			if (id_getB == IntPtr.Zero)
				id_getB = JNIEnv.GetMethodID (class_ref, "getB", "()Ljava/lang/Object;");
			try {

				if (GetType () == ThresholdType)
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_getB), JniHandleOwnership.TransferLocalRef);
				else
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getB", "()Ljava/lang/Object;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
