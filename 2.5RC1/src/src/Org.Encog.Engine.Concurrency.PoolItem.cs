using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Encog.Engine.Concurrency {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.encog.engine.concurrency']/class[@name='PoolItem']"
	[global::Android.Runtime.Register ("org/encog/engine/concurrency/PoolItem", DoNotGenerateAcw=true)]
	public partial class PoolItem : global::Java.Lang.Object, global::Java.Lang.IRunnable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/encog/engine/concurrency/PoolItem", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PoolItem); }
		}

		protected PoolItem (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_encog_engine_concurrency_EngineTask_Lorg_encog_engine_concurrency_TaskGroup_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.encog.engine.concurrency']/class[@name='PoolItem']/constructor[@name='PoolItem' and count(parameter)=2 and parameter[1][@type='org.encog.engine.concurrency.EngineTask'] and parameter[2][@type='org.encog.engine.concurrency.TaskGroup']]"
		[Register (".ctor", "(Lorg/encog/engine/concurrency/EngineTask;Lorg/encog/engine/concurrency/TaskGroup;)V", "")]
		public unsafe PoolItem (global::Org.Encog.Engine.Concurrency.IEngineTask p0, global::Org.Encog.Engine.Concurrency.TaskGroup p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (PoolItem)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/encog/engine/concurrency/EngineTask;Lorg/encog/engine/concurrency/TaskGroup;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/encog/engine/concurrency/EngineTask;Lorg/encog/engine/concurrency/TaskGroup;)V", __args);
					return;
				}

				if (id_ctor_Lorg_encog_engine_concurrency_EngineTask_Lorg_encog_engine_concurrency_TaskGroup_ == IntPtr.Zero)
					id_ctor_Lorg_encog_engine_concurrency_EngineTask_Lorg_encog_engine_concurrency_TaskGroup_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/encog/engine/concurrency/EngineTask;Lorg/encog/engine/concurrency/TaskGroup;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_encog_engine_concurrency_EngineTask_Lorg_encog_engine_concurrency_TaskGroup_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_encog_engine_concurrency_EngineTask_Lorg_encog_engine_concurrency_TaskGroup_, __args);
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
			global::Org.Encog.Engine.Concurrency.PoolItem __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Concurrency.PoolItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Run ();
		}
#pragma warning restore 0169

		static IntPtr id_run;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.concurrency']/class[@name='PoolItem']/method[@name='run' and count(parameter)=0]"
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
