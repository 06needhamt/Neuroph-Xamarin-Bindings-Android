using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Encog.Engine.Data {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.encog.engine.data']/class[@name='BasicEngineData']"
	[global::Android.Runtime.Register ("org/encog/engine/data/BasicEngineData", DoNotGenerateAcw=true)]
	public partial class BasicEngineData : global::Java.Lang.Object, global::Java.IO.ISerializable, global::Org.Encog.Engine.Data.IEngineData {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/encog/engine/data/BasicEngineData", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BasicEngineData); }
		}

		protected BasicEngineData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_arrayDarrayD;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.encog.engine.data']/class[@name='BasicEngineData']/constructor[@name='BasicEngineData' and count(parameter)=2 and parameter[1][@type='double[]'] and parameter[2][@type='double[]']]"
		[Register (".ctor", "([D[D)V", "")]
		public unsafe BasicEngineData (double[] p0, double[] p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				if (GetType () != typeof (BasicEngineData)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "([D[D)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "([D[D)V", __args);
					return;
				}

				if (id_ctor_arrayDarrayD == IntPtr.Zero)
					id_ctor_arrayDarrayD = JNIEnv.GetMethodID (class_ref, "<init>", "([D[D)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayDarrayD, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_arrayDarrayD, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static IntPtr id_ctor_arrayD;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.encog.engine.data']/class[@name='BasicEngineData']/constructor[@name='BasicEngineData' and count(parameter)=1 and parameter[1][@type='double[]']]"
		[Register (".ctor", "([D)V", "")]
		public unsafe BasicEngineData (double[] p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (BasicEngineData)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "([D)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "([D)V", __args);
					return;
				}

				if (id_ctor_arrayD == IntPtr.Zero)
					id_ctor_arrayD = JNIEnv.GetMethodID (class_ref, "<init>", "([D)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayD, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_arrayD, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
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
			global::Org.Encog.Engine.Data.BasicEngineData __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Data.BasicEngineData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSupervised;
		}
#pragma warning restore 0169

		static IntPtr id_isSupervised;
		public virtual unsafe bool IsSupervised {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.data']/class[@name='BasicEngineData']/method[@name='isSupervised' and count(parameter)=0]"
			[Register ("isSupervised", "()Z", "GetIsSupervisedHandler")]
			get {
				if (id_isSupervised == IntPtr.Zero)
					id_isSupervised = JNIEnv.GetMethodID (class_ref, "isSupervised", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isSupervised);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isSupervised", "()Z"));
				} finally {
				}
			}
		}

		static IntPtr id_createPair_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.data']/class[@name='BasicEngineData']/method[@name='createPair' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("createPair", "(II)Lorg/encog/engine/data/EngineData;", "")]
		public static unsafe global::Org.Encog.Engine.Data.IEngineData CreatePair (int p0, int p1)
		{
			if (id_createPair_II == IntPtr.Zero)
				id_createPair_II = JNIEnv.GetStaticMethodID (class_ref, "createPair", "(II)Lorg/encog/engine/data/EngineData;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Data.IEngineData> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createPair_II, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getIdealArray;
#pragma warning disable 0169
		static Delegate GetGetIdealArrayHandler ()
		{
			if (cb_getIdealArray == null)
				cb_getIdealArray = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIdealArray);
			return cb_getIdealArray;
		}

		static IntPtr n_GetIdealArray (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Data.BasicEngineData __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Data.BasicEngineData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetIdealArray ());
		}
#pragma warning restore 0169

		static IntPtr id_getIdealArray;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.data']/class[@name='BasicEngineData']/method[@name='getIdealArray' and count(parameter)=0]"
		[Register ("getIdealArray", "()[D", "GetGetIdealArrayHandler")]
		public virtual unsafe double[] GetIdealArray ()
		{
			if (id_getIdealArray == IntPtr.Zero)
				id_getIdealArray = JNIEnv.GetMethodID (class_ref, "getIdealArray", "()[D");
			try {

				if (GetType () == ThresholdType)
					return (double[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getIdealArray), JniHandleOwnership.TransferLocalRef, typeof (double));
				else
					return (double[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIdealArray", "()[D")), JniHandleOwnership.TransferLocalRef, typeof (double));
			} finally {
			}
		}

		static Delegate cb_getInputArray;
#pragma warning disable 0169
		static Delegate GetGetInputArrayHandler ()
		{
			if (cb_getInputArray == null)
				cb_getInputArray = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetInputArray);
			return cb_getInputArray;
		}

		static IntPtr n_GetInputArray (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Data.BasicEngineData __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Data.BasicEngineData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetInputArray ());
		}
#pragma warning restore 0169

		static IntPtr id_getInputArray;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.data']/class[@name='BasicEngineData']/method[@name='getInputArray' and count(parameter)=0]"
		[Register ("getInputArray", "()[D", "GetGetInputArrayHandler")]
		public virtual unsafe double[] GetInputArray ()
		{
			if (id_getInputArray == IntPtr.Zero)
				id_getInputArray = JNIEnv.GetMethodID (class_ref, "getInputArray", "()[D");
			try {

				if (GetType () == ThresholdType)
					return (double[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getInputArray), JniHandleOwnership.TransferLocalRef, typeof (double));
				else
					return (double[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getInputArray", "()[D")), JniHandleOwnership.TransferLocalRef, typeof (double));
			} finally {
			}
		}

		static Delegate cb_setIdealArray_arrayD;
#pragma warning disable 0169
		static Delegate GetSetIdealArray_arrayDHandler ()
		{
			if (cb_setIdealArray_arrayD == null)
				cb_setIdealArray_arrayD = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetIdealArray_arrayD);
			return cb_setIdealArray_arrayD;
		}

		static void n_SetIdealArray_arrayD (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Encog.Engine.Data.BasicEngineData __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Data.BasicEngineData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			double[] p0 = (double[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (double));
			__this.SetIdealArray (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_setIdealArray_arrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.data']/class[@name='BasicEngineData']/method[@name='setIdealArray' and count(parameter)=1 and parameter[1][@type='double[]']]"
		[Register ("setIdealArray", "([D)V", "GetSetIdealArray_arrayDHandler")]
		public virtual unsafe void SetIdealArray (double[] p0)
		{
			if (id_setIdealArray_arrayD == IntPtr.Zero)
				id_setIdealArray_arrayD = JNIEnv.GetMethodID (class_ref, "setIdealArray", "([D)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setIdealArray_arrayD, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setIdealArray", "([D)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_setInputArray_arrayD;
#pragma warning disable 0169
		static Delegate GetSetInputArray_arrayDHandler ()
		{
			if (cb_setInputArray_arrayD == null)
				cb_setInputArray_arrayD = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetInputArray_arrayD);
			return cb_setInputArray_arrayD;
		}

		static void n_SetInputArray_arrayD (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Encog.Engine.Data.BasicEngineData __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Data.BasicEngineData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			double[] p0 = (double[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (double));
			__this.SetInputArray (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_setInputArray_arrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.data']/class[@name='BasicEngineData']/method[@name='setInputArray' and count(parameter)=1 and parameter[1][@type='double[]']]"
		[Register ("setInputArray", "([D)V", "GetSetInputArray_arrayDHandler")]
		public virtual unsafe void SetInputArray (double[] p0)
		{
			if (id_setInputArray_arrayD == IntPtr.Zero)
				id_setInputArray_arrayD = JNIEnv.GetMethodID (class_ref, "setInputArray", "([D)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setInputArray_arrayD, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setInputArray", "([D)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

	}
}
