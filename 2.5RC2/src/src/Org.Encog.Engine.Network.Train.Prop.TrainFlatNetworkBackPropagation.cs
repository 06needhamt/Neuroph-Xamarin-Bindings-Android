using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Encog.Engine.Network.Train.Prop {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.encog.engine.network.train.prop']/class[@name='TrainFlatNetworkBackPropagation']"
	[global::Android.Runtime.Register ("org/encog/engine/network/train/prop/TrainFlatNetworkBackPropagation", DoNotGenerateAcw=true)]
	public partial class TrainFlatNetworkBackPropagation : global::Org.Encog.Engine.Network.Train.Prop.TrainFlatNetworkProp {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/encog/engine/network/train/prop/TrainFlatNetworkBackPropagation", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TrainFlatNetworkBackPropagation); }
		}

		protected TrainFlatNetworkBackPropagation (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_encog_engine_network_flat_FlatNetwork_Lorg_encog_engine_data_EngineDataSet_DD;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.encog.engine.network.train.prop']/class[@name='TrainFlatNetworkBackPropagation']/constructor[@name='TrainFlatNetworkBackPropagation' and count(parameter)=4 and parameter[1][@type='org.encog.engine.network.flat.FlatNetwork'] and parameter[2][@type='org.encog.engine.data.EngineDataSet'] and parameter[3][@type='double'] and parameter[4][@type='double']]"
		[Register (".ctor", "(Lorg/encog/engine/network/flat/FlatNetwork;Lorg/encog/engine/data/EngineDataSet;DD)V", "")]
		public unsafe TrainFlatNetworkBackPropagation (global::Org.Encog.Engine.Network.Flat.FlatNetwork p0, global::Org.Encog.Engine.Data.IEngineDataSet p1, double p2, double p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				if (GetType () != typeof (TrainFlatNetworkBackPropagation)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/encog/engine/network/flat/FlatNetwork;Lorg/encog/engine/data/EngineDataSet;DD)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/encog/engine/network/flat/FlatNetwork;Lorg/encog/engine/data/EngineDataSet;DD)V", __args);
					return;
				}

				if (id_ctor_Lorg_encog_engine_network_flat_FlatNetwork_Lorg_encog_engine_data_EngineDataSet_DD == IntPtr.Zero)
					id_ctor_Lorg_encog_engine_network_flat_FlatNetwork_Lorg_encog_engine_data_EngineDataSet_DD = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/encog/engine/network/flat/FlatNetwork;Lorg/encog/engine/data/EngineDataSet;DD)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_encog_engine_network_flat_FlatNetwork_Lorg_encog_engine_data_EngineDataSet_DD, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_encog_engine_network_flat_FlatNetwork_Lorg_encog_engine_data_EngineDataSet_DD, __args);
			} finally {
			}
		}

		static Delegate cb_getLearningRate;
#pragma warning disable 0169
		static Delegate GetGetLearningRateHandler ()
		{
			if (cb_getLearningRate == null)
				cb_getLearningRate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetLearningRate);
			return cb_getLearningRate;
		}

		static double n_GetLearningRate (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Network.Train.Prop.TrainFlatNetworkBackPropagation __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Train.Prop.TrainFlatNetworkBackPropagation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LearningRate;
		}
#pragma warning restore 0169

		static Delegate cb_setLearningRate_D;
#pragma warning disable 0169
		static Delegate GetSetLearningRate_DHandler ()
		{
			if (cb_setLearningRate_D == null)
				cb_setLearningRate_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetLearningRate_D);
			return cb_setLearningRate_D;
		}

		static void n_SetLearningRate_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Org.Encog.Engine.Network.Train.Prop.TrainFlatNetworkBackPropagation __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Train.Prop.TrainFlatNetworkBackPropagation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.LearningRate = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getLearningRate;
		static IntPtr id_setLearningRate_D;
		public virtual unsafe double LearningRate {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.train.prop']/class[@name='TrainFlatNetworkBackPropagation']/method[@name='getLearningRate' and count(parameter)=0]"
			[Register ("getLearningRate", "()D", "GetGetLearningRateHandler")]
			get {
				if (id_getLearningRate == IntPtr.Zero)
					id_getLearningRate = JNIEnv.GetMethodID (class_ref, "getLearningRate", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getLearningRate);
					else
						return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLearningRate", "()D"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.train.prop']/class[@name='TrainFlatNetworkBackPropagation']/method[@name='setLearningRate' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setLearningRate", "(D)V", "GetSetLearningRate_DHandler")]
			set {
				if (id_setLearningRate_D == IntPtr.Zero)
					id_setLearningRate_D = JNIEnv.GetMethodID (class_ref, "setLearningRate", "(D)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLearningRate_D, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLearningRate", "(D)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMomentum;
#pragma warning disable 0169
		static Delegate GetGetMomentumHandler ()
		{
			if (cb_getMomentum == null)
				cb_getMomentum = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetMomentum);
			return cb_getMomentum;
		}

		static double n_GetMomentum (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Network.Train.Prop.TrainFlatNetworkBackPropagation __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Train.Prop.TrainFlatNetworkBackPropagation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Momentum;
		}
#pragma warning restore 0169

		static Delegate cb_setMomentum_D;
#pragma warning disable 0169
		static Delegate GetSetMomentum_DHandler ()
		{
			if (cb_setMomentum_D == null)
				cb_setMomentum_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetMomentum_D);
			return cb_setMomentum_D;
		}

		static void n_SetMomentum_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Org.Encog.Engine.Network.Train.Prop.TrainFlatNetworkBackPropagation __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Train.Prop.TrainFlatNetworkBackPropagation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Momentum = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMomentum;
		static IntPtr id_setMomentum_D;
		public virtual unsafe double Momentum {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.train.prop']/class[@name='TrainFlatNetworkBackPropagation']/method[@name='getMomentum' and count(parameter)=0]"
			[Register ("getMomentum", "()D", "GetGetMomentumHandler")]
			get {
				if (id_getMomentum == IntPtr.Zero)
					id_getMomentum = JNIEnv.GetMethodID (class_ref, "getMomentum", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getMomentum);
					else
						return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMomentum", "()D"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.train.prop']/class[@name='TrainFlatNetworkBackPropagation']/method[@name='setMomentum' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setMomentum", "(D)V", "GetSetMomentum_DHandler")]
			set {
				if (id_setMomentum_D == IntPtr.Zero)
					id_setMomentum_D = JNIEnv.GetMethodID (class_ref, "setMomentum", "(D)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMomentum_D, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMomentum", "(D)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getLastDelta;
#pragma warning disable 0169
		static Delegate GetGetLastDeltaHandler ()
		{
			if (cb_getLastDelta == null)
				cb_getLastDelta = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLastDelta);
			return cb_getLastDelta;
		}

		static IntPtr n_GetLastDelta (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Network.Train.Prop.TrainFlatNetworkBackPropagation __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Train.Prop.TrainFlatNetworkBackPropagation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetLastDelta ());
		}
#pragma warning restore 0169

		static IntPtr id_getLastDelta;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.train.prop']/class[@name='TrainFlatNetworkBackPropagation']/method[@name='getLastDelta' and count(parameter)=0]"
		[Register ("getLastDelta", "()[D", "GetGetLastDeltaHandler")]
		public virtual unsafe double[] GetLastDelta ()
		{
			if (id_getLastDelta == IntPtr.Zero)
				id_getLastDelta = JNIEnv.GetMethodID (class_ref, "getLastDelta", "()[D");
			try {

				if (GetType () == ThresholdType)
					return (double[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLastDelta), JniHandleOwnership.TransferLocalRef, typeof (double));
				else
					return (double[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLastDelta", "()[D")), JniHandleOwnership.TransferLocalRef, typeof (double));
			} finally {
			}
		}

		static Delegate cb_setLastDelta_arrayD;
#pragma warning disable 0169
		static Delegate GetSetLastDelta_arrayDHandler ()
		{
			if (cb_setLastDelta_arrayD == null)
				cb_setLastDelta_arrayD = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLastDelta_arrayD);
			return cb_setLastDelta_arrayD;
		}

		static void n_SetLastDelta_arrayD (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Encog.Engine.Network.Train.Prop.TrainFlatNetworkBackPropagation __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Train.Prop.TrainFlatNetworkBackPropagation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			double[] p0 = (double[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (double));
			__this.SetLastDelta (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_setLastDelta_arrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.train.prop']/class[@name='TrainFlatNetworkBackPropagation']/method[@name='setLastDelta' and count(parameter)=1 and parameter[1][@type='double[]']]"
		[Register ("setLastDelta", "([D)V", "GetSetLastDelta_arrayDHandler")]
		public virtual unsafe void SetLastDelta (double[] p0)
		{
			if (id_setLastDelta_arrayD == IntPtr.Zero)
				id_setLastDelta_arrayD = JNIEnv.GetMethodID (class_ref, "setLastDelta", "([D)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLastDelta_arrayD, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLastDelta", "([D)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
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
			global::Org.Encog.Engine.Network.Train.Prop.TrainFlatNetworkBackPropagation __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Train.Prop.TrainFlatNetworkBackPropagation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.train.prop']/class[@name='TrainFlatNetworkBackPropagation']/method[@name='updateWeight' and count(parameter)=3 and parameter[1][@type='double[]'] and parameter[2][@type='double[]'] and parameter[3][@type='int']]"
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
