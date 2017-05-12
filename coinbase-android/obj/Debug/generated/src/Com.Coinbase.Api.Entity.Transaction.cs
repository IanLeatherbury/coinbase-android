using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Coinbase.Api.Entity {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Transaction']"
	[global::Android.Runtime.Register ("com/coinbase/api/entity/Transaction", DoNotGenerateAcw=true)]
	public partial class Transaction : global::Java.Lang.Object, global::Java.IO.ISerializable {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Transaction.DetailedStatus']"
		[global::Android.Runtime.Register ("com/coinbase/api/entity/Transaction$DetailedStatus", DoNotGenerateAcw=true)]
		public sealed partial class DetailedStatus : global::Java.Lang.Enum {


			static IntPtr CANCELED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Transaction.DetailedStatus']/field[@name='CANCELED']"
			[Register ("CANCELED")]
			public static global::Com.Coinbase.Api.Entity.Transaction.DetailedStatus Canceled {
				get {
					if (CANCELED_jfieldId == IntPtr.Zero)
						CANCELED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CANCELED", "Lcom/coinbase/api/entity/Transaction$DetailedStatus;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CANCELED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Transaction.DetailedStatus> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr COMPLETED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Transaction.DetailedStatus']/field[@name='COMPLETED']"
			[Register ("COMPLETED")]
			public static global::Com.Coinbase.Api.Entity.Transaction.DetailedStatus Completed {
				get {
					if (COMPLETED_jfieldId == IntPtr.Zero)
						COMPLETED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "COMPLETED", "Lcom/coinbase/api/entity/Transaction$DetailedStatus;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, COMPLETED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Transaction.DetailedStatus> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr EXPIRED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Transaction.DetailedStatus']/field[@name='EXPIRED']"
			[Register ("EXPIRED")]
			public static global::Com.Coinbase.Api.Entity.Transaction.DetailedStatus Expired {
				get {
					if (EXPIRED_jfieldId == IntPtr.Zero)
						EXPIRED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EXPIRED", "Lcom/coinbase/api/entity/Transaction$DetailedStatus;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EXPIRED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Transaction.DetailedStatus> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr FAILED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Transaction.DetailedStatus']/field[@name='FAILED']"
			[Register ("FAILED")]
			public static global::Com.Coinbase.Api.Entity.Transaction.DetailedStatus Failed {
				get {
					if (FAILED_jfieldId == IntPtr.Zero)
						FAILED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FAILED", "Lcom/coinbase/api/entity/Transaction$DetailedStatus;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FAILED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Transaction.DetailedStatus> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr PENDING_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Transaction.DetailedStatus']/field[@name='PENDING']"
			[Register ("PENDING")]
			public static global::Com.Coinbase.Api.Entity.Transaction.DetailedStatus Pending {
				get {
					if (PENDING_jfieldId == IntPtr.Zero)
						PENDING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PENDING", "Lcom/coinbase/api/entity/Transaction$DetailedStatus;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PENDING_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Transaction.DetailedStatus> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr WAITING_FOR_CLEARING_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Transaction.DetailedStatus']/field[@name='WAITING_FOR_CLEARING']"
			[Register ("WAITING_FOR_CLEARING")]
			public static global::Com.Coinbase.Api.Entity.Transaction.DetailedStatus WaitingForClearing {
				get {
					if (WAITING_FOR_CLEARING_jfieldId == IntPtr.Zero)
						WAITING_FOR_CLEARING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "WAITING_FOR_CLEARING", "Lcom/coinbase/api/entity/Transaction$DetailedStatus;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, WAITING_FOR_CLEARING_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Transaction.DetailedStatus> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr WAITING_FOR_SIGNATURE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Transaction.DetailedStatus']/field[@name='WAITING_FOR_SIGNATURE']"
			[Register ("WAITING_FOR_SIGNATURE")]
			public static global::Com.Coinbase.Api.Entity.Transaction.DetailedStatus WaitingForSignature {
				get {
					if (WAITING_FOR_SIGNATURE_jfieldId == IntPtr.Zero)
						WAITING_FOR_SIGNATURE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "WAITING_FOR_SIGNATURE", "Lcom/coinbase/api/entity/Transaction$DetailedStatus;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, WAITING_FOR_SIGNATURE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Transaction.DetailedStatus> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/coinbase/api/entity/Transaction$DetailedStatus", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (DetailedStatus); }
			}

			internal DetailedStatus (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_create_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Transaction.DetailedStatus']/method[@name='create' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("create", "(Ljava/lang/String;)Lcom/coinbase/api/entity/Transaction$DetailedStatus;", "")]
			public static unsafe global::Com.Coinbase.Api.Entity.Transaction.DetailedStatus Create (string p0)
			{
				if (id_create_Ljava_lang_String_ == IntPtr.Zero)
					id_create_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "create", "(Ljava/lang/String;)Lcom/coinbase/api/entity/Transaction$DetailedStatus;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Coinbase.Api.Entity.Transaction.DetailedStatus __ret = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Transaction.DetailedStatus> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Transaction.DetailedStatus']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/coinbase/api/entity/Transaction$DetailedStatus;", "")]
			public static unsafe global::Com.Coinbase.Api.Entity.Transaction.DetailedStatus ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/coinbase/api/entity/Transaction$DetailedStatus;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Coinbase.Api.Entity.Transaction.DetailedStatus __ret = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Transaction.DetailedStatus> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Transaction.DetailedStatus']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/coinbase/api/entity/Transaction$DetailedStatus;", "")]
			public static unsafe global::Com.Coinbase.Api.Entity.Transaction.DetailedStatus[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/coinbase/api/entity/Transaction$DetailedStatus;");
				try {
					return (global::Com.Coinbase.Api.Entity.Transaction.DetailedStatus[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Coinbase.Api.Entity.Transaction.DetailedStatus));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Transaction.Status']"
		[global::Android.Runtime.Register ("com/coinbase/api/entity/Transaction$Status", DoNotGenerateAcw=true)]
		public sealed partial class Status : global::Java.Lang.Enum {


			static IntPtr COMPLETE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Transaction.Status']/field[@name='COMPLETE']"
			[Register ("COMPLETE")]
			public static global::Com.Coinbase.Api.Entity.Transaction.Status Complete {
				get {
					if (COMPLETE_jfieldId == IntPtr.Zero)
						COMPLETE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "COMPLETE", "Lcom/coinbase/api/entity/Transaction$Status;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, COMPLETE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Transaction.Status> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr PENDING_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Transaction.Status']/field[@name='PENDING']"
			[Register ("PENDING")]
			public static global::Com.Coinbase.Api.Entity.Transaction.Status Pending {
				get {
					if (PENDING_jfieldId == IntPtr.Zero)
						PENDING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PENDING", "Lcom/coinbase/api/entity/Transaction$Status;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PENDING_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Transaction.Status> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/coinbase/api/entity/Transaction$Status", ref java_class_handle);
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Transaction.Status']/method[@name='create' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("create", "(Ljava/lang/String;)Lcom/coinbase/api/entity/Transaction$Status;", "")]
			public static unsafe global::Com.Coinbase.Api.Entity.Transaction.Status Create (string p0)
			{
				if (id_create_Ljava_lang_String_ == IntPtr.Zero)
					id_create_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "create", "(Ljava/lang/String;)Lcom/coinbase/api/entity/Transaction$Status;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Coinbase.Api.Entity.Transaction.Status __ret = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Transaction.Status> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Transaction.Status']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/coinbase/api/entity/Transaction$Status;", "")]
			public static unsafe global::Com.Coinbase.Api.Entity.Transaction.Status ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/coinbase/api/entity/Transaction$Status;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Coinbase.Api.Entity.Transaction.Status __ret = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Transaction.Status> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Transaction.Status']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/coinbase/api/entity/Transaction$Status;", "")]
			public static unsafe global::Com.Coinbase.Api.Entity.Transaction.Status[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/coinbase/api/entity/Transaction$Status;");
				try {
					return (global::Com.Coinbase.Api.Entity.Transaction.Status[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Coinbase.Api.Entity.Transaction.Status));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/coinbase/api/entity/Transaction", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Transaction); }
		}

		protected Transaction (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Transaction']/constructor[@name='Transaction' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Transaction ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Transaction)) {
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

		static Delegate cb_getAmountCurrencyIso;
#pragma warning disable 0169
		static Delegate GetGetAmountCurrencyIsoHandler ()
		{
			if (cb_getAmountCurrencyIso == null)
				cb_getAmountCurrencyIso = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAmountCurrencyIso);
			return cb_getAmountCurrencyIso;
		}

		static IntPtr n_GetAmountCurrencyIso (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.Transaction __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Transaction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AmountCurrencyIso);
		}
#pragma warning restore 0169

		static Delegate cb_setAmountCurrencyIso_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAmountCurrencyIso_Ljava_lang_String_Handler ()
		{
			if (cb_setAmountCurrencyIso_Ljava_lang_String_ == null)
				cb_setAmountCurrencyIso_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAmountCurrencyIso_Ljava_lang_String_);
			return cb_setAmountCurrencyIso_Ljava_lang_String_;
		}

		static void n_SetAmountCurrencyIso_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.Transaction __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Transaction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AmountCurrencyIso = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAmountCurrencyIso;
		static IntPtr id_setAmountCurrencyIso_Ljava_lang_String_;
		public virtual unsafe string AmountCurrencyIso {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Transaction']/method[@name='getAmountCurrencyIso' and count(parameter)=0]"
			[Register ("getAmountCurrencyIso", "()Ljava/lang/String;", "GetGetAmountCurrencyIsoHandler")]
			get {
				if (id_getAmountCurrencyIso == IntPtr.Zero)
					id_getAmountCurrencyIso = JNIEnv.GetMethodID (class_ref, "getAmountCurrencyIso", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getAmountCurrencyIso), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAmountCurrencyIso", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Transaction']/method[@name='setAmountCurrencyIso' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAmountCurrencyIso", "(Ljava/lang/String;)V", "GetSetAmountCurrencyIso_Ljava_lang_String_Handler")]
			set {
				if (id_setAmountCurrencyIso_Ljava_lang_String_ == IntPtr.Zero)
					id_setAmountCurrencyIso_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAmountCurrencyIso", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setAmountCurrencyIso_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAmountCurrencyIso", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getAmountString;
#pragma warning disable 0169
		static Delegate GetGetAmountStringHandler ()
		{
			if (cb_getAmountString == null)
				cb_getAmountString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAmountString);
			return cb_getAmountString;
		}

		static IntPtr n_GetAmountString (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.Transaction __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Transaction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AmountString);
		}
#pragma warning restore 0169

		static Delegate cb_setAmountString_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAmountString_Ljava_lang_String_Handler ()
		{
			if (cb_setAmountString_Ljava_lang_String_ == null)
				cb_setAmountString_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAmountString_Ljava_lang_String_);
			return cb_setAmountString_Ljava_lang_String_;
		}

		static void n_SetAmountString_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.Transaction __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Transaction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AmountString = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAmountString;
		static IntPtr id_setAmountString_Ljava_lang_String_;
		public virtual unsafe string AmountString {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Transaction']/method[@name='getAmountString' and count(parameter)=0]"
			[Register ("getAmountString", "()Ljava/lang/String;", "GetGetAmountStringHandler")]
			get {
				if (id_getAmountString == IntPtr.Zero)
					id_getAmountString = JNIEnv.GetMethodID (class_ref, "getAmountString", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getAmountString), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAmountString", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Transaction']/method[@name='setAmountString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAmountString", "(Ljava/lang/String;)V", "GetSetAmountString_Ljava_lang_String_Handler")]
			set {
				if (id_setAmountString_Ljava_lang_String_ == IntPtr.Zero)
					id_setAmountString_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAmountString", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setAmountString_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAmountString", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getConfirmations;
#pragma warning disable 0169
		static Delegate GetGetConfirmationsHandler ()
		{
			if (cb_getConfirmations == null)
				cb_getConfirmations = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetConfirmations);
			return cb_getConfirmations;
		}

		static IntPtr n_GetConfirmations (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.Transaction __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Transaction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Confirmations);
		}
#pragma warning restore 0169

		static Delegate cb_setConfirmations_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetSetConfirmations_Ljava_lang_Integer_Handler ()
		{
			if (cb_setConfirmations_Ljava_lang_Integer_ == null)
				cb_setConfirmations_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetConfirmations_Ljava_lang_Integer_);
			return cb_setConfirmations_Ljava_lang_Integer_;
		}

		static void n_SetConfirmations_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.Transaction __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Transaction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Confirmations = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getConfirmations;
		static IntPtr id_setConfirmations_Ljava_lang_Integer_;
		public virtual unsafe global::Java.Lang.Integer Confirmations {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Transaction']/method[@name='getConfirmations' and count(parameter)=0]"
			[Register ("getConfirmations", "()Ljava/lang/Integer;", "GetGetConfirmationsHandler")]
			get {
				if (id_getConfirmations == IntPtr.Zero)
					id_getConfirmations = JNIEnv.GetMethodID (class_ref, "getConfirmations", "()Ljava/lang/Integer;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod  (Handle, id_getConfirmations), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getConfirmations", "()Ljava/lang/Integer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Transaction']/method[@name='setConfirmations' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("setConfirmations", "(Ljava/lang/Integer;)V", "GetSetConfirmations_Ljava_lang_Integer_Handler")]
			set {
				if (id_setConfirmations_Ljava_lang_Integer_ == IntPtr.Zero)
					id_setConfirmations_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "setConfirmations", "(Ljava/lang/Integer;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setConfirmations_Ljava_lang_Integer_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setConfirmations", "(Ljava/lang/Integer;)V"), __args);
				} finally {
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
			global::Com.Coinbase.Api.Entity.Transaction __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Transaction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Coinbase.Api.Entity.Transaction __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Transaction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.From = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getFrom;
		static IntPtr id_setFrom_Ljava_lang_String_;
		public virtual unsafe string From {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Transaction']/method[@name='getFrom' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Transaction']/method[@name='setFrom' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getHash;
#pragma warning disable 0169
		static Delegate GetGetHashHandler ()
		{
			if (cb_getHash == null)
				cb_getHash = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHash);
			return cb_getHash;
		}

		static IntPtr n_GetHash (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.Transaction __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Transaction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Hash);
		}
#pragma warning restore 0169

		static Delegate cb_setHash_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetHash_Ljava_lang_String_Handler ()
		{
			if (cb_setHash_Ljava_lang_String_ == null)
				cb_setHash_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetHash_Ljava_lang_String_);
			return cb_setHash_Ljava_lang_String_;
		}

		static void n_SetHash_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.Transaction __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Transaction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Hash = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getHash;
		static IntPtr id_setHash_Ljava_lang_String_;
		public virtual unsafe string Hash {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Transaction']/method[@name='getHash' and count(parameter)=0]"
			[Register ("getHash", "()Ljava/lang/String;", "GetGetHashHandler")]
			get {
				if (id_getHash == IntPtr.Zero)
					id_getHash = JNIEnv.GetMethodID (class_ref, "getHash", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getHash), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHash", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Transaction']/method[@name='setHash' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setHash", "(Ljava/lang/String;)V", "GetSetHash_Ljava_lang_String_Handler")]
			set {
				if (id_setHash_Ljava_lang_String_ == IntPtr.Zero)
					id_setHash_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setHash", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setHash_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setHash", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getHsh;
#pragma warning disable 0169
		static Delegate GetGetHshHandler ()
		{
			if (cb_getHsh == null)
				cb_getHsh = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHsh);
			return cb_getHsh;
		}

		static IntPtr n_GetHsh (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.Transaction __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Transaction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Hsh);
		}
#pragma warning restore 0169

		static Delegate cb_setHsh_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetHsh_Ljava_lang_String_Handler ()
		{
			if (cb_setHsh_Ljava_lang_String_ == null)
				cb_setHsh_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetHsh_Ljava_lang_String_);
			return cb_setHsh_Ljava_lang_String_;
		}

		static void n_SetHsh_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.Transaction __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Transaction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Hsh = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getHsh;
		static IntPtr id_setHsh_Ljava_lang_String_;
		public virtual unsafe string Hsh {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Transaction']/method[@name='getHsh' and count(parameter)=0]"
			[Register ("getHsh", "()Ljava/lang/String;", "GetGetHshHandler")]
			get {
				if (id_getHsh == IntPtr.Zero)
					id_getHsh = JNIEnv.GetMethodID (class_ref, "getHsh", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getHsh), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHsh", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Transaction']/method[@name='setHsh' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setHsh", "(Ljava/lang/String;)V", "GetSetHsh_Ljava_lang_String_Handler")]
			set {
				if (id_setHsh_Ljava_lang_String_ == IntPtr.Zero)
					id_setHsh_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setHsh", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setHsh_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setHsh", "(Ljava/lang/String;)V"), __args);
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
			global::Com.Coinbase.Api.Entity.Transaction __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Transaction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Coinbase.Api.Entity.Transaction __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Transaction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Id = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getId;
		static IntPtr id_setId_Ljava_lang_String_;
		public virtual unsafe string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Transaction']/method[@name='getId' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Transaction']/method[@name='setId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getIdem;
#pragma warning disable 0169
		static Delegate GetGetIdemHandler ()
		{
			if (cb_getIdem == null)
				cb_getIdem = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIdem);
			return cb_getIdem;
		}

		static IntPtr n_GetIdem (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.Transaction __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Transaction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Idem);
		}
#pragma warning restore 0169

		static Delegate cb_setIdem_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetIdem_Ljava_lang_String_Handler ()
		{
			if (cb_setIdem_Ljava_lang_String_ == null)
				cb_setIdem_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetIdem_Ljava_lang_String_);
			return cb_setIdem_Ljava_lang_String_;
		}

		static void n_SetIdem_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.Transaction __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Transaction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Idem = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getIdem;
		static IntPtr id_setIdem_Ljava_lang_String_;
		public virtual unsafe string Idem {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Transaction']/method[@name='getIdem' and count(parameter)=0]"
			[Register ("getIdem", "()Ljava/lang/String;", "GetGetIdemHandler")]
			get {
				if (id_getIdem == IntPtr.Zero)
					id_getIdem = JNIEnv.GetMethodID (class_ref, "getIdem", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getIdem), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIdem", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Transaction']/method[@name='setIdem' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setIdem", "(Ljava/lang/String;)V", "GetSetIdem_Ljava_lang_String_Handler")]
			set {
				if (id_setIdem_Ljava_lang_String_ == IntPtr.Zero)
					id_setIdem_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setIdem", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setIdem_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setIdem", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getInstantBuy;
#pragma warning disable 0169
		static Delegate GetGetInstantBuyHandler ()
		{
			if (cb_getInstantBuy == null)
				cb_getInstantBuy = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetInstantBuy);
			return cb_getInstantBuy;
		}

		static IntPtr n_GetInstantBuy (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.Transaction __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Transaction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InstantBuy);
		}
#pragma warning restore 0169

		static Delegate cb_setInstantBuy_Ljava_lang_Boolean_;
#pragma warning disable 0169
		static Delegate GetSetInstantBuy_Ljava_lang_Boolean_Handler ()
		{
			if (cb_setInstantBuy_Ljava_lang_Boolean_ == null)
				cb_setInstantBuy_Ljava_lang_Boolean_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetInstantBuy_Ljava_lang_Boolean_);
			return cb_setInstantBuy_Ljava_lang_Boolean_;
		}

		static void n_SetInstantBuy_Ljava_lang_Boolean_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.Transaction __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Transaction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Boolean p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.InstantBuy = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getInstantBuy;
		static IntPtr id_setInstantBuy_Ljava_lang_Boolean_;
		public virtual unsafe global::Java.Lang.Boolean InstantBuy {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Transaction']/method[@name='getInstantBuy' and count(parameter)=0]"
			[Register ("getInstantBuy", "()Ljava/lang/Boolean;", "GetGetInstantBuyHandler")]
			get {
				if (id_getInstantBuy == IntPtr.Zero)
					id_getInstantBuy = JNIEnv.GetMethodID (class_ref, "getInstantBuy", "()Ljava/lang/Boolean;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallObjectMethod  (Handle, id_getInstantBuy), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getInstantBuy", "()Ljava/lang/Boolean;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Transaction']/method[@name='setInstantBuy' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
			[Register ("setInstantBuy", "(Ljava/lang/Boolean;)V", "GetSetInstantBuy_Ljava_lang_Boolean_Handler")]
			set {
				if (id_setInstantBuy_Ljava_lang_Boolean_ == IntPtr.Zero)
					id_setInstantBuy_Ljava_lang_Boolean_ = JNIEnv.GetMethodID (class_ref, "setInstantBuy", "(Ljava/lang/Boolean;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setInstantBuy_Ljava_lang_Boolean_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setInstantBuy", "(Ljava/lang/Boolean;)V"), __args);
				} finally {
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
			global::Com.Coinbase.Api.Entity.Transaction __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Transaction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Coinbase.Api.Entity.Transaction __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Transaction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Notes = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getNotes;
		static IntPtr id_setNotes_Ljava_lang_String_;
		public virtual unsafe string Notes {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Transaction']/method[@name='getNotes' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Transaction']/method[@name='setNotes' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getOrderId;
#pragma warning disable 0169
		static Delegate GetGetOrderIdHandler ()
		{
			if (cb_getOrderId == null)
				cb_getOrderId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOrderId);
			return cb_getOrderId;
		}

		static IntPtr n_GetOrderId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.Transaction __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Transaction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.OrderId);
		}
#pragma warning restore 0169

		static Delegate cb_setOrderId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetOrderId_Ljava_lang_String_Handler ()
		{
			if (cb_setOrderId_Ljava_lang_String_ == null)
				cb_setOrderId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOrderId_Ljava_lang_String_);
			return cb_setOrderId_Ljava_lang_String_;
		}

		static void n_SetOrderId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.Transaction __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Transaction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OrderId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getOrderId;
		static IntPtr id_setOrderId_Ljava_lang_String_;
		public virtual unsafe string OrderId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Transaction']/method[@name='getOrderId' and count(parameter)=0]"
			[Register ("getOrderId", "()Ljava/lang/String;", "GetGetOrderIdHandler")]
			get {
				if (id_getOrderId == IntPtr.Zero)
					id_getOrderId = JNIEnv.GetMethodID (class_ref, "getOrderId", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getOrderId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOrderId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Transaction']/method[@name='setOrderId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setOrderId", "(Ljava/lang/String;)V", "GetSetOrderId_Ljava_lang_String_Handler")]
			set {
				if (id_setOrderId_Ljava_lang_String_ == IntPtr.Zero)
					id_setOrderId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setOrderId", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setOrderId_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOrderId", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getRecipient;
#pragma warning disable 0169
		static Delegate GetGetRecipientHandler ()
		{
			if (cb_getRecipient == null)
				cb_getRecipient = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRecipient);
			return cb_getRecipient;
		}

		static IntPtr n_GetRecipient (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.Transaction __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Transaction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Recipient);
		}
#pragma warning restore 0169

		static Delegate cb_setRecipient_Lcom_coinbase_api_entity_User_;
#pragma warning disable 0169
		static Delegate GetSetRecipient_Lcom_coinbase_api_entity_User_Handler ()
		{
			if (cb_setRecipient_Lcom_coinbase_api_entity_User_ == null)
				cb_setRecipient_Lcom_coinbase_api_entity_User_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRecipient_Lcom_coinbase_api_entity_User_);
			return cb_setRecipient_Lcom_coinbase_api_entity_User_;
		}

		static void n_SetRecipient_Lcom_coinbase_api_entity_User_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.Transaction __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Transaction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Coinbase.Api.Entity.User p0 = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.User> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Recipient = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getRecipient;
		static IntPtr id_setRecipient_Lcom_coinbase_api_entity_User_;
		public virtual unsafe global::Com.Coinbase.Api.Entity.User Recipient {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Transaction']/method[@name='getRecipient' and count(parameter)=0]"
			[Register ("getRecipient", "()Lcom/coinbase/api/entity/User;", "GetGetRecipientHandler")]
			get {
				if (id_getRecipient == IntPtr.Zero)
					id_getRecipient = JNIEnv.GetMethodID (class_ref, "getRecipient", "()Lcom/coinbase/api/entity/User;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.User> (JNIEnv.CallObjectMethod  (Handle, id_getRecipient), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.User> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRecipient", "()Lcom/coinbase/api/entity/User;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Transaction']/method[@name='setRecipient' and count(parameter)=1 and parameter[1][@type='com.coinbase.api.entity.User']]"
			[Register ("setRecipient", "(Lcom/coinbase/api/entity/User;)V", "GetSetRecipient_Lcom_coinbase_api_entity_User_Handler")]
			set {
				if (id_setRecipient_Lcom_coinbase_api_entity_User_ == IntPtr.Zero)
					id_setRecipient_Lcom_coinbase_api_entity_User_ = JNIEnv.GetMethodID (class_ref, "setRecipient", "(Lcom/coinbase/api/entity/User;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setRecipient_Lcom_coinbase_api_entity_User_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRecipient", "(Lcom/coinbase/api/entity/User;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getRecipientAccount;
#pragma warning disable 0169
		static Delegate GetGetRecipientAccountHandler ()
		{
			if (cb_getRecipientAccount == null)
				cb_getRecipientAccount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRecipientAccount);
			return cb_getRecipientAccount;
		}

		static IntPtr n_GetRecipientAccount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.Transaction __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Transaction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RecipientAccount);
		}
#pragma warning restore 0169

		static Delegate cb_setRecipientAccount_Lcom_coinbase_api_entity_Account_;
#pragma warning disable 0169
		static Delegate GetSetRecipientAccount_Lcom_coinbase_api_entity_Account_Handler ()
		{
			if (cb_setRecipientAccount_Lcom_coinbase_api_entity_Account_ == null)
				cb_setRecipientAccount_Lcom_coinbase_api_entity_Account_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRecipientAccount_Lcom_coinbase_api_entity_Account_);
			return cb_setRecipientAccount_Lcom_coinbase_api_entity_Account_;
		}

		static void n_SetRecipientAccount_Lcom_coinbase_api_entity_Account_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.Transaction __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Transaction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Coinbase.Api.Entity.Account p0 = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Account> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RecipientAccount = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getRecipientAccount;
		static IntPtr id_setRecipientAccount_Lcom_coinbase_api_entity_Account_;
		public virtual unsafe global::Com.Coinbase.Api.Entity.Account RecipientAccount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Transaction']/method[@name='getRecipientAccount' and count(parameter)=0]"
			[Register ("getRecipientAccount", "()Lcom/coinbase/api/entity/Account;", "GetGetRecipientAccountHandler")]
			get {
				if (id_getRecipientAccount == IntPtr.Zero)
					id_getRecipientAccount = JNIEnv.GetMethodID (class_ref, "getRecipientAccount", "()Lcom/coinbase/api/entity/Account;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Account> (JNIEnv.CallObjectMethod  (Handle, id_getRecipientAccount), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Account> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRecipientAccount", "()Lcom/coinbase/api/entity/Account;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Transaction']/method[@name='setRecipientAccount' and count(parameter)=1 and parameter[1][@type='com.coinbase.api.entity.Account']]"
			[Register ("setRecipientAccount", "(Lcom/coinbase/api/entity/Account;)V", "GetSetRecipientAccount_Lcom_coinbase_api_entity_Account_Handler")]
			set {
				if (id_setRecipientAccount_Lcom_coinbase_api_entity_Account_ == IntPtr.Zero)
					id_setRecipientAccount_Lcom_coinbase_api_entity_Account_ = JNIEnv.GetMethodID (class_ref, "setRecipientAccount", "(Lcom/coinbase/api/entity/Account;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setRecipientAccount_Lcom_coinbase_api_entity_Account_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRecipientAccount", "(Lcom/coinbase/api/entity/Account;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getRecipientAddress;
#pragma warning disable 0169
		static Delegate GetGetRecipientAddressHandler ()
		{
			if (cb_getRecipientAddress == null)
				cb_getRecipientAddress = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRecipientAddress);
			return cb_getRecipientAddress;
		}

		static IntPtr n_GetRecipientAddress (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.Transaction __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Transaction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RecipientAddress);
		}
#pragma warning restore 0169

		static Delegate cb_setRecipientAddress_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetRecipientAddress_Ljava_lang_String_Handler ()
		{
			if (cb_setRecipientAddress_Ljava_lang_String_ == null)
				cb_setRecipientAddress_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRecipientAddress_Ljava_lang_String_);
			return cb_setRecipientAddress_Ljava_lang_String_;
		}

		static void n_SetRecipientAddress_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.Transaction __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Transaction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RecipientAddress = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getRecipientAddress;
		static IntPtr id_setRecipientAddress_Ljava_lang_String_;
		public virtual unsafe string RecipientAddress {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Transaction']/method[@name='getRecipientAddress' and count(parameter)=0]"
			[Register ("getRecipientAddress", "()Ljava/lang/String;", "GetGetRecipientAddressHandler")]
			get {
				if (id_getRecipientAddress == IntPtr.Zero)
					id_getRecipientAddress = JNIEnv.GetMethodID (class_ref, "getRecipientAddress", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getRecipientAddress), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRecipientAddress", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Transaction']/method[@name='setRecipientAddress' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setRecipientAddress", "(Ljava/lang/String;)V", "GetSetRecipientAddress_Ljava_lang_String_Handler")]
			set {
				if (id_setRecipientAddress_Ljava_lang_String_ == IntPtr.Zero)
					id_setRecipientAddress_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setRecipientAddress", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setRecipientAddress_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRecipientAddress", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getSender;
#pragma warning disable 0169
		static Delegate GetGetSenderHandler ()
		{
			if (cb_getSender == null)
				cb_getSender = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSender);
			return cb_getSender;
		}

		static IntPtr n_GetSender (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.Transaction __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Transaction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Sender);
		}
#pragma warning restore 0169

		static Delegate cb_setSender_Lcom_coinbase_api_entity_User_;
#pragma warning disable 0169
		static Delegate GetSetSender_Lcom_coinbase_api_entity_User_Handler ()
		{
			if (cb_setSender_Lcom_coinbase_api_entity_User_ == null)
				cb_setSender_Lcom_coinbase_api_entity_User_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSender_Lcom_coinbase_api_entity_User_);
			return cb_setSender_Lcom_coinbase_api_entity_User_;
		}

		static void n_SetSender_Lcom_coinbase_api_entity_User_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.Transaction __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Transaction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Coinbase.Api.Entity.User p0 = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.User> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Sender = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getSender;
		static IntPtr id_setSender_Lcom_coinbase_api_entity_User_;
		public virtual unsafe global::Com.Coinbase.Api.Entity.User Sender {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Transaction']/method[@name='getSender' and count(parameter)=0]"
			[Register ("getSender", "()Lcom/coinbase/api/entity/User;", "GetGetSenderHandler")]
			get {
				if (id_getSender == IntPtr.Zero)
					id_getSender = JNIEnv.GetMethodID (class_ref, "getSender", "()Lcom/coinbase/api/entity/User;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.User> (JNIEnv.CallObjectMethod  (Handle, id_getSender), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.User> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSender", "()Lcom/coinbase/api/entity/User;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Transaction']/method[@name='setSender' and count(parameter)=1 and parameter[1][@type='com.coinbase.api.entity.User']]"
			[Register ("setSender", "(Lcom/coinbase/api/entity/User;)V", "GetSetSender_Lcom_coinbase_api_entity_User_Handler")]
			set {
				if (id_setSender_Lcom_coinbase_api_entity_User_ == IntPtr.Zero)
					id_setSender_Lcom_coinbase_api_entity_User_ = JNIEnv.GetMethodID (class_ref, "setSender", "(Lcom/coinbase/api/entity/User;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setSender_Lcom_coinbase_api_entity_User_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSender", "(Lcom/coinbase/api/entity/User;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSenderAccount;
#pragma warning disable 0169
		static Delegate GetGetSenderAccountHandler ()
		{
			if (cb_getSenderAccount == null)
				cb_getSenderAccount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSenderAccount);
			return cb_getSenderAccount;
		}

		static IntPtr n_GetSenderAccount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.Transaction __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Transaction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SenderAccount);
		}
#pragma warning restore 0169

		static Delegate cb_setSenderAccount_Lcom_coinbase_api_entity_Account_;
#pragma warning disable 0169
		static Delegate GetSetSenderAccount_Lcom_coinbase_api_entity_Account_Handler ()
		{
			if (cb_setSenderAccount_Lcom_coinbase_api_entity_Account_ == null)
				cb_setSenderAccount_Lcom_coinbase_api_entity_Account_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSenderAccount_Lcom_coinbase_api_entity_Account_);
			return cb_setSenderAccount_Lcom_coinbase_api_entity_Account_;
		}

		static void n_SetSenderAccount_Lcom_coinbase_api_entity_Account_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.Transaction __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Transaction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Coinbase.Api.Entity.Account p0 = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Account> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SenderAccount = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getSenderAccount;
		static IntPtr id_setSenderAccount_Lcom_coinbase_api_entity_Account_;
		public virtual unsafe global::Com.Coinbase.Api.Entity.Account SenderAccount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Transaction']/method[@name='getSenderAccount' and count(parameter)=0]"
			[Register ("getSenderAccount", "()Lcom/coinbase/api/entity/Account;", "GetGetSenderAccountHandler")]
			get {
				if (id_getSenderAccount == IntPtr.Zero)
					id_getSenderAccount = JNIEnv.GetMethodID (class_ref, "getSenderAccount", "()Lcom/coinbase/api/entity/Account;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Account> (JNIEnv.CallObjectMethod  (Handle, id_getSenderAccount), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Account> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSenderAccount", "()Lcom/coinbase/api/entity/Account;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Transaction']/method[@name='setSenderAccount' and count(parameter)=1 and parameter[1][@type='com.coinbase.api.entity.Account']]"
			[Register ("setSenderAccount", "(Lcom/coinbase/api/entity/Account;)V", "GetSetSenderAccount_Lcom_coinbase_api_entity_Account_Handler")]
			set {
				if (id_setSenderAccount_Lcom_coinbase_api_entity_Account_ == IntPtr.Zero)
					id_setSenderAccount_Lcom_coinbase_api_entity_Account_ = JNIEnv.GetMethodID (class_ref, "setSenderAccount", "(Lcom/coinbase/api/entity/Account;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setSenderAccount_Lcom_coinbase_api_entity_Account_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSenderAccount", "(Lcom/coinbase/api/entity/Account;)V"), __args);
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
			global::Com.Coinbase.Api.Entity.Transaction __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Transaction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Coinbase.Api.Entity.Transaction __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Transaction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.To = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTo;
		static IntPtr id_setTo_Ljava_lang_String_;
		public virtual unsafe string To {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Transaction']/method[@name='getTo' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Transaction']/method[@name='setTo' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getUserFee;
#pragma warning disable 0169
		static Delegate GetGetUserFeeHandler ()
		{
			if (cb_getUserFee == null)
				cb_getUserFee = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUserFee);
			return cb_getUserFee;
		}

		static IntPtr n_GetUserFee (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.Transaction __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Transaction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.UserFee);
		}
#pragma warning restore 0169

		static IntPtr id_getUserFee;
		public virtual unsafe string UserFee {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Transaction']/method[@name='getUserFee' and count(parameter)=0]"
			[Register ("getUserFee", "()Ljava/lang/String;", "GetGetUserFeeHandler")]
			get {
				if (id_getUserFee == IntPtr.Zero)
					id_getUserFee = JNIEnv.GetMethodID (class_ref, "getUserFee", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getUserFee), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUserFee", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDetailedStatus;
#pragma warning disable 0169
		static Delegate GetGetDetailedStatusHandler ()
		{
			if (cb_getDetailedStatus == null)
				cb_getDetailedStatus = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDetailedStatus);
			return cb_getDetailedStatus;
		}

		static IntPtr n_GetDetailedStatus (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.Transaction __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Transaction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetDetailedStatus ());
		}
#pragma warning restore 0169

		static IntPtr id_getDetailedStatus;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Transaction']/method[@name='getDetailedStatus' and count(parameter)=0]"
		[Register ("getDetailedStatus", "()Lcom/coinbase/api/entity/Transaction$DetailedStatus;", "GetGetDetailedStatusHandler")]
		public virtual unsafe global::Com.Coinbase.Api.Entity.Transaction.DetailedStatus GetDetailedStatus ()
		{
			if (id_getDetailedStatus == IntPtr.Zero)
				id_getDetailedStatus = JNIEnv.GetMethodID (class_ref, "getDetailedStatus", "()Lcom/coinbase/api/entity/Transaction$DetailedStatus;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Transaction.DetailedStatus> (JNIEnv.CallObjectMethod  (Handle, id_getDetailedStatus), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Transaction.DetailedStatus> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDetailedStatus", "()Lcom/coinbase/api/entity/Transaction$DetailedStatus;")), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Coinbase.Api.Entity.Transaction __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Transaction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetStatus ());
		}
#pragma warning restore 0169

		static IntPtr id_getStatus;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Transaction']/method[@name='getStatus' and count(parameter)=0]"
		[Register ("getStatus", "()Lcom/coinbase/api/entity/Transaction$Status;", "GetGetStatusHandler")]
		public virtual unsafe global::Com.Coinbase.Api.Entity.Transaction.Status GetStatus ()
		{
			if (id_getStatus == IntPtr.Zero)
				id_getStatus = JNIEnv.GetMethodID (class_ref, "getStatus", "()Lcom/coinbase/api/entity/Transaction$Status;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Transaction.Status> (JNIEnv.CallObjectMethod  (Handle, id_getStatus), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Transaction.Status> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStatus", "()Lcom/coinbase/api/entity/Transaction$Status;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_isRequest;
#pragma warning disable 0169
		static Delegate GetIsRequestHandler ()
		{
			if (cb_isRequest == null)
				cb_isRequest = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_IsRequest);
			return cb_isRequest;
		}

		static IntPtr n_IsRequest (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.Transaction __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Transaction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IsRequest ());
		}
#pragma warning restore 0169

		static IntPtr id_isRequest;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Transaction']/method[@name='isRequest' and count(parameter)=0]"
		[Register ("isRequest", "()Ljava/lang/Boolean;", "GetIsRequestHandler")]
		public virtual unsafe global::Java.Lang.Boolean IsRequest ()
		{
			if (id_isRequest == IntPtr.Zero)
				id_isRequest = JNIEnv.GetMethodID (class_ref, "isRequest", "()Ljava/lang/Boolean;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallObjectMethod  (Handle, id_isRequest), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isRequest", "()Ljava/lang/Boolean;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setDetailedStatus_Lcom_coinbase_api_entity_Transaction_DetailedStatus_;
#pragma warning disable 0169
		static Delegate GetSetDetailedStatus_Lcom_coinbase_api_entity_Transaction_DetailedStatus_Handler ()
		{
			if (cb_setDetailedStatus_Lcom_coinbase_api_entity_Transaction_DetailedStatus_ == null)
				cb_setDetailedStatus_Lcom_coinbase_api_entity_Transaction_DetailedStatus_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDetailedStatus_Lcom_coinbase_api_entity_Transaction_DetailedStatus_);
			return cb_setDetailedStatus_Lcom_coinbase_api_entity_Transaction_DetailedStatus_;
		}

		static void n_SetDetailedStatus_Lcom_coinbase_api_entity_Transaction_DetailedStatus_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.Transaction __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Transaction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Coinbase.Api.Entity.Transaction.DetailedStatus p0 = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Transaction.DetailedStatus> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetDetailedStatus (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setDetailedStatus_Lcom_coinbase_api_entity_Transaction_DetailedStatus_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Transaction']/method[@name='setDetailedStatus' and count(parameter)=1 and parameter[1][@type='com.coinbase.api.entity.Transaction.DetailedStatus']]"
		[Register ("setDetailedStatus", "(Lcom/coinbase/api/entity/Transaction$DetailedStatus;)V", "GetSetDetailedStatus_Lcom_coinbase_api_entity_Transaction_DetailedStatus_Handler")]
		public virtual unsafe void SetDetailedStatus (global::Com.Coinbase.Api.Entity.Transaction.DetailedStatus p0)
		{
			if (id_setDetailedStatus_Lcom_coinbase_api_entity_Transaction_DetailedStatus_ == IntPtr.Zero)
				id_setDetailedStatus_Lcom_coinbase_api_entity_Transaction_DetailedStatus_ = JNIEnv.GetMethodID (class_ref, "setDetailedStatus", "(Lcom/coinbase/api/entity/Transaction$DetailedStatus;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setDetailedStatus_Lcom_coinbase_api_entity_Transaction_DetailedStatus_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDetailedStatus", "(Lcom/coinbase/api/entity/Transaction$DetailedStatus;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setRequest_Ljava_lang_Boolean_;
#pragma warning disable 0169
		static Delegate GetSetRequest_Ljava_lang_Boolean_Handler ()
		{
			if (cb_setRequest_Ljava_lang_Boolean_ == null)
				cb_setRequest_Ljava_lang_Boolean_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRequest_Ljava_lang_Boolean_);
			return cb_setRequest_Ljava_lang_Boolean_;
		}

		static void n_SetRequest_Ljava_lang_Boolean_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.Transaction __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Transaction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Boolean p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetRequest (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setRequest_Ljava_lang_Boolean_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Transaction']/method[@name='setRequest' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
		[Register ("setRequest", "(Ljava/lang/Boolean;)V", "GetSetRequest_Ljava_lang_Boolean_Handler")]
		public virtual unsafe void SetRequest (global::Java.Lang.Boolean p0)
		{
			if (id_setRequest_Ljava_lang_Boolean_ == IntPtr.Zero)
				id_setRequest_Ljava_lang_Boolean_ = JNIEnv.GetMethodID (class_ref, "setRequest", "(Ljava/lang/Boolean;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setRequest_Ljava_lang_Boolean_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRequest", "(Ljava/lang/Boolean;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setStatus_Lcom_coinbase_api_entity_Transaction_Status_;
#pragma warning disable 0169
		static Delegate GetSetStatus_Lcom_coinbase_api_entity_Transaction_Status_Handler ()
		{
			if (cb_setStatus_Lcom_coinbase_api_entity_Transaction_Status_ == null)
				cb_setStatus_Lcom_coinbase_api_entity_Transaction_Status_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetStatus_Lcom_coinbase_api_entity_Transaction_Status_);
			return cb_setStatus_Lcom_coinbase_api_entity_Transaction_Status_;
		}

		static void n_SetStatus_Lcom_coinbase_api_entity_Transaction_Status_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.Transaction __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Transaction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Coinbase.Api.Entity.Transaction.Status p0 = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Transaction.Status> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetStatus (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setStatus_Lcom_coinbase_api_entity_Transaction_Status_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Transaction']/method[@name='setStatus' and count(parameter)=1 and parameter[1][@type='com.coinbase.api.entity.Transaction.Status']]"
		[Register ("setStatus", "(Lcom/coinbase/api/entity/Transaction$Status;)V", "GetSetStatus_Lcom_coinbase_api_entity_Transaction_Status_Handler")]
		public virtual unsafe void SetStatus (global::Com.Coinbase.Api.Entity.Transaction.Status p0)
		{
			if (id_setStatus_Lcom_coinbase_api_entity_Transaction_Status_ == IntPtr.Zero)
				id_setStatus_Lcom_coinbase_api_entity_Transaction_Status_ = JNIEnv.GetMethodID (class_ref, "setStatus", "(Lcom/coinbase/api/entity/Transaction$Status;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setStatus_Lcom_coinbase_api_entity_Transaction_Status_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setStatus", "(Lcom/coinbase/api/entity/Transaction$Status;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setUserFee_Ljava_math_BigDecimal_;
#pragma warning disable 0169
		static Delegate GetSetUserFee_Ljava_math_BigDecimal_Handler ()
		{
			if (cb_setUserFee_Ljava_math_BigDecimal_ == null)
				cb_setUserFee_Ljava_math_BigDecimal_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetUserFee_Ljava_math_BigDecimal_);
			return cb_setUserFee_Ljava_math_BigDecimal_;
		}

		static void n_SetUserFee_Ljava_math_BigDecimal_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.Transaction __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Transaction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Math.BigDecimal p0 = global::Java.Lang.Object.GetObject<global::Java.Math.BigDecimal> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetUserFee (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setUserFee_Ljava_math_BigDecimal_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='Transaction']/method[@name='setUserFee' and count(parameter)=1 and parameter[1][@type='java.math.BigDecimal']]"
		[Register ("setUserFee", "(Ljava/math/BigDecimal;)V", "GetSetUserFee_Ljava_math_BigDecimal_Handler")]
		public virtual unsafe void SetUserFee (global::Java.Math.BigDecimal p0)
		{
			if (id_setUserFee_Ljava_math_BigDecimal_ == IntPtr.Zero)
				id_setUserFee_Ljava_math_BigDecimal_ = JNIEnv.GetMethodID (class_ref, "setUserFee", "(Ljava/math/BigDecimal;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setUserFee_Ljava_math_BigDecimal_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUserFee", "(Ljava/math/BigDecimal;)V"), __args);
			} finally {
			}
		}

	}
}
