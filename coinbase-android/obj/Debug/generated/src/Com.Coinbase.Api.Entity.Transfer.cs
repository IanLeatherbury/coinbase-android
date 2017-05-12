using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Coinbase.Api.Entity {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Transfer']"
	[global::Android.Runtime.Register ("com/coinbase/api/entity/Transfer", DoNotGenerateAcw=true)]
	public partial class Transfer : global::Java.Lang.Object, global::Java.IO.ISerializable {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Transfer.Status']"
		[global::Android.Runtime.Register ("com/coinbase/api/entity/Transfer$Status", DoNotGenerateAcw=true)]
		public sealed partial class Status : global::Java.Lang.Enum {


			static IntPtr CANCELED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Transfer.Status']/field[@name='CANCELED']"
			[Register ("CANCELED")]
			public static global::Com.Coinbase.Api.Entity.Transfer.Status Canceled {
				get {
					if (CANCELED_jfieldId == IntPtr.Zero)
						CANCELED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CANCELED", "Lcom/coinbase/api/entity/Transfer$Status;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CANCELED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Transfer.Status> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr COMPLETE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Transfer.Status']/field[@name='COMPLETE']"
			[Register ("COMPLETE")]
			public static global::Com.Coinbase.Api.Entity.Transfer.Status Complete {
				get {
					if (COMPLETE_jfieldId == IntPtr.Zero)
						COMPLETE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "COMPLETE", "Lcom/coinbase/api/entity/Transfer$Status;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, COMPLETE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Transfer.Status> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr CREATED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Transfer.Status']/field[@name='CREATED']"
			[Register ("CREATED")]
			public static global::Com.Coinbase.Api.Entity.Transfer.Status Created {
				get {
					if (CREATED_jfieldId == IntPtr.Zero)
						CREATED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATED", "Lcom/coinbase/api/entity/Transfer$Status;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Transfer.Status> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr PENDING_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Transfer.Status']/field[@name='PENDING']"
			[Register ("PENDING")]
			public static global::Com.Coinbase.Api.Entity.Transfer.Status Pending {
				get {
					if (PENDING_jfieldId == IntPtr.Zero)
						PENDING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PENDING", "Lcom/coinbase/api/entity/Transfer$Status;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PENDING_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Transfer.Status> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr REVERSED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Transfer.Status']/field[@name='REVERSED']"
			[Register ("REVERSED")]
			public static global::Com.Coinbase.Api.Entity.Transfer.Status Reversed {
				get {
					if (REVERSED_jfieldId == IntPtr.Zero)
						REVERSED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "REVERSED", "Lcom/coinbase/api/entity/Transfer$Status;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, REVERSED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Transfer.Status> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/coinbase/api/entity/Transfer$Status", ref java_class_handle);
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Transfer.Status']/method[@name='create' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("create", "(Ljava/lang/String;)Lcom/coinbase/api/entity/Transfer$Status;", "")]
			public static unsafe global::Com.Coinbase.Api.Entity.Transfer.Status Create (string p0)
			{
				if (id_create_Ljava_lang_String_ == IntPtr.Zero)
					id_create_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "create", "(Ljava/lang/String;)Lcom/coinbase/api/entity/Transfer$Status;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Coinbase.Api.Entity.Transfer.Status __ret = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Transfer.Status> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Transfer.Status']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/coinbase/api/entity/Transfer$Status;", "")]
			public static unsafe global::Com.Coinbase.Api.Entity.Transfer.Status ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/coinbase/api/entity/Transfer$Status;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Coinbase.Api.Entity.Transfer.Status __ret = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Transfer.Status> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Transfer.Status']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/coinbase/api/entity/Transfer$Status;", "")]
			public static unsafe global::Com.Coinbase.Api.Entity.Transfer.Status[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/coinbase/api/entity/Transfer$Status;");
				try {
					return (global::Com.Coinbase.Api.Entity.Transfer.Status[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Coinbase.Api.Entity.Transfer.Status));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Transfer.Type']"
		[global::Android.Runtime.Register ("com/coinbase/api/entity/Transfer$Type", DoNotGenerateAcw=true)]
		public sealed partial class Type : global::Java.Lang.Enum {


			static IntPtr BUY_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Transfer.Type']/field[@name='BUY']"
			[Register ("BUY")]
			public static global::Com.Coinbase.Api.Entity.Transfer.Type Buy {
				get {
					if (BUY_jfieldId == IntPtr.Zero)
						BUY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BUY", "Lcom/coinbase/api/entity/Transfer$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BUY_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Transfer.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr SELL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Transfer.Type']/field[@name='SELL']"
			[Register ("SELL")]
			public static global::Com.Coinbase.Api.Entity.Transfer.Type Sell {
				get {
					if (SELL_jfieldId == IntPtr.Zero)
						SELL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SELL", "Lcom/coinbase/api/entity/Transfer$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SELL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Transfer.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/coinbase/api/entity/Transfer$Type", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Type); }
			}

			internal Type (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_create_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Transfer.Type']/method[@name='create' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("create", "(Ljava/lang/String;)Lcom/coinbase/api/entity/Transfer$Type;", "")]
			public static unsafe global::Com.Coinbase.Api.Entity.Transfer.Type Create (string p0)
			{
				if (id_create_Ljava_lang_String_ == IntPtr.Zero)
					id_create_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "create", "(Ljava/lang/String;)Lcom/coinbase/api/entity/Transfer$Type;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Coinbase.Api.Entity.Transfer.Type __ret = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Transfer.Type> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Transfer.Type']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/coinbase/api/entity/Transfer$Type;", "")]
			public static unsafe global::Com.Coinbase.Api.Entity.Transfer.Type ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/coinbase/api/entity/Transfer$Type;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Coinbase.Api.Entity.Transfer.Type __ret = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Transfer.Type> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Transfer.Type']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/coinbase/api/entity/Transfer$Type;", "")]
			public static unsafe global::Com.Coinbase.Api.Entity.Transfer.Type[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/coinbase/api/entity/Transfer$Type;");
				try {
					return (global::Com.Coinbase.Api.Entity.Transfer.Type[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Coinbase.Api.Entity.Transfer.Type));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/coinbase/api/entity/Transfer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Transfer); }
		}

		protected Transfer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Transfer']/constructor[@name='Transfer' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Transfer ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Transfer)) {
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
			global::Com.Coinbase.Api.Entity.Transfer __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Transfer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Coinbase.Api.Entity.Transfer __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Transfer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Code = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCode;
		static IntPtr id_setCode_Ljava_lang_String_;
		public virtual unsafe string Code {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Transfer']/method[@name='getCode' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Transfer']/method[@name='setCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Coinbase.Api.Entity.Transfer __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Transfer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Coinbase.Api.Entity.Transfer __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Transfer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Description = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDescription;
		static IntPtr id_setDescription_Ljava_lang_String_;
		public virtual unsafe string Description {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Transfer']/method[@name='getDescription' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Transfer']/method[@name='setDescription' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getTransactionId;
#pragma warning disable 0169
		static Delegate GetGetTransactionIdHandler ()
		{
			if (cb_getTransactionId == null)
				cb_getTransactionId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTransactionId);
			return cb_getTransactionId;
		}

		static IntPtr n_GetTransactionId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.Transfer __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Transfer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TransactionId);
		}
#pragma warning restore 0169

		static Delegate cb_setTransactionId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTransactionId_Ljava_lang_String_Handler ()
		{
			if (cb_setTransactionId_Ljava_lang_String_ == null)
				cb_setTransactionId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTransactionId_Ljava_lang_String_);
			return cb_setTransactionId_Ljava_lang_String_;
		}

		static void n_SetTransactionId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.Transfer __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Transfer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TransactionId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTransactionId;
		static IntPtr id_setTransactionId_Ljava_lang_String_;
		public virtual unsafe string TransactionId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Transfer']/method[@name='getTransactionId' and count(parameter)=0]"
			[Register ("getTransactionId", "()Ljava/lang/String;", "GetGetTransactionIdHandler")]
			get {
				if (id_getTransactionId == IntPtr.Zero)
					id_getTransactionId = JNIEnv.GetMethodID (class_ref, "getTransactionId", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getTransactionId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTransactionId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Transfer']/method[@name='setTransactionId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTransactionId", "(Ljava/lang/String;)V", "GetSetTransactionId_Ljava_lang_String_Handler")]
			set {
				if (id_setTransactionId_Ljava_lang_String_ == IntPtr.Zero)
					id_setTransactionId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTransactionId", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setTransactionId_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTransactionId", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
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
			global::Com.Coinbase.Api.Entity.Transfer __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Transfer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetStatus ());
		}
#pragma warning restore 0169

		static IntPtr id_getStatus;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Transfer']/method[@name='getStatus' and count(parameter)=0]"
		[Register ("getStatus", "()Lcom/coinbase/api/entity/Transfer$Status;", "GetGetStatusHandler")]
		public virtual unsafe global::Com.Coinbase.Api.Entity.Transfer.Status GetStatus ()
		{
			if (id_getStatus == IntPtr.Zero)
				id_getStatus = JNIEnv.GetMethodID (class_ref, "getStatus", "()Lcom/coinbase/api/entity/Transfer$Status;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Transfer.Status> (JNIEnv.CallObjectMethod  (Handle, id_getStatus), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Transfer.Status> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStatus", "()Lcom/coinbase/api/entity/Transfer$Status;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getType;
#pragma warning disable 0169
		static Delegate GetGetTypeHandler ()
		{
			if (cb_getType == null)
				cb_getType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetType);
			return cb_getType;
		}

		static IntPtr n_GetType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.Transfer __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Transfer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetType ());
		}
#pragma warning restore 0169

		static IntPtr id_getType;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Transfer']/method[@name='getType' and count(parameter)=0]"
		[Register ("getType", "()Lcom/coinbase/api/entity/Transfer$Type;", "GetGetTypeHandler")]
		public virtual unsafe global::Com.Coinbase.Api.Entity.Transfer.Type GetType ()
		{
			if (id_getType == IntPtr.Zero)
				id_getType = JNIEnv.GetMethodID (class_ref, "getType", "()Lcom/coinbase/api/entity/Transfer$Type;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Transfer.Type> (JNIEnv.CallObjectMethod  (Handle, id_getType), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Transfer.Type> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getType", "()Lcom/coinbase/api/entity/Transfer$Type;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setStatus_Lcom_coinbase_api_entity_Transfer_Status_;
#pragma warning disable 0169
		static Delegate GetSetStatus_Lcom_coinbase_api_entity_Transfer_Status_Handler ()
		{
			if (cb_setStatus_Lcom_coinbase_api_entity_Transfer_Status_ == null)
				cb_setStatus_Lcom_coinbase_api_entity_Transfer_Status_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetStatus_Lcom_coinbase_api_entity_Transfer_Status_);
			return cb_setStatus_Lcom_coinbase_api_entity_Transfer_Status_;
		}

		static void n_SetStatus_Lcom_coinbase_api_entity_Transfer_Status_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.Transfer __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Transfer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Coinbase.Api.Entity.Transfer.Status p0 = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Transfer.Status> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetStatus (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setStatus_Lcom_coinbase_api_entity_Transfer_Status_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Transfer']/method[@name='setStatus' and count(parameter)=1 and parameter[1][@type='com.coinbase.api.entity.Transfer.Status']]"
		[Register ("setStatus", "(Lcom/coinbase/api/entity/Transfer$Status;)V", "GetSetStatus_Lcom_coinbase_api_entity_Transfer_Status_Handler")]
		public virtual unsafe void SetStatus (global::Com.Coinbase.Api.Entity.Transfer.Status p0)
		{
			if (id_setStatus_Lcom_coinbase_api_entity_Transfer_Status_ == IntPtr.Zero)
				id_setStatus_Lcom_coinbase_api_entity_Transfer_Status_ = JNIEnv.GetMethodID (class_ref, "setStatus", "(Lcom/coinbase/api/entity/Transfer$Status;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setStatus_Lcom_coinbase_api_entity_Transfer_Status_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setStatus", "(Lcom/coinbase/api/entity/Transfer$Status;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setType_Lcom_coinbase_api_entity_Transfer_Type_;
#pragma warning disable 0169
		static Delegate GetSetType_Lcom_coinbase_api_entity_Transfer_Type_Handler ()
		{
			if (cb_setType_Lcom_coinbase_api_entity_Transfer_Type_ == null)
				cb_setType_Lcom_coinbase_api_entity_Transfer_Type_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetType_Lcom_coinbase_api_entity_Transfer_Type_);
			return cb_setType_Lcom_coinbase_api_entity_Transfer_Type_;
		}

		static void n_SetType_Lcom_coinbase_api_entity_Transfer_Type_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.Transfer __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Transfer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Coinbase.Api.Entity.Transfer.Type p0 = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Transfer.Type> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetType (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setType_Lcom_coinbase_api_entity_Transfer_Type_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Transfer']/method[@name='setType' and count(parameter)=1 and parameter[1][@type='com.coinbase.api.entity.Transfer.Type']]"
		[Register ("setType", "(Lcom/coinbase/api/entity/Transfer$Type;)V", "GetSetType_Lcom_coinbase_api_entity_Transfer_Type_Handler")]
		public virtual unsafe void SetType (global::Com.Coinbase.Api.Entity.Transfer.Type p0)
		{
			if (id_setType_Lcom_coinbase_api_entity_Transfer_Type_ == IntPtr.Zero)
				id_setType_Lcom_coinbase_api_entity_Transfer_Type_ = JNIEnv.GetMethodID (class_ref, "setType", "(Lcom/coinbase/api/entity/Transfer$Type;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setType_Lcom_coinbase_api_entity_Transfer_Type_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setType", "(Lcom/coinbase/api/entity/Transfer$Type;)V"), __args);
			} finally {
			}
		}

	}
}
