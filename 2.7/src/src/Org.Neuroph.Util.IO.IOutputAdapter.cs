using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Util.IO {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.neuroph.util.io']/interface[@name='OutputAdapter']"
	[Register ("org/neuroph/util/io/OutputAdapter", "", "Org.Neuroph.Util.IO.IOutputAdapterInvoker")]
	public partial interface IOutputAdapter : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util.io']/interface[@name='OutputAdapter']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler:Org.Neuroph.Util.IO.IOutputAdapterInvoker, neuroph_2.7")]
		void Close ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util.io']/interface[@name='OutputAdapter']/method[@name='writeOutput' and count(parameter)=1 and parameter[1][@type='double[]']]"
		[Register ("writeOutput", "([D)V", "GetWriteOutput_arrayDHandler:Org.Neuroph.Util.IO.IOutputAdapterInvoker, neuroph_2.7")]
		void WriteOutput (double[] p0);

	}

	[global::Android.Runtime.Register ("org/neuroph/util/io/OutputAdapter", DoNotGenerateAcw=true)]
	internal class IOutputAdapterInvoker : global::Java.Lang.Object, IOutputAdapter {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/neuroph/util/io/OutputAdapter");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IOutputAdapterInvoker); }
		}

		IntPtr class_ref;

		public static IOutputAdapter GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOutputAdapter> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.neuroph.util.io.OutputAdapter"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOutputAdapterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_close;
#pragma warning disable 0169
		static Delegate GetCloseHandler ()
		{
			if (cb_close == null)
				cb_close = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Close);
			return cb_close;
		}

		static void n_Close (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Util.IO.IOutputAdapter __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.IO.IOutputAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		IntPtr id_close;
		public unsafe void Close ()
		{
			if (id_close == IntPtr.Zero)
				id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");
			JNIEnv.CallVoidMethod (Handle, id_close);
		}

		static Delegate cb_writeOutput_arrayD;
#pragma warning disable 0169
		static Delegate GetWriteOutput_arrayDHandler ()
		{
			if (cb_writeOutput_arrayD == null)
				cb_writeOutput_arrayD = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_WriteOutput_arrayD);
			return cb_writeOutput_arrayD;
		}

		static void n_WriteOutput_arrayD (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Util.IO.IOutputAdapter __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.IO.IOutputAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			double[] p0 = (double[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (double));
			__this.WriteOutput (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		IntPtr id_writeOutput_arrayD;
		public unsafe void WriteOutput (double[] p0)
		{
			if (id_writeOutput_arrayD == IntPtr.Zero)
				id_writeOutput_arrayD = JNIEnv.GetMethodID (class_ref, "writeOutput", "([D)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (Handle, id_writeOutput_arrayD, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}

}
