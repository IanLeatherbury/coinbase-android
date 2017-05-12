using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Coinbase.Api.Entity {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Merchant']"
	[global::Android.Runtime.Register ("com/coinbase/api/entity/Merchant", DoNotGenerateAcw=true)]
	public partial class Merchant : global::Java.Lang.Object, global::Java.IO.ISerializable {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Merchant.Logo']"
		[global::Android.Runtime.Register ("com/coinbase/api/entity/Merchant$Logo", DoNotGenerateAcw=true)]
		public partial class Logo : global::Java.Lang.Object, global::Java.IO.ISerializable {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/coinbase/api/entity/Merchant$Logo", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Logo); }
			}

			protected Logo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Merchant.Logo']/constructor[@name='Merchant.Logo' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Logo ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (Logo)) {
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

			static Delegate cb_getMedium;
#pragma warning disable 0169
			static Delegate GetGetMediumHandler ()
			{
				if (cb_getMedium == null)
					cb_getMedium = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMedium);
				return cb_getMedium;
			}

			static IntPtr n_GetMedium (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Coinbase.Api.Entity.Merchant.Logo __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Merchant.Logo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Medium);
			}
#pragma warning restore 0169

			static Delegate cb_setMedium_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetMedium_Ljava_lang_String_Handler ()
			{
				if (cb_setMedium_Ljava_lang_String_ == null)
					cb_setMedium_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMedium_Ljava_lang_String_);
				return cb_setMedium_Ljava_lang_String_;
			}

			static void n_SetMedium_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Coinbase.Api.Entity.Merchant.Logo __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Merchant.Logo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.Medium = p0;
			}
#pragma warning restore 0169

			static IntPtr id_getMedium;
			static IntPtr id_setMedium_Ljava_lang_String_;
			public virtual unsafe string Medium {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Merchant.Logo']/method[@name='getMedium' and count(parameter)=0]"
				[Register ("getMedium", "()Ljava/lang/String;", "GetGetMediumHandler")]
				get {
					if (id_getMedium == IntPtr.Zero)
						id_getMedium = JNIEnv.GetMethodID (class_ref, "getMedium", "()Ljava/lang/String;");
					try {

						if (GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getMedium), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMedium", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Merchant.Logo']/method[@name='setMedium' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("setMedium", "(Ljava/lang/String;)V", "GetSetMedium_Ljava_lang_String_Handler")]
				set {
					if (id_setMedium_Ljava_lang_String_ == IntPtr.Zero)
						id_setMedium_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setMedium", "(Ljava/lang/String;)V");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (native_value);

						if (GetType () == ThresholdType)
							JNIEnv.CallVoidMethod  (Handle, id_setMedium_Ljava_lang_String_, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMedium", "(Ljava/lang/String;)V"), __args);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static Delegate cb_getSmall;
#pragma warning disable 0169
			static Delegate GetGetSmallHandler ()
			{
				if (cb_getSmall == null)
					cb_getSmall = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSmall);
				return cb_getSmall;
			}

			static IntPtr n_GetSmall (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Coinbase.Api.Entity.Merchant.Logo __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Merchant.Logo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Small);
			}
#pragma warning restore 0169

			static Delegate cb_setSmall_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetSmall_Ljava_lang_String_Handler ()
			{
				if (cb_setSmall_Ljava_lang_String_ == null)
					cb_setSmall_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSmall_Ljava_lang_String_);
				return cb_setSmall_Ljava_lang_String_;
			}

			static void n_SetSmall_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Coinbase.Api.Entity.Merchant.Logo __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Merchant.Logo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.Small = p0;
			}
#pragma warning restore 0169

			static IntPtr id_getSmall;
			static IntPtr id_setSmall_Ljava_lang_String_;
			public virtual unsafe string Small {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Merchant.Logo']/method[@name='getSmall' and count(parameter)=0]"
				[Register ("getSmall", "()Ljava/lang/String;", "GetGetSmallHandler")]
				get {
					if (id_getSmall == IntPtr.Zero)
						id_getSmall = JNIEnv.GetMethodID (class_ref, "getSmall", "()Ljava/lang/String;");
					try {

						if (GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getSmall), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSmall", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Merchant.Logo']/method[@name='setSmall' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("setSmall", "(Ljava/lang/String;)V", "GetSetSmall_Ljava_lang_String_Handler")]
				set {
					if (id_setSmall_Ljava_lang_String_ == IntPtr.Zero)
						id_setSmall_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setSmall", "(Ljava/lang/String;)V");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (native_value);

						if (GetType () == ThresholdType)
							JNIEnv.CallVoidMethod  (Handle, id_setSmall_Ljava_lang_String_, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSmall", "(Ljava/lang/String;)V"), __args);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static Delegate cb_getUrl;
#pragma warning disable 0169
			static Delegate GetGetUrlHandler ()
			{
				if (cb_getUrl == null)
					cb_getUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUrl);
				return cb_getUrl;
			}

			static IntPtr n_GetUrl (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Coinbase.Api.Entity.Merchant.Logo __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Merchant.Logo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Url);
			}
#pragma warning restore 0169

			static Delegate cb_setUrl_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetUrl_Ljava_lang_String_Handler ()
			{
				if (cb_setUrl_Ljava_lang_String_ == null)
					cb_setUrl_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetUrl_Ljava_lang_String_);
				return cb_setUrl_Ljava_lang_String_;
			}

			static void n_SetUrl_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Coinbase.Api.Entity.Merchant.Logo __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Merchant.Logo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.Url = p0;
			}
#pragma warning restore 0169

			static IntPtr id_getUrl;
			static IntPtr id_setUrl_Ljava_lang_String_;
			public virtual unsafe string Url {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Merchant.Logo']/method[@name='getUrl' and count(parameter)=0]"
				[Register ("getUrl", "()Ljava/lang/String;", "GetGetUrlHandler")]
				get {
					if (id_getUrl == IntPtr.Zero)
						id_getUrl = JNIEnv.GetMethodID (class_ref, "getUrl", "()Ljava/lang/String;");
					try {

						if (GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getUrl), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Merchant.Logo']/method[@name='setUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("setUrl", "(Ljava/lang/String;)V", "GetSetUrl_Ljava_lang_String_Handler")]
				set {
					if (id_setUrl_Ljava_lang_String_ == IntPtr.Zero)
						id_setUrl_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setUrl", "(Ljava/lang/String;)V");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (native_value);

						if (GetType () == ThresholdType)
							JNIEnv.CallVoidMethod  (Handle, id_setUrl_Ljava_lang_String_, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUrl", "(Ljava/lang/String;)V"), __args);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/coinbase/api/entity/Merchant", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Merchant); }
		}

		protected Merchant (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Merchant']/constructor[@name='Merchant' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Merchant ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Merchant)) {
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

		static Delegate cb_getCompanyName;
#pragma warning disable 0169
		static Delegate GetGetCompanyNameHandler ()
		{
			if (cb_getCompanyName == null)
				cb_getCompanyName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCompanyName);
			return cb_getCompanyName;
		}

		static IntPtr n_GetCompanyName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.Merchant __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Merchant> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CompanyName);
		}
#pragma warning restore 0169

		static Delegate cb_setCompanyName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCompanyName_Ljava_lang_String_Handler ()
		{
			if (cb_setCompanyName_Ljava_lang_String_ == null)
				cb_setCompanyName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCompanyName_Ljava_lang_String_);
			return cb_setCompanyName_Ljava_lang_String_;
		}

		static void n_SetCompanyName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.Merchant __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Merchant> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CompanyName = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCompanyName;
		static IntPtr id_setCompanyName_Ljava_lang_String_;
		public virtual unsafe string CompanyName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Merchant']/method[@name='getCompanyName' and count(parameter)=0]"
			[Register ("getCompanyName", "()Ljava/lang/String;", "GetGetCompanyNameHandler")]
			get {
				if (id_getCompanyName == IntPtr.Zero)
					id_getCompanyName = JNIEnv.GetMethodID (class_ref, "getCompanyName", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getCompanyName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCompanyName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Merchant']/method[@name='setCompanyName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCompanyName", "(Ljava/lang/String;)V", "GetSetCompanyName_Ljava_lang_String_Handler")]
			set {
				if (id_setCompanyName_Ljava_lang_String_ == IntPtr.Zero)
					id_setCompanyName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCompanyName", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setCompanyName_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCompanyName", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getLogo;
#pragma warning disable 0169
		static Delegate GetGetLogoHandler ()
		{
			if (cb_getLogo == null)
				cb_getLogo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLogo);
			return cb_getLogo;
		}

		static IntPtr n_GetLogo (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.Merchant __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Merchant> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetLogo ());
		}
#pragma warning restore 0169

		static IntPtr id_getLogo;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Merchant']/method[@name='getLogo' and count(parameter)=0]"
		[Register ("getLogo", "()Lcom/coinbase/api/entity/Merchant$Logo;", "GetGetLogoHandler")]
		public virtual unsafe global::Com.Coinbase.Api.Entity.Merchant.Logo GetLogo ()
		{
			if (id_getLogo == IntPtr.Zero)
				id_getLogo = JNIEnv.GetMethodID (class_ref, "getLogo", "()Lcom/coinbase/api/entity/Merchant$Logo;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Merchant.Logo> (JNIEnv.CallObjectMethod  (Handle, id_getLogo), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Merchant.Logo> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLogo", "()Lcom/coinbase/api/entity/Merchant$Logo;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setLogo_Lcom_coinbase_api_entity_Merchant_Logo_;
#pragma warning disable 0169
		static Delegate GetSetLogo_Lcom_coinbase_api_entity_Merchant_Logo_Handler ()
		{
			if (cb_setLogo_Lcom_coinbase_api_entity_Merchant_Logo_ == null)
				cb_setLogo_Lcom_coinbase_api_entity_Merchant_Logo_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLogo_Lcom_coinbase_api_entity_Merchant_Logo_);
			return cb_setLogo_Lcom_coinbase_api_entity_Merchant_Logo_;
		}

		static void n_SetLogo_Lcom_coinbase_api_entity_Merchant_Logo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.Merchant __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Merchant> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Coinbase.Api.Entity.Merchant.Logo p0 = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Merchant.Logo> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetLogo (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setLogo_Lcom_coinbase_api_entity_Merchant_Logo_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Merchant']/method[@name='setLogo' and count(parameter)=1 and parameter[1][@type='com.coinbase.api.entity.Merchant.Logo']]"
		[Register ("setLogo", "(Lcom/coinbase/api/entity/Merchant$Logo;)V", "GetSetLogo_Lcom_coinbase_api_entity_Merchant_Logo_Handler")]
		public virtual unsafe void SetLogo (global::Com.Coinbase.Api.Entity.Merchant.Logo p0)
		{
			if (id_setLogo_Lcom_coinbase_api_entity_Merchant_Logo_ == IntPtr.Zero)
				id_setLogo_Lcom_coinbase_api_entity_Merchant_Logo_ = JNIEnv.GetMethodID (class_ref, "setLogo", "(Lcom/coinbase/api/entity/Merchant$Logo;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setLogo_Lcom_coinbase_api_entity_Merchant_Logo_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLogo", "(Lcom/coinbase/api/entity/Merchant$Logo;)V"), __args);
			} finally {
			}
		}

	}
}
