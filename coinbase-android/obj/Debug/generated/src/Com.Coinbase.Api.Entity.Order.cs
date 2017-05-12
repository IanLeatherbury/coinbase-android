using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Coinbase.Api.Entity {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Order']"
	[global::Android.Runtime.Register ("com/coinbase/api/entity/Order", DoNotGenerateAcw=true)]
	public partial class Order : global::Java.Lang.Object, global::Java.IO.ISerializable {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Order.Status']"
		[global::Android.Runtime.Register ("com/coinbase/api/entity/Order$Status", DoNotGenerateAcw=true)]
		public sealed partial class Status : global::Java.Lang.Enum {


			static IntPtr CANCELED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Order.Status']/field[@name='CANCELED']"
			[Register ("CANCELED")]
			public static global::Com.Coinbase.Api.Entity.Order.Status Canceled {
				get {
					if (CANCELED_jfieldId == IntPtr.Zero)
						CANCELED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CANCELED", "Lcom/coinbase/api/entity/Order$Status;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CANCELED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Order.Status> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr COMPLETED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Order.Status']/field[@name='COMPLETED']"
			[Register ("COMPLETED")]
			public static global::Com.Coinbase.Api.Entity.Order.Status Completed {
				get {
					if (COMPLETED_jfieldId == IntPtr.Zero)
						COMPLETED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "COMPLETED", "Lcom/coinbase/api/entity/Order$Status;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, COMPLETED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Order.Status> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr EXPIRED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Order.Status']/field[@name='EXPIRED']"
			[Register ("EXPIRED")]
			public static global::Com.Coinbase.Api.Entity.Order.Status Expired {
				get {
					if (EXPIRED_jfieldId == IntPtr.Zero)
						EXPIRED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EXPIRED", "Lcom/coinbase/api/entity/Order$Status;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EXPIRED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Order.Status> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr MISPAID_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Order.Status']/field[@name='MISPAID']"
			[Register ("MISPAID")]
			public static global::Com.Coinbase.Api.Entity.Order.Status Mispaid {
				get {
					if (MISPAID_jfieldId == IntPtr.Zero)
						MISPAID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MISPAID", "Lcom/coinbase/api/entity/Order$Status;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MISPAID_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Order.Status> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr NEW_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Order.Status']/field[@name='NEW']"
			[Register ("NEW")]
			public static global::Com.Coinbase.Api.Entity.Order.Status New {
				get {
					if (NEW_jfieldId == IntPtr.Zero)
						NEW_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NEW", "Lcom/coinbase/api/entity/Order$Status;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NEW_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Order.Status> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr REFUNDED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Order.Status']/field[@name='REFUNDED']"
			[Register ("REFUNDED")]
			public static global::Com.Coinbase.Api.Entity.Order.Status Refunded {
				get {
					if (REFUNDED_jfieldId == IntPtr.Zero)
						REFUNDED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "REFUNDED", "Lcom/coinbase/api/entity/Order$Status;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, REFUNDED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Order.Status> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/coinbase/api/entity/Order$Status", ref java_class_handle);
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Order.Status']/method[@name='create' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("create", "(Ljava/lang/String;)Lcom/coinbase/api/entity/Order$Status;", "")]
			public static unsafe global::Com.Coinbase.Api.Entity.Order.Status Create (string p0)
			{
				if (id_create_Ljava_lang_String_ == IntPtr.Zero)
					id_create_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "create", "(Ljava/lang/String;)Lcom/coinbase/api/entity/Order$Status;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Coinbase.Api.Entity.Order.Status __ret = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Order.Status> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Order.Status']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/coinbase/api/entity/Order$Status;", "")]
			public static unsafe global::Com.Coinbase.Api.Entity.Order.Status ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/coinbase/api/entity/Order$Status;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Coinbase.Api.Entity.Order.Status __ret = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Order.Status> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Order.Status']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/coinbase/api/entity/Order$Status;", "")]
			public static unsafe global::Com.Coinbase.Api.Entity.Order.Status[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/coinbase/api/entity/Order$Status;");
				try {
					return (global::Com.Coinbase.Api.Entity.Order.Status[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Coinbase.Api.Entity.Order.Status));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/coinbase/api/entity/Order", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Order); }
		}

		protected Order (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Order']/constructor[@name='Order' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Order ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Order)) {
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
			global::Com.Coinbase.Api.Entity.Order __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Order> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Coinbase.Api.Entity.Order __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Order> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Coinbase.Api.Entity.Button p0 = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Button> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Button = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getButton;
		static IntPtr id_setButton_Lcom_coinbase_api_entity_Button_;
		public virtual unsafe global::Com.Coinbase.Api.Entity.Button Button {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Order']/method[@name='getButton' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Order']/method[@name='setButton' and count(parameter)=1 and parameter[1][@type='com.coinbase.api.entity.Button']]"
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
			global::Com.Coinbase.Api.Entity.Order __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Order> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Coinbase.Api.Entity.Order __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Order> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Custom = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCustom;
		static IntPtr id_setCustom_Ljava_lang_String_;
		public virtual unsafe string Custom {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Order']/method[@name='getCustom' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Order']/method[@name='setCustom' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Coinbase.Api.Entity.Order __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Order> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Coinbase.Api.Entity.Order __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Order> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Id = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getId;
		static IntPtr id_setId_Ljava_lang_String_;
		public virtual unsafe string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Order']/method[@name='getId' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Order']/method[@name='setId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Coinbase.Api.Entity.Order __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Order> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Coinbase.Api.Entity.Order __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Order> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ReceiveAddress = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getReceiveAddress;
		static IntPtr id_setReceiveAddress_Ljava_lang_String_;
		public virtual unsafe string ReceiveAddress {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Order']/method[@name='getReceiveAddress' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Order']/method[@name='setReceiveAddress' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getRefundAddress;
#pragma warning disable 0169
		static Delegate GetGetRefundAddressHandler ()
		{
			if (cb_getRefundAddress == null)
				cb_getRefundAddress = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRefundAddress);
			return cb_getRefundAddress;
		}

		static IntPtr n_GetRefundAddress (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.Order __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Order> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RefundAddress);
		}
#pragma warning restore 0169

		static Delegate cb_setRefundAddress_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetRefundAddress_Ljava_lang_String_Handler ()
		{
			if (cb_setRefundAddress_Ljava_lang_String_ == null)
				cb_setRefundAddress_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRefundAddress_Ljava_lang_String_);
			return cb_setRefundAddress_Ljava_lang_String_;
		}

		static void n_SetRefundAddress_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.Order __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Order> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RefundAddress = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getRefundAddress;
		static IntPtr id_setRefundAddress_Ljava_lang_String_;
		public virtual unsafe string RefundAddress {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Order']/method[@name='getRefundAddress' and count(parameter)=0]"
			[Register ("getRefundAddress", "()Ljava/lang/String;", "GetGetRefundAddressHandler")]
			get {
				if (id_getRefundAddress == IntPtr.Zero)
					id_getRefundAddress = JNIEnv.GetMethodID (class_ref, "getRefundAddress", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getRefundAddress), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRefundAddress", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Order']/method[@name='setRefundAddress' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setRefundAddress", "(Ljava/lang/String;)V", "GetSetRefundAddress_Ljava_lang_String_Handler")]
			set {
				if (id_setRefundAddress_Ljava_lang_String_ == IntPtr.Zero)
					id_setRefundAddress_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setRefundAddress", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setRefundAddress_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRefundAddress", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getTransaction;
#pragma warning disable 0169
		static Delegate GetGetTransactionHandler ()
		{
			if (cb_getTransaction == null)
				cb_getTransaction = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTransaction);
			return cb_getTransaction;
		}

		static IntPtr n_GetTransaction (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.Order __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Order> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Transaction);
		}
#pragma warning restore 0169

		static Delegate cb_setTransaction_Lcom_coinbase_api_entity_Transaction_;
#pragma warning disable 0169
		static Delegate GetSetTransaction_Lcom_coinbase_api_entity_Transaction_Handler ()
		{
			if (cb_setTransaction_Lcom_coinbase_api_entity_Transaction_ == null)
				cb_setTransaction_Lcom_coinbase_api_entity_Transaction_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTransaction_Lcom_coinbase_api_entity_Transaction_);
			return cb_setTransaction_Lcom_coinbase_api_entity_Transaction_;
		}

		static void n_SetTransaction_Lcom_coinbase_api_entity_Transaction_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.Order __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Order> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Coinbase.Api.Entity.Transaction p0 = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Transaction> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Transaction = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTransaction;
		static IntPtr id_setTransaction_Lcom_coinbase_api_entity_Transaction_;
		public virtual unsafe global::Com.Coinbase.Api.Entity.Transaction Transaction {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Order']/method[@name='getTransaction' and count(parameter)=0]"
			[Register ("getTransaction", "()Lcom/coinbase/api/entity/Transaction;", "GetGetTransactionHandler")]
			get {
				if (id_getTransaction == IntPtr.Zero)
					id_getTransaction = JNIEnv.GetMethodID (class_ref, "getTransaction", "()Lcom/coinbase/api/entity/Transaction;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Transaction> (JNIEnv.CallObjectMethod  (Handle, id_getTransaction), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Transaction> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTransaction", "()Lcom/coinbase/api/entity/Transaction;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Order']/method[@name='setTransaction' and count(parameter)=1 and parameter[1][@type='com.coinbase.api.entity.Transaction']]"
			[Register ("setTransaction", "(Lcom/coinbase/api/entity/Transaction;)V", "GetSetTransaction_Lcom_coinbase_api_entity_Transaction_Handler")]
			set {
				if (id_setTransaction_Lcom_coinbase_api_entity_Transaction_ == IntPtr.Zero)
					id_setTransaction_Lcom_coinbase_api_entity_Transaction_ = JNIEnv.GetMethodID (class_ref, "setTransaction", "(Lcom/coinbase/api/entity/Transaction;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setTransaction_Lcom_coinbase_api_entity_Transaction_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTransaction", "(Lcom/coinbase/api/entity/Transaction;)V"), __args);
				} finally {
				}
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
			global::Com.Coinbase.Api.Entity.Order __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Order> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetStatus ());
		}
#pragma warning restore 0169

		static IntPtr id_getStatus;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Order']/method[@name='getStatus' and count(parameter)=0]"
		[Register ("getStatus", "()Lcom/coinbase/api/entity/Order$Status;", "GetGetStatusHandler")]
		public virtual unsafe global::Com.Coinbase.Api.Entity.Order.Status GetStatus ()
		{
			if (id_getStatus == IntPtr.Zero)
				id_getStatus = JNIEnv.GetMethodID (class_ref, "getStatus", "()Lcom/coinbase/api/entity/Order$Status;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Order.Status> (JNIEnv.CallObjectMethod  (Handle, id_getStatus), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Order.Status> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStatus", "()Lcom/coinbase/api/entity/Order$Status;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setStatus_Lcom_coinbase_api_entity_Order_Status_;
#pragma warning disable 0169
		static Delegate GetSetStatus_Lcom_coinbase_api_entity_Order_Status_Handler ()
		{
			if (cb_setStatus_Lcom_coinbase_api_entity_Order_Status_ == null)
				cb_setStatus_Lcom_coinbase_api_entity_Order_Status_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetStatus_Lcom_coinbase_api_entity_Order_Status_);
			return cb_setStatus_Lcom_coinbase_api_entity_Order_Status_;
		}

		static void n_SetStatus_Lcom_coinbase_api_entity_Order_Status_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.Order __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Order> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Coinbase.Api.Entity.Order.Status p0 = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Order.Status> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetStatus (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setStatus_Lcom_coinbase_api_entity_Order_Status_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Order']/method[@name='setStatus' and count(parameter)=1 and parameter[1][@type='com.coinbase.api.entity.Order.Status']]"
		[Register ("setStatus", "(Lcom/coinbase/api/entity/Order$Status;)V", "GetSetStatus_Lcom_coinbase_api_entity_Order_Status_Handler")]
		public virtual unsafe void SetStatus (global::Com.Coinbase.Api.Entity.Order.Status p0)
		{
			if (id_setStatus_Lcom_coinbase_api_entity_Order_Status_ == IntPtr.Zero)
				id_setStatus_Lcom_coinbase_api_entity_Order_Status_ = JNIEnv.GetMethodID (class_ref, "setStatus", "(Lcom/coinbase/api/entity/Order$Status;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setStatus_Lcom_coinbase_api_entity_Order_Status_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setStatus", "(Lcom/coinbase/api/entity/Order$Status;)V"), __args);
			} finally {
			}
		}

	}
}
