using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Coinbase.Api.Entity {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='OAuthTokensRequest']"
	[global::Android.Runtime.Register ("com/coinbase/api/entity/OAuthTokensRequest", DoNotGenerateAcw=true)]
	public partial class OAuthTokensRequest : global::Java.Lang.Object, global::Java.IO.ISerializable {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='OAuthTokensRequest.GrantType']"
		[global::Android.Runtime.Register ("com/coinbase/api/entity/OAuthTokensRequest$GrantType", DoNotGenerateAcw=true)]
		public sealed partial class GrantType : global::Java.Lang.Enum {


			static IntPtr AUTHORIZATION_CODE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='OAuthTokensRequest.GrantType']/field[@name='AUTHORIZATION_CODE']"
			[Register ("AUTHORIZATION_CODE")]
			public static global::Com.Coinbase.Api.Entity.OAuthTokensRequest.GrantType AuthorizationCode {
				get {
					if (AUTHORIZATION_CODE_jfieldId == IntPtr.Zero)
						AUTHORIZATION_CODE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AUTHORIZATION_CODE", "Lcom/coinbase/api/entity/OAuthTokensRequest$GrantType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AUTHORIZATION_CODE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.OAuthTokensRequest.GrantType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr REFRESH_TOKEN_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='OAuthTokensRequest.GrantType']/field[@name='REFRESH_TOKEN']"
			[Register ("REFRESH_TOKEN")]
			public static global::Com.Coinbase.Api.Entity.OAuthTokensRequest.GrantType RefreshToken {
				get {
					if (REFRESH_TOKEN_jfieldId == IntPtr.Zero)
						REFRESH_TOKEN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "REFRESH_TOKEN", "Lcom/coinbase/api/entity/OAuthTokensRequest$GrantType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, REFRESH_TOKEN_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.OAuthTokensRequest.GrantType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/coinbase/api/entity/OAuthTokensRequest$GrantType", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (GrantType); }
			}

			internal GrantType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_create_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='OAuthTokensRequest.GrantType']/method[@name='create' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("create", "(Ljava/lang/String;)Lcom/coinbase/api/entity/OAuthTokensRequest$GrantType;", "")]
			public static unsafe global::Com.Coinbase.Api.Entity.OAuthTokensRequest.GrantType Create (string p0)
			{
				if (id_create_Ljava_lang_String_ == IntPtr.Zero)
					id_create_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "create", "(Ljava/lang/String;)Lcom/coinbase/api/entity/OAuthTokensRequest$GrantType;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Coinbase.Api.Entity.OAuthTokensRequest.GrantType __ret = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.OAuthTokensRequest.GrantType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='OAuthTokensRequest.GrantType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/coinbase/api/entity/OAuthTokensRequest$GrantType;", "")]
			public static unsafe global::Com.Coinbase.Api.Entity.OAuthTokensRequest.GrantType ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/coinbase/api/entity/OAuthTokensRequest$GrantType;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Coinbase.Api.Entity.OAuthTokensRequest.GrantType __ret = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.OAuthTokensRequest.GrantType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='OAuthTokensRequest.GrantType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/coinbase/api/entity/OAuthTokensRequest$GrantType;", "")]
			public static unsafe global::Com.Coinbase.Api.Entity.OAuthTokensRequest.GrantType[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/coinbase/api/entity/OAuthTokensRequest$GrantType;");
				try {
					return (global::Com.Coinbase.Api.Entity.OAuthTokensRequest.GrantType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Coinbase.Api.Entity.OAuthTokensRequest.GrantType));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/coinbase/api/entity/OAuthTokensRequest", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (OAuthTokensRequest); }
		}

		protected OAuthTokensRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='OAuthTokensRequest']/constructor[@name='OAuthTokensRequest' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe OAuthTokensRequest ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (OAuthTokensRequest)) {
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
			global::Com.Coinbase.Api.Entity.OAuthTokensRequest __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.OAuthTokensRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Coinbase.Api.Entity.OAuthTokensRequest __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.OAuthTokensRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ClientId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getClientId;
		static IntPtr id_setClientId_Ljava_lang_String_;
		public virtual unsafe string ClientId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='OAuthTokensRequest']/method[@name='getClientId' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='OAuthTokensRequest']/method[@name='setClientId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getClientSecret;
#pragma warning disable 0169
		static Delegate GetGetClientSecretHandler ()
		{
			if (cb_getClientSecret == null)
				cb_getClientSecret = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetClientSecret);
			return cb_getClientSecret;
		}

		static IntPtr n_GetClientSecret (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.OAuthTokensRequest __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.OAuthTokensRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ClientSecret);
		}
#pragma warning restore 0169

		static Delegate cb_setClientSecret_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetClientSecret_Ljava_lang_String_Handler ()
		{
			if (cb_setClientSecret_Ljava_lang_String_ == null)
				cb_setClientSecret_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetClientSecret_Ljava_lang_String_);
			return cb_setClientSecret_Ljava_lang_String_;
		}

		static void n_SetClientSecret_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.OAuthTokensRequest __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.OAuthTokensRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ClientSecret = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getClientSecret;
		static IntPtr id_setClientSecret_Ljava_lang_String_;
		public virtual unsafe string ClientSecret {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='OAuthTokensRequest']/method[@name='getClientSecret' and count(parameter)=0]"
			[Register ("getClientSecret", "()Ljava/lang/String;", "GetGetClientSecretHandler")]
			get {
				if (id_getClientSecret == IntPtr.Zero)
					id_getClientSecret = JNIEnv.GetMethodID (class_ref, "getClientSecret", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getClientSecret), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getClientSecret", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='OAuthTokensRequest']/method[@name='setClientSecret' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setClientSecret", "(Ljava/lang/String;)V", "GetSetClientSecret_Ljava_lang_String_Handler")]
			set {
				if (id_setClientSecret_Ljava_lang_String_ == IntPtr.Zero)
					id_setClientSecret_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setClientSecret", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setClientSecret_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setClientSecret", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
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
			global::Com.Coinbase.Api.Entity.OAuthTokensRequest __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.OAuthTokensRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Coinbase.Api.Entity.OAuthTokensRequest __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.OAuthTokensRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Code = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCode;
		static IntPtr id_setCode_Ljava_lang_String_;
		public virtual unsafe string Code {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='OAuthTokensRequest']/method[@name='getCode' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='OAuthTokensRequest']/method[@name='setCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getRedirectUri;
#pragma warning disable 0169
		static Delegate GetGetRedirectUriHandler ()
		{
			if (cb_getRedirectUri == null)
				cb_getRedirectUri = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRedirectUri);
			return cb_getRedirectUri;
		}

		static IntPtr n_GetRedirectUri (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.OAuthTokensRequest __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.OAuthTokensRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RedirectUri);
		}
#pragma warning restore 0169

		static Delegate cb_setRedirectUri_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetRedirectUri_Ljava_lang_String_Handler ()
		{
			if (cb_setRedirectUri_Ljava_lang_String_ == null)
				cb_setRedirectUri_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRedirectUri_Ljava_lang_String_);
			return cb_setRedirectUri_Ljava_lang_String_;
		}

		static void n_SetRedirectUri_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.OAuthTokensRequest __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.OAuthTokensRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RedirectUri = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getRedirectUri;
		static IntPtr id_setRedirectUri_Ljava_lang_String_;
		public virtual unsafe string RedirectUri {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='OAuthTokensRequest']/method[@name='getRedirectUri' and count(parameter)=0]"
			[Register ("getRedirectUri", "()Ljava/lang/String;", "GetGetRedirectUriHandler")]
			get {
				if (id_getRedirectUri == IntPtr.Zero)
					id_getRedirectUri = JNIEnv.GetMethodID (class_ref, "getRedirectUri", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getRedirectUri), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRedirectUri", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='OAuthTokensRequest']/method[@name='setRedirectUri' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setRedirectUri", "(Ljava/lang/String;)V", "GetSetRedirectUri_Ljava_lang_String_Handler")]
			set {
				if (id_setRedirectUri_Ljava_lang_String_ == IntPtr.Zero)
					id_setRedirectUri_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setRedirectUri", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setRedirectUri_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRedirectUri", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getRefreshToken;
#pragma warning disable 0169
		static Delegate GetGetRefreshTokenHandler ()
		{
			if (cb_getRefreshToken == null)
				cb_getRefreshToken = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRefreshToken);
			return cb_getRefreshToken;
		}

		static IntPtr n_GetRefreshToken (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.OAuthTokensRequest __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.OAuthTokensRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RefreshToken);
		}
#pragma warning restore 0169

		static Delegate cb_setRefreshToken_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetRefreshToken_Ljava_lang_String_Handler ()
		{
			if (cb_setRefreshToken_Ljava_lang_String_ == null)
				cb_setRefreshToken_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRefreshToken_Ljava_lang_String_);
			return cb_setRefreshToken_Ljava_lang_String_;
		}

		static void n_SetRefreshToken_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.OAuthTokensRequest __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.OAuthTokensRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RefreshToken = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getRefreshToken;
		static IntPtr id_setRefreshToken_Ljava_lang_String_;
		public virtual unsafe string RefreshToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='OAuthTokensRequest']/method[@name='getRefreshToken' and count(parameter)=0]"
			[Register ("getRefreshToken", "()Ljava/lang/String;", "GetGetRefreshTokenHandler")]
			get {
				if (id_getRefreshToken == IntPtr.Zero)
					id_getRefreshToken = JNIEnv.GetMethodID (class_ref, "getRefreshToken", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getRefreshToken), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRefreshToken", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='OAuthTokensRequest']/method[@name='setRefreshToken' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setRefreshToken", "(Ljava/lang/String;)V", "GetSetRefreshToken_Ljava_lang_String_Handler")]
			set {
				if (id_setRefreshToken_Ljava_lang_String_ == IntPtr.Zero)
					id_setRefreshToken_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setRefreshToken", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setRefreshToken_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRefreshToken", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getGrantType;
#pragma warning disable 0169
		static Delegate GetGetGrantTypeHandler ()
		{
			if (cb_getGrantType == null)
				cb_getGrantType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetGrantType);
			return cb_getGrantType;
		}

		static IntPtr n_GetGrantType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.OAuthTokensRequest __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.OAuthTokensRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetGrantType ());
		}
#pragma warning restore 0169

		static IntPtr id_getGrantType;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='OAuthTokensRequest']/method[@name='getGrantType' and count(parameter)=0]"
		[Register ("getGrantType", "()Lcom/coinbase/api/entity/OAuthTokensRequest$GrantType;", "GetGetGrantTypeHandler")]
		public virtual unsafe global::Com.Coinbase.Api.Entity.OAuthTokensRequest.GrantType GetGrantType ()
		{
			if (id_getGrantType == IntPtr.Zero)
				id_getGrantType = JNIEnv.GetMethodID (class_ref, "getGrantType", "()Lcom/coinbase/api/entity/OAuthTokensRequest$GrantType;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.OAuthTokensRequest.GrantType> (JNIEnv.CallObjectMethod  (Handle, id_getGrantType), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.OAuthTokensRequest.GrantType> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getGrantType", "()Lcom/coinbase/api/entity/OAuthTokensRequest$GrantType;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setGrantType_Lcom_coinbase_api_entity_OAuthTokensRequest_GrantType_;
#pragma warning disable 0169
		static Delegate GetSetGrantType_Lcom_coinbase_api_entity_OAuthTokensRequest_GrantType_Handler ()
		{
			if (cb_setGrantType_Lcom_coinbase_api_entity_OAuthTokensRequest_GrantType_ == null)
				cb_setGrantType_Lcom_coinbase_api_entity_OAuthTokensRequest_GrantType_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetGrantType_Lcom_coinbase_api_entity_OAuthTokensRequest_GrantType_);
			return cb_setGrantType_Lcom_coinbase_api_entity_OAuthTokensRequest_GrantType_;
		}

		static void n_SetGrantType_Lcom_coinbase_api_entity_OAuthTokensRequest_GrantType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.OAuthTokensRequest __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.OAuthTokensRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Coinbase.Api.Entity.OAuthTokensRequest.GrantType p0 = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.OAuthTokensRequest.GrantType> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetGrantType (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setGrantType_Lcom_coinbase_api_entity_OAuthTokensRequest_GrantType_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='OAuthTokensRequest']/method[@name='setGrantType' and count(parameter)=1 and parameter[1][@type='com.coinbase.api.entity.OAuthTokensRequest.GrantType']]"
		[Register ("setGrantType", "(Lcom/coinbase/api/entity/OAuthTokensRequest$GrantType;)V", "GetSetGrantType_Lcom_coinbase_api_entity_OAuthTokensRequest_GrantType_Handler")]
		public virtual unsafe void SetGrantType (global::Com.Coinbase.Api.Entity.OAuthTokensRequest.GrantType p0)
		{
			if (id_setGrantType_Lcom_coinbase_api_entity_OAuthTokensRequest_GrantType_ == IntPtr.Zero)
				id_setGrantType_Lcom_coinbase_api_entity_OAuthTokensRequest_GrantType_ = JNIEnv.GetMethodID (class_ref, "setGrantType", "(Lcom/coinbase/api/entity/OAuthTokensRequest$GrantType;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setGrantType_Lcom_coinbase_api_entity_OAuthTokensRequest_GrantType_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setGrantType", "(Lcom/coinbase/api/entity/OAuthTokensRequest$GrantType;)V"), __args);
			} finally {
			}
		}

	}
}
