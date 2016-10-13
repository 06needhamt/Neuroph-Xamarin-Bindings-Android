using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Encog.Engine.Network.Flat {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.encog.engine.network.flat']/class[@name='FlatNetwork']"
	[global::Android.Runtime.Register ("org/encog/engine/network/flat/FlatNetwork", DoNotGenerateAcw=true)]
	public partial class FlatNetwork : global::Java.Lang.Object, global::Java.IO.ISerializable, global::Org.Encog.Engine.IEngineNeuralNetwork {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.encog.engine.network.flat']/class[@name='FlatNetwork']/field[@name='DEFAULT_BIAS_ACTIVATION']"
		[Register ("DEFAULT_BIAS_ACTIVATION")]
		public const double DefaultBiasActivation = (double) 1.000000000000000;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.encog.engine.network.flat']/class[@name='FlatNetwork']/field[@name='NO_BIAS_ACTIVATION']"
		[Register ("NO_BIAS_ACTIVATION")]
		public const double NoBiasActivation = (double) 0.000000000000000;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/encog/engine/network/flat/FlatNetwork", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FlatNetwork); }
		}

		protected FlatNetwork (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_IIIIZ;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.encog.engine.network.flat']/class[@name='FlatNetwork']/constructor[@name='FlatNetwork' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='boolean']]"
		[Register (".ctor", "(IIIIZ)V", "")]
		public unsafe FlatNetwork (int p0, int p1, int p2, int p3, bool p4)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				if (GetType () != typeof (FlatNetwork)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(IIIIZ)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(IIIIZ)V", __args);
					return;
				}

				if (id_ctor_IIIIZ == IntPtr.Zero)
					id_ctor_IIIIZ = JNIEnv.GetMethodID (class_ref, "<init>", "(IIIIZ)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IIIIZ, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_IIIIZ, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_arrayLorg_encog_engine_network_flat_FlatLayer_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.encog.engine.network.flat']/class[@name='FlatNetwork']/constructor[@name='FlatNetwork' and count(parameter)=1 and parameter[1][@type='org.encog.engine.network.flat.FlatLayer[]']]"
		[Register (".ctor", "([Lorg/encog/engine/network/flat/FlatLayer;)V", "")]
		public unsafe FlatNetwork (global::Org.Encog.Engine.Network.Flat.FlatLayer[] p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (FlatNetwork)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "([Lorg/encog/engine/network/flat/FlatLayer;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "([Lorg/encog/engine/network/flat/FlatLayer;)V", __args);
					return;
				}

				if (id_ctor_arrayLorg_encog_engine_network_flat_FlatLayer_ == IntPtr.Zero)
					id_ctor_arrayLorg_encog_engine_network_flat_FlatLayer_ = JNIEnv.GetMethodID (class_ref, "<init>", "([Lorg/encog/engine/network/flat/FlatLayer;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayLorg_encog_engine_network_flat_FlatLayer_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_arrayLorg_encog_engine_network_flat_FlatLayer_, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.encog.engine.network.flat']/class[@name='FlatNetwork']/constructor[@name='FlatNetwork' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe FlatNetwork ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (FlatNetwork)) {
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

		static Delegate cb_getBeginTraining;
#pragma warning disable 0169
		static Delegate GetGetBeginTrainingHandler ()
		{
			if (cb_getBeginTraining == null)
				cb_getBeginTraining = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetBeginTraining);
			return cb_getBeginTraining;
		}

		static int n_GetBeginTraining (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Network.Flat.FlatNetwork __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Flat.FlatNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BeginTraining;
		}
#pragma warning restore 0169

		static Delegate cb_setBeginTraining_I;
#pragma warning disable 0169
		static Delegate GetSetBeginTraining_IHandler ()
		{
			if (cb_setBeginTraining_I == null)
				cb_setBeginTraining_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetBeginTraining_I);
			return cb_setBeginTraining_I;
		}

		static void n_SetBeginTraining_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Encog.Engine.Network.Flat.FlatNetwork __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Flat.FlatNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.BeginTraining = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getBeginTraining;
		static IntPtr id_setBeginTraining_I;
		public virtual unsafe int BeginTraining {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.flat']/class[@name='FlatNetwork']/method[@name='getBeginTraining' and count(parameter)=0]"
			[Register ("getBeginTraining", "()I", "GetGetBeginTrainingHandler")]
			get {
				if (id_getBeginTraining == IntPtr.Zero)
					id_getBeginTraining = JNIEnv.GetMethodID (class_ref, "getBeginTraining", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getBeginTraining);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBeginTraining", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.flat']/class[@name='FlatNetwork']/method[@name='setBeginTraining' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setBeginTraining", "(I)V", "GetSetBeginTraining_IHandler")]
			set {
				if (id_setBeginTraining_I == IntPtr.Zero)
					id_setBeginTraining_I = JNIEnv.GetMethodID (class_ref, "setBeginTraining", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBeginTraining_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBeginTraining", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getConnectionLimit;
#pragma warning disable 0169
		static Delegate GetGetConnectionLimitHandler ()
		{
			if (cb_getConnectionLimit == null)
				cb_getConnectionLimit = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetConnectionLimit);
			return cb_getConnectionLimit;
		}

		static double n_GetConnectionLimit (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Network.Flat.FlatNetwork __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Flat.FlatNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ConnectionLimit;
		}
#pragma warning restore 0169

		static Delegate cb_setConnectionLimit_D;
#pragma warning disable 0169
		static Delegate GetSetConnectionLimit_DHandler ()
		{
			if (cb_setConnectionLimit_D == null)
				cb_setConnectionLimit_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetConnectionLimit_D);
			return cb_setConnectionLimit_D;
		}

		static void n_SetConnectionLimit_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Org.Encog.Engine.Network.Flat.FlatNetwork __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Flat.FlatNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ConnectionLimit = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getConnectionLimit;
		static IntPtr id_setConnectionLimit_D;
		public virtual unsafe double ConnectionLimit {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.flat']/class[@name='FlatNetwork']/method[@name='getConnectionLimit' and count(parameter)=0]"
			[Register ("getConnectionLimit", "()D", "GetGetConnectionLimitHandler")]
			get {
				if (id_getConnectionLimit == IntPtr.Zero)
					id_getConnectionLimit = JNIEnv.GetMethodID (class_ref, "getConnectionLimit", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getConnectionLimit);
					else
						return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getConnectionLimit", "()D"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.flat']/class[@name='FlatNetwork']/method[@name='setConnectionLimit' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setConnectionLimit", "(D)V", "GetSetConnectionLimit_DHandler")]
			set {
				if (id_setConnectionLimit_D == IntPtr.Zero)
					id_setConnectionLimit_D = JNIEnv.GetMethodID (class_ref, "setConnectionLimit", "(D)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setConnectionLimit_D, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setConnectionLimit", "(D)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getEncodeLength;
#pragma warning disable 0169
		static Delegate GetGetEncodeLengthHandler ()
		{
			if (cb_getEncodeLength == null)
				cb_getEncodeLength = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetEncodeLength);
			return cb_getEncodeLength;
		}

		static int n_GetEncodeLength (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Network.Flat.FlatNetwork __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Flat.FlatNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.EncodeLength;
		}
#pragma warning restore 0169

		static IntPtr id_getEncodeLength;
		public virtual unsafe int EncodeLength {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.flat']/class[@name='FlatNetwork']/method[@name='getEncodeLength' and count(parameter)=0]"
			[Register ("getEncodeLength", "()I", "GetGetEncodeLengthHandler")]
			get {
				if (id_getEncodeLength == IntPtr.Zero)
					id_getEncodeLength = JNIEnv.GetMethodID (class_ref, "getEncodeLength", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getEncodeLength);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEncodeLength", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getEndTraining;
#pragma warning disable 0169
		static Delegate GetGetEndTrainingHandler ()
		{
			if (cb_getEndTraining == null)
				cb_getEndTraining = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetEndTraining);
			return cb_getEndTraining;
		}

		static int n_GetEndTraining (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Network.Flat.FlatNetwork __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Flat.FlatNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.EndTraining;
		}
#pragma warning restore 0169

		static Delegate cb_setEndTraining_I;
#pragma warning disable 0169
		static Delegate GetSetEndTraining_IHandler ()
		{
			if (cb_setEndTraining_I == null)
				cb_setEndTraining_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetEndTraining_I);
			return cb_setEndTraining_I;
		}

		static void n_SetEndTraining_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Encog.Engine.Network.Flat.FlatNetwork __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Flat.FlatNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EndTraining = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getEndTraining;
		static IntPtr id_setEndTraining_I;
		public virtual unsafe int EndTraining {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.flat']/class[@name='FlatNetwork']/method[@name='getEndTraining' and count(parameter)=0]"
			[Register ("getEndTraining", "()I", "GetGetEndTrainingHandler")]
			get {
				if (id_getEndTraining == IntPtr.Zero)
					id_getEndTraining = JNIEnv.GetMethodID (class_ref, "getEndTraining", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getEndTraining);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEndTraining", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.flat']/class[@name='FlatNetwork']/method[@name='setEndTraining' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setEndTraining", "(I)V", "GetSetEndTraining_IHandler")]
			set {
				if (id_setEndTraining_I == IntPtr.Zero)
					id_setEndTraining_I = JNIEnv.GetMethodID (class_ref, "setEndTraining", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setEndTraining_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEndTraining", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getInputCount;
#pragma warning disable 0169
		static Delegate GetGetInputCountHandler ()
		{
			if (cb_getInputCount == null)
				cb_getInputCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetInputCount);
			return cb_getInputCount;
		}

		static int n_GetInputCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Network.Flat.FlatNetwork __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Flat.FlatNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.InputCount;
		}
#pragma warning restore 0169

		static IntPtr id_getInputCount;
		public virtual unsafe int InputCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.flat']/class[@name='FlatNetwork']/method[@name='getInputCount' and count(parameter)=0]"
			[Register ("getInputCount", "()I", "GetGetInputCountHandler")]
			get {
				if (id_getInputCount == IntPtr.Zero)
					id_getInputCount = JNIEnv.GetMethodID (class_ref, "getInputCount", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getInputCount);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getInputCount", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_isLimited;
#pragma warning disable 0169
		static Delegate GetIsLimitedHandler ()
		{
			if (cb_isLimited == null)
				cb_isLimited = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsLimited);
			return cb_isLimited;
		}

		static bool n_IsLimited (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Network.Flat.FlatNetwork __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Flat.FlatNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsLimited;
		}
#pragma warning restore 0169

		static IntPtr id_isLimited;
		public virtual unsafe bool IsLimited {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.flat']/class[@name='FlatNetwork']/method[@name='isLimited' and count(parameter)=0]"
			[Register ("isLimited", "()Z", "GetIsLimitedHandler")]
			get {
				if (id_isLimited == IntPtr.Zero)
					id_isLimited = JNIEnv.GetMethodID (class_ref, "isLimited", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isLimited);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isLimited", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getNeuronCount;
#pragma warning disable 0169
		static Delegate GetGetNeuronCountHandler ()
		{
			if (cb_getNeuronCount == null)
				cb_getNeuronCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNeuronCount);
			return cb_getNeuronCount;
		}

		static int n_GetNeuronCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Network.Flat.FlatNetwork __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Flat.FlatNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NeuronCount;
		}
#pragma warning restore 0169

		static IntPtr id_getNeuronCount;
		public virtual unsafe int NeuronCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.flat']/class[@name='FlatNetwork']/method[@name='getNeuronCount' and count(parameter)=0]"
			[Register ("getNeuronCount", "()I", "GetGetNeuronCountHandler")]
			get {
				if (id_getNeuronCount == IntPtr.Zero)
					id_getNeuronCount = JNIEnv.GetMethodID (class_ref, "getNeuronCount", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getNeuronCount);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNeuronCount", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getOutputCount;
#pragma warning disable 0169
		static Delegate GetGetOutputCountHandler ()
		{
			if (cb_getOutputCount == null)
				cb_getOutputCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetOutputCount);
			return cb_getOutputCount;
		}

		static int n_GetOutputCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Network.Flat.FlatNetwork __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Flat.FlatNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.OutputCount;
		}
#pragma warning restore 0169

		static IntPtr id_getOutputCount;
		public virtual unsafe int OutputCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.flat']/class[@name='FlatNetwork']/method[@name='getOutputCount' and count(parameter)=0]"
			[Register ("getOutputCount", "()I", "GetGetOutputCountHandler")]
			get {
				if (id_getOutputCount == IntPtr.Zero)
					id_getOutputCount = JNIEnv.GetMethodID (class_ref, "getOutputCount", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getOutputCount);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOutputCount", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_calculateError_Lorg_encog_engine_data_EngineIndexableSet_;
#pragma warning disable 0169
		static Delegate GetCalculateError_Lorg_encog_engine_data_EngineIndexableSet_Handler ()
		{
			if (cb_calculateError_Lorg_encog_engine_data_EngineIndexableSet_ == null)
				cb_calculateError_Lorg_encog_engine_data_EngineIndexableSet_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, double>) n_CalculateError_Lorg_encog_engine_data_EngineIndexableSet_);
			return cb_calculateError_Lorg_encog_engine_data_EngineIndexableSet_;
		}

		static double n_CalculateError_Lorg_encog_engine_data_EngineIndexableSet_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Encog.Engine.Network.Flat.FlatNetwork __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Flat.FlatNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Encog.Engine.Data.IEngineIndexableSet p0 = (global::Org.Encog.Engine.Data.IEngineIndexableSet)global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Data.IEngineIndexableSet> (native_p0, JniHandleOwnership.DoNotTransfer);
			double __ret = __this.CalculateError (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_calculateError_Lorg_encog_engine_data_EngineIndexableSet_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.flat']/class[@name='FlatNetwork']/method[@name='calculateError' and count(parameter)=1 and parameter[1][@type='org.encog.engine.data.EngineIndexableSet']]"
		[Register ("calculateError", "(Lorg/encog/engine/data/EngineIndexableSet;)D", "GetCalculateError_Lorg_encog_engine_data_EngineIndexableSet_Handler")]
		public virtual unsafe double CalculateError (global::Org.Encog.Engine.Data.IEngineIndexableSet p0)
		{
			if (id_calculateError_Lorg_encog_engine_data_EngineIndexableSet_ == IntPtr.Zero)
				id_calculateError_Lorg_encog_engine_data_EngineIndexableSet_ = JNIEnv.GetMethodID (class_ref, "calculateError", "(Lorg/encog/engine/data/EngineIndexableSet;)D");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				double __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_calculateError_Lorg_encog_engine_data_EngineIndexableSet_, __args);
				else
					__ret = JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "calculateError", "(Lorg/encog/engine/data/EngineIndexableSet;)D"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_clearConnectionLimit;
#pragma warning disable 0169
		static Delegate GetClearConnectionLimitHandler ()
		{
			if (cb_clearConnectionLimit == null)
				cb_clearConnectionLimit = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClearConnectionLimit);
			return cb_clearConnectionLimit;
		}

		static void n_ClearConnectionLimit (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Network.Flat.FlatNetwork __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Flat.FlatNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearConnectionLimit ();
		}
#pragma warning restore 0169

		static IntPtr id_clearConnectionLimit;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.flat']/class[@name='FlatNetwork']/method[@name='clearConnectionLimit' and count(parameter)=0]"
		[Register ("clearConnectionLimit", "()V", "GetClearConnectionLimitHandler")]
		public virtual unsafe void ClearConnectionLimit ()
		{
			if (id_clearConnectionLimit == IntPtr.Zero)
				id_clearConnectionLimit = JNIEnv.GetMethodID (class_ref, "clearConnectionLimit", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clearConnectionLimit);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clearConnectionLimit", "()V"));
			} finally {
			}
		}

		static Delegate cb_clearContext;
#pragma warning disable 0169
		static Delegate GetClearContextHandler ()
		{
			if (cb_clearContext == null)
				cb_clearContext = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClearContext);
			return cb_clearContext;
		}

		static void n_ClearContext (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Network.Flat.FlatNetwork __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Flat.FlatNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearContext ();
		}
#pragma warning restore 0169

		static IntPtr id_clearContext;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.flat']/class[@name='FlatNetwork']/method[@name='clearContext' and count(parameter)=0]"
		[Register ("clearContext", "()V", "GetClearContextHandler")]
		public virtual unsafe void ClearContext ()
		{
			if (id_clearContext == IntPtr.Zero)
				id_clearContext = JNIEnv.GetMethodID (class_ref, "clearContext", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clearContext);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clearContext", "()V"));
			} finally {
			}
		}

		static Delegate cb_clone;
#pragma warning disable 0169
		static Delegate GetCloneHandler ()
		{
			if (cb_clone == null)
				cb_clone = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Clone);
			return cb_clone;
		}

		static IntPtr n_Clone (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Network.Flat.FlatNetwork __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Flat.FlatNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Clone ());
		}
#pragma warning restore 0169

		static IntPtr id_clone;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.flat']/class[@name='FlatNetwork']/method[@name='clone' and count(parameter)=0]"
		[Register ("clone", "()Lorg/encog/engine/network/flat/FlatNetwork;", "GetCloneHandler")]
		public virtual unsafe global::Org.Encog.Engine.Network.Flat.FlatNetwork Clone ()
		{
			if (id_clone == IntPtr.Zero)
				id_clone = JNIEnv.GetMethodID (class_ref, "clone", "()Lorg/encog/engine/network/flat/FlatNetwork;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Flat.FlatNetwork> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_clone), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Flat.FlatNetwork> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clone", "()Lorg/encog/engine/network/flat/FlatNetwork;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_cloneFlatNetwork_Lorg_encog_engine_network_flat_FlatNetwork_;
#pragma warning disable 0169
		static Delegate GetCloneFlatNetwork_Lorg_encog_engine_network_flat_FlatNetwork_Handler ()
		{
			if (cb_cloneFlatNetwork_Lorg_encog_engine_network_flat_FlatNetwork_ == null)
				cb_cloneFlatNetwork_Lorg_encog_engine_network_flat_FlatNetwork_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_CloneFlatNetwork_Lorg_encog_engine_network_flat_FlatNetwork_);
			return cb_cloneFlatNetwork_Lorg_encog_engine_network_flat_FlatNetwork_;
		}

		static void n_CloneFlatNetwork_Lorg_encog_engine_network_flat_FlatNetwork_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Encog.Engine.Network.Flat.FlatNetwork __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Flat.FlatNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Encog.Engine.Network.Flat.FlatNetwork p0 = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Flat.FlatNetwork> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CloneFlatNetwork (p0);
		}
#pragma warning restore 0169

		static IntPtr id_cloneFlatNetwork_Lorg_encog_engine_network_flat_FlatNetwork_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.flat']/class[@name='FlatNetwork']/method[@name='cloneFlatNetwork' and count(parameter)=1 and parameter[1][@type='org.encog.engine.network.flat.FlatNetwork']]"
		[Register ("cloneFlatNetwork", "(Lorg/encog/engine/network/flat/FlatNetwork;)V", "GetCloneFlatNetwork_Lorg_encog_engine_network_flat_FlatNetwork_Handler")]
		public virtual unsafe void CloneFlatNetwork (global::Org.Encog.Engine.Network.Flat.FlatNetwork p0)
		{
			if (id_cloneFlatNetwork_Lorg_encog_engine_network_flat_FlatNetwork_ == IntPtr.Zero)
				id_cloneFlatNetwork_Lorg_encog_engine_network_flat_FlatNetwork_ = JNIEnv.GetMethodID (class_ref, "cloneFlatNetwork", "(Lorg/encog/engine/network/flat/FlatNetwork;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_cloneFlatNetwork_Lorg_encog_engine_network_flat_FlatNetwork_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "cloneFlatNetwork", "(Lorg/encog/engine/network/flat/FlatNetwork;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_compute_arrayDarrayD;
#pragma warning disable 0169
		static Delegate GetCompute_arrayDarrayDHandler ()
		{
			if (cb_compute_arrayDarrayD == null)
				cb_compute_arrayDarrayD = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Compute_arrayDarrayD);
			return cb_compute_arrayDarrayD;
		}

		static void n_Compute_arrayDarrayD (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Encog.Engine.Network.Flat.FlatNetwork __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Flat.FlatNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			double[] p0 = (double[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (double));
			double[] p1 = (double[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (double));
			__this.Compute (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		static IntPtr id_compute_arrayDarrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.flat']/class[@name='FlatNetwork']/method[@name='compute' and count(parameter)=2 and parameter[1][@type='double[]'] and parameter[2][@type='double[]']]"
		[Register ("compute", "([D[D)V", "GetCompute_arrayDarrayDHandler")]
		public virtual unsafe void Compute (double[] p0, double[] p1)
		{
			if (id_compute_arrayDarrayD == IntPtr.Zero)
				id_compute_arrayDarrayD = JNIEnv.GetMethodID (class_ref, "compute", "([D[D)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_compute_arrayDarrayD, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "compute", "([D[D)V"), __args);
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

		static Delegate cb_computeLayer_I;
#pragma warning disable 0169
		static Delegate GetComputeLayer_IHandler ()
		{
			if (cb_computeLayer_I == null)
				cb_computeLayer_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_ComputeLayer_I);
			return cb_computeLayer_I;
		}

		static void n_ComputeLayer_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Encog.Engine.Network.Flat.FlatNetwork __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Flat.FlatNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ComputeLayer (p0);
		}
#pragma warning restore 0169

		static IntPtr id_computeLayer_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.flat']/class[@name='FlatNetwork']/method[@name='computeLayer' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("computeLayer", "(I)V", "GetComputeLayer_IHandler")]
		protected virtual unsafe void ComputeLayer (int p0)
		{
			if (id_computeLayer_I == IntPtr.Zero)
				id_computeLayer_I = JNIEnv.GetMethodID (class_ref, "computeLayer", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_computeLayer_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "computeLayer", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_decodeNetwork_arrayD;
#pragma warning disable 0169
		static Delegate GetDecodeNetwork_arrayDHandler ()
		{
			if (cb_decodeNetwork_arrayD == null)
				cb_decodeNetwork_arrayD = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DecodeNetwork_arrayD);
			return cb_decodeNetwork_arrayD;
		}

		static void n_DecodeNetwork_arrayD (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Encog.Engine.Network.Flat.FlatNetwork __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Flat.FlatNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			double[] p0 = (double[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (double));
			__this.DecodeNetwork (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_decodeNetwork_arrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.flat']/class[@name='FlatNetwork']/method[@name='decodeNetwork' and count(parameter)=1 and parameter[1][@type='double[]']]"
		[Register ("decodeNetwork", "([D)V", "GetDecodeNetwork_arrayDHandler")]
		public virtual unsafe void DecodeNetwork (double[] p0)
		{
			if (id_decodeNetwork_arrayD == IntPtr.Zero)
				id_decodeNetwork_arrayD = JNIEnv.GetMethodID (class_ref, "decodeNetwork", "([D)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_decodeNetwork_arrayD, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "decodeNetwork", "([D)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_encodeNetwork;
#pragma warning disable 0169
		static Delegate GetEncodeNetworkHandler ()
		{
			if (cb_encodeNetwork == null)
				cb_encodeNetwork = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_EncodeNetwork);
			return cb_encodeNetwork;
		}

		static IntPtr n_EncodeNetwork (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Network.Flat.FlatNetwork __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Flat.FlatNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.EncodeNetwork ());
		}
#pragma warning restore 0169

		static IntPtr id_encodeNetwork;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.flat']/class[@name='FlatNetwork']/method[@name='encodeNetwork' and count(parameter)=0]"
		[Register ("encodeNetwork", "()[D", "GetEncodeNetworkHandler")]
		public virtual unsafe double[] EncodeNetwork ()
		{
			if (id_encodeNetwork == IntPtr.Zero)
				id_encodeNetwork = JNIEnv.GetMethodID (class_ref, "encodeNetwork", "()[D");
			try {

				if (GetType () == ThresholdType)
					return (double[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_encodeNetwork), JniHandleOwnership.TransferLocalRef, typeof (double));
				else
					return (double[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "encodeNetwork", "()[D")), JniHandleOwnership.TransferLocalRef, typeof (double));
			} finally {
			}
		}

		static Delegate cb_getActivationFunctions;
#pragma warning disable 0169
		static Delegate GetGetActivationFunctionsHandler ()
		{
			if (cb_getActivationFunctions == null)
				cb_getActivationFunctions = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetActivationFunctions);
			return cb_getActivationFunctions;
		}

		static IntPtr n_GetActivationFunctions (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Network.Flat.FlatNetwork __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Flat.FlatNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetActivationFunctions ());
		}
#pragma warning restore 0169

		static IntPtr id_getActivationFunctions;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.flat']/class[@name='FlatNetwork']/method[@name='getActivationFunctions' and count(parameter)=0]"
		[Register ("getActivationFunctions", "()[Lorg/encog/engine/network/activation/ActivationFunction;", "GetGetActivationFunctionsHandler")]
		public virtual unsafe global::Org.Encog.Engine.Network.Activation.IActivationFunction[] GetActivationFunctions ()
		{
			if (id_getActivationFunctions == IntPtr.Zero)
				id_getActivationFunctions = JNIEnv.GetMethodID (class_ref, "getActivationFunctions", "()[Lorg/encog/engine/network/activation/ActivationFunction;");
			try {

				if (GetType () == ThresholdType)
					return (global::Org.Encog.Engine.Network.Activation.IActivationFunction[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getActivationFunctions), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Encog.Engine.Network.Activation.IActivationFunction));
				else
					return (global::Org.Encog.Engine.Network.Activation.IActivationFunction[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getActivationFunctions", "()[Lorg/encog/engine/network/activation/ActivationFunction;")), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Encog.Engine.Network.Activation.IActivationFunction));
			} finally {
			}
		}

		static Delegate cb_getContextTargetOffset;
#pragma warning disable 0169
		static Delegate GetGetContextTargetOffsetHandler ()
		{
			if (cb_getContextTargetOffset == null)
				cb_getContextTargetOffset = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContextTargetOffset);
			return cb_getContextTargetOffset;
		}

		static IntPtr n_GetContextTargetOffset (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Network.Flat.FlatNetwork __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Flat.FlatNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetContextTargetOffset ());
		}
#pragma warning restore 0169

		static IntPtr id_getContextTargetOffset;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.flat']/class[@name='FlatNetwork']/method[@name='getContextTargetOffset' and count(parameter)=0]"
		[Register ("getContextTargetOffset", "()[I", "GetGetContextTargetOffsetHandler")]
		public virtual unsafe int[] GetContextTargetOffset ()
		{
			if (id_getContextTargetOffset == IntPtr.Zero)
				id_getContextTargetOffset = JNIEnv.GetMethodID (class_ref, "getContextTargetOffset", "()[I");
			try {

				if (GetType () == ThresholdType)
					return (int[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getContextTargetOffset), JniHandleOwnership.TransferLocalRef, typeof (int));
				else
					return (int[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getContextTargetOffset", "()[I")), JniHandleOwnership.TransferLocalRef, typeof (int));
			} finally {
			}
		}

		static Delegate cb_getContextTargetSize;
#pragma warning disable 0169
		static Delegate GetGetContextTargetSizeHandler ()
		{
			if (cb_getContextTargetSize == null)
				cb_getContextTargetSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContextTargetSize);
			return cb_getContextTargetSize;
		}

		static IntPtr n_GetContextTargetSize (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Network.Flat.FlatNetwork __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Flat.FlatNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetContextTargetSize ());
		}
#pragma warning restore 0169

		static IntPtr id_getContextTargetSize;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.flat']/class[@name='FlatNetwork']/method[@name='getContextTargetSize' and count(parameter)=0]"
		[Register ("getContextTargetSize", "()[I", "GetGetContextTargetSizeHandler")]
		public virtual unsafe int[] GetContextTargetSize ()
		{
			if (id_getContextTargetSize == IntPtr.Zero)
				id_getContextTargetSize = JNIEnv.GetMethodID (class_ref, "getContextTargetSize", "()[I");
			try {

				if (GetType () == ThresholdType)
					return (int[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getContextTargetSize), JniHandleOwnership.TransferLocalRef, typeof (int));
				else
					return (int[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getContextTargetSize", "()[I")), JniHandleOwnership.TransferLocalRef, typeof (int));
			} finally {
			}
		}

		static Delegate cb_getLayerCounts;
#pragma warning disable 0169
		static Delegate GetGetLayerCountsHandler ()
		{
			if (cb_getLayerCounts == null)
				cb_getLayerCounts = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLayerCounts);
			return cb_getLayerCounts;
		}

		static IntPtr n_GetLayerCounts (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Network.Flat.FlatNetwork __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Flat.FlatNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetLayerCounts ());
		}
#pragma warning restore 0169

		static IntPtr id_getLayerCounts;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.flat']/class[@name='FlatNetwork']/method[@name='getLayerCounts' and count(parameter)=0]"
		[Register ("getLayerCounts", "()[I", "GetGetLayerCountsHandler")]
		public virtual unsafe int[] GetLayerCounts ()
		{
			if (id_getLayerCounts == IntPtr.Zero)
				id_getLayerCounts = JNIEnv.GetMethodID (class_ref, "getLayerCounts", "()[I");
			try {

				if (GetType () == ThresholdType)
					return (int[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLayerCounts), JniHandleOwnership.TransferLocalRef, typeof (int));
				else
					return (int[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLayerCounts", "()[I")), JniHandleOwnership.TransferLocalRef, typeof (int));
			} finally {
			}
		}

		static Delegate cb_getLayerFeedCounts;
#pragma warning disable 0169
		static Delegate GetGetLayerFeedCountsHandler ()
		{
			if (cb_getLayerFeedCounts == null)
				cb_getLayerFeedCounts = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLayerFeedCounts);
			return cb_getLayerFeedCounts;
		}

		static IntPtr n_GetLayerFeedCounts (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Network.Flat.FlatNetwork __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Flat.FlatNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetLayerFeedCounts ());
		}
#pragma warning restore 0169

		static IntPtr id_getLayerFeedCounts;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.flat']/class[@name='FlatNetwork']/method[@name='getLayerFeedCounts' and count(parameter)=0]"
		[Register ("getLayerFeedCounts", "()[I", "GetGetLayerFeedCountsHandler")]
		public virtual unsafe int[] GetLayerFeedCounts ()
		{
			if (id_getLayerFeedCounts == IntPtr.Zero)
				id_getLayerFeedCounts = JNIEnv.GetMethodID (class_ref, "getLayerFeedCounts", "()[I");
			try {

				if (GetType () == ThresholdType)
					return (int[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLayerFeedCounts), JniHandleOwnership.TransferLocalRef, typeof (int));
				else
					return (int[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLayerFeedCounts", "()[I")), JniHandleOwnership.TransferLocalRef, typeof (int));
			} finally {
			}
		}

		static Delegate cb_getLayerIndex;
#pragma warning disable 0169
		static Delegate GetGetLayerIndexHandler ()
		{
			if (cb_getLayerIndex == null)
				cb_getLayerIndex = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLayerIndex);
			return cb_getLayerIndex;
		}

		static IntPtr n_GetLayerIndex (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Network.Flat.FlatNetwork __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Flat.FlatNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetLayerIndex ());
		}
#pragma warning restore 0169

		static IntPtr id_getLayerIndex;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.flat']/class[@name='FlatNetwork']/method[@name='getLayerIndex' and count(parameter)=0]"
		[Register ("getLayerIndex", "()[I", "GetGetLayerIndexHandler")]
		public virtual unsafe int[] GetLayerIndex ()
		{
			if (id_getLayerIndex == IntPtr.Zero)
				id_getLayerIndex = JNIEnv.GetMethodID (class_ref, "getLayerIndex", "()[I");
			try {

				if (GetType () == ThresholdType)
					return (int[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLayerIndex), JniHandleOwnership.TransferLocalRef, typeof (int));
				else
					return (int[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLayerIndex", "()[I")), JniHandleOwnership.TransferLocalRef, typeof (int));
			} finally {
			}
		}

		static Delegate cb_getLayerOutput;
#pragma warning disable 0169
		static Delegate GetGetLayerOutputHandler ()
		{
			if (cb_getLayerOutput == null)
				cb_getLayerOutput = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLayerOutput);
			return cb_getLayerOutput;
		}

		static IntPtr n_GetLayerOutput (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Network.Flat.FlatNetwork __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Flat.FlatNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetLayerOutput ());
		}
#pragma warning restore 0169

		static IntPtr id_getLayerOutput;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.flat']/class[@name='FlatNetwork']/method[@name='getLayerOutput' and count(parameter)=0]"
		[Register ("getLayerOutput", "()[D", "GetGetLayerOutputHandler")]
		public virtual unsafe double[] GetLayerOutput ()
		{
			if (id_getLayerOutput == IntPtr.Zero)
				id_getLayerOutput = JNIEnv.GetMethodID (class_ref, "getLayerOutput", "()[D");
			try {

				if (GetType () == ThresholdType)
					return (double[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLayerOutput), JniHandleOwnership.TransferLocalRef, typeof (double));
				else
					return (double[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLayerOutput", "()[D")), JniHandleOwnership.TransferLocalRef, typeof (double));
			} finally {
			}
		}

		static Delegate cb_getWeightIndex;
#pragma warning disable 0169
		static Delegate GetGetWeightIndexHandler ()
		{
			if (cb_getWeightIndex == null)
				cb_getWeightIndex = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetWeightIndex);
			return cb_getWeightIndex;
		}

		static IntPtr n_GetWeightIndex (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Network.Flat.FlatNetwork __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Flat.FlatNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetWeightIndex ());
		}
#pragma warning restore 0169

		static IntPtr id_getWeightIndex;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.flat']/class[@name='FlatNetwork']/method[@name='getWeightIndex' and count(parameter)=0]"
		[Register ("getWeightIndex", "()[I", "GetGetWeightIndexHandler")]
		public virtual unsafe int[] GetWeightIndex ()
		{
			if (id_getWeightIndex == IntPtr.Zero)
				id_getWeightIndex = JNIEnv.GetMethodID (class_ref, "getWeightIndex", "()[I");
			try {

				if (GetType () == ThresholdType)
					return (int[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getWeightIndex), JniHandleOwnership.TransferLocalRef, typeof (int));
				else
					return (int[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWeightIndex", "()[I")), JniHandleOwnership.TransferLocalRef, typeof (int));
			} finally {
			}
		}

		static Delegate cb_getWeights;
#pragma warning disable 0169
		static Delegate GetGetWeightsHandler ()
		{
			if (cb_getWeights == null)
				cb_getWeights = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetWeights);
			return cb_getWeights;
		}

		static IntPtr n_GetWeights (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Network.Flat.FlatNetwork __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Flat.FlatNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetWeights ());
		}
#pragma warning restore 0169

		static IntPtr id_getWeights;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.flat']/class[@name='FlatNetwork']/method[@name='getWeights' and count(parameter)=0]"
		[Register ("getWeights", "()[D", "GetGetWeightsHandler")]
		public virtual unsafe double[] GetWeights ()
		{
			if (id_getWeights == IntPtr.Zero)
				id_getWeights = JNIEnv.GetMethodID (class_ref, "getWeights", "()[D");
			try {

				if (GetType () == ThresholdType)
					return (double[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getWeights), JniHandleOwnership.TransferLocalRef, typeof (double));
				else
					return (double[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWeights", "()[D")), JniHandleOwnership.TransferLocalRef, typeof (double));
			} finally {
			}
		}

		static Delegate cb_hasSameActivationFunction;
#pragma warning disable 0169
		static Delegate GetHasSameActivationFunctionHandler ()
		{
			if (cb_hasSameActivationFunction == null)
				cb_hasSameActivationFunction = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_HasSameActivationFunction);
			return cb_hasSameActivationFunction;
		}

		static IntPtr n_HasSameActivationFunction (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Network.Flat.FlatNetwork __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Flat.FlatNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.HasSameActivationFunction ());
		}
#pragma warning restore 0169

		static IntPtr id_hasSameActivationFunction;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.flat']/class[@name='FlatNetwork']/method[@name='hasSameActivationFunction' and count(parameter)=0]"
		[Register ("hasSameActivationFunction", "()Ljava/lang/Class;", "GetHasSameActivationFunctionHandler")]
		public virtual unsafe global::Java.Lang.Class HasSameActivationFunction ()
		{
			if (id_hasSameActivationFunction == IntPtr.Zero)
				id_hasSameActivationFunction = JNIEnv.GetMethodID (class_ref, "hasSameActivationFunction", "()Ljava/lang/Class;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_hasSameActivationFunction), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hasSameActivationFunction", "()Ljava/lang/Class;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_init_arrayLorg_encog_engine_network_flat_FlatLayer_;
#pragma warning disable 0169
		static Delegate GetInit_arrayLorg_encog_engine_network_flat_FlatLayer_Handler ()
		{
			if (cb_init_arrayLorg_encog_engine_network_flat_FlatLayer_ == null)
				cb_init_arrayLorg_encog_engine_network_flat_FlatLayer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Init_arrayLorg_encog_engine_network_flat_FlatLayer_);
			return cb_init_arrayLorg_encog_engine_network_flat_FlatLayer_;
		}

		static void n_Init_arrayLorg_encog_engine_network_flat_FlatLayer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Encog.Engine.Network.Flat.FlatNetwork __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Flat.FlatNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Encog.Engine.Network.Flat.FlatLayer[] p0 = (global::Org.Encog.Engine.Network.Flat.FlatLayer[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Org.Encog.Engine.Network.Flat.FlatLayer));
			__this.Init (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_init_arrayLorg_encog_engine_network_flat_FlatLayer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.flat']/class[@name='FlatNetwork']/method[@name='init' and count(parameter)=1 and parameter[1][@type='org.encog.engine.network.flat.FlatLayer[]']]"
		[Register ("init", "([Lorg/encog/engine/network/flat/FlatLayer;)V", "GetInit_arrayLorg_encog_engine_network_flat_FlatLayer_Handler")]
		public virtual unsafe void Init (global::Org.Encog.Engine.Network.Flat.FlatLayer[] p0)
		{
			if (id_init_arrayLorg_encog_engine_network_flat_FlatLayer_ == IntPtr.Zero)
				id_init_arrayLorg_encog_engine_network_flat_FlatLayer_ = JNIEnv.GetMethodID (class_ref, "init", "([Lorg/encog/engine/network/flat/FlatLayer;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_init_arrayLorg_encog_engine_network_flat_FlatLayer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "init", "([Lorg/encog/engine/network/flat/FlatLayer;)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_randomize;
#pragma warning disable 0169
		static Delegate GetRandomizeHandler ()
		{
			if (cb_randomize == null)
				cb_randomize = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Randomize);
			return cb_randomize;
		}

		static void n_Randomize (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Network.Flat.FlatNetwork __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Flat.FlatNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Randomize ();
		}
#pragma warning restore 0169

		static IntPtr id_randomize;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.flat']/class[@name='FlatNetwork']/method[@name='randomize' and count(parameter)=0]"
		[Register ("randomize", "()V", "GetRandomizeHandler")]
		public virtual unsafe void Randomize ()
		{
			if (id_randomize == IntPtr.Zero)
				id_randomize = JNIEnv.GetMethodID (class_ref, "randomize", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_randomize);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "randomize", "()V"));
			} finally {
			}
		}

		static Delegate cb_randomize_DD;
#pragma warning disable 0169
		static Delegate GetRandomize_DDHandler ()
		{
			if (cb_randomize_DD == null)
				cb_randomize_DD = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double, double>) n_Randomize_DD);
			return cb_randomize_DD;
		}

		static void n_Randomize_DD (IntPtr jnienv, IntPtr native__this, double p0, double p1)
		{
			global::Org.Encog.Engine.Network.Flat.FlatNetwork __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Flat.FlatNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Randomize (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_randomize_DD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.flat']/class[@name='FlatNetwork']/method[@name='randomize' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='double']]"
		[Register ("randomize", "(DD)V", "GetRandomize_DDHandler")]
		public virtual unsafe void Randomize (double p0, double p1)
		{
			if (id_randomize_DD == IntPtr.Zero)
				id_randomize_DD = JNIEnv.GetMethodID (class_ref, "randomize", "(DD)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_randomize_DD, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "randomize", "(DD)V"), __args);
			} finally {
			}
		}

	}
}
