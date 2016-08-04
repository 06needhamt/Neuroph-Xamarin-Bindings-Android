using System;
using System.Collections.Generic;
using Android.Runtime;

namespace BE.Abeel.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='be.abeel.util']/class[@name='CountMap']"
	[global::Android.Runtime.Register ("be/abeel/util/CountMap", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"A"})]
	public partial class CountMap : global::BE.Abeel.Util.DefaultTreeMap {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("be/abeel/util/CountMap", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CountMap); }
		}

		protected CountMap (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='be.abeel.util']/class[@name='CountMap']/constructor[@name='CountMap' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe CountMap (int p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (CountMap)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(I)V", __args);
					return;
				}

				if (id_ctor_I == IntPtr.Zero)
					id_ctor_I = JNIEnv.GetMethodID (class_ref, "<init>", "(I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_I, __args);
			} finally {
			}
		}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='be.abeel.util']/class[@name='CountMap']/constructor[@name='CountMap' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CountMap ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (CountMap)) {
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

		static Delegate cb_copy;
#pragma warning disable 0169
		static Delegate GetCopyHandler ()
		{
			if (cb_copy == null)
				cb_copy = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Copy);
			return cb_copy;
		}

		static IntPtr n_Copy (IntPtr jnienv, IntPtr native__this)
		{
			global::BE.Abeel.Util.CountMap __this = global::Java.Lang.Object.GetObject<global::BE.Abeel.Util.CountMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Copy ());
		}
#pragma warning restore 0169

		static IntPtr id_copy;
		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.util']/class[@name='CountMap']/method[@name='copy' and count(parameter)=0]"
		[Register ("copy", "()Lbe/abeel/util/CountMap;", "GetCopyHandler")]
		public virtual unsafe global::BE.Abeel.Util.CountMap Copy ()
		{
			if (id_copy == IntPtr.Zero)
				id_copy = JNIEnv.GetMethodID (class_ref, "copy", "()Lbe/abeel/util/CountMap;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::BE.Abeel.Util.CountMap> (JNIEnv.CallObjectMethod  (Handle, id_copy), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::BE.Abeel.Util.CountMap> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "copy", "()Lbe/abeel/util/CountMap;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_count_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetCount_Ljava_lang_Object_Handler ()
		{
			if (cb_count_Ljava_lang_Object_ == null)
				cb_count_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Count_Ljava_lang_Object_);
			return cb_count_Ljava_lang_Object_;
		}

		static void n_Count_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BE.Abeel.Util.CountMap __this = global::Java.Lang.Object.GetObject<global::BE.Abeel.Util.CountMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Count (p0);
		}
#pragma warning restore 0169

		static IntPtr id_count_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.util']/class[@name='CountMap']/method[@name='count' and count(parameter)=1 and parameter[1][@type='A']]"
		[Register ("count", "(Ljava/lang/Object;)V", "GetCount_Ljava_lang_Object_Handler")]
		public virtual unsafe void Count (global::Java.Lang.Object p0)
		{
			if (id_count_Ljava_lang_Object_ == IntPtr.Zero)
				id_count_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "count", "(Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_count_Ljava_lang_Object_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "count", "(Ljava/lang/Object;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_count_Ljava_lang_Object_I;
#pragma warning disable 0169
		static Delegate GetCount_Ljava_lang_Object_IHandler ()
		{
			if (cb_count_Ljava_lang_Object_I == null)
				cb_count_Ljava_lang_Object_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_Count_Ljava_lang_Object_I);
			return cb_count_Ljava_lang_Object_I;
		}

		static void n_Count_Ljava_lang_Object_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::BE.Abeel.Util.CountMap __this = global::Java.Lang.Object.GetObject<global::BE.Abeel.Util.CountMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Count (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_count_Ljava_lang_Object_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.util']/class[@name='CountMap']/method[@name='count' and count(parameter)=2 and parameter[1][@type='A'] and parameter[2][@type='int']]"
		[Register ("count", "(Ljava/lang/Object;I)V", "GetCount_Ljava_lang_Object_IHandler")]
		public virtual unsafe void Count (global::Java.Lang.Object p0, int p1)
		{
			if (id_count_Ljava_lang_Object_I == IntPtr.Zero)
				id_count_Ljava_lang_Object_I = JNIEnv.GetMethodID (class_ref, "count", "(Ljava/lang/Object;I)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_count_Ljava_lang_Object_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "count", "(Ljava/lang/Object;I)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getNormalized_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetGetNormalized_Ljava_lang_Object_Handler ()
		{
			if (cb_getNormalized_Ljava_lang_Object_ == null)
				cb_getNormalized_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, double>) n_GetNormalized_Ljava_lang_Object_);
			return cb_getNormalized_Ljava_lang_Object_;
		}

		static double n_GetNormalized_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BE.Abeel.Util.CountMap __this = global::Java.Lang.Object.GetObject<global::BE.Abeel.Util.CountMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			double __ret = __this.GetNormalized (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getNormalized_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.util']/class[@name='CountMap']/method[@name='getNormalized' and count(parameter)=1 and parameter[1][@type='A']]"
		[Register ("getNormalized", "(Ljava/lang/Object;)D", "GetGetNormalized_Ljava_lang_Object_Handler")]
		public virtual unsafe double GetNormalized (global::Java.Lang.Object p0)
		{
			if (id_getNormalized_Ljava_lang_Object_ == IntPtr.Zero)
				id_getNormalized_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "getNormalized", "(Ljava/lang/Object;)D");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				double __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallDoubleMethod  (Handle, id_getNormalized_Ljava_lang_Object_, __args);
				else
					__ret = JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNormalized", "(Ljava/lang/Object;)D"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_totalCount;
#pragma warning disable 0169
		static Delegate GetTotalCountHandler ()
		{
			if (cb_totalCount == null)
				cb_totalCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_TotalCount);
			return cb_totalCount;
		}

		static int n_TotalCount (IntPtr jnienv, IntPtr native__this)
		{
			global::BE.Abeel.Util.CountMap __this = global::Java.Lang.Object.GetObject<global::BE.Abeel.Util.CountMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TotalCount ();
		}
#pragma warning restore 0169

		static IntPtr id_totalCount;
		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.util']/class[@name='CountMap']/method[@name='totalCount' and count(parameter)=0]"
		[Register ("totalCount", "()I", "GetTotalCountHandler")]
		public virtual unsafe int TotalCount ()
		{
			if (id_totalCount == IntPtr.Zero)
				id_totalCount = JNIEnv.GetMethodID (class_ref, "totalCount", "()I");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_totalCount);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "totalCount", "()I"));
			} finally {
			}
		}

	}
}
