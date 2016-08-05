using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jocl {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jocl']/class[@name='Pointer']"
	[global::Android.Runtime.Register ("org/jocl/Pointer", DoNotGenerateAcw=true)]
	public sealed partial class Pointer : global::Org.Jocl.NativePointerObject {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jocl/Pointer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Pointer); }
		}

		internal Pointer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jocl']/class[@name='Pointer']/constructor[@name='Pointer' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Pointer ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Pointer)) {
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

		static IntPtr id_to_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jocl']/class[@name='Pointer']/method[@name='to' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("to", "([B)Lorg/jocl/Pointer;", "")]
		public static unsafe global::Org.Jocl.Pointer To (byte[] p0)
		{
			if (id_to_arrayB == IntPtr.Zero)
				id_to_arrayB = JNIEnv.GetStaticMethodID (class_ref, "to", "([B)Lorg/jocl/Pointer;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Org.Jocl.Pointer __ret = global::Java.Lang.Object.GetObject<global::Org.Jocl.Pointer> (JNIEnv.CallStaticObjectMethod  (class_ref, id_to_arrayB, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_to_arrayC;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jocl']/class[@name='Pointer']/method[@name='to' and count(parameter)=1 and parameter[1][@type='char[]']]"
		[Register ("to", "([C)Lorg/jocl/Pointer;", "")]
		public static unsafe global::Org.Jocl.Pointer To (char[] p0)
		{
			if (id_to_arrayC == IntPtr.Zero)
				id_to_arrayC = JNIEnv.GetStaticMethodID (class_ref, "to", "([C)Lorg/jocl/Pointer;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Org.Jocl.Pointer __ret = global::Java.Lang.Object.GetObject<global::Org.Jocl.Pointer> (JNIEnv.CallStaticObjectMethod  (class_ref, id_to_arrayC, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_to_arrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jocl']/class[@name='Pointer']/method[@name='to' and count(parameter)=1 and parameter[1][@type='double[]']]"
		[Register ("to", "([D)Lorg/jocl/Pointer;", "")]
		public static unsafe global::Org.Jocl.Pointer To (double[] p0)
		{
			if (id_to_arrayD == IntPtr.Zero)
				id_to_arrayD = JNIEnv.GetStaticMethodID (class_ref, "to", "([D)Lorg/jocl/Pointer;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Org.Jocl.Pointer __ret = global::Java.Lang.Object.GetObject<global::Org.Jocl.Pointer> (JNIEnv.CallStaticObjectMethod  (class_ref, id_to_arrayD, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_to_arrayF;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jocl']/class[@name='Pointer']/method[@name='to' and count(parameter)=1 and parameter[1][@type='float[]']]"
		[Register ("to", "([F)Lorg/jocl/Pointer;", "")]
		public static unsafe global::Org.Jocl.Pointer To (float[] p0)
		{
			if (id_to_arrayF == IntPtr.Zero)
				id_to_arrayF = JNIEnv.GetStaticMethodID (class_ref, "to", "([F)Lorg/jocl/Pointer;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Org.Jocl.Pointer __ret = global::Java.Lang.Object.GetObject<global::Org.Jocl.Pointer> (JNIEnv.CallStaticObjectMethod  (class_ref, id_to_arrayF, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_to_arrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jocl']/class[@name='Pointer']/method[@name='to' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[Register ("to", "([I)Lorg/jocl/Pointer;", "")]
		public static unsafe global::Org.Jocl.Pointer To (int[] p0)
		{
			if (id_to_arrayI == IntPtr.Zero)
				id_to_arrayI = JNIEnv.GetStaticMethodID (class_ref, "to", "([I)Lorg/jocl/Pointer;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Org.Jocl.Pointer __ret = global::Java.Lang.Object.GetObject<global::Org.Jocl.Pointer> (JNIEnv.CallStaticObjectMethod  (class_ref, id_to_arrayI, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_to_Ljava_nio_Buffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jocl']/class[@name='Pointer']/method[@name='to' and count(parameter)=1 and parameter[1][@type='java.nio.Buffer']]"
		[Register ("to", "(Ljava/nio/Buffer;)Lorg/jocl/Pointer;", "")]
		public static unsafe global::Org.Jocl.Pointer To (global::Java.Nio.Buffer p0)
		{
			if (id_to_Ljava_nio_Buffer_ == IntPtr.Zero)
				id_to_Ljava_nio_Buffer_ = JNIEnv.GetStaticMethodID (class_ref, "to", "(Ljava/nio/Buffer;)Lorg/jocl/Pointer;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Org.Jocl.Pointer __ret = global::Java.Lang.Object.GetObject<global::Org.Jocl.Pointer> (JNIEnv.CallStaticObjectMethod  (class_ref, id_to_Ljava_nio_Buffer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_to_arrayJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jocl']/class[@name='Pointer']/method[@name='to' and count(parameter)=1 and parameter[1][@type='long[]']]"
		[Register ("to", "([J)Lorg/jocl/Pointer;", "")]
		public static unsafe global::Org.Jocl.Pointer To (long[] p0)
		{
			if (id_to_arrayJ == IntPtr.Zero)
				id_to_arrayJ = JNIEnv.GetStaticMethodID (class_ref, "to", "([J)Lorg/jocl/Pointer;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Org.Jocl.Pointer __ret = global::Java.Lang.Object.GetObject<global::Org.Jocl.Pointer> (JNIEnv.CallStaticObjectMethod  (class_ref, id_to_arrayJ, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_to_arrayLorg_jocl_NativePointerObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jocl']/class[@name='Pointer']/method[@name='to' and count(parameter)=1 and parameter[1][@type='org.jocl.NativePointerObject...']]"
		[Register ("to", "([Lorg/jocl/NativePointerObject;)Lorg/jocl/Pointer;", "")]
		public static unsafe global::Org.Jocl.Pointer To (params global:: Org.Jocl.NativePointerObject[] p0)
		{
			if (id_to_arrayLorg_jocl_NativePointerObject_ == IntPtr.Zero)
				id_to_arrayLorg_jocl_NativePointerObject_ = JNIEnv.GetStaticMethodID (class_ref, "to", "([Lorg/jocl/NativePointerObject;)Lorg/jocl/Pointer;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Org.Jocl.Pointer __ret = global::Java.Lang.Object.GetObject<global::Org.Jocl.Pointer> (JNIEnv.CallStaticObjectMethod  (class_ref, id_to_arrayLorg_jocl_NativePointerObject_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_to_arrayS;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jocl']/class[@name='Pointer']/method[@name='to' and count(parameter)=1 and parameter[1][@type='short[]']]"
		[Register ("to", "([S)Lorg/jocl/Pointer;", "")]
		public static unsafe global::Org.Jocl.Pointer To (short[] p0)
		{
			if (id_to_arrayS == IntPtr.Zero)
				id_to_arrayS = JNIEnv.GetStaticMethodID (class_ref, "to", "([S)Lorg/jocl/Pointer;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Org.Jocl.Pointer __ret = global::Java.Lang.Object.GetObject<global::Org.Jocl.Pointer> (JNIEnv.CallStaticObjectMethod  (class_ref, id_to_arrayS, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_withByteOffset_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jocl']/class[@name='Pointer']/method[@name='withByteOffset' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("withByteOffset", "(J)Lorg/jocl/Pointer;", "")]
		public unsafe global::Org.Jocl.Pointer WithByteOffset (long p0)
		{
			if (id_withByteOffset_J == IntPtr.Zero)
				id_withByteOffset_J = JNIEnv.GetMethodID (class_ref, "withByteOffset", "(J)Lorg/jocl/Pointer;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Org.Jocl.Pointer> (JNIEnv.CallObjectMethod  (Handle, id_withByteOffset_J, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
