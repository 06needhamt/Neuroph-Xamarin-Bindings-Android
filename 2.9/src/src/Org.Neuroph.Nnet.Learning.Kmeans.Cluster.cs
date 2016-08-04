using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Nnet.Learning.Kmeans {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.nnet.learning.kmeans']/class[@name='Cluster']"
	[global::Android.Runtime.Register ("org/neuroph/nnet/learning/kmeans/Cluster", DoNotGenerateAcw=true)]
	public partial class Cluster : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/nnet/learning/kmeans/Cluster", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Cluster); }
		}

		protected Cluster (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.nnet.learning.kmeans']/class[@name='Cluster']/constructor[@name='Cluster' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Cluster ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Cluster)) {
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

		static Delegate cb_getCentroid;
#pragma warning disable 0169
		static Delegate GetGetCentroidHandler ()
		{
			if (cb_getCentroid == null)
				cb_getCentroid = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCentroid);
			return cb_getCentroid;
		}

		static IntPtr n_GetCentroid (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Nnet.Learning.Kmeans.Cluster __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Learning.Kmeans.Cluster> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Centroid);
		}
#pragma warning restore 0169

		static Delegate cb_setCentroid_Lorg_neuroph_nnet_learning_kmeans_KVector_;
#pragma warning disable 0169
		static Delegate GetSetCentroid_Lorg_neuroph_nnet_learning_kmeans_KVector_Handler ()
		{
			if (cb_setCentroid_Lorg_neuroph_nnet_learning_kmeans_KVector_ == null)
				cb_setCentroid_Lorg_neuroph_nnet_learning_kmeans_KVector_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCentroid_Lorg_neuroph_nnet_learning_kmeans_KVector_);
			return cb_setCentroid_Lorg_neuroph_nnet_learning_kmeans_KVector_;
		}

		static void n_SetCentroid_Lorg_neuroph_nnet_learning_kmeans_KVector_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Nnet.Learning.Kmeans.Cluster __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Learning.Kmeans.Cluster> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Nnet.Learning.Kmeans.KVector p0 = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Learning.Kmeans.KVector> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Centroid = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCentroid;
		static IntPtr id_setCentroid_Lorg_neuroph_nnet_learning_kmeans_KVector_;
		public virtual unsafe global::Org.Neuroph.Nnet.Learning.Kmeans.KVector Centroid {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.learning.kmeans']/class[@name='Cluster']/method[@name='getCentroid' and count(parameter)=0]"
			[Register ("getCentroid", "()Lorg/neuroph/nnet/learning/kmeans/KVector;", "GetGetCentroidHandler")]
			get {
				if (id_getCentroid == IntPtr.Zero)
					id_getCentroid = JNIEnv.GetMethodID (class_ref, "getCentroid", "()Lorg/neuroph/nnet/learning/kmeans/KVector;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Learning.Kmeans.KVector> (JNIEnv.CallObjectMethod  (Handle, id_getCentroid), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Learning.Kmeans.KVector> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCentroid", "()Lorg/neuroph/nnet/learning/kmeans/KVector;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.learning.kmeans']/class[@name='Cluster']/method[@name='setCentroid' and count(parameter)=1 and parameter[1][@type='org.neuroph.nnet.learning.kmeans.KVector']]"
			[Register ("setCentroid", "(Lorg/neuroph/nnet/learning/kmeans/KVector;)V", "GetSetCentroid_Lorg_neuroph_nnet_learning_kmeans_KVector_Handler")]
			set {
				if (id_setCentroid_Lorg_neuroph_nnet_learning_kmeans_KVector_ == IntPtr.Zero)
					id_setCentroid_Lorg_neuroph_nnet_learning_kmeans_KVector_ = JNIEnv.GetMethodID (class_ref, "setCentroid", "(Lorg/neuroph/nnet/learning/kmeans/KVector;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setCentroid_Lorg_neuroph_nnet_learning_kmeans_KVector_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCentroid", "(Lorg/neuroph/nnet/learning/kmeans/KVector;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getPoints;
#pragma warning disable 0169
		static Delegate GetGetPointsHandler ()
		{
			if (cb_getPoints == null)
				cb_getPoints = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPoints);
			return cb_getPoints;
		}

		static IntPtr n_GetPoints (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Nnet.Learning.Kmeans.Cluster __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Learning.Kmeans.Cluster> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Org.Neuroph.Nnet.Learning.Kmeans.KVector>.ToLocalJniHandle (__this.Points);
		}
#pragma warning restore 0169

		static IntPtr id_getPoints;
		public virtual unsafe global::System.Collections.Generic.IList<global::Org.Neuroph.Nnet.Learning.Kmeans.KVector> Points {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.learning.kmeans']/class[@name='Cluster']/method[@name='getPoints' and count(parameter)=0]"
			[Register ("getPoints", "()Ljava/util/List;", "GetGetPointsHandler")]
			get {
				if (id_getPoints == IntPtr.Zero)
					id_getPoints = JNIEnv.GetMethodID (class_ref, "getPoints", "()Ljava/util/List;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Org.Neuroph.Nnet.Learning.Kmeans.KVector>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getPoints), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Org.Neuroph.Nnet.Learning.Kmeans.KVector>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPoints", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_assignVector_Lorg_neuroph_nnet_learning_kmeans_KVector_;
#pragma warning disable 0169
		static Delegate GetAssignVector_Lorg_neuroph_nnet_learning_kmeans_KVector_Handler ()
		{
			if (cb_assignVector_Lorg_neuroph_nnet_learning_kmeans_KVector_ == null)
				cb_assignVector_Lorg_neuroph_nnet_learning_kmeans_KVector_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AssignVector_Lorg_neuroph_nnet_learning_kmeans_KVector_);
			return cb_assignVector_Lorg_neuroph_nnet_learning_kmeans_KVector_;
		}

		static void n_AssignVector_Lorg_neuroph_nnet_learning_kmeans_KVector_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Nnet.Learning.Kmeans.Cluster __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Learning.Kmeans.Cluster> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Nnet.Learning.Kmeans.KVector p0 = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Learning.Kmeans.KVector> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AssignVector (p0);
		}
#pragma warning restore 0169

		static IntPtr id_assignVector_Lorg_neuroph_nnet_learning_kmeans_KVector_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.learning.kmeans']/class[@name='Cluster']/method[@name='assignVector' and count(parameter)=1 and parameter[1][@type='org.neuroph.nnet.learning.kmeans.KVector']]"
		[Register ("assignVector", "(Lorg/neuroph/nnet/learning/kmeans/KVector;)V", "GetAssignVector_Lorg_neuroph_nnet_learning_kmeans_KVector_Handler")]
		public virtual unsafe void AssignVector (global::Org.Neuroph.Nnet.Learning.Kmeans.KVector p0)
		{
			if (id_assignVector_Lorg_neuroph_nnet_learning_kmeans_KVector_ == IntPtr.Zero)
				id_assignVector_Lorg_neuroph_nnet_learning_kmeans_KVector_ = JNIEnv.GetMethodID (class_ref, "assignVector", "(Lorg/neuroph/nnet/learning/kmeans/KVector;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_assignVector_Lorg_neuroph_nnet_learning_kmeans_KVector_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "assignVector", "(Lorg/neuroph/nnet/learning/kmeans/KVector;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_getAvgSum;
#pragma warning disable 0169
		static Delegate GetGetAvgSumHandler ()
		{
			if (cb_getAvgSum == null)
				cb_getAvgSum = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAvgSum);
			return cb_getAvgSum;
		}

		static IntPtr n_GetAvgSum (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Nnet.Learning.Kmeans.Cluster __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Learning.Kmeans.Cluster> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetAvgSum ());
		}
#pragma warning restore 0169

		static IntPtr id_getAvgSum;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.learning.kmeans']/class[@name='Cluster']/method[@name='getAvgSum' and count(parameter)=0]"
		[Register ("getAvgSum", "()[D", "GetGetAvgSumHandler")]
		public virtual unsafe double[] GetAvgSum ()
		{
			if (id_getAvgSum == IntPtr.Zero)
				id_getAvgSum = JNIEnv.GetMethodID (class_ref, "getAvgSum", "()[D");
			try {

				if (GetType () == ThresholdType)
					return (double[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getAvgSum), JniHandleOwnership.TransferLocalRef, typeof (double));
				else
					return (double[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAvgSum", "()[D")), JniHandleOwnership.TransferLocalRef, typeof (double));
			} finally {
			}
		}

		static Delegate cb_removePoint_Lorg_neuroph_nnet_learning_kmeans_KVector_;
#pragma warning disable 0169
		static Delegate GetRemovePoint_Lorg_neuroph_nnet_learning_kmeans_KVector_Handler ()
		{
			if (cb_removePoint_Lorg_neuroph_nnet_learning_kmeans_KVector_ == null)
				cb_removePoint_Lorg_neuroph_nnet_learning_kmeans_KVector_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemovePoint_Lorg_neuroph_nnet_learning_kmeans_KVector_);
			return cb_removePoint_Lorg_neuroph_nnet_learning_kmeans_KVector_;
		}

		static void n_RemovePoint_Lorg_neuroph_nnet_learning_kmeans_KVector_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Nnet.Learning.Kmeans.Cluster __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Learning.Kmeans.Cluster> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Nnet.Learning.Kmeans.KVector p0 = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Learning.Kmeans.KVector> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemovePoint (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removePoint_Lorg_neuroph_nnet_learning_kmeans_KVector_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.learning.kmeans']/class[@name='Cluster']/method[@name='removePoint' and count(parameter)=1 and parameter[1][@type='org.neuroph.nnet.learning.kmeans.KVector']]"
		[Register ("removePoint", "(Lorg/neuroph/nnet/learning/kmeans/KVector;)V", "GetRemovePoint_Lorg_neuroph_nnet_learning_kmeans_KVector_Handler")]
		public virtual unsafe void RemovePoint (global::Org.Neuroph.Nnet.Learning.Kmeans.KVector p0)
		{
			if (id_removePoint_Lorg_neuroph_nnet_learning_kmeans_KVector_ == IntPtr.Zero)
				id_removePoint_Lorg_neuroph_nnet_learning_kmeans_KVector_ = JNIEnv.GetMethodID (class_ref, "removePoint", "(Lorg/neuroph/nnet/learning/kmeans/KVector;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_removePoint_Lorg_neuroph_nnet_learning_kmeans_KVector_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removePoint", "(Lorg/neuroph/nnet/learning/kmeans/KVector;)V"), __args);
			} finally {
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
			global::Org.Neuroph.Nnet.Learning.Kmeans.Cluster __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Learning.Kmeans.Cluster> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Size ();
		}
#pragma warning restore 0169

		static IntPtr id_size;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.learning.kmeans']/class[@name='Cluster']/method[@name='size' and count(parameter)=0]"
		[Register ("size", "()I", "GetSizeHandler")]
		public virtual unsafe int Size ()
		{
			if (id_size == IntPtr.Zero)
				id_size = JNIEnv.GetMethodID (class_ref, "size", "()I");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_size);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "size", "()I"));
			} finally {
			}
		}

	}
}
