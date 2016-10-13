using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Util.Benchmark {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.util.benchmark']/class[@name='Stopwatch']"
	[global::Android.Runtime.Register ("org/neuroph/util/benchmark/Stopwatch", DoNotGenerateAcw=true)]
	public partial class Stopwatch : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/util/benchmark/Stopwatch", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Stopwatch); }
		}

		protected Stopwatch (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.util.benchmark']/class[@name='Stopwatch']/constructor[@name='Stopwatch' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Stopwatch ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Stopwatch)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static Delegate cb_getElapsedTime;
#pragma warning disable 0169
		static Delegate GetGetElapsedTimeHandler ()
		{
			if (cb_getElapsedTime == null)
				cb_getElapsedTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetElapsedTime);
			return cb_getElapsedTime;
		}

		static long n_GetElapsedTime (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Util.Benchmark.Stopwatch __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.Benchmark.Stopwatch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ElapsedTime;
		}
#pragma warning restore 0169

		static IntPtr id_getElapsedTime;
		public virtual unsafe long ElapsedTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util.benchmark']/class[@name='Stopwatch']/method[@name='getElapsedTime' and count(parameter)=0]"
			[Register ("getElapsedTime", "()J", "GetGetElapsedTimeHandler")]
			get {
				if (id_getElapsedTime == IntPtr.Zero)
					id_getElapsedTime = JNIEnv.GetMethodID (class_ref, "getElapsedTime", "()J");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getElapsedTime);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getElapsedTime", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_reset;
#pragma warning disable 0169
		static Delegate GetResetHandler ()
		{
			if (cb_reset == null)
				cb_reset = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Reset);
			return cb_reset;
		}

		static void n_Reset (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Util.Benchmark.Stopwatch __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.Benchmark.Stopwatch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Reset ();
		}
#pragma warning restore 0169

		static IntPtr id_reset;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util.benchmark']/class[@name='Stopwatch']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "GetResetHandler")]
		public virtual unsafe void Reset ()
		{
			if (id_reset == IntPtr.Zero)
				id_reset = JNIEnv.GetMethodID (class_ref, "reset", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_reset);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "reset", "()V"));
			} finally {
			}
		}

		static Delegate cb_start;
#pragma warning disable 0169
		static Delegate GetStartHandler ()
		{
			if (cb_start == null)
				cb_start = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Start);
			return cb_start;
		}

		static void n_Start (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Util.Benchmark.Stopwatch __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.Benchmark.Stopwatch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Start ();
		}
#pragma warning restore 0169

		static IntPtr id_start;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util.benchmark']/class[@name='Stopwatch']/method[@name='start' and count(parameter)=0]"
		[Register ("start", "()V", "GetStartHandler")]
		public virtual unsafe void Start ()
		{
			if (id_start == IntPtr.Zero)
				id_start = JNIEnv.GetMethodID (class_ref, "start", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_start);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "start", "()V"));
			} finally {
			}
		}

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
			global::Org.Neuroph.Util.Benchmark.Stopwatch __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.Benchmark.Stopwatch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop ();
		}
#pragma warning restore 0169

		static IntPtr id_stop;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util.benchmark']/class[@name='Stopwatch']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "GetStopHandler")]
		public virtual unsafe void Stop ()
		{
			if (id_stop == IntPtr.Zero)
				id_stop = JNIEnv.GetMethodID (class_ref, "stop", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stop);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stop", "()V"));
			} finally {
			}
		}

	}
}
