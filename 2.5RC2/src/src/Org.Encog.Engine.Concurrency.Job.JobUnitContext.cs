using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Encog.Engine.Concurrency.Job {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.encog.engine.concurrency.job']/class[@name='JobUnitContext']"
	[global::Android.Runtime.Register ("org/encog/engine/concurrency/job/JobUnitContext", DoNotGenerateAcw=true)]
	public partial class JobUnitContext : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/encog/engine/concurrency/job/JobUnitContext", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (JobUnitContext); }
		}

		protected JobUnitContext (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.encog.engine.concurrency.job']/class[@name='JobUnitContext']/constructor[@name='JobUnitContext' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe JobUnitContext ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (JobUnitContext)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static Delegate cb_getJobUnit;
#pragma warning disable 0169
		static Delegate GetGetJobUnitHandler ()
		{
			if (cb_getJobUnit == null)
				cb_getJobUnit = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetJobUnit);
			return cb_getJobUnit;
		}

		static IntPtr n_GetJobUnit (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Concurrency.Job.JobUnitContext __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Concurrency.Job.JobUnitContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.JobUnit);
		}
#pragma warning restore 0169

		static Delegate cb_setJobUnit_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSetJobUnit_Ljava_lang_Object_Handler ()
		{
			if (cb_setJobUnit_Ljava_lang_Object_ == null)
				cb_setJobUnit_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetJobUnit_Ljava_lang_Object_);
			return cb_setJobUnit_Ljava_lang_Object_;
		}

		static void n_SetJobUnit_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Encog.Engine.Concurrency.Job.JobUnitContext __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Concurrency.Job.JobUnitContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.JobUnit = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getJobUnit;
		static IntPtr id_setJobUnit_Ljava_lang_Object_;
		public virtual unsafe global::Java.Lang.Object JobUnit {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.concurrency.job']/class[@name='JobUnitContext']/method[@name='getJobUnit' and count(parameter)=0]"
			[Register ("getJobUnit", "()Ljava/lang/Object;", "GetGetJobUnitHandler")]
			get {
				if (id_getJobUnit == IntPtr.Zero)
					id_getJobUnit = JNIEnv.GetMethodID (class_ref, "getJobUnit", "()Ljava/lang/Object;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_getJobUnit), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getJobUnit", "()Ljava/lang/Object;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.concurrency.job']/class[@name='JobUnitContext']/method[@name='setJobUnit' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
			[Register ("setJobUnit", "(Ljava/lang/Object;)V", "GetSetJobUnit_Ljava_lang_Object_Handler")]
			set {
				if (id_setJobUnit_Ljava_lang_Object_ == IntPtr.Zero)
					id_setJobUnit_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "setJobUnit", "(Ljava/lang/Object;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setJobUnit_Ljava_lang_Object_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setJobUnit", "(Ljava/lang/Object;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getOwner;
#pragma warning disable 0169
		static Delegate GetGetOwnerHandler ()
		{
			if (cb_getOwner == null)
				cb_getOwner = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOwner);
			return cb_getOwner;
		}

		static IntPtr n_GetOwner (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Concurrency.Job.JobUnitContext __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Concurrency.Job.JobUnitContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Owner);
		}
#pragma warning restore 0169

		static Delegate cb_setOwner_Lorg_encog_engine_concurrency_job_ConcurrentJob_;
#pragma warning disable 0169
		static Delegate GetSetOwner_Lorg_encog_engine_concurrency_job_ConcurrentJob_Handler ()
		{
			if (cb_setOwner_Lorg_encog_engine_concurrency_job_ConcurrentJob_ == null)
				cb_setOwner_Lorg_encog_engine_concurrency_job_ConcurrentJob_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOwner_Lorg_encog_engine_concurrency_job_ConcurrentJob_);
			return cb_setOwner_Lorg_encog_engine_concurrency_job_ConcurrentJob_;
		}

		static void n_SetOwner_Lorg_encog_engine_concurrency_job_ConcurrentJob_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Encog.Engine.Concurrency.Job.JobUnitContext __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Concurrency.Job.JobUnitContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Encog.Engine.Concurrency.Job.ConcurrentJob p0 = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Concurrency.Job.ConcurrentJob> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Owner = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getOwner;
		static IntPtr id_setOwner_Lorg_encog_engine_concurrency_job_ConcurrentJob_;
		public virtual unsafe global::Org.Encog.Engine.Concurrency.Job.ConcurrentJob Owner {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.concurrency.job']/class[@name='JobUnitContext']/method[@name='getOwner' and count(parameter)=0]"
			[Register ("getOwner", "()Lorg/encog/engine/concurrency/job/ConcurrentJob;", "GetGetOwnerHandler")]
			get {
				if (id_getOwner == IntPtr.Zero)
					id_getOwner = JNIEnv.GetMethodID (class_ref, "getOwner", "()Lorg/encog/engine/concurrency/job/ConcurrentJob;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Concurrency.Job.ConcurrentJob> (JNIEnv.CallObjectMethod  (Handle, id_getOwner), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Concurrency.Job.ConcurrentJob> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOwner", "()Lorg/encog/engine/concurrency/job/ConcurrentJob;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.concurrency.job']/class[@name='JobUnitContext']/method[@name='setOwner' and count(parameter)=1 and parameter[1][@type='org.encog.engine.concurrency.job.ConcurrentJob']]"
			[Register ("setOwner", "(Lorg/encog/engine/concurrency/job/ConcurrentJob;)V", "GetSetOwner_Lorg_encog_engine_concurrency_job_ConcurrentJob_Handler")]
			set {
				if (id_setOwner_Lorg_encog_engine_concurrency_job_ConcurrentJob_ == IntPtr.Zero)
					id_setOwner_Lorg_encog_engine_concurrency_job_ConcurrentJob_ = JNIEnv.GetMethodID (class_ref, "setOwner", "(Lorg/encog/engine/concurrency/job/ConcurrentJob;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setOwner_Lorg_encog_engine_concurrency_job_ConcurrentJob_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOwner", "(Lorg/encog/engine/concurrency/job/ConcurrentJob;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTaskNumber;
#pragma warning disable 0169
		static Delegate GetGetTaskNumberHandler ()
		{
			if (cb_getTaskNumber == null)
				cb_getTaskNumber = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTaskNumber);
			return cb_getTaskNumber;
		}

		static int n_GetTaskNumber (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Concurrency.Job.JobUnitContext __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Concurrency.Job.JobUnitContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TaskNumber;
		}
#pragma warning restore 0169

		static Delegate cb_setTaskNumber_I;
#pragma warning disable 0169
		static Delegate GetSetTaskNumber_IHandler ()
		{
			if (cb_setTaskNumber_I == null)
				cb_setTaskNumber_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetTaskNumber_I);
			return cb_setTaskNumber_I;
		}

		static void n_SetTaskNumber_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Encog.Engine.Concurrency.Job.JobUnitContext __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Concurrency.Job.JobUnitContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TaskNumber = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTaskNumber;
		static IntPtr id_setTaskNumber_I;
		public virtual unsafe int TaskNumber {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.concurrency.job']/class[@name='JobUnitContext']/method[@name='getTaskNumber' and count(parameter)=0]"
			[Register ("getTaskNumber", "()I", "GetGetTaskNumberHandler")]
			get {
				if (id_getTaskNumber == IntPtr.Zero)
					id_getTaskNumber = JNIEnv.GetMethodID (class_ref, "getTaskNumber", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getTaskNumber);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTaskNumber", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.concurrency.job']/class[@name='JobUnitContext']/method[@name='setTaskNumber' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setTaskNumber", "(I)V", "GetSetTaskNumber_IHandler")]
			set {
				if (id_setTaskNumber_I == IntPtr.Zero)
					id_setTaskNumber_I = JNIEnv.GetMethodID (class_ref, "setTaskNumber", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setTaskNumber_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTaskNumber", "(I)V"), __args);
				} finally {
				}
			}
		}

	}
}
