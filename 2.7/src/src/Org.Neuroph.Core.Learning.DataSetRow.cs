using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Core.Learning {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='DataSetRow']"
	[global::Android.Runtime.Register ("org/neuroph/core/learning/DataSetRow", DoNotGenerateAcw=true)]
	public partial class DataSetRow : global::Java.Lang.Object, global::Java.IO.ISerializable {


		static IntPtr input_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='DataSetRow']/field[@name='input']"
		[Register ("input")]
		protected IList<double> Input {
			get {
				if (input_jfieldId == IntPtr.Zero)
					input_jfieldId = JNIEnv.GetFieldID (class_ref, "input", "[D");
				return JavaArray<double>.FromJniHandle (JNIEnv.GetObjectField (Handle, input_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (input_jfieldId == IntPtr.Zero)
					input_jfieldId = JNIEnv.GetFieldID (class_ref, "input", "[D");
				IntPtr native_value = JavaArray<double>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, input_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/core/learning/DataSetRow", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DataSetRow); }
		}

		protected DataSetRow (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='DataSetRow']/constructor[@name='DataSetRow' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe DataSetRow (string p0, string p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				if (GetType () != typeof (DataSetRow)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_ctor_arrayDarrayD;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='DataSetRow']/constructor[@name='DataSetRow' and count(parameter)=2 and parameter[1][@type='double[]'] and parameter[2][@type='double[]']]"
		[Register (".ctor", "([D[D)V", "")]
		public unsafe DataSetRow (double[] p0, double[] p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				if (GetType () != typeof (DataSetRow)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "([D[D)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "([D[D)V", __args);
					return;
				}

				if (id_ctor_arrayDarrayD == IntPtr.Zero)
					id_ctor_arrayDarrayD = JNIEnv.GetMethodID (class_ref, "<init>", "([D[D)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayDarrayD, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_arrayDarrayD, __args);
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

		static IntPtr id_ctor_arrayD;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='DataSetRow']/constructor[@name='DataSetRow' and count(parameter)=1 and parameter[1][@type='double...']]"
		[Register (".ctor", "([D)V", "")]
		public unsafe DataSetRow (params  double[] p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (DataSetRow)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "([D)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "([D)V", __args);
					return;
				}

				if (id_ctor_arrayD == IntPtr.Zero)
					id_ctor_arrayD = JNIEnv.GetMethodID (class_ref, "<init>", "([D)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayD, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_arrayD, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_ctor_Ljava_util_ArrayList_Ljava_util_ArrayList_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='DataSetRow']/constructor[@name='DataSetRow' and count(parameter)=2 and parameter[1][@type='java.util.ArrayList&lt;java.lang.Double&gt;'] and parameter[2][@type='java.util.ArrayList&lt;java.lang.Double&gt;']]"
		[Register (".ctor", "(Ljava/util/ArrayList;Ljava/util/ArrayList;)V", "")]
		public unsafe DataSetRow (global::System.Collections.Generic.IList<global::Java.Lang.Double> p0, global::System.Collections.Generic.IList<global::Java.Lang.Double> p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Java.Lang.Double>.ToLocalJniHandle (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::Java.Lang.Double>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				if (GetType () != typeof (DataSetRow)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/util/ArrayList;Ljava/util/ArrayList;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/util/ArrayList;Ljava/util/ArrayList;)V", __args);
					return;
				}

				if (id_ctor_Ljava_util_ArrayList_Ljava_util_ArrayList_ == IntPtr.Zero)
					id_ctor_Ljava_util_ArrayList_Ljava_util_ArrayList_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/util/ArrayList;Ljava/util/ArrayList;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_util_ArrayList_Ljava_util_ArrayList_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_util_ArrayList_Ljava_util_ArrayList_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_ctor_Ljava_util_ArrayList_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='DataSetRow']/constructor[@name='DataSetRow' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList&lt;java.lang.Double&gt;']]"
		[Register (".ctor", "(Ljava/util/ArrayList;)V", "")]
		public unsafe DataSetRow (global::System.Collections.Generic.IList<global::Java.Lang.Double> p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Java.Lang.Double>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (DataSetRow)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/util/ArrayList;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/util/ArrayList;)V", __args);
					return;
				}

				if (id_ctor_Ljava_util_ArrayList_ == IntPtr.Zero)
					id_ctor_Ljava_util_ArrayList_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/util/ArrayList;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_util_ArrayList_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_util_ArrayList_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_isSupervised;
#pragma warning disable 0169
		static Delegate GetIsSupervisedHandler ()
		{
			if (cb_isSupervised == null)
				cb_isSupervised = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsSupervised);
			return cb_isSupervised;
		}

		static bool n_IsSupervised (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Core.Learning.DataSetRow __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.DataSetRow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSupervised;
		}
#pragma warning restore 0169

		static IntPtr id_isSupervised;
		public virtual unsafe bool IsSupervised {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='DataSetRow']/method[@name='isSupervised' and count(parameter)=0]"
			[Register ("isSupervised", "()Z", "GetIsSupervisedHandler")]
			get {
				if (id_isSupervised == IntPtr.Zero)
					id_isSupervised = JNIEnv.GetMethodID (class_ref, "isSupervised", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isSupervised);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isSupervised", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getLabel;
#pragma warning disable 0169
		static Delegate GetGetLabelHandler ()
		{
			if (cb_getLabel == null)
				cb_getLabel = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLabel);
			return cb_getLabel;
		}

		static IntPtr n_GetLabel (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Core.Learning.DataSetRow __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.DataSetRow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Label);
		}
#pragma warning restore 0169

		static Delegate cb_setLabel_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetLabel_Ljava_lang_String_Handler ()
		{
			if (cb_setLabel_Ljava_lang_String_ == null)
				cb_setLabel_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLabel_Ljava_lang_String_);
			return cb_setLabel_Ljava_lang_String_;
		}

		static void n_SetLabel_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Core.Learning.DataSetRow __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.DataSetRow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Label = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getLabel;
		static IntPtr id_setLabel_Ljava_lang_String_;
		public virtual unsafe string Label {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='DataSetRow']/method[@name='getLabel' and count(parameter)=0]"
			[Register ("getLabel", "()Ljava/lang/String;", "GetGetLabelHandler")]
			get {
				if (id_getLabel == IntPtr.Zero)
					id_getLabel = JNIEnv.GetMethodID (class_ref, "getLabel", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getLabel), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLabel", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='DataSetRow']/method[@name='setLabel' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setLabel", "(Ljava/lang/String;)V", "GetSetLabel_Ljava_lang_String_Handler")]
			set {
				if (id_setLabel_Ljava_lang_String_ == IntPtr.Zero)
					id_setLabel_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setLabel", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setLabel_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLabel", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getDesiredOutput;
#pragma warning disable 0169
		static Delegate GetGetDesiredOutputHandler ()
		{
			if (cb_getDesiredOutput == null)
				cb_getDesiredOutput = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDesiredOutput);
			return cb_getDesiredOutput;
		}

		static IntPtr n_GetDesiredOutput (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Core.Learning.DataSetRow __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.DataSetRow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetDesiredOutput ());
		}
#pragma warning restore 0169

		static IntPtr id_getDesiredOutput;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='DataSetRow']/method[@name='getDesiredOutput' and count(parameter)=0]"
		[Register ("getDesiredOutput", "()[D", "GetGetDesiredOutputHandler")]
		public virtual unsafe double[] GetDesiredOutput ()
		{
			if (id_getDesiredOutput == IntPtr.Zero)
				id_getDesiredOutput = JNIEnv.GetMethodID (class_ref, "getDesiredOutput", "()[D");
			try {

				if (GetType () == ThresholdType)
					return (double[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getDesiredOutput), JniHandleOwnership.TransferLocalRef, typeof (double));
				else
					return (double[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDesiredOutput", "()[D")), JniHandleOwnership.TransferLocalRef, typeof (double));
			} finally {
			}
		}

		static Delegate cb_getInput;
#pragma warning disable 0169
		static Delegate GetGetInputHandler ()
		{
			if (cb_getInput == null)
				cb_getInput = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetInput);
			return cb_getInput;
		}

		static IntPtr n_GetInput (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Core.Learning.DataSetRow __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.DataSetRow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetInput ());
		}
#pragma warning restore 0169

		static IntPtr id_getInput;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='DataSetRow']/method[@name='getInput' and count(parameter)=0]"
		[Register ("getInput", "()[D", "GetGetInputHandler")]
		public virtual unsafe double[] GetInput ()
		{
			if (id_getInput == IntPtr.Zero)
				id_getInput = JNIEnv.GetMethodID (class_ref, "getInput", "()[D");
			try {

				if (GetType () == ThresholdType)
					return (double[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getInput), JniHandleOwnership.TransferLocalRef, typeof (double));
				else
					return (double[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getInput", "()[D")), JniHandleOwnership.TransferLocalRef, typeof (double));
			} finally {
			}
		}

		static Delegate cb_setDesiredOutput_arrayD;
#pragma warning disable 0169
		static Delegate GetSetDesiredOutput_arrayDHandler ()
		{
			if (cb_setDesiredOutput_arrayD == null)
				cb_setDesiredOutput_arrayD = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDesiredOutput_arrayD);
			return cb_setDesiredOutput_arrayD;
		}

		static void n_SetDesiredOutput_arrayD (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Core.Learning.DataSetRow __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.DataSetRow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			double[] p0 = (double[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (double));
			__this.SetDesiredOutput (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_setDesiredOutput_arrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='DataSetRow']/method[@name='setDesiredOutput' and count(parameter)=1 and parameter[1][@type='double[]']]"
		[Register ("setDesiredOutput", "([D)V", "GetSetDesiredOutput_arrayDHandler")]
		public virtual unsafe void SetDesiredOutput (double[] p0)
		{
			if (id_setDesiredOutput_arrayD == IntPtr.Zero)
				id_setDesiredOutput_arrayD = JNIEnv.GetMethodID (class_ref, "setDesiredOutput", "([D)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setDesiredOutput_arrayD, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDesiredOutput", "([D)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_setInput_arrayD;
#pragma warning disable 0169
		static Delegate GetSetInput_arrayDHandler ()
		{
			if (cb_setInput_arrayD == null)
				cb_setInput_arrayD = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetInput_arrayD);
			return cb_setInput_arrayD;
		}

		static void n_SetInput_arrayD (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Core.Learning.DataSetRow __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.DataSetRow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			double[] p0 = (double[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (double));
			__this.SetInput (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_setInput_arrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='DataSetRow']/method[@name='setInput' and count(parameter)=1 and parameter[1][@type='double[]']]"
		[Register ("setInput", "([D)V", "GetSetInput_arrayDHandler")]
		public virtual unsafe void SetInput (double[] p0)
		{
			if (id_setInput_arrayD == IntPtr.Zero)
				id_setInput_arrayD = JNIEnv.GetMethodID (class_ref, "setInput", "([D)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setInput_arrayD, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setInput", "([D)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

	}
}
