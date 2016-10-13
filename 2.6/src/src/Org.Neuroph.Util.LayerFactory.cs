using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.util']/class[@name='LayerFactory']"
	[global::Android.Runtime.Register ("org/neuroph/util/LayerFactory", DoNotGenerateAcw=true)]
	public partial class LayerFactory : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/util/LayerFactory", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LayerFactory); }
		}

		protected LayerFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.util']/class[@name='LayerFactory']/constructor[@name='LayerFactory' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe LayerFactory ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (LayerFactory)) {
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

		static IntPtr id_createLayer_ILjava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util']/class[@name='LayerFactory']/method[@name='createLayer' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.Class&lt;? extends org.neuroph.core.transfer.TransferFunction&gt;']]"
		[Register ("createLayer", "(ILjava/lang/Class;)Lorg/neuroph/core/Layer;", "")]
		public static unsafe global::Org.Neuroph.Core.Layer CreateLayer (int p0, global::Java.Lang.Class p1)
		{
			if (id_createLayer_ILjava_lang_Class_ == IntPtr.Zero)
				id_createLayer_ILjava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "createLayer", "(ILjava/lang/Class;)Lorg/neuroph/core/Layer;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Org.Neuroph.Core.Layer __ret = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Layer> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createLayer_ILjava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_createLayer_ILorg_neuroph_util_NeuronProperties_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util']/class[@name='LayerFactory']/method[@name='createLayer' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='org.neuroph.util.NeuronProperties']]"
		[Register ("createLayer", "(ILorg/neuroph/util/NeuronProperties;)Lorg/neuroph/core/Layer;", "")]
		public static unsafe global::Org.Neuroph.Core.Layer CreateLayer (int p0, global::Org.Neuroph.Util.NeuronProperties p1)
		{
			if (id_createLayer_ILorg_neuroph_util_NeuronProperties_ == IntPtr.Zero)
				id_createLayer_ILorg_neuroph_util_NeuronProperties_ = JNIEnv.GetStaticMethodID (class_ref, "createLayer", "(ILorg/neuroph/util/NeuronProperties;)Lorg/neuroph/core/Layer;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Org.Neuroph.Core.Layer __ret = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Layer> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createLayer_ILorg_neuroph_util_NeuronProperties_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_createLayer_ILorg_neuroph_util_TransferFunctionType_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util']/class[@name='LayerFactory']/method[@name='createLayer' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='org.neuroph.util.TransferFunctionType']]"
		[Register ("createLayer", "(ILorg/neuroph/util/TransferFunctionType;)Lorg/neuroph/core/Layer;", "")]
		public static unsafe global::Org.Neuroph.Core.Layer CreateLayer (int p0, global::Org.Neuroph.Util.TransferFunctionType p1)
		{
			if (id_createLayer_ILorg_neuroph_util_TransferFunctionType_ == IntPtr.Zero)
				id_createLayer_ILorg_neuroph_util_TransferFunctionType_ = JNIEnv.GetStaticMethodID (class_ref, "createLayer", "(ILorg/neuroph/util/TransferFunctionType;)Lorg/neuroph/core/Layer;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Org.Neuroph.Core.Layer __ret = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Layer> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createLayer_ILorg_neuroph_util_TransferFunctionType_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_createLayer_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util']/class[@name='LayerFactory']/method[@name='createLayer' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;org.neuroph.util.NeuronProperties&gt;']]"
		[Register ("createLayer", "(Ljava/util/List;)Lorg/neuroph/core/Layer;", "")]
		public static unsafe global::Org.Neuroph.Core.Layer CreateLayer (global::System.Collections.Generic.IList<global::Org.Neuroph.Util.NeuronProperties> p0)
		{
			if (id_createLayer_Ljava_util_List_ == IntPtr.Zero)
				id_createLayer_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "createLayer", "(Ljava/util/List;)Lorg/neuroph/core/Layer;");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Org.Neuroph.Util.NeuronProperties>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Org.Neuroph.Core.Layer __ret = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Layer> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createLayer_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
