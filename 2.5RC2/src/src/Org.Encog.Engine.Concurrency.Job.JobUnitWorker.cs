using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Encog.Engine.Concurrency.Job {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.encog.engine.concurrency.job']/class[@name='JobUnitWorker']"
	[global::Android.Runtime.Register ("org/encog/engine/concurrency/job/JobUnitWorker", DoNotGenerateAcw=true)]
	public partial class JobUnitWorker : global::Java.Lang.Object, global::Org.Encog.Engine.Concurrency.IEngineTask {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/encog/engine/concurrency/job/JobUnitWorker", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (JobUnitWorker); }
		}

		protected JobUnitWorker (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_encog_engine_concurrency_job_JobUnitContext_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.encog.engine.concurrency.job']/class[@name='JobUnitWorker']/constructor[@name='JobUnitWorker' and count(parameter)=1 and parameter[1][@type='org.encog.engine.concurrency.job.JobUnitContext']]"
		[Register (".ctor", "(Lorg/encog/engine/concurrency/job/JobUnitContext;)V", "")]
		public unsafe JobUnitWorker (global::Org.Encog.Engine.Concurrency.Job.JobUnitContext p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (JobUnitWorker)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/encog/engine/concurrency/job/JobUnitContext;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/encog/engine/concurrency/job/JobUnitContext;)V", __args);
					return;
				}

				if (id_ctor_Lorg_encog_engine_concurrency_job_JobUnitContext_ == IntPtr.Zero)
					id_ctor_Lorg_encog_engine_concurrency_job_JobUnitContext_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/encog/engine/concurrency/job/JobUnitContext;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_encog_engine_concurrency_job_JobUnitContext_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_encog_engine_concurrency_job_JobUnitContext_, __args);
			} finally {
			}
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
			global::Org.Encog.Engine.Concurrency.Job.JobUnitWorker __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Concurrency.Job.JobUnitWorker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Run ();
		}
#pragma warning restore 0169

		static IntPtr id_run;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.concurrency.job']/class[@name='JobUnitWorker']/method[@name='run' and count(parameter)=0]"
		[Register ("run", "()V", "GetRunHandler")]
		public virtual unsafe void Run ()
		{
			if (id_run == IntPtr.Zero)
				id_run = JNIEnv.GetMethodID (class_ref, "run", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_run);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "run", "()V"));
			} finally {
			}
		}

	}
}
