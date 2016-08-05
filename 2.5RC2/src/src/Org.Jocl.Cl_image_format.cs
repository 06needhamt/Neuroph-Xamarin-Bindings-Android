using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jocl {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jocl']/class[@name='cl_image_format']"
	[global::Android.Runtime.Register ("org/jocl/cl_image_format", DoNotGenerateAcw=true)]
	public sealed partial class Cl_image_format : global::Java.Lang.Object {


		static IntPtr image_channel_data_type_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jocl']/class[@name='cl_image_format']/field[@name='image_channel_data_type']"
		[Register ("image_channel_data_type")]
		public int ImageChannelDataType {
			get {
				if (image_channel_data_type_jfieldId == IntPtr.Zero)
					image_channel_data_type_jfieldId = JNIEnv.GetFieldID (class_ref, "image_channel_data_type", "I");
				return JNIEnv.GetIntField (Handle, image_channel_data_type_jfieldId);
			}
			set {
				if (image_channel_data_type_jfieldId == IntPtr.Zero)
					image_channel_data_type_jfieldId = JNIEnv.GetFieldID (class_ref, "image_channel_data_type", "I");
				try {
					JNIEnv.SetField (Handle, image_channel_data_type_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr image_channel_order_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jocl']/class[@name='cl_image_format']/field[@name='image_channel_order']"
		[Register ("image_channel_order")]
		public int ImageChannelOrder {
			get {
				if (image_channel_order_jfieldId == IntPtr.Zero)
					image_channel_order_jfieldId = JNIEnv.GetFieldID (class_ref, "image_channel_order", "I");
				return JNIEnv.GetIntField (Handle, image_channel_order_jfieldId);
			}
			set {
				if (image_channel_order_jfieldId == IntPtr.Zero)
					image_channel_order_jfieldId = JNIEnv.GetFieldID (class_ref, "image_channel_order", "I");
				try {
					JNIEnv.SetField (Handle, image_channel_order_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jocl/cl_image_format", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Cl_image_format); }
		}

		internal Cl_image_format (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jocl']/class[@name='cl_image_format']/constructor[@name='cl_image_format' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Cl_image_format ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Cl_image_format)) {
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

	}
}
