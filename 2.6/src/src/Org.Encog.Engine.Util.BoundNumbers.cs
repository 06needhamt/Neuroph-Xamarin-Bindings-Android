using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Encog.Engine.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.encog.engine.util']/class[@name='BoundNumbers']"
	[global::Android.Runtime.Register ("org/encog/engine/util/BoundNumbers", DoNotGenerateAcw=true)]
	public sealed partial class BoundNumbers : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.encog.engine.util']/class[@name='BoundNumbers']/field[@name='TOO_BIG']"
		[Register ("TOO_BIG")]
		public const double TooBig = (double) 100000000000000000000.000000000000000;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.encog.engine.util']/class[@name='BoundNumbers']/field[@name='TOO_SMALL']"
		[Register ("TOO_SMALL")]
		public const double TooSmall = (double) -100000000000000000000.000000000000000;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/encog/engine/util/BoundNumbers", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BoundNumbers); }
		}

		internal BoundNumbers (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_bound_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.util']/class[@name='BoundNumbers']/method[@name='bound' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("bound", "(D)D", "")]
		public static unsafe double Bound (double p0)
		{
			if (id_bound_D == IntPtr.Zero)
				id_bound_D = JNIEnv.GetStaticMethodID (class_ref, "bound", "(D)D");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticDoubleMethod  (class_ref, id_bound_D, __args);
			} finally {
			}
		}

	}
}
