using System;
using System.Collections.Generic;
using Android.Runtime;

namespace BE.Abeel.Bioinformatics.Dnaproperties {

	// Metadata.xml XPath class reference: path="/api/package[@name='be.abeel.bioinformatics.dnaproperties']/class[@name='ConversionMapDNAProperty']"
	[global::Android.Runtime.Register ("be/abeel/bioinformatics/dnaproperties/ConversionMapDNAProperty", DoNotGenerateAcw=true)]
	public partial class ConversionMapDNAProperty : global::BE.Abeel.Bioinformatics.Dnaproperties.DNAProperty {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("be/abeel/bioinformatics/dnaproperties/ConversionMapDNAProperty", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ConversionMapDNAProperty); }
		}

		protected ConversionMapDNAProperty (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='be.abeel.bioinformatics.dnaproperties']/class[@name='ConversionMapDNAProperty']/constructor[@name='ConversionMapDNAProperty' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		protected unsafe ConversionMapDNAProperty (string p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (ConversionMapDNAProperty)) {
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

		static Delegate cb_length;
#pragma warning disable 0169
		static Delegate GetLengthHandler ()
		{
			if (cb_length == null)
				cb_length = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Length);
			return cb_length;
		}

		static int n_Length (IntPtr jnienv, IntPtr native__this)
		{
			global::BE.Abeel.Bioinformatics.Dnaproperties.ConversionMapDNAProperty __this = global::Java.Lang.Object.GetObject<global::BE.Abeel.Bioinformatics.Dnaproperties.ConversionMapDNAProperty> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Length ();
		}
#pragma warning restore 0169

		static IntPtr id_length;
		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.bioinformatics.dnaproperties']/class[@name='ConversionMapDNAProperty']/method[@name='length' and count(parameter)=0]"
		[Register ("length", "()I", "GetLengthHandler")]
		public override unsafe int Length ()
		{
			if (id_length == IntPtr.Zero)
				id_length = JNIEnv.GetMethodID (class_ref, "length", "()I");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_length);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "length", "()I"));
			} finally {
			}
		}

		static Delegate cb_normalizedProfile_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetNormalizedProfile_Ljava_lang_String_Handler ()
		{
			if (cb_normalizedProfile_Ljava_lang_String_ == null)
				cb_normalizedProfile_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_NormalizedProfile_Ljava_lang_String_);
			return cb_normalizedProfile_Ljava_lang_String_;
		}

		static IntPtr n_NormalizedProfile_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BE.Abeel.Bioinformatics.Dnaproperties.ConversionMapDNAProperty __this = global::Java.Lang.Object.GetObject<global::BE.Abeel.Bioinformatics.Dnaproperties.ConversionMapDNAProperty> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.NormalizedProfile (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_normalizedProfile_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.bioinformatics.dnaproperties']/class[@name='ConversionMapDNAProperty']/method[@name='normalizedProfile' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("normalizedProfile", "(Ljava/lang/String;)[D", "GetNormalizedProfile_Ljava_lang_String_Handler")]
		public override unsafe double[] NormalizedProfile (string p0)
		{
			if (id_normalizedProfile_Ljava_lang_String_ == IntPtr.Zero)
				id_normalizedProfile_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "normalizedProfile", "(Ljava/lang/String;)[D");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				double[] __ret;
				if (GetType () == ThresholdType)
					__ret = (double[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_normalizedProfile_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (double));
				else
					__ret = (double[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "normalizedProfile", "(Ljava/lang/String;)[D"), __args), JniHandleOwnership.TransferLocalRef, typeof (double));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_normalizedValue_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetNormalizedValue_Ljava_lang_String_Handler ()
		{
			if (cb_normalizedValue_Ljava_lang_String_ == null)
				cb_normalizedValue_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, double>) n_NormalizedValue_Ljava_lang_String_);
			return cb_normalizedValue_Ljava_lang_String_;
		}

		static double n_NormalizedValue_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BE.Abeel.Bioinformatics.Dnaproperties.ConversionMapDNAProperty __this = global::Java.Lang.Object.GetObject<global::BE.Abeel.Bioinformatics.Dnaproperties.ConversionMapDNAProperty> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			double __ret = __this.NormalizedValue (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_normalizedValue_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.bioinformatics.dnaproperties']/class[@name='ConversionMapDNAProperty']/method[@name='normalizedValue' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("normalizedValue", "(Ljava/lang/String;)D", "GetNormalizedValue_Ljava_lang_String_Handler")]
		public override unsafe double NormalizedValue (string p0)
		{
			if (id_normalizedValue_Ljava_lang_String_ == IntPtr.Zero)
				id_normalizedValue_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "normalizedValue", "(Ljava/lang/String;)D");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				double __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallDoubleMethod  (Handle, id_normalizedValue_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "normalizedValue", "(Ljava/lang/String;)D"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_profile_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetProfile_Ljava_lang_String_Handler ()
		{
			if (cb_profile_Ljava_lang_String_ == null)
				cb_profile_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Profile_Ljava_lang_String_);
			return cb_profile_Ljava_lang_String_;
		}

		static IntPtr n_Profile_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BE.Abeel.Bioinformatics.Dnaproperties.ConversionMapDNAProperty __this = global::Java.Lang.Object.GetObject<global::BE.Abeel.Bioinformatics.Dnaproperties.ConversionMapDNAProperty> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.Profile (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_profile_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.bioinformatics.dnaproperties']/class[@name='ConversionMapDNAProperty']/method[@name='profile' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("profile", "(Ljava/lang/String;)[D", "GetProfile_Ljava_lang_String_Handler")]
		public override unsafe double[] Profile (string p0)
		{
			if (id_profile_Ljava_lang_String_ == IntPtr.Zero)
				id_profile_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "profile", "(Ljava/lang/String;)[D");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				double[] __ret;
				if (GetType () == ThresholdType)
					__ret = (double[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_profile_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (double));
				else
					__ret = (double[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "profile", "(Ljava/lang/String;)[D"), __args), JniHandleOwnership.TransferLocalRef, typeof (double));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_value_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetValue_Ljava_lang_String_Handler ()
		{
			if (cb_value_Ljava_lang_String_ == null)
				cb_value_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, double>) n_Value_Ljava_lang_String_);
			return cb_value_Ljava_lang_String_;
		}

		static double n_Value_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BE.Abeel.Bioinformatics.Dnaproperties.ConversionMapDNAProperty __this = global::Java.Lang.Object.GetObject<global::BE.Abeel.Bioinformatics.Dnaproperties.ConversionMapDNAProperty> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			double __ret = __this.Value (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_value_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.bioinformatics.dnaproperties']/class[@name='ConversionMapDNAProperty']/method[@name='value' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("value", "(Ljava/lang/String;)D", "GetValue_Ljava_lang_String_Handler")]
		public override unsafe double Value (string p0)
		{
			if (id_value_Ljava_lang_String_ == IntPtr.Zero)
				id_value_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "value", "(Ljava/lang/String;)D");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				double __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallDoubleMethod  (Handle, id_value_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "value", "(Ljava/lang/String;)D"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
