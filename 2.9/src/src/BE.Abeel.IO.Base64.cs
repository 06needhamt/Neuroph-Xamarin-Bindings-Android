using System;
using System.Collections.Generic;
using Android.Runtime;

namespace BE.Abeel.IO {

	// Metadata.xml XPath class reference: path="/api/package[@name='be.abeel.io']/class[@name='Base64']"
	[global::Android.Runtime.Register ("be/abeel/io/Base64", DoNotGenerateAcw=true)]
	public partial class Base64 : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='be.abeel.io']/class[@name='Base64']/field[@name='DONT_BREAK_LINES']"
		[Register ("DONT_BREAK_LINES")]
		public const int DontBreakLines = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='be.abeel.io']/class[@name='Base64']/field[@name='ENCODE']"
		[Register ("ENCODE")]
		public const int Encode = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='be.abeel.io']/class[@name='Base64']/field[@name='GZIP']"
		[Register ("GZIP")]
		public const int Gzip = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='be.abeel.io']/class[@name='Base64']/field[@name='NO_OPTIONS']"
		[Register ("NO_OPTIONS")]
		public const int NoOptions = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='be.abeel.io']/class[@name='Base64']/field[@name='ORDERED']"
		[Register ("ORDERED")]
		public const int Ordered = (int) 32;

		// Metadata.xml XPath field reference: path="/api/package[@name='be.abeel.io']/class[@name='Base64']/field[@name='URL_SAFE']"
		[Register ("URL_SAFE")]
		public const int UrlSafe = (int) 16;
		// Metadata.xml XPath class reference: path="/api/package[@name='be.abeel.io']/class[@name='Base64.InputStream']"
		[global::Android.Runtime.Register ("be/abeel/io/Base64$InputStream", DoNotGenerateAcw=true)]
		public partial class InputStream : global::Java.IO.FilterInputStream {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("be/abeel/io/Base64$InputStream", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (InputStream); }
			}

			protected InputStream (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Ljava_io_InputStream_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='be.abeel.io']/class[@name='Base64.InputStream']/constructor[@name='Base64.InputStream' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
			[Register (".ctor", "(Ljava/io/InputStream;)V", "")]
			public unsafe InputStream (global::System.IO.Stream p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					if (GetType () != typeof (InputStream)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/io/InputStream;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/io/InputStream;)V", __args);
						return;
					}

					if (id_ctor_Ljava_io_InputStream_ == IntPtr.Zero)
						id_ctor_Ljava_io_InputStream_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/io/InputStream;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_io_InputStream_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_io_InputStream_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_ctor_Ljava_io_InputStream_I;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='be.abeel.io']/class[@name='Base64.InputStream']/constructor[@name='Base64.InputStream' and count(parameter)=2 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='int']]"
			[Register (".ctor", "(Ljava/io/InputStream;I)V", "")]
			public unsafe InputStream (global::System.IO.Stream p0, int p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (native_p0);
					__args [1] = new JValue (p1);
					if (GetType () != typeof (InputStream)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/io/InputStream;I)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/io/InputStream;I)V", __args);
						return;
					}

					if (id_ctor_Ljava_io_InputStream_I == IntPtr.Zero)
						id_ctor_Ljava_io_InputStream_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/io/InputStream;I)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_io_InputStream_I, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_io_InputStream_I, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='be.abeel.io']/class[@name='Base64.OutputStream']"
		[global::Android.Runtime.Register ("be/abeel/io/Base64$OutputStream", DoNotGenerateAcw=true)]
		public partial class OutputStream : global::Java.IO.FilterOutputStream {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("be/abeel/io/Base64$OutputStream", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (OutputStream); }
			}

			protected OutputStream (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Ljava_io_OutputStream_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='be.abeel.io']/class[@name='Base64.OutputStream']/constructor[@name='Base64.OutputStream' and count(parameter)=1 and parameter[1][@type='java.io.OutputStream']]"
			[Register (".ctor", "(Ljava/io/OutputStream;)V", "")]
			public unsafe OutputStream (global::System.IO.Stream p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					if (GetType () != typeof (OutputStream)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/io/OutputStream;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/io/OutputStream;)V", __args);
						return;
					}

					if (id_ctor_Ljava_io_OutputStream_ == IntPtr.Zero)
						id_ctor_Ljava_io_OutputStream_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/io/OutputStream;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_io_OutputStream_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_io_OutputStream_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_ctor_Ljava_io_OutputStream_I;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='be.abeel.io']/class[@name='Base64.OutputStream']/constructor[@name='Base64.OutputStream' and count(parameter)=2 and parameter[1][@type='java.io.OutputStream'] and parameter[2][@type='int']]"
			[Register (".ctor", "(Ljava/io/OutputStream;I)V", "")]
			public unsafe OutputStream (global::System.IO.Stream p0, int p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (p0);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (native_p0);
					__args [1] = new JValue (p1);
					if (GetType () != typeof (OutputStream)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/io/OutputStream;I)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/io/OutputStream;I)V", __args);
						return;
					}

					if (id_ctor_Ljava_io_OutputStream_I == IntPtr.Zero)
						id_ctor_Ljava_io_OutputStream_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/io/OutputStream;I)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_io_OutputStream_I, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_io_OutputStream_I, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_flushBase64;
#pragma warning disable 0169
			static Delegate GetFlushBase64Handler ()
			{
				if (cb_flushBase64 == null)
					cb_flushBase64 = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_FlushBase64);
				return cb_flushBase64;
			}

			static void n_FlushBase64 (IntPtr jnienv, IntPtr native__this)
			{
				global::BE.Abeel.IO.Base64.OutputStream __this = global::Java.Lang.Object.GetObject<global::BE.Abeel.IO.Base64.OutputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.FlushBase64 ();
			}
#pragma warning restore 0169

			static IntPtr id_flushBase64;
			// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.io']/class[@name='Base64.OutputStream']/method[@name='flushBase64' and count(parameter)=0]"
			[Register ("flushBase64", "()V", "GetFlushBase64Handler")]
			public virtual unsafe void FlushBase64 ()
			{
				if (id_flushBase64 == IntPtr.Zero)
					id_flushBase64 = JNIEnv.GetMethodID (class_ref, "flushBase64", "()V");
				try {

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_flushBase64);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "flushBase64", "()V"));
				} finally {
				}
			}

			static Delegate cb_resumeEncoding;
#pragma warning disable 0169
			static Delegate GetResumeEncodingHandler ()
			{
				if (cb_resumeEncoding == null)
					cb_resumeEncoding = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ResumeEncoding);
				return cb_resumeEncoding;
			}

			static void n_ResumeEncoding (IntPtr jnienv, IntPtr native__this)
			{
				global::BE.Abeel.IO.Base64.OutputStream __this = global::Java.Lang.Object.GetObject<global::BE.Abeel.IO.Base64.OutputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.ResumeEncoding ();
			}
#pragma warning restore 0169

			static IntPtr id_resumeEncoding;
			// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.io']/class[@name='Base64.OutputStream']/method[@name='resumeEncoding' and count(parameter)=0]"
			[Register ("resumeEncoding", "()V", "GetResumeEncodingHandler")]
			public virtual unsafe void ResumeEncoding ()
			{
				if (id_resumeEncoding == IntPtr.Zero)
					id_resumeEncoding = JNIEnv.GetMethodID (class_ref, "resumeEncoding", "()V");
				try {

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_resumeEncoding);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "resumeEncoding", "()V"));
				} finally {
				}
			}

			static Delegate cb_suspendEncoding;
#pragma warning disable 0169
			static Delegate GetSuspendEncodingHandler ()
			{
				if (cb_suspendEncoding == null)
					cb_suspendEncoding = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SuspendEncoding);
				return cb_suspendEncoding;
			}

			static void n_SuspendEncoding (IntPtr jnienv, IntPtr native__this)
			{
				global::BE.Abeel.IO.Base64.OutputStream __this = global::Java.Lang.Object.GetObject<global::BE.Abeel.IO.Base64.OutputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.SuspendEncoding ();
			}
#pragma warning restore 0169

			static IntPtr id_suspendEncoding;
			// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.io']/class[@name='Base64.OutputStream']/method[@name='suspendEncoding' and count(parameter)=0]"
			[Register ("suspendEncoding", "()V", "GetSuspendEncodingHandler")]
			public virtual unsafe void SuspendEncoding ()
			{
				if (id_suspendEncoding == IntPtr.Zero)
					id_suspendEncoding = JNIEnv.GetMethodID (class_ref, "suspendEncoding", "()V");
				try {

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_suspendEncoding);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "suspendEncoding", "()V"));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("be/abeel/io/Base64", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Base64); }
		}

		protected Base64 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_decode_arrayBIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.io']/class[@name='Base64']/method[@name='decode' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("decode", "([BIII)[B", "")]
		public static unsafe byte[] Decode (byte[] p0, int p1, int p2, int p3)
		{
			if (id_decode_arrayBIII == IntPtr.Zero)
				id_decode_arrayBIII = JNIEnv.GetStaticMethodID (class_ref, "decode", "([BIII)[B");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_decode_arrayBIII, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_decode_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.io']/class[@name='Base64']/method[@name='decode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("decode", "(Ljava/lang/String;)[B", "")]
		public static unsafe byte[] Decode (string p0)
		{
			if (id_decode_Ljava_lang_String_ == IntPtr.Zero)
				id_decode_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "decode", "(Ljava/lang/String;)[B");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_decode_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_decode_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.io']/class[@name='Base64']/method[@name='decode' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("decode", "(Ljava/lang/String;I)[B", "")]
		public static unsafe byte[] Decode (string p0, int p1)
		{
			if (id_decode_Ljava_lang_String_I == IntPtr.Zero)
				id_decode_Ljava_lang_String_I = JNIEnv.GetStaticMethodID (class_ref, "decode", "(Ljava/lang/String;I)[B");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_decode_Ljava_lang_String_I, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_decodeFileToFile_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.io']/class[@name='Base64']/method[@name='decodeFileToFile' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("decodeFileToFile", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void DecodeFileToFile (string p0, string p1)
		{
			if (id_decodeFileToFile_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_decodeFileToFile_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "decodeFileToFile", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_decodeFileToFile_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_decodeFromFile_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.io']/class[@name='Base64']/method[@name='decodeFromFile' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("decodeFromFile", "(Ljava/lang/String;)[B", "")]
		public static unsafe byte[] DecodeFromFile (string p0)
		{
			if (id_decodeFromFile_Ljava_lang_String_ == IntPtr.Zero)
				id_decodeFromFile_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "decodeFromFile", "(Ljava/lang/String;)[B");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_decodeFromFile_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_decodeToFile_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.io']/class[@name='Base64']/method[@name='decodeToFile' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("decodeToFile", "(Ljava/lang/String;Ljava/lang/String;)Z", "")]
		public static unsafe bool DecodeToFile (string p0, string p1)
		{
			if (id_decodeToFile_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_decodeToFile_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "decodeToFile", "(Ljava/lang/String;Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_decodeToFile_Ljava_lang_String_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_decodeToObject_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.io']/class[@name='Base64']/method[@name='decodeToObject' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("decodeToObject", "(Ljava/lang/String;)Ljava/lang/Object;", "")]
		public static unsafe global::Java.Lang.Object DecodeToObject (string p0)
		{
			if (id_decodeToObject_Ljava_lang_String_ == IntPtr.Zero)
				id_decodeToObject_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "decodeToObject", "(Ljava/lang/String;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Java.Lang.Object __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_decodeToObject_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_encodeBytes_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.io']/class[@name='Base64']/method[@name='encodeBytes' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("encodeBytes", "([B)Ljava/lang/String;", "")]
		public static unsafe string EncodeBytes (byte[] p0)
		{
			if (id_encodeBytes_arrayB == IntPtr.Zero)
				id_encodeBytes_arrayB = JNIEnv.GetStaticMethodID (class_ref, "encodeBytes", "([B)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_encodeBytes_arrayB, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_encodeBytes_arrayBI;
		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.io']/class[@name='Base64']/method[@name='encodeBytes' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("encodeBytes", "([BI)Ljava/lang/String;", "")]
		public static unsafe string EncodeBytes (byte[] p0, int p1)
		{
			if (id_encodeBytes_arrayBI == IntPtr.Zero)
				id_encodeBytes_arrayBI = JNIEnv.GetStaticMethodID (class_ref, "encodeBytes", "([BI)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_encodeBytes_arrayBI, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_encodeBytes_arrayBII;
		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.io']/class[@name='Base64']/method[@name='encodeBytes' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("encodeBytes", "([BII)Ljava/lang/String;", "")]
		public static unsafe string EncodeBytes (byte[] p0, int p1, int p2)
		{
			if (id_encodeBytes_arrayBII == IntPtr.Zero)
				id_encodeBytes_arrayBII = JNIEnv.GetStaticMethodID (class_ref, "encodeBytes", "([BII)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_encodeBytes_arrayBII, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_encodeBytes_arrayBIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.io']/class[@name='Base64']/method[@name='encodeBytes' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("encodeBytes", "([BIII)Ljava/lang/String;", "")]
		public static unsafe string EncodeBytes (byte[] p0, int p1, int p2, int p3)
		{
			if (id_encodeBytes_arrayBIII == IntPtr.Zero)
				id_encodeBytes_arrayBIII = JNIEnv.GetStaticMethodID (class_ref, "encodeBytes", "([BIII)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_encodeBytes_arrayBIII, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_encodeFileToFile_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.io']/class[@name='Base64']/method[@name='encodeFileToFile' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("encodeFileToFile", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void EncodeFileToFile (string p0, string p1)
		{
			if (id_encodeFileToFile_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_encodeFileToFile_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "encodeFileToFile", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_encodeFileToFile_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_encodeFromFile_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.io']/class[@name='Base64']/method[@name='encodeFromFile' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("encodeFromFile", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string EncodeFromFile (string p0)
		{
			if (id_encodeFromFile_Ljava_lang_String_ == IntPtr.Zero)
				id_encodeFromFile_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "encodeFromFile", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_encodeFromFile_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_encodeObject_Ljava_io_Serializable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.io']/class[@name='Base64']/method[@name='encodeObject' and count(parameter)=1 and parameter[1][@type='java.io.Serializable']]"
		[Register ("encodeObject", "(Ljava/io/Serializable;)Ljava/lang/String;", "")]
		public static unsafe string EncodeObject (global::Java.IO.ISerializable p0)
		{
			if (id_encodeObject_Ljava_io_Serializable_ == IntPtr.Zero)
				id_encodeObject_Ljava_io_Serializable_ = JNIEnv.GetStaticMethodID (class_ref, "encodeObject", "(Ljava/io/Serializable;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_encodeObject_Ljava_io_Serializable_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_encodeObject_Ljava_io_Serializable_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.io']/class[@name='Base64']/method[@name='encodeObject' and count(parameter)=2 and parameter[1][@type='java.io.Serializable'] and parameter[2][@type='int']]"
		[Register ("encodeObject", "(Ljava/io/Serializable;I)Ljava/lang/String;", "")]
		public static unsafe string EncodeObject (global::Java.IO.ISerializable p0, int p1)
		{
			if (id_encodeObject_Ljava_io_Serializable_I == IntPtr.Zero)
				id_encodeObject_Ljava_io_Serializable_I = JNIEnv.GetStaticMethodID (class_ref, "encodeObject", "(Ljava/io/Serializable;I)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_encodeObject_Ljava_io_Serializable_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_encodeToFile_arrayBLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.io']/class[@name='Base64']/method[@name='encodeToFile' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='java.lang.String']]"
		[Register ("encodeToFile", "([BLjava/lang/String;)Z", "")]
		public static unsafe bool EncodeToFile (byte[] p0, string p1)
		{
			if (id_encodeToFile_arrayBLjava_lang_String_ == IntPtr.Zero)
				id_encodeToFile_arrayBLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "encodeToFile", "([BLjava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_encodeToFile_arrayBLjava_lang_String_, __args);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_main_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.io']/class[@name='Base64']/method[@name='main' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register ("main", "([Ljava/lang/String;)V", "")]
		public static unsafe void Main (string[] p0)
		{
			if (id_main_arrayLjava_lang_String_ == IntPtr.Zero)
				id_main_arrayLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "main", "([Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_main_arrayLjava_lang_String_, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

	}
}
