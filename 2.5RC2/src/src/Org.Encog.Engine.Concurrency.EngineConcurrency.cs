using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Encog.Engine.Concurrency {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.encog.engine.concurrency']/class[@name='EngineConcurrency']"
	[global::Android.Runtime.Register ("org/encog/engine/concurrency/EngineConcurrency", DoNotGenerateAcw=true)]
	public partial class EngineConcurrency : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/encog/engine/concurrency/EngineConcurrency", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (EngineConcurrency); }
		}

		protected EngineConcurrency (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.encog.engine.concurrency']/class[@name='EngineConcurrency']/constructor[@name='EngineConcurrency' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe EngineConcurrency ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (EngineConcurrency)) {
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

		static IntPtr id_getInstance;
		public static unsafe global::Org.Encog.Engine.Concurrency.EngineConcurrency Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.concurrency']/class[@name='EngineConcurrency']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lorg/encog/engine/concurrency/EngineConcurrency;", "GetGetInstanceHandler")]
			get {
				if (id_getInstance == IntPtr.Zero)
					id_getInstance = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "()Lorg/encog/engine/concurrency/EngineConcurrency;");
				try {
					return global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Concurrency.EngineConcurrency> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_checkError;
#pragma warning disable 0169
		static Delegate GetCheckErrorHandler ()
		{
			if (cb_checkError == null)
				cb_checkError = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CheckError);
			return cb_checkError;
		}

		static void n_CheckError (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Concurrency.EngineConcurrency __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Concurrency.EngineConcurrency> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CheckError ();
		}
#pragma warning restore 0169

		static IntPtr id_checkError;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.concurrency']/class[@name='EngineConcurrency']/method[@name='checkError' and count(parameter)=0]"
		[Register ("checkError", "()V", "GetCheckErrorHandler")]
		public virtual unsafe void CheckError ()
		{
			if (id_checkError == IntPtr.Zero)
				id_checkError = JNIEnv.GetMethodID (class_ref, "checkError", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_checkError);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "checkError", "()V"));
			} finally {
			}
		}

		static Delegate cb_createTaskGroup;
#pragma warning disable 0169
		static Delegate GetCreateTaskGroupHandler ()
		{
			if (cb_createTaskGroup == null)
				cb_createTaskGroup = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_CreateTaskGroup);
			return cb_createTaskGroup;
		}

		static IntPtr n_CreateTaskGroup (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Concurrency.EngineConcurrency __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Concurrency.EngineConcurrency> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CreateTaskGroup ());
		}
#pragma warning restore 0169

		static IntPtr id_createTaskGroup;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.concurrency']/class[@name='EngineConcurrency']/method[@name='createTaskGroup' and count(parameter)=0]"
		[Register ("createTaskGroup", "()Lorg/encog/engine/concurrency/TaskGroup;", "GetCreateTaskGroupHandler")]
		public virtual unsafe global::Org.Encog.Engine.Concurrency.TaskGroup CreateTaskGroup ()
		{
			if (id_createTaskGroup == IntPtr.Zero)
				id_createTaskGroup = JNIEnv.GetMethodID (class_ref, "createTaskGroup", "()Lorg/encog/engine/concurrency/TaskGroup;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Concurrency.TaskGroup> (JNIEnv.CallObjectMethod  (Handle, id_createTaskGroup), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Concurrency.TaskGroup> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createTaskGroup", "()Lorg/encog/engine/concurrency/TaskGroup;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_processTask_Lorg_encog_engine_concurrency_EngineTask_;
#pragma warning disable 0169
		static Delegate GetProcessTask_Lorg_encog_engine_concurrency_EngineTask_Handler ()
		{
			if (cb_processTask_Lorg_encog_engine_concurrency_EngineTask_ == null)
				cb_processTask_Lorg_encog_engine_concurrency_EngineTask_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ProcessTask_Lorg_encog_engine_concurrency_EngineTask_);
			return cb_processTask_Lorg_encog_engine_concurrency_EngineTask_;
		}

		static void n_ProcessTask_Lorg_encog_engine_concurrency_EngineTask_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Encog.Engine.Concurrency.EngineConcurrency __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Concurrency.EngineConcurrency> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Encog.Engine.Concurrency.IEngineTask p0 = (global::Org.Encog.Engine.Concurrency.IEngineTask)global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Concurrency.IEngineTask> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ProcessTask (p0);
		}
#pragma warning restore 0169

		static IntPtr id_processTask_Lorg_encog_engine_concurrency_EngineTask_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.concurrency']/class[@name='EngineConcurrency']/method[@name='processTask' and count(parameter)=1 and parameter[1][@type='org.encog.engine.concurrency.EngineTask']]"
		[Register ("processTask", "(Lorg/encog/engine/concurrency/EngineTask;)V", "GetProcessTask_Lorg_encog_engine_concurrency_EngineTask_Handler")]
		public virtual unsafe void ProcessTask (global::Org.Encog.Engine.Concurrency.IEngineTask p0)
		{
			if (id_processTask_Lorg_encog_engine_concurrency_EngineTask_ == IntPtr.Zero)
				id_processTask_Lorg_encog_engine_concurrency_EngineTask_ = JNIEnv.GetMethodID (class_ref, "processTask", "(Lorg/encog/engine/concurrency/EngineTask;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_processTask_Lorg_encog_engine_concurrency_EngineTask_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "processTask", "(Lorg/encog/engine/concurrency/EngineTask;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_processTask_Lorg_encog_engine_concurrency_EngineTask_Lorg_encog_engine_concurrency_TaskGroup_;
#pragma warning disable 0169
		static Delegate GetProcessTask_Lorg_encog_engine_concurrency_EngineTask_Lorg_encog_engine_concurrency_TaskGroup_Handler ()
		{
			if (cb_processTask_Lorg_encog_engine_concurrency_EngineTask_Lorg_encog_engine_concurrency_TaskGroup_ == null)
				cb_processTask_Lorg_encog_engine_concurrency_EngineTask_Lorg_encog_engine_concurrency_TaskGroup_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_ProcessTask_Lorg_encog_engine_concurrency_EngineTask_Lorg_encog_engine_concurrency_TaskGroup_);
			return cb_processTask_Lorg_encog_engine_concurrency_EngineTask_Lorg_encog_engine_concurrency_TaskGroup_;
		}

		static void n_ProcessTask_Lorg_encog_engine_concurrency_EngineTask_Lorg_encog_engine_concurrency_TaskGroup_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Encog.Engine.Concurrency.EngineConcurrency __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Concurrency.EngineConcurrency> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Encog.Engine.Concurrency.IEngineTask p0 = (global::Org.Encog.Engine.Concurrency.IEngineTask)global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Concurrency.IEngineTask> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Encog.Engine.Concurrency.TaskGroup p1 = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Concurrency.TaskGroup> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.ProcessTask (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_processTask_Lorg_encog_engine_concurrency_EngineTask_Lorg_encog_engine_concurrency_TaskGroup_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.concurrency']/class[@name='EngineConcurrency']/method[@name='processTask' and count(parameter)=2 and parameter[1][@type='org.encog.engine.concurrency.EngineTask'] and parameter[2][@type='org.encog.engine.concurrency.TaskGroup']]"
		[Register ("processTask", "(Lorg/encog/engine/concurrency/EngineTask;Lorg/encog/engine/concurrency/TaskGroup;)V", "GetProcessTask_Lorg_encog_engine_concurrency_EngineTask_Lorg_encog_engine_concurrency_TaskGroup_Handler")]
		public virtual unsafe void ProcessTask (global::Org.Encog.Engine.Concurrency.IEngineTask p0, global::Org.Encog.Engine.Concurrency.TaskGroup p1)
		{
			if (id_processTask_Lorg_encog_engine_concurrency_EngineTask_Lorg_encog_engine_concurrency_TaskGroup_ == IntPtr.Zero)
				id_processTask_Lorg_encog_engine_concurrency_EngineTask_Lorg_encog_engine_concurrency_TaskGroup_ = JNIEnv.GetMethodID (class_ref, "processTask", "(Lorg/encog/engine/concurrency/EngineTask;Lorg/encog/engine/concurrency/TaskGroup;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_processTask_Lorg_encog_engine_concurrency_EngineTask_Lorg_encog_engine_concurrency_TaskGroup_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "processTask", "(Lorg/encog/engine/concurrency/EngineTask;Lorg/encog/engine/concurrency/TaskGroup;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_registerError_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetRegisterError_Ljava_lang_Throwable_Handler ()
		{
			if (cb_registerError_Ljava_lang_Throwable_ == null)
				cb_registerError_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RegisterError_Ljava_lang_Throwable_);
			return cb_registerError_Ljava_lang_Throwable_;
		}

		static void n_RegisterError_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Encog.Engine.Concurrency.EngineConcurrency __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Concurrency.EngineConcurrency> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RegisterError (p0);
		}
#pragma warning restore 0169

		static IntPtr id_registerError_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.concurrency']/class[@name='EngineConcurrency']/method[@name='registerError' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("registerError", "(Ljava/lang/Throwable;)V", "GetRegisterError_Ljava_lang_Throwable_Handler")]
		public virtual unsafe void RegisterError (global::Java.Lang.Throwable p0)
		{
			if (id_registerError_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_registerError_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "registerError", "(Ljava/lang/Throwable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_registerError_Ljava_lang_Throwable_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "registerError", "(Ljava/lang/Throwable;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_shutdown_J;
#pragma warning disable 0169
		static Delegate GetShutdown_JHandler ()
		{
			if (cb_shutdown_J == null)
				cb_shutdown_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_Shutdown_J);
			return cb_shutdown_J;
		}

		static void n_Shutdown_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Org.Encog.Engine.Concurrency.EngineConcurrency __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Concurrency.EngineConcurrency> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Shutdown (p0);
		}
#pragma warning restore 0169

		static IntPtr id_shutdown_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.concurrency']/class[@name='EngineConcurrency']/method[@name='shutdown' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("shutdown", "(J)V", "GetShutdown_JHandler")]
		public virtual unsafe void Shutdown (long p0)
		{
			if (id_shutdown_J == IntPtr.Zero)
				id_shutdown_J = JNIEnv.GetMethodID (class_ref, "shutdown", "(J)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_shutdown_J, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "shutdown", "(J)V"), __args);
			} finally {
			}
		}

	}
}
