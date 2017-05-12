using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Coinbase.Api.Entity {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='RecurringPayment']"
	[global::Android.Runtime.Register ("com/coinbase/api/entity/RecurringPayment", DoNotGenerateAcw=true)]
	public partial class RecurringPayment : global::Java.Lang.Object, global::Java.IO.ISerializable {


		static IntPtr INDEFINITE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='RecurringPayment']/field[@name='INDEFINITE']"
		[Register ("INDEFINITE")]
		public static global::Java.Lang.Integer Indefinite {
			get {
				if (INDEFINITE_jfieldId == IntPtr.Zero)
					INDEFINITE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INDEFINITE", "Ljava/lang/Integer;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INDEFINITE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='RecurringPayment.StartType']"
		[global::Android.Runtime.Register ("com/coinbase/api/entity/RecurringPayment$StartType", DoNotGenerateAcw=true)]
		public sealed partial class StartType : global::Java.Lang.Enum {


			static IntPtr NOW_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='RecurringPayment.StartType']/field[@name='NOW']"
			[Register ("NOW")]
			public static global::Com.Coinbase.Api.Entity.RecurringPayment.StartType Now {
				get {
					if (NOW_jfieldId == IntPtr.Zero)
						NOW_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NOW", "Lcom/coinbase/api/entity/RecurringPayment$StartType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NOW_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.RecurringPayment.StartType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr ON_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='RecurringPayment.StartType']/field[@name='ON']"
			[Register ("ON")]
			public static global::Com.Coinbase.Api.Entity.RecurringPayment.StartType On {
				get {
					if (ON_jfieldId == IntPtr.Zero)
						ON_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ON", "Lcom/coinbase/api/entity/RecurringPayment$StartType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ON_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.RecurringPayment.StartType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/coinbase/api/entity/RecurringPayment$StartType", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (StartType); }
			}

			internal StartType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_create_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='RecurringPayment.StartType']/method[@name='create' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("create", "(Ljava/lang/String;)Lcom/coinbase/api/entity/RecurringPayment$StartType;", "")]
			public static unsafe global::Com.Coinbase.Api.Entity.RecurringPayment.StartType Create (string p0)
			{
				if (id_create_Ljava_lang_String_ == IntPtr.Zero)
					id_create_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "create", "(Ljava/lang/String;)Lcom/coinbase/api/entity/RecurringPayment$StartType;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Coinbase.Api.Entity.RecurringPayment.StartType __ret = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.RecurringPayment.StartType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='RecurringPayment.StartType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/coinbase/api/entity/RecurringPayment$StartType;", "")]
			public static unsafe global::Com.Coinbase.Api.Entity.RecurringPayment.StartType ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/coinbase/api/entity/RecurringPayment$StartType;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Coinbase.Api.Entity.RecurringPayment.StartType __ret = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.RecurringPayment.StartType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='RecurringPayment.StartType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/coinbase/api/entity/RecurringPayment$StartType;", "")]
			public static unsafe global::Com.Coinbase.Api.Entity.RecurringPayment.StartType[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/coinbase/api/entity/RecurringPayment$StartType;");
				try {
					return (global::Com.Coinbase.Api.Entity.RecurringPayment.StartType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Coinbase.Api.Entity.RecurringPayment.StartType));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='RecurringPayment.Status']"
		[global::Android.Runtime.Register ("com/coinbase/api/entity/RecurringPayment$Status", DoNotGenerateAcw=true)]
		public sealed partial class Status : global::Java.Lang.Enum {


			static IntPtr ACTIVE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='RecurringPayment.Status']/field[@name='ACTIVE']"
			[Register ("ACTIVE")]
			public static global::Com.Coinbase.Api.Entity.RecurringPayment.Status Active {
				get {
					if (ACTIVE_jfieldId == IntPtr.Zero)
						ACTIVE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ACTIVE", "Lcom/coinbase/api/entity/RecurringPayment$Status;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ACTIVE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.RecurringPayment.Status> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr CANCELED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='RecurringPayment.Status']/field[@name='CANCELED']"
			[Register ("CANCELED")]
			public static global::Com.Coinbase.Api.Entity.RecurringPayment.Status Canceled {
				get {
					if (CANCELED_jfieldId == IntPtr.Zero)
						CANCELED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CANCELED", "Lcom/coinbase/api/entity/RecurringPayment$Status;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CANCELED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.RecurringPayment.Status> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr COMPLETED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='RecurringPayment.Status']/field[@name='COMPLETED']"
			[Register ("COMPLETED")]
			public static global::Com.Coinbase.Api.Entity.RecurringPayment.Status Completed {
				get {
					if (COMPLETED_jfieldId == IntPtr.Zero)
						COMPLETED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "COMPLETED", "Lcom/coinbase/api/entity/RecurringPayment$Status;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, COMPLETED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.RecurringPayment.Status> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr NEW_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='RecurringPayment.Status']/field[@name='NEW']"
			[Register ("NEW")]
			public static global::Com.Coinbase.Api.Entity.RecurringPayment.Status New {
				get {
					if (NEW_jfieldId == IntPtr.Zero)
						NEW_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NEW", "Lcom/coinbase/api/entity/RecurringPayment$Status;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NEW_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.RecurringPayment.Status> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr PAUSED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='RecurringPayment.Status']/field[@name='PAUSED']"
			[Register ("PAUSED")]
			public static global::Com.Coinbase.Api.Entity.RecurringPayment.Status Paused {
				get {
					if (PAUSED_jfieldId == IntPtr.Zero)
						PAUSED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PAUSED", "Lcom/coinbase/api/entity/RecurringPayment$Status;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PAUSED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.RecurringPayment.Status> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/coinbase/api/entity/RecurringPayment$Status", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Status); }
			}

			internal Status (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_create_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='RecurringPayment.Status']/method[@name='create' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("create", "(Ljava/lang/String;)Lcom/coinbase/api/entity/RecurringPayment$Status;", "")]
			public static unsafe global::Com.Coinbase.Api.Entity.RecurringPayment.Status Create (string p0)
			{
				if (id_create_Ljava_lang_String_ == IntPtr.Zero)
					id_create_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "create", "(Ljava/lang/String;)Lcom/coinbase/api/entity/RecurringPayment$Status;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Coinbase.Api.Entity.RecurringPayment.Status __ret = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.RecurringPayment.Status> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='RecurringPayment.Status']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/coinbase/api/entity/RecurringPayment$Status;", "")]
			public static unsafe global::Com.Coinbase.Api.Entity.RecurringPayment.Status ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/coinbase/api/entity/RecurringPayment$Status;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Coinbase.Api.Entity.RecurringPayment.Status __ret = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.RecurringPayment.Status> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='RecurringPayment.Status']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/coinbase/api/entity/RecurringPayment$Status;", "")]
			public static unsafe global::Com.Coinbase.Api.Entity.RecurringPayment.Status[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/coinbase/api/entity/RecurringPayment$Status;");
				try {
					return (global::Com.Coinbase.Api.Entity.RecurringPayment.Status[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Coinbase.Api.Entity.RecurringPayment.Status));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/coinbase/api/entity/RecurringPayment", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RecurringPayment); }
		}

		protected RecurringPayment (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='RecurringPayment']/constructor[@name='RecurringPayment' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe RecurringPayment ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (RecurringPayment)) {
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
			global::Com.Coinbase.Api.Entity.RecurringPayment __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.RecurringPayment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Coinbase.Api.Entity.RecurringPayment __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.RecurringPayment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Coinbase.Api.Entity.Button p0 = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Button> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Button = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getButton;
		static IntPtr id_setButton_Lcom_coinbase_api_entity_Button_;
		public virtual unsafe global::Com.Coinbase.Api.Entity.Button Button {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='RecurringPayment']/method[@name='getButton' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='RecurringPayment']/method[@name='setButton' and count(parameter)=1 and parameter[1][@type='com.coinbase.api.entity.Button']]"
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

		static Delegate cb_getCustom;
#pragma warning disable 0169
		static Delegate GetGetCustomHandler ()
		{
			if (cb_getCustom == null)
				cb_getCustom = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCustom);
			return cb_getCustom;
		}

		static IntPtr n_GetCustom (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.RecurringPayment __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.RecurringPayment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Custom);
		}
#pragma warning restore 0169

		static Delegate cb_setCustom_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCustom_Ljava_lang_String_Handler ()
		{
			if (cb_setCustom_Ljava_lang_String_ == null)
				cb_setCustom_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCustom_Ljava_lang_String_);
			return cb_setCustom_Ljava_lang_String_;
		}

		static void n_SetCustom_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.RecurringPayment __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.RecurringPayment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Custom = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCustom;
		static IntPtr id_setCustom_Ljava_lang_String_;
		public virtual unsafe string Custom {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='RecurringPayment']/method[@name='getCustom' and count(parameter)=0]"
			[Register ("getCustom", "()Ljava/lang/String;", "GetGetCustomHandler")]
			get {
				if (id_getCustom == IntPtr.Zero)
					id_getCustom = JNIEnv.GetMethodID (class_ref, "getCustom", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getCustom), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCustom", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='RecurringPayment']/method[@name='setCustom' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCustom", "(Ljava/lang/String;)V", "GetSetCustom_Ljava_lang_String_Handler")]
			set {
				if (id_setCustom_Ljava_lang_String_ == IntPtr.Zero)
					id_setCustom_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCustom", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setCustom_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCustom", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getDescription;
#pragma warning disable 0169
		static Delegate GetGetDescriptionHandler ()
		{
			if (cb_getDescription == null)
				cb_getDescription = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDescription);
			return cb_getDescription;
		}

		static IntPtr n_GetDescription (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.RecurringPayment __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.RecurringPayment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Description);
		}
#pragma warning restore 0169

		static Delegate cb_setDescription_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDescription_Ljava_lang_String_Handler ()
		{
			if (cb_setDescription_Ljava_lang_String_ == null)
				cb_setDescription_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDescription_Ljava_lang_String_);
			return cb_setDescription_Ljava_lang_String_;
		}

		static void n_SetDescription_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.RecurringPayment __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.RecurringPayment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Description = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDescription;
		static IntPtr id_setDescription_Ljava_lang_String_;
		public virtual unsafe string Description {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='RecurringPayment']/method[@name='getDescription' and count(parameter)=0]"
			[Register ("getDescription", "()Ljava/lang/String;", "GetGetDescriptionHandler")]
			get {
				if (id_getDescription == IntPtr.Zero)
					id_getDescription = JNIEnv.GetMethodID (class_ref, "getDescription", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getDescription), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDescription", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='RecurringPayment']/method[@name='setDescription' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setDescription", "(Ljava/lang/String;)V", "GetSetDescription_Ljava_lang_String_Handler")]
			set {
				if (id_setDescription_Ljava_lang_String_ == IntPtr.Zero)
					id_setDescription_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setDescription", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setDescription_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDescription", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getFrom;
#pragma warning disable 0169
		static Delegate GetGetFromHandler ()
		{
			if (cb_getFrom == null)
				cb_getFrom = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFrom);
			return cb_getFrom;
		}

		static IntPtr n_GetFrom (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.RecurringPayment __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.RecurringPayment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.From);
		}
#pragma warning restore 0169

		static Delegate cb_setFrom_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetFrom_Ljava_lang_String_Handler ()
		{
			if (cb_setFrom_Ljava_lang_String_ == null)
				cb_setFrom_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetFrom_Ljava_lang_String_);
			return cb_setFrom_Ljava_lang_String_;
		}

		static void n_SetFrom_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.RecurringPayment __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.RecurringPayment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.From = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getFrom;
		static IntPtr id_setFrom_Ljava_lang_String_;
		public virtual unsafe string From {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='RecurringPayment']/method[@name='getFrom' and count(parameter)=0]"
			[Register ("getFrom", "()Ljava/lang/String;", "GetGetFromHandler")]
			get {
				if (id_getFrom == IntPtr.Zero)
					id_getFrom = JNIEnv.GetMethodID (class_ref, "getFrom", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getFrom), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFrom", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='RecurringPayment']/method[@name='setFrom' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setFrom", "(Ljava/lang/String;)V", "GetSetFrom_Ljava_lang_String_Handler")]
			set {
				if (id_setFrom_Ljava_lang_String_ == IntPtr.Zero)
					id_setFrom_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setFrom", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setFrom_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFrom", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
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
			global::Com.Coinbase.Api.Entity.RecurringPayment __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.RecurringPayment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Coinbase.Api.Entity.RecurringPayment __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.RecurringPayment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Id = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getId;
		static IntPtr id_setId_Ljava_lang_String_;
		public virtual unsafe string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='RecurringPayment']/method[@name='getId' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='RecurringPayment']/method[@name='setId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getNotes;
#pragma warning disable 0169
		static Delegate GetGetNotesHandler ()
		{
			if (cb_getNotes == null)
				cb_getNotes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNotes);
			return cb_getNotes;
		}

		static IntPtr n_GetNotes (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.RecurringPayment __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.RecurringPayment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Notes);
		}
#pragma warning restore 0169

		static Delegate cb_setNotes_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetNotes_Ljava_lang_String_Handler ()
		{
			if (cb_setNotes_Ljava_lang_String_ == null)
				cb_setNotes_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetNotes_Ljava_lang_String_);
			return cb_setNotes_Ljava_lang_String_;
		}

		static void n_SetNotes_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.RecurringPayment __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.RecurringPayment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Notes = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getNotes;
		static IntPtr id_setNotes_Ljava_lang_String_;
		public virtual unsafe string Notes {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='RecurringPayment']/method[@name='getNotes' and count(parameter)=0]"
			[Register ("getNotes", "()Ljava/lang/String;", "GetGetNotesHandler")]
			get {
				if (id_getNotes == IntPtr.Zero)
					id_getNotes = JNIEnv.GetMethodID (class_ref, "getNotes", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getNotes), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNotes", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='RecurringPayment']/method[@name='setNotes' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setNotes", "(Ljava/lang/String;)V", "GetSetNotes_Ljava_lang_String_Handler")]
			set {
				if (id_setNotes_Ljava_lang_String_ == IntPtr.Zero)
					id_setNotes_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setNotes", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setNotes_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNotes", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getRepeat;
#pragma warning disable 0169
		static Delegate GetGetRepeatHandler ()
		{
			if (cb_getRepeat == null)
				cb_getRepeat = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRepeat);
			return cb_getRepeat;
		}

		static IntPtr n_GetRepeat (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.RecurringPayment __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.RecurringPayment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Repeat);
		}
#pragma warning restore 0169

		static Delegate cb_setRepeat_Lcom_coinbase_api_entity_Button_Repeat_;
#pragma warning disable 0169
		static Delegate GetSetRepeat_Lcom_coinbase_api_entity_Button_Repeat_Handler ()
		{
			if (cb_setRepeat_Lcom_coinbase_api_entity_Button_Repeat_ == null)
				cb_setRepeat_Lcom_coinbase_api_entity_Button_Repeat_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRepeat_Lcom_coinbase_api_entity_Button_Repeat_);
			return cb_setRepeat_Lcom_coinbase_api_entity_Button_Repeat_;
		}

		static void n_SetRepeat_Lcom_coinbase_api_entity_Button_Repeat_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.RecurringPayment __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.RecurringPayment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Coinbase.Api.Entity.Button.Repeat p0 = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Button.Repeat> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Repeat = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getRepeat;
		static IntPtr id_setRepeat_Lcom_coinbase_api_entity_Button_Repeat_;
		public virtual unsafe global::Com.Coinbase.Api.Entity.Button.Repeat Repeat {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='RecurringPayment']/method[@name='getRepeat' and count(parameter)=0]"
			[Register ("getRepeat", "()Lcom/coinbase/api/entity/Button$Repeat;", "GetGetRepeatHandler")]
			get {
				if (id_getRepeat == IntPtr.Zero)
					id_getRepeat = JNIEnv.GetMethodID (class_ref, "getRepeat", "()Lcom/coinbase/api/entity/Button$Repeat;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Button.Repeat> (JNIEnv.CallObjectMethod  (Handle, id_getRepeat), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Button.Repeat> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRepeat", "()Lcom/coinbase/api/entity/Button$Repeat;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='RecurringPayment']/method[@name='setRepeat' and count(parameter)=1 and parameter[1][@type='com.coinbase.api.entity.Button.Repeat']]"
			[Register ("setRepeat", "(Lcom/coinbase/api/entity/Button$Repeat;)V", "GetSetRepeat_Lcom_coinbase_api_entity_Button_Repeat_Handler")]
			set {
				if (id_setRepeat_Lcom_coinbase_api_entity_Button_Repeat_ == IntPtr.Zero)
					id_setRepeat_Lcom_coinbase_api_entity_Button_Repeat_ = JNIEnv.GetMethodID (class_ref, "setRepeat", "(Lcom/coinbase/api/entity/Button$Repeat;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setRepeat_Lcom_coinbase_api_entity_Button_Repeat_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRepeat", "(Lcom/coinbase/api/entity/Button$Repeat;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTimes;
#pragma warning disable 0169
		static Delegate GetGetTimesHandler ()
		{
			if (cb_getTimes == null)
				cb_getTimes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTimes);
			return cb_getTimes;
		}

		static IntPtr n_GetTimes (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.RecurringPayment __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.RecurringPayment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Times);
		}
#pragma warning restore 0169

		static Delegate cb_setTimes_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetSetTimes_Ljava_lang_Integer_Handler ()
		{
			if (cb_setTimes_Ljava_lang_Integer_ == null)
				cb_setTimes_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTimes_Ljava_lang_Integer_);
			return cb_setTimes_Ljava_lang_Integer_;
		}

		static void n_SetTimes_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.RecurringPayment __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.RecurringPayment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Times = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTimes;
		static IntPtr id_setTimes_Ljava_lang_Integer_;
		public virtual unsafe global::Java.Lang.Integer Times {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='RecurringPayment']/method[@name='getTimes' and count(parameter)=0]"
			[Register ("getTimes", "()Ljava/lang/Integer;", "GetGetTimesHandler")]
			get {
				if (id_getTimes == IntPtr.Zero)
					id_getTimes = JNIEnv.GetMethodID (class_ref, "getTimes", "()Ljava/lang/Integer;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod  (Handle, id_getTimes), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTimes", "()Ljava/lang/Integer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='RecurringPayment']/method[@name='setTimes' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("setTimes", "(Ljava/lang/Integer;)V", "GetSetTimes_Ljava_lang_Integer_Handler")]
			set {
				if (id_setTimes_Ljava_lang_Integer_ == IntPtr.Zero)
					id_setTimes_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "setTimes", "(Ljava/lang/Integer;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setTimes_Ljava_lang_Integer_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTimes", "(Ljava/lang/Integer;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTimesRun;
#pragma warning disable 0169
		static Delegate GetGetTimesRunHandler ()
		{
			if (cb_getTimesRun == null)
				cb_getTimesRun = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTimesRun);
			return cb_getTimesRun;
		}

		static IntPtr n_GetTimesRun (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.RecurringPayment __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.RecurringPayment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TimesRun);
		}
#pragma warning restore 0169

		static Delegate cb_setTimesRun_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetSetTimesRun_Ljava_lang_Integer_Handler ()
		{
			if (cb_setTimesRun_Ljava_lang_Integer_ == null)
				cb_setTimesRun_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTimesRun_Ljava_lang_Integer_);
			return cb_setTimesRun_Ljava_lang_Integer_;
		}

		static void n_SetTimesRun_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.RecurringPayment __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.RecurringPayment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TimesRun = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTimesRun;
		static IntPtr id_setTimesRun_Ljava_lang_Integer_;
		public virtual unsafe global::Java.Lang.Integer TimesRun {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='RecurringPayment']/method[@name='getTimesRun' and count(parameter)=0]"
			[Register ("getTimesRun", "()Ljava/lang/Integer;", "GetGetTimesRunHandler")]
			get {
				if (id_getTimesRun == IntPtr.Zero)
					id_getTimesRun = JNIEnv.GetMethodID (class_ref, "getTimesRun", "()Ljava/lang/Integer;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod  (Handle, id_getTimesRun), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTimesRun", "()Ljava/lang/Integer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='RecurringPayment']/method[@name='setTimesRun' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("setTimesRun", "(Ljava/lang/Integer;)V", "GetSetTimesRun_Ljava_lang_Integer_Handler")]
			set {
				if (id_setTimesRun_Ljava_lang_Integer_ == IntPtr.Zero)
					id_setTimesRun_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "setTimesRun", "(Ljava/lang/Integer;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setTimesRun_Ljava_lang_Integer_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTimesRun", "(Ljava/lang/Integer;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTo;
#pragma warning disable 0169
		static Delegate GetGetToHandler ()
		{
			if (cb_getTo == null)
				cb_getTo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTo);
			return cb_getTo;
		}

		static IntPtr n_GetTo (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.RecurringPayment __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.RecurringPayment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.To);
		}
#pragma warning restore 0169

		static Delegate cb_setTo_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTo_Ljava_lang_String_Handler ()
		{
			if (cb_setTo_Ljava_lang_String_ == null)
				cb_setTo_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTo_Ljava_lang_String_);
			return cb_setTo_Ljava_lang_String_;
		}

		static void n_SetTo_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.RecurringPayment __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.RecurringPayment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.To = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTo;
		static IntPtr id_setTo_Ljava_lang_String_;
		public virtual unsafe string To {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='RecurringPayment']/method[@name='getTo' and count(parameter)=0]"
			[Register ("getTo", "()Ljava/lang/String;", "GetGetToHandler")]
			get {
				if (id_getTo == IntPtr.Zero)
					id_getTo = JNIEnv.GetMethodID (class_ref, "getTo", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getTo), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTo", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='RecurringPayment']/method[@name='setTo' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTo", "(Ljava/lang/String;)V", "GetSetTo_Ljava_lang_String_Handler")]
			set {
				if (id_setTo_Ljava_lang_String_ == IntPtr.Zero)
					id_setTo_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTo", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setTo_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTo", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getStartType;
#pragma warning disable 0169
		static Delegate GetGetStartTypeHandler ()
		{
			if (cb_getStartType == null)
				cb_getStartType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStartType);
			return cb_getStartType;
		}

		static IntPtr n_GetStartType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.RecurringPayment __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.RecurringPayment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetStartType ());
		}
#pragma warning restore 0169

		static IntPtr id_getStartType;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='RecurringPayment']/method[@name='getStartType' and count(parameter)=0]"
		[Register ("getStartType", "()Lcom/coinbase/api/entity/RecurringPayment$StartType;", "GetGetStartTypeHandler")]
		public virtual unsafe global::Com.Coinbase.Api.Entity.RecurringPayment.StartType GetStartType ()
		{
			if (id_getStartType == IntPtr.Zero)
				id_getStartType = JNIEnv.GetMethodID (class_ref, "getStartType", "()Lcom/coinbase/api/entity/RecurringPayment$StartType;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.RecurringPayment.StartType> (JNIEnv.CallObjectMethod  (Handle, id_getStartType), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.RecurringPayment.StartType> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStartType", "()Lcom/coinbase/api/entity/RecurringPayment$StartType;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getStatus;
#pragma warning disable 0169
		static Delegate GetGetStatusHandler ()
		{
			if (cb_getStatus == null)
				cb_getStatus = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStatus);
			return cb_getStatus;
		}

		static IntPtr n_GetStatus (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.RecurringPayment __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.RecurringPayment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetStatus ());
		}
#pragma warning restore 0169

		static IntPtr id_getStatus;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='RecurringPayment']/method[@name='getStatus' and count(parameter)=0]"
		[Register ("getStatus", "()Lcom/coinbase/api/entity/RecurringPayment$Status;", "GetGetStatusHandler")]
		public virtual unsafe global::Com.Coinbase.Api.Entity.RecurringPayment.Status GetStatus ()
		{
			if (id_getStatus == IntPtr.Zero)
				id_getStatus = JNIEnv.GetMethodID (class_ref, "getStatus", "()Lcom/coinbase/api/entity/RecurringPayment$Status;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.RecurringPayment.Status> (JNIEnv.CallObjectMethod  (Handle, id_getStatus), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.RecurringPayment.Status> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStatus", "()Lcom/coinbase/api/entity/RecurringPayment$Status;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setStartType_Lcom_coinbase_api_entity_RecurringPayment_StartType_;
#pragma warning disable 0169
		static Delegate GetSetStartType_Lcom_coinbase_api_entity_RecurringPayment_StartType_Handler ()
		{
			if (cb_setStartType_Lcom_coinbase_api_entity_RecurringPayment_StartType_ == null)
				cb_setStartType_Lcom_coinbase_api_entity_RecurringPayment_StartType_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetStartType_Lcom_coinbase_api_entity_RecurringPayment_StartType_);
			return cb_setStartType_Lcom_coinbase_api_entity_RecurringPayment_StartType_;
		}

		static void n_SetStartType_Lcom_coinbase_api_entity_RecurringPayment_StartType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.RecurringPayment __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.RecurringPayment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Coinbase.Api.Entity.RecurringPayment.StartType p0 = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.RecurringPayment.StartType> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetStartType (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setStartType_Lcom_coinbase_api_entity_RecurringPayment_StartType_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='RecurringPayment']/method[@name='setStartType' and count(parameter)=1 and parameter[1][@type='com.coinbase.api.entity.RecurringPayment.StartType']]"
		[Register ("setStartType", "(Lcom/coinbase/api/entity/RecurringPayment$StartType;)V", "GetSetStartType_Lcom_coinbase_api_entity_RecurringPayment_StartType_Handler")]
		public virtual unsafe void SetStartType (global::Com.Coinbase.Api.Entity.RecurringPayment.StartType p0)
		{
			if (id_setStartType_Lcom_coinbase_api_entity_RecurringPayment_StartType_ == IntPtr.Zero)
				id_setStartType_Lcom_coinbase_api_entity_RecurringPayment_StartType_ = JNIEnv.GetMethodID (class_ref, "setStartType", "(Lcom/coinbase/api/entity/RecurringPayment$StartType;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setStartType_Lcom_coinbase_api_entity_RecurringPayment_StartType_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setStartType", "(Lcom/coinbase/api/entity/RecurringPayment$StartType;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setStatus_Lcom_coinbase_api_entity_RecurringPayment_Status_;
#pragma warning disable 0169
		static Delegate GetSetStatus_Lcom_coinbase_api_entity_RecurringPayment_Status_Handler ()
		{
			if (cb_setStatus_Lcom_coinbase_api_entity_RecurringPayment_Status_ == null)
				cb_setStatus_Lcom_coinbase_api_entity_RecurringPayment_Status_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetStatus_Lcom_coinbase_api_entity_RecurringPayment_Status_);
			return cb_setStatus_Lcom_coinbase_api_entity_RecurringPayment_Status_;
		}

		static void n_SetStatus_Lcom_coinbase_api_entity_RecurringPayment_Status_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.RecurringPayment __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.RecurringPayment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Coinbase.Api.Entity.RecurringPayment.Status p0 = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.RecurringPayment.Status> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetStatus (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setStatus_Lcom_coinbase_api_entity_RecurringPayment_Status_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='RecurringPayment']/method[@name='setStatus' and count(parameter)=1 and parameter[1][@type='com.coinbase.api.entity.RecurringPayment.Status']]"
		[Register ("setStatus", "(Lcom/coinbase/api/entity/RecurringPayment$Status;)V", "GetSetStatus_Lcom_coinbase_api_entity_RecurringPayment_Status_Handler")]
		public virtual unsafe void SetStatus (global::Com.Coinbase.Api.Entity.RecurringPayment.Status p0)
		{
			if (id_setStatus_Lcom_coinbase_api_entity_RecurringPayment_Status_ == IntPtr.Zero)
				id_setStatus_Lcom_coinbase_api_entity_RecurringPayment_Status_ = JNIEnv.GetMethodID (class_ref, "setStatus", "(Lcom/coinbase/api/entity/RecurringPayment$Status;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setStatus_Lcom_coinbase_api_entity_RecurringPayment_Status_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setStatus", "(Lcom/coinbase/api/entity/RecurringPayment$Status;)V"), __args);
			} finally {
			}
		}

	}
}
