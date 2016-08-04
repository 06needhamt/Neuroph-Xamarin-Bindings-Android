using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jocl {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jocl']/class[@name='Sizeof']"
	[global::Android.Runtime.Register ("org/jocl/Sizeof", DoNotGenerateAcw=true)]
	public sealed partial class Sizeof : global::Java.Lang.Object {


		static IntPtr POINTER_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jocl']/class[@name='Sizeof']/field[@name='POINTER']"
		[Register ("POINTER")]
		public static int Pointer {
			get {
				if (POINTER_jfieldId == IntPtr.Zero)
					POINTER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "POINTER", "I");
				return JNIEnv.GetStaticIntField (class_ref, POINTER_jfieldId);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jocl']/class[@name='Sizeof']/field[@name='cl_char']"
		[Register ("cl_char")]
		public const int ClChar = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jocl']/class[@name='Sizeof']/field[@name='cl_char16']"
		[Register ("cl_char16")]
		public const int ClChar16 = (int) 16;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jocl']/class[@name='Sizeof']/field[@name='cl_char2']"
		[Register ("cl_char2")]
		public const int ClChar2 = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jocl']/class[@name='Sizeof']/field[@name='cl_char4']"
		[Register ("cl_char4")]
		public const int ClChar4 = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jocl']/class[@name='Sizeof']/field[@name='cl_char8']"
		[Register ("cl_char8")]
		public const int ClChar8 = (int) 8;

		static IntPtr cl_command_queue_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jocl']/class[@name='Sizeof']/field[@name='cl_command_queue']"
		[Register ("cl_command_queue")]
		public static int ClCommandQueue {
			get {
				if (cl_command_queue_jfieldId == IntPtr.Zero)
					cl_command_queue_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "cl_command_queue", "I");
				return JNIEnv.GetStaticIntField (class_ref, cl_command_queue_jfieldId);
			}
		}

		static IntPtr cl_context_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jocl']/class[@name='Sizeof']/field[@name='cl_context']"
		[Register ("cl_context")]
		public static int ClContext {
			get {
				if (cl_context_jfieldId == IntPtr.Zero)
					cl_context_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "cl_context", "I");
				return JNIEnv.GetStaticIntField (class_ref, cl_context_jfieldId);
			}
		}

		static IntPtr cl_device_id_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jocl']/class[@name='Sizeof']/field[@name='cl_device_id']"
		[Register ("cl_device_id")]
		public static int ClDeviceId {
			get {
				if (cl_device_id_jfieldId == IntPtr.Zero)
					cl_device_id_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "cl_device_id", "I");
				return JNIEnv.GetStaticIntField (class_ref, cl_device_id_jfieldId);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jocl']/class[@name='Sizeof']/field[@name='cl_double']"
		[Register ("cl_double")]
		public const int ClDouble = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jocl']/class[@name='Sizeof']/field[@name='cl_double16']"
		[Register ("cl_double16")]
		public const int ClDouble16 = (int) 128;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jocl']/class[@name='Sizeof']/field[@name='cl_double2']"
		[Register ("cl_double2")]
		public const int ClDouble2 = (int) 16;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jocl']/class[@name='Sizeof']/field[@name='cl_double4']"
		[Register ("cl_double4")]
		public const int ClDouble4 = (int) 32;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jocl']/class[@name='Sizeof']/field[@name='cl_double8']"
		[Register ("cl_double8")]
		public const int ClDouble8 = (int) 64;

		static IntPtr cl_event_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jocl']/class[@name='Sizeof']/field[@name='cl_event']"
		[Register ("cl_event")]
		public static int ClEvent {
			get {
				if (cl_event_jfieldId == IntPtr.Zero)
					cl_event_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "cl_event", "I");
				return JNIEnv.GetStaticIntField (class_ref, cl_event_jfieldId);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jocl']/class[@name='Sizeof']/field[@name='cl_float']"
		[Register ("cl_float")]
		public const int ClFloat = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jocl']/class[@name='Sizeof']/field[@name='cl_float16']"
		[Register ("cl_float16")]
		public const int ClFloat16 = (int) 64;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jocl']/class[@name='Sizeof']/field[@name='cl_float2']"
		[Register ("cl_float2")]
		public const int ClFloat2 = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jocl']/class[@name='Sizeof']/field[@name='cl_float4']"
		[Register ("cl_float4")]
		public const int ClFloat4 = (int) 16;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jocl']/class[@name='Sizeof']/field[@name='cl_float8']"
		[Register ("cl_float8")]
		public const int ClFloat8 = (int) 32;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jocl']/class[@name='Sizeof']/field[@name='cl_half']"
		[Register ("cl_half")]
		public const int ClHalf = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jocl']/class[@name='Sizeof']/field[@name='cl_int']"
		[Register ("cl_int")]
		public const int ClInt = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jocl']/class[@name='Sizeof']/field[@name='cl_int16']"
		[Register ("cl_int16")]
		public const int ClInt16 = (int) 64;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jocl']/class[@name='Sizeof']/field[@name='cl_int2']"
		[Register ("cl_int2")]
		public const int ClInt2 = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jocl']/class[@name='Sizeof']/field[@name='cl_int4']"
		[Register ("cl_int4")]
		public const int ClInt4 = (int) 16;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jocl']/class[@name='Sizeof']/field[@name='cl_int8']"
		[Register ("cl_int8")]
		public const int ClInt8 = (int) 32;

		static IntPtr cl_kernel_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jocl']/class[@name='Sizeof']/field[@name='cl_kernel']"
		[Register ("cl_kernel")]
		public static int ClKernel {
			get {
				if (cl_kernel_jfieldId == IntPtr.Zero)
					cl_kernel_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "cl_kernel", "I");
				return JNIEnv.GetStaticIntField (class_ref, cl_kernel_jfieldId);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jocl']/class[@name='Sizeof']/field[@name='cl_long']"
		[Register ("cl_long")]
		public const int ClLong = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jocl']/class[@name='Sizeof']/field[@name='cl_long16']"
		[Register ("cl_long16")]
		public const int ClLong16 = (int) 128;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jocl']/class[@name='Sizeof']/field[@name='cl_long2']"
		[Register ("cl_long2")]
		public const int ClLong2 = (int) 16;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jocl']/class[@name='Sizeof']/field[@name='cl_long4']"
		[Register ("cl_long4")]
		public const int ClLong4 = (int) 32;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jocl']/class[@name='Sizeof']/field[@name='cl_long8']"
		[Register ("cl_long8")]
		public const int ClLong8 = (int) 64;

		static IntPtr cl_mem_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jocl']/class[@name='Sizeof']/field[@name='cl_mem']"
		[Register ("cl_mem")]
		public static int ClMem {
			get {
				if (cl_mem_jfieldId == IntPtr.Zero)
					cl_mem_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "cl_mem", "I");
				return JNIEnv.GetStaticIntField (class_ref, cl_mem_jfieldId);
			}
		}

		static IntPtr cl_platform_id_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jocl']/class[@name='Sizeof']/field[@name='cl_platform_id']"
		[Register ("cl_platform_id")]
		public static int ClPlatformId {
			get {
				if (cl_platform_id_jfieldId == IntPtr.Zero)
					cl_platform_id_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "cl_platform_id", "I");
				return JNIEnv.GetStaticIntField (class_ref, cl_platform_id_jfieldId);
			}
		}

		static IntPtr cl_program_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jocl']/class[@name='Sizeof']/field[@name='cl_program']"
		[Register ("cl_program")]
		public static int ClProgram {
			get {
				if (cl_program_jfieldId == IntPtr.Zero)
					cl_program_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "cl_program", "I");
				return JNIEnv.GetStaticIntField (class_ref, cl_program_jfieldId);
			}
		}

		static IntPtr cl_sampler_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jocl']/class[@name='Sizeof']/field[@name='cl_sampler']"
		[Register ("cl_sampler")]
		public static int ClSampler {
			get {
				if (cl_sampler_jfieldId == IntPtr.Zero)
					cl_sampler_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "cl_sampler", "I");
				return JNIEnv.GetStaticIntField (class_ref, cl_sampler_jfieldId);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jocl']/class[@name='Sizeof']/field[@name='cl_short']"
		[Register ("cl_short")]
		public const int ClShort = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jocl']/class[@name='Sizeof']/field[@name='cl_short16']"
		[Register ("cl_short16")]
		public const int ClShort16 = (int) 32;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jocl']/class[@name='Sizeof']/field[@name='cl_short2']"
		[Register ("cl_short2")]
		public const int ClShort2 = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jocl']/class[@name='Sizeof']/field[@name='cl_short4']"
		[Register ("cl_short4")]
		public const int ClShort4 = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jocl']/class[@name='Sizeof']/field[@name='cl_short8']"
		[Register ("cl_short8")]
		public const int ClShort8 = (int) 16;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jocl']/class[@name='Sizeof']/field[@name='cl_uchar']"
		[Register ("cl_uchar")]
		public const int ClUchar = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jocl']/class[@name='Sizeof']/field[@name='cl_uchar16']"
		[Register ("cl_uchar16")]
		public const int ClUchar16 = (int) 16;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jocl']/class[@name='Sizeof']/field[@name='cl_uchar2']"
		[Register ("cl_uchar2")]
		public const int ClUchar2 = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jocl']/class[@name='Sizeof']/field[@name='cl_uchar4']"
		[Register ("cl_uchar4")]
		public const int ClUchar4 = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jocl']/class[@name='Sizeof']/field[@name='cl_uchar8']"
		[Register ("cl_uchar8")]
		public const int ClUchar8 = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jocl']/class[@name='Sizeof']/field[@name='cl_uint']"
		[Register ("cl_uint")]
		public const int ClUint = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jocl']/class[@name='Sizeof']/field[@name='cl_uint16']"
		[Register ("cl_uint16")]
		public const int ClUint16 = (int) 64;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jocl']/class[@name='Sizeof']/field[@name='cl_uint2']"
		[Register ("cl_uint2")]
		public const int ClUint2 = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jocl']/class[@name='Sizeof']/field[@name='cl_uint4']"
		[Register ("cl_uint4")]
		public const int ClUint4 = (int) 16;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jocl']/class[@name='Sizeof']/field[@name='cl_uint8']"
		[Register ("cl_uint8")]
		public const int ClUint8 = (int) 32;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jocl']/class[@name='Sizeof']/field[@name='cl_ulong']"
		[Register ("cl_ulong")]
		public const int ClUlong = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jocl']/class[@name='Sizeof']/field[@name='cl_ulong16']"
		[Register ("cl_ulong16")]
		public const int ClUlong16 = (int) 128;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jocl']/class[@name='Sizeof']/field[@name='cl_ulong2']"
		[Register ("cl_ulong2")]
		public const int ClUlong2 = (int) 16;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jocl']/class[@name='Sizeof']/field[@name='cl_ulong4']"
		[Register ("cl_ulong4")]
		public const int ClUlong4 = (int) 32;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jocl']/class[@name='Sizeof']/field[@name='cl_ulong8']"
		[Register ("cl_ulong8")]
		public const int ClUlong8 = (int) 64;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jocl']/class[@name='Sizeof']/field[@name='cl_ushort']"
		[Register ("cl_ushort")]
		public const int ClUshort = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jocl']/class[@name='Sizeof']/field[@name='cl_ushort16']"
		[Register ("cl_ushort16")]
		public const int ClUshort16 = (int) 32;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jocl']/class[@name='Sizeof']/field[@name='cl_ushort2']"
		[Register ("cl_ushort2")]
		public const int ClUshort2 = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jocl']/class[@name='Sizeof']/field[@name='cl_ushort4']"
		[Register ("cl_ushort4")]
		public const int ClUshort4 = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jocl']/class[@name='Sizeof']/field[@name='cl_ushort8']"
		[Register ("cl_ushort8")]
		public const int ClUshort8 = (int) 16;

		static IntPtr size_t_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jocl']/class[@name='Sizeof']/field[@name='size_t']"
		[Register ("size_t")]
		public static int SizeT {
			get {
				if (size_t_jfieldId == IntPtr.Zero)
					size_t_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "size_t", "I");
				return JNIEnv.GetStaticIntField (class_ref, size_t_jfieldId);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jocl/Sizeof", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Sizeof); }
		}

		internal Sizeof (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
