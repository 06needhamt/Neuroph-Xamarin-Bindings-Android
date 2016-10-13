using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Encog.Engine.Data {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.encog.engine.data']/class[@name='BasicEngineDataSet']"
	[global::Android.Runtime.Register ("org/encog/engine/data/BasicEngineDataSet", DoNotGenerateAcw=true)]
	public partial class BasicEngineDataSet : global::Java.Lang.Object, global::Java.IO.ISerializable, global::Org.Encog.Engine.Data.IEngineIndexableSet {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/encog/engine/data/BasicEngineDataSet", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BasicEngineDataSet); }
		}

		protected BasicEngineDataSet (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_util_List_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.encog.engine.data']/class[@name='BasicEngineDataSet']/constructor[@name='BasicEngineDataSet' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;org.encog.engine.data.EngineData&gt;']]"
		[Register (".ctor", "(Ljava/util/List;)V", "")]
		public unsafe BasicEngineDataSet (global::System.Collections.Generic.IList<global::Org.Encog.Engine.Data.IEngineData> p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Org.Encog.Engine.Data.IEngineData>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (BasicEngineDataSet)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/util/List;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/util/List;)V", __args);
					return;
				}

				if (id_ctor_Ljava_util_List_ == IntPtr.Zero)
					id_ctor_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/util/List;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_util_List_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_util_List_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_ctor_arrayarrayDarrayarrayD;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.encog.engine.data']/class[@name='BasicEngineDataSet']/constructor[@name='BasicEngineDataSet' and count(parameter)=2 and parameter[1][@type='double[][]'] and parameter[2][@type='double[][]']]"
		[Register (".ctor", "([[D[[D)V", "")]
		public unsafe BasicEngineDataSet (double[][] p0, double[][] p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				if (GetType () != typeof (BasicEngineDataSet)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "([[D[[D)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "([[D[[D)V", __args);
					return;
				}

				if (id_ctor_arrayarrayDarrayarrayD == IntPtr.Zero)
					id_ctor_arrayarrayDarrayarrayD = JNIEnv.GetMethodID (class_ref, "<init>", "([[D[[D)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayarrayDarrayarrayD, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_arrayarrayDarrayarrayD, __args);
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

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.encog.engine.data']/class[@name='BasicEngineDataSet']/constructor[@name='BasicEngineDataSet' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BasicEngineDataSet ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (BasicEngineDataSet)) {
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

		static Delegate cb_getData;
#pragma warning disable 0169
		static Delegate GetGetDataHandler ()
		{
			if (cb_getData == null)
				cb_getData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetData);
			return cb_getData;
		}

		static IntPtr n_GetData (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Data.BasicEngineDataSet __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Data.BasicEngineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Org.Encog.Engine.Data.IEngineData>.ToLocalJniHandle (__this.Data);
		}
#pragma warning restore 0169

		static Delegate cb_setData_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetData_Ljava_util_List_Handler ()
		{
			if (cb_setData_Ljava_util_List_ == null)
				cb_setData_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetData_Ljava_util_List_);
			return cb_setData_Ljava_util_List_;
		}

		static void n_SetData_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Encog.Engine.Data.BasicEngineDataSet __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Data.BasicEngineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Org.Encog.Engine.Data.IEngineData>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Data = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getData;
		static IntPtr id_setData_Ljava_util_List_;
		public virtual unsafe global::System.Collections.Generic.IList<global::Org.Encog.Engine.Data.IEngineData> Data {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.data']/class[@name='BasicEngineDataSet']/method[@name='getData' and count(parameter)=0]"
			[Register ("getData", "()Ljava/util/List;", "GetGetDataHandler")]
			get {
				if (id_getData == IntPtr.Zero)
					id_getData = JNIEnv.GetMethodID (class_ref, "getData", "()Ljava/util/List;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Org.Encog.Engine.Data.IEngineData>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getData), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Org.Encog.Engine.Data.IEngineData>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getData", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.data']/class[@name='BasicEngineDataSet']/method[@name='setData' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;org.encog.engine.data.EngineData&gt;']]"
			[Register ("setData", "(Ljava/util/List;)V", "GetSetData_Ljava_util_List_Handler")]
			set {
				if (id_setData_Ljava_util_List_ == IntPtr.Zero)
					id_setData_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setData", "(Ljava/util/List;)V");
				IntPtr native_value = global::Android.Runtime.JavaList<global::Org.Encog.Engine.Data.IEngineData>.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setData_Ljava_util_List_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setData", "(Ljava/util/List;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
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
			global::Org.Encog.Engine.Data.BasicEngineDataSet __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Data.BasicEngineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IdealSize;
		}
#pragma warning restore 0169

		static IntPtr id_getIdealSize;
		public virtual unsafe int IdealSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.data']/class[@name='BasicEngineDataSet']/method[@name='getIdealSize' and count(parameter)=0]"
			[Register ("getIdealSize", "()I", "GetGetIdealSizeHandler")]
			get {
				if (id_getIdealSize == IntPtr.Zero)
					id_getIdealSize = JNIEnv.GetMethodID (class_ref, "getIdealSize", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getIdealSize);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIdealSize", "()I"));
				} finally {
				}
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
			global::Org.Encog.Engine.Data.BasicEngineDataSet __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Data.BasicEngineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.InputSize;
		}
#pragma warning restore 0169

		static IntPtr id_getInputSize;
		public virtual unsafe int InputSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.data']/class[@name='BasicEngineDataSet']/method[@name='getInputSize' and count(parameter)=0]"
			[Register ("getInputSize", "()I", "GetGetInputSizeHandler")]
			get {
				if (id_getInputSize == IntPtr.Zero)
					id_getInputSize = JNIEnv.GetMethodID (class_ref, "getInputSize", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getInputSize);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getInputSize", "()I"));
				} finally {
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
			global::Org.Encog.Engine.Data.BasicEngineDataSet __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Data.BasicEngineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSupervised;
		}
#pragma warning restore 0169

		static IntPtr id_isSupervised;
		public virtual unsafe bool IsSupervised {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.data']/class[@name='BasicEngineDataSet']/method[@name='isSupervised' and count(parameter)=0]"
			[Register ("isSupervised", "()Z", "GetIsSupervisedHandler")]
			get {
				if (id_isSupervised == IntPtr.Zero)
					id_isSupervised = JNIEnv.GetMethodID (class_ref, "isSupervised", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isSupervised);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isSupervised", "()Z"));
				} finally {
				}
			}
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
			global::Org.Encog.Engine.Data.BasicEngineDataSet __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Data.BasicEngineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RecordCount;
		}
#pragma warning restore 0169

		static IntPtr id_getRecordCount;
		public virtual unsafe long RecordCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.data']/class[@name='BasicEngineDataSet']/method[@name='getRecordCount' and count(parameter)=0]"
			[Register ("getRecordCount", "()J", "GetGetRecordCountHandler")]
			get {
				if (id_getRecordCount == IntPtr.Zero)
					id_getRecordCount = JNIEnv.GetMethodID (class_ref, "getRecordCount", "()J");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getRecordCount);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRecordCount", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_add_arrayD;
#pragma warning disable 0169
		static Delegate GetAdd_arrayDHandler ()
		{
			if (cb_add_arrayD == null)
				cb_add_arrayD = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Add_arrayD);
			return cb_add_arrayD;
		}

		static void n_Add_arrayD (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Encog.Engine.Data.BasicEngineDataSet __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Data.BasicEngineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			double[] p0 = (double[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (double));
			__this.Add (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_add_arrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.data']/class[@name='BasicEngineDataSet']/method[@name='add' and count(parameter)=1 and parameter[1][@type='double[]']]"
		[Register ("add", "([D)V", "GetAdd_arrayDHandler")]
		public virtual unsafe void Add (double[] p0)
		{
			if (id_add_arrayD == IntPtr.Zero)
				id_add_arrayD = JNIEnv.GetMethodID (class_ref, "add", "([D)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_add_arrayD, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "add", "([D)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_add_arrayDarrayD;
#pragma warning disable 0169
		static Delegate GetAdd_arrayDarrayDHandler ()
		{
			if (cb_add_arrayDarrayD == null)
				cb_add_arrayDarrayD = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Add_arrayDarrayD);
			return cb_add_arrayDarrayD;
		}

		static void n_Add_arrayDarrayD (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Encog.Engine.Data.BasicEngineDataSet __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Data.BasicEngineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			double[] p0 = (double[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (double));
			double[] p1 = (double[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (double));
			__this.Add (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		static IntPtr id_add_arrayDarrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.data']/class[@name='BasicEngineDataSet']/method[@name='add' and count(parameter)=2 and parameter[1][@type='double[]'] and parameter[2][@type='double[]']]"
		[Register ("add", "([D[D)V", "GetAdd_arrayDarrayDHandler")]
		public virtual unsafe void Add (double[] p0, double[] p1)
		{
			if (id_add_arrayDarrayD == IntPtr.Zero)
				id_add_arrayDarrayD = JNIEnv.GetMethodID (class_ref, "add", "([D[D)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_add_arrayDarrayD, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "add", "([D[D)V"), __args);
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

		static Delegate cb_add_Lorg_encog_engine_data_EngineData_;
#pragma warning disable 0169
		static Delegate GetAdd_Lorg_encog_engine_data_EngineData_Handler ()
		{
			if (cb_add_Lorg_encog_engine_data_EngineData_ == null)
				cb_add_Lorg_encog_engine_data_EngineData_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Add_Lorg_encog_engine_data_EngineData_);
			return cb_add_Lorg_encog_engine_data_EngineData_;
		}

		static void n_Add_Lorg_encog_engine_data_EngineData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Encog.Engine.Data.BasicEngineDataSet __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Data.BasicEngineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Encog.Engine.Data.IEngineData p0 = (global::Org.Encog.Engine.Data.IEngineData)global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Data.IEngineData> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Add (p0);
		}
#pragma warning restore 0169

		static IntPtr id_add_Lorg_encog_engine_data_EngineData_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.data']/class[@name='BasicEngineDataSet']/method[@name='add' and count(parameter)=1 and parameter[1][@type='org.encog.engine.data.EngineData']]"
		[Register ("add", "(Lorg/encog/engine/data/EngineData;)V", "GetAdd_Lorg_encog_engine_data_EngineData_Handler")]
		public virtual unsafe void Add (global::Org.Encog.Engine.Data.IEngineData p0)
		{
			if (id_add_Lorg_encog_engine_data_EngineData_ == IntPtr.Zero)
				id_add_Lorg_encog_engine_data_EngineData_ = JNIEnv.GetMethodID (class_ref, "add", "(Lorg/encog/engine/data/EngineData;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_add_Lorg_encog_engine_data_EngineData_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "add", "(Lorg/encog/engine/data/EngineData;)V"), __args);
			} finally {
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
			global::Org.Encog.Engine.Data.BasicEngineDataSet __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Data.BasicEngineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Encog.Engine.Data.IEngineData p1 = (global::Org.Encog.Engine.Data.IEngineData)global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Data.IEngineData> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.GetRecord (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_getRecord_JLorg_encog_engine_data_EngineData_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.data']/class[@name='BasicEngineDataSet']/method[@name='getRecord' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='org.encog.engine.data.EngineData']]"
		[Register ("getRecord", "(JLorg/encog/engine/data/EngineData;)V", "GetGetRecord_JLorg_encog_engine_data_EngineData_Handler")]
		public virtual unsafe void GetRecord (long p0, global::Org.Encog.Engine.Data.IEngineData p1)
		{
			if (id_getRecord_JLorg_encog_engine_data_EngineData_ == IntPtr.Zero)
				id_getRecord_JLorg_encog_engine_data_EngineData_ = JNIEnv.GetMethodID (class_ref, "getRecord", "(JLorg/encog/engine/data/EngineData;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getRecord_JLorg_encog_engine_data_EngineData_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRecord", "(JLorg/encog/engine/data/EngineData;)V"), __args);
			} finally {
			}
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
			global::Org.Encog.Engine.Data.BasicEngineDataSet __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Data.BasicEngineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OpenAdditional ());
		}
#pragma warning restore 0169

		static IntPtr id_openAdditional;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.data']/class[@name='BasicEngineDataSet']/method[@name='openAdditional' and count(parameter)=0]"
		[Register ("openAdditional", "()Lorg/encog/engine/data/EngineIndexableSet;", "GetOpenAdditionalHandler")]
		public virtual unsafe global::Org.Encog.Engine.Data.IEngineIndexableSet OpenAdditional ()
		{
			if (id_openAdditional == IntPtr.Zero)
				id_openAdditional = JNIEnv.GetMethodID (class_ref, "openAdditional", "()Lorg/encog/engine/data/EngineIndexableSet;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Data.IEngineIndexableSet> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_openAdditional), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Data.IEngineIndexableSet> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "openAdditional", "()Lorg/encog/engine/data/EngineIndexableSet;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
