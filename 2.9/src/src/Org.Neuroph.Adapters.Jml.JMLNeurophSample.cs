using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Adapters.Jml {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.adapters.jml']/class[@name='JMLNeurophSample']"
	[global::Android.Runtime.Register ("org/neuroph/adapters/jml/JMLNeurophSample", DoNotGenerateAcw=true)]
	public partial class JMLNeurophSample : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/adapters/jml/JMLNeurophSample", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (JMLNeurophSample); }
		}

		protected JMLNeurophSample (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.adapters.jml']/class[@name='JMLNeurophSample']/constructor[@name='JMLNeurophSample' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe JMLNeurophSample ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (JMLNeurophSample)) {
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

		static IntPtr id_main_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.adapters.jml']/class[@name='JMLNeurophSample']/method[@name='main' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register ("main", "([Ljava/lang/String;)V", "")]
		public static unsafe void Main (string[] p0)
		{
			if (id_main_arrayLjava_lang_String_ == IntPtr.Zero)
				id_main_arrayLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "main", "([Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_main_arrayLjava_lang_String_, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_printDataset_Lorg_neuroph_core_data_DataSet_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.adapters.jml']/class[@name='JMLNeurophSample']/method[@name='printDataset' and count(parameter)=1 and parameter[1][@type='org.neuroph.core.data.DataSet']]"
		[Register ("printDataset", "(Lorg/neuroph/core/data/DataSet;)V", "")]
		public static unsafe void PrintDataset (global::Org.Neuroph.Core.Data.DataSet p0)
		{
			if (id_printDataset_Lorg_neuroph_core_data_DataSet_ == IntPtr.Zero)
				id_printDataset_Lorg_neuroph_core_data_DataSet_ = JNIEnv.GetStaticMethodID (class_ref, "printDataset", "(Lorg/neuroph/core/data/DataSet;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_printDataset_Lorg_neuroph_core_data_DataSet_, __args);
			} finally {
			}
		}

	}
}
