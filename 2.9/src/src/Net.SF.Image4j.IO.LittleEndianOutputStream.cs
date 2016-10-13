using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Net.SF.Image4j.IO {

	// Metadata.xml XPath class reference: path="/api/package[@name='net.sf.image4j.io']/class[@name='LittleEndianOutputStream']"
	[global::Android.Runtime.Register ("net/sf/image4j/io/LittleEndianOutputStream", DoNotGenerateAcw=true)]
	public partial class LittleEndianOutputStream : global::Java.IO.DataOutputStream {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("net/sf/image4j/io/LittleEndianOutputStream", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LittleEndianOutputStream); }
		}

		protected LittleEndianOutputStream (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_io_OutputStream_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='net.sf.image4j.io']/class[@name='LittleEndianOutputStream']/constructor[@name='LittleEndianOutputStream' and count(parameter)=1 and parameter[1][@type='java.io.OutputStream']]"
		[Register (".ctor", "(Ljava/io/OutputStream;)V", "")]
		public unsafe LittleEndianOutputStream (global::System.IO.Stream p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (LittleEndianOutputStream)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/io/OutputStream;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/io/OutputStream;)V", __args);
					return;
				}

				if (id_ctor_Ljava_io_OutputStream_ == IntPtr.Zero)
					id_ctor_Ljava_io_OutputStream_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/io/OutputStream;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_io_OutputStream_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_io_OutputStream_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
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
			global::Net.SF.Image4j.IO.LittleEndianOutputStream __this = global::Java.Lang.Object.GetObject<global::Net.SF.Image4j.IO.LittleEndianOutputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WriteDoubleLE (p0);
		}
#pragma warning restore 0169

		static IntPtr id_writeDoubleLE_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='net.sf.image4j.io']/class[@name='LittleEndianOutputStream']/method[@name='writeDoubleLE' and count(parameter)=1 and parameter[1][@type='double']]"
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
			global::Net.SF.Image4j.IO.LittleEndianOutputStream __this = global::Java.Lang.Object.GetObject<global::Net.SF.Image4j.IO.LittleEndianOutputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WriteFloatLE (p0);
		}
#pragma warning restore 0169

		static IntPtr id_writeFloatLE_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='net.sf.image4j.io']/class[@name='LittleEndianOutputStream']/method[@name='writeFloatLE' and count(parameter)=1 and parameter[1][@type='float']]"
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
			global::Net.SF.Image4j.IO.LittleEndianOutputStream __this = global::Java.Lang.Object.GetObject<global::Net.SF.Image4j.IO.LittleEndianOutputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WriteIntLE (p0);
		}
#pragma warning restore 0169

		static IntPtr id_writeIntLE_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='net.sf.image4j.io']/class[@name='LittleEndianOutputStream']/method[@name='writeIntLE' and count(parameter)=1 and parameter[1][@type='int']]"
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
			global::Net.SF.Image4j.IO.LittleEndianOutputStream __this = global::Java.Lang.Object.GetObject<global::Net.SF.Image4j.IO.LittleEndianOutputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WriteLongLE (p0);
		}
#pragma warning restore 0169

		static IntPtr id_writeLongLE_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='net.sf.image4j.io']/class[@name='LittleEndianOutputStream']/method[@name='writeLongLE' and count(parameter)=1 and parameter[1][@type='long']]"
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
			global::Net.SF.Image4j.IO.LittleEndianOutputStream __this = global::Java.Lang.Object.GetObject<global::Net.SF.Image4j.IO.LittleEndianOutputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WriteShortLE (p0);
		}
#pragma warning restore 0169

		static IntPtr id_writeShortLE_S;
		// Metadata.xml XPath method reference: path="/api/package[@name='net.sf.image4j.io']/class[@name='LittleEndianOutputStream']/method[@name='writeShortLE' and count(parameter)=1 and parameter[1][@type='short']]"
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

		static Delegate cb_writeUnsignedInt_J;
#pragma warning disable 0169
		static Delegate GetWriteUnsignedInt_JHandler ()
		{
			if (cb_writeUnsignedInt_J == null)
				cb_writeUnsignedInt_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_WriteUnsignedInt_J);
			return cb_writeUnsignedInt_J;
		}

		static void n_WriteUnsignedInt_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Net.SF.Image4j.IO.LittleEndianOutputStream __this = global::Java.Lang.Object.GetObject<global::Net.SF.Image4j.IO.LittleEndianOutputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WriteUnsignedInt (p0);
		}
#pragma warning restore 0169

		static IntPtr id_writeUnsignedInt_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='net.sf.image4j.io']/class[@name='LittleEndianOutputStream']/method[@name='writeUnsignedInt' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("writeUnsignedInt", "(J)V", "GetWriteUnsignedInt_JHandler")]
		public virtual unsafe void WriteUnsignedInt (long p0)
		{
			if (id_writeUnsignedInt_J == IntPtr.Zero)
				id_writeUnsignedInt_J = JNIEnv.GetMethodID (class_ref, "writeUnsignedInt", "(J)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_writeUnsignedInt_J, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeUnsignedInt", "(J)V"), __args);
			} finally {
			}
		}

		static Delegate cb_writeUnsignedIntLE_J;
#pragma warning disable 0169
		static Delegate GetWriteUnsignedIntLE_JHandler ()
		{
			if (cb_writeUnsignedIntLE_J == null)
				cb_writeUnsignedIntLE_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_WriteUnsignedIntLE_J);
			return cb_writeUnsignedIntLE_J;
		}

		static void n_WriteUnsignedIntLE_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Net.SF.Image4j.IO.LittleEndianOutputStream __this = global::Java.Lang.Object.GetObject<global::Net.SF.Image4j.IO.LittleEndianOutputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WriteUnsignedIntLE (p0);
		}
#pragma warning restore 0169

		static IntPtr id_writeUnsignedIntLE_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='net.sf.image4j.io']/class[@name='LittleEndianOutputStream']/method[@name='writeUnsignedIntLE' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("writeUnsignedIntLE", "(J)V", "GetWriteUnsignedIntLE_JHandler")]
		public virtual unsafe void WriteUnsignedIntLE (long p0)
		{
			if (id_writeUnsignedIntLE_J == IntPtr.Zero)
				id_writeUnsignedIntLE_J = JNIEnv.GetMethodID (class_ref, "writeUnsignedIntLE", "(J)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_writeUnsignedIntLE_J, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeUnsignedIntLE", "(J)V"), __args);
			} finally {
			}
		}

	}
}
