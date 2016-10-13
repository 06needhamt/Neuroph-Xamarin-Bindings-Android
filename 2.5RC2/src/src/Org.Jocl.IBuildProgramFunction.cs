using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jocl {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.jocl']/interface[@name='BuildProgramFunction']"
	[Register ("org/jocl/BuildProgramFunction", "", "Org.Jocl.IBuildProgramFunctionInvoker")]
	public partial interface IBuildProgramFunction : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.jocl']/interface[@name='BuildProgramFunction']/method[@name='function' and count(parameter)=2 and parameter[1][@type='org.jocl.cl_program'] and parameter[2][@type='java.lang.Object']]"
		[Register ("function", "(Lorg/jocl/cl_program;Ljava/lang/Object;)V", "GetFunction_Lorg_jocl_cl_program_Ljava_lang_Object_Handler:Org.Jocl.IBuildProgramFunctionInvoker, neuroph_2.5RC2")]
		void Function (global::Org.Jocl.Cl_program p0, global::Java.Lang.Object p1);

	}

	[global::Android.Runtime.Register ("org/jocl/BuildProgramFunction", DoNotGenerateAcw=true)]
	internal class IBuildProgramFunctionInvoker : global::Java.Lang.Object, IBuildProgramFunction {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/jocl/BuildProgramFunction");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IBuildProgramFunctionInvoker); }
		}

		IntPtr class_ref;

		public static IBuildProgramFunction GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBuildProgramFunction> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.jocl.BuildProgramFunction"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBuildProgramFunctionInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_function_Lorg_jocl_cl_program_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetFunction_Lorg_jocl_cl_program_Ljava_lang_Object_Handler ()
		{
			if (cb_function_Lorg_jocl_cl_program_Ljava_lang_Object_ == null)
				cb_function_Lorg_jocl_cl_program_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Function_Lorg_jocl_cl_program_Ljava_lang_Object_);
			return cb_function_Lorg_jocl_cl_program_Ljava_lang_Object_;
		}

		static void n_Function_Lorg_jocl_cl_program_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Jocl.IBuildProgramFunction __this = global::Java.Lang.Object.GetObject<global::Org.Jocl.IBuildProgramFunction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jocl.Cl_program p0 = global::Java.Lang.Object.GetObject<global::Org.Jocl.Cl_program> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Function (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_function_Lorg_jocl_cl_program_Ljava_lang_Object_;
		public unsafe void Function (global::Org.Jocl.Cl_program p0, global::Java.Lang.Object p1)
		{
			if (id_function_Lorg_jocl_cl_program_Ljava_lang_Object_ == IntPtr.Zero)
				id_function_Lorg_jocl_cl_program_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "function", "(Lorg/jocl/cl_program;Ljava/lang/Object;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_function_Lorg_jocl_cl_program_Ljava_lang_Object_, __args);
		}

	}

}
