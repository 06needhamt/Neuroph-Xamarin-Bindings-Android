using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Core.Learning.Stop {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.neuroph.core.learning.stop']/interface[@name='StopCondition']"
	[Register ("org/neuroph/core/learning/stop/StopCondition", "", "Org.Neuroph.Core.Learning.Stop.IStopConditionInvoker")]
	public partial interface IStopCondition : IJavaObject {

		bool IsReached {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core.learning.stop']/interface[@name='StopCondition']/method[@name='isReached' and count(parameter)=0]"
			[Register ("isReached", "()Z", "GetIsReachedHandler:Org.Neuroph.Core.Learning.Stop.IStopConditionInvoker, neuroph_2.9")] get;
		}

	}

	[global::Android.Runtime.Register ("org/neuroph/core/learning/stop/StopCondition", DoNotGenerateAcw=true)]
	internal class IStopConditionInvoker : global::Java.Lang.Object, IStopCondition {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/neuroph/core/learning/stop/StopCondition");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IStopConditionInvoker); }
		}

		IntPtr class_ref;

		public static IStopCondition GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IStopCondition> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.neuroph.core.learning.stop.StopCondition"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IStopConditionInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_isReached;
#pragma warning disable 0169
		static Delegate GetIsReachedHandler ()
		{
			if (cb_isReached == null)
				cb_isReached = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsReached);
			return cb_isReached;
		}

		static bool n_IsReached (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Core.Learning.Stop.IStopCondition __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Learning.Stop.IStopCondition> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsReached;
		}
#pragma warning restore 0169

		IntPtr id_isReached;
		public unsafe bool IsReached {
			get {
				if (id_isReached == IntPtr.Zero)
					id_isReached = JNIEnv.GetMethodID (class_ref, "isReached", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_isReached);
			}
		}

	}

}
