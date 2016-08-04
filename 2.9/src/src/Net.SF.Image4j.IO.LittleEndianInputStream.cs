using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Net.SF.Image4j.IO {

	// Metadata.xml XPath class reference: path="/api/package[@name='net.sf.image4j.io']/class[@name='LittleEndianInputStream']"
	[global::Android.Runtime.Register ("net/sf/image4j/io/LittleEndianInputStream", DoNotGenerateAcw=true)]
	public partial class LittleEndianInputStream : global::Java.IO.DataInputStream {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("net/sf/image4j/io/LittleEndianInputStream", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LittleEndianInputStream); }
		}

		protected LittleEndianInputStream (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_io_InputStream_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='net.sf.image4j.io']/class[@name='LittleEndianInputStream']/constructor[@name='LittleEndianInputStream' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register (".ctor", "(Ljava/io/InputStream;)V", "")]
		public unsafe LittleEndianInputStream (global::System.IO.Stream p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (LittleEndianInputStream)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/io/InputStream;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/io/InputStream;)V", __args);
					return;
				}

				if (id_ctor_Ljava_io_InputStream_ == IntPtr.Zero)
					id_ctor_Ljava_io_InputStream_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/io/InputStream;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_io_InputStream_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_io_InputStream_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_readDoubleLE;
#pragma warning disable 0169
		static Delegate GetReadDoubleLEHandler ()
		{
			if (cb_readDoubleLE == null)
				cb_readDoubleLE = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_ReadDoubleLE);
			return cb_readDoubleLE;
		}

		static double n_ReadDoubleLE (IntPtr jnienv, IntPtr native__this)
		{
			global::Net.SF.Image4j.IO.LittleEndianInputStream __this = global::Java.Lang.Object.GetObject<global::Net.SF.Image4j.IO.LittleEndianInputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ReadDoubleLE ();
		}
#pragma warning restore 0169

		static IntPtr id_readDoubleLE;
		// Metadata.xml XPath method reference: path="/api/package[@name='net.sf.image4j.io']/class[@name='LittleEndianInputStream']/method[@name='readDoubleLE' and count(parameter)=0]"
		[Register ("readDoubleLE", "()D", "GetReadDoubleLEHandler")]
		public virtual unsafe double ReadDoubleLE ()
		{
			if (id_readDoubleLE == IntPtr.Zero)
				id_readDoubleLE = JNIEnv.GetMethodID (class_ref, "readDoubleLE", "()D");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallDoubleMethod  (Handle, id_readDoubleLE);
				else
					return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "readDoubleLE", "()D"));
			} finally {
			}
		}

		static Delegate cb_readFloatLE;
#pragma warning disable 0169
		static Delegate GetReadFloatLEHandler ()
		{
			if (cb_readFloatLE == null)
				cb_readFloatLE = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_ReadFloatLE);
			return cb_readFloatLE;
		}

		static float n_ReadFloatLE (IntPtr jnienv, IntPtr native__this)
		{
			global::Net.SF.Image4j.IO.LittleEndianInputStream __this = global::Java.Lang.Object.GetObject<global::Net.SF.Image4j.IO.LittleEndianInputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ReadFloatLE ();
		}
#pragma warning restore 0169

		static IntPtr id_readFloatLE;
		// Metadata.xml XPath method reference: path="/api/package[@name='net.sf.image4j.io']/class[@name='LittleEndianInputStream']/method[@name='readFloatLE' and count(parameter)=0]"
		[Register ("readFloatLE", "()F", "GetReadFloatLEHandler")]
		public virtual unsafe float ReadFloatLE ()
		{
			if (id_readFloatLE == IntPtr.Zero)
				id_readFloatLE = JNIEnv.GetMethodID (class_ref, "readFloatLE", "()F");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallFloatMethod  (Handle, id_readFloatLE);
				else
					return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "readFloatLE", "()F"));
			} finally {
			}
		}

		static Delegate cb_readIntLE;
#pragma warning disable 0169
		static Delegate GetReadIntLEHandler ()
		{
			if (cb_readIntLE == null)
				cb_readIntLE = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_ReadIntLE);
			return cb_readIntLE;
		}

		static int n_ReadIntLE (IntPtr jnienv, IntPtr native__this)
		{
			global::Net.SF.Image4j.IO.LittleEndianInputStream __this = global::Java.Lang.Object.GetObject<global::Net.SF.Image4j.IO.LittleEndianInputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ReadIntLE ();
		}
#pragma warning restore 0169

		static IntPtr id_readIntLE;
		// Metadata.xml XPath method reference: path="/api/package[@name='net.sf.image4j.io']/class[@name='LittleEndianInputStream']/method[@name='readIntLE' and count(parameter)=0]"
		[Register ("readIntLE", "()I", "GetReadIntLEHandler")]
		public virtual unsafe int ReadIntLE ()
		{
			if (id_readIntLE == IntPtr.Zero)
				id_readIntLE = JNIEnv.GetMethodID (class_ref, "readIntLE", "()I");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_readIntLE);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "readIntLE", "()I"));
			} finally {
			}
		}

		static Delegate cb_readLongLE;
#pragma warning disable 0169
		static Delegate GetReadLongLEHandler ()
		{
			if (cb_readLongLE == null)
				cb_readLongLE = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_ReadLongLE);
			return cb_readLongLE;
		}

		static long n_ReadLongLE (IntPtr jnienv, IntPtr native__this)
		{
			global::Net.SF.Image4j.IO.LittleEndianInputStream __this = global::Java.Lang.Object.GetObject<global::Net.SF.Image4j.IO.LittleEndianInputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ReadLongLE ();
		}
#pragma warning restore 0169

		static IntPtr id_readLongLE;
		// Metadata.xml XPath method reference: path="/api/package[@name='net.sf.image4j.io']/class[@name='LittleEndianInputStream']/method[@name='readLongLE' and count(parameter)=0]"
		[Register ("readLongLE", "()J", "GetReadLongLEHandler")]
		public virtual unsafe long ReadLongLE ()
		{
			if (id_readLongLE == IntPtr.Zero)
				id_readLongLE = JNIEnv.GetMethodID (class_ref, "readLongLE", "()J");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallLongMethod  (Handle, id_readLongLE);
				else
					return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "readLongLE", "()J"));
			} finally {
			}
		}

		static Delegate cb_readShortLE;
#pragma warning disable 0169
		static Delegate GetReadShortLEHandler ()
		{
			if (cb_readShortLE == null)
				cb_readShortLE = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, short>) n_ReadShortLE);
			return cb_readShortLE;
		}

		static short n_ReadShortLE (IntPtr jnienv, IntPtr native__this)
		{
			global::Net.SF.Image4j.IO.LittleEndianInputStream __this = global::Java.Lang.Object.GetObject<global::Net.SF.Image4j.IO.LittleEndianInputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ReadShortLE ();
		}
#pragma warning restore 0169

		static IntPtr id_readShortLE;
		// Metadata.xml XPath method reference: path="/api/package[@name='net.sf.image4j.io']/class[@name='LittleEndianInputStream']/method[@name='readShortLE' and count(parameter)=0]"
		[Register ("readShortLE", "()S", "GetReadShortLEHandler")]
		public virtual unsafe short ReadShortLE ()
		{
			if (id_readShortLE == IntPtr.Zero)
				id_readShortLE = JNIEnv.GetMethodID (class_ref, "readShortLE", "()S");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallShortMethod  (Handle, id_readShortLE);
				else
					return JNIEnv.CallNonvirtualShortMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "readShortLE", "()S"));
			} finally {
			}
		}

		static Delegate cb_readUnsignedInt;
#pragma warning disable 0169
		static Delegate GetReadUnsignedIntHandler ()
		{
			if (cb_readUnsignedInt == null)
				cb_readUnsignedInt = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_ReadUnsignedInt);
			return cb_readUnsignedInt;
		}

		static long n_ReadUnsignedInt (IntPtr jnienv, IntPtr native__this)
		{
			global::Net.SF.Image4j.IO.LittleEndianInputStream __this = global::Java.Lang.Object.GetObject<global::Net.SF.Image4j.IO.LittleEndianInputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ReadUnsignedInt ();
		}
#pragma warning restore 0169

		static IntPtr id_readUnsignedInt;
		// Metadata.xml XPath method reference: path="/api/package[@name='net.sf.image4j.io']/class[@name='LittleEndianInputStream']/method[@name='readUnsignedInt' and count(parameter)=0]"
		[Register ("readUnsignedInt", "()J", "GetReadUnsignedIntHandler")]
		public virtual unsafe long ReadUnsignedInt ()
		{
			if (id_readUnsignedInt == IntPtr.Zero)
				id_readUnsignedInt = JNIEnv.GetMethodID (class_ref, "readUnsignedInt", "()J");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallLongMethod  (Handle, id_readUnsignedInt);
				else
					return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "readUnsignedInt", "()J"));
			} finally {
			}
		}

		static Delegate cb_readUnsignedIntLE;
#pragma warning disable 0169
		static Delegate GetReadUnsignedIntLEHandler ()
		{
			if (cb_readUnsignedIntLE == null)
				cb_readUnsignedIntLE = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_ReadUnsignedIntLE);
			return cb_readUnsignedIntLE;
		}

		static long n_ReadUnsignedIntLE (IntPtr jnienv, IntPtr native__this)
		{
			global::Net.SF.Image4j.IO.LittleEndianInputStream __this = global::Java.Lang.Object.GetObject<global::Net.SF.Image4j.IO.LittleEndianInputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ReadUnsignedIntLE ();
		}
#pragma warning restore 0169

		static IntPtr id_readUnsignedIntLE;
		// Metadata.xml XPath method reference: path="/api/package[@name='net.sf.image4j.io']/class[@name='LittleEndianInputStream']/method[@name='readUnsignedIntLE' and count(parameter)=0]"
		[Register ("readUnsignedIntLE", "()J", "GetReadUnsignedIntLEHandler")]
		public virtual unsafe long ReadUnsignedIntLE ()
		{
			if (id_readUnsignedIntLE == IntPtr.Zero)
				id_readUnsignedIntLE = JNIEnv.GetMethodID (class_ref, "readUnsignedIntLE", "()J");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallLongMethod  (Handle, id_readUnsignedIntLE);
				else
					return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "readUnsignedIntLE", "()J"));
			} finally {
			}
		}

	}
}
