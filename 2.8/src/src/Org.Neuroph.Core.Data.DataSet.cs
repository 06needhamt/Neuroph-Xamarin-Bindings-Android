using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Core.Data {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.core.data']/class[@name='DataSet']"
	[global::Android.Runtime.Register ("org/neuroph/core/data/DataSet", DoNotGenerateAcw=true)]
	public partial class DataSet : global::Java.Lang.Object, global::Java.IO.ISerializable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/core/data/DataSet", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DataSet); }
		}

		protected DataSet (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.core.data']/class[@name='DataSet']/constructor[@name='DataSet' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe DataSet (int p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (DataSet)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(I)V", __args);
					return;
				}

				if (id_ctor_I == IntPtr.Zero)
					id_ctor_I = JNIEnv.GetMethodID (class_ref, "<init>", "(I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_I, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_II;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.core.data']/class[@name='DataSet']/constructor[@name='DataSet' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register (".ctor", "(II)V", "")]
		public unsafe DataSet (int p0, int p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (DataSet)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(II)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(II)V", __args);
					return;
				}

				if (id_ctor_II == IntPtr.Zero)
					id_ctor_II = JNIEnv.GetMethodID (class_ref, "<init>", "(II)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_II, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_II, __args);
			} finally {
			}
		}

		static Delegate cb_getFilePath;
#pragma warning disable 0169
		static Delegate GetGetFilePathHandler ()
		{
			if (cb_getFilePath == null)
				cb_getFilePath = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFilePath);
			return cb_getFilePath;
		}

		static IntPtr n_GetFilePath (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Core.Data.DataSet __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Data.DataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.FilePath);
		}
#pragma warning restore 0169

		static Delegate cb_setFilePath_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetFilePath_Ljava_lang_String_Handler ()
		{
			if (cb_setFilePath_Ljava_lang_String_ == null)
				cb_setFilePath_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetFilePath_Ljava_lang_String_);
			return cb_setFilePath_Ljava_lang_String_;
		}

		static void n_SetFilePath_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Core.Data.DataSet __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Data.DataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.FilePath = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getFilePath;
		static IntPtr id_setFilePath_Ljava_lang_String_;
		public virtual unsafe string FilePath {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.data']/class[@name='DataSet']/method[@name='getFilePath' and count(parameter)=0]"
			[Register ("getFilePath", "()Ljava/lang/String;", "GetGetFilePathHandler")]
			get {
				if (id_getFilePath == IntPtr.Zero)
					id_getFilePath = JNIEnv.GetMethodID (class_ref, "getFilePath", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFilePath), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFilePath", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.data']/class[@name='DataSet']/method[@name='setFilePath' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setFilePath", "(Ljava/lang/String;)V", "GetSetFilePath_Ljava_lang_String_Handler")]
			set {
				if (id_setFilePath_Ljava_lang_String_ == IntPtr.Zero)
					id_setFilePath_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setFilePath", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setFilePath_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFilePath", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getInputSize;
#pragma warning disable 0169
		static Delegate GetGetInputSizeHandler ()
		{
			if (cb_getInputSize == null)
				cb_getInputSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetInputSize);
			return cb_getInputSize;
		}

		static int n_GetInputSize (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Core.Data.DataSet __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Data.DataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.InputSize;
		}
#pragma warning restore 0169

		static IntPtr id_getInputSize;
		public virtual unsafe int InputSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.data']/class[@name='DataSet']/method[@name='getInputSize' and count(parameter)=0]"
			[Register ("getInputSize", "()I", "GetGetInputSizeHandler")]
			get {
				if (id_getInputSize == IntPtr.Zero)
					id_getInputSize = JNIEnv.GetMethodID (class_ref, "getInputSize", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getInputSize);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getInputSize", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_isEmpty;
#pragma warning disable 0169
		static Delegate GetIsEmptyHandler ()
		{
			if (cb_isEmpty == null)
				cb_isEmpty = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsEmpty);
			return cb_isEmpty;
		}

		static bool n_IsEmpty (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Core.Data.DataSet __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Data.DataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsEmpty;
		}
#pragma warning restore 0169

		static IntPtr id_isEmpty;
		public virtual unsafe bool IsEmpty {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.data']/class[@name='DataSet']/method[@name='isEmpty' and count(parameter)=0]"
			[Register ("isEmpty", "()Z", "GetIsEmptyHandler")]
			get {
				if (id_isEmpty == IntPtr.Zero)
					id_isEmpty = JNIEnv.GetMethodID (class_ref, "isEmpty", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isEmpty);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isEmpty", "()Z"));
				} finally {
				}
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
			global::Org.Neuroph.Core.Data.DataSet __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Data.DataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSupervised;
		}
#pragma warning restore 0169

		static IntPtr id_isSupervised;
		public virtual unsafe bool IsSupervised {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.data']/class[@name='DataSet']/method[@name='isSupervised' and count(parameter)=0]"
			[Register ("isSupervised", "()Z", "GetIsSupervisedHandler")]
			get {
				if (id_isSupervised == IntPtr.Zero)
					id_isSupervised = JNIEnv.GetMethodID (class_ref, "isSupervised", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isSupervised);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isSupervised", "()Z"));
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
			global::Org.Neuroph.Core.Data.DataSet __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Data.DataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Org.Neuroph.Core.Data.DataSet __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Data.DataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Label = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getLabel;
		static IntPtr id_setLabel_Ljava_lang_String_;
		public virtual unsafe string Label {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.data']/class[@name='DataSet']/method[@name='getLabel' and count(parameter)=0]"
			[Register ("getLabel", "()Ljava/lang/String;", "GetGetLabelHandler")]
			get {
				if (id_getLabel == IntPtr.Zero)
					id_getLabel = JNIEnv.GetMethodID (class_ref, "getLabel", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLabel), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLabel", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.data']/class[@name='DataSet']/method[@name='setLabel' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setLabel", "(Ljava/lang/String;)V", "GetSetLabel_Ljava_lang_String_Handler")]
			set {
				if (id_setLabel_Ljava_lang_String_ == IntPtr.Zero)
					id_setLabel_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setLabel", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLabel_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLabel", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getOutputSize;
#pragma warning disable 0169
		static Delegate GetGetOutputSizeHandler ()
		{
			if (cb_getOutputSize == null)
				cb_getOutputSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetOutputSize);
			return cb_getOutputSize;
		}

		static int n_GetOutputSize (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Core.Data.DataSet __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Data.DataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.OutputSize;
		}
#pragma warning restore 0169

		static IntPtr id_getOutputSize;
		public virtual unsafe int OutputSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.data']/class[@name='DataSet']/method[@name='getOutputSize' and count(parameter)=0]"
			[Register ("getOutputSize", "()I", "GetGetOutputSizeHandler")]
			get {
				if (id_getOutputSize == IntPtr.Zero)
					id_getOutputSize = JNIEnv.GetMethodID (class_ref, "getOutputSize", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getOutputSize);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOutputSize", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getRows;
#pragma warning disable 0169
		static Delegate GetGetRowsHandler ()
		{
			if (cb_getRows == null)
				cb_getRows = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRows);
			return cb_getRows;
		}

		static IntPtr n_GetRows (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Core.Data.DataSet __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Data.DataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Org.Neuroph.Core.Data.DataSetRow>.ToLocalJniHandle (__this.Rows);
		}
#pragma warning restore 0169

		static IntPtr id_getRows;
		public virtual unsafe global::System.Collections.Generic.IList<global::Org.Neuroph.Core.Data.DataSetRow> Rows {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.data']/class[@name='DataSet']/method[@name='getRows' and count(parameter)=0]"
			[Register ("getRows", "()Ljava/util/List;", "GetGetRowsHandler")]
			get {
				if (id_getRows == IntPtr.Zero)
					id_getRows = JNIEnv.GetMethodID (class_ref, "getRows", "()Ljava/util/List;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Org.Neuroph.Core.Data.DataSetRow>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRows), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Org.Neuroph.Core.Data.DataSetRow>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRows", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_addRow_arrayD;
#pragma warning disable 0169
		static Delegate GetAddRow_arrayDHandler ()
		{
			if (cb_addRow_arrayD == null)
				cb_addRow_arrayD = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddRow_arrayD);
			return cb_addRow_arrayD;
		}

		static void n_AddRow_arrayD (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Core.Data.DataSet __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Data.DataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			double[] p0 = (double[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (double));
			__this.AddRow (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_addRow_arrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.data']/class[@name='DataSet']/method[@name='addRow' and count(parameter)=1 and parameter[1][@type='double[]']]"
		[Register ("addRow", "([D)V", "GetAddRow_arrayDHandler")]
		public virtual unsafe void AddRow (double[] p0)
		{
			if (id_addRow_arrayD == IntPtr.Zero)
				id_addRow_arrayD = JNIEnv.GetMethodID (class_ref, "addRow", "([D)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addRow_arrayD, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addRow", "([D)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_addRow_arrayDarrayD;
#pragma warning disable 0169
		static Delegate GetAddRow_arrayDarrayDHandler ()
		{
			if (cb_addRow_arrayDarrayD == null)
				cb_addRow_arrayDarrayD = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddRow_arrayDarrayD);
			return cb_addRow_arrayDarrayD;
		}

		static void n_AddRow_arrayDarrayD (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Neuroph.Core.Data.DataSet __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Data.DataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			double[] p0 = (double[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (double));
			double[] p1 = (double[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (double));
			__this.AddRow (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		static IntPtr id_addRow_arrayDarrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.data']/class[@name='DataSet']/method[@name='addRow' and count(parameter)=2 and parameter[1][@type='double[]'] and parameter[2][@type='double[]']]"
		[Register ("addRow", "([D[D)V", "GetAddRow_arrayDarrayDHandler")]
		public virtual unsafe void AddRow (double[] p0, double[] p1)
		{
			if (id_addRow_arrayDarrayD == IntPtr.Zero)
				id_addRow_arrayDarrayD = JNIEnv.GetMethodID (class_ref, "addRow", "([D[D)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addRow_arrayDarrayD, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addRow", "([D[D)V"), __args);
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

		static Delegate cb_addRow_Lorg_neuroph_core_data_DataSetRow_;
#pragma warning disable 0169
		static Delegate GetAddRow_Lorg_neuroph_core_data_DataSetRow_Handler ()
		{
			if (cb_addRow_Lorg_neuroph_core_data_DataSetRow_ == null)
				cb_addRow_Lorg_neuroph_core_data_DataSetRow_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddRow_Lorg_neuroph_core_data_DataSetRow_);
			return cb_addRow_Lorg_neuroph_core_data_DataSetRow_;
		}

		static void n_AddRow_Lorg_neuroph_core_data_DataSetRow_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Core.Data.DataSet __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Data.DataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Core.Data.DataSetRow p0 = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Data.DataSetRow> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddRow (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addRow_Lorg_neuroph_core_data_DataSetRow_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.data']/class[@name='DataSet']/method[@name='addRow' and count(parameter)=1 and parameter[1][@type='org.neuroph.core.data.DataSetRow']]"
		[Register ("addRow", "(Lorg/neuroph/core/data/DataSetRow;)V", "GetAddRow_Lorg_neuroph_core_data_DataSetRow_Handler")]
		public virtual unsafe void AddRow (global::Org.Neuroph.Core.Data.DataSetRow p0)
		{
			if (id_addRow_Lorg_neuroph_core_data_DataSetRow_ == IntPtr.Zero)
				id_addRow_Lorg_neuroph_core_data_DataSetRow_ = JNIEnv.GetMethodID (class_ref, "addRow", "(Lorg/neuroph/core/data/DataSetRow;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addRow_Lorg_neuroph_core_data_DataSetRow_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addRow", "(Lorg/neuroph/core/data/DataSetRow;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_clear;
#pragma warning disable 0169
		static Delegate GetClearHandler ()
		{
			if (cb_clear == null)
				cb_clear = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Clear);
			return cb_clear;
		}

		static void n_Clear (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Core.Data.DataSet __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Data.DataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		static IntPtr id_clear;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.data']/class[@name='DataSet']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "GetClearHandler")]
		public virtual unsafe void Clear ()
		{
			if (id_clear == IntPtr.Zero)
				id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clear);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clear", "()V"));
			} finally {
			}
		}

		static IntPtr id_createFromFile_Ljava_lang_String_IILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.data']/class[@name='DataSet']/method[@name='createFromFile' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String']]"
		[Register ("createFromFile", "(Ljava/lang/String;IILjava/lang/String;)Lorg/neuroph/core/data/DataSet;", "")]
		public static unsafe global::Org.Neuroph.Core.Data.DataSet CreateFromFile (string p0, int p1, int p2, string p3)
		{
			if (id_createFromFile_Ljava_lang_String_IILjava_lang_String_ == IntPtr.Zero)
				id_createFromFile_Ljava_lang_String_IILjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "createFromFile", "(Ljava/lang/String;IILjava/lang/String;)Lorg/neuroph/core/data/DataSet;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				global::Org.Neuroph.Core.Data.DataSet __ret = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Data.DataSet> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createFromFile_Ljava_lang_String_IILjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_createTrainingAndTestSubsets_II;
#pragma warning disable 0169
		static Delegate GetCreateTrainingAndTestSubsets_IIHandler ()
		{
			if (cb_createTrainingAndTestSubsets_II == null)
				cb_createTrainingAndTestSubsets_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr>) n_CreateTrainingAndTestSubsets_II);
			return cb_createTrainingAndTestSubsets_II;
		}

		static IntPtr n_CreateTrainingAndTestSubsets_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Org.Neuroph.Core.Data.DataSet __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Data.DataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.CreateTrainingAndTestSubsets (p0, p1));
		}
#pragma warning restore 0169

		static IntPtr id_createTrainingAndTestSubsets_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.data']/class[@name='DataSet']/method[@name='createTrainingAndTestSubsets' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("createTrainingAndTestSubsets", "(II)[Lorg/neuroph/core/data/DataSet;", "GetCreateTrainingAndTestSubsets_IIHandler")]
		public virtual unsafe global::Org.Neuroph.Core.Data.DataSet[] CreateTrainingAndTestSubsets (int p0, int p1)
		{
			if (id_createTrainingAndTestSubsets_II == IntPtr.Zero)
				id_createTrainingAndTestSubsets_II = JNIEnv.GetMethodID (class_ref, "createTrainingAndTestSubsets", "(II)[Lorg/neuroph/core/data/DataSet;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					return (global::Org.Neuroph.Core.Data.DataSet[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createTrainingAndTestSubsets_II, __args), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Neuroph.Core.Data.DataSet));
				else
					return (global::Org.Neuroph.Core.Data.DataSet[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createTrainingAndTestSubsets", "(II)[Lorg/neuroph/core/data/DataSet;"), __args), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Neuroph.Core.Data.DataSet));
			} finally {
			}
		}

		static Delegate cb_getColumnName_I;
#pragma warning disable 0169
		static Delegate GetGetColumnName_IHandler ()
		{
			if (cb_getColumnName_I == null)
				cb_getColumnName_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetColumnName_I);
			return cb_getColumnName_I;
		}

		static IntPtr n_GetColumnName_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Neuroph.Core.Data.DataSet __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Data.DataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GetColumnName (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getColumnName_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.data']/class[@name='DataSet']/method[@name='getColumnName' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getColumnName", "(I)Ljava/lang/String;", "GetGetColumnName_IHandler")]
		public virtual unsafe string GetColumnName (int p0)
		{
			if (id_getColumnName_I == IntPtr.Zero)
				id_getColumnName_I = JNIEnv.GetMethodID (class_ref, "getColumnName", "(I)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getColumnName_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getColumnName", "(I)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getColumnNames;
#pragma warning disable 0169
		static Delegate GetGetColumnNamesHandler ()
		{
			if (cb_getColumnNames == null)
				cb_getColumnNames = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetColumnNames);
			return cb_getColumnNames;
		}

		static IntPtr n_GetColumnNames (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Core.Data.DataSet __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Data.DataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetColumnNames ());
		}
#pragma warning restore 0169

		static IntPtr id_getColumnNames;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.data']/class[@name='DataSet']/method[@name='getColumnNames' and count(parameter)=0]"
		[Register ("getColumnNames", "()[Ljava/lang/String;", "GetGetColumnNamesHandler")]
		public virtual unsafe string[] GetColumnNames ()
		{
			if (id_getColumnNames == IntPtr.Zero)
				id_getColumnNames = JNIEnv.GetMethodID (class_ref, "getColumnNames", "()[Ljava/lang/String;");
			try {

				if (GetType () == ThresholdType)
					return (string[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getColumnNames), JniHandleOwnership.TransferLocalRef, typeof (string));
				else
					return (string[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getColumnNames", "()[Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
			}
		}

		static Delegate cb_getRowAt_I;
#pragma warning disable 0169
		static Delegate GetGetRowAt_IHandler ()
		{
			if (cb_getRowAt_I == null)
				cb_getRowAt_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetRowAt_I);
			return cb_getRowAt_I;
		}

		static IntPtr n_GetRowAt_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Neuroph.Core.Data.DataSet __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Data.DataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetRowAt (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getRowAt_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.data']/class[@name='DataSet']/method[@name='getRowAt' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getRowAt", "(I)Lorg/neuroph/core/data/DataSetRow;", "GetGetRowAt_IHandler")]
		public virtual unsafe global::Org.Neuroph.Core.Data.DataSetRow GetRowAt (int p0)
		{
			if (id_getRowAt_I == IntPtr.Zero)
				id_getRowAt_I = JNIEnv.GetMethodID (class_ref, "getRowAt", "(I)Lorg/neuroph/core/data/DataSetRow;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Data.DataSetRow> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRowAt_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Data.DataSetRow> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRowAt", "(I)Lorg/neuroph/core/data/DataSetRow;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_iterator;
#pragma warning disable 0169
		static Delegate GetIteratorHandler ()
		{
			if (cb_iterator == null)
				cb_iterator = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Iterator);
			return cb_iterator;
		}

		static IntPtr n_Iterator (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Core.Data.DataSet __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Data.DataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Iterator ());
		}
#pragma warning restore 0169

		static IntPtr id_iterator;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.data']/class[@name='DataSet']/method[@name='iterator' and count(parameter)=0]"
		[Register ("iterator", "()Ljava/util/Iterator;", "GetIteratorHandler")]
		public virtual unsafe global::Java.Util.IIterator Iterator ()
		{
			if (id_iterator == IntPtr.Zero)
				id_iterator = JNIEnv.GetMethodID (class_ref, "iterator", "()Ljava/util/Iterator;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Util.IIterator> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_iterator), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Util.IIterator> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "iterator", "()Ljava/util/Iterator;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_load_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.data']/class[@name='DataSet']/method[@name='load' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("load", "(Ljava/lang/String;)Lorg/neuroph/core/data/DataSet;", "")]
		public static unsafe global::Org.Neuroph.Core.Data.DataSet Load (string p0)
		{
			if (id_load_Ljava_lang_String_ == IntPtr.Zero)
				id_load_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "load", "(Ljava/lang/String;)Lorg/neuroph/core/data/DataSet;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Org.Neuroph.Core.Data.DataSet __ret = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Data.DataSet> (JNIEnv.CallStaticObjectMethod  (class_ref, id_load_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_normalize;
#pragma warning disable 0169
		static Delegate GetNormalizeHandler ()
		{
			if (cb_normalize == null)
				cb_normalize = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Normalize);
			return cb_normalize;
		}

		static void n_Normalize (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Core.Data.DataSet __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Data.DataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Normalize ();
		}
#pragma warning restore 0169

		static IntPtr id_normalize;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.data']/class[@name='DataSet']/method[@name='normalize' and count(parameter)=0]"
		[Register ("normalize", "()V", "GetNormalizeHandler")]
		public virtual unsafe void Normalize ()
		{
			if (id_normalize == IntPtr.Zero)
				id_normalize = JNIEnv.GetMethodID (class_ref, "normalize", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_normalize);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "normalize", "()V"));
			} finally {
			}
		}

		static Delegate cb_normalize_Lorg_neuroph_core_data_norm_Normalizer_;
#pragma warning disable 0169
		static Delegate GetNormalize_Lorg_neuroph_core_data_norm_Normalizer_Handler ()
		{
			if (cb_normalize_Lorg_neuroph_core_data_norm_Normalizer_ == null)
				cb_normalize_Lorg_neuroph_core_data_norm_Normalizer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Normalize_Lorg_neuroph_core_data_norm_Normalizer_);
			return cb_normalize_Lorg_neuroph_core_data_norm_Normalizer_;
		}

		static void n_Normalize_Lorg_neuroph_core_data_norm_Normalizer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Core.Data.DataSet __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Data.DataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Core.Data.Norm.INormalizer p0 = (global::Org.Neuroph.Core.Data.Norm.INormalizer)global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Data.Norm.INormalizer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Normalize (p0);
		}
#pragma warning restore 0169

		static IntPtr id_normalize_Lorg_neuroph_core_data_norm_Normalizer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.data']/class[@name='DataSet']/method[@name='normalize' and count(parameter)=1 and parameter[1][@type='org.neuroph.core.data.norm.Normalizer']]"
		[Register ("normalize", "(Lorg/neuroph/core/data/norm/Normalizer;)V", "GetNormalize_Lorg_neuroph_core_data_norm_Normalizer_Handler")]
		public virtual unsafe void Normalize (global::Org.Neuroph.Core.Data.Norm.INormalizer p0)
		{
			if (id_normalize_Lorg_neuroph_core_data_norm_Normalizer_ == IntPtr.Zero)
				id_normalize_Lorg_neuroph_core_data_norm_Normalizer_ = JNIEnv.GetMethodID (class_ref, "normalize", "(Lorg/neuroph/core/data/norm/Normalizer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_normalize_Lorg_neuroph_core_data_norm_Normalizer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "normalize", "(Lorg/neuroph/core/data/norm/Normalizer;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_removeRowAt_I;
#pragma warning disable 0169
		static Delegate GetRemoveRowAt_IHandler ()
		{
			if (cb_removeRowAt_I == null)
				cb_removeRowAt_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_RemoveRowAt_I);
			return cb_removeRowAt_I;
		}

		static void n_RemoveRowAt_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Neuroph.Core.Data.DataSet __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Data.DataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveRowAt (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeRowAt_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.data']/class[@name='DataSet']/method[@name='removeRowAt' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("removeRowAt", "(I)V", "GetRemoveRowAt_IHandler")]
		public virtual unsafe void RemoveRowAt (int p0)
		{
			if (id_removeRowAt_I == IntPtr.Zero)
				id_removeRowAt_I = JNIEnv.GetMethodID (class_ref, "removeRowAt", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeRowAt_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeRowAt", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_sample_I;
#pragma warning disable 0169
		static Delegate GetSample_IHandler ()
		{
			if (cb_sample_I == null)
				cb_sample_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_Sample_I);
			return cb_sample_I;
		}

		static IntPtr n_Sample_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Neuroph.Core.Data.DataSet __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Data.DataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.Sample (p0));
		}
#pragma warning restore 0169

		static IntPtr id_sample_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.data']/class[@name='DataSet']/method[@name='sample' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("sample", "(I)[Lorg/neuroph/core/data/DataSet;", "GetSample_IHandler")]
		public virtual unsafe global::Org.Neuroph.Core.Data.DataSet[] Sample (int p0)
		{
			if (id_sample_I == IntPtr.Zero)
				id_sample_I = JNIEnv.GetMethodID (class_ref, "sample", "(I)[Lorg/neuroph/core/data/DataSet;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return (global::Org.Neuroph.Core.Data.DataSet[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_sample_I, __args), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Neuroph.Core.Data.DataSet));
				else
					return (global::Org.Neuroph.Core.Data.DataSet[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sample", "(I)[Lorg/neuroph/core/data/DataSet;"), __args), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Neuroph.Core.Data.DataSet));
			} finally {
			}
		}

		static Delegate cb_sample_Lorg_neuroph_core_data_sample_Sampling_;
#pragma warning disable 0169
		static Delegate GetSample_Lorg_neuroph_core_data_sample_Sampling_Handler ()
		{
			if (cb_sample_Lorg_neuroph_core_data_sample_Sampling_ == null)
				cb_sample_Lorg_neuroph_core_data_sample_Sampling_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Sample_Lorg_neuroph_core_data_sample_Sampling_);
			return cb_sample_Lorg_neuroph_core_data_sample_Sampling_;
		}

		static IntPtr n_Sample_Lorg_neuroph_core_data_sample_Sampling_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Core.Data.DataSet __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Data.DataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Core.Data.Sample.ISampling p0 = (global::Org.Neuroph.Core.Data.Sample.ISampling)global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Data.Sample.ISampling> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.Sample (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_sample_Lorg_neuroph_core_data_sample_Sampling_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.data']/class[@name='DataSet']/method[@name='sample' and count(parameter)=1 and parameter[1][@type='org.neuroph.core.data.sample.Sampling']]"
		[Register ("sample", "(Lorg/neuroph/core/data/sample/Sampling;)[Lorg/neuroph/core/data/DataSet;", "GetSample_Lorg_neuroph_core_data_sample_Sampling_Handler")]
		public virtual unsafe global::Org.Neuroph.Core.Data.DataSet[] Sample (global::Org.Neuroph.Core.Data.Sample.ISampling p0)
		{
			if (id_sample_Lorg_neuroph_core_data_sample_Sampling_ == IntPtr.Zero)
				id_sample_Lorg_neuroph_core_data_sample_Sampling_ = JNIEnv.GetMethodID (class_ref, "sample", "(Lorg/neuroph/core/data/sample/Sampling;)[Lorg/neuroph/core/data/DataSet;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Org.Neuroph.Core.Data.DataSet[] __ret;
				if (GetType () == ThresholdType)
					__ret = (global::Org.Neuroph.Core.Data.DataSet[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_sample_Lorg_neuroph_core_data_sample_Sampling_, __args), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Neuroph.Core.Data.DataSet));
				else
					__ret = (global::Org.Neuroph.Core.Data.DataSet[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sample", "(Lorg/neuroph/core/data/sample/Sampling;)[Lorg/neuroph/core/data/DataSet;"), __args), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Neuroph.Core.Data.DataSet));
				return __ret;
			} finally {
			}
		}

		static Delegate cb_save;
#pragma warning disable 0169
		static Delegate GetSaveHandler ()
		{
			if (cb_save == null)
				cb_save = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Save);
			return cb_save;
		}

		static void n_Save (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Core.Data.DataSet __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Data.DataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Save ();
		}
#pragma warning restore 0169

		static IntPtr id_save;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.data']/class[@name='DataSet']/method[@name='save' and count(parameter)=0]"
		[Register ("save", "()V", "GetSaveHandler")]
		public virtual unsafe void Save ()
		{
			if (id_save == IntPtr.Zero)
				id_save = JNIEnv.GetMethodID (class_ref, "save", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_save);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "save", "()V"));
			} finally {
			}
		}

		static Delegate cb_save_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSave_Ljava_lang_String_Handler ()
		{
			if (cb_save_Ljava_lang_String_ == null)
				cb_save_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Save_Ljava_lang_String_);
			return cb_save_Ljava_lang_String_;
		}

		static void n_Save_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Core.Data.DataSet __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Data.DataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Save (p0);
		}
#pragma warning restore 0169

		static IntPtr id_save_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.data']/class[@name='DataSet']/method[@name='save' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("save", "(Ljava/lang/String;)V", "GetSave_Ljava_lang_String_Handler")]
		public virtual unsafe void Save (string p0)
		{
			if (id_save_Ljava_lang_String_ == IntPtr.Zero)
				id_save_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "save", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_save_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "save", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_saveAsTxt_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSaveAsTxt_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_saveAsTxt_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_saveAsTxt_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SaveAsTxt_Ljava_lang_String_Ljava_lang_String_);
			return cb_saveAsTxt_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_SaveAsTxt_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Neuroph.Core.Data.DataSet __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Data.DataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SaveAsTxt (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_saveAsTxt_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.data']/class[@name='DataSet']/method[@name='saveAsTxt' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("saveAsTxt", "(Ljava/lang/String;Ljava/lang/String;)V", "GetSaveAsTxt_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void SaveAsTxt (string p0, string p1)
		{
			if (id_saveAsTxt_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_saveAsTxt_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "saveAsTxt", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_saveAsTxt_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "saveAsTxt", "(Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_setColumnName_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetSetColumnName_Ljava_lang_String_IHandler ()
		{
			if (cb_setColumnName_Ljava_lang_String_I == null)
				cb_setColumnName_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_SetColumnName_Ljava_lang_String_I);
			return cb_setColumnName_Ljava_lang_String_I;
		}

		static void n_SetColumnName_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Org.Neuroph.Core.Data.DataSet __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Data.DataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetColumnName (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setColumnName_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.data']/class[@name='DataSet']/method[@name='setColumnName' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("setColumnName", "(Ljava/lang/String;I)V", "GetSetColumnName_Ljava_lang_String_IHandler")]
		public virtual unsafe void SetColumnName (string p0, int p1)
		{
			if (id_setColumnName_Ljava_lang_String_I == IntPtr.Zero)
				id_setColumnName_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "setColumnName", "(Ljava/lang/String;I)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setColumnName_Ljava_lang_String_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setColumnName", "(Ljava/lang/String;I)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setColumnNames_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetColumnNames_arrayLjava_lang_String_Handler ()
		{
			if (cb_setColumnNames_arrayLjava_lang_String_ == null)
				cb_setColumnNames_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetColumnNames_arrayLjava_lang_String_);
			return cb_setColumnNames_arrayLjava_lang_String_;
		}

		static void n_SetColumnNames_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Core.Data.DataSet __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Data.DataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] p0 = (string[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (string));
			__this.SetColumnNames (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_setColumnNames_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.data']/class[@name='DataSet']/method[@name='setColumnNames' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register ("setColumnNames", "([Ljava/lang/String;)V", "GetSetColumnNames_arrayLjava_lang_String_Handler")]
		public virtual unsafe void SetColumnNames (string[] p0)
		{
			if (id_setColumnNames_arrayLjava_lang_String_ == IntPtr.Zero)
				id_setColumnNames_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setColumnNames", "([Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setColumnNames_arrayLjava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setColumnNames", "([Ljava/lang/String;)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_shuffle;
#pragma warning disable 0169
		static Delegate GetShuffleHandler ()
		{
			if (cb_shuffle == null)
				cb_shuffle = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Shuffle);
			return cb_shuffle;
		}

		static void n_Shuffle (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Core.Data.DataSet __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Data.DataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Shuffle ();
		}
#pragma warning restore 0169

		static IntPtr id_shuffle;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.data']/class[@name='DataSet']/method[@name='shuffle' and count(parameter)=0]"
		[Register ("shuffle", "()V", "GetShuffleHandler")]
		public virtual unsafe void Shuffle ()
		{
			if (id_shuffle == IntPtr.Zero)
				id_shuffle = JNIEnv.GetMethodID (class_ref, "shuffle", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_shuffle);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "shuffle", "()V"));
			} finally {
			}
		}

		static Delegate cb_size;
#pragma warning disable 0169
		static Delegate GetSizeHandler ()
		{
			if (cb_size == null)
				cb_size = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Size);
			return cb_size;
		}

		static int n_Size (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Core.Data.DataSet __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Data.DataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Size ();
		}
#pragma warning restore 0169

		static IntPtr id_size;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.data']/class[@name='DataSet']/method[@name='size' and count(parameter)=0]"
		[Register ("size", "()I", "GetSizeHandler")]
		public virtual unsafe int Size ()
		{
			if (id_size == IntPtr.Zero)
				id_size = JNIEnv.GetMethodID (class_ref, "size", "()I");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_size);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "size", "()I"));
			} finally {
			}
		}

		static Delegate cb_toCSV;
#pragma warning disable 0169
		static Delegate GetToCSVHandler ()
		{
			if (cb_toCSV == null)
				cb_toCSV = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToCSV);
			return cb_toCSV;
		}

		static IntPtr n_ToCSV (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Core.Data.DataSet __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Data.DataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ToCSV ());
		}
#pragma warning restore 0169

		static IntPtr id_toCSV;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.data']/class[@name='DataSet']/method[@name='toCSV' and count(parameter)=0]"
		[Register ("toCSV", "()Ljava/lang/String;", "GetToCSVHandler")]
		public virtual unsafe string ToCSV ()
		{
			if (id_toCSV == IntPtr.Zero)
				id_toCSV = JNIEnv.GetMethodID (class_ref, "toCSV", "()Ljava/lang/String;");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toCSV), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toCSV", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
