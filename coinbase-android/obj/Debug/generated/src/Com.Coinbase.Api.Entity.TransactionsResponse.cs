using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Coinbase.Api.Entity {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='TransactionsResponse']"
	[global::Android.Runtime.Register ("com/coinbase/api/entity/TransactionsResponse", DoNotGenerateAcw=true)]
	public partial class TransactionsResponse : global::Com.Coinbase.Api.Entity.Response {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/coinbase/api/entity/TransactionsResponse", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TransactionsResponse); }
		}

		protected TransactionsResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='TransactionsResponse']/constructor[@name='TransactionsResponse' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TransactionsResponse ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (TransactionsResponse)) {
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

		static Delegate cb_getCurrentUser;
#pragma warning disable 0169
		static Delegate GetGetCurrentUserHandler ()
		{
			if (cb_getCurrentUser == null)
				cb_getCurrentUser = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCurrentUser);
			return cb_getCurrentUser;
		}

		static IntPtr n_GetCurrentUser (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.TransactionsResponse __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.TransactionsResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CurrentUser);
		}
#pragma warning restore 0169

		static Delegate cb_setCurrentUser_Lcom_coinbase_api_entity_User_;
#pragma warning disable 0169
		static Delegate GetSetCurrentUser_Lcom_coinbase_api_entity_User_Handler ()
		{
			if (cb_setCurrentUser_Lcom_coinbase_api_entity_User_ == null)
				cb_setCurrentUser_Lcom_coinbase_api_entity_User_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCurrentUser_Lcom_coinbase_api_entity_User_);
			return cb_setCurrentUser_Lcom_coinbase_api_entity_User_;
		}

		static void n_SetCurrentUser_Lcom_coinbase_api_entity_User_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.TransactionsResponse __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.TransactionsResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Coinbase.Api.Entity.User p0 = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.User> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CurrentUser = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCurrentUser;
		static IntPtr id_setCurrentUser_Lcom_coinbase_api_entity_User_;
		public virtual unsafe global::Com.Coinbase.Api.Entity.User CurrentUser {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='TransactionsResponse']/method[@name='getCurrentUser' and count(parameter)=0]"
			[Register ("getCurrentUser", "()Lcom/coinbase/api/entity/User;", "GetGetCurrentUserHandler")]
			get {
				if (id_getCurrentUser == IntPtr.Zero)
					id_getCurrentUser = JNIEnv.GetMethodID (class_ref, "getCurrentUser", "()Lcom/coinbase/api/entity/User;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.User> (JNIEnv.CallObjectMethod  (Handle, id_getCurrentUser), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.User> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCurrentUser", "()Lcom/coinbase/api/entity/User;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='TransactionsResponse']/method[@name='setCurrentUser' and count(parameter)=1 and parameter[1][@type='com.coinbase.api.entity.User']]"
			[Register ("setCurrentUser", "(Lcom/coinbase/api/entity/User;)V", "GetSetCurrentUser_Lcom_coinbase_api_entity_User_Handler")]
			set {
				if (id_setCurrentUser_Lcom_coinbase_api_entity_User_ == IntPtr.Zero)
					id_setCurrentUser_Lcom_coinbase_api_entity_User_ = JNIEnv.GetMethodID (class_ref, "setCurrentUser", "(Lcom/coinbase/api/entity/User;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setCurrentUser_Lcom_coinbase_api_entity_User_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCurrentUser", "(Lcom/coinbase/api/entity/User;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTransactions;
#pragma warning disable 0169
		static Delegate GetGetTransactionsHandler ()
		{
			if (cb_getTransactions == null)
				cb_getTransactions = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTransactions);
			return cb_getTransactions;
		}

		static IntPtr n_GetTransactions (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.TransactionsResponse __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.TransactionsResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Coinbase.Api.Entity.Transaction>.ToLocalJniHandle (__this.Transactions);
		}
#pragma warning restore 0169

		static Delegate cb_setTransactions_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetTransactions_Ljava_util_List_Handler ()
		{
			if (cb_setTransactions_Ljava_util_List_ == null)
				cb_setTransactions_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTransactions_Ljava_util_List_);
			return cb_setTransactions_Ljava_util_List_;
		}

		static void n_SetTransactions_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.TransactionsResponse __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.TransactionsResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Coinbase.Api.Entity.Transaction>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Transactions = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTransactions;
		static IntPtr id_setTransactions_Ljava_util_List_;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Coinbase.Api.Entity.Transaction> Transactions {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='TransactionsResponse']/method[@name='getTransactions' and count(parameter)=0]"
			[Register ("getTransactions", "()Ljava/util/List;", "GetGetTransactionsHandler")]
			get {
				if (id_getTransactions == IntPtr.Zero)
					id_getTransactions = JNIEnv.GetMethodID (class_ref, "getTransactions", "()Ljava/util/List;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Coinbase.Api.Entity.Transaction>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getTransactions), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Coinbase.Api.Entity.Transaction>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTransactions", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='TransactionsResponse']/method[@name='setTransactions' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.coinbase.api.entity.Transaction&gt;']]"
			[Register ("setTransactions", "(Ljava/util/List;)V", "GetSetTransactions_Ljava_util_List_Handler")]
			set {
				if (id_setTransactions_Ljava_util_List_ == IntPtr.Zero)
					id_setTransactions_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setTransactions", "(Ljava/util/List;)V");
				IntPtr native_value = global::Android.Runtime.JavaList<global::Com.Coinbase.Api.Entity.Transaction>.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setTransactions_Ljava_util_List_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTransactions", "(Ljava/util/List;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

	}
}
