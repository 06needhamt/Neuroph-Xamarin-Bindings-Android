using System;
using System.Collections.Generic;
using Android.Runtime;

namespace BE.Abeel.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='be.abeel.util']/class[@name='TimeInterval']"
	[global::Android.Runtime.Register ("be/abeel/util/TimeInterval", DoNotGenerateAcw=true)]
	public partial class TimeInterval : global::Java.Lang.Object, global::Java.IO.ISerializable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("be/abeel/util/TimeInterval", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TimeInterval); }
		}

		protected TimeInterval (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='be.abeel.util']/class[@name='TimeInterval']/constructor[@name='TimeInterval' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe TimeInterval (string p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (TimeInterval)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_ctor_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='be.abeel.util']/class[@name='TimeInterval']/constructor[@name='TimeInterval' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		public unsafe TimeInterval (long p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (TimeInterval)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(J)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(J)V", __args);
					return;
				}

				if (id_ctor_J == IntPtr.Zero)
					id_ctor_J = JNIEnv.GetMethodID (class_ref, "<init>", "(J)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_J, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_J, __args);
			} finally {
			}
		}

		static Delegate cb_getDays;
#pragma warning disable 0169
		static Delegate GetGetDaysHandler ()
		{
			if (cb_getDays == null)
				cb_getDays = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetDays);
			return cb_getDays;
		}

		static long n_GetDays (IntPtr jnienv, IntPtr native__this)
		{
			global::BE.Abeel.Util.TimeInterval __this = global::Java.Lang.Object.GetObject<global::BE.Abeel.Util.TimeInterval> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Days;
		}
#pragma warning restore 0169

		static IntPtr id_getDays;
		public virtual unsafe long Days {
			// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.util']/class[@name='TimeInterval']/method[@name='getDays' and count(parameter)=0]"
			[Register ("getDays", "()J", "GetGetDaysHandler")]
			get {
				if (id_getDays == IntPtr.Zero)
					id_getDays = JNIEnv.GetMethodID (class_ref, "getDays", "()J");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallLongMethod  (Handle, id_getDays);
					else
						return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDays", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_getHours;
#pragma warning disable 0169
		static Delegate GetGetHoursHandler ()
		{
			if (cb_getHours == null)
				cb_getHours = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetHours);
			return cb_getHours;
		}

		static long n_GetHours (IntPtr jnienv, IntPtr native__this)
		{
			global::BE.Abeel.Util.TimeInterval __this = global::Java.Lang.Object.GetObject<global::BE.Abeel.Util.TimeInterval> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Hours;
		}
#pragma warning restore 0169

		static IntPtr id_getHours;
		public virtual unsafe long Hours {
			// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.util']/class[@name='TimeInterval']/method[@name='getHours' and count(parameter)=0]"
			[Register ("getHours", "()J", "GetGetHoursHandler")]
			get {
				if (id_getHours == IntPtr.Zero)
					id_getHours = JNIEnv.GetMethodID (class_ref, "getHours", "()J");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallLongMethod  (Handle, id_getHours);
					else
						return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHours", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_getLengthInMilliseconds;
#pragma warning disable 0169
		static Delegate GetGetLengthInMillisecondsHandler ()
		{
			if (cb_getLengthInMilliseconds == null)
				cb_getLengthInMilliseconds = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetLengthInMilliseconds);
			return cb_getLengthInMilliseconds;
		}

		static long n_GetLengthInMilliseconds (IntPtr jnienv, IntPtr native__this)
		{
			global::BE.Abeel.Util.TimeInterval __this = global::Java.Lang.Object.GetObject<global::BE.Abeel.Util.TimeInterval> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LengthInMilliseconds;
		}
#pragma warning restore 0169

		static IntPtr id_getLengthInMilliseconds;
		public virtual unsafe long LengthInMilliseconds {
			// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.util']/class[@name='TimeInterval']/method[@name='getLengthInMilliseconds' and count(parameter)=0]"
			[Register ("getLengthInMilliseconds", "()J", "GetGetLengthInMillisecondsHandler")]
			get {
				if (id_getLengthInMilliseconds == IntPtr.Zero)
					id_getLengthInMilliseconds = JNIEnv.GetMethodID (class_ref, "getLengthInMilliseconds", "()J");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallLongMethod  (Handle, id_getLengthInMilliseconds);
					else
						return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLengthInMilliseconds", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_getMilliseconds;
#pragma warning disable 0169
		static Delegate GetGetMillisecondsHandler ()
		{
			if (cb_getMilliseconds == null)
				cb_getMilliseconds = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetMilliseconds);
			return cb_getMilliseconds;
		}

		static long n_GetMilliseconds (IntPtr jnienv, IntPtr native__this)
		{
			global::BE.Abeel.Util.TimeInterval __this = global::Java.Lang.Object.GetObject<global::BE.Abeel.Util.TimeInterval> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Milliseconds;
		}
#pragma warning restore 0169

		static IntPtr id_getMilliseconds;
		public virtual unsafe long Milliseconds {
			// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.util']/class[@name='TimeInterval']/method[@name='getMilliseconds' and count(parameter)=0]"
			[Register ("getMilliseconds", "()J", "GetGetMillisecondsHandler")]
			get {
				if (id_getMilliseconds == IntPtr.Zero)
					id_getMilliseconds = JNIEnv.GetMethodID (class_ref, "getMilliseconds", "()J");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallLongMethod  (Handle, id_getMilliseconds);
					else
						return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMilliseconds", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_getMinutes;
#pragma warning disable 0169
		static Delegate GetGetMinutesHandler ()
		{
			if (cb_getMinutes == null)
				cb_getMinutes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetMinutes);
			return cb_getMinutes;
		}

		static long n_GetMinutes (IntPtr jnienv, IntPtr native__this)
		{
			global::BE.Abeel.Util.TimeInterval __this = global::Java.Lang.Object.GetObject<global::BE.Abeel.Util.TimeInterval> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Minutes;
		}
#pragma warning restore 0169

		static IntPtr id_getMinutes;
		public virtual unsafe long Minutes {
			// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.util']/class[@name='TimeInterval']/method[@name='getMinutes' and count(parameter)=0]"
			[Register ("getMinutes", "()J", "GetGetMinutesHandler")]
			get {
				if (id_getMinutes == IntPtr.Zero)
					id_getMinutes = JNIEnv.GetMethodID (class_ref, "getMinutes", "()J");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallLongMethod  (Handle, id_getMinutes);
					else
						return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMinutes", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_getSeconds;
#pragma warning disable 0169
		static Delegate GetGetSecondsHandler ()
		{
			if (cb_getSeconds == null)
				cb_getSeconds = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetSeconds);
			return cb_getSeconds;
		}

		static long n_GetSeconds (IntPtr jnienv, IntPtr native__this)
		{
			global::BE.Abeel.Util.TimeInterval __this = global::Java.Lang.Object.GetObject<global::BE.Abeel.Util.TimeInterval> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Seconds;
		}
#pragma warning restore 0169

		static IntPtr id_getSeconds;
		public virtual unsafe long Seconds {
			// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.util']/class[@name='TimeInterval']/method[@name='getSeconds' and count(parameter)=0]"
			[Register ("getSeconds", "()J", "GetGetSecondsHandler")]
			get {
				if (id_getSeconds == IntPtr.Zero)
					id_getSeconds = JNIEnv.GetMethodID (class_ref, "getSeconds", "()J");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallLongMethod  (Handle, id_getSeconds);
					else
						return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSeconds", "()J"));
				} finally {
				}
			}
		}

	}
}
