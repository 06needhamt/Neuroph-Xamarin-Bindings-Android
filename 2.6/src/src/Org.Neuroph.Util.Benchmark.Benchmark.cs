using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Util.Benchmark {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.util.benchmark']/class[@name='Benchmark']"
	[global::Android.Runtime.Register ("org/neuroph/util/benchmark/Benchmark", DoNotGenerateAcw=true)]
	public partial class Benchmark : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/util/benchmark/Benchmark", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Benchmark); }
		}

		protected Benchmark (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.util.benchmark']/class[@name='Benchmark']/constructor[@name='Benchmark' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Benchmark ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Benchmark)) {
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

		static Delegate cb_addTask_Lorg_neuroph_util_benchmark_BenchmarkTask_;
#pragma warning disable 0169
		static Delegate GetAddTask_Lorg_neuroph_util_benchmark_BenchmarkTask_Handler ()
		{
			if (cb_addTask_Lorg_neuroph_util_benchmark_BenchmarkTask_ == null)
				cb_addTask_Lorg_neuroph_util_benchmark_BenchmarkTask_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddTask_Lorg_neuroph_util_benchmark_BenchmarkTask_);
			return cb_addTask_Lorg_neuroph_util_benchmark_BenchmarkTask_;
		}

		static void n_AddTask_Lorg_neuroph_util_benchmark_BenchmarkTask_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Util.Benchmark.Benchmark __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.Benchmark.Benchmark> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Util.Benchmark.BenchmarkTask p0 = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.Benchmark.BenchmarkTask> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddTask (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addTask_Lorg_neuroph_util_benchmark_BenchmarkTask_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util.benchmark']/class[@name='Benchmark']/method[@name='addTask' and count(parameter)=1 and parameter[1][@type='org.neuroph.util.benchmark.BenchmarkTask']]"
		[Register ("addTask", "(Lorg/neuroph/util/benchmark/BenchmarkTask;)V", "GetAddTask_Lorg_neuroph_util_benchmark_BenchmarkTask_Handler")]
		public virtual unsafe void AddTask (global::Org.Neuroph.Util.Benchmark.BenchmarkTask p0)
		{
			if (id_addTask_Lorg_neuroph_util_benchmark_BenchmarkTask_ == IntPtr.Zero)
				id_addTask_Lorg_neuroph_util_benchmark_BenchmarkTask_ = JNIEnv.GetMethodID (class_ref, "addTask", "(Lorg/neuroph/util/benchmark/BenchmarkTask;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_addTask_Lorg_neuroph_util_benchmark_BenchmarkTask_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addTask", "(Lorg/neuroph/util/benchmark/BenchmarkTask;)V"), __args);
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
			global::Org.Neuroph.Util.Benchmark.Benchmark __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.Benchmark.Benchmark> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Run ();
		}
#pragma warning restore 0169

		static IntPtr id_run;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util.benchmark']/class[@name='Benchmark']/method[@name='run' and count(parameter)=0]"
		[Register ("run", "()V", "GetRunHandler")]
		public virtual unsafe void Run ()
		{
			if (id_run == IntPtr.Zero)
				id_run = JNIEnv.GetMethodID (class_ref, "run", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_run);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "run", "()V"));
			} finally {
			}
		}

		static IntPtr id_runTask_Lorg_neuroph_util_benchmark_BenchmarkTask_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util.benchmark']/class[@name='Benchmark']/method[@name='runTask' and count(parameter)=1 and parameter[1][@type='org.neuroph.util.benchmark.BenchmarkTask']]"
		[Register ("runTask", "(Lorg/neuroph/util/benchmark/BenchmarkTask;)V", "")]
		public static unsafe void RunTask (global::Org.Neuroph.Util.Benchmark.BenchmarkTask p0)
		{
			if (id_runTask_Lorg_neuroph_util_benchmark_BenchmarkTask_ == IntPtr.Zero)
				id_runTask_Lorg_neuroph_util_benchmark_BenchmarkTask_ = JNIEnv.GetStaticMethodID (class_ref, "runTask", "(Lorg/neuroph/util/benchmark/BenchmarkTask;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_runTask_Lorg_neuroph_util_benchmark_BenchmarkTask_, __args);
			} finally {
			}
		}

	}
}
