using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Nnet.Learning.Kmeans {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.nnet.learning.kmeans']/class[@name='KVector']"
	[global::Android.Runtime.Register ("org/neuroph/nnet/learning/kmeans/KVector", DoNotGenerateAcw=true)]
	public partial class KVector : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/nnet/learning/kmeans/KVector", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (KVector); }
		}

		protected KVector (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.nnet.learning.kmeans']/class[@name='KVector']/constructor[@name='KVector' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe KVector (int p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (KVector)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(I)V", __args);
					return;
				}

				if (id_ctor_I == IntPtr.Zero)
					id_ctor_I = JNIEnv.GetMethodID (class_ref, "<init>", "(I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_I, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_arrayD;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.nnet.learning.kmeans']/class[@name='KVector']/constructor[@name='KVector' and count(parameter)=1 and parameter[1][@type='double[]']]"
		[Register (".ctor", "([D)V", "")]
		public unsafe KVector (double[] p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (KVector)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "([D)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "([D)V", __args);
					return;
				}

				if (id_ctor_arrayD == IntPtr.Zero)
					id_ctor_arrayD = JNIEnv.GetMethodID (class_ref, "<init>", "([D)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayD, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_arrayD, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_getCluster;
#pragma warning disable 0169
		static Delegate GetGetClusterHandler ()
		{
			if (cb_getCluster == null)
				cb_getCluster = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCluster);
			return cb_getCluster;
		}

		static IntPtr n_GetCluster (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Nnet.Learning.Kmeans.KVector __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Learning.Kmeans.KVector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Cluster);
		}
#pragma warning restore 0169

		static Delegate cb_setCluster_Lorg_neuroph_nnet_learning_kmeans_Cluster_;
#pragma warning disable 0169
		static Delegate GetSetCluster_Lorg_neuroph_nnet_learning_kmeans_Cluster_Handler ()
		{
			if (cb_setCluster_Lorg_neuroph_nnet_learning_kmeans_Cluster_ == null)
				cb_setCluster_Lorg_neuroph_nnet_learning_kmeans_Cluster_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCluster_Lorg_neuroph_nnet_learning_kmeans_Cluster_);
			return cb_setCluster_Lorg_neuroph_nnet_learning_kmeans_Cluster_;
		}

		static void n_SetCluster_Lorg_neuroph_nnet_learning_kmeans_Cluster_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Nnet.Learning.Kmeans.KVector __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Learning.Kmeans.KVector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Nnet.Learning.Kmeans.Cluster p0 = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Learning.Kmeans.Cluster> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Cluster = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCluster;
		static IntPtr id_setCluster_Lorg_neuroph_nnet_learning_kmeans_Cluster_;
		public virtual unsafe global::Org.Neuroph.Nnet.Learning.Kmeans.Cluster Cluster {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.learning.kmeans']/class[@name='KVector']/method[@name='getCluster' and count(parameter)=0]"
			[Register ("getCluster", "()Lorg/neuroph/nnet/learning/kmeans/Cluster;", "GetGetClusterHandler")]
			get {
				if (id_getCluster == IntPtr.Zero)
					id_getCluster = JNIEnv.GetMethodID (class_ref, "getCluster", "()Lorg/neuroph/nnet/learning/kmeans/Cluster;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Learning.Kmeans.Cluster> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCluster), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Learning.Kmeans.Cluster> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCluster", "()Lorg/neuroph/nnet/learning/kmeans/Cluster;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.learning.kmeans']/class[@name='KVector']/method[@name='setCluster' and count(parameter)=1 and parameter[1][@type='org.neuroph.nnet.learning.kmeans.Cluster']]"
			[Register ("setCluster", "(Lorg/neuroph/nnet/learning/kmeans/Cluster;)V", "GetSetCluster_Lorg_neuroph_nnet_learning_kmeans_Cluster_Handler")]
			set {
				if (id_setCluster_Lorg_neuroph_nnet_learning_kmeans_Cluster_ == IntPtr.Zero)
					id_setCluster_Lorg_neuroph_nnet_learning_kmeans_Cluster_ = JNIEnv.GetMethodID (class_ref, "setCluster", "(Lorg/neuroph/nnet/learning/kmeans/Cluster;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCluster_Lorg_neuroph_nnet_learning_kmeans_Cluster_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCluster", "(Lorg/neuroph/nnet/learning/kmeans/Cluster;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getDistance;
#pragma warning disable 0169
		static Delegate GetGetDistanceHandler ()
		{
			if (cb_getDistance == null)
				cb_getDistance = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetDistance);
			return cb_getDistance;
		}

		static double n_GetDistance (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Nnet.Learning.Kmeans.KVector __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Learning.Kmeans.KVector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Distance;
		}
#pragma warning restore 0169

		static Delegate cb_setDistance_D;
#pragma warning disable 0169
		static Delegate GetSetDistance_DHandler ()
		{
			if (cb_setDistance_D == null)
				cb_setDistance_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetDistance_D);
			return cb_setDistance_D;
		}

		static void n_SetDistance_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Org.Neuroph.Nnet.Learning.Kmeans.KVector __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Learning.Kmeans.KVector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Distance = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDistance;
		static IntPtr id_setDistance_D;
		public virtual unsafe double Distance {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.learning.kmeans']/class[@name='KVector']/method[@name='getDistance' and count(parameter)=0]"
			[Register ("getDistance", "()D", "GetGetDistanceHandler")]
			get {
				if (id_getDistance == IntPtr.Zero)
					id_getDistance = JNIEnv.GetMethodID (class_ref, "getDistance", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getDistance);
					else
						return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDistance", "()D"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.learning.kmeans']/class[@name='KVector']/method[@name='setDistance' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setDistance", "(D)V", "GetSetDistance_DHandler")]
			set {
				if (id_setDistance_D == IntPtr.Zero)
					id_setDistance_D = JNIEnv.GetMethodID (class_ref, "setDistance", "(D)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDistance_D, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDistance", "(D)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getIntensity;
#pragma warning disable 0169
		static Delegate GetGetIntensityHandler ()
		{
			if (cb_getIntensity == null)
				cb_getIntensity = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetIntensity);
			return cb_getIntensity;
		}

		static double n_GetIntensity (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Nnet.Learning.Kmeans.KVector __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Learning.Kmeans.KVector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Intensity;
		}
#pragma warning restore 0169

		static IntPtr id_getIntensity;
		public virtual unsafe double Intensity {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.learning.kmeans']/class[@name='KVector']/method[@name='getIntensity' and count(parameter)=0]"
			[Register ("getIntensity", "()D", "GetGetIntensityHandler")]
			get {
				if (id_getIntensity == IntPtr.Zero)
					id_getIntensity = JNIEnv.GetMethodID (class_ref, "getIntensity", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getIntensity);
					else
						return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIntensity", "()D"));
				} finally {
				}
			}
		}

		static Delegate cb_distanceFrom_Lorg_neuroph_nnet_learning_kmeans_KVector_;
#pragma warning disable 0169
		static Delegate GetDistanceFrom_Lorg_neuroph_nnet_learning_kmeans_KVector_Handler ()
		{
			if (cb_distanceFrom_Lorg_neuroph_nnet_learning_kmeans_KVector_ == null)
				cb_distanceFrom_Lorg_neuroph_nnet_learning_kmeans_KVector_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, double>) n_DistanceFrom_Lorg_neuroph_nnet_learning_kmeans_KVector_);
			return cb_distanceFrom_Lorg_neuroph_nnet_learning_kmeans_KVector_;
		}

		static double n_DistanceFrom_Lorg_neuroph_nnet_learning_kmeans_KVector_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Nnet.Learning.Kmeans.KVector __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Learning.Kmeans.KVector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Nnet.Learning.Kmeans.KVector p0 = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Learning.Kmeans.KVector> (native_p0, JniHandleOwnership.DoNotTransfer);
			double __ret = __this.DistanceFrom (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_distanceFrom_Lorg_neuroph_nnet_learning_kmeans_KVector_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.learning.kmeans']/class[@name='KVector']/method[@name='distanceFrom' and count(parameter)=1 and parameter[1][@type='org.neuroph.nnet.learning.kmeans.KVector']]"
		[Register ("distanceFrom", "(Lorg/neuroph/nnet/learning/kmeans/KVector;)D", "GetDistanceFrom_Lorg_neuroph_nnet_learning_kmeans_KVector_Handler")]
		public virtual unsafe double DistanceFrom (global::Org.Neuroph.Nnet.Learning.Kmeans.KVector p0)
		{
			if (id_distanceFrom_Lorg_neuroph_nnet_learning_kmeans_KVector_ == IntPtr.Zero)
				id_distanceFrom_Lorg_neuroph_nnet_learning_kmeans_KVector_ = JNIEnv.GetMethodID (class_ref, "distanceFrom", "(Lorg/neuroph/nnet/learning/kmeans/KVector;)D");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				double __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_distanceFrom_Lorg_neuroph_nnet_learning_kmeans_KVector_, __args);
				else
					__ret = JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "distanceFrom", "(Lorg/neuroph/nnet/learning/kmeans/KVector;)D"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getValueAt_I;
#pragma warning disable 0169
		static Delegate GetGetValueAt_IHandler ()
		{
			if (cb_getValueAt_I == null)
				cb_getValueAt_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, double>) n_GetValueAt_I);
			return cb_getValueAt_I;
		}

		static double n_GetValueAt_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Neuroph.Nnet.Learning.Kmeans.KVector __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Learning.Kmeans.KVector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetValueAt (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getValueAt_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.learning.kmeans']/class[@name='KVector']/method[@name='getValueAt' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getValueAt", "(I)D", "GetGetValueAt_IHandler")]
		public virtual unsafe double GetValueAt (int p0)
		{
			if (id_getValueAt_I == IntPtr.Zero)
				id_getValueAt_I = JNIEnv.GetMethodID (class_ref, "getValueAt", "(I)D");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getValueAt_I, __args);
				else
					return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getValueAt", "(I)D"), __args);
			} finally {
			}
		}

		static Delegate cb_getValues;
#pragma warning disable 0169
		static Delegate GetGetValuesHandler ()
		{
			if (cb_getValues == null)
				cb_getValues = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetValues);
			return cb_getValues;
		}

		static IntPtr n_GetValues (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Nnet.Learning.Kmeans.KVector __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Learning.Kmeans.KVector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetValues ());
		}
#pragma warning restore 0169

		static IntPtr id_getValues;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.learning.kmeans']/class[@name='KVector']/method[@name='getValues' and count(parameter)=0]"
		[Register ("getValues", "()[D", "GetGetValuesHandler")]
		public virtual unsafe double[] GetValues ()
		{
			if (id_getValues == IntPtr.Zero)
				id_getValues = JNIEnv.GetMethodID (class_ref, "getValues", "()[D");
			try {

				if (GetType () == ThresholdType)
					return (double[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getValues), JniHandleOwnership.TransferLocalRef, typeof (double));
				else
					return (double[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getValues", "()[D")), JniHandleOwnership.TransferLocalRef, typeof (double));
			} finally {
			}
		}

		static Delegate cb_setValueAt_ID;
#pragma warning disable 0169
		static Delegate GetSetValueAt_IDHandler ()
		{
			if (cb_setValueAt_ID == null)
				cb_setValueAt_ID = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, double>) n_SetValueAt_ID);
			return cb_setValueAt_ID;
		}

		static void n_SetValueAt_ID (IntPtr jnienv, IntPtr native__this, int p0, double p1)
		{
			global::Org.Neuroph.Nnet.Learning.Kmeans.KVector __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Learning.Kmeans.KVector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetValueAt (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setValueAt_ID;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.learning.kmeans']/class[@name='KVector']/method[@name='setValueAt' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='double']]"
		[Register ("setValueAt", "(ID)V", "GetSetValueAt_IDHandler")]
		public virtual unsafe void SetValueAt (int p0, double p1)
		{
			if (id_setValueAt_ID == IntPtr.Zero)
				id_setValueAt_ID = JNIEnv.GetMethodID (class_ref, "setValueAt", "(ID)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setValueAt_ID, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setValueAt", "(ID)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setValues_arrayD;
#pragma warning disable 0169
		static Delegate GetSetValues_arrayDHandler ()
		{
			if (cb_setValues_arrayD == null)
				cb_setValues_arrayD = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetValues_arrayD);
			return cb_setValues_arrayD;
		}

		static void n_SetValues_arrayD (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Nnet.Learning.Kmeans.KVector __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Learning.Kmeans.KVector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			double[] p0 = (double[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (double));
			__this.SetValues (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_setValues_arrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.learning.kmeans']/class[@name='KVector']/method[@name='setValues' and count(parameter)=1 and parameter[1][@type='double[]']]"
		[Register ("setValues", "([D)V", "GetSetValues_arrayDHandler")]
		public virtual unsafe void SetValues (double[] p0)
		{
			if (id_setValues_arrayD == IntPtr.Zero)
				id_setValues_arrayD = JNIEnv.GetMethodID (class_ref, "setValues", "([D)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setValues_arrayD, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setValues", "([D)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_size;
#pragma warning disable 0169
		static Delegate GetSizeHandler ()
		{
			if (cb_size == null)
				cb_size = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Size);
			return cb_size;
		}

		static int n_Size (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Nnet.Learning.Kmeans.KVector __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Learning.Kmeans.KVector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Size ();
		}
#pragma warning restore 0169

		static IntPtr id_size;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.learning.kmeans']/class[@name='KVector']/method[@name='size' and count(parameter)=0]"
		[Register ("size", "()I", "GetSizeHandler")]
		public virtual unsafe int Size ()
		{
			if (id_size == IntPtr.Zero)
				id_size = JNIEnv.GetMethodID (class_ref, "size", "()I");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_size);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "size", "()I"));
			} finally {
			}
		}

	}
}
