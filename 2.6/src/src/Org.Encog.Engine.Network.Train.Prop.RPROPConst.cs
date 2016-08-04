using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Encog.Engine.Network.Train.Prop {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.encog.engine.network.train.prop']/class[@name='RPROPConst']"
	[global::Android.Runtime.Register ("org/encog/engine/network/train/prop/RPROPConst", DoNotGenerateAcw=true)]
	public sealed partial class RPROPConst : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.encog.engine.network.train.prop']/class[@name='RPROPConst']/field[@name='DEFAULT_INITIAL_UPDATE']"
		[Register ("DEFAULT_INITIAL_UPDATE")]
		public const double DefaultInitialUpdate = (double) 0.100000000000000;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.encog.engine.network.train.prop']/class[@name='RPROPConst']/field[@name='DEFAULT_MAX_STEP']"
		[Register ("DEFAULT_MAX_STEP")]
		public const double DefaultMaxStep = (double) 50.000000000000000;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.encog.engine.network.train.prop']/class[@name='RPROPConst']/field[@name='DEFAULT_ZERO_TOLERANCE']"
		[Register ("DEFAULT_ZERO_TOLERANCE")]
		public const double DefaultZeroTolerance = (double) 0.000000000000000;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.encog.engine.network.train.prop']/class[@name='RPROPConst']/field[@name='DELTA_MIN']"
		[Register ("DELTA_MIN")]
		public const double DeltaMin = (double) 0.000001000000000;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.encog.engine.network.train.prop']/class[@name='RPROPConst']/field[@name='NEGATIVE_ETA']"
		[Register ("NEGATIVE_ETA")]
		public const double NegativeEta = (double) 0.500000000000000;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.encog.engine.network.train.prop']/class[@name='RPROPConst']/field[@name='POSITIVE_ETA']"
		[Register ("POSITIVE_ETA")]
		public const double PositiveEta = (double) 1.200000000000000;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/encog/engine/network/train/prop/RPROPConst", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RPROPConst); }
		}

		internal RPROPConst (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
