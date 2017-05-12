using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Coinbase.Api.Entity {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='ContactNode']"
	[global::Android.Runtime.Register ("com/coinbase/api/entity/ContactNode", DoNotGenerateAcw=true)]
	public partial class ContactNode : global::Java.Lang.Object, global::Java.IO.ISerializable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/coinbase/api/entity/ContactNode", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ContactNode); }
		}

		protected ContactNode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='ContactNode']/constructor[@name='ContactNode' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ContactNode ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ContactNode)) {
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

		static Delegate cb_getContact;
#pragma warning disable 0169
		static Delegate GetGetContactHandler ()
		{
			if (cb_getContact == null)
				cb_getContact = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContact);
			return cb_getContact;
		}

		static IntPtr n_GetContact (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.ContactNode __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.ContactNode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Contact);
		}
#pragma warning restore 0169

		static Delegate cb_setContact_Lcom_coinbase_api_entity_Contact_;
#pragma warning disable 0169
		static Delegate GetSetContact_Lcom_coinbase_api_entity_Contact_Handler ()
		{
			if (cb_setContact_Lcom_coinbase_api_entity_Contact_ == null)
				cb_setContact_Lcom_coinbase_api_entity_Contact_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetContact_Lcom_coinbase_api_entity_Contact_);
			return cb_setContact_Lcom_coinbase_api_entity_Contact_;
		}

		static void n_SetContact_Lcom_coinbase_api_entity_Contact_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.ContactNode __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.ContactNode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Coinbase.Api.Entity.Contact p0 = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Contact> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Contact = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getContact;
		static IntPtr id_setContact_Lcom_coinbase_api_entity_Contact_;
		public virtual unsafe global::Com.Coinbase.Api.Entity.Contact Contact {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='ContactNode']/method[@name='getContact' and count(parameter)=0]"
			[Register ("getContact", "()Lcom/coinbase/api/entity/Contact;", "GetGetContactHandler")]
			get {
				if (id_getContact == IntPtr.Zero)
					id_getContact = JNIEnv.GetMethodID (class_ref, "getContact", "()Lcom/coinbase/api/entity/Contact;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Contact> (JNIEnv.CallObjectMethod  (Handle, id_getContact), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Contact> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getContact", "()Lcom/coinbase/api/entity/Contact;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='ContactNode']/method[@name='setContact' and count(parameter)=1 and parameter[1][@type='com.coinbase.api.entity.Contact']]"
			[Register ("setContact", "(Lcom/coinbase/api/entity/Contact;)V", "GetSetContact_Lcom_coinbase_api_entity_Contact_Handler")]
			set {
				if (id_setContact_Lcom_coinbase_api_entity_Contact_ == IntPtr.Zero)
					id_setContact_Lcom_coinbase_api_entity_Contact_ = JNIEnv.GetMethodID (class_ref, "setContact", "(Lcom/coinbase/api/entity/Contact;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setContact_Lcom_coinbase_api_entity_Contact_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setContact", "(Lcom/coinbase/api/entity/Contact;)V"), __args);
				} finally {
				}
			}
		}

	}
}
