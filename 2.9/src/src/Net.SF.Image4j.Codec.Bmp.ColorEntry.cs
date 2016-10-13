using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Net.SF.Image4j.Codec.Bmp {

	// Metadata.xml XPath class reference: path="/api/package[@name='net.sf.image4j.codec.bmp']/class[@name='ColorEntry']"
	[global::Android.Runtime.Register ("net/sf/image4j/codec/bmp/ColorEntry", DoNotGenerateAcw=true)]
	public partial class ColorEntry : global::Java.Lang.Object {


		static IntPtr bBlue_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='net.sf.image4j.codec.bmp']/class[@name='ColorEntry']/field[@name='bBlue']"
		[Register ("bBlue")]
		public int BBlue {
			get {
				if (bBlue_jfieldId == IntPtr.Zero)
					bBlue_jfieldId = JNIEnv.GetFieldID (class_ref, "bBlue", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, bBlue_jfieldId);
			}
			set {
				if (bBlue_jfieldId == IntPtr.Zero)
					bBlue_jfieldId = JNIEnv.GetFieldID (class_ref, "bBlue", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, bBlue_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr bGreen_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='net.sf.image4j.codec.bmp']/class[@name='ColorEntry']/field[@name='bGreen']"
		[Register ("bGreen")]
		public int BGreen {
			get {
				if (bGreen_jfieldId == IntPtr.Zero)
					bGreen_jfieldId = JNIEnv.GetFieldID (class_ref, "bGreen", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, bGreen_jfieldId);
			}
			set {
				if (bGreen_jfieldId == IntPtr.Zero)
					bGreen_jfieldId = JNIEnv.GetFieldID (class_ref, "bGreen", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, bGreen_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr bRed_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='net.sf.image4j.codec.bmp']/class[@name='ColorEntry']/field[@name='bRed']"
		[Register ("bRed")]
		public int BRed {
			get {
				if (bRed_jfieldId == IntPtr.Zero)
					bRed_jfieldId = JNIEnv.GetFieldID (class_ref, "bRed", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, bRed_jfieldId);
			}
			set {
				if (bRed_jfieldId == IntPtr.Zero)
					bRed_jfieldId = JNIEnv.GetFieldID (class_ref, "bRed", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, bRed_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr bReserved_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='net.sf.image4j.codec.bmp']/class[@name='ColorEntry']/field[@name='bReserved']"
		[Register ("bReserved")]
		public int BReserved {
			get {
				if (bReserved_jfieldId == IntPtr.Zero)
					bReserved_jfieldId = JNIEnv.GetFieldID (class_ref, "bReserved", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, bReserved_jfieldId);
			}
			set {
				if (bReserved_jfieldId == IntPtr.Zero)
					bReserved_jfieldId = JNIEnv.GetFieldID (class_ref, "bReserved", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, bReserved_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("net/sf/image4j/codec/bmp/ColorEntry", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ColorEntry); }
		}

		protected ColorEntry (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lnet_sf_image4j_io_LittleEndianInputStream_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='net.sf.image4j.codec.bmp']/class[@name='ColorEntry']/constructor[@name='ColorEntry' and count(parameter)=1 and parameter[1][@type='net.sf.image4j.io.LittleEndianInputStream']]"
		[Register (".ctor", "(Lnet/sf/image4j/io/LittleEndianInputStream;)V", "")]
		public unsafe ColorEntry (global::Net.SF.Image4j.IO.LittleEndianInputStream p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (ColorEntry)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lnet/sf/image4j/io/LittleEndianInputStream;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lnet/sf/image4j/io/LittleEndianInputStream;)V", __args);
					return;
				}

				if (id_ctor_Lnet_sf_image4j_io_LittleEndianInputStream_ == IntPtr.Zero)
					id_ctor_Lnet_sf_image4j_io_LittleEndianInputStream_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lnet/sf/image4j/io/LittleEndianInputStream;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lnet_sf_image4j_io_LittleEndianInputStream_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lnet_sf_image4j_io_LittleEndianInputStream_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='net.sf.image4j.codec.bmp']/class[@name='ColorEntry']/constructor[@name='ColorEntry' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ColorEntry ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ColorEntry)) {
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

		static IntPtr id_ctor_IIII;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='net.sf.image4j.codec.bmp']/class[@name='ColorEntry']/constructor[@name='ColorEntry' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register (".ctor", "(IIII)V", "")]
		public unsafe ColorEntry (int p0, int p1, int p2, int p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				if (GetType () != typeof (ColorEntry)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(IIII)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(IIII)V", __args);
					return;
				}

				if (id_ctor_IIII == IntPtr.Zero)
					id_ctor_IIII = JNIEnv.GetMethodID (class_ref, "<init>", "(IIII)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IIII, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_IIII, __args);
			} finally {
			}
		}

	}
}
