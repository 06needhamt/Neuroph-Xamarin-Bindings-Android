using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Encog.Engine.Concurrency {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.encog.engine.concurrency']/class[@name='DetermineWorkload']"
	[global::Android.Runtime.Register ("org/encog/engine/concurrency/DetermineWorkload", DoNotGenerateAcw=true)]
	public partial class DetermineWorkload : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.encog.engine.concurrency']/class[@name='DetermineWorkload']/field[@name='MIN_WORTHWHILE']"
		[Register ("MIN_WORTHWHILE")]
		public const int MinWorthwhile = (int) 100;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/encog/engine/concurrency/DetermineWorkload", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DetermineWorkload); }
		}

		protected DetermineWorkload (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_II;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.encog.engine.concurrency']/class[@name='DetermineWorkload']/constructor[@name='DetermineWorkload' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register (".ctor", "(II)V", "")]
		public unsafe DetermineWorkload (int p0, int p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (DetermineWorkload)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(II)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(II)V", __args);
					return;
				}

				if (id_ctor_II == IntPtr.Zero)
					id_ctor_II = JNIEnv.GetMethodID (class_ref, "<init>", "(II)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_II, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_II, __args);
			} finally {
			}
		}

		static Delegate cb_getThreadCount;
#pragma warning disable 0169
		static Delegate GetGetThreadCountHandler ()
		{
			if (cb_getThreadCount == null)
				cb_getThreadCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetThreadCount);
			return cb_getThreadCount;
		}

		static int n_GetThreadCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Concurrency.DetermineWorkload __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Concurrency.DetermineWorkload> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ThreadCount;
		}
#pragma warning restore 0169

		static IntPtr id_getThreadCount;
		public virtual unsafe int ThreadCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.concurrency']/class[@name='DetermineWorkload']/method[@name='getThreadCount' and count(parameter)=0]"
			[Register ("getThreadCount", "()I", "GetGetThreadCountHandler")]
			get {
				if (id_getThreadCount == IntPtr.Zero)
					id_getThreadCount = JNIEnv.GetMethodID (class_ref, "getThreadCount", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getThreadCount);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getThreadCount", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_calculateWorkers;
#pragma warning disable 0169
		static Delegate GetCalculateWorkersHandler ()
		{
			if (cb_calculateWorkers == null)
				cb_calculateWorkers = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_CalculateWorkers);
			return cb_calculateWorkers;
		}

		static IntPtr n_CalculateWorkers (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Concurrency.DetermineWorkload __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Concurrency.DetermineWorkload> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Org.Encog.Engine.Util.IntRange>.ToLocalJniHandle (__this.CalculateWorkers ());
		}
#pragma warning restore 0169

		static IntPtr id_calculateWorkers;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.concurrency']/class[@name='DetermineWorkload']/method[@name='calculateWorkers' and count(parameter)=0]"
		[Register ("calculateWorkers", "()Ljava/util/List;", "GetCalculateWorkersHandler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Org.Encog.Engine.Util.IntRange> CalculateWorkers ()
		{
			if (id_calculateWorkers == IntPtr.Zero)
				id_calculateWorkers = JNIEnv.GetMethodID (class_ref, "calculateWorkers", "()Ljava/util/List;");
			try {

				if (GetType () == ThresholdType)
					return global::Android.Runtime.JavaList<global::Org.Encog.Engine.Util.IntRange>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_calculateWorkers), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaList<global::Org.Encog.Engine.Util.IntRange>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "calculateWorkers", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
