using System;
using System.Collections.Generic;
using Android.Runtime;

namespace CH.Qos.Logback.Classic.Spi {

	// Metadata.xml XPath class reference: path="/api/package[@name='ch.qos.logback.classic.spi']/class[@name='PackagingDataCalculator']"
	[global::Android.Runtime.Register ("ch/qos/logback/classic/spi/PackagingDataCalculator", DoNotGenerateAcw=true)]
	public partial class PackagingDataCalculator : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("ch/qos/logback/classic/spi/PackagingDataCalculator", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PackagingDataCalculator); }
		}

		protected PackagingDataCalculator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='ch.qos.logback.classic.spi']/class[@name='PackagingDataCalculator']/constructor[@name='PackagingDataCalculator' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PackagingDataCalculator ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (PackagingDataCalculator)) {
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

		static Delegate cb_calculate_Lch_qos_logback_classic_spi_IThrowableProxy_;
#pragma warning disable 0169
		static Delegate GetCalculate_Lch_qos_logback_classic_spi_IThrowableProxy_Handler ()
		{
			if (cb_calculate_Lch_qos_logback_classic_spi_IThrowableProxy_ == null)
				cb_calculate_Lch_qos_logback_classic_spi_IThrowableProxy_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Calculate_Lch_qos_logback_classic_spi_IThrowableProxy_);
			return cb_calculate_Lch_qos_logback_classic_spi_IThrowableProxy_;
		}

		static void n_Calculate_Lch_qos_logback_classic_spi_IThrowableProxy_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CH.Qos.Logback.Classic.Spi.PackagingDataCalculator __this = global::Java.Lang.Object.GetObject<global::CH.Qos.Logback.Classic.Spi.PackagingDataCalculator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::CH.Qos.Logback.Classic.Spi.IThrowableProxy p0 = (global::CH.Qos.Logback.Classic.Spi.IThrowableProxy)global::Java.Lang.Object.GetObject<global::CH.Qos.Logback.Classic.Spi.IThrowableProxy> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Calculate (p0);
		}
#pragma warning restore 0169

		static IntPtr id_calculate_Lch_qos_logback_classic_spi_IThrowableProxy_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ch.qos.logback.classic.spi']/class[@name='PackagingDataCalculator']/method[@name='calculate' and count(parameter)=1 and parameter[1][@type='ch.qos.logback.classic.spi.IThrowableProxy']]"
		[Register ("calculate", "(Lch/qos/logback/classic/spi/IThrowableProxy;)V", "GetCalculate_Lch_qos_logback_classic_spi_IThrowableProxy_Handler")]
		public virtual unsafe void Calculate (global::CH.Qos.Logback.Classic.Spi.IThrowableProxy p0)
		{
			if (id_calculate_Lch_qos_logback_classic_spi_IThrowableProxy_ == IntPtr.Zero)
				id_calculate_Lch_qos_logback_classic_spi_IThrowableProxy_ = JNIEnv.GetMethodID (class_ref, "calculate", "(Lch/qos/logback/classic/spi/IThrowableProxy;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_calculate_Lch_qos_logback_classic_spi_IThrowableProxy_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "calculate", "(Lch/qos/logback/classic/spi/IThrowableProxy;)V"), __args);
			} finally {
			}
		}

	}
}
