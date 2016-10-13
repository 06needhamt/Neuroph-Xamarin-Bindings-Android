using System;
using System.Collections.Generic;
using Android.Runtime;

namespace BE.Abeel.IO {

	// Metadata.xml XPath class reference: path="/api/package[@name='be.abeel.io']/class[@name='Copier']"
	[global::Android.Runtime.Register ("be/abeel/io/Copier", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public sealed partial class Copier : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='be.abeel.io']/class[@name='Copier.FastByteArrayInputStream']"
		[global::Android.Runtime.Register ("be/abeel/io/Copier$FastByteArrayInputStream", DoNotGenerateAcw=true)]
		public partial class FastByteArrayInputStream : global::Java.IO.InputStream {


			static IntPtr buf_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='be.abeel.io']/class[@name='Copier.FastByteArrayInputStream']/field[@name='buf']"
			[Register ("buf")]
			protected IList<byte> Buf {
				get {
					if (buf_jfieldId == IntPtr.Zero)
						buf_jfieldId = JNIEnv.GetFieldID (class_ref, "buf", "[B");
					return global::Android.Runtime.JavaArray<byte>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, buf_jfieldId), JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (buf_jfieldId == IntPtr.Zero)
						buf_jfieldId = JNIEnv.GetFieldID (class_ref, "buf", "[B");
					IntPtr native_value = global::Android.Runtime.JavaArray<byte>.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, buf_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr count_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='be.abeel.io']/class[@name='Copier.FastByteArrayInputStream']/field[@name='count']"
			[Register ("count")]
			protected int Count {
				get {
					if (count_jfieldId == IntPtr.Zero)
						count_jfieldId = JNIEnv.GetFieldID (class_ref, "count", "I");
					return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, count_jfieldId);
				}
				set {
					if (count_jfieldId == IntPtr.Zero)
						count_jfieldId = JNIEnv.GetFieldID (class_ref, "count", "I");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, count_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr pos_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='be.abeel.io']/class[@name='Copier.FastByteArrayInputStream']/field[@name='pos']"
			[Register ("pos")]
			protected int Pos {
				get {
					if (pos_jfieldId == IntPtr.Zero)
						pos_jfieldId = JNIEnv.GetFieldID (class_ref, "pos", "I");
					return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, pos_jfieldId);
				}
				set {
					if (pos_jfieldId == IntPtr.Zero)
						pos_jfieldId = JNIEnv.GetFieldID (class_ref, "pos", "I");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, pos_jfieldId, value);
					} finally {
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("be/abeel/io/Copier$FastByteArrayInputStream", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (FastByteArrayInputStream); }
			}

			protected FastByteArrayInputStream (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lbe_abeel_io_Copier_arrayBI;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='be.abeel.io']/class[@name='Copier.FastByteArrayInputStream']/constructor[@name='Copier.FastByteArrayInputStream' and count(parameter)=3 and parameter[1][@type='be.abeel.io.Copier'] and parameter[2][@type='byte[]'] and parameter[3][@type='int']]"
			[Register (".ctor", "(Lbe/abeel/io/Copier;[BI)V", "")]
			public unsafe FastByteArrayInputStream (global::BE.Abeel.IO.Copier __self, byte[] p1, int p2)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_p1 = JNIEnv.NewArray (p1);
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (native_p1);
					__args [2] = new JValue (p2);
					if (GetType () != typeof (FastByteArrayInputStream)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";[BI)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";[BI)V", __args);
						return;
					}

					if (id_ctor_Lbe_abeel_io_Copier_arrayBI == IntPtr.Zero)
						id_ctor_Lbe_abeel_io_Copier_arrayBI = JNIEnv.GetMethodID (class_ref, "<init>", "(Lbe/abeel/io/Copier;[BI)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lbe_abeel_io_Copier_arrayBI, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lbe_abeel_io_Copier_arrayBI, __args);
				} finally {
					if (p1 != null) {
						JNIEnv.CopyArray (native_p1, p1);
						JNIEnv.DeleteLocalRef (native_p1);
					}
				}
			}

			static IntPtr id_available;
			// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.io']/class[@name='Copier.FastByteArrayInputStream']/method[@name='available' and count(parameter)=0]"
			[Register ("available", "()I", "")]
			public override sealed unsafe int Available ()
			{
				if (id_available == IntPtr.Zero)
					id_available = JNIEnv.GetMethodID (class_ref, "available", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_available);
				} finally {
				}
			}

			static IntPtr id_read;
			// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.io']/class[@name='Copier.FastByteArrayInputStream']/method[@name='read' and count(parameter)=0]"
			[Register ("read", "()I", "")]
			public override sealed unsafe int Read ()
			{
				if (id_read == IntPtr.Zero)
					id_read = JNIEnv.GetMethodID (class_ref, "read", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_read);
				} finally {
				}
			}

			static IntPtr id_read_arrayBII;
			// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.io']/class[@name='Copier.FastByteArrayInputStream']/method[@name='read' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register ("read", "([BII)I", "")]
			public override sealed unsafe int Read (byte[] p0, int p1, int p2)
			{
				if (id_read_arrayBII == IntPtr.Zero)
					id_read_arrayBII = JNIEnv.GetMethodID (class_ref, "read", "([BII)I");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (native_p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);
					int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_read_arrayBII, __args);
					return __ret;
				} finally {
					if (p0 != null) {
						JNIEnv.CopyArray (native_p0, p0);
						JNIEnv.DeleteLocalRef (native_p0);
					}
				}
			}

			static IntPtr id_skip_J;
			// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.io']/class[@name='Copier.FastByteArrayInputStream']/method[@name='skip' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("skip", "(J)J", "")]
			public override sealed unsafe long Skip (long p0)
			{
				if (id_skip_J == IntPtr.Zero)
					id_skip_J = JNIEnv.GetMethodID (class_ref, "skip", "(J)J");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_skip_J, __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='be.abeel.io']/class[@name='Copier.FastByteArrayOutputStream']"
		[global::Android.Runtime.Register ("be/abeel/io/Copier$FastByteArrayOutputStream", DoNotGenerateAcw=true)]
		public partial class FastByteArrayOutputStream : global::Java.IO.OutputStream {


			static IntPtr buf_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='be.abeel.io']/class[@name='Copier.FastByteArrayOutputStream']/field[@name='buf']"
			[Register ("buf")]
			protected IList<byte> Buf {
				get {
					if (buf_jfieldId == IntPtr.Zero)
						buf_jfieldId = JNIEnv.GetFieldID (class_ref, "buf", "[B");
					return global::Android.Runtime.JavaArray<byte>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, buf_jfieldId), JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (buf_jfieldId == IntPtr.Zero)
						buf_jfieldId = JNIEnv.GetFieldID (class_ref, "buf", "[B");
					IntPtr native_value = global::Android.Runtime.JavaArray<byte>.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, buf_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("be/abeel/io/Copier$FastByteArrayOutputStream", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (FastByteArrayOutputStream); }
			}

			protected FastByteArrayOutputStream (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lbe_abeel_io_Copier_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='be.abeel.io']/class[@name='Copier.FastByteArrayOutputStream']/constructor[@name='Copier.FastByteArrayOutputStream' and count(parameter)=1 and parameter[1][@type='be.abeel.io.Copier']]"
			[Register (".ctor", "(Lbe/abeel/io/Copier;)V", "")]
			public unsafe FastByteArrayOutputStream (global::BE.Abeel.IO.Copier __self)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (__self);
					if (GetType () != typeof (FastByteArrayOutputStream)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args);
						return;
					}

					if (id_ctor_Lbe_abeel_io_Copier_ == IntPtr.Zero)
						id_ctor_Lbe_abeel_io_Copier_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lbe/abeel/io/Copier;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lbe_abeel_io_Copier_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lbe_abeel_io_Copier_, __args);
				} finally {
				}
			}

			static IntPtr id_ctor_Lbe_abeel_io_Copier_I;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='be.abeel.io']/class[@name='Copier.FastByteArrayOutputStream']/constructor[@name='Copier.FastByteArrayOutputStream' and count(parameter)=2 and parameter[1][@type='be.abeel.io.Copier'] and parameter[2][@type='int']]"
			[Register (".ctor", "(Lbe/abeel/io/Copier;I)V", "")]
			public unsafe FastByteArrayOutputStream (global::BE.Abeel.IO.Copier __self, int p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (p1);
					if (GetType () != typeof (FastByteArrayOutputStream)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";I)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";I)V", __args);
						return;
					}

					if (id_ctor_Lbe_abeel_io_Copier_I == IntPtr.Zero)
						id_ctor_Lbe_abeel_io_Copier_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Lbe/abeel/io/Copier;I)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lbe_abeel_io_Copier_I, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lbe_abeel_io_Copier_I, __args);
				} finally {
				}
			}

			static Delegate cb_getInputStream;
#pragma warning disable 0169
			static Delegate GetGetInputStreamHandler ()
			{
				if (cb_getInputStream == null)
					cb_getInputStream = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetInputStream);
				return cb_getInputStream;
			}

			static IntPtr n_GetInputStream (IntPtr jnienv, IntPtr native__this)
			{
				global::BE.Abeel.IO.Copier.FastByteArrayOutputStream __this = global::Java.Lang.Object.GetObject<global::BE.Abeel.IO.Copier.FastByteArrayOutputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (__this.InputStream);
			}
#pragma warning restore 0169

			static IntPtr id_getInputStream;
			public virtual unsafe global::System.IO.Stream InputStream {
				// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.io']/class[@name='Copier.FastByteArrayOutputStream']/method[@name='getInputStream' and count(parameter)=0]"
				[Register ("getInputStream", "()Ljava/io/InputStream;", "GetGetInputStreamHandler")]
				get {
					if (id_getInputStream == IntPtr.Zero)
						id_getInputStream = JNIEnv.GetMethodID (class_ref, "getInputStream", "()Ljava/io/InputStream;");
					try {

						if (GetType () == ThresholdType)
							return global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getInputStream), JniHandleOwnership.TransferLocalRef);
						else
							return global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getInputStream", "()Ljava/io/InputStream;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getSize;
#pragma warning disable 0169
			static Delegate GetGetSizeHandler ()
			{
				if (cb_getSize == null)
					cb_getSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSize);
				return cb_getSize;
			}

			static int n_GetSize (IntPtr jnienv, IntPtr native__this)
			{
				global::BE.Abeel.IO.Copier.FastByteArrayOutputStream __this = global::Java.Lang.Object.GetObject<global::BE.Abeel.IO.Copier.FastByteArrayOutputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Size;
			}
#pragma warning restore 0169

			static IntPtr id_getSize;
			public virtual unsafe int Size {
				// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.io']/class[@name='Copier.FastByteArrayOutputStream']/method[@name='getSize' and count(parameter)=0]"
				[Register ("getSize", "()I", "GetGetSizeHandler")]
				get {
					if (id_getSize == IntPtr.Zero)
						id_getSize = JNIEnv.GetMethodID (class_ref, "getSize", "()I");
					try {

						if (GetType () == ThresholdType)
							return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getSize);
						else
							return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSize", "()I"));
					} finally {
					}
				}
			}

			static Delegate cb_getByteArray;
#pragma warning disable 0169
			static Delegate GetGetByteArrayHandler ()
			{
				if (cb_getByteArray == null)
					cb_getByteArray = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetByteArray);
				return cb_getByteArray;
			}

			static IntPtr n_GetByteArray (IntPtr jnienv, IntPtr native__this)
			{
				global::BE.Abeel.IO.Copier.FastByteArrayOutputStream __this = global::Java.Lang.Object.GetObject<global::BE.Abeel.IO.Copier.FastByteArrayOutputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewArray (__this.GetByteArray ());
			}
#pragma warning restore 0169

			static IntPtr id_getByteArray;
			// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.io']/class[@name='Copier.FastByteArrayOutputStream']/method[@name='getByteArray' and count(parameter)=0]"
			[Register ("getByteArray", "()[B", "GetGetByteArrayHandler")]
			public virtual unsafe byte[] GetByteArray ()
			{
				if (id_getByteArray == IntPtr.Zero)
					id_getByteArray = JNIEnv.GetMethodID (class_ref, "getByteArray", "()[B");
				try {

					if (GetType () == ThresholdType)
						return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getByteArray), JniHandleOwnership.TransferLocalRef, typeof (byte));
					else
						return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getByteArray", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
				} finally {
				}
			}

			static Delegate cb_reset;
#pragma warning disable 0169
			static Delegate GetResetHandler ()
			{
				if (cb_reset == null)
					cb_reset = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Reset);
				return cb_reset;
			}

			static void n_Reset (IntPtr jnienv, IntPtr native__this)
			{
				global::BE.Abeel.IO.Copier.FastByteArrayOutputStream __this = global::Java.Lang.Object.GetObject<global::BE.Abeel.IO.Copier.FastByteArrayOutputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Reset ();
			}
#pragma warning restore 0169

			static IntPtr id_reset;
			// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.io']/class[@name='Copier.FastByteArrayOutputStream']/method[@name='reset' and count(parameter)=0]"
			[Register ("reset", "()V", "GetResetHandler")]
			public virtual unsafe void Reset ()
			{
				if (id_reset == IntPtr.Zero)
					id_reset = JNIEnv.GetMethodID (class_ref, "reset", "()V");
				try {

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_reset);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "reset", "()V"));
				} finally {
				}
			}

			static IntPtr id_write_arrayB;
			// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.io']/class[@name='Copier.FastByteArrayOutputStream']/method[@name='write' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("write", "([B)V", "")]
			public override sealed unsafe void Write (byte[] p0)
			{
				if (id_write_arrayB == IntPtr.Zero)
					id_write_arrayB = JNIEnv.GetMethodID (class_ref, "write", "([B)V");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_write_arrayB, __args);
				} finally {
					if (p0 != null) {
						JNIEnv.CopyArray (native_p0, p0);
						JNIEnv.DeleteLocalRef (native_p0);
					}
				}
			}

			static IntPtr id_write_arrayBII;
			// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.io']/class[@name='Copier.FastByteArrayOutputStream']/method[@name='write' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register ("write", "([BII)V", "")]
			public override sealed unsafe void Write (byte[] p0, int p1, int p2)
			{
				if (id_write_arrayBII == IntPtr.Zero)
					id_write_arrayBII = JNIEnv.GetMethodID (class_ref, "write", "([BII)V");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (native_p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_write_arrayBII, __args);
				} finally {
					if (p0 != null) {
						JNIEnv.CopyArray (native_p0, p0);
						JNIEnv.DeleteLocalRef (native_p0);
					}
				}
			}

			static IntPtr id_write_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.io']/class[@name='Copier.FastByteArrayOutputStream']/method[@name='write' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("write", "(I)V", "")]
			public override sealed unsafe void Write (int p0)
			{
				if (id_write_I == IntPtr.Zero)
					id_write_I = JNIEnv.GetMethodID (class_ref, "write", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_write_I, __args);
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("be/abeel/io/Copier", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Copier); }
		}

		internal Copier (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='be.abeel.io']/class[@name='Copier']/constructor[@name='Copier' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Copier ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Copier)) {
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

		static IntPtr id_copy_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.io']/class[@name='Copier']/method[@name='copy' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("copy", "(Ljava/lang/Object;)Ljava/lang/Object;", "")]
		public unsafe global::Java.Lang.Object Copy (global::Java.Lang.Object p0)
		{
			if (id_copy_Ljava_lang_Object_ == IntPtr.Zero)
				id_copy_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "copy", "(Ljava/lang/Object;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_copy_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
