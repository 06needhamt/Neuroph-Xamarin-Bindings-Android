using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Util.Benchmark {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.util.benchmark']/class[@name='BenchmarkTask']"
	[global::Android.Runtime.Register ("org/neuroph/util/benchmark/BenchmarkTask", DoNotGenerateAcw=true)]
	public abstract partial class BenchmarkTask : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/util/benchmark/BenchmarkTask", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BenchmarkTask); }
		}

		protected BenchmarkTask (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.util.benchmark']/class[@name='BenchmarkTask']/constructor[@name='BenchmarkTask' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe BenchmarkTask (string p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (BenchmarkTask)) {
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

		static Delegate cb_getName;
#pragma warning disable 0169
		static Delegate GetGetNameHandler ()
		{
			if (cb_getName == null)
				cb_getName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetName);
			return cb_getName;
		}

		static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Util.Benchmark.BenchmarkTask __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.Benchmark.BenchmarkTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		static Delegate cb_setName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetName_Ljava_lang_String_Handler ()
		{
			if (cb_setName_Ljava_lang_String_ == null)
				cb_setName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetName_Ljava_lang_String_);
			return cb_setName_Ljava_lang_String_;
		}

		static void n_SetName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Util.Benchmark.BenchmarkTask __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.Benchmark.BenchmarkTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Name = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getName;
		static IntPtr id_setName_Ljava_lang_String_;
		public virtual unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util.benchmark']/class[@name='BenchmarkTask']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
			get {
				if (id_getName == IntPtr.Zero)
					id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util.benchmark']/class[@name='BenchmarkTask']/method[@name='setName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setName", "(Ljava/lang/String;)V", "GetSetName_Ljava_lang_String_Handler")]
			set {
				if (id_setName_Ljava_lang_String_ == IntPtr.Zero)
					id_setName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setName", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setName_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setName", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getTestIterations;
#pragma warning disable 0169
		static Delegate GetGetTestIterationsHandler ()
		{
			if (cb_getTestIterations == null)
				cb_getTestIterations = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTestIterations);
			return cb_getTestIterations;
		}

		static int n_GetTestIterations (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Util.Benchmark.BenchmarkTask __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.Benchmark.BenchmarkTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TestIterations;
		}
#pragma warning restore 0169

		static Delegate cb_setTestIterations_I;
#pragma warning disable 0169
		static Delegate GetSetTestIterations_IHandler ()
		{
			if (cb_setTestIterations_I == null)
				cb_setTestIterations_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetTestIterations_I);
			return cb_setTestIterations_I;
		}

		static void n_SetTestIterations_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Neuroph.Util.Benchmark.BenchmarkTask __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.Benchmark.BenchmarkTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TestIterations = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTestIterations;
		static IntPtr id_setTestIterations_I;
		public virtual unsafe int TestIterations {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util.benchmark']/class[@name='BenchmarkTask']/method[@name='getTestIterations' and count(parameter)=0]"
			[Register ("getTestIterations", "()I", "GetGetTestIterationsHandler")]
			get {
				if (id_getTestIterations == IntPtr.Zero)
					id_getTestIterations = JNIEnv.GetMethodID (class_ref, "getTestIterations", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getTestIterations);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTestIterations", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util.benchmark']/class[@name='BenchmarkTask']/method[@name='setTestIterations' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setTestIterations", "(I)V", "GetSetTestIterations_IHandler")]
			set {
				if (id_setTestIterations_I == IntPtr.Zero)
					id_setTestIterations_I = JNIEnv.GetMethodID (class_ref, "setTestIterations", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTestIterations_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTestIterations", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getWarmupIterations;
#pragma warning disable 0169
		static Delegate GetGetWarmupIterationsHandler ()
		{
			if (cb_getWarmupIterations == null)
				cb_getWarmupIterations = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetWarmupIterations);
			return cb_getWarmupIterations;
		}

		static int n_GetWarmupIterations (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Util.Benchmark.BenchmarkTask __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.Benchmark.BenchmarkTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.WarmupIterations;
		}
#pragma warning restore 0169

		static Delegate cb_setWarmupIterations_I;
#pragma warning disable 0169
		static Delegate GetSetWarmupIterations_IHandler ()
		{
			if (cb_setWarmupIterations_I == null)
				cb_setWarmupIterations_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetWarmupIterations_I);
			return cb_setWarmupIterations_I;
		}

		static void n_SetWarmupIterations_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Neuroph.Util.Benchmark.BenchmarkTask __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.Benchmark.BenchmarkTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WarmupIterations = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getWarmupIterations;
		static IntPtr id_setWarmupIterations_I;
		public virtual unsafe int WarmupIterations {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util.benchmark']/class[@name='BenchmarkTask']/method[@name='getWarmupIterations' and count(parameter)=0]"
			[Register ("getWarmupIterations", "()I", "GetGetWarmupIterationsHandler")]
			get {
				if (id_getWarmupIterations == IntPtr.Zero)
					id_getWarmupIterations = JNIEnv.GetMethodID (class_ref, "getWarmupIterations", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getWarmupIterations);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWarmupIterations", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util.benchmark']/class[@name='BenchmarkTask']/method[@name='setWarmupIterations' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setWarmupIterations", "(I)V", "GetSetWarmupIterations_IHandler")]
			set {
				if (id_setWarmupIterations_I == IntPtr.Zero)
					id_setWarmupIterations_I = JNIEnv.GetMethodID (class_ref, "setWarmupIterations", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setWarmupIterations_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setWarmupIterations", "(I)V"), __args);
				} finally {
				}
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
			global::Org.Neuroph.Util.Benchmark.BenchmarkTask __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.Benchmark.BenchmarkTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PrepareTest ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util.benchmark']/class[@name='BenchmarkTask']/method[@name='prepareTest' and count(parameter)=0]"
		[Register ("prepareTest", "()V", "GetPrepareTestHandler")]
		public abstract void PrepareTest ();

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
			global::Org.Neuroph.Util.Benchmark.BenchmarkTask __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.Benchmark.BenchmarkTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RunTest ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util.benchmark']/class[@name='BenchmarkTask']/method[@name='runTest' and count(parameter)=0]"
		[Register ("runTest", "()V", "GetRunTestHandler")]
		public abstract void RunTest ();

	}

	[global::Android.Runtime.Register ("org/neuroph/util/benchmark/BenchmarkTask", DoNotGenerateAcw=true)]
	internal partial class BenchmarkTaskInvoker : BenchmarkTask {

		public BenchmarkTaskInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (BenchmarkTaskInvoker); }
		}

		static IntPtr id_prepareTest;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util.benchmark']/class[@name='BenchmarkTask']/method[@name='prepareTest' and count(parameter)=0]"
		[Register ("prepareTest", "()V", "GetPrepareTestHandler")]
		public override unsafe void PrepareTest ()
		{
			if (id_prepareTest == IntPtr.Zero)
				id_prepareTest = JNIEnv.GetMethodID (class_ref, "prepareTest", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_prepareTest);
			} finally {
			}
		}

		static IntPtr id_runTest;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util.benchmark']/class[@name='BenchmarkTask']/method[@name='runTest' and count(parameter)=0]"
		[Register ("runTest", "()V", "GetRunTestHandler")]
		public override unsafe void RunTest ()
		{
			if (id_runTest == IntPtr.Zero)
				id_runTest = JNIEnv.GetMethodID (class_ref, "runTest", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_runTest);
			} finally {
			}
		}

	}

}
