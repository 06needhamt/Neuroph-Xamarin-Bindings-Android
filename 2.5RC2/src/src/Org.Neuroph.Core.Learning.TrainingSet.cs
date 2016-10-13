using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Core.Learning {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='TrainingSet']"
	[global::Android.Runtime.Register ("org/neuroph/core/learning/TrainingSet", DoNotGenerateAcw=true)]
	public partial class TrainingSet : global::Java.Lang.Object, global::Java.IO.ISerializable, global::Org.Encog.Engine.Data.IEngineIndexableSet {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/core/learning/TrainingSet", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TrainingSet); }
		}

		protected TrainingSet (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_II;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='TrainingSet']/constructor[@name='TrainingSet' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register (".ctor", "(II)V", "")]
		public unsafe TrainingSet (int p0, int p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (TrainingSet)) {
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

		static IntPtr id_ctor_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='TrainingSet']/constructor[@name='TrainingSet' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe TrainingSet (int p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (TrainingSet)) {
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

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='TrainingSet']/constructor[@name='TrainingSet' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe TrainingSet (string p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (TrainingSet)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='TrainingSet']/constructor[@name='TrainingSet' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TrainingSet ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (TrainingSet)) {
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
			global::Org.Neuroph.Core.Learning.TrainingSet __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.TrainingSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Org.Neuroph.Core.Learning.TrainingSet __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.TrainingSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.FilePath = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getFilePath;
		static IntPtr id_setFilePath_Ljava_lang_String_;
		public virtual unsafe string FilePath {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='TrainingSet']/method[@name='getFilePath' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='TrainingSet']/method[@name='setFilePath' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getIdealSize;
#pragma warning disable 0169
		static Delegate GetGetIdealSizeHandler ()
		{
			if (cb_getIdealSize == null)
				cb_getIdealSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetIdealSize);
			return cb_getIdealSize;
		}

		static int n_GetIdealSize (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Core.Learning.TrainingSet __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.TrainingSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IdealSize;
		}
#pragma warning restore 0169

		static IntPtr id_getIdealSize;
		public virtual unsafe int IdealSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='TrainingSet']/method[@name='getIdealSize' and count(parameter)=0]"
			[Register ("getIdealSize", "()I", "GetGetIdealSizeHandler")]
			get {
				if (id_getIdealSize == IntPtr.Zero)
					id_getIdealSize = JNIEnv.GetMethodID (class_ref, "getIdealSize", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getIdealSize);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIdealSize", "()I"));
				} finally {
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
			global::Org.Neuroph.Core.Learning.TrainingSet __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.TrainingSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.InputSize;
		}
#pragma warning restore 0169

		static IntPtr id_getInputSize;
		public virtual unsafe int InputSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='TrainingSet']/method[@name='getInputSize' and count(parameter)=0]"
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
			global::Org.Neuroph.Core.Learning.TrainingSet __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.TrainingSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsEmpty;
		}
#pragma warning restore 0169

		static IntPtr id_isEmpty;
		public virtual unsafe bool IsEmpty {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='TrainingSet']/method[@name='isEmpty' and count(parameter)=0]"
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
			global::Org.Neuroph.Core.Learning.TrainingSet __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.TrainingSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSupervised;
		}
#pragma warning restore 0169

		static IntPtr id_isSupervised;
		public virtual unsafe bool IsSupervised {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='TrainingSet']/method[@name='isSupervised' and count(parameter)=0]"
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
			global::Org.Neuroph.Core.Learning.TrainingSet __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.TrainingSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Org.Neuroph.Core.Learning.TrainingSet __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.TrainingSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Label = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getLabel;
		static IntPtr id_setLabel_Ljava_lang_String_;
		public virtual unsafe string Label {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='TrainingSet']/method[@name='getLabel' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='TrainingSet']/method[@name='setLabel' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Org.Neuroph.Core.Learning.TrainingSet __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.TrainingSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.OutputSize;
		}
#pragma warning restore 0169

		static IntPtr id_getOutputSize;
		public virtual unsafe int OutputSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='TrainingSet']/method[@name='getOutputSize' and count(parameter)=0]"
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

		static Delegate cb_getRecordCount;
#pragma warning disable 0169
		static Delegate GetGetRecordCountHandler ()
		{
			if (cb_getRecordCount == null)
				cb_getRecordCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetRecordCount);
			return cb_getRecordCount;
		}

		static long n_GetRecordCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Core.Learning.TrainingSet __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.TrainingSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RecordCount;
		}
#pragma warning restore 0169

		static IntPtr id_getRecordCount;
		public virtual unsafe long RecordCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='TrainingSet']/method[@name='getRecordCount' and count(parameter)=0]"
			[Register ("getRecordCount", "()J", "GetGetRecordCountHandler")]
			get {
				if (id_getRecordCount == IntPtr.Zero)
					id_getRecordCount = JNIEnv.GetMethodID (class_ref, "getRecordCount", "()J");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getRecordCount);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRecordCount", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_addElement_Lorg_neuroph_core_learning_TrainingElement_;
#pragma warning disable 0169
		static Delegate GetAddElement_Lorg_neuroph_core_learning_TrainingElement_Handler ()
		{
			if (cb_addElement_Lorg_neuroph_core_learning_TrainingElement_ == null)
				cb_addElement_Lorg_neuroph_core_learning_TrainingElement_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddElement_Lorg_neuroph_core_learning_TrainingElement_);
			return cb_addElement_Lorg_neuroph_core_learning_TrainingElement_;
		}

		static void n_AddElement_Lorg_neuroph_core_learning_TrainingElement_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Core.Learning.TrainingSet __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.TrainingSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Core.Learning.TrainingElement p0 = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.TrainingElement> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddElement (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addElement_Lorg_neuroph_core_learning_TrainingElement_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='TrainingSet']/method[@name='addElement' and count(parameter)=1 and parameter[1][@type='org.neuroph.core.learning.TrainingElement']]"
		[Register ("addElement", "(Lorg/neuroph/core/learning/TrainingElement;)V", "GetAddElement_Lorg_neuroph_core_learning_TrainingElement_Handler")]
		public virtual unsafe void AddElement (global::Org.Neuroph.Core.Learning.TrainingElement p0)
		{
			if (id_addElement_Lorg_neuroph_core_learning_TrainingElement_ == IntPtr.Zero)
				id_addElement_Lorg_neuroph_core_learning_TrainingElement_ = JNIEnv.GetMethodID (class_ref, "addElement", "(Lorg/neuroph/core/learning/TrainingElement;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addElement_Lorg_neuroph_core_learning_TrainingElement_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addElement", "(Lorg/neuroph/core/learning/TrainingElement;)V"), __args);
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
			global::Org.Neuroph.Core.Learning.TrainingSet __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.TrainingSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		static IntPtr id_clear;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='TrainingSet']/method[@name='clear' and count(parameter)=0]"
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

		static Delegate cb_elementAt_I;
#pragma warning disable 0169
		static Delegate GetElementAt_IHandler ()
		{
			if (cb_elementAt_I == null)
				cb_elementAt_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_ElementAt_I);
			return cb_elementAt_I;
		}

		static IntPtr n_ElementAt_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Neuroph.Core.Learning.TrainingSet __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.TrainingSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ElementAt (p0));
		}
#pragma warning restore 0169

		static IntPtr id_elementAt_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='TrainingSet']/method[@name='elementAt' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("elementAt", "(I)Lorg/neuroph/core/learning/TrainingElement;", "GetElementAt_IHandler")]
		public virtual unsafe global::Org.Neuroph.Core.Learning.TrainingElement ElementAt (int p0)
		{
			if (id_elementAt_I == IntPtr.Zero)
				id_elementAt_I = JNIEnv.GetMethodID (class_ref, "elementAt", "(I)Lorg/neuroph/core/learning/TrainingElement;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.TrainingElement> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_elementAt_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.TrainingElement> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "elementAt", "(I)Lorg/neuroph/core/learning/TrainingElement;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getRecord_JLorg_encog_engine_data_EngineData_;
#pragma warning disable 0169
		static Delegate GetGetRecord_JLorg_encog_engine_data_EngineData_Handler ()
		{
			if (cb_getRecord_JLorg_encog_engine_data_EngineData_ == null)
				cb_getRecord_JLorg_encog_engine_data_EngineData_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long, IntPtr>) n_GetRecord_JLorg_encog_engine_data_EngineData_);
			return cb_getRecord_JLorg_encog_engine_data_EngineData_;
		}

		static void n_GetRecord_JLorg_encog_engine_data_EngineData_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
		{
			global::Org.Neuroph.Core.Learning.TrainingSet __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.TrainingSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Encog.Engine.Data.IEngineData p1 = (global::Org.Encog.Engine.Data.IEngineData)global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Data.IEngineData> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.GetRecord (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_getRecord_JLorg_encog_engine_data_EngineData_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='TrainingSet']/method[@name='getRecord' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='org.encog.engine.data.EngineData']]"
		[Register ("getRecord", "(JLorg/encog/engine/data/EngineData;)V", "GetGetRecord_JLorg_encog_engine_data_EngineData_Handler")]
		public virtual unsafe void GetRecord (long p0, global::Org.Encog.Engine.Data.IEngineData p1)
		{
			if (id_getRecord_JLorg_encog_engine_data_EngineData_ == IntPtr.Zero)
				id_getRecord_JLorg_encog_engine_data_EngineData_ = JNIEnv.GetMethodID (class_ref, "getRecord", "(JLorg/encog/engine/data/EngineData;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getRecord_JLorg_encog_engine_data_EngineData_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRecord", "(JLorg/encog/engine/data/EngineData;)V"), __args);
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
			global::Org.Neuroph.Core.Learning.TrainingSet __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.TrainingSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Iterator ());
		}
#pragma warning restore 0169

		static IntPtr id_iterator;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='TrainingSet']/method[@name='iterator' and count(parameter)=0]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='TrainingSet']/method[@name='load' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("load", "(Ljava/lang/String;)Lorg/neuroph/core/learning/TrainingSet;", "")]
		public static unsafe global::Org.Neuroph.Core.Learning.TrainingSet Load (string p0)
		{
			if (id_load_Ljava_lang_String_ == IntPtr.Zero)
				id_load_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "load", "(Ljava/lang/String;)Lorg/neuroph/core/learning/TrainingSet;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Org.Neuroph.Core.Learning.TrainingSet __ret = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.TrainingSet> (JNIEnv.CallStaticObjectMethod  (class_ref, id_load_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_openAdditional;
#pragma warning disable 0169
		static Delegate GetOpenAdditionalHandler ()
		{
			if (cb_openAdditional == null)
				cb_openAdditional = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_OpenAdditional);
			return cb_openAdditional;
		}

		static IntPtr n_OpenAdditional (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Core.Learning.TrainingSet __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.TrainingSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OpenAdditional ());
		}
#pragma warning restore 0169

		static IntPtr id_openAdditional;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='TrainingSet']/method[@name='openAdditional' and count(parameter)=0]"
		[Register ("openAdditional", "()Lorg/encog/engine/data/EngineIndexableSet;", "GetOpenAdditionalHandler")]
		public virtual unsafe global::Org.Encog.Engine.Data.IEngineIndexableSet OpenAdditional ()
		{
			if (id_openAdditional == IntPtr.Zero)
				id_openAdditional = JNIEnv.GetMethodID (class_ref, "openAdditional", "()Lorg/encog/engine/data/EngineIndexableSet;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Data.IEngineIndexableSet> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_openAdditional), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Data.IEngineIndexableSet> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "openAdditional", "()Lorg/encog/engine/data/EngineIndexableSet;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_removeElementAt_I;
#pragma warning disable 0169
		static Delegate GetRemoveElementAt_IHandler ()
		{
			if (cb_removeElementAt_I == null)
				cb_removeElementAt_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_RemoveElementAt_I);
			return cb_removeElementAt_I;
		}

		static void n_RemoveElementAt_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Neuroph.Core.Learning.TrainingSet __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.TrainingSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveElementAt (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeElementAt_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='TrainingSet']/method[@name='removeElementAt' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("removeElementAt", "(I)V", "GetRemoveElementAt_IHandler")]
		public virtual unsafe void RemoveElementAt (int p0)
		{
			if (id_removeElementAt_I == IntPtr.Zero)
				id_removeElementAt_I = JNIEnv.GetMethodID (class_ref, "removeElementAt", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeElementAt_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeElementAt", "(I)V"), __args);
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
			global::Org.Neuroph.Core.Learning.TrainingSet __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.TrainingSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Save ();
		}
#pragma warning restore 0169

		static IntPtr id_save;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='TrainingSet']/method[@name='save' and count(parameter)=0]"
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
			global::Org.Neuroph.Core.Learning.TrainingSet __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.TrainingSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Save (p0);
		}
#pragma warning restore 0169

		static IntPtr id_save_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='TrainingSet']/method[@name='save' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Org.Neuroph.Core.Learning.TrainingSet __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.TrainingSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Size ();
		}
#pragma warning restore 0169

		static IntPtr id_size;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='TrainingSet']/method[@name='size' and count(parameter)=0]"
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

		static Delegate cb_trainingElements;
#pragma warning disable 0169
		static Delegate GetTrainingElementsHandler ()
		{
			if (cb_trainingElements == null)
				cb_trainingElements = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_TrainingElements);
			return cb_trainingElements;
		}

		static IntPtr n_TrainingElements (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Core.Learning.TrainingSet __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.TrainingSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Org.Neuroph.Core.Learning.TrainingElement>.ToLocalJniHandle (__this.TrainingElements ());
		}
#pragma warning restore 0169

		static IntPtr id_trainingElements;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.learning']/class[@name='TrainingSet']/method[@name='trainingElements' and count(parameter)=0]"
		[Register ("trainingElements", "()Ljava/util/List;", "GetTrainingElementsHandler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Org.Neuroph.Core.Learning.TrainingElement> TrainingElements ()
		{
			if (id_trainingElements == IntPtr.Zero)
				id_trainingElements = JNIEnv.GetMethodID (class_ref, "trainingElements", "()Ljava/util/List;");
			try {

				if (GetType () == ThresholdType)
					return global::Android.Runtime.JavaList<global::Org.Neuroph.Core.Learning.TrainingElement>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_trainingElements), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaList<global::Org.Neuroph.Core.Learning.TrainingElement>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "trainingElements", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
