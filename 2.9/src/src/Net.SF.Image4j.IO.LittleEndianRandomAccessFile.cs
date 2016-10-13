using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Net.SF.Image4j.IO {

	// Metadata.xml XPath class reference: path="/api/package[@name='net.sf.image4j.io']/class[@name='LittleEndianRandomAccessFile']"
	[global::Android.Runtime.Register ("net/sf/image4j/io/LittleEndianRandomAccessFile", DoNotGenerateAcw=true)]
	public partial class LittleEndianRandomAccessFile : global::Java.IO.RandomAccessFile {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("net/sf/image4j/io/LittleEndianRandomAccessFile", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LittleEndianRandomAccessFile); }
		}

		protected LittleEndianRandomAccessFile (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_io_File_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='net.sf.image4j.io']/class[@name='LittleEndianRandomAccessFile']/constructor[@name='LittleEndianRandomAccessFile' and count(parameter)=2 and parameter[1][@type='java.io.File'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/io/File;Ljava/lang/String;)V", "")]
		public unsafe LittleEndianRandomAccessFile (global::Java.IO.File p0, string p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				if (GetType () != typeof (LittleEndianRandomAccessFile)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/io/File;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/io/File;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_io_File_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_io_File_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/io/File;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_io_File_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_io_File_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='net.sf.image4j.io']/class[@name='LittleEndianRandomAccessFile']/constructor[@name='LittleEndianRandomAccessFile' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe LittleEndianRandomAccessFile (string p0, string p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				if (GetType () != typeof (LittleEndianRandomAccessFile)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
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
			global::Net.SF.Image4j.IO.LittleEndianRandomAccessFile __this = global::Java.Lang.Object.GetObject<global::Net.SF.Image4j.IO.LittleEndianRandomAccessFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ReadDoubleLE ();
		}
#pragma warning restore 0169

		static IntPtr id_readDoubleLE;
		// Metadata.xml XPath method reference: path="/api/package[@name='net.sf.image4j.io']/class[@name='LittleEndianRandomAccessFile']/method[@name='readDoubleLE' and count(parameter)=0]"
		[Register ("readDoubleLE", "()D", "GetReadDoubleLEHandler")]
		public virtual unsafe double ReadDoubleLE ()
		{
			if (id_readDoubleLE == IntPtr.Zero)
				id_readDoubleLE = JNIEnv.GetMethodID (class_ref, "readDoubleLE", "()D");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_readDoubleLE);
				else
					return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "readDoubleLE", "()D"));
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
			global::Net.SF.Image4j.IO.LittleEndianRandomAccessFile __this = global::Java.Lang.Object.GetObject<global::Net.SF.Image4j.IO.LittleEndianRandomAccessFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ReadFloatLE ();
		}
#pragma warning restore 0169

		static IntPtr id_readFloatLE;
		// Metadata.xml XPath method reference: path="/api/package[@name='net.sf.image4j.io']/class[@name='LittleEndianRandomAccessFile']/method[@name='readFloatLE' and count(parameter)=0]"
		[Register ("readFloatLE", "()F", "GetReadFloatLEHandler")]
		public virtual unsafe float ReadFloatLE ()
		{
			if (id_readFloatLE == IntPtr.Zero)
				id_readFloatLE = JNIEnv.GetMethodID (class_ref, "readFloatLE", "()F");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_readFloatLE);
				else
					return JNIEnv.CallNonvirtualFloatMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "readFloatLE", "()F"));
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
			global::Net.SF.Image4j.IO.LittleEndianRandomAccessFile __this = global::Java.Lang.Object.GetObject<global::Net.SF.Image4j.IO.LittleEndianRandomAccessFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ReadIntLE ();
		}
#pragma warning restore 0169

		static IntPtr id_readIntLE;
		// Metadata.xml XPath method reference: path="/api/package[@name='net.sf.image4j.io']/class[@name='LittleEndianRandomAccessFile']/method[@name='readIntLE' and count(parameter)=0]"
		[Register ("readIntLE", "()I", "GetReadIntLEHandler")]
		public virtual unsafe int ReadIntLE ()
		{
			if (id_readIntLE == IntPtr.Zero)
				id_readIntLE = JNIEnv.GetMethodID (class_ref, "readIntLE", "()I");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_readIntLE);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "readIntLE", "()I"));
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
			global::Net.SF.Image4j.IO.LittleEndianRandomAccessFile __this = global::Java.Lang.Object.GetObject<global::Net.SF.Image4j.IO.LittleEndianRandomAccessFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ReadLongLE ();
		}
#pragma warning restore 0169

		static IntPtr id_readLongLE;
		// Metadata.xml XPath method reference: path="/api/package[@name='net.sf.image4j.io']/class[@name='LittleEndianRandomAccessFile']/method[@name='readLongLE' and count(parameter)=0]"
		[Register ("readLongLE", "()J", "GetReadLongLEHandler")]
		public virtual unsafe long ReadLongLE ()
		{
			if (id_readLongLE == IntPtr.Zero)
				id_readLongLE = JNIEnv.GetMethodID (class_ref, "readLongLE", "()J");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_readLongLE);
				else
					return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "readLongLE", "()J"));
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
			global::Net.SF.Image4j.IO.LittleEndianRandomAccessFile __this = global::Java.Lang.Object.GetObject<global::Net.SF.Image4j.IO.LittleEndianRandomAccessFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ReadShortLE ();
		}
#pragma warning restore 0169

		static IntPtr id_readShortLE;
		// Metadata.xml XPath method reference: path="/api/package[@name='net.sf.image4j.io']/class[@name='LittleEndianRandomAccessFile']/method[@name='readShortLE' and count(parameter)=0]"
		[Register ("readShortLE", "()S", "GetReadShortLEHandler")]
		public virtual unsafe short ReadShortLE ()
		{
			if (id_readShortLE == IntPtr.Zero)
				id_readShortLE = JNIEnv.GetMethodID (class_ref, "readShortLE", "()S");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallShortMethod (((global::Java.Lang.Object) this).Handle, id_readShortLE);
				else
					return JNIEnv.CallNonvirtualShortMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "readShortLE", "()S"));
			} finally {
			}
		}

		static Delegate cb_writeDoubleLE_D;
#pragma warning disable 0169
		static Delegate GetWriteDoubleLE_DHandler ()
		{
			if (cb_writeDoubleLE_D == null)
				cb_writeDoubleLE_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_WriteDoubleLE_D);
			return cb_writeDoubleLE_D;
		}

		static void n_WriteDoubleLE_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Net.SF.Image4j.IO.LittleEndianRandomAccessFile __this = global::Java.Lang.Object.GetObject<global::Net.SF.Image4j.IO.LittleEndianRandomAccessFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WriteDoubleLE (p0);
		}
#pragma warning restore 0169

		static IntPtr id_writeDoubleLE_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='net.sf.image4j.io']/class[@name='LittleEndianRandomAccessFile']/method[@name='writeDoubleLE' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("writeDoubleLE", "(D)V", "GetWriteDoubleLE_DHandler")]
		public virtual unsafe void WriteDoubleLE (double p0)
		{
			if (id_writeDoubleLE_D == IntPtr.Zero)
				id_writeDoubleLE_D = JNIEnv.GetMethodID (class_ref, "writeDoubleLE", "(D)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_writeDoubleLE_D, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeDoubleLE", "(D)V"), __args);
			} finally {
			}
		}

		static Delegate cb_writeFloatLE_F;
#pragma warning disable 0169
		static Delegate GetWriteFloatLE_FHandler ()
		{
			if (cb_writeFloatLE_F == null)
				cb_writeFloatLE_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_WriteFloatLE_F);
			return cb_writeFloatLE_F;
		}

		static void n_WriteFloatLE_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Net.SF.Image4j.IO.LittleEndianRandomAccessFile __this = global::Java.Lang.Object.GetObject<global::Net.SF.Image4j.IO.LittleEndianRandomAccessFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WriteFloatLE (p0);
		}
#pragma warning restore 0169

		static IntPtr id_writeFloatLE_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='net.sf.image4j.io']/class[@name='LittleEndianRandomAccessFile']/method[@name='writeFloatLE' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("writeFloatLE", "(F)V", "GetWriteFloatLE_FHandler")]
		public virtual unsafe void WriteFloatLE (float p0)
		{
			if (id_writeFloatLE_F == IntPtr.Zero)
				id_writeFloatLE_F = JNIEnv.GetMethodID (class_ref, "writeFloatLE", "(F)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_writeFloatLE_F, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeFloatLE", "(F)V"), __args);
			} finally {
			}
		}

		static Delegate cb_writeIntLE_I;
#pragma warning disable 0169
		static Delegate GetWriteIntLE_IHandler ()
		{
			if (cb_writeIntLE_I == null)
				cb_writeIntLE_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_WriteIntLE_I);
			return cb_writeIntLE_I;
		}

		static void n_WriteIntLE_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Net.SF.Image4j.IO.LittleEndianRandomAccessFile __this = global::Java.Lang.Object.GetObject<global::Net.SF.Image4j.IO.LittleEndianRandomAccessFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WriteIntLE (p0);
		}
#pragma warning restore 0169

		static IntPtr id_writeIntLE_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='net.sf.image4j.io']/class[@name='LittleEndianRandomAccessFile']/method[@name='writeIntLE' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("writeIntLE", "(I)V", "GetWriteIntLE_IHandler")]
		public virtual unsafe void WriteIntLE (int p0)
		{
			if (id_writeIntLE_I == IntPtr.Zero)
				id_writeIntLE_I = JNIEnv.GetMethodID (class_ref, "writeIntLE", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_writeIntLE_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeIntLE", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_writeLongLE_J;
#pragma warning disable 0169
		static Delegate GetWriteLongLE_JHandler ()
		{
			if (cb_writeLongLE_J == null)
				cb_writeLongLE_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_WriteLongLE_J);
			return cb_writeLongLE_J;
		}

		static void n_WriteLongLE_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Net.SF.Image4j.IO.LittleEndianRandomAccessFile __this = global::Java.Lang.Object.GetObject<global::Net.SF.Image4j.IO.LittleEndianRandomAccessFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WriteLongLE (p0);
		}
#pragma warning restore 0169

		static IntPtr id_writeLongLE_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='net.sf.image4j.io']/class[@name='LittleEndianRandomAccessFile']/method[@name='writeLongLE' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("writeLongLE", "(J)V", "GetWriteLongLE_JHandler")]
		public virtual unsafe void WriteLongLE (long p0)
		{
			if (id_writeLongLE_J == IntPtr.Zero)
				id_writeLongLE_J = JNIEnv.GetMethodID (class_ref, "writeLongLE", "(J)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_writeLongLE_J, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeLongLE", "(J)V"), __args);
			} finally {
			}
		}

		static Delegate cb_writeShortLE_S;
#pragma warning disable 0169
		static Delegate GetWriteShortLE_SHandler ()
		{
			if (cb_writeShortLE_S == null)
				cb_writeShortLE_S = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, short>) n_WriteShortLE_S);
			return cb_writeShortLE_S;
		}

		static void n_WriteShortLE_S (IntPtr jnienv, IntPtr native__this, short p0)
		{
			global::Net.SF.Image4j.IO.LittleEndianRandomAccessFile __this = global::Java.Lang.Object.GetObject<global::Net.SF.Image4j.IO.LittleEndianRandomAccessFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WriteShortLE (p0);
		}
#pragma warning restore 0169

		static IntPtr id_writeShortLE_S;
		// Metadata.xml XPath method reference: path="/api/package[@name='net.sf.image4j.io']/class[@name='LittleEndianRandomAccessFile']/method[@name='writeShortLE' and count(parameter)=1 and parameter[1][@type='short']]"
		[Register ("writeShortLE", "(S)V", "GetWriteShortLE_SHandler")]
		public virtual unsafe void WriteShortLE (short p0)
		{
			if (id_writeShortLE_S == IntPtr.Zero)
				id_writeShortLE_S = JNIEnv.GetMethodID (class_ref, "writeShortLE", "(S)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_writeShortLE_S, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeShortLE", "(S)V"), __args);
			} finally {
			}
		}

	}
}
