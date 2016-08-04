using System;
using System.Collections.Generic;
using Android.Runtime;

namespace BE.Abeel.Bioinformatics.Dnaproperties {

	// Metadata.xml XPath class reference: path="/api/package[@name='be.abeel.bioinformatics.dnaproperties']/class[@name='DNAProperty']"
	[global::Android.Runtime.Register ("be/abeel/bioinformatics/dnaproperties/DNAProperty", DoNotGenerateAcw=true)]
	public abstract partial class DNAProperty : global::Java.Lang.Object {


		static IntPtr A_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='be.abeel.bioinformatics.dnaproperties']/class[@name='DNAProperty']/field[@name='A']"
		[Register ("A")]
		public static global::BE.Abeel.Bioinformatics.Dnaproperties.DNAProperty A {
			get {
				if (A_jfieldId == IntPtr.Zero)
					A_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "A", "Lbe/abeel/bioinformatics/dnaproperties/DNAProperty;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, A_jfieldId);
				return global::Java.Lang.Object.GetObject<global::BE.Abeel.Bioinformatics.Dnaproperties.DNAProperty> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr APhilicity_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='be.abeel.bioinformatics.dnaproperties']/class[@name='DNAProperty']/field[@name='APhilicity']"
		[Register ("APhilicity")]
		public static global::BE.Abeel.Bioinformatics.Dnaproperties.DNAProperty APhilicity {
			get {
				if (APhilicity_jfieldId == IntPtr.Zero)
					APhilicity_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "APhilicity", "Lbe/abeel/bioinformatics/dnaproperties/DNAProperty;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, APhilicity_jfieldId);
				return global::Java.Lang.Object.GetObject<global::BE.Abeel.Bioinformatics.Dnaproperties.DNAProperty> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr AT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='be.abeel.bioinformatics.dnaproperties']/class[@name='DNAProperty']/field[@name='AT']"
		[Register ("AT")]
		public static global::BE.Abeel.Bioinformatics.Dnaproperties.DNAProperty At {
			get {
				if (AT_jfieldId == IntPtr.Zero)
					AT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AT", "Lbe/abeel/bioinformatics/dnaproperties/DNAProperty;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::BE.Abeel.Bioinformatics.Dnaproperties.DNAProperty> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ATG_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='be.abeel.bioinformatics.dnaproperties']/class[@name='DNAProperty']/field[@name='ATG']"
		[Register ("ATG")]
		public static global::BE.Abeel.Bioinformatics.Dnaproperties.DNAProperty Atg {
			get {
				if (ATG_jfieldId == IntPtr.Zero)
					ATG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ATG", "Lbe/abeel/bioinformatics/dnaproperties/DNAProperty;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ATG_jfieldId);
				return global::Java.Lang.Object.GetObject<global::BE.Abeel.Bioinformatics.Dnaproperties.DNAProperty> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr BaseStacking_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='be.abeel.bioinformatics.dnaproperties']/class[@name='DNAProperty']/field[@name='BaseStacking']"
		[Register ("BaseStacking")]
		public static global::BE.Abeel.Bioinformatics.Dnaproperties.DNAProperty BaseStacking {
			get {
				if (BaseStacking_jfieldId == IntPtr.Zero)
					BaseStacking_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BaseStacking", "Lbe/abeel/bioinformatics/dnaproperties/DNAProperty;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BaseStacking_jfieldId);
				return global::Java.Lang.Object.GetObject<global::BE.Abeel.Bioinformatics.Dnaproperties.DNAProperty> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr Bendability_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='be.abeel.bioinformatics.dnaproperties']/class[@name='DNAProperty']/field[@name='Bendability']"
		[Register ("Bendability")]
		public static global::BE.Abeel.Bioinformatics.Dnaproperties.DNAProperty Bendability {
			get {
				if (Bendability_jfieldId == IntPtr.Zero)
					Bendability_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Bendability", "Lbe/abeel/bioinformatics/dnaproperties/DNAProperty;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Bendability_jfieldId);
				return global::Java.Lang.Object.GetObject<global::BE.Abeel.Bioinformatics.Dnaproperties.DNAProperty> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr BendingStiffness_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='be.abeel.bioinformatics.dnaproperties']/class[@name='DNAProperty']/field[@name='BendingStiffness']"
		[Register ("BendingStiffness")]
		public static global::BE.Abeel.Bioinformatics.Dnaproperties.DNAProperty BendingStiffness {
			get {
				if (BendingStiffness_jfieldId == IntPtr.Zero)
					BendingStiffness_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BendingStiffness", "Lbe/abeel/bioinformatics/dnaproperties/DNAProperty;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BendingStiffness_jfieldId);
				return global::Java.Lang.Object.GetObject<global::BE.Abeel.Bioinformatics.Dnaproperties.DNAProperty> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr C_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='be.abeel.bioinformatics.dnaproperties']/class[@name='DNAProperty']/field[@name='C']"
		[Register ("C")]
		public static global::BE.Abeel.Bioinformatics.Dnaproperties.DNAProperty C {
			get {
				if (C_jfieldId == IntPtr.Zero)
					C_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "C", "Lbe/abeel/bioinformatics/dnaproperties/DNAProperty;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, C_jfieldId);
				return global::Java.Lang.Object.GetObject<global::BE.Abeel.Bioinformatics.Dnaproperties.DNAProperty> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr DNADenaturation_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='be.abeel.bioinformatics.dnaproperties']/class[@name='DNAProperty']/field[@name='DNADenaturation']"
		[Register ("DNADenaturation")]
		public static global::BE.Abeel.Bioinformatics.Dnaproperties.DNAProperty DNADenaturation {
			get {
				if (DNADenaturation_jfieldId == IntPtr.Zero)
					DNADenaturation_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DNADenaturation", "Lbe/abeel/bioinformatics/dnaproperties/DNAProperty;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DNADenaturation_jfieldId);
				return global::Java.Lang.Object.GetObject<global::BE.Abeel.Bioinformatics.Dnaproperties.DNAProperty> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr DimerRadicalCleavageIntensity_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='be.abeel.bioinformatics.dnaproperties']/class[@name='DNAProperty']/field[@name='DimerRadicalCleavageIntensity']"
		[Register ("DimerRadicalCleavageIntensity")]
		public static global::BE.Abeel.Bioinformatics.Dnaproperties.DNAProperty DimerRadicalCleavageIntensity {
			get {
				if (DimerRadicalCleavageIntensity_jfieldId == IntPtr.Zero)
					DimerRadicalCleavageIntensity_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DimerRadicalCleavageIntensity", "Lbe/abeel/bioinformatics/dnaproperties/DNAProperty;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DimerRadicalCleavageIntensity_jfieldId);
				return global::Java.Lang.Object.GetObject<global::BE.Abeel.Bioinformatics.Dnaproperties.DNAProperty> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr DuplexStabilityDisruptEnergy_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='be.abeel.bioinformatics.dnaproperties']/class[@name='DNAProperty']/field[@name='DuplexStabilityDisruptEnergy']"
		[Register ("DuplexStabilityDisruptEnergy")]
		public static global::BE.Abeel.Bioinformatics.Dnaproperties.DNAProperty DuplexStabilityDisruptEnergy {
			get {
				if (DuplexStabilityDisruptEnergy_jfieldId == IntPtr.Zero)
					DuplexStabilityDisruptEnergy_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DuplexStabilityDisruptEnergy", "Lbe/abeel/bioinformatics/dnaproperties/DNAProperty;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DuplexStabilityDisruptEnergy_jfieldId);
				return global::Java.Lang.Object.GetObject<global::BE.Abeel.Bioinformatics.Dnaproperties.DNAProperty> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr DuplexStabilityFreeEnergy_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='be.abeel.bioinformatics.dnaproperties']/class[@name='DNAProperty']/field[@name='DuplexStabilityFreeEnergy']"
		[Register ("DuplexStabilityFreeEnergy")]
		public static global::BE.Abeel.Bioinformatics.Dnaproperties.DNAProperty DuplexStabilityFreeEnergy {
			get {
				if (DuplexStabilityFreeEnergy_jfieldId == IntPtr.Zero)
					DuplexStabilityFreeEnergy_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DuplexStabilityFreeEnergy", "Lbe/abeel/bioinformatics/dnaproperties/DNAProperty;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DuplexStabilityFreeEnergy_jfieldId);
				return global::Java.Lang.Object.GetObject<global::BE.Abeel.Bioinformatics.Dnaproperties.DNAProperty> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr G_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='be.abeel.bioinformatics.dnaproperties']/class[@name='DNAProperty']/field[@name='G']"
		[Register ("G")]
		public static global::BE.Abeel.Bioinformatics.Dnaproperties.DNAProperty G {
			get {
				if (G_jfieldId == IntPtr.Zero)
					G_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "G", "Lbe/abeel/bioinformatics/dnaproperties/DNAProperty;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, G_jfieldId);
				return global::Java.Lang.Object.GetObject<global::BE.Abeel.Bioinformatics.Dnaproperties.DNAProperty> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr GC_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='be.abeel.bioinformatics.dnaproperties']/class[@name='DNAProperty']/field[@name='GC']"
		[Register ("GC")]
		public static global::BE.Abeel.Bioinformatics.Dnaproperties.DNAProperty Gc {
			get {
				if (GC_jfieldId == IntPtr.Zero)
					GC_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GC", "Lbe/abeel/bioinformatics/dnaproperties/DNAProperty;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, GC_jfieldId);
				return global::Java.Lang.Object.GetObject<global::BE.Abeel.Bioinformatics.Dnaproperties.DNAProperty> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr NucleosomePosition_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='be.abeel.bioinformatics.dnaproperties']/class[@name='DNAProperty']/field[@name='NucleosomePosition']"
		[Register ("NucleosomePosition")]
		public static global::BE.Abeel.Bioinformatics.Dnaproperties.DNAProperty NucleosomePosition {
			get {
				if (NucleosomePosition_jfieldId == IntPtr.Zero)
					NucleosomePosition_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NucleosomePosition", "Lbe/abeel/bioinformatics/dnaproperties/DNAProperty;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NucleosomePosition_jfieldId);
				return global::Java.Lang.Object.GetObject<global::BE.Abeel.Bioinformatics.Dnaproperties.DNAProperty> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr PentamerRadicalCleavageIntensity_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='be.abeel.bioinformatics.dnaproperties']/class[@name='DNAProperty']/field[@name='PentamerRadicalCleavageIntensity']"
		[Register ("PentamerRadicalCleavageIntensity")]
		public static global::BE.Abeel.Bioinformatics.Dnaproperties.DNAProperty PentamerRadicalCleavageIntensity {
			get {
				if (PentamerRadicalCleavageIntensity_jfieldId == IntPtr.Zero)
					PentamerRadicalCleavageIntensity_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PentamerRadicalCleavageIntensity", "Lbe/abeel/bioinformatics/dnaproperties/DNAProperty;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PentamerRadicalCleavageIntensity_jfieldId);
				return global::Java.Lang.Object.GetObject<global::BE.Abeel.Bioinformatics.Dnaproperties.DNAProperty> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr PropellorTwist_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='be.abeel.bioinformatics.dnaproperties']/class[@name='DNAProperty']/field[@name='PropellorTwist']"
		[Register ("PropellorTwist")]
		public static global::BE.Abeel.Bioinformatics.Dnaproperties.DNAProperty PropellorTwist {
			get {
				if (PropellorTwist_jfieldId == IntPtr.Zero)
					PropellorTwist_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PropellorTwist", "Lbe/abeel/bioinformatics/dnaproperties/DNAProperty;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PropellorTwist_jfieldId);
				return global::Java.Lang.Object.GetObject<global::BE.Abeel.Bioinformatics.Dnaproperties.DNAProperty> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ProteinDNATwist_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='be.abeel.bioinformatics.dnaproperties']/class[@name='DNAProperty']/field[@name='ProteinDNATwist']"
		[Register ("ProteinDNATwist")]
		public static global::BE.Abeel.Bioinformatics.Dnaproperties.DNAProperty ProteinDNATwist {
			get {
				if (ProteinDNATwist_jfieldId == IntPtr.Zero)
					ProteinDNATwist_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ProteinDNATwist", "Lbe/abeel/bioinformatics/dnaproperties/DNAProperty;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ProteinDNATwist_jfieldId);
				return global::Java.Lang.Object.GetObject<global::BE.Abeel.Bioinformatics.Dnaproperties.DNAProperty> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ProteinDeformation_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='be.abeel.bioinformatics.dnaproperties']/class[@name='DNAProperty']/field[@name='ProteinDeformation']"
		[Register ("ProteinDeformation")]
		public static global::BE.Abeel.Bioinformatics.Dnaproperties.DNAProperty ProteinDeformation {
			get {
				if (ProteinDeformation_jfieldId == IntPtr.Zero)
					ProteinDeformation_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ProteinDeformation", "Lbe/abeel/bioinformatics/dnaproperties/DNAProperty;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ProteinDeformation_jfieldId);
				return global::Java.Lang.Object.GetObject<global::BE.Abeel.Bioinformatics.Dnaproperties.DNAProperty> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr Purine_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='be.abeel.bioinformatics.dnaproperties']/class[@name='DNAProperty']/field[@name='Purine']"
		[Register ("Purine")]
		public static global::BE.Abeel.Bioinformatics.Dnaproperties.DNAProperty Purine {
			get {
				if (Purine_jfieldId == IntPtr.Zero)
					Purine_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Purine", "Lbe/abeel/bioinformatics/dnaproperties/DNAProperty;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Purine_jfieldId);
				return global::Java.Lang.Object.GetObject<global::BE.Abeel.Bioinformatics.Dnaproperties.DNAProperty> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr Pyrimidine_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='be.abeel.bioinformatics.dnaproperties']/class[@name='DNAProperty']/field[@name='Pyrimidine']"
		[Register ("Pyrimidine")]
		public static global::BE.Abeel.Bioinformatics.Dnaproperties.DNAProperty Pyrimidine {
			get {
				if (Pyrimidine_jfieldId == IntPtr.Zero)
					Pyrimidine_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Pyrimidine", "Lbe/abeel/bioinformatics/dnaproperties/DNAProperty;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Pyrimidine_jfieldId);
				return global::Java.Lang.Object.GetObject<global::BE.Abeel.Bioinformatics.Dnaproperties.DNAProperty> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr Rise_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='be.abeel.bioinformatics.dnaproperties']/class[@name='DNAProperty']/field[@name='Rise']"
		[Register ("Rise")]
		public static global::BE.Abeel.Bioinformatics.Dnaproperties.DNAProperty Rise {
			get {
				if (Rise_jfieldId == IntPtr.Zero)
					Rise_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Rise", "Lbe/abeel/bioinformatics/dnaproperties/DNAProperty;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Rise_jfieldId);
				return global::Java.Lang.Object.GetObject<global::BE.Abeel.Bioinformatics.Dnaproperties.DNAProperty> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr Roll_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='be.abeel.bioinformatics.dnaproperties']/class[@name='DNAProperty']/field[@name='Roll']"
		[Register ("Roll")]
		public static global::BE.Abeel.Bioinformatics.Dnaproperties.DNAProperty Roll {
			get {
				if (Roll_jfieldId == IntPtr.Zero)
					Roll_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Roll", "Lbe/abeel/bioinformatics/dnaproperties/DNAProperty;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Roll_jfieldId);
				return global::Java.Lang.Object.GetObject<global::BE.Abeel.Bioinformatics.Dnaproperties.DNAProperty> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr Shift_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='be.abeel.bioinformatics.dnaproperties']/class[@name='DNAProperty']/field[@name='Shift']"
		[Register ("Shift")]
		public static global::BE.Abeel.Bioinformatics.Dnaproperties.DNAProperty Shift {
			get {
				if (Shift_jfieldId == IntPtr.Zero)
					Shift_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Shift", "Lbe/abeel/bioinformatics/dnaproperties/DNAProperty;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Shift_jfieldId);
				return global::Java.Lang.Object.GetObject<global::BE.Abeel.Bioinformatics.Dnaproperties.DNAProperty> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr Slide_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='be.abeel.bioinformatics.dnaproperties']/class[@name='DNAProperty']/field[@name='Slide']"
		[Register ("Slide")]
		public static global::BE.Abeel.Bioinformatics.Dnaproperties.DNAProperty Slide {
			get {
				if (Slide_jfieldId == IntPtr.Zero)
					Slide_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Slide", "Lbe/abeel/bioinformatics/dnaproperties/DNAProperty;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Slide_jfieldId);
				return global::Java.Lang.Object.GetObject<global::BE.Abeel.Bioinformatics.Dnaproperties.DNAProperty> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr T_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='be.abeel.bioinformatics.dnaproperties']/class[@name='DNAProperty']/field[@name='T']"
		[Register ("T")]
		public static global::BE.Abeel.Bioinformatics.Dnaproperties.DNAProperty T {
			get {
				if (T_jfieldId == IntPtr.Zero)
					T_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "T", "Lbe/abeel/bioinformatics/dnaproperties/DNAProperty;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, T_jfieldId);
				return global::Java.Lang.Object.GetObject<global::BE.Abeel.Bioinformatics.Dnaproperties.DNAProperty> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TetramerRadicalCleavageIntensity_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='be.abeel.bioinformatics.dnaproperties']/class[@name='DNAProperty']/field[@name='TetramerRadicalCleavageIntensity']"
		[Register ("TetramerRadicalCleavageIntensity")]
		public static global::BE.Abeel.Bioinformatics.Dnaproperties.DNAProperty TetramerRadicalCleavageIntensity {
			get {
				if (TetramerRadicalCleavageIntensity_jfieldId == IntPtr.Zero)
					TetramerRadicalCleavageIntensity_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TetramerRadicalCleavageIntensity", "Lbe/abeel/bioinformatics/dnaproperties/DNAProperty;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TetramerRadicalCleavageIntensity_jfieldId);
				return global::Java.Lang.Object.GetObject<global::BE.Abeel.Bioinformatics.Dnaproperties.DNAProperty> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr Tilt_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='be.abeel.bioinformatics.dnaproperties']/class[@name='DNAProperty']/field[@name='Tilt']"
		[Register ("Tilt")]
		public static global::BE.Abeel.Bioinformatics.Dnaproperties.DNAProperty Tilt {
			get {
				if (Tilt_jfieldId == IntPtr.Zero)
					Tilt_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Tilt", "Lbe/abeel/bioinformatics/dnaproperties/DNAProperty;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Tilt_jfieldId);
				return global::Java.Lang.Object.GetObject<global::BE.Abeel.Bioinformatics.Dnaproperties.DNAProperty> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TrimerRadicalCleavageIntensity_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='be.abeel.bioinformatics.dnaproperties']/class[@name='DNAProperty']/field[@name='TrimerRadicalCleavageIntensity']"
		[Register ("TrimerRadicalCleavageIntensity")]
		public static global::BE.Abeel.Bioinformatics.Dnaproperties.DNAProperty TrimerRadicalCleavageIntensity {
			get {
				if (TrimerRadicalCleavageIntensity_jfieldId == IntPtr.Zero)
					TrimerRadicalCleavageIntensity_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TrimerRadicalCleavageIntensity", "Lbe/abeel/bioinformatics/dnaproperties/DNAProperty;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TrimerRadicalCleavageIntensity_jfieldId);
				return global::Java.Lang.Object.GetObject<global::BE.Abeel.Bioinformatics.Dnaproperties.DNAProperty> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr Twist_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='be.abeel.bioinformatics.dnaproperties']/class[@name='DNAProperty']/field[@name='Twist']"
		[Register ("Twist")]
		public static global::BE.Abeel.Bioinformatics.Dnaproperties.DNAProperty Twist {
			get {
				if (Twist_jfieldId == IntPtr.Zero)
					Twist_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Twist", "Lbe/abeel/bioinformatics/dnaproperties/DNAProperty;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Twist_jfieldId);
				return global::Java.Lang.Object.GetObject<global::BE.Abeel.Bioinformatics.Dnaproperties.DNAProperty> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr bDNATwist_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='be.abeel.bioinformatics.dnaproperties']/class[@name='DNAProperty']/field[@name='bDNATwist']"
		[Register ("bDNATwist")]
		public static global::BE.Abeel.Bioinformatics.Dnaproperties.DNAProperty BDNATwist {
			get {
				if (bDNATwist_jfieldId == IntPtr.Zero)
					bDNATwist_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "bDNATwist", "Lbe/abeel/bioinformatics/dnaproperties/DNAProperty;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, bDNATwist_jfieldId);
				return global::Java.Lang.Object.GetObject<global::BE.Abeel.Bioinformatics.Dnaproperties.DNAProperty> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr zDNA_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='be.abeel.bioinformatics.dnaproperties']/class[@name='DNAProperty']/field[@name='zDNA']"
		[Register ("zDNA")]
		public static global::BE.Abeel.Bioinformatics.Dnaproperties.DNAProperty ZDNA {
			get {
				if (zDNA_jfieldId == IntPtr.Zero)
					zDNA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "zDNA", "Lbe/abeel/bioinformatics/dnaproperties/DNAProperty;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, zDNA_jfieldId);
				return global::Java.Lang.Object.GetObject<global::BE.Abeel.Bioinformatics.Dnaproperties.DNAProperty> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("be/abeel/bioinformatics/dnaproperties/DNAProperty", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DNAProperty); }
		}

		protected DNAProperty (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='be.abeel.bioinformatics.dnaproperties']/class[@name='DNAProperty']/constructor[@name='DNAProperty' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		protected unsafe DNAProperty (string p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (DNAProperty)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_create_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.bioinformatics.dnaproperties']/class[@name='DNAProperty']/method[@name='create' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("create", "(Ljava/lang/String;)Lbe/abeel/bioinformatics/dnaproperties/DNAProperty;", "")]
		public static unsafe global::BE.Abeel.Bioinformatics.Dnaproperties.DNAProperty Create (string p0)
		{
			if (id_create_Ljava_lang_String_ == IntPtr.Zero)
				id_create_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "create", "(Ljava/lang/String;)Lbe/abeel/bioinformatics/dnaproperties/DNAProperty;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::BE.Abeel.Bioinformatics.Dnaproperties.DNAProperty __ret = global::Java.Lang.Object.GetObject<global::BE.Abeel.Bioinformatics.Dnaproperties.DNAProperty> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_length;
#pragma warning disable 0169
		static Delegate GetLengthHandler ()
		{
			if (cb_length == null)
				cb_length = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Length);
			return cb_length;
		}

		static int n_Length (IntPtr jnienv, IntPtr native__this)
		{
			global::BE.Abeel.Bioinformatics.Dnaproperties.DNAProperty __this = global::Java.Lang.Object.GetObject<global::BE.Abeel.Bioinformatics.Dnaproperties.DNAProperty> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Length ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.bioinformatics.dnaproperties']/class[@name='DNAProperty']/method[@name='length' and count(parameter)=0]"
		[Register ("length", "()I", "GetLengthHandler")]
		public abstract int Length ();

		static Delegate cb_normalizedProfile_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetNormalizedProfile_Ljava_lang_String_Handler ()
		{
			if (cb_normalizedProfile_Ljava_lang_String_ == null)
				cb_normalizedProfile_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_NormalizedProfile_Ljava_lang_String_);
			return cb_normalizedProfile_Ljava_lang_String_;
		}

		static IntPtr n_NormalizedProfile_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BE.Abeel.Bioinformatics.Dnaproperties.DNAProperty __this = global::Java.Lang.Object.GetObject<global::BE.Abeel.Bioinformatics.Dnaproperties.DNAProperty> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.NormalizedProfile (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.bioinformatics.dnaproperties']/class[@name='DNAProperty']/method[@name='normalizedProfile' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("normalizedProfile", "(Ljava/lang/String;)[D", "GetNormalizedProfile_Ljava_lang_String_Handler")]
		public abstract double[] NormalizedProfile (string p0);

		static Delegate cb_normalizedValue_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetNormalizedValue_Ljava_lang_String_Handler ()
		{
			if (cb_normalizedValue_Ljava_lang_String_ == null)
				cb_normalizedValue_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, double>) n_NormalizedValue_Ljava_lang_String_);
			return cb_normalizedValue_Ljava_lang_String_;
		}

		static double n_NormalizedValue_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BE.Abeel.Bioinformatics.Dnaproperties.DNAProperty __this = global::Java.Lang.Object.GetObject<global::BE.Abeel.Bioinformatics.Dnaproperties.DNAProperty> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			double __ret = __this.NormalizedValue (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.bioinformatics.dnaproperties']/class[@name='DNAProperty']/method[@name='normalizedValue' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("normalizedValue", "(Ljava/lang/String;)D", "GetNormalizedValue_Ljava_lang_String_Handler")]
		public abstract double NormalizedValue (string p0);

		static Delegate cb_profile_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetProfile_Ljava_lang_String_Handler ()
		{
			if (cb_profile_Ljava_lang_String_ == null)
				cb_profile_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Profile_Ljava_lang_String_);
			return cb_profile_Ljava_lang_String_;
		}

		static IntPtr n_Profile_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BE.Abeel.Bioinformatics.Dnaproperties.DNAProperty __this = global::Java.Lang.Object.GetObject<global::BE.Abeel.Bioinformatics.Dnaproperties.DNAProperty> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.Profile (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.bioinformatics.dnaproperties']/class[@name='DNAProperty']/method[@name='profile' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("profile", "(Ljava/lang/String;)[D", "GetProfile_Ljava_lang_String_Handler")]
		public abstract double[] Profile (string p0);

		static Delegate cb_value_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetValue_Ljava_lang_String_Handler ()
		{
			if (cb_value_Ljava_lang_String_ == null)
				cb_value_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, double>) n_Value_Ljava_lang_String_);
			return cb_value_Ljava_lang_String_;
		}

		static double n_Value_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BE.Abeel.Bioinformatics.Dnaproperties.DNAProperty __this = global::Java.Lang.Object.GetObject<global::BE.Abeel.Bioinformatics.Dnaproperties.DNAProperty> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			double __ret = __this.Value (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.bioinformatics.dnaproperties']/class[@name='DNAProperty']/method[@name='value' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("value", "(Ljava/lang/String;)D", "GetValue_Ljava_lang_String_Handler")]
		public abstract double Value (string p0);

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.bioinformatics.dnaproperties']/class[@name='DNAProperty']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lbe/abeel/bioinformatics/dnaproperties/DNAProperty;", "")]
		public static unsafe global::BE.Abeel.Bioinformatics.Dnaproperties.DNAProperty[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lbe/abeel/bioinformatics/dnaproperties/DNAProperty;");
			try {
				return (global::BE.Abeel.Bioinformatics.Dnaproperties.DNAProperty[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::BE.Abeel.Bioinformatics.Dnaproperties.DNAProperty));
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("be/abeel/bioinformatics/dnaproperties/DNAProperty", DoNotGenerateAcw=true)]
	internal partial class DNAPropertyInvoker : DNAProperty {

		public DNAPropertyInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (DNAPropertyInvoker); }
		}

		static IntPtr id_length;
		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.bioinformatics.dnaproperties']/class[@name='DNAProperty']/method[@name='length' and count(parameter)=0]"
		[Register ("length", "()I", "GetLengthHandler")]
		public override unsafe int Length ()
		{
			if (id_length == IntPtr.Zero)
				id_length = JNIEnv.GetMethodID (class_ref, "length", "()I");
			try {
				return JNIEnv.CallIntMethod  (Handle, id_length);
			} finally {
			}
		}

		static IntPtr id_normalizedProfile_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.bioinformatics.dnaproperties']/class[@name='DNAProperty']/method[@name='normalizedProfile' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("normalizedProfile", "(Ljava/lang/String;)[D", "GetNormalizedProfile_Ljava_lang_String_Handler")]
		public override unsafe double[] NormalizedProfile (string p0)
		{
			if (id_normalizedProfile_Ljava_lang_String_ == IntPtr.Zero)
				id_normalizedProfile_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "normalizedProfile", "(Ljava/lang/String;)[D");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				double[] __ret = (double[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_normalizedProfile_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (double));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_normalizedValue_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.bioinformatics.dnaproperties']/class[@name='DNAProperty']/method[@name='normalizedValue' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("normalizedValue", "(Ljava/lang/String;)D", "GetNormalizedValue_Ljava_lang_String_Handler")]
		public override unsafe double NormalizedValue (string p0)
		{
			if (id_normalizedValue_Ljava_lang_String_ == IntPtr.Zero)
				id_normalizedValue_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "normalizedValue", "(Ljava/lang/String;)D");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				double __ret = JNIEnv.CallDoubleMethod  (Handle, id_normalizedValue_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_profile_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.bioinformatics.dnaproperties']/class[@name='DNAProperty']/method[@name='profile' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("profile", "(Ljava/lang/String;)[D", "GetProfile_Ljava_lang_String_Handler")]
		public override unsafe double[] Profile (string p0)
		{
			if (id_profile_Ljava_lang_String_ == IntPtr.Zero)
				id_profile_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "profile", "(Ljava/lang/String;)[D");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				double[] __ret = (double[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_profile_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (double));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_value_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='be.abeel.bioinformatics.dnaproperties']/class[@name='DNAProperty']/method[@name='value' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("value", "(Ljava/lang/String;)D", "GetValue_Ljava_lang_String_Handler")]
		public override unsafe double Value (string p0)
		{
			if (id_value_Ljava_lang_String_ == IntPtr.Zero)
				id_value_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "value", "(Ljava/lang/String;)D");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				double __ret = JNIEnv.CallDoubleMethod  (Handle, id_value_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}

}
