using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.util']/class[@name='NeuralNetworkType']"
	[global::Android.Runtime.Register ("org/neuroph/util/NeuralNetworkType", DoNotGenerateAcw=true)]
	public sealed partial class NeuralNetworkType : global::Java.Lang.Enum {


		static IntPtr ADALINE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.neuroph.util']/class[@name='NeuralNetworkType']/field[@name='ADALINE']"
		[Register ("ADALINE")]
		public static global::Org.Neuroph.Util.NeuralNetworkType Adaline {
			get {
				if (ADALINE_jfieldId == IntPtr.Zero)
					ADALINE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ADALINE", "Lorg/neuroph/util/NeuralNetworkType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ADALINE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.NeuralNetworkType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr BAM_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.neuroph.util']/class[@name='NeuralNetworkType']/field[@name='BAM']"
		[Register ("BAM")]
		public static global::Org.Neuroph.Util.NeuralNetworkType Bam {
			get {
				if (BAM_jfieldId == IntPtr.Zero)
					BAM_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BAM", "Lorg/neuroph/util/NeuralNetworkType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BAM_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.NeuralNetworkType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr COMPETITIVE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.neuroph.util']/class[@name='NeuralNetworkType']/field[@name='COMPETITIVE']"
		[Register ("COMPETITIVE")]
		public static global::Org.Neuroph.Util.NeuralNetworkType Competitive {
			get {
				if (COMPETITIVE_jfieldId == IntPtr.Zero)
					COMPETITIVE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "COMPETITIVE", "Lorg/neuroph/util/NeuralNetworkType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, COMPETITIVE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.NeuralNetworkType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr HOPFIELD_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.neuroph.util']/class[@name='NeuralNetworkType']/field[@name='HOPFIELD']"
		[Register ("HOPFIELD")]
		public static global::Org.Neuroph.Util.NeuralNetworkType Hopfield {
			get {
				if (HOPFIELD_jfieldId == IntPtr.Zero)
					HOPFIELD_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "HOPFIELD", "Lorg/neuroph/util/NeuralNetworkType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, HOPFIELD_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.NeuralNetworkType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr INSTAR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.neuroph.util']/class[@name='NeuralNetworkType']/field[@name='INSTAR']"
		[Register ("INSTAR")]
		public static global::Org.Neuroph.Util.NeuralNetworkType Instar {
			get {
				if (INSTAR_jfieldId == IntPtr.Zero)
					INSTAR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INSTAR", "Lorg/neuroph/util/NeuralNetworkType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INSTAR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.NeuralNetworkType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr KOHONEN_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.neuroph.util']/class[@name='NeuralNetworkType']/field[@name='KOHONEN']"
		[Register ("KOHONEN")]
		public static global::Org.Neuroph.Util.NeuralNetworkType Kohonen {
			get {
				if (KOHONEN_jfieldId == IntPtr.Zero)
					KOHONEN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "KOHONEN", "Lorg/neuroph/util/NeuralNetworkType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, KOHONEN_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.NeuralNetworkType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr MAXNET_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.neuroph.util']/class[@name='NeuralNetworkType']/field[@name='MAXNET']"
		[Register ("MAXNET")]
		public static global::Org.Neuroph.Util.NeuralNetworkType Maxnet {
			get {
				if (MAXNET_jfieldId == IntPtr.Zero)
					MAXNET_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MAXNET", "Lorg/neuroph/util/NeuralNetworkType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MAXNET_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.NeuralNetworkType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr MULTI_LAYER_PERCEPTRON_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.neuroph.util']/class[@name='NeuralNetworkType']/field[@name='MULTI_LAYER_PERCEPTRON']"
		[Register ("MULTI_LAYER_PERCEPTRON")]
		public static global::Org.Neuroph.Util.NeuralNetworkType MultiLayerPerceptron {
			get {
				if (MULTI_LAYER_PERCEPTRON_jfieldId == IntPtr.Zero)
					MULTI_LAYER_PERCEPTRON_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MULTI_LAYER_PERCEPTRON", "Lorg/neuroph/util/NeuralNetworkType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MULTI_LAYER_PERCEPTRON_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.NeuralNetworkType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr NEURO_FUZZY_REASONER_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.neuroph.util']/class[@name='NeuralNetworkType']/field[@name='NEURO_FUZZY_REASONER']"
		[Register ("NEURO_FUZZY_REASONER")]
		public static global::Org.Neuroph.Util.NeuralNetworkType NeuroFuzzyReasoner {
			get {
				if (NEURO_FUZZY_REASONER_jfieldId == IntPtr.Zero)
					NEURO_FUZZY_REASONER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NEURO_FUZZY_REASONER", "Lorg/neuroph/util/NeuralNetworkType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NEURO_FUZZY_REASONER_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.NeuralNetworkType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr OUTSTAR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.neuroph.util']/class[@name='NeuralNetworkType']/field[@name='OUTSTAR']"
		[Register ("OUTSTAR")]
		public static global::Org.Neuroph.Util.NeuralNetworkType Outstar {
			get {
				if (OUTSTAR_jfieldId == IntPtr.Zero)
					OUTSTAR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OUTSTAR", "Lorg/neuroph/util/NeuralNetworkType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, OUTSTAR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.NeuralNetworkType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr PERCEPTRON_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.neuroph.util']/class[@name='NeuralNetworkType']/field[@name='PERCEPTRON']"
		[Register ("PERCEPTRON")]
		public static global::Org.Neuroph.Util.NeuralNetworkType Perceptron {
			get {
				if (PERCEPTRON_jfieldId == IntPtr.Zero)
					PERCEPTRON_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PERCEPTRON", "Lorg/neuroph/util/NeuralNetworkType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PERCEPTRON_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.NeuralNetworkType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr RBF_NETWORK_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.neuroph.util']/class[@name='NeuralNetworkType']/field[@name='RBF_NETWORK']"
		[Register ("RBF_NETWORK")]
		public static global::Org.Neuroph.Util.NeuralNetworkType RbfNetwork {
			get {
				if (RBF_NETWORK_jfieldId == IntPtr.Zero)
					RBF_NETWORK_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RBF_NETWORK", "Lorg/neuroph/util/NeuralNetworkType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RBF_NETWORK_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.NeuralNetworkType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr RECOMMENDER_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.neuroph.util']/class[@name='NeuralNetworkType']/field[@name='RECOMMENDER']"
		[Register ("RECOMMENDER")]
		public static global::Org.Neuroph.Util.NeuralNetworkType Recommender {
			get {
				if (RECOMMENDER_jfieldId == IntPtr.Zero)
					RECOMMENDER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RECOMMENDER", "Lorg/neuroph/util/NeuralNetworkType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RECOMMENDER_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.NeuralNetworkType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SUPERVISED_HEBBIAN_NET_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.neuroph.util']/class[@name='NeuralNetworkType']/field[@name='SUPERVISED_HEBBIAN_NET']"
		[Register ("SUPERVISED_HEBBIAN_NET")]
		public static global::Org.Neuroph.Util.NeuralNetworkType SupervisedHebbianNet {
			get {
				if (SUPERVISED_HEBBIAN_NET_jfieldId == IntPtr.Zero)
					SUPERVISED_HEBBIAN_NET_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SUPERVISED_HEBBIAN_NET", "Lorg/neuroph/util/NeuralNetworkType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SUPERVISED_HEBBIAN_NET_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.NeuralNetworkType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr UNSUPERVISED_HEBBIAN_NET_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.neuroph.util']/class[@name='NeuralNetworkType']/field[@name='UNSUPERVISED_HEBBIAN_NET']"
		[Register ("UNSUPERVISED_HEBBIAN_NET")]
		public static global::Org.Neuroph.Util.NeuralNetworkType UnsupervisedHebbianNet {
			get {
				if (UNSUPERVISED_HEBBIAN_NET_jfieldId == IntPtr.Zero)
					UNSUPERVISED_HEBBIAN_NET_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNSUPERVISED_HEBBIAN_NET", "Lorg/neuroph/util/NeuralNetworkType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNSUPERVISED_HEBBIAN_NET_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.NeuralNetworkType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/util/NeuralNetworkType", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NeuralNetworkType); }
		}

		internal NeuralNetworkType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getTypeLabel;
		public unsafe string TypeLabel {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util']/class[@name='NeuralNetworkType']/method[@name='getTypeLabel' and count(parameter)=0]"
			[Register ("getTypeLabel", "()Ljava/lang/String;", "GetGetTypeLabelHandler")]
			get {
				if (id_getTypeLabel == IntPtr.Zero)
					id_getTypeLabel = JNIEnv.GetMethodID (class_ref, "getTypeLabel", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTypeLabel), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util']/class[@name='NeuralNetworkType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lorg/neuroph/util/NeuralNetworkType;", "")]
		public static unsafe global::Org.Neuroph.Util.NeuralNetworkType ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lorg/neuroph/util/NeuralNetworkType;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Org.Neuroph.Util.NeuralNetworkType __ret = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Util.NeuralNetworkType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util']/class[@name='NeuralNetworkType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lorg/neuroph/util/NeuralNetworkType;", "")]
		public static unsafe global::Org.Neuroph.Util.NeuralNetworkType[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lorg/neuroph/util/NeuralNetworkType;");
			try {
				return (global::Org.Neuroph.Util.NeuralNetworkType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Neuroph.Util.NeuralNetworkType));
			} finally {
			}
		}

	}
}
