using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Coinbase.Api.Entity {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Request']"
	[global::Android.Runtime.Register ("com/coinbase/api/entity/Request", DoNotGenerateAcw=true)]
	public partial class Request : global::Java.Lang.Object, global::Java.IO.ISerializable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/coinbase/api/entity/Request", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Request); }
		}

		protected Request (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Request']/constructor[@name='Request' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Request ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Request)) {
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

		static Delegate cb_getAccount;
#pragma warning disable 0169
		static Delegate GetGetAccountHandler ()
		{
			if (cb_getAccount == null)
				cb_getAccount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAccount);
			return cb_getAccount;
		}

		static IntPtr n_GetAccount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.Request __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Request> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Account);
		}
#pragma warning restore 0169

		static Delegate cb_setAccount_Lcom_coinbase_api_entity_Account_;
#pragma warning disable 0169
		static Delegate GetSetAccount_Lcom_coinbase_api_entity_Account_Handler ()
		{
			if (cb_setAccount_Lcom_coinbase_api_entity_Account_ == null)
				cb_setAccount_Lcom_coinbase_api_entity_Account_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAccount_Lcom_coinbase_api_entity_Account_);
			return cb_setAccount_Lcom_coinbase_api_entity_Account_;
		}

		static void n_SetAccount_Lcom_coinbase_api_entity_Account_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.Request __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Request> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Coinbase.Api.Entity.Account p0 = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Account> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Account = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAccount;
		static IntPtr id_setAccount_Lcom_coinbase_api_entity_Account_;
		public virtual unsafe global::Com.Coinbase.Api.Entity.Account Account {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Request']/method[@name='getAccount' and count(parameter)=0]"
			[Register ("getAccount", "()Lcom/coinbase/api/entity/Account;", "GetGetAccountHandler")]
			get {
				if (id_getAccount == IntPtr.Zero)
					id_getAccount = JNIEnv.GetMethodID (class_ref, "getAccount", "()Lcom/coinbase/api/entity/Account;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Account> (JNIEnv.CallObjectMethod  (Handle, id_getAccount), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Account> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAccount", "()Lcom/coinbase/api/entity/Account;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Request']/method[@name='setAccount' and count(parameter)=1 and parameter[1][@type='com.coinbase.api.entity.Account']]"
			[Register ("setAccount", "(Lcom/coinbase/api/entity/Account;)V", "GetSetAccount_Lcom_coinbase_api_entity_Account_Handler")]
			set {
				if (id_setAccount_Lcom_coinbase_api_entity_Account_ == IntPtr.Zero)
					id_setAccount_Lcom_coinbase_api_entity_Account_ = JNIEnv.GetMethodID (class_ref, "setAccount", "(Lcom/coinbase/api/entity/Account;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setAccount_Lcom_coinbase_api_entity_Account_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAccount", "(Lcom/coinbase/api/entity/Account;)V"), __args);
				} finally {
				}
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
			global::Com.Coinbase.Api.Entity.Request __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Request> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Coinbase.Api.Entity.Request __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Request> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AccountId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAccountId;
		static IntPtr id_setAccountId_Ljava_lang_String_;
		public virtual unsafe string AccountId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Request']/method[@name='getAccountId' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Request']/method[@name='setAccountId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getAddress;
#pragma warning disable 0169
		static Delegate GetGetAddressHandler ()
		{
			if (cb_getAddress == null)
				cb_getAddress = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAddress);
			return cb_getAddress;
		}

		static IntPtr n_GetAddress (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.Request __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Request> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Address);
		}
#pragma warning restore 0169

		static Delegate cb_setAddress_Lcom_coinbase_api_entity_Address_;
#pragma warning disable 0169
		static Delegate GetSetAddress_Lcom_coinbase_api_entity_Address_Handler ()
		{
			if (cb_setAddress_Lcom_coinbase_api_entity_Address_ == null)
				cb_setAddress_Lcom_coinbase_api_entity_Address_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAddress_Lcom_coinbase_api_entity_Address_);
			return cb_setAddress_Lcom_coinbase_api_entity_Address_;
		}

		static void n_SetAddress_Lcom_coinbase_api_entity_Address_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.Request __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Request> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Coinbase.Api.Entity.Address p0 = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Address> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Address = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAddress;
		static IntPtr id_setAddress_Lcom_coinbase_api_entity_Address_;
		public virtual unsafe global::Com.Coinbase.Api.Entity.Address Address {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Request']/method[@name='getAddress' and count(parameter)=0]"
			[Register ("getAddress", "()Lcom/coinbase/api/entity/Address;", "GetGetAddressHandler")]
			get {
				if (id_getAddress == IntPtr.Zero)
					id_getAddress = JNIEnv.GetMethodID (class_ref, "getAddress", "()Lcom/coinbase/api/entity/Address;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Address> (JNIEnv.CallObjectMethod  (Handle, id_getAddress), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Address> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAddress", "()Lcom/coinbase/api/entity/Address;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Request']/method[@name='setAddress' and count(parameter)=1 and parameter[1][@type='com.coinbase.api.entity.Address']]"
			[Register ("setAddress", "(Lcom/coinbase/api/entity/Address;)V", "GetSetAddress_Lcom_coinbase_api_entity_Address_Handler")]
			set {
				if (id_setAddress_Lcom_coinbase_api_entity_Address_ == IntPtr.Zero)
					id_setAddress_Lcom_coinbase_api_entity_Address_ = JNIEnv.GetMethodID (class_ref, "setAddress", "(Lcom/coinbase/api/entity/Address;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setAddress_Lcom_coinbase_api_entity_Address_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAddress", "(Lcom/coinbase/api/entity/Address;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getApplication;
#pragma warning disable 0169
		static Delegate GetGetApplicationHandler ()
		{
			if (cb_getApplication == null)
				cb_getApplication = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetApplication);
			return cb_getApplication;
		}

		static IntPtr n_GetApplication (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.Request __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Request> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Application);
		}
#pragma warning restore 0169

		static Delegate cb_setApplication_Lcom_coinbase_api_entity_Application_;
#pragma warning disable 0169
		static Delegate GetSetApplication_Lcom_coinbase_api_entity_Application_Handler ()
		{
			if (cb_setApplication_Lcom_coinbase_api_entity_Application_ == null)
				cb_setApplication_Lcom_coinbase_api_entity_Application_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetApplication_Lcom_coinbase_api_entity_Application_);
			return cb_setApplication_Lcom_coinbase_api_entity_Application_;
		}

		static void n_SetApplication_Lcom_coinbase_api_entity_Application_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.Request __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Request> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Coinbase.Api.Entity.Application p0 = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Application> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Application = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getApplication;
		static IntPtr id_setApplication_Lcom_coinbase_api_entity_Application_;
		public virtual unsafe global::Com.Coinbase.Api.Entity.Application Application {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Request']/method[@name='getApplication' and count(parameter)=0]"
			[Register ("getApplication", "()Lcom/coinbase/api/entity/Application;", "GetGetApplicationHandler")]
			get {
				if (id_getApplication == IntPtr.Zero)
					id_getApplication = JNIEnv.GetMethodID (class_ref, "getApplication", "()Lcom/coinbase/api/entity/Application;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Application> (JNIEnv.CallObjectMethod  (Handle, id_getApplication), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Application> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getApplication", "()Lcom/coinbase/api/entity/Application;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Request']/method[@name='setApplication' and count(parameter)=1 and parameter[1][@type='com.coinbase.api.entity.Application']]"
			[Register ("setApplication", "(Lcom/coinbase/api/entity/Application;)V", "GetSetApplication_Lcom_coinbase_api_entity_Application_Handler")]
			set {
				if (id_setApplication_Lcom_coinbase_api_entity_Application_ == IntPtr.Zero)
					id_setApplication_Lcom_coinbase_api_entity_Application_ = JNIEnv.GetMethodID (class_ref, "setApplication", "(Lcom/coinbase/api/entity/Application;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setApplication_Lcom_coinbase_api_entity_Application_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setApplication", "(Lcom/coinbase/api/entity/Application;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getButton;
#pragma warning disable 0169
		static Delegate GetGetButtonHandler ()
		{
			if (cb_getButton == null)
				cb_getButton = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetButton);
			return cb_getButton;
		}

		static IntPtr n_GetButton (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.Request __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Request> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Button);
		}
#pragma warning restore 0169

		static Delegate cb_setButton_Lcom_coinbase_api_entity_Button_;
#pragma warning disable 0169
		static Delegate GetSetButton_Lcom_coinbase_api_entity_Button_Handler ()
		{
			if (cb_setButton_Lcom_coinbase_api_entity_Button_ == null)
				cb_setButton_Lcom_coinbase_api_entity_Button_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetButton_Lcom_coinbase_api_entity_Button_);
			return cb_setButton_Lcom_coinbase_api_entity_Button_;
		}

		static void n_SetButton_Lcom_coinbase_api_entity_Button_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.Request __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Request> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Coinbase.Api.Entity.Button p0 = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Button> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Button = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getButton;
		static IntPtr id_setButton_Lcom_coinbase_api_entity_Button_;
		public virtual unsafe global::Com.Coinbase.Api.Entity.Button Button {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Request']/method[@name='getButton' and count(parameter)=0]"
			[Register ("getButton", "()Lcom/coinbase/api/entity/Button;", "GetGetButtonHandler")]
			get {
				if (id_getButton == IntPtr.Zero)
					id_getButton = JNIEnv.GetMethodID (class_ref, "getButton", "()Lcom/coinbase/api/entity/Button;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Button> (JNIEnv.CallObjectMethod  (Handle, id_getButton), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Button> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getButton", "()Lcom/coinbase/api/entity/Button;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Request']/method[@name='setButton' and count(parameter)=1 and parameter[1][@type='com.coinbase.api.entity.Button']]"
			[Register ("setButton", "(Lcom/coinbase/api/entity/Button;)V", "GetSetButton_Lcom_coinbase_api_entity_Button_Handler")]
			set {
				if (id_setButton_Lcom_coinbase_api_entity_Button_ == IntPtr.Zero)
					id_setButton_Lcom_coinbase_api_entity_Button_ = JNIEnv.GetMethodID (class_ref, "setButton", "(Lcom/coinbase/api/entity/Button;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setButton_Lcom_coinbase_api_entity_Button_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setButton", "(Lcom/coinbase/api/entity/Button;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getClientId;
#pragma warning disable 0169
		static Delegate GetGetClientIdHandler ()
		{
			if (cb_getClientId == null)
				cb_getClientId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetClientId);
			return cb_getClientId;
		}

		static IntPtr n_GetClientId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.Request __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Request> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ClientId);
		}
#pragma warning restore 0169

		static Delegate cb_setClientId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetClientId_Ljava_lang_String_Handler ()
		{
			if (cb_setClientId_Ljava_lang_String_ == null)
				cb_setClientId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetClientId_Ljava_lang_String_);
			return cb_setClientId_Ljava_lang_String_;
		}

		static void n_SetClientId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.Request __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Request> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ClientId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getClientId;
		static IntPtr id_setClientId_Ljava_lang_String_;
		public virtual unsafe string ClientId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Request']/method[@name='getClientId' and count(parameter)=0]"
			[Register ("getClientId", "()Ljava/lang/String;", "GetGetClientIdHandler")]
			get {
				if (id_getClientId == IntPtr.Zero)
					id_getClientId = JNIEnv.GetMethodID (class_ref, "getClientId", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getClientId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getClientId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Request']/method[@name='setClientId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setClientId", "(Ljava/lang/String;)V", "GetSetClientId_Ljava_lang_String_Handler")]
			set {
				if (id_setClientId_Ljava_lang_String_ == IntPtr.Zero)
					id_setClientId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setClientId", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setClientId_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setClientId", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getCommit;
#pragma warning disable 0169
		static Delegate GetGetCommitHandler ()
		{
			if (cb_getCommit == null)
				cb_getCommit = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCommit);
			return cb_getCommit;
		}

		static IntPtr n_GetCommit (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.Request __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Request> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Commit);
		}
#pragma warning restore 0169

		static Delegate cb_setCommit_Ljava_lang_Boolean_;
#pragma warning disable 0169
		static Delegate GetSetCommit_Ljava_lang_Boolean_Handler ()
		{
			if (cb_setCommit_Ljava_lang_Boolean_ == null)
				cb_setCommit_Ljava_lang_Boolean_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCommit_Ljava_lang_Boolean_);
			return cb_setCommit_Ljava_lang_Boolean_;
		}

		static void n_SetCommit_Ljava_lang_Boolean_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.Request __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Request> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Boolean p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Commit = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCommit;
		static IntPtr id_setCommit_Ljava_lang_Boolean_;
		public virtual unsafe global::Java.Lang.Boolean Commit {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Request']/method[@name='getCommit' and count(parameter)=0]"
			[Register ("getCommit", "()Ljava/lang/Boolean;", "GetGetCommitHandler")]
			get {
				if (id_getCommit == IntPtr.Zero)
					id_getCommit = JNIEnv.GetMethodID (class_ref, "getCommit", "()Ljava/lang/Boolean;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallObjectMethod  (Handle, id_getCommit), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCommit", "()Ljava/lang/Boolean;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Request']/method[@name='setCommit' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
			[Register ("setCommit", "(Ljava/lang/Boolean;)V", "GetSetCommit_Ljava_lang_Boolean_Handler")]
			set {
				if (id_setCommit_Ljava_lang_Boolean_ == IntPtr.Zero)
					id_setCommit_Ljava_lang_Boolean_ = JNIEnv.GetMethodID (class_ref, "setCommit", "(Ljava/lang/Boolean;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setCommit_Ljava_lang_Boolean_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCommit", "(Ljava/lang/Boolean;)V"), __args);
				} finally {
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
			global::Com.Coinbase.Api.Entity.Request __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Request> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Coinbase.Api.Entity.Request __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Request> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Currency = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCurrency;
		static IntPtr id_setCurrency_Ljava_lang_String_;
		public virtual unsafe string Currency {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Request']/method[@name='getCurrency' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Request']/method[@name='setCurrency' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getPaymentMethodId;
#pragma warning disable 0169
		static Delegate GetGetPaymentMethodIdHandler ()
		{
			if (cb_getPaymentMethodId == null)
				cb_getPaymentMethodId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPaymentMethodId);
			return cb_getPaymentMethodId;
		}

		static IntPtr n_GetPaymentMethodId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.Request __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Request> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PaymentMethodId);
		}
#pragma warning restore 0169

		static Delegate cb_setPaymentMethodId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetPaymentMethodId_Ljava_lang_String_Handler ()
		{
			if (cb_setPaymentMethodId_Ljava_lang_String_ == null)
				cb_setPaymentMethodId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPaymentMethodId_Ljava_lang_String_);
			return cb_setPaymentMethodId_Ljava_lang_String_;
		}

		static void n_SetPaymentMethodId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.Request __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Request> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PaymentMethodId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getPaymentMethodId;
		static IntPtr id_setPaymentMethodId_Ljava_lang_String_;
		public virtual unsafe string PaymentMethodId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Request']/method[@name='getPaymentMethodId' and count(parameter)=0]"
			[Register ("getPaymentMethodId", "()Ljava/lang/String;", "GetGetPaymentMethodIdHandler")]
			get {
				if (id_getPaymentMethodId == IntPtr.Zero)
					id_getPaymentMethodId = JNIEnv.GetMethodID (class_ref, "getPaymentMethodId", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getPaymentMethodId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPaymentMethodId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Request']/method[@name='setPaymentMethodId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setPaymentMethodId", "(Ljava/lang/String;)V", "GetSetPaymentMethodId_Ljava_lang_String_Handler")]
			set {
				if (id_setPaymentMethodId_Ljava_lang_String_ == IntPtr.Zero)
					id_setPaymentMethodId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setPaymentMethodId", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setPaymentMethodId_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPaymentMethodId", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getQty;
#pragma warning disable 0169
		static Delegate GetGetQtyHandler ()
		{
			if (cb_getQty == null)
				cb_getQty = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetQty);
			return cb_getQty;
		}

		static IntPtr n_GetQty (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.Request __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Request> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Qty);
		}
#pragma warning restore 0169

		static Delegate cb_setQty_Ljava_lang_Double_;
#pragma warning disable 0169
		static Delegate GetSetQty_Ljava_lang_Double_Handler ()
		{
			if (cb_setQty_Ljava_lang_Double_ == null)
				cb_setQty_Ljava_lang_Double_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetQty_Ljava_lang_Double_);
			return cb_setQty_Ljava_lang_Double_;
		}

		static void n_SetQty_Ljava_lang_Double_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.Request __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Request> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Double p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Qty = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getQty;
		static IntPtr id_setQty_Ljava_lang_Double_;
		public virtual unsafe global::Java.Lang.Double Qty {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Request']/method[@name='getQty' and count(parameter)=0]"
			[Register ("getQty", "()Ljava/lang/Double;", "GetGetQtyHandler")]
			get {
				if (id_getQty == IntPtr.Zero)
					id_getQty = JNIEnv.GetMethodID (class_ref, "getQty", "()Ljava/lang/Double;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallObjectMethod  (Handle, id_getQty), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getQty", "()Ljava/lang/Double;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Request']/method[@name='setQty' and count(parameter)=1 and parameter[1][@type='java.lang.Double']]"
			[Register ("setQty", "(Ljava/lang/Double;)V", "GetSetQty_Ljava_lang_Double_Handler")]
			set {
				if (id_setQty_Ljava_lang_Double_ == IntPtr.Zero)
					id_setQty_Ljava_lang_Double_ = JNIEnv.GetMethodID (class_ref, "setQty", "(Ljava/lang/Double;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setQty_Ljava_lang_Double_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setQty", "(Ljava/lang/Double;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getReport;
#pragma warning disable 0169
		static Delegate GetGetReportHandler ()
		{
			if (cb_getReport == null)
				cb_getReport = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetReport);
			return cb_getReport;
		}

		static IntPtr n_GetReport (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.Request __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Request> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Report);
		}
#pragma warning restore 0169

		static Delegate cb_setReport_Lcom_coinbase_api_entity_Report_;
#pragma warning disable 0169
		static Delegate GetSetReport_Lcom_coinbase_api_entity_Report_Handler ()
		{
			if (cb_setReport_Lcom_coinbase_api_entity_Report_ == null)
				cb_setReport_Lcom_coinbase_api_entity_Report_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetReport_Lcom_coinbase_api_entity_Report_);
			return cb_setReport_Lcom_coinbase_api_entity_Report_;
		}

		static void n_SetReport_Lcom_coinbase_api_entity_Report_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.Request __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Request> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Coinbase.Api.Entity.Report p0 = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Report> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Report = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getReport;
		static IntPtr id_setReport_Lcom_coinbase_api_entity_Report_;
		public virtual unsafe global::Com.Coinbase.Api.Entity.Report Report {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Request']/method[@name='getReport' and count(parameter)=0]"
			[Register ("getReport", "()Lcom/coinbase/api/entity/Report;", "GetGetReportHandler")]
			get {
				if (id_getReport == IntPtr.Zero)
					id_getReport = JNIEnv.GetMethodID (class_ref, "getReport", "()Lcom/coinbase/api/entity/Report;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Report> (JNIEnv.CallObjectMethod  (Handle, id_getReport), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Report> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getReport", "()Lcom/coinbase/api/entity/Report;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Request']/method[@name='setReport' and count(parameter)=1 and parameter[1][@type='com.coinbase.api.entity.Report']]"
			[Register ("setReport", "(Lcom/coinbase/api/entity/Report;)V", "GetSetReport_Lcom_coinbase_api_entity_Report_Handler")]
			set {
				if (id_setReport_Lcom_coinbase_api_entity_Report_ == IntPtr.Zero)
					id_setReport_Lcom_coinbase_api_entity_Report_ = JNIEnv.GetMethodID (class_ref, "setReport", "(Lcom/coinbase/api/entity/Report;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setReport_Lcom_coinbase_api_entity_Report_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setReport", "(Lcom/coinbase/api/entity/Report;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getScopes;
#pragma warning disable 0169
		static Delegate GetGetScopesHandler ()
		{
			if (cb_getScopes == null)
				cb_getScopes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetScopes);
			return cb_getScopes;
		}

		static IntPtr n_GetScopes (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.Request __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Request> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Scopes);
		}
#pragma warning restore 0169

		static Delegate cb_setScopes_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetScopes_Ljava_lang_String_Handler ()
		{
			if (cb_setScopes_Ljava_lang_String_ == null)
				cb_setScopes_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetScopes_Ljava_lang_String_);
			return cb_setScopes_Ljava_lang_String_;
		}

		static void n_SetScopes_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.Request __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Request> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Scopes = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getScopes;
		static IntPtr id_setScopes_Ljava_lang_String_;
		public virtual unsafe string Scopes {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Request']/method[@name='getScopes' and count(parameter)=0]"
			[Register ("getScopes", "()Ljava/lang/String;", "GetGetScopesHandler")]
			get {
				if (id_getScopes == IntPtr.Zero)
					id_getScopes = JNIEnv.GetMethodID (class_ref, "getScopes", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getScopes), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getScopes", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Request']/method[@name='setScopes' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setScopes", "(Ljava/lang/String;)V", "GetSetScopes_Ljava_lang_String_Handler")]
			set {
				if (id_setScopes_Ljava_lang_String_ == IntPtr.Zero)
					id_setScopes_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setScopes", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setScopes_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setScopes", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getTokenId;
#pragma warning disable 0169
		static Delegate GetGetTokenIdHandler ()
		{
			if (cb_getTokenId == null)
				cb_getTokenId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTokenId);
			return cb_getTokenId;
		}

		static IntPtr n_GetTokenId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.Request __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Request> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TokenId);
		}
#pragma warning restore 0169

		static Delegate cb_setTokenId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTokenId_Ljava_lang_String_Handler ()
		{
			if (cb_setTokenId_Ljava_lang_String_ == null)
				cb_setTokenId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTokenId_Ljava_lang_String_);
			return cb_setTokenId_Ljava_lang_String_;
		}

		static void n_SetTokenId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.Request __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Request> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TokenId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTokenId;
		static IntPtr id_setTokenId_Ljava_lang_String_;
		public virtual unsafe string TokenId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Request']/method[@name='getTokenId' and count(parameter)=0]"
			[Register ("getTokenId", "()Ljava/lang/String;", "GetGetTokenIdHandler")]
			get {
				if (id_getTokenId == IntPtr.Zero)
					id_getTokenId = JNIEnv.GetMethodID (class_ref, "getTokenId", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getTokenId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTokenId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Request']/method[@name='setTokenId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTokenId", "(Ljava/lang/String;)V", "GetSetTokenId_Ljava_lang_String_Handler")]
			set {
				if (id_setTokenId_Ljava_lang_String_ == IntPtr.Zero)
					id_setTokenId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTokenId", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setTokenId_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTokenId", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getTransaction;
#pragma warning disable 0169
		static Delegate GetGetTransactionHandler ()
		{
			if (cb_getTransaction == null)
				cb_getTransaction = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTransaction);
			return cb_getTransaction;
		}

		static IntPtr n_GetTransaction (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.Request __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Request> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Transaction);
		}
#pragma warning restore 0169

		static Delegate cb_setTransaction_Lcom_coinbase_api_entity_Transaction_;
#pragma warning disable 0169
		static Delegate GetSetTransaction_Lcom_coinbase_api_entity_Transaction_Handler ()
		{
			if (cb_setTransaction_Lcom_coinbase_api_entity_Transaction_ == null)
				cb_setTransaction_Lcom_coinbase_api_entity_Transaction_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTransaction_Lcom_coinbase_api_entity_Transaction_);
			return cb_setTransaction_Lcom_coinbase_api_entity_Transaction_;
		}

		static void n_SetTransaction_Lcom_coinbase_api_entity_Transaction_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.Request __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Request> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Coinbase.Api.Entity.Transaction p0 = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Transaction> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Transaction = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTransaction;
		static IntPtr id_setTransaction_Lcom_coinbase_api_entity_Transaction_;
		public virtual unsafe global::Com.Coinbase.Api.Entity.Transaction Transaction {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Request']/method[@name='getTransaction' and count(parameter)=0]"
			[Register ("getTransaction", "()Lcom/coinbase/api/entity/Transaction;", "GetGetTransactionHandler")]
			get {
				if (id_getTransaction == IntPtr.Zero)
					id_getTransaction = JNIEnv.GetMethodID (class_ref, "getTransaction", "()Lcom/coinbase/api/entity/Transaction;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Transaction> (JNIEnv.CallObjectMethod  (Handle, id_getTransaction), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Transaction> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTransaction", "()Lcom/coinbase/api/entity/Transaction;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Request']/method[@name='setTransaction' and count(parameter)=1 and parameter[1][@type='com.coinbase.api.entity.Transaction']]"
			[Register ("setTransaction", "(Lcom/coinbase/api/entity/Transaction;)V", "GetSetTransaction_Lcom_coinbase_api_entity_Transaction_Handler")]
			set {
				if (id_setTransaction_Lcom_coinbase_api_entity_Transaction_ == IntPtr.Zero)
					id_setTransaction_Lcom_coinbase_api_entity_Transaction_ = JNIEnv.GetMethodID (class_ref, "setTransaction", "(Lcom/coinbase/api/entity/Transaction;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setTransaction_Lcom_coinbase_api_entity_Transaction_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTransaction", "(Lcom/coinbase/api/entity/Transaction;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getUser;
#pragma warning disable 0169
		static Delegate GetGetUserHandler ()
		{
			if (cb_getUser == null)
				cb_getUser = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUser);
			return cb_getUser;
		}

		static IntPtr n_GetUser (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.Request __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Request> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.User);
		}
#pragma warning restore 0169

		static Delegate cb_setUser_Lcom_coinbase_api_entity_User_;
#pragma warning disable 0169
		static Delegate GetSetUser_Lcom_coinbase_api_entity_User_Handler ()
		{
			if (cb_setUser_Lcom_coinbase_api_entity_User_ == null)
				cb_setUser_Lcom_coinbase_api_entity_User_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetUser_Lcom_coinbase_api_entity_User_);
			return cb_setUser_Lcom_coinbase_api_entity_User_;
		}

		static void n_SetUser_Lcom_coinbase_api_entity_User_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.Request __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Request> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Coinbase.Api.Entity.User p0 = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.User> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.User = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getUser;
		static IntPtr id_setUser_Lcom_coinbase_api_entity_User_;
		public virtual unsafe global::Com.Coinbase.Api.Entity.User User {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Request']/method[@name='getUser' and count(parameter)=0]"
			[Register ("getUser", "()Lcom/coinbase/api/entity/User;", "GetGetUserHandler")]
			get {
				if (id_getUser == IntPtr.Zero)
					id_getUser = JNIEnv.GetMethodID (class_ref, "getUser", "()Lcom/coinbase/api/entity/User;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.User> (JNIEnv.CallObjectMethod  (Handle, id_getUser), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.User> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUser", "()Lcom/coinbase/api/entity/User;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Request']/method[@name='setUser' and count(parameter)=1 and parameter[1][@type='com.coinbase.api.entity.User']]"
			[Register ("setUser", "(Lcom/coinbase/api/entity/User;)V", "GetSetUser_Lcom_coinbase_api_entity_User_Handler")]
			set {
				if (id_setUser_Lcom_coinbase_api_entity_User_ == IntPtr.Zero)
					id_setUser_Lcom_coinbase_api_entity_User_ = JNIEnv.GetMethodID (class_ref, "setUser", "(Lcom/coinbase/api/entity/User;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setUser_Lcom_coinbase_api_entity_User_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUser", "(Lcom/coinbase/api/entity/User;)V"), __args);
				} finally {
				}
			}
		}

	}
}
