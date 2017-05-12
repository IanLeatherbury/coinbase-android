using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Coinbase.Api.Entity {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Button']"
	[global::Android.Runtime.Register ("com/coinbase/api/entity/Button", DoNotGenerateAcw=true)]
	public partial class Button : global::Java.Lang.Object, global::Java.IO.ISerializable {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Button.Repeat']"
		[global::Android.Runtime.Register ("com/coinbase/api/entity/Button$Repeat", DoNotGenerateAcw=true)]
		public sealed partial class Repeat : global::Java.Lang.Enum {


			static IntPtr BIWEEKLY_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Button.Repeat']/field[@name='BIWEEKLY']"
			[Register ("BIWEEKLY")]
			public static global::Com.Coinbase.Api.Entity.Button.Repeat Biweekly {
				get {
					if (BIWEEKLY_jfieldId == IntPtr.Zero)
						BIWEEKLY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BIWEEKLY", "Lcom/coinbase/api/entity/Button$Repeat;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BIWEEKLY_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Button.Repeat> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr DAILY_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Button.Repeat']/field[@name='DAILY']"
			[Register ("DAILY")]
			public static global::Com.Coinbase.Api.Entity.Button.Repeat Daily {
				get {
					if (DAILY_jfieldId == IntPtr.Zero)
						DAILY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DAILY", "Lcom/coinbase/api/entity/Button$Repeat;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DAILY_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Button.Repeat> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr MONTHLY_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Button.Repeat']/field[@name='MONTHLY']"
			[Register ("MONTHLY")]
			public static global::Com.Coinbase.Api.Entity.Button.Repeat Monthly {
				get {
					if (MONTHLY_jfieldId == IntPtr.Zero)
						MONTHLY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MONTHLY", "Lcom/coinbase/api/entity/Button$Repeat;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MONTHLY_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Button.Repeat> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr NEVER_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Button.Repeat']/field[@name='NEVER']"
			[Register ("NEVER")]
			public static global::Com.Coinbase.Api.Entity.Button.Repeat Never {
				get {
					if (NEVER_jfieldId == IntPtr.Zero)
						NEVER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NEVER", "Lcom/coinbase/api/entity/Button$Repeat;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NEVER_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Button.Repeat> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr QUARTERLY_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Button.Repeat']/field[@name='QUARTERLY']"
			[Register ("QUARTERLY")]
			public static global::Com.Coinbase.Api.Entity.Button.Repeat Quarterly {
				get {
					if (QUARTERLY_jfieldId == IntPtr.Zero)
						QUARTERLY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "QUARTERLY", "Lcom/coinbase/api/entity/Button$Repeat;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, QUARTERLY_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Button.Repeat> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr WEEKLY_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Button.Repeat']/field[@name='WEEKLY']"
			[Register ("WEEKLY")]
			public static global::Com.Coinbase.Api.Entity.Button.Repeat Weekly {
				get {
					if (WEEKLY_jfieldId == IntPtr.Zero)
						WEEKLY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "WEEKLY", "Lcom/coinbase/api/entity/Button$Repeat;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, WEEKLY_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Button.Repeat> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr YEARLY_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Button.Repeat']/field[@name='YEARLY']"
			[Register ("YEARLY")]
			public static global::Com.Coinbase.Api.Entity.Button.Repeat Yearly {
				get {
					if (YEARLY_jfieldId == IntPtr.Zero)
						YEARLY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "YEARLY", "Lcom/coinbase/api/entity/Button$Repeat;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, YEARLY_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Button.Repeat> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/coinbase/api/entity/Button$Repeat", ref java_class_handle);
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Button.Repeat']/method[@name='create' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("create", "(Ljava/lang/String;)Lcom/coinbase/api/entity/Button$Repeat;", "")]
			public static unsafe global::Com.Coinbase.Api.Entity.Button.Repeat Create (string p0)
			{
				if (id_create_Ljava_lang_String_ == IntPtr.Zero)
					id_create_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "create", "(Ljava/lang/String;)Lcom/coinbase/api/entity/Button$Repeat;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Coinbase.Api.Entity.Button.Repeat __ret = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Button.Repeat> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Button.Repeat']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/coinbase/api/entity/Button$Repeat;", "")]
			public static unsafe global::Com.Coinbase.Api.Entity.Button.Repeat ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/coinbase/api/entity/Button$Repeat;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Coinbase.Api.Entity.Button.Repeat __ret = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Button.Repeat> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Button.Repeat']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/coinbase/api/entity/Button$Repeat;", "")]
			public static unsafe global::Com.Coinbase.Api.Entity.Button.Repeat[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/coinbase/api/entity/Button$Repeat;");
				try {
					return (global::Com.Coinbase.Api.Entity.Button.Repeat[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Coinbase.Api.Entity.Button.Repeat));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Button.Style']"
		[global::Android.Runtime.Register ("com/coinbase/api/entity/Button$Style", DoNotGenerateAcw=true)]
		public sealed partial class Style : global::Java.Lang.Enum {


			static IntPtr BUY_NOW_LARGE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Button.Style']/field[@name='BUY_NOW_LARGE']"
			[Register ("BUY_NOW_LARGE")]
			public static global::Com.Coinbase.Api.Entity.Button.Style BuyNowLarge {
				get {
					if (BUY_NOW_LARGE_jfieldId == IntPtr.Zero)
						BUY_NOW_LARGE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BUY_NOW_LARGE", "Lcom/coinbase/api/entity/Button$Style;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BUY_NOW_LARGE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Button.Style> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr BUY_NOW_SMALL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Button.Style']/field[@name='BUY_NOW_SMALL']"
			[Register ("BUY_NOW_SMALL")]
			public static global::Com.Coinbase.Api.Entity.Button.Style BuyNowSmall {
				get {
					if (BUY_NOW_SMALL_jfieldId == IntPtr.Zero)
						BUY_NOW_SMALL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BUY_NOW_SMALL", "Lcom/coinbase/api/entity/Button$Style;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BUY_NOW_SMALL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Button.Style> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr CUSTOM_LARGE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Button.Style']/field[@name='CUSTOM_LARGE']"
			[Register ("CUSTOM_LARGE")]
			public static global::Com.Coinbase.Api.Entity.Button.Style CustomLarge {
				get {
					if (CUSTOM_LARGE_jfieldId == IntPtr.Zero)
						CUSTOM_LARGE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CUSTOM_LARGE", "Lcom/coinbase/api/entity/Button$Style;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CUSTOM_LARGE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Button.Style> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr CUSTOM_SMALL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Button.Style']/field[@name='CUSTOM_SMALL']"
			[Register ("CUSTOM_SMALL")]
			public static global::Com.Coinbase.Api.Entity.Button.Style CustomSmall {
				get {
					if (CUSTOM_SMALL_jfieldId == IntPtr.Zero)
						CUSTOM_SMALL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CUSTOM_SMALL", "Lcom/coinbase/api/entity/Button$Style;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CUSTOM_SMALL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Button.Style> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr DONATION_LARGE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Button.Style']/field[@name='DONATION_LARGE']"
			[Register ("DONATION_LARGE")]
			public static global::Com.Coinbase.Api.Entity.Button.Style DonationLarge {
				get {
					if (DONATION_LARGE_jfieldId == IntPtr.Zero)
						DONATION_LARGE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DONATION_LARGE", "Lcom/coinbase/api/entity/Button$Style;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DONATION_LARGE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Button.Style> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr DONATION_SMALL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Button.Style']/field[@name='DONATION_SMALL']"
			[Register ("DONATION_SMALL")]
			public static global::Com.Coinbase.Api.Entity.Button.Style DonationSmall {
				get {
					if (DONATION_SMALL_jfieldId == IntPtr.Zero)
						DONATION_SMALL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DONATION_SMALL", "Lcom/coinbase/api/entity/Button$Style;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DONATION_SMALL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Button.Style> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr NONE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Button.Style']/field[@name='NONE']"
			[Register ("NONE")]
			public static global::Com.Coinbase.Api.Entity.Button.Style None {
				get {
					if (NONE_jfieldId == IntPtr.Zero)
						NONE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NONE", "Lcom/coinbase/api/entity/Button$Style;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NONE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Button.Style> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr SUBSCRIPTION_LARGE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Button.Style']/field[@name='SUBSCRIPTION_LARGE']"
			[Register ("SUBSCRIPTION_LARGE")]
			public static global::Com.Coinbase.Api.Entity.Button.Style SubscriptionLarge {
				get {
					if (SUBSCRIPTION_LARGE_jfieldId == IntPtr.Zero)
						SUBSCRIPTION_LARGE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SUBSCRIPTION_LARGE", "Lcom/coinbase/api/entity/Button$Style;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SUBSCRIPTION_LARGE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Button.Style> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr SUBSCRIPTION_SMALL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Button.Style']/field[@name='SUBSCRIPTION_SMALL']"
			[Register ("SUBSCRIPTION_SMALL")]
			public static global::Com.Coinbase.Api.Entity.Button.Style SubscriptionSmall {
				get {
					if (SUBSCRIPTION_SMALL_jfieldId == IntPtr.Zero)
						SUBSCRIPTION_SMALL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SUBSCRIPTION_SMALL", "Lcom/coinbase/api/entity/Button$Style;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SUBSCRIPTION_SMALL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Button.Style> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/coinbase/api/entity/Button$Style", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Style); }
			}

			internal Style (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_create_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Button.Style']/method[@name='create' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("create", "(Ljava/lang/String;)Lcom/coinbase/api/entity/Button$Style;", "")]
			public static unsafe global::Com.Coinbase.Api.Entity.Button.Style Create (string p0)
			{
				if (id_create_Ljava_lang_String_ == IntPtr.Zero)
					id_create_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "create", "(Ljava/lang/String;)Lcom/coinbase/api/entity/Button$Style;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Coinbase.Api.Entity.Button.Style __ret = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Button.Style> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Button.Style']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/coinbase/api/entity/Button$Style;", "")]
			public static unsafe global::Com.Coinbase.Api.Entity.Button.Style ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/coinbase/api/entity/Button$Style;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Coinbase.Api.Entity.Button.Style __ret = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Button.Style> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Button.Style']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/coinbase/api/entity/Button$Style;", "")]
			public static unsafe global::Com.Coinbase.Api.Entity.Button.Style[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/coinbase/api/entity/Button$Style;");
				try {
					return (global::Com.Coinbase.Api.Entity.Button.Style[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Coinbase.Api.Entity.Button.Style));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Button.Type']"
		[global::Android.Runtime.Register ("com/coinbase/api/entity/Button$Type", DoNotGenerateAcw=true)]
		public sealed partial class Type : global::Java.Lang.Enum {


			static IntPtr BUY_NOW_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Button.Type']/field[@name='BUY_NOW']"
			[Register ("BUY_NOW")]
			public static global::Com.Coinbase.Api.Entity.Button.Type BuyNow {
				get {
					if (BUY_NOW_jfieldId == IntPtr.Zero)
						BUY_NOW_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BUY_NOW", "Lcom/coinbase/api/entity/Button$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BUY_NOW_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Button.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr DONATION_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Button.Type']/field[@name='DONATION']"
			[Register ("DONATION")]
			public static global::Com.Coinbase.Api.Entity.Button.Type Donation {
				get {
					if (DONATION_jfieldId == IntPtr.Zero)
						DONATION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DONATION", "Lcom/coinbase/api/entity/Button$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DONATION_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Button.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr SUBSCRIPTION_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Button.Type']/field[@name='SUBSCRIPTION']"
			[Register ("SUBSCRIPTION")]
			public static global::Com.Coinbase.Api.Entity.Button.Type Subscription {
				get {
					if (SUBSCRIPTION_jfieldId == IntPtr.Zero)
						SUBSCRIPTION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SUBSCRIPTION", "Lcom/coinbase/api/entity/Button$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SUBSCRIPTION_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Button.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/coinbase/api/entity/Button$Type", ref java_class_handle);
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Button.Type']/method[@name='create' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("create", "(Ljava/lang/String;)Lcom/coinbase/api/entity/Button$Type;", "")]
			public static unsafe global::Com.Coinbase.Api.Entity.Button.Type Create (string p0)
			{
				if (id_create_Ljava_lang_String_ == IntPtr.Zero)
					id_create_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "create", "(Ljava/lang/String;)Lcom/coinbase/api/entity/Button$Type;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Coinbase.Api.Entity.Button.Type __ret = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Button.Type> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Button.Type']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/coinbase/api/entity/Button$Type;", "")]
			public static unsafe global::Com.Coinbase.Api.Entity.Button.Type ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/coinbase/api/entity/Button$Type;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Coinbase.Api.Entity.Button.Type __ret = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Button.Type> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Button.Type']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/coinbase/api/entity/Button$Type;", "")]
			public static unsafe global::Com.Coinbase.Api.Entity.Button.Type[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/coinbase/api/entity/Button$Type;");
				try {
					return (global::Com.Coinbase.Api.Entity.Button.Type[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Coinbase.Api.Entity.Button.Type));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/coinbase/api/entity/Button", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Button); }
		}

		protected Button (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Button']/constructor[@name='Button' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Button ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Button)) {
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

		static Delegate cb_getAutoRedirect;
#pragma warning disable 0169
		static Delegate GetGetAutoRedirectHandler ()
		{
			if (cb_getAutoRedirect == null)
				cb_getAutoRedirect = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAutoRedirect);
			return cb_getAutoRedirect;
		}

		static IntPtr n_GetAutoRedirect (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.Button __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Button> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AutoRedirect);
		}
#pragma warning restore 0169

		static Delegate cb_setAutoRedirect_Ljava_lang_Boolean_;
#pragma warning disable 0169
		static Delegate GetSetAutoRedirect_Ljava_lang_Boolean_Handler ()
		{
			if (cb_setAutoRedirect_Ljava_lang_Boolean_ == null)
				cb_setAutoRedirect_Ljava_lang_Boolean_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAutoRedirect_Ljava_lang_Boolean_);
			return cb_setAutoRedirect_Ljava_lang_Boolean_;
		}

		static void n_SetAutoRedirect_Ljava_lang_Boolean_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.Button __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Button> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Boolean p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AutoRedirect = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAutoRedirect;
		static IntPtr id_setAutoRedirect_Ljava_lang_Boolean_;
		public virtual unsafe global::Java.Lang.Boolean AutoRedirect {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Button']/method[@name='getAutoRedirect' and count(parameter)=0]"
			[Register ("getAutoRedirect", "()Ljava/lang/Boolean;", "GetGetAutoRedirectHandler")]
			get {
				if (id_getAutoRedirect == IntPtr.Zero)
					id_getAutoRedirect = JNIEnv.GetMethodID (class_ref, "getAutoRedirect", "()Ljava/lang/Boolean;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallObjectMethod  (Handle, id_getAutoRedirect), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAutoRedirect", "()Ljava/lang/Boolean;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Button']/method[@name='setAutoRedirect' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
			[Register ("setAutoRedirect", "(Ljava/lang/Boolean;)V", "GetSetAutoRedirect_Ljava_lang_Boolean_Handler")]
			set {
				if (id_setAutoRedirect_Ljava_lang_Boolean_ == IntPtr.Zero)
					id_setAutoRedirect_Ljava_lang_Boolean_ = JNIEnv.GetMethodID (class_ref, "setAutoRedirect", "(Ljava/lang/Boolean;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setAutoRedirect_Ljava_lang_Boolean_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAutoRedirect", "(Ljava/lang/Boolean;)V"), __args);
				} finally {
				}
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
			global::Com.Coinbase.Api.Entity.Button __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Button> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Coinbase.Api.Entity.Button __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Button> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CallbackUrl = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCallbackUrl;
		static IntPtr id_setCallbackUrl_Ljava_lang_String_;
		public virtual unsafe string CallbackUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Button']/method[@name='getCallbackUrl' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Button']/method[@name='setCallbackUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getCancelUrl;
#pragma warning disable 0169
		static Delegate GetGetCancelUrlHandler ()
		{
			if (cb_getCancelUrl == null)
				cb_getCancelUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCancelUrl);
			return cb_getCancelUrl;
		}

		static IntPtr n_GetCancelUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.Button __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Button> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CancelUrl);
		}
#pragma warning restore 0169

		static Delegate cb_setCancelUrl_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCancelUrl_Ljava_lang_String_Handler ()
		{
			if (cb_setCancelUrl_Ljava_lang_String_ == null)
				cb_setCancelUrl_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCancelUrl_Ljava_lang_String_);
			return cb_setCancelUrl_Ljava_lang_String_;
		}

		static void n_SetCancelUrl_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.Button __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Button> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CancelUrl = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCancelUrl;
		static IntPtr id_setCancelUrl_Ljava_lang_String_;
		public virtual unsafe string CancelUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Button']/method[@name='getCancelUrl' and count(parameter)=0]"
			[Register ("getCancelUrl", "()Ljava/lang/String;", "GetGetCancelUrlHandler")]
			get {
				if (id_getCancelUrl == IntPtr.Zero)
					id_getCancelUrl = JNIEnv.GetMethodID (class_ref, "getCancelUrl", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getCancelUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCancelUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Button']/method[@name='setCancelUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCancelUrl", "(Ljava/lang/String;)V", "GetSetCancelUrl_Ljava_lang_String_Handler")]
			set {
				if (id_setCancelUrl_Ljava_lang_String_ == IntPtr.Zero)
					id_setCancelUrl_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCancelUrl", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setCancelUrl_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCancelUrl", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getChoosePrice;
#pragma warning disable 0169
		static Delegate GetGetChoosePriceHandler ()
		{
			if (cb_getChoosePrice == null)
				cb_getChoosePrice = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetChoosePrice);
			return cb_getChoosePrice;
		}

		static IntPtr n_GetChoosePrice (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.Button __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Button> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ChoosePrice);
		}
#pragma warning restore 0169

		static Delegate cb_setChoosePrice_Ljava_lang_Boolean_;
#pragma warning disable 0169
		static Delegate GetSetChoosePrice_Ljava_lang_Boolean_Handler ()
		{
			if (cb_setChoosePrice_Ljava_lang_Boolean_ == null)
				cb_setChoosePrice_Ljava_lang_Boolean_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetChoosePrice_Ljava_lang_Boolean_);
			return cb_setChoosePrice_Ljava_lang_Boolean_;
		}

		static void n_SetChoosePrice_Ljava_lang_Boolean_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.Button __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Button> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Boolean p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ChoosePrice = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getChoosePrice;
		static IntPtr id_setChoosePrice_Ljava_lang_Boolean_;
		public virtual unsafe global::Java.Lang.Boolean ChoosePrice {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Button']/method[@name='getChoosePrice' and count(parameter)=0]"
			[Register ("getChoosePrice", "()Ljava/lang/Boolean;", "GetGetChoosePriceHandler")]
			get {
				if (id_getChoosePrice == IntPtr.Zero)
					id_getChoosePrice = JNIEnv.GetMethodID (class_ref, "getChoosePrice", "()Ljava/lang/Boolean;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallObjectMethod  (Handle, id_getChoosePrice), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getChoosePrice", "()Ljava/lang/Boolean;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Button']/method[@name='setChoosePrice' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
			[Register ("setChoosePrice", "(Ljava/lang/Boolean;)V", "GetSetChoosePrice_Ljava_lang_Boolean_Handler")]
			set {
				if (id_setChoosePrice_Ljava_lang_Boolean_ == IntPtr.Zero)
					id_setChoosePrice_Ljava_lang_Boolean_ = JNIEnv.GetMethodID (class_ref, "setChoosePrice", "(Ljava/lang/Boolean;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setChoosePrice_Ljava_lang_Boolean_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setChoosePrice", "(Ljava/lang/Boolean;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getCode;
#pragma warning disable 0169
		static Delegate GetGetCodeHandler ()
		{
			if (cb_getCode == null)
				cb_getCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCode);
			return cb_getCode;
		}

		static IntPtr n_GetCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.Button __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Button> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Code);
		}
#pragma warning restore 0169

		static Delegate cb_setCode_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCode_Ljava_lang_String_Handler ()
		{
			if (cb_setCode_Ljava_lang_String_ == null)
				cb_setCode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCode_Ljava_lang_String_);
			return cb_setCode_Ljava_lang_String_;
		}

		static void n_SetCode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.Button __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Button> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Code = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCode;
		static IntPtr id_setCode_Ljava_lang_String_;
		public virtual unsafe string Code {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Button']/method[@name='getCode' and count(parameter)=0]"
			[Register ("getCode", "()Ljava/lang/String;", "GetGetCodeHandler")]
			get {
				if (id_getCode == IntPtr.Zero)
					id_getCode = JNIEnv.GetMethodID (class_ref, "getCode", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getCode), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCode", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Button']/method[@name='setCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCode", "(Ljava/lang/String;)V", "GetSetCode_Ljava_lang_String_Handler")]
			set {
				if (id_setCode_Ljava_lang_String_ == IntPtr.Zero)
					id_setCode_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCode", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setCode_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCode", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getCustom;
#pragma warning disable 0169
		static Delegate GetGetCustomHandler ()
		{
			if (cb_getCustom == null)
				cb_getCustom = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCustom);
			return cb_getCustom;
		}

		static IntPtr n_GetCustom (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.Button __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Button> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Custom);
		}
#pragma warning restore 0169

		static Delegate cb_setCustom_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCustom_Ljava_lang_String_Handler ()
		{
			if (cb_setCustom_Ljava_lang_String_ == null)
				cb_setCustom_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCustom_Ljava_lang_String_);
			return cb_setCustom_Ljava_lang_String_;
		}

		static void n_SetCustom_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.Button __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Button> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Custom = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCustom;
		static IntPtr id_setCustom_Ljava_lang_String_;
		public virtual unsafe string Custom {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Button']/method[@name='getCustom' and count(parameter)=0]"
			[Register ("getCustom", "()Ljava/lang/String;", "GetGetCustomHandler")]
			get {
				if (id_getCustom == IntPtr.Zero)
					id_getCustom = JNIEnv.GetMethodID (class_ref, "getCustom", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getCustom), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCustom", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Button']/method[@name='setCustom' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCustom", "(Ljava/lang/String;)V", "GetSetCustom_Ljava_lang_String_Handler")]
			set {
				if (id_setCustom_Ljava_lang_String_ == IntPtr.Zero)
					id_setCustom_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCustom", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setCustom_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCustom", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getCustomSecure;
#pragma warning disable 0169
		static Delegate GetGetCustomSecureHandler ()
		{
			if (cb_getCustomSecure == null)
				cb_getCustomSecure = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCustomSecure);
			return cb_getCustomSecure;
		}

		static IntPtr n_GetCustomSecure (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.Button __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Button> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CustomSecure);
		}
#pragma warning restore 0169

		static Delegate cb_setCustomSecure_Ljava_lang_Boolean_;
#pragma warning disable 0169
		static Delegate GetSetCustomSecure_Ljava_lang_Boolean_Handler ()
		{
			if (cb_setCustomSecure_Ljava_lang_Boolean_ == null)
				cb_setCustomSecure_Ljava_lang_Boolean_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCustomSecure_Ljava_lang_Boolean_);
			return cb_setCustomSecure_Ljava_lang_Boolean_;
		}

		static void n_SetCustomSecure_Ljava_lang_Boolean_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.Button __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Button> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Boolean p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CustomSecure = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCustomSecure;
		static IntPtr id_setCustomSecure_Ljava_lang_Boolean_;
		public virtual unsafe global::Java.Lang.Boolean CustomSecure {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Button']/method[@name='getCustomSecure' and count(parameter)=0]"
			[Register ("getCustomSecure", "()Ljava/lang/Boolean;", "GetGetCustomSecureHandler")]
			get {
				if (id_getCustomSecure == IntPtr.Zero)
					id_getCustomSecure = JNIEnv.GetMethodID (class_ref, "getCustomSecure", "()Ljava/lang/Boolean;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallObjectMethod  (Handle, id_getCustomSecure), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCustomSecure", "()Ljava/lang/Boolean;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Button']/method[@name='setCustomSecure' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
			[Register ("setCustomSecure", "(Ljava/lang/Boolean;)V", "GetSetCustomSecure_Ljava_lang_Boolean_Handler")]
			set {
				if (id_setCustomSecure_Ljava_lang_Boolean_ == IntPtr.Zero)
					id_setCustomSecure_Ljava_lang_Boolean_ = JNIEnv.GetMethodID (class_ref, "setCustomSecure", "(Ljava/lang/Boolean;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setCustomSecure_Ljava_lang_Boolean_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCustomSecure", "(Ljava/lang/Boolean;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getDescription;
#pragma warning disable 0169
		static Delegate GetGetDescriptionHandler ()
		{
			if (cb_getDescription == null)
				cb_getDescription = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDescription);
			return cb_getDescription;
		}

		static IntPtr n_GetDescription (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.Button __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Button> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Description);
		}
#pragma warning restore 0169

		static Delegate cb_setDescription_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDescription_Ljava_lang_String_Handler ()
		{
			if (cb_setDescription_Ljava_lang_String_ == null)
				cb_setDescription_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDescription_Ljava_lang_String_);
			return cb_setDescription_Ljava_lang_String_;
		}

		static void n_SetDescription_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.Button __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Button> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Description = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDescription;
		static IntPtr id_setDescription_Ljava_lang_String_;
		public virtual unsafe string Description {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Button']/method[@name='getDescription' and count(parameter)=0]"
			[Register ("getDescription", "()Ljava/lang/String;", "GetGetDescriptionHandler")]
			get {
				if (id_getDescription == IntPtr.Zero)
					id_getDescription = JNIEnv.GetMethodID (class_ref, "getDescription", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getDescription), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDescription", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Button']/method[@name='setDescription' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setDescription", "(Ljava/lang/String;)V", "GetSetDescription_Ljava_lang_String_Handler")]
			set {
				if (id_setDescription_Ljava_lang_String_ == IntPtr.Zero)
					id_setDescription_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setDescription", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setDescription_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDescription", "(Ljava/lang/String;)V"), __args);
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
			global::Com.Coinbase.Api.Entity.Button __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Button> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Coinbase.Api.Entity.Button __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Button> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Id = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getId;
		static IntPtr id_setId_Ljava_lang_String_;
		public virtual unsafe string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Button']/method[@name='getId' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Button']/method[@name='setId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getIncludeAddress;
#pragma warning disable 0169
		static Delegate GetGetIncludeAddressHandler ()
		{
			if (cb_getIncludeAddress == null)
				cb_getIncludeAddress = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIncludeAddress);
			return cb_getIncludeAddress;
		}

		static IntPtr n_GetIncludeAddress (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.Button __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Button> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IncludeAddress);
		}
#pragma warning restore 0169

		static Delegate cb_setIncludeAddress_Ljava_lang_Boolean_;
#pragma warning disable 0169
		static Delegate GetSetIncludeAddress_Ljava_lang_Boolean_Handler ()
		{
			if (cb_setIncludeAddress_Ljava_lang_Boolean_ == null)
				cb_setIncludeAddress_Ljava_lang_Boolean_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetIncludeAddress_Ljava_lang_Boolean_);
			return cb_setIncludeAddress_Ljava_lang_Boolean_;
		}

		static void n_SetIncludeAddress_Ljava_lang_Boolean_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.Button __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Button> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Boolean p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.IncludeAddress = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getIncludeAddress;
		static IntPtr id_setIncludeAddress_Ljava_lang_Boolean_;
		public virtual unsafe global::Java.Lang.Boolean IncludeAddress {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Button']/method[@name='getIncludeAddress' and count(parameter)=0]"
			[Register ("getIncludeAddress", "()Ljava/lang/Boolean;", "GetGetIncludeAddressHandler")]
			get {
				if (id_getIncludeAddress == IntPtr.Zero)
					id_getIncludeAddress = JNIEnv.GetMethodID (class_ref, "getIncludeAddress", "()Ljava/lang/Boolean;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallObjectMethod  (Handle, id_getIncludeAddress), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIncludeAddress", "()Ljava/lang/Boolean;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Button']/method[@name='setIncludeAddress' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
			[Register ("setIncludeAddress", "(Ljava/lang/Boolean;)V", "GetSetIncludeAddress_Ljava_lang_Boolean_Handler")]
			set {
				if (id_setIncludeAddress_Ljava_lang_Boolean_ == IntPtr.Zero)
					id_setIncludeAddress_Ljava_lang_Boolean_ = JNIEnv.GetMethodID (class_ref, "setIncludeAddress", "(Ljava/lang/Boolean;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setIncludeAddress_Ljava_lang_Boolean_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setIncludeAddress", "(Ljava/lang/Boolean;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getIncludeEmail;
#pragma warning disable 0169
		static Delegate GetGetIncludeEmailHandler ()
		{
			if (cb_getIncludeEmail == null)
				cb_getIncludeEmail = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIncludeEmail);
			return cb_getIncludeEmail;
		}

		static IntPtr n_GetIncludeEmail (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.Button __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Button> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IncludeEmail);
		}
#pragma warning restore 0169

		static Delegate cb_setIncludeEmail_Ljava_lang_Boolean_;
#pragma warning disable 0169
		static Delegate GetSetIncludeEmail_Ljava_lang_Boolean_Handler ()
		{
			if (cb_setIncludeEmail_Ljava_lang_Boolean_ == null)
				cb_setIncludeEmail_Ljava_lang_Boolean_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetIncludeEmail_Ljava_lang_Boolean_);
			return cb_setIncludeEmail_Ljava_lang_Boolean_;
		}

		static void n_SetIncludeEmail_Ljava_lang_Boolean_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.Button __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Button> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Boolean p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.IncludeEmail = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getIncludeEmail;
		static IntPtr id_setIncludeEmail_Ljava_lang_Boolean_;
		public virtual unsafe global::Java.Lang.Boolean IncludeEmail {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Button']/method[@name='getIncludeEmail' and count(parameter)=0]"
			[Register ("getIncludeEmail", "()Ljava/lang/Boolean;", "GetGetIncludeEmailHandler")]
			get {
				if (id_getIncludeEmail == IntPtr.Zero)
					id_getIncludeEmail = JNIEnv.GetMethodID (class_ref, "getIncludeEmail", "()Ljava/lang/Boolean;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallObjectMethod  (Handle, id_getIncludeEmail), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIncludeEmail", "()Ljava/lang/Boolean;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Button']/method[@name='setIncludeEmail' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
			[Register ("setIncludeEmail", "(Ljava/lang/Boolean;)V", "GetSetIncludeEmail_Ljava_lang_Boolean_Handler")]
			set {
				if (id_setIncludeEmail_Ljava_lang_Boolean_ == IntPtr.Zero)
					id_setIncludeEmail_Ljava_lang_Boolean_ = JNIEnv.GetMethodID (class_ref, "setIncludeEmail", "(Ljava/lang/Boolean;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setIncludeEmail_Ljava_lang_Boolean_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setIncludeEmail", "(Ljava/lang/Boolean;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getInfoUrl;
#pragma warning disable 0169
		static Delegate GetGetInfoUrlHandler ()
		{
			if (cb_getInfoUrl == null)
				cb_getInfoUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetInfoUrl);
			return cb_getInfoUrl;
		}

		static IntPtr n_GetInfoUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.Button __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Button> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.InfoUrl);
		}
#pragma warning restore 0169

		static Delegate cb_setInfoUrl_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetInfoUrl_Ljava_lang_String_Handler ()
		{
			if (cb_setInfoUrl_Ljava_lang_String_ == null)
				cb_setInfoUrl_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetInfoUrl_Ljava_lang_String_);
			return cb_setInfoUrl_Ljava_lang_String_;
		}

		static void n_SetInfoUrl_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.Button __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Button> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.InfoUrl = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getInfoUrl;
		static IntPtr id_setInfoUrl_Ljava_lang_String_;
		public virtual unsafe string InfoUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Button']/method[@name='getInfoUrl' and count(parameter)=0]"
			[Register ("getInfoUrl", "()Ljava/lang/String;", "GetGetInfoUrlHandler")]
			get {
				if (id_getInfoUrl == IntPtr.Zero)
					id_getInfoUrl = JNIEnv.GetMethodID (class_ref, "getInfoUrl", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getInfoUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getInfoUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Button']/method[@name='setInfoUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setInfoUrl", "(Ljava/lang/String;)V", "GetSetInfoUrl_Ljava_lang_String_Handler")]
			set {
				if (id_setInfoUrl_Ljava_lang_String_ == IntPtr.Zero)
					id_setInfoUrl_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setInfoUrl", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setInfoUrl_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setInfoUrl", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getName;
#pragma warning disable 0169
		static Delegate GetGetNameHandler ()
		{
			if (cb_getName == null)
				cb_getName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetName);
			return cb_getName;
		}

		static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.Button __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Button> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		static Delegate cb_setName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetName_Ljava_lang_String_Handler ()
		{
			if (cb_setName_Ljava_lang_String_ == null)
				cb_setName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetName_Ljava_lang_String_);
			return cb_setName_Ljava_lang_String_;
		}

		static void n_SetName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.Button __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Button> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Name = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getName;
		static IntPtr id_setName_Ljava_lang_String_;
		public virtual unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Button']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
			get {
				if (id_getName == IntPtr.Zero)
					id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Button']/method[@name='setName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setName", "(Ljava/lang/String;)V", "GetSetName_Ljava_lang_String_Handler")]
			set {
				if (id_setName_Ljava_lang_String_ == IntPtr.Zero)
					id_setName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setName", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setName_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setName", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getPriceCurrencyIso;
#pragma warning disable 0169
		static Delegate GetGetPriceCurrencyIsoHandler ()
		{
			if (cb_getPriceCurrencyIso == null)
				cb_getPriceCurrencyIso = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPriceCurrencyIso);
			return cb_getPriceCurrencyIso;
		}

		static IntPtr n_GetPriceCurrencyIso (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.Button __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Button> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PriceCurrencyIso);
		}
#pragma warning restore 0169

		static Delegate cb_setPriceCurrencyIso_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetPriceCurrencyIso_Ljava_lang_String_Handler ()
		{
			if (cb_setPriceCurrencyIso_Ljava_lang_String_ == null)
				cb_setPriceCurrencyIso_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPriceCurrencyIso_Ljava_lang_String_);
			return cb_setPriceCurrencyIso_Ljava_lang_String_;
		}

		static void n_SetPriceCurrencyIso_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.Button __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Button> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PriceCurrencyIso = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getPriceCurrencyIso;
		static IntPtr id_setPriceCurrencyIso_Ljava_lang_String_;
		public virtual unsafe string PriceCurrencyIso {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Button']/method[@name='getPriceCurrencyIso' and count(parameter)=0]"
			[Register ("getPriceCurrencyIso", "()Ljava/lang/String;", "GetGetPriceCurrencyIsoHandler")]
			get {
				if (id_getPriceCurrencyIso == IntPtr.Zero)
					id_getPriceCurrencyIso = JNIEnv.GetMethodID (class_ref, "getPriceCurrencyIso", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getPriceCurrencyIso), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPriceCurrencyIso", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Button']/method[@name='setPriceCurrencyIso' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setPriceCurrencyIso", "(Ljava/lang/String;)V", "GetSetPriceCurrencyIso_Ljava_lang_String_Handler")]
			set {
				if (id_setPriceCurrencyIso_Ljava_lang_String_ == IntPtr.Zero)
					id_setPriceCurrencyIso_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setPriceCurrencyIso", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setPriceCurrencyIso_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPriceCurrencyIso", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getPriceString;
#pragma warning disable 0169
		static Delegate GetGetPriceStringHandler ()
		{
			if (cb_getPriceString == null)
				cb_getPriceString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPriceString);
			return cb_getPriceString;
		}

		static IntPtr n_GetPriceString (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.Button __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Button> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PriceString);
		}
#pragma warning restore 0169

		static Delegate cb_setPriceString_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetPriceString_Ljava_lang_String_Handler ()
		{
			if (cb_setPriceString_Ljava_lang_String_ == null)
				cb_setPriceString_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPriceString_Ljava_lang_String_);
			return cb_setPriceString_Ljava_lang_String_;
		}

		static void n_SetPriceString_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.Button __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Button> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PriceString = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getPriceString;
		static IntPtr id_setPriceString_Ljava_lang_String_;
		public virtual unsafe string PriceString {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Button']/method[@name='getPriceString' and count(parameter)=0]"
			[Register ("getPriceString", "()Ljava/lang/String;", "GetGetPriceStringHandler")]
			get {
				if (id_getPriceString == IntPtr.Zero)
					id_getPriceString = JNIEnv.GetMethodID (class_ref, "getPriceString", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getPriceString), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPriceString", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Button']/method[@name='setPriceString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setPriceString", "(Ljava/lang/String;)V", "GetSetPriceString_Ljava_lang_String_Handler")]
			set {
				if (id_setPriceString_Ljava_lang_String_ == IntPtr.Zero)
					id_setPriceString_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setPriceString", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setPriceString_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPriceString", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getSuccessUrl;
#pragma warning disable 0169
		static Delegate GetGetSuccessUrlHandler ()
		{
			if (cb_getSuccessUrl == null)
				cb_getSuccessUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSuccessUrl);
			return cb_getSuccessUrl;
		}

		static IntPtr n_GetSuccessUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.Button __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Button> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SuccessUrl);
		}
#pragma warning restore 0169

		static Delegate cb_setSuccessUrl_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSuccessUrl_Ljava_lang_String_Handler ()
		{
			if (cb_setSuccessUrl_Ljava_lang_String_ == null)
				cb_setSuccessUrl_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSuccessUrl_Ljava_lang_String_);
			return cb_setSuccessUrl_Ljava_lang_String_;
		}

		static void n_SetSuccessUrl_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.Button __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Button> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SuccessUrl = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getSuccessUrl;
		static IntPtr id_setSuccessUrl_Ljava_lang_String_;
		public virtual unsafe string SuccessUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Button']/method[@name='getSuccessUrl' and count(parameter)=0]"
			[Register ("getSuccessUrl", "()Ljava/lang/String;", "GetGetSuccessUrlHandler")]
			get {
				if (id_getSuccessUrl == IntPtr.Zero)
					id_getSuccessUrl = JNIEnv.GetMethodID (class_ref, "getSuccessUrl", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getSuccessUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSuccessUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Button']/method[@name='setSuccessUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setSuccessUrl", "(Ljava/lang/String;)V", "GetSetSuccessUrl_Ljava_lang_String_Handler")]
			set {
				if (id_setSuccessUrl_Ljava_lang_String_ == IntPtr.Zero)
					id_setSuccessUrl_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setSuccessUrl", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setSuccessUrl_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSuccessUrl", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getText;
#pragma warning disable 0169
		static Delegate GetGetTextHandler ()
		{
			if (cb_getText == null)
				cb_getText = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetText);
			return cb_getText;
		}

		static IntPtr n_GetText (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.Button __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Button> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Text);
		}
#pragma warning restore 0169

		static Delegate cb_setText_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetText_Ljava_lang_String_Handler ()
		{
			if (cb_setText_Ljava_lang_String_ == null)
				cb_setText_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetText_Ljava_lang_String_);
			return cb_setText_Ljava_lang_String_;
		}

		static void n_SetText_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.Button __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Button> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Text = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getText;
		static IntPtr id_setText_Ljava_lang_String_;
		public virtual unsafe string Text {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Button']/method[@name='getText' and count(parameter)=0]"
			[Register ("getText", "()Ljava/lang/String;", "GetGetTextHandler")]
			get {
				if (id_getText == IntPtr.Zero)
					id_getText = JNIEnv.GetMethodID (class_ref, "getText", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getText), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getText", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Button']/method[@name='setText' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setText", "(Ljava/lang/String;)V", "GetSetText_Ljava_lang_String_Handler")]
			set {
				if (id_setText_Ljava_lang_String_ == IntPtr.Zero)
					id_setText_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setText", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setText_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setText", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
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
			global::Com.Coinbase.Api.Entity.Button __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Button> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetRepeat ());
		}
#pragma warning restore 0169

		static IntPtr id_getRepeat;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Button']/method[@name='getRepeat' and count(parameter)=0]"
		[Register ("getRepeat", "()Lcom/coinbase/api/entity/Button$Repeat;", "GetGetRepeatHandler")]
		public virtual unsafe global::Com.Coinbase.Api.Entity.Button.Repeat GetRepeat ()
		{
			if (id_getRepeat == IntPtr.Zero)
				id_getRepeat = JNIEnv.GetMethodID (class_ref, "getRepeat", "()Lcom/coinbase/api/entity/Button$Repeat;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Button.Repeat> (JNIEnv.CallObjectMethod  (Handle, id_getRepeat), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Button.Repeat> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRepeat", "()Lcom/coinbase/api/entity/Button$Repeat;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getStyle;
#pragma warning disable 0169
		static Delegate GetGetStyleHandler ()
		{
			if (cb_getStyle == null)
				cb_getStyle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStyle);
			return cb_getStyle;
		}

		static IntPtr n_GetStyle (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.Button __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Button> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetStyle ());
		}
#pragma warning restore 0169

		static IntPtr id_getStyle;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Button']/method[@name='getStyle' and count(parameter)=0]"
		[Register ("getStyle", "()Lcom/coinbase/api/entity/Button$Style;", "GetGetStyleHandler")]
		public virtual unsafe global::Com.Coinbase.Api.Entity.Button.Style GetStyle ()
		{
			if (id_getStyle == IntPtr.Zero)
				id_getStyle = JNIEnv.GetMethodID (class_ref, "getStyle", "()Lcom/coinbase/api/entity/Button$Style;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Button.Style> (JNIEnv.CallObjectMethod  (Handle, id_getStyle), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Button.Style> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStyle", "()Lcom/coinbase/api/entity/Button$Style;")), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Coinbase.Api.Entity.Button __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Button> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetType ());
		}
#pragma warning restore 0169

		static IntPtr id_getType;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Button']/method[@name='getType' and count(parameter)=0]"
		[Register ("getType", "()Lcom/coinbase/api/entity/Button$Type;", "GetGetTypeHandler")]
		public virtual unsafe global::Com.Coinbase.Api.Entity.Button.Type GetType ()
		{
			if (id_getType == IntPtr.Zero)
				id_getType = JNIEnv.GetMethodID (class_ref, "getType", "()Lcom/coinbase/api/entity/Button$Type;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Button.Type> (JNIEnv.CallObjectMethod  (Handle, id_getType), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Button.Type> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getType", "()Lcom/coinbase/api/entity/Button$Type;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setRepeat_Lcom_coinbase_api_entity_Button_Repeat_;
#pragma warning disable 0169
		static Delegate GetSetRepeat_Lcom_coinbase_api_entity_Button_Repeat_Handler ()
		{
			if (cb_setRepeat_Lcom_coinbase_api_entity_Button_Repeat_ == null)
				cb_setRepeat_Lcom_coinbase_api_entity_Button_Repeat_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRepeat_Lcom_coinbase_api_entity_Button_Repeat_);
			return cb_setRepeat_Lcom_coinbase_api_entity_Button_Repeat_;
		}

		static void n_SetRepeat_Lcom_coinbase_api_entity_Button_Repeat_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.Button __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Button> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Coinbase.Api.Entity.Button.Repeat p0 = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Button.Repeat> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetRepeat (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setRepeat_Lcom_coinbase_api_entity_Button_Repeat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Button']/method[@name='setRepeat' and count(parameter)=1 and parameter[1][@type='com.coinbase.api.entity.Button.Repeat']]"
		[Register ("setRepeat", "(Lcom/coinbase/api/entity/Button$Repeat;)V", "GetSetRepeat_Lcom_coinbase_api_entity_Button_Repeat_Handler")]
		public virtual unsafe void SetRepeat (global::Com.Coinbase.Api.Entity.Button.Repeat p0)
		{
			if (id_setRepeat_Lcom_coinbase_api_entity_Button_Repeat_ == IntPtr.Zero)
				id_setRepeat_Lcom_coinbase_api_entity_Button_Repeat_ = JNIEnv.GetMethodID (class_ref, "setRepeat", "(Lcom/coinbase/api/entity/Button$Repeat;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setRepeat_Lcom_coinbase_api_entity_Button_Repeat_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRepeat", "(Lcom/coinbase/api/entity/Button$Repeat;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setStyle_Lcom_coinbase_api_entity_Button_Style_;
#pragma warning disable 0169
		static Delegate GetSetStyle_Lcom_coinbase_api_entity_Button_Style_Handler ()
		{
			if (cb_setStyle_Lcom_coinbase_api_entity_Button_Style_ == null)
				cb_setStyle_Lcom_coinbase_api_entity_Button_Style_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetStyle_Lcom_coinbase_api_entity_Button_Style_);
			return cb_setStyle_Lcom_coinbase_api_entity_Button_Style_;
		}

		static void n_SetStyle_Lcom_coinbase_api_entity_Button_Style_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.Button __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Button> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Coinbase.Api.Entity.Button.Style p0 = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Button.Style> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetStyle (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setStyle_Lcom_coinbase_api_entity_Button_Style_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Button']/method[@name='setStyle' and count(parameter)=1 and parameter[1][@type='com.coinbase.api.entity.Button.Style']]"
		[Register ("setStyle", "(Lcom/coinbase/api/entity/Button$Style;)V", "GetSetStyle_Lcom_coinbase_api_entity_Button_Style_Handler")]
		public virtual unsafe void SetStyle (global::Com.Coinbase.Api.Entity.Button.Style p0)
		{
			if (id_setStyle_Lcom_coinbase_api_entity_Button_Style_ == IntPtr.Zero)
				id_setStyle_Lcom_coinbase_api_entity_Button_Style_ = JNIEnv.GetMethodID (class_ref, "setStyle", "(Lcom/coinbase/api/entity/Button$Style;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setStyle_Lcom_coinbase_api_entity_Button_Style_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setStyle", "(Lcom/coinbase/api/entity/Button$Style;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setType_Lcom_coinbase_api_entity_Button_Type_;
#pragma warning disable 0169
		static Delegate GetSetType_Lcom_coinbase_api_entity_Button_Type_Handler ()
		{
			if (cb_setType_Lcom_coinbase_api_entity_Button_Type_ == null)
				cb_setType_Lcom_coinbase_api_entity_Button_Type_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetType_Lcom_coinbase_api_entity_Button_Type_);
			return cb_setType_Lcom_coinbase_api_entity_Button_Type_;
		}

		static void n_SetType_Lcom_coinbase_api_entity_Button_Type_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.Button __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Button> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Coinbase.Api.Entity.Button.Type p0 = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Button.Type> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetType (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setType_Lcom_coinbase_api_entity_Button_Type_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Button']/method[@name='setType' and count(parameter)=1 and parameter[1][@type='com.coinbase.api.entity.Button.Type']]"
		[Register ("setType", "(Lcom/coinbase/api/entity/Button$Type;)V", "GetSetType_Lcom_coinbase_api_entity_Button_Type_Handler")]
		public virtual unsafe void SetType (global::Com.Coinbase.Api.Entity.Button.Type p0)
		{
			if (id_setType_Lcom_coinbase_api_entity_Button_Type_ == IntPtr.Zero)
				id_setType_Lcom_coinbase_api_entity_Button_Type_ = JNIEnv.GetMethodID (class_ref, "setType", "(Lcom/coinbase/api/entity/Button$Type;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setType_Lcom_coinbase_api_entity_Button_Type_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setType", "(Lcom/coinbase/api/entity/Button$Type;)V"), __args);
			} finally {
			}
		}

	}
}
