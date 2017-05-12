using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Coinbase.Api.Entity {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='AccountChange']"
	[global::Android.Runtime.Register ("com/coinbase/api/entity/AccountChange", DoNotGenerateAcw=true)]
	public partial class AccountChange : global::Java.Lang.Object, global::Java.IO.ISerializable {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='AccountChange.Cache']"
		[global::Android.Runtime.Register ("com/coinbase/api/entity/AccountChange$Cache", DoNotGenerateAcw=true)]
		public partial class Cache : global::Java.Lang.Object, global::Java.IO.ISerializable {

			// Metadata.xml XPath class reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='AccountChange.Cache.Category']"
			[global::Android.Runtime.Register ("com/coinbase/api/entity/AccountChange$Cache$Category", DoNotGenerateAcw=true)]
			public sealed partial class Category : global::Java.Lang.Enum {


				static IntPtr CANCELED_jfieldId;

				// Metadata.xml XPath field reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='AccountChange.Cache.Category']/field[@name='CANCELED']"
				[Register ("CANCELED")]
				public static global::Com.Coinbase.Api.Entity.AccountChange.Cache.Category Canceled {
					get {
						if (CANCELED_jfieldId == IntPtr.Zero)
							CANCELED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CANCELED", "Lcom/coinbase/api/entity/AccountChange$Cache$Category;");
						IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CANCELED_jfieldId);
						return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.AccountChange.Cache.Category> (__ret, JniHandleOwnership.TransferLocalRef);
					}
				}

				static IntPtr DEPOSIT_WITHDRAWAL_jfieldId;

				// Metadata.xml XPath field reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='AccountChange.Cache.Category']/field[@name='DEPOSIT_WITHDRAWAL']"
				[Register ("DEPOSIT_WITHDRAWAL")]
				public static global::Com.Coinbase.Api.Entity.AccountChange.Cache.Category DepositWithdrawal {
					get {
						if (DEPOSIT_WITHDRAWAL_jfieldId == IntPtr.Zero)
							DEPOSIT_WITHDRAWAL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEPOSIT_WITHDRAWAL", "Lcom/coinbase/api/entity/AccountChange$Cache$Category;");
						IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DEPOSIT_WITHDRAWAL_jfieldId);
						return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.AccountChange.Cache.Category> (__ret, JniHandleOwnership.TransferLocalRef);
					}
				}

				static IntPtr INVOICE_jfieldId;

				// Metadata.xml XPath field reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='AccountChange.Cache.Category']/field[@name='INVOICE']"
				[Register ("INVOICE")]
				public static global::Com.Coinbase.Api.Entity.AccountChange.Cache.Category Invoice {
					get {
						if (INVOICE_jfieldId == IntPtr.Zero)
							INVOICE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INVOICE", "Lcom/coinbase/api/entity/AccountChange$Cache$Category;");
						IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INVOICE_jfieldId);
						return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.AccountChange.Cache.Category> (__ret, JniHandleOwnership.TransferLocalRef);
					}
				}

				static IntPtr MISPAYMENT_REFUND_jfieldId;

				// Metadata.xml XPath field reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='AccountChange.Cache.Category']/field[@name='MISPAYMENT_REFUND']"
				[Register ("MISPAYMENT_REFUND")]
				public static global::Com.Coinbase.Api.Entity.AccountChange.Cache.Category MispaymentRefund {
					get {
						if (MISPAYMENT_REFUND_jfieldId == IntPtr.Zero)
							MISPAYMENT_REFUND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MISPAYMENT_REFUND", "Lcom/coinbase/api/entity/AccountChange$Cache$Category;");
						IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MISPAYMENT_REFUND_jfieldId);
						return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.AccountChange.Cache.Category> (__ret, JniHandleOwnership.TransferLocalRef);
					}
				}

				static IntPtr ORDER_jfieldId;

				// Metadata.xml XPath field reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='AccountChange.Cache.Category']/field[@name='ORDER']"
				[Register ("ORDER")]
				public static global::Com.Coinbase.Api.Entity.AccountChange.Cache.Category Order {
					get {
						if (ORDER_jfieldId == IntPtr.Zero)
							ORDER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ORDER", "Lcom/coinbase/api/entity/AccountChange$Cache$Category;");
						IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ORDER_jfieldId);
						return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.AccountChange.Cache.Category> (__ret, JniHandleOwnership.TransferLocalRef);
					}
				}

				static IntPtr ORDER_REFUND_jfieldId;

				// Metadata.xml XPath field reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='AccountChange.Cache.Category']/field[@name='ORDER_REFUND']"
				[Register ("ORDER_REFUND")]
				public static global::Com.Coinbase.Api.Entity.AccountChange.Cache.Category OrderRefund {
					get {
						if (ORDER_REFUND_jfieldId == IntPtr.Zero)
							ORDER_REFUND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ORDER_REFUND", "Lcom/coinbase/api/entity/AccountChange$Cache$Category;");
						IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ORDER_REFUND_jfieldId);
						return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.AccountChange.Cache.Category> (__ret, JniHandleOwnership.TransferLocalRef);
					}
				}

				static IntPtr PAYMENT_REQUEST_jfieldId;

				// Metadata.xml XPath field reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='AccountChange.Cache.Category']/field[@name='PAYMENT_REQUEST']"
				[Register ("PAYMENT_REQUEST")]
				public static global::Com.Coinbase.Api.Entity.AccountChange.Cache.Category PaymentRequest {
					get {
						if (PAYMENT_REQUEST_jfieldId == IntPtr.Zero)
							PAYMENT_REQUEST_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PAYMENT_REQUEST", "Lcom/coinbase/api/entity/AccountChange$Cache$Category;");
						IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PAYMENT_REQUEST_jfieldId);
						return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.AccountChange.Cache.Category> (__ret, JniHandleOwnership.TransferLocalRef);
					}
				}

				static IntPtr REQUEST_jfieldId;

				// Metadata.xml XPath field reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='AccountChange.Cache.Category']/field[@name='REQUEST']"
				[Register ("REQUEST")]
				public static global::Com.Coinbase.Api.Entity.AccountChange.Cache.Category Request {
					get {
						if (REQUEST_jfieldId == IntPtr.Zero)
							REQUEST_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "REQUEST", "Lcom/coinbase/api/entity/AccountChange$Cache$Category;");
						IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, REQUEST_jfieldId);
						return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.AccountChange.Cache.Category> (__ret, JniHandleOwnership.TransferLocalRef);
					}
				}

				static IntPtr TRANSACTION_jfieldId;

				// Metadata.xml XPath field reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='AccountChange.Cache.Category']/field[@name='TRANSACTION']"
				[Register ("TRANSACTION")]
				public static global::Com.Coinbase.Api.Entity.AccountChange.Cache.Category Transaction {
					get {
						if (TRANSACTION_jfieldId == IntPtr.Zero)
							TRANSACTION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TRANSACTION", "Lcom/coinbase/api/entity/AccountChange$Cache$Category;");
						IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TRANSACTION_jfieldId);
						return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.AccountChange.Cache.Category> (__ret, JniHandleOwnership.TransferLocalRef);
					}
				}

				static IntPtr TRANSFER_jfieldId;

				// Metadata.xml XPath field reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='AccountChange.Cache.Category']/field[@name='TRANSFER']"
				[Register ("TRANSFER")]
				public static global::Com.Coinbase.Api.Entity.AccountChange.Cache.Category Transfer {
					get {
						if (TRANSFER_jfieldId == IntPtr.Zero)
							TRANSFER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TRANSFER", "Lcom/coinbase/api/entity/AccountChange$Cache$Category;");
						IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TRANSFER_jfieldId);
						return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.AccountChange.Cache.Category> (__ret, JniHandleOwnership.TransferLocalRef);
					}
				}

				static IntPtr TRANSFER_MONEY_jfieldId;

				// Metadata.xml XPath field reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='AccountChange.Cache.Category']/field[@name='TRANSFER_MONEY']"
				[Register ("TRANSFER_MONEY")]
				public static global::Com.Coinbase.Api.Entity.AccountChange.Cache.Category TransferMoney {
					get {
						if (TRANSFER_MONEY_jfieldId == IntPtr.Zero)
							TRANSFER_MONEY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TRANSFER_MONEY", "Lcom/coinbase/api/entity/AccountChange$Cache$Category;");
						IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TRANSFER_MONEY_jfieldId);
						return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.AccountChange.Cache.Category> (__ret, JniHandleOwnership.TransferLocalRef);
					}
				}

				static IntPtr VAULT_WITHDRAWAL_jfieldId;

				// Metadata.xml XPath field reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='AccountChange.Cache.Category']/field[@name='VAULT_WITHDRAWAL']"
				[Register ("VAULT_WITHDRAWAL")]
				public static global::Com.Coinbase.Api.Entity.AccountChange.Cache.Category VaultWithdrawal {
					get {
						if (VAULT_WITHDRAWAL_jfieldId == IntPtr.Zero)
							VAULT_WITHDRAWAL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VAULT_WITHDRAWAL", "Lcom/coinbase/api/entity/AccountChange$Cache$Category;");
						IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VAULT_WITHDRAWAL_jfieldId);
						return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.AccountChange.Cache.Category> (__ret, JniHandleOwnership.TransferLocalRef);
					}
				}
				internal static IntPtr java_class_handle;
				internal static IntPtr class_ref {
					get {
						return JNIEnv.FindClass ("com/coinbase/api/entity/AccountChange$Cache$Category", ref java_class_handle);
					}
				}

				protected override IntPtr ThresholdClass {
					get { return class_ref; }
				}

				protected override global::System.Type ThresholdType {
					get { return typeof (Category); }
				}

				internal Category (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

				static IntPtr id_create_Ljava_lang_String_;
				// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='AccountChange.Cache.Category']/method[@name='create' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("create", "(Ljava/lang/String;)Lcom/coinbase/api/entity/AccountChange$Cache$Category;", "")]
				public static unsafe global::Com.Coinbase.Api.Entity.AccountChange.Cache.Category Create (string p0)
				{
					if (id_create_Ljava_lang_String_ == IntPtr.Zero)
						id_create_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "create", "(Ljava/lang/String;)Lcom/coinbase/api/entity/AccountChange$Cache$Category;");
					IntPtr native_p0 = JNIEnv.NewString (p0);
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (native_p0);
						global::Com.Coinbase.Api.Entity.AccountChange.Cache.Category __ret = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.AccountChange.Cache.Category> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
						return __ret;
					} finally {
						JNIEnv.DeleteLocalRef (native_p0);
					}
				}

				static IntPtr id_valueOf_Ljava_lang_String_;
				// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='AccountChange.Cache.Category']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("valueOf", "(Ljava/lang/String;)Lcom/coinbase/api/entity/AccountChange$Cache$Category;", "")]
				public static unsafe global::Com.Coinbase.Api.Entity.AccountChange.Cache.Category ValueOf (string p0)
				{
					if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
						id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/coinbase/api/entity/AccountChange$Cache$Category;");
					IntPtr native_p0 = JNIEnv.NewString (p0);
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (native_p0);
						global::Com.Coinbase.Api.Entity.AccountChange.Cache.Category __ret = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.AccountChange.Cache.Category> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
						return __ret;
					} finally {
						JNIEnv.DeleteLocalRef (native_p0);
					}
				}

				static IntPtr id_values;
				// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='AccountChange.Cache.Category']/method[@name='values' and count(parameter)=0]"
				[Register ("values", "()[Lcom/coinbase/api/entity/AccountChange$Cache$Category;", "")]
				public static unsafe global::Com.Coinbase.Api.Entity.AccountChange.Cache.Category[] Values ()
				{
					if (id_values == IntPtr.Zero)
						id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/coinbase/api/entity/AccountChange$Cache$Category;");
					try {
						return (global::Com.Coinbase.Api.Entity.AccountChange.Cache.Category[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Coinbase.Api.Entity.AccountChange.Cache.Category));
					} finally {
					}
				}

			}

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/coinbase/api/entity/AccountChange$Cache", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Cache); }
			}

			protected Cache (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='AccountChange.Cache']/constructor[@name='AccountChange.Cache' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Cache ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (Cache)) {
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

			static Delegate cb_getOtherAccount;
#pragma warning disable 0169
			static Delegate GetGetOtherAccountHandler ()
			{
				if (cb_getOtherAccount == null)
					cb_getOtherAccount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOtherAccount);
				return cb_getOtherAccount;
			}

			static IntPtr n_GetOtherAccount (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Coinbase.Api.Entity.AccountChange.Cache __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.AccountChange.Cache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.OtherAccount);
			}
#pragma warning restore 0169

			static Delegate cb_setOtherAccount_Lcom_coinbase_api_entity_Account_;
#pragma warning disable 0169
			static Delegate GetSetOtherAccount_Lcom_coinbase_api_entity_Account_Handler ()
			{
				if (cb_setOtherAccount_Lcom_coinbase_api_entity_Account_ == null)
					cb_setOtherAccount_Lcom_coinbase_api_entity_Account_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOtherAccount_Lcom_coinbase_api_entity_Account_);
				return cb_setOtherAccount_Lcom_coinbase_api_entity_Account_;
			}

			static void n_SetOtherAccount_Lcom_coinbase_api_entity_Account_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Coinbase.Api.Entity.AccountChange.Cache __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.AccountChange.Cache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Coinbase.Api.Entity.Account p0 = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Account> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OtherAccount = p0;
			}
#pragma warning restore 0169

			static IntPtr id_getOtherAccount;
			static IntPtr id_setOtherAccount_Lcom_coinbase_api_entity_Account_;
			public virtual unsafe global::Com.Coinbase.Api.Entity.Account OtherAccount {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='AccountChange.Cache']/method[@name='getOtherAccount' and count(parameter)=0]"
				[Register ("getOtherAccount", "()Lcom/coinbase/api/entity/Account;", "GetGetOtherAccountHandler")]
				get {
					if (id_getOtherAccount == IntPtr.Zero)
						id_getOtherAccount = JNIEnv.GetMethodID (class_ref, "getOtherAccount", "()Lcom/coinbase/api/entity/Account;");
					try {

						if (GetType () == ThresholdType)
							return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Account> (JNIEnv.CallObjectMethod  (Handle, id_getOtherAccount), JniHandleOwnership.TransferLocalRef);
						else
							return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Account> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOtherAccount", "()Lcom/coinbase/api/entity/Account;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='AccountChange.Cache']/method[@name='setOtherAccount' and count(parameter)=1 and parameter[1][@type='com.coinbase.api.entity.Account']]"
				[Register ("setOtherAccount", "(Lcom/coinbase/api/entity/Account;)V", "GetSetOtherAccount_Lcom_coinbase_api_entity_Account_Handler")]
				set {
					if (id_setOtherAccount_Lcom_coinbase_api_entity_Account_ == IntPtr.Zero)
						id_setOtherAccount_Lcom_coinbase_api_entity_Account_ = JNIEnv.GetMethodID (class_ref, "setOtherAccount", "(Lcom/coinbase/api/entity/Account;)V");
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (value);

						if (GetType () == ThresholdType)
							JNIEnv.CallVoidMethod  (Handle, id_setOtherAccount_Lcom_coinbase_api_entity_Account_, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOtherAccount", "(Lcom/coinbase/api/entity/Account;)V"), __args);
					} finally {
					}
				}
			}

			static Delegate cb_getOtherUser;
#pragma warning disable 0169
			static Delegate GetGetOtherUserHandler ()
			{
				if (cb_getOtherUser == null)
					cb_getOtherUser = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOtherUser);
				return cb_getOtherUser;
			}

			static IntPtr n_GetOtherUser (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Coinbase.Api.Entity.AccountChange.Cache __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.AccountChange.Cache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.OtherUser);
			}
#pragma warning restore 0169

			static Delegate cb_setOtherUser_Lcom_coinbase_api_entity_User_;
#pragma warning disable 0169
			static Delegate GetSetOtherUser_Lcom_coinbase_api_entity_User_Handler ()
			{
				if (cb_setOtherUser_Lcom_coinbase_api_entity_User_ == null)
					cb_setOtherUser_Lcom_coinbase_api_entity_User_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOtherUser_Lcom_coinbase_api_entity_User_);
				return cb_setOtherUser_Lcom_coinbase_api_entity_User_;
			}

			static void n_SetOtherUser_Lcom_coinbase_api_entity_User_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Coinbase.Api.Entity.AccountChange.Cache __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.AccountChange.Cache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Coinbase.Api.Entity.User p0 = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.User> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OtherUser = p0;
			}
#pragma warning restore 0169

			static IntPtr id_getOtherUser;
			static IntPtr id_setOtherUser_Lcom_coinbase_api_entity_User_;
			public virtual unsafe global::Com.Coinbase.Api.Entity.User OtherUser {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='AccountChange.Cache']/method[@name='getOtherUser' and count(parameter)=0]"
				[Register ("getOtherUser", "()Lcom/coinbase/api/entity/User;", "GetGetOtherUserHandler")]
				get {
					if (id_getOtherUser == IntPtr.Zero)
						id_getOtherUser = JNIEnv.GetMethodID (class_ref, "getOtherUser", "()Lcom/coinbase/api/entity/User;");
					try {

						if (GetType () == ThresholdType)
							return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.User> (JNIEnv.CallObjectMethod  (Handle, id_getOtherUser), JniHandleOwnership.TransferLocalRef);
						else
							return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.User> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOtherUser", "()Lcom/coinbase/api/entity/User;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='AccountChange.Cache']/method[@name='setOtherUser' and count(parameter)=1 and parameter[1][@type='com.coinbase.api.entity.User']]"
				[Register ("setOtherUser", "(Lcom/coinbase/api/entity/User;)V", "GetSetOtherUser_Lcom_coinbase_api_entity_User_Handler")]
				set {
					if (id_setOtherUser_Lcom_coinbase_api_entity_User_ == IntPtr.Zero)
						id_setOtherUser_Lcom_coinbase_api_entity_User_ = JNIEnv.GetMethodID (class_ref, "setOtherUser", "(Lcom/coinbase/api/entity/User;)V");
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (value);

						if (GetType () == ThresholdType)
							JNIEnv.CallVoidMethod  (Handle, id_setOtherUser_Lcom_coinbase_api_entity_User_, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOtherUser", "(Lcom/coinbase/api/entity/User;)V"), __args);
					} finally {
					}
				}
			}

			static Delegate cb_getPaymentMethod;
#pragma warning disable 0169
			static Delegate GetGetPaymentMethodHandler ()
			{
				if (cb_getPaymentMethod == null)
					cb_getPaymentMethod = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPaymentMethod);
				return cb_getPaymentMethod;
			}

			static IntPtr n_GetPaymentMethod (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Coinbase.Api.Entity.AccountChange.Cache __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.AccountChange.Cache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.PaymentMethod);
			}
#pragma warning restore 0169

			static Delegate cb_setPaymentMethod_Lcom_coinbase_api_entity_PaymentMethod_;
#pragma warning disable 0169
			static Delegate GetSetPaymentMethod_Lcom_coinbase_api_entity_PaymentMethod_Handler ()
			{
				if (cb_setPaymentMethod_Lcom_coinbase_api_entity_PaymentMethod_ == null)
					cb_setPaymentMethod_Lcom_coinbase_api_entity_PaymentMethod_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPaymentMethod_Lcom_coinbase_api_entity_PaymentMethod_);
				return cb_setPaymentMethod_Lcom_coinbase_api_entity_PaymentMethod_;
			}

			static void n_SetPaymentMethod_Lcom_coinbase_api_entity_PaymentMethod_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Coinbase.Api.Entity.AccountChange.Cache __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.AccountChange.Cache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Coinbase.Api.Entity.PaymentMethod p0 = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.PaymentMethod> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.PaymentMethod = p0;
			}
#pragma warning restore 0169

			static IntPtr id_getPaymentMethod;
			static IntPtr id_setPaymentMethod_Lcom_coinbase_api_entity_PaymentMethod_;
			public virtual unsafe global::Com.Coinbase.Api.Entity.PaymentMethod PaymentMethod {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='AccountChange.Cache']/method[@name='getPaymentMethod' and count(parameter)=0]"
				[Register ("getPaymentMethod", "()Lcom/coinbase/api/entity/PaymentMethod;", "GetGetPaymentMethodHandler")]
				get {
					if (id_getPaymentMethod == IntPtr.Zero)
						id_getPaymentMethod = JNIEnv.GetMethodID (class_ref, "getPaymentMethod", "()Lcom/coinbase/api/entity/PaymentMethod;");
					try {

						if (GetType () == ThresholdType)
							return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.PaymentMethod> (JNIEnv.CallObjectMethod  (Handle, id_getPaymentMethod), JniHandleOwnership.TransferLocalRef);
						else
							return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.PaymentMethod> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPaymentMethod", "()Lcom/coinbase/api/entity/PaymentMethod;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='AccountChange.Cache']/method[@name='setPaymentMethod' and count(parameter)=1 and parameter[1][@type='com.coinbase.api.entity.PaymentMethod']]"
				[Register ("setPaymentMethod", "(Lcom/coinbase/api/entity/PaymentMethod;)V", "GetSetPaymentMethod_Lcom_coinbase_api_entity_PaymentMethod_Handler")]
				set {
					if (id_setPaymentMethod_Lcom_coinbase_api_entity_PaymentMethod_ == IntPtr.Zero)
						id_setPaymentMethod_Lcom_coinbase_api_entity_PaymentMethod_ = JNIEnv.GetMethodID (class_ref, "setPaymentMethod", "(Lcom/coinbase/api/entity/PaymentMethod;)V");
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (value);

						if (GetType () == ThresholdType)
							JNIEnv.CallVoidMethod  (Handle, id_setPaymentMethod_Lcom_coinbase_api_entity_PaymentMethod_, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPaymentMethod", "(Lcom/coinbase/api/entity/PaymentMethod;)V"), __args);
					} finally {
					}
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
				global::Com.Coinbase.Api.Entity.AccountChange.Cache __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.AccountChange.Cache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Status);
			}
#pragma warning restore 0169

			static Delegate cb_setStatus_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetStatus_Ljava_lang_String_Handler ()
			{
				if (cb_setStatus_Ljava_lang_String_ == null)
					cb_setStatus_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetStatus_Ljava_lang_String_);
				return cb_setStatus_Ljava_lang_String_;
			}

			static void n_SetStatus_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Coinbase.Api.Entity.AccountChange.Cache __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.AccountChange.Cache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.Status = p0;
			}
#pragma warning restore 0169

			static IntPtr id_getStatus;
			static IntPtr id_setStatus_Ljava_lang_String_;
			public virtual unsafe string Status {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='AccountChange.Cache']/method[@name='getStatus' and count(parameter)=0]"
				[Register ("getStatus", "()Ljava/lang/String;", "GetGetStatusHandler")]
				get {
					if (id_getStatus == IntPtr.Zero)
						id_getStatus = JNIEnv.GetMethodID (class_ref, "getStatus", "()Ljava/lang/String;");
					try {

						if (GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getStatus), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStatus", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='AccountChange.Cache']/method[@name='setStatus' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("setStatus", "(Ljava/lang/String;)V", "GetSetStatus_Ljava_lang_String_Handler")]
				set {
					if (id_setStatus_Ljava_lang_String_ == IntPtr.Zero)
						id_setStatus_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setStatus", "(Ljava/lang/String;)V");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (native_value);

						if (GetType () == ThresholdType)
							JNIEnv.CallVoidMethod  (Handle, id_setStatus_Ljava_lang_String_, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setStatus", "(Ljava/lang/String;)V"), __args);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static Delegate cb_getCategory;
#pragma warning disable 0169
			static Delegate GetGetCategoryHandler ()
			{
				if (cb_getCategory == null)
					cb_getCategory = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCategory);
				return cb_getCategory;
			}

			static IntPtr n_GetCategory (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Coinbase.Api.Entity.AccountChange.Cache __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.AccountChange.Cache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.GetCategory ());
			}
#pragma warning restore 0169

			static IntPtr id_getCategory;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='AccountChange.Cache']/method[@name='getCategory' and count(parameter)=0]"
			[Register ("getCategory", "()Lcom/coinbase/api/entity/AccountChange$Cache$Category;", "GetGetCategoryHandler")]
			public virtual unsafe global::Com.Coinbase.Api.Entity.AccountChange.Cache.Category GetCategory ()
			{
				if (id_getCategory == IntPtr.Zero)
					id_getCategory = JNIEnv.GetMethodID (class_ref, "getCategory", "()Lcom/coinbase/api/entity/AccountChange$Cache$Category;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.AccountChange.Cache.Category> (JNIEnv.CallObjectMethod  (Handle, id_getCategory), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.AccountChange.Cache.Category> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCategory", "()Lcom/coinbase/api/entity/AccountChange$Cache$Category;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_isFiat;
#pragma warning disable 0169
			static Delegate GetIsFiatHandler ()
			{
				if (cb_isFiat == null)
					cb_isFiat = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_IsFiat);
				return cb_isFiat;
			}

			static IntPtr n_IsFiat (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Coinbase.Api.Entity.AccountChange.Cache __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.AccountChange.Cache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.IsFiat ());
			}
#pragma warning restore 0169

			static IntPtr id_isFiat;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='AccountChange.Cache']/method[@name='isFiat' and count(parameter)=0]"
			[Register ("isFiat", "()Ljava/lang/Boolean;", "GetIsFiatHandler")]
			public virtual unsafe global::Java.Lang.Boolean IsFiat ()
			{
				if (id_isFiat == IntPtr.Zero)
					id_isFiat = JNIEnv.GetMethodID (class_ref, "isFiat", "()Ljava/lang/Boolean;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallObjectMethod  (Handle, id_isFiat), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isFiat", "()Ljava/lang/Boolean;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_isNotesPresent;
#pragma warning disable 0169
			static Delegate GetIsNotesPresentHandler ()
			{
				if (cb_isNotesPresent == null)
					cb_isNotesPresent = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_IsNotesPresent);
				return cb_isNotesPresent;
			}

			static IntPtr n_IsNotesPresent (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Coinbase.Api.Entity.AccountChange.Cache __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.AccountChange.Cache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.IsNotesPresent ());
			}
#pragma warning restore 0169

			static IntPtr id_isNotesPresent;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='AccountChange.Cache']/method[@name='isNotesPresent' and count(parameter)=0]"
			[Register ("isNotesPresent", "()Ljava/lang/Boolean;", "GetIsNotesPresentHandler")]
			public virtual unsafe global::Java.Lang.Boolean IsNotesPresent ()
			{
				if (id_isNotesPresent == IntPtr.Zero)
					id_isNotesPresent = JNIEnv.GetMethodID (class_ref, "isNotesPresent", "()Ljava/lang/Boolean;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallObjectMethod  (Handle, id_isNotesPresent), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isNotesPresent", "()Ljava/lang/Boolean;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setCategory_Lcom_coinbase_api_entity_AccountChange_Cache_Category_;
#pragma warning disable 0169
			static Delegate GetSetCategory_Lcom_coinbase_api_entity_AccountChange_Cache_Category_Handler ()
			{
				if (cb_setCategory_Lcom_coinbase_api_entity_AccountChange_Cache_Category_ == null)
					cb_setCategory_Lcom_coinbase_api_entity_AccountChange_Cache_Category_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCategory_Lcom_coinbase_api_entity_AccountChange_Cache_Category_);
				return cb_setCategory_Lcom_coinbase_api_entity_AccountChange_Cache_Category_;
			}

			static void n_SetCategory_Lcom_coinbase_api_entity_AccountChange_Cache_Category_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Coinbase.Api.Entity.AccountChange.Cache __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.AccountChange.Cache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Coinbase.Api.Entity.AccountChange.Cache.Category p0 = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.AccountChange.Cache.Category> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.SetCategory (p0);
			}
#pragma warning restore 0169

			static IntPtr id_setCategory_Lcom_coinbase_api_entity_AccountChange_Cache_Category_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='AccountChange.Cache']/method[@name='setCategory' and count(parameter)=1 and parameter[1][@type='com.coinbase.api.entity.AccountChange.Cache.Category']]"
			[Register ("setCategory", "(Lcom/coinbase/api/entity/AccountChange$Cache$Category;)V", "GetSetCategory_Lcom_coinbase_api_entity_AccountChange_Cache_Category_Handler")]
			public virtual unsafe void SetCategory (global::Com.Coinbase.Api.Entity.AccountChange.Cache.Category p0)
			{
				if (id_setCategory_Lcom_coinbase_api_entity_AccountChange_Cache_Category_ == IntPtr.Zero)
					id_setCategory_Lcom_coinbase_api_entity_AccountChange_Cache_Category_ = JNIEnv.GetMethodID (class_ref, "setCategory", "(Lcom/coinbase/api/entity/AccountChange$Cache$Category;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setCategory_Lcom_coinbase_api_entity_AccountChange_Cache_Category_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCategory", "(Lcom/coinbase/api/entity/AccountChange$Cache$Category;)V"), __args);
				} finally {
				}
			}

			static Delegate cb_setFiat_Ljava_lang_Boolean_;
#pragma warning disable 0169
			static Delegate GetSetFiat_Ljava_lang_Boolean_Handler ()
			{
				if (cb_setFiat_Ljava_lang_Boolean_ == null)
					cb_setFiat_Ljava_lang_Boolean_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetFiat_Ljava_lang_Boolean_);
				return cb_setFiat_Ljava_lang_Boolean_;
			}

			static void n_SetFiat_Ljava_lang_Boolean_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Coinbase.Api.Entity.AccountChange.Cache __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.AccountChange.Cache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Boolean p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.SetFiat (p0);
			}
#pragma warning restore 0169

			static IntPtr id_setFiat_Ljava_lang_Boolean_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='AccountChange.Cache']/method[@name='setFiat' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
			[Register ("setFiat", "(Ljava/lang/Boolean;)V", "GetSetFiat_Ljava_lang_Boolean_Handler")]
			public virtual unsafe void SetFiat (global::Java.Lang.Boolean p0)
			{
				if (id_setFiat_Ljava_lang_Boolean_ == IntPtr.Zero)
					id_setFiat_Ljava_lang_Boolean_ = JNIEnv.GetMethodID (class_ref, "setFiat", "(Ljava/lang/Boolean;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setFiat_Ljava_lang_Boolean_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFiat", "(Ljava/lang/Boolean;)V"), __args);
				} finally {
				}
			}

			static Delegate cb_setNotesPresent_Ljava_lang_Boolean_;
#pragma warning disable 0169
			static Delegate GetSetNotesPresent_Ljava_lang_Boolean_Handler ()
			{
				if (cb_setNotesPresent_Ljava_lang_Boolean_ == null)
					cb_setNotesPresent_Ljava_lang_Boolean_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetNotesPresent_Ljava_lang_Boolean_);
				return cb_setNotesPresent_Ljava_lang_Boolean_;
			}

			static void n_SetNotesPresent_Ljava_lang_Boolean_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Coinbase.Api.Entity.AccountChange.Cache __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.AccountChange.Cache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Boolean p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.SetNotesPresent (p0);
			}
#pragma warning restore 0169

			static IntPtr id_setNotesPresent_Ljava_lang_Boolean_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='AccountChange.Cache']/method[@name='setNotesPresent' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
			[Register ("setNotesPresent", "(Ljava/lang/Boolean;)V", "GetSetNotesPresent_Ljava_lang_Boolean_Handler")]
			public virtual unsafe void SetNotesPresent (global::Java.Lang.Boolean p0)
			{
				if (id_setNotesPresent_Ljava_lang_Boolean_ == IntPtr.Zero)
					id_setNotesPresent_Ljava_lang_Boolean_ = JNIEnv.GetMethodID (class_ref, "setNotesPresent", "(Ljava/lang/Boolean;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setNotesPresent_Ljava_lang_Boolean_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNotesPresent", "(Ljava/lang/Boolean;)V"), __args);
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/coinbase/api/entity/AccountChange", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AccountChange); }
		}

		protected AccountChange (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='AccountChange']/constructor[@name='AccountChange' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AccountChange ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (AccountChange)) {
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
			global::Com.Coinbase.Api.Entity.AccountChange __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.AccountChange> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Coinbase.Api.Entity.AccountChange __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.AccountChange> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Id = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getId;
		static IntPtr id_setId_Ljava_lang_String_;
		public virtual unsafe string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='AccountChange']/method[@name='getId' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='AccountChange']/method[@name='setId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getTransactionId;
#pragma warning disable 0169
		static Delegate GetGetTransactionIdHandler ()
		{
			if (cb_getTransactionId == null)
				cb_getTransactionId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTransactionId);
			return cb_getTransactionId;
		}

		static IntPtr n_GetTransactionId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.AccountChange __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.AccountChange> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TransactionId);
		}
#pragma warning restore 0169

		static Delegate cb_setTransactionId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTransactionId_Ljava_lang_String_Handler ()
		{
			if (cb_setTransactionId_Ljava_lang_String_ == null)
				cb_setTransactionId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTransactionId_Ljava_lang_String_);
			return cb_setTransactionId_Ljava_lang_String_;
		}

		static void n_SetTransactionId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.AccountChange __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.AccountChange> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TransactionId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTransactionId;
		static IntPtr id_setTransactionId_Ljava_lang_String_;
		public virtual unsafe string TransactionId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='AccountChange']/method[@name='getTransactionId' and count(parameter)=0]"
			[Register ("getTransactionId", "()Ljava/lang/String;", "GetGetTransactionIdHandler")]
			get {
				if (id_getTransactionId == IntPtr.Zero)
					id_getTransactionId = JNIEnv.GetMethodID (class_ref, "getTransactionId", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getTransactionId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTransactionId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='AccountChange']/method[@name='setTransactionId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTransactionId", "(Ljava/lang/String;)V", "GetSetTransactionId_Ljava_lang_String_Handler")]
			set {
				if (id_setTransactionId_Ljava_lang_String_ == IntPtr.Zero)
					id_setTransactionId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTransactionId", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setTransactionId_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTransactionId", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getCache;
#pragma warning disable 0169
		static Delegate GetGetCacheHandler ()
		{
			if (cb_getCache == null)
				cb_getCache = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCache);
			return cb_getCache;
		}

		static IntPtr n_GetCache (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.AccountChange __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.AccountChange> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetCache ());
		}
#pragma warning restore 0169

		static IntPtr id_getCache;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='AccountChange']/method[@name='getCache' and count(parameter)=0]"
		[Register ("getCache", "()Lcom/coinbase/api/entity/AccountChange$Cache;", "GetGetCacheHandler")]
		public virtual unsafe global::Com.Coinbase.Api.Entity.AccountChange.Cache GetCache ()
		{
			if (id_getCache == IntPtr.Zero)
				id_getCache = JNIEnv.GetMethodID (class_ref, "getCache", "()Lcom/coinbase/api/entity/AccountChange$Cache;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.AccountChange.Cache> (JNIEnv.CallObjectMethod  (Handle, id_getCache), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.AccountChange.Cache> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCache", "()Lcom/coinbase/api/entity/AccountChange$Cache;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_isConfirmed;
#pragma warning disable 0169
		static Delegate GetIsConfirmedHandler ()
		{
			if (cb_isConfirmed == null)
				cb_isConfirmed = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_IsConfirmed);
			return cb_isConfirmed;
		}

		static IntPtr n_IsConfirmed (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.AccountChange __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.AccountChange> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IsConfirmed ());
		}
#pragma warning restore 0169

		static IntPtr id_isConfirmed;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='AccountChange']/method[@name='isConfirmed' and count(parameter)=0]"
		[Register ("isConfirmed", "()Ljava/lang/Boolean;", "GetIsConfirmedHandler")]
		public virtual unsafe global::Java.Lang.Boolean IsConfirmed ()
		{
			if (id_isConfirmed == IntPtr.Zero)
				id_isConfirmed = JNIEnv.GetMethodID (class_ref, "isConfirmed", "()Ljava/lang/Boolean;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallObjectMethod  (Handle, id_isConfirmed), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isConfirmed", "()Ljava/lang/Boolean;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setCache_Lcom_coinbase_api_entity_AccountChange_Cache_;
#pragma warning disable 0169
		static Delegate GetSetCache_Lcom_coinbase_api_entity_AccountChange_Cache_Handler ()
		{
			if (cb_setCache_Lcom_coinbase_api_entity_AccountChange_Cache_ == null)
				cb_setCache_Lcom_coinbase_api_entity_AccountChange_Cache_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCache_Lcom_coinbase_api_entity_AccountChange_Cache_);
			return cb_setCache_Lcom_coinbase_api_entity_AccountChange_Cache_;
		}

		static void n_SetCache_Lcom_coinbase_api_entity_AccountChange_Cache_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.AccountChange __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.AccountChange> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Coinbase.Api.Entity.AccountChange.Cache p0 = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.AccountChange.Cache> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetCache (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setCache_Lcom_coinbase_api_entity_AccountChange_Cache_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='AccountChange']/method[@name='setCache' and count(parameter)=1 and parameter[1][@type='com.coinbase.api.entity.AccountChange.Cache']]"
		[Register ("setCache", "(Lcom/coinbase/api/entity/AccountChange$Cache;)V", "GetSetCache_Lcom_coinbase_api_entity_AccountChange_Cache_Handler")]
		public virtual unsafe void SetCache (global::Com.Coinbase.Api.Entity.AccountChange.Cache p0)
		{
			if (id_setCache_Lcom_coinbase_api_entity_AccountChange_Cache_ == IntPtr.Zero)
				id_setCache_Lcom_coinbase_api_entity_AccountChange_Cache_ = JNIEnv.GetMethodID (class_ref, "setCache", "(Lcom/coinbase/api/entity/AccountChange$Cache;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setCache_Lcom_coinbase_api_entity_AccountChange_Cache_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCache", "(Lcom/coinbase/api/entity/AccountChange$Cache;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setConfirmed_Ljava_lang_Boolean_;
#pragma warning disable 0169
		static Delegate GetSetConfirmed_Ljava_lang_Boolean_Handler ()
		{
			if (cb_setConfirmed_Ljava_lang_Boolean_ == null)
				cb_setConfirmed_Ljava_lang_Boolean_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetConfirmed_Ljava_lang_Boolean_);
			return cb_setConfirmed_Ljava_lang_Boolean_;
		}

		static void n_SetConfirmed_Ljava_lang_Boolean_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.AccountChange __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.AccountChange> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Boolean p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetConfirmed (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setConfirmed_Ljava_lang_Boolean_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='AccountChange']/method[@name='setConfirmed' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
		[Register ("setConfirmed", "(Ljava/lang/Boolean;)V", "GetSetConfirmed_Ljava_lang_Boolean_Handler")]
		public virtual unsafe void SetConfirmed (global::Java.Lang.Boolean p0)
		{
			if (id_setConfirmed_Ljava_lang_Boolean_ == IntPtr.Zero)
				id_setConfirmed_Ljava_lang_Boolean_ = JNIEnv.GetMethodID (class_ref, "setConfirmed", "(Ljava/lang/Boolean;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setConfirmed_Ljava_lang_Boolean_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setConfirmed", "(Ljava/lang/Boolean;)V"), __args);
			} finally {
			}
		}

	}
}
