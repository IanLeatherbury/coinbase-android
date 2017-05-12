using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Coinbase.Api.Entity {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='PaymentMethod']"
	[global::Android.Runtime.Register ("com/coinbase/api/entity/PaymentMethod", DoNotGenerateAcw=true)]
	public partial class PaymentMethod : global::Java.Lang.Object, global::Java.IO.ISerializable {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='PaymentMethod.Type']"
		[global::Android.Runtime.Register ("com/coinbase/api/entity/PaymentMethod$Type", DoNotGenerateAcw=true)]
		public sealed partial class Type : global::Java.Lang.Enum {


			static IntPtr BANK_ACCOUNT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='PaymentMethod.Type']/field[@name='BANK_ACCOUNT']"
			[Register ("BANK_ACCOUNT")]
			public static global::Com.Coinbase.Api.Entity.PaymentMethod.Type BankAccount {
				get {
					if (BANK_ACCOUNT_jfieldId == IntPtr.Zero)
						BANK_ACCOUNT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BANK_ACCOUNT", "Lcom/coinbase/api/entity/PaymentMethod$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BANK_ACCOUNT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.PaymentMethod.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr BANK_WIRE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='PaymentMethod.Type']/field[@name='BANK_WIRE']"
			[Register ("BANK_WIRE")]
			public static global::Com.Coinbase.Api.Entity.PaymentMethod.Type BankWire {
				get {
					if (BANK_WIRE_jfieldId == IntPtr.Zero)
						BANK_WIRE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BANK_WIRE", "Lcom/coinbase/api/entity/PaymentMethod$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BANK_WIRE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.PaymentMethod.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr COINBASE_ACCOUNT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='PaymentMethod.Type']/field[@name='COINBASE_ACCOUNT']"
			[Register ("COINBASE_ACCOUNT")]
			public static global::Com.Coinbase.Api.Entity.PaymentMethod.Type CoinbaseAccount {
				get {
					if (COINBASE_ACCOUNT_jfieldId == IntPtr.Zero)
						COINBASE_ACCOUNT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "COINBASE_ACCOUNT", "Lcom/coinbase/api/entity/PaymentMethod$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, COINBASE_ACCOUNT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.PaymentMethod.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr COINBASE_FIAT_ACCOUNT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='PaymentMethod.Type']/field[@name='COINBASE_FIAT_ACCOUNT']"
			[Register ("COINBASE_FIAT_ACCOUNT")]
			public static global::Com.Coinbase.Api.Entity.PaymentMethod.Type CoinbaseFiatAccount {
				get {
					if (COINBASE_FIAT_ACCOUNT_jfieldId == IntPtr.Zero)
						COINBASE_FIAT_ACCOUNT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "COINBASE_FIAT_ACCOUNT", "Lcom/coinbase/api/entity/PaymentMethod$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, COINBASE_FIAT_ACCOUNT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.PaymentMethod.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr CREDIT_CARD_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='PaymentMethod.Type']/field[@name='CREDIT_CARD']"
			[Register ("CREDIT_CARD")]
			public static global::Com.Coinbase.Api.Entity.PaymentMethod.Type CreditCard {
				get {
					if (CREDIT_CARD_jfieldId == IntPtr.Zero)
						CREDIT_CARD_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREDIT_CARD", "Lcom/coinbase/api/entity/PaymentMethod$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREDIT_CARD_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.PaymentMethod.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr FUTURE_MERCHANT_PAYOUT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='PaymentMethod.Type']/field[@name='FUTURE_MERCHANT_PAYOUT']"
			[Register ("FUTURE_MERCHANT_PAYOUT")]
			public static global::Com.Coinbase.Api.Entity.PaymentMethod.Type FutureMerchantPayout {
				get {
					if (FUTURE_MERCHANT_PAYOUT_jfieldId == IntPtr.Zero)
						FUTURE_MERCHANT_PAYOUT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FUTURE_MERCHANT_PAYOUT", "Lcom/coinbase/api/entity/PaymentMethod$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FUTURE_MERCHANT_PAYOUT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.PaymentMethod.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr SEPA_PAYMENT_METHOD_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='PaymentMethod.Type']/field[@name='SEPA_PAYMENT_METHOD']"
			[Register ("SEPA_PAYMENT_METHOD")]
			public static global::Com.Coinbase.Api.Entity.PaymentMethod.Type SepaPaymentMethod {
				get {
					if (SEPA_PAYMENT_METHOD_jfieldId == IntPtr.Zero)
						SEPA_PAYMENT_METHOD_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SEPA_PAYMENT_METHOD", "Lcom/coinbase/api/entity/PaymentMethod$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SEPA_PAYMENT_METHOD_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.PaymentMethod.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/coinbase/api/entity/PaymentMethod$Type", ref java_class_handle);
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='PaymentMethod.Type']/method[@name='create' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("create", "(Ljava/lang/String;)Lcom/coinbase/api/entity/PaymentMethod$Type;", "")]
			public static unsafe global::Com.Coinbase.Api.Entity.PaymentMethod.Type Create (string p0)
			{
				if (id_create_Ljava_lang_String_ == IntPtr.Zero)
					id_create_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "create", "(Ljava/lang/String;)Lcom/coinbase/api/entity/PaymentMethod$Type;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Coinbase.Api.Entity.PaymentMethod.Type __ret = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.PaymentMethod.Type> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='PaymentMethod.Type']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/coinbase/api/entity/PaymentMethod$Type;", "")]
			public static unsafe global::Com.Coinbase.Api.Entity.PaymentMethod.Type ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/coinbase/api/entity/PaymentMethod$Type;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Coinbase.Api.Entity.PaymentMethod.Type __ret = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.PaymentMethod.Type> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='PaymentMethod.Type']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/coinbase/api/entity/PaymentMethod$Type;", "")]
			public static unsafe global::Com.Coinbase.Api.Entity.PaymentMethod.Type[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/coinbase/api/entity/PaymentMethod$Type;");
				try {
					return (global::Com.Coinbase.Api.Entity.PaymentMethod.Type[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Coinbase.Api.Entity.PaymentMethod.Type));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/coinbase/api/entity/PaymentMethod", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PaymentMethod); }
		}

		protected PaymentMethod (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='PaymentMethod']/constructor[@name='PaymentMethod' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PaymentMethod ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (PaymentMethod)) {
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

		static Delegate cb_getAccountId;
#pragma warning disable 0169
		static Delegate GetGetAccountIdHandler ()
		{
			if (cb_getAccountId == null)
				cb_getAccountId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAccountId);
			return cb_getAccountId;
		}

		static IntPtr n_GetAccountId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.PaymentMethod __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.PaymentMethod> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AccountId);
		}
#pragma warning restore 0169

		static Delegate cb_setAccountId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAccountId_Ljava_lang_String_Handler ()
		{
			if (cb_setAccountId_Ljava_lang_String_ == null)
				cb_setAccountId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAccountId_Ljava_lang_String_);
			return cb_setAccountId_Ljava_lang_String_;
		}

		static void n_SetAccountId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.PaymentMethod __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.PaymentMethod> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AccountId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAccountId;
		static IntPtr id_setAccountId_Ljava_lang_String_;
		public virtual unsafe string AccountId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='PaymentMethod']/method[@name='getAccountId' and count(parameter)=0]"
			[Register ("getAccountId", "()Ljava/lang/String;", "GetGetAccountIdHandler")]
			get {
				if (id_getAccountId == IntPtr.Zero)
					id_getAccountId = JNIEnv.GetMethodID (class_ref, "getAccountId", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getAccountId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAccountId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='PaymentMethod']/method[@name='setAccountId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAccountId", "(Ljava/lang/String;)V", "GetSetAccountId_Ljava_lang_String_Handler")]
			set {
				if (id_setAccountId_Ljava_lang_String_ == IntPtr.Zero)
					id_setAccountId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAccountId", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setAccountId_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAccountId", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getCurrency;
#pragma warning disable 0169
		static Delegate GetGetCurrencyHandler ()
		{
			if (cb_getCurrency == null)
				cb_getCurrency = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCurrency);
			return cb_getCurrency;
		}

		static IntPtr n_GetCurrency (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.PaymentMethod __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.PaymentMethod> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Currency);
		}
#pragma warning restore 0169

		static Delegate cb_setCurrency_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCurrency_Ljava_lang_String_Handler ()
		{
			if (cb_setCurrency_Ljava_lang_String_ == null)
				cb_setCurrency_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCurrency_Ljava_lang_String_);
			return cb_setCurrency_Ljava_lang_String_;
		}

		static void n_SetCurrency_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.PaymentMethod __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.PaymentMethod> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Currency = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCurrency;
		static IntPtr id_setCurrency_Ljava_lang_String_;
		public virtual unsafe string Currency {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='PaymentMethod']/method[@name='getCurrency' and count(parameter)=0]"
			[Register ("getCurrency", "()Ljava/lang/String;", "GetGetCurrencyHandler")]
			get {
				if (id_getCurrency == IntPtr.Zero)
					id_getCurrency = JNIEnv.GetMethodID (class_ref, "getCurrency", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getCurrency), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCurrency", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='PaymentMethod']/method[@name='setCurrency' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCurrency", "(Ljava/lang/String;)V", "GetSetCurrency_Ljava_lang_String_Handler")]
			set {
				if (id_setCurrency_Ljava_lang_String_ == IntPtr.Zero)
					id_setCurrency_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCurrency", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setCurrency_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCurrency", "(Ljava/lang/String;)V"), __args);
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
			global::Com.Coinbase.Api.Entity.PaymentMethod __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.PaymentMethod> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Coinbase.Api.Entity.PaymentMethod __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.PaymentMethod> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Id = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getId;
		static IntPtr id_setId_Ljava_lang_String_;
		public virtual unsafe string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='PaymentMethod']/method[@name='getId' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='PaymentMethod']/method[@name='setId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Coinbase.Api.Entity.PaymentMethod __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.PaymentMethod> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Coinbase.Api.Entity.PaymentMethod __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.PaymentMethod> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Name = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getName;
		static IntPtr id_setName_Ljava_lang_String_;
		public virtual unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='PaymentMethod']/method[@name='getName' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='PaymentMethod']/method[@name='setName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_canBuy;
#pragma warning disable 0169
		static Delegate GetCanBuyHandler ()
		{
			if (cb_canBuy == null)
				cb_canBuy = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_CanBuy);
			return cb_canBuy;
		}

		static IntPtr n_CanBuy (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.PaymentMethod __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.PaymentMethod> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CanBuy ());
		}
#pragma warning restore 0169

		static IntPtr id_canBuy;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='PaymentMethod']/method[@name='canBuy' and count(parameter)=0]"
		[Register ("canBuy", "()Ljava/lang/Boolean;", "GetCanBuyHandler")]
		public virtual unsafe global::Java.Lang.Boolean CanBuy ()
		{
			if (id_canBuy == IntPtr.Zero)
				id_canBuy = JNIEnv.GetMethodID (class_ref, "canBuy", "()Ljava/lang/Boolean;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallObjectMethod  (Handle, id_canBuy), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "canBuy", "()Ljava/lang/Boolean;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_canSell;
#pragma warning disable 0169
		static Delegate GetCanSellHandler ()
		{
			if (cb_canSell == null)
				cb_canSell = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_CanSell);
			return cb_canSell;
		}

		static IntPtr n_CanSell (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.PaymentMethod __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.PaymentMethod> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CanSell ());
		}
#pragma warning restore 0169

		static IntPtr id_canSell;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='PaymentMethod']/method[@name='canSell' and count(parameter)=0]"
		[Register ("canSell", "()Ljava/lang/Boolean;", "GetCanSellHandler")]
		public virtual unsafe global::Java.Lang.Boolean CanSell ()
		{
			if (id_canSell == IntPtr.Zero)
				id_canSell = JNIEnv.GetMethodID (class_ref, "canSell", "()Ljava/lang/Boolean;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallObjectMethod  (Handle, id_canSell), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "canSell", "()Ljava/lang/Boolean;")), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Coinbase.Api.Entity.PaymentMethod __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.PaymentMethod> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetType ());
		}
#pragma warning restore 0169

		static IntPtr id_getType;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='PaymentMethod']/method[@name='getType' and count(parameter)=0]"
		[Register ("getType", "()Lcom/coinbase/api/entity/PaymentMethod$Type;", "GetGetTypeHandler")]
		public virtual unsafe global::Com.Coinbase.Api.Entity.PaymentMethod.Type GetType ()
		{
			if (id_getType == IntPtr.Zero)
				id_getType = JNIEnv.GetMethodID (class_ref, "getType", "()Lcom/coinbase/api/entity/PaymentMethod$Type;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.PaymentMethod.Type> (JNIEnv.CallObjectMethod  (Handle, id_getType), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.PaymentMethod.Type> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getType", "()Lcom/coinbase/api/entity/PaymentMethod$Type;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setCanBuy_Ljava_lang_Boolean_;
#pragma warning disable 0169
		static Delegate GetSetCanBuy_Ljava_lang_Boolean_Handler ()
		{
			if (cb_setCanBuy_Ljava_lang_Boolean_ == null)
				cb_setCanBuy_Ljava_lang_Boolean_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCanBuy_Ljava_lang_Boolean_);
			return cb_setCanBuy_Ljava_lang_Boolean_;
		}

		static void n_SetCanBuy_Ljava_lang_Boolean_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.PaymentMethod __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.PaymentMethod> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Boolean p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetCanBuy (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setCanBuy_Ljava_lang_Boolean_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='PaymentMethod']/method[@name='setCanBuy' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
		[Register ("setCanBuy", "(Ljava/lang/Boolean;)V", "GetSetCanBuy_Ljava_lang_Boolean_Handler")]
		public virtual unsafe void SetCanBuy (global::Java.Lang.Boolean p0)
		{
			if (id_setCanBuy_Ljava_lang_Boolean_ == IntPtr.Zero)
				id_setCanBuy_Ljava_lang_Boolean_ = JNIEnv.GetMethodID (class_ref, "setCanBuy", "(Ljava/lang/Boolean;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setCanBuy_Ljava_lang_Boolean_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCanBuy", "(Ljava/lang/Boolean;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setCanSell_Ljava_lang_Boolean_;
#pragma warning disable 0169
		static Delegate GetSetCanSell_Ljava_lang_Boolean_Handler ()
		{
			if (cb_setCanSell_Ljava_lang_Boolean_ == null)
				cb_setCanSell_Ljava_lang_Boolean_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCanSell_Ljava_lang_Boolean_);
			return cb_setCanSell_Ljava_lang_Boolean_;
		}

		static void n_SetCanSell_Ljava_lang_Boolean_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.PaymentMethod __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.PaymentMethod> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Boolean p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetCanSell (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setCanSell_Ljava_lang_Boolean_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='PaymentMethod']/method[@name='setCanSell' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
		[Register ("setCanSell", "(Ljava/lang/Boolean;)V", "GetSetCanSell_Ljava_lang_Boolean_Handler")]
		public virtual unsafe void SetCanSell (global::Java.Lang.Boolean p0)
		{
			if (id_setCanSell_Ljava_lang_Boolean_ == IntPtr.Zero)
				id_setCanSell_Ljava_lang_Boolean_ = JNIEnv.GetMethodID (class_ref, "setCanSell", "(Ljava/lang/Boolean;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setCanSell_Ljava_lang_Boolean_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCanSell", "(Ljava/lang/Boolean;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setType_Lcom_coinbase_api_entity_PaymentMethod_Type_;
#pragma warning disable 0169
		static Delegate GetSetType_Lcom_coinbase_api_entity_PaymentMethod_Type_Handler ()
		{
			if (cb_setType_Lcom_coinbase_api_entity_PaymentMethod_Type_ == null)
				cb_setType_Lcom_coinbase_api_entity_PaymentMethod_Type_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetType_Lcom_coinbase_api_entity_PaymentMethod_Type_);
			return cb_setType_Lcom_coinbase_api_entity_PaymentMethod_Type_;
		}

		static void n_SetType_Lcom_coinbase_api_entity_PaymentMethod_Type_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.PaymentMethod __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.PaymentMethod> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Coinbase.Api.Entity.PaymentMethod.Type p0 = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.PaymentMethod.Type> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetType (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setType_Lcom_coinbase_api_entity_PaymentMethod_Type_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='PaymentMethod']/method[@name='setType' and count(parameter)=1 and parameter[1][@type='com.coinbase.api.entity.PaymentMethod.Type']]"
		[Register ("setType", "(Lcom/coinbase/api/entity/PaymentMethod$Type;)V", "GetSetType_Lcom_coinbase_api_entity_PaymentMethod_Type_Handler")]
		public virtual unsafe void SetType (global::Com.Coinbase.Api.Entity.PaymentMethod.Type p0)
		{
			if (id_setType_Lcom_coinbase_api_entity_PaymentMethod_Type_ == IntPtr.Zero)
				id_setType_Lcom_coinbase_api_entity_PaymentMethod_Type_ = JNIEnv.GetMethodID (class_ref, "setType", "(Lcom/coinbase/api/entity/PaymentMethod$Type;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setType_Lcom_coinbase_api_entity_PaymentMethod_Type_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setType", "(Lcom/coinbase/api/entity/PaymentMethod$Type;)V"), __args);
			} finally {
			}
		}

	}
}
