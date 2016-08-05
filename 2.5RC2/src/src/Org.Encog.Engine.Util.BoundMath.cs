using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Encog.Engine.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.encog.engine.util']/class[@name='BoundMath']"
	[global::Android.Runtime.Register ("org/encog/engine/util/BoundMath", DoNotGenerateAcw=true)]
	public sealed partial class BoundMath : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/encog/engine/util/BoundMath", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BoundMath); }
		}

		internal BoundMath (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_cos_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.util']/class[@name='BoundMath']/method[@name='cos' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("cos", "(D)D", "")]
		public static unsafe double Cos (double p0)
		{
			if (id_cos_D == IntPtr.Zero)
				id_cos_D = JNIEnv.GetStaticMethodID (class_ref, "cos", "(D)D");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticDoubleMethod  (class_ref, id_cos_D, __args);
			} finally {
			}
		}

		static IntPtr id_exp_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.util']/class[@name='BoundMath']/method[@name='exp' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("exp", "(D)D", "")]
		public static unsafe double Exp (double p0)
		{
			if (id_exp_D == IntPtr.Zero)
				id_exp_D = JNIEnv.GetStaticMethodID (class_ref, "exp", "(D)D");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticDoubleMethod  (class_ref, id_exp_D, __args);
			} finally {
			}
		}

		static IntPtr id_log_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.util']/class[@name='BoundMath']/method[@name='log' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("log", "(D)D", "")]
		public static unsafe double Log (double p0)
		{
			if (id_log_D == IntPtr.Zero)
				id_log_D = JNIEnv.GetStaticMethodID (class_ref, "log", "(D)D");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticDoubleMethod  (class_ref, id_log_D, __args);
			} finally {
			}
		}

		static IntPtr id_pow_DD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.util']/class[@name='BoundMath']/method[@name='pow' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='double']]"
		[Register ("pow", "(DD)D", "")]
		public static unsafe double Pow (double p0, double p1)
		{
			if (id_pow_DD == IntPtr.Zero)
				id_pow_DD = JNIEnv.GetStaticMethodID (class_ref, "pow", "(DD)D");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return JNIEnv.CallStaticDoubleMethod  (class_ref, id_pow_DD, __args);
			} finally {
			}
		}

		static IntPtr id_sin_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.util']/class[@name='BoundMath']/method[@name='sin' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("sin", "(D)D", "")]
		public static unsafe double Sin (double p0)
		{
			if (id_sin_D == IntPtr.Zero)
				id_sin_D = JNIEnv.GetStaticMethodID (class_ref, "sin", "(D)D");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticDoubleMethod  (class_ref, id_sin_D, __args);
			} finally {
			}
		}

		static IntPtr id_sqrt_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.util']/class[@name='BoundMath']/method[@name='sqrt' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("sqrt", "(D)D", "")]
		public static unsafe double Sqrt (double p0)
		{
			if (id_sqrt_D == IntPtr.Zero)
				id_sqrt_D = JNIEnv.GetStaticMethodID (class_ref, "sqrt", "(D)D");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticDoubleMethod  (class_ref, id_sqrt_D, __args);
			} finally {
			}
		}

	}
}
