using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Encog.Engine.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.encog.engine.util']/class[@name='Stopwatch']"
	[global::Android.Runtime.Register ("org/encog/engine/util/Stopwatch", DoNotGenerateAcw=true)]
	public partial class Stopwatch : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/encog/engine/util/Stopwatch", ref java_class_handle);
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.encog.engine.util']/class[@name='Stopwatch']/constructor[@name='Stopwatch' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Stopwatch ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Stopwatch)) {
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

		static Delegate cb_getElapsedMilliseconds;
#pragma warning disable 0169
		static Delegate GetGetElapsedMillisecondsHandler ()
		{
			if (cb_getElapsedMilliseconds == null)
				cb_getElapsedMilliseconds = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetElapsedMilliseconds);
			return cb_getElapsedMilliseconds;
		}

		static long n_GetElapsedMilliseconds (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Util.Stopwatch __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Util.Stopwatch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ElapsedMilliseconds;
		}
#pragma warning restore 0169

		static IntPtr id_getElapsedMilliseconds;
		public virtual unsafe long ElapsedMilliseconds {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.util']/class[@name='Stopwatch']/method[@name='getElapsedMilliseconds' and count(parameter)=0]"
			[Register ("getElapsedMilliseconds", "()J", "GetGetElapsedMillisecondsHandler")]
			get {
				if (id_getElapsedMilliseconds == IntPtr.Zero)
					id_getElapsedMilliseconds = JNIEnv.GetMethodID (class_ref, "getElapsedMilliseconds", "()J");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallLongMethod  (Handle, id_getElapsedMilliseconds);
					else
						return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getElapsedMilliseconds", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_getElapsedTicks;
#pragma warning disable 0169
		static Delegate GetGetElapsedTicksHandler ()
		{
			if (cb_getElapsedTicks == null)
				cb_getElapsedTicks = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetElapsedTicks);
			return cb_getElapsedTicks;
		}

		static long n_GetElapsedTicks (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Util.Stopwatch __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Util.Stopwatch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ElapsedTicks;
		}
#pragma warning restore 0169

		static IntPtr id_getElapsedTicks;
		public virtual unsafe long ElapsedTicks {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.util']/class[@name='Stopwatch']/method[@name='getElapsedTicks' and count(parameter)=0]"
			[Register ("getElapsedTicks", "()J", "GetGetElapsedTicksHandler")]
			get {
				if (id_getElapsedTicks == IntPtr.Zero)
					id_getElapsedTicks = JNIEnv.GetMethodID (class_ref, "getElapsedTicks", "()J");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallLongMethod  (Handle, id_getElapsedTicks);
					else
						return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getElapsedTicks", "()J"));
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
			global::Org.Encog.Engine.Util.Stopwatch __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Util.Stopwatch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Reset ();
		}
#pragma warning restore 0169

		static IntPtr id_reset;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.util']/class[@name='Stopwatch']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "GetResetHandler")]
		public virtual unsafe void Reset ()
		{
			if (id_reset == IntPtr.Zero)
				id_reset = JNIEnv.GetMethodID (class_ref, "reset", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_reset);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "reset", "()V"));
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
			global::Org.Encog.Engine.Util.Stopwatch __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Util.Stopwatch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Start ();
		}
#pragma warning restore 0169

		static IntPtr id_start;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.util']/class[@name='Stopwatch']/method[@name='start' and count(parameter)=0]"
		[Register ("start", "()V", "GetStartHandler")]
		public virtual unsafe void Start ()
		{
			if (id_start == IntPtr.Zero)
				id_start = JNIEnv.GetMethodID (class_ref, "start", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_start);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "start", "()V"));
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
			global::Org.Encog.Engine.Util.Stopwatch __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Util.Stopwatch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop ();
		}
#pragma warning restore 0169

		static IntPtr id_stop;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.util']/class[@name='Stopwatch']/method[@name='stop' and count(parameter)=0]"
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
}
