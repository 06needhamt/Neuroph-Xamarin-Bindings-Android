using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Encog.Engine.Data {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.encog.engine.data']/interface[@name='EngineData']"
	[Register ("org/encog/engine/data/EngineData", "", "Org.Encog.Engine.Data.IEngineDataInvoker")]
	public partial interface IEngineData : IJavaObject {

		bool IsSupervised {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.data']/interface[@name='EngineData']/method[@name='isSupervised' and count(parameter)=0]"
			[Register ("isSupervised", "()Z", "GetIsSupervisedHandler:Org.Encog.Engine.Data.IEngineDataInvoker, neuroph_2.5RC2")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.data']/interface[@name='EngineData']/method[@name='getIdealArray' and count(parameter)=0]"
		[Register ("getIdealArray", "()[D", "GetGetIdealArrayHandler:Org.Encog.Engine.Data.IEngineDataInvoker, neuroph_2.5RC2")]
		double[] GetIdealArray ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.data']/interface[@name='EngineData']/method[@name='getInputArray' and count(parameter)=0]"
		[Register ("getInputArray", "()[D", "GetGetInputArrayHandler:Org.Encog.Engine.Data.IEngineDataInvoker, neuroph_2.5RC2")]
		double[] GetInputArray ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.data']/interface[@name='EngineData']/method[@name='setIdealArray' and count(parameter)=1 and parameter[1][@type='double[]']]"
		[Register ("setIdealArray", "([D)V", "GetSetIdealArray_arrayDHandler:Org.Encog.Engine.Data.IEngineDataInvoker, neuroph_2.5RC2")]
		void SetIdealArray (double[] p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.data']/interface[@name='EngineData']/method[@name='setInputArray' and count(parameter)=1 and parameter[1][@type='double[]']]"
		[Register ("setInputArray", "([D)V", "GetSetInputArray_arrayDHandler:Org.Encog.Engine.Data.IEngineDataInvoker, neuroph_2.5RC2")]
		void SetInputArray (double[] p0);

	}

	[global::Android.Runtime.Register ("org/encog/engine/data/EngineData", DoNotGenerateAcw=true)]
	internal class IEngineDataInvoker : global::Java.Lang.Object, IEngineData {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/encog/engine/data/EngineData");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IEngineDataInvoker); }
		}

		IntPtr class_ref;

		public static IEngineData GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IEngineData> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.encog.engine.data.EngineData"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IEngineDataInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Org.Encog.Engine.Data.IEngineData __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Data.IEngineData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSupervised;
		}
#pragma warning restore 0169

		IntPtr id_isSupervised;
		public unsafe bool IsSupervised {
			get {
				if (id_isSupervised == IntPtr.Zero)
					id_isSupervised = JNIEnv.GetMethodID (class_ref, "isSupervised", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_isSupervised);
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
			global::Org.Encog.Engine.Data.IEngineData __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Data.IEngineData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetIdealArray ());
		}
#pragma warning restore 0169

		IntPtr id_getIdealArray;
		public unsafe double[] GetIdealArray ()
		{
			if (id_getIdealArray == IntPtr.Zero)
				id_getIdealArray = JNIEnv.GetMethodID (class_ref, "getIdealArray", "()[D");
			return (double[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (Handle, id_getIdealArray), JniHandleOwnership.TransferLocalRef, typeof (double));
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
			global::Org.Encog.Engine.Data.IEngineData __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Data.IEngineData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetInputArray ());
		}
#pragma warning restore 0169

		IntPtr id_getInputArray;
		public unsafe double[] GetInputArray ()
		{
			if (id_getInputArray == IntPtr.Zero)
				id_getInputArray = JNIEnv.GetMethodID (class_ref, "getInputArray", "()[D");
			return (double[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (Handle, id_getInputArray), JniHandleOwnership.TransferLocalRef, typeof (double));
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
			global::Org.Encog.Engine.Data.IEngineData __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Data.IEngineData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			double[] p0 = (double[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (double));
			__this.SetIdealArray (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		IntPtr id_setIdealArray_arrayD;
		public unsafe void SetIdealArray (double[] p0)
		{
			if (id_setIdealArray_arrayD == IntPtr.Zero)
				id_setIdealArray_arrayD = JNIEnv.GetMethodID (class_ref, "setIdealArray", "([D)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (Handle, id_setIdealArray_arrayD, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
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
			global::Org.Encog.Engine.Data.IEngineData __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Data.IEngineData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			double[] p0 = (double[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (double));
			__this.SetInputArray (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		IntPtr id_setInputArray_arrayD;
		public unsafe void SetInputArray (double[] p0)
		{
			if (id_setInputArray_arrayD == IntPtr.Zero)
				id_setInputArray_arrayD = JNIEnv.GetMethodID (class_ref, "setInputArray", "([D)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (Handle, id_setInputArray_arrayD, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}

}
