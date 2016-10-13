using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Util.Plugins {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.util.plugins']/class[@name='LabelsPlugin']"
	[global::Android.Runtime.Register ("org/neuroph/util/plugins/LabelsPlugin", DoNotGenerateAcw=true)]
	public partial class LabelsPlugin : global::Org.Neuroph.Util.Plugins.PluginBase {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.neuroph.util.plugins']/class[@name='LabelsPlugin']/field[@name='LABELS_PLUGIN_NAME']"
		[Register ("LABELS_PLUGIN_NAME")]
		public const string LabelsPluginName = (string) "LabelsPlugin";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/util/plugins/LabelsPlugin", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LabelsPlugin); }
		}

		protected LabelsPlugin (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.util.plugins']/class[@name='LabelsPlugin']/constructor[@name='LabelsPlugin' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe LabelsPlugin ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (LabelsPlugin)) {
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

		static Delegate cb_getLabel_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetGetLabel_Ljava_lang_Object_Handler ()
		{
			if (cb_getLabel_Ljava_lang_Object_ == null)
				cb_getLabel_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetLabel_Ljava_lang_Object_);
			return cb_getLabel_Ljava_lang_Object_;
		}

		static IntPtr n_GetLabel_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Util.Plugins.LabelsPlugin __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.Plugins.LabelsPlugin> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetLabel (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getLabel_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util.plugins']/class[@name='LabelsPlugin']/method[@name='getLabel' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("getLabel", "(Ljava/lang/Object;)Ljava/lang/String;", "GetGetLabel_Ljava_lang_Object_Handler")]
		public virtual unsafe string GetLabel (global::Java.Lang.Object p0)
		{
			if (id_getLabel_Ljava_lang_Object_ == IntPtr.Zero)
				id_getLabel_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "getLabel", "(Ljava/lang/Object;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				string __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLabel_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLabel", "(Ljava/lang/Object;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_setLabel_Ljava_lang_Object_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetLabel_Ljava_lang_Object_Ljava_lang_String_Handler ()
		{
			if (cb_setLabel_Ljava_lang_Object_Ljava_lang_String_ == null)
				cb_setLabel_Ljava_lang_Object_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetLabel_Ljava_lang_Object_Ljava_lang_String_);
			return cb_setLabel_Ljava_lang_Object_Ljava_lang_String_;
		}

		static void n_SetLabel_Ljava_lang_Object_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Neuroph.Util.Plugins.LabelsPlugin __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.Plugins.LabelsPlugin> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetLabel (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setLabel_Ljava_lang_Object_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util.plugins']/class[@name='LabelsPlugin']/method[@name='setLabel' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String']]"
		[Register ("setLabel", "(Ljava/lang/Object;Ljava/lang/String;)V", "GetSetLabel_Ljava_lang_Object_Ljava_lang_String_Handler")]
		public virtual unsafe void SetLabel (global::Java.Lang.Object p0, string p1)
		{
			if (id_setLabel_Ljava_lang_Object_Ljava_lang_String_ == IntPtr.Zero)
				id_setLabel_Ljava_lang_Object_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setLabel", "(Ljava/lang/Object;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLabel_Ljava_lang_Object_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLabel", "(Ljava/lang/Object;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
