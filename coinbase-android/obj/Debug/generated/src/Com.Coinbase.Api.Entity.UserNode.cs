using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Coinbase.Api.Entity {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='UserNode']"
	[global::Android.Runtime.Register ("com/coinbase/api/entity/UserNode", DoNotGenerateAcw=true)]
	public partial class UserNode : global::Java.Lang.Object, global::Java.IO.ISerializable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/coinbase/api/entity/UserNode", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UserNode); }
		}

		protected UserNode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='UserNode']/constructor[@name='UserNode' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe UserNode ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (UserNode)) {
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

		static Delegate cb_getUser;
#pragma warning disable 0169
		static Delegate GetGetUserHandler ()
		{
			if (cb_getUser == null)
				cb_getUser = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUser);
			return cb_getUser;
		}

		static IntPtr n_GetUser (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.UserNode __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.UserNode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.User);
		}
#pragma warning restore 0169

		static Delegate cb_setUser_Lcom_coinbase_api_entity_User_;
#pragma warning disable 0169
		static Delegate GetSetUser_Lcom_coinbase_api_entity_User_Handler ()
		{
			if (cb_setUser_Lcom_coinbase_api_entity_User_ == null)
				cb_setUser_Lcom_coinbase_api_entity_User_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetUser_Lcom_coinbase_api_entity_User_);
			return cb_setUser_Lcom_coinbase_api_entity_User_;
		}

		static void n_SetUser_Lcom_coinbase_api_entity_User_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.UserNode __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.UserNode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Coinbase.Api.Entity.User p0 = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.User> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.User = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getUser;
		static IntPtr id_setUser_Lcom_coinbase_api_entity_User_;
		public virtual unsafe global::Com.Coinbase.Api.Entity.User User {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='UserNode']/method[@name='getUser' and count(parameter)=0]"
			[Register ("getUser", "()Lcom/coinbase/api/entity/User;", "GetGetUserHandler")]
			get {
				if (id_getUser == IntPtr.Zero)
					id_getUser = JNIEnv.GetMethodID (class_ref, "getUser", "()Lcom/coinbase/api/entity/User;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.User> (JNIEnv.CallObjectMethod  (Handle, id_getUser), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.User> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUser", "()Lcom/coinbase/api/entity/User;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='UserNode']/method[@name='setUser' and count(parameter)=1 and parameter[1][@type='com.coinbase.api.entity.User']]"
			[Register ("setUser", "(Lcom/coinbase/api/entity/User;)V", "GetSetUser_Lcom_coinbase_api_entity_User_Handler")]
			set {
				if (id_setUser_Lcom_coinbase_api_entity_User_ == IntPtr.Zero)
					id_setUser_Lcom_coinbase_api_entity_User_ = JNIEnv.GetMethodID (class_ref, "setUser", "(Lcom/coinbase/api/entity/User;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setUser_Lcom_coinbase_api_entity_User_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUser", "(Lcom/coinbase/api/entity/User;)V"), __args);
				} finally {
				}
			}
		}

	}
}
