using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Nnet.Learning.Knn {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.nnet.learning.knn']/class[@name='KNearestNeighbour']"
	[global::Android.Runtime.Register ("org/neuroph/nnet/learning/knn/KNearestNeighbour", DoNotGenerateAcw=true)]
	public partial class KNearestNeighbour : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/nnet/learning/knn/KNearestNeighbour", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (KNearestNeighbour); }
		}

		protected KNearestNeighbour (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.nnet.learning.knn']/class[@name='KNearestNeighbour']/constructor[@name='KNearestNeighbour' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe KNearestNeighbour ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (KNearestNeighbour)) {
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
			global::Org.Neuroph.Nnet.Learning.Knn.KNearestNeighbour __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Learning.Knn.KNearestNeighbour> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Org.Neuroph.Nnet.Learning.Kmeans.KVector>.ToLocalJniHandle (__this.DataSet);
		}
#pragma warning restore 0169

		static Delegate cb_setDataSet_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetDataSet_Ljava_util_List_Handler ()
		{
			if (cb_setDataSet_Ljava_util_List_ == null)
				cb_setDataSet_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDataSet_Ljava_util_List_);
			return cb_setDataSet_Ljava_util_List_;
		}

		static void n_SetDataSet_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Nnet.Learning.Knn.KNearestNeighbour __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Learning.Knn.KNearestNeighbour> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Org.Neuroph.Nnet.Learning.Kmeans.KVector>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DataSet = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDataSet;
		static IntPtr id_setDataSet_Ljava_util_List_;
		public virtual unsafe global::System.Collections.Generic.IList<global::Org.Neuroph.Nnet.Learning.Kmeans.KVector> DataSet {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.learning.knn']/class[@name='KNearestNeighbour']/method[@name='getDataSet' and count(parameter)=0]"
			[Register ("getDataSet", "()Ljava/util/List;", "GetGetDataSetHandler")]
			get {
				if (id_getDataSet == IntPtr.Zero)
					id_getDataSet = JNIEnv.GetMethodID (class_ref, "getDataSet", "()Ljava/util/List;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Org.Neuroph.Nnet.Learning.Kmeans.KVector>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDataSet), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Org.Neuroph.Nnet.Learning.Kmeans.KVector>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDataSet", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.learning.knn']/class[@name='KNearestNeighbour']/method[@name='setDataSet' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;org.neuroph.nnet.learning.kmeans.KVector&gt;']]"
			[Register ("setDataSet", "(Ljava/util/List;)V", "GetSetDataSet_Ljava_util_List_Handler")]
			set {
				if (id_setDataSet_Ljava_util_List_ == IntPtr.Zero)
					id_setDataSet_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setDataSet", "(Ljava/util/List;)V");
				IntPtr native_value = global::Android.Runtime.JavaList<global::Org.Neuroph.Nnet.Learning.Kmeans.KVector>.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDataSet_Ljava_util_List_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDataSet", "(Ljava/util/List;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getKNearestNeighbours_Lorg_neuroph_nnet_learning_kmeans_KVector_I;
#pragma warning disable 0169
		static Delegate GetGetKNearestNeighbours_Lorg_neuroph_nnet_learning_kmeans_KVector_IHandler ()
		{
			if (cb_getKNearestNeighbours_Lorg_neuroph_nnet_learning_kmeans_KVector_I == null)
				cb_getKNearestNeighbours_Lorg_neuroph_nnet_learning_kmeans_KVector_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_GetKNearestNeighbours_Lorg_neuroph_nnet_learning_kmeans_KVector_I);
			return cb_getKNearestNeighbours_Lorg_neuroph_nnet_learning_kmeans_KVector_I;
		}

		static IntPtr n_GetKNearestNeighbours_Lorg_neuroph_nnet_learning_kmeans_KVector_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Org.Neuroph.Nnet.Learning.Knn.KNearestNeighbour __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Learning.Knn.KNearestNeighbour> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Nnet.Learning.Kmeans.KVector p0 = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Learning.Kmeans.KVector> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.GetKNearestNeighbours (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getKNearestNeighbours_Lorg_neuroph_nnet_learning_kmeans_KVector_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.nnet.learning.knn']/class[@name='KNearestNeighbour']/method[@name='getKNearestNeighbours' and count(parameter)=2 and parameter[1][@type='org.neuroph.nnet.learning.kmeans.KVector'] and parameter[2][@type='int']]"
		[Register ("getKNearestNeighbours", "(Lorg/neuroph/nnet/learning/kmeans/KVector;I)[Lorg/neuroph/nnet/learning/kmeans/KVector;", "GetGetKNearestNeighbours_Lorg_neuroph_nnet_learning_kmeans_KVector_IHandler")]
		public virtual unsafe global::Org.Neuroph.Nnet.Learning.Kmeans.KVector[] GetKNearestNeighbours (global::Org.Neuroph.Nnet.Learning.Kmeans.KVector p0, int p1)
		{
			if (id_getKNearestNeighbours_Lorg_neuroph_nnet_learning_kmeans_KVector_I == IntPtr.Zero)
				id_getKNearestNeighbours_Lorg_neuroph_nnet_learning_kmeans_KVector_I = JNIEnv.GetMethodID (class_ref, "getKNearestNeighbours", "(Lorg/neuroph/nnet/learning/kmeans/KVector;I)[Lorg/neuroph/nnet/learning/kmeans/KVector;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Org.Neuroph.Nnet.Learning.Kmeans.KVector[] __ret;
				if (GetType () == ThresholdType)
					__ret = (global::Org.Neuroph.Nnet.Learning.Kmeans.KVector[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getKNearestNeighbours_Lorg_neuroph_nnet_learning_kmeans_KVector_I, __args), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Neuroph.Nnet.Learning.Kmeans.KVector));
				else
					__ret = (global::Org.Neuroph.Nnet.Learning.Kmeans.KVector[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getKNearestNeighbours", "(Lorg/neuroph/nnet/learning/kmeans/KVector;I)[Lorg/neuroph/nnet/learning/kmeans/KVector;"), __args), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Neuroph.Nnet.Learning.Kmeans.KVector));
				return __ret;
			} finally {
			}
		}

	}
}
