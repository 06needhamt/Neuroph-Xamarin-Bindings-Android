using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Net.SF.Image4j.IO {

	// Metadata.xml XPath class reference: path="/api/package[@name='net.sf.image4j.io']/class[@name='EndianUtils']"
	[global::Android.Runtime.Register ("net/sf/image4j/io/EndianUtils", DoNotGenerateAcw=true)]
	public partial class EndianUtils : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("net/sf/image4j/io/EndianUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (EndianUtils); }
		}

		protected EndianUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='net.sf.image4j.io']/class[@name='EndianUtils']/constructor[@name='EndianUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe EndianUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (EndianUtils)) {
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

		static IntPtr id_swapDouble_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='net.sf.image4j.io']/class[@name='EndianUtils']/method[@name='swapDouble' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("swapDouble", "(D)D", "")]
		public static unsafe double SwapDouble (double p0)
		{
			if (id_swapDouble_D == IntPtr.Zero)
				id_swapDouble_D = JNIEnv.GetStaticMethodID (class_ref, "swapDouble", "(D)D");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticDoubleMethod  (class_ref, id_swapDouble_D, __args);
			} finally {
			}
		}

		static IntPtr id_swapFloat_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='net.sf.image4j.io']/class[@name='EndianUtils']/method[@name='swapFloat' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("swapFloat", "(F)F", "")]
		public static unsafe float SwapFloat (float p0)
		{
			if (id_swapFloat_F == IntPtr.Zero)
				id_swapFloat_F = JNIEnv.GetStaticMethodID (class_ref, "swapFloat", "(F)F");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticFloatMethod  (class_ref, id_swapFloat_F, __args);
			} finally {
			}
		}

		static IntPtr id_swapInteger_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='net.sf.image4j.io']/class[@name='EndianUtils']/method[@name='swapInteger' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("swapInteger", "(I)I", "")]
		public static unsafe int SwapInteger (int p0)
		{
			if (id_swapInteger_I == IntPtr.Zero)
				id_swapInteger_I = JNIEnv.GetStaticMethodID (class_ref, "swapInteger", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_swapInteger_I, __args);
			} finally {
			}
		}

		static IntPtr id_swapLong_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='net.sf.image4j.io']/class[@name='EndianUtils']/method[@name='swapLong' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("swapLong", "(J)J", "")]
		public static unsafe long SwapLong (long p0)
		{
			if (id_swapLong_J == IntPtr.Zero)
				id_swapLong_J = JNIEnv.GetStaticMethodID (class_ref, "swapLong", "(J)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticLongMethod  (class_ref, id_swapLong_J, __args);
			} finally {
			}
		}

		static IntPtr id_swapShort_S;
		// Metadata.xml XPath method reference: path="/api/package[@name='net.sf.image4j.io']/class[@name='EndianUtils']/method[@name='swapShort' and count(parameter)=1 and parameter[1][@type='short']]"
		[Register ("swapShort", "(S)S", "")]
		public static unsafe short SwapShort (short p0)
		{
			if (id_swapShort_S == IntPtr.Zero)
				id_swapShort_S = JNIEnv.GetStaticMethodID (class_ref, "swapShort", "(S)S");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticShortMethod  (class_ref, id_swapShort_S, __args);
			} finally {
			}
		}

	}
}
