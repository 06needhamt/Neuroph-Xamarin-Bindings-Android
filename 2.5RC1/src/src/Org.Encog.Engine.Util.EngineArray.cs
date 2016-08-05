using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Encog.Engine.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.encog.engine.util']/class[@name='EngineArray']"
	[global::Android.Runtime.Register ("org/encog/engine/util/EngineArray", DoNotGenerateAcw=true)]
	public sealed partial class EngineArray : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/encog/engine/util/EngineArray", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (EngineArray); }
		}

		internal EngineArray (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_arrayCopy_arrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.util']/class[@name='EngineArray']/method[@name='arrayCopy' and count(parameter)=1 and parameter[1][@type='double[]']]"
		[Register ("arrayCopy", "([D)[D", "")]
		public static unsafe double[] ArrayCopy (double[] p0)
		{
			if (id_arrayCopy_arrayD == IntPtr.Zero)
				id_arrayCopy_arrayD = JNIEnv.GetStaticMethodID (class_ref, "arrayCopy", "([D)[D");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				double[] __ret = (double[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_arrayCopy_arrayD, __args), JniHandleOwnership.TransferLocalRef, typeof (double));
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_arrayCopy_arrayDarrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.util']/class[@name='EngineArray']/method[@name='arrayCopy' and count(parameter)=2 and parameter[1][@type='double[]'] and parameter[2][@type='double[]']]"
		[Register ("arrayCopy", "([D[D)V", "")]
		public static unsafe void ArrayCopy (double[] p0, double[] p1)
		{
			if (id_arrayCopy_arrayDarrayD == IntPtr.Zero)
				id_arrayCopy_arrayDarrayD = JNIEnv.GetStaticMethodID (class_ref, "arrayCopy", "([D[D)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_arrayCopy_arrayDarrayD, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static IntPtr id_arrayCopy_arrayDarrayF;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.util']/class[@name='EngineArray']/method[@name='arrayCopy' and count(parameter)=2 and parameter[1][@type='double[]'] and parameter[2][@type='float[]']]"
		[Register ("arrayCopy", "([D[F)V", "")]
		public static unsafe void ArrayCopy (double[] p0, float[] p1)
		{
			if (id_arrayCopy_arrayDarrayF == IntPtr.Zero)
				id_arrayCopy_arrayDarrayF = JNIEnv.GetStaticMethodID (class_ref, "arrayCopy", "([D[F)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_arrayCopy_arrayDarrayF, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static IntPtr id_arrayCopy_arrayDIarrayDII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.util']/class[@name='EngineArray']/method[@name='arrayCopy' and count(parameter)=5 and parameter[1][@type='double[]'] and parameter[2][@type='int'] and parameter[3][@type='double[]'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("arrayCopy", "([DI[DII)V", "")]
		public static unsafe void ArrayCopy (double[] p0, int p1, double[] p2, int p3, int p4)
		{
			if (id_arrayCopy_arrayDIarrayDII == IntPtr.Zero)
				id_arrayCopy_arrayDIarrayDII = JNIEnv.GetStaticMethodID (class_ref, "arrayCopy", "([DI[DII)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_arrayCopy_arrayDIarrayDII, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static IntPtr id_arrayCopy_arrayarrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.util']/class[@name='EngineArray']/method[@name='arrayCopy' and count(parameter)=1 and parameter[1][@type='double[][]']]"
		[Register ("arrayCopy", "([[D)[[D", "")]
		public static unsafe double[][] ArrayCopy (double[][] p0)
		{
			if (id_arrayCopy_arrayarrayD == IntPtr.Zero)
				id_arrayCopy_arrayarrayD = JNIEnv.GetStaticMethodID (class_ref, "arrayCopy", "([[D)[[D");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				double[][] __ret = (double[][]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_arrayCopy_arrayarrayD, __args), JniHandleOwnership.TransferLocalRef, typeof (double[]));
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_arrayCopy_arrayFarrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.util']/class[@name='EngineArray']/method[@name='arrayCopy' and count(parameter)=2 and parameter[1][@type='float[]'] and parameter[2][@type='double[]']]"
		[Register ("arrayCopy", "([F[D)V", "")]
		public static unsafe void ArrayCopy (float[] p0, double[] p1)
		{
			if (id_arrayCopy_arrayFarrayD == IntPtr.Zero)
				id_arrayCopy_arrayFarrayD = JNIEnv.GetStaticMethodID (class_ref, "arrayCopy", "([F[D)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_arrayCopy_arrayFarrayD, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static IntPtr id_arrayCopy_arrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.util']/class[@name='EngineArray']/method[@name='arrayCopy' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[Register ("arrayCopy", "([I)[I", "")]
		public static unsafe int[] ArrayCopy (int[] p0)
		{
			if (id_arrayCopy_arrayI == IntPtr.Zero)
				id_arrayCopy_arrayI = JNIEnv.GetStaticMethodID (class_ref, "arrayCopy", "([I)[I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				int[] __ret = (int[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_arrayCopy_arrayI, __args), JniHandleOwnership.TransferLocalRef, typeof (int));
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_arrayCopy_arrayIarrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.util']/class[@name='EngineArray']/method[@name='arrayCopy' and count(parameter)=2 and parameter[1][@type='int[]'] and parameter[2][@type='int[]']]"
		[Register ("arrayCopy", "([I[I)V", "")]
		public static unsafe void ArrayCopy (int[] p0, int[] p1)
		{
			if (id_arrayCopy_arrayIarrayI == IntPtr.Zero)
				id_arrayCopy_arrayIarrayI = JNIEnv.GetStaticMethodID (class_ref, "arrayCopy", "([I[I)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_arrayCopy_arrayIarrayI, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static IntPtr id_doubleToObject_arrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.util']/class[@name='EngineArray']/method[@name='doubleToObject' and count(parameter)=1 and parameter[1][@type='double[]']]"
		[Register ("doubleToObject", "([D)[Ljava/lang/Double;", "")]
		public static unsafe global::Java.Lang.Double[] DoubleToObject (double[] p0)
		{
			if (id_doubleToObject_arrayD == IntPtr.Zero)
				id_doubleToObject_arrayD = JNIEnv.GetStaticMethodID (class_ref, "doubleToObject", "([D)[Ljava/lang/Double;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Java.Lang.Double[] __ret = (global::Java.Lang.Double[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_doubleToObject_arrayD, __args), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Double));
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_fill_arrayDD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.util']/class[@name='EngineArray']/method[@name='fill' and count(parameter)=2 and parameter[1][@type='double[]'] and parameter[2][@type='double']]"
		[Register ("fill", "([DD)V", "")]
		public static unsafe void Fill (double[] p0, double p1)
		{
			if (id_fill_arrayDD == IntPtr.Zero)
				id_fill_arrayDD = JNIEnv.GetStaticMethodID (class_ref, "fill", "([DD)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_fill_arrayDD, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_fill_arrayFF;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.util']/class[@name='EngineArray']/method[@name='fill' and count(parameter)=2 and parameter[1][@type='float[]'] and parameter[2][@type='float']]"
		[Register ("fill", "([FF)V", "")]
		public static unsafe void Fill (float[] p0, float p1)
		{
			if (id_fill_arrayFF == IntPtr.Zero)
				id_fill_arrayFF = JNIEnv.GetStaticMethodID (class_ref, "fill", "([FF)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_fill_arrayFF, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_findStringInArray_arrayLjava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.util']/class[@name='EngineArray']/method[@name='findStringInArray' and count(parameter)=2 and parameter[1][@type='java.lang.String[]'] and parameter[2][@type='java.lang.String']]"
		[Register ("findStringInArray", "([Ljava/lang/String;Ljava/lang/String;)I", "")]
		public static unsafe int FindStringInArray (string[] p0, string p1)
		{
			if (id_findStringInArray_arrayLjava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_findStringInArray_arrayLjava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "findStringInArray", "([Ljava/lang/String;Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_findStringInArray_arrayLjava_lang_String_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_listToDouble_Ljava_util_Collection_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.util']/class[@name='EngineArray']/method[@name='listToDouble' and count(parameter)=1 and parameter[1][@type='java.util.Collection&lt;?&gt;']]"
		[Register ("listToDouble", "(Ljava/util/Collection;)[D", "")]
		public static unsafe double[] ListToDouble (global::System.Collections.Generic.ICollection<object> p0)
		{
			if (id_listToDouble_Ljava_util_Collection_ == IntPtr.Zero)
				id_listToDouble_Ljava_util_Collection_ = JNIEnv.GetStaticMethodID (class_ref, "listToDouble", "(Ljava/util/Collection;)[D");
			IntPtr native_p0 = global::Android.Runtime.JavaCollection<object>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				double[] __ret = (double[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_listToDouble_Ljava_util_Collection_, __args), JniHandleOwnership.TransferLocalRef, typeof (double));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_objectToDouble_arrayLjava_lang_Double_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.util']/class[@name='EngineArray']/method[@name='objectToDouble' and count(parameter)=1 and parameter[1][@type='java.lang.Double[]']]"
		[Register ("objectToDouble", "([Ljava/lang/Double;)[D", "")]
		public static unsafe double[] ObjectToDouble (global::Java.Lang.Double[] p0)
		{
			if (id_objectToDouble_arrayLjava_lang_Double_ == IntPtr.Zero)
				id_objectToDouble_arrayLjava_lang_Double_ = JNIEnv.GetStaticMethodID (class_ref, "objectToDouble", "([Ljava/lang/Double;)[D");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				double[] __ret = (double[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_objectToDouble_arrayLjava_lang_Double_, __args), JniHandleOwnership.TransferLocalRef, typeof (double));
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_vectorProduct_arrayDarrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.encog.engine.util']/class[@name='EngineArray']/method[@name='vectorProduct' and count(parameter)=2 and parameter[1][@type='double[]'] and parameter[2][@type='double[]']]"
		[Register ("vectorProduct", "([D[D)D", "")]
		public static unsafe double VectorProduct (double[] p0, double[] p1)
		{
			if (id_vectorProduct_arrayDarrayD == IntPtr.Zero)
				id_vectorProduct_arrayDarrayD = JNIEnv.GetStaticMethodID (class_ref, "vectorProduct", "([D[D)D");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				double __ret = JNIEnv.CallStaticDoubleMethod  (class_ref, id_vectorProduct_arrayDarrayD, __args);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

	}
}
