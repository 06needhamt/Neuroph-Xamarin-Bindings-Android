using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Encog.Engine.Network.Train.Prop {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.encog.engine.network.train.prop']/class[@name='TrainFlatNetworkManhattan']"
	[global::Android.Runtime.Register ("org/encog/engine/network/train/prop/TrainFlatNetworkManhattan", DoNotGenerateAcw=true)]
	public partial class TrainFlatNetworkManhattan : global::Org.Encog.Engine.Network.Train.Prop.TrainFlatNetworkProp {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/encog/engine/network/train/prop/TrainFlatNetworkManhattan", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TrainFlatNetworkManhattan); }
		}

		protected TrainFlatNetworkManhattan (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_encog_engine_network_flat_FlatNetwork_Lorg_encog_engine_data_EngineDataSet_D;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.encog.engine.network.train.prop']/class[@name='TrainFlatNetworkManhattan']/constructor[@name='TrainFlatNetworkManhattan' and count(parameter)=3 and parameter[1][@type='org.encog.engine.network.flat.FlatNetwork'] and parameter[2][@type='org.encog.engine.data.EngineDataSet'] and parameter[3][@type='double']]"
		[Register (".ctor", "(Lorg/encog/engine/network/flat/FlatNetwork;Lorg/encog/engine/data/EngineDataSet;D)V", "")]
		public unsafe TrainFlatNetworkManhattan (global::Org.Encog.Engine.Network.Flat.FlatNetwork p0, global::Org.Encog.Engine.Data.IEngineDataSet p1, double p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (TrainFlatNetworkManhattan)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/encog/engine/network/flat/FlatNetwork;Lorg/encog/engine/data/EngineDataSet;D)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/encog/engine/network/flat/FlatNetwork;Lorg/encog/engine/data/EngineDataSet;D)V", __args);
					return;
				}

				if (id_ctor_Lorg_encog_engine_network_flat_FlatNetwork_Lorg_encog_engine_data_EngineDataSet_D == IntPtr.Zero)
					id_ctor_Lorg_encog_engine_network_flat_FlatNetwork_Lorg_encog_engine_data_EngineDataSet_D = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/encog/engine/network/flat/FlatNetwork;Lorg/encog/engine/data/EngineDataSet;D)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_encog_engine_network_flat_FlatNetwork_Lorg_encog_engine_data_EngineDataSet_D, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_encog_engine_network_flat_FlatNetwork_Lorg_encog_engine_data_EngineDataSet_D, __args);
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
			global::Org.Encog.Engine.Network.Train.Prop.TrainFlatNetworkManhattan __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Train.Prop.TrainFlatNetworkManhattan> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.train.prop']/class[@name='TrainFlatNetworkManhattan']/method[@name='updateWeight' and count(parameter)=3 and parameter[1][@type='double[]'] and parameter[2][@type='double[]'] and parameter[3][@type='int']]"
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
					__ret = JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_updateWeight_arrayDarrayDI, __args);
				else
					__ret = JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateWeight", "([D[DI)D"), __args);
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
