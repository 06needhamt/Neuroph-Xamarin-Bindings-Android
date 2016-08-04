using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Nnet.Comp {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.nnet.comp']/class[@name='Kernel']"
	[global::Android.Runtime.Register ("org/neuroph/nnet/comp/Kernel", DoNotGenerateAcw=true)]
	public partial class Kernel : global::Java.Lang.Object, global::Java.IO.ISerializable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/nnet/comp/Kernel", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Kernel); }
		}

		protected Kernel (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_II;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.nnet.comp']/class[@name='Kernel']/constructor[@name='Kernel' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register (".ctor", "(II)V", "")]
		public unsafe Kernel (int p0, int p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (Kernel)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(II)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(II)V", __args);
					return;
				}

				if (id_ctor_II == IntPtr.Zero)
					id_ctor_II = JNIEnv.GetMethodID (class_ref, "<init>", "(II)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_II, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_II, __args);
			} finally {
			}
		}

		static Delegate cb_getArea;
#pragma warning disable 0169
		static Delegate GetGetAreaHandler ()
		{
			if (cb_getArea == null)
				cb_getArea = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetArea);
			return cb_getArea;
		}

		static int n_GetArea (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Nnet.Comp.Kernel __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Comp.Kernel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Area;
		}
#pragma warning restore 0169

		static IntPtr id_getArea;
		public virtual unsafe int Area {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.comp']/class[@name='Kernel']/method[@name='getArea' and count(parameter)=0]"
			[Register ("getArea", "()I", "GetGetAreaHandler")]
			get {
				if (id_getArea == IntPtr.Zero)
					id_getArea = JNIEnv.GetMethodID (class_ref, "getArea", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getArea);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getArea", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getHeight;
#pragma warning disable 0169
		static Delegate GetGetHeightHandler ()
		{
			if (cb_getHeight == null)
				cb_getHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHeight);
			return cb_getHeight;
		}

		static int n_GetHeight (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Nnet.Comp.Kernel __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Comp.Kernel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Height;
		}
#pragma warning restore 0169

		static Delegate cb_setHeight_I;
#pragma warning disable 0169
		static Delegate GetSetHeight_IHandler ()
		{
			if (cb_setHeight_I == null)
				cb_setHeight_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetHeight_I);
			return cb_setHeight_I;
		}

		static void n_SetHeight_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Neuroph.Nnet.Comp.Kernel __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Comp.Kernel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Height = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getHeight;
		static IntPtr id_setHeight_I;
		public virtual unsafe int Height {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.comp']/class[@name='Kernel']/method[@name='getHeight' and count(parameter)=0]"
			[Register ("getHeight", "()I", "GetGetHeightHandler")]
			get {
				if (id_getHeight == IntPtr.Zero)
					id_getHeight = JNIEnv.GetMethodID (class_ref, "getHeight", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getHeight);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHeight", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.comp']/class[@name='Kernel']/method[@name='setHeight' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setHeight", "(I)V", "GetSetHeight_IHandler")]
			set {
				if (id_setHeight_I == IntPtr.Zero)
					id_setHeight_I = JNIEnv.GetMethodID (class_ref, "setHeight", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setHeight_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setHeight", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getWidth;
#pragma warning disable 0169
		static Delegate GetGetWidthHandler ()
		{
			if (cb_getWidth == null)
				cb_getWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetWidth);
			return cb_getWidth;
		}

		static int n_GetWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Nnet.Comp.Kernel __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Comp.Kernel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Width;
		}
#pragma warning restore 0169

		static Delegate cb_setWidth_I;
#pragma warning disable 0169
		static Delegate GetSetWidth_IHandler ()
		{
			if (cb_setWidth_I == null)
				cb_setWidth_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetWidth_I);
			return cb_setWidth_I;
		}

		static void n_SetWidth_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Neuroph.Nnet.Comp.Kernel __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Comp.Kernel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Width = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getWidth;
		static IntPtr id_setWidth_I;
		public virtual unsafe int Width {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.comp']/class[@name='Kernel']/method[@name='getWidth' and count(parameter)=0]"
			[Register ("getWidth", "()I", "GetGetWidthHandler")]
			get {
				if (id_getWidth == IntPtr.Zero)
					id_getWidth = JNIEnv.GetMethodID (class_ref, "getWidth", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getWidth);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWidth", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.comp']/class[@name='Kernel']/method[@name='setWidth' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setWidth", "(I)V", "GetSetWidth_IHandler")]
			set {
				if (id_setWidth_I == IntPtr.Zero)
					id_setWidth_I = JNIEnv.GetMethodID (class_ref, "setWidth", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setWidth_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setWidth", "(I)V"), __args);
				} finally {
				}
			}
		}

	}
}
