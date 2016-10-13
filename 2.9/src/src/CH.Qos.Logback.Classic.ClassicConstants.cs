using System;
using System.Collections.Generic;
using Android.Runtime;

namespace CH.Qos.Logback.Classic {

	// Metadata.xml XPath class reference: path="/api/package[@name='ch.qos.logback.classic']/class[@name='ClassicConstants']"
	[global::Android.Runtime.Register ("ch/qos/logback/classic/ClassicConstants", DoNotGenerateAcw=true)]
	public partial class ClassicConstants : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='ch.qos.logback.classic']/class[@name='ClassicConstants']/field[@name='DEFAULT_MAX_CALLEDER_DATA_DEPTH']"
		[Register ("DEFAULT_MAX_CALLEDER_DATA_DEPTH")]
		public const int DefaultMaxCallederDataDepth = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='ch.qos.logback.classic']/class[@name='ClassicConstants']/field[@name='FINALIZE_SESSION']"
		[Register ("FINALIZE_SESSION")]
		public const string FinalizeSession = (string) "FINALIZE_SESSION";

		// Metadata.xml XPath field reference: path="/api/package[@name='ch.qos.logback.classic']/class[@name='ClassicConstants']/field[@name='GAFFER_CONFIGURATOR_FQCN']"
		[Register ("GAFFER_CONFIGURATOR_FQCN")]
		public const string GafferConfiguratorFqcn = (string) "ch.qos.logback.classic.gaffer.GafferConfigurator";

		// Metadata.xml XPath field reference: path="/api/package[@name='ch.qos.logback.classic']/class[@name='ClassicConstants']/field[@name='JNDI_CONFIGURATION_RESOURCE']"
		[Register ("JNDI_CONFIGURATION_RESOURCE")]
		public const string JndiConfigurationResource = (string) "java:comp/env/logback/configuration-resource";

		// Metadata.xml XPath field reference: path="/api/package[@name='ch.qos.logback.classic']/class[@name='ClassicConstants']/field[@name='JNDI_CONTEXT_NAME']"
		[Register ("JNDI_CONTEXT_NAME")]
		public const string JndiContextName = (string) "java:comp/env/logback/context-name";

		// Metadata.xml XPath field reference: path="/api/package[@name='ch.qos.logback.classic']/class[@name='ClassicConstants']/field[@name='LOGBACK_CONTEXT_SELECTOR']"
		[Register ("LOGBACK_CONTEXT_SELECTOR")]
		public const string LogbackContextSelector = (string) "logback.ContextSelector";

		// Metadata.xml XPath field reference: path="/api/package[@name='ch.qos.logback.classic']/class[@name='ClassicConstants']/field[@name='MAX_DOTS']"
		[Register ("MAX_DOTS")]
		public const int MaxDots = (int) 16;

		// Metadata.xml XPath field reference: path="/api/package[@name='ch.qos.logback.classic']/class[@name='ClassicConstants']/field[@name='REQUEST_QUERY_STRING']"
		[Register ("REQUEST_QUERY_STRING")]
		public const string RequestQueryString = (string) "req.queryString";

		// Metadata.xml XPath field reference: path="/api/package[@name='ch.qos.logback.classic']/class[@name='ClassicConstants']/field[@name='REQUEST_REMOTE_HOST_MDC_KEY']"
		[Register ("REQUEST_REMOTE_HOST_MDC_KEY")]
		public const string RequestRemoteHostMdcKey = (string) "req.remoteHost";

		// Metadata.xml XPath field reference: path="/api/package[@name='ch.qos.logback.classic']/class[@name='ClassicConstants']/field[@name='REQUEST_REQUEST_URI']"
		[Register ("REQUEST_REQUEST_URI")]
		public const string RequestRequestUri = (string) "req.requestURI";

		// Metadata.xml XPath field reference: path="/api/package[@name='ch.qos.logback.classic']/class[@name='ClassicConstants']/field[@name='REQUEST_REQUEST_URL']"
		[Register ("REQUEST_REQUEST_URL")]
		public const string RequestRequestUrl = (string) "req.requestURL";

		// Metadata.xml XPath field reference: path="/api/package[@name='ch.qos.logback.classic']/class[@name='ClassicConstants']/field[@name='REQUEST_USER_AGENT_MDC_KEY']"
		[Register ("REQUEST_USER_AGENT_MDC_KEY")]
		public const string RequestUserAgentMdcKey = (string) "req.userAgent";

		// Metadata.xml XPath field reference: path="/api/package[@name='ch.qos.logback.classic']/class[@name='ClassicConstants']/field[@name='REQUEST_X_FORWARDED_FOR']"
		[Register ("REQUEST_X_FORWARDED_FOR")]
		public const string RequestXForwardedFor = (string) "req.xForwardedFor";

		// Metadata.xml XPath field reference: path="/api/package[@name='ch.qos.logback.classic']/class[@name='ClassicConstants']/field[@name='USER_MDC_KEY']"
		[Register ("USER_MDC_KEY")]
		public const string UserMdcKey = (string) "user";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("ch/qos/logback/classic/ClassicConstants", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ClassicConstants); }
		}

		protected ClassicConstants (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='ch.qos.logback.classic']/class[@name='ClassicConstants']/constructor[@name='ClassicConstants' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ClassicConstants ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ClassicConstants)) {
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

	}
}
