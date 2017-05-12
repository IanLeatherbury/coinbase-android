using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Coinbase.Api.Entity {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='User']"
	[global::Android.Runtime.Register ("com/coinbase/api/entity/User", DoNotGenerateAcw=true)]
	public partial class User : global::Java.Lang.Object, global::Java.IO.ISerializable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/coinbase/api/entity/User", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (User); }
		}

		protected User (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='User']/constructor[@name='User' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe User ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (User)) {
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

		static Delegate cb_getAcceptAgreement;
#pragma warning disable 0169
		static Delegate GetGetAcceptAgreementHandler ()
		{
			if (cb_getAcceptAgreement == null)
				cb_getAcceptAgreement = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAcceptAgreement);
			return cb_getAcceptAgreement;
		}

		static IntPtr n_GetAcceptAgreement (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.User __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.User> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AcceptAgreement);
		}
#pragma warning restore 0169

		static Delegate cb_setAcceptAgreement_Ljava_lang_Boolean_;
#pragma warning disable 0169
		static Delegate GetSetAcceptAgreement_Ljava_lang_Boolean_Handler ()
		{
			if (cb_setAcceptAgreement_Ljava_lang_Boolean_ == null)
				cb_setAcceptAgreement_Ljava_lang_Boolean_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAcceptAgreement_Ljava_lang_Boolean_);
			return cb_setAcceptAgreement_Ljava_lang_Boolean_;
		}

		static void n_SetAcceptAgreement_Ljava_lang_Boolean_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.User __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.User> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Boolean p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AcceptAgreement = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAcceptAgreement;
		static IntPtr id_setAcceptAgreement_Ljava_lang_Boolean_;
		public virtual unsafe global::Java.Lang.Boolean AcceptAgreement {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='User']/method[@name='getAcceptAgreement' and count(parameter)=0]"
			[Register ("getAcceptAgreement", "()Ljava/lang/Boolean;", "GetGetAcceptAgreementHandler")]
			get {
				if (id_getAcceptAgreement == IntPtr.Zero)
					id_getAcceptAgreement = JNIEnv.GetMethodID (class_ref, "getAcceptAgreement", "()Ljava/lang/Boolean;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallObjectMethod  (Handle, id_getAcceptAgreement), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAcceptAgreement", "()Ljava/lang/Boolean;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='User']/method[@name='setAcceptAgreement' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
			[Register ("setAcceptAgreement", "(Ljava/lang/Boolean;)V", "GetSetAcceptAgreement_Ljava_lang_Boolean_Handler")]
			set {
				if (id_setAcceptAgreement_Ljava_lang_Boolean_ == IntPtr.Zero)
					id_setAcceptAgreement_Ljava_lang_Boolean_ = JNIEnv.GetMethodID (class_ref, "setAcceptAgreement", "(Ljava/lang/Boolean;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setAcceptAgreement_Ljava_lang_Boolean_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAcceptAgreement", "(Ljava/lang/Boolean;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getAvatarUrl;
#pragma warning disable 0169
		static Delegate GetGetAvatarUrlHandler ()
		{
			if (cb_getAvatarUrl == null)
				cb_getAvatarUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAvatarUrl);
			return cb_getAvatarUrl;
		}

		static IntPtr n_GetAvatarUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.User __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.User> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AvatarUrl);
		}
#pragma warning restore 0169

		static Delegate cb_setAvatarUrl_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAvatarUrl_Ljava_lang_String_Handler ()
		{
			if (cb_setAvatarUrl_Ljava_lang_String_ == null)
				cb_setAvatarUrl_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAvatarUrl_Ljava_lang_String_);
			return cb_setAvatarUrl_Ljava_lang_String_;
		}

		static void n_SetAvatarUrl_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.User __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.User> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AvatarUrl = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAvatarUrl;
		static IntPtr id_setAvatarUrl_Ljava_lang_String_;
		public virtual unsafe string AvatarUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='User']/method[@name='getAvatarUrl' and count(parameter)=0]"
			[Register ("getAvatarUrl", "()Ljava/lang/String;", "GetGetAvatarUrlHandler")]
			get {
				if (id_getAvatarUrl == IntPtr.Zero)
					id_getAvatarUrl = JNIEnv.GetMethodID (class_ref, "getAvatarUrl", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getAvatarUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAvatarUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='User']/method[@name='setAvatarUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAvatarUrl", "(Ljava/lang/String;)V", "GetSetAvatarUrl_Ljava_lang_String_Handler")]
			set {
				if (id_setAvatarUrl_Ljava_lang_String_ == IntPtr.Zero)
					id_setAvatarUrl_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAvatarUrl", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setAvatarUrl_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAvatarUrl", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getBitcoinUnits;
#pragma warning disable 0169
		static Delegate GetGetBitcoinUnitsHandler ()
		{
			if (cb_getBitcoinUnits == null)
				cb_getBitcoinUnits = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBitcoinUnits);
			return cb_getBitcoinUnits;
		}

		static IntPtr n_GetBitcoinUnits (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.User __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.User> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.BitcoinUnits);
		}
#pragma warning restore 0169

		static Delegate cb_setBitcoinUnits_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetBitcoinUnits_Ljava_lang_String_Handler ()
		{
			if (cb_setBitcoinUnits_Ljava_lang_String_ == null)
				cb_setBitcoinUnits_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBitcoinUnits_Ljava_lang_String_);
			return cb_setBitcoinUnits_Ljava_lang_String_;
		}

		static void n_SetBitcoinUnits_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.User __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.User> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.BitcoinUnits = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getBitcoinUnits;
		static IntPtr id_setBitcoinUnits_Ljava_lang_String_;
		public virtual unsafe string BitcoinUnits {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='User']/method[@name='getBitcoinUnits' and count(parameter)=0]"
			[Register ("getBitcoinUnits", "()Ljava/lang/String;", "GetGetBitcoinUnitsHandler")]
			get {
				if (id_getBitcoinUnits == IntPtr.Zero)
					id_getBitcoinUnits = JNIEnv.GetMethodID (class_ref, "getBitcoinUnits", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getBitcoinUnits), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBitcoinUnits", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='User']/method[@name='setBitcoinUnits' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setBitcoinUnits", "(Ljava/lang/String;)V", "GetSetBitcoinUnits_Ljava_lang_String_Handler")]
			set {
				if (id_setBitcoinUnits_Ljava_lang_String_ == IntPtr.Zero)
					id_setBitcoinUnits_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setBitcoinUnits", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setBitcoinUnits_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBitcoinUnits", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getBuyLevel;
#pragma warning disable 0169
		static Delegate GetGetBuyLevelHandler ()
		{
			if (cb_getBuyLevel == null)
				cb_getBuyLevel = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBuyLevel);
			return cb_getBuyLevel;
		}

		static IntPtr n_GetBuyLevel (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.User __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.User> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BuyLevel);
		}
#pragma warning restore 0169

		static Delegate cb_setBuyLevel_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetSetBuyLevel_Ljava_lang_Integer_Handler ()
		{
			if (cb_setBuyLevel_Ljava_lang_Integer_ == null)
				cb_setBuyLevel_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBuyLevel_Ljava_lang_Integer_);
			return cb_setBuyLevel_Ljava_lang_Integer_;
		}

		static void n_SetBuyLevel_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.User __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.User> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.BuyLevel = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getBuyLevel;
		static IntPtr id_setBuyLevel_Ljava_lang_Integer_;
		public virtual unsafe global::Java.Lang.Integer BuyLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='User']/method[@name='getBuyLevel' and count(parameter)=0]"
			[Register ("getBuyLevel", "()Ljava/lang/Integer;", "GetGetBuyLevelHandler")]
			get {
				if (id_getBuyLevel == IntPtr.Zero)
					id_getBuyLevel = JNIEnv.GetMethodID (class_ref, "getBuyLevel", "()Ljava/lang/Integer;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod  (Handle, id_getBuyLevel), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBuyLevel", "()Ljava/lang/Integer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='User']/method[@name='setBuyLevel' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("setBuyLevel", "(Ljava/lang/Integer;)V", "GetSetBuyLevel_Ljava_lang_Integer_Handler")]
			set {
				if (id_setBuyLevel_Ljava_lang_Integer_ == IntPtr.Zero)
					id_setBuyLevel_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "setBuyLevel", "(Ljava/lang/Integer;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setBuyLevel_Ljava_lang_Integer_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBuyLevel", "(Ljava/lang/Integer;)V"), __args);
				} finally {
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
			global::Com.Coinbase.Api.Entity.User __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.User> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Coinbase.Api.Entity.User __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.User> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Email = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getEmail;
		static IntPtr id_setEmail_Ljava_lang_String_;
		public virtual unsafe string Email {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='User']/method[@name='getEmail' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='User']/method[@name='setEmail' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getEmailVerified;
#pragma warning disable 0169
		static Delegate GetGetEmailVerifiedHandler ()
		{
			if (cb_getEmailVerified == null)
				cb_getEmailVerified = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEmailVerified);
			return cb_getEmailVerified;
		}

		static IntPtr n_GetEmailVerified (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.User __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.User> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.EmailVerified);
		}
#pragma warning restore 0169

		static Delegate cb_setEmailVerified_Ljava_lang_Boolean_;
#pragma warning disable 0169
		static Delegate GetSetEmailVerified_Ljava_lang_Boolean_Handler ()
		{
			if (cb_setEmailVerified_Ljava_lang_Boolean_ == null)
				cb_setEmailVerified_Ljava_lang_Boolean_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetEmailVerified_Ljava_lang_Boolean_);
			return cb_setEmailVerified_Ljava_lang_Boolean_;
		}

		static void n_SetEmailVerified_Ljava_lang_Boolean_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.User __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.User> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Boolean p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.EmailVerified = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getEmailVerified;
		static IntPtr id_setEmailVerified_Ljava_lang_Boolean_;
		public virtual unsafe global::Java.Lang.Boolean EmailVerified {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='User']/method[@name='getEmailVerified' and count(parameter)=0]"
			[Register ("getEmailVerified", "()Ljava/lang/Boolean;", "GetGetEmailVerifiedHandler")]
			get {
				if (id_getEmailVerified == IntPtr.Zero)
					id_getEmailVerified = JNIEnv.GetMethodID (class_ref, "getEmailVerified", "()Ljava/lang/Boolean;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallObjectMethod  (Handle, id_getEmailVerified), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEmailVerified", "()Ljava/lang/Boolean;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='User']/method[@name='setEmailVerified' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
			[Register ("setEmailVerified", "(Ljava/lang/Boolean;)V", "GetSetEmailVerified_Ljava_lang_Boolean_Handler")]
			set {
				if (id_setEmailVerified_Ljava_lang_Boolean_ == IntPtr.Zero)
					id_setEmailVerified_Ljava_lang_Boolean_ = JNIEnv.GetMethodID (class_ref, "setEmailVerified", "(Ljava/lang/Boolean;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setEmailVerified_Ljava_lang_Boolean_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEmailVerified", "(Ljava/lang/Boolean;)V"), __args);
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
			global::Com.Coinbase.Api.Entity.User __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.User> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Coinbase.Api.Entity.User __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.User> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Id = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getId;
		static IntPtr id_setId_Ljava_lang_String_;
		public virtual unsafe string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='User']/method[@name='getId' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='User']/method[@name='setId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getLocation;
#pragma warning disable 0169
		static Delegate GetGetLocationHandler ()
		{
			if (cb_getLocation == null)
				cb_getLocation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLocation);
			return cb_getLocation;
		}

		static IntPtr n_GetLocation (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.User __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.User> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Location);
		}
#pragma warning restore 0169

		static Delegate cb_setLocation_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetLocation_Ljava_lang_String_Handler ()
		{
			if (cb_setLocation_Ljava_lang_String_ == null)
				cb_setLocation_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLocation_Ljava_lang_String_);
			return cb_setLocation_Ljava_lang_String_;
		}

		static void n_SetLocation_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.User __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.User> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Location = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getLocation;
		static IntPtr id_setLocation_Ljava_lang_String_;
		public virtual unsafe string Location {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='User']/method[@name='getLocation' and count(parameter)=0]"
			[Register ("getLocation", "()Ljava/lang/String;", "GetGetLocationHandler")]
			get {
				if (id_getLocation == IntPtr.Zero)
					id_getLocation = JNIEnv.GetMethodID (class_ref, "getLocation", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getLocation), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLocation", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='User']/method[@name='setLocation' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setLocation", "(Ljava/lang/String;)V", "GetSetLocation_Ljava_lang_String_Handler")]
			set {
				if (id_setLocation_Ljava_lang_String_ == IntPtr.Zero)
					id_setLocation_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setLocation", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setLocation_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLocation", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getMerchant;
#pragma warning disable 0169
		static Delegate GetGetMerchantHandler ()
		{
			if (cb_getMerchant == null)
				cb_getMerchant = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMerchant);
			return cb_getMerchant;
		}

		static IntPtr n_GetMerchant (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.User __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.User> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Merchant);
		}
#pragma warning restore 0169

		static Delegate cb_setMerchant_Lcom_coinbase_api_entity_Merchant_;
#pragma warning disable 0169
		static Delegate GetSetMerchant_Lcom_coinbase_api_entity_Merchant_Handler ()
		{
			if (cb_setMerchant_Lcom_coinbase_api_entity_Merchant_ == null)
				cb_setMerchant_Lcom_coinbase_api_entity_Merchant_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMerchant_Lcom_coinbase_api_entity_Merchant_);
			return cb_setMerchant_Lcom_coinbase_api_entity_Merchant_;
		}

		static void n_SetMerchant_Lcom_coinbase_api_entity_Merchant_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.User __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.User> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Coinbase.Api.Entity.Merchant p0 = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Merchant> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Merchant = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMerchant;
		static IntPtr id_setMerchant_Lcom_coinbase_api_entity_Merchant_;
		public virtual unsafe global::Com.Coinbase.Api.Entity.Merchant Merchant {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='User']/method[@name='getMerchant' and count(parameter)=0]"
			[Register ("getMerchant", "()Lcom/coinbase/api/entity/Merchant;", "GetGetMerchantHandler")]
			get {
				if (id_getMerchant == IntPtr.Zero)
					id_getMerchant = JNIEnv.GetMethodID (class_ref, "getMerchant", "()Lcom/coinbase/api/entity/Merchant;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Merchant> (JNIEnv.CallObjectMethod  (Handle, id_getMerchant), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Merchant> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMerchant", "()Lcom/coinbase/api/entity/Merchant;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='User']/method[@name='setMerchant' and count(parameter)=1 and parameter[1][@type='com.coinbase.api.entity.Merchant']]"
			[Register ("setMerchant", "(Lcom/coinbase/api/entity/Merchant;)V", "GetSetMerchant_Lcom_coinbase_api_entity_Merchant_Handler")]
			set {
				if (id_setMerchant_Lcom_coinbase_api_entity_Merchant_ == IntPtr.Zero)
					id_setMerchant_Lcom_coinbase_api_entity_Merchant_ = JNIEnv.GetMethodID (class_ref, "setMerchant", "(Lcom/coinbase/api/entity/Merchant;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setMerchant_Lcom_coinbase_api_entity_Merchant_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMerchant", "(Lcom/coinbase/api/entity/Merchant;)V"), __args);
				} finally {
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
			global::Com.Coinbase.Api.Entity.User __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.User> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Coinbase.Api.Entity.User __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.User> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Name = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getName;
		static IntPtr id_setName_Ljava_lang_String_;
		public virtual unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='User']/method[@name='getName' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='User']/method[@name='setName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getPassword;
#pragma warning disable 0169
		static Delegate GetGetPasswordHandler ()
		{
			if (cb_getPassword == null)
				cb_getPassword = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPassword);
			return cb_getPassword;
		}

		static IntPtr n_GetPassword (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.User __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.User> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Password);
		}
#pragma warning restore 0169

		static Delegate cb_setPassword_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetPassword_Ljava_lang_String_Handler ()
		{
			if (cb_setPassword_Ljava_lang_String_ == null)
				cb_setPassword_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPassword_Ljava_lang_String_);
			return cb_setPassword_Ljava_lang_String_;
		}

		static void n_SetPassword_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.User __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.User> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Password = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getPassword;
		static IntPtr id_setPassword_Ljava_lang_String_;
		public virtual unsafe string Password {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='User']/method[@name='getPassword' and count(parameter)=0]"
			[Register ("getPassword", "()Ljava/lang/String;", "GetGetPasswordHandler")]
			get {
				if (id_getPassword == IntPtr.Zero)
					id_getPassword = JNIEnv.GetMethodID (class_ref, "getPassword", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getPassword), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPassword", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='User']/method[@name='setPassword' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setPassword", "(Ljava/lang/String;)V", "GetSetPassword_Ljava_lang_String_Handler")]
			set {
				if (id_setPassword_Ljava_lang_String_ == IntPtr.Zero)
					id_setPassword_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setPassword", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setPassword_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPassword", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getProfileDescription;
#pragma warning disable 0169
		static Delegate GetGetProfileDescriptionHandler ()
		{
			if (cb_getProfileDescription == null)
				cb_getProfileDescription = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetProfileDescription);
			return cb_getProfileDescription;
		}

		static IntPtr n_GetProfileDescription (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.User __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.User> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ProfileDescription);
		}
#pragma warning restore 0169

		static Delegate cb_setProfileDescription_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetProfileDescription_Ljava_lang_String_Handler ()
		{
			if (cb_setProfileDescription_Ljava_lang_String_ == null)
				cb_setProfileDescription_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetProfileDescription_Ljava_lang_String_);
			return cb_setProfileDescription_Ljava_lang_String_;
		}

		static void n_SetProfileDescription_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.User __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.User> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ProfileDescription = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getProfileDescription;
		static IntPtr id_setProfileDescription_Ljava_lang_String_;
		public virtual unsafe string ProfileDescription {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='User']/method[@name='getProfileDescription' and count(parameter)=0]"
			[Register ("getProfileDescription", "()Ljava/lang/String;", "GetGetProfileDescriptionHandler")]
			get {
				if (id_getProfileDescription == IntPtr.Zero)
					id_getProfileDescription = JNIEnv.GetMethodID (class_ref, "getProfileDescription", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getProfileDescription), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getProfileDescription", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='User']/method[@name='setProfileDescription' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setProfileDescription", "(Ljava/lang/String;)V", "GetSetProfileDescription_Ljava_lang_String_Handler")]
			set {
				if (id_setProfileDescription_Ljava_lang_String_ == IntPtr.Zero)
					id_setProfileDescription_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setProfileDescription", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setProfileDescription_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setProfileDescription", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getReceiveAddress;
#pragma warning disable 0169
		static Delegate GetGetReceiveAddressHandler ()
		{
			if (cb_getReceiveAddress == null)
				cb_getReceiveAddress = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetReceiveAddress);
			return cb_getReceiveAddress;
		}

		static IntPtr n_GetReceiveAddress (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.User __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.User> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ReceiveAddress);
		}
#pragma warning restore 0169

		static Delegate cb_setReceiveAddress_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetReceiveAddress_Ljava_lang_String_Handler ()
		{
			if (cb_setReceiveAddress_Ljava_lang_String_ == null)
				cb_setReceiveAddress_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetReceiveAddress_Ljava_lang_String_);
			return cb_setReceiveAddress_Ljava_lang_String_;
		}

		static void n_SetReceiveAddress_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.User __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.User> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ReceiveAddress = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getReceiveAddress;
		static IntPtr id_setReceiveAddress_Ljava_lang_String_;
		public virtual unsafe string ReceiveAddress {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='User']/method[@name='getReceiveAddress' and count(parameter)=0]"
			[Register ("getReceiveAddress", "()Ljava/lang/String;", "GetGetReceiveAddressHandler")]
			get {
				if (id_getReceiveAddress == IntPtr.Zero)
					id_getReceiveAddress = JNIEnv.GetMethodID (class_ref, "getReceiveAddress", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getReceiveAddress), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getReceiveAddress", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='User']/method[@name='setReceiveAddress' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setReceiveAddress", "(Ljava/lang/String;)V", "GetSetReceiveAddress_Ljava_lang_String_Handler")]
			set {
				if (id_setReceiveAddress_Ljava_lang_String_ == IntPtr.Zero)
					id_setReceiveAddress_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setReceiveAddress", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setReceiveAddress_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setReceiveAddress", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getReferrerId;
#pragma warning disable 0169
		static Delegate GetGetReferrerIdHandler ()
		{
			if (cb_getReferrerId == null)
				cb_getReferrerId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetReferrerId);
			return cb_getReferrerId;
		}

		static IntPtr n_GetReferrerId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.User __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.User> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ReferrerId);
		}
#pragma warning restore 0169

		static Delegate cb_setReferrerId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetReferrerId_Ljava_lang_String_Handler ()
		{
			if (cb_setReferrerId_Ljava_lang_String_ == null)
				cb_setReferrerId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetReferrerId_Ljava_lang_String_);
			return cb_setReferrerId_Ljava_lang_String_;
		}

		static void n_SetReferrerId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.User __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.User> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ReferrerId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getReferrerId;
		static IntPtr id_setReferrerId_Ljava_lang_String_;
		public virtual unsafe string ReferrerId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='User']/method[@name='getReferrerId' and count(parameter)=0]"
			[Register ("getReferrerId", "()Ljava/lang/String;", "GetGetReferrerIdHandler")]
			get {
				if (id_getReferrerId == IntPtr.Zero)
					id_getReferrerId = JNIEnv.GetMethodID (class_ref, "getReferrerId", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getReferrerId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getReferrerId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='User']/method[@name='setReferrerId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setReferrerId", "(Ljava/lang/String;)V", "GetSetReferrerId_Ljava_lang_String_Handler")]
			set {
				if (id_setReferrerId_Ljava_lang_String_ == IntPtr.Zero)
					id_setReferrerId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setReferrerId", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setReferrerId_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setReferrerId", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getSellLevel;
#pragma warning disable 0169
		static Delegate GetGetSellLevelHandler ()
		{
			if (cb_getSellLevel == null)
				cb_getSellLevel = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSellLevel);
			return cb_getSellLevel;
		}

		static IntPtr n_GetSellLevel (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.User __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.User> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SellLevel);
		}
#pragma warning restore 0169

		static Delegate cb_setSellLevel_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetSetSellLevel_Ljava_lang_Integer_Handler ()
		{
			if (cb_setSellLevel_Ljava_lang_Integer_ == null)
				cb_setSellLevel_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSellLevel_Ljava_lang_Integer_);
			return cb_setSellLevel_Ljava_lang_Integer_;
		}

		static void n_SetSellLevel_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.User __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.User> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SellLevel = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getSellLevel;
		static IntPtr id_setSellLevel_Ljava_lang_Integer_;
		public virtual unsafe global::Java.Lang.Integer SellLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='User']/method[@name='getSellLevel' and count(parameter)=0]"
			[Register ("getSellLevel", "()Ljava/lang/Integer;", "GetGetSellLevelHandler")]
			get {
				if (id_getSellLevel == IntPtr.Zero)
					id_getSellLevel = JNIEnv.GetMethodID (class_ref, "getSellLevel", "()Ljava/lang/Integer;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod  (Handle, id_getSellLevel), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSellLevel", "()Ljava/lang/Integer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='User']/method[@name='setSellLevel' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("setSellLevel", "(Ljava/lang/Integer;)V", "GetSetSellLevel_Ljava_lang_Integer_Handler")]
			set {
				if (id_setSellLevel_Ljava_lang_Integer_ == IntPtr.Zero)
					id_setSellLevel_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "setSellLevel", "(Ljava/lang/Integer;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setSellLevel_Ljava_lang_Integer_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSellLevel", "(Ljava/lang/Integer;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTimeZone;
#pragma warning disable 0169
		static Delegate GetGetTimeZoneHandler ()
		{
			if (cb_getTimeZone == null)
				cb_getTimeZone = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTimeZone);
			return cb_getTimeZone;
		}

		static IntPtr n_GetTimeZone (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.User __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.User> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TimeZone);
		}
#pragma warning restore 0169

		static Delegate cb_setTimeZone_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTimeZone_Ljava_lang_String_Handler ()
		{
			if (cb_setTimeZone_Ljava_lang_String_ == null)
				cb_setTimeZone_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTimeZone_Ljava_lang_String_);
			return cb_setTimeZone_Ljava_lang_String_;
		}

		static void n_SetTimeZone_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.User __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.User> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TimeZone = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTimeZone;
		static IntPtr id_setTimeZone_Ljava_lang_String_;
		public virtual unsafe string TimeZone {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='User']/method[@name='getTimeZone' and count(parameter)=0]"
			[Register ("getTimeZone", "()Ljava/lang/String;", "GetGetTimeZoneHandler")]
			get {
				if (id_getTimeZone == IntPtr.Zero)
					id_getTimeZone = JNIEnv.GetMethodID (class_ref, "getTimeZone", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getTimeZone), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTimeZone", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='User']/method[@name='setTimeZone' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTimeZone", "(Ljava/lang/String;)V", "GetSetTimeZone_Ljava_lang_String_Handler")]
			set {
				if (id_setTimeZone_Ljava_lang_String_ == IntPtr.Zero)
					id_setTimeZone_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTimeZone", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setTimeZone_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTimeZone", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getUsername;
#pragma warning disable 0169
		static Delegate GetGetUsernameHandler ()
		{
			if (cb_getUsername == null)
				cb_getUsername = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUsername);
			return cb_getUsername;
		}

		static IntPtr n_GetUsername (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.User __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.User> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Username);
		}
#pragma warning restore 0169

		static Delegate cb_setUsername_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetUsername_Ljava_lang_String_Handler ()
		{
			if (cb_setUsername_Ljava_lang_String_ == null)
				cb_setUsername_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetUsername_Ljava_lang_String_);
			return cb_setUsername_Ljava_lang_String_;
		}

		static void n_SetUsername_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.User __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.User> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Username = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getUsername;
		static IntPtr id_setUsername_Ljava_lang_String_;
		public virtual unsafe string Username {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='User']/method[@name='getUsername' and count(parameter)=0]"
			[Register ("getUsername", "()Ljava/lang/String;", "GetGetUsernameHandler")]
			get {
				if (id_getUsername == IntPtr.Zero)
					id_getUsername = JNIEnv.GetMethodID (class_ref, "getUsername", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getUsername), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUsername", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='User']/method[@name='setUsername' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setUsername", "(Ljava/lang/String;)V", "GetSetUsername_Ljava_lang_String_Handler")]
			set {
				if (id_setUsername_Ljava_lang_String_ == IntPtr.Zero)
					id_setUsername_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setUsername", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setUsername_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUsername", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

	}
}
