using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Coinbase.Api.Entity {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Report']"
	[global::Android.Runtime.Register ("com/coinbase/api/entity/Report", DoNotGenerateAcw=true)]
	public partial class Report : global::Java.Lang.Object, global::Java.IO.ISerializable {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Report.Repeat']"
		[global::Android.Runtime.Register ("com/coinbase/api/entity/Report$Repeat", DoNotGenerateAcw=true)]
		public sealed partial class Repeat : global::Java.Lang.Enum {


			static IntPtr BIWEEKLY_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Report.Repeat']/field[@name='BIWEEKLY']"
			[Register ("BIWEEKLY")]
			public static global::Com.Coinbase.Api.Entity.Report.Repeat Biweekly {
				get {
					if (BIWEEKLY_jfieldId == IntPtr.Zero)
						BIWEEKLY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BIWEEKLY", "Lcom/coinbase/api/entity/Report$Repeat;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BIWEEKLY_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Report.Repeat> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr DAILY_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Report.Repeat']/field[@name='DAILY']"
			[Register ("DAILY")]
			public static global::Com.Coinbase.Api.Entity.Report.Repeat Daily {
				get {
					if (DAILY_jfieldId == IntPtr.Zero)
						DAILY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DAILY", "Lcom/coinbase/api/entity/Report$Repeat;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DAILY_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Report.Repeat> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr MONTHLY_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Report.Repeat']/field[@name='MONTHLY']"
			[Register ("MONTHLY")]
			public static global::Com.Coinbase.Api.Entity.Report.Repeat Monthly {
				get {
					if (MONTHLY_jfieldId == IntPtr.Zero)
						MONTHLY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MONTHLY", "Lcom/coinbase/api/entity/Report$Repeat;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MONTHLY_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Report.Repeat> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr NEVER_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Report.Repeat']/field[@name='NEVER']"
			[Register ("NEVER")]
			public static global::Com.Coinbase.Api.Entity.Report.Repeat Never {
				get {
					if (NEVER_jfieldId == IntPtr.Zero)
						NEVER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NEVER", "Lcom/coinbase/api/entity/Report$Repeat;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NEVER_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Report.Repeat> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr QUARTERLY_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Report.Repeat']/field[@name='QUARTERLY']"
			[Register ("QUARTERLY")]
			public static global::Com.Coinbase.Api.Entity.Report.Repeat Quarterly {
				get {
					if (QUARTERLY_jfieldId == IntPtr.Zero)
						QUARTERLY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "QUARTERLY", "Lcom/coinbase/api/entity/Report$Repeat;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, QUARTERLY_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Report.Repeat> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr WEEKLY_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Report.Repeat']/field[@name='WEEKLY']"
			[Register ("WEEKLY")]
			public static global::Com.Coinbase.Api.Entity.Report.Repeat Weekly {
				get {
					if (WEEKLY_jfieldId == IntPtr.Zero)
						WEEKLY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "WEEKLY", "Lcom/coinbase/api/entity/Report$Repeat;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, WEEKLY_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Report.Repeat> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr YEARLY_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Report.Repeat']/field[@name='YEARLY']"
			[Register ("YEARLY")]
			public static global::Com.Coinbase.Api.Entity.Report.Repeat Yearly {
				get {
					if (YEARLY_jfieldId == IntPtr.Zero)
						YEARLY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "YEARLY", "Lcom/coinbase/api/entity/Report$Repeat;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, YEARLY_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Report.Repeat> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/coinbase/api/entity/Report$Repeat", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Repeat); }
			}

			internal Repeat (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_create_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Report.Repeat']/method[@name='create' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("create", "(Ljava/lang/String;)Lcom/coinbase/api/entity/Report$Repeat;", "")]
			public static unsafe global::Com.Coinbase.Api.Entity.Report.Repeat Create (string p0)
			{
				if (id_create_Ljava_lang_String_ == IntPtr.Zero)
					id_create_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "create", "(Ljava/lang/String;)Lcom/coinbase/api/entity/Report$Repeat;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Coinbase.Api.Entity.Report.Repeat __ret = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Report.Repeat> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Report.Repeat']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/coinbase/api/entity/Report$Repeat;", "")]
			public static unsafe global::Com.Coinbase.Api.Entity.Report.Repeat ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/coinbase/api/entity/Report$Repeat;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Coinbase.Api.Entity.Report.Repeat __ret = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Report.Repeat> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Report.Repeat']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/coinbase/api/entity/Report$Repeat;", "")]
			public static unsafe global::Com.Coinbase.Api.Entity.Report.Repeat[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/coinbase/api/entity/Report$Repeat;");
				try {
					return (global::Com.Coinbase.Api.Entity.Report.Repeat[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Coinbase.Api.Entity.Report.Repeat));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Report.StartType']"
		[global::Android.Runtime.Register ("com/coinbase/api/entity/Report$StartType", DoNotGenerateAcw=true)]
		public sealed partial class StartType : global::Java.Lang.Enum {


			static IntPtr NOW_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Report.StartType']/field[@name='NOW']"
			[Register ("NOW")]
			public static global::Com.Coinbase.Api.Entity.Report.StartType Now {
				get {
					if (NOW_jfieldId == IntPtr.Zero)
						NOW_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NOW", "Lcom/coinbase/api/entity/Report$StartType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NOW_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Report.StartType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr ON_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Report.StartType']/field[@name='ON']"
			[Register ("ON")]
			public static global::Com.Coinbase.Api.Entity.Report.StartType On {
				get {
					if (ON_jfieldId == IntPtr.Zero)
						ON_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ON", "Lcom/coinbase/api/entity/Report$StartType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ON_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Report.StartType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/coinbase/api/entity/Report$StartType", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (StartType); }
			}

			internal StartType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_create_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Report.StartType']/method[@name='create' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("create", "(Ljava/lang/String;)Lcom/coinbase/api/entity/Report$StartType;", "")]
			public static unsafe global::Com.Coinbase.Api.Entity.Report.StartType Create (string p0)
			{
				if (id_create_Ljava_lang_String_ == IntPtr.Zero)
					id_create_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "create", "(Ljava/lang/String;)Lcom/coinbase/api/entity/Report$StartType;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Coinbase.Api.Entity.Report.StartType __ret = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Report.StartType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Report.StartType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/coinbase/api/entity/Report$StartType;", "")]
			public static unsafe global::Com.Coinbase.Api.Entity.Report.StartType ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/coinbase/api/entity/Report$StartType;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Coinbase.Api.Entity.Report.StartType __ret = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Report.StartType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Report.StartType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/coinbase/api/entity/Report$StartType;", "")]
			public static unsafe global::Com.Coinbase.Api.Entity.Report.StartType[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/coinbase/api/entity/Report$StartType;");
				try {
					return (global::Com.Coinbase.Api.Entity.Report.StartType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Coinbase.Api.Entity.Report.StartType));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Report.Status']"
		[global::Android.Runtime.Register ("com/coinbase/api/entity/Report$Status", DoNotGenerateAcw=true)]
		public sealed partial class Status : global::Java.Lang.Enum {


			static IntPtr ACTIVE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Report.Status']/field[@name='ACTIVE']"
			[Register ("ACTIVE")]
			public static global::Com.Coinbase.Api.Entity.Report.Status Active {
				get {
					if (ACTIVE_jfieldId == IntPtr.Zero)
						ACTIVE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ACTIVE", "Lcom/coinbase/api/entity/Report$Status;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ACTIVE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Report.Status> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr COMPLETED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Report.Status']/field[@name='COMPLETED']"
			[Register ("COMPLETED")]
			public static global::Com.Coinbase.Api.Entity.Report.Status Completed {
				get {
					if (COMPLETED_jfieldId == IntPtr.Zero)
						COMPLETED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "COMPLETED", "Lcom/coinbase/api/entity/Report$Status;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, COMPLETED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Report.Status> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/coinbase/api/entity/Report$Status", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Status); }
			}

			internal Status (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_create_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Report.Status']/method[@name='create' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("create", "(Ljava/lang/String;)Lcom/coinbase/api/entity/Report$Status;", "")]
			public static unsafe global::Com.Coinbase.Api.Entity.Report.Status Create (string p0)
			{
				if (id_create_Ljava_lang_String_ == IntPtr.Zero)
					id_create_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "create", "(Ljava/lang/String;)Lcom/coinbase/api/entity/Report$Status;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Coinbase.Api.Entity.Report.Status __ret = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Report.Status> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Report.Status']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/coinbase/api/entity/Report$Status;", "")]
			public static unsafe global::Com.Coinbase.Api.Entity.Report.Status ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/coinbase/api/entity/Report$Status;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Coinbase.Api.Entity.Report.Status __ret = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Report.Status> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Report.Status']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/coinbase/api/entity/Report$Status;", "")]
			public static unsafe global::Com.Coinbase.Api.Entity.Report.Status[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/coinbase/api/entity/Report$Status;");
				try {
					return (global::Com.Coinbase.Api.Entity.Report.Status[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Coinbase.Api.Entity.Report.Status));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Report.TimeRange']"
		[global::Android.Runtime.Register ("com/coinbase/api/entity/Report$TimeRange", DoNotGenerateAcw=true)]
		public sealed partial class TimeRange : global::Java.Lang.Enum {


			static IntPtr ALL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Report.TimeRange']/field[@name='ALL']"
			[Register ("ALL")]
			public static global::Com.Coinbase.Api.Entity.Report.TimeRange All {
				get {
					if (ALL_jfieldId == IntPtr.Zero)
						ALL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ALL", "Lcom/coinbase/api/entity/Report$TimeRange;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ALL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Report.TimeRange> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr CUSTOM_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Report.TimeRange']/field[@name='CUSTOM']"
			[Register ("CUSTOM")]
			public static global::Com.Coinbase.Api.Entity.Report.TimeRange Custom {
				get {
					if (CUSTOM_jfieldId == IntPtr.Zero)
						CUSTOM_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CUSTOM", "Lcom/coinbase/api/entity/Report$TimeRange;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CUSTOM_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Report.TimeRange> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr LAST_FULL_MONTH_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Report.TimeRange']/field[@name='LAST_FULL_MONTH']"
			[Register ("LAST_FULL_MONTH")]
			public static global::Com.Coinbase.Api.Entity.Report.TimeRange LastFullMonth {
				get {
					if (LAST_FULL_MONTH_jfieldId == IntPtr.Zero)
						LAST_FULL_MONTH_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LAST_FULL_MONTH", "Lcom/coinbase/api/entity/Report$TimeRange;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LAST_FULL_MONTH_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Report.TimeRange> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr LAST_FULL_YEAR_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Report.TimeRange']/field[@name='LAST_FULL_YEAR']"
			[Register ("LAST_FULL_YEAR")]
			public static global::Com.Coinbase.Api.Entity.Report.TimeRange LastFullYear {
				get {
					if (LAST_FULL_YEAR_jfieldId == IntPtr.Zero)
						LAST_FULL_YEAR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LAST_FULL_YEAR", "Lcom/coinbase/api/entity/Report$TimeRange;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LAST_FULL_YEAR_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Report.TimeRange> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr MONTH_TO_DATE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Report.TimeRange']/field[@name='MONTH_TO_DATE']"
			[Register ("MONTH_TO_DATE")]
			public static global::Com.Coinbase.Api.Entity.Report.TimeRange MonthToDate {
				get {
					if (MONTH_TO_DATE_jfieldId == IntPtr.Zero)
						MONTH_TO_DATE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MONTH_TO_DATE", "Lcom/coinbase/api/entity/Report$TimeRange;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MONTH_TO_DATE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Report.TimeRange> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr PAST_SEVEN_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Report.TimeRange']/field[@name='PAST_SEVEN']"
			[Register ("PAST_SEVEN")]
			public static global::Com.Coinbase.Api.Entity.Report.TimeRange PastSeven {
				get {
					if (PAST_SEVEN_jfieldId == IntPtr.Zero)
						PAST_SEVEN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PAST_SEVEN", "Lcom/coinbase/api/entity/Report$TimeRange;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PAST_SEVEN_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Report.TimeRange> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr PAST_THIRTY_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Report.TimeRange']/field[@name='PAST_THIRTY']"
			[Register ("PAST_THIRTY")]
			public static global::Com.Coinbase.Api.Entity.Report.TimeRange PastThirty {
				get {
					if (PAST_THIRTY_jfieldId == IntPtr.Zero)
						PAST_THIRTY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PAST_THIRTY", "Lcom/coinbase/api/entity/Report$TimeRange;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PAST_THIRTY_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Report.TimeRange> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr TODAY_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Report.TimeRange']/field[@name='TODAY']"
			[Register ("TODAY")]
			public static global::Com.Coinbase.Api.Entity.Report.TimeRange Today {
				get {
					if (TODAY_jfieldId == IntPtr.Zero)
						TODAY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TODAY", "Lcom/coinbase/api/entity/Report$TimeRange;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TODAY_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Report.TimeRange> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr YEAR_TO_DATE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Report.TimeRange']/field[@name='YEAR_TO_DATE']"
			[Register ("YEAR_TO_DATE")]
			public static global::Com.Coinbase.Api.Entity.Report.TimeRange YearToDate {
				get {
					if (YEAR_TO_DATE_jfieldId == IntPtr.Zero)
						YEAR_TO_DATE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "YEAR_TO_DATE", "Lcom/coinbase/api/entity/Report$TimeRange;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, YEAR_TO_DATE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Report.TimeRange> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr YESTERDAY_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Report.TimeRange']/field[@name='YESTERDAY']"
			[Register ("YESTERDAY")]
			public static global::Com.Coinbase.Api.Entity.Report.TimeRange Yesterday {
				get {
					if (YESTERDAY_jfieldId == IntPtr.Zero)
						YESTERDAY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "YESTERDAY", "Lcom/coinbase/api/entity/Report$TimeRange;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, YESTERDAY_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Report.TimeRange> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/coinbase/api/entity/Report$TimeRange", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (TimeRange); }
			}

			internal TimeRange (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_create_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Report.TimeRange']/method[@name='create' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("create", "(Ljava/lang/String;)Lcom/coinbase/api/entity/Report$TimeRange;", "")]
			public static unsafe global::Com.Coinbase.Api.Entity.Report.TimeRange Create (string p0)
			{
				if (id_create_Ljava_lang_String_ == IntPtr.Zero)
					id_create_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "create", "(Ljava/lang/String;)Lcom/coinbase/api/entity/Report$TimeRange;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Coinbase.Api.Entity.Report.TimeRange __ret = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Report.TimeRange> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Report.TimeRange']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/coinbase/api/entity/Report$TimeRange;", "")]
			public static unsafe global::Com.Coinbase.Api.Entity.Report.TimeRange ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/coinbase/api/entity/Report$TimeRange;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Coinbase.Api.Entity.Report.TimeRange __ret = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Report.TimeRange> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Report.TimeRange']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/coinbase/api/entity/Report$TimeRange;", "")]
			public static unsafe global::Com.Coinbase.Api.Entity.Report.TimeRange[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/coinbase/api/entity/Report$TimeRange;");
				try {
					return (global::Com.Coinbase.Api.Entity.Report.TimeRange[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Coinbase.Api.Entity.Report.TimeRange));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Report.Type']"
		[global::Android.Runtime.Register ("com/coinbase/api/entity/Report$Type", DoNotGenerateAcw=true)]
		public sealed partial class Type : global::Java.Lang.Enum {


			static IntPtr ORDERS_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Report.Type']/field[@name='ORDERS']"
			[Register ("ORDERS")]
			public static global::Com.Coinbase.Api.Entity.Report.Type Orders {
				get {
					if (ORDERS_jfieldId == IntPtr.Zero)
						ORDERS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ORDERS", "Lcom/coinbase/api/entity/Report$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ORDERS_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Report.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr TRANSACTIONS_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Report.Type']/field[@name='TRANSACTIONS']"
			[Register ("TRANSACTIONS")]
			public static global::Com.Coinbase.Api.Entity.Report.Type Transactions {
				get {
					if (TRANSACTIONS_jfieldId == IntPtr.Zero)
						TRANSACTIONS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TRANSACTIONS", "Lcom/coinbase/api/entity/Report$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TRANSACTIONS_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Report.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr TRANSFERS_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Report.Type']/field[@name='TRANSFERS']"
			[Register ("TRANSFERS")]
			public static global::Com.Coinbase.Api.Entity.Report.Type Transfers {
				get {
					if (TRANSFERS_jfieldId == IntPtr.Zero)
						TRANSFERS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TRANSFERS", "Lcom/coinbase/api/entity/Report$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TRANSFERS_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Report.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/coinbase/api/entity/Report$Type", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Type); }
			}

			internal Type (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_create_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Report.Type']/method[@name='create' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("create", "(Ljava/lang/String;)Lcom/coinbase/api/entity/Report$Type;", "")]
			public static unsafe global::Com.Coinbase.Api.Entity.Report.Type Create (string p0)
			{
				if (id_create_Ljava_lang_String_ == IntPtr.Zero)
					id_create_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "create", "(Ljava/lang/String;)Lcom/coinbase/api/entity/Report$Type;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Coinbase.Api.Entity.Report.Type __ret = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Report.Type> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Report.Type']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/coinbase/api/entity/Report$Type;", "")]
			public static unsafe global::Com.Coinbase.Api.Entity.Report.Type ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/coinbase/api/entity/Report$Type;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Coinbase.Api.Entity.Report.Type __ret = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Report.Type> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Report.Type']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/coinbase/api/entity/Report$Type;", "")]
			public static unsafe global::Com.Coinbase.Api.Entity.Report.Type[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/coinbase/api/entity/Report$Type;");
				try {
					return (global::Com.Coinbase.Api.Entity.Report.Type[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Coinbase.Api.Entity.Report.Type));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/coinbase/api/entity/Report", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Report); }
		}

		protected Report (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Report']/constructor[@name='Report' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Report ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Report)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static Delegate cb_getCallbackUrl;
#pragma warning disable 0169
		static Delegate GetGetCallbackUrlHandler ()
		{
			if (cb_getCallbackUrl == null)
				cb_getCallbackUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCallbackUrl);
			return cb_getCallbackUrl;
		}

		static IntPtr n_GetCallbackUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.Report __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Report> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CallbackUrl);
		}
#pragma warning restore 0169

		static Delegate cb_setCallbackUrl_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCallbackUrl_Ljava_lang_String_Handler ()
		{
			if (cb_setCallbackUrl_Ljava_lang_String_ == null)
				cb_setCallbackUrl_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCallbackUrl_Ljava_lang_String_);
			return cb_setCallbackUrl_Ljava_lang_String_;
		}

		static void n_SetCallbackUrl_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.Report __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Report> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CallbackUrl = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCallbackUrl;
		static IntPtr id_setCallbackUrl_Ljava_lang_String_;
		public virtual unsafe string CallbackUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Report']/method[@name='getCallbackUrl' and count(parameter)=0]"
			[Register ("getCallbackUrl", "()Ljava/lang/String;", "GetGetCallbackUrlHandler")]
			get {
				if (id_getCallbackUrl == IntPtr.Zero)
					id_getCallbackUrl = JNIEnv.GetMethodID (class_ref, "getCallbackUrl", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getCallbackUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCallbackUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Report']/method[@name='setCallbackUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCallbackUrl", "(Ljava/lang/String;)V", "GetSetCallbackUrl_Ljava_lang_String_Handler")]
			set {
				if (id_setCallbackUrl_Ljava_lang_String_ == IntPtr.Zero)
					id_setCallbackUrl_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCallbackUrl", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setCallbackUrl_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCallbackUrl", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getEmail;
#pragma warning disable 0169
		static Delegate GetGetEmailHandler ()
		{
			if (cb_getEmail == null)
				cb_getEmail = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEmail);
			return cb_getEmail;
		}

		static IntPtr n_GetEmail (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.Report __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Report> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Email);
		}
#pragma warning restore 0169

		static Delegate cb_setEmail_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetEmail_Ljava_lang_String_Handler ()
		{
			if (cb_setEmail_Ljava_lang_String_ == null)
				cb_setEmail_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetEmail_Ljava_lang_String_);
			return cb_setEmail_Ljava_lang_String_;
		}

		static void n_SetEmail_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.Report __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Report> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Email = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getEmail;
		static IntPtr id_setEmail_Ljava_lang_String_;
		public virtual unsafe string Email {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Report']/method[@name='getEmail' and count(parameter)=0]"
			[Register ("getEmail", "()Ljava/lang/String;", "GetGetEmailHandler")]
			get {
				if (id_getEmail == IntPtr.Zero)
					id_getEmail = JNIEnv.GetMethodID (class_ref, "getEmail", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getEmail), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEmail", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Report']/method[@name='setEmail' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setEmail", "(Ljava/lang/String;)V", "GetSetEmail_Ljava_lang_String_Handler")]
			set {
				if (id_setEmail_Ljava_lang_String_ == IntPtr.Zero)
					id_setEmail_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setEmail", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setEmail_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEmail", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getId;
#pragma warning disable 0169
		static Delegate GetGetIdHandler ()
		{
			if (cb_getId == null)
				cb_getId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetId);
			return cb_getId;
		}

		static IntPtr n_GetId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.Report __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Report> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Id);
		}
#pragma warning restore 0169

		static Delegate cb_setId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetId_Ljava_lang_String_Handler ()
		{
			if (cb_setId_Ljava_lang_String_ == null)
				cb_setId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetId_Ljava_lang_String_);
			return cb_setId_Ljava_lang_String_;
		}

		static void n_SetId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.Report __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Report> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Id = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getId;
		static IntPtr id_setId_Ljava_lang_String_;
		public virtual unsafe string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Report']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()Ljava/lang/String;", "GetGetIdHandler")]
			get {
				if (id_getId == IntPtr.Zero)
					id_getId = JNIEnv.GetMethodID (class_ref, "getId", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Report']/method[@name='setId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setId", "(Ljava/lang/String;)V", "GetSetId_Ljava_lang_String_Handler")]
			set {
				if (id_setId_Ljava_lang_String_ == IntPtr.Zero)
					id_setId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setId", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setId_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setId", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr id_getInfinite;
		public static unsafe global::Java.Lang.Integer Infinite {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Report']/method[@name='getInfinite' and count(parameter)=0]"
			[Register ("getInfinite", "()Ljava/lang/Integer;", "GetGetInfiniteHandler")]
			get {
				if (id_getInfinite == IntPtr.Zero)
					id_getInfinite = JNIEnv.GetStaticMethodID (class_ref, "getInfinite", "()Ljava/lang/Integer;");
				try {
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInfinite), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getNextRunDate;
#pragma warning disable 0169
		static Delegate GetGetNextRunDateHandler ()
		{
			if (cb_getNextRunDate == null)
				cb_getNextRunDate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNextRunDate);
			return cb_getNextRunDate;
		}

		static IntPtr n_GetNextRunDate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.Report __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Report> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.NextRunDate);
		}
#pragma warning restore 0169

		static IntPtr id_getNextRunDate;
		public virtual unsafe string NextRunDate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Report']/method[@name='getNextRunDate' and count(parameter)=0]"
			[Register ("getNextRunDate", "()Ljava/lang/String;", "GetGetNextRunDateHandler")]
			get {
				if (id_getNextRunDate == IntPtr.Zero)
					id_getNextRunDate = JNIEnv.GetMethodID (class_ref, "getNextRunDate", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getNextRunDate), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNextRunDate", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getNextRunTime;
#pragma warning disable 0169
		static Delegate GetGetNextRunTimeHandler ()
		{
			if (cb_getNextRunTime == null)
				cb_getNextRunTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNextRunTime);
			return cb_getNextRunTime;
		}

		static IntPtr n_GetNextRunTime (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.Report __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Report> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.NextRunTime);
		}
#pragma warning restore 0169

		static IntPtr id_getNextRunTime;
		public virtual unsafe string NextRunTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Report']/method[@name='getNextRunTime' and count(parameter)=0]"
			[Register ("getNextRunTime", "()Ljava/lang/String;", "GetGetNextRunTimeHandler")]
			get {
				if (id_getNextRunTime == IntPtr.Zero)
					id_getNextRunTime = JNIEnv.GetMethodID (class_ref, "getNextRunTime", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getNextRunTime), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNextRunTime", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTimeRangeEnd;
#pragma warning disable 0169
		static Delegate GetGetTimeRangeEndHandler ()
		{
			if (cb_getTimeRangeEnd == null)
				cb_getTimeRangeEnd = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTimeRangeEnd);
			return cb_getTimeRangeEnd;
		}

		static IntPtr n_GetTimeRangeEnd (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.Report __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Report> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TimeRangeEnd);
		}
#pragma warning restore 0169

		static IntPtr id_getTimeRangeEnd;
		public virtual unsafe string TimeRangeEnd {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Report']/method[@name='getTimeRangeEnd' and count(parameter)=0]"
			[Register ("getTimeRangeEnd", "()Ljava/lang/String;", "GetGetTimeRangeEndHandler")]
			get {
				if (id_getTimeRangeEnd == IntPtr.Zero)
					id_getTimeRangeEnd = JNIEnv.GetMethodID (class_ref, "getTimeRangeEnd", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getTimeRangeEnd), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTimeRangeEnd", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTimeRangeStart;
#pragma warning disable 0169
		static Delegate GetGetTimeRangeStartHandler ()
		{
			if (cb_getTimeRangeStart == null)
				cb_getTimeRangeStart = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTimeRangeStart);
			return cb_getTimeRangeStart;
		}

		static IntPtr n_GetTimeRangeStart (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.Report __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Report> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TimeRangeStart);
		}
#pragma warning restore 0169

		static IntPtr id_getTimeRangeStart;
		public virtual unsafe string TimeRangeStart {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Report']/method[@name='getTimeRangeStart' and count(parameter)=0]"
			[Register ("getTimeRangeStart", "()Ljava/lang/String;", "GetGetTimeRangeStartHandler")]
			get {
				if (id_getTimeRangeStart == IntPtr.Zero)
					id_getTimeRangeStart = JNIEnv.GetMethodID (class_ref, "getTimeRangeStart", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getTimeRangeStart), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTimeRangeStart", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTimes;
#pragma warning disable 0169
		static Delegate GetGetTimesHandler ()
		{
			if (cb_getTimes == null)
				cb_getTimes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTimes);
			return cb_getTimes;
		}

		static IntPtr n_GetTimes (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.Report __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Report> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Times);
		}
#pragma warning restore 0169

		static Delegate cb_setTimes_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetSetTimes_Ljava_lang_Integer_Handler ()
		{
			if (cb_setTimes_Ljava_lang_Integer_ == null)
				cb_setTimes_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTimes_Ljava_lang_Integer_);
			return cb_setTimes_Ljava_lang_Integer_;
		}

		static void n_SetTimes_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.Report __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Report> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Times = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTimes;
		static IntPtr id_setTimes_Ljava_lang_Integer_;
		public virtual unsafe global::Java.Lang.Integer Times {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Report']/method[@name='getTimes' and count(parameter)=0]"
			[Register ("getTimes", "()Ljava/lang/Integer;", "GetGetTimesHandler")]
			get {
				if (id_getTimes == IntPtr.Zero)
					id_getTimes = JNIEnv.GetMethodID (class_ref, "getTimes", "()Ljava/lang/Integer;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod  (Handle, id_getTimes), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTimes", "()Ljava/lang/Integer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Report']/method[@name='setTimes' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("setTimes", "(Ljava/lang/Integer;)V", "GetSetTimes_Ljava_lang_Integer_Handler")]
			set {
				if (id_setTimes_Ljava_lang_Integer_ == IntPtr.Zero)
					id_setTimes_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "setTimes", "(Ljava/lang/Integer;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setTimes_Ljava_lang_Integer_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTimes", "(Ljava/lang/Integer;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTimesRun;
#pragma warning disable 0169
		static Delegate GetGetTimesRunHandler ()
		{
			if (cb_getTimesRun == null)
				cb_getTimesRun = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTimesRun);
			return cb_getTimesRun;
		}

		static IntPtr n_GetTimesRun (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.Report __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Report> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TimesRun);
		}
#pragma warning restore 0169

		static Delegate cb_setTimesRun_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetSetTimesRun_Ljava_lang_Integer_Handler ()
		{
			if (cb_setTimesRun_Ljava_lang_Integer_ == null)
				cb_setTimesRun_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTimesRun_Ljava_lang_Integer_);
			return cb_setTimesRun_Ljava_lang_Integer_;
		}

		static void n_SetTimesRun_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.Report __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Report> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TimesRun = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTimesRun;
		static IntPtr id_setTimesRun_Ljava_lang_Integer_;
		public virtual unsafe global::Java.Lang.Integer TimesRun {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Report']/method[@name='getTimesRun' and count(parameter)=0]"
			[Register ("getTimesRun", "()Ljava/lang/Integer;", "GetGetTimesRunHandler")]
			get {
				if (id_getTimesRun == IntPtr.Zero)
					id_getTimesRun = JNIEnv.GetMethodID (class_ref, "getTimesRun", "()Ljava/lang/Integer;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod  (Handle, id_getTimesRun), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTimesRun", "()Ljava/lang/Integer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Report']/method[@name='setTimesRun' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("setTimesRun", "(Ljava/lang/Integer;)V", "GetSetTimesRun_Ljava_lang_Integer_Handler")]
			set {
				if (id_setTimesRun_Ljava_lang_Integer_ == IntPtr.Zero)
					id_setTimesRun_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "setTimesRun", "(Ljava/lang/Integer;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setTimesRun_Ljava_lang_Integer_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTimesRun", "(Ljava/lang/Integer;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getRepeat;
#pragma warning disable 0169
		static Delegate GetGetRepeatHandler ()
		{
			if (cb_getRepeat == null)
				cb_getRepeat = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRepeat);
			return cb_getRepeat;
		}

		static IntPtr n_GetRepeat (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.Report __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Report> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetRepeat ());
		}
#pragma warning restore 0169

		static IntPtr id_getRepeat;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Report']/method[@name='getRepeat' and count(parameter)=0]"
		[Register ("getRepeat", "()Lcom/coinbase/api/entity/Report$Repeat;", "GetGetRepeatHandler")]
		public virtual unsafe global::Com.Coinbase.Api.Entity.Report.Repeat GetRepeat ()
		{
			if (id_getRepeat == IntPtr.Zero)
				id_getRepeat = JNIEnv.GetMethodID (class_ref, "getRepeat", "()Lcom/coinbase/api/entity/Report$Repeat;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Report.Repeat> (JNIEnv.CallObjectMethod  (Handle, id_getRepeat), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Report.Repeat> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRepeat", "()Lcom/coinbase/api/entity/Report$Repeat;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getStartType;
#pragma warning disable 0169
		static Delegate GetGetStartTypeHandler ()
		{
			if (cb_getStartType == null)
				cb_getStartType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStartType);
			return cb_getStartType;
		}

		static IntPtr n_GetStartType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.Report __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Report> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetStartType ());
		}
#pragma warning restore 0169

		static IntPtr id_getStartType;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Report']/method[@name='getStartType' and count(parameter)=0]"
		[Register ("getStartType", "()Lcom/coinbase/api/entity/Report$StartType;", "GetGetStartTypeHandler")]
		public virtual unsafe global::Com.Coinbase.Api.Entity.Report.StartType GetStartType ()
		{
			if (id_getStartType == IntPtr.Zero)
				id_getStartType = JNIEnv.GetMethodID (class_ref, "getStartType", "()Lcom/coinbase/api/entity/Report$StartType;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Report.StartType> (JNIEnv.CallObjectMethod  (Handle, id_getStartType), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Report.StartType> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStartType", "()Lcom/coinbase/api/entity/Report$StartType;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getStatus;
#pragma warning disable 0169
		static Delegate GetGetStatusHandler ()
		{
			if (cb_getStatus == null)
				cb_getStatus = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStatus);
			return cb_getStatus;
		}

		static IntPtr n_GetStatus (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.Report __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Report> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetStatus ());
		}
#pragma warning restore 0169

		static IntPtr id_getStatus;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Report']/method[@name='getStatus' and count(parameter)=0]"
		[Register ("getStatus", "()Lcom/coinbase/api/entity/Report$Status;", "GetGetStatusHandler")]
		public virtual unsafe global::Com.Coinbase.Api.Entity.Report.Status GetStatus ()
		{
			if (id_getStatus == IntPtr.Zero)
				id_getStatus = JNIEnv.GetMethodID (class_ref, "getStatus", "()Lcom/coinbase/api/entity/Report$Status;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Report.Status> (JNIEnv.CallObjectMethod  (Handle, id_getStatus), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Report.Status> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStatus", "()Lcom/coinbase/api/entity/Report$Status;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getTimeRange;
#pragma warning disable 0169
		static Delegate GetGetTimeRangeHandler ()
		{
			if (cb_getTimeRange == null)
				cb_getTimeRange = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTimeRange);
			return cb_getTimeRange;
		}

		static IntPtr n_GetTimeRange (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.Report __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Report> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetTimeRange ());
		}
#pragma warning restore 0169

		static IntPtr id_getTimeRange;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Report']/method[@name='getTimeRange' and count(parameter)=0]"
		[Register ("getTimeRange", "()Lcom/coinbase/api/entity/Report$TimeRange;", "GetGetTimeRangeHandler")]
		public virtual unsafe global::Com.Coinbase.Api.Entity.Report.TimeRange GetTimeRange ()
		{
			if (id_getTimeRange == IntPtr.Zero)
				id_getTimeRange = JNIEnv.GetMethodID (class_ref, "getTimeRange", "()Lcom/coinbase/api/entity/Report$TimeRange;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Report.TimeRange> (JNIEnv.CallObjectMethod  (Handle, id_getTimeRange), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Report.TimeRange> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTimeRange", "()Lcom/coinbase/api/entity/Report$TimeRange;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getType;
#pragma warning disable 0169
		static Delegate GetGetTypeHandler ()
		{
			if (cb_getType == null)
				cb_getType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetType);
			return cb_getType;
		}

		static IntPtr n_GetType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.Report __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Report> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetType ());
		}
#pragma warning restore 0169

		static IntPtr id_getType;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Report']/method[@name='getType' and count(parameter)=0]"
		[Register ("getType", "()Lcom/coinbase/api/entity/Report$Type;", "GetGetTypeHandler")]
		public virtual unsafe global::Com.Coinbase.Api.Entity.Report.Type GetType ()
		{
			if (id_getType == IntPtr.Zero)
				id_getType = JNIEnv.GetMethodID (class_ref, "getType", "()Lcom/coinbase/api/entity/Report$Type;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Report.Type> (JNIEnv.CallObjectMethod  (Handle, id_getType), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Report.Type> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getType", "()Lcom/coinbase/api/entity/Report$Type;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setRepeat_Lcom_coinbase_api_entity_Report_Repeat_;
#pragma warning disable 0169
		static Delegate GetSetRepeat_Lcom_coinbase_api_entity_Report_Repeat_Handler ()
		{
			if (cb_setRepeat_Lcom_coinbase_api_entity_Report_Repeat_ == null)
				cb_setRepeat_Lcom_coinbase_api_entity_Report_Repeat_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRepeat_Lcom_coinbase_api_entity_Report_Repeat_);
			return cb_setRepeat_Lcom_coinbase_api_entity_Report_Repeat_;
		}

		static void n_SetRepeat_Lcom_coinbase_api_entity_Report_Repeat_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.Report __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Report> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Coinbase.Api.Entity.Report.Repeat p0 = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Report.Repeat> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetRepeat (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setRepeat_Lcom_coinbase_api_entity_Report_Repeat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Report']/method[@name='setRepeat' and count(parameter)=1 and parameter[1][@type='com.coinbase.api.entity.Report.Repeat']]"
		[Register ("setRepeat", "(Lcom/coinbase/api/entity/Report$Repeat;)V", "GetSetRepeat_Lcom_coinbase_api_entity_Report_Repeat_Handler")]
		public virtual unsafe void SetRepeat (global::Com.Coinbase.Api.Entity.Report.Repeat p0)
		{
			if (id_setRepeat_Lcom_coinbase_api_entity_Report_Repeat_ == IntPtr.Zero)
				id_setRepeat_Lcom_coinbase_api_entity_Report_Repeat_ = JNIEnv.GetMethodID (class_ref, "setRepeat", "(Lcom/coinbase/api/entity/Report$Repeat;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setRepeat_Lcom_coinbase_api_entity_Report_Repeat_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRepeat", "(Lcom/coinbase/api/entity/Report$Repeat;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setStartType_Lcom_coinbase_api_entity_Report_StartType_;
#pragma warning disable 0169
		static Delegate GetSetStartType_Lcom_coinbase_api_entity_Report_StartType_Handler ()
		{
			if (cb_setStartType_Lcom_coinbase_api_entity_Report_StartType_ == null)
				cb_setStartType_Lcom_coinbase_api_entity_Report_StartType_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetStartType_Lcom_coinbase_api_entity_Report_StartType_);
			return cb_setStartType_Lcom_coinbase_api_entity_Report_StartType_;
		}

		static void n_SetStartType_Lcom_coinbase_api_entity_Report_StartType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.Report __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Report> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Coinbase.Api.Entity.Report.StartType p0 = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Report.StartType> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetStartType (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setStartType_Lcom_coinbase_api_entity_Report_StartType_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Report']/method[@name='setStartType' and count(parameter)=1 and parameter[1][@type='com.coinbase.api.entity.Report.StartType']]"
		[Register ("setStartType", "(Lcom/coinbase/api/entity/Report$StartType;)V", "GetSetStartType_Lcom_coinbase_api_entity_Report_StartType_Handler")]
		public virtual unsafe void SetStartType (global::Com.Coinbase.Api.Entity.Report.StartType p0)
		{
			if (id_setStartType_Lcom_coinbase_api_entity_Report_StartType_ == IntPtr.Zero)
				id_setStartType_Lcom_coinbase_api_entity_Report_StartType_ = JNIEnv.GetMethodID (class_ref, "setStartType", "(Lcom/coinbase/api/entity/Report$StartType;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setStartType_Lcom_coinbase_api_entity_Report_StartType_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setStartType", "(Lcom/coinbase/api/entity/Report$StartType;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setStatus_Lcom_coinbase_api_entity_Report_Status_;
#pragma warning disable 0169
		static Delegate GetSetStatus_Lcom_coinbase_api_entity_Report_Status_Handler ()
		{
			if (cb_setStatus_Lcom_coinbase_api_entity_Report_Status_ == null)
				cb_setStatus_Lcom_coinbase_api_entity_Report_Status_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetStatus_Lcom_coinbase_api_entity_Report_Status_);
			return cb_setStatus_Lcom_coinbase_api_entity_Report_Status_;
		}

		static void n_SetStatus_Lcom_coinbase_api_entity_Report_Status_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.Report __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Report> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Coinbase.Api.Entity.Report.Status p0 = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Report.Status> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetStatus (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setStatus_Lcom_coinbase_api_entity_Report_Status_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Report']/method[@name='setStatus' and count(parameter)=1 and parameter[1][@type='com.coinbase.api.entity.Report.Status']]"
		[Register ("setStatus", "(Lcom/coinbase/api/entity/Report$Status;)V", "GetSetStatus_Lcom_coinbase_api_entity_Report_Status_Handler")]
		public virtual unsafe void SetStatus (global::Com.Coinbase.Api.Entity.Report.Status p0)
		{
			if (id_setStatus_Lcom_coinbase_api_entity_Report_Status_ == IntPtr.Zero)
				id_setStatus_Lcom_coinbase_api_entity_Report_Status_ = JNIEnv.GetMethodID (class_ref, "setStatus", "(Lcom/coinbase/api/entity/Report$Status;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setStatus_Lcom_coinbase_api_entity_Report_Status_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setStatus", "(Lcom/coinbase/api/entity/Report$Status;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setTimeRange_Lcom_coinbase_api_entity_Report_TimeRange_;
#pragma warning disable 0169
		static Delegate GetSetTimeRange_Lcom_coinbase_api_entity_Report_TimeRange_Handler ()
		{
			if (cb_setTimeRange_Lcom_coinbase_api_entity_Report_TimeRange_ == null)
				cb_setTimeRange_Lcom_coinbase_api_entity_Report_TimeRange_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTimeRange_Lcom_coinbase_api_entity_Report_TimeRange_);
			return cb_setTimeRange_Lcom_coinbase_api_entity_Report_TimeRange_;
		}

		static void n_SetTimeRange_Lcom_coinbase_api_entity_Report_TimeRange_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.Report __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Report> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Coinbase.Api.Entity.Report.TimeRange p0 = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Report.TimeRange> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetTimeRange (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setTimeRange_Lcom_coinbase_api_entity_Report_TimeRange_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Report']/method[@name='setTimeRange' and count(parameter)=1 and parameter[1][@type='com.coinbase.api.entity.Report.TimeRange']]"
		[Register ("setTimeRange", "(Lcom/coinbase/api/entity/Report$TimeRange;)V", "GetSetTimeRange_Lcom_coinbase_api_entity_Report_TimeRange_Handler")]
		public virtual unsafe void SetTimeRange (global::Com.Coinbase.Api.Entity.Report.TimeRange p0)
		{
			if (id_setTimeRange_Lcom_coinbase_api_entity_Report_TimeRange_ == IntPtr.Zero)
				id_setTimeRange_Lcom_coinbase_api_entity_Report_TimeRange_ = JNIEnv.GetMethodID (class_ref, "setTimeRange", "(Lcom/coinbase/api/entity/Report$TimeRange;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setTimeRange_Lcom_coinbase_api_entity_Report_TimeRange_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTimeRange", "(Lcom/coinbase/api/entity/Report$TimeRange;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setType_Lcom_coinbase_api_entity_Report_Type_;
#pragma warning disable 0169
		static Delegate GetSetType_Lcom_coinbase_api_entity_Report_Type_Handler ()
		{
			if (cb_setType_Lcom_coinbase_api_entity_Report_Type_ == null)
				cb_setType_Lcom_coinbase_api_entity_Report_Type_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetType_Lcom_coinbase_api_entity_Report_Type_);
			return cb_setType_Lcom_coinbase_api_entity_Report_Type_;
		}

		static void n_SetType_Lcom_coinbase_api_entity_Report_Type_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.Report __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Report> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Coinbase.Api.Entity.Report.Type p0 = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Report.Type> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetType (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setType_Lcom_coinbase_api_entity_Report_Type_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Report']/method[@name='setType' and count(parameter)=1 and parameter[1][@type='com.coinbase.api.entity.Report.Type']]"
		[Register ("setType", "(Lcom/coinbase/api/entity/Report$Type;)V", "GetSetType_Lcom_coinbase_api_entity_Report_Type_Handler")]
		public virtual unsafe void SetType (global::Com.Coinbase.Api.Entity.Report.Type p0)
		{
			if (id_setType_Lcom_coinbase_api_entity_Report_Type_ == IntPtr.Zero)
				id_setType_Lcom_coinbase_api_entity_Report_Type_ = JNIEnv.GetMethodID (class_ref, "setType", "(Lcom/coinbase/api/entity/Report$Type;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setType_Lcom_coinbase_api_entity_Report_Type_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setType", "(Lcom/coinbase/api/entity/Report$Type;)V"), __args);
			} finally {
			}
		}

	}
}
