using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Encog.Engine.Concurrency {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.encog.engine.concurrency']/interface[@name='EngineTask']"
	[Register ("org/encog/engine/concurrency/EngineTask", "", "Org.Encog.Engine.Concurrency.IEngineTaskInvoker")]
	public partial interface IEngineTask : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.concurrency']/interface[@name='EngineTask']/method[@name='run' and count(parameter)=0]"
		[Register ("run", "()V", "GetRunHandler:Org.Encog.Engine.Concurrency.IEngineTaskInvoker, neuroph_2.5RC1")]
		void Run ();

	}

	[global::Android.Runtime.Register ("org/encog/engine/concurrency/EngineTask", DoNotGenerateAcw=true)]
	internal class IEngineTaskInvoker : global::Java.Lang.Object, IEngineTask {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/encog/engine/concurrency/EngineTask");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IEngineTaskInvoker); }
		}

		IntPtr class_ref;

		public static IEngineTask GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IEngineTask> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.encog.engine.concurrency.EngineTask"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IEngineTaskInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_run;
#pragma warning disable 0169
		static Delegate GetRunHandler ()
		{
			if (cb_run == null)
				cb_run = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Run);
			return cb_run;
		}

		static void n_Run (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Concurrency.IEngineTask __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Concurrency.IEngineTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Run ();
		}
#pragma warning restore 0169

		IntPtr id_run;
		public unsafe void Run ()
		{
			if (id_run == IntPtr.Zero)
				id_run = JNIEnv.GetMethodID (class_ref, "run", "()V");
			JNIEnv.CallVoidMethod (Handle, id_run);
		}

	}

}
