using System;
using System.Collections.Generic;
using Android.Runtime;

namespace BE.Abeel.Net {

	// Metadata.xml XPath class reference: path="/api/package[@name='be.abeel.net']/class[@name='ClientHttpRequest']"
	[global::Android.Runtime.Register ("be/abeel/net/ClientHttpRequest", DoNotGenerateAcw=true)]
	public partial class ClientHttpRequest : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("be/abeel/net/ClientHttpRequest", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ClientHttpRequest); }
		}

		protected ClientHttpRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='be.abeel.net']/class[@name='ClientHttpRequest']/constructor[@name='ClientHttpRequest' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe ClientHttpRequest (string p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (ClientHttpRequest)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_ctor_Ljava_net_URL_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='be.abeel.net']/class[@name='ClientHttpRequest']/constructor[@name='ClientHttpRequest' and count(parameter)=1 and parameter[1][@type='java.net.URL']]"
		[Register (".ctor", "(Ljava/net/URL;)V", "")]
		public unsafe ClientHttpRequest (global::Java.Net.URL p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (ClientHttpRequest)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/net/URL;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/net/URL;)V", __args);
					return;
				}

				if (id_ctor_Ljava_net_URL_ == IntPtr.Zero)
					id_ctor_Ljava_net_URL_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/net/URL;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_net_URL_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_net_URL_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Ljava_net_URLConnection_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='be.abeel.net']/class[@name='ClientHttpRequest']/constructor[@name='ClientHttpRequest' and count(parameter)=1 and parameter[1][@type='java.net.URLConnection']]"
		[Register (".ctor", "(Ljava/net/URLConnection;)V", "")]
		public unsafe ClientHttpRequest (global::Java.Net.URLConnection p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (ClientHttpRequest)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/net/URLConnection;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/net/URLConnection;)V", __args);
					return;
				}

				if (id_ctor_Ljava_net_URLConnection_ == IntPtr.Zero)
					id_ctor_Ljava_net_URLConnection_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/net/URLConnection;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_net_URLConnection_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_net_URLConnection_, __args);
			} finally {
			}
		}

		static Delegate cb_connect;
#pragma warning disable 0169
		static Delegate GetConnectHandler ()
		{
			if (cb_connect == null)
				cb_connect = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Connect);
			return cb_connect;
		}

		static void n_Connect (IntPtr jnienv, IntPtr native__this)
		{
			global::BE.Abeel.Net.ClientHttpRequest __this = global::Java.Lang.Object.GetObject<global::BE.Abeel.Net.ClientHttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Connect ();
		}
#pragma warning restore 0169

		static IntPtr id_connect;
		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.net']/class[@name='ClientHttpRequest']/method[@name='connect' and count(parameter)=0]"
		[Register ("connect", "()V", "GetConnectHandler")]
		protected virtual unsafe void Connect ()
		{
			if (id_connect == IntPtr.Zero)
				id_connect = JNIEnv.GetMethodID (class_ref, "connect", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_connect);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "connect", "()V"));
			} finally {
			}
		}

		static Delegate cb_newline;
#pragma warning disable 0169
		static Delegate GetNewlineHandler ()
		{
			if (cb_newline == null)
				cb_newline = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Newline);
			return cb_newline;
		}

		static void n_Newline (IntPtr jnienv, IntPtr native__this)
		{
			global::BE.Abeel.Net.ClientHttpRequest __this = global::Java.Lang.Object.GetObject<global::BE.Abeel.Net.ClientHttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Newline ();
		}
#pragma warning restore 0169

		static IntPtr id_newline;
		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.net']/class[@name='ClientHttpRequest']/method[@name='newline' and count(parameter)=0]"
		[Register ("newline", "()V", "GetNewlineHandler")]
		protected virtual unsafe void Newline ()
		{
			if (id_newline == IntPtr.Zero)
				id_newline = JNIEnv.GetMethodID (class_ref, "newline", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_newline);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "newline", "()V"));
			} finally {
			}
		}

		static Delegate cb_post;
#pragma warning disable 0169
		static Delegate GetPostHandler ()
		{
			if (cb_post == null)
				cb_post = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Post);
			return cb_post;
		}

		static IntPtr n_Post (IntPtr jnienv, IntPtr native__this)
		{
			global::BE.Abeel.Net.ClientHttpRequest __this = global::Java.Lang.Object.GetObject<global::BE.Abeel.Net.ClientHttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (__this.Post ());
		}
#pragma warning restore 0169

		static IntPtr id_post;
		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.net']/class[@name='ClientHttpRequest']/method[@name='post' and count(parameter)=0]"
		[Register ("post", "()Ljava/io/InputStream;", "GetPostHandler")]
		public virtual unsafe global::System.IO.Stream Post ()
		{
			if (id_post == IntPtr.Zero)
				id_post = JNIEnv.GetMethodID (class_ref, "post", "()Ljava/io/InputStream;");
			try {

				if (GetType () == ThresholdType)
					return global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_post), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "post", "()Ljava/io/InputStream;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_post_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetPost_arrayLjava_lang_Object_Handler ()
		{
			if (cb_post_arrayLjava_lang_Object_ == null)
				cb_post_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Post_arrayLjava_lang_Object_);
			return cb_post_arrayLjava_lang_Object_;
		}

		static IntPtr n_Post_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BE.Abeel.Net.ClientHttpRequest __this = global::Java.Lang.Object.GetObject<global::BE.Abeel.Net.ClientHttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] p0 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			IntPtr __ret = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (__this.Post (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_post_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.net']/class[@name='ClientHttpRequest']/method[@name='post' and count(parameter)=1 and parameter[1][@type='java.lang.Object[]']]"
		[Register ("post", "([Ljava/lang/Object;)Ljava/io/InputStream;", "GetPost_arrayLjava_lang_Object_Handler")]
		public virtual unsafe global::System.IO.Stream Post (global::Java.Lang.Object[] p0)
		{
			if (id_post_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_post_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "post", "([Ljava/lang/Object;)Ljava/io/InputStream;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::System.IO.Stream __ret;
				if (GetType () == ThresholdType)
					__ret = global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_post_arrayLjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "post", "([Ljava/lang/Object;)Ljava/io/InputStream;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_post_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetPost_Ljava_lang_String_Ljava_lang_Object_Handler ()
		{
			if (cb_post_Ljava_lang_String_Ljava_lang_Object_ == null)
				cb_post_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Post_Ljava_lang_String_Ljava_lang_Object_);
			return cb_post_Ljava_lang_String_Ljava_lang_Object_;
		}

		static IntPtr n_Post_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::BE.Abeel.Net.ClientHttpRequest __this = global::Java.Lang.Object.GetObject<global::BE.Abeel.Net.ClientHttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (__this.Post (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_post_Ljava_lang_String_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.net']/class[@name='ClientHttpRequest']/method[@name='post' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Register ("post", "(Ljava/lang/String;Ljava/lang/Object;)Ljava/io/InputStream;", "GetPost_Ljava_lang_String_Ljava_lang_Object_Handler")]
		public virtual unsafe global::System.IO.Stream Post (string p0, global::Java.Lang.Object p1)
		{
			if (id_post_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
				id_post_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "post", "(Ljava/lang/String;Ljava/lang/Object;)Ljava/io/InputStream;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				global::System.IO.Stream __ret;
				if (GetType () == ThresholdType)
					__ret = global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_post_Ljava_lang_String_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "post", "(Ljava/lang/String;Ljava/lang/Object;)Ljava/io/InputStream;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_post_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetPost_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_Handler ()
		{
			if (cb_post_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_ == null)
				cb_post_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Post_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_);
			return cb_post_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_;
		}

		static IntPtr n_Post_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::BE.Abeel.Net.ClientHttpRequest __this = global::Java.Lang.Object.GetObject<global::BE.Abeel.Net.ClientHttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p3 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p3, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (__this.Post (p0, p1, p2, p3));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_post_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.net']/class[@name='ClientHttpRequest']/method[@name='post' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Object']]"
		[Register ("post", "(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/String;Ljava/lang/Object;)Ljava/io/InputStream;", "GetPost_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_Handler")]
		public virtual unsafe global::System.IO.Stream Post (string p0, global::Java.Lang.Object p1, string p2, global::Java.Lang.Object p3)
		{
			if (id_post_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
				id_post_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "post", "(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/String;Ljava/lang/Object;)Ljava/io/InputStream;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);

				global::System.IO.Stream __ret;
				if (GetType () == ThresholdType)
					__ret = global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_post_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "post", "(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/String;Ljava/lang/Object;)Ljava/io/InputStream;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_post_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetPost_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_Handler ()
		{
			if (cb_post_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_ == null)
				cb_post_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Post_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_);
			return cb_post_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_;
		}

		static IntPtr n_Post_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, IntPtr native_p5)
		{
			global::BE.Abeel.Net.ClientHttpRequest __this = global::Java.Lang.Object.GetObject<global::BE.Abeel.Net.ClientHttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p3 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p3, JniHandleOwnership.DoNotTransfer);
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p5 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p5, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (__this.Post (p0, p1, p2, p3, p4, p5));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_post_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.net']/class[@name='ClientHttpRequest']/method[@name='post' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Object'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.Object']]"
		[Register ("post", "(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/String;Ljava/lang/Object;Ljava/lang/String;Ljava/lang/Object;)Ljava/io/InputStream;", "GetPost_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_Handler")]
		public virtual unsafe global::System.IO.Stream Post (string p0, global::Java.Lang.Object p1, string p2, global::Java.Lang.Object p3, string p4, global::Java.Lang.Object p5)
		{
			if (id_post_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
				id_post_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "post", "(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/String;Ljava/lang/Object;Ljava/lang/String;Ljava/lang/Object;)Ljava/io/InputStream;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (p5);

				global::System.IO.Stream __ret;
				if (GetType () == ThresholdType)
					__ret = global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_post_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "post", "(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/String;Ljava/lang/Object;Ljava/lang/String;Ljava/lang/Object;)Ljava/io/InputStream;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static Delegate cb_post_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetPost_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_Handler ()
		{
			if (cb_post_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_ == null)
				cb_post_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Post_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_);
			return cb_post_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_;
		}

		static IntPtr n_Post_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, IntPtr native_p5, IntPtr native_p6, IntPtr native_p7)
		{
			global::BE.Abeel.Net.ClientHttpRequest __this = global::Java.Lang.Object.GetObject<global::BE.Abeel.Net.ClientHttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p3 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p3, JniHandleOwnership.DoNotTransfer);
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p5 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p5, JniHandleOwnership.DoNotTransfer);
			string p6 = JNIEnv.GetString (native_p6, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p7 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p7, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (__this.Post (p0, p1, p2, p3, p4, p5, p6, p7));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_post_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.net']/class[@name='ClientHttpRequest']/method[@name='post' and count(parameter)=8 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Object'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.Object'] and parameter[7][@type='java.lang.String'] and parameter[8][@type='java.lang.Object']]"
		[Register ("post", "(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/String;Ljava/lang/Object;Ljava/lang/String;Ljava/lang/Object;Ljava/lang/String;Ljava/lang/Object;)Ljava/io/InputStream;", "GetPost_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_Handler")]
		public virtual unsafe global::System.IO.Stream Post (string p0, global::Java.Lang.Object p1, string p2, global::Java.Lang.Object p3, string p4, global::Java.Lang.Object p5, string p6, global::Java.Lang.Object p7)
		{
			if (id_post_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
				id_post_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "post", "(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/String;Ljava/lang/Object;Ljava/lang/String;Ljava/lang/Object;Ljava/lang/String;Ljava/lang/Object;)Ljava/io/InputStream;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			IntPtr native_p6 = JNIEnv.NewString (p6);
			try {
				JValue* __args = stackalloc JValue [8];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (native_p6);
				__args [7] = new JValue (p7);

				global::System.IO.Stream __ret;
				if (GetType () == ThresholdType)
					__ret = global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_post_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "post", "(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/String;Ljava/lang/Object;Ljava/lang/String;Ljava/lang/Object;Ljava/lang/String;Ljava/lang/Object;)Ljava/io/InputStream;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p4);
				JNIEnv.DeleteLocalRef (native_p6);
			}
		}

		static Delegate cb_post_arrayLjava_lang_String_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetPost_arrayLjava_lang_String_arrayLjava_lang_Object_Handler ()
		{
			if (cb_post_arrayLjava_lang_String_arrayLjava_lang_Object_ == null)
				cb_post_arrayLjava_lang_String_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Post_arrayLjava_lang_String_arrayLjava_lang_Object_);
			return cb_post_arrayLjava_lang_String_arrayLjava_lang_Object_;
		}

		static IntPtr n_Post_arrayLjava_lang_String_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::BE.Abeel.Net.ClientHttpRequest __this = global::Java.Lang.Object.GetObject<global::BE.Abeel.Net.ClientHttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] p0 = (string[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (string));
			global::Java.Lang.Object[] p1 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			IntPtr __ret = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (__this.Post (p0, p1));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_post_arrayLjava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.net']/class[@name='ClientHttpRequest']/method[@name='post' and count(parameter)=2 and parameter[1][@type='java.lang.String[]'] and parameter[2][@type='java.lang.Object[]']]"
		[Register ("post", "([Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/InputStream;", "GetPost_arrayLjava_lang_String_arrayLjava_lang_Object_Handler")]
		public virtual unsafe global::System.IO.Stream Post (string[] p0, global::Java.Lang.Object[] p1)
		{
			if (id_post_arrayLjava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_post_arrayLjava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "post", "([Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/InputStream;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				global::System.IO.Stream __ret;
				if (GetType () == ThresholdType)
					__ret = global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_post_arrayLjava_lang_String_arrayLjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "post", "([Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/InputStream;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static IntPtr id_post_Ljava_net_URL_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.net']/class[@name='ClientHttpRequest']/method[@name='post' and count(parameter)=2 and parameter[1][@type='java.net.URL'] and parameter[2][@type='java.lang.Object[]']]"
		[Register ("post", "(Ljava/net/URL;[Ljava/lang/Object;)Ljava/io/InputStream;", "")]
		public static unsafe global::System.IO.Stream Post (global::Java.Net.URL p0, global::Java.Lang.Object[] p1)
		{
			if (id_post_Ljava_net_URL_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_post_Ljava_net_URL_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "post", "(Ljava/net/URL;[Ljava/lang/Object;)Ljava/io/InputStream;");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				global::System.IO.Stream __ret = global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_post_Ljava_net_URL_arrayLjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static IntPtr id_post_Ljava_net_URL_Ljava_lang_String_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.net']/class[@name='ClientHttpRequest']/method[@name='post' and count(parameter)=3 and parameter[1][@type='java.net.URL'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object']]"
		[Register ("post", "(Ljava/net/URL;Ljava/lang/String;Ljava/lang/Object;)Ljava/io/InputStream;", "")]
		public static unsafe global::System.IO.Stream Post (global::Java.Net.URL p0, string p1, global::Java.Lang.Object p2)
		{
			if (id_post_Ljava_net_URL_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
				id_post_Ljava_net_URL_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "post", "(Ljava/net/URL;Ljava/lang/String;Ljava/lang/Object;)Ljava/io/InputStream;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				global::System.IO.Stream __ret = global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_post_Ljava_net_URL_Ljava_lang_String_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_post_Ljava_net_URL_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.net']/class[@name='ClientHttpRequest']/method[@name='post' and count(parameter)=5 and parameter[1][@type='java.net.URL'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.Object']]"
		[Register ("post", "(Ljava/net/URL;Ljava/lang/String;Ljava/lang/Object;Ljava/lang/String;Ljava/lang/Object;)Ljava/io/InputStream;", "")]
		public static unsafe global::System.IO.Stream Post (global::Java.Net.URL p0, string p1, global::Java.Lang.Object p2, string p3, global::Java.Lang.Object p4)
		{
			if (id_post_Ljava_net_URL_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
				id_post_Ljava_net_URL_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "post", "(Ljava/net/URL;Ljava/lang/String;Ljava/lang/Object;Ljava/lang/String;Ljava/lang/Object;)Ljava/io/InputStream;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (p4);
				global::System.IO.Stream __ret = global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_post_Ljava_net_URL_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static IntPtr id_post_Ljava_net_URL_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.net']/class[@name='ClientHttpRequest']/method[@name='post' and count(parameter)=7 and parameter[1][@type='java.net.URL'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.Object'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='java.lang.Object']]"
		[Register ("post", "(Ljava/net/URL;Ljava/lang/String;Ljava/lang/Object;Ljava/lang/String;Ljava/lang/Object;Ljava/lang/String;Ljava/lang/Object;)Ljava/io/InputStream;", "")]
		public static unsafe global::System.IO.Stream Post (global::Java.Net.URL p0, string p1, global::Java.Lang.Object p2, string p3, global::Java.Lang.Object p4, string p5, global::Java.Lang.Object p6)
		{
			if (id_post_Ljava_net_URL_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
				id_post_Ljava_net_URL_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "post", "(Ljava/net/URL;Ljava/lang/String;Ljava/lang/Object;Ljava/lang/String;Ljava/lang/Object;Ljava/lang/String;Ljava/lang/Object;)Ljava/io/InputStream;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p5 = JNIEnv.NewString (p5);
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (native_p5);
				__args [6] = new JValue (p6);
				global::System.IO.Stream __ret = global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_post_Ljava_net_URL_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p5);
			}
		}

		static IntPtr id_post_Ljava_net_URL_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.net']/class[@name='ClientHttpRequest']/method[@name='post' and count(parameter)=9 and parameter[1][@type='java.net.URL'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.Object'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='java.lang.Object'] and parameter[8][@type='java.lang.String'] and parameter[9][@type='java.lang.Object']]"
		[Register ("post", "(Ljava/net/URL;Ljava/lang/String;Ljava/lang/Object;Ljava/lang/String;Ljava/lang/Object;Ljava/lang/String;Ljava/lang/Object;Ljava/lang/String;Ljava/lang/Object;)Ljava/io/InputStream;", "")]
		public static unsafe global::System.IO.Stream Post (global::Java.Net.URL p0, string p1, global::Java.Lang.Object p2, string p3, global::Java.Lang.Object p4, string p5, global::Java.Lang.Object p6, string p7, global::Java.Lang.Object p8)
		{
			if (id_post_Ljava_net_URL_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
				id_post_Ljava_net_URL_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "post", "(Ljava/net/URL;Ljava/lang/String;Ljava/lang/Object;Ljava/lang/String;Ljava/lang/Object;Ljava/lang/String;Ljava/lang/Object;Ljava/lang/String;Ljava/lang/Object;)Ljava/io/InputStream;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p5 = JNIEnv.NewString (p5);
			IntPtr native_p7 = JNIEnv.NewString (p7);
			try {
				JValue* __args = stackalloc JValue [9];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (native_p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (native_p7);
				__args [8] = new JValue (p8);
				global::System.IO.Stream __ret = global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_post_Ljava_net_URL_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p5);
				JNIEnv.DeleteLocalRef (native_p7);
			}
		}

		static IntPtr id_post_Ljava_net_URL_arrayLjava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.net']/class[@name='ClientHttpRequest']/method[@name='post' and count(parameter)=3 and parameter[1][@type='java.net.URL'] and parameter[2][@type='java.lang.String[]'] and parameter[3][@type='java.lang.Object[]']]"
		[Register ("post", "(Ljava/net/URL;[Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/InputStream;", "")]
		public static unsafe global::System.IO.Stream Post (global::Java.Net.URL p0, string[] p1, global::Java.Lang.Object[] p2)
		{
			if (id_post_Ljava_net_URL_arrayLjava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_post_Ljava_net_URL_arrayLjava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "post", "(Ljava/net/URL;[Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/InputStream;");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				global::System.IO.Stream __ret = global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_post_Ljava_net_URL_arrayLjava_lang_String_arrayLjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static IntPtr id_post_Ljava_net_URL_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.net']/class[@name='ClientHttpRequest']/method[@name='post' and count(parameter)=2 and parameter[1][@type='java.net.URL'] and parameter[2][@type='java.util.Map']]"
		[Register ("post", "(Ljava/net/URL;Ljava/util/Map;)Ljava/io/InputStream;", "")]
		public static unsafe global::System.IO.Stream Post (global::Java.Net.URL p0, global::System.Collections.IDictionary p1)
		{
			if (id_post_Ljava_net_URL_Ljava_util_Map_ == IntPtr.Zero)
				id_post_Ljava_net_URL_Ljava_util_Map_ = JNIEnv.GetStaticMethodID (class_ref, "post", "(Ljava/net/URL;Ljava/util/Map;)Ljava/io/InputStream;");
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				global::System.IO.Stream __ret = global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_post_Ljava_net_URL_Ljava_util_Map_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_post_Ljava_net_URL_Ljava_util_Map_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.net']/class[@name='ClientHttpRequest']/method[@name='post' and count(parameter)=3 and parameter[1][@type='java.net.URL'] and parameter[2][@type='java.util.Map'] and parameter[3][@type='java.util.Map']]"
		[Register ("post", "(Ljava/net/URL;Ljava/util/Map;Ljava/util/Map;)Ljava/io/InputStream;", "")]
		public static unsafe global::System.IO.Stream Post (global::Java.Net.URL p0, global::System.Collections.IDictionary p1, global::System.Collections.IDictionary p2)
		{
			if (id_post_Ljava_net_URL_Ljava_util_Map_Ljava_util_Map_ == IntPtr.Zero)
				id_post_Ljava_net_URL_Ljava_util_Map_Ljava_util_Map_ = JNIEnv.GetStaticMethodID (class_ref, "post", "(Ljava/net/URL;Ljava/util/Map;Ljava/util/Map;)Ljava/io/InputStream;");
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (p1);
			IntPtr native_p2 = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				global::System.IO.Stream __ret = global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_post_Ljava_net_URL_Ljava_util_Map_Ljava_util_Map_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_post_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetPost_Ljava_util_Map_Handler ()
		{
			if (cb_post_Ljava_util_Map_ == null)
				cb_post_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Post_Ljava_util_Map_);
			return cb_post_Ljava_util_Map_;
		}

		static IntPtr n_Post_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BE.Abeel.Net.ClientHttpRequest __this = global::Java.Lang.Object.GetObject<global::BE.Abeel.Net.ClientHttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (__this.Post (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_post_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.net']/class[@name='ClientHttpRequest']/method[@name='post' and count(parameter)=1 and parameter[1][@type='java.util.Map']]"
		[Register ("post", "(Ljava/util/Map;)Ljava/io/InputStream;", "GetPost_Ljava_util_Map_Handler")]
		public virtual unsafe global::System.IO.Stream Post (global::System.Collections.IDictionary p0)
		{
			if (id_post_Ljava_util_Map_ == IntPtr.Zero)
				id_post_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "post", "(Ljava/util/Map;)Ljava/io/InputStream;");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::System.IO.Stream __ret;
				if (GetType () == ThresholdType)
					__ret = global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_post_Ljava_util_Map_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "post", "(Ljava/util/Map;)Ljava/io/InputStream;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_post_Ljava_util_Map_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetPost_Ljava_util_Map_Ljava_util_Map_Handler ()
		{
			if (cb_post_Ljava_util_Map_Ljava_util_Map_ == null)
				cb_post_Ljava_util_Map_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Post_Ljava_util_Map_Ljava_util_Map_);
			return cb_post_Ljava_util_Map_Ljava_util_Map_;
		}

		static IntPtr n_Post_Ljava_util_Map_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::BE.Abeel.Net.ClientHttpRequest __this = global::Java.Lang.Object.GetObject<global::BE.Abeel.Net.ClientHttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaDictionary.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (__this.Post (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_post_Ljava_util_Map_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.net']/class[@name='ClientHttpRequest']/method[@name='post' and count(parameter)=2 and parameter[1][@type='java.util.Map'] and parameter[2][@type='java.util.Map']]"
		[Register ("post", "(Ljava/util/Map;Ljava/util/Map;)Ljava/io/InputStream;", "GetPost_Ljava_util_Map_Ljava_util_Map_Handler")]
		public virtual unsafe global::System.IO.Stream Post (global::System.Collections.IDictionary p0, global::System.Collections.IDictionary p1)
		{
			if (id_post_Ljava_util_Map_Ljava_util_Map_ == IntPtr.Zero)
				id_post_Ljava_util_Map_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "post", "(Ljava/util/Map;Ljava/util/Map;)Ljava/io/InputStream;");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				global::System.IO.Stream __ret;
				if (GetType () == ThresholdType)
					__ret = global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_post_Ljava_util_Map_Ljava_util_Map_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "post", "(Ljava/util/Map;Ljava/util/Map;)Ljava/io/InputStream;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_randomString;
		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.net']/class[@name='ClientHttpRequest']/method[@name='randomString' and count(parameter)=0]"
		[Register ("randomString", "()Ljava/lang/String;", "")]
		protected static unsafe string RandomString ()
		{
			if (id_randomString == IntPtr.Zero)
				id_randomString = JNIEnv.GetStaticMethodID (class_ref, "randomString", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_randomString), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setCookie_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCookie_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_setCookie_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_setCookie_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetCookie_Ljava_lang_String_Ljava_lang_String_);
			return cb_setCookie_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_SetCookie_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::BE.Abeel.Net.ClientHttpRequest __this = global::Java.Lang.Object.GetObject<global::BE.Abeel.Net.ClientHttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetCookie (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setCookie_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.net']/class[@name='ClientHttpRequest']/method[@name='setCookie' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("setCookie", "(Ljava/lang/String;Ljava/lang/String;)V", "GetSetCookie_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void SetCookie (string p0, string p1)
		{
			if (id_setCookie_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_setCookie_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCookie", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCookie_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCookie", "(Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_setCookies_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCookies_arrayLjava_lang_String_Handler ()
		{
			if (cb_setCookies_arrayLjava_lang_String_ == null)
				cb_setCookies_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCookies_arrayLjava_lang_String_);
			return cb_setCookies_arrayLjava_lang_String_;
		}

		static void n_SetCookies_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BE.Abeel.Net.ClientHttpRequest __this = global::Java.Lang.Object.GetObject<global::BE.Abeel.Net.ClientHttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] p0 = (string[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (string));
			__this.SetCookies (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_setCookies_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.net']/class[@name='ClientHttpRequest']/method[@name='setCookies' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register ("setCookies", "([Ljava/lang/String;)V", "GetSetCookies_arrayLjava_lang_String_Handler")]
		public virtual unsafe void SetCookies (string[] p0)
		{
			if (id_setCookies_arrayLjava_lang_String_ == IntPtr.Zero)
				id_setCookies_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCookies", "([Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCookies_arrayLjava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCookies", "([Ljava/lang/String;)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_setCookies_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetSetCookies_Ljava_util_Map_Handler ()
		{
			if (cb_setCookies_Ljava_util_Map_ == null)
				cb_setCookies_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCookies_Ljava_util_Map_);
			return cb_setCookies_Ljava_util_Map_;
		}

		static void n_SetCookies_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BE.Abeel.Net.ClientHttpRequest __this = global::Java.Lang.Object.GetObject<global::BE.Abeel.Net.ClientHttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetCookies (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setCookies_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.net']/class[@name='ClientHttpRequest']/method[@name='setCookies' and count(parameter)=1 and parameter[1][@type='java.util.Map']]"
		[Register ("setCookies", "(Ljava/util/Map;)V", "GetSetCookies_Ljava_util_Map_Handler")]
		public virtual unsafe void SetCookies (global::System.Collections.IDictionary p0)
		{
			if (id_setCookies_Ljava_util_Map_ == IntPtr.Zero)
				id_setCookies_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "setCookies", "(Ljava/util/Map;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCookies_Ljava_util_Map_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCookies", "(Ljava/util/Map;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setParameter_Ljava_lang_String_Ljava_io_File_;
#pragma warning disable 0169
		static Delegate GetSetParameter_Ljava_lang_String_Ljava_io_File_Handler ()
		{
			if (cb_setParameter_Ljava_lang_String_Ljava_io_File_ == null)
				cb_setParameter_Ljava_lang_String_Ljava_io_File_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetParameter_Ljava_lang_String_Ljava_io_File_);
			return cb_setParameter_Ljava_lang_String_Ljava_io_File_;
		}

		static void n_SetParameter_Ljava_lang_String_Ljava_io_File_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::BE.Abeel.Net.ClientHttpRequest __this = global::Java.Lang.Object.GetObject<global::BE.Abeel.Net.ClientHttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.File p1 = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetParameter (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setParameter_Ljava_lang_String_Ljava_io_File_;
		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.net']/class[@name='ClientHttpRequest']/method[@name='setParameter' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.io.File']]"
		[Register ("setParameter", "(Ljava/lang/String;Ljava/io/File;)V", "GetSetParameter_Ljava_lang_String_Ljava_io_File_Handler")]
		public virtual unsafe void SetParameter (string p0, global::Java.IO.File p1)
		{
			if (id_setParameter_Ljava_lang_String_Ljava_io_File_ == IntPtr.Zero)
				id_setParameter_Ljava_lang_String_Ljava_io_File_ = JNIEnv.GetMethodID (class_ref, "setParameter", "(Ljava/lang/String;Ljava/io/File;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setParameter_Ljava_lang_String_Ljava_io_File_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setParameter", "(Ljava/lang/String;Ljava/io/File;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setParameter_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSetParameter_Ljava_lang_String_Ljava_lang_Object_Handler ()
		{
			if (cb_setParameter_Ljava_lang_String_Ljava_lang_Object_ == null)
				cb_setParameter_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetParameter_Ljava_lang_String_Ljava_lang_Object_);
			return cb_setParameter_Ljava_lang_String_Ljava_lang_Object_;
		}

		static void n_SetParameter_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::BE.Abeel.Net.ClientHttpRequest __this = global::Java.Lang.Object.GetObject<global::BE.Abeel.Net.ClientHttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetParameter (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setParameter_Ljava_lang_String_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.net']/class[@name='ClientHttpRequest']/method[@name='setParameter' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Register ("setParameter", "(Ljava/lang/String;Ljava/lang/Object;)V", "GetSetParameter_Ljava_lang_String_Ljava_lang_Object_Handler")]
		public virtual unsafe void SetParameter (string p0, global::Java.Lang.Object p1)
		{
			if (id_setParameter_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
				id_setParameter_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "setParameter", "(Ljava/lang/String;Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setParameter_Ljava_lang_String_Ljava_lang_Object_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setParameter", "(Ljava/lang/String;Ljava/lang/Object;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setParameter_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetParameter_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_setParameter_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_setParameter_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetParameter_Ljava_lang_String_Ljava_lang_String_);
			return cb_setParameter_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_SetParameter_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::BE.Abeel.Net.ClientHttpRequest __this = global::Java.Lang.Object.GetObject<global::BE.Abeel.Net.ClientHttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetParameter (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setParameter_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.net']/class[@name='ClientHttpRequest']/method[@name='setParameter' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("setParameter", "(Ljava/lang/String;Ljava/lang/String;)V", "GetSetParameter_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void SetParameter (string p0, string p1)
		{
			if (id_setParameter_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_setParameter_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setParameter", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setParameter_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setParameter", "(Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_setParameter_Ljava_lang_String_Ljava_lang_String_Ljava_io_InputStream_;
#pragma warning disable 0169
		static Delegate GetSetParameter_Ljava_lang_String_Ljava_lang_String_Ljava_io_InputStream_Handler ()
		{
			if (cb_setParameter_Ljava_lang_String_Ljava_lang_String_Ljava_io_InputStream_ == null)
				cb_setParameter_Ljava_lang_String_Ljava_lang_String_Ljava_io_InputStream_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SetParameter_Ljava_lang_String_Ljava_lang_String_Ljava_io_InputStream_);
			return cb_setParameter_Ljava_lang_String_Ljava_lang_String_Ljava_io_InputStream_;
		}

		static void n_SetParameter_Ljava_lang_String_Ljava_lang_String_Ljava_io_InputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::BE.Abeel.Net.ClientHttpRequest __this = global::Java.Lang.Object.GetObject<global::BE.Abeel.Net.ClientHttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream p2 = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.SetParameter (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_setParameter_Ljava_lang_String_Ljava_lang_String_Ljava_io_InputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.net']/class[@name='ClientHttpRequest']/method[@name='setParameter' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.io.InputStream']]"
		[Register ("setParameter", "(Ljava/lang/String;Ljava/lang/String;Ljava/io/InputStream;)V", "GetSetParameter_Ljava_lang_String_Ljava_lang_String_Ljava_io_InputStream_Handler")]
		public virtual unsafe void SetParameter (string p0, string p1, global::System.IO.Stream p2)
		{
			if (id_setParameter_Ljava_lang_String_Ljava_lang_String_Ljava_io_InputStream_ == IntPtr.Zero)
				id_setParameter_Ljava_lang_String_Ljava_lang_String_Ljava_io_InputStream_ = JNIEnv.GetMethodID (class_ref, "setParameter", "(Ljava/lang/String;Ljava/lang/String;Ljava/io/InputStream;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setParameter_Ljava_lang_String_Ljava_lang_String_Ljava_io_InputStream_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setParameter", "(Ljava/lang/String;Ljava/lang/String;Ljava/io/InputStream;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_setParameters_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSetParameters_arrayLjava_lang_Object_Handler ()
		{
			if (cb_setParameters_arrayLjava_lang_Object_ == null)
				cb_setParameters_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetParameters_arrayLjava_lang_Object_);
			return cb_setParameters_arrayLjava_lang_Object_;
		}

		static void n_SetParameters_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BE.Abeel.Net.ClientHttpRequest __this = global::Java.Lang.Object.GetObject<global::BE.Abeel.Net.ClientHttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] p0 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			__this.SetParameters (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_setParameters_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.net']/class[@name='ClientHttpRequest']/method[@name='setParameters' and count(parameter)=1 and parameter[1][@type='java.lang.Object[]']]"
		[Register ("setParameters", "([Ljava/lang/Object;)V", "GetSetParameters_arrayLjava_lang_Object_Handler")]
		public virtual unsafe void SetParameters (global::Java.Lang.Object[] p0)
		{
			if (id_setParameters_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_setParameters_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "setParameters", "([Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setParameters_arrayLjava_lang_Object_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setParameters", "([Ljava/lang/Object;)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_setParameters_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetSetParameters_Ljava_util_Map_Handler ()
		{
			if (cb_setParameters_Ljava_util_Map_ == null)
				cb_setParameters_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetParameters_Ljava_util_Map_);
			return cb_setParameters_Ljava_util_Map_;
		}

		static void n_SetParameters_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BE.Abeel.Net.ClientHttpRequest __this = global::Java.Lang.Object.GetObject<global::BE.Abeel.Net.ClientHttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetParameters (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setParameters_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.net']/class[@name='ClientHttpRequest']/method[@name='setParameters' and count(parameter)=1 and parameter[1][@type='java.util.Map']]"
		[Register ("setParameters", "(Ljava/util/Map;)V", "GetSetParameters_Ljava_util_Map_Handler")]
		public virtual unsafe void SetParameters (global::System.Collections.IDictionary p0)
		{
			if (id_setParameters_Ljava_util_Map_ == IntPtr.Zero)
				id_setParameters_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "setParameters", "(Ljava/util/Map;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setParameters_Ljava_util_Map_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setParameters", "(Ljava/util/Map;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_write_C;
#pragma warning disable 0169
		static Delegate GetWrite_CHandler ()
		{
			if (cb_write_C == null)
				cb_write_C = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, char>) n_Write_C);
			return cb_write_C;
		}

		static void n_Write_C (IntPtr jnienv, IntPtr native__this, char p0)
		{
			global::BE.Abeel.Net.ClientHttpRequest __this = global::Java.Lang.Object.GetObject<global::BE.Abeel.Net.ClientHttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Write (p0);
		}
#pragma warning restore 0169

		static IntPtr id_write_C;
		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.net']/class[@name='ClientHttpRequest']/method[@name='write' and count(parameter)=1 and parameter[1][@type='char']]"
		[Register ("write", "(C)V", "GetWrite_CHandler")]
		protected virtual unsafe void Write (char p0)
		{
			if (id_write_C == IntPtr.Zero)
				id_write_C = JNIEnv.GetMethodID (class_ref, "write", "(C)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_write_C, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "write", "(C)V"), __args);
			} finally {
			}
		}

		static Delegate cb_write_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetWrite_Ljava_lang_String_Handler ()
		{
			if (cb_write_Ljava_lang_String_ == null)
				cb_write_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Write_Ljava_lang_String_);
			return cb_write_Ljava_lang_String_;
		}

		static void n_Write_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BE.Abeel.Net.ClientHttpRequest __this = global::Java.Lang.Object.GetObject<global::BE.Abeel.Net.ClientHttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Write (p0);
		}
#pragma warning restore 0169

		static IntPtr id_write_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.net']/class[@name='ClientHttpRequest']/method[@name='write' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("write", "(Ljava/lang/String;)V", "GetWrite_Ljava_lang_String_Handler")]
		protected virtual unsafe void Write (string p0)
		{
			if (id_write_Ljava_lang_String_ == IntPtr.Zero)
				id_write_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "write", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_write_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "write", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_writeln_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetWriteln_Ljava_lang_String_Handler ()
		{
			if (cb_writeln_Ljava_lang_String_ == null)
				cb_writeln_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Writeln_Ljava_lang_String_);
			return cb_writeln_Ljava_lang_String_;
		}

		static void n_Writeln_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BE.Abeel.Net.ClientHttpRequest __this = global::Java.Lang.Object.GetObject<global::BE.Abeel.Net.ClientHttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Writeln (p0);
		}
#pragma warning restore 0169

		static IntPtr id_writeln_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.net']/class[@name='ClientHttpRequest']/method[@name='writeln' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("writeln", "(Ljava/lang/String;)V", "GetWriteln_Ljava_lang_String_Handler")]
		protected virtual unsafe void Writeln (string p0)
		{
			if (id_writeln_Ljava_lang_String_ == IntPtr.Zero)
				id_writeln_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "writeln", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_writeln_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeln", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
