using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Encog.Engine.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.encog.engine.util']/class[@name='ErrorCalculation']"
	[global::Android.Runtime.Register ("org/encog/engine/util/ErrorCalculation", DoNotGenerateAcw=true)]
	public partial class ErrorCalculation : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/encog/engine/util/ErrorCalculation", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ErrorCalculation); }
		}

		protected ErrorCalculation (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.encog.engine.util']/class[@name='ErrorCalculation']/constructor[@name='ErrorCalculation' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ErrorCalculation ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ErrorCalculation)) {
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

		static IntPtr id_getMode;
		static IntPtr id_setMode_Lorg_encog_engine_util_ErrorCalculationMode_;
		public static unsafe global::Org.Encog.Engine.Util.ErrorCalculationMode Mode {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.util']/class[@name='ErrorCalculation']/method[@name='getMode' and count(parameter)=0]"
			[Register ("getMode", "()Lorg/encog/engine/util/ErrorCalculationMode;", "GetGetModeHandler")]
			get {
				if (id_getMode == IntPtr.Zero)
					id_getMode = JNIEnv.GetStaticMethodID (class_ref, "getMode", "()Lorg/encog/engine/util/ErrorCalculationMode;");
				try {
					return global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Util.ErrorCalculationMode> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getMode), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.util']/class[@name='ErrorCalculation']/method[@name='setMode' and count(parameter)=1 and parameter[1][@type='org.encog.engine.util.ErrorCalculationMode']]"
			[Register ("setMode", "(Lorg/encog/engine/util/ErrorCalculationMode;)V", "GetSetMode_Lorg_encog_engine_util_ErrorCalculationMode_Handler")]
			set {
				if (id_setMode_Lorg_encog_engine_util_ErrorCalculationMode_ == IntPtr.Zero)
					id_setMode_Lorg_encog_engine_util_ErrorCalculationMode_ = JNIEnv.GetStaticMethodID (class_ref, "setMode", "(Lorg/encog/engine/util/ErrorCalculationMode;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallStaticVoidMethod  (class_ref, id_setMode_Lorg_encog_engine_util_ErrorCalculationMode_, __args);
				} finally {
				}
			}
		}

		static Delegate cb_calculate;
#pragma warning disable 0169
		static Delegate GetCalculateHandler ()
		{
			if (cb_calculate == null)
				cb_calculate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_Calculate);
			return cb_calculate;
		}

		static double n_Calculate (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Util.ErrorCalculation __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Util.ErrorCalculation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Calculate ();
		}
#pragma warning restore 0169

		static IntPtr id_calculate;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.util']/class[@name='ErrorCalculation']/method[@name='calculate' and count(parameter)=0]"
		[Register ("calculate", "()D", "GetCalculateHandler")]
		public virtual unsafe double Calculate ()
		{
			if (id_calculate == IntPtr.Zero)
				id_calculate = JNIEnv.GetMethodID (class_ref, "calculate", "()D");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_calculate);
				else
					return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "calculate", "()D"));
			} finally {
			}
		}

		static Delegate cb_calculateARCTAN;
#pragma warning disable 0169
		static Delegate GetCalculateARCTANHandler ()
		{
			if (cb_calculateARCTAN == null)
				cb_calculateARCTAN = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_CalculateARCTAN);
			return cb_calculateARCTAN;
		}

		static double n_CalculateARCTAN (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Util.ErrorCalculation __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Util.ErrorCalculation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CalculateARCTAN ();
		}
#pragma warning restore 0169

		static IntPtr id_calculateARCTAN;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.util']/class[@name='ErrorCalculation']/method[@name='calculateARCTAN' and count(parameter)=0]"
		[Register ("calculateARCTAN", "()D", "GetCalculateARCTANHandler")]
		public virtual unsafe double CalculateARCTAN ()
		{
			if (id_calculateARCTAN == IntPtr.Zero)
				id_calculateARCTAN = JNIEnv.GetMethodID (class_ref, "calculateARCTAN", "()D");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_calculateARCTAN);
				else
					return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "calculateARCTAN", "()D"));
			} finally {
			}
		}

		static Delegate cb_calculateMSE;
#pragma warning disable 0169
		static Delegate GetCalculateMSEHandler ()
		{
			if (cb_calculateMSE == null)
				cb_calculateMSE = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_CalculateMSE);
			return cb_calculateMSE;
		}

		static double n_CalculateMSE (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Util.ErrorCalculation __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Util.ErrorCalculation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CalculateMSE ();
		}
#pragma warning restore 0169

		static IntPtr id_calculateMSE;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.util']/class[@name='ErrorCalculation']/method[@name='calculateMSE' and count(parameter)=0]"
		[Register ("calculateMSE", "()D", "GetCalculateMSEHandler")]
		public virtual unsafe double CalculateMSE ()
		{
			if (id_calculateMSE == IntPtr.Zero)
				id_calculateMSE = JNIEnv.GetMethodID (class_ref, "calculateMSE", "()D");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_calculateMSE);
				else
					return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "calculateMSE", "()D"));
			} finally {
			}
		}

		static Delegate cb_calculateRMS;
#pragma warning disable 0169
		static Delegate GetCalculateRMSHandler ()
		{
			if (cb_calculateRMS == null)
				cb_calculateRMS = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_CalculateRMS);
			return cb_calculateRMS;
		}

		static double n_CalculateRMS (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Util.ErrorCalculation __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Util.ErrorCalculation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CalculateRMS ();
		}
#pragma warning restore 0169

		static IntPtr id_calculateRMS;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.util']/class[@name='ErrorCalculation']/method[@name='calculateRMS' and count(parameter)=0]"
		[Register ("calculateRMS", "()D", "GetCalculateRMSHandler")]
		public virtual unsafe double CalculateRMS ()
		{
			if (id_calculateRMS == IntPtr.Zero)
				id_calculateRMS = JNIEnv.GetMethodID (class_ref, "calculateRMS", "()D");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_calculateRMS);
				else
					return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "calculateRMS", "()D"));
			} finally {
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
			global::Org.Encog.Engine.Util.ErrorCalculation __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Util.ErrorCalculation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Reset ();
		}
#pragma warning restore 0169

		static IntPtr id_reset;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.util']/class[@name='ErrorCalculation']/method[@name='reset' and count(parameter)=0]"
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

		static Delegate cb_updateError_DD;
#pragma warning disable 0169
		static Delegate GetUpdateError_DDHandler ()
		{
			if (cb_updateError_DD == null)
				cb_updateError_DD = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double, double>) n_UpdateError_DD);
			return cb_updateError_DD;
		}

		static void n_UpdateError_DD (IntPtr jnienv, IntPtr native__this, double p0, double p1)
		{
			global::Org.Encog.Engine.Util.ErrorCalculation __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Util.ErrorCalculation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UpdateError (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_updateError_DD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.util']/class[@name='ErrorCalculation']/method[@name='updateError' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='double']]"
		[Register ("updateError", "(DD)V", "GetUpdateError_DDHandler")]
		public virtual unsafe void UpdateError (double p0, double p1)
		{
			if (id_updateError_DD == IntPtr.Zero)
				id_updateError_DD = JNIEnv.GetMethodID (class_ref, "updateError", "(DD)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateError_DD, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateError", "(DD)V"), __args);
			} finally {
			}
		}

		static Delegate cb_updateError_arrayDarrayD;
#pragma warning disable 0169
		static Delegate GetUpdateError_arrayDarrayDHandler ()
		{
			if (cb_updateError_arrayDarrayD == null)
				cb_updateError_arrayDarrayD = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_UpdateError_arrayDarrayD);
			return cb_updateError_arrayDarrayD;
		}

		static void n_UpdateError_arrayDarrayD (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Encog.Engine.Util.ErrorCalculation __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Util.ErrorCalculation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			double[] p0 = (double[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (double));
			double[] p1 = (double[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (double));
			__this.UpdateError (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		static IntPtr id_updateError_arrayDarrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.util']/class[@name='ErrorCalculation']/method[@name='updateError' and count(parameter)=2 and parameter[1][@type='double[]'] and parameter[2][@type='double[]']]"
		[Register ("updateError", "([D[D)V", "GetUpdateError_arrayDarrayDHandler")]
		public virtual unsafe void UpdateError (double[] p0, double[] p1)
		{
			if (id_updateError_arrayDarrayD == IntPtr.Zero)
				id_updateError_arrayDarrayD = JNIEnv.GetMethodID (class_ref, "updateError", "([D[D)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateError_arrayDarrayD, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateError", "([D[D)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

	}
}
