using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Encog.Engine {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.encog.engine']/interface[@name='StatusReportable']"
	[Register ("org/encog/engine/StatusReportable", "", "Org.Encog.Engine.IStatusReportableInvoker")]
	public partial interface IStatusReportable : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine']/interface[@name='StatusReportable']/method[@name='report' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
		[Register ("report", "(IILjava/lang/String;)V", "GetReport_IILjava_lang_String_Handler:Org.Encog.Engine.IStatusReportableInvoker, Neuroph_2.6")]
		void Report (int p0, int p1, string p2);

	}

	[global::Android.Runtime.Register ("org/encog/engine/StatusReportable", DoNotGenerateAcw=true)]
	internal class IStatusReportableInvoker : global::Java.Lang.Object, IStatusReportable {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/encog/engine/StatusReportable");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IStatusReportableInvoker); }
		}

		IntPtr class_ref;

		public static IStatusReportable GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IStatusReportable> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.encog.engine.StatusReportable"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IStatusReportableInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_report_IILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetReport_IILjava_lang_String_Handler ()
		{
			if (cb_report_IILjava_lang_String_ == null)
				cb_report_IILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, IntPtr>) n_Report_IILjava_lang_String_);
			return cb_report_IILjava_lang_String_;
		}

		static void n_Report_IILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2)
		{
			global::Org.Encog.Engine.IStatusReportable __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.IStatusReportable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Report (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_report_IILjava_lang_String_;
		public unsafe void Report (int p0, int p1, string p2)
		{
			if (id_report_IILjava_lang_String_ == IntPtr.Zero)
				id_report_IILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "report", "(IILjava/lang/String;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (native_p2);
			JNIEnv.CallVoidMethod (Handle, id_report_IILjava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p2);
		}

	}

}
