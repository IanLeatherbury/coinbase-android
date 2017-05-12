using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Coinbase.Api.Entity {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='TokenResponse']"
	[global::Android.Runtime.Register ("com/coinbase/api/entity/TokenResponse", DoNotGenerateAcw=true)]
	public partial class TokenResponse : global::Com.Coinbase.Api.Entity.Response {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/coinbase/api/entity/TokenResponse", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TokenResponse); }
		}

		protected TokenResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='TokenResponse']/constructor[@name='TokenResponse' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TokenResponse ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (TokenResponse)) {
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

		static Delegate cb_getToken;
#pragma warning disable 0169
		static Delegate GetGetTokenHandler ()
		{
			if (cb_getToken == null)
				cb_getToken = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetToken);
			return cb_getToken;
		}

		static IntPtr n_GetToken (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.TokenResponse __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.TokenResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Token);
		}
#pragma warning restore 0169

		static Delegate cb_setToken_Lcom_coinbase_api_entity_Token_;
#pragma warning disable 0169
		static Delegate GetSetToken_Lcom_coinbase_api_entity_Token_Handler ()
		{
			if (cb_setToken_Lcom_coinbase_api_entity_Token_ == null)
				cb_setToken_Lcom_coinbase_api_entity_Token_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetToken_Lcom_coinbase_api_entity_Token_);
			return cb_setToken_Lcom_coinbase_api_entity_Token_;
		}

		static void n_SetToken_Lcom_coinbase_api_entity_Token_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.TokenResponse __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.TokenResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Coinbase.Api.Entity.Token p0 = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Token> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Token = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getToken;
		static IntPtr id_setToken_Lcom_coinbase_api_entity_Token_;
		public virtual unsafe global::Com.Coinbase.Api.Entity.Token Token {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='TokenResponse']/method[@name='getToken' and count(parameter)=0]"
			[Register ("getToken", "()Lcom/coinbase/api/entity/Token;", "GetGetTokenHandler")]
			get {
				if (id_getToken == IntPtr.Zero)
					id_getToken = JNIEnv.GetMethodID (class_ref, "getToken", "()Lcom/coinbase/api/entity/Token;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Token> (JNIEnv.CallObjectMethod  (Handle, id_getToken), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Token> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getToken", "()Lcom/coinbase/api/entity/Token;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='TokenResponse']/method[@name='setToken' and count(parameter)=1 and parameter[1][@type='com.coinbase.api.entity.Token']]"
			[Register ("setToken", "(Lcom/coinbase/api/entity/Token;)V", "GetSetToken_Lcom_coinbase_api_entity_Token_Handler")]
			set {
				if (id_setToken_Lcom_coinbase_api_entity_Token_ == IntPtr.Zero)
					id_setToken_Lcom_coinbase_api_entity_Token_ = JNIEnv.GetMethodID (class_ref, "setToken", "(Lcom/coinbase/api/entity/Token;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setToken_Lcom_coinbase_api_entity_Token_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setToken", "(Lcom/coinbase/api/entity/Token;)V"), __args);
				} finally {
				}
			}
		}

	}
}
