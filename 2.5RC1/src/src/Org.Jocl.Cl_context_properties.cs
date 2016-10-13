using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jocl {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jocl']/class[@name='cl_context_properties']"
	[global::Android.Runtime.Register ("org/jocl/cl_context_properties", DoNotGenerateAcw=true)]
	public sealed partial class Cl_context_properties : global::Org.Jocl.NativePointerObject {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jocl/cl_context_properties", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Cl_context_properties); }
		}

		internal Cl_context_properties (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jocl']/class[@name='cl_context_properties']/constructor[@name='cl_context_properties' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Cl_context_properties ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Cl_context_properties)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static IntPtr id_addProperty_JJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jocl']/class[@name='cl_context_properties']/method[@name='addProperty' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
		[Register ("addProperty", "(JJ)V", "")]
		public unsafe void AddProperty (long p0, long p1)
		{
			if (id_addProperty_JJ == IntPtr.Zero)
				id_addProperty_JJ = JNIEnv.GetMethodID (class_ref, "addProperty", "(JJ)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addProperty_JJ, __args);
			} finally {
			}
		}

		static IntPtr id_addProperty_JLorg_jocl_cl_platform_id_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jocl']/class[@name='cl_context_properties']/method[@name='addProperty' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='org.jocl.cl_platform_id']]"
		[Register ("addProperty", "(JLorg/jocl/cl_platform_id;)V", "")]
		public unsafe void AddProperty (long p0, global::Org.Jocl.Cl_platform_id p1)
		{
			if (id_addProperty_JLorg_jocl_cl_platform_id_ == IntPtr.Zero)
				id_addProperty_JLorg_jocl_cl_platform_id_ = JNIEnv.GetMethodID (class_ref, "addProperty", "(JLorg/jocl/cl_platform_id;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addProperty_JLorg_jocl_cl_platform_id_, __args);
			} finally {
			}
		}

	}
}
