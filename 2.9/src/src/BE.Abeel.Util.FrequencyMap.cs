using System;
using System.Collections.Generic;
using Android.Runtime;

namespace BE.Abeel.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='be.abeel.util']/class[@name='FrequencyMap']"
	[global::Android.Runtime.Register ("be/abeel/util/FrequencyMap", DoNotGenerateAcw=true)]
	public partial class FrequencyMap : global::BE.Abeel.Util.DefaultTreeMap {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("be/abeel/util/FrequencyMap", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FrequencyMap); }
		}

		protected FrequencyMap (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='be.abeel.util']/class[@name='FrequencyMap']/constructor[@name='FrequencyMap' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe FrequencyMap ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (FrequencyMap)) {
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

		static Delegate cb_average;
#pragma warning disable 0169
		static Delegate GetAverageHandler ()
		{
			if (cb_average == null)
				cb_average = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_Average);
			return cb_average;
		}

		static double n_Average (IntPtr jnienv, IntPtr native__this)
		{
			global::BE.Abeel.Util.FrequencyMap __this = global::Java.Lang.Object.GetObject<global::BE.Abeel.Util.FrequencyMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Average ();
		}
#pragma warning restore 0169

		static IntPtr id_average;
		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.util']/class[@name='FrequencyMap']/method[@name='average' and count(parameter)=0]"
		[Register ("average", "()D", "GetAverageHandler")]
		public virtual unsafe double Average ()
		{
			if (id_average == IntPtr.Zero)
				id_average = JNIEnv.GetMethodID (class_ref, "average", "()D");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallDoubleMethod  (Handle, id_average);
				else
					return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "average", "()D"));
			} finally {
			}
		}

		static Delegate cb_bin_I;
#pragma warning disable 0169
		static Delegate GetBin_IHandler ()
		{
			if (cb_bin_I == null)
				cb_bin_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_Bin_I);
			return cb_bin_I;
		}

		static IntPtr n_Bin_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::BE.Abeel.Util.FrequencyMap __this = global::Java.Lang.Object.GetObject<global::BE.Abeel.Util.FrequencyMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Bin (p0));
		}
#pragma warning restore 0169

		static IntPtr id_bin_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.util']/class[@name='FrequencyMap']/method[@name='bin' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("bin", "(I)Lbe/abeel/util/FrequencyMap;", "GetBin_IHandler")]
		public virtual unsafe global::BE.Abeel.Util.FrequencyMap Bin (int p0)
		{
			if (id_bin_I == IntPtr.Zero)
				id_bin_I = JNIEnv.GetMethodID (class_ref, "bin", "(I)Lbe/abeel/util/FrequencyMap;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::BE.Abeel.Util.FrequencyMap> (JNIEnv.CallObjectMethod  (Handle, id_bin_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::BE.Abeel.Util.FrequencyMap> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "bin", "(I)Lbe/abeel/util/FrequencyMap;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_copy;
#pragma warning disable 0169
		static Delegate GetCopyHandler ()
		{
			if (cb_copy == null)
				cb_copy = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Copy);
			return cb_copy;
		}

		static IntPtr n_Copy (IntPtr jnienv, IntPtr native__this)
		{
			global::BE.Abeel.Util.FrequencyMap __this = global::Java.Lang.Object.GetObject<global::BE.Abeel.Util.FrequencyMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Copy ());
		}
#pragma warning restore 0169

		static IntPtr id_copy;
		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.util']/class[@name='FrequencyMap']/method[@name='copy' and count(parameter)=0]"
		[Register ("copy", "()Lbe/abeel/util/FrequencyMap;", "GetCopyHandler")]
		public virtual unsafe global::BE.Abeel.Util.FrequencyMap Copy ()
		{
			if (id_copy == IntPtr.Zero)
				id_copy = JNIEnv.GetMethodID (class_ref, "copy", "()Lbe/abeel/util/FrequencyMap;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::BE.Abeel.Util.FrequencyMap> (JNIEnv.CallObjectMethod  (Handle, id_copy), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::BE.Abeel.Util.FrequencyMap> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "copy", "()Lbe/abeel/util/FrequencyMap;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_count_I;
#pragma warning disable 0169
		static Delegate GetCount_IHandler ()
		{
			if (cb_count_I == null)
				cb_count_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_Count_I);
			return cb_count_I;
		}

		static void n_Count_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::BE.Abeel.Util.FrequencyMap __this = global::Java.Lang.Object.GetObject<global::BE.Abeel.Util.FrequencyMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Count (p0);
		}
#pragma warning restore 0169

		static IntPtr id_count_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.util']/class[@name='FrequencyMap']/method[@name='count' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("count", "(I)V", "GetCount_IHandler")]
		public virtual unsafe void Count (int p0)
		{
			if (id_count_I == IntPtr.Zero)
				id_count_I = JNIEnv.GetMethodID (class_ref, "count", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_count_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "count", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_count_II;
#pragma warning disable 0169
		static Delegate GetCount_IIHandler ()
		{
			if (cb_count_II == null)
				cb_count_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_Count_II);
			return cb_count_II;
		}

		static void n_Count_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::BE.Abeel.Util.FrequencyMap __this = global::Java.Lang.Object.GetObject<global::BE.Abeel.Util.FrequencyMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Count (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_count_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.util']/class[@name='FrequencyMap']/method[@name='count' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("count", "(II)V", "GetCount_IIHandler")]
		public virtual unsafe void Count (int p0, int p1)
		{
			if (id_count_II == IntPtr.Zero)
				id_count_II = JNIEnv.GetMethodID (class_ref, "count", "(II)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_count_II, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "count", "(II)V"), __args);
			} finally {
			}
		}

		static Delegate cb_max;
#pragma warning disable 0169
		static Delegate GetMaxHandler ()
		{
			if (cb_max == null)
				cb_max = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Max);
			return cb_max;
		}

		static int n_Max (IntPtr jnienv, IntPtr native__this)
		{
			global::BE.Abeel.Util.FrequencyMap __this = global::Java.Lang.Object.GetObject<global::BE.Abeel.Util.FrequencyMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Max ();
		}
#pragma warning restore 0169

		static IntPtr id_max;
		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.util']/class[@name='FrequencyMap']/method[@name='max' and count(parameter)=0]"
		[Register ("max", "()I", "GetMaxHandler")]
		public virtual unsafe int Max ()
		{
			if (id_max == IntPtr.Zero)
				id_max = JNIEnv.GetMethodID (class_ref, "max", "()I");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_max);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "max", "()I"));
			} finally {
			}
		}

		static Delegate cb_median;
#pragma warning disable 0169
		static Delegate GetMedianHandler ()
		{
			if (cb_median == null)
				cb_median = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Median);
			return cb_median;
		}

		static int n_Median (IntPtr jnienv, IntPtr native__this)
		{
			global::BE.Abeel.Util.FrequencyMap __this = global::Java.Lang.Object.GetObject<global::BE.Abeel.Util.FrequencyMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Median ();
		}
#pragma warning restore 0169

		static IntPtr id_median;
		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.util']/class[@name='FrequencyMap']/method[@name='median' and count(parameter)=0]"
		[Register ("median", "()I", "GetMedianHandler")]
		public virtual unsafe int Median ()
		{
			if (id_median == IntPtr.Zero)
				id_median = JNIEnv.GetMethodID (class_ref, "median", "()I");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_median);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "median", "()I"));
			} finally {
			}
		}

		static Delegate cb_min;
#pragma warning disable 0169
		static Delegate GetMinHandler ()
		{
			if (cb_min == null)
				cb_min = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Min);
			return cb_min;
		}

		static int n_Min (IntPtr jnienv, IntPtr native__this)
		{
			global::BE.Abeel.Util.FrequencyMap __this = global::Java.Lang.Object.GetObject<global::BE.Abeel.Util.FrequencyMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Min ();
		}
#pragma warning restore 0169

		static IntPtr id_min;
		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.util']/class[@name='FrequencyMap']/method[@name='min' and count(parameter)=0]"
		[Register ("min", "()I", "GetMinHandler")]
		public virtual unsafe int Min ()
		{
			if (id_min == IntPtr.Zero)
				id_min = JNIEnv.GetMethodID (class_ref, "min", "()I");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_min);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "min", "()I"));
			} finally {
			}
		}

		static Delegate cb_mode;
#pragma warning disable 0169
		static Delegate GetModeHandler ()
		{
			if (cb_mode == null)
				cb_mode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Mode);
			return cb_mode;
		}

		static int n_Mode (IntPtr jnienv, IntPtr native__this)
		{
			global::BE.Abeel.Util.FrequencyMap __this = global::Java.Lang.Object.GetObject<global::BE.Abeel.Util.FrequencyMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Mode ();
		}
#pragma warning restore 0169

		static IntPtr id_mode;
		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.util']/class[@name='FrequencyMap']/method[@name='mode' and count(parameter)=0]"
		[Register ("mode", "()I", "GetModeHandler")]
		public virtual unsafe int Mode ()
		{
			if (id_mode == IntPtr.Zero)
				id_mode = JNIEnv.GetMethodID (class_ref, "mode", "()I");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_mode);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "mode", "()I"));
			} finally {
			}
		}

		static Delegate cb_removeAbove_I;
#pragma warning disable 0169
		static Delegate GetRemoveAbove_IHandler ()
		{
			if (cb_removeAbove_I == null)
				cb_removeAbove_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_RemoveAbove_I);
			return cb_removeAbove_I;
		}

		static IntPtr n_RemoveAbove_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::BE.Abeel.Util.FrequencyMap __this = global::Java.Lang.Object.GetObject<global::BE.Abeel.Util.FrequencyMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RemoveAbove (p0));
		}
#pragma warning restore 0169

		static IntPtr id_removeAbove_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.util']/class[@name='FrequencyMap']/method[@name='removeAbove' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("removeAbove", "(I)Lbe/abeel/util/FrequencyMap;", "GetRemoveAbove_IHandler")]
		public virtual unsafe global::BE.Abeel.Util.FrequencyMap RemoveAbove (int p0)
		{
			if (id_removeAbove_I == IntPtr.Zero)
				id_removeAbove_I = JNIEnv.GetMethodID (class_ref, "removeAbove", "(I)Lbe/abeel/util/FrequencyMap;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::BE.Abeel.Util.FrequencyMap> (JNIEnv.CallObjectMethod  (Handle, id_removeAbove_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::BE.Abeel.Util.FrequencyMap> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeAbove", "(I)Lbe/abeel/util/FrequencyMap;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_removeBelow_I;
#pragma warning disable 0169
		static Delegate GetRemoveBelow_IHandler ()
		{
			if (cb_removeBelow_I == null)
				cb_removeBelow_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_RemoveBelow_I);
			return cb_removeBelow_I;
		}

		static IntPtr n_RemoveBelow_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::BE.Abeel.Util.FrequencyMap __this = global::Java.Lang.Object.GetObject<global::BE.Abeel.Util.FrequencyMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RemoveBelow (p0));
		}
#pragma warning restore 0169

		static IntPtr id_removeBelow_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.util']/class[@name='FrequencyMap']/method[@name='removeBelow' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("removeBelow", "(I)Lbe/abeel/util/FrequencyMap;", "GetRemoveBelow_IHandler")]
		public virtual unsafe global::BE.Abeel.Util.FrequencyMap RemoveBelow (int p0)
		{
			if (id_removeBelow_I == IntPtr.Zero)
				id_removeBelow_I = JNIEnv.GetMethodID (class_ref, "removeBelow", "(I)Lbe/abeel/util/FrequencyMap;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::BE.Abeel.Util.FrequencyMap> (JNIEnv.CallObjectMethod  (Handle, id_removeBelow_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::BE.Abeel.Util.FrequencyMap> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeBelow", "(I)Lbe/abeel/util/FrequencyMap;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_shift_I;
#pragma warning disable 0169
		static Delegate GetShift_IHandler ()
		{
			if (cb_shift_I == null)
				cb_shift_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_Shift_I);
			return cb_shift_I;
		}

		static IntPtr n_Shift_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::BE.Abeel.Util.FrequencyMap __this = global::Java.Lang.Object.GetObject<global::BE.Abeel.Util.FrequencyMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Shift (p0));
		}
#pragma warning restore 0169

		static IntPtr id_shift_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.util']/class[@name='FrequencyMap']/method[@name='shift' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("shift", "(I)Lbe/abeel/util/FrequencyMap;", "GetShift_IHandler")]
		public virtual unsafe global::BE.Abeel.Util.FrequencyMap Shift (int p0)
		{
			if (id_shift_I == IntPtr.Zero)
				id_shift_I = JNIEnv.GetMethodID (class_ref, "shift", "(I)Lbe/abeel/util/FrequencyMap;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::BE.Abeel.Util.FrequencyMap> (JNIEnv.CallObjectMethod  (Handle, id_shift_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::BE.Abeel.Util.FrequencyMap> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "shift", "(I)Lbe/abeel/util/FrequencyMap;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_std;
#pragma warning disable 0169
		static Delegate GetStdHandler ()
		{
			if (cb_std == null)
				cb_std = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_Std);
			return cb_std;
		}

		static double n_Std (IntPtr jnienv, IntPtr native__this)
		{
			global::BE.Abeel.Util.FrequencyMap __this = global::Java.Lang.Object.GetObject<global::BE.Abeel.Util.FrequencyMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Std ();
		}
#pragma warning restore 0169

		static IntPtr id_std;
		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.util']/class[@name='FrequencyMap']/method[@name='std' and count(parameter)=0]"
		[Register ("std", "()D", "GetStdHandler")]
		public virtual unsafe double Std ()
		{
			if (id_std == IntPtr.Zero)
				id_std = JNIEnv.GetMethodID (class_ref, "std", "()D");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallDoubleMethod  (Handle, id_std);
				else
					return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "std", "()D"));
			} finally {
			}
		}

		static Delegate cb_sum;
#pragma warning disable 0169
		static Delegate GetSumHandler ()
		{
			if (cb_sum == null)
				cb_sum = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_Sum);
			return cb_sum;
		}

		static double n_Sum (IntPtr jnienv, IntPtr native__this)
		{
			global::BE.Abeel.Util.FrequencyMap __this = global::Java.Lang.Object.GetObject<global::BE.Abeel.Util.FrequencyMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Sum ();
		}
#pragma warning restore 0169

		static IntPtr id_sum;
		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.util']/class[@name='FrequencyMap']/method[@name='sum' and count(parameter)=0]"
		[Register ("sum", "()D", "GetSumHandler")]
		public virtual unsafe double Sum ()
		{
			if (id_sum == IntPtr.Zero)
				id_sum = JNIEnv.GetMethodID (class_ref, "sum", "()D");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallDoubleMethod  (Handle, id_sum);
				else
					return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sum", "()D"));
			} finally {
			}
		}

		static Delegate cb_totalCount;
#pragma warning disable 0169
		static Delegate GetTotalCountHandler ()
		{
			if (cb_totalCount == null)
				cb_totalCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_TotalCount);
			return cb_totalCount;
		}

		static int n_TotalCount (IntPtr jnienv, IntPtr native__this)
		{
			global::BE.Abeel.Util.FrequencyMap __this = global::Java.Lang.Object.GetObject<global::BE.Abeel.Util.FrequencyMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TotalCount ();
		}
#pragma warning restore 0169

		static IntPtr id_totalCount;
		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.util']/class[@name='FrequencyMap']/method[@name='totalCount' and count(parameter)=0]"
		[Register ("totalCount", "()I", "GetTotalCountHandler")]
		public virtual unsafe int TotalCount ()
		{
			if (id_totalCount == IntPtr.Zero)
				id_totalCount = JNIEnv.GetMethodID (class_ref, "totalCount", "()I");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_totalCount);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "totalCount", "()I"));
			} finally {
			}
		}

		static Delegate cb_truncate_II;
#pragma warning disable 0169
		static Delegate GetTruncate_IIHandler ()
		{
			if (cb_truncate_II == null)
				cb_truncate_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr>) n_Truncate_II);
			return cb_truncate_II;
		}

		static IntPtr n_Truncate_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::BE.Abeel.Util.FrequencyMap __this = global::Java.Lang.Object.GetObject<global::BE.Abeel.Util.FrequencyMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Truncate (p0, p1));
		}
#pragma warning restore 0169

		static IntPtr id_truncate_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.util']/class[@name='FrequencyMap']/method[@name='truncate' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("truncate", "(II)Lbe/abeel/util/FrequencyMap;", "GetTruncate_IIHandler")]
		public virtual unsafe global::BE.Abeel.Util.FrequencyMap Truncate (int p0, int p1)
		{
			if (id_truncate_II == IntPtr.Zero)
				id_truncate_II = JNIEnv.GetMethodID (class_ref, "truncate", "(II)Lbe/abeel/util/FrequencyMap;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::BE.Abeel.Util.FrequencyMap> (JNIEnv.CallObjectMethod  (Handle, id_truncate_II, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::BE.Abeel.Util.FrequencyMap> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "truncate", "(II)Lbe/abeel/util/FrequencyMap;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
