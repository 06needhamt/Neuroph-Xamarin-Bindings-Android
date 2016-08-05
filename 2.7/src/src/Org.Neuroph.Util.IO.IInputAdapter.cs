using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Util.IO {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.neuroph.util.io']/interface[@name='InputAdapter']"
	[Register ("org/neuroph/util/io/InputAdapter", "", "Org.Neuroph.Util.IO.IInputAdapterInvoker")]
	public partial interface IInputAdapter : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util.io']/interface[@name='InputAdapter']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler:Org.Neuroph.Util.IO.IInputAdapterInvoker, neuroph_2.7")]
		void Close ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util.io']/interface[@name='InputAdapter']/method[@name='readInput' and count(parameter)=0]"
		[Register ("readInput", "()[D", "GetReadInputHandler:Org.Neuroph.Util.IO.IInputAdapterInvoker, neuroph_2.7")]
		double[] ReadInput ();

	}

	[global::Android.Runtime.Register ("org/neuroph/util/io/InputAdapter", DoNotGenerateAcw=true)]
	internal class IInputAdapterInvoker : global::Java.Lang.Object, IInputAdapter {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/neuroph/util/io/InputAdapter");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IInputAdapterInvoker); }
		}

		IntPtr class_ref;

		public static IInputAdapter GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IInputAdapter> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.neuroph.util.io.InputAdapter"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IInputAdapterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
			global::Org.Neuroph.Util.IO.IInputAdapter __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.IO.IInputAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_readInput;
#pragma warning disable 0169
		static Delegate GetReadInputHandler ()
		{
			if (cb_readInput == null)
				cb_readInput = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ReadInput);
			return cb_readInput;
		}

		static IntPtr n_ReadInput (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Util.IO.IInputAdapter __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.IO.IInputAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.ReadInput ());
		}
#pragma warning restore 0169

		IntPtr id_readInput;
		public unsafe double[] ReadInput ()
		{
			if (id_readInput == IntPtr.Zero)
				id_readInput = JNIEnv.GetMethodID (class_ref, "readInput", "()[D");
			return (double[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (Handle, id_readInput), JniHandleOwnership.TransferLocalRef, typeof (double));
		}

	}

}
