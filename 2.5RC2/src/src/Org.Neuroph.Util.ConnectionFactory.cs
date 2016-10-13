using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.util']/class[@name='ConnectionFactory']"
	[global::Android.Runtime.Register ("org/neuroph/util/ConnectionFactory", DoNotGenerateAcw=true)]
	public partial class ConnectionFactory : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/util/ConnectionFactory", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ConnectionFactory); }
		}

		protected ConnectionFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.util']/class[@name='ConnectionFactory']/constructor[@name='ConnectionFactory' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ConnectionFactory ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ConnectionFactory)) {
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

		static IntPtr id_createConnection_Lorg_neuroph_core_Neuron_Lorg_neuroph_core_Neuron_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util']/class[@name='ConnectionFactory']/method[@name='createConnection' and count(parameter)=2 and parameter[1][@type='org.neuroph.core.Neuron'] and parameter[2][@type='org.neuroph.core.Neuron']]"
		[Register ("createConnection", "(Lorg/neuroph/core/Neuron;Lorg/neuroph/core/Neuron;)V", "")]
		public static unsafe void CreateConnection (global::Org.Neuroph.Core.Neuron p0, global::Org.Neuroph.Core.Neuron p1)
		{
			if (id_createConnection_Lorg_neuroph_core_Neuron_Lorg_neuroph_core_Neuron_ == IntPtr.Zero)
				id_createConnection_Lorg_neuroph_core_Neuron_Lorg_neuroph_core_Neuron_ = JNIEnv.GetStaticMethodID (class_ref, "createConnection", "(Lorg/neuroph/core/Neuron;Lorg/neuroph/core/Neuron;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_createConnection_Lorg_neuroph_core_Neuron_Lorg_neuroph_core_Neuron_, __args);
			} finally {
			}
		}

		static IntPtr id_createConnection_Lorg_neuroph_core_Neuron_Lorg_neuroph_core_Neuron_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util']/class[@name='ConnectionFactory']/method[@name='createConnection' and count(parameter)=3 and parameter[1][@type='org.neuroph.core.Neuron'] and parameter[2][@type='org.neuroph.core.Neuron'] and parameter[3][@type='double']]"
		[Register ("createConnection", "(Lorg/neuroph/core/Neuron;Lorg/neuroph/core/Neuron;D)V", "")]
		public static unsafe void CreateConnection (global::Org.Neuroph.Core.Neuron p0, global::Org.Neuroph.Core.Neuron p1, double p2)
		{
			if (id_createConnection_Lorg_neuroph_core_Neuron_Lorg_neuroph_core_Neuron_D == IntPtr.Zero)
				id_createConnection_Lorg_neuroph_core_Neuron_Lorg_neuroph_core_Neuron_D = JNIEnv.GetStaticMethodID (class_ref, "createConnection", "(Lorg/neuroph/core/Neuron;Lorg/neuroph/core/Neuron;D)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_createConnection_Lorg_neuroph_core_Neuron_Lorg_neuroph_core_Neuron_D, __args);
			} finally {
			}
		}

		static IntPtr id_createConnection_Lorg_neuroph_core_Neuron_Lorg_neuroph_core_Neuron_DI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util']/class[@name='ConnectionFactory']/method[@name='createConnection' and count(parameter)=4 and parameter[1][@type='org.neuroph.core.Neuron'] and parameter[2][@type='org.neuroph.core.Neuron'] and parameter[3][@type='double'] and parameter[4][@type='int']]"
		[Register ("createConnection", "(Lorg/neuroph/core/Neuron;Lorg/neuroph/core/Neuron;DI)V", "")]
		public static unsafe void CreateConnection (global::Org.Neuroph.Core.Neuron p0, global::Org.Neuroph.Core.Neuron p1, double p2, int p3)
		{
			if (id_createConnection_Lorg_neuroph_core_Neuron_Lorg_neuroph_core_Neuron_DI == IntPtr.Zero)
				id_createConnection_Lorg_neuroph_core_Neuron_Lorg_neuroph_core_Neuron_DI = JNIEnv.GetStaticMethodID (class_ref, "createConnection", "(Lorg/neuroph/core/Neuron;Lorg/neuroph/core/Neuron;DI)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_createConnection_Lorg_neuroph_core_Neuron_Lorg_neuroph_core_Neuron_DI, __args);
			} finally {
			}
		}

		static IntPtr id_createConnection_Lorg_neuroph_core_Neuron_Lorg_neuroph_core_Neuron_Lorg_neuroph_core_Weight_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util']/class[@name='ConnectionFactory']/method[@name='createConnection' and count(parameter)=3 and parameter[1][@type='org.neuroph.core.Neuron'] and parameter[2][@type='org.neuroph.core.Neuron'] and parameter[3][@type='org.neuroph.core.Weight']]"
		[Register ("createConnection", "(Lorg/neuroph/core/Neuron;Lorg/neuroph/core/Neuron;Lorg/neuroph/core/Weight;)V", "")]
		public static unsafe void CreateConnection (global::Org.Neuroph.Core.Neuron p0, global::Org.Neuroph.Core.Neuron p1, global::Org.Neuroph.Core.Weight p2)
		{
			if (id_createConnection_Lorg_neuroph_core_Neuron_Lorg_neuroph_core_Neuron_Lorg_neuroph_core_Weight_ == IntPtr.Zero)
				id_createConnection_Lorg_neuroph_core_Neuron_Lorg_neuroph_core_Neuron_Lorg_neuroph_core_Weight_ = JNIEnv.GetStaticMethodID (class_ref, "createConnection", "(Lorg/neuroph/core/Neuron;Lorg/neuroph/core/Neuron;Lorg/neuroph/core/Weight;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_createConnection_Lorg_neuroph_core_Neuron_Lorg_neuroph_core_Neuron_Lorg_neuroph_core_Weight_, __args);
			} finally {
			}
		}

		static IntPtr id_forwardConnect_Lorg_neuroph_core_Layer_Lorg_neuroph_core_Layer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util']/class[@name='ConnectionFactory']/method[@name='forwardConnect' and count(parameter)=2 and parameter[1][@type='org.neuroph.core.Layer'] and parameter[2][@type='org.neuroph.core.Layer']]"
		[Register ("forwardConnect", "(Lorg/neuroph/core/Layer;Lorg/neuroph/core/Layer;)V", "")]
		public static unsafe void ForwardConnect (global::Org.Neuroph.Core.Layer p0, global::Org.Neuroph.Core.Layer p1)
		{
			if (id_forwardConnect_Lorg_neuroph_core_Layer_Lorg_neuroph_core_Layer_ == IntPtr.Zero)
				id_forwardConnect_Lorg_neuroph_core_Layer_Lorg_neuroph_core_Layer_ = JNIEnv.GetStaticMethodID (class_ref, "forwardConnect", "(Lorg/neuroph/core/Layer;Lorg/neuroph/core/Layer;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_forwardConnect_Lorg_neuroph_core_Layer_Lorg_neuroph_core_Layer_, __args);
			} finally {
			}
		}

		static IntPtr id_forwardConnect_Lorg_neuroph_core_Layer_Lorg_neuroph_core_Layer_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util']/class[@name='ConnectionFactory']/method[@name='forwardConnect' and count(parameter)=3 and parameter[1][@type='org.neuroph.core.Layer'] and parameter[2][@type='org.neuroph.core.Layer'] and parameter[3][@type='double']]"
		[Register ("forwardConnect", "(Lorg/neuroph/core/Layer;Lorg/neuroph/core/Layer;D)V", "")]
		public static unsafe void ForwardConnect (global::Org.Neuroph.Core.Layer p0, global::Org.Neuroph.Core.Layer p1, double p2)
		{
			if (id_forwardConnect_Lorg_neuroph_core_Layer_Lorg_neuroph_core_Layer_D == IntPtr.Zero)
				id_forwardConnect_Lorg_neuroph_core_Layer_Lorg_neuroph_core_Layer_D = JNIEnv.GetStaticMethodID (class_ref, "forwardConnect", "(Lorg/neuroph/core/Layer;Lorg/neuroph/core/Layer;D)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_forwardConnect_Lorg_neuroph_core_Layer_Lorg_neuroph_core_Layer_D, __args);
			} finally {
			}
		}

		static IntPtr id_fullConnect_Lorg_neuroph_core_Layer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util']/class[@name='ConnectionFactory']/method[@name='fullConnect' and count(parameter)=1 and parameter[1][@type='org.neuroph.core.Layer']]"
		[Register ("fullConnect", "(Lorg/neuroph/core/Layer;)V", "")]
		public static unsafe void FullConnect (global::Org.Neuroph.Core.Layer p0)
		{
			if (id_fullConnect_Lorg_neuroph_core_Layer_ == IntPtr.Zero)
				id_fullConnect_Lorg_neuroph_core_Layer_ = JNIEnv.GetStaticMethodID (class_ref, "fullConnect", "(Lorg/neuroph/core/Layer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_fullConnect_Lorg_neuroph_core_Layer_, __args);
			} finally {
			}
		}

		static IntPtr id_fullConnect_Lorg_neuroph_core_Layer_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util']/class[@name='ConnectionFactory']/method[@name='fullConnect' and count(parameter)=2 and parameter[1][@type='org.neuroph.core.Layer'] and parameter[2][@type='double']]"
		[Register ("fullConnect", "(Lorg/neuroph/core/Layer;D)V", "")]
		public static unsafe void FullConnect (global::Org.Neuroph.Core.Layer p0, double p1)
		{
			if (id_fullConnect_Lorg_neuroph_core_Layer_D == IntPtr.Zero)
				id_fullConnect_Lorg_neuroph_core_Layer_D = JNIEnv.GetStaticMethodID (class_ref, "fullConnect", "(Lorg/neuroph/core/Layer;D)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_fullConnect_Lorg_neuroph_core_Layer_D, __args);
			} finally {
			}
		}

		static IntPtr id_fullConnect_Lorg_neuroph_core_Layer_DI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util']/class[@name='ConnectionFactory']/method[@name='fullConnect' and count(parameter)=3 and parameter[1][@type='org.neuroph.core.Layer'] and parameter[2][@type='double'] and parameter[3][@type='int']]"
		[Register ("fullConnect", "(Lorg/neuroph/core/Layer;DI)V", "")]
		public static unsafe void FullConnect (global::Org.Neuroph.Core.Layer p0, double p1, int p2)
		{
			if (id_fullConnect_Lorg_neuroph_core_Layer_DI == IntPtr.Zero)
				id_fullConnect_Lorg_neuroph_core_Layer_DI = JNIEnv.GetStaticMethodID (class_ref, "fullConnect", "(Lorg/neuroph/core/Layer;DI)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_fullConnect_Lorg_neuroph_core_Layer_DI, __args);
			} finally {
			}
		}

		static IntPtr id_fullConnect_Lorg_neuroph_core_Layer_Lorg_neuroph_core_Layer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util']/class[@name='ConnectionFactory']/method[@name='fullConnect' and count(parameter)=2 and parameter[1][@type='org.neuroph.core.Layer'] and parameter[2][@type='org.neuroph.core.Layer']]"
		[Register ("fullConnect", "(Lorg/neuroph/core/Layer;Lorg/neuroph/core/Layer;)V", "")]
		public static unsafe void FullConnect (global::Org.Neuroph.Core.Layer p0, global::Org.Neuroph.Core.Layer p1)
		{
			if (id_fullConnect_Lorg_neuroph_core_Layer_Lorg_neuroph_core_Layer_ == IntPtr.Zero)
				id_fullConnect_Lorg_neuroph_core_Layer_Lorg_neuroph_core_Layer_ = JNIEnv.GetStaticMethodID (class_ref, "fullConnect", "(Lorg/neuroph/core/Layer;Lorg/neuroph/core/Layer;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_fullConnect_Lorg_neuroph_core_Layer_Lorg_neuroph_core_Layer_, __args);
			} finally {
			}
		}

		static IntPtr id_fullConnect_Lorg_neuroph_core_Layer_Lorg_neuroph_core_Layer_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util']/class[@name='ConnectionFactory']/method[@name='fullConnect' and count(parameter)=3 and parameter[1][@type='org.neuroph.core.Layer'] and parameter[2][@type='org.neuroph.core.Layer'] and parameter[3][@type='boolean']]"
		[Register ("fullConnect", "(Lorg/neuroph/core/Layer;Lorg/neuroph/core/Layer;Z)V", "")]
		public static unsafe void FullConnect (global::Org.Neuroph.Core.Layer p0, global::Org.Neuroph.Core.Layer p1, bool p2)
		{
			if (id_fullConnect_Lorg_neuroph_core_Layer_Lorg_neuroph_core_Layer_Z == IntPtr.Zero)
				id_fullConnect_Lorg_neuroph_core_Layer_Lorg_neuroph_core_Layer_Z = JNIEnv.GetStaticMethodID (class_ref, "fullConnect", "(Lorg/neuroph/core/Layer;Lorg/neuroph/core/Layer;Z)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_fullConnect_Lorg_neuroph_core_Layer_Lorg_neuroph_core_Layer_Z, __args);
			} finally {
			}
		}

		static IntPtr id_fullConnect_Lorg_neuroph_core_Layer_Lorg_neuroph_core_Layer_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.util']/class[@name='ConnectionFactory']/method[@name='fullConnect' and count(parameter)=3 and parameter[1][@type='org.neuroph.core.Layer'] and parameter[2][@type='org.neuroph.core.Layer'] and parameter[3][@type='double']]"
		[Register ("fullConnect", "(Lorg/neuroph/core/Layer;Lorg/neuroph/core/Layer;D)V", "")]
		public static unsafe void FullConnect (global::Org.Neuroph.Core.Layer p0, global::Org.Neuroph.Core.Layer p1, double p2)
		{
			if (id_fullConnect_Lorg_neuroph_core_Layer_Lorg_neuroph_core_Layer_D == IntPtr.Zero)
				id_fullConnect_Lorg_neuroph_core_Layer_Lorg_neuroph_core_Layer_D = JNIEnv.GetStaticMethodID (class_ref, "fullConnect", "(Lorg/neuroph/core/Layer;Lorg/neuroph/core/Layer;D)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_fullConnect_Lorg_neuroph_core_Layer_Lorg_neuroph_core_Layer_D, __args);
			} finally {
			}
		}

	}
}
