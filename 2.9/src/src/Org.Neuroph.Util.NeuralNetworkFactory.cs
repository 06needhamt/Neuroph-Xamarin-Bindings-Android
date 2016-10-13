using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.util']/class[@name='NeuralNetworkFactory']"
	[global::Android.Runtime.Register ("org/neuroph/util/NeuralNetworkFactory", DoNotGenerateAcw=true)]
	public partial class NeuralNetworkFactory : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/util/NeuralNetworkFactory", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NeuralNetworkFactory); }
		}

		protected NeuralNetworkFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.util']/class[@name='NeuralNetworkFactory']/constructor[@name='NeuralNetworkFactory' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe NeuralNetworkFactory ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (NeuralNetworkFactory)) {
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

		static IntPtr id_createAdaline_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util']/class[@name='NeuralNetworkFactory']/method[@name='createAdaline' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("createAdaline", "(I)Lorg/neuroph/nnet/Adaline;", "")]
		public static unsafe global::Org.Neuroph.Nnet.Adaline CreateAdaline (int p0)
		{
			if (id_createAdaline_I == IntPtr.Zero)
				id_createAdaline_I = JNIEnv.GetStaticMethodID (class_ref, "createAdaline", "(I)Lorg/neuroph/nnet/Adaline;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Adaline> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createAdaline_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_createBam_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util']/class[@name='NeuralNetworkFactory']/method[@name='createBam' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("createBam", "(II)Lorg/neuroph/nnet/BAM;", "")]
		public static unsafe global::Org.Neuroph.Nnet.BAM CreateBam (int p0, int p1)
		{
			if (id_createBam_II == IntPtr.Zero)
				id_createBam_II = JNIEnv.GetStaticMethodID (class_ref, "createBam", "(II)Lorg/neuroph/nnet/BAM;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.BAM> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createBam_II, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_createCompetitiveNetwork_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util']/class[@name='NeuralNetworkFactory']/method[@name='createCompetitiveNetwork' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("createCompetitiveNetwork", "(II)Lorg/neuroph/nnet/CompetitiveNetwork;", "")]
		public static unsafe global::Org.Neuroph.Nnet.CompetitiveNetwork CreateCompetitiveNetwork (int p0, int p1)
		{
			if (id_createCompetitiveNetwork_II == IntPtr.Zero)
				id_createCompetitiveNetwork_II = JNIEnv.GetStaticMethodID (class_ref, "createCompetitiveNetwork", "(II)Lorg/neuroph/nnet/CompetitiveNetwork;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.CompetitiveNetwork> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createCompetitiveNetwork_II, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_createHopfield_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util']/class[@name='NeuralNetworkFactory']/method[@name='createHopfield' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("createHopfield", "(I)Lorg/neuroph/nnet/Hopfield;", "")]
		public static unsafe global::Org.Neuroph.Nnet.Hopfield CreateHopfield (int p0)
		{
			if (id_createHopfield_I == IntPtr.Zero)
				id_createHopfield_I = JNIEnv.GetStaticMethodID (class_ref, "createHopfield", "(I)Lorg/neuroph/nnet/Hopfield;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Hopfield> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createHopfield_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_createInstar_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util']/class[@name='NeuralNetworkFactory']/method[@name='createInstar' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("createInstar", "(I)Lorg/neuroph/nnet/Instar;", "")]
		public static unsafe global::Org.Neuroph.Nnet.Instar CreateInstar (int p0)
		{
			if (id_createInstar_I == IntPtr.Zero)
				id_createInstar_I = JNIEnv.GetStaticMethodID (class_ref, "createInstar", "(I)Lorg/neuroph/nnet/Instar;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Instar> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createInstar_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_createKohonen_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util']/class[@name='NeuralNetworkFactory']/method[@name='createKohonen' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("createKohonen", "(II)Lorg/neuroph/nnet/Kohonen;", "")]
		public static unsafe global::Org.Neuroph.Nnet.Kohonen CreateKohonen (int p0, int p1)
		{
			if (id_createKohonen_II == IntPtr.Zero)
				id_createKohonen_II = JNIEnv.GetStaticMethodID (class_ref, "createKohonen", "(II)Lorg/neuroph/nnet/Kohonen;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Kohonen> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createKohonen_II, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_createMLPerceptron_Ljava_lang_String_Lorg_neuroph_util_TransferFunctionType_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util']/class[@name='NeuralNetworkFactory']/method[@name='createMLPerceptron' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.neuroph.util.TransferFunctionType']]"
		[Register ("createMLPerceptron", "(Ljava/lang/String;Lorg/neuroph/util/TransferFunctionType;)Lorg/neuroph/nnet/MultiLayerPerceptron;", "")]
		public static unsafe global::Org.Neuroph.Nnet.MultiLayerPerceptron CreateMLPerceptron (string p0, global::Org.Neuroph.Util.TransferFunctionType p1)
		{
			if (id_createMLPerceptron_Ljava_lang_String_Lorg_neuroph_util_TransferFunctionType_ == IntPtr.Zero)
				id_createMLPerceptron_Ljava_lang_String_Lorg_neuroph_util_TransferFunctionType_ = JNIEnv.GetStaticMethodID (class_ref, "createMLPerceptron", "(Ljava/lang/String;Lorg/neuroph/util/TransferFunctionType;)Lorg/neuroph/nnet/MultiLayerPerceptron;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				global::Org.Neuroph.Nnet.MultiLayerPerceptron __ret = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.MultiLayerPerceptron> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createMLPerceptron_Ljava_lang_String_Lorg_neuroph_util_TransferFunctionType_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_createMLPerceptron_Ljava_lang_String_Lorg_neuroph_util_TransferFunctionType_Ljava_lang_Class_ZZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util']/class[@name='NeuralNetworkFactory']/method[@name='createMLPerceptron' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.neuroph.util.TransferFunctionType'] and parameter[3][@type='java.lang.Class'] and parameter[4][@type='boolean'] and parameter[5][@type='boolean']]"
		[Register ("createMLPerceptron", "(Ljava/lang/String;Lorg/neuroph/util/TransferFunctionType;Ljava/lang/Class;ZZ)Lorg/neuroph/nnet/MultiLayerPerceptron;", "")]
		public static unsafe global::Org.Neuroph.Nnet.MultiLayerPerceptron CreateMLPerceptron (string p0, global::Org.Neuroph.Util.TransferFunctionType p1, global::Java.Lang.Class p2, bool p3, bool p4)
		{
			if (id_createMLPerceptron_Ljava_lang_String_Lorg_neuroph_util_TransferFunctionType_Ljava_lang_Class_ZZ == IntPtr.Zero)
				id_createMLPerceptron_Ljava_lang_String_Lorg_neuroph_util_TransferFunctionType_Ljava_lang_Class_ZZ = JNIEnv.GetStaticMethodID (class_ref, "createMLPerceptron", "(Ljava/lang/String;Lorg/neuroph/util/TransferFunctionType;Ljava/lang/Class;ZZ)Lorg/neuroph/nnet/MultiLayerPerceptron;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				global::Org.Neuroph.Nnet.MultiLayerPerceptron __ret = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.MultiLayerPerceptron> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createMLPerceptron_Ljava_lang_String_Lorg_neuroph_util_TransferFunctionType_Ljava_lang_Class_ZZ, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_createMaxNet_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util']/class[@name='NeuralNetworkFactory']/method[@name='createMaxNet' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("createMaxNet", "(I)Lorg/neuroph/nnet/MaxNet;", "")]
		public static unsafe global::Org.Neuroph.Nnet.MaxNet CreateMaxNet (int p0)
		{
			if (id_createMaxNet_I == IntPtr.Zero)
				id_createMaxNet_I = JNIEnv.GetStaticMethodID (class_ref, "createMaxNet", "(I)Lorg/neuroph/nnet/MaxNet;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.MaxNet> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createMaxNet_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_createOutstar_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util']/class[@name='NeuralNetworkFactory']/method[@name='createOutstar' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("createOutstar", "(I)Lorg/neuroph/nnet/Outstar;", "")]
		public static unsafe global::Org.Neuroph.Nnet.Outstar CreateOutstar (int p0)
		{
			if (id_createOutstar_I == IntPtr.Zero)
				id_createOutstar_I = JNIEnv.GetStaticMethodID (class_ref, "createOutstar", "(I)Lorg/neuroph/nnet/Outstar;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Outstar> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createOutstar_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_createPerceptron_IILorg_neuroph_util_TransferFunctionType_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util']/class[@name='NeuralNetworkFactory']/method[@name='createPerceptron' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='org.neuroph.util.TransferFunctionType']]"
		[Register ("createPerceptron", "(IILorg/neuroph/util/TransferFunctionType;)Lorg/neuroph/nnet/Perceptron;", "")]
		public static unsafe global::Org.Neuroph.Nnet.Perceptron CreatePerceptron (int p0, int p1, global::Org.Neuroph.Util.TransferFunctionType p2)
		{
			if (id_createPerceptron_IILorg_neuroph_util_TransferFunctionType_ == IntPtr.Zero)
				id_createPerceptron_IILorg_neuroph_util_TransferFunctionType_ = JNIEnv.GetStaticMethodID (class_ref, "createPerceptron", "(IILorg/neuroph/util/TransferFunctionType;)Lorg/neuroph/nnet/Perceptron;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				global::Org.Neuroph.Nnet.Perceptron __ret = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Perceptron> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createPerceptron_IILorg_neuroph_util_TransferFunctionType_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_createPerceptron_IILorg_neuroph_util_TransferFunctionType_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util']/class[@name='NeuralNetworkFactory']/method[@name='createPerceptron' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='org.neuroph.util.TransferFunctionType'] and parameter[4][@type='java.lang.Class']]"
		[Register ("createPerceptron", "(IILorg/neuroph/util/TransferFunctionType;Ljava/lang/Class;)Lorg/neuroph/nnet/Perceptron;", "")]
		public static unsafe global::Org.Neuroph.Nnet.Perceptron CreatePerceptron (int p0, int p1, global::Org.Neuroph.Util.TransferFunctionType p2, global::Java.Lang.Class p3)
		{
			if (id_createPerceptron_IILorg_neuroph_util_TransferFunctionType_Ljava_lang_Class_ == IntPtr.Zero)
				id_createPerceptron_IILorg_neuroph_util_TransferFunctionType_Ljava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "createPerceptron", "(IILorg/neuroph/util/TransferFunctionType;Ljava/lang/Class;)Lorg/neuroph/nnet/Perceptron;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				global::Org.Neuroph.Nnet.Perceptron __ret = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.Perceptron> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createPerceptron_IILorg_neuroph_util_TransferFunctionType_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_createRbfNetwork_III;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util']/class[@name='NeuralNetworkFactory']/method[@name='createRbfNetwork' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("createRbfNetwork", "(III)Lorg/neuroph/nnet/RBFNetwork;", "")]
		public static unsafe global::Org.Neuroph.Nnet.RBFNetwork CreateRbfNetwork (int p0, int p1, int p2)
		{
			if (id_createRbfNetwork_III == IntPtr.Zero)
				id_createRbfNetwork_III = JNIEnv.GetStaticMethodID (class_ref, "createRbfNetwork", "(III)Lorg/neuroph/nnet/RBFNetwork;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.RBFNetwork> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createRbfNetwork_III, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_createSupervisedHebbian_IILorg_neuroph_util_TransferFunctionType_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util']/class[@name='NeuralNetworkFactory']/method[@name='createSupervisedHebbian' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='org.neuroph.util.TransferFunctionType']]"
		[Register ("createSupervisedHebbian", "(IILorg/neuroph/util/TransferFunctionType;)Lorg/neuroph/nnet/SupervisedHebbianNetwork;", "")]
		public static unsafe global::Org.Neuroph.Nnet.SupervisedHebbianNetwork CreateSupervisedHebbian (int p0, int p1, global::Org.Neuroph.Util.TransferFunctionType p2)
		{
			if (id_createSupervisedHebbian_IILorg_neuroph_util_TransferFunctionType_ == IntPtr.Zero)
				id_createSupervisedHebbian_IILorg_neuroph_util_TransferFunctionType_ = JNIEnv.GetStaticMethodID (class_ref, "createSupervisedHebbian", "(IILorg/neuroph/util/TransferFunctionType;)Lorg/neuroph/nnet/SupervisedHebbianNetwork;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				global::Org.Neuroph.Nnet.SupervisedHebbianNetwork __ret = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.SupervisedHebbianNetwork> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createSupervisedHebbian_IILorg_neuroph_util_TransferFunctionType_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_createUnsupervisedHebbian_IILorg_neuroph_util_TransferFunctionType_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util']/class[@name='NeuralNetworkFactory']/method[@name='createUnsupervisedHebbian' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='org.neuroph.util.TransferFunctionType']]"
		[Register ("createUnsupervisedHebbian", "(IILorg/neuroph/util/TransferFunctionType;)Lorg/neuroph/nnet/UnsupervisedHebbianNetwork;", "")]
		public static unsafe global::Org.Neuroph.Nnet.UnsupervisedHebbianNetwork CreateUnsupervisedHebbian (int p0, int p1, global::Org.Neuroph.Util.TransferFunctionType p2)
		{
			if (id_createUnsupervisedHebbian_IILorg_neuroph_util_TransferFunctionType_ == IntPtr.Zero)
				id_createUnsupervisedHebbian_IILorg_neuroph_util_TransferFunctionType_ = JNIEnv.GetStaticMethodID (class_ref, "createUnsupervisedHebbian", "(IILorg/neuroph/util/TransferFunctionType;)Lorg/neuroph/nnet/UnsupervisedHebbianNetwork;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				global::Org.Neuroph.Nnet.UnsupervisedHebbianNetwork __ret = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Nnet.UnsupervisedHebbianNetwork> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createUnsupervisedHebbian_IILorg_neuroph_util_TransferFunctionType_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_setDefaultIO_Lorg_neuroph_core_NeuralNetwork_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util']/class[@name='NeuralNetworkFactory']/method[@name='setDefaultIO' and count(parameter)=1 and parameter[1][@type='org.neuroph.core.NeuralNetwork']]"
		[Register ("setDefaultIO", "(Lorg/neuroph/core/NeuralNetwork;)V", "")]
		public static unsafe void SetDefaultIO (global::Org.Neuroph.Core.NeuralNetwork p0)
		{
			if (id_setDefaultIO_Lorg_neuroph_core_NeuralNetwork_ == IntPtr.Zero)
				id_setDefaultIO_Lorg_neuroph_core_NeuralNetwork_ = JNIEnv.GetStaticMethodID (class_ref, "setDefaultIO", "(Lorg/neuroph/core/NeuralNetwork;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setDefaultIO_Lorg_neuroph_core_NeuralNetwork_, __args);
			} finally {
			}
		}

	}
}
