using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Contrib.Imgrec.Image {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.contrib.imgrec.image']/class[@name='Color']"
	[global::Android.Runtime.Register ("org/neuroph/contrib/imgrec/image/Color", DoNotGenerateAcw=true)]
	public partial class Color : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/contrib/imgrec/image/Color", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Color); }
		}

		protected Color (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.contrib.imgrec.image']/class[@name='Color']/constructor[@name='Color' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe Color (int p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (Color)) {
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

		static IntPtr id_getBlue_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.contrib.imgrec.image']/class[@name='Color']/method[@name='getBlue' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getBlue", "(I)I", "")]
		public static unsafe int GetBlue (int p0)
		{
			if (id_getBlue_I == IntPtr.Zero)
				id_getBlue_I = JNIEnv.GetStaticMethodID (class_ref, "getBlue", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_getBlue_I, __args);
			} finally {
			}
		}

		static Delegate cb_getColor;
#pragma warning disable 0169
		static Delegate GetGetColorHandler ()
		{
			if (cb_getColor == null)
				cb_getColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetColor);
			return cb_getColor;
		}

		static int n_GetColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Contrib.Imgrec.Image.Color __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.Imgrec.Image.Color> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetColor ();
		}
#pragma warning restore 0169

		static IntPtr id_getColor;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.contrib.imgrec.image']/class[@name='Color']/method[@name='getColor' and count(parameter)=0]"
		[Register ("getColor", "()I", "GetGetColorHandler")]
		public virtual unsafe int GetColor ()
		{
			if (id_getColor == IntPtr.Zero)
				id_getColor = JNIEnv.GetMethodID (class_ref, "getColor", "()I");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getColor);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getColor", "()I"));
			} finally {
			}
		}

		static IntPtr id_getGreen_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.contrib.imgrec.image']/class[@name='Color']/method[@name='getGreen' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getGreen", "(I)I", "")]
		public static unsafe int GetGreen (int p0)
		{
			if (id_getGreen_I == IntPtr.Zero)
				id_getGreen_I = JNIEnv.GetStaticMethodID (class_ref, "getGreen", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_getGreen_I, __args);
			} finally {
			}
		}

		static IntPtr id_getRed_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.contrib.imgrec.image']/class[@name='Color']/method[@name='getRed' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getRed", "(I)I", "")]
		public static unsafe int GetRed (int p0)
		{
			if (id_getRed_I == IntPtr.Zero)
				id_getRed_I = JNIEnv.GetStaticMethodID (class_ref, "getRed", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_getRed_I, __args);
			} finally {
			}
		}

	}
}
