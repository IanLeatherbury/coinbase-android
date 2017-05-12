using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Coinbase.Api.Entity {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='AccountResponse']"
	[global::Android.Runtime.Register ("com/coinbase/api/entity/AccountResponse", DoNotGenerateAcw=true)]
	public partial class AccountResponse : global::Com.Coinbase.Api.Entity.Response {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/coinbase/api/entity/AccountResponse", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AccountResponse); }
		}

		protected AccountResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='AccountResponse']/constructor[@name='AccountResponse' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AccountResponse ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (AccountResponse)) {
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

		static Delegate cb_getAccount;
#pragma warning disable 0169
		static Delegate GetGetAccountHandler ()
		{
			if (cb_getAccount == null)
				cb_getAccount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAccount);
			return cb_getAccount;
		}

		static IntPtr n_GetAccount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.AccountResponse __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.AccountResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Account);
		}
#pragma warning restore 0169

		static Delegate cb_setAccount_Lcom_coinbase_api_entity_Account_;
#pragma warning disable 0169
		static Delegate GetSetAccount_Lcom_coinbase_api_entity_Account_Handler ()
		{
			if (cb_setAccount_Lcom_coinbase_api_entity_Account_ == null)
				cb_setAccount_Lcom_coinbase_api_entity_Account_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAccount_Lcom_coinbase_api_entity_Account_);
			return cb_setAccount_Lcom_coinbase_api_entity_Account_;
		}

		static void n_SetAccount_Lcom_coinbase_api_entity_Account_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.AccountResponse __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.AccountResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Coinbase.Api.Entity.Account p0 = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Account> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Account = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAccount;
		static IntPtr id_setAccount_Lcom_coinbase_api_entity_Account_;
		public virtual unsafe global::Com.Coinbase.Api.Entity.Account Account {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='AccountResponse']/method[@name='getAccount' and count(parameter)=0]"
			[Register ("getAccount", "()Lcom/coinbase/api/entity/Account;", "GetGetAccountHandler")]
			get {
				if (id_getAccount == IntPtr.Zero)
					id_getAccount = JNIEnv.GetMethodID (class_ref, "getAccount", "()Lcom/coinbase/api/entity/Account;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Account> (JNIEnv.CallObjectMethod  (Handle, id_getAccount), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Account> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAccount", "()Lcom/coinbase/api/entity/Account;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='AccountResponse']/method[@name='setAccount' and count(parameter)=1 and parameter[1][@type='com.coinbase.api.entity.Account']]"
			[Register ("setAccount", "(Lcom/coinbase/api/entity/Account;)V", "GetSetAccount_Lcom_coinbase_api_entity_Account_Handler")]
			set {
				if (id_setAccount_Lcom_coinbase_api_entity_Account_ == IntPtr.Zero)
					id_setAccount_Lcom_coinbase_api_entity_Account_ = JNIEnv.GetMethodID (class_ref, "setAccount", "(Lcom/coinbase/api/entity/Account;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setAccount_Lcom_coinbase_api_entity_Account_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAccount", "(Lcom/coinbase/api/entity/Account;)V"), __args);
				} finally {
				}
			}
		}

	}
}
