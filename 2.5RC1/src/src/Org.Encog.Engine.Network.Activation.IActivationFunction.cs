using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Encog.Engine.Network.Activation {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.encog.engine.network.activation']/interface[@name='ActivationFunction']"
	[Register ("org/encog/engine/network/activation/ActivationFunction", "", "Org.Encog.Engine.Network.Activation.IActivationFunctionInvoker")]
	public partial interface IActivationFunction : global::Java.IO.ISerializable, global::Java.Lang.ICloneable {

		bool HasDerivative {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.activation']/interface[@name='ActivationFunction']/method[@name='hasDerivative' and count(parameter)=0]"
			[Register ("hasDerivative", "()Z", "GetHasDerivativeHandler:Org.Encog.Engine.Network.Activation.IActivationFunctionInvoker, neuroph_2.5RC1")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.activation']/interface[@name='ActivationFunction']/method[@name='activationFunction' and count(parameter)=3 and parameter[1][@type='double[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("activationFunction", "([DII)V", "GetActivationFunction_arrayDIIHandler:Org.Encog.Engine.Network.Activation.IActivationFunctionInvoker, neuroph_2.5RC1")]
		void ActivationFunction (double[] p0, int p1, int p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.activation']/interface[@name='ActivationFunction']/method[@name='clone' and count(parameter)=0]"
		[Register ("clone", "()Lorg/encog/engine/network/activation/ActivationFunction;", "GetCloneHandler:Org.Encog.Engine.Network.Activation.IActivationFunctionInvoker, neuroph_2.5RC1")]
		global::Org.Encog.Engine.Network.Activation.IActivationFunction Clone ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.activation']/interface[@name='ActivationFunction']/method[@name='derivativeFunction' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("derivativeFunction", "(D)D", "GetDerivativeFunction_DHandler:Org.Encog.Engine.Network.Activation.IActivationFunctionInvoker, neuroph_2.5RC1")]
		double DerivativeFunction (double p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.activation']/interface[@name='ActivationFunction']/method[@name='getOpenCLExpression' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("getOpenCLExpression", "(Z)Ljava/lang/String;", "GetGetOpenCLExpression_ZHandler:Org.Encog.Engine.Network.Activation.IActivationFunctionInvoker, neuroph_2.5RC1")]
		string GetOpenCLExpression (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.activation']/interface[@name='ActivationFunction']/method[@name='getParamNames' and count(parameter)=0]"
		[Register ("getParamNames", "()[Ljava/lang/String;", "GetGetParamNamesHandler:Org.Encog.Engine.Network.Activation.IActivationFunctionInvoker, neuroph_2.5RC1")]
		string[] GetParamNames ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.activation']/interface[@name='ActivationFunction']/method[@name='getParams' and count(parameter)=0]"
		[Register ("getParams", "()[D", "GetGetParamsHandler:Org.Encog.Engine.Network.Activation.IActivationFunctionInvoker, neuroph_2.5RC1")]
		double[] GetParams ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.activation']/interface[@name='ActivationFunction']/method[@name='setParam' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='double']]"
		[Register ("setParam", "(ID)V", "GetSetParam_IDHandler:Org.Encog.Engine.Network.Activation.IActivationFunctionInvoker, neuroph_2.5RC1")]
		void SetParam (int p0, double p1);

	}

	[global::Android.Runtime.Register ("org/encog/engine/network/activation/ActivationFunction", DoNotGenerateAcw=true)]
	internal class IActivationFunctionInvoker : global::Java.Lang.Object, IActivationFunction {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/encog/engine/network/activation/ActivationFunction");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IActivationFunctionInvoker); }
		}

		IntPtr class_ref;

		public static IActivationFunction GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IActivationFunction> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.encog.engine.network.activation.ActivationFunction"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IActivationFunctionInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_hasDerivative;
#pragma warning disable 0169
		static Delegate GetHasDerivativeHandler ()
		{
			if (cb_hasDerivative == null)
				cb_hasDerivative = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasDerivative);
			return cb_hasDerivative;
		}

		static bool n_HasDerivative (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Network.Activation.IActivationFunction __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Activation.IActivationFunction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasDerivative;
		}
#pragma warning restore 0169

		IntPtr id_hasDerivative;
		public unsafe bool HasDerivative {
			get {
				if (id_hasDerivative == IntPtr.Zero)
					id_hasDerivative = JNIEnv.GetMethodID (class_ref, "hasDerivative", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasDerivative);
			}
		}

		static Delegate cb_activationFunction_arrayDII;
#pragma warning disable 0169
		static Delegate GetActivationFunction_arrayDIIHandler ()
		{
			if (cb_activationFunction_arrayDII == null)
				cb_activationFunction_arrayDII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int>) n_ActivationFunction_arrayDII);
			return cb_activationFunction_arrayDII;
		}

		static void n_ActivationFunction_arrayDII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::Org.Encog.Engine.Network.Activation.IActivationFunction __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Activation.IActivationFunction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			double[] p0 = (double[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (double));
			__this.ActivationFunction (p0, p1, p2);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		IntPtr id_activationFunction_arrayDII;
		public unsafe void ActivationFunction (double[] p0, int p1, int p2)
		{
			if (id_activationFunction_arrayDII == IntPtr.Zero)
				id_activationFunction_arrayDII = JNIEnv.GetMethodID (class_ref, "activationFunction", "([DII)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_activationFunction_arrayDII, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
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
			global::Org.Encog.Engine.Network.Activation.IActivationFunction __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Activation.IActivationFunction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Clone ());
		}
#pragma warning restore 0169

		IntPtr id_clone;
		public unsafe global::Org.Encog.Engine.Network.Activation.IActivationFunction Clone ()
		{
			if (id_clone == IntPtr.Zero)
				id_clone = JNIEnv.GetMethodID (class_ref, "clone", "()Lorg/encog/engine/network/activation/ActivationFunction;");
			return global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Activation.IActivationFunction> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_clone), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_derivativeFunction_D;
#pragma warning disable 0169
		static Delegate GetDerivativeFunction_DHandler ()
		{
			if (cb_derivativeFunction_D == null)
				cb_derivativeFunction_D = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double, double>) n_DerivativeFunction_D);
			return cb_derivativeFunction_D;
		}

		static double n_DerivativeFunction_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Org.Encog.Engine.Network.Activation.IActivationFunction __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Activation.IActivationFunction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DerivativeFunction (p0);
		}
#pragma warning restore 0169

		IntPtr id_derivativeFunction_D;
		public unsafe double DerivativeFunction (double p0)
		{
			if (id_derivativeFunction_D == IntPtr.Zero)
				id_derivativeFunction_D = JNIEnv.GetMethodID (class_ref, "derivativeFunction", "(D)D");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_derivativeFunction_D, __args);
		}

		static Delegate cb_getOpenCLExpression_Z;
#pragma warning disable 0169
		static Delegate GetGetOpenCLExpression_ZHandler ()
		{
			if (cb_getOpenCLExpression_Z == null)
				cb_getOpenCLExpression_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_GetOpenCLExpression_Z);
			return cb_getOpenCLExpression_Z;
		}

		static IntPtr n_GetOpenCLExpression_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Org.Encog.Engine.Network.Activation.IActivationFunction __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Activation.IActivationFunction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GetOpenCLExpression (p0));
		}
#pragma warning restore 0169

		IntPtr id_getOpenCLExpression_Z;
		public unsafe string GetOpenCLExpression (bool p0)
		{
			if (id_getOpenCLExpression_Z == IntPtr.Zero)
				id_getOpenCLExpression_Z = JNIEnv.GetMethodID (class_ref, "getOpenCLExpression", "(Z)Ljava/lang/String;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOpenCLExpression_Z, __args), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_getParamNames;
#pragma warning disable 0169
		static Delegate GetGetParamNamesHandler ()
		{
			if (cb_getParamNames == null)
				cb_getParamNames = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetParamNames);
			return cb_getParamNames;
		}

		static IntPtr n_GetParamNames (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Network.Activation.IActivationFunction __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Activation.IActivationFunction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetParamNames ());
		}
#pragma warning restore 0169

		IntPtr id_getParamNames;
		public unsafe string[] GetParamNames ()
		{
			if (id_getParamNames == IntPtr.Zero)
				id_getParamNames = JNIEnv.GetMethodID (class_ref, "getParamNames", "()[Ljava/lang/String;");
			return (string[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getParamNames), JniHandleOwnership.TransferLocalRef, typeof (string));
		}

		static Delegate cb_getParams;
#pragma warning disable 0169
		static Delegate GetGetParamsHandler ()
		{
			if (cb_getParams == null)
				cb_getParams = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetParams);
			return cb_getParams;
		}

		static IntPtr n_GetParams (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Network.Activation.IActivationFunction __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Activation.IActivationFunction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetParams ());
		}
#pragma warning restore 0169

		IntPtr id_getParams;
		public unsafe double[] GetParams ()
		{
			if (id_getParams == IntPtr.Zero)
				id_getParams = JNIEnv.GetMethodID (class_ref, "getParams", "()[D");
			return (double[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getParams), JniHandleOwnership.TransferLocalRef, typeof (double));
		}

		static Delegate cb_setParam_ID;
#pragma warning disable 0169
		static Delegate GetSetParam_IDHandler ()
		{
			if (cb_setParam_ID == null)
				cb_setParam_ID = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, double>) n_SetParam_ID);
			return cb_setParam_ID;
		}

		static void n_SetParam_ID (IntPtr jnienv, IntPtr native__this, int p0, double p1)
		{
			global::Org.Encog.Engine.Network.Activation.IActivationFunction __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Activation.IActivationFunction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetParam (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_setParam_ID;
		public unsafe void SetParam (int p0, double p1)
		{
			if (id_setParam_ID == IntPtr.Zero)
				id_setParam_ID = JNIEnv.GetMethodID (class_ref, "setParam", "(ID)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setParam_ID, __args);
		}

	}

}
