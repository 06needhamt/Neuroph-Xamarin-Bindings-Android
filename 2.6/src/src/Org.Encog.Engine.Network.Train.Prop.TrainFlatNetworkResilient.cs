using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Encog.Engine.Network.Train.Prop {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.encog.engine.network.train.prop']/class[@name='TrainFlatNetworkResilient']"
	[global::Android.Runtime.Register ("org/encog/engine/network/train/prop/TrainFlatNetworkResilient", DoNotGenerateAcw=true)]
	public partial class TrainFlatNetworkResilient : global::Org.Encog.Engine.Network.Train.Prop.TrainFlatNetworkProp {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/encog/engine/network/train/prop/TrainFlatNetworkResilient", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TrainFlatNetworkResilient); }
		}

		protected TrainFlatNetworkResilient (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_encog_engine_network_flat_FlatNetwork_Lorg_encog_engine_data_EngineDataSet_DDD;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.encog.engine.network.train.prop']/class[@name='TrainFlatNetworkResilient']/constructor[@name='TrainFlatNetworkResilient' and count(parameter)=5 and parameter[1][@type='org.encog.engine.network.flat.FlatNetwork'] and parameter[2][@type='org.encog.engine.data.EngineDataSet'] and parameter[3][@type='double'] and parameter[4][@type='double'] and parameter[5][@type='double']]"
		[Register (".ctor", "(Lorg/encog/engine/network/flat/FlatNetwork;Lorg/encog/engine/data/EngineDataSet;DDD)V", "")]
		public unsafe TrainFlatNetworkResilient (global::Org.Encog.Engine.Network.Flat.FlatNetwork p0, global::Org.Encog.Engine.Data.IEngineDataSet p1, double p2, double p3, double p4)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				if (GetType () != typeof (TrainFlatNetworkResilient)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/encog/engine/network/flat/FlatNetwork;Lorg/encog/engine/data/EngineDataSet;DDD)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorg/encog/engine/network/flat/FlatNetwork;Lorg/encog/engine/data/EngineDataSet;DDD)V", __args);
					return;
				}

				if (id_ctor_Lorg_encog_engine_network_flat_FlatNetwork_Lorg_encog_engine_data_EngineDataSet_DDD == IntPtr.Zero)
					id_ctor_Lorg_encog_engine_network_flat_FlatNetwork_Lorg_encog_engine_data_EngineDataSet_DDD = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/encog/engine/network/flat/FlatNetwork;Lorg/encog/engine/data/EngineDataSet;DDD)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_encog_engine_network_flat_FlatNetwork_Lorg_encog_engine_data_EngineDataSet_DDD, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_encog_engine_network_flat_FlatNetwork_Lorg_encog_engine_data_EngineDataSet_DDD, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Lorg_encog_engine_network_flat_FlatNetwork_Lorg_encog_engine_data_EngineDataSet_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.encog.engine.network.train.prop']/class[@name='TrainFlatNetworkResilient']/constructor[@name='TrainFlatNetworkResilient' and count(parameter)=2 and parameter[1][@type='org.encog.engine.network.flat.FlatNetwork'] and parameter[2][@type='org.encog.engine.data.EngineDataSet']]"
		[Register (".ctor", "(Lorg/encog/engine/network/flat/FlatNetwork;Lorg/encog/engine/data/EngineDataSet;)V", "")]
		public unsafe TrainFlatNetworkResilient (global::Org.Encog.Engine.Network.Flat.FlatNetwork p0, global::Org.Encog.Engine.Data.IEngineDataSet p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (TrainFlatNetworkResilient)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/encog/engine/network/flat/FlatNetwork;Lorg/encog/engine/data/EngineDataSet;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorg/encog/engine/network/flat/FlatNetwork;Lorg/encog/engine/data/EngineDataSet;)V", __args);
					return;
				}

				if (id_ctor_Lorg_encog_engine_network_flat_FlatNetwork_Lorg_encog_engine_data_EngineDataSet_ == IntPtr.Zero)
					id_ctor_Lorg_encog_engine_network_flat_FlatNetwork_Lorg_encog_engine_data_EngineDataSet_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/encog/engine/network/flat/FlatNetwork;Lorg/encog/engine/data/EngineDataSet;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_encog_engine_network_flat_FlatNetwork_Lorg_encog_engine_data_EngineDataSet_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_encog_engine_network_flat_FlatNetwork_Lorg_encog_engine_data_EngineDataSet_, __args);
			} finally {
			}
		}

		static Delegate cb_getUpdateValues;
#pragma warning disable 0169
		static Delegate GetGetUpdateValuesHandler ()
		{
			if (cb_getUpdateValues == null)
				cb_getUpdateValues = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUpdateValues);
			return cb_getUpdateValues;
		}

		static IntPtr n_GetUpdateValues (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Network.Train.Prop.TrainFlatNetworkResilient __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Train.Prop.TrainFlatNetworkResilient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetUpdateValues ());
		}
#pragma warning restore 0169

		static IntPtr id_getUpdateValues;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.train.prop']/class[@name='TrainFlatNetworkResilient']/method[@name='getUpdateValues' and count(parameter)=0]"
		[Register ("getUpdateValues", "()[D", "GetGetUpdateValuesHandler")]
		public virtual unsafe double[] GetUpdateValues ()
		{
			if (id_getUpdateValues == IntPtr.Zero)
				id_getUpdateValues = JNIEnv.GetMethodID (class_ref, "getUpdateValues", "()[D");
			try {

				if (GetType () == ThresholdType)
					return (double[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getUpdateValues), JniHandleOwnership.TransferLocalRef, typeof (double));
				else
					return (double[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUpdateValues", "()[D")), JniHandleOwnership.TransferLocalRef, typeof (double));
			} finally {
			}
		}

		static Delegate cb_updateWeight_arrayDarrayDI;
#pragma warning disable 0169
		static Delegate GetUpdateWeight_arrayDarrayDIHandler ()
		{
			if (cb_updateWeight_arrayDarrayDI == null)
				cb_updateWeight_arrayDarrayDI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int, double>) n_UpdateWeight_arrayDarrayDI);
			return cb_updateWeight_arrayDarrayDI;
		}

		static double n_UpdateWeight_arrayDarrayDI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2)
		{
			global::Org.Encog.Engine.Network.Train.Prop.TrainFlatNetworkResilient __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Train.Prop.TrainFlatNetworkResilient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			double[] p0 = (double[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (double));
			double[] p1 = (double[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (double));
			double __ret = __this.UpdateWeight (p0, p1, p2);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_updateWeight_arrayDarrayDI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.train.prop']/class[@name='TrainFlatNetworkResilient']/method[@name='updateWeight' and count(parameter)=3 and parameter[1][@type='double[]'] and parameter[2][@type='double[]'] and parameter[3][@type='int']]"
		[Register ("updateWeight", "([D[DI)D", "GetUpdateWeight_arrayDarrayDIHandler")]
		public override unsafe double UpdateWeight (double[] p0, double[] p1, int p2)
		{
			if (id_updateWeight_arrayDarrayDI == IntPtr.Zero)
				id_updateWeight_arrayDarrayDI = JNIEnv.GetMethodID (class_ref, "updateWeight", "([D[DI)D");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);

				double __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallDoubleMethod  (Handle, id_updateWeight_arrayDarrayDI, __args);
				else
					__ret = JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateWeight", "([D[DI)D"), __args);
				return __ret;
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

	}
}
