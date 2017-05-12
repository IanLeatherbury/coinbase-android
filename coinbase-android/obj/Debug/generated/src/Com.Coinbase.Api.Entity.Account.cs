using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Coinbase.Api.Entity {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Account']"
	[global::Android.Runtime.Register ("com/coinbase/api/entity/Account", DoNotGenerateAcw=true)]
	public partial class Account : global::Java.Lang.Object, global::Java.IO.ISerializable {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Account.Type']"
		[global::Android.Runtime.Register ("com/coinbase/api/entity/Account$Type", DoNotGenerateAcw=true)]
		public sealed partial class Type : global::Java.Lang.Enum {


			static IntPtr FIAT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Account.Type']/field[@name='FIAT']"
			[Register ("FIAT")]
			public static global::Com.Coinbase.Api.Entity.Account.Type Fiat {
				get {
					if (FIAT_jfieldId == IntPtr.Zero)
						FIAT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FIAT", "Lcom/coinbase/api/entity/Account$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FIAT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Account.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr MULTISIG_VAULT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Account.Type']/field[@name='MULTISIG_VAULT']"
			[Register ("MULTISIG_VAULT")]
			public static global::Com.Coinbase.Api.Entity.Account.Type MultisigVault {
				get {
					if (MULTISIG_VAULT_jfieldId == IntPtr.Zero)
						MULTISIG_VAULT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MULTISIG_VAULT", "Lcom/coinbase/api/entity/Account$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MULTISIG_VAULT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Account.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr MULTISIG_WALLET_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Account.Type']/field[@name='MULTISIG_WALLET']"
			[Register ("MULTISIG_WALLET")]
			public static global::Com.Coinbase.Api.Entity.Account.Type MultisigWallet {
				get {
					if (MULTISIG_WALLET_jfieldId == IntPtr.Zero)
						MULTISIG_WALLET_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MULTISIG_WALLET", "Lcom/coinbase/api/entity/Account$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MULTISIG_WALLET_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Account.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VAULT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Account.Type']/field[@name='VAULT']"
			[Register ("VAULT")]
			public static global::Com.Coinbase.Api.Entity.Account.Type Vault {
				get {
					if (VAULT_jfieldId == IntPtr.Zero)
						VAULT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VAULT", "Lcom/coinbase/api/entity/Account$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VAULT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Account.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr WALLET_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Account.Type']/field[@name='WALLET']"
			[Register ("WALLET")]
			public static global::Com.Coinbase.Api.Entity.Account.Type Wallet {
				get {
					if (WALLET_jfieldId == IntPtr.Zero)
						WALLET_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "WALLET", "Lcom/coinbase/api/entity/Account$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, WALLET_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Account.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/coinbase/api/entity/Account$Type", ref java_class_handle);
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Account.Type']/method[@name='create' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("create", "(Ljava/lang/String;)Lcom/coinbase/api/entity/Account$Type;", "")]
			public static unsafe global::Com.Coinbase.Api.Entity.Account.Type Create (string p0)
			{
				if (id_create_Ljava_lang_String_ == IntPtr.Zero)
					id_create_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "create", "(Ljava/lang/String;)Lcom/coinbase/api/entity/Account$Type;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Coinbase.Api.Entity.Account.Type __ret = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Account.Type> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Account.Type']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/coinbase/api/entity/Account$Type;", "")]
			public static unsafe global::Com.Coinbase.Api.Entity.Account.Type ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/coinbase/api/entity/Account$Type;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Coinbase.Api.Entity.Account.Type __ret = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Account.Type> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Account.Type']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/coinbase/api/entity/Account$Type;", "")]
			public static unsafe global::Com.Coinbase.Api.Entity.Account.Type[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/coinbase/api/entity/Account$Type;");
				try {
					return (global::Com.Coinbase.Api.Entity.Account.Type[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Coinbase.Api.Entity.Account.Type));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/coinbase/api/entity/Account", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Account); }
		}

		protected Account (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Account']/constructor[@name='Account' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Account ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Account)) {
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

		static Delegate cb_getType;
#pragma warning disable 0169
		static Delegate GetGetAcountTypeHandler ()
		{
			if (cb_getType == null)
				cb_getType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAcountType);
			return cb_getType;
		}

		static IntPtr n_GetAcountType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.Account __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Account> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AcountType);
		}
#pragma warning restore 0169

		static IntPtr id_getType;
		public virtual unsafe global::Com.Coinbase.Api.Entity.Account.Type AcountType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Account']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()Lcom/coinbase/api/entity/Account$Type;", "GetGetAcountTypeHandler")]
			get {
				if (id_getType == IntPtr.Zero)
					id_getType = JNIEnv.GetMethodID (class_ref, "getType", "()Lcom/coinbase/api/entity/Account$Type;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Account.Type> (JNIEnv.CallObjectMethod  (Handle, id_getType), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Account.Type> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getType", "()Lcom/coinbase/api/entity/Account$Type;")), JniHandleOwnership.TransferLocalRef);
				} finally {
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
			global::Com.Coinbase.Api.Entity.Account __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Account> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Coinbase.Api.Entity.Account __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Account> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Id = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getId;
		static IntPtr id_setId_Ljava_lang_String_;
		public virtual unsafe string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Account']/method[@name='getId' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Account']/method[@name='setId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Coinbase.Api.Entity.Account __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Account> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Coinbase.Api.Entity.Account __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Account> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Name = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getName;
		static IntPtr id_setName_Ljava_lang_String_;
		public virtual unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Account']/method[@name='getName' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Account']/method[@name='setName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_isActive;
#pragma warning disable 0169
		static Delegate GetIsActiveHandler ()
		{
			if (cb_isActive == null)
				cb_isActive = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_IsActive);
			return cb_isActive;
		}

		static IntPtr n_IsActive (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.Account __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Account> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IsActive ());
		}
#pragma warning restore 0169

		static IntPtr id_isActive;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Account']/method[@name='isActive' and count(parameter)=0]"
		[Register ("isActive", "()Ljava/lang/Boolean;", "GetIsActiveHandler")]
		public virtual unsafe global::Java.Lang.Boolean IsActive ()
		{
			if (id_isActive == IntPtr.Zero)
				id_isActive = JNIEnv.GetMethodID (class_ref, "isActive", "()Ljava/lang/Boolean;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallObjectMethod  (Handle, id_isActive), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isActive", "()Ljava/lang/Boolean;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_isPrimary;
#pragma warning disable 0169
		static Delegate GetIsPrimaryHandler ()
		{
			if (cb_isPrimary == null)
				cb_isPrimary = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_IsPrimary);
			return cb_isPrimary;
		}

		static IntPtr n_IsPrimary (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.Account __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Account> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IsPrimary ());
		}
#pragma warning restore 0169

		static IntPtr id_isPrimary;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Account']/method[@name='isPrimary' and count(parameter)=0]"
		[Register ("isPrimary", "()Ljava/lang/Boolean;", "GetIsPrimaryHandler")]
		public virtual unsafe global::Java.Lang.Boolean IsPrimary ()
		{
			if (id_isPrimary == IntPtr.Zero)
				id_isPrimary = JNIEnv.GetMethodID (class_ref, "isPrimary", "()Ljava/lang/Boolean;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallObjectMethod  (Handle, id_isPrimary), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isPrimary", "()Ljava/lang/Boolean;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setActive_Z;
#pragma warning disable 0169
		static Delegate GetSetActive_ZHandler ()
		{
			if (cb_setActive_Z == null)
				cb_setActive_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetActive_Z);
			return cb_setActive_Z;
		}

		static void n_SetActive_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Coinbase.Api.Entity.Account __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Account> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetActive (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setActive_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Account']/method[@name='setActive' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setActive", "(Z)V", "GetSetActive_ZHandler")]
		public virtual unsafe void SetActive (bool p0)
		{
			if (id_setActive_Z == IntPtr.Zero)
				id_setActive_Z = JNIEnv.GetMethodID (class_ref, "setActive", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setActive_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setActive", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setPrimary_Z;
#pragma warning disable 0169
		static Delegate GetSetPrimary_ZHandler ()
		{
			if (cb_setPrimary_Z == null)
				cb_setPrimary_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetPrimary_Z);
			return cb_setPrimary_Z;
		}

		static void n_SetPrimary_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Coinbase.Api.Entity.Account __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Account> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetPrimary (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setPrimary_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Account']/method[@name='setPrimary' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setPrimary", "(Z)V", "GetSetPrimary_ZHandler")]
		public virtual unsafe void SetPrimary (bool p0)
		{
			if (id_setPrimary_Z == IntPtr.Zero)
				id_setPrimary_Z = JNIEnv.GetMethodID (class_ref, "setPrimary", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setPrimary_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPrimary", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setType_Lcom_coinbase_api_entity_Account_Type_;
#pragma warning disable 0169
		static Delegate GetSetType_Lcom_coinbase_api_entity_Account_Type_Handler ()
		{
			if (cb_setType_Lcom_coinbase_api_entity_Account_Type_ == null)
				cb_setType_Lcom_coinbase_api_entity_Account_Type_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetType_Lcom_coinbase_api_entity_Account_Type_);
			return cb_setType_Lcom_coinbase_api_entity_Account_Type_;
		}

		static void n_SetType_Lcom_coinbase_api_entity_Account_Type_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.Account __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Account> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Coinbase.Api.Entity.Account.Type p0 = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Account.Type> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetType (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setType_Lcom_coinbase_api_entity_Account_Type_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Account']/method[@name='setType' and count(parameter)=1 and parameter[1][@type='com.coinbase.api.entity.Account.Type']]"
		[Register ("setType", "(Lcom/coinbase/api/entity/Account$Type;)V", "GetSetType_Lcom_coinbase_api_entity_Account_Type_Handler")]
		public virtual unsafe void SetType (global::Com.Coinbase.Api.Entity.Account.Type p0)
		{
			if (id_setType_Lcom_coinbase_api_entity_Account_Type_ == IntPtr.Zero)
				id_setType_Lcom_coinbase_api_entity_Account_Type_ = JNIEnv.GetMethodID (class_ref, "setType", "(Lcom/coinbase/api/entity/Account$Type;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setType_Lcom_coinbase_api_entity_Account_Type_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setType", "(Lcom/coinbase/api/entity/Account$Type;)V"), __args);
			} finally {
			}
		}

	}
}
