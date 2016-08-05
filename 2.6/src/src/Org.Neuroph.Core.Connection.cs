using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.core']/class[@name='Connection']"
	[global::Android.Runtime.Register ("org/neuroph/core/Connection", DoNotGenerateAcw=true)]
	public partial class Connection : global::Java.Lang.Object, global::Java.IO.ISerializable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/core/Connection", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Connection); }
		}

		protected Connection (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_neuroph_core_Neuron_Lorg_neuroph_core_Neuron_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.core']/class[@name='Connection']/constructor[@name='Connection' and count(parameter)=2 and parameter[1][@type='org.neuroph.core.Neuron'] and parameter[2][@type='org.neuroph.core.Neuron']]"
		[Register (".ctor", "(Lorg/neuroph/core/Neuron;Lorg/neuroph/core/Neuron;)V", "")]
		public unsafe Connection (global::Org.Neuroph.Core.Neuron p0, global::Org.Neuroph.Core.Neuron p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (Connection)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/neuroph/core/Neuron;Lorg/neuroph/core/Neuron;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorg/neuroph/core/Neuron;Lorg/neuroph/core/Neuron;)V", __args);
					return;
				}

				if (id_ctor_Lorg_neuroph_core_Neuron_Lorg_neuroph_core_Neuron_ == IntPtr.Zero)
					id_ctor_Lorg_neuroph_core_Neuron_Lorg_neuroph_core_Neuron_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/neuroph/core/Neuron;Lorg/neuroph/core/Neuron;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_neuroph_core_Neuron_Lorg_neuroph_core_Neuron_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_neuroph_core_Neuron_Lorg_neuroph_core_Neuron_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Lorg_neuroph_core_Neuron_Lorg_neuroph_core_Neuron_Lorg_neuroph_core_Weight_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.core']/class[@name='Connection']/constructor[@name='Connection' and count(parameter)=3 and parameter[1][@type='org.neuroph.core.Neuron'] and parameter[2][@type='org.neuroph.core.Neuron'] and parameter[3][@type='org.neuroph.core.Weight']]"
		[Register (".ctor", "(Lorg/neuroph/core/Neuron;Lorg/neuroph/core/Neuron;Lorg/neuroph/core/Weight;)V", "")]
		public unsafe Connection (global::Org.Neuroph.Core.Neuron p0, global::Org.Neuroph.Core.Neuron p1, global::Org.Neuroph.Core.Weight p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (Connection)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/neuroph/core/Neuron;Lorg/neuroph/core/Neuron;Lorg/neuroph/core/Weight;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorg/neuroph/core/Neuron;Lorg/neuroph/core/Neuron;Lorg/neuroph/core/Weight;)V", __args);
					return;
				}

				if (id_ctor_Lorg_neuroph_core_Neuron_Lorg_neuroph_core_Neuron_Lorg_neuroph_core_Weight_ == IntPtr.Zero)
					id_ctor_Lorg_neuroph_core_Neuron_Lorg_neuroph_core_Neuron_Lorg_neuroph_core_Weight_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/neuroph/core/Neuron;Lorg/neuroph/core/Neuron;Lorg/neuroph/core/Weight;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_neuroph_core_Neuron_Lorg_neuroph_core_Neuron_Lorg_neuroph_core_Weight_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_neuroph_core_Neuron_Lorg_neuroph_core_Neuron_Lorg_neuroph_core_Weight_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Lorg_neuroph_core_Neuron_Lorg_neuroph_core_Neuron_D;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.core']/class[@name='Connection']/constructor[@name='Connection' and count(parameter)=3 and parameter[1][@type='org.neuroph.core.Neuron'] and parameter[2][@type='org.neuroph.core.Neuron'] and parameter[3][@type='double']]"
		[Register (".ctor", "(Lorg/neuroph/core/Neuron;Lorg/neuroph/core/Neuron;D)V", "")]
		public unsafe Connection (global::Org.Neuroph.Core.Neuron p0, global::Org.Neuroph.Core.Neuron p1, double p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (Connection)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/neuroph/core/Neuron;Lorg/neuroph/core/Neuron;D)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorg/neuroph/core/Neuron;Lorg/neuroph/core/Neuron;D)V", __args);
					return;
				}

				if (id_ctor_Lorg_neuroph_core_Neuron_Lorg_neuroph_core_Neuron_D == IntPtr.Zero)
					id_ctor_Lorg_neuroph_core_Neuron_Lorg_neuroph_core_Neuron_D = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/neuroph/core/Neuron;Lorg/neuroph/core/Neuron;D)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_neuroph_core_Neuron_Lorg_neuroph_core_Neuron_D, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_neuroph_core_Neuron_Lorg_neuroph_core_Neuron_D, __args);
			} finally {
			}
		}

		static Delegate cb_getFromNeuron;
#pragma warning disable 0169
		static Delegate GetGetFromNeuronHandler ()
		{
			if (cb_getFromNeuron == null)
				cb_getFromNeuron = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFromNeuron);
			return cb_getFromNeuron;
		}

		static IntPtr n_GetFromNeuron (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Core.Connection __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Connection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FromNeuron);
		}
#pragma warning restore 0169

		static Delegate cb_setFromNeuron_Lorg_neuroph_core_Neuron_;
#pragma warning disable 0169
		static Delegate GetSetFromNeuron_Lorg_neuroph_core_Neuron_Handler ()
		{
			if (cb_setFromNeuron_Lorg_neuroph_core_Neuron_ == null)
				cb_setFromNeuron_Lorg_neuroph_core_Neuron_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetFromNeuron_Lorg_neuroph_core_Neuron_);
			return cb_setFromNeuron_Lorg_neuroph_core_Neuron_;
		}

		static void n_SetFromNeuron_Lorg_neuroph_core_Neuron_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Core.Connection __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Connection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Core.Neuron p0 = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Neuron> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.FromNeuron = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getFromNeuron;
		static IntPtr id_setFromNeuron_Lorg_neuroph_core_Neuron_;
		public virtual unsafe global::Org.Neuroph.Core.Neuron FromNeuron {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='Connection']/method[@name='getFromNeuron' and count(parameter)=0]"
			[Register ("getFromNeuron", "()Lorg/neuroph/core/Neuron;", "GetGetFromNeuronHandler")]
			get {
				if (id_getFromNeuron == IntPtr.Zero)
					id_getFromNeuron = JNIEnv.GetMethodID (class_ref, "getFromNeuron", "()Lorg/neuroph/core/Neuron;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Neuron> (JNIEnv.CallObjectMethod  (Handle, id_getFromNeuron), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Neuron> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFromNeuron", "()Lorg/neuroph/core/Neuron;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='Connection']/method[@name='setFromNeuron' and count(parameter)=1 and parameter[1][@type='org.neuroph.core.Neuron']]"
			[Register ("setFromNeuron", "(Lorg/neuroph/core/Neuron;)V", "GetSetFromNeuron_Lorg_neuroph_core_Neuron_Handler")]
			set {
				if (id_setFromNeuron_Lorg_neuroph_core_Neuron_ == IntPtr.Zero)
					id_setFromNeuron_Lorg_neuroph_core_Neuron_ = JNIEnv.GetMethodID (class_ref, "setFromNeuron", "(Lorg/neuroph/core/Neuron;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setFromNeuron_Lorg_neuroph_core_Neuron_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFromNeuron", "(Lorg/neuroph/core/Neuron;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getInput;
#pragma warning disable 0169
		static Delegate GetGetInputHandler ()
		{
			if (cb_getInput == null)
				cb_getInput = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetInput);
			return cb_getInput;
		}

		static double n_GetInput (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Core.Connection __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Connection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Input;
		}
#pragma warning restore 0169

		static IntPtr id_getInput;
		public virtual unsafe double Input {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='Connection']/method[@name='getInput' and count(parameter)=0]"
			[Register ("getInput", "()D", "GetGetInputHandler")]
			get {
				if (id_getInput == IntPtr.Zero)
					id_getInput = JNIEnv.GetMethodID (class_ref, "getInput", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod  (Handle, id_getInput);
					else
						return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getInput", "()D"));
				} finally {
				}
			}
		}

		static Delegate cb_getToNeuron;
#pragma warning disable 0169
		static Delegate GetGetToNeuronHandler ()
		{
			if (cb_getToNeuron == null)
				cb_getToNeuron = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetToNeuron);
			return cb_getToNeuron;
		}

		static IntPtr n_GetToNeuron (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Core.Connection __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Connection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ToNeuron);
		}
#pragma warning restore 0169

		static Delegate cb_setToNeuron_Lorg_neuroph_core_Neuron_;
#pragma warning disable 0169
		static Delegate GetSetToNeuron_Lorg_neuroph_core_Neuron_Handler ()
		{
			if (cb_setToNeuron_Lorg_neuroph_core_Neuron_ == null)
				cb_setToNeuron_Lorg_neuroph_core_Neuron_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetToNeuron_Lorg_neuroph_core_Neuron_);
			return cb_setToNeuron_Lorg_neuroph_core_Neuron_;
		}

		static void n_SetToNeuron_Lorg_neuroph_core_Neuron_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Core.Connection __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Connection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Core.Neuron p0 = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Neuron> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ToNeuron = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getToNeuron;
		static IntPtr id_setToNeuron_Lorg_neuroph_core_Neuron_;
		public virtual unsafe global::Org.Neuroph.Core.Neuron ToNeuron {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='Connection']/method[@name='getToNeuron' and count(parameter)=0]"
			[Register ("getToNeuron", "()Lorg/neuroph/core/Neuron;", "GetGetToNeuronHandler")]
			get {
				if (id_getToNeuron == IntPtr.Zero)
					id_getToNeuron = JNIEnv.GetMethodID (class_ref, "getToNeuron", "()Lorg/neuroph/core/Neuron;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Neuron> (JNIEnv.CallObjectMethod  (Handle, id_getToNeuron), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Neuron> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getToNeuron", "()Lorg/neuroph/core/Neuron;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='Connection']/method[@name='setToNeuron' and count(parameter)=1 and parameter[1][@type='org.neuroph.core.Neuron']]"
			[Register ("setToNeuron", "(Lorg/neuroph/core/Neuron;)V", "GetSetToNeuron_Lorg_neuroph_core_Neuron_Handler")]
			set {
				if (id_setToNeuron_Lorg_neuroph_core_Neuron_ == IntPtr.Zero)
					id_setToNeuron_Lorg_neuroph_core_Neuron_ = JNIEnv.GetMethodID (class_ref, "setToNeuron", "(Lorg/neuroph/core/Neuron;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setToNeuron_Lorg_neuroph_core_Neuron_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setToNeuron", "(Lorg/neuroph/core/Neuron;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getWeight;
#pragma warning disable 0169
		static Delegate GetGetWeightHandler ()
		{
			if (cb_getWeight == null)
				cb_getWeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetWeight);
			return cb_getWeight;
		}

		static IntPtr n_GetWeight (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Core.Connection __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Connection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Weight);
		}
#pragma warning restore 0169

		static Delegate cb_setWeight_Lorg_neuroph_core_Weight_;
#pragma warning disable 0169
		static Delegate GetSetWeight_Lorg_neuroph_core_Weight_Handler ()
		{
			if (cb_setWeight_Lorg_neuroph_core_Weight_ == null)
				cb_setWeight_Lorg_neuroph_core_Weight_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetWeight_Lorg_neuroph_core_Weight_);
			return cb_setWeight_Lorg_neuroph_core_Weight_;
		}

		static void n_SetWeight_Lorg_neuroph_core_Weight_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Core.Connection __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Connection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Neuroph.Core.Weight p0 = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Weight> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Weight = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getWeight;
		static IntPtr id_setWeight_Lorg_neuroph_core_Weight_;
		public virtual unsafe global::Org.Neuroph.Core.Weight Weight {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='Connection']/method[@name='getWeight' and count(parameter)=0]"
			[Register ("getWeight", "()Lorg/neuroph/core/Weight;", "GetGetWeightHandler")]
			get {
				if (id_getWeight == IntPtr.Zero)
					id_getWeight = JNIEnv.GetMethodID (class_ref, "getWeight", "()Lorg/neuroph/core/Weight;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Weight> (JNIEnv.CallObjectMethod  (Handle, id_getWeight), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Weight> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWeight", "()Lorg/neuroph/core/Weight;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='Connection']/method[@name='setWeight' and count(parameter)=1 and parameter[1][@type='org.neuroph.core.Weight']]"
			[Register ("setWeight", "(Lorg/neuroph/core/Weight;)V", "GetSetWeight_Lorg_neuroph_core_Weight_Handler")]
			set {
				if (id_setWeight_Lorg_neuroph_core_Weight_ == IntPtr.Zero)
					id_setWeight_Lorg_neuroph_core_Weight_ = JNIEnv.GetMethodID (class_ref, "setWeight", "(Lorg/neuroph/core/Weight;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setWeight_Lorg_neuroph_core_Weight_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setWeight", "(Lorg/neuroph/core/Weight;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getWeightedInput;
#pragma warning disable 0169
		static Delegate GetGetWeightedInputHandler ()
		{
			if (cb_getWeightedInput == null)
				cb_getWeightedInput = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetWeightedInput);
			return cb_getWeightedInput;
		}

		static double n_GetWeightedInput (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Core.Connection __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Core.Connection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.WeightedInput;
		}
#pragma warning restore 0169

		static IntPtr id_getWeightedInput;
		public virtual unsafe double WeightedInput {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.core']/class[@name='Connection']/method[@name='getWeightedInput' and count(parameter)=0]"
			[Register ("getWeightedInput", "()D", "GetGetWeightedInputHandler")]
			get {
				if (id_getWeightedInput == IntPtr.Zero)
					id_getWeightedInput = JNIEnv.GetMethodID (class_ref, "getWeightedInput", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod  (Handle, id_getWeightedInput);
					else
						return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWeightedInput", "()D"));
				} finally {
				}
			}
		}

	}
}
