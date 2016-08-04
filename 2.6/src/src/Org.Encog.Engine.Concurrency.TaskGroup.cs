using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Encog.Engine.Concurrency {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.encog.engine.concurrency']/class[@name='TaskGroup']"
	[global::Android.Runtime.Register ("org/encog/engine/concurrency/TaskGroup", DoNotGenerateAcw=true)]
	public partial class TaskGroup : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/encog/engine/concurrency/TaskGroup", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TaskGroup); }
		}

		protected TaskGroup (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.encog.engine.concurrency']/class[@name='TaskGroup']/constructor[@name='TaskGroup' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe TaskGroup (int p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (TaskGroup)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(I)V", __args);
					return;
				}

				if (id_ctor_I == IntPtr.Zero)
					id_ctor_I = JNIEnv.GetMethodID (class_ref, "<init>", "(I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_I, __args);
			} finally {
			}
		}

		static Delegate cb_getID;
#pragma warning disable 0169
		static Delegate GetGetIDHandler ()
		{
			if (cb_getID == null)
				cb_getID = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetID);
			return cb_getID;
		}

		static int n_GetID (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Concurrency.TaskGroup __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Concurrency.TaskGroup> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ID;
		}
#pragma warning restore 0169

		static IntPtr id_getID;
		public virtual unsafe int ID {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.concurrency']/class[@name='TaskGroup']/method[@name='getID' and count(parameter)=0]"
			[Register ("getID", "()I", "GetGetIDHandler")]
			get {
				if (id_getID == IntPtr.Zero)
					id_getID = JNIEnv.GetMethodID (class_ref, "getID", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getID);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getID", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getNoTasks;
#pragma warning disable 0169
		static Delegate GetGetNoTasksHandler ()
		{
			if (cb_getNoTasks == null)
				cb_getNoTasks = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetNoTasks);
			return cb_getNoTasks;
		}

		static bool n_GetNoTasks (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Concurrency.TaskGroup __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Concurrency.TaskGroup> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NoTasks;
		}
#pragma warning restore 0169

		static IntPtr id_getNoTasks;
		public virtual unsafe bool NoTasks {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.concurrency']/class[@name='TaskGroup']/method[@name='getNoTasks' and count(parameter)=0]"
			[Register ("getNoTasks", "()Z", "GetGetNoTasksHandler")]
			get {
				if (id_getNoTasks == IntPtr.Zero)
					id_getNoTasks = JNIEnv.GetMethodID (class_ref, "getNoTasks", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_getNoTasks);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNoTasks", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_taskStarting;
#pragma warning disable 0169
		static Delegate GetTaskStartingHandler ()
		{
			if (cb_taskStarting == null)
				cb_taskStarting = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_TaskStarting);
			return cb_taskStarting;
		}

		static void n_TaskStarting (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Concurrency.TaskGroup __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Concurrency.TaskGroup> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TaskStarting ();
		}
#pragma warning restore 0169

		static IntPtr id_taskStarting;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.concurrency']/class[@name='TaskGroup']/method[@name='taskStarting' and count(parameter)=0]"
		[Register ("taskStarting", "()V", "GetTaskStartingHandler")]
		public virtual unsafe void TaskStarting ()
		{
			if (id_taskStarting == IntPtr.Zero)
				id_taskStarting = JNIEnv.GetMethodID (class_ref, "taskStarting", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_taskStarting);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "taskStarting", "()V"));
			} finally {
			}
		}

		static Delegate cb_taskStopping;
#pragma warning disable 0169
		static Delegate GetTaskStoppingHandler ()
		{
			if (cb_taskStopping == null)
				cb_taskStopping = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_TaskStopping);
			return cb_taskStopping;
		}

		static void n_TaskStopping (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Concurrency.TaskGroup __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Concurrency.TaskGroup> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TaskStopping ();
		}
#pragma warning restore 0169

		static IntPtr id_taskStopping;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.concurrency']/class[@name='TaskGroup']/method[@name='taskStopping' and count(parameter)=0]"
		[Register ("taskStopping", "()V", "GetTaskStoppingHandler")]
		public virtual unsafe void TaskStopping ()
		{
			if (id_taskStopping == IntPtr.Zero)
				id_taskStopping = JNIEnv.GetMethodID (class_ref, "taskStopping", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_taskStopping);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "taskStopping", "()V"));
			} finally {
			}
		}

		static Delegate cb_waitForComplete;
#pragma warning disable 0169
		static Delegate GetWaitForCompleteHandler ()
		{
			if (cb_waitForComplete == null)
				cb_waitForComplete = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_WaitForComplete);
			return cb_waitForComplete;
		}

		static void n_WaitForComplete (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Concurrency.TaskGroup __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Concurrency.TaskGroup> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WaitForComplete ();
		}
#pragma warning restore 0169

		static IntPtr id_waitForComplete;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.concurrency']/class[@name='TaskGroup']/method[@name='waitForComplete' and count(parameter)=0]"
		[Register ("waitForComplete", "()V", "GetWaitForCompleteHandler")]
		public virtual unsafe void WaitForComplete ()
		{
			if (id_waitForComplete == IntPtr.Zero)
				id_waitForComplete = JNIEnv.GetMethodID (class_ref, "waitForComplete", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_waitForComplete);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "waitForComplete", "()V"));
			} finally {
			}
		}

	}
}
