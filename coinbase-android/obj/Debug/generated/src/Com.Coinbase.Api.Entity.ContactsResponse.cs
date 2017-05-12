using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Coinbase.Api.Entity {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='ContactsResponse']"
	[global::Android.Runtime.Register ("com/coinbase/api/entity/ContactsResponse", DoNotGenerateAcw=true)]
	public partial class ContactsResponse : global::Com.Coinbase.Api.Entity.Response {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/coinbase/api/entity/ContactsResponse", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ContactsResponse); }
		}

		protected ContactsResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='ContactsResponse']/constructor[@name='ContactsResponse' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ContactsResponse ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ContactsResponse)) {
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

		static Delegate cb_getContacts;
#pragma warning disable 0169
		static Delegate GetGetContactsHandler ()
		{
			if (cb_getContacts == null)
				cb_getContacts = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContacts);
			return cb_getContacts;
		}

		static IntPtr n_GetContacts (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.ContactsResponse __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.ContactsResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Coinbase.Api.Entity.Contact>.ToLocalJniHandle (__this.Contacts);
		}
#pragma warning restore 0169

		static Delegate cb_setContacts_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetContacts_Ljava_util_List_Handler ()
		{
			if (cb_setContacts_Ljava_util_List_ == null)
				cb_setContacts_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetContacts_Ljava_util_List_);
			return cb_setContacts_Ljava_util_List_;
		}

		static void n_SetContacts_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.ContactsResponse __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.ContactsResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Coinbase.Api.Entity.Contact>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Contacts = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getContacts;
		static IntPtr id_setContacts_Ljava_util_List_;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Coinbase.Api.Entity.Contact> Contacts {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='ContactsResponse']/method[@name='getContacts' and count(parameter)=0]"
			[Register ("getContacts", "()Ljava/util/List;", "GetGetContactsHandler")]
			get {
				if (id_getContacts == IntPtr.Zero)
					id_getContacts = JNIEnv.GetMethodID (class_ref, "getContacts", "()Ljava/util/List;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Coinbase.Api.Entity.Contact>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getContacts), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Coinbase.Api.Entity.Contact>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getContacts", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='ContactsResponse']/method[@name='setContacts' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.coinbase.api.entity.Contact&gt;']]"
			[Register ("setContacts", "(Ljava/util/List;)V", "GetSetContacts_Ljava_util_List_Handler")]
			set {
				if (id_setContacts_Ljava_util_List_ == IntPtr.Zero)
					id_setContacts_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setContacts", "(Ljava/util/List;)V");
				IntPtr native_value = global::Android.Runtime.JavaList<global::Com.Coinbase.Api.Entity.Contact>.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setContacts_Ljava_util_List_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setContacts", "(Ljava/util/List;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

	}
}
