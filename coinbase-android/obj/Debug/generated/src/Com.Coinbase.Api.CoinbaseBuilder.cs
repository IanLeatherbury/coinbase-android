using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Coinbase.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.coinbase.api']/class[@name='CoinbaseBuilder']"
	[global::Android.Runtime.Register ("com/coinbase/api/CoinbaseBuilder", DoNotGenerateAcw=true)]
	public partial class CoinbaseBuilder : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/coinbase/api/CoinbaseBuilder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CoinbaseBuilder); }
		}

		protected CoinbaseBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.coinbase.api']/class[@name='CoinbaseBuilder']/constructor[@name='CoinbaseBuilder' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CoinbaseBuilder ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (CoinbaseBuilder)) {
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

		static Delegate cb_withAccessToken_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetWithAccessToken_Ljava_lang_String_Handler ()
		{
			if (cb_withAccessToken_Ljava_lang_String_ == null)
				cb_withAccessToken_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithAccessToken_Ljava_lang_String_);
			return cb_withAccessToken_Ljava_lang_String_;
		}

		static IntPtr n_WithAccessToken_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.CoinbaseBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.CoinbaseBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithAccessToken (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withAccessToken_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api']/class[@name='CoinbaseBuilder']/method[@name='withAccessToken' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("withAccessToken", "(Ljava/lang/String;)Lcom/coinbase/api/CoinbaseBuilder;", "GetWithAccessToken_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Coinbase.Api.CoinbaseBuilder WithAccessToken (string p0)
		{
			if (id_withAccessToken_Ljava_lang_String_ == IntPtr.Zero)
				id_withAccessToken_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "withAccessToken", "(Ljava/lang/String;)Lcom/coinbase/api/CoinbaseBuilder;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Coinbase.Api.CoinbaseBuilder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.CoinbaseBuilder> (JNIEnv.CallObjectMethod  (Handle, id_withAccessToken_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.CoinbaseBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withAccessToken", "(Ljava/lang/String;)Lcom/coinbase/api/CoinbaseBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_withAccountId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetWithAccountId_Ljava_lang_String_Handler ()
		{
			if (cb_withAccountId_Ljava_lang_String_ == null)
				cb_withAccountId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithAccountId_Ljava_lang_String_);
			return cb_withAccountId_Ljava_lang_String_;
		}

		static IntPtr n_WithAccountId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.CoinbaseBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.CoinbaseBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithAccountId (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withAccountId_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api']/class[@name='CoinbaseBuilder']/method[@name='withAccountId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("withAccountId", "(Ljava/lang/String;)Lcom/coinbase/api/CoinbaseBuilder;", "GetWithAccountId_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Coinbase.Api.CoinbaseBuilder WithAccountId (string p0)
		{
			if (id_withAccountId_Ljava_lang_String_ == IntPtr.Zero)
				id_withAccountId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "withAccountId", "(Ljava/lang/String;)Lcom/coinbase/api/CoinbaseBuilder;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Coinbase.Api.CoinbaseBuilder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.CoinbaseBuilder> (JNIEnv.CallObjectMethod  (Handle, id_withAccountId_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.CoinbaseBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withAccountId", "(Ljava/lang/String;)Lcom/coinbase/api/CoinbaseBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_withApiKey_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetWithApiKey_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_withApiKey_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_withApiKey_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_WithApiKey_Ljava_lang_String_Ljava_lang_String_);
			return cb_withApiKey_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_WithApiKey_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Coinbase.Api.CoinbaseBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.CoinbaseBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithApiKey (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withApiKey_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api']/class[@name='CoinbaseBuilder']/method[@name='withApiKey' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("withApiKey", "(Ljava/lang/String;Ljava/lang/String;)Lcom/coinbase/api/CoinbaseBuilder;", "GetWithApiKey_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Coinbase.Api.CoinbaseBuilder WithApiKey (string p0, string p1)
		{
			if (id_withApiKey_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_withApiKey_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "withApiKey", "(Ljava/lang/String;Ljava/lang/String;)Lcom/coinbase/api/CoinbaseBuilder;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				global::Com.Coinbase.Api.CoinbaseBuilder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.CoinbaseBuilder> (JNIEnv.CallObjectMethod  (Handle, id_withApiKey_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.CoinbaseBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withApiKey", "(Ljava/lang/String;Ljava/lang/String;)Lcom/coinbase/api/CoinbaseBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_withBaseApiURL_Ljava_net_URL_;
#pragma warning disable 0169
		static Delegate GetWithBaseApiURL_Ljava_net_URL_Handler ()
		{
			if (cb_withBaseApiURL_Ljava_net_URL_ == null)
				cb_withBaseApiURL_Ljava_net_URL_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithBaseApiURL_Ljava_net_URL_);
			return cb_withBaseApiURL_Ljava_net_URL_;
		}

		static IntPtr n_WithBaseApiURL_Ljava_net_URL_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.CoinbaseBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.CoinbaseBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Net.URL p0 = global::Java.Lang.Object.GetObject<global::Java.Net.URL> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithBaseApiURL (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withBaseApiURL_Ljava_net_URL_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api']/class[@name='CoinbaseBuilder']/method[@name='withBaseApiURL' and count(parameter)=1 and parameter[1][@type='java.net.URL']]"
		[Register ("withBaseApiURL", "(Ljava/net/URL;)Lcom/coinbase/api/CoinbaseBuilder;", "GetWithBaseApiURL_Ljava_net_URL_Handler")]
		public virtual unsafe global::Com.Coinbase.Api.CoinbaseBuilder WithBaseApiURL (global::Java.Net.URL p0)
		{
			if (id_withBaseApiURL_Ljava_net_URL_ == IntPtr.Zero)
				id_withBaseApiURL_Ljava_net_URL_ = JNIEnv.GetMethodID (class_ref, "withBaseApiURL", "(Ljava/net/URL;)Lcom/coinbase/api/CoinbaseBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Coinbase.Api.CoinbaseBuilder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.CoinbaseBuilder> (JNIEnv.CallObjectMethod  (Handle, id_withBaseApiURL_Ljava_net_URL_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.CoinbaseBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withBaseApiURL", "(Ljava/net/URL;)Lcom/coinbase/api/CoinbaseBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_withBaseOAuthURL_Ljava_net_URL_;
#pragma warning disable 0169
		static Delegate GetWithBaseOAuthURL_Ljava_net_URL_Handler ()
		{
			if (cb_withBaseOAuthURL_Ljava_net_URL_ == null)
				cb_withBaseOAuthURL_Ljava_net_URL_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithBaseOAuthURL_Ljava_net_URL_);
			return cb_withBaseOAuthURL_Ljava_net_URL_;
		}

		static IntPtr n_WithBaseOAuthURL_Ljava_net_URL_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.CoinbaseBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.CoinbaseBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Net.URL p0 = global::Java.Lang.Object.GetObject<global::Java.Net.URL> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithBaseOAuthURL (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withBaseOAuthURL_Ljava_net_URL_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api']/class[@name='CoinbaseBuilder']/method[@name='withBaseOAuthURL' and count(parameter)=1 and parameter[1][@type='java.net.URL']]"
		[Register ("withBaseOAuthURL", "(Ljava/net/URL;)Lcom/coinbase/api/CoinbaseBuilder;", "GetWithBaseOAuthURL_Ljava_net_URL_Handler")]
		public virtual unsafe global::Com.Coinbase.Api.CoinbaseBuilder WithBaseOAuthURL (global::Java.Net.URL p0)
		{
			if (id_withBaseOAuthURL_Ljava_net_URL_ == IntPtr.Zero)
				id_withBaseOAuthURL_Ljava_net_URL_ = JNIEnv.GetMethodID (class_ref, "withBaseOAuthURL", "(Ljava/net/URL;)Lcom/coinbase/api/CoinbaseBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Coinbase.Api.CoinbaseBuilder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.CoinbaseBuilder> (JNIEnv.CallObjectMethod  (Handle, id_withBaseOAuthURL_Ljava_net_URL_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.CoinbaseBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withBaseOAuthURL", "(Ljava/net/URL;)Lcom/coinbase/api/CoinbaseBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_withSSLContext_Ljavax_net_ssl_SSLContext_;
#pragma warning disable 0169
		static Delegate GetWithSSLContext_Ljavax_net_ssl_SSLContext_Handler ()
		{
			if (cb_withSSLContext_Ljavax_net_ssl_SSLContext_ == null)
				cb_withSSLContext_Ljavax_net_ssl_SSLContext_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithSSLContext_Ljavax_net_ssl_SSLContext_);
			return cb_withSSLContext_Ljavax_net_ssl_SSLContext_;
		}

		static IntPtr n_WithSSLContext_Ljavax_net_ssl_SSLContext_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.CoinbaseBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.CoinbaseBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Javax.Net.Ssl.SSLContext p0 = global::Java.Lang.Object.GetObject<global::Javax.Net.Ssl.SSLContext> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithSSLContext (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withSSLContext_Ljavax_net_ssl_SSLContext_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api']/class[@name='CoinbaseBuilder']/method[@name='withSSLContext' and count(parameter)=1 and parameter[1][@type='javax.net.ssl.SSLContext']]"
		[Register ("withSSLContext", "(Ljavax/net/ssl/SSLContext;)Lcom/coinbase/api/CoinbaseBuilder;", "GetWithSSLContext_Ljavax_net_ssl_SSLContext_Handler")]
		public virtual unsafe global::Com.Coinbase.Api.CoinbaseBuilder WithSSLContext (global::Javax.Net.Ssl.SSLContext p0)
		{
			if (id_withSSLContext_Ljavax_net_ssl_SSLContext_ == IntPtr.Zero)
				id_withSSLContext_Ljavax_net_ssl_SSLContext_ = JNIEnv.GetMethodID (class_ref, "withSSLContext", "(Ljavax/net/ssl/SSLContext;)Lcom/coinbase/api/CoinbaseBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Coinbase.Api.CoinbaseBuilder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.CoinbaseBuilder> (JNIEnv.CallObjectMethod  (Handle, id_withSSLContext_Ljavax_net_ssl_SSLContext_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.CoinbaseBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withSSLContext", "(Ljavax/net/ssl/SSLContext;)Lcom/coinbase/api/CoinbaseBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
