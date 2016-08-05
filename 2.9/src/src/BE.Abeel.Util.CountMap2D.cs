using System;
using System.Collections.Generic;
using Android.Runtime;

namespace BE.Abeel.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='be.abeel.util']/class[@name='CountMap2D']"
	[global::Android.Runtime.Register ("be/abeel/util/CountMap2D", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"K", "L"})]
	public partial class CountMap2D : global::BE.Abeel.Util.DefaultHashMap2D {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("be/abeel/util/CountMap2D", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CountMap2D); }
		}

		protected CountMap2D (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='be.abeel.util']/class[@name='CountMap2D']/constructor[@name='CountMap2D' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CountMap2D ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (CountMap2D)) {
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

		static IntPtr id_ctor_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='be.abeel.util']/class[@name='CountMap2D']/constructor[@name='CountMap2D' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe CountMap2D (int p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (CountMap2D)) {
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

		static Delegate cb_count_Ljava_lang_Object_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetCount_Ljava_lang_Object_Ljava_lang_Object_Handler ()
		{
			if (cb_count_Ljava_lang_Object_Ljava_lang_Object_ == null)
				cb_count_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Count_Ljava_lang_Object_Ljava_lang_Object_);
			return cb_count_Ljava_lang_Object_Ljava_lang_Object_;
		}

		static void n_Count_Ljava_lang_Object_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::BE.Abeel.Util.CountMap2D __this = global::Java.Lang.Object.GetObject<global::BE.Abeel.Util.CountMap2D> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Count (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_count_Ljava_lang_Object_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.util']/class[@name='CountMap2D']/method[@name='count' and count(parameter)=2 and parameter[1][@type='K'] and parameter[2][@type='L']]"
		[Register ("count", "(Ljava/lang/Object;Ljava/lang/Object;)V", "GetCount_Ljava_lang_Object_Ljava_lang_Object_Handler")]
		public virtual unsafe void Count (global::Java.Lang.Object p0, global::Java.Lang.Object p1)
		{
			if (id_count_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
				id_count_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "count", "(Ljava/lang/Object;Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_count_Ljava_lang_Object_Ljava_lang_Object_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "count", "(Ljava/lang/Object;Ljava/lang/Object;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_getNormalized_Ljava_lang_Object_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetGetNormalized_Ljava_lang_Object_Ljava_lang_Object_Handler ()
		{
			if (cb_getNormalized_Ljava_lang_Object_Ljava_lang_Object_ == null)
				cb_getNormalized_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, double>) n_GetNormalized_Ljava_lang_Object_Ljava_lang_Object_);
			return cb_getNormalized_Ljava_lang_Object_Ljava_lang_Object_;
		}

		static double n_GetNormalized_Ljava_lang_Object_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::BE.Abeel.Util.CountMap2D __this = global::Java.Lang.Object.GetObject<global::BE.Abeel.Util.CountMap2D> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			double __ret = __this.GetNormalized (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getNormalized_Ljava_lang_Object_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.util']/class[@name='CountMap2D']/method[@name='getNormalized' and count(parameter)=2 and parameter[1][@type='K'] and parameter[2][@type='L']]"
		[Register ("getNormalized", "(Ljava/lang/Object;Ljava/lang/Object;)D", "GetGetNormalized_Ljava_lang_Object_Ljava_lang_Object_Handler")]
		public virtual unsafe double GetNormalized (global::Java.Lang.Object p0, global::Java.Lang.Object p1)
		{
			if (id_getNormalized_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
				id_getNormalized_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "getNormalized", "(Ljava/lang/Object;Ljava/lang/Object;)D");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				double __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallDoubleMethod  (Handle, id_getNormalized_Ljava_lang_Object_Ljava_lang_Object_, __args);
				else
					__ret = JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNormalized", "(Ljava/lang/Object;Ljava/lang/Object;)D"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
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
			global::BE.Abeel.Util.CountMap2D __this = global::Java.Lang.Object.GetObject<global::BE.Abeel.Util.CountMap2D> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TotalCount ();
		}
#pragma warning restore 0169

		static IntPtr id_totalCount;
		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.util']/class[@name='CountMap2D']/method[@name='totalCount' and count(parameter)=0]"
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

		static Delegate cb_totalXCount_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetTotalXCount_Ljava_lang_Object_Handler ()
		{
			if (cb_totalXCount_Ljava_lang_Object_ == null)
				cb_totalXCount_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_TotalXCount_Ljava_lang_Object_);
			return cb_totalXCount_Ljava_lang_Object_;
		}

		static int n_TotalXCount_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BE.Abeel.Util.CountMap2D __this = global::Java.Lang.Object.GetObject<global::BE.Abeel.Util.CountMap2D> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.TotalXCount (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_totalXCount_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.util']/class[@name='CountMap2D']/method[@name='totalXCount' and count(parameter)=1 and parameter[1][@type='K']]"
		[Register ("totalXCount", "(Ljava/lang/Object;)I", "GetTotalXCount_Ljava_lang_Object_Handler")]
		public virtual unsafe int TotalXCount (global::Java.Lang.Object p0)
		{
			if (id_totalXCount_Ljava_lang_Object_ == IntPtr.Zero)
				id_totalXCount_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "totalXCount", "(Ljava/lang/Object;)I");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod  (Handle, id_totalXCount_Ljava_lang_Object_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "totalXCount", "(Ljava/lang/Object;)I"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_totalYCount_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetTotalYCount_Ljava_lang_Object_Handler ()
		{
			if (cb_totalYCount_Ljava_lang_Object_ == null)
				cb_totalYCount_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_TotalYCount_Ljava_lang_Object_);
			return cb_totalYCount_Ljava_lang_Object_;
		}

		static int n_TotalYCount_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BE.Abeel.Util.CountMap2D __this = global::Java.Lang.Object.GetObject<global::BE.Abeel.Util.CountMap2D> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.TotalYCount (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_totalYCount_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.util']/class[@name='CountMap2D']/method[@name='totalYCount' and count(parameter)=1 and parameter[1][@type='L']]"
		[Register ("totalYCount", "(Ljava/lang/Object;)I", "GetTotalYCount_Ljava_lang_Object_Handler")]
		public virtual unsafe int TotalYCount (global::Java.Lang.Object p0)
		{
			if (id_totalYCount_Ljava_lang_Object_ == IntPtr.Zero)
				id_totalYCount_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "totalYCount", "(Ljava/lang/Object;)I");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod  (Handle, id_totalYCount_Ljava_lang_Object_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "totalYCount", "(Ljava/lang/Object;)I"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
