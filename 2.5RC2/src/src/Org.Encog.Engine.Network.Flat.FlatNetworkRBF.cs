using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Encog.Engine.Network.Flat {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.encog.engine.network.flat']/class[@name='FlatNetworkRBF']"
	[global::Android.Runtime.Register ("org/encog/engine/network/flat/FlatNetworkRBF", DoNotGenerateAcw=true)]
	public partial class FlatNetworkRBF : global::Org.Encog.Engine.Network.Flat.FlatNetwork, global::Java.IO.ISerializable {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/encog/engine/network/flat/FlatNetworkRBF", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FlatNetworkRBF); }
		}

		protected FlatNetworkRBF (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.encog.engine.network.flat']/class[@name='FlatNetworkRBF']/constructor[@name='FlatNetworkRBF' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe FlatNetworkRBF ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (FlatNetworkRBF)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static IntPtr id_ctor_IIIarrayarrayDarrayD;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.encog.engine.network.flat']/class[@name='FlatNetworkRBF']/constructor[@name='FlatNetworkRBF' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='double[][]'] and parameter[5][@type='double[]']]"
		[Register (".ctor", "(III[[D[D)V", "")]
		public unsafe FlatNetworkRBF (int p0, int p1, int p2, double[][] p3, double[] p4)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p3 = JNIEnv.NewArray (p3);
			IntPtr native_p4 = JNIEnv.NewArray (p4);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				if (GetType () != typeof (FlatNetworkRBF)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(III[[D[D)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(III[[D[D)V", __args);
					return;
				}

				if (id_ctor_IIIarrayarrayDarrayD == IntPtr.Zero)
					id_ctor_IIIarrayarrayDarrayD = JNIEnv.GetMethodID (class_ref, "<init>", "(III[[D[D)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IIIarrayarrayDarrayD, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_IIIarrayarrayDarrayD, __args);
			} finally {
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
				if (p4 != null) {
					JNIEnv.CopyArray (native_p4, p4);
					JNIEnv.DeleteLocalRef (native_p4);
				}
			}
		}

	}
}
