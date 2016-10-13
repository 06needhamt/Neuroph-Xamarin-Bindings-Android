using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Encog.Engine.Network.Rbf {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.encog.engine.network.rbf']/interface[@name='RadialBasisFunction']"
	[Register ("org/encog/engine/network/rbf/RadialBasisFunction", "", "Org.Encog.Engine.Network.Rbf.IRadialBasisFunctionInvoker")]
	public partial interface IRadialBasisFunction : IJavaObject {

		int Dimensions {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.rbf']/interface[@name='RadialBasisFunction']/method[@name='getDimensions' and count(parameter)=0]"
			[Register ("getDimensions", "()I", "GetGetDimensionsHandler:Org.Encog.Engine.Network.Rbf.IRadialBasisFunctionInvoker, Neuroph_2.6")] get;
		}

		double Peak {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.rbf']/interface[@name='RadialBasisFunction']/method[@name='getPeak' and count(parameter)=0]"
			[Register ("getPeak", "()D", "GetGetPeakHandler:Org.Encog.Engine.Network.Rbf.IRadialBasisFunctionInvoker, Neuroph_2.6")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.rbf']/interface[@name='RadialBasisFunction']/method[@name='setPeak' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setPeak", "(D)V", "GetSetPeak_DHandler:Org.Encog.Engine.Network.Rbf.IRadialBasisFunctionInvoker, Neuroph_2.6")] set;
		}

		double Width {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.rbf']/interface[@name='RadialBasisFunction']/method[@name='getWidth' and count(parameter)=0]"
			[Register ("getWidth", "()D", "GetGetWidthHandler:Org.Encog.Engine.Network.Rbf.IRadialBasisFunctionInvoker, Neuroph_2.6")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.rbf']/interface[@name='RadialBasisFunction']/method[@name='setWidth' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setWidth", "(D)V", "GetSetWidth_DHandler:Org.Encog.Engine.Network.Rbf.IRadialBasisFunctionInvoker, Neuroph_2.6")] set;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.rbf']/interface[@name='RadialBasisFunction']/method[@name='calculate' and count(parameter)=1 and parameter[1][@type='double[]']]"
		[Register ("calculate", "([D)D", "GetCalculate_arrayDHandler:Org.Encog.Engine.Network.Rbf.IRadialBasisFunctionInvoker, Neuroph_2.6")]
		double Calculate (double[] p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.rbf']/interface[@name='RadialBasisFunction']/method[@name='getCenter' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getCenter", "(I)D", "GetGetCenter_IHandler:Org.Encog.Engine.Network.Rbf.IRadialBasisFunctionInvoker, Neuroph_2.6")]
		double GetCenter (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.rbf']/interface[@name='RadialBasisFunction']/method[@name='getCenters' and count(parameter)=0]"
		[Register ("getCenters", "()[D", "GetGetCentersHandler:Org.Encog.Engine.Network.Rbf.IRadialBasisFunctionInvoker, Neuroph_2.6")]
		double[] GetCenters ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.network.rbf']/interface[@name='RadialBasisFunction']/method[@name='setCenters' and count(parameter)=1 and parameter[1][@type='double[]']]"
		[Register ("setCenters", "([D)V", "GetSetCenters_arrayDHandler:Org.Encog.Engine.Network.Rbf.IRadialBasisFunctionInvoker, Neuroph_2.6")]
		void SetCenters (double[] p0);

	}

	[global::Android.Runtime.Register ("org/encog/engine/network/rbf/RadialBasisFunction", DoNotGenerateAcw=true)]
	internal class IRadialBasisFunctionInvoker : global::Java.Lang.Object, IRadialBasisFunction {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/encog/engine/network/rbf/RadialBasisFunction");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IRadialBasisFunctionInvoker); }
		}

		IntPtr class_ref;

		public static IRadialBasisFunction GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IRadialBasisFunction> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.encog.engine.network.rbf.RadialBasisFunction"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IRadialBasisFunctionInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getDimensions;
#pragma warning disable 0169
		static Delegate GetGetDimensionsHandler ()
		{
			if (cb_getDimensions == null)
				cb_getDimensions = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDimensions);
			return cb_getDimensions;
		}

		static int n_GetDimensions (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Network.Rbf.IRadialBasisFunction __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Rbf.IRadialBasisFunction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Dimensions;
		}
#pragma warning restore 0169

		IntPtr id_getDimensions;
		public unsafe int Dimensions {
			get {
				if (id_getDimensions == IntPtr.Zero)
					id_getDimensions = JNIEnv.GetMethodID (class_ref, "getDimensions", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getDimensions);
			}
		}

		static Delegate cb_getPeak;
#pragma warning disable 0169
		static Delegate GetGetPeakHandler ()
		{
			if (cb_getPeak == null)
				cb_getPeak = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetPeak);
			return cb_getPeak;
		}

		static double n_GetPeak (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Network.Rbf.IRadialBasisFunction __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Rbf.IRadialBasisFunction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Peak;
		}
#pragma warning restore 0169

		static Delegate cb_setPeak_D;
#pragma warning disable 0169
		static Delegate GetSetPeak_DHandler ()
		{
			if (cb_setPeak_D == null)
				cb_setPeak_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetPeak_D);
			return cb_setPeak_D;
		}

		static void n_SetPeak_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Org.Encog.Engine.Network.Rbf.IRadialBasisFunction __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Rbf.IRadialBasisFunction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Peak = p0;
		}
#pragma warning restore 0169

		IntPtr id_getPeak;
		IntPtr id_setPeak_D;
		public unsafe double Peak {
			get {
				if (id_getPeak == IntPtr.Zero)
					id_getPeak = JNIEnv.GetMethodID (class_ref, "getPeak", "()D");
				return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getPeak);
			}
			set {
				if (id_setPeak_D == IntPtr.Zero)
					id_setPeak_D = JNIEnv.GetMethodID (class_ref, "setPeak", "(D)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPeak_D, __args);
			}
		}

		static Delegate cb_getWidth;
#pragma warning disable 0169
		static Delegate GetGetWidthHandler ()
		{
			if (cb_getWidth == null)
				cb_getWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetWidth);
			return cb_getWidth;
		}

		static double n_GetWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Network.Rbf.IRadialBasisFunction __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Rbf.IRadialBasisFunction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Width;
		}
#pragma warning restore 0169

		static Delegate cb_setWidth_D;
#pragma warning disable 0169
		static Delegate GetSetWidth_DHandler ()
		{
			if (cb_setWidth_D == null)
				cb_setWidth_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetWidth_D);
			return cb_setWidth_D;
		}

		static void n_SetWidth_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Org.Encog.Engine.Network.Rbf.IRadialBasisFunction __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Rbf.IRadialBasisFunction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Width = p0;
		}
#pragma warning restore 0169

		IntPtr id_getWidth;
		IntPtr id_setWidth_D;
		public unsafe double Width {
			get {
				if (id_getWidth == IntPtr.Zero)
					id_getWidth = JNIEnv.GetMethodID (class_ref, "getWidth", "()D");
				return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getWidth);
			}
			set {
				if (id_setWidth_D == IntPtr.Zero)
					id_setWidth_D = JNIEnv.GetMethodID (class_ref, "setWidth", "(D)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setWidth_D, __args);
			}
		}

		static Delegate cb_calculate_arrayD;
#pragma warning disable 0169
		static Delegate GetCalculate_arrayDHandler ()
		{
			if (cb_calculate_arrayD == null)
				cb_calculate_arrayD = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, double>) n_Calculate_arrayD);
			return cb_calculate_arrayD;
		}

		static double n_Calculate_arrayD (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Encog.Engine.Network.Rbf.IRadialBasisFunction __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Rbf.IRadialBasisFunction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			double[] p0 = (double[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (double));
			double __ret = __this.Calculate (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_calculate_arrayD;
		public unsafe double Calculate (double[] p0)
		{
			if (id_calculate_arrayD == IntPtr.Zero)
				id_calculate_arrayD = JNIEnv.GetMethodID (class_ref, "calculate", "([D)D");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			double __ret = JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_calculate_arrayD, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate cb_getCenter_I;
#pragma warning disable 0169
		static Delegate GetGetCenter_IHandler ()
		{
			if (cb_getCenter_I == null)
				cb_getCenter_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, double>) n_GetCenter_I);
			return cb_getCenter_I;
		}

		static double n_GetCenter_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Encog.Engine.Network.Rbf.IRadialBasisFunction __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Rbf.IRadialBasisFunction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetCenter (p0);
		}
#pragma warning restore 0169

		IntPtr id_getCenter_I;
		public unsafe double GetCenter (int p0)
		{
			if (id_getCenter_I == IntPtr.Zero)
				id_getCenter_I = JNIEnv.GetMethodID (class_ref, "getCenter", "(I)D");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getCenter_I, __args);
		}

		static Delegate cb_getCenters;
#pragma warning disable 0169
		static Delegate GetGetCentersHandler ()
		{
			if (cb_getCenters == null)
				cb_getCenters = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCenters);
			return cb_getCenters;
		}

		static IntPtr n_GetCenters (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Encog.Engine.Network.Rbf.IRadialBasisFunction __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Rbf.IRadialBasisFunction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetCenters ());
		}
#pragma warning restore 0169

		IntPtr id_getCenters;
		public unsafe double[] GetCenters ()
		{
			if (id_getCenters == IntPtr.Zero)
				id_getCenters = JNIEnv.GetMethodID (class_ref, "getCenters", "()[D");
			return (double[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCenters), JniHandleOwnership.TransferLocalRef, typeof (double));
		}

		static Delegate cb_setCenters_arrayD;
#pragma warning disable 0169
		static Delegate GetSetCenters_arrayDHandler ()
		{
			if (cb_setCenters_arrayD == null)
				cb_setCenters_arrayD = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCenters_arrayD);
			return cb_setCenters_arrayD;
		}

		static void n_SetCenters_arrayD (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Encog.Engine.Network.Rbf.IRadialBasisFunction __this = global::Java.Lang.Object.GetObject<global::Org.Encog.Engine.Network.Rbf.IRadialBasisFunction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			double[] p0 = (double[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (double));
			__this.SetCenters (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		IntPtr id_setCenters_arrayD;
		public unsafe void SetCenters (double[] p0)
		{
			if (id_setCenters_arrayD == IntPtr.Zero)
				id_setCenters_arrayD = JNIEnv.GetMethodID (class_ref, "setCenters", "([D)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCenters_arrayD, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}

}
