using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Contrib.Imgrec {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.contrib.imgrec']/class[@name='FractionRgbData']"
	[global::Android.Runtime.Register ("org/neuroph/contrib/imgrec/FractionRgbData", DoNotGenerateAcw=true)]
	public partial class FractionRgbData : global::Java.Lang.Object {


		static IntPtr blueValues_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.neuroph.contrib.imgrec']/class[@name='FractionRgbData']/field[@name='blueValues']"
		[Register ("blueValues")]
		protected IList<double[]> BlueValues {
			get {
				if (blueValues_jfieldId == IntPtr.Zero)
					blueValues_jfieldId = JNIEnv.GetFieldID (class_ref, "blueValues", "[[D");
				return JavaArray<double[]>.FromJniHandle (JNIEnv.GetObjectField (Handle, blueValues_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (blueValues_jfieldId == IntPtr.Zero)
					blueValues_jfieldId = JNIEnv.GetFieldID (class_ref, "blueValues", "[[D");
				IntPtr native_value = JavaArray<double[]>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, blueValues_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr flattenedRgbValues_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.neuroph.contrib.imgrec']/class[@name='FractionRgbData']/field[@name='flattenedRgbValues']"
		[Register ("flattenedRgbValues")]
		protected IList<double> FlattenedRgbValues {
			get {
				if (flattenedRgbValues_jfieldId == IntPtr.Zero)
					flattenedRgbValues_jfieldId = JNIEnv.GetFieldID (class_ref, "flattenedRgbValues", "[D");
				return JavaArray<double>.FromJniHandle (JNIEnv.GetObjectField (Handle, flattenedRgbValues_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (flattenedRgbValues_jfieldId == IntPtr.Zero)
					flattenedRgbValues_jfieldId = JNIEnv.GetFieldID (class_ref, "flattenedRgbValues", "[D");
				IntPtr native_value = JavaArray<double>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, flattenedRgbValues_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr greenValues_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.neuroph.contrib.imgrec']/class[@name='FractionRgbData']/field[@name='greenValues']"
		[Register ("greenValues")]
		protected IList<double[]> GreenValues {
			get {
				if (greenValues_jfieldId == IntPtr.Zero)
					greenValues_jfieldId = JNIEnv.GetFieldID (class_ref, "greenValues", "[[D");
				return JavaArray<double[]>.FromJniHandle (JNIEnv.GetObjectField (Handle, greenValues_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (greenValues_jfieldId == IntPtr.Zero)
					greenValues_jfieldId = JNIEnv.GetFieldID (class_ref, "greenValues", "[[D");
				IntPtr native_value = JavaArray<double[]>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, greenValues_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr redValues_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.neuroph.contrib.imgrec']/class[@name='FractionRgbData']/field[@name='redValues']"
		[Register ("redValues")]
		protected IList<double[]> RedValues {
			get {
				if (redValues_jfieldId == IntPtr.Zero)
					redValues_jfieldId = JNIEnv.GetFieldID (class_ref, "redValues", "[[D");
				return JavaArray<double[]>.FromJniHandle (JNIEnv.GetObjectField (Handle, redValues_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (redValues_jfieldId == IntPtr.Zero)
					redValues_jfieldId = JNIEnv.GetFieldID (class_ref, "redValues", "[[D");
				IntPtr native_value = JavaArray<double[]>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, redValues_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/contrib/imgrec/FractionRgbData", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FractionRgbData); }
		}

		protected FractionRgbData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getHeight;
#pragma warning disable 0169
		static Delegate GetGetHeightHandler ()
		{
			if (cb_getHeight == null)
				cb_getHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHeight);
			return cb_getHeight;
		}

		static int n_GetHeight (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Contrib.Imgrec.FractionRgbData __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.Imgrec.FractionRgbData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Height;
		}
#pragma warning restore 0169

		static IntPtr id_getHeight;
		public virtual unsafe int Height {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.contrib.imgrec']/class[@name='FractionRgbData']/method[@name='getHeight' and count(parameter)=0]"
			[Register ("getHeight", "()I", "GetGetHeightHandler")]
			get {
				if (id_getHeight == IntPtr.Zero)
					id_getHeight = JNIEnv.GetMethodID (class_ref, "getHeight", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getHeight);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHeight", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getWidth;
#pragma warning disable 0169
		static Delegate GetGetWidthHandler ()
		{
			if (cb_getWidth == null)
				cb_getWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetWidth);
			return cb_getWidth;
		}

		static int n_GetWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Contrib.Imgrec.FractionRgbData __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.Imgrec.FractionRgbData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Width;
		}
#pragma warning restore 0169

		static IntPtr id_getWidth;
		public virtual unsafe int Width {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.contrib.imgrec']/class[@name='FractionRgbData']/method[@name='getWidth' and count(parameter)=0]"
			[Register ("getWidth", "()I", "GetGetWidthHandler")]
			get {
				if (id_getWidth == IntPtr.Zero)
					id_getWidth = JNIEnv.GetMethodID (class_ref, "getWidth", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getWidth);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWidth", "()I"));
				} finally {
				}
			}
		}

		static IntPtr id_convertRgbInputToBinaryBlackAndWhite_arrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.contrib.imgrec']/class[@name='FractionRgbData']/method[@name='convertRgbInputToBinaryBlackAndWhite' and count(parameter)=1 and parameter[1][@type='double[]']]"
		[Register ("convertRgbInputToBinaryBlackAndWhite", "([D)[D", "")]
		public static unsafe double[] ConvertRgbInputToBinaryBlackAndWhite (double[] p0)
		{
			if (id_convertRgbInputToBinaryBlackAndWhite_arrayD == IntPtr.Zero)
				id_convertRgbInputToBinaryBlackAndWhite_arrayD = JNIEnv.GetStaticMethodID (class_ref, "convertRgbInputToBinaryBlackAndWhite", "([D)[D");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				double[] __ret = (double[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_convertRgbInputToBinaryBlackAndWhite_arrayD, __args), JniHandleOwnership.TransferLocalRef, typeof (double));
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_getBlueValues;
#pragma warning disable 0169
		static Delegate GetGetBlueValuesHandler ()
		{
			if (cb_getBlueValues == null)
				cb_getBlueValues = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBlueValues);
			return cb_getBlueValues;
		}

		static IntPtr n_GetBlueValues (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Contrib.Imgrec.FractionRgbData __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.Imgrec.FractionRgbData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetBlueValues ());
		}
#pragma warning restore 0169

		static IntPtr id_getBlueValues;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.contrib.imgrec']/class[@name='FractionRgbData']/method[@name='getBlueValues' and count(parameter)=0]"
		[Register ("getBlueValues", "()[[D", "GetGetBlueValuesHandler")]
		public virtual unsafe double[][] GetBlueValues ()
		{
			if (id_getBlueValues == IntPtr.Zero)
				id_getBlueValues = JNIEnv.GetMethodID (class_ref, "getBlueValues", "()[[D");
			try {

				if (GetType () == ThresholdType)
					return (double[][]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getBlueValues), JniHandleOwnership.TransferLocalRef, typeof (double[]));
				else
					return (double[][]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBlueValues", "()[[D")), JniHandleOwnership.TransferLocalRef, typeof (double[]));
			} finally {
			}
		}

		static Delegate cb_getFlattenedRgbValues;
#pragma warning disable 0169
		static Delegate GetGetFlattenedRgbValuesHandler ()
		{
			if (cb_getFlattenedRgbValues == null)
				cb_getFlattenedRgbValues = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFlattenedRgbValues);
			return cb_getFlattenedRgbValues;
		}

		static IntPtr n_GetFlattenedRgbValues (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Contrib.Imgrec.FractionRgbData __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.Imgrec.FractionRgbData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetFlattenedRgbValues ());
		}
#pragma warning restore 0169

		static IntPtr id_getFlattenedRgbValues;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.contrib.imgrec']/class[@name='FractionRgbData']/method[@name='getFlattenedRgbValues' and count(parameter)=0]"
		[Register ("getFlattenedRgbValues", "()[D", "GetGetFlattenedRgbValuesHandler")]
		public virtual unsafe double[] GetFlattenedRgbValues ()
		{
			if (id_getFlattenedRgbValues == IntPtr.Zero)
				id_getFlattenedRgbValues = JNIEnv.GetMethodID (class_ref, "getFlattenedRgbValues", "()[D");
			try {

				if (GetType () == ThresholdType)
					return (double[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getFlattenedRgbValues), JniHandleOwnership.TransferLocalRef, typeof (double));
				else
					return (double[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFlattenedRgbValues", "()[D")), JniHandleOwnership.TransferLocalRef, typeof (double));
			} finally {
			}
		}

		static Delegate cb_getGreenValues;
#pragma warning disable 0169
		static Delegate GetGetGreenValuesHandler ()
		{
			if (cb_getGreenValues == null)
				cb_getGreenValues = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetGreenValues);
			return cb_getGreenValues;
		}

		static IntPtr n_GetGreenValues (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Contrib.Imgrec.FractionRgbData __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.Imgrec.FractionRgbData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetGreenValues ());
		}
#pragma warning restore 0169

		static IntPtr id_getGreenValues;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.contrib.imgrec']/class[@name='FractionRgbData']/method[@name='getGreenValues' and count(parameter)=0]"
		[Register ("getGreenValues", "()[[D", "GetGetGreenValuesHandler")]
		public virtual unsafe double[][] GetGreenValues ()
		{
			if (id_getGreenValues == IntPtr.Zero)
				id_getGreenValues = JNIEnv.GetMethodID (class_ref, "getGreenValues", "()[[D");
			try {

				if (GetType () == ThresholdType)
					return (double[][]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getGreenValues), JniHandleOwnership.TransferLocalRef, typeof (double[]));
				else
					return (double[][]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getGreenValues", "()[[D")), JniHandleOwnership.TransferLocalRef, typeof (double[]));
			} finally {
			}
		}

		static Delegate cb_getRedValues;
#pragma warning disable 0169
		static Delegate GetGetRedValuesHandler ()
		{
			if (cb_getRedValues == null)
				cb_getRedValues = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRedValues);
			return cb_getRedValues;
		}

		static IntPtr n_GetRedValues (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Contrib.Imgrec.FractionRgbData __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Contrib.Imgrec.FractionRgbData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetRedValues ());
		}
#pragma warning restore 0169

		static IntPtr id_getRedValues;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.contrib.imgrec']/class[@name='FractionRgbData']/method[@name='getRedValues' and count(parameter)=0]"
		[Register ("getRedValues", "()[[D", "GetGetRedValuesHandler")]
		public virtual unsafe double[][] GetRedValues ()
		{
			if (id_getRedValues == IntPtr.Zero)
				id_getRedValues = JNIEnv.GetMethodID (class_ref, "getRedValues", "()[[D");
			try {

				if (GetType () == ThresholdType)
					return (double[][]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getRedValues), JniHandleOwnership.TransferLocalRef, typeof (double[]));
				else
					return (double[][]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRedValues", "()[[D")), JniHandleOwnership.TransferLocalRef, typeof (double[]));
			} finally {
			}
		}

	}
}
