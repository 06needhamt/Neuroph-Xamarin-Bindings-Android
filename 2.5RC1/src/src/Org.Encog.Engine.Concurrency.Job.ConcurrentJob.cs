using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Encog.Engine.Concurrency.Job {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.encog.engine.concurrency.job']/class[@name='ConcurrentJob']"
	[global::Android.Runtime.Register ("org/encog/engine/concurrency/job/ConcurrentJob", DoNotGenerateAcw=true)]
	public abstract partial class ConcurrentJob : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/encog/engine/concurrency/job/ConcurrentJob", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ConcurrentJob); }
		}

		protected ConcurrentJob (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_encog_engine_StatusReportable_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.encog.engine.concurrency.job']/class[@name='ConcurrentJob']/constructor[@name='ConcurrentJob' and count(parameter)=1 and parameter[1][@type='org.encog.engine.StatusReportable']]"
		[Register (".ctor", "(Lorg/encog/engine/StatusReportable;)V", "")]
		public unsafe ConcurrentJob (global::Org.Encog.Engine.IStatusReportable p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (ConcurrentJob)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/encog/engine/StatusReportable;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorg/encog/engine/StatusReportable;)V", __args);
					return;
				}

				if (id_ctor_Lorg_encog_engine_StatusReportable_ == IntPtr.Zero)
					id_ctor_Lorg_encog_engine_StatusReportable_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/encog/engine/StatusReportable;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_encog_engine_StatusReportable_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_encog_engine_StatusReportable_, __args);
			} finally {
			}
		}

		static Delegate cb_getShouldStop;
#pragma warning disable 0169
		static Delegate GetGetShouldStopHandler ()
		{
			if (cb_getShouldStop == null)
				cb_getShouldStop = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetShouldStop);
			return cb_getShouldStop;
		}

		static bool n_GetShouldStop (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Concurrency.Job.ConcurrentJob __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Concurrency.Job.ConcurrentJob> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShouldStop;
		}
#pragma warning restore 0169

		static IntPtr id_getShouldStop;
		public virtual unsafe bool ShouldStop {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.concurrency.job']/class[@name='ConcurrentJob']/method[@name='getShouldStop' and count(parameter)=0]"
			[Register ("getShouldStop", "()Z", "GetGetShouldStopHandler")]
			get {
				if (id_getShouldStop == IntPtr.Zero)
					id_getShouldStop = JNIEnv.GetMethodID (class_ref, "getShouldStop", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_getShouldStop);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getShouldStop", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_loadWorkload;
#pragma warning disable 0169
		static Delegate GetLoadWorkloadHandler ()
		{
			if (cb_loadWorkload == null)
				cb_loadWorkload = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_LoadWorkload);
			return cb_loadWorkload;
		}

		static int n_LoadWorkload (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Concurrency.Job.ConcurrentJob __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Concurrency.Job.ConcurrentJob> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LoadWorkload ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.concurrency.job']/class[@name='ConcurrentJob']/method[@name='loadWorkload' and count(parameter)=0]"
		[Register ("loadWorkload", "()I", "GetLoadWorkloadHandler")]
		public abstract int LoadWorkload ();

		static Delegate cb_performJobUnit_Lorg_encog_engine_concurrency_job_JobUnitContext_;
#pragma warning disable 0169
		static Delegate GetPerformJobUnit_Lorg_encog_engine_concurrency_job_JobUnitContext_Handler ()
		{
			if (cb_performJobUnit_Lorg_encog_engine_concurrency_job_JobUnitContext_ == null)
				cb_performJobUnit_Lorg_encog_engine_concurrency_job_JobUnitContext_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_PerformJobUnit_Lorg_encog_engine_concurrency_job_JobUnitContext_);
			return cb_performJobUnit_Lorg_encog_engine_concurrency_job_JobUnitContext_;
		}

		static void n_PerformJobUnit_Lorg_encog_engine_concurrency_job_JobUnitContext_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Encog.Engine.Concurrency.Job.ConcurrentJob __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Concurrency.Job.ConcurrentJob> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Encog.Engine.Concurrency.Job.JobUnitContext p0 = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Concurrency.Job.JobUnitContext> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PerformJobUnit (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.concurrency.job']/class[@name='ConcurrentJob']/method[@name='performJobUnit' and count(parameter)=1 and parameter[1][@type='org.encog.engine.concurrency.job.JobUnitContext']]"
		[Register ("performJobUnit", "(Lorg/encog/engine/concurrency/job/JobUnitContext;)V", "GetPerformJobUnit_Lorg_encog_engine_concurrency_job_JobUnitContext_Handler")]
		public abstract void PerformJobUnit (global::Org.Encog.Engine.Concurrency.Job.JobUnitContext p0);

		static Delegate cb_process;
#pragma warning disable 0169
		static Delegate GetProcessHandler ()
		{
			if (cb_process == null)
				cb_process = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Process);
			return cb_process;
		}

		static void n_Process (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Concurrency.Job.ConcurrentJob __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Concurrency.Job.ConcurrentJob> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Process ();
		}
#pragma warning restore 0169

		static IntPtr id_process;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.concurrency.job']/class[@name='ConcurrentJob']/method[@name='process' and count(parameter)=0]"
		[Register ("process", "()V", "GetProcessHandler")]
		public virtual unsafe void Process ()
		{
			if (id_process == IntPtr.Zero)
				id_process = JNIEnv.GetMethodID (class_ref, "process", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_process);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "process", "()V"));
			} finally {
			}
		}

		static Delegate cb_reportStatus_Lorg_encog_engine_concurrency_job_JobUnitContext_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetReportStatus_Lorg_encog_engine_concurrency_job_JobUnitContext_Ljava_lang_String_Handler ()
		{
			if (cb_reportStatus_Lorg_encog_engine_concurrency_job_JobUnitContext_Ljava_lang_String_ == null)
				cb_reportStatus_Lorg_encog_engine_concurrency_job_JobUnitContext_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_ReportStatus_Lorg_encog_engine_concurrency_job_JobUnitContext_Ljava_lang_String_);
			return cb_reportStatus_Lorg_encog_engine_concurrency_job_JobUnitContext_Ljava_lang_String_;
		}

		static void n_ReportStatus_Lorg_encog_engine_concurrency_job_JobUnitContext_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Encog.Engine.Concurrency.Job.ConcurrentJob __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Concurrency.Job.ConcurrentJob> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Encog.Engine.Concurrency.Job.JobUnitContext p0 = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Concurrency.Job.JobUnitContext> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.ReportStatus (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_reportStatus_Lorg_encog_engine_concurrency_job_JobUnitContext_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.concurrency.job']/class[@name='ConcurrentJob']/method[@name='reportStatus' and count(parameter)=2 and parameter[1][@type='org.encog.engine.concurrency.job.JobUnitContext'] and parameter[2][@type='java.lang.String']]"
		[Register ("reportStatus", "(Lorg/encog/engine/concurrency/job/JobUnitContext;Ljava/lang/String;)V", "GetReportStatus_Lorg_encog_engine_concurrency_job_JobUnitContext_Ljava_lang_String_Handler")]
		public virtual unsafe void ReportStatus (global::Org.Encog.Engine.Concurrency.Job.JobUnitContext p0, string p1)
		{
			if (id_reportStatus_Lorg_encog_engine_concurrency_job_JobUnitContext_Ljava_lang_String_ == IntPtr.Zero)
				id_reportStatus_Lorg_encog_engine_concurrency_job_JobUnitContext_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "reportStatus", "(Lorg/encog/engine/concurrency/job/JobUnitContext;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_reportStatus_Lorg_encog_engine_concurrency_job_JobUnitContext_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "reportStatus", "(Lorg/encog/engine/concurrency/job/JobUnitContext;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_requestNextTask;
#pragma warning disable 0169
		static Delegate GetRequestNextTaskHandler ()
		{
			if (cb_requestNextTask == null)
				cb_requestNextTask = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_RequestNextTask);
			return cb_requestNextTask;
		}

		static IntPtr n_RequestNextTask (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Concurrency.Job.ConcurrentJob __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Concurrency.Job.ConcurrentJob> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RequestNextTask ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.concurrency.job']/class[@name='ConcurrentJob']/method[@name='requestNextTask' and count(parameter)=0]"
		[Register ("requestNextTask", "()Ljava/lang/Object;", "GetRequestNextTaskHandler")]
		public abstract global::Java.Lang.Object RequestNextTask ();

		static Delegate cb_stop;
#pragma warning disable 0169
		static Delegate GetStopHandler ()
		{
			if (cb_stop == null)
				cb_stop = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Stop);
			return cb_stop;
		}

		static void n_Stop (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Concurrency.Job.ConcurrentJob __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Concurrency.Job.ConcurrentJob> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop ();
		}
#pragma warning restore 0169

		static IntPtr id_stop;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.concurrency.job']/class[@name='ConcurrentJob']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "GetStopHandler")]
		public virtual unsafe void Stop ()
		{
			if (id_stop == IntPtr.Zero)
				id_stop = JNIEnv.GetMethodID (class_ref, "stop", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_stop);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stop", "()V"));
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("org/encog/engine/concurrency/job/ConcurrentJob", DoNotGenerateAcw=true)]
	internal partial class ConcurrentJobInvoker : ConcurrentJob {

		public ConcurrentJobInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (ConcurrentJobInvoker); }
		}

		static IntPtr id_loadWorkload;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.concurrency.job']/class[@name='ConcurrentJob']/method[@name='loadWorkload' and count(parameter)=0]"
		[Register ("loadWorkload", "()I", "GetLoadWorkloadHandler")]
		public override unsafe int LoadWorkload ()
		{
			if (id_loadWorkload == IntPtr.Zero)
				id_loadWorkload = JNIEnv.GetMethodID (class_ref, "loadWorkload", "()I");
			try {
				return JNIEnv.CallIntMethod  (Handle, id_loadWorkload);
			} finally {
			}
		}

		static IntPtr id_performJobUnit_Lorg_encog_engine_concurrency_job_JobUnitContext_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.concurrency.job']/class[@name='ConcurrentJob']/method[@name='performJobUnit' and count(parameter)=1 and parameter[1][@type='org.encog.engine.concurrency.job.JobUnitContext']]"
		[Register ("performJobUnit", "(Lorg/encog/engine/concurrency/job/JobUnitContext;)V", "GetPerformJobUnit_Lorg_encog_engine_concurrency_job_JobUnitContext_Handler")]
		public override unsafe void PerformJobUnit (global::Org.Encog.Engine.Concurrency.Job.JobUnitContext p0)
		{
			if (id_performJobUnit_Lorg_encog_engine_concurrency_job_JobUnitContext_ == IntPtr.Zero)
				id_performJobUnit_Lorg_encog_engine_concurrency_job_JobUnitContext_ = JNIEnv.GetMethodID (class_ref, "performJobUnit", "(Lorg/encog/engine/concurrency/job/JobUnitContext;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_performJobUnit_Lorg_encog_engine_concurrency_job_JobUnitContext_, __args);
			} finally {
			}
		}

		static IntPtr id_requestNextTask;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.concurrency.job']/class[@name='ConcurrentJob']/method[@name='requestNextTask' and count(parameter)=0]"
		[Register ("requestNextTask", "()Ljava/lang/Object;", "GetRequestNextTaskHandler")]
		public override unsafe global::Java.Lang.Object RequestNextTask ()
		{
			if (id_requestNextTask == IntPtr.Zero)
				id_requestNextTask = JNIEnv.GetMethodID (class_ref, "requestNextTask", "()Ljava/lang/Object;");
			try {
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_requestNextTask), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

}
