using System;
using System.Collections.Generic;
using Android.Runtime;

namespace BE.Abeel.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='be.abeel.util']/class[@name='SetTools']"
	[global::Android.Runtime.Register ("be/abeel/util/SetTools", DoNotGenerateAcw=true)]
	public partial class SetTools : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("be/abeel/util/SetTools", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SetTools); }
		}

		protected SetTools (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='be.abeel.util']/class[@name='SetTools']/constructor[@name='SetTools' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SetTools ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (SetTools)) {
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

		static IntPtr id_intersection_Ljava_util_Set_Ljava_util_Set_;
		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.util']/class[@name='SetTools']/method[@name='intersection' and count(parameter)=2 and parameter[1][@type='java.util.Set&lt;?&gt;'] and parameter[2][@type='java.util.Set&lt;?&gt;']]"
		[Register ("intersection", "(Ljava/util/Set;Ljava/util/Set;)Ljava/util/Set;", "")]
		public static unsafe global::System.Collections.Generic.ICollection<object> Intersection (global::System.Collections.Generic.ICollection<object> p0, global::System.Collections.Generic.ICollection<object> p1)
		{
			if (id_intersection_Ljava_util_Set_Ljava_util_Set_ == IntPtr.Zero)
				id_intersection_Ljava_util_Set_Ljava_util_Set_ = JNIEnv.GetStaticMethodID (class_ref, "intersection", "(Ljava/util/Set;Ljava/util/Set;)Ljava/util/Set;");
			IntPtr native_p0 = global::Android.Runtime.JavaSet<object>.ToLocalJniHandle (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaSet<object>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				global::System.Collections.Generic.ICollection<object> __ret = global::Android.Runtime.JavaSet<object>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_intersection_Ljava_util_Set_Ljava_util_Set_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_union_Ljava_util_Set_Ljava_util_Set_;
		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.util']/class[@name='SetTools']/method[@name='union' and count(parameter)=2 and parameter[1][@type='java.util.Set&lt;?&gt;'] and parameter[2][@type='java.util.Set&lt;?&gt;']]"
		[Register ("union", "(Ljava/util/Set;Ljava/util/Set;)Ljava/util/Set;", "")]
		public static unsafe global::System.Collections.Generic.ICollection<object> Union (global::System.Collections.Generic.ICollection<object> p0, global::System.Collections.Generic.ICollection<object> p1)
		{
			if (id_union_Ljava_util_Set_Ljava_util_Set_ == IntPtr.Zero)
				id_union_Ljava_util_Set_Ljava_util_Set_ = JNIEnv.GetStaticMethodID (class_ref, "union", "(Ljava/util/Set;Ljava/util/Set;)Ljava/util/Set;");
			IntPtr native_p0 = global::Android.Runtime.JavaSet<object>.ToLocalJniHandle (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaSet<object>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				global::System.Collections.Generic.ICollection<object> __ret = global::Android.Runtime.JavaSet<object>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_union_Ljava_util_Set_Ljava_util_Set_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
