using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Util.Benchmark {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.util.benchmark']/class[@name='BenchmarkTaskResults']"
	[global::Android.Runtime.Register ("org/neuroph/util/benchmark/BenchmarkTaskResults", DoNotGenerateAcw=true)]
	public partial class BenchmarkTaskResults : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/util/benchmark/BenchmarkTaskResults", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BenchmarkTaskResults); }
		}

		protected BenchmarkTaskResults (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.util.benchmark']/class[@name='BenchmarkTaskResults']/constructor[@name='BenchmarkTaskResults' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe BenchmarkTaskResults (int p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (BenchmarkTaskResults)) {
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

		static Delegate cb_getAverageTestTime;
#pragma warning disable 0169
		static Delegate GetGetAverageTestTimeHandler ()
		{
			if (cb_getAverageTestTime == null)
				cb_getAverageTestTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetAverageTestTime);
			return cb_getAverageTestTime;
		}

		static double n_GetAverageTestTime (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Util.Benchmark.BenchmarkTaskResults __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.Benchmark.BenchmarkTaskResults> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AverageTestTime;
		}
#pragma warning restore 0169

		static IntPtr id_getAverageTestTime;
		public virtual unsafe double AverageTestTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util.benchmark']/class[@name='BenchmarkTaskResults']/method[@name='getAverageTestTime' and count(parameter)=0]"
			[Register ("getAverageTestTime", "()D", "GetGetAverageTestTimeHandler")]
			get {
				if (id_getAverageTestTime == IntPtr.Zero)
					id_getAverageTestTime = JNIEnv.GetMethodID (class_ref, "getAverageTestTime", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod  (Handle, id_getAverageTestTime);
					else
						return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAverageTestTime", "()D"));
				} finally {
				}
			}
		}

		static Delegate cb_getMaxTestTime;
#pragma warning disable 0169
		static Delegate GetGetMaxTestTimeHandler ()
		{
			if (cb_getMaxTestTime == null)
				cb_getMaxTestTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetMaxTestTime);
			return cb_getMaxTestTime;
		}

		static double n_GetMaxTestTime (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Util.Benchmark.BenchmarkTaskResults __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.Benchmark.BenchmarkTaskResults> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxTestTime;
		}
#pragma warning restore 0169

		static IntPtr id_getMaxTestTime;
		public virtual unsafe double MaxTestTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util.benchmark']/class[@name='BenchmarkTaskResults']/method[@name='getMaxTestTime' and count(parameter)=0]"
			[Register ("getMaxTestTime", "()D", "GetGetMaxTestTimeHandler")]
			get {
				if (id_getMaxTestTime == IntPtr.Zero)
					id_getMaxTestTime = JNIEnv.GetMethodID (class_ref, "getMaxTestTime", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod  (Handle, id_getMaxTestTime);
					else
						return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMaxTestTime", "()D"));
				} finally {
				}
			}
		}

		static Delegate cb_getMinTestTime;
#pragma warning disable 0169
		static Delegate GetGetMinTestTimeHandler ()
		{
			if (cb_getMinTestTime == null)
				cb_getMinTestTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetMinTestTime);
			return cb_getMinTestTime;
		}

		static double n_GetMinTestTime (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Util.Benchmark.BenchmarkTaskResults __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.Benchmark.BenchmarkTaskResults> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MinTestTime;
		}
#pragma warning restore 0169

		static IntPtr id_getMinTestTime;
		public virtual unsafe double MinTestTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util.benchmark']/class[@name='BenchmarkTaskResults']/method[@name='getMinTestTime' and count(parameter)=0]"
			[Register ("getMinTestTime", "()D", "GetGetMinTestTimeHandler")]
			get {
				if (id_getMinTestTime == IntPtr.Zero)
					id_getMinTestTime = JNIEnv.GetMethodID (class_ref, "getMinTestTime", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod  (Handle, id_getMinTestTime);
					else
						return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMinTestTime", "()D"));
				} finally {
				}
			}
		}

		static Delegate cb_getStandardDeviation;
#pragma warning disable 0169
		static Delegate GetGetStandardDeviationHandler ()
		{
			if (cb_getStandardDeviation == null)
				cb_getStandardDeviation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetStandardDeviation);
			return cb_getStandardDeviation;
		}

		static double n_GetStandardDeviation (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Util.Benchmark.BenchmarkTaskResults __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.Benchmark.BenchmarkTaskResults> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StandardDeviation;
		}
#pragma warning restore 0169

		static IntPtr id_getStandardDeviation;
		public virtual unsafe double StandardDeviation {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util.benchmark']/class[@name='BenchmarkTaskResults']/method[@name='getStandardDeviation' and count(parameter)=0]"
			[Register ("getStandardDeviation", "()D", "GetGetStandardDeviationHandler")]
			get {
				if (id_getStandardDeviation == IntPtr.Zero)
					id_getStandardDeviation = JNIEnv.GetMethodID (class_ref, "getStandardDeviation", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod  (Handle, id_getStandardDeviation);
					else
						return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStandardDeviation", "()D"));
				} finally {
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
			global::Org.Neuroph.Util.Benchmark.BenchmarkTaskResults __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.Benchmark.BenchmarkTaskResults> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TestIterations;
		}
#pragma warning restore 0169

		static IntPtr id_getTestIterations;
		public virtual unsafe int TestIterations {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util.benchmark']/class[@name='BenchmarkTaskResults']/method[@name='getTestIterations' and count(parameter)=0]"
			[Register ("getTestIterations", "()I", "GetGetTestIterationsHandler")]
			get {
				if (id_getTestIterations == IntPtr.Zero)
					id_getTestIterations = JNIEnv.GetMethodID (class_ref, "getTestIterations", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getTestIterations);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTestIterations", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_addElapsedTime_J;
#pragma warning disable 0169
		static Delegate GetAddElapsedTime_JHandler ()
		{
			if (cb_addElapsedTime_J == null)
				cb_addElapsedTime_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_AddElapsedTime_J);
			return cb_addElapsedTime_J;
		}

		static void n_AddElapsedTime_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Org.Neuroph.Util.Benchmark.BenchmarkTaskResults __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.Benchmark.BenchmarkTaskResults> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AddElapsedTime (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addElapsedTime_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util.benchmark']/class[@name='BenchmarkTaskResults']/method[@name='addElapsedTime' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("addElapsedTime", "(J)V", "GetAddElapsedTime_JHandler")]
		public virtual unsafe void AddElapsedTime (long p0)
		{
			if (id_addElapsedTime_J == IntPtr.Zero)
				id_addElapsedTime_J = JNIEnv.GetMethodID (class_ref, "addElapsedTime", "(J)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_addElapsedTime_J, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addElapsedTime", "(J)V"), __args);
			} finally {
			}
		}

		static Delegate cb_calculateStatistics;
#pragma warning disable 0169
		static Delegate GetCalculateStatisticsHandler ()
		{
			if (cb_calculateStatistics == null)
				cb_calculateStatistics = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CalculateStatistics);
			return cb_calculateStatistics;
		}

		static void n_CalculateStatistics (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Util.Benchmark.BenchmarkTaskResults __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.Benchmark.BenchmarkTaskResults> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CalculateStatistics ();
		}
#pragma warning restore 0169

		static IntPtr id_calculateStatistics;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util.benchmark']/class[@name='BenchmarkTaskResults']/method[@name='calculateStatistics' and count(parameter)=0]"
		[Register ("calculateStatistics", "()V", "GetCalculateStatisticsHandler")]
		public virtual unsafe void CalculateStatistics ()
		{
			if (id_calculateStatistics == IntPtr.Zero)
				id_calculateStatistics = JNIEnv.GetMethodID (class_ref, "calculateStatistics", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_calculateStatistics);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "calculateStatistics", "()V"));
			} finally {
			}
		}

		static Delegate cb_getElapsedTimes;
#pragma warning disable 0169
		static Delegate GetGetElapsedTimesHandler ()
		{
			if (cb_getElapsedTimes == null)
				cb_getElapsedTimes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetElapsedTimes);
			return cb_getElapsedTimes;
		}

		static IntPtr n_GetElapsedTimes (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Util.Benchmark.BenchmarkTaskResults __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.Benchmark.BenchmarkTaskResults> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetElapsedTimes ());
		}
#pragma warning restore 0169

		static IntPtr id_getElapsedTimes;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util.benchmark']/class[@name='BenchmarkTaskResults']/method[@name='getElapsedTimes' and count(parameter)=0]"
		[Register ("getElapsedTimes", "()[J", "GetGetElapsedTimesHandler")]
		public virtual unsafe long[] GetElapsedTimes ()
		{
			if (id_getElapsedTimes == IntPtr.Zero)
				id_getElapsedTimes = JNIEnv.GetMethodID (class_ref, "getElapsedTimes", "()[J");
			try {

				if (GetType () == ThresholdType)
					return (long[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getElapsedTimes), JniHandleOwnership.TransferLocalRef, typeof (long));
				else
					return (long[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getElapsedTimes", "()[J")), JniHandleOwnership.TransferLocalRef, typeof (long));
			} finally {
			}
		}

	}
}
