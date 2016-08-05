using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Neuroph.Imgrec.Image {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.neuroph.imgrec.image']/class[@name='ImageAndroid']"
	[global::Android.Runtime.Register ("org/neuroph/imgrec/image/ImageAndroid", DoNotGenerateAcw=true)]
	public partial class ImageAndroid : global::Java.Lang.Object, global::Org.Neuroph.Imgrec.Image.IImage {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/neuroph/imgrec/image/ImageAndroid", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ImageAndroid); }
		}

		protected ImageAndroid (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_graphics_Bitmap_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.neuroph.imgrec.image']/class[@name='ImageAndroid']/constructor[@name='ImageAndroid' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Register (".ctor", "(Landroid/graphics/Bitmap;)V", "")]
		public unsafe ImageAndroid (global::Android.Graphics.Bitmap p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (ImageAndroid)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/graphics/Bitmap;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/graphics/Bitmap;)V", __args);
					return;
				}

				if (id_ctor_Landroid_graphics_Bitmap_ == IntPtr.Zero)
					id_ctor_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/graphics/Bitmap;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_graphics_Bitmap_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_graphics_Bitmap_, __args);
			} finally {
			}
		}

		static Delegate cb_getBitmap;
#pragma warning disable 0169
		static Delegate GetGetBitmapHandler ()
		{
			if (cb_getBitmap == null)
				cb_getBitmap = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBitmap);
			return cb_getBitmap;
		}

		static IntPtr n_GetBitmap (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Imgrec.Image.ImageAndroid __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Imgrec.Image.ImageAndroid> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Bitmap);
		}
#pragma warning restore 0169

		static Delegate cb_setBitmap_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
		static Delegate GetSetBitmap_Landroid_graphics_Bitmap_Handler ()
		{
			if (cb_setBitmap_Landroid_graphics_Bitmap_ == null)
				cb_setBitmap_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBitmap_Landroid_graphics_Bitmap_);
			return cb_setBitmap_Landroid_graphics_Bitmap_;
		}

		static void n_SetBitmap_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Neuroph.Imgrec.Image.ImageAndroid __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Imgrec.Image.ImageAndroid> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Bitmap = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getBitmap;
		static IntPtr id_setBitmap_Landroid_graphics_Bitmap_;
		public virtual unsafe global::Android.Graphics.Bitmap Bitmap {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.imgrec.image']/class[@name='ImageAndroid']/method[@name='getBitmap' and count(parameter)=0]"
			[Register ("getBitmap", "()Landroid/graphics/Bitmap;", "GetGetBitmapHandler")]
			get {
				if (id_getBitmap == IntPtr.Zero)
					id_getBitmap = JNIEnv.GetMethodID (class_ref, "getBitmap", "()Landroid/graphics/Bitmap;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod  (Handle, id_getBitmap), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBitmap", "()Landroid/graphics/Bitmap;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.imgrec.image']/class[@name='ImageAndroid']/method[@name='setBitmap' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
			[Register ("setBitmap", "(Landroid/graphics/Bitmap;)V", "GetSetBitmap_Landroid_graphics_Bitmap_Handler")]
			set {
				if (id_setBitmap_Landroid_graphics_Bitmap_ == IntPtr.Zero)
					id_setBitmap_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "setBitmap", "(Landroid/graphics/Bitmap;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setBitmap_Landroid_graphics_Bitmap_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBitmap", "(Landroid/graphics/Bitmap;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getHeight;
#pragma warning disable 0169
		static Delegate GetGetHeightHandler ()
		{
			if (cb_getHeight == null)
				cb_getHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHeight);
			return cb_getHeight;
		}

		static int n_GetHeight (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Imgrec.Image.ImageAndroid __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Imgrec.Image.ImageAndroid> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Height;
		}
#pragma warning restore 0169

		static IntPtr id_getHeight;
		public virtual unsafe int Height {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.imgrec.image']/class[@name='ImageAndroid']/method[@name='getHeight' and count(parameter)=0]"
			[Register ("getHeight", "()I", "GetGetHeightHandler")]
			get {
				if (id_getHeight == IntPtr.Zero)
					id_getHeight = JNIEnv.GetMethodID (class_ref, "getHeight", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getHeight);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHeight", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getType;
#pragma warning disable 0169
		static Delegate GetGetTypeHandler ()
		{
			if (cb_getType == null)
				cb_getType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetType);
			return cb_getType;
		}

		static int n_GetType (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Imgrec.Image.ImageAndroid __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Imgrec.Image.ImageAndroid> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Type;
		}
#pragma warning restore 0169

		static IntPtr id_getType;
		public virtual unsafe int Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.imgrec.image']/class[@name='ImageAndroid']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()I", "GetGetTypeHandler")]
			get {
				if (id_getType == IntPtr.Zero)
					id_getType = JNIEnv.GetMethodID (class_ref, "getType", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getType);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getType", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getWidth;
#pragma warning disable 0169
		static Delegate GetGetWidthHandler ()
		{
			if (cb_getWidth == null)
				cb_getWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetWidth);
			return cb_getWidth;
		}

		static int n_GetWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Neuroph.Imgrec.Image.ImageAndroid __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Imgrec.Image.ImageAndroid> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Width;
		}
#pragma warning restore 0169

		static IntPtr id_getWidth;
		public virtual unsafe int Width {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.imgrec.image']/class[@name='ImageAndroid']/method[@name='getWidth' and count(parameter)=0]"
			[Register ("getWidth", "()I", "GetGetWidthHandler")]
			get {
				if (id_getWidth == IntPtr.Zero)
					id_getWidth = JNIEnv.GetMethodID (class_ref, "getWidth", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getWidth);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWidth", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_crop_IIII;
#pragma warning disable 0169
		static Delegate GetCrop_IIIIHandler ()
		{
			if (cb_crop_IIII == null)
				cb_crop_IIII = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, int, int, IntPtr>) n_Crop_IIII);
			return cb_crop_IIII;
		}

		static IntPtr n_Crop_IIII (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, int p3)
		{
			global::Org.Neuroph.Imgrec.Image.ImageAndroid __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Imgrec.Image.ImageAndroid> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Crop (p0, p1, p2, p3));
		}
#pragma warning restore 0169

		static IntPtr id_crop_IIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.imgrec.image']/class[@name='ImageAndroid']/method[@name='crop' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("crop", "(IIII)Lorg/neuroph/imgrec/image/Image;", "GetCrop_IIIIHandler")]
		public virtual unsafe global::Org.Neuroph.Imgrec.Image.IImage Crop (int p0, int p1, int p2, int p3)
		{
			if (id_crop_IIII == IntPtr.Zero)
				id_crop_IIII = JNIEnv.GetMethodID (class_ref, "crop", "(IIII)Lorg/neuroph/imgrec/image/Image;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Imgrec.Image.IImage> (JNIEnv.CallObjectMethod  (Handle, id_crop_IIII, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Imgrec.Image.IImage> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "crop", "(IIII)Lorg/neuroph/imgrec/image/Image;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getPixel_II;
#pragma warning disable 0169
		static Delegate GetGetPixel_IIHandler ()
		{
			if (cb_getPixel_II == null)
				cb_getPixel_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, int>) n_GetPixel_II);
			return cb_getPixel_II;
		}

		static int n_GetPixel_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Org.Neuroph.Imgrec.Image.ImageAndroid __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Imgrec.Image.ImageAndroid> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetPixel (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_getPixel_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.imgrec.image']/class[@name='ImageAndroid']/method[@name='getPixel' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("getPixel", "(II)I", "GetGetPixel_IIHandler")]
		public virtual unsafe int GetPixel (int p0, int p1)
		{
			if (id_getPixel_II == IntPtr.Zero)
				id_getPixel_II = JNIEnv.GetMethodID (class_ref, "getPixel", "(II)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getPixel_II, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPixel", "(II)I"), __args);
			} finally {
			}
		}

		static Delegate cb_getPixels_IIIIII;
#pragma warning disable 0169
		static Delegate GetGetPixels_IIIIIIHandler ()
		{
			if (cb_getPixels_IIIIII == null)
				cb_getPixels_IIIIII = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, int, int, int, int, IntPtr>) n_GetPixels_IIIIII);
			return cb_getPixels_IIIIII;
		}

		static IntPtr n_GetPixels_IIIIII (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, int p3, int p4, int p5)
		{
			global::Org.Neuroph.Imgrec.Image.ImageAndroid __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Imgrec.Image.ImageAndroid> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetPixels (p0, p1, p2, p3, p4, p5));
		}
#pragma warning restore 0169

		static IntPtr id_getPixels_IIIIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.imgrec.image']/class[@name='ImageAndroid']/method[@name='getPixels' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int']]"
		[Register ("getPixels", "(IIIIII)[I", "GetGetPixels_IIIIIIHandler")]
		public virtual unsafe int[] GetPixels (int p0, int p1, int p2, int p3, int p4, int p5)
		{
			if (id_getPixels_IIIIII == IntPtr.Zero)
				id_getPixels_IIIIII = JNIEnv.GetMethodID (class_ref, "getPixels", "(IIIIII)[I");
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);

				if (GetType () == ThresholdType)
					return (int[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getPixels_IIIIII, __args), JniHandleOwnership.TransferLocalRef, typeof (int));
				else
					return (int[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPixels", "(IIIIII)[I"), __args), JniHandleOwnership.TransferLocalRef, typeof (int));
			} finally {
			}
		}

		static Delegate cb_resize_II;
#pragma warning disable 0169
		static Delegate GetResize_IIHandler ()
		{
			if (cb_resize_II == null)
				cb_resize_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr>) n_Resize_II);
			return cb_resize_II;
		}

		static IntPtr n_Resize_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Org.Neuroph.Imgrec.Image.ImageAndroid __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Imgrec.Image.ImageAndroid> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Resize (p0, p1));
		}
#pragma warning restore 0169

		static IntPtr id_resize_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.imgrec.image']/class[@name='ImageAndroid']/method[@name='resize' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("resize", "(II)Lorg/neuroph/imgrec/image/Image;", "GetResize_IIHandler")]
		public virtual unsafe global::Org.Neuroph.Imgrec.Image.IImage Resize (int p0, int p1)
		{
			if (id_resize_II == IntPtr.Zero)
				id_resize_II = JNIEnv.GetMethodID (class_ref, "resize", "(II)Lorg/neuroph/imgrec/image/Image;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Imgrec.Image.IImage> (JNIEnv.CallObjectMethod  (Handle, id_resize_II, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Neuroph.Imgrec.Image.IImage> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "resize", "(II)Lorg/neuroph/imgrec/image/Image;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setPixel_III;
#pragma warning disable 0169
		static Delegate GetSetPixel_IIIHandler ()
		{
			if (cb_setPixel_III == null)
				cb_setPixel_III = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, int>) n_SetPixel_III);
			return cb_setPixel_III;
		}

		static void n_SetPixel_III (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2)
		{
			global::Org.Neuroph.Imgrec.Image.ImageAndroid __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Imgrec.Image.ImageAndroid> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetPixel (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_setPixel_III;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.imgrec.image']/class[@name='ImageAndroid']/method[@name='setPixel' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("setPixel", "(III)V", "GetSetPixel_IIIHandler")]
		public virtual unsafe void SetPixel (int p0, int p1, int p2)
		{
			if (id_setPixel_III == IntPtr.Zero)
				id_setPixel_III = JNIEnv.GetMethodID (class_ref, "setPixel", "(III)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setPixel_III, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPixel", "(III)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setPixels_arrayIIIIIII;
#pragma warning disable 0169
		static Delegate GetSetPixels_arrayIIIIIIIHandler ()
		{
			if (cb_setPixels_arrayIIIIIII == null)
				cb_setPixels_arrayIIIIIII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int, int, int, int, int>) n_SetPixels_arrayIIIIIII);
			return cb_setPixels_arrayIIIIIII;
		}

		static void n_SetPixels_arrayIIIIIII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, int p3, int p4, int p5, int p6)
		{
			global::Org.Neuroph.Imgrec.Image.ImageAndroid __this = global::Java.Lang.Object.GetObject<global::Org.Neuroph.Imgrec.Image.ImageAndroid> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] p0 = (int[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.SetPixels (p0, p1, p2, p3, p4, p5, p6);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_setPixels_arrayIIIIIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.neuroph.imgrec.image']/class[@name='ImageAndroid']/method[@name='setPixels' and count(parameter)=7 and parameter[1][@type='int[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int']]"
		[Register ("setPixels", "([IIIIIII)V", "GetSetPixels_arrayIIIIIIIHandler")]
		public virtual unsafe void SetPixels (int[] p0, int p1, int p2, int p3, int p4, int p5, int p6)
		{
			if (id_setPixels_arrayIIIIIII == IntPtr.Zero)
				id_setPixels_arrayIIIIIII = JNIEnv.GetMethodID (class_ref, "setPixels", "([IIIIIII)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setPixels_arrayIIIIIII, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPixels", "([IIIIIII)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

	}
}
