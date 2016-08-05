using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Encog.Engine.Opencl.Kernels {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.encog.engine.opencl.kernels']/class[@name='KernelNetworkTrain']"
	[global::Android.Runtime.Register ("org/encog/engine/opencl/kernels/KernelNetworkTrain", DoNotGenerateAcw=true)]
	public partial class KernelNetworkTrain : global::Org.Encog.Engine.Opencl.Kernels.EncogKernel {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.encog.engine.opencl.kernels']/class[@name='KernelNetworkTrain']/field[@name='PARRAY_INPUT_COUNT']"
		[Register ("PARRAY_INPUT_COUNT")]
		public const int ParrayInputCount = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.encog.engine.opencl.kernels']/class[@name='KernelNetworkTrain']/field[@name='PARRAY_ITEMS_PER']"
		[Register ("PARRAY_ITEMS_PER")]
		public const int ParrayItemsPer = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.encog.engine.opencl.kernels']/class[@name='KernelNetworkTrain']/field[@name='PARRAY_ITERATIONS']"
		[Register ("PARRAY_ITERATIONS")]
		public const int ParrayIterations = (int) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.encog.engine.opencl.kernels']/class[@name='KernelNetworkTrain']/field[@name='PARRAY_LAYER_COUNT']"
		[Register ("PARRAY_LAYER_COUNT")]
		public const int ParrayLayerCount = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.encog.engine.opencl.kernels']/class[@name='KernelNetworkTrain']/field[@name='PARRAY_LEARN']"
		[Register ("PARRAY_LEARN")]
		public const int ParrayLearn = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.encog.engine.opencl.kernels']/class[@name='KernelNetworkTrain']/field[@name='PARRAY_OUTPUT_COUNT']"
		[Register ("PARRAY_OUTPUT_COUNT")]
		public const int ParrayOutputCount = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.encog.engine.opencl.kernels']/class[@name='KernelNetworkTrain']/field[@name='PARRAY_START']"
		[Register ("PARRAY_START")]
		public const int ParrayStart = (int) 4;
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/encog/engine/opencl/kernels/KernelNetworkTrain", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (KernelNetworkTrain); }
		}

		protected KernelNetworkTrain (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_encog_engine_opencl_EncogCLDevice_Lorg_encog_engine_network_flat_FlatNetwork_Lorg_encog_engine_data_EngineIndexableSet_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.encog.engine.opencl.kernels']/class[@name='KernelNetworkTrain']/constructor[@name='KernelNetworkTrain' and count(parameter)=4 and parameter[1][@type='org.encog.engine.opencl.EncogCLDevice'] and parameter[2][@type='org.encog.engine.network.flat.FlatNetwork'] and parameter[3][@type='org.encog.engine.data.EngineIndexableSet'] and parameter[4][@type='int']]"
		[Register (".ctor", "(Lorg/encog/engine/opencl/EncogCLDevice;Lorg/encog/engine/network/flat/FlatNetwork;Lorg/encog/engine/data/EngineIndexableSet;I)V", "")]
		public unsafe KernelNetworkTrain (global::Org.Encog.Engine.Opencl.EncogCLDevice p0, global::Org.Encog.Engine.Network.Flat.FlatNetwork p1, global::Org.Encog.Engine.Data.IEngineIndexableSet p2, int p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				if (GetType () != typeof (KernelNetworkTrain)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/encog/engine/opencl/EncogCLDevice;Lorg/encog/engine/network/flat/FlatNetwork;Lorg/encog/engine/data/EngineIndexableSet;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorg/encog/engine/opencl/EncogCLDevice;Lorg/encog/engine/network/flat/FlatNetwork;Lorg/encog/engine/data/EngineIndexableSet;I)V", __args);
					return;
				}

				if (id_ctor_Lorg_encog_engine_opencl_EncogCLDevice_Lorg_encog_engine_network_flat_FlatNetwork_Lorg_encog_engine_data_EngineIndexableSet_I == IntPtr.Zero)
					id_ctor_Lorg_encog_engine_opencl_EncogCLDevice_Lorg_encog_engine_network_flat_FlatNetwork_Lorg_encog_engine_data_EngineIndexableSet_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/encog/engine/opencl/EncogCLDevice;Lorg/encog/engine/network/flat/FlatNetwork;Lorg/encog/engine/data/EngineIndexableSet;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_encog_engine_opencl_EncogCLDevice_Lorg_encog_engine_network_flat_FlatNetwork_Lorg_encog_engine_data_EngineIndexableSet_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_encog_engine_opencl_EncogCLDevice_Lorg_encog_engine_network_flat_FlatNetwork_Lorg_encog_engine_data_EngineIndexableSet_I, __args);
			} finally {
			}
		}

		static Delegate cb_assignWorkgroupSizes_II;
#pragma warning disable 0169
		static Delegate GetAssignWorkgroupSizes_IIHandler ()
		{
			if (cb_assignWorkgroupSizes_II == null)
				cb_assignWorkgroupSizes_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_AssignWorkgroupSizes_II);
			return cb_assignWorkgroupSizes_II;
		}

		static void n_AssignWorkgroupSizes_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Org.Encog.Engine.Opencl.Kernels.KernelNetworkTrain __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Opencl.Kernels.KernelNetworkTrain> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AssignWorkgroupSizes (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_assignWorkgroupSizes_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.opencl.kernels']/class[@name='KernelNetworkTrain']/method[@name='assignWorkgroupSizes' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("assignWorkgroupSizes", "(II)V", "GetAssignWorkgroupSizes_IIHandler")]
		public virtual unsafe void AssignWorkgroupSizes (int p0, int p1)
		{
			if (id_assignWorkgroupSizes_II == IntPtr.Zero)
				id_assignWorkgroupSizes_II = JNIEnv.GetMethodID (class_ref, "assignWorkgroupSizes", "(II)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_assignWorkgroupSizes_II, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "assignWorkgroupSizes", "(II)V"), __args);
			} finally {
			}
		}

		static Delegate cb_calculate_IIZI;
#pragma warning disable 0169
		static Delegate GetCalculate_IIZIHandler ()
		{
			if (cb_calculate_IIZI == null)
				cb_calculate_IIZI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, bool, int>) n_Calculate_IIZI);
			return cb_calculate_IIZI;
		}

		static void n_Calculate_IIZI (IntPtr jnienv, IntPtr native__this, int p0, int p1, bool p2, int p3)
		{
			global::Org.Encog.Engine.Opencl.Kernels.KernelNetworkTrain __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Opencl.Kernels.KernelNetworkTrain> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Calculate (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_calculate_IIZI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.opencl.kernels']/class[@name='KernelNetworkTrain']/method[@name='calculate' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='boolean'] and parameter[4][@type='int']]"
		[Register ("calculate", "(IIZI)V", "GetCalculate_IIZIHandler")]
		public virtual unsafe void Calculate (int p0, int p1, bool p2, int p3)
		{
			if (id_calculate_IIZI == IntPtr.Zero)
				id_calculate_IIZI = JNIEnv.GetMethodID (class_ref, "calculate", "(IIZI)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_calculate_IIZI, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "calculate", "(IIZI)V"), __args);
			} finally {
			}
		}

		static Delegate cb_compile_Ljava_util_Map_Lorg_encog_engine_network_train_prop_OpenCLTrainingProfile_Lorg_encog_engine_network_flat_FlatNetwork_;
#pragma warning disable 0169
		static Delegate GetCompile_Ljava_util_Map_Lorg_encog_engine_network_train_prop_OpenCLTrainingProfile_Lorg_encog_engine_network_flat_FlatNetwork_Handler ()
		{
			if (cb_compile_Ljava_util_Map_Lorg_encog_engine_network_train_prop_OpenCLTrainingProfile_Lorg_encog_engine_network_flat_FlatNetwork_ == null)
				cb_compile_Ljava_util_Map_Lorg_encog_engine_network_train_prop_OpenCLTrainingProfile_Lorg_encog_engine_network_flat_FlatNetwork_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Compile_Ljava_util_Map_Lorg_encog_engine_network_train_prop_OpenCLTrainingProfile_Lorg_encog_engine_network_flat_FlatNetwork_);
			return cb_compile_Ljava_util_Map_Lorg_encog_engine_network_train_prop_OpenCLTrainingProfile_Lorg_encog_engine_network_flat_FlatNetwork_;
		}

		static void n_Compile_Ljava_util_Map_Lorg_encog_engine_network_train_prop_OpenCLTrainingProfile_Lorg_encog_engine_network_flat_FlatNetwork_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Org.Encog.Engine.Opencl.Kernels.KernelNetworkTrain __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Opencl.Kernels.KernelNetworkTrain> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Encog.Engine.Network.Train.Prop.OpenCLTrainingProfile p1 = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Train.Prop.OpenCLTrainingProfile> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Org.Encog.Engine.Network.Flat.FlatNetwork p2 = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Flat.FlatNetwork> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Compile (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_compile_Ljava_util_Map_Lorg_encog_engine_network_train_prop_OpenCLTrainingProfile_Lorg_encog_engine_network_flat_FlatNetwork_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.opencl.kernels']/class[@name='KernelNetworkTrain']/method[@name='compile' and count(parameter)=3 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;'] and parameter[2][@type='org.encog.engine.network.train.prop.OpenCLTrainingProfile'] and parameter[3][@type='org.encog.engine.network.flat.FlatNetwork']]"
		[Register ("compile", "(Ljava/util/Map;Lorg/encog/engine/network/train/prop/OpenCLTrainingProfile;Lorg/encog/engine/network/flat/FlatNetwork;)V", "GetCompile_Ljava_util_Map_Lorg_encog_engine_network_train_prop_OpenCLTrainingProfile_Lorg_encog_engine_network_flat_FlatNetwork_Handler")]
		public virtual unsafe void Compile (global::System.Collections.Generic.IDictionary<string, string> p0, global::Org.Encog.Engine.Network.Train.Prop.OpenCLTrainingProfile p1, global::Org.Encog.Engine.Network.Flat.FlatNetwork p2)
		{
			if (id_compile_Ljava_util_Map_Lorg_encog_engine_network_train_prop_OpenCLTrainingProfile_Lorg_encog_engine_network_flat_FlatNetwork_ == IntPtr.Zero)
				id_compile_Ljava_util_Map_Lorg_encog_engine_network_train_prop_OpenCLTrainingProfile_Lorg_encog_engine_network_flat_FlatNetwork_ = JNIEnv.GetMethodID (class_ref, "compile", "(Ljava/util/Map;Lorg/encog/engine/network/train/prop/OpenCLTrainingProfile;Lorg/encog/engine/network/flat/FlatNetwork;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_compile_Ljava_util_Map_Lorg_encog_engine_network_train_prop_OpenCLTrainingProfile_Lorg_encog_engine_network_flat_FlatNetwork_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "compile", "(Ljava/util/Map;Lorg/encog/engine/network/train/prop/OpenCLTrainingProfile;Lorg/encog/engine/network/flat/FlatNetwork;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getErrors;
#pragma warning disable 0169
		static Delegate GetGetErrorsHandler ()
		{
			if (cb_getErrors == null)
				cb_getErrors = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetErrors);
			return cb_getErrors;
		}

		static IntPtr n_GetErrors (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Opencl.Kernels.KernelNetworkTrain __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Opencl.Kernels.KernelNetworkTrain> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetErrors ());
		}
#pragma warning restore 0169

		static IntPtr id_getErrors;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.opencl.kernels']/class[@name='KernelNetworkTrain']/method[@name='getErrors' and count(parameter)=0]"
		[Register ("getErrors", "()[F", "GetGetErrorsHandler")]
		public virtual unsafe float[] GetErrors ()
		{
			if (id_getErrors == IntPtr.Zero)
				id_getErrors = JNIEnv.GetMethodID (class_ref, "getErrors", "()[F");
			try {

				if (GetType () == ThresholdType)
					return (float[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getErrors), JniHandleOwnership.TransferLocalRef, typeof (float));
				else
					return (float[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getErrors", "()[F")), JniHandleOwnership.TransferLocalRef, typeof (float));
			} finally {
			}
		}

		static Delegate cb_getTempDataArray;
#pragma warning disable 0169
		static Delegate GetGetTempDataArrayHandler ()
		{
			if (cb_getTempDataArray == null)
				cb_getTempDataArray = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTempDataArray);
			return cb_getTempDataArray;
		}

		static IntPtr n_GetTempDataArray (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Opencl.Kernels.KernelNetworkTrain __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Opencl.Kernels.KernelNetworkTrain> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetTempDataArray ());
		}
#pragma warning restore 0169

		static IntPtr id_getTempDataArray;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.opencl.kernels']/class[@name='KernelNetworkTrain']/method[@name='getTempDataArray' and count(parameter)=0]"
		[Register ("getTempDataArray", "()[F", "GetGetTempDataArrayHandler")]
		public virtual unsafe float[] GetTempDataArray ()
		{
			if (id_getTempDataArray == IntPtr.Zero)
				id_getTempDataArray = JNIEnv.GetMethodID (class_ref, "getTempDataArray", "()[F");
			try {

				if (GetType () == ThresholdType)
					return (float[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getTempDataArray), JniHandleOwnership.TransferLocalRef, typeof (float));
				else
					return (float[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTempDataArray", "()[F")), JniHandleOwnership.TransferLocalRef, typeof (float));
			} finally {
			}
		}

		static Delegate cb_getWeightOutArray;
#pragma warning disable 0169
		static Delegate GetGetWeightOutArrayHandler ()
		{
			if (cb_getWeightOutArray == null)
				cb_getWeightOutArray = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetWeightOutArray);
			return cb_getWeightOutArray;
		}

		static IntPtr n_GetWeightOutArray (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Opencl.Kernels.KernelNetworkTrain __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Opencl.Kernels.KernelNetworkTrain> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetWeightOutArray ());
		}
#pragma warning restore 0169

		static IntPtr id_getWeightOutArray;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.opencl.kernels']/class[@name='KernelNetworkTrain']/method[@name='getWeightOutArray' and count(parameter)=0]"
		[Register ("getWeightOutArray", "()[F", "GetGetWeightOutArrayHandler")]
		public virtual unsafe float[] GetWeightOutArray ()
		{
			if (id_getWeightOutArray == IntPtr.Zero)
				id_getWeightOutArray = JNIEnv.GetMethodID (class_ref, "getWeightOutArray", "()[F");
			try {

				if (GetType () == ThresholdType)
					return (float[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getWeightOutArray), JniHandleOwnership.TransferLocalRef, typeof (float));
				else
					return (float[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWeightOutArray", "()[F")), JniHandleOwnership.TransferLocalRef, typeof (float));
			} finally {
			}
		}

		static Delegate cb_init_Lorg_encog_engine_network_train_prop_OpenCLTrainingProfile_;
#pragma warning disable 0169
		static Delegate GetInit_Lorg_encog_engine_network_train_prop_OpenCLTrainingProfile_Handler ()
		{
			if (cb_init_Lorg_encog_engine_network_train_prop_OpenCLTrainingProfile_ == null)
				cb_init_Lorg_encog_engine_network_train_prop_OpenCLTrainingProfile_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Init_Lorg_encog_engine_network_train_prop_OpenCLTrainingProfile_);
			return cb_init_Lorg_encog_engine_network_train_prop_OpenCLTrainingProfile_;
		}

		static void n_Init_Lorg_encog_engine_network_train_prop_OpenCLTrainingProfile_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Encog.Engine.Opencl.Kernels.KernelNetworkTrain __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Opencl.Kernels.KernelNetworkTrain> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Encog.Engine.Network.Train.Prop.OpenCLTrainingProfile p0 = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Train.Prop.OpenCLTrainingProfile> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Init (p0);
		}
#pragma warning restore 0169

		static IntPtr id_init_Lorg_encog_engine_network_train_prop_OpenCLTrainingProfile_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.opencl.kernels']/class[@name='KernelNetworkTrain']/method[@name='init' and count(parameter)=1 and parameter[1][@type='org.encog.engine.network.train.prop.OpenCLTrainingProfile']]"
		[Register ("init", "(Lorg/encog/engine/network/train/prop/OpenCLTrainingProfile;)V", "GetInit_Lorg_encog_engine_network_train_prop_OpenCLTrainingProfile_Handler")]
		public virtual unsafe void Init (global::Org.Encog.Engine.Network.Train.Prop.OpenCLTrainingProfile p0)
		{
			if (id_init_Lorg_encog_engine_network_train_prop_OpenCLTrainingProfile_ == IntPtr.Zero)
				id_init_Lorg_encog_engine_network_train_prop_OpenCLTrainingProfile_ = JNIEnv.GetMethodID (class_ref, "init", "(Lorg/encog/engine/network/train/prop/OpenCLTrainingProfile;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_init_Lorg_encog_engine_network_train_prop_OpenCLTrainingProfile_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "init", "(Lorg/encog/engine/network/train/prop/OpenCLTrainingProfile;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setTempDataArray_arrayF;
#pragma warning disable 0169
		static Delegate GetSetTempDataArray_arrayFHandler ()
		{
			if (cb_setTempDataArray_arrayF == null)
				cb_setTempDataArray_arrayF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTempDataArray_arrayF);
			return cb_setTempDataArray_arrayF;
		}

		static void n_SetTempDataArray_arrayF (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Encog.Engine.Opencl.Kernels.KernelNetworkTrain __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Opencl.Kernels.KernelNetworkTrain> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			float[] p0 = (float[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (float));
			__this.SetTempDataArray (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_setTempDataArray_arrayF;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.opencl.kernels']/class[@name='KernelNetworkTrain']/method[@name='setTempDataArray' and count(parameter)=1 and parameter[1][@type='float[]']]"
		[Register ("setTempDataArray", "([F)V", "GetSetTempDataArray_arrayFHandler")]
		public virtual unsafe void SetTempDataArray (float[] p0)
		{
			if (id_setTempDataArray_arrayF == IntPtr.Zero)
				id_setTempDataArray_arrayF = JNIEnv.GetMethodID (class_ref, "setTempDataArray", "([F)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setTempDataArray_arrayF, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTempDataArray", "([F)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

	}
}
