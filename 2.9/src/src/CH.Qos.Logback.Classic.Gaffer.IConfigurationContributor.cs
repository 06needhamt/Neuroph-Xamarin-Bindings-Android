using System;
using System.Collections.Generic;
using Android.Runtime;

namespace CH.Qos.Logback.Classic.Gaffer {

	// Metadata.xml XPath interface reference: path="/api/package[@name='ch.qos.logback.classic.gaffer']/interface[@name='ConfigurationContributor']"
	[Register ("ch/qos/logback/classic/gaffer/ConfigurationContributor", "", "CH.Qos.Logback.Classic.Gaffer.IConfigurationContributorInvoker")]
	public partial interface IConfigurationContributor : IJavaObject {

		global::System.Collections.Generic.IDictionary<string, string> Mappings {
			// Metadata.xml XPath method reference: path="/api/package[@name='ch.qos.logback.classic.gaffer']/interface[@name='ConfigurationContributor']/method[@name='getMappings' and count(parameter)=0]"
			[Register ("getMappings", "()Ljava/util/Map;", "GetGetMappingsHandler:CH.Qos.Logback.Classic.Gaffer.IConfigurationContributorInvoker, neuroph_2.9")] get;
		}

	}

	[global::Android.Runtime.Register ("ch/qos/logback/classic/gaffer/ConfigurationContributor", DoNotGenerateAcw=true)]
	internal class IConfigurationContributorInvoker : global::Java.Lang.Object, IConfigurationContributor {

		static IntPtr java_class_ref = JNIEnv.FindClass ("ch/qos/logback/classic/gaffer/ConfigurationContributor");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IConfigurationContributorInvoker); }
		}

		IntPtr class_ref;

		public static IConfigurationContributor GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IConfigurationContributor> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "ch.qos.logback.classic.gaffer.ConfigurationContributor"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IConfigurationContributorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getMappings;
#pragma warning disable 0169
		static Delegate GetGetMappingsHandler ()
		{
			if (cb_getMappings == null)
				cb_getMappings = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMappings);
			return cb_getMappings;
		}

		static IntPtr n_GetMappings (IntPtr jnienv, IntPtr native__this)
		{
			global::CH.Qos.Logback.Classic.Gaffer.IConfigurationContributor __this = global::Java.Lang.Object.GetObject<global::CH.Qos.Logback.Classic.Gaffer.IConfigurationContributor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.Mappings);
		}
#pragma warning restore 0169

		IntPtr id_getMappings;
		public unsafe global::System.Collections.Generic.IDictionary<string, string> Mappings {
			get {
				if (id_getMappings == IntPtr.Zero)
					id_getMappings = JNIEnv.GetMethodID (class_ref, "getMappings", "()Ljava/util/Map;");
				return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMappings), JniHandleOwnership.TransferLocalRef);
			}
		}

	}

}
