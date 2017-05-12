using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Coinbase.Api.Entity {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='OAuthTokensResponse']"
	[global::Android.Runtime.Register ("com/coinbase/api/entity/OAuthTokensResponse", DoNotGenerateAcw=true)]
	public partial class OAuthTokensResponse : global::Com.Coinbase.Api.Entity.Response {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/coinbase/api/entity/OAuthTokensResponse", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (OAuthTokensResponse); }
		}

		protected OAuthTokensResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='OAuthTokensResponse']/constructor[@name='OAuthTokensResponse' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe OAuthTokensResponse ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (OAuthTokensResponse)) {
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

		static Delegate cb_getAccessToken;
#pragma warning disable 0169
		static Delegate GetGetAccessTokenHandler ()
		{
			if (cb_getAccessToken == null)
				cb_getAccessToken = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAccessToken);
			return cb_getAccessToken;
		}

		static IntPtr n_GetAccessToken (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.OAuthTokensResponse __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.OAuthTokensResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AccessToken);
		}
#pragma warning restore 0169

		static Delegate cb_setAccessToken_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAccessToken_Ljava_lang_String_Handler ()
		{
			if (cb_setAccessToken_Ljava_lang_String_ == null)
				cb_setAccessToken_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAccessToken_Ljava_lang_String_);
			return cb_setAccessToken_Ljava_lang_String_;
		}

		static void n_SetAccessToken_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.OAuthTokensResponse __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.OAuthTokensResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AccessToken = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAccessToken;
		static IntPtr id_setAccessToken_Ljava_lang_String_;
		public virtual unsafe string AccessToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='OAuthTokensResponse']/method[@name='getAccessToken' and count(parameter)=0]"
			[Register ("getAccessToken", "()Ljava/lang/String;", "GetGetAccessTokenHandler")]
			get {
				if (id_getAccessToken == IntPtr.Zero)
					id_getAccessToken = JNIEnv.GetMethodID (class_ref, "getAccessToken", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getAccessToken), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAccessToken", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='OAuthTokensResponse']/method[@name='setAccessToken' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAccessToken", "(Ljava/lang/String;)V", "GetSetAccessToken_Ljava_lang_String_Handler")]
			set {
				if (id_setAccessToken_Ljava_lang_String_ == IntPtr.Zero)
					id_setAccessToken_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAccessToken", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setAccessToken_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAccessToken", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getExpireIn;
#pragma warning disable 0169
		static Delegate GetGetExpireInHandler ()
		{
			if (cb_getExpireIn == null)
				cb_getExpireIn = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetExpireIn);
			return cb_getExpireIn;
		}

		static IntPtr n_GetExpireIn (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.OAuthTokensResponse __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.OAuthTokensResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ExpireIn);
		}
#pragma warning restore 0169

		static Delegate cb_setExpireIn_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetSetExpireIn_Ljava_lang_Integer_Handler ()
		{
			if (cb_setExpireIn_Ljava_lang_Integer_ == null)
				cb_setExpireIn_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetExpireIn_Ljava_lang_Integer_);
			return cb_setExpireIn_Ljava_lang_Integer_;
		}

		static void n_SetExpireIn_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.OAuthTokensResponse __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.OAuthTokensResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ExpireIn = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getExpireIn;
		static IntPtr id_setExpireIn_Ljava_lang_Integer_;
		public virtual unsafe global::Java.Lang.Integer ExpireIn {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='OAuthTokensResponse']/method[@name='getExpireIn' and count(parameter)=0]"
			[Register ("getExpireIn", "()Ljava/lang/Integer;", "GetGetExpireInHandler")]
			get {
				if (id_getExpireIn == IntPtr.Zero)
					id_getExpireIn = JNIEnv.GetMethodID (class_ref, "getExpireIn", "()Ljava/lang/Integer;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod  (Handle, id_getExpireIn), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getExpireIn", "()Ljava/lang/Integer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='OAuthTokensResponse']/method[@name='setExpireIn' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("setExpireIn", "(Ljava/lang/Integer;)V", "GetSetExpireIn_Ljava_lang_Integer_Handler")]
			set {
				if (id_setExpireIn_Ljava_lang_Integer_ == IntPtr.Zero)
					id_setExpireIn_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "setExpireIn", "(Ljava/lang/Integer;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setExpireIn_Ljava_lang_Integer_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setExpireIn", "(Ljava/lang/Integer;)V"), __args);
				} finally {
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
			global::Com.Coinbase.Api.Entity.OAuthTokensResponse __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.OAuthTokensResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Coinbase.Api.Entity.OAuthTokensResponse __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.OAuthTokensResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RefreshToken = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getRefreshToken;
		static IntPtr id_setRefreshToken_Ljava_lang_String_;
		public virtual unsafe string RefreshToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='OAuthTokensResponse']/method[@name='getRefreshToken' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='OAuthTokensResponse']/method[@name='setRefreshToken' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getScope;
#pragma warning disable 0169
		static Delegate GetGetScopeHandler ()
		{
			if (cb_getScope == null)
				cb_getScope = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetScope);
			return cb_getScope;
		}

		static IntPtr n_GetScope (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.OAuthTokensResponse __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.OAuthTokensResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Scope);
		}
#pragma warning restore 0169

		static Delegate cb_setScope_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetScope_Ljava_lang_String_Handler ()
		{
			if (cb_setScope_Ljava_lang_String_ == null)
				cb_setScope_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetScope_Ljava_lang_String_);
			return cb_setScope_Ljava_lang_String_;
		}

		static void n_SetScope_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.OAuthTokensResponse __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.OAuthTokensResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Scope = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getScope;
		static IntPtr id_setScope_Ljava_lang_String_;
		public virtual unsafe string Scope {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='OAuthTokensResponse']/method[@name='getScope' and count(parameter)=0]"
			[Register ("getScope", "()Ljava/lang/String;", "GetGetScopeHandler")]
			get {
				if (id_getScope == IntPtr.Zero)
					id_getScope = JNIEnv.GetMethodID (class_ref, "getScope", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getScope), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getScope", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='OAuthTokensResponse']/method[@name='setScope' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setScope", "(Ljava/lang/String;)V", "GetSetScope_Ljava_lang_String_Handler")]
			set {
				if (id_setScope_Ljava_lang_String_ == IntPtr.Zero)
					id_setScope_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setScope", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setScope_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setScope", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getTokenType;
#pragma warning disable 0169
		static Delegate GetGetTokenTypeHandler ()
		{
			if (cb_getTokenType == null)
				cb_getTokenType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTokenType);
			return cb_getTokenType;
		}

		static IntPtr n_GetTokenType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.OAuthTokensResponse __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.OAuthTokensResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TokenType);
		}
#pragma warning restore 0169

		static Delegate cb_setTokenType_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTokenType_Ljava_lang_String_Handler ()
		{
			if (cb_setTokenType_Ljava_lang_String_ == null)
				cb_setTokenType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTokenType_Ljava_lang_String_);
			return cb_setTokenType_Ljava_lang_String_;
		}

		static void n_SetTokenType_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.OAuthTokensResponse __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.OAuthTokensResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TokenType = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTokenType;
		static IntPtr id_setTokenType_Ljava_lang_String_;
		public virtual unsafe string TokenType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='OAuthTokensResponse']/method[@name='getTokenType' and count(parameter)=0]"
			[Register ("getTokenType", "()Ljava/lang/String;", "GetGetTokenTypeHandler")]
			get {
				if (id_getTokenType == IntPtr.Zero)
					id_getTokenType = JNIEnv.GetMethodID (class_ref, "getTokenType", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getTokenType), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTokenType", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='OAuthTokensResponse']/method[@name='setTokenType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTokenType", "(Ljava/lang/String;)V", "GetSetTokenType_Ljava_lang_String_Handler")]
			set {
				if (id_setTokenType_Ljava_lang_String_ == IntPtr.Zero)
					id_setTokenType_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTokenType", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setTokenType_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTokenType", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

	}
}
