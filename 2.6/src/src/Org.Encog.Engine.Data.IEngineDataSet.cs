using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Encog.Engine.Data {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.encog.engine.data']/interface[@name='EngineDataSet']"
	[Register ("org/encog/engine/data/EngineDataSet", "", "Org.Encog.Engine.Data.IEngineDataSetInvoker")]
	public partial interface IEngineDataSet : IJavaObject {

		int IdealSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.data']/interface[@name='EngineDataSet']/method[@name='getIdealSize' and count(parameter)=0]"
			[Register ("getIdealSize", "()I", "GetGetIdealSizeHandler:Org.Encog.Engine.Data.IEngineDataSetInvoker, Neuroph_2.6")] get;
		}

		int InputSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.data']/interface[@name='EngineDataSet']/method[@name='getInputSize' and count(parameter)=0]"
			[Register ("getInputSize", "()I", "GetGetInputSizeHandler:Org.Encog.Engine.Data.IEngineDataSetInvoker, Neuroph_2.6")] get;
		}

		bool IsSupervised {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.data']/interface[@name='EngineDataSet']/method[@name='isSupervised' and count(parameter)=0]"
			[Register ("isSupervised", "()Z", "GetIsSupervisedHandler:Org.Encog.Engine.Data.IEngineDataSetInvoker, Neuroph_2.6")] get;
		}

	}

	[global::Android.Runtime.Register ("org/encog/engine/data/EngineDataSet", DoNotGenerateAcw=true)]
	internal class IEngineDataSetInvoker : global::Java.Lang.Object, IEngineDataSet {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/encog/engine/data/EngineDataSet");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IEngineDataSetInvoker); }
		}

		IntPtr class_ref;

		public static IEngineDataSet GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IEngineDataSet> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.encog.engine.data.EngineDataSet"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IEngineDataSetInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getIdealSize;
#pragma warning disable 0169
		static Delegate GetGetIdealSizeHandler ()
		{
			if (cb_getIdealSize == null)
				cb_getIdealSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetIdealSize);
			return cb_getIdealSize;
		}

		static int n_GetIdealSize (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Data.IEngineDataSet __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Data.IEngineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IdealSize;
		}
#pragma warning restore 0169

		IntPtr id_getIdealSize;
		public unsafe int IdealSize {
			get {
				if (id_getIdealSize == IntPtr.Zero)
					id_getIdealSize = JNIEnv.GetMethodID (class_ref, "getIdealSize", "()I");
				return JNIEnv.CallIntMethod (Handle, id_getIdealSize);
			}
		}

		static Delegate cb_getInputSize;
#pragma warning disable 0169
		static Delegate GetGetInputSizeHandler ()
		{
			if (cb_getInputSize == null)
				cb_getInputSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetInputSize);
			return cb_getInputSize;
		}

		static int n_GetInputSize (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Data.IEngineDataSet __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Data.IEngineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.InputSize;
		}
#pragma warning restore 0169

		IntPtr id_getInputSize;
		public unsafe int InputSize {
			get {
				if (id_getInputSize == IntPtr.Zero)
					id_getInputSize = JNIEnv.GetMethodID (class_ref, "getInputSize", "()I");
				return JNIEnv.CallIntMethod (Handle, id_getInputSize);
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
			global::Org.Encog.Engine.Data.IEngineDataSet __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Data.IEngineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

	}

}
