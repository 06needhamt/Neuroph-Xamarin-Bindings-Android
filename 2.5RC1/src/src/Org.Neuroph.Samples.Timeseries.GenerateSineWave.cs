using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Samples.Timeseries {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.samples.timeseries']/class[@name='GenerateSineWave']"
	[global::Android.Runtime.Register ("org/neuroph/samples/timeseries/GenerateSineWave", DoNotGenerateAcw=true)]
	public partial class GenerateSineWave : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/samples/timeseries/GenerateSineWave", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GenerateSineWave); }
		}

		protected GenerateSineWave (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getNextSample;
#pragma warning disable 0169
		static Delegate GetGetNextSampleHandler ()
		{
			if (cb_getNextSample == null)
				cb_getNextSample = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetNextSample);
			return cb_getNextSample;
		}

		static double n_GetNextSample (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Samples.Timeseries.GenerateSineWave __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Samples.Timeseries.GenerateSineWave> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NextSample;
		}
#pragma warning restore 0169

		static IntPtr id_getNextSample;
		public virtual unsafe double NextSample {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.samples.timeseries']/class[@name='GenerateSineWave']/method[@name='getNextSample' and count(parameter)=0]"
			[Register ("getNextSample", "()D", "GetGetNextSampleHandler")]
			get {
				if (id_getNextSample == IntPtr.Zero)
					id_getNextSample = JNIEnv.GetMethodID (class_ref, "getNextSample", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getNextSample);
					else
						return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNextSample", "()D"));
				} finally {
				}
			}
		}

	}
}
