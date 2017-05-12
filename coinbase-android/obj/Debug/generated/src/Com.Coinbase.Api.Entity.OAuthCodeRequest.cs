using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Coinbase.Api.Entity {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='OAuthCodeRequest']"
	[global::Android.Runtime.Register ("com/coinbase/api/entity/OAuthCodeRequest", DoNotGenerateAcw=true)]
	public partial class OAuthCodeRequest : global::Java.Lang.Object, global::Java.IO.ISerializable {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='OAuthCodeRequest.Meta']"
		[global::Android.Runtime.Register ("com/coinbase/api/entity/OAuthCodeRequest$Meta", DoNotGenerateAcw=true)]
		public partial class Meta : global::Java.Lang.Object, global::Java.IO.ISerializable {

			// Metadata.xml XPath class reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='OAuthCodeRequest.Meta.Period']"
			[global::Android.Runtime.Register ("com/coinbase/api/entity/OAuthCodeRequest$Meta$Period", DoNotGenerateAcw=true)]
			public sealed partial class Period : global::Java.Lang.Enum {


				static IntPtr DAILY_jfieldId;

				// Metadata.xml XPath field reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='OAuthCodeRequest.Meta.Period']/field[@name='DAILY']"
				[Register ("DAILY")]
				public static global::Com.Coinbase.Api.Entity.OAuthCodeRequest.Meta.Period Daily {
					get {
						if (DAILY_jfieldId == IntPtr.Zero)
							DAILY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DAILY", "Lcom/coinbase/api/entity/OAuthCodeRequest$Meta$Period;");
						IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DAILY_jfieldId);
						return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.OAuthCodeRequest.Meta.Period> (__ret, JniHandleOwnership.TransferLocalRef);
					}
				}

				static IntPtr MONTHLY_jfieldId;

				// Metadata.xml XPath field reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='OAuthCodeRequest.Meta.Period']/field[@name='MONTHLY']"
				[Register ("MONTHLY")]
				public static global::Com.Coinbase.Api.Entity.OAuthCodeRequest.Meta.Period Monthly {
					get {
						if (MONTHLY_jfieldId == IntPtr.Zero)
							MONTHLY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MONTHLY", "Lcom/coinbase/api/entity/OAuthCodeRequest$Meta$Period;");
						IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MONTHLY_jfieldId);
						return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.OAuthCodeRequest.Meta.Period> (__ret, JniHandleOwnership.TransferLocalRef);
					}
				}

				static IntPtr WEEKLY_jfieldId;

				// Metadata.xml XPath field reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='OAuthCodeRequest.Meta.Period']/field[@name='WEEKLY']"
				[Register ("WEEKLY")]
				public static global::Com.Coinbase.Api.Entity.OAuthCodeRequest.Meta.Period Weekly {
					get {
						if (WEEKLY_jfieldId == IntPtr.Zero)
							WEEKLY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "WEEKLY", "Lcom/coinbase/api/entity/OAuthCodeRequest$Meta$Period;");
						IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, WEEKLY_jfieldId);
						return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.OAuthCodeRequest.Meta.Period> (__ret, JniHandleOwnership.TransferLocalRef);
					}
				}
				internal static IntPtr java_class_handle;
				internal static IntPtr class_ref {
					get {
						return JNIEnv.FindClass ("com/coinbase/api/entity/OAuthCodeRequest$Meta$Period", ref java_class_handle);
					}
				}

				protected override IntPtr ThresholdClass {
					get { return class_ref; }
				}

				protected override global::System.Type ThresholdType {
					get { return typeof (Period); }
				}

				internal Period (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

				static IntPtr id_create_Ljava_lang_String_;
				// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='OAuthCodeRequest.Meta.Period']/method[@name='create' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("create", "(Ljava/lang/String;)Lcom/coinbase/api/entity/OAuthCodeRequest$Meta$Period;", "")]
				public static unsafe global::Com.Coinbase.Api.Entity.OAuthCodeRequest.Meta.Period Create (string p0)
				{
					if (id_create_Ljava_lang_String_ == IntPtr.Zero)
						id_create_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "create", "(Ljava/lang/String;)Lcom/coinbase/api/entity/OAuthCodeRequest$Meta$Period;");
					IntPtr native_p0 = JNIEnv.NewString (p0);
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (native_p0);
						global::Com.Coinbase.Api.Entity.OAuthCodeRequest.Meta.Period __ret = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.OAuthCodeRequest.Meta.Period> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
						return __ret;
					} finally {
						JNIEnv.DeleteLocalRef (native_p0);
					}
				}

				static IntPtr id_valueOf_Ljava_lang_String_;
				// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='OAuthCodeRequest.Meta.Period']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("valueOf", "(Ljava/lang/String;)Lcom/coinbase/api/entity/OAuthCodeRequest$Meta$Period;", "")]
				public static unsafe global::Com.Coinbase.Api.Entity.OAuthCodeRequest.Meta.Period ValueOf (string p0)
				{
					if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
						id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/coinbase/api/entity/OAuthCodeRequest$Meta$Period;");
					IntPtr native_p0 = JNIEnv.NewString (p0);
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (native_p0);
						global::Com.Coinbase.Api.Entity.OAuthCodeRequest.Meta.Period __ret = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.OAuthCodeRequest.Meta.Period> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
						return __ret;
					} finally {
						JNIEnv.DeleteLocalRef (native_p0);
					}
				}

				static IntPtr id_values;
				// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='OAuthCodeRequest.Meta.Period']/method[@name='values' and count(parameter)=0]"
				[Register ("values", "()[Lcom/coinbase/api/entity/OAuthCodeRequest$Meta$Period;", "")]
				public static unsafe global::Com.Coinbase.Api.Entity.OAuthCodeRequest.Meta.Period[] Values ()
				{
					if (id_values == IntPtr.Zero)
						id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/coinbase/api/entity/OAuthCodeRequest$Meta$Period;");
					try {
						return (global::Com.Coinbase.Api.Entity.OAuthCodeRequest.Meta.Period[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Coinbase.Api.Entity.OAuthCodeRequest.Meta.Period));
					} finally {
					}
				}

			}

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/coinbase/api/entity/OAuthCodeRequest$Meta", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Meta); }
			}

			protected Meta (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='OAuthCodeRequest.Meta']/constructor[@name='OAuthCodeRequest.Meta' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Meta ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (Meta)) {
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
				global::Com.Coinbase.Api.Entity.OAuthCodeRequest.Meta __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.OAuthCodeRequest.Meta> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				global::Com.Coinbase.Api.Entity.OAuthCodeRequest.Meta __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.OAuthCodeRequest.Meta> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.Name = p0;
			}
#pragma warning restore 0169

			static IntPtr id_getName;
			static IntPtr id_setName_Ljava_lang_String_;
			public virtual unsafe string Name {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='OAuthCodeRequest.Meta']/method[@name='getName' and count(parameter)=0]"
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
				// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='OAuthCodeRequest.Meta']/method[@name='setName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

			static Delegate cb_getSendLimitCurrency;
#pragma warning disable 0169
			static Delegate GetGetSendLimitCurrencyHandler ()
			{
				if (cb_getSendLimitCurrency == null)
					cb_getSendLimitCurrency = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSendLimitCurrency);
				return cb_getSendLimitCurrency;
			}

			static IntPtr n_GetSendLimitCurrency (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Coinbase.Api.Entity.OAuthCodeRequest.Meta __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.OAuthCodeRequest.Meta> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.SendLimitCurrency);
			}
#pragma warning restore 0169

			static IntPtr id_getSendLimitCurrency;
			public virtual unsafe string SendLimitCurrency {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='OAuthCodeRequest.Meta']/method[@name='getSendLimitCurrency' and count(parameter)=0]"
				[Register ("getSendLimitCurrency", "()Ljava/lang/String;", "GetGetSendLimitCurrencyHandler")]
				get {
					if (id_getSendLimitCurrency == IntPtr.Zero)
						id_getSendLimitCurrency = JNIEnv.GetMethodID (class_ref, "getSendLimitCurrency", "()Ljava/lang/String;");
					try {

						if (GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getSendLimitCurrency), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSendLimitCurrency", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getSendLimitPeriod;
#pragma warning disable 0169
			static Delegate GetGetSendLimitPeriodHandler ()
			{
				if (cb_getSendLimitPeriod == null)
					cb_getSendLimitPeriod = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSendLimitPeriod);
				return cb_getSendLimitPeriod;
			}

			static IntPtr n_GetSendLimitPeriod (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Coinbase.Api.Entity.OAuthCodeRequest.Meta __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.OAuthCodeRequest.Meta> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SendLimitPeriod);
			}
#pragma warning restore 0169

			static Delegate cb_setSendLimitPeriod_Lcom_coinbase_api_entity_OAuthCodeRequest_Meta_Period_;
#pragma warning disable 0169
			static Delegate GetSetSendLimitPeriod_Lcom_coinbase_api_entity_OAuthCodeRequest_Meta_Period_Handler ()
			{
				if (cb_setSendLimitPeriod_Lcom_coinbase_api_entity_OAuthCodeRequest_Meta_Period_ == null)
					cb_setSendLimitPeriod_Lcom_coinbase_api_entity_OAuthCodeRequest_Meta_Period_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSendLimitPeriod_Lcom_coinbase_api_entity_OAuthCodeRequest_Meta_Period_);
				return cb_setSendLimitPeriod_Lcom_coinbase_api_entity_OAuthCodeRequest_Meta_Period_;
			}

			static void n_SetSendLimitPeriod_Lcom_coinbase_api_entity_OAuthCodeRequest_Meta_Period_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Coinbase.Api.Entity.OAuthCodeRequest.Meta __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.OAuthCodeRequest.Meta> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Coinbase.Api.Entity.OAuthCodeRequest.Meta.Period p0 = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.OAuthCodeRequest.Meta.Period> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.SendLimitPeriod = p0;
			}
#pragma warning restore 0169

			static IntPtr id_getSendLimitPeriod;
			static IntPtr id_setSendLimitPeriod_Lcom_coinbase_api_entity_OAuthCodeRequest_Meta_Period_;
			public virtual unsafe global::Com.Coinbase.Api.Entity.OAuthCodeRequest.Meta.Period SendLimitPeriod {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='OAuthCodeRequest.Meta']/method[@name='getSendLimitPeriod' and count(parameter)=0]"
				[Register ("getSendLimitPeriod", "()Lcom/coinbase/api/entity/OAuthCodeRequest$Meta$Period;", "GetGetSendLimitPeriodHandler")]
				get {
					if (id_getSendLimitPeriod == IntPtr.Zero)
						id_getSendLimitPeriod = JNIEnv.GetMethodID (class_ref, "getSendLimitPeriod", "()Lcom/coinbase/api/entity/OAuthCodeRequest$Meta$Period;");
					try {

						if (GetType () == ThresholdType)
							return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.OAuthCodeRequest.Meta.Period> (JNIEnv.CallObjectMethod  (Handle, id_getSendLimitPeriod), JniHandleOwnership.TransferLocalRef);
						else
							return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.OAuthCodeRequest.Meta.Period> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSendLimitPeriod", "()Lcom/coinbase/api/entity/OAuthCodeRequest$Meta$Period;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='OAuthCodeRequest.Meta']/method[@name='setSendLimitPeriod' and count(parameter)=1 and parameter[1][@type='com.coinbase.api.entity.OAuthCodeRequest.Meta.Period']]"
				[Register ("setSendLimitPeriod", "(Lcom/coinbase/api/entity/OAuthCodeRequest$Meta$Period;)V", "GetSetSendLimitPeriod_Lcom_coinbase_api_entity_OAuthCodeRequest_Meta_Period_Handler")]
				set {
					if (id_setSendLimitPeriod_Lcom_coinbase_api_entity_OAuthCodeRequest_Meta_Period_ == IntPtr.Zero)
						id_setSendLimitPeriod_Lcom_coinbase_api_entity_OAuthCodeRequest_Meta_Period_ = JNIEnv.GetMethodID (class_ref, "setSendLimitPeriod", "(Lcom/coinbase/api/entity/OAuthCodeRequest$Meta$Period;)V");
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (value);

						if (GetType () == ThresholdType)
							JNIEnv.CallVoidMethod  (Handle, id_setSendLimitPeriod_Lcom_coinbase_api_entity_OAuthCodeRequest_Meta_Period_, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSendLimitPeriod", "(Lcom/coinbase/api/entity/OAuthCodeRequest$Meta$Period;)V"), __args);
					} finally {
					}
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/coinbase/api/entity/OAuthCodeRequest", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (OAuthCodeRequest); }
		}

		protected OAuthCodeRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='OAuthCodeRequest']/constructor[@name='OAuthCodeRequest' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe OAuthCodeRequest ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (OAuthCodeRequest)) {
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
			global::Com.Coinbase.Api.Entity.OAuthCodeRequest __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.OAuthCodeRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Coinbase.Api.Entity.OAuthCodeRequest __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.OAuthCodeRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ClientId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getClientId;
		static IntPtr id_setClientId_Ljava_lang_String_;
		public virtual unsafe string ClientId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='OAuthCodeRequest']/method[@name='getClientId' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='OAuthCodeRequest']/method[@name='setClientId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Coinbase.Api.Entity.OAuthCodeRequest __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.OAuthCodeRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Coinbase.Api.Entity.OAuthCodeRequest __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.OAuthCodeRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ClientSecret = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getClientSecret;
		static IntPtr id_setClientSecret_Ljava_lang_String_;
		public virtual unsafe string ClientSecret {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='OAuthCodeRequest']/method[@name='getClientSecret' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='OAuthCodeRequest']/method[@name='setClientSecret' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Coinbase.Api.Entity.OAuthCodeRequest __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.OAuthCodeRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Coinbase.Api.Entity.OAuthCodeRequest __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.OAuthCodeRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Password = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getPassword;
		static IntPtr id_setPassword_Ljava_lang_String_;
		public virtual unsafe string Password {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='OAuthCodeRequest']/method[@name='getPassword' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='OAuthCodeRequest']/method[@name='setPassword' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Coinbase.Api.Entity.OAuthCodeRequest __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.OAuthCodeRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Coinbase.Api.Entity.OAuthCodeRequest __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.OAuthCodeRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RedirectUri = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getRedirectUri;
		static IntPtr id_setRedirectUri_Ljava_lang_String_;
		public virtual unsafe string RedirectUri {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='OAuthCodeRequest']/method[@name='getRedirectUri' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='OAuthCodeRequest']/method[@name='setRedirectUri' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Coinbase.Api.Entity.OAuthCodeRequest __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.OAuthCodeRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Coinbase.Api.Entity.OAuthCodeRequest __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.OAuthCodeRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Scope = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getScope;
		static IntPtr id_setScope_Ljava_lang_String_;
		public virtual unsafe string Scope {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='OAuthCodeRequest']/method[@name='getScope' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='OAuthCodeRequest']/method[@name='setScope' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Coinbase.Api.Entity.OAuthCodeRequest __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.OAuthCodeRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Token);
		}
#pragma warning restore 0169

		static Delegate cb_setToken_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetToken_Ljava_lang_String_Handler ()
		{
			if (cb_setToken_Ljava_lang_String_ == null)
				cb_setToken_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetToken_Ljava_lang_String_);
			return cb_setToken_Ljava_lang_String_;
		}

		static void n_SetToken_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.OAuthCodeRequest __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.OAuthCodeRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Token = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getToken;
		static IntPtr id_setToken_Ljava_lang_String_;
		public virtual unsafe string Token {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='OAuthCodeRequest']/method[@name='getToken' and count(parameter)=0]"
			[Register ("getToken", "()Ljava/lang/String;", "GetGetTokenHandler")]
			get {
				if (id_getToken == IntPtr.Zero)
					id_getToken = JNIEnv.GetMethodID (class_ref, "getToken", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getToken), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getToken", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='OAuthCodeRequest']/method[@name='setToken' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setToken", "(Ljava/lang/String;)V", "GetSetToken_Ljava_lang_String_Handler")]
			set {
				if (id_setToken_Ljava_lang_String_ == IntPtr.Zero)
					id_setToken_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setToken", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setToken_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setToken", "(Ljava/lang/String;)V"), __args);
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
			global::Com.Coinbase.Api.Entity.OAuthCodeRequest __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.OAuthCodeRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Coinbase.Api.Entity.OAuthCodeRequest __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.OAuthCodeRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Username = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getUsername;
		static IntPtr id_setUsername_Ljava_lang_String_;
		public virtual unsafe string Username {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='OAuthCodeRequest']/method[@name='getUsername' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='OAuthCodeRequest']/method[@name='setUsername' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getMeta;
#pragma warning disable 0169
		static Delegate GetGetMetaHandler ()
		{
			if (cb_getMeta == null)
				cb_getMeta = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMeta);
			return cb_getMeta;
		}

		static IntPtr n_GetMeta (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.OAuthCodeRequest __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.OAuthCodeRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetMeta ());
		}
#pragma warning restore 0169

		static IntPtr id_getMeta;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='OAuthCodeRequest']/method[@name='getMeta' and count(parameter)=0]"
		[Register ("getMeta", "()Lcom/coinbase/api/entity/OAuthCodeRequest$Meta;", "GetGetMetaHandler")]
		public virtual unsafe global::Com.Coinbase.Api.Entity.OAuthCodeRequest.Meta GetMeta ()
		{
			if (id_getMeta == IntPtr.Zero)
				id_getMeta = JNIEnv.GetMethodID (class_ref, "getMeta", "()Lcom/coinbase/api/entity/OAuthCodeRequest$Meta;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.OAuthCodeRequest.Meta> (JNIEnv.CallObjectMethod  (Handle, id_getMeta), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.OAuthCodeRequest.Meta> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMeta", "()Lcom/coinbase/api/entity/OAuthCodeRequest$Meta;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setMeta_Lcom_coinbase_api_entity_OAuthCodeRequest_Meta_;
#pragma warning disable 0169
		static Delegate GetSetMeta_Lcom_coinbase_api_entity_OAuthCodeRequest_Meta_Handler ()
		{
			if (cb_setMeta_Lcom_coinbase_api_entity_OAuthCodeRequest_Meta_ == null)
				cb_setMeta_Lcom_coinbase_api_entity_OAuthCodeRequest_Meta_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMeta_Lcom_coinbase_api_entity_OAuthCodeRequest_Meta_);
			return cb_setMeta_Lcom_coinbase_api_entity_OAuthCodeRequest_Meta_;
		}

		static void n_SetMeta_Lcom_coinbase_api_entity_OAuthCodeRequest_Meta_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.OAuthCodeRequest __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.OAuthCodeRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Coinbase.Api.Entity.OAuthCodeRequest.Meta p0 = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.OAuthCodeRequest.Meta> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetMeta (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setMeta_Lcom_coinbase_api_entity_OAuthCodeRequest_Meta_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='OAuthCodeRequest']/method[@name='setMeta' and count(parameter)=1 and parameter[1][@type='com.coinbase.api.entity.OAuthCodeRequest.Meta']]"
		[Register ("setMeta", "(Lcom/coinbase/api/entity/OAuthCodeRequest$Meta;)V", "GetSetMeta_Lcom_coinbase_api_entity_OAuthCodeRequest_Meta_Handler")]
		public virtual unsafe void SetMeta (global::Com.Coinbase.Api.Entity.OAuthCodeRequest.Meta p0)
		{
			if (id_setMeta_Lcom_coinbase_api_entity_OAuthCodeRequest_Meta_ == IntPtr.Zero)
				id_setMeta_Lcom_coinbase_api_entity_OAuthCodeRequest_Meta_ = JNIEnv.GetMethodID (class_ref, "setMeta", "(Lcom/coinbase/api/entity/OAuthCodeRequest$Meta;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setMeta_Lcom_coinbase_api_entity_OAuthCodeRequest_Meta_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMeta", "(Lcom/coinbase/api/entity/OAuthCodeRequest$Meta;)V"), __args);
			} finally {
			}
		}

	}
}
