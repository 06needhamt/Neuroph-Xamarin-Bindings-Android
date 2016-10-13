using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Util.Benchmark {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.util.benchmark']/class[@name='MyBenchmarkTask']"
	[global::Android.Runtime.Register ("org/neuroph/util/benchmark/MyBenchmarkTask", DoNotGenerateAcw=true)]
	public partial class MyBenchmarkTask : global::Org.Neuroph.Util.Benchmark.BenchmarkTask {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/util/benchmark/MyBenchmarkTask", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MyBenchmarkTask); }
		}

		protected MyBenchmarkTask (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.util.benchmark']/class[@name='MyBenchmarkTask']/constructor[@name='MyBenchmarkTask' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe MyBenchmarkTask (string p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (MyBenchmarkTask)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_prepareTest;
#pragma warning disable 0169
		static Delegate GetPrepareTestHandler ()
		{
			if (cb_prepareTest == null)
				cb_prepareTest = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_PrepareTest);
			return cb_prepareTest;
		}

		static void n_PrepareTest (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Util.Benchmark.MyBenchmarkTask __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.Benchmark.MyBenchmarkTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PrepareTest ();
		}
#pragma warning restore 0169

		static IntPtr id_prepareTest;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util.benchmark']/class[@name='MyBenchmarkTask']/method[@name='prepareTest' and count(parameter)=0]"
		[Register ("prepareTest", "()V", "GetPrepareTestHandler")]
		public override unsafe void PrepareTest ()
		{
			if (id_prepareTest == IntPtr.Zero)
				id_prepareTest = JNIEnv.GetMethodID (class_ref, "prepareTest", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_prepareTest);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "prepareTest", "()V"));
			} finally {
			}
		}

		static Delegate cb_runTest;
#pragma warning disable 0169
		static Delegate GetRunTestHandler ()
		{
			if (cb_runTest == null)
				cb_runTest = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RunTest);
			return cb_runTest;
		}

		static void n_RunTest (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Util.Benchmark.MyBenchmarkTask __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.Benchmark.MyBenchmarkTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RunTest ();
		}
#pragma warning restore 0169

		static IntPtr id_runTest;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util.benchmark']/class[@name='MyBenchmarkTask']/method[@name='runTest' and count(parameter)=0]"
		[Register ("runTest", "()V", "GetRunTestHandler")]
		public override unsafe void RunTest ()
		{
			if (id_runTest == IntPtr.Zero)
				id_runTest = JNIEnv.GetMethodID (class_ref, "runTest", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_runTest);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "runTest", "()V"));
			} finally {
			}
		}

	}
}
