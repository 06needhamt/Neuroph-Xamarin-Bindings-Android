using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Net.SF.Image4j.Codec.Ico {

	// Metadata.xml XPath class reference: path="/api/package[@name='net.sf.image4j.codec.ico']/class[@name='IconEntry']"
	[global::Android.Runtime.Register ("net/sf/image4j/codec/ico/IconEntry", DoNotGenerateAcw=true)]
	public partial class IconEntry : global::Java.Lang.Object {


		static IntPtr bColorCount_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='net.sf.image4j.codec.ico']/class[@name='IconEntry']/field[@name='bColorCount']"
		[Register ("bColorCount")]
		public int BColorCount {
			get {
				if (bColorCount_jfieldId == IntPtr.Zero)
					bColorCount_jfieldId = JNIEnv.GetFieldID (class_ref, "bColorCount", "I");
				return JNIEnv.GetIntField (Handle, bColorCount_jfieldId);
			}
			set {
				if (bColorCount_jfieldId == IntPtr.Zero)
					bColorCount_jfieldId = JNIEnv.GetFieldID (class_ref, "bColorCount", "I");
				try {
					JNIEnv.SetField (Handle, bColorCount_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr bHeight_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='net.sf.image4j.codec.ico']/class[@name='IconEntry']/field[@name='bHeight']"
		[Register ("bHeight")]
		public int BHeight {
			get {
				if (bHeight_jfieldId == IntPtr.Zero)
					bHeight_jfieldId = JNIEnv.GetFieldID (class_ref, "bHeight", "I");
				return JNIEnv.GetIntField (Handle, bHeight_jfieldId);
			}
			set {
				if (bHeight_jfieldId == IntPtr.Zero)
					bHeight_jfieldId = JNIEnv.GetFieldID (class_ref, "bHeight", "I");
				try {
					JNIEnv.SetField (Handle, bHeight_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr bReserved_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='net.sf.image4j.codec.ico']/class[@name='IconEntry']/field[@name='bReserved']"
		[Register ("bReserved")]
		public sbyte BReserved {
			get {
				if (bReserved_jfieldId == IntPtr.Zero)
					bReserved_jfieldId = JNIEnv.GetFieldID (class_ref, "bReserved", "B");
				return JNIEnv.GetByteField (Handle, bReserved_jfieldId);
			}
			set {
				if (bReserved_jfieldId == IntPtr.Zero)
					bReserved_jfieldId = JNIEnv.GetFieldID (class_ref, "bReserved", "B");
				try {
					JNIEnv.SetField (Handle, bReserved_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr bWidth_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='net.sf.image4j.codec.ico']/class[@name='IconEntry']/field[@name='bWidth']"
		[Register ("bWidth")]
		public int BWidth {
			get {
				if (bWidth_jfieldId == IntPtr.Zero)
					bWidth_jfieldId = JNIEnv.GetFieldID (class_ref, "bWidth", "I");
				return JNIEnv.GetIntField (Handle, bWidth_jfieldId);
			}
			set {
				if (bWidth_jfieldId == IntPtr.Zero)
					bWidth_jfieldId = JNIEnv.GetFieldID (class_ref, "bWidth", "I");
				try {
					JNIEnv.SetField (Handle, bWidth_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr iFileOffset_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='net.sf.image4j.codec.ico']/class[@name='IconEntry']/field[@name='iFileOffset']"
		[Register ("iFileOffset")]
		public int IFileOffset {
			get {
				if (iFileOffset_jfieldId == IntPtr.Zero)
					iFileOffset_jfieldId = JNIEnv.GetFieldID (class_ref, "iFileOffset", "I");
				return JNIEnv.GetIntField (Handle, iFileOffset_jfieldId);
			}
			set {
				if (iFileOffset_jfieldId == IntPtr.Zero)
					iFileOffset_jfieldId = JNIEnv.GetFieldID (class_ref, "iFileOffset", "I");
				try {
					JNIEnv.SetField (Handle, iFileOffset_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr iSizeInBytes_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='net.sf.image4j.codec.ico']/class[@name='IconEntry']/field[@name='iSizeInBytes']"
		[Register ("iSizeInBytes")]
		public int ISizeInBytes {
			get {
				if (iSizeInBytes_jfieldId == IntPtr.Zero)
					iSizeInBytes_jfieldId = JNIEnv.GetFieldID (class_ref, "iSizeInBytes", "I");
				return JNIEnv.GetIntField (Handle, iSizeInBytes_jfieldId);
			}
			set {
				if (iSizeInBytes_jfieldId == IntPtr.Zero)
					iSizeInBytes_jfieldId = JNIEnv.GetFieldID (class_ref, "iSizeInBytes", "I");
				try {
					JNIEnv.SetField (Handle, iSizeInBytes_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr sBitCount_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='net.sf.image4j.codec.ico']/class[@name='IconEntry']/field[@name='sBitCount']"
		[Register ("sBitCount")]
		public short SBitCount {
			get {
				if (sBitCount_jfieldId == IntPtr.Zero)
					sBitCount_jfieldId = JNIEnv.GetFieldID (class_ref, "sBitCount", "S");
				return JNIEnv.GetShortField (Handle, sBitCount_jfieldId);
			}
			set {
				if (sBitCount_jfieldId == IntPtr.Zero)
					sBitCount_jfieldId = JNIEnv.GetFieldID (class_ref, "sBitCount", "S");
				try {
					JNIEnv.SetField (Handle, sBitCount_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr sPlanes_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='net.sf.image4j.codec.ico']/class[@name='IconEntry']/field[@name='sPlanes']"
		[Register ("sPlanes")]
		public short SPlanes {
			get {
				if (sPlanes_jfieldId == IntPtr.Zero)
					sPlanes_jfieldId = JNIEnv.GetFieldID (class_ref, "sPlanes", "S");
				return JNIEnv.GetShortField (Handle, sPlanes_jfieldId);
			}
			set {
				if (sPlanes_jfieldId == IntPtr.Zero)
					sPlanes_jfieldId = JNIEnv.GetFieldID (class_ref, "sPlanes", "S");
				try {
					JNIEnv.SetField (Handle, sPlanes_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("net/sf/image4j/codec/ico/IconEntry", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IconEntry); }
		}

		protected IconEntry (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lnet_sf_image4j_io_LittleEndianInputStream_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='net.sf.image4j.codec.ico']/class[@name='IconEntry']/constructor[@name='IconEntry' and count(parameter)=1 and parameter[1][@type='net.sf.image4j.io.LittleEndianInputStream']]"
		[Register (".ctor", "(Lnet/sf/image4j/io/LittleEndianInputStream;)V", "")]
		public unsafe IconEntry (global::Net.SF.Image4j.IO.LittleEndianInputStream p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (IconEntry)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lnet/sf/image4j/io/LittleEndianInputStream;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lnet/sf/image4j/io/LittleEndianInputStream;)V", __args);
					return;
				}

				if (id_ctor_Lnet_sf_image4j_io_LittleEndianInputStream_ == IntPtr.Zero)
					id_ctor_Lnet_sf_image4j_io_LittleEndianInputStream_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lnet/sf/image4j/io/LittleEndianInputStream;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lnet_sf_image4j_io_LittleEndianInputStream_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lnet_sf_image4j_io_LittleEndianInputStream_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='net.sf.image4j.codec.ico']/class[@name='IconEntry']/constructor[@name='IconEntry' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe IconEntry ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (IconEntry)) {
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

		static Delegate cb_write_Lnet_sf_image4j_io_LittleEndianOutputStream_;
#pragma warning disable 0169
		static Delegate GetWrite_Lnet_sf_image4j_io_LittleEndianOutputStream_Handler ()
		{
			if (cb_write_Lnet_sf_image4j_io_LittleEndianOutputStream_ == null)
				cb_write_Lnet_sf_image4j_io_LittleEndianOutputStream_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Write_Lnet_sf_image4j_io_LittleEndianOutputStream_);
			return cb_write_Lnet_sf_image4j_io_LittleEndianOutputStream_;
		}

		static void n_Write_Lnet_sf_image4j_io_LittleEndianOutputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Net.SF.Image4j.Codec.Ico.IconEntry __this = global::Java.Lang.Object.GetObject<global::Net.SF.Image4j.Codec.Ico.IconEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Net.SF.Image4j.IO.LittleEndianOutputStream p0 = global::Java.Lang.Object.GetObject<global::Net.SF.Image4j.IO.LittleEndianOutputStream> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Write (p0);
		}
#pragma warning restore 0169

		static IntPtr id_write_Lnet_sf_image4j_io_LittleEndianOutputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='net.sf.image4j.codec.ico']/class[@name='IconEntry']/method[@name='write' and count(parameter)=1 and parameter[1][@type='net.sf.image4j.io.LittleEndianOutputStream']]"
		[Register ("write", "(Lnet/sf/image4j/io/LittleEndianOutputStream;)V", "GetWrite_Lnet_sf_image4j_io_LittleEndianOutputStream_Handler")]
		public virtual unsafe void Write (global::Net.SF.Image4j.IO.LittleEndianOutputStream p0)
		{
			if (id_write_Lnet_sf_image4j_io_LittleEndianOutputStream_ == IntPtr.Zero)
				id_write_Lnet_sf_image4j_io_LittleEndianOutputStream_ = JNIEnv.GetMethodID (class_ref, "write", "(Lnet/sf/image4j/io/LittleEndianOutputStream;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_write_Lnet_sf_image4j_io_LittleEndianOutputStream_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "write", "(Lnet/sf/image4j/io/LittleEndianOutputStream;)V"), __args);
			} finally {
			}
		}

	}
}
