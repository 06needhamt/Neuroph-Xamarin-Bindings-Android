using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Nnet.Learning.Kmeans {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.nnet.learning.kmeans']/class[@name='KMeansClustering']"
	[global::Android.Runtime.Register ("org/neuroph/nnet/learning/kmeans/KMeansClustering", DoNotGenerateAcw=true)]
	public partial class KMeansClustering : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/nnet/learning/kmeans/KMeansClustering", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (KMeansClustering); }
		}

		protected KMeansClustering (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_neuroph_core_data_DataSet_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.nnet.learning.kmeans']/class[@name='KMeansClustering']/constructor[@name='KMeansClustering' and count(parameter)=1 and parameter[1][@type='org.neuroph.core.data.DataSet']]"
		[Register (".ctor", "(Lorg/neuroph/core/data/DataSet;)V", "")]
		public unsafe KMeansClustering (global::Org.Neuroph.Core.Data.DataSet p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (KMeansClustering)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/neuroph/core/data/DataSet;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/neuroph/core/data/DataSet;)V", __args);
					return;
				}

				if (id_ctor_Lorg_neuroph_core_data_DataSet_ == IntPtr.Zero)
					id_ctor_Lorg_neuroph_core_data_DataSet_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/neuroph/core/data/DataSet;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_neuroph_core_data_DataSet_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_neuroph_core_data_DataSet_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Lorg_neuroph_core_data_DataSet_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.nnet.learning.kmeans']/class[@name='KMeansClustering']/constructor[@name='KMeansClustering' and count(parameter)=2 and parameter[1][@type='org.neuroph.core.data.DataSet'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Lorg/neuroph/core/data/DataSet;I)V", "")]
		public unsafe KMeansClustering (global::Org.Neuroph.Core.Data.DataSet p0, int p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (KMeansClustering)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/neuroph/core/data/DataSet;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/neuroph/core/data/DataSet;I)V", __args);
					return;
				}

				if (id_ctor_Lorg_neuroph_core_data_DataSet_I == IntPtr.Zero)
					id_ctor_Lorg_neuroph_core_data_DataSet_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/neuroph/core/data/DataSet;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_neuroph_core_data_DataSet_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_neuroph_core_data_DataSet_I, __args);
			} finally {
			}
		}

		static Delegate cb_getDataSet;
#pragma warning disable 0169
		static Delegate GetGetDataSetHandler ()
		{
			if (cb_getDataSet == null)
				cb_getDataSet = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDataSet);
			return cb_getDataSet;
		}

		static IntPtr n_GetDataSet (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Nnet.Learning.Kmeans.KMeansClustering __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Learning.Kmeans.KMeansClustering> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DataSet);
		}
#pragma warning restore 0169

		static Delegate cb_setDataSet_Lorg_neuroph_core_data_DataSet_;
#pragma warning disable 0169
		static Delegate GetSetDataSet_Lorg_neuroph_core_data_DataSet_Handler ()
		{
			if (cb_setDataSet_Lorg_neuroph_core_data_DataSet_ == null)
				cb_setDataSet_Lorg_neuroph_core_data_DataSet_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDataSet_Lorg_neuroph_core_data_DataSet_);
			return cb_setDataSet_Lorg_neuroph_core_data_DataSet_;
		}

		static void n_SetDataSet_Lorg_neuroph_core_data_DataSet_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Nnet.Learning.Kmeans.KMeansClustering __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Learning.Kmeans.KMeansClustering> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Core.Data.DataSet p0 = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Data.DataSet> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DataSet = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDataSet;
		static IntPtr id_setDataSet_Lorg_neuroph_core_data_DataSet_;
		public virtual unsafe global::Org.Neuroph.Core.Data.DataSet DataSet {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.learning.kmeans']/class[@name='KMeansClustering']/method[@name='getDataSet' and count(parameter)=0]"
			[Register ("getDataSet", "()Lorg/neuroph/core/data/DataSet;", "GetGetDataSetHandler")]
			get {
				if (id_getDataSet == IntPtr.Zero)
					id_getDataSet = JNIEnv.GetMethodID (class_ref, "getDataSet", "()Lorg/neuroph/core/data/DataSet;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Data.DataSet> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDataSet), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Data.DataSet> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDataSet", "()Lorg/neuroph/core/data/DataSet;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.learning.kmeans']/class[@name='KMeansClustering']/method[@name='setDataSet' and count(parameter)=1 and parameter[1][@type='org.neuroph.core.data.DataSet']]"
			[Register ("setDataSet", "(Lorg/neuroph/core/data/DataSet;)V", "GetSetDataSet_Lorg_neuroph_core_data_DataSet_Handler")]
			set {
				if (id_setDataSet_Lorg_neuroph_core_data_DataSet_ == IntPtr.Zero)
					id_setDataSet_Lorg_neuroph_core_data_DataSet_ = JNIEnv.GetMethodID (class_ref, "setDataSet", "(Lorg/neuroph/core/data/DataSet;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDataSet_Lorg_neuroph_core_data_DataSet_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDataSet", "(Lorg/neuroph/core/data/DataSet;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getLog;
#pragma warning disable 0169
		static Delegate GetGetLogHandler ()
		{
			if (cb_getLog == null)
				cb_getLog = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLog);
			return cb_getLog;
		}

		static IntPtr n_GetLog (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Nnet.Learning.Kmeans.KMeansClustering __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Learning.Kmeans.KMeansClustering> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Log);
		}
#pragma warning restore 0169

		static IntPtr id_getLog;
		public virtual unsafe string Log {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.learning.kmeans']/class[@name='KMeansClustering']/method[@name='getLog' and count(parameter)=0]"
			[Register ("getLog", "()Ljava/lang/String;", "GetGetLogHandler")]
			get {
				if (id_getLog == IntPtr.Zero)
					id_getLog = JNIEnv.GetMethodID (class_ref, "getLog", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLog), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLog", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_doClustering;
#pragma warning disable 0169
		static Delegate GetDoClusteringHandler ()
		{
			if (cb_doClustering == null)
				cb_doClustering = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DoClustering);
			return cb_doClustering;
		}

		static void n_DoClustering (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Nnet.Learning.Kmeans.KMeansClustering __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Learning.Kmeans.KMeansClustering> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DoClustering ();
		}
#pragma warning restore 0169

		static IntPtr id_doClustering;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.learning.kmeans']/class[@name='KMeansClustering']/method[@name='doClustering' and count(parameter)=0]"
		[Register ("doClustering", "()V", "GetDoClusteringHandler")]
		public virtual unsafe void DoClustering ()
		{
			if (id_doClustering == IntPtr.Zero)
				id_doClustering = JNIEnv.GetMethodID (class_ref, "doClustering", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_doClustering);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "doClustering", "()V"));
			} finally {
			}
		}

		static Delegate cb_getClusters;
#pragma warning disable 0169
		static Delegate GetGetClustersHandler ()
		{
			if (cb_getClusters == null)
				cb_getClusters = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetClusters);
			return cb_getClusters;
		}

		static IntPtr n_GetClusters (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Nnet.Learning.Kmeans.KMeansClustering __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Learning.Kmeans.KMeansClustering> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetClusters ());
		}
#pragma warning restore 0169

		static IntPtr id_getClusters;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.learning.kmeans']/class[@name='KMeansClustering']/method[@name='getClusters' and count(parameter)=0]"
		[Register ("getClusters", "()[Lorg/neuroph/nnet/learning/kmeans/Cluster;", "GetGetClustersHandler")]
		public virtual unsafe global::Org.Neuroph.Nnet.Learning.Kmeans.Cluster[] GetClusters ()
		{
			if (id_getClusters == IntPtr.Zero)
				id_getClusters = JNIEnv.GetMethodID (class_ref, "getClusters", "()[Lorg/neuroph/nnet/learning/kmeans/Cluster;");
			try {

				if (GetType () == ThresholdType)
					return (global::Org.Neuroph.Nnet.Learning.Kmeans.Cluster[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getClusters), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Neuroph.Nnet.Learning.Kmeans.Cluster));
				else
					return (global::Org.Neuroph.Nnet.Learning.Kmeans.Cluster[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getClusters", "()[Lorg/neuroph/nnet/learning/kmeans/Cluster;")), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Neuroph.Nnet.Learning.Kmeans.Cluster));
			} finally {
			}
		}

		static Delegate cb_initClusters;
#pragma warning disable 0169
		static Delegate GetInitClustersHandler ()
		{
			if (cb_initClusters == null)
				cb_initClusters = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_InitClusters);
			return cb_initClusters;
		}

		static void n_InitClusters (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Nnet.Learning.Kmeans.KMeansClustering __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Learning.Kmeans.KMeansClustering> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.InitClusters ();
		}
#pragma warning restore 0169

		static IntPtr id_initClusters;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.learning.kmeans']/class[@name='KMeansClustering']/method[@name='initClusters' and count(parameter)=0]"
		[Register ("initClusters", "()V", "GetInitClustersHandler")]
		public virtual unsafe void InitClusters ()
		{
			if (id_initClusters == IntPtr.Zero)
				id_initClusters = JNIEnv.GetMethodID (class_ref, "initClusters", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_initClusters);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "initClusters", "()V"));
			} finally {
			}
		}

		static Delegate cb_setNumberOfClusters_I;
#pragma warning disable 0169
		static Delegate GetSetNumberOfClusters_IHandler ()
		{
			if (cb_setNumberOfClusters_I == null)
				cb_setNumberOfClusters_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetNumberOfClusters_I);
			return cb_setNumberOfClusters_I;
		}

		static void n_SetNumberOfClusters_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Neuroph.Nnet.Learning.Kmeans.KMeansClustering __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Learning.Kmeans.KMeansClustering> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetNumberOfClusters (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setNumberOfClusters_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.learning.kmeans']/class[@name='KMeansClustering']/method[@name='setNumberOfClusters' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setNumberOfClusters", "(I)V", "GetSetNumberOfClusters_IHandler")]
		public virtual unsafe void SetNumberOfClusters (int p0)
		{
			if (id_setNumberOfClusters_I == IntPtr.Zero)
				id_setNumberOfClusters_I = JNIEnv.GetMethodID (class_ref, "setNumberOfClusters", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setNumberOfClusters_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNumberOfClusters", "(I)V"), __args);
			} finally {
			}
		}

	}
}
