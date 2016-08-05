using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Encog.Engine.Data {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.encog.engine.data']/interface[@name='EngineIndexableSet']"
	[Register ("org/encog/engine/data/EngineIndexableSet", "", "Org.Encog.Engine.Data.IEngineIndexableSetInvoker")]
	public partial interface IEngineIndexableSet : global::Org.Encog.Engine.Data.IEngineDataSet {

		long RecordCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.data']/interface[@name='EngineIndexableSet']/method[@name='getRecordCount' and count(parameter)=0]"
			[Register ("getRecordCount", "()J", "GetGetRecordCountHandler:Org.Encog.Engine.Data.IEngineIndexableSetInvoker, neuroph_2.5RC2")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.data']/interface[@name='EngineIndexableSet']/method[@name='getRecord' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='org.encog.engine.data.EngineData']]"
		[Register ("getRecord", "(JLorg/encog/engine/data/EngineData;)V", "GetGetRecord_JLorg_encog_engine_data_EngineData_Handler:Org.Encog.Engine.Data.IEngineIndexableSetInvoker, neuroph_2.5RC2")]
		void GetRecord (long p0, global::Org.Encog.Engine.Data.IEngineData p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.data']/interface[@name='EngineIndexableSet']/method[@name='openAdditional' and count(parameter)=0]"
		[Register ("openAdditional", "()Lorg/encog/engine/data/EngineIndexableSet;", "GetOpenAdditionalHandler:Org.Encog.Engine.Data.IEngineIndexableSetInvoker, neuroph_2.5RC2")]
		global::Org.Encog.Engine.Data.IEngineIndexableSet OpenAdditional ();

	}

	[global::Android.Runtime.Register ("org/encog/engine/data/EngineIndexableSet", DoNotGenerateAcw=true)]
	internal class IEngineIndexableSetInvoker : global::Java.Lang.Object, IEngineIndexableSet {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/encog/engine/data/EngineIndexableSet");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IEngineIndexableSetInvoker); }
		}

		IntPtr class_ref;

		public static IEngineIndexableSet GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IEngineIndexableSet> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.encog.engine.data.EngineIndexableSet"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IEngineIndexableSetInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getRecordCount;
#pragma warning disable 0169
		static Delegate GetGetRecordCountHandler ()
		{
			if (cb_getRecordCount == null)
				cb_getRecordCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetRecordCount);
			return cb_getRecordCount;
		}

		static long n_GetRecordCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Data.IEngineIndexableSet __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Data.IEngineIndexableSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RecordCount;
		}
#pragma warning restore 0169

		IntPtr id_getRecordCount;
		public unsafe long RecordCount {
			get {
				if (id_getRecordCount == IntPtr.Zero)
					id_getRecordCount = JNIEnv.GetMethodID (class_ref, "getRecordCount", "()J");
				return JNIEnv.CallLongMethod (Handle, id_getRecordCount);
			}
		}

		static Delegate cb_getRecord_JLorg_encog_engine_data_EngineData_;
#pragma warning disable 0169
		static Delegate GetGetRecord_JLorg_encog_engine_data_EngineData_Handler ()
		{
			if (cb_getRecord_JLorg_encog_engine_data_EngineData_ == null)
				cb_getRecord_JLorg_encog_engine_data_EngineData_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long, IntPtr>) n_GetRecord_JLorg_encog_engine_data_EngineData_);
			return cb_getRecord_JLorg_encog_engine_data_EngineData_;
		}

		static void n_GetRecord_JLorg_encog_engine_data_EngineData_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
		{
			global::Org.Encog.Engine.Data.IEngineIndexableSet __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Data.IEngineIndexableSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Encog.Engine.Data.IEngineData p1 = (global::Org.Encog.Engine.Data.IEngineData)global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Data.IEngineData> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.GetRecord (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_getRecord_JLorg_encog_engine_data_EngineData_;
		public unsafe void GetRecord (long p0, global::Org.Encog.Engine.Data.IEngineData p1)
		{
			if (id_getRecord_JLorg_encog_engine_data_EngineData_ == IntPtr.Zero)
				id_getRecord_JLorg_encog_engine_data_EngineData_ = JNIEnv.GetMethodID (class_ref, "getRecord", "(JLorg/encog/engine/data/EngineData;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (Handle, id_getRecord_JLorg_encog_engine_data_EngineData_, __args);
		}

		static Delegate cb_openAdditional;
#pragma warning disable 0169
		static Delegate GetOpenAdditionalHandler ()
		{
			if (cb_openAdditional == null)
				cb_openAdditional = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_OpenAdditional);
			return cb_openAdditional;
		}

		static IntPtr n_OpenAdditional (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Data.IEngineIndexableSet __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Data.IEngineIndexableSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OpenAdditional ());
		}
#pragma warning restore 0169

		IntPtr id_openAdditional;
		public unsafe global::Org.Encog.Engine.Data.IEngineIndexableSet OpenAdditional ()
		{
			if (id_openAdditional == IntPtr.Zero)
				id_openAdditional = JNIEnv.GetMethodID (class_ref, "openAdditional", "()Lorg/encog/engine/data/EngineIndexableSet;");
			return global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Data.IEngineIndexableSet> (JNIEnv.CallObjectMethod (Handle, id_openAdditional), JniHandleOwnership.TransferLocalRef);
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
			global::Org.Encog.Engine.Data.IEngineIndexableSet __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Data.IEngineIndexableSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Org.Encog.Engine.Data.IEngineIndexableSet __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Data.IEngineIndexableSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Org.Encog.Engine.Data.IEngineIndexableSet __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Data.IEngineIndexableSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
