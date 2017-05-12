using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Coinbase.Api.Entity {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='UserResponse']"
	[global::Android.Runtime.Register ("com/coinbase/api/entity/UserResponse", DoNotGenerateAcw=true)]
	public partial class UserResponse : global::Com.Coinbase.Api.Entity.Response {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/coinbase/api/entity/UserResponse", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UserResponse); }
		}

		protected UserResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='UserResponse']/constructor[@name='UserResponse' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe UserResponse ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (UserResponse)) {
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

		static Delegate cb_getOauth;
#pragma warning disable 0169
		static Delegate GetGetOauthHandler ()
		{
			if (cb_getOauth == null)
				cb_getOauth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOauth);
			return cb_getOauth;
		}

		static IntPtr n_GetOauth (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.UserResponse __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.UserResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Oauth);
		}
#pragma warning restore 0169

		static Delegate cb_setOauth_Lcom_coinbase_api_entity_OAuthTokensResponse_;
#pragma warning disable 0169
		static Delegate GetSetOauth_Lcom_coinbase_api_entity_OAuthTokensResponse_Handler ()
		{
			if (cb_setOauth_Lcom_coinbase_api_entity_OAuthTokensResponse_ == null)
				cb_setOauth_Lcom_coinbase_api_entity_OAuthTokensResponse_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOauth_Lcom_coinbase_api_entity_OAuthTokensResponse_);
			return cb_setOauth_Lcom_coinbase_api_entity_OAuthTokensResponse_;
		}

		static void n_SetOauth_Lcom_coinbase_api_entity_OAuthTokensResponse_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.UserResponse __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.UserResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Coinbase.Api.Entity.OAuthTokensResponse p0 = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.OAuthTokensResponse> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Oauth = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getOauth;
		static IntPtr id_setOauth_Lcom_coinbase_api_entity_OAuthTokensResponse_;
		public virtual unsafe global::Com.Coinbase.Api.Entity.OAuthTokensResponse Oauth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='UserResponse']/method[@name='getOauth' and count(parameter)=0]"
			[Register ("getOauth", "()Lcom/coinbase/api/entity/OAuthTokensResponse;", "GetGetOauthHandler")]
			get {
				if (id_getOauth == IntPtr.Zero)
					id_getOauth = JNIEnv.GetMethodID (class_ref, "getOauth", "()Lcom/coinbase/api/entity/OAuthTokensResponse;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.OAuthTokensResponse> (JNIEnv.CallObjectMethod  (Handle, id_getOauth), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.OAuthTokensResponse> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOauth", "()Lcom/coinbase/api/entity/OAuthTokensResponse;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='UserResponse']/method[@name='setOauth' and count(parameter)=1 and parameter[1][@type='com.coinbase.api.entity.OAuthTokensResponse']]"
			[Register ("setOauth", "(Lcom/coinbase/api/entity/OAuthTokensResponse;)V", "GetSetOauth_Lcom_coinbase_api_entity_OAuthTokensResponse_Handler")]
			set {
				if (id_setOauth_Lcom_coinbase_api_entity_OAuthTokensResponse_ == IntPtr.Zero)
					id_setOauth_Lcom_coinbase_api_entity_OAuthTokensResponse_ = JNIEnv.GetMethodID (class_ref, "setOauth", "(Lcom/coinbase/api/entity/OAuthTokensResponse;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setOauth_Lcom_coinbase_api_entity_OAuthTokensResponse_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOauth", "(Lcom/coinbase/api/entity/OAuthTokensResponse;)V"), __args);
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
			global::Com.Coinbase.Api.Entity.UserResponse __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.UserResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Coinbase.Api.Entity.UserResponse __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.UserResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Coinbase.Api.Entity.User p0 = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.User> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.User = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getUser;
		static IntPtr id_setUser_Lcom_coinbase_api_entity_User_;
		public virtual unsafe global::Com.Coinbase.Api.Entity.User User {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='UserResponse']/method[@name='getUser' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='UserResponse']/method[@name='setUser' and count(parameter)=1 and parameter[1][@type='com.coinbase.api.entity.User']]"
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
