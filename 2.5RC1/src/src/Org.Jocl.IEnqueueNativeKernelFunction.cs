using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jocl {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.jocl']/interface[@name='EnqueueNativeKernelFunction']"
	[Register ("org/jocl/EnqueueNativeKernelFunction", "", "Org.Jocl.IEnqueueNativeKernelFunctionInvoker")]
	public partial interface IEnqueueNativeKernelFunction : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.jocl']/interface[@name='EnqueueNativeKernelFunction']/method[@name='function' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("function", "(Ljava/lang/Object;)V", "GetFunction_Ljava_lang_Object_Handler:Org.Jocl.IEnqueueNativeKernelFunctionInvoker, neuroph_2.5RC1")]
		void Function (global::Java.Lang.Object p0);

	}

	[global::Android.Runtime.Register ("org/jocl/EnqueueNativeKernelFunction", DoNotGenerateAcw=true)]
	internal class IEnqueueNativeKernelFunctionInvoker : global::Java.Lang.Object, IEnqueueNativeKernelFunction {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/jocl/EnqueueNativeKernelFunction");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IEnqueueNativeKernelFunctionInvoker); }
		}

		IntPtr class_ref;

		public static IEnqueueNativeKernelFunction GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IEnqueueNativeKernelFunction> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.jocl.EnqueueNativeKernelFunction"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IEnqueueNativeKernelFunctionInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_function_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetFunction_Ljava_lang_Object_Handler ()
		{
			if (cb_function_Ljava_lang_Object_ == null)
				cb_function_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Function_Ljava_lang_Object_);
			return cb_function_Ljava_lang_Object_;
		}

		static void n_Function_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Jocl.IEnqueueNativeKernelFunction __this = global::Java.Lang.Object.GetObject<global::Org.Jocl.IEnqueueNativeKernelFunction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Function (p0);
		}
#pragma warning restore 0169

		IntPtr id_function_Ljava_lang_Object_;
		public unsafe void Function (global::Java.Lang.Object p0)
		{
			if (id_function_Ljava_lang_Object_ == IntPtr.Zero)
				id_function_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "function", "(Ljava/lang/Object;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_function_Ljava_lang_Object_, __args);
		}

	}

}
