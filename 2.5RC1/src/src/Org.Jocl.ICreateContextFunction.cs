using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jocl {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.jocl']/interface[@name='CreateContextFunction']"
	[Register ("org/jocl/CreateContextFunction", "", "Org.Jocl.ICreateContextFunctionInvoker")]
	public partial interface ICreateContextFunction : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.jocl']/interface[@name='CreateContextFunction']/method[@name='function' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.jocl.Pointer'] and parameter[3][@type='long'] and parameter[4][@type='java.lang.Object']]"
		[Register ("function", "(Ljava/lang/String;Lorg/jocl/Pointer;JLjava/lang/Object;)V", "GetFunction_Ljava_lang_String_Lorg_jocl_Pointer_JLjava_lang_Object_Handler:Org.Jocl.ICreateContextFunctionInvoker, neuroph_2.5RC1")]
		void Function (string p0, global::Org.Jocl.Pointer p1, long p2, global::Java.Lang.Object p3);

	}

	[global::Android.Runtime.Register ("org/jocl/CreateContextFunction", DoNotGenerateAcw=true)]
	internal class ICreateContextFunctionInvoker : global::Java.Lang.Object, ICreateContextFunction {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/jocl/CreateContextFunction");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ICreateContextFunctionInvoker); }
		}

		IntPtr class_ref;

		public static ICreateContextFunction GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICreateContextFunction> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.jocl.CreateContextFunction"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICreateContextFunctionInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_function_Ljava_lang_String_Lorg_jocl_Pointer_JLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetFunction_Ljava_lang_String_Lorg_jocl_Pointer_JLjava_lang_Object_Handler ()
		{
			if (cb_function_Ljava_lang_String_Lorg_jocl_Pointer_JLjava_lang_Object_ == null)
				cb_function_Ljava_lang_String_Lorg_jocl_Pointer_JLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, long, IntPtr>) n_Function_Ljava_lang_String_Lorg_jocl_Pointer_JLjava_lang_Object_);
			return cb_function_Ljava_lang_String_Lorg_jocl_Pointer_JLjava_lang_Object_;
		}

		static void n_Function_Ljava_lang_String_Lorg_jocl_Pointer_JLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, long p2, IntPtr native_p3)
		{
			global::Org.Jocl.ICreateContextFunction __this = global::Java.Lang.Object.GetObject<global::Org.Jocl.ICreateContextFunction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Jocl.Pointer p1 = global::Java.Lang.Object.GetObject<global::Org.Jocl.Pointer> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p3 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.Function (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_function_Ljava_lang_String_Lorg_jocl_Pointer_JLjava_lang_Object_;
		public unsafe void Function (string p0, global::Org.Jocl.Pointer p1, long p2, global::Java.Lang.Object p3)
		{
			if (id_function_Ljava_lang_String_Lorg_jocl_Pointer_JLjava_lang_Object_ == IntPtr.Zero)
				id_function_Ljava_lang_String_Lorg_jocl_Pointer_JLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "function", "(Ljava/lang/String;Lorg/jocl/Pointer;JLjava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			JNIEnv.CallVoidMethod (Handle, id_function_Ljava_lang_String_Lorg_jocl_Pointer_JLjava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

}
