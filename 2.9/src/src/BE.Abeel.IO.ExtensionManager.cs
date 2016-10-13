using System;
using System.Collections.Generic;
using Android.Runtime;

namespace BE.Abeel.IO {

	// Metadata.xml XPath class reference: path="/api/package[@name='be.abeel.io']/class[@name='ExtensionManager']"
	[global::Android.Runtime.Register ("be/abeel/io/ExtensionManager", DoNotGenerateAcw=true)]
	public partial class ExtensionManager : global::Java.Lang.Object {


		static IntPtr BMP_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='be.abeel.io']/class[@name='ExtensionManager']/field[@name='BMP']"
		[Register ("BMP")]
		public static global::System.Collections.IList Bmp {
			get {
				if (BMP_jfieldId == IntPtr.Zero)
					BMP_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BMP", "Ljava/util/List;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BMP_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (BMP_jfieldId == IntPtr.Zero)
					BMP_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BMP", "Ljava/util/List;");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, BMP_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr EPS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='be.abeel.io']/class[@name='ExtensionManager']/field[@name='EPS']"
		[Register ("EPS")]
		public static global::System.Collections.IList Eps {
			get {
				if (EPS_jfieldId == IntPtr.Zero)
					EPS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EPS", "Ljava/util/List;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EPS_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (EPS_jfieldId == IntPtr.Zero)
					EPS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EPS", "Ljava/util/List;");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, EPS_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr GIF_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='be.abeel.io']/class[@name='ExtensionManager']/field[@name='GIF']"
		[Register ("GIF")]
		public static global::System.Collections.IList Gif {
			get {
				if (GIF_jfieldId == IntPtr.Zero)
					GIF_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GIF", "Ljava/util/List;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, GIF_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (GIF_jfieldId == IntPtr.Zero)
					GIF_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GIF", "Ljava/util/List;");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, GIF_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr ICO_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='be.abeel.io']/class[@name='ExtensionManager']/field[@name='ICO']"
		[Register ("ICO")]
		public static global::System.Collections.IList Ico {
			get {
				if (ICO_jfieldId == IntPtr.Zero)
					ICO_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ICO", "Ljava/util/List;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ICO_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (ICO_jfieldId == IntPtr.Zero)
					ICO_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ICO", "Ljava/util/List;");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, ICO_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr JPG_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='be.abeel.io']/class[@name='ExtensionManager']/field[@name='JPG']"
		[Register ("JPG")]
		public static global::System.Collections.IList Jpg {
			get {
				if (JPG_jfieldId == IntPtr.Zero)
					JPG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "JPG", "Ljava/util/List;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, JPG_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (JPG_jfieldId == IntPtr.Zero)
					JPG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "JPG", "Ljava/util/List;");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, JPG_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr PDF_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='be.abeel.io']/class[@name='ExtensionManager']/field[@name='PDF']"
		[Register ("PDF")]
		public static global::System.Collections.IList Pdf {
			get {
				if (PDF_jfieldId == IntPtr.Zero)
					PDF_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PDF", "Ljava/util/List;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PDF_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (PDF_jfieldId == IntPtr.Zero)
					PDF_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PDF", "Ljava/util/List;");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, PDF_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr PNG_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='be.abeel.io']/class[@name='ExtensionManager']/field[@name='PNG']"
		[Register ("PNG")]
		public static global::System.Collections.IList Png {
			get {
				if (PNG_jfieldId == IntPtr.Zero)
					PNG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PNG", "Ljava/util/List;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PNG_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (PNG_jfieldId == IntPtr.Zero)
					PNG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PNG", "Ljava/util/List;");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, PNG_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr SVG_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='be.abeel.io']/class[@name='ExtensionManager']/field[@name='SVG']"
		[Register ("SVG")]
		public static global::System.Collections.IList Svg {
			get {
				if (SVG_jfieldId == IntPtr.Zero)
					SVG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SVG", "Ljava/util/List;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SVG_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (SVG_jfieldId == IntPtr.Zero)
					SVG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SVG", "Ljava/util/List;");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, SVG_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr WEB_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='be.abeel.io']/class[@name='ExtensionManager']/field[@name='WEB']"
		[Register ("WEB")]
		public static global::System.Collections.IList Web {
			get {
				if (WEB_jfieldId == IntPtr.Zero)
					WEB_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "WEB", "Ljava/util/List;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, WEB_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (WEB_jfieldId == IntPtr.Zero)
					WEB_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "WEB", "Ljava/util/List;");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, WEB_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("be/abeel/io/ExtensionManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ExtensionManager); }
		}

		protected ExtensionManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='be.abeel.io']/class[@name='ExtensionManager']/constructor[@name='ExtensionManager' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ExtensionManager ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ExtensionManager)) {
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

		static IntPtr id_extension_Ljava_io_File_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.io']/class[@name='ExtensionManager']/method[@name='extension' and count(parameter)=2 and parameter[1][@type='java.io.File'] and parameter[2][@type='java.lang.String']]"
		[Register ("extension", "(Ljava/io/File;Ljava/lang/String;)Ljava/io/File;", "")]
		public static unsafe global::Java.IO.File Extension (global::Java.IO.File p0, string p1)
		{
			if (id_extension_Ljava_io_File_Ljava_lang_String_ == IntPtr.Zero)
				id_extension_Ljava_io_File_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "extension", "(Ljava/io/File;Ljava/lang/String;)Ljava/io/File;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				global::Java.IO.File __ret = global::Java.Lang.Object.GetObject<global::Java.IO.File> (JNIEnv.CallStaticObjectMethod  (class_ref, id_extension_Ljava_io_File_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_extension_Ljava_io_File_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.io']/class[@name='ExtensionManager']/method[@name='extension' and count(parameter)=2 and parameter[1][@type='java.io.File'] and parameter[2][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register ("extension", "(Ljava/io/File;Ljava/util/List;)Ljava/io/File;", "")]
		public static unsafe global::Java.IO.File Extension (global::Java.IO.File p0, global::System.Collections.Generic.IList<string> p1)
		{
			if (id_extension_Ljava_io_File_Ljava_util_List_ == IntPtr.Zero)
				id_extension_Ljava_io_File_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "extension", "(Ljava/io/File;Ljava/util/List;)Ljava/io/File;");
			IntPtr native_p1 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				global::Java.IO.File __ret = global::Java.Lang.Object.GetObject<global::Java.IO.File> (JNIEnv.CallStaticObjectMethod  (class_ref, id_extension_Ljava_io_File_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_extension_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.io']/class[@name='ExtensionManager']/method[@name='extension' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("extension", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string Extension (string p0, string p1)
		{
			if (id_extension_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_extension_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "extension", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_extension_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_extension_Ljava_lang_String_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.io']/class[@name='ExtensionManager']/method[@name='extension' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register ("extension", "(Ljava/lang/String;Ljava/util/List;)Ljava/lang/String;", "")]
		public static unsafe string Extension (string p0, global::System.Collections.Generic.IList<string> p1)
		{
			if (id_extension_Ljava_lang_String_Ljava_util_List_ == IntPtr.Zero)
				id_extension_Ljava_lang_String_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "extension", "(Ljava/lang/String;Ljava/util/List;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_extension_Ljava_lang_String_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
