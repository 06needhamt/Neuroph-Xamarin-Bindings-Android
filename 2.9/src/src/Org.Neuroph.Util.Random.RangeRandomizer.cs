using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Util.Random {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.util.random']/class[@name='RangeRandomizer']"
	[global::Android.Runtime.Register ("org/neuroph/util/random/RangeRandomizer", DoNotGenerateAcw=true)]
	public partial class RangeRandomizer : global::Org.Neuroph.Util.Random.WeightsRandomizer {


		static IntPtr max_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.neuroph.util.random']/class[@name='RangeRandomizer']/field[@name='max']"
		[Register ("max")]
		protected double Max {
			get {
				if (max_jfieldId == IntPtr.Zero)
					max_jfieldId = JNIEnv.GetFieldID (class_ref, "max", "D");
				return JNIEnv.GetDoubleField (((global::Java.Lang.Object) this).Handle, max_jfieldId);
			}
			set {
				if (max_jfieldId == IntPtr.Zero)
					max_jfieldId = JNIEnv.GetFieldID (class_ref, "max", "D");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, max_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr min_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.neuroph.util.random']/class[@name='RangeRandomizer']/field[@name='min']"
		[Register ("min")]
		protected double Min {
			get {
				if (min_jfieldId == IntPtr.Zero)
					min_jfieldId = JNIEnv.GetFieldID (class_ref, "min", "D");
				return JNIEnv.GetDoubleField (((global::Java.Lang.Object) this).Handle, min_jfieldId);
			}
			set {
				if (min_jfieldId == IntPtr.Zero)
					min_jfieldId = JNIEnv.GetFieldID (class_ref, "min", "D");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, min_jfieldId, value);
				} finally {
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/util/random/RangeRandomizer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RangeRandomizer); }
		}

		protected RangeRandomizer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_DD;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.util.random']/class[@name='RangeRandomizer']/constructor[@name='RangeRandomizer' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='double']]"
		[Register (".ctor", "(DD)V", "")]
		public unsafe RangeRandomizer (double p0, double p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (RangeRandomizer)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(DD)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(DD)V", __args);
					return;
				}

				if (id_ctor_DD == IntPtr.Zero)
					id_ctor_DD = JNIEnv.GetMethodID (class_ref, "<init>", "(DD)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_DD, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_DD, __args);
			} finally {
			}
		}

	}
}
