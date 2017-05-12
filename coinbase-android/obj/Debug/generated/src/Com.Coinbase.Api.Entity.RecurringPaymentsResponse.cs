using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Coinbase.Api.Entity {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='RecurringPaymentsResponse']"
	[global::Android.Runtime.Register ("com/coinbase/api/entity/RecurringPaymentsResponse", DoNotGenerateAcw=true)]
	public partial class RecurringPaymentsResponse : global::Com.Coinbase.Api.Entity.Response {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/coinbase/api/entity/RecurringPaymentsResponse", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RecurringPaymentsResponse); }
		}

		protected RecurringPaymentsResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='RecurringPaymentsResponse']/constructor[@name='RecurringPaymentsResponse' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe RecurringPaymentsResponse ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (RecurringPaymentsResponse)) {
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

		static Delegate cb_getRecurringPayments;
#pragma warning disable 0169
		static Delegate GetGetRecurringPaymentsHandler ()
		{
			if (cb_getRecurringPayments == null)
				cb_getRecurringPayments = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRecurringPayments);
			return cb_getRecurringPayments;
		}

		static IntPtr n_GetRecurringPayments (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.RecurringPaymentsResponse __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.RecurringPaymentsResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Coinbase.Api.Entity.RecurringPayment>.ToLocalJniHandle (__this.RecurringPayments);
		}
#pragma warning restore 0169

		static Delegate cb_setRecurringPayments_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetRecurringPayments_Ljava_util_List_Handler ()
		{
			if (cb_setRecurringPayments_Ljava_util_List_ == null)
				cb_setRecurringPayments_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRecurringPayments_Ljava_util_List_);
			return cb_setRecurringPayments_Ljava_util_List_;
		}

		static void n_SetRecurringPayments_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.RecurringPaymentsResponse __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.RecurringPaymentsResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Coinbase.Api.Entity.RecurringPayment>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RecurringPayments = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getRecurringPayments;
		static IntPtr id_setRecurringPayments_Ljava_util_List_;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Coinbase.Api.Entity.RecurringPayment> RecurringPayments {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='RecurringPaymentsResponse']/method[@name='getRecurringPayments' and count(parameter)=0]"
			[Register ("getRecurringPayments", "()Ljava/util/List;", "GetGetRecurringPaymentsHandler")]
			get {
				if (id_getRecurringPayments == IntPtr.Zero)
					id_getRecurringPayments = JNIEnv.GetMethodID (class_ref, "getRecurringPayments", "()Ljava/util/List;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Coinbase.Api.Entity.RecurringPayment>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getRecurringPayments), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Coinbase.Api.Entity.RecurringPayment>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRecurringPayments", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='RecurringPaymentsResponse']/method[@name='setRecurringPayments' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.coinbase.api.entity.RecurringPayment&gt;']]"
			[Register ("setRecurringPayments", "(Ljava/util/List;)V", "GetSetRecurringPayments_Ljava_util_List_Handler")]
			set {
				if (id_setRecurringPayments_Ljava_util_List_ == IntPtr.Zero)
					id_setRecurringPayments_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setRecurringPayments", "(Ljava/util/List;)V");
				IntPtr native_value = global::Android.Runtime.JavaList<global::Com.Coinbase.Api.Entity.RecurringPayment>.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setRecurringPayments_Ljava_util_List_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRecurringPayments", "(Ljava/util/List;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

	}
}
